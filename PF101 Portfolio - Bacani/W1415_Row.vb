Imports System.Text.RegularExpressions

Public Class W1415_Row

    Private dtMock As New DataTable("Students")
    Private currentRowIndex As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week14_15Selector.OpenChildForm(New W1415_Dataset())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Week14_15Selector.OpenChildForm(New W1415_Database())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter
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

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Try
            Dim btn = DirectCast(sender, Button)
            btn.Top += 3
            btn.Cursor = Cursors.Default
            If btn.Name = "Button1" Then btn.ForeColor = Color.Black
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W1415_Row_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()

            dtMock.Columns.Add("ID", GetType(Integer))
            dtMock.Columns.Add("Name", GetType(String))
            dtMock.Columns.Add("Age", GetType(Integer))

            dtMock.Rows.Add(1, "Ryuji", 17)
            dtMock.Rows.Add(2, "Makoto", 18)

            Dim nullRow As DataRow = dtMock.NewRow()
            nullRow("ID") = 3
            nullRow("Name") = "Lavenza"
            nullRow("Age") = DBNull.Value
            dtMock.Rows.Add(nullRow)

            UpdateRowDisplay()
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateRowDisplay()
        Try
            Dim row As DataRow = dtMock.Rows(currentRowIndex)
            Dim ageDisplay As String = If(row.IsNull("Age"), "NULL", row("Age").ToString())

            lblRowData.Text = $"[Row {currentRowIndex}] ID: {row("ID")} | Name: {row("Name")} | Age: {ageDisplay}"

            btnPrev.Enabled = (currentRowIndex > 0)
            btnNext.Enabled = (currentRowIndex < dtMock.Rows.Count - 1)
            rtbTerminal.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Try
            If currentRowIndex > 0 Then
                currentRowIndex -= 1
                UpdateRowDisplay()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            If currentRowIndex < dtMock.Rows.Count - 1 Then
                currentRowIndex += 1
                UpdateRowDisplay()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Try
            rtbTerminal.Clear()

            Dim row As DataRow = dtMock.Rows(currentRowIndex)

            rtbTerminal.SelectionColor = Color.DodgerBlue
            rtbTerminal.AppendText($"Evaluating: Is {row("Name")}'s Age >= 18?" & vbCrLf & vbCrLf)

            If row.IsNull("Age") Then
                rtbTerminal.SelectionColor = Color.LimeGreen
                rtbTerminal.AppendText("Result: UNKNOWN" & vbCrLf & vbCrLf)
                rtbTerminal.SelectionColor = Color.LightGray
                rtbTerminal.AppendText("Because the age is NULL, the relational database cannot determine if it is >= 18. It evaluates to neither True nor False.")
            Else
                Dim age As Integer = Convert.ToInt32(row("Age"))
                rtbTerminal.SelectionColor = Color.White
                If age >= 18 Then
                    rtbTerminal.AppendText("Result: TRUE" & vbCrLf & vbCrLf)
                    rtbTerminal.SelectionColor = Color.LightGray
                    rtbTerminal.AppendText($"{row("Name")} is 18 or older.")
                Else
                    rtbTerminal.AppendText("Result: FALSE" & vbCrLf & vbCrLf)
                    rtbTerminal.SelectionColor = Color.LightGray
                    rtbTerminal.AppendText($"{row("Name")} is under 18.")
                End If
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