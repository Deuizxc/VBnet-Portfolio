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
        dgvInventory = New DataGridView()
        lblTitle = New Label()
        txtItemName = New TextBox()
        txtPrice = New TextBox()
        txtStock = New TextBox()
        lblItem = New Label()
        lblPrice = New Label()
        lblStock = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnBack = New Button()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvInventory
        ' 
        dgvInventory.AllowUserToAddRows = False
        dgvInventory.AllowUserToDeleteRows = False
        dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInventory.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvInventory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvInventory.DefaultCellStyle = DataGridViewCellStyle2
        dgvInventory.Location = New Point(300, 70)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.ReadOnly = True
        dgvInventory.RowHeadersVisible = False
        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInventory.Size = New Size(470, 310)
        dgvInventory.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(300, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(230, 25)
        lblTitle.TabIndex = 1
        lblTitle.Text = "INVENTORY MANAGEMENT"
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtItemName.ForeColor = Color.White
        txtItemName.Location = New Point(30, 95)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(220, 23)
        txtItemName.TabIndex = 2
        ' 
        ' txtPrice
        ' 
        txtPrice.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtPrice.ForeColor = Color.White
        txtPrice.Location = New Point(30, 155)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(220, 23)
        txtPrice.TabIndex = 3
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtStock.ForeColor = Color.White
        txtStock.Location = New Point(30, 215)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(220, 23)
        txtStock.TabIndex = 4
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.ForeColor = Color.White
        lblItem.Location = New Point(30, 75)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(69, 15)
        lblItem.TabIndex = 5
        lblItem.Text = "Product Name"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.ForeColor = Color.White
        lblPrice.Location = New Point(30, 135)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 6
        lblPrice.Text = "Price"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(30, 195)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(66, 15)
        lblStock.TabIndex = 7
        lblStock.Text = "Stock Level"
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
        btnAdd.Location = New Point(30, 260)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 30)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD ITEM"
        btnAdd.UseVisualStyleBackColor = False
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
        btnUpdate.Location = New Point(150, 260)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(100, 30)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
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
        btnDelete.Location = New Point(30, 305)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 30)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(150, 305)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 30)
        btnBack.TabIndex = 11
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FPinventory
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(lblStock)
        Controls.Add(lblPrice)
        Controls.Add(lblItem)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(txtItemName)
        Controls.Add(lblTitle)
        Controls.Add(dgvInventory)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPinventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPinventory"
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
End Class