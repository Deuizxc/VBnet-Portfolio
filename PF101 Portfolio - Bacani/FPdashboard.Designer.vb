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
        btnKiosk = New FPdashboardMenuButton()
        btnInventory = New FPdashboardMenuButton()
        btnOrders = New FPdashboardMenuButton()
        btnReports = New FPdashboardMenuButton()
        btnClose = New FPdashboardMenuButton()
        SuspendLayout()
        ' 
        ' btnKiosk
        ' 
        btnKiosk.BackColor = Color.FromArgb(190, 22, 49)
        btnKiosk.Cursor = Cursors.Hand
        btnKiosk.FlatAppearance.BorderColor = Color.FromArgb(190, 22, 49)
        btnKiosk.FlatAppearance.BorderSize = 1
        btnKiosk.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 16, 37)
        btnKiosk.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 34, 61)
        btnKiosk.FlatStyle = FlatStyle.Flat
        btnKiosk.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnKiosk.ForeColor = Color.White
        btnKiosk.ImageAlign = ContentAlignment.MiddleLeft
        btnKiosk.Location = New Point(490, 56)
        btnKiosk.MenuSymbol = "▶"
        btnKiosk.Name = "btnKiosk"
        btnKiosk.Padding = New Padding(16, 0, 12, 0)
        btnKiosk.Size = New Size(415, 55)
        btnKiosk.TabIndex = 0
        btnKiosk.Text = "Start Order"
        btnKiosk.TextAlign = ContentAlignment.MiddleLeft
        btnKiosk.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKiosk.UseVisualStyleBackColor = False
        ' 
        ' btnOrders
        ' 
        btnOrders.BackColor = Color.FromArgb(22, 22, 24)
        btnOrders.Cursor = Cursors.Hand
        btnOrders.FlatAppearance.BorderColor = Color.FromArgb(84, 47, 53)
        btnOrders.FlatAppearance.BorderSize = 1
        btnOrders.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 31, 38)
        btnOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 30, 34)
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnOrders.ForeColor = Color.White
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft
        btnOrders.Location = New Point(490, 135)
        btnOrders.MenuSymbol = "☷"
        btnOrders.Name = "btnOrders"
        btnOrders.Padding = New Padding(16, 0, 12, 0)
        btnOrders.ShowAccent = True
        btnOrders.Size = New Size(415, 55)
        btnOrders.TabIndex = 1
        btnOrders.Text = "Order Queue"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOrders.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Color.FromArgb(22, 22, 24)
        btnInventory.Cursor = Cursors.Hand
        btnInventory.FlatAppearance.BorderColor = Color.FromArgb(84, 47, 53)
        btnInventory.FlatAppearance.BorderSize = 1
        btnInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 31, 38)
        btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 30, 34)
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnInventory.ForeColor = Color.White
        btnInventory.ImageAlign = ContentAlignment.MiddleLeft
        btnInventory.Location = New Point(490, 212)
        btnInventory.MenuSymbol = "▣"
        btnInventory.Name = "btnInventory"
        btnInventory.Padding = New Padding(16, 0, 12, 0)
        btnInventory.ShowAccent = True
        btnInventory.Size = New Size(415, 55)
        btnInventory.TabIndex = 2
        btnInventory.Text = "Manage Inventory"
        btnInventory.TextAlign = ContentAlignment.MiddleLeft
        btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.FromArgb(22, 22, 24)
        btnReports.Cursor = Cursors.Hand
        btnReports.FlatAppearance.BorderColor = Color.FromArgb(84, 47, 53)
        btnReports.FlatAppearance.BorderSize = 1
        btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 31, 38)
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 30, 34)
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnReports.ForeColor = Color.White
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(490, 286)
        btnReports.MenuSymbol = "▥"
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(16, 0, 12, 0)
        btnReports.ShowAccent = True
        btnReports.Size = New Size(415, 55)
        btnReports.TabIndex = 3
        btnReports.Text = "Sales Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(22, 22, 24)
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(84, 47, 53)
        btnClose.FlatAppearance.BorderSize = 1
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 31, 38)
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 30, 34)
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.Gainsboro
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(764, 365)
        btnClose.MenuSymbol = "↪"
        btnClose.Name = "btnClose"
        btnClose.Padding = New Padding(16, 0, 12, 0)
        btnClose.Size = New Size(141, 36)
        btnClose.TabIndex = 4
        btnClose.Text = "Exit"
        btnClose.TextAlign = ContentAlignment.MiddleLeft
        btnClose.TextImageRelation = TextImageRelation.ImageBeforeText
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
    Friend WithEvents btnKiosk As FPdashboardMenuButton
    Friend WithEvents btnInventory As FPdashboardMenuButton
    Friend WithEvents btnOrders As FPdashboardMenuButton
    Friend WithEvents btnReports As FPdashboardMenuButton
    Friend WithEvents btnClose As FPdashboardMenuButton
End Class
