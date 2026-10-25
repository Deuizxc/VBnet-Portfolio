<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1112_String
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1112_String))
        Button1 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        txtInput = New TextBox()
        btnUCase = New Button()
        btnReverse = New Button()
        btnTrim = New Button()
        btnCurrency = New Button()
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
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(12, 418)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 20)
        Button6.TabIndex = 22
        Button6.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(453, 34)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(146, 21)
        lblTitle.TabIndex = 24
        lblTitle.Text = "STRING MUTATOR"
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtInput.BorderStyle = BorderStyle.FixedSingle
        txtInput.Font = New Font("Segoe UI", 11.0F)
        txtInput.ForeColor = Color.White
        txtInput.Location = New Point(453, 67)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(237, 27)
        txtInput.TabIndex = 25
        txtInput.Text = "Persona 5"
        ' 
        ' btnUCase
        ' 
        btnUCase.BackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnUCase.FlatStyle = FlatStyle.Flat
        btnUCase.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUCase.ForeColor = Color.White
        btnUCase.Location = New Point(453, 110)
        btnUCase.Name = "btnUCase"
        btnUCase.Size = New Size(111, 35)
        btnUCase.TabIndex = 26
        btnUCase.Text = "UCase()"
        btnUCase.UseVisualStyleBackColor = False
        ' 
        ' btnReverse
        ' 
        btnReverse.BackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnReverse.FlatStyle = FlatStyle.Flat
        btnReverse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnReverse.ForeColor = Color.White
        btnReverse.Location = New Point(579, 110)
        btnReverse.Name = "btnReverse"
        btnReverse.Size = New Size(111, 35)
        btnReverse.TabIndex = 27
        btnReverse.Text = "StrReverse()"
        btnReverse.UseVisualStyleBackColor = False
        ' 
        ' btnTrim
        ' 
        btnTrim.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnTrim.FlatStyle = FlatStyle.Flat
        btnTrim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTrim.ForeColor = Color.White
        btnTrim.Location = New Point(453, 155)
        btnTrim.Name = "btnTrim"
        btnTrim.Size = New Size(111, 35)
        btnTrim.TabIndex = 28
        btnTrim.Text = "Trim()"
        btnTrim.UseVisualStyleBackColor = False
        ' 
        ' btnCurrency
        ' 
        btnCurrency.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnCurrency.FlatStyle = FlatStyle.Flat
        btnCurrency.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnCurrency.ForeColor = Color.White
        btnCurrency.Location = New Point(579, 155)
        btnCurrency.Name = "btnCurrency"
        btnCurrency.Size = New Size(111, 35)
        btnCurrency.TabIndex = 29
        btnCurrency.Text = "FormatCurrency()"
        btnCurrency.UseVisualStyleBackColor = False
        ' 
        ' rtbOutput
        ' 
        rtbOutput.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        rtbOutput.BorderStyle = BorderStyle.None
        rtbOutput.Font = New Font("Segoe UI", 11.0F)
        rtbOutput.ForeColor = Color.White
        rtbOutput.Location = New Point(453, 213)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ReadOnly = True
        rtbOutput.Size = New Size(237, 98)
        rtbOutput.TabIndex = 30
        rtbOutput.Text = "> Waiting for string manipulation..."
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(139, 67)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(277, 295)
        RichTextBox1.TabIndex = 44
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W1112_String
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbOutput)
        Controls.Add(btnCurrency)
        Controls.Add(btnTrim)
        Controls.Add(btnReverse)
        Controls.Add(btnUCase)
        Controls.Add(txtInput)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1112_String"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W1112_String"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUCase As Button
    Friend WithEvents btnReverse As Button
    Friend WithEvents btnTrim As Button
    Friend WithEvents btnCurrency As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class