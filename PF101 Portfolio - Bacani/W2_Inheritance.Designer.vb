<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W2_Inheritance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W2_Inheritance))
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
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
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InactiveCaptionText
        TextBox1.ForeColor = SystemColors.ButtonHighlight
        TextBox1.Location = New Point(402, 71)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(248, 308)
        TextBox1.TabIndex = 14
        TextBox1.Text = resources.GetString("TextBox1.Text")
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
        Button3.Location = New Point(686, 418)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 20)
        Button3.TabIndex = 17
        Button3.UseVisualStyleBackColor = False
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
        Button2.Location = New Point(12, 418)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 20)
        Button2.TabIndex = 18
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(150, 71)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(236, 296)
        RichTextBox1.TabIndex = 24
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W2_Inheritance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W2_Inheritance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W2_Inheritance"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
