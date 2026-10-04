Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Public Class Level3
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    Private Const PBM_SETSTATE As Integer = &H410
    Private Const PBST_ERROR As Integer = 2
    ' --- 1. ENGINE VARIABLES ---
    Private rand As New Random()
    Private hitCount As Integer = 0

    ' --- HP BAR ---
    Private Const maxHP As Integer = 1000
    ' Damage per image. Index 1 to 5 matches 3_dmg_1 to 3_dmg_5 (index 0 unused)
    Private dmgValues As Integer() = {0, 45, 67, 70, 80, 99}

    ' --- DAMAGE IMAGES ---
    Private dmgImages(5) As Image          ' index 1 to 5 used
    Private critChance As Integer = 8      ' % chance for 3_dmg_5.png (crit)

    ' --- DAMAGE DRAWING / POP ANIMATION ---
    Private dmgCurrent As Image = Nothing  ' the image currently shown on the boss
    Private dmgScale As Single = 1.0F      ' 1.0 = normal size
    Private dmgBounds As Rectangle         ' where to draw it, relative to picBoss
    Private dmgAnimId As Integer = 0       ' lets a new hit cancel the previous pop

    ' --- BOSS IMAGES / IDLE ANIMATION ---
    Private bossIdle(3) As Image                       ' idle_1 to idle_4 (index 0 to 3)
    Private bossHurt1 As Image
    Private bossHurt2 As Image
    Private idleOrder As Integer() = {0, 1, 2, 3}   ' 1,2,3,4,3,2 then loops back to 1
    Private idlePos As Integer = 0
    Private idleSpeed As Integer = 400                ' ms per idle frame (lower = faster)
    Private hurtTime As Integer = 400                 ' ms the hurt image stays up
    Private hurtId As Integer = 0                      ' lets a newer hit take over the hurt timing
    Private bossDead As Boolean = False
    Private tmrIdle As New System.Windows.Forms.Timer()

    ' --- HARDCODED SPAWN LOCATIONS ---
    Private spawnPoints As Point() = {
                New Point(756, 240), New Point(619, 229), New Point(633, 363),
                New Point(639, 460), New Point(828, 473), New Point(898, 411),
                New Point(927, 296), New Point(750, 433), New Point(778, 366),
                New Point(765, 167)
            }

    Private Sub Level3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        ' Glue targets to the boss so they don't punch holes in the background
        picTarget1.Parent = picBoss
        picTarget2.Parent = picBoss
        picTarget3.Parent = picBoss

        picTarget1.BackColor = Color.Transparent
        picTarget2.BackColor = Color.Transparent
        picTarget3.BackColor = Color.Transparent

        ' Use picDmg only as a "placeholder" for position and size.
        If picDmg.Parent Is picBoss Then
            dmgBounds = picDmg.Bounds
        Else
            dmgBounds = New Rectangle(picDmg.Left - picBoss.Left, picDmg.Top - picBoss.Top, picDmg.Width, picDmg.Height)
        End If
        picDmg.Visible = False

        ' HP bar setup
        hpBar.Minimum = 0
        hpBar.Maximum = maxHP
        AddHandler hpBar.HandleCreated, Sub() MakeHpBarRed()

        ' Slow down the master shuffle timer to 3 seconds
        tmrTeleport.Interval = 3000

        ' Hide the result panels initially on load
        win.Visible = False
        lose.Visible = False

        LoadDamageImages()
        LoadBossImages()

        ' Idle animation timer
        tmrIdle.Interval = idleSpeed
        AddHandler tmrIdle.Tick, AddressOf tmrIdle_Tick

        ResetGame()
    End Sub

    Private Sub Level3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        hpBar.Value = maxHP
        MakeHpBarRed()
    End Sub

    ' Load all 5 damage images once so clicking doesn't read from disk every time
    Private Sub LoadDamageImages()
        For i As Integer = 1 To 5
            Dim path As String = System.IO.Path.Combine(Application.StartupPath, "Assets", $"3_dmg_{i}.png")
            If File.Exists(path) Then
                Using temp As Image = Image.FromFile(path)
                    dmgImages(i) = New Bitmap(temp)   ' copy so the file isn't locked
                End Using
            End If
        Next
    End Sub

    ' --- BOSS IMAGE LOADING ---
    Private Function LoadAsset(fileName As String) As Image
        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "Assets", fileName)
        If File.Exists(path) Then
            Using temp As Image = Image.FromFile(path)
                Return New Bitmap(temp)               ' copy so the file isn't locked
            End Using
        End If
        Return Nothing
    End Function

    Private Sub LoadBossImages()
        For i As Integer = 0 To 3
            bossIdle(i) = LoadAsset($"3_kamoshida_idle_{i + 1}.png")
        Next
        bossHurt1 = LoadAsset("3_kamoshida_hurt_1.png")
        bossHurt2 = LoadAsset("3_kamoshida_hurt_2.png")
    End Sub

    ' --- IDLE ANIMATION ---
    Private Sub StartIdle()
        idlePos = 0
        If bossIdle(idleOrder(0)) IsNot Nothing Then picBoss.Image = bossIdle(idleOrder(0))
        tmrIdle.Stop()
        tmrIdle.Start()
    End Sub

    Private Sub tmrIdle_Tick(sender As Object, e As EventArgs)
        If bossDead Then Return
        idlePos = (idlePos + 1) Mod idleOrder.Length
        Dim frame As Image = bossIdle(idleOrder(idlePos))
        If frame IsNot Nothing Then picBoss.Image = frame
    End Sub

    ' Shows hurt_1 briefly, then goes back to idle starting from idle_1
    Private Async Sub BossHurtImage()
        hurtId += 1
        Dim myId As Integer = hurtId

        tmrIdle.Stop()
        If bossHurt1 IsNot Nothing Then picBoss.Image = bossHurt1

        Await Task.Delay(hurtTime)

        ' Ignore if a newer hit happened, or the boss died in the meantime
        If myId <> hurtId OrElse bossDead Then Return
        StartIdle()
    End Sub

    Private Sub MakeHpBarRed()
        If hpBar.IsHandleCreated Then
            SendMessage(hpBar.Handle, PBM_SETSTATE, PBST_ERROR, 0)
        End If
    End Sub
    ' Picks 1 to 4 most of the time, 5 (crit) rarely. Returns the number picked.
    Private Function ShowDamageImage() As Integer
        Dim n As Integer

        If rand.Next(100) < critChance Then
            n = 5
        Else
            n = rand.Next(1, 5)   ' 1, 2, 3 or 4
        End If

        If dmgImages(n) IsNot Nothing Then
            dmgCurrent = dmgImages(n)
            PopDamage()
        End If

        Return n
    End Function

    ' --- DRAWS THE DAMAGE IMAGE ON TOP OF THE BOSS ---
    Private Sub picBoss_Paint(sender As Object, e As PaintEventArgs) Handles picBoss.Paint
        If dmgCurrent Is Nothing Then Return

        Dim g As Graphics = e.Graphics
        g.InterpolationMode = InterpolationMode.HighQualityBicubic
        g.SmoothingMode = SmoothingMode.HighQuality

        Dim ratio As Double = Math.Min(dmgBounds.Width / dmgCurrent.Width, dmgBounds.Height / dmgCurrent.Height)
        Dim w As Integer = CInt(dmgCurrent.Width * ratio * dmgScale)
        Dim h As Integer = CInt(dmgCurrent.Height * ratio * dmgScale)

        Dim cx As Integer = dmgBounds.Left + dmgBounds.Width \ 2
        Dim cy As Integer = dmgBounds.Top + dmgBounds.Height \ 2

        g.DrawImage(dmgCurrent, cx - w \ 2, cy - h \ 2, w, h)
    End Sub

    ' --- POP ANIMATION: starts small, grows back to full size ---
    Private Async Sub PopDamage()
        dmgAnimId += 1
        Dim myId As Integer = dmgAnimId

        Const totalSteps As Integer = 8
        Const startScale As Single = 0.6F
        Dim area As Rectangle = Rectangle.Inflate(dmgBounds, 20, 20)

        For i As Integer = 0 To totalSteps
            If myId <> dmgAnimId Then Return

            Dim t As Single = i / totalSteps
            Dim eased As Single = 1.0F - CSng(Math.Pow(1.0F - t, 3))
            dmgScale = startScale + (1.0F - startScale) * eased

            picBoss.Invalidate(area)
            picBoss.Update()
            Await Task.Delay(12)
        Next
    End Sub

    Public Sub ResetGame()
        hitCount = 0
        lblScore.Text = "HITS: 0"
        hpBar.Value = maxHP
        MakeHpBarRed()

        ' Boss is alive again, restart idle loop from idle_1
        bossDead = False
        hurtId += 1
        StartIdle()

        ' Clear the damage image
        dmgAnimId += 1
        dmgCurrent = Nothing
        picBoss.Invalidate()

        picTarget1.Visible = True
        picTarget2.Visible = True
        picTarget3.Visible = True

        ' Hide result panels on reset
        win.Visible = False
        lose.Visible = False

        ' Instantly place them on the boss before the timer starts
        ShuffleAllTargets()

        tmrTeleport.Start()
    End Sub

    ' --- FIXED SPAWN LOGIC ---
    Private Sub ShuffleTarget(target As PictureBox)
        Dim pt As Point = spawnPoints(rand.Next(spawnPoints.Length))
        target.Left = pt.X - picBoss.Left
        target.Top = pt.Y - picBoss.Top
    End Sub

    Private Sub ShuffleAllTargets()
        ShuffleTarget(picTarget1)
        ShuffleTarget(picTarget2)
        ShuffleTarget(picTarget3)
    End Sub

    ' --- 2. THE TELEPORTER ---
    Private Sub tmrTeleport_Tick(sender As Object, e As EventArgs) Handles tmrTeleport.Tick
        ShuffleAllTargets()
    End Sub

    ' --- 4. THE HITBOX CLICKS ---
    Private Sub Target_Click(sender As Object, e As EventArgs) Handles picTarget1.Click, picTarget2.Click, picTarget3.Click
        If bossDead Then Return

        My.Computer.Audio.Play("Sounds\Gunshot.wav", AudioPlayMode.Background)
        hitCount += 1
        lblScore.Text = $"HITS: {hitCount}"

        ' Show a damage image and take HP based on which one it was
        Dim n As Integer = ShowDamageImage()
        hpBar.Value = Math.Max(0, hpBar.Value - dmgValues(n))

        Dim clickedTarget As PictureBox = CType(sender, PictureBox)
        ShuffleTarget(clickedTarget)

        tmrTeleport.Stop()
        tmrTeleport.Start()

        FireGunAnimation()
        BossHurtAnimation()

        ' Boss is dead
        If hpBar.Value <= 0 Then
            bossDead = True
            hurtId += 1
            tmrIdle.Stop()
            If bossHurt2 IsNot Nothing Then picBoss.Image = bossHurt2

            tmrTeleport.Stop()

            picTarget1.Visible = False
            picTarget2.Visible = False
            picTarget3.Visible = False

            ' Center and show the Win panel
            win.Location = New Point((Me.ClientSize.Width - win.Width) \ 2, (Me.ClientSize.Height - win.Height) \ 2)
            win.BringToFront()
            win.Visible = True
        Else
            BossHurtImage()
        End If
    End Sub

    ' --- 5. THE VISUAL EFFECTS ---
    Private Async Sub FireGunAnimation()
        picJoker.Left -= 15
        Await Task.Delay(50)
        picJoker.Left += 15
    End Sub

    Private Async Sub BossHurtAnimation()
        For i As Integer = 1 To 2
            picBoss.Left += 10
            picBoss.Top -= 5
            Await Task.Delay(30)
            picBoss.Left -= 10
            picBoss.Top += 5
            Await Task.Delay(30)
        Next
    End Sub

    ' --- NAVIGATION & RESTART BUTTON HANDLERS ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menu.Show()
        Menu.Update()
    End Sub

    ' FIXED: Added ResetGame() so it actually restarts when you click Try Again
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lose.Visible = False
        ResetGame()
    End Sub

    ' FIXED: Added ResetGame() so it actually restarts when you click Try Again
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        win.Visible = False
        ResetGame()
    End Sub

End Class