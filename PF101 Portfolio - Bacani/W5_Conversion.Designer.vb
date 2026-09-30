<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W5_Conversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W5_Conversion))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        txtInputNumber = New TextBox()
        btnConvertTest = New Button()
        lblParsed = New Label()
        lblIntConverted = New Label()
        lblDoubleImplicit = New Label()
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
        RichTextBox1.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(113, 39)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(284, 350)
        RichTextBox1.TabIndex = 29
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' txtInputNumber
        ' 
        txtInputNumber.BackColor = Color.White
        txtInputNumber.Location = New Point(496, 85)
        txtInputNumber.Name = "txtInputNumber"
        txtInputNumber.Size = New Size(124, 23)
        txtInputNumber.TabIndex = 30
        ' 
        ' btnConvertTest
        ' 
        btnConvertTest.BackColor = Color.Black
        btnConvertTest.FlatStyle = FlatStyle.Flat
        btnConvertTest.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConvertTest.ForeColor = Color.White
        btnConvertTest.Location = New Point(519, 124)
        btnConvertTest.Name = "btnConvertTest"
        btnConvertTest.Size = New Size(75, 23)
        btnConvertTest.TabIndex = 31
        btnConvertTest.Text = "Convert"
        btnConvertTest.UseVisualStyleBackColor = False
        ' 
        ' lblParsed
        ' 
        lblParsed.AutoSize = True
        lblParsed.BackColor = Color.Black
        lblParsed.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblParsed.ForeColor = Color.White
        lblParsed.Location = New Point(429, 179)
        lblParsed.Name = "lblParsed"
        lblParsed.Size = New Size(141, 18)
        lblParsed.TabIndex = 32
        lblParsed.Text = "Parsed (Decimal): -"
        ' 
        ' lblIntConverted
        ' 
        lblIntConverted.AutoSize = True
        lblIntConverted.BackColor = Color.Black
        lblIntConverted.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIntConverted.ForeColor = Color.White
        lblIntConverted.Location = New Point(429, 219)
        lblIntConverted.Name = "lblIntConverted"
        lblIntConverted.Size = New Size(135, 18)
        lblIntConverted.TabIndex = 33
        lblIntConverted.Text = "Convert.ToInt32: -"
        ' 
        ' lblDoubleImplicit
        ' 
        lblDoubleImplicit.AutoSize = True
        lblDoubleImplicit.BackColor = Color.Black
        lblDoubleImplicit.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDoubleImplicit.ForeColor = Color.White
        lblDoubleImplicit.Location = New Point(429, 257)
        lblDoubleImplicit.Name = "lblDoubleImplicit"
        lblDoubleImplicit.Size = New Size(136, 18)
        lblDoubleImplicit.TabIndex = 34
        lblDoubleImplicit.Text = "Implicit (Double): -"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(496, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 19)
        Label1.TabIndex = 35
        Label1.Text = "Input a decimal"
        ' 
        ' W5_Conversion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblDoubleImplicit)
        Controls.Add(lblIntConverted)
        Controls.Add(lblParsed)
        Controls.Add(btnConvertTest)
        Controls.Add(txtInputNumber)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W5_Conversion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W5_Conversion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtInputNumber As TextBox
    Friend WithEvents btnConvertTest As Button
    Friend WithEvents lblParsed As Label
    Friend WithEvents lblIntConverted As Label
    Friend WithEvents lblDoubleImplicit As Label
    Friend WithEvents Label1 As Label
End Class
