Imports System.Text.RegularExpressions

Public Class W3_Vbnet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week3Selector.Show()
            Week3Selector.Update()
        Catch ex As Exception
            Dim w3 As New Week3Selector()
            w3.Show()
            w3.Update()
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
            W3_IDE.Show()
        Catch ex As Exception
            Dim ide As New W3_IDE()
            ide.Show()
        End Try
    End Sub

    Private Sub btnrun_Click(sender As Object, e As EventArgs) Handles btnrun.Click
        Dim cmdCommands As String = "/k @echo off & title PF101 Execution Terminal & " &
                                "echo ============================================================== & " &
                                "echo             PF101 .NET RUNTIME EXECUTION ENVIRONMENT           & " &
                                "echo ============================================================== & " &
                                "echo [STATUS]    : Showcasing Output.. OK & " &
                                "echo [TARGET]    : Console Application Module & " &
                                "echo -------------------------------------------------------------- & " &
                                "echo [OUTPUT]   -^> Hello, World! & " &
                                "echo -------------------------------------------------------------- & " &
                                "echo Process exited with code 0 (0x0). & " &
                                "echo. & pause"
        Process.Start("cmd.exe", cmdCommands)
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
    End Sub

    Private Sub btnrun_MouseEnter(sender As Object, e As EventArgs) Handles btnrun.MouseEnter
        btnrun.Top -= 3
        btnrun.Cursor = Cursors.Hand
    End Sub

    Private Sub btnrun_MouseLeave(sender As Object, e As EventArgs) Handles btnrun.MouseLeave
        btnrun.Top += 3
        btnrun.Cursor = Cursors.Default
    End Sub

    Private Sub W3_Vbnet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        FormatRichText()
        FormatCodeBox()
    End Sub

    Private Sub FormatRichText()
        Try
            Dim rtb As RichTextBox = Nothing
            If Me.Controls.Find("RichTextBox1", True).Length > 0 Then
                rtb = DirectCast(Me.Controls.Find("RichTextBox1", True)(0), RichTextBox)
            End If
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return

            rtb.SuspendLayout()
            Dim origStart As Integer = rtb.SelectionStart
            Dim origLen As Integer = rtb.SelectionLength

            rtb.SelectAll()
            rtb.SelectionFont = New Font("Segoe UI", 9.0F, FontStyle.Regular)
            rtb.SelectionColor = Color.FromArgb(40, 40, 40)

            Dim mc As MatchCollection = Regex.Matches(rtb.Text, "(?m)^[•\-]\s*([^:]+):")
            For Each m As Match In mc
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^\d+\.\s+.*$|\[.*?\]")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            rtb.Select(origStart, origLen)
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatCodeBox()
        Try
            Dim rtb As RichTextBox = Nothing
            If Me.Controls.Find("RichTextBox2", True).Length > 0 Then
                rtb = DirectCast(Me.Controls.Find("RichTextBox2", True)(0), RichTextBox)
            End If
            If rtb Is Nothing Then Return

            rtb.SuspendLayout()
            rtb.Clear()
            rtb.BackColor = Color.Black

            Dim kwFont As New Font("Consolas", 9.0F, FontStyle.Bold)
            Dim regFont As New Font("Consolas", 9.0F, FontStyle.Regular)
            Dim blueColor As Color = Color.FromArgb(78, 156, 245)
            Dim whiteColor As Color = Color.White
            Dim maroonColor As Color = Color.FromArgb(214, 157, 133)
            Dim greenColor As Color = Color.FromArgb(87, 166, 74)

            rtb.SelectionFont = kwFont
            rtb.SelectionColor = blueColor
            rtb.AppendText("Imports ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = whiteColor
            rtb.AppendText("System.Console" & vbCrLf & vbCrLf)

            rtb.SelectionFont = kwFont
            rtb.SelectionColor = blueColor
            rtb.AppendText("Module ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = whiteColor
            rtb.AppendText("Module1" & vbCrLf)

            rtb.SelectionFont = kwFont
            rtb.SelectionColor = blueColor
            rtb.AppendText("    Sub ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = whiteColor
            rtb.AppendText("Main()" & vbCrLf)

            rtb.SelectionFont = regFont
            rtb.SelectionColor = whiteColor
            rtb.AppendText("        System.Console.Write(")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = maroonColor
            rtb.AppendText("""Hello world""")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = whiteColor
            rtb.AppendText(")" & vbCrLf)

            rtb.SelectionFont = regFont
            rtb.SelectionColor = whiteColor
            rtb.AppendText("        Read()" & vbCrLf)

            rtb.SelectionFont = kwFont
            rtb.SelectionColor = blueColor
            rtb.AppendText("    End Sub" & vbCrLf)

            rtb.SelectionFont = kwFont
            rtb.SelectionColor = blueColor
            rtb.AppendText("End Module" & vbCrLf & vbCrLf)

            rtb.SelectionFont = kwFont
            rtb.SelectionColor = greenColor
            rtb.AppendText("Output: Hello world")
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblTerminalOutput_Click(sender As Object, e As EventArgs) Handles lblTerminalOutput.Click
    End Sub
End Class