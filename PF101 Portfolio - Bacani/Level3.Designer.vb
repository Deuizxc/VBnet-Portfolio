<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level3))
        Button1 = New Button()
        picJoker = New PictureBox()
        picPersona = New PictureBox()
        picBoss = New PictureBox()
        lose = New Panel()
        Button7 = New Button()
        win = New Panel()
        Button2 = New Button()
        picDmg = New PictureBox()
        hpBar = New ProgressBar()
        lblBossName = New Label()
        lblActionBanner = New Label()
        pnlCommandMenu = New Panel()
        lblMenuHeader = New Label()
        btnAttack = New Button()
        btnPersona = New Button()
        btnDefend = New Button()
        pnlJokerHud = New Panel()
        lblJokerTitle = New Label()
        lblJokerHp = New Label()
        jokerHpBar = New ProgressBar()
        lblJokerSp = New Label()
        jokerSpBar = New ProgressBar()
        CType(picJoker, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPersona, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoss, ComponentModel.ISupportInitialize).BeginInit()
        lose.SuspendLayout()
        win.SuspendLayout()
        CType(picDmg, ComponentModel.ISupportInitialize).BeginInit()
        pnlCommandMenu.SuspendLayout()
        pnlJokerHud.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(8, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 36)
        Button1.TabIndex = 24
        Button1.UseVisualStyleBackColor = False
        ' 
        ' picJoker
        ' 
        picJoker.BackColor = Color.Transparent
        picJoker.Image = CType(resources.GetObject("picJoker.Image"), Image)
        picJoker.Location = New Point(225, 195)
        picJoker.Name = "picJoker"
        picJoker.Size = New Size(265, 290)
        picJoker.SizeMode = PictureBoxSizeMode.StretchImage
        picJoker.TabIndex = 25
        picJoker.TabStop = False
        picJoker.Visible = False
        ' 
        ' picPersona
        ' 
        picPersona.BackColor = Color.Transparent
        picPersona.Location = New Point(175, 70)
        picPersona.Name = "picPersona"
        picPersona.Size = New Size(235, 235)
        picPersona.SizeMode = PictureBoxSizeMode.Zoom
        picPersona.TabIndex = 50
        picPersona.TabStop = False
        picPersona.Visible = False
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
        picBoss.Visible = False
        ' 
        ' lose
        ' 
        lose.BackColor = Color.Transparent
        lose.BackgroundImage = CType(resources.GetObject("lose.BackgroundImage"), Image)
        lose.BackgroundImageLayout = ImageLayout.Stretch
        lose.Controls.Add(Button7)
        lose.Location = New Point(955, 371)
        lose.Name = "lose"
        lose.Size = New Size(608, 407)
        lose.TabIndex = 45
        lose.Visible = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.Cursor = Cursors.Hand
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
        win.Location = New Point(496, 512)
        win.Name = "win"
        win.Size = New Size(608, 407)
        win.TabIndex = 46
        win.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
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
        picDmg.Location = New Point(820, 95)
        picDmg.Name = "picDmg"
        picDmg.Size = New Size(170, 145)
        picDmg.SizeMode = PictureBoxSizeMode.Zoom
        picDmg.TabIndex = 47
        picDmg.TabStop = False
        picDmg.Visible = False
        ' 
        ' hpBar
        ' 
        hpBar.Location = New Point(308, 8)
        hpBar.Maximum = 1000
        hpBar.Name = "hpBar"
        hpBar.Size = New Size(527, 36)
        hpBar.TabIndex = 48
        hpBar.Visible = False
        ' 
        ' lblBossName
        ' 
        lblBossName.Location = New Point(645, 41)
        lblBossName.Name = "lblBossName"
        lblBossName.Size = New Size(10, 10)
        lblBossName.TabIndex = 51
        lblBossName.Visible = False
        ' 
        ' lblActionBanner
        ' 
        lblActionBanner.Location = New Point(162, 205)
        lblActionBanner.Name = "lblActionBanner"
        lblActionBanner.Size = New Size(10, 10)
        lblActionBanner.TabIndex = 52
        lblActionBanner.Visible = False
        ' 
        ' pnlCommandMenu
        ' 
        pnlCommandMenu.BackColor = Color.FromArgb(CByte(14), CByte(14), CByte(14))
        pnlCommandMenu.Controls.Add(lblMenuHeader)
        pnlCommandMenu.Controls.Add(btnAttack)
        pnlCommandMenu.Controls.Add(btnPersona)
        pnlCommandMenu.Controls.Add(btnDefend)
        pnlCommandMenu.Location = New Point(12, 180)
        pnlCommandMenu.Name = "pnlCommandMenu"
        pnlCommandMenu.Size = New Size(144, 208)
        pnlCommandMenu.TabIndex = 53
        ' 
        ' lblMenuHeader
        ' 
        lblMenuHeader.BackColor = Color.FromArgb(CByte(220), CByte(0), CByte(25))
        lblMenuHeader.Font = New Font("Impact", 12.0F, FontStyle.Italic)
        lblMenuHeader.ForeColor = Color.White
        lblMenuHeader.Location = New Point(2, 2)
        lblMenuHeader.Name = "lblMenuHeader"
        lblMenuHeader.Size = New Size(140, 26)
        lblMenuHeader.TabIndex = 0
        lblMenuHeader.Text = "COMMAND"
        lblMenuHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAttack
        ' 
        btnAttack.BackColor = Color.FromArgb(CByte(200), CByte(0), CByte(25))
        btnAttack.Cursor = Cursors.Hand
        btnAttack.FlatAppearance.BorderColor = Color.White
        btnAttack.FlatAppearance.BorderSize = 0
        btnAttack.FlatStyle = FlatStyle.Flat
        btnAttack.Font = New Font("Impact", 13.0F, FontStyle.Italic)
        btnAttack.ForeColor = Color.White
        btnAttack.Location = New Point(7, 36)
        btnAttack.Name = "btnAttack"
        btnAttack.Size = New Size(130, 48)
        btnAttack.TabIndex = 1
        btnAttack.Text = "ATTACK"
        btnAttack.UseVisualStyleBackColor = False
        ' 
        ' btnPersona
        ' 
        btnPersona.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnPersona.Cursor = Cursors.Hand
        btnPersona.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(0), CByte(25))
        btnPersona.FlatAppearance.BorderSize = 0
        btnPersona.FlatStyle = FlatStyle.Flat
        btnPersona.Font = New Font("Impact", 13.0F, FontStyle.Italic)
        btnPersona.ForeColor = Color.White
        btnPersona.Location = New Point(7, 92)
        btnPersona.Name = "btnPersona"
        btnPersona.Size = New Size(130, 48)
        btnPersona.TabIndex = 2
        btnPersona.Text = "PERSONA"
        btnPersona.UseVisualStyleBackColor = False
        ' 
        ' btnDefend
        ' 
        btnDefend.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnDefend.Cursor = Cursors.Hand
        btnDefend.FlatAppearance.BorderColor = Color.DeepSkyBlue
        btnDefend.FlatAppearance.BorderSize = 0
        btnDefend.FlatStyle = FlatStyle.Flat
        btnDefend.Font = New Font("Impact", 13.0F, FontStyle.Italic)
        btnDefend.ForeColor = Color.White
        btnDefend.Location = New Point(7, 148)
        btnDefend.Name = "btnDefend"
        btnDefend.Size = New Size(130, 48)
        btnDefend.TabIndex = 3
        btnDefend.Text = "DEFEND"
        btnDefend.UseVisualStyleBackColor = False
        ' 
        ' pnlJokerHud
        ' 
        pnlJokerHud.BackColor = Color.FromArgb(CByte(14), CByte(14), CByte(14))
        pnlJokerHud.Controls.Add(lblJokerTitle)
        pnlJokerHud.Controls.Add(lblJokerHp)
        pnlJokerHud.Controls.Add(jokerHpBar)
        pnlJokerHud.Controls.Add(lblJokerSp)
        pnlJokerHud.Controls.Add(jokerSpBar)
        pnlJokerHud.Location = New Point(12, 412)
        pnlJokerHud.Name = "pnlJokerHud"
        pnlJokerHud.Size = New Size(212, 122)
        pnlJokerHud.TabIndex = 54
        ' 
        ' lblJokerTitle
        ' 
        lblJokerTitle.BackColor = Color.FromArgb(CByte(220), CByte(0), CByte(25))
        lblJokerTitle.Font = New Font("Impact", 11.5F, FontStyle.Italic)
        lblJokerTitle.ForeColor = Color.White
        lblJokerTitle.Location = New Point(2, 2)
        lblJokerTitle.Name = "lblJokerTitle"
        lblJokerTitle.Padding = New Padding(6, 0, 0, 0)
        lblJokerTitle.Size = New Size(208, 24)
        lblJokerTitle.TabIndex = 0
        lblJokerTitle.Text = "JOKER  |  LV. 99"
        lblJokerTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblJokerHp
        ' 
        lblJokerHp.AutoSize = True
        lblJokerHp.Font = New Font("Impact", 10.5F, FontStyle.Italic)
        lblJokerHp.ForeColor = Color.FromArgb(CByte(80), CByte(255), CByte(130))
        lblJokerHp.Location = New Point(10, 30)
        lblJokerHp.Name = "lblJokerHp"
        lblJokerHp.Size = New Size(85, 18)
        lblJokerHp.TabIndex = 1
        lblJokerHp.Text = "HP   300 / 300"
        ' 
        ' jokerHpBar
        ' 
        jokerHpBar.Location = New Point(12, 51)
        jokerHpBar.Maximum = 300
        jokerHpBar.Name = "jokerHpBar"
        jokerHpBar.Size = New Size(186, 14)
        jokerHpBar.TabIndex = 2
        jokerHpBar.Value = 300
        jokerHpBar.Visible = False
        ' 
        ' lblJokerSp
        ' 
        lblJokerSp.AutoSize = True
        lblJokerSp.Font = New Font("Impact", 10.5F, FontStyle.Italic)
        lblJokerSp.ForeColor = Color.FromArgb(CByte(255), CByte(215), CByte(50))
        lblJokerSp.Location = New Point(10, 73)
        lblJokerSp.Name = "lblJokerSp"
        lblJokerSp.Size = New Size(80, 18)
        lblJokerSp.TabIndex = 3
        lblJokerSp.Text = "SP   100 / 100"
        ' 
        ' jokerSpBar
        ' 
        jokerSpBar.Location = New Point(12, 94)
        jokerSpBar.Name = "jokerSpBar"
        jokerSpBar.Size = New Size(186, 14)
        jokerSpBar.TabIndex = 4
        jokerSpBar.Value = 100
        jokerSpBar.Visible = False
        ' 
        ' Level3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1064, 559)
        Controls.Add(win)
        Controls.Add(lose)
        Controls.Add(pnlCommandMenu)
        Controls.Add(pnlJokerHud)
        Controls.Add(lblActionBanner)
        Controls.Add(lblBossName)
        Controls.Add(hpBar)
        Controls.Add(picDmg)
        Controls.Add(picBoss)
        Controls.Add(picJoker)
        Controls.Add(picPersona)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Level3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level3"
        CType(picJoker, ComponentModel.ISupportInitialize).EndInit()
        CType(picPersona, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoss, ComponentModel.ISupportInitialize).EndInit()
        lose.ResumeLayout(False)
        win.ResumeLayout(False)
        CType(picDmg, ComponentModel.ISupportInitialize).EndInit()
        pnlCommandMenu.ResumeLayout(False)
        pnlJokerHud.ResumeLayout(False)
        pnlJokerHud.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents picJoker As PictureBox
    Friend WithEvents picPersona As PictureBox
    Friend WithEvents picBoss As PictureBox
    Friend WithEvents lose As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents win As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents picDmg As PictureBox
    Friend WithEvents hpBar As ProgressBar
    Friend WithEvents lblBossName As Label
    Friend WithEvents lblActionBanner As Label
    Friend WithEvents pnlCommandMenu As Panel
    Friend WithEvents lblMenuHeader As Label
    Friend WithEvents btnAttack As Button
    Friend WithEvents btnPersona As Button
    Friend WithEvents btnDefend As Button
    Friend WithEvents pnlJokerHud As Panel
    Friend WithEvents lblJokerTitle As Label
    Friend WithEvents lblJokerHp As Label
    Friend WithEvents jokerHpBar As ProgressBar
    Friend WithEvents lblJokerSp As Label
    Friend WithEvents jokerSpBar As ProgressBar
End Class