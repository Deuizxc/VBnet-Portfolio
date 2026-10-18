Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Media

Public Class Level1

    ' The two boat seats (absolute positions while the boat is at boatStart)
    Private ReadOnly slots() As Point = {New Point(586, 300), New Point(514, 299)}
    Private ReadOnly slotTaken(1) As Boolean

    ' Seat positions relative to the boat, so seats follow the boat when it moves
    Private ReadOnly seatOffset(1) As Size

    ' Boat positions
    Private ReadOnly boatStart As New Point(523, 360)
    Private ReadOnly boatEnd As New Point(362, 360)
    Private boatAtStart As Boolean = True
    Private boatMoving As Boolean = False

    ' Which seat each boarded character is sitting in
    Private ReadOnly seatOf As New Dictionary(Of PictureBox, Integer)

    ' Home spots on the START bank (saved on load) and the FAR bank
    Private ReadOnly originalPos As New Dictionary(Of PictureBox, Point)
    Private ReadOnly farPos As New Dictionary(Of PictureBox, Point)

    ' True = character is on the start bank, False = on the far bank
    Private ReadOnly charAtStart As New Dictionary(Of PictureBox, Boolean)

    Private gameOver As Boolean = False
    Private moveCount As Integer = 0
    Private hoveredChar As PictureBox = Nothing

    ' Countdown
    Private Const StartTime As Integer = 60
    Private timeLeft As Integer = StartTime
    Private WithEvents gameTimer As New System.Windows.Forms.Timer With {.Interval = 1000}

    ' Characters currently animating (ignore clicks until they finish)
    Private ReadOnly busy As New HashSet(Of PictureBox)

    ' Caches so files aren't reloaded every time
    Private ReadOnly spriteCache As New Dictionary(Of String, Image)
    Private ReadOnly sfxCache As New Dictionary(Of String, SoundPlayer)

    ' Paint order: first = bottom, last = top.
    Private ReadOnly drawOrder As New List(Of PictureBox)

    ' Only these can be clicked
    Private ReadOnly characters As New HashSet(Of PictureBox)

    Private ReadOnly rng As New Random()

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.UserPaint Or
                 ControlStyles.OptimizedDoubleBuffer, True)
        UpdateStyles()
        Me.KeyPreview = True
    End Sub

    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Boat.Location = boatStart
        drawOrder.Add(Boat)

        For i As Integer = 0 To 1
            seatOffset(i) = New Size(slots(i).X - boatStart.X, slots(i).Y - boatStart.Y)
        Next

        ' Far bank spots
        farPos(Priest1) = New Point(9, 290)
        farPos(Priest2) = New Point(103, 277)
        farPos(Priest3) = New Point(195, 292)
        farPos(Devil1) = New Point(-10, 338)
        farPos(Devil2) = New Point(91, 337)
        farPos(Devil3) = New Point(170, 346)

        For Each pb As PictureBox In {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}
            originalPos(pb) = pb.Location
            charAtStart(pb) = True
            characters.Add(pb)
            drawOrder.Add(pb)
            SetSprite(pb, "idle_left")
        Next

        SortSpritesByDepth()

        ' Hide the real controls; the form paints them now
        For Each pb As PictureBox In drawOrder
            pb.Visible = False
        Next

        UpdateHud()

        win.Visible = False
        lose.Visible = False

        gameTimer.Start()
    End Sub

    Private Sub UpdateHud()
        If timeLeft <= 10 Then
            Label1.ForeColor = Color.Crimson
        Else
            Label1.ForeColor = Color.White ' Or your default label color
        End If
        Label1.Text = $"Time Left: {timeLeft}s | Crossings: {moveCount}"
    End Sub

    Private Function SeatPos(seat As Integer) As Point
        Return Boat.Location + seatOffset(seat)
    End Function

    ' ---------- KEYBOARD SHORTCUT ----------
    Private Sub Level1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space AndAlso btnMoveBoat.Enabled Then
            e.SuppressKeyPress = True
            btnMoveBoat.PerformClick()
        End If
    End Sub

    ' ---------- TIMER ----------
    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If gameOver Then Return

        timeLeft -= 1
        UpdateHud()

        If timeLeft <= 0 Then
            timeLeft = 0
            UpdateHud()
            EndGame(False, "Time's up!")
        End If
    End Sub

    ' ---------- PAINTING ----------
    Private Function GetZoomRect(pb As PictureBox) As RectangleF
        If pb.Image Is Nothing Then Return RectangleF.Empty

        If pb.SizeMode = PictureBoxSizeMode.StretchImage Then
            Return New RectangleF(pb.Left, pb.Top, pb.Width, pb.Height)
        End If

        Dim scale As Single = Math.Min(pb.Width / CSng(pb.Image.Width),
                                       pb.Height / CSng(pb.Image.Height))
        Dim w As Single = pb.Image.Width * scale
        Dim h As Single = pb.Image.Height * scale

        Return New RectangleF(pb.Left + (pb.Width - w) / 2.0F,
                              pb.Top + (pb.Height - h) / 2.0F,
                              w, h)
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.InterpolationMode = InterpolationMode.NearestNeighbor
        g.PixelOffsetMode = PixelOffsetMode.Half
        g.CompositingMode = CompositingMode.SourceOver
        g.SmoothingMode = SmoothingMode.AntiAlias

        Using shadowBrush As New SolidBrush(Color.FromArgb(75, 0, 0, 0))
            For Each pb As PictureBox In drawOrder
                If pb.Image Is Nothing Then Continue For

                Dim rect As RectangleF = GetZoomRect(pb)

                ' Subtle ground shadow under characters
                If characters.Contains(pb) AndAlso Not busy.Contains(pb) Then
                    Dim shadowW As Single = rect.Width * 0.65F
                    Dim shadowH As Single = 10.0F
                    Dim shadowX As Single = rect.Left + (rect.Width - shadowW) / 2.0F
                    Dim shadowY As Single = rect.Bottom - (shadowH / 2.0F)
                    g.FillEllipse(shadowBrush, shadowX, shadowY, shadowW, shadowH)
                End If

                ' Slight lift when hovering a clickable character
                If pb Is hoveredChar AndAlso CanClick(pb) Then
                    rect.Y -= 4.0F
                End If

                g.DrawImage(pb.Image, rect)
            Next
        End Using
    End Sub

    Private Sub BringSpriteToFront(pb As PictureBox)
        drawOrder.Remove(pb)
        drawOrder.Add(pb)
        Invalidate()
    End Sub

    Private Sub SortSpritesByDepth()
        Dim sortedChars = drawOrder.Where(Function(p) p IsNot Boat).OrderBy(Function(p) p.Bottom).ToList()
        drawOrder.Clear()
        drawOrder.Add(Boat)
        drawOrder.AddRange(sortedChars)
        Invalidate()
    End Sub

    ' ---------- MOUSE (pixel-perfect hit test) ----------
    Private Function HitTest(p As Point) As PictureBox
        For i As Integer = drawOrder.Count - 1 To 0 Step -1
            Dim pb As PictureBox = drawOrder(i)
            If Not characters.Contains(pb) Then Continue For

            Dim r As RectangleF = GetZoomRect(pb)
            If Not r.Contains(p) Then Continue For

            Dim bmp As Bitmap = TryCast(pb.Image, Bitmap)
            If bmp Is Nothing Then Return pb

            Dim x As Integer = Math.Min(bmp.Width - 1, Math.Max(0, CInt((p.X - r.X) * bmp.Width / r.Width)))
            Dim y As Integer = Math.Min(bmp.Height - 1, Math.Max(0, CInt((p.Y - r.Y) * bmp.Height / r.Height)))

            If bmp.GetPixel(x, y).A > 20 Then Return pb
        Next
        Return Nothing
    End Function

    Private Function CanClick(pb As PictureBox) As Boolean
        If gameOver OrElse boatMoving OrElse busy.Contains(pb) Then Return False
        If seatOf.ContainsKey(pb) Then Return True
        If charAtStart(pb) <> boatAtStart Then Return False
        Return Not (slotTaken(0) AndAlso slotTaken(1))
    End Function

    Private Sub Level1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim pb As PictureBox = HitTest(e.Location)
        Dim clickable As Boolean = (pb IsNot Nothing AndAlso CanClick(pb))
        Cursor = If(clickable, Cursors.Hand, Cursors.Default)

        Dim newHover As PictureBox = If(clickable, pb, Nothing)
        If hoveredChar IsNot newHover Then
            hoveredChar = newHover
            Invalidate()
        End If
    End Sub

    Private Async Sub Level1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Dim pb As PictureBox = HitTest(e.Location)
        If pb Is Nothing OrElse Not CanClick(pb) Then Return

        hoveredChar = Nothing
        If seatOf.ContainsKey(pb) Then
            Await LeaveBoat(pb)
        Else
            Await BoardBoat(pb)
        End If
    End Sub

    ' ---------- BOAT ----------
    Private Async Sub btnMoveBoat_Click(sender As Object, e As EventArgs) Handles btnMoveBoat.Click
        If gameOver OrElse boatMoving OrElse busy.Count > 0 Then Return
        If seatOf.Count = 0 Then Return

        PlaySfx("click.wav")

        moveCount += 1
        UpdateHud()

        boatMoving = True
        btnMoveBoat.Enabled = False

        Dim target As Point = If(boatAtStart, boatEnd, boatStart)
        Await MoveBoatTo(target)
        boatAtStart = Not boatAtStart

        btnMoveBoat.Enabled = True
        boatMoving = False

        CheckGameState()
    End Sub

    Private Async Function MoveBoatTo(target As Point) As Task
        Const duration As Integer = 1500 ' ms

        Dim boatFrom As Point = Boat.Location
        Dim riders As New List(Of PictureBox)(seatOf.Keys)
        Dim riderFrom As New Dictionary(Of PictureBox, Point)
        For Each r As PictureBox In riders
            riderFrom(r) = r.Location
        Next

        Dim dx As Integer = target.X - boatFrom.X
        Dim dy As Integer = target.Y - boatFrom.Y
        Dim sw As Stopwatch = Stopwatch.StartNew()

        Do While sw.ElapsedMilliseconds < duration
            If Not Visible Then Return ' Abort if user exited to menu

            Dim t As Double = sw.ElapsedMilliseconds / duration
            Dim eased As Double = t * t * (3 - 2 * t)
            ' Subtle wave bobbing while sailing
            Dim bob As Integer = CInt(Math.Sin(t * Math.PI * 6) * 2)

            Dim ox As Integer = CInt(dx * eased)
            Dim oy As Integer = CInt(dy * eased) + bob

            Boat.Location = New Point(boatFrom.X + ox, boatFrom.Y + oy)
            For Each r As PictureBox In riders
                r.Location = New Point(riderFrom(r).X + ox, riderFrom(r).Y + oy)
            Next

            Invalidate()
            Await Task.Delay(10)
        Loop

        Boat.Location = target
        For Each r As PictureBox In riders
            r.Location = New Point(riderFrom(r).X + dx, riderFrom(r).Y + dy)
        Next
        Invalidate()
    End Function

    ' ---------- BOARDING ----------
    Private Async Function BoardBoat(pb As PictureBox) As Task
        Dim seat As Integer = -1
        If Not slotTaken(0) Then
            seat = 0
        ElseIf Not slotTaken(1) Then
            seat = 1
        End If
        If seat = -1 Then Return

        slotTaken(seat) = True
        seatOf(pb) = seat
        busy.Add(pb)
        BringSpriteToFront(pb)

        Dim dir As String = If(charAtStart(pb), "left", "right")

        SetSprite(pb, "dash_" & dir)
        PlaySfx("sfx_dash_" & rng.Next(1, 3) & ".wav")

        Await MoveTo(pb, SeatPos(seat), jumpHeight:=35)

        PlaySfx("sfx_land_" & rng.Next(1, 3) & ".wav")
        SetSprite(pb, "land_" & dir)

        ' Quick boat dip on landing
        Boat.Top += 3
        For Each r As PictureBox In seatOf.Keys
            r.Top += 3
        Next
        Invalidate()

        Await Task.Delay(200)

        Boat.Top -= 3
        For Each r As PictureBox In seatOf.Keys
            r.Top -= 3
        Next

        SetSprite(pb, If(seat = 1, "sit_right", "sit_left"))
        SortSpritesByDepth()
        busy.Remove(pb)
    End Function

    ' ---------- LEAVING ----------
    Private Async Function LeaveBoat(pb As PictureBox) As Task
        slotTaken(seatOf(pb)) = False
        seatOf.Remove(pb)
        busy.Add(pb)
        BringSpriteToFront(pb)

        charAtStart(pb) = boatAtStart
        Dim target As Point = If(boatAtStart, originalPos(pb), farPos(pb))

        Dim dir As String = If(boatAtStart, "right", "left")
        Dim idle As String = If(boatAtStart, "idle_left", "idle_right")

        SetSprite(pb, "dash_" & dir)
        PlaySfx("sfx_dash_" & rng.Next(1, 3) & ".wav")

        Await MoveTo(pb, target, jumpHeight:=35)

        PlaySfx("sfx_land_" & rng.Next(1, 3) & ".wav")
        SetSprite(pb, "land_" & dir)
        Await Task.Delay(200)
        SetSprite(pb, idle)

        SortSpritesByDepth()
        busy.Remove(pb)

        CheckGameState()
    End Function

    ' ---------- GAME LOGIC ----------
    Private Sub CheckGameState()
        If gameOver Then Return

        Dim priests(1) As Integer
        Dim devils(1) As Integer

        For Each pb As PictureBox In characters
            Dim onStart As Boolean = If(seatOf.ContainsKey(pb), boatAtStart, charAtStart(pb))
            Dim side As Integer = If(onStart, 0, 1)
            If pb.Name.StartsWith("Priest") Then
                priests(side) += 1
            Else
                devils(side) += 1
            End If
        Next

        Dim lost As Boolean = (priests(0) > 0 AndAlso devils(0) > priests(0)) OrElse
                              (priests(1) > 0 AndAlso devils(1) > priests(1))
        Dim won As Boolean = (priests(1) = 3 AndAlso devils(1) = 3 AndAlso seatOf.Count = 0)

        If won Then
            EndGame(True, $"Cleared in {moveCount} crossings!")
        ElseIf lost Then
            EndGame(False, "The devils outnumbered the priests!")
        End If
    End Sub

    Private Async Sub EndGame(won As Boolean, message As String)
        If gameOver Then Return
        gameOver = True
        gameTimer.Stop()

        Label1.Text = message

        Do While busy.Count > 0 OrElse boatMoving
            Await Task.Delay(50)
        Loop

        If won Then
            win.Location = New Point((Me.ClientSize.Width - win.Width) \ 2, (Me.ClientSize.Height - win.Height) \ 2)
            win.BringToFront()
            win.Visible = True
        Else
            lose.Location = New Point((Me.ClientSize.Width - lose.Width) \ 2, (Me.ClientSize.Height - lose.Height) \ 2)
            lose.BringToFront()
            lose.Visible = True
        End If
    End Sub

    Public Sub ResetLevel()
        seatOf.Clear()
        busy.Clear()
        slotTaken(0) = False
        slotTaken(1) = False
        boatAtStart = True
        boatMoving = False
        Boat.Location = boatStart

        For Each pb As PictureBox In characters
            pb.Location = originalPos(pb)
            charAtStart(pb) = True
            SetSprite(pb, "idle_left")
        Next

        SortSpritesByDepth()
        btnMoveBoat.Enabled = True

        win.Visible = False
        lose.Visible = False

        timeLeft = StartTime
        moveCount = 0
        UpdateHud()
        gameTimer.Start()

        gameOver = False
        Invalidate()
    End Sub

    ' ---------- ANIMATION ----------
    Private Async Function MoveTo(pb As PictureBox, target As Point, Optional jumpHeight As Integer = 0) As Task
        Const duration As Integer = 400 ' ms
        Dim start As Point = pb.Location
        Dim sw As Stopwatch = Stopwatch.StartNew()

        Do While sw.ElapsedMilliseconds < duration
            If Not Visible Then Return

            Dim t As Double = sw.ElapsedMilliseconds / duration
            Dim eased As Double = 1 - (1 - t) * (1 - t)
            Dim arc As Double = Math.Sin(t * Math.PI) * jumpHeight

            pb.Location = New Point(
                CInt(start.X + (target.X - start.X) * eased),
                CInt(start.Y + (target.Y - start.Y) * eased - arc))
            Invalidate()
            Await Task.Delay(10)
        Loop

        pb.Location = target
        Invalidate()
    End Function

    ' ---------- SPRITES ----------
    Private Sub SetSprite(pb As PictureBox, state As String)
        Dim prefix As String = If(pb.Name.StartsWith("Priest"), "joker", "devil")
        Dim fileName As String = prefix & "_" & state & ".png"
        Dim fullPath As String = Path.Combine(Application.StartupPath, "Assets", fileName)

        Try
            If Not spriteCache.ContainsKey(fullPath) Then
                Using fs As New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                    Using temp As New Bitmap(fs)
                        spriteCache(fullPath) = New Bitmap(temp)
                    End Using
                End Using
            End If
            pb.Image = spriteCache(fullPath)
            Invalidate()
        Catch ex As Exception
            Debug.WriteLine("Sprite failed to load: " & fullPath & " - " & ex.Message)
        End Try
    End Sub

    ' ---------- SOUND ----------
    Private Sub PlaySfx(fileName As String)
        Try
            Dim fullPath As String = Path.Combine(Application.StartupPath, "Sounds", fileName)
            If Not sfxCache.ContainsKey(fullPath) Then
                Dim player As New SoundPlayer(fullPath)
                player.LoadAsync()
                sfxCache(fullPath) = player
            End If
            sfxCache(fullPath).Play()
        Catch ex As Exception
        End Try
    End Sub

    ' ---------- MENU & BUTTONS ----------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gameTimer.Stop()
        Menu.Show()
        Hide()
    End Sub

    Private Sub Level1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible AndAlso characters.Count > 0 Then ResetLevel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lose.Visible = False
        ResetLevel()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        win.Visible = False
        ResetLevel()
    End Sub
End Class