Public Class W3_Components
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week3Selector.Show()
        Week3Selector.Update()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        W3_IDE.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W3_Programming.Show()
    End Sub

    Private Sub GreetUser(userName As String)
        Dim message As String = "Hello, " & userName & "! Welcome to my portfolio"
        Label2.Text = message
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inputName As String = TextBox1.Text.Trim()
        If inputName = "" Then
            Label2.Text = "Error: Please enter a name first."
            Exit Sub
        End If

        GreetUser(inputName)
    End Sub

    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter, Button4.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave, Button4.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        Label2.Text = "Waiting for input"
        TextBox1.Focus()
    End Sub

    Private Sub W3_Components_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class