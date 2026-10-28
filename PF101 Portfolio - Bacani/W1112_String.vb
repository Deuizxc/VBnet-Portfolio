Imports System.Text.RegularExpressions

Public Class W1112_String
    Private Sub W1112_String_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week11_12Selector.OpenChildForm(New W1112_Classes())
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

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter
        Try
            Dim btn = DirectCast(sender, Button)
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent
            btn.Top -= 3
            btn.Cursor = Cursors.Hand
            If btn.Name = "Button1" Then btn.ForeColor = Color.Red
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave
        Try
            Dim btn = DirectCast(sender, Button)
            btn.Top += 3
            btn.Cursor = Cursors.Default
            If btn.Name = "Button1" Then btn.ForeColor = Color.Black
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateOutput(title As String, result As String)
        Try
            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.DodgerBlue
            rtbOutput.AppendText("[" & title & "]" & vbCrLf)
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("Result: ")
            rtbOutput.SelectionColor = Color.LimeGreen
            rtbOutput.AppendText(result)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUCase_Click(sender As Object, e As EventArgs) Handles btnUCase.Click
        Try
            UpdateOutput("UCase()", UCase(txtInput.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        Try
            Dim rawStr As String = "   " & txtInput.Text & "   "
            UpdateOutput("Trim()", Trim(rawStr))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Try
            UpdateOutput("StrReverse()", StrReverse(txtInput.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCurrency_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        Try
            Dim val As Double = Convert.ToDouble(txtInput.Text.Trim())
            UpdateOutput("FormatCurrency()", FormatCurrency(val))
        Catch ex As Exception
            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.Red
            rtbOutput.AppendText("[ERROR]" & vbCrLf & "Input must be numeric to format as currency.")
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

            Dim kw As String = "\b(Class|Sub|Function|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|ByVal|ByRef|Step|Inherits|MustInherit|MyBase|Try|Catch|Finally|Exception|UCase|Trim|StrReverse|FormatCurrency)\b"
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