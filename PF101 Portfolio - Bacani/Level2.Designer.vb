<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level2))
        Button1 = New Button()
        lblAttempts = New Label()
        lblSecurityLevel = New Label()
        txtPin1 = New TextBox()
        btnDecrypt = New Button()
        btnAbort = New Button()
        txtPin2 = New TextBox()
        txtPin3 = New PictureBox()
        TextBox2 = New TextBox()
        lstLog = New RichTextBox()
        lose = New Panel()
        Button7 = New Button()
        win = New Panel()
        Button2 = New Button()
        CType(txtPin3, ComponentModel.ISupportInitialize).BeginInit()
        lose.SuspendLayout()
        win.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
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
        Button1.TabIndex = 24
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblAttempts
        ' 
        lblAttempts.BackColor = Color.Black
        lblAttempts.FlatStyle = FlatStyle.System
        lblAttempts.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttempts.ForeColor = Color.White
        lblAttempts.Location = New Point(513, 290)
        lblAttempts.Name = "lblAttempts"
        lblAttempts.Size = New Size(203, 25)
        lblAttempts.TabIndex = 30
        lblAttempts.Text = "ATTEMPTS: -"
        lblAttempts.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSecurityLevel
        ' 
        lblSecurityLevel.BackColor = Color.Black
        lblSecurityLevel.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSecurityLevel.ForeColor = Color.Red
        lblSecurityLevel.Location = New Point(743, 290)
        lblSecurityLevel.Name = "lblSecurityLevel"
        lblSecurityLevel.Size = New Size(202, 25)
        lblSecurityLevel.TabIndex = 31
        lblSecurityLevel.Text = "SECURITY LEVEL: -"
        lblSecurityLevel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtPin1
        ' 
        txtPin1.BackColor = Color.Black
        txtPin1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPin1.ForeColor = Color.White
        txtPin1.Location = New Point(601, 132)
        txtPin1.MaxLength = 1
        txtPin1.Name = "txtPin1"
        txtPin1.Size = New Size(45, 39)
        txtPin1.TabIndex = 34
        txtPin1.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnDecrypt
        ' 
        btnDecrypt.BackColor = Color.Black
        btnDecrypt.BackgroundImage = CType(resources.GetObject("btnDecrypt.BackgroundImage"), Image)
        btnDecrypt.BackgroundImageLayout = ImageLayout.Stretch
        btnDecrypt.FlatAppearance.BorderSize = 0
        btnDecrypt.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnDecrypt.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnDecrypt.FlatStyle = FlatStyle.Flat
        btnDecrypt.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDecrypt.ForeColor = Color.Transparent
        btnDecrypt.Location = New Point(590, 211)
        btnDecrypt.Name = "btnDecrypt"
        btnDecrypt.Size = New Size(114, 31)
        btnDecrypt.TabIndex = 37
        btnDecrypt.UseVisualStyleBackColor = False
        ' 
        ' btnAbort
        ' 
        btnAbort.BackColor = Color.Black
        btnAbort.BackgroundImage = CType(resources.GetObject("btnAbort.BackgroundImage"), Image)
        btnAbort.BackgroundImageLayout = ImageLayout.Stretch
        btnAbort.FlatAppearance.BorderSize = 0
        btnAbort.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnAbort.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnAbort.FlatStyle = FlatStyle.Flat
        btnAbort.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAbort.ForeColor = Color.Transparent
        btnAbort.Location = New Point(753, 211)
        btnAbort.Name = "btnAbort"
        btnAbort.Size = New Size(114, 31)
        btnAbort.TabIndex = 40
        btnAbort.UseVisualStyleBackColor = False
        ' 
        ' txtPin2
        ' 
        txtPin2.BackColor = Color.Black
        txtPin2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPin2.ForeColor = Color.White
        txtPin2.Location = New Point(705, 132)
        txtPin2.MaxLength = 1
        txtPin2.Name = "txtPin2"
        txtPin2.Size = New Size(45, 39)
        txtPin2.TabIndex = 41
        txtPin2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPin3
        ' 
        txtPin3.Dock = DockStyle.Fill
        txtPin3.Image = CType(resources.GetObject("txtPin3.Image"), Image)
        txtPin3.Location = New Point(0, 0)
        txtPin3.Name = "txtPin3"
        txtPin3.Size = New Size(1064, 559)
        txtPin3.SizeMode = PictureBoxSizeMode.StretchImage
        txtPin3.TabIndex = 0
        txtPin3.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(809, 132)
        TextBox2.MaxLength = 1
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(45, 39)
        TextBox2.TabIndex = 42
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' lstLog
        ' 
        lstLog.BackColor = Color.Black
        lstLog.Font = New Font("Franklin Gothic Book", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lstLog.ForeColor = Color.White
        lstLog.Location = New Point(503, 328)
        lstLog.Name = "lstLog"
        lstLog.ReadOnly = True
        lstLog.Size = New Size(450, 96)
        lstLog.TabIndex = 43
        lstLog.Text = ""
        ' 
        ' lose
        ' 
        lose.BackColor = Color.Transparent
        lose.BackgroundImage = CType(resources.GetObject("lose.BackgroundImage"), Image)
        lose.BackgroundImageLayout = ImageLayout.Stretch
        lose.Controls.Add(Button7)
        lose.Location = New Point(601, 189)
        lose.Name = "lose"
        lose.Size = New Size(608, 407)
        lose.TabIndex = 44
        lose.Visible = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Red
        Button7.Location = New Point(274, 343)
        Button7.Name = "Button7"
        Button7.Size = New Size(66, 28)
        Button7.TabIndex = 16
        Button7.Tag = ""
        Button7.Text = "OK"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' win
        ' 
        win.BackColor = Color.Transparent
        win.BackgroundImage = CType(resources.GetObject("win.BackgroundImage"), Image)
        win.BackgroundImageLayout = ImageLayout.Stretch
        win.Controls.Add(Button2)
        win.Location = New Point(96, 481)
        win.Name = "win"
        win.Size = New Size(608, 407)
        win.TabIndex = 45
        win.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(269, 340)
        Button2.Name = "Button2"
        Button2.Size = New Size(66, 28)
        Button2.TabIndex = 16
        Button2.Tag = ""
        Button2.Text = "OK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Level2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1064, 559)
        Controls.Add(win)
        Controls.Add(lose)
        Controls.Add(lstLog)
        Controls.Add(TextBox2)
        Controls.Add(txtPin2)
        Controls.Add(btnAbort)
        Controls.Add(btnDecrypt)
        Controls.Add(txtPin1)
        Controls.Add(lblSecurityLevel)
        Controls.Add(lblAttempts)
        Controls.Add(Button1)
        Controls.Add(txtPin3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Level2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level2"
        CType(txtPin3, ComponentModel.ISupportInitialize).EndInit()
        lose.ResumeLayout(False)
        win.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents lblAttempts As Label
    Friend WithEvents lblSecurityLevel As Label
    Friend WithEvents txtPin1 As TextBox
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents btnAbort As Button
    Friend WithEvents txtPin2 As TextBox
    Friend WithEvents txtPin3 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lstLog As RichTextBox
    Friend WithEvents lose As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents win As Panel
    Friend WithEvents Button2 As Button
End Class
