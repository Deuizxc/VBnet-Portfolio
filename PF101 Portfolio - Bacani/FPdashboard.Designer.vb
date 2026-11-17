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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPdashboard))
        btnKiosk = New Button()
        btnInventory = New Button()
        btnOrders = New Button()
        btnReports = New Button()
        btnClose = New Button()
        SuspendLayout()
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
        btnKiosk.Location = New Point(490, 56)
        btnKiosk.Name = "btnKiosk"
        btnKiosk.Size = New Size(415, 55)
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
        btnInventory.Location = New Point(490, 135)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(415, 55)
        btnInventory.TabIndex = 4
        btnInventory.Text = "📦 INVENTORY & CATALOG MANAGER (SELL)"
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnOrders
        ' 
        btnOrders.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnOrders.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnOrders.FlatAppearance.BorderSize = 2
        btnOrders.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnOrders.ForeColor = Color.White
        btnOrders.Location = New Point(490, 212)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(415, 55)
        btnOrders.TabIndex = 5
        btnOrders.Text = "ORDERS"
        btnOrders.UseVisualStyleBackColor = False
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
        btnReports.Location = New Point(490, 286)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(415, 55)
        btnReports.TabIndex = 6
        btnReports.Text = "📈 SALES REPORTS "
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
        btnClose.Location = New Point(490, 365)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(415, 55)
        btnClose.TabIndex = 7
        btnClose.Text = "EXIT APPLICATION"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' FPdashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(940, 450)
        Controls.Add(btnClose)
        Controls.Add(btnReports)
        Controls.Add(btnOrders)
        Controls.Add(btnInventory)
        Controls.Add(btnKiosk)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPdashboard"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnKiosk As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnClose As Button
End Class
