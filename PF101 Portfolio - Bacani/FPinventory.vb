Imports System.Drawing
Imports System.Data
Imports System.IO

Public Class FPinventory
    Private Const LowStockThreshold As Integer = 5
    Private dtInventory As New DataTable()
    Private currentPhoto As Byte()
    Private selectedProductId As Long
    Private selectedStock As Integer

    Private Sub FPinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        cmbCategory.SelectedIndex = 0

        dtInventory.Columns.Add("Photo", GetType(Image))
        dtInventory.Columns.Add("ItemName", GetType(String))
        dtInventory.Columns.Add("Category", GetType(String))
        dtInventory.Columns.Add("Price", GetType(Decimal))
        dtInventory.Columns.Add("Stock", GetType(Integer))
        dtInventory.Columns.Add("ProductId", GetType(Long))
        dtInventory.Columns.Add("PhotoBytes", GetType(Byte()))

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

        dgvInventory.Columns("ProductId").Visible = False
        dgvInventory.Columns("PhotoBytes").Visible = False
        ReloadInventory()
    End Sub

    Private Sub ReloadInventory()
        Try
            Dim products = KioskDatabase.GetProducts()
            ClearEditorFields()
            For Each row As DataRow In dtInventory.Rows
                DirectCast(row("Photo"), Image).Dispose()
            Next
            dtInventory.Clear()

            For Each product In products
                Dim initials = product.Name.Substring(0, Math.Min(2, product.Name.Length)).ToUpperInvariant()
                Dim picture = If(product.Photo Is Nothing, CreatePlaceholderBadge(initials), LoadPhoto(product.Photo))
                dtInventory.Rows.Add(picture, product.Name, product.Category, product.Price,
                                     product.Stock, product.Id, If(CType(product.Photo, Object), DBNull.Value))
            Next
            Dim lowStockCount As Integer = dtInventory.Select($"Stock <= {LowStockThreshold}").Length
            Dim productLabel As String = If(lowStockCount = 1, "product", "products")
            lblStockAlert.Text = $"{lowStockCount} {productLabel} at {LowStockThreshold} units or fewer"
            lblStockAlert.ForeColor = If(lowStockCount > 0, Color.Khaki, Color.Gainsboro)
            dgvInventory.ClearSelection()
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The product catalog could not be loaded.", ex)
        End Try
    End Sub

    Private Function LoadPhoto(data As Byte()) As Image
        Using stream As New MemoryStream(data),
              original = Image.FromStream(stream)
            Return New Bitmap(original)
        End Using
    End Function

    Private Sub SetPreview(picture As Image)
        Dim previous = picPreview.Image
        picPreview.Image = picture
        If previous IsNot Nothing Then previous.Dispose()
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
        Using dialog As New OpenFileDialog()
            dialog.Title = "Select Product Photo"
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            Try
                Dim data = File.ReadAllBytes(dialog.FileName)
                SetPreview(LoadPhoto(data))
                currentPhoto = data
            Catch ex As Exception
                KioskDatabase.ShowDatabaseError(Me, "The photo could not be opened.", ex)
            End Try
        End Using
    End Sub

    Private Sub btnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        currentPhoto = Nothing
        SetPreview(CreatePlaceholderBadge("NO IMG"))
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SaveProduct(0)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedProductId = 0 Then
            MessageBox.Show(Me, "Select a product from the catalog first.")
            Return
        End If
        SaveProduct(selectedProductId)
    End Sub

    Private Sub SaveProduct(productId As Long)
        Dim price As Decimal
        Dim stock As Integer
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse cmbCategory.SelectedIndex < 0 OrElse
            Not Decimal.TryParse(txtPrice.Text, price) OrElse price < 0D OrElse
            price > Long.MaxValue / 100D OrElse Decimal.Round(price, 2) <> price OrElse
            Not Integer.TryParse(txtStock.Text, stock) OrElse stock < 0 Then
            MessageBox.Show(Me, "Enter a product name, category, nonnegative price with up to two decimals, and whole-number stock.")
            Return
        End If

        Try
            KioskDatabase.SaveProduct(New KioskDatabase.ProductRecord With {
                .Id = productId, .Name = txtItemName.Text.Trim(),
                .Category = cmbCategory.SelectedItem.ToString(), .Price = price,
                .Stock = stock, .Photo = currentPhoto
            }, selectedStock)
            ReloadInventory()
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The product could not be saved.", ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedProductId = 0 Then Return
        If MessageBox.Show(Me, "Remove this product from the menu?", "Remove Product",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            KioskDatabase.RemoveProduct(selectedProductId)
            ReloadInventory()
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The product could not be removed.", ex)
        End Try
    End Sub

    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex < 0 Then Return
        Dim item = TryCast(dgvInventory.Rows(e.RowIndex).DataBoundItem, DataRowView)
        If item Is Nothing Then Return

        Dim row = item.Row
        selectedProductId = CLng(row("ProductId"))
        selectedStock = CInt(row("Stock"))
        txtItemName.Text = CStr(row("ItemName"))
        cmbCategory.SelectedItem = CStr(row("Category"))
        txtPrice.Text = CDec(row("Price")).ToString("0.00")
        txtStock.Text = selectedStock.ToString()
        currentPhoto = If(row.IsNull("PhotoBytes"), Nothing, DirectCast(row("PhotoBytes"), Byte()))
        SetPreview(New Bitmap(DirectCast(row("Photo"), Image)))
    End Sub

    Private Sub InventoryFilterChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, chkLowStockOnly.CheckedChanged
        If Not dtInventory.Columns.Contains("Stock") Then Return

        Dim keyword As String = System.Text.RegularExpressions.Regex.Replace(txtSearch.Text.Trim(), "[\[\]\*%]", "[$0]").Replace("'", "''")
        Dim searchFilter As String = ""
        If keyword.Length > 0 Then
            searchFilter = $"(ItemName LIKE '%{keyword}%' OR Category LIKE '%{keyword}%')"
        End If

        If chkLowStockOnly.Checked Then
            Dim lowStockFilter As String = $"Stock <= {LowStockThreshold}"
            searchFilter = If(searchFilter.Length = 0, lowStockFilter, $"{searchFilter} AND {lowStockFilter}")
        End If

        dtInventory.DefaultView.RowFilter = searchFilter
        If selectedProductId = 0 Then Return

        For Each product As DataRowView In dtInventory.DefaultView
            If CLng(product("ProductId")) = selectedProductId Then Return
        Next

        dgvInventory.ClearSelection()
        ClearEditorFields()
    End Sub

    Private Sub dgvInventory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvInventory.CellFormatting
        If e.ColumnIndex < 0 OrElse dgvInventory.Columns(e.ColumnIndex).Name <> "Stock" OrElse
            Not TypeOf e.Value Is Integer Then Return

        Dim stock As Integer = CInt(e.Value)
        If stock > LowStockThreshold Then Return

        e.Value = If(stock = 0, "0 · Out of stock", $"{stock} · Low")
        e.FormattingApplied = True
        e.CellStyle.BackColor = Color.FromArgb(68, 47, 22)
        e.CellStyle.ForeColor = Color.Khaki
        e.CellStyle.SelectionBackColor = Color.FromArgb(102, 68, 24)
        e.CellStyle.SelectionForeColor = Color.LemonChiffon
    End Sub

    Private Sub ClearEditorFields()
        txtItemName.Clear()
        txtPrice.Clear()
        txtStock.Clear()
        cmbCategory.SelectedIndex = 0
        selectedProductId = 0
        selectedStock = 0
        currentPhoto = Nothing
        SetPreview(CreatePlaceholderBadge("NO IMG"))
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
