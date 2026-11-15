Imports System.Drawing
Imports System.IO

Public Class FPinventory
    Private dtInventory As New DataTable()
    Private currentImagePath As String = String.Empty

    Private Sub FPinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        cmbCategory.SelectedIndex = 0

        ' Setup DataTable schema with Image and ImagePath columns
        dtInventory.Columns.Add("Photo", GetType(Image))
        dtInventory.Columns.Add("ItemName", GetType(String))
        dtInventory.Columns.Add("Category", GetType(String))
        dtInventory.Columns.Add("Price", GetType(Decimal))
        dtInventory.Columns.Add("Stock", GetType(Integer))
        dtInventory.Columns.Add("ImagePath", GetType(String))

        ' Sample placeholder items with generated badge thumbnails
        AddSampleRow("Big Mac Meal", "Favorites", 199D, 50, "BM")
        AddSampleRow("2-pc Chicken Joy", "Meals", 149D, 45, "CJ")
        AddSampleRow("Large Fries", "Favorites", 75D, 120, "FR")
        AddSampleRow("Coca-Cola Float", "Drinks", 55D, 60, "CF")
        AddSampleRow("Sundae Cone", "Desserts", 35D, 90, "SC")

        dgvInventory.DataSource = dtInventory

        ' Format columns cleanly
        If dgvInventory.Columns.Contains("Photo") Then
            Dim imgCol = DirectCast(dgvInventory.Columns("Photo"), DataGridViewImageColumn)
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.Width = 65
            imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        End If

        If dgvInventory.Columns.Contains("Price") Then
            dgvInventory.Columns("Price").DefaultCellStyle.Format = "₱#,##0.00"
        End If

        If dgvInventory.Columns.Contains("ImagePath") Then
            dgvInventory.Columns("ImagePath").Visible = False
        End If

        picPreview.Image = CreatePlaceholderBadge("NO IMG")
    End Sub

    Private Sub AddSampleRow(itemName As String, category As String, price As Decimal, stock As Integer, code As String)
        dtInventory.Rows.Add(CreatePlaceholderBadge(code), itemName, category, price, stock, String.Empty)
    End Sub

    Private Function CreatePlaceholderBadge(labelText As String) As Bitmap
        Dim bmp As New Bitmap(80, 80)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.FromArgb(42, 42, 42))
            Using pen As New Pen(Color.FromArgb(190, 20, 20), 2)
                g.DrawRectangle(pen, 1, 1, 77, 77)
            End Using
            Using sf As New StringFormat()
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
                Using fnt As New Font("Segoe UI", 11.0F, FontStyle.Bold)
                    g.DrawString(labelText, fnt, Brushes.White, New RectangleF(0, 0, 80, 80), sf)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Product Photo"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp"
            If ofd.ShowDialog() = DialogResult.OK Then
                currentImagePath = ofd.FileName
                Using fs As New FileStream(currentImagePath, FileMode.Open, FileAccess.Read)
                    picPreview.Image = Image.FromStream(fs)
                End Using
            End If
        End Using
    End Sub

    Private Sub btnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        currentImagePath = String.Empty
        picPreview.Image = CreatePlaceholderBadge("NO IMG")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtItemName.Text) Then
            MessageBox.Show("Please enter a product name.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim price As Decimal
        Dim stock As Integer
        If Not Decimal.TryParse(txtPrice.Text, price) OrElse Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("Please enter valid numeric values for Price and Stock.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim thumb As Image
        If Not String.IsNullOrEmpty(currentImagePath) AndAlso File.Exists(currentImagePath) Then
            Using fs As New FileStream(currentImagePath, FileMode.Open, FileAccess.Read)
                thumb = Image.FromStream(fs)
            End Using
        Else
            Dim initials As String = txtItemName.Text.Trim().Substring(0, Math.Min(2, txtItemName.Text.Trim().Length)).ToUpper()
            thumb = CreatePlaceholderBadge(initials)
        End If

        Dim categoryText As String = If(cmbCategory.SelectedItem IsNot Nothing, cmbCategory.SelectedItem.ToString(), "Favorites")
        dtInventory.Rows.Add(thumb, txtItemName.Text.Trim(), categoryText, price, stock, currentImagePath)

        ClearEditorFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product from the catalog first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim price As Decimal
        Dim stock As Integer
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse Not Decimal.TryParse(txtPrice.Text, price) OrElse Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("Please verify the product name, price, and stock values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRowView = TryCast(dgvInventory.SelectedRows(0).DataBoundItem, DataRowView)
        If selectedRowView IsNot Nothing Then
            Dim row = selectedRowView.Row
            row("ItemName") = txtItemName.Text.Trim()
            row("Category") = If(cmbCategory.SelectedItem IsNot Nothing, cmbCategory.SelectedItem.ToString(), "Favorites")
            row("Price") = price
            row("Stock") = stock
            row("ImagePath") = currentImagePath

            If Not String.IsNullOrEmpty(currentImagePath) AndAlso File.Exists(currentImagePath) Then
                Using fs As New FileStream(currentImagePath, FileMode.Open, FileAccess.Read)
                    row("Photo") = Image.FromStream(fs)
                End Using
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.SelectedRows.Count = 0 Then Exit Sub

        Dim selectedRowView = TryCast(dgvInventory.SelectedRows(0).DataBoundItem, DataRowView)
        If selectedRowView IsNot Nothing Then
            selectedRowView.Row.Delete()
            ClearEditorFields()
        End If
    End Sub

    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim selectedRowView = TryCast(dgvInventory.Rows(e.RowIndex).DataBoundItem, DataRowView)
        If selectedRowView IsNot Nothing Then
            Dim row = selectedRowView.Row
            txtItemName.Text = row("ItemName").ToString()
            cmbCategory.SelectedItem = row("Category").ToString()
            txtPrice.Text = Convert.ToDecimal(row("Price")).ToString("0.00")
            txtStock.Text = row("Stock").ToString()
            currentImagePath = row("ImagePath").ToString()

            If TypeOf row("Photo") Is Image Then
                picPreview.Image = DirectCast(row("Photo"), Image)
            Else
                picPreview.Image = CreatePlaceholderBadge("NO IMG")
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim().Replace("'", "''")
        If String.IsNullOrEmpty(keyword) Then
            dtInventory.DefaultView.RowFilter = String.Empty
        Else
            dtInventory.DefaultView.RowFilter = $"ItemName LIKE '%{keyword}%' OR Category LIKE '%{keyword}%'"
        End If
    End Sub

    Private Sub ClearEditorFields()
        txtItemName.Clear()
        txtPrice.Clear()
        txtStock.Clear()
        cmbCategory.SelectedIndex = 0
        currentImagePath = String.Empty
        picPreview.Image = CreatePlaceholderBadge("NO IMG")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New FPdashboard()
        dash.Show()
        Me.Close()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnBrowseImage.MouseEnter, btnClearImage.MouseEnter, btnAdd.MouseEnter, btnUpdate.MouseEnter, btnDelete.MouseEnter, btnBack.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowseImage.MouseLeave, btnClearImage.MouseLeave, btnAdd.MouseLeave, btnUpdate.MouseLeave, btnDelete.MouseLeave, btnBack.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class