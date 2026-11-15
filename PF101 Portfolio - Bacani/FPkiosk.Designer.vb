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
        lstMenu = New ListBox()
        lstCart = New ListBox()
        lblMenu = New Label()
        lblCart = New Label()
        btnAddCart = New Button()
        btnRemoveCart = New Button()
        btnCheckout = New Button()
        btnBack = New Button()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(300, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(198, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SELF-ORDER KIOSK"
        ' 
        ' lstMenu
        ' 
        lstMenu.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lstMenu.ForeColor = Color.White
        lstMenu.FormattingEnabled = True
        lstMenu.ItemHeight = 15
        lstMenu.Location = New Point(30, 80)
        lstMenu.Name = "lstMenu"
        lstMenu.Size = New Size(320, 229)
        lstMenu.TabIndex = 1
        ' 
        ' lstCart
        ' 
        lstCart.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lstCart.ForeColor = Color.White
        lstCart.FormattingEnabled = True
        lstCart.ItemHeight = 15
        lstCart.Location = New Point(440, 80)
        lstCart.Name = "lstCart"
        lstCart.Size = New Size(320, 229)
        lstCart.TabIndex = 2
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.ForeColor = Color.White
        lblMenu.Location = New Point(30, 60)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(81, 15)
        lblMenu.TabIndex = 3
        lblMenu.Text = "Available Menu"
        ' 
        ' lblCart
        ' 
        lblCart.AutoSize = True
        lblCart.ForeColor = Color.White
        lblCart.Location = New Point(440, 60)
        lblCart.Name = "lblCart"
        lblCart.Size = New Size(62, 15)
        lblCart.TabIndex = 4
        lblCart.Text = "Current Cart"
        ' 
        ' btnAddCart
        ' 
        btnAddCart.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAddCart.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnAddCart.FlatAppearance.BorderSize = 2
        btnAddCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAddCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAddCart.FlatStyle = FlatStyle.Flat
        btnAddCart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAddCart.ForeColor = Color.White
        btnAddCart.Location = New Point(30, 325)
        btnAddCart.Name = "btnAddCart"
        btnAddCart.Size = New Size(150, 30)
        btnAddCart.TabIndex = 5
        btnAddCart.Text = "ADD TO CART"
        btnAddCart.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveCart
        ' 
        btnRemoveCart.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnRemoveCart.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnRemoveCart.FlatAppearance.BorderSize = 2
        btnRemoveCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnRemoveCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnRemoveCart.FlatStyle = FlatStyle.Flat
        btnRemoveCart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnRemoveCart.ForeColor = Color.White
        btnRemoveCart.Location = New Point(200, 325)
        btnRemoveCart.Name = "btnRemoveCart"
        btnRemoveCart.Size = New Size(150, 30)
        btnRemoveCart.TabIndex = 6
        btnRemoveCart.Text = "REMOVE ITEM"
        btnRemoveCart.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnCheckout.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnCheckout.FlatAppearance.BorderSize = 2
        btnCheckout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnCheckout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnCheckout.ForeColor = Color.White
        btnCheckout.Location = New Point(440, 325)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(150, 30)
        btnCheckout.TabIndex = 7
        btnCheckout.Text = "CHECKOUT"
        btnCheckout.UseVisualStyleBackColor = False
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
        btnBack.Location = New Point(610, 325)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(150, 30)
        btnBack.TabIndex = 8
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.LimeGreen
        lblTotal.Location = New Point(440, 375)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(117, 21)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total: ₱0.00"
        ' 
        ' FPkiosk
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(btnBack)
        Controls.Add(btnCheckout)
        Controls.Add(btnRemoveCart)
        Controls.Add(btnAddCart)
        Controls.Add(lblCart)
        Controls.Add(lblMenu)
        Controls.Add(lstCart)
        Controls.Add(lstMenu)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FPkiosk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FPkiosk"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstMenu As ListBox
    Friend WithEvents lstCart As ListBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblCart As Label
    Friend WithEvents btnAddCart As Button
    Friend WithEvents btnRemoveCart As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTotal As Label
End Class