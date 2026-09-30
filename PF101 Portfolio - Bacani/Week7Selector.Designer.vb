<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week7Selector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week7Selector))
        Button7 = New Button()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.ActiveCaptionText
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = SystemColors.ButtonHighlight
        Button7.Location = New Point(12, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 31)
        Button7.TabIndex = 9
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(340, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 23)
        Label3.TabIndex = 20
        Label3.Text = "Array Basics"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(340, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 20)
        Label6.TabIndex = 21
        Label6.Text = "Multidimensional Arrays"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(340, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(185, 23)
        Label7.TabIndex = 22
        Label7.Text = "Procedures & Functions"
        ' 
        ' Week7Selector
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Button7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Week7Selector"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week7Selector"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
