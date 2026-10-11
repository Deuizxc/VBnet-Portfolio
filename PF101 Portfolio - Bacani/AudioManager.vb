Imports System.IO
Imports System.Media

Module AudioManager

    ' Plays BGM and other layered sounds on separate audio channels so they don't block UI sounds
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private hoverPlayer As SoundPlayer
    Private clickPlayer As SoundPlayer
    Private currentBgmPath As String = ""

    ' Timestamp tracker to prevent rapid re-triggering (debounce)
    Private lastHoverTime As DateTime = DateTime.MinValue

    Public Sub InitializeAudio()
        Try
            ' RESTORED YOUR EXACT ORIGINAL PATHS FOR UI SOUNDS
            Dim hoverPath As String = Path.Combine(Application.StartupPath, "Sounds", "hover1.wav")
            Dim clickPath As String = Path.Combine(Application.StartupPath, "Sounds", "click.wav")

            ' BGM path
            currentBgmPath = Path.Combine(Application.StartupPath, "Resources", "TakeOver.wav")

            If File.Exists(hoverPath) Then
                hoverPlayer = New SoundPlayer(hoverPath)
                hoverPlayer.LoadAsync()
            End If

            If File.Exists(clickPath) Then
                clickPlayer = New SoundPlayer(clickPath)
                clickPlayer.LoadAsync()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub PlayHover()
        ' Ignore triggers if less than 180ms have elapsed since the last sound
        If (DateTime.Now - lastHoverTime).TotalMilliseconds < 180 Then
            Exit Sub
        End If

        lastHoverTime = DateTime.Now

        If hoverPlayer IsNot Nothing Then
            hoverPlayer.Play()
        End If
    End Sub

    Public Sub PlayClick()
        If clickPlayer IsNot Nothing Then
            clickPlayer.Play()
        End If
    End Sub

    ' --- UPGRADED: BULLETPROOF GUNSHOT METHOD ---
    Public Sub PlayGunshot()
        Try
            ' Look for the gunshot file directly so it works independently
            Dim gunshotPath As String = Path.Combine(Application.StartupPath, "Resources", "gunshot.wav")

            If File.Exists(gunshotPath) Then
                ' Route the gunshot to its own dedicated audio channel (alias "gun")
                ' This ensures it NEVER gets muted by hover sounds or clicks!
                mciSendString("close gun", Nothing, 0, 0)
                mciSendString($"open ""{gunshotPath}"" type waveaudio alias gun", Nothing, 0, 0)
                mciSendString("play gun", Nothing, 0, 0)
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' --- BACKGROUND MUSIC API ---
    Public Sub PlayBGM()
        If File.Exists(currentBgmPath) Then
            mciSendString("close bgm", Nothing, 0, 0)
            mciSendString($"open ""{currentBgmPath}"" type waveaudio alias bgm", Nothing, 0, 0)
            mciSendString("play bgm repeat", Nothing, 0, 0)
        End If
    End Sub

    Public Sub StopBGM()
        mciSendString("stop bgm", Nothing, 0, 0)
        mciSendString("close bgm", Nothing, 0, 0)
    End Sub

    Public Sub AttachSounds(parent As Control)
        For Each ctrl As Control In parent.Controls
            ' Target Buttons, PictureBoxes, and Labels
            If TypeOf ctrl Is Button OrElse TypeOf ctrl Is PictureBox OrElse TypeOf ctrl Is Label Then
                ' Strip existing handlers first to avoid stacking duplicate calls
                RemoveHandler ctrl.MouseEnter, AddressOf Control_MouseEnter
                RemoveHandler ctrl.Click, AddressOf Control_Click

                AddHandler ctrl.MouseEnter, AddressOf Control_MouseEnter
                AddHandler ctrl.Click, AddressOf Control_Click
            End If

            If ctrl.HasChildren Then
                AttachSounds(ctrl)
            End If
        Next
    End Sub

    Public Sub ApplyIcon(frm As Form)
        Try
            ' Ensure your file is named exactly "favicon.ico" and placed in your Resources folder
            Dim iconPath As String = Path.Combine(Application.StartupPath, "Resources", "favicon.ico")

            If File.Exists(iconPath) Then
                frm.Icon = New Icon(iconPath)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Control_MouseEnter(sender As Object, e As EventArgs)
        PlayHover()
    End Sub

    Private Sub Control_Click(sender As Object, e As EventArgs)
        PlayClick()
    End Sub

End Module