' W10_Handling.Designer.vb
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W10_Handling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W10_Handling))
        Button1 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        lblOp = New Label()
        cboOp = New ComboBox()
        btnExecute = New Button()
        rtbOutput = New RichTextBox()
        RichTextBox1 = New RichTextBox()
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(478, 39)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(196, 17)
        lblTitle.TabIndex = 25
        lblTitle.Text = "EXCEPTION FLOW VISUALIZER"
        ' 
        ' lblOp
        ' 
        lblOp.AutoSize = True
        lblOp.BackColor = Color.Transparent
        lblOp.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOp.ForeColor = Color.LightGray
        lblOp.Location = New Point(478, 67)
        lblOp.Name = "lblOp"
        lblOp.Size = New Size(152, 15)
        lblOp.TabIndex = 26
        lblOp.Text = "Select Operation to Trace:"
        ' 
        ' cboOp
        ' 
        cboOp.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cboOp.DropDownStyle = ComboBoxStyle.DropDownList
        cboOp.FlatStyle = FlatStyle.Flat
        cboOp.ForeColor = Color.White
        cboOp.FormattingEnabled = True
        cboOp.Location = New Point(478, 101)
        cboOp.Name = "cboOp"
        cboOp.Size = New Size(233, 23)
        cboOp.TabIndex = 27
        ' 
        ' btnExecute
        ' 
        btnExecute.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        btnExecute.FlatStyle = FlatStyle.Flat
        btnExecute.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExecute.ForeColor = Color.White
        btnExecute.Location = New Point(478, 130)
        btnExecute.Name = "btnExecute"
        btnExecute.Size = New Size(233, 30)
        btnExecute.TabIndex = 28
        btnExecute.Text = "Execute Try...Catch Block"
        btnExecute.UseVisualStyleBackColor = False
        ' 
        ' rtbOutput
        ' 
        rtbOutput.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        rtbOutput.BorderStyle = BorderStyle.None
        rtbOutput.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbOutput.ForeColor = Color.White
        rtbOutput.Location = New Point(492, 180)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ReadOnly = True
        rtbOutput.Size = New Size(207, 133)
        rtbOutput.TabIndex = 29
        rtbOutput.Text = ""
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(198, 66)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(243, 227)
        RichTextBox1.TabIndex = 40
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(253, 381)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 36)
        Label1.TabIndex = 41
        Label1.Text = "The 'Try' block runs the code, 'Catch' intercepts errors to " & vbCrLf & "prevent a crash, and 'Finally' cleans up memory."
        ' 
        ' W10_Handling
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbOutput)
        Controls.Add(btnExecute)
        Controls.Add(cboOp)
        Controls.Add(lblOp)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W10_Handling"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W10_Handling"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOp As Label
    Friend WithEvents cboOp As ComboBox
    Friend WithEvents btnExecute As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
End Class