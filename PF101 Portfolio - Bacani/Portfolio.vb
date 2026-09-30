Imports System.Runtime.CompilerServices


Public Class Portfolio

    Private Sub CenterStatsPanel()
        Dim centerX As Integer = (Me.ClientSize.Width - pnlStatsPopup.Width) \ 2
        Dim centerY As Integer = (Me.ClientSize.Height - pnlStatsPopup.Height) \ 2
        pnlStatsPopup.Location = New Point(centerX, centerY)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Portfolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        pnlStatsPopup.Visible = False
        AudioManager.InitializeAudio()
        AudioManager.AttachSounds(Me)
    End Sub

    Private Sub Portfolio_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlStatsPopup IsNot Nothing AndAlso pnlStatsPopup.Visible Then
            CenterStatsPanel()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Lessons.Show()
        Lessons.Update()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Profile.Show()
        Profile.Update()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CenterStatsPanel()
        pnlStatsPopup.BringToFront()
        pnlStatsPopup.Visible = True
    End Sub

    Private Sub btnCloseStats_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnlStatsPopup.Visible = False
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
        Button1.Size = New Size(166, 76)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
        Button1.Size = New Size(156, 66)
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.Red
        Button2.Top -= 3
        Button2.Cursor = Cursors.Hand
        Button2.Size = New Size(167, 68)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
        Button2.Top += 3
        Button2.Cursor = Cursors.Default
        Button2.Size = New Size(158, 58)
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.Red
        Button3.Top -= 3
        Button3.Cursor = Cursors.Hand
        Button3.Size = New Size(141, 59)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
        Button3.Top += 3
        Button3.Cursor = Cursors.Default
        Button3.Size = New Size(131, 49)
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.Red
        Button4.Top -= 3
        Button4.Cursor = Cursors.Hand
        Button4.Size = New Size(149, 57)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
        Button4.Top += 3
        Button4.Cursor = Cursors.Default
        Button4.Size = New Size(139, 47)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnlStatsPopup.Visible = False
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show(":((", "PhAN-SiTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        MessageBox.Show("LET'S GOOOOOOO! ٩(ˊᗜˋ*)و" & vbCrLf, "PhAN-SiTE")


    End Sub

End Class