Public Class W1112_Classes
    Private childCount As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week11_12Selector.OpenChildForm(New W1112_Net())
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week11_12Selector.OpenChildForm(New W1112_String())
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

    Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnSpawn.Click
        childCount += 1
        Dim child As New Label()
        child.Text = "Child " & childCount
        child.Size = New Size(60, 30)
        child.BackColor = Color.DodgerBlue
        child.ForeColor = Color.White
        child.TextAlign = ContentAlignment.MiddleCenter

        ' Randomly place inside the parent panel bounds to prove containment
        Dim rnd As New Random()
        child.Left = rnd.Next(0, pnlParent.Width - child.Width)
        child.Top = rnd.Next(0, pnlParent.Height - child.Height)

        pnlParent.Controls.Add(child)
        child.BringToFront()
    End Sub

    Private Sub pnlParent_Paint(sender As Object, e As PaintEventArgs) Handles pnlParent.Paint

    End Sub
End Class