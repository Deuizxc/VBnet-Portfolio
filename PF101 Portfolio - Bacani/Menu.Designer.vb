<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Button1 = New Button()
        Label8 = New Label()
        lvl2start = New Label()
        Label2 = New Label()
        lvl1popup = New Panel()
        Button7 = New Button()
        lvl2popup = New Panel()
        Button2 = New Button()
        lvl1popup.SuspendLayout()
        lvl2popup.SuspendLayout()
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
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.FlatStyle = FlatStyle.Flat
        Label8.Font = New Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(448, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 19)
        Label8.TabIndex = 22
        Label8.Text = "START"
        ' 
        ' lvl2start
        ' 
        lvl2start.AutoSize = True
        lvl2start.BackColor = Color.Transparent
        lvl2start.FlatStyle = FlatStyle.Flat
        lvl2start.Font = New Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvl2start.ForeColor = Color.White
        lvl2start.Location = New Point(596, 267)
        lvl2start.Name = "lvl2start"
        lvl2start.Size = New Size(45, 19)
        lvl2start.TabIndex = 23
        lvl2start.Text = "START"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(675, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 19)
        Label2.TabIndex = 24
        Label2.Text = "START"
        ' 
        ' lvl1popup
        ' 
        lvl1popup.BackColor = Color.Transparent
        lvl1popup.BackgroundImage = CType(resources.GetObject("lvl1popup.BackgroundImage"), Image)
        lvl1popup.BackgroundImageLayout = ImageLayout.Stretch
        lvl1popup.Controls.Add(Button7)
        lvl1popup.Location = New Point(749, 373)
        lvl1popup.Name = "lvl1popup"
        lvl1popup.Size = New Size(608, 407)
        lvl1popup.TabIndex = 25
        lvl1popup.Visible = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Red
        Button7.Location = New Point(274, 343)
        Button7.Name = "Button7"
        Button7.Size = New Size(66, 28)
        Button7.TabIndex = 16
        Button7.Tag = ""
        Button7.Text = "OK"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' lvl2popup
        ' 
        lvl2popup.BackColor = Color.Transparent
        lvl2popup.BackgroundImage = CType(resources.GetObject("lvl2popup.BackgroundImage"), Image)
        lvl2popup.BackgroundImageLayout = ImageLayout.Stretch
        lvl2popup.Controls.Add(Button2)
        lvl2popup.Location = New Point(362, 409)
        lvl2popup.Name = "lvl2popup"
        lvl2popup.Size = New Size(608, 407)
        lvl2popup.TabIndex = 26
        lvl2popup.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(274, 343)
        Button2.Name = "Button2"
        Button2.Size = New Size(66, 28)
        Button2.TabIndex = 16
        Button2.Tag = ""
        Button2.Text = "OK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lvl2popup)
        Controls.Add(lvl1popup)
        Controls.Add(Label2)
        Controls.Add(lvl2start)
        Controls.Add(Label8)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        lvl1popup.ResumeLayout(False)
        lvl2popup.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lvl2start As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvl1popup As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents lvl2popup As Panel
    Friend WithEvents Button2 As Button
End Class
