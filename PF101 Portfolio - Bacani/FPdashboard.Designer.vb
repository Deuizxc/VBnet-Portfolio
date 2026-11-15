<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPdashboard
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
        lblTitle = New Label()
        btnKiosk = New Button()
        btnInventory = New Button()
        btnReports = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(360, 39)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(77, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "KIOSK"
        ' 
        ' btnKiosk
        ' 
        btnKiosk.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.BorderSize = 2
        btnKiosk.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatStyle = FlatStyle.Flat
        btnKiosk.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnKiosk.ForeColor = Color.White
        btnKiosk.Location = New Point(280, 110)
        btnKiosk.Name = "btnKiosk"
        btnKiosk.Size = New Size(240, 45)
        btnKiosk.TabIndex = 1
        btnKiosk.Text = "CUSTOMER KIOSK (BUY)"
        btnKiosk.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnInventory.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnInventory.FlatAppearance.BorderSize = 2
        btnInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnInventory.ForeColor = Color.White
        btnInventory.Location = New Point(280, 175)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(240, 45)
        btnInventory.TabIndex = 2
        btnInventory.Text = "INVENTORY MANAGER"
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReports.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnReports.FlatAppearance.BorderSize = 2
        btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(280, 240)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(240, 45)
        btnReports.TabIndex = 3
        btnReports.Text = "SALES REPORTS"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnClose.FlatAppearance.BorderSize = 2
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(280, 315)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(240, 45)
        btnClose.TabIndex = 4
        btnClose.Text = "EXIT APPLICATION"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' FPdashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnReports)
        Controls.Add(btnInventory)
        Controls.Add(btnKiosk)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPdashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnKiosk As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnClose As Button
End Class