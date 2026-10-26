Public Class W13_Memory
    ' RETURN BUTTON (Closes MDI Child)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' PREVIOUS BUTTON (Swaps to W13_Sql)
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week13Selector.OpenChildForm(New W13_Sql())
    End Sub

    ' CONTINUE BUTTON (Swaps to W13_Visual)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week13Selector.OpenChildForm(New W13_Visual())
    End Sub

    ' HOVER EFFECTS (Unified & Clean)
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub W13_Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class