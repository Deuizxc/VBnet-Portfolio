Imports System.Text.RegularExpressions

Public Class W7_Procedure

    Private currentNum As Integer = 10

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week7Selector.Show()
            Week7Selector.Update()
        Catch ex As Exception
            Dim w7 As New Week7Selector()
            w7.Show()
            w7.Update()
        End Try
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
        Try
            W7_Dimension.Show()
        Catch ex As Exception
            Dim frm As New W7_Dimension()
            frm.Show()
        End Try
    End Sub

    Private Sub DoubleByVal(ByVal n As Integer)
        n *= 2
    End Sub

    Private Sub DoubleByRef(ByRef n As Integer)
        n *= 2
    End Sub

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
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        FormatRichText(RichTextBox1)
    End Sub

    Private Sub FormatRichText(rtb As RichTextBox)
        Try
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
            rtb.SuspendLayout()
            Dim origStart As Integer = rtb.SelectionStart
            Dim origLen As Integer = rtb.SelectionLength

            rtb.SelectAll()
            rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Regular)
            If rtb.BackColor = Color.Black Then
                rtb.SelectionColor = Color.White
            Else
                rtb.SelectionColor = Color.FromArgb(40, 40, 40)
            End If

            Dim mc1 As MatchCollection = Regex.Matches(rtb.Text, "\[.*?\]")
            For Each m As Match In mc1
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 13.0F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•)\s+[^:\r\n]+:")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|Function|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|ByVal|ByRef|Step)\b"
            Dim mc3 As MatchCollection = Regex.Matches(rtb.Text, kw)
            For Each m As Match In mc3
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(0, 70, 190)
            Next

            rtb.Select(origStart, origLen)
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub

End Class