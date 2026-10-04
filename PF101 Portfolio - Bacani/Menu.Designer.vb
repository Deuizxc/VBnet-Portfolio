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
        lvl3start = New Label()
        lvl1popup = New Panel()
        Button7 = New Button()
        lvl2popup = New Panel()
        Button2 = New Button()
        lvl3popup = New Panel()
        Button3 = New Button()
        lvl1popup.SuspendLayout()
        lvl2popup.SuspendLayout()
        lvl3popup.SuspendLayout()
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
        Label8.Location = New Point(447, 122)
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
        lvl2start.Location = New Point(598, 264)
        lvl2start.Name = "lvl2start"
        lvl2start.Size = New Size(45, 19)
        lvl2start.TabIndex = 23
        lvl2start.Text = "START"
        ' 
        ' lvl3start
        ' 
        lvl3start.AutoSize = True
        lvl3start.BackColor = Color.Transparent
        lvl3start.FlatStyle = FlatStyle.Flat
        lvl3start.Font = New Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvl3start.ForeColor = Color.White
        lvl3start.Location = New Point(675, 406)
        lvl3start.Name = "lvl3start"
        lvl3start.Size = New Size(45, 19)
        lvl3start.TabIndex = 24
        lvl3start.Text = "START"
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
        lvl2popup.Location = New Point(770, 204)
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
        ' lvl3popup
        ' 
        lvl3popup.BackColor = Color.Transparent
        lvl3popup.BackgroundImage = CType(resources.GetObject("lvl3popup.BackgroundImage"), Image)
        lvl3popup.BackgroundImageLayout = ImageLayout.Stretch
        lvl3popup.Controls.Add(Button3)
        lvl3popup.Location = New Point(156, 417)
        lvl3popup.Name = "lvl3popup"
        lvl3popup.Size = New Size(608, 407)
        lvl3popup.TabIndex = 27
        lvl3popup.Visible = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(274, 343)
        Button3.Name = "Button3"
        Button3.Size = New Size(66, 28)
        Button3.TabIndex = 16
        Button3.Tag = ""
        Button3.Text = "OK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lvl3popup)
        Controls.Add(lvl2popup)
        Controls.Add(lvl1popup)
        Controls.Add(lvl3start)
        Controls.Add(lvl2start)
        Controls.Add(Label8)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        lvl1popup.ResumeLayout(False)
        lvl2popup.ResumeLayout(False)
        lvl3popup.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lvl2start As Label
    Friend WithEvents lvl3start As Label
    Friend WithEvents lvl1popup As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents lvl2popup As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lvl3popup As Panel
    Friend WithEvents Button3 As Button
End Class
