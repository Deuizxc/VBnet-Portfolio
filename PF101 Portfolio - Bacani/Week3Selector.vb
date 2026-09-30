Public Class Week3Selector
    Private Sub Week3Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Lessons.Show()
        Lessons.Update()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

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
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        W3_Programming.Show()
        W3_Programming.Update()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        W3_Components.Show()
        W3_Components.Update()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        W3_IDE.Show()
        W3_IDE.Update()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        W3_Vbnet.Show()
        W3_Vbnet.Update()
        Me.Hide()
    End Sub

    'HOVER EFFECTS
    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles _
    Label3.MouseEnter, Label7.MouseEnter, Label8.MouseEnter, Label9.MouseEnter

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 3
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles _
    Label3.MouseLeave, Label7.MouseLeave, Label8.MouseLeave, Label9.MouseLeave

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.White
        lbl.Top += 3
        lbl.Cursor = Cursors.Default
    End Sub
End Class