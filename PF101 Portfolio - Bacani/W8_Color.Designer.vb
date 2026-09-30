<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W8_Color
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W8_Color))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        btnColor = New Button()
        btnFont = New Button()
        btnReset = New Button()
        lblColorInfo = New Label()
        lblFontInfo = New Label()
        lblSample = New Label()
        lblFeedback = New Label()
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
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(686, 418)
        Button7.Name = "Button7"
        Button7.Size = New Size(93, 20)
        Button7.TabIndex = 23
        Button7.UseVisualStyleBackColor = False
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
        Button6.TabIndex = 24
        Button6.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(128, 47)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(266, 343)
        RichTextBox1.TabIndex = 37
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(467, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(247, 20)
        Label2.TabIndex = 41
        Label2.Text = "COLOR AND FONT FORMATTER DEMO"
        ' 
        ' btnColor
        ' 
        btnColor.BackColor = Color.Black
        btnColor.FlatStyle = FlatStyle.Flat
        btnColor.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnColor.ForeColor = Color.White
        btnColor.Location = New Point(443, 199)
        btnColor.Name = "btnColor"
        btnColor.Size = New Size(90, 25)
        btnColor.TabIndex = 47
        btnColor.Text = "Change color"
        btnColor.UseVisualStyleBackColor = False
        ' 
        ' btnFont
        ' 
        btnFont.BackColor = Color.Black
        btnFont.FlatStyle = FlatStyle.Flat
        btnFont.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFont.ForeColor = Color.White
        btnFont.Location = New Point(539, 199)
        btnFont.Name = "btnFont"
        btnFont.Size = New Size(90, 25)
        btnFont.TabIndex = 48
        btnFont.Text = "Change font"
        btnFont.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Black
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(635, 199)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(90, 25)
        btnReset.TabIndex = 49
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' lblColorInfo
        ' 
        lblColorInfo.AutoSize = True
        lblColorInfo.BackColor = Color.Transparent
        lblColorInfo.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblColorInfo.ForeColor = Color.White
        lblColorInfo.Location = New Point(443, 250)
        lblColorInfo.Name = "lblColorInfo"
        lblColorInfo.Size = New Size(84, 20)
        lblColorInfo.TabIndex = 50
        lblColorInfo.Text = "Color: White"
        ' 
        ' lblFontInfo
        ' 
        lblFontInfo.AutoSize = True
        lblFontInfo.BackColor = Color.Transparent
        lblFontInfo.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFontInfo.ForeColor = Color.White
        lblFontInfo.Location = New Point(443, 279)
        lblFontInfo.Name = "lblFontInfo"
        lblFontInfo.Size = New Size(130, 20)
        lblFontInfo.TabIndex = 51
        lblFontInfo.Text = "Font: Segoe UI, 11pt"
        ' 
        ' lblSample
        ' 
        lblSample.BackColor = Color.Transparent
        lblSample.BorderStyle = BorderStyle.FixedSingle
        lblSample.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSample.ForeColor = Color.White
        lblSample.Location = New Point(443, 126)
        lblSample.Name = "lblSample"
        lblSample.Size = New Size(282, 37)
        lblSample.TabIndex = 52
        lblSample.Text = "Take your heart"
        lblSample.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFeedback
        ' 
        lblFeedback.BackColor = Color.Transparent
        lblFeedback.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFeedback.ForeColor = Color.LimeGreen
        lblFeedback.Location = New Point(443, 308)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(282, 44)
        lblFeedback.TabIndex = 53
        lblFeedback.Text = "Executed: Ready"
        ' 
        ' W8_Color
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblFeedback)
        Controls.Add(lblSample)
        Controls.Add(lblFontInfo)
        Controls.Add(lblColorInfo)
        Controls.Add(btnReset)
        Controls.Add(btnFont)
        Controls.Add(btnColor)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W8_Color"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W8_Color"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnColor As Button
    Friend WithEvents btnFont As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblColorInfo As Label
    Friend WithEvents lblFontInfo As Label
    Friend WithEvents lblSample As Label
    Friend WithEvents lblFeedback As Label
End Class
