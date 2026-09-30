Public Class Week6Selector
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Lessons.Show()
        Lessons.Update()
        Me.Hide()
    End Sub
    'nudge sa home button
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.Left -= 2
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.Left += 2
        Button7.Cursor = Cursors.Default
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        W6_Classes.Show()
        W6_Classes.Update()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        W6_Selection.Show()
        W6_Selection.Update()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        W6_Operator.Show()
        W6_Operator.Update()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        W6_Repeat.Show()
        W6_Repeat.Update()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        W6_Date.Show()
        W6_Date.Update()
        Me.Hide()
    End Sub

    'HOVER EFFECTS
    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles _
    Label3.MouseEnter, Label7.MouseEnter, Label8.MouseEnter, Label9.MouseEnter, Label11.MouseEnter

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 3
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles _
    Label3.MouseLeave, Label7.MouseLeave, Label8.MouseLeave, Label9.MouseLeave, Label11.MouseLeave

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.White
        lbl.Top += 3
        lbl.Cursor = Cursors.Default
    End Sub

    Private Sub Week6Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class