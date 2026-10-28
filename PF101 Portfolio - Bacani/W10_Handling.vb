Imports System.Text.RegularExpressions

Public Class W10_Handling
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week10Selector.OpenChildForm(New W10_Errors())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W10_Handling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()

            cboOp.Items.Clear()
            cboOp.Items.Add("1. Valid Math Operation (100 / 2)")
            cboOp.Items.Add("2. Divide by Zero (100 / 0)")
            cboOp.Items.Add("3. Uninitialized Object (Null Reference)")
            cboOp.SelectedIndex = 0

            rtbOutput.Text = "> Awaiting execution trace..."
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Try
            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("Initiating Try Structure..." & vbCrLf & vbCrLf)

            Try
                rtbOutput.SelectionColor = Color.DodgerBlue
                rtbOutput.AppendText("[ACTIVE] TRY:" & vbCrLf)
                rtbOutput.AppendText(" -> Attempting operation..." & vbCrLf)

                If cboOp.SelectedIndex = 0 Then
                    Dim result As Integer = 100 / 2
                    rtbOutput.AppendText(" -> Success: Result is " & result & vbCrLf & vbCrLf)

                ElseIf cboOp.SelectedIndex = 1 Then
                    Dim zero As Integer = 0
                    Dim result As Integer = 100 \ zero

                ElseIf cboOp.SelectedIndex = 2 Then
                    Dim dummyObj As Control = Nothing
                    Dim temp As String = dummyObj.Name
                End If

            Catch ex As DivideByZeroException
                rtbOutput.SelectionColor = Color.Orange
                rtbOutput.AppendText(vbCrLf & "[CAUGHT] CATCH (DivideByZero):" & vbCrLf)
                rtbOutput.AppendText(" -> " & ex.Message & vbCrLf & vbCrLf)

            Catch ex As NullReferenceException
                rtbOutput.SelectionColor = Color.Orange
                rtbOutput.AppendText(vbCrLf & "[CAUGHT] CATCH (NullReference):" & vbCrLf)
                rtbOutput.AppendText(" -> " & ex.Message & vbCrLf & vbCrLf)

            Catch ex As Exception
                rtbOutput.SelectionColor = Color.Red
                rtbOutput.AppendText(vbCrLf & "[CAUGHT] CATCH (Generic Exception):" & vbCrLf)
                rtbOutput.AppendText(" -> " & ex.Message & vbCrLf & vbCrLf)

            Finally
                rtbOutput.SelectionColor = Color.LimeGreen
                rtbOutput.AppendText("[ACTIVE] FINALLY:" & vbCrLf)
                rtbOutput.AppendText(" -> Cleaning up resources..." & vbCrLf)
                rtbOutput.AppendText(" -> Execution cycle completed.")
            End Try
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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•)\s+[^:\r\n]+:")
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