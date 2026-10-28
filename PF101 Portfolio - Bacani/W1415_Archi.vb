Imports System.Text.RegularExpressions

Public Class W1415_Archi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Week14_15Selector.OpenChildForm(New W1415_Dataset())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button7.MouseEnter
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

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button7.MouseLeave
        Try
            Dim btn = DirectCast(sender, Button)
            btn.Top += 3
            btn.Cursor = Cursors.Default
            If btn.Name = "Button1" Then btn.ForeColor = Color.Black
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W1415_Archi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            rbApproach2.Checked = True
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        Try
            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.DodgerBlue
            rtbOutput.AppendText("[Builder] Generating OrderSummary..." & vbCrLf & vbCrLf)

            If rbApproach1.Checked Then
                rtbOutput.SelectionColor = Color.White
                rtbOutput.AppendText("class OrderSummary {" & vbCrLf)
                rtbOutput.AppendText("  public Order obOrder = {" & vbCrLf)
                rtbOutput.AppendText("    OrderNum: 88472," & vbCrLf)
                rtbOutput.AppendText("    Lines: 4," & vbCrLf)
                rtbOutput.SelectionColor = Color.Red
                rtbOutput.AppendText("    DB_Hash: ""0x8F9A""," & vbCrLf)
                rtbOutput.AppendText("    SysFlags: 00110" & vbCrLf)
                rtbOutput.SelectionColor = Color.White
                rtbOutput.AppendText("  }" & vbCrLf)
                rtbOutput.AppendText("}" & vbCrLf & vbCrLf)
                rtbOutput.SelectionColor = Color.Red
                rtbOutput.AppendText("WARNING: Backend data leaked!")
            ElseIf rbApproach2.Checked Then
                rtbOutput.SelectionColor = Color.White
                rtbOutput.AppendText("class OrderSummary {" & vbCrLf)
                rtbOutput.AppendText("  public int OrderNum = 88472;" & vbCrLf)
                rtbOutput.AppendText("  public int Lines = 4;" & vbCrLf)
                rtbOutput.AppendText("}" & vbCrLf & vbCrLf)
                rtbOutput.SelectionColor = Color.LimeGreen
                rtbOutput.AppendText("SUCCESS: Model is clean & secure.")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatRichText(rtb As RichTextBox)
        Try
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
            rtb.SuspendLayout()

            rtb.SelectAll()
            rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Regular)
            If rtb.BackColor = Color.Black Then
                rtb.SelectionColor = Color.White
            Else
                rtb.SelectionColor = Color.FromArgb(40, 40, 40)
            End If

            Dim redColor As Color = Color.FromArgb(190, 20, 20)
            Dim blueColor As Color = Color.FromArgb(0, 70, 190)
            Dim titleFont As New Font("Segoe UI", 13.0F, FontStyle.Bold)
            Dim boldFont As New Font("Segoe UI", 11.25F, FontStyle.Bold)

            Dim mc1 As MatchCollection = Regex.Matches(rtb.Text, "\[.*?\]")
            Dim startPos1 As Integer = 0
            For Each m As Match In mc1
                Dim pos As Integer = rtb.Find(m.Value, startPos1, RichTextBoxFinds.None)
                If pos <> -1 Then
                    rtb.Select(pos, m.Value.Length)
                    rtb.SelectionFont = titleFont
                    rtb.SelectionColor = redColor
                    startPos1 = pos + m.Value.Length
                End If
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•|\-)\s*([^\r\n]+)")
            Dim startPos2 As Integer = 0
            For Each m As Match In mc2
                Dim fullLine As String = m.Groups(1).Value.Trim()
                Dim parts() As String = fullLine.Split(New Char() {":"c}, 2)

                Dim headerText As String = ""
                If parts.Length > 1 Then
                    headerText = m.Value.Substring(0, m.Value.IndexOf(parts(0)) + parts(0).Length + 1)
                Else
                    headerText = m.Value
                End If

                Dim pos As Integer = rtb.Find(headerText, startPos2, RichTextBoxFinds.None)
                If pos <> -1 Then
                    rtb.Select(pos, headerText.Length)
                    rtb.SelectionFont = boldFont
                    rtb.SelectionColor = redColor
                    startPos2 = pos + headerText.Length
                End If
            Next

            Dim kw() As String = {"Class", "Sub", "Function", "End", "Private", "Public", "Handles", "Dim", "As", "String", "Integer", "Double", "Decimal", "If", "ElseIf", "Else", "Then", "Return", "True", "False", "Const", "Select", "Case", "Mod", "Do", "While", "Until", "Loop", "For", "Next", "To", "Boolean", "Char", "Byte", "Long", "Short", "New", "ByVal", "ByRef", "Step", "Inherits", "MustInherit", "MyBase", "Try", "Catch", "Finally", "Exception", "UCase", "Trim", "StrReverse", "FormatCurrency", "Imports", "Module", "using", "class", "static", "void", "string", "import", "public", "main", "SELECT", "FROM", "WHERE", "ORDER", "BY", "DESC", "AS"}
            For Each word In kw
                Dim pos As Integer = 0
                Do
                    pos = rtb.Find(word, pos, RichTextBoxFinds.WholeWord Or RichTextBoxFinds.MatchCase)
                    If pos <> -1 Then
                        rtb.Select(pos, word.Length)
                        If rtb.SelectionColor <> redColor Then
                            rtb.SelectionFont = boldFont
                            rtb.SelectionColor = blueColor
                        End If
                        pos += word.Length
                    End If
                Loop While pos <> -1
            Next

            rtb.Select(0, 0)
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub
End Class