Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports Microsoft.Data.Sqlite

Friend Module KioskDatabase
    Private ReadOnly DbPath As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "PhantomKiosk", "phantom-kiosk.db")
    Private ReadOnly SetupLock As New Object()
    Private Initialized As Boolean

    Friend NotInheritable Class ProductRecord
        Public Property Id As Long
        Public Property Name As String
        Public Property Category As String
        Public Property Description As String
        Public Property Price As Decimal
        Public Property Stock As Integer
        Public Property Photo As Byte()
    End Class

    Friend NotInheritable Class OrderLine
        Public Property ProductId As Long
        Public Property ProductName As String
        Public Property UnitPrice As Decimal
        Public Property Quantity As Integer
    End Class

    Friend NotInheritable Class OrderRecord
        Public Property Id As Long
        Public Property PlacedAt As Date
        Public Property CompletedAt As Date?
        Public Property Status As String
        Public Property Total As Decimal
        Public ReadOnly Property Items As New List(Of OrderLine)()
        Public ReadOnly Property OrderNumber As String
            Get
                Return $"ORD-{Id:0000}"
            End Get
        End Property
    End Class

    Friend NotInheritable Class OrderUnavailableException
        Inherits InvalidOperationException

        Public Sub New(message As String)
            MyBase.New(message)
        End Sub
    End Class

    Private Function OpenDatabase() As SqliteConnection
        SyncLock SetupLock
            Dim connection As New SqliteConnection(
                New SqliteConnectionStringBuilder With {
                    .DataSource = DbPath,
                    .ForeignKeys = True
                }.ToString())

            Try
                Directory.CreateDirectory(Path.GetDirectoryName(DbPath))
                connection.Open()
                If Not Initialized Then
                    InitializeDatabase(connection)
                    Initialized = True
                End If
                Return connection
            Catch
                connection.Dispose()
                Throw
            End Try
        End SyncLock
    End Function

    Private Sub InitializeDatabase(connection As SqliteConnection)
        Using transaction = connection.BeginTransaction()
            Dim schemaVersion As Integer
            Using command = CreateCommand(connection, transaction, "PRAGMA user_version")
                schemaVersion = Convert.ToInt32(command.ExecuteScalar())
            End Using

            If schemaVersion = 1 Then
                Using command = CreateCommand(connection, transaction,
                    "UPDATE Products SET Category = 'Meals' WHERE Category = 'Favorites';
                     PRAGMA user_version = 2;")
                    command.ExecuteNonQuery()
                End Using
            End If

            If schemaVersion <> 0 Then
                transaction.Commit()
                Return
            End If

            Using command = CreateCommand(connection, transaction,
                "CREATE TABLE Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL CHECK (length(trim(Name)) > 0),
                    Category TEXT NOT NULL CHECK (Category IN ('Meals','Drinks','Desserts')),
                    Description TEXT NOT NULL DEFAULT '',
                    PriceCents INTEGER NOT NULL CHECK (PriceCents >= 0),
                    Stock INTEGER NOT NULL CHECK (Stock >= 0),
                    Photo BLOB,
                    Active INTEGER NOT NULL DEFAULT 1 CHECK (Active IN (0,1))
                );
                CREATE TABLE Orders (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PlacedAt TEXT NOT NULL,
                    CompletedAt TEXT,
                    Status TEXT NOT NULL DEFAULT 'New' CHECK (Status IN ('New','Preparing','Ready','Completed')),
                    SubtotalCents INTEGER NOT NULL CHECK (SubtotalCents >= 0),
                    TaxCents INTEGER NOT NULL CHECK (TaxCents >= 0)
                );
                CREATE TABLE OrderItems (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrderId INTEGER NOT NULL REFERENCES Orders(Id),
                    ProductId INTEGER NOT NULL REFERENCES Products(Id),
                    ProductName TEXT NOT NULL,
                    UnitPriceCents INTEGER NOT NULL CHECK (UnitPriceCents >= 0),
                    Quantity INTEGER NOT NULL CHECK (Quantity > 0)
                );
                CREATE INDEX IX_OrderItems_OrderId ON OrderItems(OrderId);

                INSERT INTO Products (Name, Category, Description, PriceCents, Stock) VALUES
                    ('Big Mac Meal', 'Meals', 'Signature Burger', 19900, 50),
                    ('2-pc Chicken Joy', 'Meals', 'Crispy & Juicy', 14900, 45),
                    ('Large Fries', 'Meals', 'Golden & Salted', 7500, 120),
                    ('Coca-Cola Float', 'Drinks', 'Icy Refreshment', 5500, 60),
                    ('Cheeseburger', 'Meals', 'Classic Cheese', 8900, 50),
                    ('Bacon Burger', 'Meals', 'Smoky Bacon', 13900, 50),
                    ('Lemon Iced Tea', 'Drinks', 'Fresh Brew', 6900, 60),
                    ('Mango Shake', 'Drinks', 'Real Fruit', 8900, 60),
                    ('Sundae Cone', 'Desserts', 'Vanilla Soft Serve', 3500, 90),
                    ('Apple Pie', 'Desserts', 'Crisp & Warm', 5000, 90);

                PRAGMA user_version = 2;")
                command.ExecuteNonQuery()
            End Using
            transaction.Commit()
        End Using
    End Sub

    Friend Function GetProducts(Optional category As String = Nothing) As List(Of ProductRecord)
        Dim products As New List(Of ProductRecord)()

        Using connection = OpenDatabase(),
              command = connection.CreateCommand()
            command.CommandText =
                "SELECT Id, Name, Category, Description, PriceCents, Stock, Photo
                 FROM Products
                 WHERE Active = 1 AND ($category IS NULL OR Category = $category)
                 ORDER BY Id"
            command.Parameters.AddWithValue("$category", If(CType(category, Object), DBNull.Value))
            Using reader = command.ExecuteReader()
                While reader.Read()
                    products.Add(New ProductRecord With {
                        .Id = reader.GetInt64(0),
                        .Name = reader.GetString(1),
                        .Category = reader.GetString(2),
                        .Description = reader.GetString(3),
                        .Price = reader.GetInt64(4) / 100D,
                        .Stock = reader.GetInt32(5),
                        .Photo = If(reader.IsDBNull(6), Nothing, DirectCast(reader.GetValue(6), Byte()))
                    })
                End While
            End Using
        End Using
        Return products
    End Function

    Friend Sub SaveProduct(product As ProductRecord, previousStock As Integer)
        Using connection = OpenDatabase(),
              command = connection.CreateCommand()
            If product.Id = 0 Then
                command.CommandText =
                    "INSERT INTO Products (Name, Category, PriceCents, Stock, Photo)
                     VALUES ($name, $category, $price, $stock, $photo)"
            Else
                command.CommandText =
                    "UPDATE Products SET Name = $name, Category = $category, PriceCents = $price,
                                         Stock = $stock, Photo = $photo
                     WHERE Id = $id AND Active = 1 AND Stock = $previousStock"
                command.Parameters.AddWithValue("$id", product.Id)
                command.Parameters.AddWithValue("$previousStock", previousStock)
            End If

            command.Parameters.AddWithValue("$name", product.Name)
            command.Parameters.AddWithValue("$category", product.Category)
            command.Parameters.AddWithValue("$price", ToCents(product.Price))
            command.Parameters.AddWithValue("$stock", product.Stock)
            command.Parameters.Add("$photo", SqliteType.Blob).Value = If(CType(product.Photo, Object), DBNull.Value)
            If command.ExecuteNonQuery() = 0 Then
                Throw New InvalidOperationException("This product or its stock changed. Reopen Inventory and try again.")
            End If
        End Using
    End Sub

    Friend Sub RemoveProduct(productId As Long)
        Using connection = OpenDatabase(),
              command = connection.CreateCommand()
            command.CommandText = "UPDATE Products SET Active = 0 WHERE Id = $id"
            command.Parameters.AddWithValue("$id", productId)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Friend Function CalculateTax(subtotal As Decimal) As Decimal
        Return Math.Round(subtotal * 0.12D, 2, MidpointRounding.AwayFromZero)
    End Function

    Friend Function PlaceOrder(items As List(Of OrderLine)) As String
        If items.Count = 0 Then Throw New ArgumentException("The cart is empty.")

        Using connection = OpenDatabase(),
              transaction = connection.BeginTransaction()
            Dim subtotalCents As Long = 0
            Dim savedNames As New List(Of String)()

            For Each item In items
                If item.Quantity <= 0 Then Throw New ArgumentException("Order quantity must be positive.")
                Dim priceCents = ToCents(item.UnitPrice)

                Using command = CreateCommand(connection, transaction,
                    "UPDATE Products SET Stock = Stock - $qty
                     WHERE Id = $id AND Active = 1 AND Stock >= $qty AND PriceCents = $price")
                    command.Parameters.AddWithValue("$qty", item.Quantity)
                    command.Parameters.AddWithValue("$id", item.ProductId)
                    command.Parameters.AddWithValue("$price", priceCents)
                    If command.ExecuteNonQuery() <> 1 Then
                        Throw New OrderUnavailableException(
                            $"{item.ProductName} changed price or is unavailable in that quantity. Remove it and select it again.")
                    End If
                End Using

                Using command = CreateCommand(connection, transaction, "SELECT Name FROM Products WHERE Id = $id")
                    command.Parameters.AddWithValue("$id", item.ProductId)
                    savedNames.Add(CStr(command.ExecuteScalar()))
                End Using
                subtotalCents += priceCents * item.Quantity
            Next

            Dim orderId As Long
            Using command = CreateCommand(connection, transaction,
                "INSERT INTO Orders (PlacedAt, SubtotalCents, TaxCents)
                 VALUES ($placedAt, $subtotal, $tax)")
                command.Parameters.AddWithValue("$placedAt", UtcTimestamp())
                command.Parameters.AddWithValue("$subtotal", subtotalCents)
                command.Parameters.AddWithValue("$tax", ToCents(CalculateTax(subtotalCents / 100D)))
                command.ExecuteNonQuery()
                command.CommandText = "SELECT last_insert_rowid()"
                command.Parameters.Clear()
                orderId = Convert.ToInt64(command.ExecuteScalar())
            End Using

            For index As Integer = 0 To items.Count - 1
                Dim item = items(index)
                Using command = CreateCommand(connection, transaction,
                    "INSERT INTO OrderItems (OrderId, ProductId, ProductName, UnitPriceCents, Quantity)
                     VALUES ($orderId, $productId, $name, $price, $qty)")
                    command.Parameters.AddWithValue("$orderId", orderId)
                    command.Parameters.AddWithValue("$productId", item.ProductId)
                    command.Parameters.AddWithValue("$name", savedNames(index))
                    command.Parameters.AddWithValue("$price", ToCents(item.UnitPrice))
                    command.Parameters.AddWithValue("$qty", item.Quantity)
                    command.ExecuteNonQuery()
                End Using
            Next

            transaction.Commit()
            Return $"ORD-{orderId:0000}"
        End Using
    End Function

    Friend Function GetOrders(Optional completedOnly As Boolean = False) As List(Of OrderRecord)
        Dim orders As New List(Of OrderRecord)()
        Dim order As OrderRecord = Nothing

        Using connection = OpenDatabase(),
              command = connection.CreateCommand()
            command.CommandText =
                "SELECT o.Id, o.PlacedAt, o.Status, o.SubtotalCents + o.TaxCents, o.CompletedAt,
                        i.ProductId, i.ProductName, i.UnitPriceCents, i.Quantity
                 FROM Orders o INNER JOIN OrderItems i ON o.Id = i.OrderId
                 WHERE $completedOnly = 0 OR o.Status = 'Completed'
                 ORDER BY o.Id DESC, i.Id"
            command.Parameters.AddWithValue("$completedOnly", If(completedOnly, 1, 0))

            Using reader = command.ExecuteReader()
                While reader.Read()
                    If order Is Nothing OrElse order.Id <> reader.GetInt64(0) Then
                        order = New OrderRecord With {
                            .Id = reader.GetInt64(0),
                            .PlacedAt = ParseTimestamp(reader.GetString(1)),
                            .Status = reader.GetString(2),
                            .Total = reader.GetInt64(3) / 100D
                        }
                        If Not reader.IsDBNull(4) Then order.CompletedAt = ParseTimestamp(reader.GetString(4))
                        orders.Add(order)
                    End If
                    order.Items.Add(New OrderLine With {
                        .ProductId = reader.GetInt64(5),
                        .ProductName = reader.GetString(6),
                        .UnitPrice = reader.GetInt64(7) / 100D,
                        .Quantity = reader.GetInt32(8)
                    })
                End While
            End Using
        End Using
        Return orders
    End Function

    Friend Function UpdateOrderStatus(orderId As Long, currentStatus As String, nextStatus As String) As Boolean
        Using connection = OpenDatabase(),
              command = connection.CreateCommand()
            command.CommandText =
                "UPDATE Orders SET Status = $next,
                       CompletedAt = CASE WHEN $next = 'Completed' THEN $now ELSE CompletedAt END
                 WHERE Id = $id AND Status = $current
                   AND (($current = 'New' AND $next = 'Preparing')
                     OR ($current = 'Preparing' AND $next = 'Ready')
                     OR ($current = 'Ready' AND $next = 'Completed'))"
            command.Parameters.AddWithValue("$id", orderId)
            command.Parameters.AddWithValue("$current", currentStatus)
            command.Parameters.AddWithValue("$next", nextStatus)
            command.Parameters.AddWithValue("$now", UtcTimestamp())
            Return command.ExecuteNonQuery() = 1
        End Using
    End Function

    Private Function CreateCommand(connection As SqliteConnection, transaction As SqliteTransaction, sql As String) As SqliteCommand
        Dim command = connection.CreateCommand()
        command.Transaction = transaction
        command.CommandText = sql
        Return command
    End Function

    Private Function ToCents(amount As Decimal) As Long
        Return Decimal.ToInt64(Math.Round(amount * 100D, 0, MidpointRounding.AwayFromZero))
    End Function

    Private Function UtcTimestamp() As String
        Return Date.UtcNow.ToString("O", CultureInfo.InvariantCulture)
    End Function

    Private Function ParseTimestamp(value As String) As Date
        Return Date.ParseExact(value, "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind).ToLocalTime()
    End Function

    Friend Sub ShowDatabaseError(owner As System.Windows.Forms.Form, action As String, ex As Exception)
        System.Windows.Forms.MessageBox.Show(owner, action & Environment.NewLine & ex.Message,
            "Phantom Kiosk", System.Windows.Forms.MessageBoxButtons.OK,
            System.Windows.Forms.MessageBoxIcon.Warning)
    End Sub
End Module
