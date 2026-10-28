<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W10_Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W10_Classes))
        Button1 = New Button()
        Button7 = New Button()
        lblTitle = New Label()
        lblClassInfo = New Label()
        lblEngine = New Label()
        txtEngine = New TextBox()
        lblWheels = New Label()
        txtWheels = New TextBox()
        btnInstantiate = New Button()
        rtbOutput = New RichTextBox()
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(430, 38)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(253, 20)
        lblTitle.TabIndex = 25
        lblTitle.Text = "OBJECT INSTANTIATOR SANDBOX"
        ' 
        ' lblClassInfo
        ' 
        lblClassInfo.AutoSize = True
        lblClassInfo.BackColor = Color.Transparent
        lblClassInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClassInfo.ForeColor = Color.LightGray
        lblClassInfo.Location = New Point(429, 70)
        lblClassInfo.Name = "lblClassInfo"
        lblClassInfo.Size = New Size(191, 30)
        lblClassInfo.TabIndex = 26
        lblClassInfo.Text = "[ Abstract Class: Vehicle ]" & vbCrLf & "Derived Class: Car (Inherits Vehicle)"
        ' 
        ' lblEngine
        ' 
        lblEngine.AutoSize = True
        lblEngine.BackColor = Color.Transparent
        lblEngine.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEngine.ForeColor = Color.LightGray
        lblEngine.Location = New Point(429, 120)
        lblEngine.Name = "lblEngine"
        lblEngine.Size = New Size(92, 15)
        lblEngine.TabIndex = 27
        lblEngine.Text = "Engine Size (cc):"
        ' 
        ' txtEngine
        ' 
        txtEngine.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtEngine.BorderStyle = BorderStyle.FixedSingle
        txtEngine.ForeColor = Color.White
        txtEngine.Location = New Point(583, 118)
        txtEngine.Name = "txtEngine"
        txtEngine.Size = New Size(100, 23)
        txtEngine.TabIndex = 28
        txtEngine.Text = "2000"
        ' 
        ' lblWheels
        ' 
        lblWheels.AutoSize = True
        lblWheels.BackColor = Color.Transparent
        lblWheels.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWheels.ForeColor = Color.LightGray
        lblWheels.Location = New Point(429, 159)
        lblWheels.Name = "lblWheels"
        lblWheels.Size = New Size(109, 15)
        lblWheels.TabIndex = 29
        lblWheels.Text = "Number of Wheels:"
        ' 
        ' txtWheels
        ' 
        txtWheels.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtWheels.BorderStyle = BorderStyle.FixedSingle
        txtWheels.ForeColor = Color.White
        txtWheels.Location = New Point(583, 157)
        txtWheels.Name = "txtWheels"
        txtWheels.Size = New Size(100, 23)
        txtWheels.TabIndex = 30
        txtWheels.Text = "4"
        ' 
        ' btnInstantiate
        ' 
        btnInstantiate.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        btnInstantiate.FlatStyle = FlatStyle.Flat
        btnInstantiate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInstantiate.ForeColor = Color.White
        btnInstantiate.Location = New Point(462, 194)
        btnInstantiate.Name = "btnInstantiate"
        btnInstantiate.Size = New Size(210, 30)
        btnInstantiate.TabIndex = 31
        btnInstantiate.Text = "Instantiate Car Object (Sub New)"
        btnInstantiate.UseVisualStyleBackColor = False
        ' 
        ' rtbOutput
        ' 
        rtbOutput.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        rtbOutput.BorderStyle = BorderStyle.None
        rtbOutput.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbOutput.ForeColor = Color.LimeGreen
        rtbOutput.Location = New Point(462, 242)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ReadOnly = True
        rtbOutput.Size = New Size(210, 125)
        rtbOutput.TabIndex = 32
        rtbOutput.Text = ""
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(121, 54)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(271, 357)
        RichTextBox1.TabIndex = 38
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W10_Classes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbOutput)
        Controls.Add(btnInstantiate)
        Controls.Add(txtWheels)
        Controls.Add(lblWheels)
        Controls.Add(txtEngine)
        Controls.Add(lblEngine)
        Controls.Add(lblClassInfo)
        Controls.Add(lblTitle)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W10_Classes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W10_Classes"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblClassInfo As Label
    Friend WithEvents lblEngine As Label
    Friend WithEvents txtEngine As TextBox
    Friend WithEvents lblWheels As Label
    Friend WithEvents txtWheels As TextBox
    Friend WithEvents btnInstantiate As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class