<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1415_Dataset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1415_Dataset))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        btnFill = New Button()
        btnIterate = New Button()
        rtbTerminal = New RichTextBox()
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
        Button7.TabIndex = 24
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
        Button6.TabIndex = 25
        Button6.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(423, 56)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(200, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "ADAPTER FILL SIMULATOR"
        ' 
        ' btnFill
        ' 
        btnFill.BackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnFill.FlatAppearance.BorderColor = Color.White
        btnFill.FlatStyle = FlatStyle.Flat
        btnFill.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnFill.ForeColor = Color.White
        btnFill.Location = New Point(439, 92)
        btnFill.Name = "btnFill"
        btnFill.Size = New Size(240, 30)
        btnFill.TabIndex = 27
        btnFill.Text = "1. Execute da.Fill()"
        btnFill.UseVisualStyleBackColor = False
        ' 
        ' btnIterate
        ' 
        btnIterate.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnIterate.Enabled = False
        btnIterate.FlatAppearance.BorderColor = Color.White
        btnIterate.FlatStyle = FlatStyle.Flat
        btnIterate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnIterate.ForeColor = Color.White
        btnIterate.Location = New Point(439, 149)
        btnIterate.Name = "btnIterate"
        btnIterate.Size = New Size(240, 30)
        btnIterate.TabIndex = 28
        btnIterate.Text = "2. Iterate Disconnected Hierarchy"
        btnIterate.UseVisualStyleBackColor = False
        ' 
        ' rtbTerminal
        ' 
        rtbTerminal.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        rtbTerminal.BorderStyle = BorderStyle.FixedSingle
        rtbTerminal.Font = New Font("Consolas", 8.25F)
        rtbTerminal.ForeColor = Color.White
        rtbTerminal.Location = New Point(439, 213)
        rtbTerminal.Name = "rtbTerminal"
        rtbTerminal.ReadOnly = True
        rtbTerminal.ScrollBars = RichTextBoxScrollBars.None
        rtbTerminal.Size = New Size(240, 125)
        rtbTerminal.TabIndex = 29
        rtbTerminal.Text = "> System Ready..." & vbLf
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(135, 83)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(250, 255)
        RichTextBox1.TabIndex = 49
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W1415_Dataset
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbTerminal)
        Controls.Add(btnIterate)
        Controls.Add(btnFill)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1415_Dataset"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W1415_Dataset"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnFill As Button
    Friend WithEvents btnIterate As Button
    Friend WithEvents rtbTerminal As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class