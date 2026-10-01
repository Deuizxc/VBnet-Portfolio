Public Class Level1

    Private WithEvents gameTimer As New Timer()
    Private WithEvents countdownTimer As New Timer()
    Private timeLeft As Integer = 60

    Private verticalBounceHeight As Integer = 120

    Private boatLocation As String = "Right"
    Private slot1 As PictureBox = Nothing
    Private slot2 As PictureBox = Nothing

    Private boatRightX As Integer = 572
    Private boatLeftX As Integer = 340
    Private boatY As Integer = 349

    Private rightShorePositions As New Dictionary(Of PictureBox, Point)
    Private leftShorePositions As New Dictionary(Of PictureBox, Point)

    Private movingChar As PictureBox = Nothing
    Private charStart As Point
    Private charTarget As Point
    Private jumpProgress As Double = 0.0
    Private jumpSpeed As Double = 0.04

    Private isBoatMoving As Boolean = False
    Private boatTargetX As Integer
    Private boatMoveSpeed As Integer = 10

    ' Pre-loaded image arrays for smooth animation
    Private rFrames(8) As Image ' Priest Right (JR)
    Private lFrames(8) As Image ' Priest Left (JL)
    Private rDFrames(8) As Image ' Devil Right (DR)
    Private lDFrames(8) As Image ' Devil Left (DL)

    Private Sub LoadAllFrames()
        For i As Integer = 1 To 8
            ' Load Priests
            rFrames(i) = LoadAsset("rJ" & i & ".png")
            If rFrames(i) Is Nothing Then rFrames(i) = LoadAsset("JR" & i & ".png")

            lFrames(i) = LoadAsset("lj" & i & ".png")
            If lFrames(i) Is Nothing Then lFrames(i) = LoadAsset("JL" & i & ".png")
            If lFrames(i) Is Nothing Then lFrames(i) = rFrames(i)

            ' Load Devils
            rDFrames(i) = LoadAsset("rD" & i & ".png")
            If rDFrames(i) Is Nothing Then rDFrames(i) = LoadAsset("DR" & i & ".png")

            lDFrames(i) = LoadAsset("lD" & i & ".png")
            If lDFrames(i) Is Nothing Then lDFrames(i) = LoadAsset("DL" & i & ".png")
            If lDFrames(i) Is Nothing Then lDFrames(i) = rDFrames(i)
        Next
    End Sub

    Private Function LoadAsset(filename As String) As Image
        Dim directPath As String = IO.Path.Combine(Application.StartupPath, filename)
        If IO.File.Exists(directPath) Then Return Image.FromFile(directPath)

        Dim folderPath As String = IO.Path.Combine(Application.StartupPath, "Animation Assets", filename)
        If IO.File.Exists(folderPath) Then Return Image.FromFile(folderPath)

        Dim parentPath As String = IO.Path.Combine(Application.StartupPath, "..", "..", "..", "Animation Assets", filename)
        If IO.File.Exists(parentPath) Then Return Image.FromFile(parentPath)

        Return Nothing
    End Function

    ' Helper to instantly set a character to their correct standing frame based on their shore
    Private Sub SetIdleFrame(pb As PictureBox)
        Dim isLeft As Boolean = (pb.Tag.ToString() = "Left" OrElse (pb.Tag.ToString().StartsWith("Boat") AndAlso boatLocation = "Left"))

        If pb.Name.StartsWith("Devil") Then
            pb.Image = If(isLeft, lDFrames(1), rDFrames(1))
        Else
            pb.Image = If(isLeft, lFrames(1), rFrames(1))
        End If
    End Sub

    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        gameTimer.Interval = 16

        countdownTimer.Interval = 1000
        countdownTimer.Start()

        Boat.Location = New Point(boatRightX, boatY)

        rightShorePositions(Priest1) = New Point(739, 255)
        rightShorePositions(Priest2) = New Point(791, 255)
        rightShorePositions(Priest3) = New Point(843, 255)
        rightShorePositions(Devil1) = New Point(897, 255)
        rightShorePositions(Devil2) = New Point(949, 255)
        rightShorePositions(Devil3) = New Point(1006, 255)

        leftShorePositions(Priest1) = New Point(266, 264)
        leftShorePositions(Priest2) = New Point(214, 264)
        leftShorePositions(Priest3) = New Point(162, 264)
        leftShorePositions(Devil1) = New Point(110, 264)
        leftShorePositions(Devil2) = New Point(58, 264)
        leftShorePositions(Devil3) = New Point(6, 264)

        ' Load all frames into memory immediately on startup
        LoadAllFrames()

        Dim allCharacters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}
        For Each character In allCharacters
            character.Tag = "Right"
            character.Location = rightShorePositions(character)
            SetIdleFrame(character) ' Sets to JR1 / DR1
        Next
    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        timeLeft -= 1
        Label1.Text = "Time Left: " & timeLeft

        If timeLeft <= 0 Then
            countdownTimer.Stop()
            MessageBox.Show("Time's Up! You failed to cross in time.", "Game Over")
            ResetLevel()
        End If
    End Sub



    Private Sub Character_Click(sender As Object, e As EventArgs) Handles Priest1.Click, Priest2.Click, Priest3.Click, Devil1.Click, Devil2.Click, Devil3.Click
        If movingChar IsNot Nothing OrElse isBoatMoving Then Exit Sub

        Dim clickedSprite = CType(sender, PictureBox)
        Dim currentState = clickedSprite.Tag.ToString

        If currentState = "Right" AndAlso boatLocation = "Right" Then
            BoardBoat(clickedSprite)
        ElseIf currentState = "Left" AndAlso boatLocation = "Left" Then
            BoardBoat(clickedSprite)
        ElseIf currentState.StartsWith("Boat") Then
            DisembarkBoat(clickedSprite)
        End If
    End Sub

    Private Sub BoardBoat(p As PictureBox)
        If slot1 Is Nothing Then
            slot1 = p
            p.Tag = "Boat1"
            charTarget = New Point(Boat.Left + 10, 271)
        ElseIf slot2 Is Nothing Then
            slot2 = p
            p.Tag = "Boat2"
            charTarget = New Point(Boat.Left + 60, 271)
        Else
            Exit Sub
        End If

        StartJumpAnimation(p)
    End Sub

    Private Sub DisembarkBoat(p As PictureBox)
        If p.Tag.ToString() = "Boat1" Then slot1 = Nothing
        If p.Tag.ToString() = "Boat2" Then slot2 = Nothing

        If boatLocation = "Right" Then
            p.Tag = "Right"
            charTarget = rightShorePositions(p)
        Else
            p.Tag = "Left"
            charTarget = leftShorePositions(p)
        End If

        StartJumpAnimation(p)
    End Sub

    Private Sub StartJumpAnimation(p As PictureBox)
        movingChar = p
        p.BringToFront()
        charStart = p.Location
        jumpProgress = 0.0
        gameTimer.Start()
    End Sub

    Private Sub btnMoveBoat_Click(sender As Object, e As EventArgs) Handles btnMoveBoat.Click
        If movingChar IsNot Nothing OrElse isBoatMoving Then Exit Sub

        If slot1 Is Nothing AndAlso slot2 Is Nothing Then Exit Sub

        isBoatMoving = True

        If boatLocation = "Right" Then
            boatTargetX = boatLeftX
            boatLocation = "Left"
        Else
            boatTargetX = boatRightX
            boatLocation = "Right"
        End If

        gameTimer.Start()
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If movingChar IsNot Nothing Then
            jumpProgress += jumpSpeed
            Dim isFacingRight As Boolean = (charStart.X < charTarget.X)

            If jumpProgress >= 1.0 Then
                jumpProgress = 1.0
                movingChar.Location = charTarget

                ' Back to standing image based on shore when the jump ends
                SetIdleFrame(movingChar)
                movingChar = Nothing

                If Not isBoatMoving Then
                    gameTimer.Stop()
                    CheckGameRules()
                End If
            Else
                Dim currentX As Integer = CInt(charStart.X + (charTarget.X - charStart.X) * jumpProgress)
                Dim currentY As Integer = CInt(charStart.Y + (charTarget.Y - charStart.Y) * jumpProgress)

                Dim arcY As Integer = CInt(-verticalBounceHeight * Math.Sin(jumpProgress * Math.PI))
                movingChar.Location = New Point(currentX, currentY + arcY)

                ' Fixed Timing: Matches the physical arc curve perfectly
                Dim frameIndex As Integer = 1
                If jumpProgress < 0.15 Then
                    frameIndex = 3 ' Crouch/Takeoff
                ElseIf jumpProgress >= 0.15 AndAlso jumpProgress < 0.3 Then
                    frameIndex = 4 ' Launching up
                ElseIf jumpProgress >= 0.3 AndAlso jumpProgress < 0.8 Then
                    frameIndex = 5 ' Flying Mid-Air
                Else
                    frameIndex = 6 ' Landing
                End If

                If movingChar.Name.StartsWith("Devil") Then
                    movingChar.Image = If(isFacingRight, rDFrames(frameIndex), lDFrames(frameIndex))
                Else
                    movingChar.Image = If(isFacingRight, rFrames(frameIndex), lFrames(frameIndex))
                End If
            End If

        ElseIf isBoatMoving Then
            Dim diff As Integer = boatTargetX - Boat.Left
            Dim stepX As Integer = If(Math.Abs(diff) < boatMoveSpeed, diff, Math.Sign(diff) * boatMoveSpeed)

            Boat.Left += stepX
            If slot1 IsNot Nothing Then slot1.Left += stepX
            If slot2 IsNot Nothing Then slot2.Left += stepX

            If Boat.Left = boatTargetX Then
                isBoatMoving = False
                gameTimer.Stop()
                CheckGameRules()
            End If
        Else
            gameTimer.Stop()
        End If
    End Sub

    Private Sub CheckGameRules()
        Dim leftPriests = 0, leftDevils = 0, rightPriests = 0, rightDevils = 0
        Dim allCharacters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}

        For Each c In allCharacters
            Dim loc As String = c.Tag.ToString()
            If loc.StartsWith("Boat") Then loc = boatLocation

            If c.Name.StartsWith("Priest") Then
                If loc = "Left" Then leftPriests += 1 Else rightPriests += 1
            ElseIf c.Name.StartsWith("Devil") Then
                If loc = "Left" Then leftDevils += 1 Else rightDevils += 1
            End If
        Next

        ' VICTORY
        If leftPriests = 3 AndAlso leftDevils = 3 Then
            countdownTimer.Stop()

            ' Set all characters to Victory Frame (7)
            For Each c In allCharacters
                Dim isLeft As Boolean = (c.Tag.ToString() = "Left" OrElse (c.Tag.ToString().StartsWith("Boat") AndAlso boatLocation = "Left"))
                If c.Name.StartsWith("Devil") Then
                    c.Image = If(isLeft, lDFrames(7), rDFrames(7))
                Else
                    c.Image = If(isLeft, lFrames(7), rFrames(7))
                End If
            Next

            MessageBox.Show("You Win! Everyone safely crossed the river.", "Victory")
            ResetLevel()
            Exit Sub
        End If

        ' DEFEAT
        If (leftPriests > 0 AndAlso leftDevils > leftPriests) OrElse
           (rightPriests > 0 AndAlso rightDevils > rightPriests) Then
            countdownTimer.Stop()

            ' Set ALL characters to Down/Defeat Frame (8) based on their direction
            For Each c In allCharacters
                Dim isLeft As Boolean = (c.Tag.ToString() = "Left" OrElse (c.Tag.ToString().StartsWith("Boat") AndAlso boatLocation = "Left"))
                If c.Name.StartsWith("Devil") Then
                    c.Image = If(isLeft, lDFrames(8), rDFrames(8))
                Else
                    c.Image = If(isLeft, lFrames(8), rFrames(8))
                End If
            Next

            MessageBox.Show("Game Over! The Devils outnumbered the Priests.", "Defeat")
            ResetLevel()
        End If
    End Sub

    Private Sub ResetLevel()
        gameTimer.Stop()
        movingChar = Nothing
        isBoatMoving = False

        slot1 = Nothing
        slot2 = Nothing
        boatLocation = "Right"
        Boat.Location = New Point(boatRightX, boatY)

        Dim allCharacters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}
        For Each c In allCharacters
            c.Tag = "Right"
            c.Location = rightShorePositions(c)
            SetIdleFrame(c) ' Resets everyone to frame 1 facing left toward the river
        Next

        timeLeft = 60
        Label1.Text = "Time Left: 60"
        countdownTimer.Start()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        countdownTimer.Stop()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub
End Class