<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W10_Errors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W10_Errors))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        lblSynTitle = New Label()
        lblSynCode = New Label()
        chkSynFix = New CheckBox()
        btnSynTest = New Button()
        lblRunTitle = New Label()
        cboRunDrive = New ComboBox()
        btnRunTest = New Button()
        lblLogTitle = New Label()
        lblLogMath = New Label()
        chkLogFix = New CheckBox()
        btnLogTest = New Button()
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(420, 34)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(239, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "ERROR DIAGNOSTICS SANDBOX"
        ' 
        ' lblSynTitle
        ' 
        lblSynTitle.AutoSize = True
        lblSynTitle.BackColor = Color.Transparent
        lblSynTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSynTitle.ForeColor = Color.LightGray
        lblSynTitle.Location = New Point(420, 56)
        lblSynTitle.Name = "lblSynTitle"
        lblSynTitle.Size = New Size(110, 15)
        lblSynTitle.TabIndex = 27
        lblSynTitle.Text = "1. Syntax Validator"
        ' 
        ' lblSynCode
        ' 
        lblSynCode.AutoSize = True
        lblSynCode.BackColor = Color.Transparent
        lblSynCode.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSynCode.ForeColor = Color.Orange
        lblSynCode.Location = New Point(420, 81)
        lblSynCode.Name = "lblSynCode"
        lblSynCode.Size = New Size(223, 13)
        lblSynCode.TabIndex = 28
        lblSynCode.Text = "Dim msg As String = ""Hello Metaverse"
        ' 
        ' chkSynFix
        ' 
        chkSynFix.AutoSize = True
        chkSynFix.BackColor = Color.Transparent
        chkSynFix.ForeColor = Color.White
        chkSynFix.Location = New Point(420, 97)
        chkSynFix.Name = "chkSynFix"
        chkSynFix.Size = New Size(76, 19)
        chkSynFix.TabIndex = 29
        chkSynFix.Text = "Fix Quote"
        chkSynFix.UseVisualStyleBackColor = False
        ' 
        ' btnSynTest
        ' 
        btnSynTest.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        btnSynTest.FlatStyle = FlatStyle.Flat
        btnSynTest.ForeColor = Color.White
        btnSynTest.Location = New Point(555, 97)
        btnSynTest.Name = "btnSynTest"
        btnSynTest.Size = New Size(125, 25)
        btnSynTest.TabIndex = 30
        btnSynTest.Text = "Compile Code"
        btnSynTest.UseVisualStyleBackColor = False
        ' 
        ' lblRunTitle
        ' 
        lblRunTitle.AutoSize = True
        lblRunTitle.BackColor = Color.Transparent
        lblRunTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRunTitle.ForeColor = Color.LightGray
        lblRunTitle.Location = New Point(420, 128)
        lblRunTitle.Name = "lblRunTitle"
        lblRunTitle.Size = New Size(122, 15)
        lblRunTitle.TabIndex = 31
        lblRunTitle.Text = "2. Run-Time I/O Test"
        ' 
        ' cboRunDrive
        ' 
        cboRunDrive.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cboRunDrive.DropDownStyle = ComboBoxStyle.DropDownList
        cboRunDrive.FlatStyle = FlatStyle.Flat
        cboRunDrive.ForeColor = Color.White
        cboRunDrive.FormattingEnabled = True
        cboRunDrive.Location = New Point(420, 154)
        cboRunDrive.Name = "cboRunDrive"
        cboRunDrive.Size = New Size(135, 23)
        cboRunDrive.TabIndex = 32
        ' 
        ' btnRunTest
        ' 
        btnRunTest.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        btnRunTest.FlatStyle = FlatStyle.Flat
        btnRunTest.ForeColor = Color.White
        btnRunTest.Location = New Point(580, 152)
        btnRunTest.Name = "btnRunTest"
        btnRunTest.Size = New Size(100, 25)
        btnRunTest.TabIndex = 33
        btnRunTest.Text = "Fetch File"
        btnRunTest.UseVisualStyleBackColor = False
        ' 
        ' lblLogTitle
        ' 
        lblLogTitle.AutoSize = True
        lblLogTitle.BackColor = Color.Transparent
        lblLogTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogTitle.ForeColor = Color.LightGray
        lblLogTitle.Location = New Point(420, 195)
        lblLogTitle.Name = "lblLogTitle"
        lblLogTitle.Size = New Size(149, 15)
        lblLogTitle.TabIndex = 34
        lblLogTitle.Text = "3. Logic Error (Total Price)"
        ' 
        ' lblLogMath
        ' 
        lblLogMath.AutoSize = True
        lblLogMath.BackColor = Color.Transparent
        lblLogMath.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogMath.ForeColor = Color.DodgerBlue
        lblLogMath.Location = New Point(420, 214)
        lblLogMath.Name = "lblLogMath"
        lblLogMath.Size = New Size(199, 13)
        lblLogMath.TabIndex = 35
        lblLogMath.Text = "Code: Total = Price(50) - Tax(5)"
        ' 
        ' chkLogFix
        ' 
        chkLogFix.AutoSize = True
        chkLogFix.BackColor = Color.Transparent
        chkLogFix.ForeColor = Color.White
        chkLogFix.Location = New Point(420, 231)
        chkLogFix.Name = "chkLogFix"
        chkLogFix.Size = New Size(90, 19)
        chkLogFix.TabIndex = 36
        chkLogFix.Text = "Fix Operator"
        chkLogFix.UseVisualStyleBackColor = False
        ' 
        ' btnLogTest
        ' 
        btnLogTest.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        btnLogTest.FlatStyle = FlatStyle.Flat
        btnLogTest.ForeColor = Color.White
        btnLogTest.Location = New Point(534, 234)
        btnLogTest.Name = "btnLogTest"
        btnLogTest.Size = New Size(125, 25)
        btnLogTest.TabIndex = 37
        btnLogTest.Text = "Execute Math"
        btnLogTest.UseVisualStyleBackColor = False
        ' 
        ' rtbOutput
        ' 
        rtbOutput.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        rtbOutput.BorderStyle = BorderStyle.None
        rtbOutput.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbOutput.ForeColor = Color.LimeGreen
        rtbOutput.Location = New Point(420, 279)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ReadOnly = True
        rtbOutput.Size = New Size(284, 119)
        rtbOutput.TabIndex = 38
        rtbOutput.Text = ""
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(122, 55)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(271, 329)
        RichTextBox1.TabIndex = 39
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W10_Errors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbOutput)
        Controls.Add(btnLogTest)
        Controls.Add(chkLogFix)
        Controls.Add(lblLogMath)
        Controls.Add(lblLogTitle)
        Controls.Add(btnRunTest)
        Controls.Add(cboRunDrive)
        Controls.Add(lblRunTitle)
        Controls.Add(btnSynTest)
        Controls.Add(chkSynFix)
        Controls.Add(lblSynCode)
        Controls.Add(lblSynTitle)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W10_Errors"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W10_Errors"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents rtbDocs As RichTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSynTitle As Label
    Friend WithEvents lblSynCode As Label
    Friend WithEvents chkSynFix As CheckBox
    Friend WithEvents btnSynTest As Button
    Friend WithEvents lblRunTitle As Label
    Friend WithEvents cboRunDrive As ComboBox
    Friend WithEvents btnRunTest As Button
    Friend WithEvents lblLogTitle As Label
    Friend WithEvents lblLogMath As Label
    Friend WithEvents chkLogFix As CheckBox
    Friend WithEvents btnLogTest As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class