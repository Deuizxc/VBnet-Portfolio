<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W1112_Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W1112_Classes))
        Button1 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        lblTitle = New Label()
        btnSpawn = New Button()
        pnlParent = New Panel()
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
        Button1.TabIndex = 6
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
        Button6.TabIndex = 4
        Button6.UseVisualStyleBackColor = False
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
        Button7.TabIndex = 5
        Button7.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(437, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(218, 26)
        lblTitle.TabIndex = 2
        lblTitle.Text = "MDI BOUNDING BOX VISUALIZER"
        ' 
        ' btnSpawn
        ' 
        btnSpawn.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        btnSpawn.FlatStyle = FlatStyle.Flat
        btnSpawn.ForeColor = Color.White
        btnSpawn.Location = New Point(455, 76)
        btnSpawn.Name = "btnSpawn"
        btnSpawn.Size = New Size(200, 30)
        btnSpawn.TabIndex = 1
        btnSpawn.Text = "Spawn Virtual Child Form"
        btnSpawn.UseVisualStyleBackColor = False
        ' 
        ' pnlParent
        ' 
        pnlParent.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        pnlParent.BorderStyle = BorderStyle.FixedSingle
        pnlParent.Location = New Point(455, 127)
        pnlParent.Name = "pnlParent"
        pnlParent.Size = New Size(200, 222)
        pnlParent.TabIndex = 0
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(125, 58)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(277, 301)
        RichTextBox1.TabIndex = 44
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W1112_Classes
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(pnlParent)
        Controls.Add(btnSpawn)
        Controls.Add(lblTitle)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "W1112_Classes"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSpawn As Button
    Friend WithEvents pnlParent As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
End Class