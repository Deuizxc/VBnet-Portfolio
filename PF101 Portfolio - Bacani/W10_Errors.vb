Imports System.Text.RegularExpressions

Public Class W10_Errors
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
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
        Try
            Week10Selector.OpenChildForm(New W10_Handling())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week10Selector.OpenChildForm(New W10_Classes())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W10_Errors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()

            cboRunDrive.Items.Add("C:\System\Config.sys (Valid)")
            cboRunDrive.Items.Add("Z:\Offline\Data.bin (Invalid)")
            cboRunDrive.SelectedIndex = 0

            rtbOutput.Text = "> System Diagnostics Active." & vbCrLf & "> Awaiting execution..."
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkSynFix_CheckedChanged(sender As Object, e As EventArgs) Handles chkSynFix.CheckedChanged
        Try
            If chkSynFix.Checked Then
                lblSynCode.Text = "Dim msg As String = ""Hello Metaverse"""
                lblSynCode.ForeColor = Color.LimeGreen
            Else
                lblSynCode.Text = "Dim msg As String = ""Hello Metaverse"
                lblSynCode.ForeColor = Color.Orange
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSynTest_Click(sender As Object, e As EventArgs) Handles btnSynTest.Click
        Try
            rtbOutput.Clear()
            If chkSynFix.Checked Then
                rtbOutput.ForeColor = Color.LimeGreen
                rtbOutput.AppendText("> [SUCCESS] CODE COMPILED" & vbCrLf)
                rtbOutput.AppendText("> Output: Hello Metaverse")
            Else
                rtbOutput.ForeColor = Color.Orange
                rtbOutput.AppendText("> [FAILED] SYNTAX ERROR" & vbCrLf)
                rtbOutput.AppendText("> BC30198: String constant must end with a double quote." & vbCrLf)
                rtbOutput.AppendText("> Action: Compiler halted. Code will not execute.")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRunTest_Click(sender As Object, e As EventArgs) Handles btnRunTest.Click
        Try
            rtbOutput.Clear()

            If cboRunDrive.SelectedIndex = 0 Then
                rtbOutput.ForeColor = Color.LimeGreen
                rtbOutput.AppendText("> [SUCCESS] RUN-TIME I/O" & vbCrLf)
                rtbOutput.AppendText("> Status: Simulated file successfully read into memory.")
            Else
                rtbOutput.ForeColor = Color.Red
                Try
                    Dim testPath As String = System.IO.File.ReadAllText("Z:\Offline\Data.bin")
                Catch ex As Exception
                    rtbOutput.AppendText("> [CRASH] RUN-TIME ERROR" & vbCrLf)
                    rtbOutput.AppendText("> Type: " & ex.GetType().Name & vbCrLf)
                    rtbOutput.AppendText("> Message: " & ex.Message & vbCrLf)
                    rtbOutput.AppendText("> Action: Program crashed unexpectedly during execution.")
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkLogFix_CheckedChanged(sender As Object, e As EventArgs) Handles chkLogFix.CheckedChanged
        Try
            If chkLogFix.Checked Then
                lblLogMath.Text = "Code: Total = Price(50) + Tax(5)"
                lblLogMath.ForeColor = Color.LimeGreen
            Else
                lblLogMath.Text = "Code: Total = Price(50) - Tax(5)"
                lblLogMath.ForeColor = Color.DodgerBlue
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLogTest_Click(sender As Object, e As EventArgs) Handles btnLogTest.Click
        Try
            rtbOutput.Clear()
            Dim price As Integer = 50
            Dim tax As Integer = 5

            If chkLogFix.Checked Then
                Dim total As Integer = price + tax
                rtbOutput.ForeColor = Color.LimeGreen
                rtbOutput.AppendText("> [SUCCESS] CALCULATION" & vbCrLf)
                rtbOutput.AppendText("> Result: Payment is $" & total & vbCrLf)
            Else
                Dim total As Integer = price - tax
                rtbOutput.ForeColor = Color.DodgerBlue
                rtbOutput.AppendText("> [SILENT] LOGIC ERROR" & vbCrLf)
                rtbOutput.AppendText("> Result: Payment is $" & total & vbCrLf)
                rtbOutput.AppendText("> Action: Ran perfectly, but charged the user the wrong amount of money!")
            End If
        Catch ex As Exception
        End Try
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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•|\-)\s+[^:\r\n]+:")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|Function|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|ByVal|ByRef|Step|Inherits|MustInherit|MyBase|Try|Catch|Finally|Exception)\b"
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