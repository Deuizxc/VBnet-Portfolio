<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W3_Components
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W3_Components))
        Button1 = New Button()
        Button7 = New Button()
        Button2 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Label2 = New Label()
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
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(686, 418)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 20)
        Button2.TabIndex = 24
        Button2.UseVisualStyleBackColor = False
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
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(124, 48)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(250, 316)
        RichTextBox1.TabIndex = 26
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(506, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 22)
        Label1.TabIndex = 27
        Label1.Text = "Enter your name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(440, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(265, 23)
        TextBox1.TabIndex = 28
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(459, 194)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 41)
        Button3.TabIndex = 29
        Button3.Text = "Greet user"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Red
        Button4.Location = New Point(591, 194)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 41)
        Button4.TabIndex = 30
        Button4.Text = "RESET"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(475, 284)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 59)
        Label2.TabIndex = 31
        Label2.Text = "Waiting for input..."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' W3_Components
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button2)
        Controls.Add(Button7)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W3_Components"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W3_Components"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
End Class
