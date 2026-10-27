<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1415_Archi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1415_Archi))
        Button1 = New Button()
        Button7 = New Button()
        lblTitle = New Label()
        grpApproaches = New GroupBox()
        rbApproach2 = New RadioButton()
        rbApproach1 = New RadioButton()
        btnBuild = New Button()
        rtbOutput = New RichTextBox()
        RichTextBox1 = New RichTextBox()
        grpApproaches.SuspendLayout()
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(419, 70)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(188, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "VIEWMODEL SIMULATOR"
        ' 
        ' grpApproaches
        ' 
        grpApproaches.BackColor = Color.Transparent
        grpApproaches.Controls.Add(rbApproach2)
        grpApproaches.Controls.Add(rbApproach1)
        grpApproaches.ForeColor = Color.LightGray
        grpApproaches.Location = New Point(419, 104)
        grpApproaches.Name = "grpApproaches"
        grpApproaches.Size = New Size(240, 75)
        grpApproaches.TabIndex = 27
        grpApproaches.TabStop = False
        grpApproaches.Text = "Builder Strategy"
        ' 
        ' rbApproach2
        ' 
        rbApproach2.AutoSize = True
        rbApproach2.ForeColor = Color.LimeGreen
        rbApproach2.Location = New Point(15, 45)
        rbApproach2.Name = "rbApproach2"
        rbApproach2.Size = New Size(166, 19)
        rbApproach2.TabIndex = 1
        rbApproach2.Text = "Appr. 2: Selective Mapping"
        rbApproach2.UseVisualStyleBackColor = True
        ' 
        ' rbApproach1
        ' 
        rbApproach1.AutoSize = True
        rbApproach1.ForeColor = Color.White
        rbApproach1.Location = New Point(15, 20)
        rbApproach1.Name = "rbApproach1"
        rbApproach1.Size = New Size(178, 19)
        rbApproach1.TabIndex = 0
        rbApproach1.Text = "Appr. 1: Direct Object Embed"
        rbApproach1.UseVisualStyleBackColor = True
        ' 
        ' btnBuild
        ' 
        btnBuild.BackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnBuild.FlatAppearance.BorderColor = Color.White
        btnBuild.FlatStyle = FlatStyle.Flat
        btnBuild.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBuild.ForeColor = Color.White
        btnBuild.Location = New Point(419, 200)
        btnBuild.Name = "btnBuild"
        btnBuild.Size = New Size(240, 30)
        btnBuild.TabIndex = 28
        btnBuild.Text = "Execute Builder()"
        btnBuild.UseVisualStyleBackColor = False
        ' 
        ' rtbOutput
        ' 
        rtbOutput.BackColor = Color.Black
        rtbOutput.BorderStyle = BorderStyle.None
        rtbOutput.Font = New Font("Consolas", 8.25F)
        rtbOutput.ForeColor = Color.White
        rtbOutput.Location = New Point(419, 250)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ReadOnly = True
        rtbOutput.ScrollBars = RichTextBoxScrollBars.None
        rtbOutput.Size = New Size(178, 143)
        rtbOutput.TabIndex = 29
        rtbOutput.Text = "> Waiting for build execution..."
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(101, 73)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(277, 320)
        RichTextBox1.TabIndex = 48
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W1415_Archi
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbOutput)
        Controls.Add(btnBuild)
        Controls.Add(grpApproaches)
        Controls.Add(lblTitle)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1415_Archi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W1415_Archi"
        grpApproaches.ResumeLayout(False)
        grpApproaches.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpApproaches As GroupBox
    Friend WithEvents rbApproach1 As RadioButton
    Friend WithEvents rbApproach2 As RadioButton
    Friend WithEvents btnBuild As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class