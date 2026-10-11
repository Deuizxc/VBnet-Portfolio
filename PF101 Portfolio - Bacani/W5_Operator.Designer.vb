<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W5_Operator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W5_Operator))
        Button1 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        txtMinutes = New TextBox()
        btnCalcDivision = New Button()
        lblNormalDiv = New Label()
        lblIntDiv = New Label()
        lblMod = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button7 = New Button()
        Label3 = New Label()
        Button8 = New Button()
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
        RichTextBox1.Location = New Point(119, 75)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(234, 326)
        RichTextBox1.TabIndex = 30
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' txtMinutes
        ' 
        txtMinutes.Location = New Point(401, 292)
        txtMinutes.Name = "txtMinutes"
        txtMinutes.Size = New Size(121, 23)
        txtMinutes.TabIndex = 31
        ' 
        ' btnCalcDivision
        ' 
        btnCalcDivision.BackColor = Color.Black
        btnCalcDivision.BackgroundImage = CType(resources.GetObject("btnCalcDivision.BackgroundImage"), Image)
        btnCalcDivision.BackgroundImageLayout = ImageLayout.Stretch
        btnCalcDivision.FlatAppearance.BorderSize = 0
        btnCalcDivision.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnCalcDivision.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCalcDivision.FlatStyle = FlatStyle.Flat
        btnCalcDivision.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalcDivision.ForeColor = Color.WhiteSmoke
        btnCalcDivision.Location = New Point(415, 324)
        btnCalcDivision.Name = "btnCalcDivision"
        btnCalcDivision.Size = New Size(92, 39)
        btnCalcDivision.TabIndex = 32
        btnCalcDivision.UseVisualStyleBackColor = False
        ' 
        ' lblNormalDiv
        ' 
        lblNormalDiv.AutoSize = True
        lblNormalDiv.BackColor = Color.Black
        lblNormalDiv.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNormalDiv.ForeColor = Color.White
        lblNormalDiv.Location = New Point(548, 292)
        lblNormalDiv.Name = "lblNormalDiv"
        lblNormalDiv.Size = New Size(85, 16)
        lblNormalDiv.TabIndex = 33
        lblNormalDiv.Text = "Normal (/) : -"
        ' 
        ' lblIntDiv
        ' 
        lblIntDiv.AutoSize = True
        lblIntDiv.BackColor = Color.Black
        lblIntDiv.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIntDiv.ForeColor = Color.White
        lblIntDiv.Location = New Point(549, 318)
        lblIntDiv.Name = "lblIntDiv"
        lblIntDiv.Size = New Size(84, 16)
        lblIntDiv.TabIndex = 34
        lblIntDiv.Text = "Integer (\) : -"
        ' 
        ' lblMod
        ' 
        lblMod.AutoSize = True
        lblMod.BackColor = Color.Black
        lblMod.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMod.ForeColor = Color.White
        lblMod.Location = New Point(549, 347)
        lblMod.Name = "lblMod"
        lblMod.Size = New Size(132, 16)
        lblMod.TabIndex = 35
        lblMod.Text = "Mod (Remainder) : -"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(473, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 20)
        Label2.TabIndex = 37
        Label2.Text = "ARITHMETIC CALCULATOR"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(433, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 38
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(597, 75)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 39
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(433, 123)
        Button3.Name = "Button3"
        Button3.Size = New Size(45, 27)
        Button3.TabIndex = 41
        Button3.Text = "+"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(597, 123)
        Button4.Name = "Button4"
        Button4.Size = New Size(45, 27)
        Button4.TabIndex = 42
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(539, 123)
        Button5.Name = "Button5"
        Button5.Size = New Size(45, 27)
        Button5.TabIndex = 43
        Button5.Text = "*"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.White
        Button7.Location = New Point(484, 123)
        Button7.Name = "Button7"
        Button7.Size = New Size(45, 27)
        Button7.TabIndex = 44
        Button7.Text = "-"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(415, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 45
        Label3.Text = "Results: -"
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button8.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(652, 123)
        Button8.Name = "Button8"
        Button8.Size = New Size(45, 27)
        Button8.TabIndex = 46
        Button8.Text = "^"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(493, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 20)
        Label1.TabIndex = 47
        Label1.Text = "MINUTE CALCULATOR"
        ' 
        ' W5_Operator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button8)
        Controls.Add(Label3)
        Controls.Add(Button7)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(lblMod)
        Controls.Add(lblIntDiv)
        Controls.Add(txtMinutes)
        Controls.Add(lblNormalDiv)
        Controls.Add(btnCalcDivision)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W5_Operator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W5_Operator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents btnCalcDivision As Button
    Friend WithEvents lblNormalDiv As Label
    Friend WithEvents lblIntDiv As Label
    Friend WithEvents lblMod As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
End Class
