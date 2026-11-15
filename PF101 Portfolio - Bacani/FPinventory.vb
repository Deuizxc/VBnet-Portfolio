Public Class FPinventory
    Private dtInventory As New DataTable()

    Private Sub FPinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        dtInventory.Columns.Add("ItemName", GetType(String))
        dtInventory.Columns.Add("Price", GetType(Decimal))
        dtInventory.Columns.Add("Stock", GetType(Integer))

        dtInventory.Rows.Add("Big Mac Meal", 199D, 50)
        dtInventory.Rows.Add("Cheeseburger", 89D, 80)
        dtInventory.Rows.Add("Large Fries", 75D, 120)
        dtInventory.Rows.Add("Coca-Cola Float", 55D, 60)

        dgvInventory.DataSource = dtInventory
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtItemName.Text) Then Exit Sub
        Dim price As Decimal, stock As Integer
        If Decimal.TryParse(txtPrice.Text, price) And Integer.TryParse(txtStock.Text, stock) Then
            dtInventory.Rows.Add(txtItemName.Text, price, stock)
            txtItemName.Clear()
            txtPrice.Clear()
            txtStock.Clear()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            Dim idx = dgvInventory.SelectedRows(0).Index
            dtInventory.Rows(idx)("ItemName") = txtItemName.Text
            dtInventory.Rows(idx)("Price") = Convert.ToDecimal(txtPrice.Text)
            dtInventory.Rows(idx)("Stock") = Convert.ToInt32(txtStock.Text)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            dgvInventory.Rows.RemoveAt(dgvInventory.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvInventory.Rows(e.RowIndex)
            txtItemName.Text = row.Cells("ItemName").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtStock.Text = row.Cells("Stock").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New FPdashboard()
        dash.Show()
        Me.Close()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter, btnUpdate.MouseEnter, btnDelete.MouseEnter, btnBack.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave, btnUpdate.MouseLeave, btnDelete.MouseLeave, btnBack.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class