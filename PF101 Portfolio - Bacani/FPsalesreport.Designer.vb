<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPsalesreport
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
        btnBack = New Button()
        pnlCard1 = New Panel()
        lblTotalRevenue = New Label()
        lblRevTitle = New Label()
        pnlCard2 = New Panel()
        lblTotalTxn = New Label()
        lblTxnTitle = New Label()
        pnlCard3 = New Panel()
        lblAvgTicket = New Label()
        lblAvgTitle = New Label()
        pnlGridContainer = New Panel()
        btnExport = New Button()
        dgvSales = New DataGridView()
        txtSearch = New TextBox()
        lblSearch = New Label()
        lblGridHeader = New Label()
        pnlCard1.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard3.SuspendLayout()
        pnlGridContainer.SuspendLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(25, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(295, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SALES REPORTS & ANALYTICS"
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
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlCard1.BorderStyle = BorderStyle.FixedSingle
        pnlCard1.Controls.Add(lblTotalRevenue)
        pnlCard1.Controls.Add(lblRevTitle)
        pnlCard1.Location = New Point(25, 60)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(285, 75)
        pnlCard1.TabIndex = 2
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.AutoSize = True
        lblTotalRevenue.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTotalRevenue.ForeColor = Color.LimeGreen
        lblTotalRevenue.Location = New Point(12, 32)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(85, 25)
        lblTotalRevenue.TabIndex = 1
        lblTotalRevenue.Text = "₱0.00"
        ' 
        ' lblRevTitle
        ' 
        lblRevTitle.AutoSize = True
        lblRevTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblRevTitle.ForeColor = Color.DarkGray
        lblRevTitle.Location = New Point(12, 12)
        lblRevTitle.Name = "lblRevTitle"
        lblRevTitle.Size = New Size(94, 15)
        lblRevTitle.TabIndex = 0
        lblRevTitle.Text = "TOTAL REVENUE"
        ' 
        ' pnlCard2
        ' 
        pnlCard2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlCard2.BorderStyle = BorderStyle.FixedSingle
        pnlCard2.Controls.Add(lblTotalTxn)
        pnlCard2.Controls.Add(lblTxnTitle)
        pnlCard2.Location = New Point(328, 60)
        pnlCard2.Name = "pnlCard2"
        pnlCard2.Size = New Size(285, 75)
        pnlCard2.TabIndex = 3
        ' 
        ' lblTotalTxn
        ' 
        lblTotalTxn.AutoSize = True
        lblTotalTxn.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTotalTxn.ForeColor = Color.White
        lblTotalTxn.Location = New Point(12, 32)
        lblTotalTxn.Name = "lblTotalTxn"
        lblTotalTxn.Size = New Size(34, 25)
        lblTotalTxn.TabIndex = 1
        lblTotalTxn.Text = "0"
        ' 
        ' lblTxnTitle
        ' 
        lblTxnTitle.AutoSize = True
        lblTxnTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblTxnTitle.ForeColor = Color.DarkGray
        lblTxnTitle.Location = New Point(12, 12)
        lblTxnTitle.Name = "lblTxnTitle"
        lblTxnTitle.Size = New Size(130, 15)
        lblTxnTitle.TabIndex = 0
        lblTxnTitle.Text = "TOTAL TRANSACTIONS"
        ' 
        ' pnlCard3
        ' 
        pnlCard3.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlCard3.BorderStyle = BorderStyle.FixedSingle
        pnlCard3.Controls.Add(lblAvgTicket)
        pnlCard3.Controls.Add(lblAvgTitle)
        pnlCard3.Location = New Point(630, 60)
        pnlCard3.Name = "pnlCard3"
        pnlCard3.Size = New Size(285, 75)
        pnlCard3.TabIndex = 4
        ' 
        ' lblAvgTicket
        ' 
        lblAvgTicket.AutoSize = True
        lblAvgTicket.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblAvgTicket.ForeColor = Color.Cyan
        lblAvgTicket.Location = New Point(12, 32)
        lblAvgTicket.Name = "lblAvgTicket"
        lblAvgTicket.Size = New Size(70, 25)
        lblAvgTicket.TabIndex = 1
        lblAvgTicket.Text = "₱0.00"
        ' 
        ' lblAvgTitle
        ' 
        lblAvgTitle.AutoSize = True
        lblAvgTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblAvgTitle.ForeColor = Color.DarkGray
        lblAvgTitle.Location = New Point(12, 12)
        lblAvgTitle.Name = "lblAvgTitle"
        lblAvgTitle.Size = New Size(115, 15)
        lblAvgTitle.TabIndex = 0
        lblAvgTitle.Text = "AVERAGE ORDER SIZE"
        ' 
        ' pnlGridContainer
        ' 
        pnlGridContainer.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlGridContainer.BorderStyle = BorderStyle.FixedSingle
        pnlGridContainer.Controls.Add(btnExport)
        pnlGridContainer.Controls.Add(dgvSales)
        pnlGridContainer.Controls.Add(txtSearch)
        pnlGridContainer.Controls.Add(lblSearch)
        pnlGridContainer.Controls.Add(lblGridHeader)
        pnlGridContainer.Location = New Point(25, 150)
        pnlGridContainer.Name = "pnlGridContainer"
        pnlGridContainer.Size = New Size(890, 330)
        pnlGridContainer.TabIndex = 5
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExport.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnExport.FlatAppearance.BorderSize = 2
        btnExport.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExport.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(15, 278)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(180, 35)
        btnExport.TabIndex = 4
        btnExport.Text = "EXPORT REPORT (CSV)"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' dgvSales
        ' 
        dgvSales.AllowUserToAddRows = False
        dgvSales.AllowUserToDeleteRows = False
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSales.BackgroundColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        dgvSales.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSales.ColumnHeadersHeight = 32
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSales.DefaultCellStyle = DataGridViewCellStyle2
        dgvSales.EnableHeadersVisualStyles = False
        dgvSales.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        dgvSales.Location = New Point(15, 45)
        dgvSales.MultiSelect = False
        dgvSales.Name = "dgvSales"
        dgvSales.ReadOnly = True
        dgvSales.RowHeadersVisible = False
        dgvSales.RowTemplate.Height = 35
        dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSales.Size = New Size(855, 220)
        dgvSales.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.0F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(655, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(215, 23)
        txtSearch.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.DarkGray
        lblSearch.Location = New Point(600, 14)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(47, 15)
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
        lblGridHeader.Size = New Size(158, 20)
        lblGridHeader.TabIndex = 0
        lblGridHeader.Text = "TRANSACTION LOGS"
        ' 
        ' FPsalesreport
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        ClientSize = New Size(940, 500)
        Controls.Add(pnlGridContainer)
        Controls.Add(pnlCard3)
        Controls.Add(pnlCard2)
        Controls.Add(pnlCard1)
        Controls.Add(btnBack)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPsalesreport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPsalesreport"
        pnlCard1.ResumeLayout(False)
        pnlCard1.PerformLayout()
        pnlCard2.ResumeLayout(False)
        pnlCard2.PerformLayout()
        pnlCard3.ResumeLayout(False)
        pnlCard3.PerformLayout()
        pnlGridContainer.ResumeLayout(False)
        pnlGridContainer.PerformLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblRevTitle As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblTxnTitle As Label
    Friend WithEvents lblTotalTxn As Label
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblAvgTitle As Label
    Friend WithEvents lblAvgTicket As Label
    Friend WithEvents pnlGridContainer As Panel
    Friend WithEvents lblGridHeader As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents btnExport As Button
End Class