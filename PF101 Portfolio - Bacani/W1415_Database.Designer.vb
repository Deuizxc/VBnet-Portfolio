<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1415_Database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1415_Database))
        Button1 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        cboKeyType = New ComboBox()
        btnSync = New Button()
        rtbTerminal = New RichTextBox()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 33)
        Button1.TabIndex = 13
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(12, 418)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 20)
        Button6.TabIndex = 25
        Button6.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(431, 42)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(139, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "SYNC DISPATCHER"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboKeyType
        ' 
        cboKeyType.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        cboKeyType.DropDownStyle = ComboBoxStyle.DropDownList
        cboKeyType.FlatStyle = FlatStyle.Flat
        cboKeyType.ForeColor = Color.White
        cboKeyType.FormattingEnabled = True
        cboKeyType.Location = New Point(431, 77)
        cboKeyType.Name = "cboKeyType"
        cboKeyType.Size = New Size(257, 23)
        cboKeyType.TabIndex = 27
        ' 
        ' btnSync
        ' 
        btnSync.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnSync.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnSync.FlatAppearance.BorderSize = 2
        btnSync.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnSync.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnSync.FlatStyle = FlatStyle.Flat
        btnSync.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSync.ForeColor = Color.White
        btnSync.Location = New Point(431, 121)
        btnSync.Name = "btnSync"
        btnSync.Size = New Size(257, 30)
        btnSync.TabIndex = 28
        btnSync.Text = "EXECUTE ADAPTER UPDATE"
        btnSync.UseVisualStyleBackColor = False
        ' 
        ' rtbTerminal
        ' 
        rtbTerminal.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        rtbTerminal.BorderStyle = BorderStyle.FixedSingle
        rtbTerminal.Font = New Font("Consolas", 8.25F)
        rtbTerminal.ForeColor = Color.White
        rtbTerminal.Location = New Point(431, 168)
        rtbTerminal.Name = "rtbTerminal"
        rtbTerminal.ReadOnly = True
        rtbTerminal.ScrollBars = RichTextBoxScrollBars.None
        rtbTerminal.Size = New Size(257, 135)
        rtbTerminal.TabIndex = 29
        rtbTerminal.Text = "> Queue empty..."
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(133, 62)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(245, 325)
        RichTextBox1.TabIndex = 48
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W1415_Database
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbTerminal)
        Controls.Add(btnSync)
        Controls.Add(cboKeyType)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1415_Database"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W1415_Database"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboKeyType As ComboBox
    Friend WithEvents btnSync As Button
    Friend WithEvents rtbTerminal As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class