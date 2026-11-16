<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPkiosk
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
        pnlCategories = New FlowLayoutPanel()
        btnCatBurgers = New Button()
        btnCatDrinks = New Button()
        btnCatDesserts = New Button()
        flpMenuGrid = New FlowLayoutPanel()
        pnlCartContainer = New Panel()
        lblCartHeader = New Label()
        flpCartItems = New FlowLayoutPanel()
        lblTaxLabel = New Label()
        lblTaxValue = New Label()
        lblTotalLabel = New Label()
        lblTotalValue = New Label()
        btnPay = New Button()
        btnBack = New Button()
        pnlCategories.SuspendLayout()
        pnlCartContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(30, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(260, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SELF-ORDER KIOSK POS"
        ' 
        ' pnlCategories
        ' 
        pnlCategories.BackColor = Color.FromArgb(35, 35, 35)
        pnlCategories.Controls.Add(btnCatBurgers)
        pnlCategories.Controls.Add(btnCatDrinks)
        pnlCategories.Controls.Add(btnCatDesserts)
        pnlCategories.Location = New Point(30, 60)
        pnlCategories.Name = "pnlCategories"
        pnlCategories.Size = New Size(540, 50)
        pnlCategories.TabIndex = 1
        ' 
        ' btnCatBurgers
        ' 
        btnCatBurgers.BackColor = Color.FromArgb(20, 20, 20)
        btnCatBurgers.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnCatBurgers.FlatAppearance.BorderSize = 2
        btnCatBurgers.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20)
        btnCatBurgers.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20)
        btnCatBurgers.FlatStyle = FlatStyle.Flat
        btnCatBurgers.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCatBurgers.ForeColor = Color.White
        btnCatBurgers.Location = New Point(8, 8)
        btnCatBurgers.Margin = New Padding(8)
        btnCatBurgers.Name = "btnCatBurgers"
        btnCatBurgers.Size = New Size(164, 35)
        btnCatBurgers.TabIndex = 0
        btnCatBurgers.Text = "🍔 Meals"
        btnCatBurgers.UseVisualStyleBackColor = False
        ' 
        ' btnCatDrinks
        ' 
        btnCatDrinks.BackColor = Color.FromArgb(20, 20, 20)
        btnCatDrinks.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnCatDrinks.FlatAppearance.BorderSize = 2
        btnCatDrinks.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20)
        btnCatDrinks.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20)
        btnCatDrinks.FlatStyle = FlatStyle.Flat
        btnCatDrinks.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCatDrinks.ForeColor = Color.White
        btnCatDrinks.Location = New Point(188, 8)
        btnCatDrinks.Margin = New Padding(8)
        btnCatDrinks.Name = "btnCatDrinks"
        btnCatDrinks.Size = New Size(164, 35)
        btnCatDrinks.TabIndex = 1
        btnCatDrinks.Text = ChrW(55358) + ChrW(56676) + " Drinks"
        btnCatDrinks.UseVisualStyleBackColor = False
        ' 
        ' btnCatDesserts
        ' 
        btnCatDesserts.BackColor = Color.FromArgb(20, 20, 20)
        btnCatDesserts.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnCatDesserts.FlatAppearance.BorderSize = 2
        btnCatDesserts.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20)
        btnCatDesserts.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20)
        btnCatDesserts.FlatStyle = FlatStyle.Flat
        btnCatDesserts.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCatDesserts.ForeColor = Color.White
        btnCatDesserts.Location = New Point(368, 8)
        btnCatDesserts.Margin = New Padding(8)
        btnCatDesserts.Name = "btnCatDesserts"
        btnCatDesserts.Size = New Size(164, 35)
        btnCatDesserts.TabIndex = 2
        btnCatDesserts.Text = "🍦 Desserts"
        btnCatDesserts.UseVisualStyleBackColor = False
        ' 
        ' flpMenuGrid
        ' 
        flpMenuGrid.AutoScroll = True
        flpMenuGrid.BackColor = Color.FromArgb(35, 35, 35)
        flpMenuGrid.BorderStyle = BorderStyle.FixedSingle
        flpMenuGrid.Location = New Point(30, 120)
        flpMenuGrid.Name = "flpMenuGrid"
        flpMenuGrid.Size = New Size(540, 305)
        flpMenuGrid.TabIndex = 2
        ' 
        ' pnlCartContainer
        ' 
        pnlCartContainer.BackColor = Color.FromArgb(35, 35, 35)
        pnlCartContainer.BorderStyle = BorderStyle.FixedSingle
        pnlCartContainer.Controls.Add(lblCartHeader)
        pnlCartContainer.Controls.Add(flpCartItems)
        pnlCartContainer.Controls.Add(lblTaxLabel)
        pnlCartContainer.Controls.Add(lblTaxValue)
        pnlCartContainer.Controls.Add(lblTotalLabel)
        pnlCartContainer.Controls.Add(lblTotalValue)
        pnlCartContainer.Controls.Add(btnPay)
        pnlCartContainer.Controls.Add(btnBack)
        pnlCartContainer.Location = New Point(585, 15)
        pnlCartContainer.Name = "pnlCartContainer"
        pnlCartContainer.Size = New Size(340, 410)
        pnlCartContainer.TabIndex = 3
        ' 
        ' lblCartHeader
        ' 
        lblCartHeader.AutoSize = True
        lblCartHeader.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblCartHeader.ForeColor = Color.White
        lblCartHeader.Location = New Point(15, 12)
        lblCartHeader.Name = "lblCartHeader"
        lblCartHeader.Size = New Size(106, 20)
        lblCartHeader.TabIndex = 0
        lblCartHeader.Text = "Current Order"
        ' 
        ' flpCartItems
        ' 
        flpCartItems.AutoScroll = True
        flpCartItems.BackColor = Color.FromArgb(28, 28, 28)
        flpCartItems.Location = New Point(15, 45)
        flpCartItems.Name = "flpCartItems"
        flpCartItems.Size = New Size(308, 200)
        flpCartItems.TabIndex = 1
        ' 
        ' lblTaxLabel
        ' 
        lblTaxLabel.AutoSize = True
        lblTaxLabel.ForeColor = Color.DarkGray
        lblTaxLabel.Location = New Point(15, 258)
        lblTaxLabel.Name = "lblTaxLabel"
        lblTaxLabel.Size = New Size(57, 15)
        lblTaxLabel.TabIndex = 2
        lblTaxLabel.Text = "Tax (12%)"
        ' 
        ' lblTaxValue
        ' 
        lblTaxValue.AutoSize = True
        lblTaxValue.ForeColor = Color.White
        lblTaxValue.Location = New Point(255, 258)
        lblTaxValue.Name = "lblTaxValue"
        lblTaxValue.Size = New Size(35, 15)
        lblTaxValue.TabIndex = 3
        lblTaxValue.Text = "₱0.00"
        ' 
        ' lblTotalLabel
        ' 
        lblTotalLabel.AutoSize = True
        lblTotalLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTotalLabel.ForeColor = Color.White
        lblTotalLabel.Location = New Point(15, 285)
        lblTotalLabel.Name = "lblTotalLabel"
        lblTotalLabel.Size = New Size(44, 20)
        lblTotalLabel.TabIndex = 4
        lblTotalLabel.Text = "Total"
        ' 
        ' lblTotalValue
        ' 
        lblTotalValue.AutoSize = True
        lblTotalValue.Font = New Font("Segoe UI", 12.25F, FontStyle.Bold)
        lblTotalValue.ForeColor = Color.LimeGreen
        lblTotalValue.Location = New Point(220, 283)
        lblTotalValue.Name = "lblTotalValue"
        lblTotalValue.Size = New Size(56, 23)
        lblTotalValue.TabIndex = 5
        lblTotalValue.Text = "₱0.00"
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.FromArgb(20, 20, 20)
        btnPay.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnPay.FlatAppearance.BorderSize = 2
        btnPay.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20)
        btnPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20)
        btnPay.FlatStyle = FlatStyle.Flat
        btnPay.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnPay.ForeColor = Color.White
        btnPay.Location = New Point(15, 320)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(145, 38)
        btnPay.TabIndex = 6
        btnPay.Text = "CHECKOUT"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(20, 20, 20)
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(190, 20, 20)
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20)
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(175, 320)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(145, 38)
        btnBack.TabIndex = 7
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FPkiosk
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(940, 440)
        Controls.Add(pnlCartContainer)
        Controls.Add(flpMenuGrid)
        Controls.Add(pnlCategories)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPkiosk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPkiosk"
        pnlCategories.ResumeLayout(False)
        pnlCartContainer.ResumeLayout(False)
        pnlCartContainer.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlCategories As FlowLayoutPanel
    Friend WithEvents btnCatBurgers As Button
    Friend WithEvents btnCatDrinks As Button
    Friend WithEvents btnCatDesserts As Button
    Friend WithEvents flpMenuGrid As FlowLayoutPanel
    Friend WithEvents pnlCartContainer As Panel
    Friend WithEvents lblCartHeader As Label
    Friend WithEvents flpCartItems As FlowLayoutPanel
    Friend WithEvents lblTaxLabel As Label
    Friend WithEvents lblTaxValue As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents btnBack As Button
End Class
