Public Class W1112_Classes
    ' RETURN BUTTON (Closes MDI Child)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    ' PREVIOUS BUTTON (Swaps to W1112_Net)
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week11_12Selector.OpenChildForm(New W1112_Net())
    End Sub

    ' CONTINUE BUTTON (Swaps to W1112_String)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week11_12Selector.OpenChildForm(New W1112_String())
    End Sub

    Private Sub W1112_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class