<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPinventory
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        pnlEditor = New Panel()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        txtStock = New TextBox()
        lblStock = New Label()
        txtPrice = New TextBox()
        lblPrice = New Label()
        cmbCategory = New ComboBox()
        lblCategory = New Label()
        txtItemName = New TextBox()
        lblItem = New Label()
        btnClearImage = New Button()
        btnBrowseImage = New Button()
        picPreview = New PictureBox()
        lblEditorHeader = New Label()
        pnlGridContainer = New Panel()
        dgvInventory = New DataGridView()
        txtSearch = New TextBox()
        lblSearch = New Label()
        lblGridHeader = New Label()
        btnBack = New Button()
        pnlEditor.SuspendLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridContainer.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(25, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(331, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "INVENTORY & MENU MANAGER"
        ' 
        ' pnlEditor
        ' 
        pnlEditor.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlEditor.BorderStyle = BorderStyle.FixedSingle
        pnlEditor.Controls.Add(btnDelete)
        pnlEditor.Controls.Add(btnUpdate)
        pnlEditor.Controls.Add(btnAdd)
        pnlEditor.Controls.Add(txtStock)
        pnlEditor.Controls.Add(lblStock)
        pnlEditor.Controls.Add(txtPrice)
        pnlEditor.Controls.Add(lblPrice)
        pnlEditor.Controls.Add(cmbCategory)
        pnlEditor.Controls.Add(lblCategory)
        pnlEditor.Controls.Add(txtItemName)
        pnlEditor.Controls.Add(lblItem)
        pnlEditor.Controls.Add(btnClearImage)
        pnlEditor.Controls.Add(btnBrowseImage)
        pnlEditor.Controls.Add(picPreview)
        pnlEditor.Controls.Add(lblEditorHeader)
        pnlEditor.Location = New Point(25, 60)
        pnlEditor.Name = "pnlEditor"
        pnlEditor.Size = New Size(330, 420)
        pnlEditor.TabIndex = 2
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnDelete.FlatAppearance.BorderSize = 2
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(168, 374)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(142, 34)
        btnDelete.TabIndex = 14
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnUpdate.FlatAppearance.BorderSize = 2
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(15, 374)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(142, 34)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnAdd.FlatAppearance.BorderSize = 2
        btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(15, 332)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(295, 34)
        btnAdd.TabIndex = 12
        btnAdd.Text = "+ ADD NEW PRODUCT"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        txtStock.BorderStyle = BorderStyle.FixedSingle
        txtStock.Font = New Font("Segoe UI", 9.5F)
        txtStock.ForeColor = Color.White
        txtStock.Location = New Point(172, 288)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(138, 24)
        txtStock.TabIndex = 11
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(172, 268)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(72, 15)
        lblStock.TabIndex = 10
        lblStock.Text = "Stock Level"
        ' 
        ' txtPrice
        ' 
        txtPrice.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        txtPrice.BorderStyle = BorderStyle.FixedSingle
        txtPrice.Font = New Font("Segoe UI", 9.5F)
        txtPrice.ForeColor = Color.White
        txtPrice.Location = New Point(15, 288)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(138, 24)
        txtPrice.TabIndex = 9
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPrice.ForeColor = Color.White
        lblPrice.Location = New Point(15, 268)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(54, 15)
        lblPrice.TabIndex = 8
        lblPrice.Text = "Price (₱)"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FlatStyle = FlatStyle.Flat
        cmbCategory.Font = New Font("Segoe UI", 9.5F)
        cmbCategory.ForeColor = Color.White
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Favorites", "Meals", "Drinks", "Desserts"})
        cmbCategory.Location = New Point(15, 234)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(295, 25)
        cmbCategory.TabIndex = 7
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCategory.ForeColor = Color.White
        lblCategory.Location = New Point(15, 214)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(57, 15)
        lblCategory.TabIndex = 6
        lblCategory.Text = "Category"
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        txtItemName.BorderStyle = BorderStyle.FixedSingle
        txtItemName.Font = New Font("Segoe UI", 9.5F)
        txtItemName.ForeColor = Color.White
        txtItemName.Location = New Point(15, 180)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(295, 24)
        txtItemName.TabIndex = 5
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblItem.ForeColor = Color.White
        lblItem.Location = New Point(15, 160)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(87, 15)
        lblItem.TabIndex = 4
        lblItem.Text = "Product Name"
        ' 
        ' btnClearImage
        ' 
        btnClearImage.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClearImage.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnClearImage.FlatAppearance.BorderSize = 2
        btnClearImage.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClearImage.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClearImage.FlatStyle = FlatStyle.Flat
        btnClearImage.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnClearImage.ForeColor = Color.White
        btnClearImage.Location = New Point(150, 98)
        btnClearImage.Name = "btnClearImage"
        btnClearImage.Size = New Size(160, 34)
        btnClearImage.TabIndex = 3
        btnClearImage.Text = "CLEAR PHOTO"
        btnClearImage.UseVisualStyleBackColor = False
        ' 
        ' btnBrowseImage
        ' 
        btnBrowseImage.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBrowseImage.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnBrowseImage.FlatAppearance.BorderSize = 2
        btnBrowseImage.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBrowseImage.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBrowseImage.FlatStyle = FlatStyle.Flat
        btnBrowseImage.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnBrowseImage.ForeColor = Color.White
        btnBrowseImage.Location = New Point(150, 52)
        btnBrowseImage.Name = "btnBrowseImage"
        btnBrowseImage.Size = New Size(160, 34)
        btnBrowseImage.TabIndex = 2
        btnBrowseImage.Text = "BROWSE PHOTO"
        btnBrowseImage.UseVisualStyleBackColor = False
        ' 
        ' picPreview
        ' 
        picPreview.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        picPreview.BorderStyle = BorderStyle.FixedSingle
        picPreview.Location = New Point(15, 42)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(120, 105)
        picPreview.SizeMode = PictureBoxSizeMode.Zoom
        picPreview.TabIndex = 1
        picPreview.TabStop = False
        ' 
        ' lblEditorHeader
        ' 
        lblEditorHeader.AutoSize = True
        lblEditorHeader.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblEditorHeader.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        lblEditorHeader.Location = New Point(15, 12)
        lblEditorHeader.Name = "lblEditorHeader"
        lblEditorHeader.Size = New Size(142, 20)
        lblEditorHeader.TabIndex = 0
        lblEditorHeader.Text = "PRODUCT DETAILS"
        ' 
        ' pnlGridContainer
        ' 
        pnlGridContainer.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlGridContainer.BorderStyle = BorderStyle.FixedSingle
        pnlGridContainer.Controls.Add(dgvInventory)
        pnlGridContainer.Controls.Add(txtSearch)
        pnlGridContainer.Controls.Add(lblSearch)
        pnlGridContainer.Controls.Add(lblGridHeader)
        pnlGridContainer.Location = New Point(370, 60)
        pnlGridContainer.Name = "pnlGridContainer"
        pnlGridContainer.Size = New Size(545, 420)
        pnlGridContainer.TabIndex = 3
        ' 
        ' dgvInventory
        ' 
        dgvInventory.AllowUserToAddRows = False
        dgvInventory.AllowUserToDeleteRows = False
        dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInventory.BackgroundColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        dgvInventory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInventory.ColumnHeadersHeight = 32
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvInventory.DefaultCellStyle = DataGridViewCellStyle2
        dgvInventory.EnableHeadersVisualStyles = False
        dgvInventory.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        dgvInventory.Location = New Point(15, 45)
        dgvInventory.MultiSelect = False
        dgvInventory.Name = "dgvInventory"
        dgvInventory.ReadOnly = True
        dgvInventory.RowHeadersVisible = False
        dgvInventory.RowTemplate.Height = 48
        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInventory.Size = New Size(513, 360)
        dgvInventory.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.0F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(318, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(210, 23)
        txtSearch.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.DarkGray
        lblSearch.Location = New Point(265, 14)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(48, 15)
        lblSearch.TabIndex = 1
        lblSearch.Text = "Search:"
        ' 
        ' lblGridHeader
        ' 
        lblGridHeader.AutoSize = True
        lblGridHeader.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblGridHeader.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        lblGridHeader.Location = New Point(15, 12)
        lblGridHeader.Name = "lblGridHeader"
        lblGridHeader.Size = New Size(150, 20)
        lblGridHeader.TabIndex = 0
        lblGridHeader.Text = "CURRENT CATALOG"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(795, 14)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(120, 34)
        btnBack.TabIndex = 1
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FPinventory
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(940, 500)
        Controls.Add(pnlGridContainer)
        Controls.Add(pnlEditor)
        Controls.Add(btnBack)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPinventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPinventory"
        pnlEditor.ResumeLayout(False)
        pnlEditor.PerformLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        pnlGridContainer.ResumeLayout(False)
        pnlGridContainer.PerformLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlEditor As Panel
    Friend WithEvents lblEditorHeader As Label
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents btnClearImage As Button
    Friend WithEvents lblItem As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents pnlGridContainer As Panel
    Friend WithEvents lblGridHeader As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvInventory As DataGridView
End Class