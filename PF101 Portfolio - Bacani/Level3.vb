Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Level3

    ' --- 1. TURN-BASED COMBAT STATE & STATS ---
    Private rand As New Random()
    Private isPlayerTurn As Boolean = True
    Private isBusy As Boolean = False
    Private isDefending As Boolean = False
    Private bossDead As Boolean = False

    ' Boss Stats
    Private Const maxBossHP As Integer = 1000
    Private currentBossHP As Integer = maxBossHP

    ' Joker Stats
    Private Const maxJokerHP As Integer = 300
    Private currentJokerHP As Integer = maxJokerHP
    Private Const maxJokerSP As Integer = 100
    Private currentJokerSP As Integer = maxJokerSP
    Private Const personaSpCost As Integer = 15

    ' Dynamic Sprite Bounds for True Transparent Form Drawing
    Private jokerRect As Rectangle
    Private bossRect As Rectangle
    Private personaRect As Rectangle
    Private jokerBasePos As Point
    Private bossBasePos As Point
    Private personaBasePos As Point
    Private showPersonaCutIn As Boolean = False

    ' Native Slanted Action Box Text (Drawn directly into the background's black slanted box!)
    Private currentTurnText As String = "YOUR TURN"
    Private currentTurnColor As Color = Color.White

    ' --- 2. BOSS DAMAGE VALUES & IMAGES ---
    Private dmgValues As Integer() = {0, 65, 80, 95, 110, 180}
    Private dmgImages(5) As Image
    Private critChance As Integer = 18

    ' --- 3. DAMAGE POP & SLASH/CURSE VFX VARIABLES ---
    Private dmgCurrent As Image = Nothing
    Private dmgScale As Single = 1.0F
    Private dmgBounds As Rectangle
    Private dmgAnimId As Integer = 0

    ' Visual Slash / Curse Effect on Boss
    Private activeVfxType As Integer = 0 ' 0 = None, 1 = Physical Slash, 2 = Curse Eiha Flame

    ' Joker Floating Text (for taking damage, GUARD, or +SP)
    Private jokerPopupText As String = ""
    Private jokerPopupColor As Color = Color.Red

    ' Center Screen Big P5 Callout Banner (For "1 MORE!", "WEAK!", "ARSÈNE: EIHA!")
    Private centerCalloutText As String = ""
    Private centerCalloutColor As Color = Color.Crimson

    ' --- 4. BOSS IDLE & HURT SPRITES ---
    Private bossIdle(3) As Image
    Private bossHurt1 As Image
    Private bossHurt2 As Image
    Private currentBossSprite As Image = Nothing
    Private idleOrder As Integer() = {0, 1, 2, 3}
    Private idlePos As Integer = 0
    Private idleSpeed As Integer = 380
    Private hurtTime As Integer = 450
    Private hurtId As Integer = 0
    Private tmrIdle As New System.Windows.Forms.Timer()

    ' Hover tracking for custom P5 buttons
    Private hoveredButton As Button = Nothing

    Private Sub Level3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)

        ' Capture Designer PictureBox positions, then hide the PictureBoxes & Labels
        ' so everything renders cleanly with true GDI+ alpha transparency
        jokerRect = picJoker.Bounds
        bossRect = picBoss.Bounds
        personaRect = picPersona.Bounds

        jokerBasePos = jokerRect.Location
        bossBasePos = bossRect.Location
        personaBasePos = personaRect.Location
        dmgBounds = picDmg.Bounds

        picJoker.Visible = False
        picBoss.Visible = False
        picPersona.Visible = False
        picDmg.Visible = False
        hpBar.Visible = False
        lblBossName.Visible = False
        lblActionBanner.Visible = False
        jokerHpBar.Visible = False
        jokerSpBar.Visible = False

        win.Visible = False
        lose.Visible = False

        LoadDamageImages()
        LoadBossImages()
        LoadPersonaImage()

        For Each btn As Button In {btnAttack, btnPersona, btnDefend}
            AddHandler btn.MouseEnter, Sub(s, ev)
                                           hoveredButton = CType(s, Button)
                                           hoveredButton.Invalidate()
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, ev)
                                           hoveredButton = Nothing
                                           CType(s, Button).Invalidate()
                                       End Sub
        Next

        tmrIdle.Interval = idleSpeed
        AddHandler tmrIdle.Tick, AddressOf tmrIdle_Tick

        ResetGame()
    End Sub

    ' --- ASSET LOADERS ---
    Private Function LoadAsset(fileName As String) As Image
        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "Assets", fileName)
        If File.Exists(path) Then
            Using temp As Image = Image.FromFile(path)
                Return New Bitmap(temp)
            End Using
        End If
        Return Nothing
    End Function

    Private Sub LoadDamageImages()
        For i As Integer = 1 To 5
            dmgImages(i) = LoadAsset($"3_dmg_{i}.png")
        Next
    End Sub

    Private Sub LoadBossImages()
        For i As Integer = 0 To 3
            bossIdle(i) = LoadAsset($"3_kamoshida_idle_{i + 1}.png")
        Next
        bossHurt1 = LoadAsset("3_kamoshida_hurt_1.png")
        bossHurt2 = LoadAsset("3_kamoshida_hurt_2.png")
        currentBossSprite = If(bossIdle(0), picBoss.Image)
    End Sub

    Private Sub LoadPersonaImage()
        If picPersona.Image Is Nothing Then
            Dim pImg As Image = LoadAsset("persona.png")
            If pImg Is Nothing Then pImg = LoadAsset("3_persona.png")
            If pImg IsNot Nothing Then picPersona.Image = pImg
        End If
    End Sub

    ' =========================================================================
    ' 2. TRUE LAYERED GDI+ RENDERING (FORM, NATIVE BARS & P5 SKEWED BUTTONS)
    ' =========================================================================
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.InterpolationMode = InterpolationMode.HighQualityBicubic
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' 1. Draw Top Boss HP Bar + Transparent HP Text inside the bar (never covers "Suguru Asmodeus Kamoshida"!)
        DrawSkewedBossBar(g)

        ' 2. Draw Status Text directly inside the native slanted black box near Joker
        DrawNativeSlantedBoxText(g)

        ' 3. Draw Persona Cut-in (Behind Joker when summoned)
        If showPersonaCutIn Then
            DrawPersonaCutIn(g)
        End If

        ' 4. Draw Joker Sprite
        If picJoker.Image IsNot Nothing Then
            g.DrawImage(picJoker.Image, jokerRect)
        End If

        ' 5. Draw Defensive Shield Aura around Joker if Guarding
        If isDefending Then
            Using shieldPen As New Pen(Color.FromArgb(190, 0, 195, 255), 3.0F)
                shieldPen.DashStyle = DashStyle.Dash
                Dim auraRect As New Rectangle(jokerRect.X + 25, jokerRect.Y + 15, jokerRect.Width - 50, jokerRect.Height - 25)
                g.DrawEllipse(shieldPen, auraRect)
            End Using
        End If

        ' 6. Draw Boss Sprite
        Dim bSprite As Image = If(currentBossSprite, picBoss.Image)
        If bSprite IsNot Nothing Then
            DrawImageZoom(g, bSprite, bossRect)
        End If

        ' 7. Draw Attack Slash / Curse Eiha VFX over Boss
        If activeVfxType = 1 Then
            Using slashPenRed As New Pen(Color.FromArgb(220, 255, 0, 35), 9.0F),
                  slashPenWhite As New Pen(Color.White, 3.0F)
                slashPenRed.StartCap = LineCap.Triangle
                slashPenRed.EndCap = LineCap.Triangle
                Dim x1 As Integer = bossRect.X + 90
                Dim y1 As Integer = bossRect.Y + 80
                Dim x2 As Integer = bossRect.Right - 90
                Dim y2 As Integer = bossRect.Bottom - 90
                g.DrawLine(slashPenRed, x1, y1, x2, y2)
                g.DrawLine(slashPenWhite, x1, y1, x2, y2)
            End Using
        ElseIf activeVfxType = 2 Then
            Dim cx As Integer = bossRect.X + bossRect.Width \ 2
            Dim cy As Integer = bossRect.Y + bossRect.Height \ 2
            Using curseBrush As New SolidBrush(Color.FromArgb(145, 160, 0, 50)),
                  cursePen As New Pen(Color.FromArgb(240, 255, 20, 60), 5.0F),
                  corePen As New Pen(Color.Black, 6.0F)
                g.FillEllipse(curseBrush, cx - 130, cy - 130, 260, 260)
                g.DrawEllipse(corePen, cx - 105, cy - 105, 210, 210)
                g.DrawEllipse(cursePen, cx - 130, cy - 130, 260, 260)
                g.DrawLine(cursePen, cx - 160, cy - 40, cx + 160, cy + 40)
                g.DrawLine(cursePen, cx - 40, cy - 160, cx + 40, cy + 160)
            End Using
        End If

        ' 8. Draw Popping Damage Number Image on Boss
        If dmgCurrent IsNot Nothing Then
            Dim ratio As Double = Math.Min(dmgBounds.Width / dmgCurrent.Width, dmgBounds.Height / dmgCurrent.Height)
            Dim w As Integer = CInt(dmgCurrent.Width * ratio * dmgScale)
            Dim h As Integer = CInt(dmgCurrent.Height * ratio * dmgScale)
            Dim cx As Integer = dmgBounds.Left + dmgBounds.Width \ 2
            Dim cy As Integer = dmgBounds.Top + dmgBounds.Height \ 2
            g.DrawImage(dmgCurrent, cx - w \ 2, cy - h \ 2, w, h)
        End If

        ' 9. Draw Joker Floating Damage / Guard Popup
        If Not String.IsNullOrEmpty(jokerPopupText) Then
            Using f As New Font("Impact", 22.0F, FontStyle.Italic)
                Using shadowBrush As New SolidBrush(Color.Black), textBrush As New SolidBrush(jokerPopupColor)
                    Dim px As Integer = jokerRect.X + 45
                    Dim py As Integer = jokerRect.Y + 10
                    g.DrawString(jokerPopupText, f, shadowBrush, px + 4, py + 4)
                    g.DrawString(jokerPopupText, f, textBrush, px, py)
                End Using
            End Using
        End If

        ' 10. Draw Center Screen P5 Callout ("1 MORE!", "WEAK!", etc.)
        If Not String.IsNullOrEmpty(centerCalloutText) Then
            DrawCenterCallout(g)
        End If
    End Sub

    Private Sub DrawImageZoom(g As Graphics, img As Image, bounds As Rectangle)
        Dim ratio As Double = Math.Min(CDbl(bounds.Width) / img.Width, CDbl(bounds.Height) / img.Height)
        Dim w As Integer = CInt(img.Width * ratio)
        Dim h As Integer = CInt(img.Height * ratio)
        Dim x As Integer = bounds.X + (bounds.Width - w) \ 2
        Dim y As Integer = bounds.Y + (bounds.Height - h) \ 2
        g.DrawImage(img, x, y, w, h)
    End Sub

    Private Sub DrawSkewedBossBar(g As Graphics)
        ' Fits inside the native top white/black skewed bar on your background
        Dim barRect As New Rectangle(312, 16, 488, 22)
        Dim skew As Integer = 12

        Dim bgPts As Point() = {
            New Point(barRect.Left + skew, barRect.Top),
            New Point(barRect.Right, barRect.Top),
            New Point(barRect.Right - skew, barRect.Bottom),
            New Point(barRect.Left, barRect.Bottom)
        }

        Using bgBrush As New SolidBrush(Color.FromArgb(225, 16, 16, 16)),
              borderPen As New Pen(Color.White, 2.0F)
            g.FillPolygon(bgBrush, bgPts)

            Dim pct As Single = CSng(Math.Max(0, Math.Min(1.0, currentBossHP / maxBossHP)))
            If pct > 0 Then
                Dim fillW As Integer = CInt((barRect.Width - skew) * pct)
                Dim fillPts As Point() = {
                    New Point(barRect.Left + skew, barRect.Top + 2),
                    New Point(barRect.Left + skew + fillW, barRect.Top + 2),
                    New Point(barRect.Left + fillW, barRect.Bottom - 2),
                    New Point(barRect.Left + 2, barRect.Bottom - 2)
                }
                Using fillBrush As New LinearGradientBrush(barRect, Color.FromArgb(255, 25, 45), Color.FromArgb(180, 0, 20), LinearGradientMode.Horizontal)
                    g.FillPolygon(fillBrush, fillPts)
                End Using
            End If

            g.DrawPolygon(borderPen, bgPts)

            ' Draw Boss HP Counter cleanly inside the right side of the bar (zero overlap with boss name below!)
            Dim hpString As String = $"HP: {currentBossHP} / {maxBossHP}"
            Using f As New Font("Impact", 11.0F, FontStyle.Italic),
                  sf As New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center}
                Dim textRect As New Rectangle(barRect.Left, barRect.Top, barRect.Width - 18, barRect.Height)
                g.DrawString(hpString, f, Brushes.Black, New Rectangle(textRect.X + 2, textRect.Y + 2, textRect.Width, textRect.Height), sf)
                g.DrawString(hpString, f, Brushes.White, textRect, sf)
            End Using
        End Using
    End Sub

    Private Sub DrawNativeSlantedBoxText(g As Graphics)
        ' Draws directly inside the slanted black callout box baked into your background (X:162, Y:205, W:118, H:25)
        Dim boxRect As New Rectangle(162, 204, 118, 25)
        Using f As New Font("Impact", 10.5F, FontStyle.Italic),
              sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center},
              textBrush As New SolidBrush(currentTurnColor)
            g.DrawString(currentTurnText, f, Brushes.Black, New Rectangle(boxRect.X + 2, boxRect.Y + 2, boxRect.Width, boxRect.Height), sf)
            g.DrawString(currentTurnText, f, textBrush, boxRect, sf)
        End Using
    End Sub

    Private Sub DrawPersonaCutIn(g As Graphics)
        If picPersona.Image IsNot Nothing Then
            DrawImageZoom(g, picPersona.Image, personaRect)
        Else
            Dim pts As Point() = {
                New Point(personaRect.Left + 10, personaRect.Top + 25),
                New Point(personaRect.Right - 10, personaRect.Top + 5),
                New Point(personaRect.Right - 25, personaRect.Bottom - 20),
                New Point(personaRect.Left + 25, personaRect.Bottom - 5)
            }
            Using bgBrush As New SolidBrush(Color.FromArgb(215, 190, 0, 25)),
                  borderPen As New Pen(Color.White, 3.0F),
                  innerPen As New Pen(Color.Black, 6.0F)
                g.FillPolygon(bgBrush, pts)
                g.DrawPolygon(innerPen, pts)
                g.DrawPolygon(borderPen, pts)
            End Using

            Using fTitle As New Font("Impact", 22.0F, FontStyle.Italic),
                  fSub As New Font("Impact", 11.0F, FontStyle.Italic)
                g.DrawString("ARSÈNE", fTitle, Brushes.Black, personaRect.Left + 54, personaRect.Top + 78)
                g.DrawString("ARSÈNE", fTitle, Brushes.White, personaRect.Left + 50, personaRect.Top + 74)
                g.DrawString("SKILL: EIHA", fSub, Brushes.Gold, personaRect.Left + 62, personaRect.Top + 118)
            End Using
        End If
    End Sub

    Private Sub DrawCenterCallout(g As Graphics)
        Dim bannerPts As Point() = {
            New Point(320, 115),
            New Point(750, 100),
            New Point(730, 158),
            New Point(300, 173)
        }
        Using bgBrush As New SolidBrush(Color.FromArgb(235, 10, 10, 10)),
              accentPen As New Pen(centerCalloutColor, 4.0F),
              f As New Font("Impact", 21.0F, FontStyle.Italic),
              sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            g.FillPolygon(bgBrush, bannerPts)
            g.DrawPolygon(accentPen, bannerPts)
            Dim rect As New Rectangle(300, 100, 450, 73)
            g.DrawString(centerCalloutText, f, Brushes.Black, New Rectangle(rect.X + 3, rect.Y + 3, rect.Width, rect.Height), sf)
            Using fgBrush As New SolidBrush(centerCalloutColor)
                g.DrawString(centerCalloutText, f, fgBrush, rect, sf)
            End Using
        End Using
    End Sub

    ' --- CUSTOM PAINT FOR JOKER'S SKEWED HP/SP HUD ---
    Private Sub pnlJokerHud_Paint(sender As Object, e As PaintEventArgs) Handles pnlJokerHud.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Draw Skewed HP Bar
        DrawHudMeter(g, New Rectangle(10, 52, 188, 14), CSng(currentJokerHP / maxJokerHP), Color.FromArgb(0, 230, 90), Color.FromArgb(0, 150, 60))

        ' Draw Skewed SP Bar
        DrawHudMeter(g, New Rectangle(10, 95, 188, 14), CSng(currentJokerSP / maxJokerSP), Color.FromArgb(255, 215, 40), Color.FromArgb(210, 140, 0))

        ' Outer Brutalist P5 Border
        Using pRed As New Pen(Color.FromArgb(220, 0, 25), 3.0F),
              pWhite As New Pen(Color.White, 1.5F)
            g.DrawRectangle(pRed, 2, 2, pnlJokerHud.Width - 4, pnlJokerHud.Height - 4)
            g.DrawRectangle(pWhite, 0, 0, pnlJokerHud.Width - 2, pnlJokerHud.Height - 2)
        End Using
    End Sub

    Private Sub DrawHudMeter(g As Graphics, rect As Rectangle, pct As Single, c1 As Color, c2 As Color)
        pct = Math.Max(0.0F, Math.Min(1.0F, pct))
        Dim skew As Integer = 6
        Dim bgPts As Point() = {
            New Point(rect.Left + skew, rect.Top),
            New Point(rect.Right, rect.Top),
            New Point(rect.Right - skew, rect.Bottom),
            New Point(rect.Left, rect.Bottom)
        }
        Using bgBrush As New SolidBrush(Color.FromArgb(45, 45, 45)),
              borderPen As New Pen(Color.FromArgb(190, 255, 255, 255), 1.5F)
            g.FillPolygon(bgBrush, bgPts)
            If pct > 0 Then
                Dim w As Integer = CInt((rect.Width - skew) * pct)
                Dim fillPts As Point() = {
                    New Point(rect.Left + skew, rect.Top + 1),
                    New Point(rect.Left + skew + w, rect.Top + 1),
                    New Point(rect.Left + w, rect.Bottom - 1),
                    New Point(rect.Left + 1, rect.Bottom - 1)
                }
                Using fillBrush As New LinearGradientBrush(rect, c1, c2, LinearGradientMode.Horizontal)
                    g.FillPolygon(fillBrush, fillPts)
                End Using
            End If
            g.DrawPolygon(borderPen, bgPts)
        End Using
    End Sub

    ' --- CUSTOM PAINT FOR P5 COMMAND MENU & BUTTONS ---
    Private Sub pnlCommandMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlCommandMenu.Paint
        Using pRed As New Pen(Color.FromArgb(220, 0, 25), 3.0F),
              pWhite As New Pen(Color.White, 1.5F)
            e.Graphics.DrawRectangle(pRed, 2, 2, pnlCommandMenu.Width - 4, pnlCommandMenu.Height - 4)
            e.Graphics.DrawRectangle(pWhite, 0, 0, pnlCommandMenu.Width - 2, pnlCommandMenu.Height - 2)
        End Using
    End Sub

    Private Sub P5Button_Paint(sender As Object, e As PaintEventArgs) Handles btnAttack.Paint, btnPersona.Paint, btnDefend.Paint
        Dim btn As Button = CType(sender, Button)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        g.Clear(pnlCommandMenu.BackColor)

        Dim isHovered As Boolean = (hoveredButton Is btn) AndAlso btn.Enabled
        Dim accentColor As Color
        Dim mainText As String = ""
        Dim subText As String = ""

        If btn Is btnAttack Then
            accentColor = Color.FromArgb(225, 0, 30)
            mainText = "ATTACK"
            subText = "SLASH / GUN"
        ElseIf btn Is btnPersona Then
            accentColor = Color.FromArgb(225, 0, 30)
            mainText = "PERSONA"
            subText = $"EIHA ({personaSpCost} SP)"
        Else
            accentColor = Color.DeepSkyBlue
            mainText = "DEFEND"
            subText = "GUARD +10 SP"
        End If

        Dim pts As Point() = {
            New Point(7, 2),
            New Point(btn.Width - 2, 2),
            New Point(btn.Width - 7, btn.Height - 2),
            New Point(2, btn.Height - 2)
        }

        Dim fillCol As Color = If(Not btn.Enabled, Color.FromArgb(30, 30, 30),
                               If(isHovered, accentColor,
                               If(btn Is btnAttack, Color.FromArgb(175, 0, 22), Color.FromArgb(26, 26, 26))))

        Dim borderCol As Color = If(Not btn.Enabled, Color.DimGray,
                                 If(isHovered, Color.White, accentColor))

        Using bgBrush As New SolidBrush(fillCol),
              borderPen As New Pen(borderCol, 2.0F)
            g.FillPolygon(bgBrush, pts)
            g.DrawPolygon(borderPen, pts)
        End Using

        Dim textCol As Color = If(btn.Enabled, Color.White, Color.Gray)
        Dim subCol As Color = If(Not btn.Enabled, Color.DimGray, If(isHovered, Color.Black, Color.Silver))

        Using fMain As New Font("Impact", 12.5F, FontStyle.Italic),
              fSub As New Font("Impact", 8.25F, FontStyle.Regular),
              bMain As New SolidBrush(textCol),
              bSub As New SolidBrush(subCol),
              sf As New StringFormat() With {.Alignment = StringAlignment.Center}
            g.DrawString(mainText, fMain, bMain, New RectangleF(0, 4, btn.Width, 23), sf)
            g.DrawString(subText, fSub, bSub, New RectangleF(0, 27, btn.Width, 16), sf)
        End Using
    End Sub

    ' =========================================================================
    ' 3. GAME RESET & HUD UPDATES
    ' =========================================================================
    Public Sub ResetGame()
        bossDead = False
        isPlayerTurn = True
        isBusy = False
        isDefending = False
        showPersonaCutIn = False
        activeVfxType = 0
        centerCalloutText = ""

        currentBossHP = maxBossHP
        currentJokerHP = maxJokerHP
        currentJokerSP = maxJokerSP

        jokerRect.Location = jokerBasePos
        bossRect.Location = bossBasePos
        personaRect.Location = personaBasePos

        hurtId += 1
        StartIdle()

        dmgAnimId += 1
        dmgCurrent = Nothing
        jokerPopupText = ""

        win.Visible = False
        lose.Visible = False

        UpdateHUD()
        SetBanner("YOUR TURN", Color.White, Color.FromArgb(220, 0, 25))
        SetMenuEnabled(True)
        Me.Invalidate()
    End Sub

    Private Sub UpdateHUD()
        lblJokerHp.Text = $"HP   {currentJokerHP} / {maxJokerHP}"
        lblJokerSp.Text = $"SP   {currentJokerSP} / {maxJokerSP}"

        pnlJokerHud.Invalidate()
        Me.Invalidate()
    End Sub

    Private Sub SetBanner(text As String, textColor As Color, headerColor As Color)
        currentTurnText = text
        currentTurnColor = textColor
        lblMenuHeader.BackColor = headerColor
        Me.Invalidate(New Rectangle(150, 195, 145, 45))
    End Sub

    Private Sub SetMenuEnabled(enabled As Boolean)
        pnlCommandMenu.Enabled = enabled
        btnAttack.Enabled = enabled
        btnDefend.Enabled = enabled
        btnPersona.Enabled = enabled AndAlso (currentJokerSP >= personaSpCost)

        btnAttack.Invalidate()
        btnPersona.Invalidate()
        btnDefend.Invalidate()
    End Sub

    ' =========================================================================
    ' 4. PLAYER TURN ACTIONS (ATTACK, PERSONA, DEFEND)
    ' =========================================================================

    ' --- ACTION 1: ATTACK ---
    Private Async Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If Not isPlayerTurn OrElse isBusy OrElse bossDead Then Return
        isBusy = True
        isDefending = False
        SetMenuEnabled(False)

        SetBanner("ATTACK!", Color.White, Color.FromArgb(220, 0, 25))
        PlaySoundSafe("Sounds\Gunshot.wav")

        ' Joker lunges forward to strike
        jokerRect.X = jokerBasePos.X + 55
        activeVfxType = 1
        Me.Invalidate()
        Await Task.Delay(110)

        jokerRect.X = jokerBasePos.X
        activeVfxType = 0
        Me.Invalidate()

        ' Roll damage (1 to 4 normal, 5 = critical)
        Dim isCrit As Boolean = (rand.Next(100) < critChance)
        Dim imgIndex As Integer = If(isCrit, 5, rand.Next(1, 5))
        Dim damage As Integer = dmgValues(imgIndex) + rand.Next(-5, 8)

        TriggerBossDamage(imgIndex, damage)
        BossHurtAnimation()

        If isCrit Then
            SetBanner("CRITICAL!", Color.Gold, Color.Gold)
            centerCalloutText = $"CRITICAL! -{damage} HP"
            centerCalloutColor = Color.Gold
            Me.Invalidate()
        Else
            SetBanner($"-{damage} HP!", Color.White, Color.FromArgb(220, 0, 25))
        End If

        If CheckBossDefeated() Then Return

        BossHurtImage()
        Await Task.Delay(900)
        ClearBossDamagePop()
        centerCalloutText = ""
        Me.Invalidate()

        ' 1 MORE mechanic on Critical Hit!
        If isCrit Then
            SetBanner("1 MORE!", Color.Cyan, Color.Gold)
            centerCalloutText = "1 MORE! EXTRA TURN!"
            centerCalloutColor = Color.Cyan
            Me.Invalidate()
            Await Task.Delay(850)
            centerCalloutText = ""
            isBusy = False
            SetBanner("YOUR TURN", Color.White, Color.FromArgb(220, 0, 25))
            SetMenuEnabled(True)
            Me.Invalidate()
        Else
            Await ExecuteBossTurn()
        End If
    End Sub

    ' --- ACTION 2: PERSONA (SKILL) ---
    Private Async Sub btnPersona_Click(sender As Object, e As EventArgs) Handles btnPersona.Click
        If Not isPlayerTurn OrElse isBusy OrElse bossDead Then Return
        If currentJokerSP < personaSpCost Then Return

        isBusy = True
        isDefending = False
        SetMenuEnabled(False)

        ' Deduct SP
        currentJokerSP -= personaSpCost
        UpdateHUD()

        SetBanner("PERSONA!", Color.Gold, Color.FromArgb(220, 0, 25))
        centerCalloutText = "ARSÈNE: EIHA!"
        centerCalloutColor = Color.FromArgb(255, 30, 60)
        PlaySoundSafe("Sounds\Gunshot.wav")

        ' Show and animate Persona cut-in behind Joker
        personaRect.Location = New Point(personaBasePos.X - 35, personaBasePos.Y + 20)
        showPersonaCutIn = True

        For stepIdx As Integer = 1 To 7
            personaRect.X += 5
            personaRect.Y -= 3
            Me.Invalidate()
            Await Task.Delay(22)
        Next

        Await Task.Delay(220)

        ' Heavy Curse Damage + VFX
        activeVfxType = 2
        Dim hitWeakness As Boolean = (rand.Next(100) < 40)
        Dim dmgIndex As Integer = If(dmgImages(5) IsNot Nothing, 5, 4)
        Dim personaDmg As Integer = rand.Next(160, 198)

        TriggerBossDamage(dmgIndex, personaDmg)
        BossHurtAnimation()

        If hitWeakness Then
            SetBanner("WEAKNESS!", Color.Cyan, Color.Cyan)
            centerCalloutText = $"WEAK! -{personaDmg} HP!"
            centerCalloutColor = Color.Cyan
        Else
            SetBanner($"-{personaDmg} HP!", Color.White, Color.FromArgb(220, 0, 25))
            centerCalloutText = $"EIHA! -{personaDmg} HP!"
            centerCalloutColor = Color.FromArgb(255, 50, 70)
        End If
        Me.Invalidate()

        Await Task.Delay(180)
        activeVfxType = 0
        Me.Invalidate()

        If CheckBossDefeated() Then
            showPersonaCutIn = False
            centerCalloutText = ""
            Me.Invalidate()
            Return
        End If

        BossHurtImage()
        Await Task.Delay(800)

        showPersonaCutIn = False
        centerCalloutText = ""
        ClearBossDamagePop()

        If hitWeakness Then
            SetBanner("1 MORE!", Color.Gold, Color.Gold)
            centerCalloutText = "1 MORE! KNOCK DOWN!"
            centerCalloutColor = Color.Gold
            Me.Invalidate()
            Await Task.Delay(900)
            centerCalloutText = ""
            isBusy = False
            SetBanner("YOUR TURN", Color.White, Color.FromArgb(220, 0, 25))
            SetMenuEnabled(True)
            Me.Invalidate()
        Else
            Await ExecuteBossTurn()
        End If
    End Sub

    ' --- ACTION 3: DEFEND (GUARD) ---
    Private Async Sub btnDefend_Click(sender As Object, e As EventArgs) Handles btnDefend.Click
        If Not isPlayerTurn OrElse isBusy OrElse bossDead Then Return
        isBusy = True
        isDefending = True
        SetMenuEnabled(False)

        ' Recover +10 SP when guarding
        Dim spRegen As Integer = Math.Min(10, maxJokerSP - currentJokerSP)
        currentJokerSP += spRegen
        UpdateHUD()

        SetBanner("GUARDING", Color.DeepSkyBlue, Color.DeepSkyBlue)
        ShowJokerPopup($"GUARD +{spRegen} SP", Color.DeepSkyBlue)

        ' Slight defensive step-back stance
        jokerRect.X = jokerBasePos.X - 12
        Me.Invalidate()
        Await Task.Delay(850)

        jokerPopupText = ""
        Me.Invalidate()

        Await ExecuteBossTurn()
    End Sub

    ' =========================================================================
    ' 5. ENEMY TURN AI (SHADOW KAMOSHIDA)
    ' =========================================================================
    Private Async Function ExecuteBossTurn() As Task
        If bossDead Then Return
        isPlayerTurn = False

        Dim isHeavySpike As Boolean = (rand.Next(100) < 40)
        Dim attackName As String = If(isHeavySpike, "VOLLEYBALL SPIKE!", "CROWN SLAM!")
        Dim rawDamage As Integer = If(isHeavySpike, rand.Next(55, 76), rand.Next(35, 52))

        SetBanner("ENEMY TURN", Color.OrangeRed, Color.OrangeRed)
        centerCalloutText = $"KAMOSHIDA: {attackName}"
        centerCalloutColor = Color.OrangeRed
        Me.Invalidate()
        Await Task.Delay(700)

        ' Boss lunges toward Joker
        For i As Integer = 1 To 4
            bossRect.X -= 20
            Me.Invalidate()
            Await Task.Delay(22)
        Next
        PlaySoundSafe("Sounds\Gunshot.wav")
        For i As Integer = 1 To 4
            bossRect.X += 20
            Me.Invalidate()
            Await Task.Delay(22)
        Next
        bossRect.Location = bossBasePos
        centerCalloutText = ""

        ' Calculate Damage (60% reduction if Defending)
        Dim finalDamage As Integer = rawDamage
        If isDefending Then
            finalDamage = CInt(Math.Max(1, Math.Round(rawDamage * 0.4)))
        End If

        currentJokerHP = Math.Max(0, currentJokerHP - finalDamage)
        UpdateHUD()

        If isDefending Then
            SetBanner("BLOCKED!", Color.DeepSkyBlue, Color.DeepSkyBlue)
            ShowJokerPopup($"-{finalDamage} (GUARD)", Color.DeepSkyBlue)
        Else
            SetBanner($"-{finalDamage} HP!", Color.Red, Color.Red)
            ShowJokerPopup($"-{finalDamage}", Color.Red)
        End If

        ' Shake Joker on hit
        For i As Integer = 1 To 3
            jokerRect.X -= 10
            Me.Invalidate()
            Await Task.Delay(32)
            jokerRect.X += 10
            Me.Invalidate()
            Await Task.Delay(32)
        Next
        jokerRect.Location = jokerBasePos
        Me.Invalidate()

        Await Task.Delay(800)
        jokerPopupText = ""
        Me.Invalidate()

        ' Check if Joker died
        If currentJokerHP <= 0 Then
            SetBanner("DEFEATED", Color.Red, Color.Red)
            tmrIdle.Stop()
            lose.Location = New Point((Me.ClientSize.Width - lose.Width) \ 2, (Me.ClientSize.Height - lose.Height) \ 2)
            lose.BringToFront()
            lose.Visible = True
            Return
        End If

        ' Return to Player Turn
        isDefending = False
        isPlayerTurn = True
        isBusy = False
        SetBanner("YOUR TURN", Color.White, Color.FromArgb(220, 0, 25))
        SetMenuEnabled(True)
        Me.Invalidate()
    End Function

    ' =========================================================================
    ' 6. ANIMATIONS & HELPERS
    ' =========================================================================
    Private Function CheckBossDefeated() As Boolean
        If currentBossHP <= 0 Then
            bossDead = True
            hurtId += 1
            tmrIdle.Stop()
            If bossHurt2 IsNot Nothing Then currentBossSprite = bossHurt2

            SetBanner("VICTORY!", Color.Gold, Color.Gold)
            centerCalloutText = ""
            SetMenuEnabled(False)
            Me.Invalidate()

            win.Location = New Point((Me.ClientSize.Width - win.Width) \ 2, (Me.ClientSize.Height - win.Height) \ 2)
            win.BringToFront()
            win.Visible = True
            Return True
        End If
        Return False
    End Function

    Private Sub TriggerBossDamage(imgIndex As Integer, damageAmount As Integer)
        currentBossHP = Math.Max(0, currentBossHP - damageAmount)
        UpdateHUD()

        If dmgImages(imgIndex) IsNot Nothing Then
            dmgCurrent = dmgImages(imgIndex)
            PopDamage()
        End If
    End Sub

    Private Sub ClearBossDamagePop()
        dmgAnimId += 1
        dmgCurrent = Nothing
        Me.Invalidate()
    End Sub

    Private Sub ShowJokerPopup(text As String, col As Color)
        jokerPopupText = text
        jokerPopupColor = col
        Me.Invalidate()
    End Sub

    Private Sub PlaySoundSafe(relativePath As String)
        Try
            Dim fullPath As String = System.IO.Path.Combine(Application.StartupPath, relativePath)
            If File.Exists(fullPath) Then
                My.Computer.Audio.Play(fullPath, AudioPlayMode.Background)
            End If
        Catch
        End Try
    End Sub

    ' --- BOSS IDLE LOOP ---
    Private Sub StartIdle()
        idlePos = 0
        If bossIdle(idleOrder(0)) IsNot Nothing Then currentBossSprite = bossIdle(idleOrder(0))
        tmrIdle.Stop()
        tmrIdle.Start()
        Me.Invalidate()
    End Sub

    Private Sub tmrIdle_Tick(sender As Object, e As EventArgs)
        If bossDead Then Return
        idlePos = (idlePos + 1) Mod idleOrder.Length
        Dim frame As Image = bossIdle(idleOrder(idlePos))
        If frame IsNot Nothing Then
            currentBossSprite = frame
            Me.Invalidate(bossRect)
        End If
    End Sub

    Private Async Sub BossHurtImage()
        hurtId += 1
        Dim myId As Integer = hurtId

        tmrIdle.Stop()
        If bossHurt1 IsNot Nothing Then
            currentBossSprite = bossHurt1
            Me.Invalidate(bossRect)
        End If

        Await Task.Delay(hurtTime)

        If myId <> hurtId OrElse bossDead Then Return
        StartIdle()
    End Sub

    Private Async Sub BossHurtAnimation()
        For i As Integer = 1 To 2
            bossRect.X += 12
            bossRect.Y -= 6
            Me.Invalidate()
            Await Task.Delay(28)
            bossRect.X -= 12
            bossRect.Y += 6
            Me.Invalidate()
            Await Task.Delay(28)
        Next
        bossRect.Location = bossBasePos
        Me.Invalidate()
    End Sub

    ' --- POP ANIMATION ---
    Private Async Sub PopDamage()
        dmgAnimId += 1
        Dim myId As Integer = dmgAnimId

        Const totalSteps As Integer = 8
        Const startScale As Single = 0.55F
        Dim area As Rectangle = Rectangle.Inflate(dmgBounds, 30, 30)

        For i As Integer = 0 To totalSteps
            If myId <> dmgAnimId Then Return

            Dim t As Single = CSng(i / totalSteps)
            Dim eased As Single = 1.0F - CSng(Math.Pow(1.0F - t, 3))
            dmgScale = startScale + (1.0F - startScale) * eased

            Me.Invalidate(area)
            Await Task.Delay(14)
        Next
    End Sub

    ' --- NAVIGATION & RESTART BUTTON HANDLERS ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrIdle.Stop()
        Me.Hide()
        Menu.Show()
        Menu.Update()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lose.Visible = False
        ResetGame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        win.Visible = False
        ResetGame()
    End Sub

End Class