Public Class W3_Programming
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Week3Selector.Show()
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
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W3_Components.Show()
    End Sub

    Private Sub W3_Programming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class