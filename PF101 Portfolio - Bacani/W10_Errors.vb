Public Class W10_Errors
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week10Selector.Show()
        Week10Selector.Update()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W10_Handling.Show() ' Adjust to your Form 3 name
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W10_Classes.Show()
    End Sub

    Private Sub W10_Errors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' Empty as requested, you will paste the text in the Designer


        cboRunDrive.Items.Add("C:\System\Config.sys (Valid)")
        cboRunDrive.Items.Add("Z:\Offline\Data.bin (Invalid)")
        cboRunDrive.SelectedIndex = 0

        rtbOutput.Text = "> System Diagnostics Active." & vbCrLf & "> Awaiting execution..."
    End Sub

    ' --- 1. SYNTAX ERROR DEMO ---
    Private Sub chkSynFix_CheckedChanged(sender As Object, e As EventArgs) Handles chkSynFix.CheckedChanged
        If chkSynFix.Checked Then
            lblSynCode.Text = "Dim msg As String = ""Hello Metaverse"""
            lblSynCode.ForeColor = Color.LimeGreen
        Else
            lblSynCode.Text = "Dim msg As String = ""Hello Metaverse"
            lblSynCode.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub btnSynTest_Click(sender As Object, e As EventArgs) Handles btnSynTest.Click
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
    End Sub

    ' --- 2. RUN-TIME ERROR DEMO ---
    Private Sub btnRunTest_Click(sender As Object, e As EventArgs) Handles btnRunTest.Click
        rtbOutput.Clear()

        If cboRunDrive.SelectedIndex = 0 Then
            rtbOutput.ForeColor = Color.LimeGreen
            rtbOutput.AppendText("> [SUCCESS] RUN-TIME I/O" & vbCrLf)
            rtbOutput.AppendText("> Status: Simulated file successfully read into memory.")
        Else
            ' This genuinely causes an exception, proving what a runtime error is
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
    End Sub

    ' --- 3. LOGIC ERROR DEMO ---
    Private Sub chkLogFix_CheckedChanged(sender As Object, e As EventArgs) Handles chkLogFix.CheckedChanged
        If chkLogFix.Checked Then
            lblLogMath.Text = "Code: Total = Price(50) + Tax(5)"
            lblLogMath.ForeColor = Color.LimeGreen
        Else
            lblLogMath.Text = "Code: Total = Price(50) - Tax(5)"
            lblLogMath.ForeColor = Color.DodgerBlue
        End If
    End Sub

    Private Sub btnLogTest_Click(sender As Object, e As EventArgs) Handles btnLogTest.Click
        rtbOutput.Clear()
        Dim price As Integer = 50
        Dim tax As Integer = 5

        If chkLogFix.Checked Then
            Dim total As Integer = price + tax
            rtbOutput.ForeColor = Color.LimeGreen
            rtbOutput.AppendText("> [SUCCESS] CALCULATION" & vbCrLf)
            rtbOutput.AppendText("> Result: Payment is $" & total & vbCrLf)
        Else
            Dim total As Integer = price - tax ' Flawed logic (subtracting tax)
            rtbOutput.ForeColor = Color.DodgerBlue
            rtbOutput.AppendText("> [SILENT] LOGIC ERROR" & vbCrLf)
            rtbOutput.AppendText("> Result: Payment is $" & total & vbCrLf)
            rtbOutput.AppendText("> Action: Ran perfectly, but charged the user the wrong amount of money!")
        End If
    End Sub
End Class