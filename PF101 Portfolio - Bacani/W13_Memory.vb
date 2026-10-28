Imports System.Text.RegularExpressions

Public Class W13_Memory

    Private dtBooks As New DataTable("Titles")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week13Selector.OpenChildForm(New W13_Sql())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Week13Selector.OpenChildForm(New W13_Visual())
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

    Private Sub W13_Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            FormatRichText(RichTextBox1)
            InitializeDataTable()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InitializeDataTable()
        Try
            dtBooks.Columns.Add("Title", GetType(String))
            dtBooks.Columns.Add("Type", GetType(String))
            dtBooks.Rows.Add("Persona 5 Artbook", "Art")
            dtBooks.Rows.Add("Advanced SQL", "Education")
            dtBooks.AcceptChanges()
            dgvData.DataSource = dtBooks
            LogAction("System", "DataTable 'Titles' initialized and loaded into memory.")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LogAction(action As String, message As String)
        Try
            rtbLog.Clear()
            rtbLog.SelectionColor = Color.DodgerBlue
            rtbLog.AppendText("[" & action & "]" & vbCrLf)
            rtbLog.SelectionColor = Color.White
            rtbLog.AppendText("-> ")
            rtbLog.SelectionColor = Color.LimeGreen
            rtbLog.AppendText(message)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim newDataRow As DataRow = dtBooks.NewRow()
            newDataRow("Title") = "New York"
            newDataRow("Type") = "Business"
            dtBooks.Rows.Add(newDataRow)
            LogAction("Rows.Add()", "NewRow added. RowState is now [Added]. Call AcceptChanges() to commit.")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If dgvData.SelectedRows.Count > 0 Then
                Dim selectedView As DataRowView = DirectCast(dgvData.SelectedRows(0).DataBoundItem, DataRowView)
                Dim editRow As DataRow = selectedView.Row
                editRow.BeginEdit()
                editRow("Title") = editRow("Title").ToString().ToUpper() & " (EDITED)"
                editRow.EndEdit()
                LogAction("BeginEdit() / EndEdit()", "Row data modified. RowState is now [Modified].")
            Else
                LogAction("Error", "Please select an entire row by clicking the left margin first.")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dgvData.SelectedRows.Count > 0 Then
                Dim selectedView As DataRowView = DirectCast(dgvData.SelectedRows(0).DataBoundItem, DataRowView)
                Dim delRow As DataRow = selectedView.Row
                delRow.Delete()
                LogAction("Row.Delete()", "Row marked for deletion. It is hidden but still in memory! Call AcceptChanges() to permanently delete it, or RejectChanges() to bring it back.")
            Else
                LogAction("Error", "Please select an entire row by clicking the left margin first.")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            dtBooks.AcceptChanges()
            LogAction("AcceptChanges()", "All memory states (Added, Modified, Deleted) have been permanently committed to the DataSet.")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try
            dtBooks.RejectChanges()
            LogAction("RejectChanges()", "All uncommitted changes have been rolled back. Deleted rows have been restored.")
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