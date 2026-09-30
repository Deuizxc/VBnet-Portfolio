<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W3_Vbnet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W3_Vbnet))
        Button1 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        btnrun = New Button()
        Panel1 = New Panel()
        lblTerminalOutput = New Label()
        Panel1.SuspendLayout()
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
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(125, 57)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(250, 308)
        RichTextBox1.TabIndex = 30
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.Black
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox2.ForeColor = Color.White
        RichTextBox2.Location = New Point(440, 59)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(263, 222)
        RichTextBox2.TabIndex = 31
        RichTextBox2.Text = "Imports System.Console" & vbLf & vbLf & "Module Module1" & vbLf & "    Sub Main()" & vbLf & "        System.Console.Write(""Hello world"")" & vbLf & "        Read()" & vbLf & "    End Sub" & vbLf & "End Module" & vbLf & vbLf & "Output: Hello world"
        ' 
        ' btnrun
        ' 
        btnrun.BackColor = Color.Black
        btnrun.FlatStyle = FlatStyle.Flat
        btnrun.ForeColor = Color.Red
        btnrun.Location = New Point(103, 40)
        btnrun.Name = "btnrun"
        btnrun.Size = New Size(75, 23)
        btnrun.TabIndex = 32
        btnrun.Text = "CLICK"
        btnrun.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblTerminalOutput)
        Panel1.Controls.Add(btnrun)
        Panel1.Location = New Point(440, 287)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(263, 78)
        Panel1.TabIndex = 33
        ' 
        ' lblTerminalOutput
        ' 
        lblTerminalOutput.AutoSize = True
        lblTerminalOutput.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTerminalOutput.ForeColor = Color.White
        lblTerminalOutput.Location = New Point(3, 10)
        lblTerminalOutput.Name = "lblTerminalOutput"
        lblTerminalOutput.Size = New Size(175, 14)
        lblTerminalOutput.TabIndex = 0
        lblTerminalOutput.Text = "Click the button to try:"
        ' 
        ' W3_Vbnet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W3_Vbnet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W3_Vbnet"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnrun As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTerminalOutput As Label
End Class
