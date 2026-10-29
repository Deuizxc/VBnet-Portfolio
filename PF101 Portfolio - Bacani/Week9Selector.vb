Public Class Week9Selector
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Lessons.Show()
        Lessons.Update()
        Hide()
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.Left -= 2
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.Left += 2
        Button7.Cursor = Cursors.Default
    End Sub

    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles _
    Label3.MouseEnter, Label1.MouseEnter

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 3
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles _
    Label3.MouseLeave, Label1.MouseLeave

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.White
        lbl.Top += 3
        lbl.Cursor = Cursors.Default
    End Sub

    Private Sub Week9Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Panel1.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim mnu As New Menu()
        mnu.Show()
        mnu.Update()
        Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Center the panel horizontally and vertically
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2

        Panel1.Visible = True
        Panel1.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 2
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.White
        Button1.Top += 2
        Button1.Cursor = Cursors.Default
    End Sub
End Class