Public Class W2_Classes
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week2Selector.Show()
        Week2Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.Red
        Button7.Top -= 3
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black
        Button7.Top += 3
        Button7.Cursor = Cursors.Default
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Left -= 4
        Button2.Cursor = Cursors.Default
    End Sub

    Private Sub W2_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        W2_Encapsulation.Show()
    End Sub
End Class