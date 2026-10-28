Imports System.Text.RegularExpressions

Public Class W4_Layout
    Private originalLocation As Point
    Private originalSize As Size

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Try
            W4_Form.Show()
        Catch ex As Exception
            Dim frm As New W4_Form()
            frm.Show()
        End Try
    End Sub

    Private Sub btnToggleLayout_Click(sender As Object, e As EventArgs) Handles btnToggleLayout.Click
        If testbox.Dock = DockStyle.None AndAlso testbox.Anchor = (AnchorStyles.Top Or AnchorStyles.Left) Then
            testbox.Dock = DockStyle.Bottom
            lblLayoutStatus.Text = "Mode: Docked"
        ElseIf testbox.Dock = DockStyle.Bottom Then
            testbox.Dock = DockStyle.None
            testbox.Size = New Size(80, 30)
            testbox.Location = New Point(testbox.Parent.ClientSize.Width - testbox.Width - 15, 15)
            testbox.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lblLayoutStatus.Text = "Mode: Anchored"
        Else
            testbox.Dock = DockStyle.None
            testbox.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            testbox.Size = originalSize
            testbox.Location = originalLocation
            lblLayoutStatus.Text = "Mode: Default"
        End If
    End Sub

    Private Sub W4_Layout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        originalLocation = testbox.Location
        originalSize = testbox.Size
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        FormatRichText(RichTextBox1)
    End Sub

    Private Sub btnToggleLayout_MouseEnter(sender As Object, e As EventArgs) Handles btnToggleLayout.MouseEnter
        btnToggleLayout.Top -= 3
        btnToggleLayout.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnToggleLayout.MouseLeave
        btnToggleLayout.Top += 3
        btnToggleLayout.Cursor = Cursors.Default
    End Sub

    Private Sub lblLayoutStatus_Click(sender As Object, e As EventArgs) Handles lblLayoutStatus.Click
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