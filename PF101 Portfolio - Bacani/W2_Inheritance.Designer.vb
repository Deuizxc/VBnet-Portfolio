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
        Button3 = New Button()
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
        TextBox2 = New TextBox()
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
        RichTextBox1.Font = New Font("Franklin Gothic Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(180, 70)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(276, 225)
        RichTextBox1.TabIndex = 24
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.InfoText
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Menu
        TextBox2.Location = New Point(487, 43)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(274, 252)
        TextBox2.TabIndex = 25
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(205, 378)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 36)
        Label1.TabIndex = 28
        Label1.Text = "Inheritance allows the derived class to reuse existing " & vbCrLf & "base logic without duplicating code."
        ' 
        ' W2_Inheritance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W2_Inheritance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W2_Inheritance"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
End Class
