<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W13_Visual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W13_Visual))
        Button1 = New Button()
        Button6 = New Button()
        lblTitle = New Label()
        grpGridPane = New GroupBox()
        chkSalary = New CheckBox()
        chkLast = New CheckBox()
        chkFirst = New CheckBox()
        chkID = New CheckBox()
        lblSqlPaneTitle = New Label()
        lblSqlPane = New Label()
        btnExecute = New Button()
        rtbResults = New RichTextBox()
        RichTextBox1 = New RichTextBox()
        grpGridPane.SuspendLayout()
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
        lblTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(450, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(231, 20)
        lblTitle.TabIndex = 24
        lblTitle.Text = "QUERY BUILDER & DATAREADER"
        ' 
        ' grpGridPane
        ' 
        grpGridPane.BackColor = Color.Transparent
        grpGridPane.Controls.Add(chkSalary)
        grpGridPane.Controls.Add(chkLast)
        grpGridPane.Controls.Add(chkFirst)
        grpGridPane.Controls.Add(chkID)
        grpGridPane.ForeColor = Color.LightGray
        grpGridPane.Location = New Point(452, 60)
        grpGridPane.Name = "grpGridPane"
        grpGridPane.Size = New Size(260, 65)
        grpGridPane.TabIndex = 25
        grpGridPane.TabStop = False
        grpGridPane.Text = "1. Grid Pane (Select Columns)"
        ' 
        ' chkSalary
        ' 
        chkSalary.AutoSize = True
        chkSalary.ForeColor = Color.White
        chkSalary.Location = New Point(110, 40)
        chkSalary.Name = "chkSalary"
        chkSalary.Size = New Size(57, 19)
        chkSalary.TabIndex = 3
        chkSalary.Text = "Salary"
        chkSalary.UseVisualStyleBackColor = True
        ' 
        ' chkLast
        ' 
        chkLast.AutoSize = True
        chkLast.ForeColor = Color.White
        chkLast.Location = New Point(15, 40)
        chkLast.Name = "chkLast"
        chkLast.Size = New Size(82, 19)
        chkLast.TabIndex = 2
        chkLast.Text = "Last Name"
        chkLast.UseVisualStyleBackColor = True
        ' 
        ' chkFirst
        ' 
        chkFirst.AutoSize = True
        chkFirst.Checked = True
        chkFirst.CheckState = CheckState.Checked
        chkFirst.ForeColor = Color.White
        chkFirst.Location = New Point(65, 20)
        chkFirst.Name = "chkFirst"
        chkFirst.Size = New Size(83, 19)
        chkFirst.TabIndex = 1
        chkFirst.Text = "First Name"
        chkFirst.UseVisualStyleBackColor = True
        ' 
        ' chkID
        ' 
        chkID.AutoSize = True
        chkID.Checked = True
        chkID.CheckState = CheckState.Checked
        chkID.ForeColor = Color.White
        chkID.Location = New Point(15, 20)
        chkID.Name = "chkID"
        chkID.Size = New Size(37, 19)
        chkID.TabIndex = 0
        chkID.Text = "ID"
        chkID.UseVisualStyleBackColor = True
        ' 
        ' lblSqlPaneTitle
        ' 
        lblSqlPaneTitle.AutoSize = True
        lblSqlPaneTitle.BackColor = Color.Transparent
        lblSqlPaneTitle.ForeColor = Color.LightGray
        lblSqlPaneTitle.Location = New Point(450, 135)
        lblSqlPaneTitle.Name = "lblSqlPaneTitle"
        lblSqlPaneTitle.Size = New Size(69, 15)
        lblSqlPaneTitle.TabIndex = 26
        lblSqlPaneTitle.Text = "2. SQL Pane"
        ' 
        ' lblSqlPane
        ' 
        lblSqlPane.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        lblSqlPane.BorderStyle = BorderStyle.FixedSingle
        lblSqlPane.Font = New Font("Consolas", 9.0F)
        lblSqlPane.ForeColor = Color.White
        lblSqlPane.Location = New Point(452, 155)
        lblSqlPane.Name = "lblSqlPane"
        lblSqlPane.Padding = New Padding(5)
        lblSqlPane.Size = New Size(260, 45)
        lblSqlPane.TabIndex = 27
        lblSqlPane.Text = "SELECT *" & vbCrLf & "FROM SalesStaff"
        ' 
        ' btnExecute
        ' 
        btnExecute.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExecute.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        btnExecute.FlatAppearance.BorderSize = 2
        btnExecute.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExecute.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnExecute.FlatStyle = FlatStyle.Flat
        btnExecute.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnExecute.ForeColor = Color.White
        btnExecute.Location = New Point(452, 210)
        btnExecute.Name = "btnExecute"
        btnExecute.Size = New Size(260, 30)
        btnExecute.TabIndex = 28
        btnExecute.Text = "EXECUTE COMMAND"
        btnExecute.UseVisualStyleBackColor = False
        ' 
        ' rtbResults
        ' 
        rtbResults.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        rtbResults.BorderStyle = BorderStyle.None
        rtbResults.Font = New Font("Consolas", 8.25F)
        rtbResults.ForeColor = Color.White
        rtbResults.Location = New Point(452, 250)
        rtbResults.Name = "rtbResults"
        rtbResults.ReadOnly = True
        rtbResults.Size = New Size(189, 117)
        rtbResults.TabIndex = 29
        rtbResults.Text = ""
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(134, 51)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(277, 325)
        RichTextBox1.TabIndex = 47
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W13_Visual
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(rtbResults)
        Controls.Add(btnExecute)
        Controls.Add(lblSqlPane)
        Controls.Add(lblSqlPaneTitle)
        Controls.Add(grpGridPane)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W13_Visual"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W13_Visual"
        grpGridPane.ResumeLayout(False)
        grpGridPane.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpGridPane As GroupBox
    Friend WithEvents chkSalary As CheckBox
    Friend WithEvents chkLast As CheckBox
    Friend WithEvents chkFirst As CheckBox
    Friend WithEvents chkID As CheckBox
    Friend WithEvents lblSqlPaneTitle As Label
    Friend WithEvents lblSqlPane As Label
    Friend WithEvents btnExecute As Button
    Friend WithEvents rtbResults As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class