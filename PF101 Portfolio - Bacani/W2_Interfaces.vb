Public Class W2_Interfaces


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week2Selector.Show()
        Week2Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        W2_Polymorphism.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub W2_Interfaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Label2.Text = "Enter amount"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amount As Decimal = Val(TextBox1.Text)
        If amount <= 0 Then
            Label2.Text = "Please enter a valid amount."
            Exit Sub
        End If

        Dim payment As IPaymentMethod = New CreditCardPayment()
        Label2.Text = payment.ProcessPayment(amount)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim amount As Decimal = Val(TextBox1.Text)
        If amount <= 0 Then
            Label2.Text = "Please enter a valid amount."
            Exit Sub
        End If

        Dim payment As IPaymentMethod = New PayPalPayment()
        Label2.Text = payment.ProcessPayment(amount)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim amount As Decimal = Val(TextBox1.Text)
        If amount <= 0 Then
            Label2.Text = "Please enter a valid amount."
            Exit Sub
        End If

        Dim payment As IPaymentMethod = New CashPayment()
        Label2.Text = payment.ProcessPayment(amount)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        Label2.Text = "Enter amount"
        TextBox1.Focus()
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.Top -= 3
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Top += 3
        Button2.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.Top -= 3
        Button4.Cursor = Cursors.Hand
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.Top += 3
        Button4.Cursor = Cursors.Default
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.Top -= 3
        Button5.Cursor = Cursors.Hand
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.Top += 3
        Button5.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

Public Interface IPaymentMethod
    Function ProcessPayment(amount As Decimal) As String
End Interface

Public Class CreditCardPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Paid " & amount.ToString("C2") & " via Credit Card"
    End Function
End Class

Public Class PayPalPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Paid " & amount.ToString("C2") & " via Gcash"
    End Function
End Class

Public Class CashPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Paid " & amount.ToString("C2") & " in Cash"
    End Function
End Class