Public Class W2_Encapsulation

    Public Class BankAccount
        Private _balance As Decimal = 0

        Public ReadOnly Property Balance As Decimal
            Get
                Return _balance
            End Get
        End Property

        Public Function Deposit(amount As Decimal) As Boolean
            If amount > 0 Then
                _balance += amount
                Return True
            End If
            Return False
        End Function

        Public Function Withdraw(amount As Decimal) As Boolean
            If amount > 0 AndAlso amount <= _balance Then
                _balance -= amount
                Return True
            End If
            Return False
        End Function
    End Class

    Private myAccount As New BankAccount()
    Private currentAction As String = ""

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W2_Classes.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W2_Inheritance.Show()
    End Sub

    Private Sub W2_Encapsulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        Panel1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Label1.Text = "Select an option below"

        LoadDocumentationText()
    End Sub

    Private Sub LoadDocumentationText()
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
        RichTextBox1.AppendText("[ ENCAPSULATION & DATA HIDING ]" & vbCrLf & vbCrLf)

        ' Point 1
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("1. Data Hiding (Shielding):" & vbCrLf)
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Protects internal object state by restricting direct access. Fields are declared as ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = blueColor
        RichTextBox1.AppendText("Private ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("so outside classes cannot corrupt values directly." & vbCrLf & vbCrLf)

        ' Point 2
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("2. Controlled Access (Properties):" & vbCrLf)
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Exposes public accessors via ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = blueColor
        RichTextBox1.AppendText("Get ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("and ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = blueColor
        RichTextBox1.AppendText("Set")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText(", or makes data strictly ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = blueColor
        RichTextBox1.AppendText("ReadOnly")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("." & vbCrLf & vbCrLf)

        ' Point 3
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("3. Business Logic Validation:" & vbCrLf)
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Modifications must pass through authorized public methods (e.g., ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Deposit()")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText(" & ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Withdraw()")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText(") to enforce security rules.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentAction = "Deposit"
        Panel1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        TextBox1.Clear()
        TextBox1.Focus()
        Label1.Text = "Mode: Deposit"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        currentAction = "Withdraw"
        Panel1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        TextBox1.Clear()
        TextBox1.Focus()
        Label1.Text = "Mode: Withdraw"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim amount As Decimal = Val(TextBox1.Text)

        If currentAction = "Deposit" Then
            If myAccount.Deposit(amount) Then
                Label1.Text = "Deposited: " & amount.ToString("C2")
            Else
                Label1.Text = "Invalid deposit amount."
            End If
        ElseIf currentAction = "Withdraw" Then
            If myAccount.Withdraw(amount) Then
                Label1.Text = "Withdrew: " & amount.ToString("C2")
            Else
                Label1.Text = "Insufficient balance!"
            End If
        End If

        Panel1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "Current Balance: " & myAccount.Balance.ToString("C2")
    End Sub

    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

End Class