Imports System.Text.RegularExpressions

Public Class W6_Repeat

    Private Sub W6_Repeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        RadioButton1.Checked = True
        ListBox1.Items.Clear()
        Label3.Text = "Total Iterations: -"
        FormatRichText(RichTextBox1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week6Selector.Show()
            Week6Selector.Update()
        Catch ex As Exception
            Dim w6 As New Week6Selector()
            w6.Show()
            w6.Update()
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
            W6_Date.Show()
        Catch ex As Exception
            Dim frm As New W6_Date()
            frm.Show()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Try
            W6_Classes.Show()
        Catch ex As Exception
            Dim frm As New W6_Classes()
            frm.Show()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim maxCount As Integer

        If Not Integer.TryParse(TextBox1.Text, maxCount) OrElse maxCount <= 0 Then
            MessageBox.Show("Please enter a valid positive integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Label3.ForeColor = Color.Red
            Label3.Text = "Total Iterations: Error"
            TextBox1.SelectAll()
            TextBox1.Focus()
            Exit Sub
        End If

        ' Arbitrary limit to prevent accidental infinite hangs during demo
        If maxCount > 10000 Then maxCount = 10000

        ListBox1.BeginUpdate()
        Dim iterations As Integer = 0

        If RadioButton1.Checked Then
            Dim i As Integer = 0
            Do While i < maxCount
                ListBox1.Items.Add("Do While: Item " & (i + 1))
                i += 1
                iterations += 1
            Loop
        ElseIf RadioButton2.Checked Then
            For i As Integer = 0 To maxCount - 1
                ListBox1.Items.Add("For...Next: Item " & (i + 1))
                iterations += 1
            Next
        ElseIf RadioButton3.Checked Then
            Dim i As Integer = 0
            Do Until i = maxCount
                ListBox1.Items.Add("Do Until: Item " & (i + 1))
                i += 1
                iterations += 1
            Loop
        ElseIf RadioButton4.Checked Then
            For outer As Integer = 1 To 2
                For inner As Integer = 1 To maxCount
                    ListBox1.Items.Add("Outer " & outer & " -> Inner " & inner)
                    iterations += 1
                Next
            Next
        End If
        ListBox1.EndUpdate()

        Label3.ForeColor = Color.LimeGreen
        Label3.Text = "Total Iterations: " & iterations.ToString("N0")

        ' Auto-scroll listbox
        If ListBox1.Items.Count > 0 Then
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
        Label3.ForeColor = Color.White
        Label3.Text = "Total Iterations: -"
        TextBox1.Focus()
    End Sub

    Private Sub HoverButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button3.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub HoverButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button3.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub FormatRichText(rtb As RichTextBox)
        Try
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
            rtb.SuspendLayout()
            Dim origStart As Integer = rtb.SelectionStart
            Dim origLen As Integer = rtb.SelectionLength

            rtb.Text = rtb.Text

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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^\d+\.\s+[^:\r\n]+:?")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc3 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^[•]\s*[^:\r\n]+:?")
            For Each m As Match In mc3
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|VB\.Net|MessageBox|Show|IsNumeric|Empty|Trim|ToUpper|ToLower)\b"
            Dim mc4 As MatchCollection = Regex.Matches(rtb.Text, kw)
            For Each m As Match In mc4
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