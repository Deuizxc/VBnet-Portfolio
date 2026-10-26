Public Class Week13Selector
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Lessons.Show()
        Lessons.Update()
        Me.Hide()
    End Sub

    ' Nudge home button
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.Left -= 2
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.Left += 2
        Button7.Cursor = Cursors.Default
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    ' --- MDI NAVIGATION & OVERLAP FIX ---

    Public Sub ToggleSelectorControls(showControls As Boolean)
        For Each ctrl As Control In Me.Controls
            If Not TypeOf ctrl Is MdiClient Then
                ctrl.Visible = showControls
            End If
        Next
    End Sub

    Public Sub OpenChildForm(childForm As Form)
        ' Remove handlers and close existing children first
        For Each child As Form In Me.MdiChildren
            RemoveHandler child.FormClosed, AddressOf ChildForm_Closed
            child.Close()
        Next

        ' Hide selector labels/buttons so they don't bleed through
        ToggleSelectorControls(False)

        ' Attach child to MDI Parent
        childForm.MdiParent = Me
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        AddHandler childForm.FormClosed, AddressOf ChildForm_Closed
        childForm.Show()
    End Sub

    Private Sub ChildForm_Closed(sender As Object, e As FormClosedEventArgs)
        ' Bring back the selector UI if no children are open
        If Me.MdiChildren.Length <= 1 Then
            ToggleSelectorControls(True)
        End If
    End Sub

    ' Open the respective Child Forms
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        OpenChildForm(New W13_Database())
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        OpenChildForm(New W13_Sql())
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        OpenChildForm(New W13_Memory())
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        OpenChildForm(New W13_Visual())
    End Sub

    ' --- HOVER EFFECTS ---
    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles _
    Label3.MouseEnter, Label7.MouseEnter, Label8.MouseEnter, Label9.MouseEnter

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 3
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles _
    Label3.MouseLeave, Label7.MouseLeave, Label8.MouseLeave, Label9.MouseLeave

        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.White
        lbl.Top += 3
        lbl.Cursor = Cursors.Default
    End Sub

    Private Sub Week13Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' Fix potential gray background on labels by matching the dark banner RGB
        Dim bannerBlack As Color = Color.FromArgb(24, 24, 24)
        Label3.BackColor = bannerBlack
        Label7.BackColor = bannerBlack
        Label8.BackColor = bannerBlack
        Label9.BackColor = bannerBlack
    End Sub
End Class