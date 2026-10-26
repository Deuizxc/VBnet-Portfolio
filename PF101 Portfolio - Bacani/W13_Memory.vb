Public Class W13_Memory
    ' In-Memory Database Table
    Private dtBooks As New DataTable("Titles")

    ' --- MDI NAVIGATION ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week13Selector.OpenChildForm(New W13_Sql())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week13Selector.OpenChildForm(New W13_Visual())
    End Sub

    ' --- HOVER EFFECTS ---
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    ' --- FORM LOAD ---
    Private Sub W13_Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        LoadDocumentationText()
        InitializeDataTable()
    End Sub

    Private Sub LoadDocumentationText()

    End Sub

    Private Sub InitializeDataTable()
        ' Matches Week 13 Presentation Example
        dtBooks.Columns.Add("Title", GetType(String))
        dtBooks.Columns.Add("Type", GetType(String))

        dtBooks.Rows.Add("Persona 5 Artbook", "Art")
        dtBooks.Rows.Add("Advanced SQL", "Education")
        dtBooks.AcceptChanges() ' Baseline state

        dgvData.DataSource = dtBooks
        LogAction("System", "DataTable 'Titles' initialized and loaded into memory.")
    End Sub

    Private Sub LogAction(action As String, message As String)
        rtbLog.Clear()
        rtbLog.SelectionColor = Color.DodgerBlue
        rtbLog.AppendText("[" & action & "]" & vbCrLf)
        rtbLog.SelectionColor = Color.White
        rtbLog.AppendText("-> ")
        rtbLog.SelectionColor = Color.LimeGreen
        rtbLog.AppendText(message)
    End Sub

    ' --- DATA OPERATIONS ---

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' 1. Instantiate DataRow using NewRow method
        Dim newDataRow As DataRow = dtBooks.NewRow()
        ' 2. Populate columns
        newDataRow("Title") = "New York"
        newDataRow("Type") = "Business"
        ' 3. Call Add method
        dtBooks.Rows.Add(newDataRow)

        LogAction("Rows.Add()", "NewRow added. RowState is now [Added]. Call AcceptChanges() to commit.")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvData.SelectedRows.Count > 0 Then
            ' Get the actual underlying DataRow from the DataGridView selection
            Dim selectedView As DataRowView = DirectCast(dgvData.SelectedRows(0).DataBoundItem, DataRowView)
            Dim editRow As DataRow = selectedView.Row

            ' 1. Call BeginEdit
            editRow.BeginEdit()
            ' 2. Change Data
            editRow("Title") = editRow("Title").ToString().ToUpper() & " (EDITED)"
            ' 3. Call EndEdit
            editRow.EndEdit()

            LogAction("BeginEdit() / EndEdit()", "Row data modified. RowState is now [Modified].")
        Else
            LogAction("Error", "Please select an entire row by clicking the left margin first.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvData.SelectedRows.Count > 0 Then
            Dim selectedView As DataRowView = DirectCast(dgvData.SelectedRows(0).DataBoundItem, DataRowView)
            Dim delRow As DataRow = selectedView.Row

            ' Delete method only marks the row for deletion
            delRow.Delete()

            LogAction("Row.Delete()", "Row marked for deletion. It is hidden but still in memory! Call AcceptChanges() to permanently delete it, or RejectChanges() to bring it back.")
        Else
            LogAction("Error", "Please select an entire row by clicking the left margin first.")
        End If
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        dtBooks.AcceptChanges()
        LogAction("AcceptChanges()", "All memory states (Added, Modified, Deleted) have been permanently committed to the DataSet.")
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        dtBooks.RejectChanges()
        LogAction("RejectChanges()", "All uncommitted changes have been rolled back. Deleted rows have been restored.")
    End Sub
End Class