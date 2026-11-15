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
        lblSubtitle = New Label()
        pnlNavCard = New Panel()
        btnClose = New Button()
        btnReports = New Button()
        btnInventory = New Button()
        btnKiosk = New Button()
        lblNavHeader = New Label()
        pnlStatusCard = New Panel()
        lblStatusHeader = New Label()
        lblDbStatus = New Label()
        lblModeStatus = New Label()
        lblVersion = New Label()
        pnlNavCard.SuspendLayout()
        pnlStatusCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(30, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(346, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "BURGER KIOSK & POS SUITE"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        lblSubtitle.ForeColor = Color.DarkGray
        lblSubtitle.Location = New Point(32, 55)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(309, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Business Observation & Inventory Management System"
        ' 
        ' pnlNavCard
        ' 
        pnlNavCard.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlNavCard.BorderStyle = BorderStyle.FixedSingle
        pnlNavCard.Controls.Add(btnClose)
        pnlNavCard.Controls.Add(btnReports)
        pnlNavCard.Controls.Add(btnInventory)
        pnlNavCard.Controls.Add(btnKiosk)
        pnlNavCard.Controls.Add(lblNavHeader)
        pnlNavCard.Location = New Point(30, 100)
        pnlNavCard.Name = "pnlNavCard"
        pnlNavCard.Size = New Size(420, 350)
        pnlNavCard.TabIndex = 2
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnClose.FlatAppearance.BorderSize = 2
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(25, 275)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(368, 45)
        btnClose.TabIndex = 4
        btnClose.Text = "EXIT APPLICATION"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReports.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnReports.FlatAppearance.BorderSize = 2
        btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(25, 205)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(368, 45)
        btnReports.TabIndex = 3
        btnReports.Text = "📈 SALES REPORTS & ANALYTICS"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnInventory.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnInventory.FlatAppearance.BorderSize = 2
        btnInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnInventory.ForeColor = Color.White
        btnInventory.Location = New Point(25, 135)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(368, 45)
        btnInventory.TabIndex = 2
        btnInventory.Text = "📦 INVENTORY & MENU MANAGER"
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnKiosk
        ' 
        btnKiosk.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.BorderSize = 2
        btnKiosk.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatStyle = FlatStyle.Flat
        btnKiosk.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnKiosk.ForeColor = Color.White
        btnKiosk.Location = New Point(25, 65)
        btnKiosk.Name = "btnKiosk"
        btnKiosk.Size = New Size(368, 45)
        btnKiosk.TabIndex = 1
        btnKiosk.Text = "🛒 SELF-ORDER KIOSK (POS)"
        btnKiosk.UseVisualStyleBackColor = False
        ' 
        ' lblNavHeader
        ' 
        lblNavHeader.AutoSize = True
        lblNavHeader.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblNavHeader.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        lblNavHeader.Location = New Point(25, 22)
        lblNavHeader.Name = "lblNavHeader"
        lblNavHeader.Size = New Size(160, 20)
        lblNavHeader.TabIndex = 0
        lblNavHeader.Text = "SYSTEM NAVIGATION"
        ' 
        ' pnlStatusCard
        ' 
        pnlStatusCard.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlStatusCard.BorderStyle = BorderStyle.FixedSingle
        pnlStatusCard.Controls.Add(lblVersion)
        pnlStatusCard.Controls.Add(lblModeStatus)
        pnlStatusCard.Controls.Add(lblDbStatus)
        pnlStatusCard.Controls.Add(lblStatusHeader)
        pnlStatusCard.Location = New Point(470, 100)
        pnlStatusCard.Name = "pnlStatusCard"
        pnlStatusCard.Size = New Size(440, 350)
        pnlStatusCard.TabIndex = 3
        ' 
        ' lblStatusHeader
        ' 
        lblStatusHeader.AutoSize = True
        lblStatusHeader.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblStatusHeader.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        lblStatusHeader.Location = New Point(25, 22)
        lblStatusHeader.Name = "lblStatusHeader"
        lblStatusHeader.Size = New Size(181, 20)
        lblStatusHeader.TabIndex = 0
        lblStatusHeader.Text = "SYSTEM & NODE STATUS"
        ' 
        ' lblDbStatus
        ' 
        lblDbStatus.AutoSize = True
        lblDbStatus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDbStatus.ForeColor = Color.LimeGreen
        lblDbStatus.Location = New Point(25, 75)
        lblDbStatus.Name = "lblDbStatus"
        lblDbStatus.Size = New Size(224, 19)
        lblDbStatus.TabIndex = 1
        lblDbStatus.Text = "● Database Connection: Active"
        ' 
        ' lblModeStatus
        ' 
        lblModeStatus.AutoSize = True
        lblModeStatus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblModeStatus.ForeColor = Color.White
        lblModeStatus.Location = New Point(25, 115)
        lblModeStatus.Name = "lblModeStatus"
        lblModeStatus.Size = New Size(207, 19)
        lblModeStatus.TabIndex = 2
        lblModeStatus.Text = "● Operating Mode: Live POS"
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Segoe UI", 9.5F, FontStyle.Italic)
        lblVersion.ForeColor = Color.DarkGray
        lblVersion.Location = New Point(25, 290)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(168, 17)
        lblVersion.TabIndex = 3
        lblVersion.Text = "Portfolio Build v2.6 (P5 Edition)"
        ' 
        ' FPdashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        ClientSize = New Size(940, 480)
        Controls.Add(pnlStatusCard)
        Controls.Add(pnlNavCard)
        Controls.Add(lblSubtitle)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPdashboard"
        pnlNavCard.ResumeLayout(False)
        pnlNavCard.PerformLayout()
        pnlStatusCard.ResumeLayout(False)
        pnlStatusCard.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlNavCard As Panel
    Friend WithEvents lblNavHeader As Label
    Friend WithEvents btnKiosk As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlStatusCard As Panel
    Friend WithEvents lblStatusHeader As Label
    Friend WithEvents lblDbStatus As Label
    Friend WithEvents lblModeStatus As Label
    Friend WithEvents lblVersion As Label
End Class