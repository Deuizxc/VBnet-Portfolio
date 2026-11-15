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
        dgvSales = New DataGridView()
        btnExport = New Button()
        btnBack = New Button()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(300, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(224, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SALES & TRANSACTION LOG"
        ' 
        ' dgvSales
        ' 
        dgvSales.AllowUserToAddRows = False
        dgvSales.AllowUserToDeleteRows = False
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSales.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvSales.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSales.DefaultCellStyle = DataGridViewCellStyle2
        dgvSales.Location = New Point(50, 80)
        dgvSales.Name = "dgvSales"
        dgvSales.ReadOnly = True
        dgvSales.RowHeadersVisible = False
        dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSales.Size = New Size(700, 260)
        dgvSales.TabIndex = 1
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
        btnExport.Location = New Point(230, 360)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(160, 35)
        btnExport.TabIndex = 2
        btnExport.Text = "EXPORT REPORT"
        btnExport.UseVisualStyleBackColor = False
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
        btnBack.Location = New Point(410, 360)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(160, 35)
        btnBack.TabIndex = 3
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FPsalesreport
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnExport)
        Controls.Add(dgvSales)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPsalesreport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPsalesreport"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents btnExport As Button
    Friend WithEvents btnBack As Button
End Class