Imports System.Text.RegularExpressions

Public Class W13_Visual

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week13Selector.OpenChildForm(New W13_Memory())
        Catch ex As Exception
        End Try
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

    Private Sub W13_Visual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            FormatRichText(RichTextBox1)
            UpdateSQLPane()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles chkID.CheckedChanged, chkFirst.CheckedChanged, chkLast.CheckedChanged, chkSalary.CheckedChanged
        Try
            UpdateSQLPane()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateSQLPane()
        Try
            Dim cols As New List(Of String)
            If chkID.Checked Then cols.Add("ID")
            If chkFirst.Checked Then cols.Add("First_Name")
            If chkLast.Checked Then cols.Add("Last_Name")
            If chkSalary.Checked Then cols.Add("Salary")

            Dim selectString As String = If(cols.Count > 0, String.Join(", ", cols), "*")
            lblSqlPane.Text = "SELECT " & selectString & vbCrLf & "FROM SalesStaff"

            rtbResults.Clear()
            rtbResults.Text = "> Waiting for Command execution..."
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Try
            rtbResults.Clear()
            rtbResults.SelectionColor = Color.DodgerBlue
            rtbResults.AppendText("[Command] Executing query..." & vbCrLf)
            rtbResults.SelectionColor = Color.Orange
            rtbResults.AppendText("[DataReader] Opening forward-only stream..." & vbCrLf & vbCrLf)
            rtbResults.SelectionColor = Color.White

            Dim mockData As New List(Of Dictionary(Of String, String)) From {
                New Dictionary(Of String, String) From {{"ID", "104"}, {"First_Name", "Adrian"}, {"Last_Name", "Adams"}, {"Salary", "$35,007"}},
                New Dictionary(Of String, String) From {{"ID", "114"}, {"First_Name", "Fay"}, {"Last_Name", "Franklin"}, {"Salary", "$56,001"}},
                New Dictionary(Of String, String) From {{"ID", "115"}, {"First_Name", "Adiel"}, {"Last_Name", "Franklin"}, {"Salary", "$41,000"}}
            }

            Dim rowCount As Integer = 1
            For Each row In mockData
                rtbResults.SelectionColor = Color.LimeGreen
                rtbResults.AppendText("-> Read() Row " & rowCount & ": ")
                rtbResults.SelectionColor = Color.White

                Dim rowOutput As New List(Of String)
                If chkID.Checked Then rowOutput.Add(row("ID"))
                If chkFirst.Checked Then rowOutput.Add(row("First_Name"))
                If chkLast.Checked Then rowOutput.Add(row("Last_Name"))
                If chkSalary.Checked Then rowOutput.Add(row("Salary"))

                If rowOutput.Count = 0 Then
                    rowOutput.Add(row("ID") & " | " & row("First_Name") & " | " & row("Last_Name") & " | " & row("Salary"))
                End If

                rtbResults.AppendText(String.Join(", ", rowOutput) & vbCrLf)
                rowCount += 1
            Next

            rtbResults.SelectionColor = Color.DodgerBlue
            rtbResults.AppendText(vbCrLf & "[DataReader] End of stream reached. Closed.")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExecute_MouseEnter(sender As Object, e As EventArgs) Handles btnExecute.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub btnExecute_MouseLeave(sender As Object, e As EventArgs) Handles btnExecute.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•|\-)\s*[^:\r\n]+:")
            Dim startPos2 As Integer = 0
            For Each m As Match In mc2
                Dim searchStr As String = m.Value.Replace(vbCr, "").Replace(vbLf, "")
                Dim pos As Integer = rtb.Find(searchStr, startPos2, RichTextBoxFinds.None)
                If pos <> -1 Then
                    rtb.Select(pos, searchStr.Length)
                    rtb.SelectionFont = boldFont
                    rtb.SelectionColor = redColor
                    startPos2 = pos + searchStr.Length
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