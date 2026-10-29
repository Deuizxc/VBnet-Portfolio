<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W13_Memory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W13_Memory))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        dgvData = New DataGridView()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnAccept = New Button()
        btnReject = New Button()
        rtbLog = New RichTextBox()
        RichTextBox1 = New RichTextBox()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
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
        lblTitle.Location = New Point(452, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(202, 20)
        lblTitle.TabIndex = 26
        lblTitle.Text = "DATASET STATE MANAGER"
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.AllowUserToResizeColumns = False
        dgvData.AllowUserToResizeRows = False
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvData.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        dgvData.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.25F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvData.DefaultCellStyle = DataGridViewCellStyle2
        dgvData.EnableHeadersVisualStyles = False
        dgvData.Location = New Point(452, 60)
        dgvData.MultiSelect = False
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(266, 110)
        dgvData.TabIndex = 27
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnAdd.FlatAppearance.BorderSize = 2
        btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(452, 180)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(83, 28)
        btnAdd.TabIndex = 28
        btnAdd.Text = "+ Add Row"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnEdit.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnEdit.FlatAppearance.BorderSize = 2
        btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(541, 181)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(88, 28)
        btnEdit.TabIndex = 29
        btnEdit.Text = "Edit Row"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnDelete.FlatAppearance.BorderSize = 2
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(635, 181)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(83, 28)
        btnDelete.TabIndex = 30
        btnDelete.Text = "- Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAccept.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnAccept.FlatAppearance.BorderSize = 2
        btnAccept.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAccept.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnAccept.FlatStyle = FlatStyle.Flat
        btnAccept.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnAccept.ForeColor = Color.White
        btnAccept.Location = New Point(452, 215)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(125, 28)
        btnAccept.TabIndex = 31
        btnAccept.Text = "AcceptChanges()"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReject.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnReject.FlatAppearance.BorderSize = 2
        btnReject.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReject.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnReject.ForeColor = Color.White
        btnReject.Location = New Point(587, 215)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(131, 28)
        btnReject.TabIndex = 32
        btnReject.Text = "RejectChanges()"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' rtbLog
        ' 
        rtbLog.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        rtbLog.BorderStyle = BorderStyle.None
        rtbLog.Font = New Font("Consolas", 8.5F)
        rtbLog.ForeColor = Color.LimeGreen
        rtbLog.Location = New Point(464, 255)
        rtbLog.Name = "rtbLog"
        rtbLog.ReadOnly = True
        rtbLog.Size = New Size(248, 115)
        rtbLog.TabIndex = 33
        rtbLog.Text = ""
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(134, 60)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(277, 310)
        RichTextBox1.TabIndex = 47
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W13_Memory
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbLog)
        Controls.Add(btnReject)
        Controls.Add(btnAccept)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvData)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W13_Memory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W13_Memory"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class