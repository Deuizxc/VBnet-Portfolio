Public Class Level3
    ' --- 1. ENGINE VARIABLES ---
    Private rand As New Random()
    Private hitCount As Integer = 0
    Private targetGoal As Integer = 40
    Private maxTimerWidth As Integer = 500

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

        maxTimerWidth = panTimer.Width

        ' Slow down the master shuffle timer to 3 seconds
        tmrTeleport.Interval = 3000

        ' Hide the result panels initially on load
        win.Visible = False
        lose.Visible = False

        ResetGame()
    End Sub

    Public Sub ResetGame()
        hitCount = 0
        lblScore.Text = $"HITS: 0 / {targetGoal}"
        panTimer.Width = maxTimerWidth

        picTarget1.Visible = True
        picTarget2.Visible = True
        picTarget3.Visible = True

        ' Hide result panels on reset
        win.Visible = False
        lose.Visible = False

        ' Instantly place them on the boss before the timer even starts
        ShuffleAllTargets()

        tmrCountdown.Start()
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

    ' --- 3. THE CLOCK ---
    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        panTimer.Width -= 2

        If panTimer.Width <= 0 Then
            tmrCountdown.Stop()
            tmrTeleport.Stop()
            panTimer.Width = 0

            picTarget1.Visible = False
            picTarget2.Visible = False
            picTarget3.Visible = False

            ' Center and show the Lose panel
            lose.Location = New Point((Me.ClientSize.Width - lose.Width) \ 2, (Me.ClientSize.Height - lose.Height) \ 2)
            lose.BringToFront()
            lose.Visible = True
        End If
    End Sub

    ' --- 4. THE HITBOX CLICKS ---
    Private Sub Target_Click(sender As Object, e As EventArgs) Handles picTarget1.Click, picTarget2.Click, picTarget3.Click
        AudioManager.PlayGunshot()
        hitCount += 1
        lblScore.Text = $"HITS: {hitCount} / {targetGoal}"

        Dim clickedTarget As PictureBox = CType(sender, PictureBox)
        ShuffleTarget(clickedTarget)

        tmrTeleport.Stop()
        tmrTeleport.Start()

        FireGunAnimation()
        BossHurtAnimation()

        If hitCount >= targetGoal Then
            tmrCountdown.Stop()
            tmrTeleport.Stop()

            picTarget1.Visible = False
            picTarget2.Visible = False
            picTarget3.Visible = False

            ' Center and show the Win panel
            win.Location = New Point((Me.ClientSize.Width - win.Width) \ 2, (Me.ClientSize.Height - win.Height) \ 2)
            win.BringToFront()
            win.Visible = True
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