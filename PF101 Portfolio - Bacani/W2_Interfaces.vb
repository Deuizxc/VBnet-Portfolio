Public Class W2_Interfaces

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week2Selector.Show()
        Week2Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Try
            W2_Polymorphism.Show()
        Catch ex As Exception
            Dim poly As New W2_Polymorphism()
            poly.Show()
        End Try
    End Sub

    Private Sub W2_Interfaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        Label2.Text = "Ready for transaction."
        LoadDocumentationText()
    End Sub

    Private Sub LoadDocumentationText()
        Try
            RichTextBox1.Clear()

            Dim titleFont As New Font("Segoe UI", 9.5F, FontStyle.Bold)
            Dim labelFont As New Font("Segoe UI", 8.5F, FontStyle.Bold)
            Dim bodyFont As New Font("Segoe UI", 8.5F, FontStyle.Regular)
            Dim kwFont As New Font("Consolas", 8.5F, FontStyle.Bold)

            Dim redColor As Color = Color.FromArgb(190, 20, 20)
            Dim blueColor As Color = Color.FromArgb(0, 70, 190)
            Dim darkColor As Color = Color.FromArgb(20, 20, 20)
            Dim bodyColor As Color = Color.FromArgb(50, 50, 50)

            RichTextBox1.SelectionFont = titleFont
            RichTextBox1.SelectionColor = redColor
            RichTextBox1.AppendText("[ INTERFACES & CONTRACTS ]" & vbCrLf & vbCrLf)

            RichTextBox1.SelectionFont = labelFont
            RichTextBox1.SelectionColor = darkColor
            RichTextBox1.AppendText("1. Formal Contract:" & vbCrLf)
            RichTextBox1.SelectionFont = bodyFont
            RichTextBox1.SelectionColor = bodyColor
            RichTextBox1.AppendText("An ")
            RichTextBox1.SelectionFont = kwFont
            RichTextBox1.SelectionColor = blueColor
            RichTextBox1.AppendText("Interface ")
            RichTextBox1.SelectionFont = bodyFont
            RichTextBox1.SelectionColor = bodyColor
            RichTextBox1.AppendText("specifies method signatures and properties without providing any implementation body." & vbCrLf & vbCrLf)

            RichTextBox1.SelectionFont = labelFont
            RichTextBox1.SelectionColor = darkColor
            RichTextBox1.AppendText("2. The Implements Clause:" & vbCrLf)
            RichTextBox1.SelectionFont = bodyFont
            RichTextBox1.SelectionColor = bodyColor
            RichTextBox1.AppendText("Any class adhering to an interface MUST implement every declared member using ")
            RichTextBox1.SelectionFont = kwFont
            RichTextBox1.SelectionColor = blueColor
            RichTextBox1.AppendText("Implements")
            RichTextBox1.SelectionFont = bodyFont
            RichTextBox1.SelectionColor = bodyColor
            RichTextBox1.AppendText("." & vbCrLf & vbCrLf)

            RichTextBox1.SelectionFont = labelFont
            RichTextBox1.SelectionColor = darkColor
            RichTextBox1.AppendText("3. Decoupled Architecture:" & vbCrLf)
            RichTextBox1.SelectionFont = bodyFont
            RichTextBox1.SelectionColor = bodyColor
            RichTextBox1.AppendText("Allows Card, GCash, and Cash classes to be treated interchangeably as ")
            RichTextBox1.SelectionFont = kwFont
            RichTextBox1.SelectionColor = redColor
            RichTextBox1.AppendText("IPaymentMethod")
            RichTextBox1.SelectionFont = bodyFont
            RichTextBox1.SelectionColor = bodyColor
            RichTextBox1.AppendText(".")
        Catch ex As Exception
        End Try
    End Sub

    Private Async Sub ExecutePayment(method As IPaymentMethod)
        Dim amount As Decimal
        If Not Decimal.TryParse(TextBox1.Text, amount) OrElse amount <= 0 Then
            Label2.ForeColor = Color.Red
            Label2.Text = "Error: Invalid amount."
            Exit Sub
        End If

        SetUIEnabled(False)
        Label2.ForeColor = Color.Gold
        Label2.Text = "Processing transaction..."

        Await Task.Delay(1000)

        Label2.ForeColor = Color.LimeGreen
        Label2.Text = method.ProcessPayment(amount)

        SetUIEnabled(True)
    End Sub

    Private Sub SetUIEnabled(isEnabled As Boolean)
        Button2.Enabled = isEnabled
        Button4.Enabled = isEnabled
        Button5.Enabled = isEnabled
        Button6.Enabled = isEnabled
        TextBox1.Enabled = isEnabled
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExecutePayment(New CreditCardPayment())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ExecutePayment(New GCashPayment())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ExecutePayment(New CashPayment())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        Label2.ForeColor = Color.Red
        Label2.Text = "Ready for transaction."
        TextBox1.Focus()
    End Sub

    Private Sub PaymentButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = Color.White
        btn.ForeColor = Color.Black
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub PaymentButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button4.MouseLeave, Button5.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = Color.FromArgb(20, 20, 20)
        btn.ForeColor = Color.White
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.Gold
        Button6.Top -= 3
        Button6.Cursor = Cursors.Hand
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.FromArgb(190, 20, 20)
        Button6.Top += 3
        Button6.Cursor = Cursors.Default
    End Sub

End Class

Public Interface IPaymentMethod
    Function ProcessPayment(amount As Decimal) As String
End Interface

Public Class CreditCardPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Successfully paid ₱" & amount.ToString("N2") & " via Credit Card."
    End Function
End Class

Public Class GCashPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Successfully paid ₱" & amount.ToString("N2") & " via GCash."
    End Function
End Class

Public Class CashPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Successfully paid ₱" & amount.ToString("N2") & " in Cash."
    End Function
End Class