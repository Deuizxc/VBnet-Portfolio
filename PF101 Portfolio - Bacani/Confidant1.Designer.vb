<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confidant1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confidant1))
        Button1 = New Button()
        Button2 = New Button()
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
        Button1.TabIndex = 14
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
        Button2.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(759, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(29, 26)
        Button2.TabIndex = 15
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Confidant1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Confidant1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Confidant1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
