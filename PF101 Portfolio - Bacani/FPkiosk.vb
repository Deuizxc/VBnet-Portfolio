Imports System.Collections.Generic
Imports System.IO
Imports System.Linq

Public Class FPkiosk

    Private Class CartItem
        Public Property ProductId As Long
        Public Property Stock As Integer
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
    End Class

    Private currentCategory As String = "Meals"
    Private cartList As New List(Of CartItem)()

    Private Sub FPkiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        LoadMenu(currentCategory)
    End Sub

    Private Sub LoadMenu(category As String)
        currentCategory = category
        Do While flpMenuGrid.Controls.Count > 0
            flpMenuGrid.Controls(0).Dispose()
        Loop

        Dim items As List(Of KioskDatabase.ProductRecord)
        Try
            items = KioskDatabase.GetProducts(category)
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The menu could not be loaded.", ex)
            Return
        End Try

        If items.Count = 0 Then
            flpMenuGrid.Controls.Add(New Label With {
                .Text = "No products in this category.", .AutoSize = True, .ForeColor = Color.White
            })
        End If

        For Each item In items
            Dim card As New Panel()
            card.Width = 160
            card.Height = 208
            card.BackColor = Color.FromArgb(20, 20, 20)
            card.Cursor = Cursors.Hand

            Dim photo As New PictureBox With {
                .Location = New Point(8, 8),
                .Size = New Size(144, 104),
                .BackColor = Color.FromArgb(32, 32, 32),
                .SizeMode = PictureBoxSizeMode.Zoom
            }
            Dim thumbnail As Image = LoadMenuPhoto(item.Photo)
            photo.Image = thumbnail
            If thumbnail IsNot Nothing Then
                AddHandler photo.Disposed, Sub(sender, args) thumbnail.Dispose()
            End If

            Dim lblName As New Label()
            lblName.Text = item.Name
            lblName.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            lblName.ForeColor = Color.White
            lblName.AutoSize = False
            lblName.Width = 145
            lblName.Height = 30
            lblName.Location = New Point(8, 119)

            Dim lblSub As New Label()
            lblSub.Text = item.Description
            lblSub.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular)
            lblSub.ForeColor = Color.DarkGray
            lblSub.AutoSize = False
            lblSub.Width = 145
            lblSub.Height = 16
            lblSub.Location = New Point(8, 151)

            Dim lblStock As New Label With {
                .Text = If(item.Stock > 0, $"Stock: {item.Stock}", "Stock: 0 (Sold out)"),
                .Font = New Font("Segoe UI", 8.0F, FontStyle.Bold),
                .ForeColor = If(item.Stock > 0, Color.Gainsboro, Color.LightSalmon),
                .AutoSize = False,
                .Location = New Point(8, 168),
                .Size = New Size(145, 17)
            }

            Dim lblPrice As New Label()
            lblPrice.Text = $"₱{item.Price:N2}"
            lblPrice.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            lblPrice.ForeColor = Color.LightGreen
            lblPrice.AutoSize = False
            lblPrice.Width = 145
            lblPrice.Height = 21
            lblPrice.Location = New Point(8, 185)

            card.Controls.Add(photo)
            card.Controls.Add(lblName)
            card.Controls.Add(lblSub)
            card.Controls.Add(lblStock)
            card.Controls.Add(lblPrice)

            If item.Stock > 0 Then
                Dim product = item
                AddHandler card.Click, Sub(sender, args) AddToCart(product)
                AddHandler photo.Click, Sub(sender, args) AddToCart(product)
                AddHandler lblName.Click, Sub(sender, args) AddToCart(product)
                AddHandler lblSub.Click, Sub(sender, args) AddToCart(product)
                AddHandler lblStock.Click, Sub(sender, args) AddToCart(product)
                AddHandler lblPrice.Click, Sub(sender, args) AddToCart(product)
            Else
                card.Cursor = Cursors.Default
                lblPrice.ForeColor = Color.DarkGray
            End If

            flpMenuGrid.Controls.Add(card)
        Next


        Dim gridWidth As Integer = 3 * (160 + 6)
        Dim availableWidth As Integer = flpMenuGrid.Width

        If items.Count > 3 Then
            availableWidth -= SystemInformation.VerticalScrollBarWidth
        End If

        Dim leftPadding As Integer = Math.Max(0, (availableWidth - gridWidth) \ 2)
        flpMenuGrid.Padding = New Padding(leftPadding, 0, 0, 0)
    End Sub

    Private Function LoadMenuPhoto(data As Byte()) As Image
        If data Is Nothing OrElse data.Length = 0 Then Return Nothing

        Try
            Using stream As New MemoryStream(data),
                  original As Image = Image.FromStream(stream)
                Dim scale As Double = Math.Min(1.0, Math.Min(288.0 / original.Width, 208.0 / original.Height))
                Dim width As Integer = Math.Max(1, CInt(Math.Round(original.Width * scale)))
                Dim height As Integer = Math.Max(1, CInt(Math.Round(original.Height * scale)))
                Return New Bitmap(original, width, height)
            End Using
        Catch ex As ArgumentException
            Return Nothing
        Catch ex As OutOfMemoryException
            ' GDI+ can report invalid or unsupported image data with this exception.
            Return Nothing
        End Try
    End Function

    Private Sub AddToCart(product As KioskDatabase.ProductRecord)
        Dim existing = cartList.FirstOrDefault(Function(item) item.ProductId = product.Id)
        If existing Is Nothing Then
            cartList.Add(New CartItem With {
                .ProductId = product.Id, .Name = product.Name, .Price = product.Price,
                .Stock = product.Stock, .Quantity = 1
            })
        ElseIf existing.Quantity < product.Stock Then
            existing.Stock = product.Stock
            existing.Quantity += 1
        Else
            MessageBox.Show(Me, "There is no additional stock for this item.")
        End If
        RefreshCartDisplay()
    End Sub

    Private Sub RefreshCartDisplay()
        Do While flpCartItems.Controls.Count > 0
            flpCartItems.Controls(0).Dispose()
        Loop
        Dim subtotal As Decimal = 0D

        For Each item In cartList
            subtotal += (item.Price * item.Quantity)

            Dim rowPanel As New Panel()
            rowPanel.Width = 285
            rowPanel.Height = 45
            rowPanel.BackColor = Color.FromArgb(40, 40, 40)

            Dim lblItemName As New Label()
            lblItemName.Text = $"{item.Name} (₱{item.Price})"
            lblItemName.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
            lblItemName.ForeColor = Color.White
            lblItemName.AutoSize = False
            lblItemName.Width = 160
            lblItemName.Height = 35
            lblItemName.Location = New Point(5, 5)

            Dim currentItem = item
            Dim btnMinus As New Button()
            btnMinus.Text = "-"
            btnMinus.Width = 25
            btnMinus.Height = 25
            btnMinus.Location = New Point(170, 10)
            btnMinus.BackColor = Color.FromArgb(20, 20, 20)
            btnMinus.ForeColor = Color.White
            btnMinus.FlatStyle = FlatStyle.Flat
            AddHandler btnMinus.Click, Sub(s, ev)
                                           currentItem.Quantity -= 1
                                           If currentItem.Quantity <= 0 Then
                                               cartList.Remove(currentItem)
                                           End If
                                           RefreshCartDisplay()
                                       End Sub

            Dim lblQty As New Label()
            lblQty.Text = currentItem.Quantity.ToString()
            lblQty.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblQty.ForeColor = Color.White
            lblQty.TextAlign = ContentAlignment.MiddleCenter
            lblQty.Width = 25
            lblQty.Height = 25
            lblQty.Location = New Point(198, 10)

            Dim btnPlus As New Button()
            btnPlus.Text = "+"
            btnPlus.Enabled = item.Quantity < item.Stock
            btnPlus.Width = 25
            btnPlus.Height = 25
            btnPlus.Location = New Point(226, 10)
            btnPlus.BackColor = Color.FromArgb(20, 20, 20)
            btnPlus.ForeColor = Color.White
            btnPlus.FlatStyle = FlatStyle.Flat
            AddHandler btnPlus.Click, Sub(s, ev)
                                          currentItem.Quantity += 1
                                          RefreshCartDisplay()
                                      End Sub

            Dim btnRemove As New Button()
            btnRemove.Text = "✕"
            btnRemove.Width = 25
            btnRemove.Height = 25
            btnRemove.Location = New Point(255, 10)
            btnRemove.BackColor = Color.FromArgb(190, 20, 20)
            btnRemove.ForeColor = Color.White
            btnRemove.FlatStyle = FlatStyle.Flat
            AddHandler btnRemove.Click, Sub(s, ev)
                                            cartList.Remove(currentItem)
                                            RefreshCartDisplay()
                                        End Sub

            rowPanel.Controls.Add(lblItemName)
            rowPanel.Controls.Add(btnMinus)
            rowPanel.Controls.Add(lblQty)
            rowPanel.Controls.Add(btnPlus)
            rowPanel.Controls.Add(btnRemove)

            flpCartItems.Controls.Add(rowPanel)
        Next

        Dim tax As Decimal = KioskDatabase.CalculateTax(subtotal)
        Dim grandTotal As Decimal = subtotal + tax

        lblTaxValue.Text = $"₱{tax:N2}"
        lblTotalValue.Text = $"₱{grandTotal:N2}"
    End Sub

    Private Sub btnCatBurgers_Click(sender As Object, e As EventArgs) Handles btnCatBurgers.Click
        LoadMenu("Meals")
    End Sub

    Private Sub btnCatDrinks_Click(sender As Object, e As EventArgs) Handles btnCatDrinks.Click
        LoadMenu("Drinks")
    End Sub

    Private Sub btnCatDesserts_Click(sender As Object, e As EventArgs) Handles btnCatDesserts.Click
        LoadMenu("Desserts")
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If cartList.Count = 0 Then
            MessageBox.Show(Me, "Your cart is empty. Please select items first.")
            Return
        End If

        Dim orderItems As New List(Of KioskDatabase.OrderLine)()
        For Each item In cartList
            orderItems.Add(New KioskDatabase.OrderLine With {
                .ProductId = item.ProductId, .ProductName = item.Name,
                .UnitPrice = item.Price, .Quantity = item.Quantity
            })
        Next

        Dim paymentMethod As String
        Dim diningOption As String
        Using review As New FPcheckout()
            review.SetOrder(orderItems)
            If review.ShowDialog(Me) <> DialogResult.OK Then Return
            paymentMethod = review.PaymentMethod
            diningOption = review.DiningOption
        End Using

        Dim total As Decimal = orderItems.Sum(Function(item) item.UnitPrice * item.Quantity)
        total += KioskDatabase.CalculateTax(total)

        Dim orderNumber As String
        Try
            orderNumber = KioskDatabase.PlaceOrder(orderItems, paymentMethod, diningOption)
        Catch ex As KioskDatabase.OrderUnavailableException
            KioskDatabase.ShowDatabaseError(Me, "Review your cart and try again.", ex)
            LoadMenu(currentCategory)
            Return
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The order could not be saved.", ex)
            Return
        End Try

        cartList.Clear()
        RefreshCartDisplay()
        LoadMenu(currentCategory)
        MessageBox.Show(Me, $"Order {orderNumber} · {diningOption}" & vbCrLf &
                        $"Please pay ₱{total:N2} at the counter and give your order number.",
                        "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New FPdashboard()
        dash.Show()
        Me.Close()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnCatBurgers.MouseEnter, btnCatDrinks.MouseEnter, btnCatDesserts.MouseEnter, btnPay.MouseEnter, btnBack.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnCatBurgers.MouseLeave, btnCatDrinks.MouseLeave, btnCatDesserts.MouseLeave, btnPay.MouseLeave, btnBack.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class
