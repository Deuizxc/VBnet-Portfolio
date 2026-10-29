Imports System.Text.RegularExpressions

Public Class W4_Common
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week4Selector.Show()
            Week4Selector.Update()
        Catch ex As Exception
            Dim w4 As New Week4Selector()
            w4.Show()
            w4.Update()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        Try
            W4_Form.Show()
        Catch ex As Exception
            Dim frm As New W4_Form()
            frm.Show()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Try
            W4_Basic.Show()
        Catch ex As Exception
            Dim bsc As New W4_Basic()
            bsc.Show()
        End Try
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userName As String = txtDemo.Text.Trim()

        If String.IsNullOrEmpty(userName) Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Error: Name is required."
            Exit Sub
        End If

        If Not RadioButton1.Checked AndAlso Not RadioButton2.Checked Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Error: Select a role."
            Exit Sub
        End If

        If Not CheckBox1.Checked Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Error: Accept terms."
            Exit Sub
        End If

        lblStatus.ForeColor = Color.Gold
        lblStatus.Text = "Authenticating..."
        Button2.Enabled = False
        ProgressBar1.Value = 0

        For i As Integer = 1 To 100
            ProgressBar1.Value = i
            Await Task.Delay(10)
        Next

        Dim selectedRole As String = If(RadioButton1.Checked, "Student", "Prof")

        lblStatus.ForeColor = Color.LimeGreen
        lblStatus.Text = $"Welcome, {selectedRole} {userName}!"
        Button2.Enabled = True
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDemo.TextChanged
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click
    End Sub

    Private Sub W4_Common_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            rtb.SelectionColor = Color.FromArgb(40, 40, 40)

            Dim mc1 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^[•\-]\s*([^:]+):")
            For Each m As Match In mc1
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^\d+\.\s+.*$|\[.*?\]")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 13.0F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|End|Private|Public|Handles|Dim|As|String|Integer|If|ElseIf|Else|Then|Return|True|False)\b"
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