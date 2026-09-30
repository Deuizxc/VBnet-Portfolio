<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W2_Polymorphism
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W2_Polymorphism))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        RichTextBox2 = New RichTextBox()
        Button4 = New Button()
        Button5 = New Button()
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
        Button2.TabIndex = 17
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(12, 418)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 20)
        Button3.TabIndex = 18
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox2.Location = New Point(116, 42)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(256, 323)
        RichTextBox2.TabIndex = 19
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(404, 219)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 40)
        Button4.TabIndex = 20
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(583, 219)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 40)
        Button5.TabIndex = 22
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(502, 281)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 18)
        Label1.TabIndex = 23
        Label1.Text = "What does the animal say?:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' W2_Polymorphism
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(RichTextBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W2_Polymorphism"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W2_Polymorphism"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
End Class
