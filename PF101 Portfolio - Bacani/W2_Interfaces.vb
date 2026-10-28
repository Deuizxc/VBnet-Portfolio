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

        Label2.Text = "Enter amount"
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

            ' Header
            RichTextBox1.SelectionFont = titleFont
            RichTextBox1.SelectionColor = redColor
            RichTextBox1.AppendText("[ INTERFACES & CONTRACTS ]" & vbCrLf & vbCrLf)

            ' Point 1
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

            ' Point 2
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

            ' Point 3
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

End Class

' --- INTERFACES & IMPLEMENTATIONS MUST REMAIN BELOW THE FORM CLASS ---
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
        Return "Paid " & amount.ToString("C2") & " via GCash"
    End Function
End Class

Public Class CashPayment
    Implements IPaymentMethod

    Public Function ProcessPayment(amount As Decimal) As String Implements IPaymentMethod.ProcessPayment
        Return "Paid " & amount.ToString("C2") & " in Cash"
    End Function
End Class