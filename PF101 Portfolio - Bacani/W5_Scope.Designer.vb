<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W5_Scope
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W5_Scope))
        Button1 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        RichTextBox3 = New RichTextBox()
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
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Black
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.White
        RichTextBox1.Location = New Point(135, 31)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(310, 74)
        RichTextBox1.TabIndex = 37
        RichTextBox1.Text = "VARIABLE SCOPE & LIFETIME " & vbLf & "Determines where a variable is accessible and how long it remains allocated in memory."
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox2.Location = New Point(387, 136)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(289, 256)
        RichTextBox2.TabIndex = 38
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.BackColor = Color.Black
        RichTextBox3.BorderStyle = BorderStyle.None
        RichTextBox3.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox3.ForeColor = Color.White
        RichTextBox3.Location = New Point(144, 101)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(219, 291)
        RichTextBox3.TabIndex = 39
        RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        ' 
        ' W5_Scope
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox3)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W5_Scope"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W5_Scope"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
End Class
