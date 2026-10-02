<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W4_Layout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W4_Layout))
        Button1 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        testbox = New Panel()
        lblLayoutStatus = New Label()
        btnToggleLayout = New Button()
        Label1 = New Label()
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
        RichTextBox1.Font = New Font("Franklin Gothic Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(156, 84)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(280, 318)
        RichTextBox1.TabIndex = 33
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(556, 84)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(556, 113)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(106, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(556, 142)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(106, 23)
        TextBox3.TabIndex = 2
        ' 
        ' testbox
        ' 
        testbox.BackColor = Color.Cyan
        testbox.Location = New Point(562, 200)
        testbox.Name = "testbox"
        testbox.Size = New Size(100, 30)
        testbox.TabIndex = 34
        ' 
        ' lblLayoutStatus
        ' 
        lblLayoutStatus.BackColor = Color.Transparent
        lblLayoutStatus.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLayoutStatus.ForeColor = Color.White
        lblLayoutStatus.Location = New Point(491, 249)
        lblLayoutStatus.Name = "lblLayoutStatus"
        lblLayoutStatus.Size = New Size(227, 18)
        lblLayoutStatus.TabIndex = 35
        lblLayoutStatus.Text = "Status: Ready"
        lblLayoutStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnToggleLayout
        ' 
        btnToggleLayout.BackColor = Color.Transparent
        btnToggleLayout.BackgroundImage = CType(resources.GetObject("btnToggleLayout.BackgroundImage"), Image)
        btnToggleLayout.BackgroundImageLayout = ImageLayout.Stretch
        btnToggleLayout.FlatAppearance.BorderSize = 0
        btnToggleLayout.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnToggleLayout.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnToggleLayout.FlatStyle = FlatStyle.Flat
        btnToggleLayout.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToggleLayout.ForeColor = Color.White
        btnToggleLayout.Location = New Point(556, 284)
        btnToggleLayout.Name = "btnToggleLayout"
        btnToggleLayout.Size = New Size(106, 37)
        btnToggleLayout.TabIndex = 36
        btnToggleLayout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(531, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 18)
        Label1.TabIndex = 37
        Label1.Text = "Tab index"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' W4_Layout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnToggleLayout)
        Controls.Add(lblLayoutStatus)
        Controls.Add(testbox)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W4_Layout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W4_Layout"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents testbox As Panel
    Friend WithEvents lblLayoutStatus As Label
    Friend WithEvents btnToggleLayout As Button
    Friend WithEvents Label1 As Label
End Class
