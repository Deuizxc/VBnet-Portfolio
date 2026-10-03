Public Class W4_Layout
    Private originalLocation As Point
    Private originalSize As Size
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week4Selector.Show()
        Week4Selector.Update()
        Me.Hide()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W4_Form.Show()
    End Sub

    Private Sub btnToggleLayout_Click(sender As Object, e As EventArgs) Handles btnToggleLayout.Click
        If testbox.Dock = DockStyle.None AndAlso testbox.Anchor = (AnchorStyles.Top Or AnchorStyles.Left) Then
            testbox.Dock = DockStyle.Bottom
            lblLayoutStatus.Text = "Mode: Docked"

        ElseIf testbox.Dock = DockStyle.Bottom Then
            testbox.Dock = DockStyle.None
            testbox.Size = New Size(80, 30)
            testbox.Location = New Point(testbox.Parent.ClientSize.Width - testbox.Width - 15, 15)
            testbox.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lblLayoutStatus.Text = "Mode: Anchored"

        Else
            testbox.Dock = DockStyle.None
            testbox.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            testbox.Size = originalSize
            testbox.Location = originalLocation
            lblLayoutStatus.Text = "Mode: Default"
        End If
    End Sub

    Private Sub W4_Layout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        originalLocation = testbox.Location
        originalSize = testbox.Size
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
    Private Sub btnToggleLayout_MouseEnter(sender As Object, e As EventArgs) Handles btnToggleLayout.MouseEnter
        btnToggleLayout.Top -= 3
        btnToggleLayout.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnToggleLayout.MouseLeave
        btnToggleLayout.Top += 3
        btnToggleLayout.Cursor = Cursors.Default
    End Sub
    Private Sub lblLayoutStatus_Click(sender As Object, e As EventArgs) Handles lblLayoutStatus.Click

    End Sub
End Class