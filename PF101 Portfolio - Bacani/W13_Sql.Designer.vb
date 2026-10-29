<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W13_Sql
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W13_Sql))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        cboScenario = New ComboBox()
        lblSqlTerminal = New Label()
        btnExecute = New Button()
        dgvResults = New DataGridView()
        RichTextBox1 = New RichTextBox()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
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
        lblTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(499, 40)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(178, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "SQL QUERY SIMULATOR"
        ' 
        ' cboScenario
        ' 
        cboScenario.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        cboScenario.DropDownStyle = ComboBoxStyle.DropDownList
        cboScenario.FlatStyle = FlatStyle.Flat
        cboScenario.ForeColor = Color.White
        cboScenario.FormattingEnabled = True
        cboScenario.Location = New Point(448, 72)
        cboScenario.Name = "cboScenario"
        cboScenario.Size = New Size(272, 23)
        cboScenario.TabIndex = 27
        ' 
        ' lblSqlTerminal
        ' 
        lblSqlTerminal.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        lblSqlTerminal.BorderStyle = BorderStyle.FixedSingle
        lblSqlTerminal.Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSqlTerminal.ForeColor = Color.LimeGreen
        lblSqlTerminal.Location = New Point(460, 109)
        lblSqlTerminal.Name = "lblSqlTerminal"
        lblSqlTerminal.Padding = New Padding(5)
        lblSqlTerminal.Size = New Size(246, 75)
        lblSqlTerminal.TabIndex = 28
        lblSqlTerminal.Text = "SELECT *" & vbCrLf & "FROM Payroll"
        ' 
        ' btnExecute
        ' 
        btnExecute.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExecute.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnExecute.FlatAppearance.BorderSize = 2
        btnExecute.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExecute.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExecute.FlatStyle = FlatStyle.Flat
        btnExecute.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExecute.ForeColor = Color.White
        btnExecute.Location = New Point(460, 187)
        btnExecute.Name = "btnExecute"
        btnExecute.Size = New Size(246, 30)
        btnExecute.TabIndex = 29
        btnExecute.Text = "EXECUTE QUERY"
        btnExecute.UseVisualStyleBackColor = False
        ' 
        ' dgvResults
        ' 
        dgvResults.AllowUserToAddRows = False
        dgvResults.AllowUserToDeleteRows = False
        dgvResults.AllowUserToResizeColumns = False
        dgvResults.AllowUserToResizeRows = False
        dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvResults.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        dgvResults.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvResults.DefaultCellStyle = DataGridViewCellStyle2
        dgvResults.EnableHeadersVisualStyles = False
        dgvResults.Location = New Point(460, 223)
        dgvResults.Name = "dgvResults"
        dgvResults.ReadOnly = True
        dgvResults.RowHeadersVisible = False
        dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResults.Size = New Size(246, 146)
        dgvResults.TabIndex = 30
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(132, 59)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(277, 310)
        RichTextBox1.TabIndex = 46
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W13_Sql
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(dgvResults)
        Controls.Add(btnExecute)
        Controls.Add(lblSqlTerminal)
        Controls.Add(cboScenario)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W13_Sql"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W13_Sql"
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboScenario As ComboBox
    Friend WithEvents lblSqlTerminal As Label
    Friend WithEvents btnExecute As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents RichTextBox1 As RichTextBox
End Class