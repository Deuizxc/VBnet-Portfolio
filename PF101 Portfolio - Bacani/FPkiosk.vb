Public Class FPkiosk

    Private Class CartItem
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
    End Class

    Private cartList As New List(Of CartItem)()

    Private Sub FPkiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        LoadMenu("Favorites")
    End Sub

    Private Sub LoadMenu(category As String)
        flpMenuGrid.Controls.Clear()

        Dim items As New List(Of Tuple(Of String, Decimal, String))()

        If category = "Favorites" Then
            items.Add(New Tuple(Of String, Decimal, String)("🍔 Big Mac Meal", 199D, "Popular Combo"))
            items.Add(New Tuple(Of String, Decimal, String)("🍗 2-pc Chicken Joy", 149D, "Crispy & Juicy"))
            items.Add(New Tuple(Of String, Decimal, String)("🍟 Large Fries", 75D, "Golden & Salted Float"))
            items.Add(New Tuple(Of String, Decimal, String)("🥤 Coca-Cola Float", 55D, "Icy Refreshment"))
        ElseIf category = "Burgers" Then
            items.Add(New Tuple(Of String, Decimal, String)("🍔 Big Mac Meal", 199D, "Signature Burger"))
            items.Add(New Tuple(Of String, Decimal, String)("🧀 Cheeseburger", 89D, "Classic Cheese"))
            items.Add(New Tuple(Of String, Decimal, String)("🥓 Bacon Burger", 139D, "Smoky Bacon"))
        ElseIf category = "Drinks" Then
            items.Add(New Tuple(Of String, Decimal, String)("🥤 Coca-Cola Float", 55D, "Large Cup"))
            items.Add(New Tuple(Of String, Decimal, String)("🍵 Lemon Iced Tea", 69D, "Fresh Brew"))
            items.Add(New Tuple(Of String, Decimal, String)("🥭 Mango Shake", 89D, "Real Fruit"))
        ElseIf category = "Desserts" Then
            items.Add(New Tuple(Of String, Decimal, String)("🍦 Sundae Cone", 35D, "Vanilla Soft Serve"))
            items.Add(New Tuple(Of String, Decimal, String)("🥧 Apple Pie", 50D, "Crisp & Warm"))
        End If

        For Each item In items
            Dim card As New Panel()
            card.Width = 160
            card.Height = 125
            card.BackColor = Color.FromArgb(20, 20, 20)
            card.Cursor = Cursors.Hand

            Dim lblName As New Label()
            lblName.Text = item.Item1
            lblName.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            lblName.ForeColor = Color.White
            lblName.AutoSize = False
            lblName.Width = 145
            lblName.Height = 35
            lblName.Location = New Point(8, 10)

            Dim lblSub As New Label()
            lblSub.Text = item.Item3
            lblSub.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular)
            lblSub.ForeColor = Color.DarkGray
            lblSub.AutoSize = False
            lblSub.Width = 145
            lblSub.Height = 20
            lblSub.Location = New Point(8, 48)

            Dim lblPrice As New Label()
            lblPrice.Text = $"₱{item.Item2:N2}"
            lblPrice.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            lblPrice.ForeColor = Color.LightGreen
            lblPrice.AutoSize = False
            lblPrice.Width = 145
            lblPrice.Height = 25
            lblPrice.Location = New Point(8, 75)

            card.Controls.Add(lblName)
            card.Controls.Add(lblSub)
            card.Controls.Add(lblPrice)

            ' Click handlers to add to cart
            Dim productName = item.Item1
            Dim productPrice = item.Item2

            AddHandler card.Click, Sub(s, ev) AddToCart(productName, productPrice)
            AddHandler lblName.Click, Sub(s, ev) AddToCart(productName, productPrice)
            AddHandler lblSub.Click, Sub(s, ev) AddToCart(productName, productPrice)
            AddHandler lblPrice.Click, Sub(s, ev) AddToCart(productName, productPrice)

            flpMenuGrid.Controls.Add(card)
        Next
    End Sub

    Private Sub AddToCart(name As String, price As Decimal)
        Dim existing = cartList.FirstOrDefault(Function(x) x.Name = name)
        If existing IsNot Nothing Then
            existing.Quantity += 1
        Else
            cartList.Add(New CartItem With {.Name = name, .Price = price, .Quantity = 1})
        End If
        RefreshCartDisplay()
    End Sub

    Private Sub RefreshCartDisplay()
        flpCartItems.Controls.Clear()
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

        Dim tax As Decimal = CalculateTax(subtotal)
        Dim grandTotal As Decimal = subtotal + tax

        lblTaxValue.Text = $"₱{tax:N2}"
        lblTotalValue.Text = $"₱{grandTotal:N2}"
    End Sub

    Private Sub btnCatFavorites_Click(sender As Object, e As EventArgs) Handles btnCatFavorites.Click
        LoadMenu("Favorites")
    End Sub

    Private Sub btnCatBurgers_Click(sender As Object, e As EventArgs) Handles btnCatBurgers.Click
        LoadMenu("Burgers")
    End Sub

    Private Sub btnCatDrinks_Click(sender As Object, e As EventArgs) Handles btnCatDrinks.Click
        LoadMenu("Drinks")
    End Sub

    Private Sub btnCatDesserts_Click(sender As Object, e As EventArgs) Handles btnCatDesserts.Click
        LoadMenu("Desserts")
    End Sub

    Private Function CalculateTax(subtotal As Decimal) As Decimal
        Return Math.Round(subtotal * 0.12D, 2, MidpointRounding.AwayFromZero)
    End Function

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If cartList.Count = 0 Then
            MessageBox.Show("Your cart is empty. Please select items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim orderItems As New List(Of FPorders.OrderItem)()
        Dim subtotal As Decimal = 0D

        For Each item In cartList
            orderItems.Add(New FPorders.OrderItem(item.Name, item.Price, item.Quantity))
            subtotal += item.Price * item.Quantity
        Next

        Dim orderNumber As String = FPorders.PlaceOrder(orderItems, subtotal + CalculateTax(subtotal))
        cartList.Clear()
        RefreshCartDisplay()

        MessageBox.Show(Me, $"Your order number is {orderNumber}." & vbCrLf &
                        "Please wait for your order number to be called.",
                        "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New FPdashboard()
        dash.Show()
        Me.Close()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnCatFavorites.MouseEnter, btnCatBurgers.MouseEnter, btnCatDrinks.MouseEnter, btnCatDesserts.MouseEnter, btnPay.MouseEnter, btnBack.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnCatFavorites.MouseLeave, btnCatBurgers.MouseLeave, btnCatDrinks.MouseLeave, btnCatDesserts.MouseLeave, btnPay.MouseLeave, btnBack.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class
