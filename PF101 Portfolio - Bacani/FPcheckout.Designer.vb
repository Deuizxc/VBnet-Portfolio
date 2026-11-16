Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPcheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim headerStyle As New DataGridViewCellStyle()
        Dim itemStyle As New DataGridViewCellStyle()

        lblTitle = New Label()
        dgvReview = New DataGridView()
        colItem = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        lblOrderType = New Label()
        cmbOrderType = New ComboBox()
        lblPaymentMethod = New Label()
        cmbPaymentMethod = New ComboBox()
        lblInstructions = New Label()
        lblBreakdown = New Label()
        lblTotal = New Label()
        btnBackToCart = New Button()
        btnConfirm = New Button()
        CType(dgvReview, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblTitle.Name = "lblTitle"
        lblTitle.Location = New Point(22, 16)
        lblTitle.Size = New Size(556, 40)
        lblTitle.Text = "REVIEW ORDER"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.ForeColor = Color.White
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        dgvReview.Name = "dgvReview"
        dgvReview.Location = New Point(22, 68)
        dgvReview.Size = New Size(556, 218)
        dgvReview.TabIndex = 0
        dgvReview.AllowUserToAddRows = False
        dgvReview.AllowUserToDeleteRows = False
        dgvReview.AllowUserToResizeRows = False
        dgvReview.ReadOnly = True
        dgvReview.RowHeadersVisible = False
        dgvReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReview.MultiSelect = False
        dgvReview.EnableHeadersVisualStyles = False
        dgvReview.BackgroundColor = Color.FromArgb(24, 24, 24)
        dgvReview.GridColor = Color.FromArgb(62, 62, 62)
        dgvReview.BorderStyle = BorderStyle.None
        dgvReview.ColumnHeadersHeight = 32
        dgvReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvReview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        headerStyle.BackColor = Color.FromArgb(63, 63, 63)
        headerStyle.ForeColor = Color.White
        headerStyle.SelectionBackColor = Color.FromArgb(63, 63, 63)
        headerStyle.SelectionForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        itemStyle.BackColor = Color.FromArgb(28, 28, 28)
        itemStyle.ForeColor = Color.White
        itemStyle.SelectionBackColor = Color.FromArgb(85, 38, 38)
        itemStyle.SelectionForeColor = Color.White
        itemStyle.Font = New Font("Segoe UI", 9F)
        itemStyle.Padding = New Padding(4)
        dgvReview.ColumnHeadersDefaultCellStyle = headerStyle
        dgvReview.DefaultCellStyle = itemStyle
        dgvReview.Columns.AddRange(New DataGridViewColumn() {colItem, colQty, colAmount})
        colItem.Name = "colItem"
        colItem.HeaderText = "Item"
        colItem.FillWeight = 60
        colItem.SortMode = DataGridViewColumnSortMode.NotSortable
        colQty.Name = "colQty"
        colQty.HeaderText = "Qty"
        colQty.FillWeight = 12
        colQty.SortMode = DataGridViewColumnSortMode.NotSortable
        colAmount.Name = "colAmount"
        colAmount.HeaderText = "Amount"
        colAmount.FillWeight = 28
        colAmount.SortMode = DataGridViewColumnSortMode.NotSortable
        colItem.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        colAmount.DefaultCellStyle.Format = "₱#,##0.00"
        colAmount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        lblOrderType.Name = "lblOrderType"
        lblOrderType.Location = New Point(22, 300)
        lblOrderType.Size = New Size(255, 22)
        lblOrderType.Text = "Order type"
        lblOrderType.TextAlign = ContentAlignment.MiddleLeft
        lblOrderType.ForeColor = Color.White
        lblOrderType.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Location = New Point(305, 300)
        lblPaymentMethod.Size = New Size(273, 22)
        lblPaymentMethod.Text = "Payment method"
        lblPaymentMethod.TextAlign = ContentAlignment.MiddleLeft
        lblPaymentMethod.ForeColor = Color.White
        lblPaymentMethod.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cmbOrderType.Name = "cmbOrderType"
        cmbOrderType.Location = New Point(22, 328)
        cmbOrderType.Size = New Size(255, 28)
        cmbOrderType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbOrderType.TabIndex = 1
        cmbOrderType.FlatStyle = FlatStyle.Flat
        cmbOrderType.BackColor = Color.FromArgb(48, 48, 48)
        cmbOrderType.ForeColor = Color.White
        cmbOrderType.Font = New Font("Segoe UI", 11F)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Location = New Point(305, 328)
        cmbPaymentMethod.Size = New Size(273, 28)
        cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMethod.TabIndex = 2
        cmbPaymentMethod.FlatStyle = FlatStyle.Flat
        cmbPaymentMethod.BackColor = Color.FromArgb(48, 48, 48)
        cmbPaymentMethod.ForeColor = Color.White
        cmbPaymentMethod.Font = New Font("Segoe UI", 11F)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Location = New Point(22, 364)
        lblInstructions.Size = New Size(556, 22)
        lblInstructions.Text = "Pay at the counter using your order number."
        lblInstructions.TextAlign = ContentAlignment.MiddleLeft
        lblInstructions.ForeColor = Color.Gainsboro
        lblInstructions.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblBreakdown.Name = "lblBreakdown"
        lblBreakdown.Location = New Point(22, 394)
        lblBreakdown.Size = New Size(556, 22)
        lblBreakdown.Text = ""
        lblBreakdown.TextAlign = ContentAlignment.MiddleRight
        lblBreakdown.ForeColor = Color.Gainsboro
        lblBreakdown.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblTotal.Name = "lblTotal"
        lblTotal.Location = New Point(22, 418)
        lblTotal.Size = New Size(556, 34)
        lblTotal.Text = ""
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        lblTotal.ForeColor = Color.White
        lblTotal.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        btnBackToCart.Name = "btnBackToCart"
        btnBackToCart.Location = New Point(22, 470)
        btnBackToCart.Size = New Size(255, 42)
        btnBackToCart.Text = "BACK TO CART"
        btnBackToCart.TabIndex = 3
        btnBackToCart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        btnBackToCart.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBackToCart.ForeColor = Color.White
        btnBackToCart.BackColor = Color.FromArgb(24, 24, 24)
        btnBackToCart.FlatStyle = FlatStyle.Flat
        btnBackToCart.Cursor = Cursors.Hand
        btnBackToCart.UseVisualStyleBackColor = False
        btnBackToCart.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnBackToCart.FlatAppearance.BorderSize = 2
        btnBackToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 24, 24)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Location = New Point(305, 470)
        btnConfirm.Size = New Size(273, 42)
        btnConfirm.Text = "CONFIRM ORDER"
        btnConfirm.TabIndex = 4
        btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK
        btnConfirm.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnConfirm.ForeColor = Color.White
        btnConfirm.BackColor = Color.FromArgb(190, 20, 20)
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Cursor = Cursors.Hand
        btnConfirm.UseVisualStyleBackColor = False
        btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnConfirm.FlatAppearance.BorderSize = 2
        btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 24, 24)

        AcceptButton = btnConfirm
        CancelButton = btnBackToCart
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Font = New Font("Segoe UI", 9F)
        BackColor = Color.FromArgb(35, 35, 35)
        ClientSize = New Size(600, 534)
        Controls.AddRange(New Control() {lblTitle, dgvReview, lblOrderType, cmbOrderType, lblPaymentMethod, cmbPaymentMethod, lblInstructions, lblBreakdown, lblTotal, btnBackToCart, btnConfirm})
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Name = "FPcheckout"
        Text = "Review Order"
        CType(dgvReview, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvReview As DataGridView
    Friend WithEvents colItem As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents lblOrderType As Label
    Friend WithEvents cmbOrderType As ComboBox
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblBreakdown As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBackToCart As Button
    Friend WithEvents btnConfirm As Button
End Class
