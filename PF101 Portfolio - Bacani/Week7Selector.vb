Imports System.Reflection.Emit

Public Class Week7Selector
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
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        W7_Procedure.Show()
        W7_Procedure.Update()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        W7_Array.Show()
        W7_Array.Update()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        W7_Dimension.Show()
        W7_Dimension.Update()
        Me.Hide()
    End Sub

    'HOVER EFFECTS
    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.Gold
        Label7.Top -= 3
        Label7.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.White
        Label7.Top += 3
        Label7.Cursor = Cursors.Default
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Gold
        Label6.Top -= 3
        Label6.Cursor = Cursors.Hand
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.White
        Label6.Top += 3
        Label6.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Gold
        Label3.Top -= 3
        Label3.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.White
        Label3.Top += 3
        Label3.Cursor = Cursors.Default
    End Sub

    Private Sub Week7Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class