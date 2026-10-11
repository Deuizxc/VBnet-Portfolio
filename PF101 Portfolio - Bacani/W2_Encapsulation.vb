Public Class W2_Encapsulation


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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Label1.Text = "Select an option below"
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
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Hide()
        W2_Inheritance.Show()
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