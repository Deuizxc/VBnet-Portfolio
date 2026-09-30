<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W2_Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W2_Classes))
        Button7 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
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
        Button7.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Transparent
        Button7.Location = New Point(12, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(83, 33)
        Button7.TabIndex = 11
        Button7.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InfoText
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Menu
        TextBox1.Location = New Point(403, 64)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 314)
        TextBox1.TabIndex = 12
        TextBox1.Text = resources.GetString("TextBox1.Text")
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
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(156, 74)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(232, 290)
        RichTextBox1.TabIndex = 18
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' W2_Classes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Button7)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "W2_Classes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W2_Classes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
