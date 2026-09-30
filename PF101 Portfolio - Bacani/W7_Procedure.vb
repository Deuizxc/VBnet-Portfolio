Public Class W7_Procedure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week7Selector.Show()
        Week7Selector.Update()
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W7_Dimension.Show()
    End Sub
    Private currentNum As Integer = 10

    ' Sub ByVal: Only works with a copy
    Private Sub DoubleByVal(ByVal n As Integer)
        n *= 2
    End Sub

    ' Sub ByRef: Directly alters the caller's variable
    Private Sub DoubleByRef(ByRef n As Integer)
        n *= 2
    End Sub

    ' Function: Calculates and returns a new value
    Private Function AddBonus(ByVal n As Integer) As Integer
        Return n + 5
    End Function

    Private Sub btnByVal_Click(sender As Object, e As EventArgs) Handles btnByVal.Click
        DoubleByVal(currentNum)
        lblDisplay.Text = $"num = {currentNum}"
        lblExecOutput.ForeColor = Color.Yellow
        lblExecOutput.Text = "Sub ByVal executed: Copied value doubled to 20, but original 'num' stays 10!"
    End Sub

    Private Sub btnByRef_Click(sender As Object, e As EventArgs) Handles btnByRef.Click
        DoubleByRef(currentNum)
        lblDisplay.Text = $"num = {currentNum}"
        lblExecOutput.ForeColor = Color.LimeGreen
        lblExecOutput.Text = $"Sub ByRef executed: Original memory altered directly! 'num' is now {currentNum}."
    End Sub

    Private Sub btnFunc_Click(sender As Object, e As EventArgs) Handles btnFunc.Click
        currentNum = AddBonus(currentNum)
        lblDisplay.Text = $"num = {currentNum}"
        lblExecOutput.ForeColor = Color.Cyan
        lblExecOutput.Text = $"Function executed: Returned {currentNum} and assigned back to 'num'."
    End Sub

    Private Sub btnResetP_Click(sender As Object, e As EventArgs) Handles btnResetP.Click
        currentNum = 10
        lblDisplay.Text = "num = 10"
        lblExecOutput.ForeColor = Color.White
        lblExecOutput.Text = "Reset: Variable restored to initial value (10)."
    End Sub
    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnByVal.MouseEnter, btnByRef.MouseEnter, btnFunc.MouseEnter, btnResetP.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnByVal.MouseLeave, btnByRef.MouseLeave, btnFunc.MouseLeave, btnResetP.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub W7_Procedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class