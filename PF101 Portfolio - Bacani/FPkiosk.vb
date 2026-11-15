Public Class FPkiosk
    Private cartTotal As Decimal = 0.0D

    Private Sub FPkiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        lstMenu.Items.Add("Big Mac Meal - ₱199.00")
        lstMenu.Items.Add("Cheeseburger - ₱89.00")
        lstMenu.Items.Add("Large Fries - ₱75.00")
        lstMenu.Items.Add("Coca-Cola Float - ₱55.00")
    End Sub

    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        If lstMenu.SelectedItem IsNot Nothing Then
            Dim selectedItem = lstMenu.SelectedItem.ToString()
            lstCart.Items.Add(selectedItem)
            CalculateTotal()
        End If
    End Sub

    Private Sub btnRemoveCart_Click(sender As Object, e As EventArgs) Handles btnRemoveCart.Click
        If lstCart.SelectedItem IsNot Nothing Then
            lstCart.Items.Remove(lstCart.SelectedItem)
            CalculateTotal()
        End If
    End Sub

    Private Sub CalculateTotal()
        cartTotal = 0.0D
        For Each item As String In lstCart.Items
            Dim parts = item.Split("₱")
            If parts.Length > 1 Then
                Dim price As Decimal
                If Decimal.TryParse(parts(1), price) Then
                    cartTotal += price
                End If
            End If
        Next
        lblTotal.Text = $"Total: ₱{cartTotal:N2}"
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If lstCart.Items.Count > 0 Then
            MessageBox.Show($"Order placed successfully! Total Paid: ₱{cartTotal:N2}", "Kiosk Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Clear()
            CalculateTotal()
        Else
            MessageBox.Show("Your cart is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New FPdashboard()
        dash.Show()
        Me.Close()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnAddCart.MouseEnter, btnRemoveCart.MouseEnter, btnCheckout.MouseEnter, btnBack.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnAddCart.MouseLeave, btnRemoveCart.MouseLeave, btnCheckout.MouseLeave, btnBack.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class