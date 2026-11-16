Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPorders
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
        Dim rowStyle As New DataGridViewCellStyle()

        lblTitle = New Label()
        btnBack = New Button()
        pnlQueue = New Panel()
        lblQueue = New Label()
        dgvOrders = New DataGridView()
        colOrderNumber = New DataGridViewTextBoxColumn()
        colPlacedAt = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colPayment = New DataGridViewTextBoxColumn()
        colTotal = New DataGridViewTextBoxColumn()
        pnlDetails = New Panel()
        lblOrderNumber = New Label()
        lblOrderStatus = New Label()
        dgvOrderItems = New DataGridView()
        colProduct = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colLineTotal = New DataGridViewTextBoxColumn()
        lblOrderTotal = New Label()
        lblPayment = New Label()
        lblDiningOption = New Label()
        btnMarkPaid = New Button()
        btnCancelOrder = New Button()
        btnAdvance = New Button()
        pnlQueue.SuspendLayout()
        pnlDetails.SuspendLayout()
        CType(dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        headerStyle.BackColor = Color.FromArgb(50, 50, 50)
        headerStyle.ForeColor = Color.White
        headerStyle.SelectionBackColor = Color.FromArgb(50, 50, 50)
        headerStyle.SelectionForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        rowStyle.BackColor = Color.FromArgb(28, 28, 28)
        rowStyle.ForeColor = Color.White
        rowStyle.SelectionBackColor = Color.FromArgb(145, 24, 24)
        rowStyle.SelectionForeColor = Color.White
        rowStyle.Font = New Font("Segoe UI", 9F)
        rowStyle.Padding = New Padding(3, 0, 3, 0)

        lblTitle.Location = New Point(25, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(600, 35)
        lblTitle.Text = "ORDERS"
        lblTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(24, 24, 24)
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        btnBack.Location = New Point(795, 14)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(120, 34)
        btnBack.Text = "BACK"
        btnBack.TabIndex = 4
        btnBack.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.BackColor = Color.FromArgb(20, 20, 20)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Cursor = Cursors.Hand
        btnBack.UseVisualStyleBackColor = False
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 24, 24)

        pnlQueue.Location = New Point(25, 60)
        pnlQueue.Name = "pnlQueue"
        pnlQueue.Size = New Size(500, 420)
        pnlQueue.BackColor = Color.FromArgb(35, 35, 35)
        pnlQueue.TabIndex = 0
        pnlQueue.Controls.AddRange(New Control() {lblQueue, dgvOrders})
        lblQueue.Location = New Point(15, 10)
        lblQueue.Name = "lblQueue"
        lblQueue.Size = New Size(470, 24)
        lblQueue.Text = "ORDER QUEUE"
        lblQueue.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblQueue.ForeColor = Color.White
        lblQueue.TextAlign = ContentAlignment.MiddleLeft
        dgvOrders.Location = New Point(15, 45)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.Size = New Size(470, 360)
        dgvOrders.TabIndex = 0
        dgvOrders.AllowUserToAddRows = False
        dgvOrders.AllowUserToDeleteRows = False
        dgvOrders.AllowUserToResizeRows = False
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrders.BackgroundColor = Color.FromArgb(24, 24, 24)
        dgvOrders.BorderStyle = BorderStyle.None
        dgvOrders.ColumnHeadersHeight = 32
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrders.EnableHeadersVisualStyles = False
        dgvOrders.GridColor = Color.FromArgb(62, 62, 62)
        dgvOrders.MultiSelect = False
        dgvOrders.ReadOnly = True
        dgvOrders.RowHeadersVisible = False
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrders.RowTemplate.Height = 32
        dgvOrders.ColumnHeadersDefaultCellStyle = headerStyle
        dgvOrders.DefaultCellStyle = rowStyle
        dgvOrders.Columns.AddRange(New DataGridViewColumn() {colOrderNumber, colPlacedAt, colStatus, colPayment, colTotal})
        colOrderNumber.Name = "colOrderNumber"
        colOrderNumber.HeaderText = "Order No."
        colOrderNumber.FillWeight = 22
        colOrderNumber.SortMode = DataGridViewColumnSortMode.NotSortable
        colPlacedAt.Name = "colPlacedAt"
        colPlacedAt.HeaderText = "Time"
        colPlacedAt.FillWeight = 16
        colPlacedAt.SortMode = DataGridViewColumnSortMode.NotSortable
        colStatus.Name = "colStatus"
        colStatus.HeaderText = "Status"
        colStatus.FillWeight = 21
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable
        colPayment.Name = "colPayment"
        colPayment.HeaderText = "Payment"
        colPayment.FillWeight = 22
        colPayment.SortMode = DataGridViewColumnSortMode.NotSortable
        colTotal.Name = "colTotal"
        colTotal.HeaderText = "Total"
        colTotal.FillWeight = 19
        colTotal.SortMode = DataGridViewColumnSortMode.NotSortable
        colTotal.DefaultCellStyle.Format = "₱#,##0.00"
        colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        pnlDetails.Location = New Point(540, 60)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(375, 420)
        pnlDetails.BackColor = Color.FromArgb(35, 35, 35)
        pnlDetails.TabIndex = 1
        pnlDetails.Controls.AddRange(New Control() {lblOrderNumber, lblOrderStatus, lblPayment, lblDiningOption, dgvOrderItems, lblOrderTotal, btnMarkPaid, btnCancelOrder, btnAdvance})
        lblOrderNumber.Location = New Point(15, 9)
        lblOrderNumber.Name = "lblOrderNumber"
        lblOrderNumber.Size = New Size(345, 27)
        lblOrderNumber.Text = "Select an order"
        lblOrderNumber.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblOrderNumber.ForeColor = Color.White
        lblOrderNumber.TextAlign = ContentAlignment.MiddleLeft
        lblOrderStatus.Location = New Point(15, 39)
        lblOrderStatus.Name = "lblOrderStatus"
        lblOrderStatus.Size = New Size(345, 22)
        lblOrderStatus.Text = ""
        lblOrderStatus.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblOrderStatus.ForeColor = Color.White
        lblOrderStatus.TextAlign = ContentAlignment.MiddleLeft
        lblOrderStatus.ForeColor = Color.Gainsboro
        dgvOrderItems.Location = New Point(15, 111)
        dgvOrderItems.Name = "dgvOrderItems"
        dgvOrderItems.Size = New Size(345, 149)
        dgvOrderItems.TabIndex = 0
        dgvOrderItems.AllowUserToAddRows = False
        dgvOrderItems.AllowUserToDeleteRows = False
        dgvOrderItems.AllowUserToResizeRows = False
        dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrderItems.BackgroundColor = Color.FromArgb(24, 24, 24)
        dgvOrderItems.BorderStyle = BorderStyle.None
        dgvOrderItems.ColumnHeadersHeight = 32
        dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrderItems.EnableHeadersVisualStyles = False
        dgvOrderItems.GridColor = Color.FromArgb(62, 62, 62)
        dgvOrderItems.MultiSelect = False
        dgvOrderItems.ReadOnly = True
        dgvOrderItems.RowHeadersVisible = False
        dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrderItems.RowTemplate.Height = 32
        dgvOrderItems.ColumnHeadersDefaultCellStyle = headerStyle
        dgvOrderItems.DefaultCellStyle = rowStyle
        dgvOrderItems.Columns.AddRange(New DataGridViewColumn() {colProduct, colQty, colLineTotal})
        colProduct.Name = "colProduct"
        colProduct.HeaderText = "Item"
        colProduct.FillWeight = 58
        colProduct.SortMode = DataGridViewColumnSortMode.NotSortable
        colProduct.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        colQty.Name = "colQty"
        colQty.HeaderText = "Qty"
        colQty.FillWeight = 14
        colQty.SortMode = DataGridViewColumnSortMode.NotSortable
        colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        colLineTotal.Name = "colLineTotal"
        colLineTotal.HeaderText = "Amount"
        colLineTotal.FillWeight = 28
        colLineTotal.SortMode = DataGridViewColumnSortMode.NotSortable
        colLineTotal.DefaultCellStyle.Format = "₱#,##0.00"
        colLineTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        lblPayment.Name = "lblPayment"
        lblPayment.Location = New Point(15, 63)
        lblPayment.Size = New Size(345, 20)
        lblPayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblPayment.ForeColor = Color.Gainsboro
        lblPayment.TextAlign = ContentAlignment.MiddleLeft
        lblDiningOption.Name = "lblDiningOption"
        lblDiningOption.Location = New Point(15, 84)
        lblDiningOption.Size = New Size(345, 20)
        lblDiningOption.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblDiningOption.ForeColor = Color.Gainsboro
        lblDiningOption.TextAlign = ContentAlignment.MiddleLeft
        btnMarkPaid.Name = "btnMarkPaid"
        btnMarkPaid.Location = New Point(15, 308)
        btnMarkPaid.Size = New Size(168, 40)
        btnMarkPaid.Text = "MARK AS PAID"
        btnMarkPaid.TabIndex = 1
        btnMarkPaid.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnMarkPaid.ForeColor = Color.White
        btnMarkPaid.BackColor = Color.FromArgb(20, 20, 20)
        btnMarkPaid.FlatStyle = FlatStyle.Flat
        btnMarkPaid.Cursor = Cursors.Hand
        btnMarkPaid.UseVisualStyleBackColor = False
        btnMarkPaid.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnMarkPaid.FlatAppearance.BorderSize = 2
        btnMarkPaid.Enabled = False
        btnCancelOrder.Name = "btnCancelOrder"
        btnCancelOrder.Location = New Point(192, 308)
        btnCancelOrder.Size = New Size(168, 40)
        btnCancelOrder.Text = "CANCEL ORDER"
        btnCancelOrder.TabIndex = 2
        btnCancelOrder.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancelOrder.ForeColor = Color.White
        btnCancelOrder.BackColor = Color.FromArgb(20, 20, 20)
        btnCancelOrder.FlatStyle = FlatStyle.Flat
        btnCancelOrder.Cursor = Cursors.Hand
        btnCancelOrder.UseVisualStyleBackColor = False
        btnCancelOrder.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnCancelOrder.FlatAppearance.BorderSize = 2
        btnCancelOrder.Enabled = False
        lblOrderTotal.Location = New Point(15, 265)
        lblOrderTotal.Name = "lblOrderTotal"
        lblOrderTotal.Size = New Size(345, 32)
        lblOrderTotal.Text = ""
        lblOrderTotal.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblOrderTotal.ForeColor = Color.White
        lblOrderTotal.TextAlign = ContentAlignment.MiddleLeft
        btnAdvance.Location = New Point(15, 358)
        btnAdvance.Name = "btnAdvance"
        btnAdvance.Size = New Size(345, 43)
        btnAdvance.Text = "UPDATE STATUS"
        btnAdvance.TabIndex = 3
        btnAdvance.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAdvance.ForeColor = Color.White
        btnAdvance.BackColor = Color.FromArgb(190, 20, 20)
        btnAdvance.FlatStyle = FlatStyle.Flat
        btnAdvance.Cursor = Cursors.Hand
        btnAdvance.UseVisualStyleBackColor = False
        btnAdvance.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnAdvance.FlatAppearance.BorderSize = 2
        btnAdvance.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 24, 24)
        btnAdvance.Enabled = False

        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(940, 500)
        Controls.AddRange(New Control() {lblTitle, btnBack, pnlQueue, pnlDetails})
        FormBorderStyle = FormBorderStyle.None
        Name = "FPorders"
        StartPosition = FormStartPosition.CenterParent
        Text = "Orders"
        CType(dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        pnlQueue.ResumeLayout(False)
        pnlDetails.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlQueue As Panel
    Friend WithEvents lblQueue As Label
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents colOrderNumber As DataGridViewTextBoxColumn
    Friend WithEvents colPlacedAt As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblOrderStatus As Label
    Friend WithEvents dgvOrderItems As DataGridView
    Friend WithEvents colProduct As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colLineTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents colPayment As DataGridViewTextBoxColumn
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblDiningOption As Label
    Friend WithEvents btnMarkPaid As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnAdvance As Button
End Class
