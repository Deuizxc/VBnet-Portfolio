<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1112_Net
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1112_Net))
        Button1 = New Button()
        Button7 = New Button()
        cboLanguage = New ComboBox()
        btnCompile = New Button()
        rtbOutput = New RichTextBox()
        lblTitle = New Label()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
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
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(686, 418)
        Button7.Name = "Button7"
        Button7.Size = New Size(93, 20)
        Button7.TabIndex = 23
        Button7.UseVisualStyleBackColor = False
        ' 
        ' cboLanguage
        ' 
        cboLanguage.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        cboLanguage.DropDownStyle = ComboBoxStyle.DropDownList
        cboLanguage.ForeColor = Color.White
        cboLanguage.FormattingEnabled = True
        cboLanguage.Location = New Point(448, 48)
        cboLanguage.Name = "cboLanguage"
        cboLanguage.Size = New Size(220, 23)
        cboLanguage.TabIndex = 27
        ' 
        ' btnCompile
        ' 
        btnCompile.BackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnCompile.FlatStyle = FlatStyle.Flat
        btnCompile.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnCompile.ForeColor = Color.White
        btnCompile.Location = New Point(450, 89)
        btnCompile.Name = "btnCompile"
        btnCompile.Size = New Size(218, 31)
        btnCompile.TabIndex = 28
        btnCompile.Text = "Execute via CLR"
        btnCompile.UseVisualStyleBackColor = False
        ' 
        ' rtbOutput
        ' 
        rtbOutput.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        rtbOutput.BorderStyle = BorderStyle.None
        rtbOutput.ForeColor = Color.White
        rtbOutput.Location = New Point(450, 141)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ReadOnly = True
        rtbOutput.Size = New Size(218, 150)
        rtbOutput.TabIndex = 29
        rtbOutput.Text = ""
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(438, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(209, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "CLR COMPILATION TESTING"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(261, 372)
        Label1.Name = "Label1"
        Label1.Size = New Size(376, 36)
        Label1.TabIndex = 42
        Label1.Text = """See? Whether it's VB or C#, the Common Language Runtime (CLR) " & vbCrLf & "translates it into the same intermediate language!"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(132, 48)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(277, 156)
        RichTextBox1.TabIndex = 43
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W1112_Net
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Controls.Add(rtbOutput)
        Controls.Add(btnCompile)
        Controls.Add(cboLanguage)
        Controls.Add(lblTitle)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1112_Net"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W1112_Net"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents btnCompile As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class