<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W8_File
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W8_File))
        Button1 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        lblHeader = New Label()
        tvCategories = New TreeView()
        lvDetails = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        btnExpand = New Button()
        btnToggle = New Button()
        lblFeedback = New Label()
        Label1 = New Label()
        Label2 = New Label()
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
        Button1.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
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
        Button6.TabIndex = 22
        Button6.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(130, 79)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(267, 322)
        RichTextBox1.TabIndex = 37
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.BackColor = Color.Transparent
        lblHeader.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(485, 25)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(220, 20)
        lblHeader.TabIndex = 42
        lblHeader.Text = "HIERARCHY AND LIST INSPECTOR"
        ' 
        ' tvCategories
        ' 
        tvCategories.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        tvCategories.BorderStyle = BorderStyle.FixedSingle
        tvCategories.ForeColor = Color.White
        tvCategories.LineColor = Color.Gray
        tvCategories.Location = New Point(440, 79)
        tvCategories.Name = "tvCategories"
        tvCategories.Size = New Size(300, 138)
        tvCategories.TabIndex = 43
        ' 
        ' lvDetails
        ' 
        lvDetails.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        lvDetails.BorderStyle = BorderStyle.FixedSingle
        lvDetails.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lvDetails.ForeColor = Color.White
        lvDetails.FullRowSelect = True
        lvDetails.GridLines = True
        lvDetails.Location = New Point(440, 255)
        lvDetails.Name = "lvDetails"
        lvDetails.Size = New Size(310, 95)
        lvDetails.TabIndex = 44
        lvDetails.UseCompatibleStateImageBehavior = False
        lvDetails.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Item"
        ColumnHeader1.Width = 65
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Type"
        ColumnHeader2.Width = 80
        ' 
        ' btnExpand
        ' 
        btnExpand.BackColor = Color.Black
        btnExpand.FlatStyle = FlatStyle.Flat
        btnExpand.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExpand.ForeColor = Color.White
        btnExpand.Location = New Point(498, 360)
        btnExpand.Name = "btnExpand"
        btnExpand.Size = New Size(81, 24)
        btnExpand.TabIndex = 48
        btnExpand.Text = "Expand"
        btnExpand.UseVisualStyleBackColor = False
        ' 
        ' btnToggle
        ' 
        btnToggle.BackColor = Color.Black
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToggle.ForeColor = Color.White
        btnToggle.Location = New Point(602, 360)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(81, 24)
        btnToggle.TabIndex = 49
        btnToggle.Text = "Toggle view"
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' lblFeedback
        ' 
        lblFeedback.BackColor = Color.Transparent
        lblFeedback.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFeedback.ForeColor = Color.LimeGreen
        lblFeedback.Location = New Point(426, 387)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(334, 34)
        lblFeedback.TabIndex = 53
        lblFeedback.Text = "Executed: Ready"
        lblFeedback.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(440, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 54
        Label1.Text = "TreeView"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(440, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 55
        Label2.Text = "List View"
        ' 
        ' W8_File
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblFeedback)
        Controls.Add(btnToggle)
        Controls.Add(btnExpand)
        Controls.Add(lvDetails)
        Controls.Add(tvCategories)
        Controls.Add(lblHeader)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W8_File"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W8_File"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents tvCategories As TreeView
    Friend WithEvents lvDetails As ListView
    Friend WithEvents btnExpand As Button
    Friend WithEvents btnToggle As Button
    Friend WithEvents lblFeedback As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
