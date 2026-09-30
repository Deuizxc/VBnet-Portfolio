<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week5Selector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week5Selector))
        Button7 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
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
        Button7.Location = New Point(21, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 31)
        Button7.TabIndex = 8
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(340, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 23)
        Label7.TabIndex = 17
        Label7.Text = "Data Types"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.FlatStyle = FlatStyle.Flat
        Label8.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(340, 200)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 18
        Label8.Text = "Variables and Constants"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.FlatStyle = FlatStyle.Flat
        Label9.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(340, 251)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 23)
        Label9.TabIndex = 19
        Label9.Text = "Variable Scope"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.FlatStyle = FlatStyle.Flat
        Label10.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(340, 301)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 23)
        Label10.TabIndex = 20
        Label10.Text = "Data Conversion"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.FlatStyle = FlatStyle.Flat
        Label11.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(340, 354)
        Label11.Name = "Label11"
        Label11.Size = New Size(184, 20)
        Label11.TabIndex = 21
        Label11.Text = "Operators and Expressions"
        ' 
        ' Week5Selector
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Week5Selector"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week5Selector"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
