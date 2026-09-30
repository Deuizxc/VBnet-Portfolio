<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W6_Operator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W6_Operator))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        Label3 = New Label()
        radAnd = New RadioButton()
        radOr = New RadioButton()
        radXor = New RadioButton()
        radNot = New RadioButton()
        dgvTruthTable = New DataGridView()
        lblRule = New Label()
        CType(dgvTruthTable, ComponentModel.ISupportInitialize).BeginInit()
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
        Button1.Location = New Point(12, 11)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 31)
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
        Button7.Margin = New Padding(3, 4, 3, 4)
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
        Button6.Margin = New Padding(3, 4, 3, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 20)
        Button6.TabIndex = 24
        Button6.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(133, 38)
        RichTextBox1.Margin = New Padding(3, 4, 3, 4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(241, 362)
        RichTextBox1.TabIndex = 31
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(493, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 38
        Label2.Text = "TRUTH TABLE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(424, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 20)
        Label3.TabIndex = 42
        Label3.Text = "[ Select Logical Operator ]"
        ' 
        ' radAnd
        ' 
        radAnd.AutoSize = True
        radAnd.BackColor = Color.Transparent
        radAnd.Checked = True
        radAnd.Location = New Point(417, 102)
        radAnd.Margin = New Padding(3, 4, 3, 4)
        radAnd.Name = "radAnd"
        radAnd.Size = New Size(52, 24)
        radAnd.TabIndex = 43
        radAnd.TabStop = True
        radAnd.Text = "AND"
        radAnd.UseVisualStyleBackColor = False
        ' 
        ' radOr
        ' 
        radOr.AutoSize = True
        radOr.BackColor = Color.Transparent
        radOr.Location = New Point(484, 102)
        radOr.Margin = New Padding(3, 4, 3, 4)
        radOr.Name = "radOr"
        radOr.Size = New Size(46, 24)
        radOr.TabIndex = 44
        radOr.Text = "OR"
        radOr.UseVisualStyleBackColor = False
        ' 
        ' radXor
        ' 
        radXor.AutoSize = True
        radXor.BackColor = Color.Transparent
        radXor.Location = New Point(545, 102)
        radXor.Margin = New Padding(3, 4, 3, 4)
        radXor.Name = "radXor"
        radXor.Size = New Size(54, 24)
        radXor.TabIndex = 45
        radXor.Text = "XOR"
        radXor.UseVisualStyleBackColor = False
        ' 
        ' radNot
        ' 
        radNot.AutoSize = True
        radNot.BackColor = Color.Transparent
        radNot.Location = New Point(615, 102)
        radNot.Margin = New Padding(3, 4, 3, 4)
        radNot.Name = "radNot"
        radNot.Size = New Size(55, 24)
        radNot.TabIndex = 49
        radNot.Text = "NOT"
        radNot.UseVisualStyleBackColor = False
        ' 
        ' dgvTruthTable
        ' 
        dgvTruthTable.AllowUserToAddRows = False
        dgvTruthTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTruthTable.BackgroundColor = Color.Black
        dgvTruthTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTruthTable.Location = New Point(417, 133)
        dgvTruthTable.Name = "dgvTruthTable"
        dgvTruthTable.ReadOnly = True
        dgvTruthTable.RowHeadersVisible = False
        dgvTruthTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTruthTable.Size = New Size(253, 184)
        dgvTruthTable.TabIndex = 50
        ' 
        ' lblRule
        ' 
        lblRule.BackColor = Color.Transparent
        lblRule.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRule.ForeColor = Color.White
        lblRule.Location = New Point(417, 320)
        lblRule.Name = "lblRule"
        lblRule.Size = New Size(253, 80)
        lblRule.TabIndex = 51
        lblRule.Text = "RULE"
        ' 
        ' W6_Operator
        ' 
        AutoScaleDimensions = New SizeF(7F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblRule)
        Controls.Add(dgvTruthTable)
        Controls.Add(radNot)
        Controls.Add(radXor)
        Controls.Add(radOr)
        Controls.Add(radAnd)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "W6_Operator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W6_Operator"
        CType(dgvTruthTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radAnd As RadioButton
    Friend WithEvents radOr As RadioButton
    Friend WithEvents radXor As RadioButton
    Friend WithEvents radNot As RadioButton
    Friend WithEvents dgvTruthTable As DataGridView
    Friend WithEvents lblRule As Label
End Class
