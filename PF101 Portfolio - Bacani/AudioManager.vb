Imports System.IO
Imports System.Media

Module AudioManager

    Private hoverPlayer As SoundPlayer
    Private clickPlayer As SoundPlayer

    Public Sub InitializeAudio()
        Try
            Dim hoverPath As String = Path.Combine(Application.StartupPath, "Sounds", "hover1.wav")
            Dim clickPath As String = Path.Combine(Application.StartupPath, "Sounds", "click.wav")

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
        If hoverPlayer IsNot Nothing Then
            hoverPlayer.Play()
        End If
    End Sub

    Public Sub PlayClick()
        If clickPlayer IsNot Nothing Then
            clickPlayer.Play()
        End If
    End Sub

    Public Sub AttachSounds(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Button OrElse TypeOf ctrl Is PictureBox Then
                AddHandler ctrl.MouseEnter, AddressOf Control_MouseEnter
                AddHandler ctrl.Click, AddressOf Control_Click
            End If

            If ctrl.HasChildren Then
                AttachSounds(ctrl)
            End If
        Next
    End Sub

    Private Sub Control_MouseEnter(sender As Object, e As EventArgs)
        PlayHover()
    End Sub

    Private Sub Control_Click(sender As Object, e As EventArgs)
        PlayClick()
    End Sub

End Module