<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W2_Interfaces
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W2_Interfaces))
        Button1 = New Button()
        Button3 = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button5 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Button6 = New Button()
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
        Button1.Font = New Font("p5hatty", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Button3.Location = New Point(12, 418)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 20)
        Button3.TabIndex = 17
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(162, 80)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(257, 273)
        RichTextBox1.TabIndex = 24
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(551, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 24)
        Label1.TabIndex = 25
        Label1.Text = "Enter Amount:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(524, 104)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 26
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button5.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatAppearance.MouseDownBackColor = Color.White
        Button5.FlatAppearance.MouseOverBackColor = Color.White
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(542, 259)
        Button5.Name = "Button5"
        Button5.Size = New Size(142, 32)
        Button5.TabIndex = 2
        Button5.Text = "Pay with Cash"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.MouseDownBackColor = Color.White
        Button4.FlatAppearance.MouseOverBackColor = Color.White
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(542, 208)
        Button4.Name = "Button4"
        Button4.Size = New Size(142, 36)
        Button4.TabIndex = 1
        Button4.Text = "Pay with Gcash"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = Color.White
        Button2.FlatAppearance.MouseOverBackColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(542, 160)
        Button2.Name = "Button2"
        Button2.Size = New Size(142, 32)
        Button2.TabIndex = 0
        Button2.Text = "Pay with Card"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(476, 347)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 64)
        Label2.TabIndex = 28
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button6.Location = New Point(542, 301)
        Button6.Name = "Button6"
        Button6.Size = New Size(142, 27)
        Button6.TabIndex = 29
        Button6.Text = "Reset"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' W2_Interfaces
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W2_Interfaces"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W2_Interfaces"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
End Class