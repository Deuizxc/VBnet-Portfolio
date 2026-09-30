<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W6_Selection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W6_Selection))
        Button1 = New Button()
        Button7 = New Button()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(183, 26)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(274, 261)
        RichTextBox1.TabIndex = 30
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.Black
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox2.ForeColor = Color.White
        RichTextBox2.Location = New Point(507, 33)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(246, 105)
        RichTextBox2.TabIndex = 33
        RichTextBox2.Text = "If deadline = ""Near"" Then" & vbLf & "    lblActivity.Text = ""Cram""" & vbLf & "Else" & vbLf & "    lblActivity.Text = ""Relax""" & vbLf & "End If"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(247, 369)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 36)
        Label1.TabIndex = 35
        Label1.Text = "An If statement tests a condition: if True, it executes " & vbCrLf & "Then; otherwise, it jumps to Else or exits at End If."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(507, 133)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(246, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' W6_Selection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button7)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W6_Selection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W6_Selection"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
