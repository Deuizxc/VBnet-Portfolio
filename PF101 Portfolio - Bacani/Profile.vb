Public Class Profile
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub RichTextBox10_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox10.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Portfolio.Show()
        Portfolio.Update()
        Hide()
    End Sub
    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Confidant1.Show()
        Confidant1.Update()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cert.Show()
        Cert.Update()
        Hide()
    End Sub
End Class