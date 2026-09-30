Public Class Level1

    ' --- TIMERS & CORE SETTINGS ---
    Private WithEvents gameTimer As New Timer()
    Private WithEvents countdownTimer As New Timer()
    Private timeLeft As Integer = 60

    Private verticalBounceHeight As Integer = 120

    ' --- GAME STATE TRACKING ---
    Private boatLocation As String = "Right"
    Private slot1 As PictureBox = Nothing
    Private slot2 As PictureBox = Nothing

    ' Hardcoded Boat Coordinates
    Private boatRightX As Integer = 472
    Private boatLeftX As Integer = 282
    Private boatY As Integer = 483

    Private rightShorePositions As New Dictionary(Of PictureBox, Point)
    Private leftShorePositions As New Dictionary(Of PictureBox, Point)

    ' --- ANIMATION VARIABLES ---
    Private movingChar As PictureBox = Nothing
    Private charStart As Point
    Private charTarget As Point
    Private jumpProgress As Double = 0.0
    Private jumpSpeed As Double = 0.04

    Private isBoatMoving As Boolean = False
    Private boatTargetX As Integer
    Private boatMoveSpeed As Integer = 10

    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        gameTimer.Interval = 16

        countdownTimer.Interval = 1000
        countdownTimer.Start()

        ' Snap boat directly to the starting hardcoded location
        Boat.Location = New Point(boatRightX, boatY)

        ' Hardcoded Base (Right) Shore Locations
        rightShorePositions(Priest1) = New Point(607, 429)
        rightShorePositions(Priest2) = New Point(653, 429)
        rightShorePositions(Priest3) = New Point(699, 429)
        rightShorePositions(Devil1) = New Point(745, 429)
        rightShorePositions(Devil2) = New Point(791, 429)
        rightShorePositions(Devil3) = New Point(837, 429)

        ' Hardcoded Destination (Left) Shore Locations
        leftShorePositions(Priest1) = New Point(236, 429)
        leftShorePositions(Priest2) = New Point(190, 429)
        leftShorePositions(Priest3) = New Point(144, 429)
        leftShorePositions(Devil1) = New Point(98, 429)
        leftShorePositions(Devil2) = New Point(52, 429)
        leftShorePositions(Devil3) = New Point(6, 429)

        Dim allCharacters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}
        For Each character In allCharacters
            character.Tag = "Right"
            character.Location = rightShorePositions(character) ' Snap to base immediately
        Next
    End Sub

    ' --- 60 SECOND COUNTDOWN ---
    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        timeLeft -= 1
        Label1.Text = "Time Left: " & timeLeft

        If timeLeft <= 0 Then
            countdownTimer.Stop()
            MessageBox.Show("Time's Up! You failed to cross in time.", "Game Over")
            ResetLevel()
        End If
    End Sub

    ' --- RETURN / MENU BUTTON ---
    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        countdownTimer.Stop()
        Me.Hide()
        ' Home.Show() 
    End Sub

    ' --- CHARACTER CLICK LOGIC ---
    Private Sub Character_Click(sender As Object, e As EventArgs) Handles Priest1.Click, Priest2.Click, Priest3.Click, Devil1.Click, Devil2.Click, Devil3.Click
        ' Prevent moving characters while animation or boat is active
        If movingChar IsNot Nothing OrElse isBoatMoving Then Exit Sub

        Dim clickedSprite As PictureBox = CType(sender, PictureBox)
        Dim currentState As String = clickedSprite.Tag.ToString()

        ' Character must be on the same shore as the boat to board
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
            charTarget = New Point(Boat.Left + 10, Boat.Top - 40)
        ElseIf slot2 Is Nothing Then
            slot2 = p
            p.Tag = "Boat2"
            charTarget = New Point(Boat.Left + 60, Boat.Top - 40)
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
        charStart = p.Location
        jumpProgress = 0.0
        gameTimer.Start()
    End Sub

    ' --- GO BUTTON LOGIC ---
    Private Sub btnMoveBoat_Click(sender As Object, e As EventArgs) Handles btnMoveBoat.Click
        If movingChar IsNot Nothing OrElse isBoatMoving Then Exit Sub

        ' Core Rule: Boat cannot move empty
        If slot1 Is Nothing AndAlso slot2 Is Nothing Then Exit Sub

        isBoatMoving = True

        ' Set the destination using the new exact coordinates
        If boatLocation = "Right" Then
            boatTargetX = boatLeftX
            boatLocation = "Left"
        Else
            boatTargetX = boatRightX
            boatLocation = "Right"
        End If

        gameTimer.Start()
    End Sub

    ' --- THE MAIN ANIMATION LOOP (Jump Arcs & Boat Movement) ---
    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        ' 1. Parabolic Jump Arc Logic
        If movingChar IsNot Nothing Then
            jumpProgress += jumpSpeed

            If jumpProgress >= 1.0 Then
                jumpProgress = 1.0
                movingChar.Location = charTarget
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
            End If

            ' 2. Boat Sailing Logic
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

    ' --- GAME LOGIC & RULES ---
    Private Sub CheckGameRules()
        Dim leftPriests = 0, leftDevils = 0, rightPriests = 0, rightDevils = 0
        Dim allCharacters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}

        For Each c In allCharacters
            Dim loc As String = c.Tag.ToString()
            ' Characters in the boat count towards the shore the boat is currently at
            If loc.StartsWith("Boat") Then loc = boatLocation

            If c.Name.StartsWith("Priest") Then
                If loc = "Left" Then leftPriests += 1 Else rightPriests += 1
            ElseIf c.Name.StartsWith("Devil") Then
                If loc = "Left" Then leftDevils += 1 Else rightDevils += 1
            End If
        Next

        ' Core Rule 1: Win Condition
        If leftPriests = 3 AndAlso leftDevils = 3 Then
            countdownTimer.Stop()
            MessageBox.Show("You Win! Everyone safely crossed the river.", "Victory")
            ResetLevel()
            Exit Sub
        End If

        ' Core Rule 2: Lose Condition (Devils outnumber Priests on ANY shore, provided Priests > 0)
        If (leftPriests > 0 AndAlso leftDevils > leftPriests) OrElse
           (rightPriests > 0 AndAlso rightDevils > rightPriests) Then
            countdownTimer.Stop()
            MessageBox.Show("Game Over! The Devils outnumbered the Priests.", "Defeat")
            ResetLevel()
        End If
    End Sub

    ' --- RESET FUNCTION ---
    Private Sub ResetLevel()
        ' Force stop all current animations
        gameTimer.Stop()
        movingChar = Nothing
        isBoatMoving = False

        ' Empty and snap boat back to original start position using exact coordinates
        slot1 = Nothing
        slot2 = Nothing
        boatLocation = "Right"
        Boat.Location = New Point(boatRightX, boatY)

        ' Snap all characters directly to their hardcoded base coordinates
        Dim allCharacters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}
        For Each c In allCharacters
            c.Tag = "Right"
            c.Location = rightShorePositions(c)
        Next

        ' Restart Countdown
        timeLeft = 60
        Label1.Text = "Time Left: 60"
        countdownTimer.Start()
    End Sub

End Class