<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1415_Row
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1415_Row))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        lblRowData = New Label()
        btnPrev = New Button()
        btnNext = New Button()
        btnEvaluate = New Button()
        rtbTerminal = New RichTextBox()
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
        lblTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(454, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(191, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "ROW NAVIGATOR & NULLS"
        ' 
        ' lblRowData
        ' 
        lblRowData.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        lblRowData.BorderStyle = BorderStyle.FixedSingle
        lblRowData.Font = New Font("Consolas", 8.5F)
        lblRowData.ForeColor = Color.Gold
        lblRowData.Location = New Point(466, 56)
        lblRowData.Name = "lblRowData"
        lblRowData.Size = New Size(212, 25)
        lblRowData.TabIndex = 27
        lblRowData.Text = "[Row 0] Data"
        lblRowData.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnPrev.FlatAppearance.BorderColor = Color.White
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnPrev.ForeColor = Color.White
        btnPrev.Location = New Point(454, 95)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(115, 28)
        btnPrev.TabIndex = 28
        btnPrev.Text = "<< Prev Row"
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnNext.FlatAppearance.BorderColor = Color.White
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(575, 95)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 28)
        btnNext.TabIndex = 29
        btnNext.Text = "Next Row >>"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.BackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnEvaluate.FlatAppearance.BorderColor = Color.White
        btnEvaluate.FlatStyle = FlatStyle.Flat
        btnEvaluate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEvaluate.ForeColor = Color.White
        btnEvaluate.Location = New Point(465, 140)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(213, 28)
        btnEvaluate.TabIndex = 30
        btnEvaluate.Text = "Evaluate Rule: Is Age >= 18?"
        btnEvaluate.UseVisualStyleBackColor = False
        ' 
        ' rtbTerminal
        ' 
        rtbTerminal.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        rtbTerminal.BorderStyle = BorderStyle.FixedSingle
        rtbTerminal.Font = New Font("Consolas", 8.25F)
        rtbTerminal.ForeColor = Color.White
        rtbTerminal.Location = New Point(466, 185)
        rtbTerminal.Name = "rtbTerminal"
        rtbTerminal.ReadOnly = True
        rtbTerminal.ScrollBars = RichTextBoxScrollBars.None
        rtbTerminal.Size = New Size(213, 110)
        rtbTerminal.TabIndex = 31
        rtbTerminal.Text = "> Awaiting evaluation..."
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(142, 40)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(281, 190)
        RichTextBox1.TabIndex = 50
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(208, 369)
        Label1.Name = "Label1"
        Label1.Size = New Size(409, 72)
        Label1.TabIndex = 51
        Label1.Text = "NULL represents unknown data—not zero or empty text. That is why comparisons evaluate strictly to True, False, or Unknown."
        ' 
        ' W1415_Row
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbTerminal)
        Controls.Add(btnEvaluate)
        Controls.Add(btnNext)
        Controls.Add(btnPrev)
        Controls.Add(lblRowData)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1415_Row"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W1415_Row"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRowData As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents rtbTerminal As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
End Class