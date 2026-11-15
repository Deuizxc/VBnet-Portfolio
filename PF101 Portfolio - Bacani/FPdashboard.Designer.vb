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
        pnlHeroBanner = New Panel()
        lblTagline = New Label()
        btnKiosk = New Button()
        btnInventory = New Button()
        btnReports = New Button()
        btnClose = New Button()
        pnlHeroBanner.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(35, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(335, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "PHANTOM KIOSK POS"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        lblSubtitle.Location = New Point(38, 68)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(285, 20)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "RETAIL BUY & SELL OBSERVATION SUITE"
        ' 
        ' pnlHeroBanner
        ' 
        pnlHeroBanner.BackColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        pnlHeroBanner.Controls.Add(lblTagline)
        pnlHeroBanner.Location = New Point(35, 105)
        pnlHeroBanner.Name = "pnlHeroBanner"
        pnlHeroBanner.Size = New Size(430, 315)
        pnlHeroBanner.TabIndex = 2
        ' 
        ' lblTagline
        ' 
        lblTagline.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblTagline.ForeColor = Color.White
        lblTagline.Location = New Point(25, 25)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(380, 260)
        lblTagline.TabIndex = 0
        lblTagline.Text = "TAKE CONTROL OF YOUR TRANSACTIONS." & vbCrLf & vbCrLf & "Manage customer ordering queues, update live inventory stock levels, and audit business performance in real time."
        ' 
        ' btnKiosk
        ' 
        btnKiosk.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.BorderSize = 2
        btnKiosk.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnKiosk.FlatStyle = FlatStyle.Flat
        btnKiosk.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnKiosk.ForeColor = Color.White
        btnKiosk.Location = New Point(490, 105)
        btnKiosk.Name = "btnKiosk"
        btnKiosk.Size = New Size(415, 68)
        btnKiosk.TabIndex = 3
        btnKiosk.Text = ChrW(55357) & ChrW(57042) & " CUSTOMER ORDERING KIOSK (BUY)"
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
        btnInventory.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnInventory.ForeColor = Color.White
        btnInventory.Location = New Point(490, 187)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(415, 68)
        btnInventory.TabIndex = 4
        btnInventory.Text = "📦 INVENTORY & CATALOG MANAGER (SELL)"
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
        btnReports.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(490, 269)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(415, 68)
        btnReports.TabIndex = 5
        btnReports.Text = "📈 SALES REPORTS & ANALYTICS"
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
        btnClose.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(490, 351)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(415, 69)
        btnClose.TabIndex = 6
        btnClose.Text = "EXIT APPLICATION"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' FPdashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(940, 450)
        Controls.Add(btnClose)
        Controls.Add(btnReports)
        Controls.Add(btnInventory)
        Controls.Add(btnKiosk)
        Controls.Add(pnlHeroBanner)
        Controls.Add(lblSubtitle)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPdashboard"
        pnlHeroBanner.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlHeroBanner As Panel
    Friend WithEvents lblTagline As Label
    Friend WithEvents btnKiosk As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnClose As Button
End Class