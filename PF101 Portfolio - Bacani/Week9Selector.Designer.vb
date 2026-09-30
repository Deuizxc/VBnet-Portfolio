<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week9Selector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week9Selector))
        Button7 = New Button()
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
        ' Week9Selector
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Week9Selector"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week9Selector"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button7 As Button
End Class
