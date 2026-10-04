Public Class Menu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week9Selector.Show()
        Week9Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub

    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter, lvl2start.MouseEnter, lvl3start.MouseEnter
        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 2
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave, lvl2start.MouseLeave, lvl3start.MouseLeave
        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.White
        lbl.Top += 2
        lbl.Cursor = Cursors.Default
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        lvl1popup.Parent = Me
        lvl1popup.Left = (Me.ClientSize.Width - lvl1popup.Width) \ 2
        lvl1popup.Top = (Me.ClientSize.Height - lvl1popup.Height) \ 2
        lvl1popup.Visible = False

        lvl2popup.Parent = Me
        lvl2popup.Left = (Me.ClientSize.Width - lvl2popup.Width) \ 2
        lvl2popup.Top = (Me.ClientSize.Height - lvl2popup.Height) \ 2
        lvl2popup.Visible = False

        ' --- ADDED: Initialize lvl3popup panel centering and visibility ---
        lvl3popup.Parent = Me
        lvl3popup.Left = (Me.ClientSize.Width - lvl3popup.Width) \ 2
        lvl3popup.Top = (Me.ClientSize.Height - lvl3popup.Height) \ 2
        lvl3popup.Visible = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        lvl1popup.Visible = True
        lvl1popup.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lvl1popup.Visible = False
        Level1.Dispose()
        Level1.Show()
        Level1.Update()
        Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lvl2start.Click
        lvl2popup.Visible = True
        lvl2popup.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lvl2popup.Visible = False
        Level2.Dispose()
        Level2.Show()
        Level2.Update()
        Hide()
    End Sub

    ' --- FIXED: Now centers and shows the lvl3popup panel instead of treating it like a Form ---
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lvl3start.Click
        lvl3popup.Location = New Point((Me.ClientSize.Width - lvl3popup.Width) \ 2, (Me.ClientSize.Height - lvl3popup.Height) \ 2)
        lvl3popup.Visible = True
        lvl3popup.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lvl3popup.Visible = False
        Level3.Dispose()
        Level3.Show()
        Level3.Update()
        Hide()
    End Sub

End Class