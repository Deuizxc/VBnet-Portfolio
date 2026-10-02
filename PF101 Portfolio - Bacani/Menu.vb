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

    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles _
    Label8.MouseEnter, Label1.MouseEnter, Label2.MouseEnter
        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 2
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles _
    Label8.MouseLeave, Label1.MouseLeave, Label2.MouseLeave
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
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        lvl1popup.Visible = True
        lvl1popup.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lvl1popup.Visible = False

        ' Destroys the hidden old level so a fresh one is built, restarting the timer automatically
        Level1.Dispose()

        Level1.Show()
        Level1.Update()
        Me.Hide()
    End Sub

End Class