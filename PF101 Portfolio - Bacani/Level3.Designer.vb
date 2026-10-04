<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level3
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level3))
        Button1 = New Button()
        picJoker = New PictureBox()
        picBoss = New PictureBox()
        picTarget2 = New PictureBox()
        picTarget1 = New PictureBox()
        picTarget3 = New PictureBox()
        lblScore = New Label()
        tmrCountdown = New Timer(components)
        tmrTeleport = New Timer(components)
        lose = New Panel()
        Button7 = New Button()
        win = New Panel()
        Button2 = New Button()
        picDmg = New PictureBox()
        hpBar = New ProgressBar()
        CType(picJoker, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoss, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTarget2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTarget1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTarget3, ComponentModel.ISupportInitialize).BeginInit()
        lose.SuspendLayout()
        win.SuspendLayout()
        CType(picDmg, ComponentModel.ISupportInitialize).BeginInit()
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
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 33)
        Button1.TabIndex = 24
        Button1.UseVisualStyleBackColor = False
        ' 
        ' picJoker
        ' 
        picJoker.BackColor = Color.Transparent
        picJoker.Image = CType(resources.GetObject("picJoker.Image"), Image)
        picJoker.Location = New Point(152, 251)
        picJoker.Name = "picJoker"
        picJoker.Size = New Size(284, 296)
        picJoker.SizeMode = PictureBoxSizeMode.StretchImage
        picJoker.TabIndex = 25
        picJoker.TabStop = False
        ' 
        ' picBoss
        ' 
        picBoss.BackColor = Color.Transparent
        picBoss.Image = CType(resources.GetObject("picBoss.Image"), Image)
        picBoss.Location = New Point(519, 90)
        picBoss.Name = "picBoss"
        picBoss.Size = New Size(518, 476)
        picBoss.SizeMode = PictureBoxSizeMode.Zoom
        picBoss.TabIndex = 26
        picBoss.TabStop = False
        ' 
        ' picTarget2
        ' 
        picTarget2.BackColor = Color.Transparent
        picTarget2.Image = CType(resources.GetObject("picTarget2.Image"), Image)
        picTarget2.Location = New Point(429, 73)
        picTarget2.Name = "picTarget2"
        picTarget2.Size = New Size(46, 50)
        picTarget2.SizeMode = PictureBoxSizeMode.StretchImage
        picTarget2.TabIndex = 27
        picTarget2.TabStop = False
        ' 
        ' picTarget1
        ' 
        picTarget1.BackColor = Color.Transparent
        picTarget1.Image = CType(resources.GetObject("picTarget1.Image"), Image)
        picTarget1.Location = New Point(429, 143)
        picTarget1.Name = "picTarget1"
        picTarget1.Size = New Size(46, 50)
        picTarget1.SizeMode = PictureBoxSizeMode.StretchImage
        picTarget1.TabIndex = 28
        picTarget1.TabStop = False
        ' 
        ' picTarget3
        ' 
        picTarget3.BackColor = Color.Transparent
        picTarget3.Image = CType(resources.GetObject("picTarget3.Image"), Image)
        picTarget3.Location = New Point(355, 90)
        picTarget3.Name = "picTarget3"
        picTarget3.Size = New Size(46, 50)
        picTarget3.SizeMode = PictureBoxSizeMode.StretchImage
        picTarget3.TabIndex = 29
        picTarget3.TabStop = False
        ' 
        ' lblScore
        ' 
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = Color.Red
        lblScore.Location = New Point(196, 211)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(110, 37)
        lblScore.TabIndex = 32
        lblScore.Text = "HITS: 0 / 40"
        lblScore.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tmrTeleport
        ' 
        tmrTeleport.Interval = 800
        ' 
        ' lose
        ' 
        lose.BackColor = Color.Transparent
        lose.BackgroundImage = CType(resources.GetObject("lose.BackgroundImage"), Image)
        lose.BackgroundImageLayout = ImageLayout.Stretch
        lose.Controls.Add(Button7)
        lose.Location = New Point(981, 140)
        lose.Name = "lose"
        lose.Size = New Size(608, 407)
        lose.TabIndex = 45
        lose.Visible = False
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
        ' win
        ' 
        win.BackColor = Color.Transparent
        win.BackgroundImage = CType(resources.GetObject("win.BackgroundImage"), Image)
        win.BackgroundImageLayout = ImageLayout.Stretch
        win.Controls.Add(Button2)
        win.Location = New Point(429, 517)
        win.Name = "win"
        win.Size = New Size(608, 407)
        win.TabIndex = 46
        win.Visible = False
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
        Button2.Location = New Point(273, 338)
        Button2.Name = "Button2"
        Button2.Size = New Size(66, 28)
        Button2.TabIndex = 16
        Button2.Tag = ""
        Button2.Text = "OK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' picDmg
        ' 
        picDmg.BackColor = Color.Transparent
        picDmg.Location = New Point(848, 73)
        picDmg.Name = "picDmg"
        picDmg.Size = New Size(165, 143)
        picDmg.SizeMode = PictureBoxSizeMode.Zoom
        picDmg.TabIndex = 47
        picDmg.TabStop = False
        ' 
        ' hpBar
        ' 
        hpBar.Location = New Point(313, 12)
        hpBar.Maximum = 1000
        hpBar.Name = "hpBar"
        hpBar.Size = New Size(512, 26)
        hpBar.TabIndex = 48
        ' 
        ' Level3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1064, 559)
        Controls.Add(hpBar)
        Controls.Add(picDmg)
        Controls.Add(win)
        Controls.Add(lose)
        Controls.Add(lblScore)
        Controls.Add(picTarget3)
        Controls.Add(picTarget1)
        Controls.Add(picTarget2)
        Controls.Add(picBoss)
        Controls.Add(picJoker)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Level3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level3"
        CType(picJoker, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoss, ComponentModel.ISupportInitialize).EndInit()
        CType(picTarget2, ComponentModel.ISupportInitialize).EndInit()
        CType(picTarget1, ComponentModel.ISupportInitialize).EndInit()
        CType(picTarget3, ComponentModel.ISupportInitialize).EndInit()
        lose.ResumeLayout(False)
        win.ResumeLayout(False)
        CType(picDmg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents picJoker As PictureBox
    Friend WithEvents picBoss As PictureBox
    Friend WithEvents picTarget2 As PictureBox
    Friend WithEvents picTarget1 As PictureBox
    Friend WithEvents picTarget3 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents tmrCountdown As Timer
    Friend WithEvents tmrTeleport As Timer
    Friend WithEvents lose As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents win As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents picDmg As PictureBox
    Friend WithEvents hpBar As ProgressBar
End Class
