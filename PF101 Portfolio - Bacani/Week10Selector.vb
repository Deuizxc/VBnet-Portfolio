Public Class Week10Selector
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

    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub

    ' --- MDI NAVIGATION & OVERLAP FIX ---

    ' Toggles the selector controls so they don't overlap MDI child forms
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
        ' If no more child forms are open, bring back the selector UI
        If Me.MdiChildren.Length <= 1 Then
            ToggleSelectorControls(True)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        OpenChildForm(New W10_Classes())
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        OpenChildForm(New W10_Errors())
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        OpenChildForm(New W10_Handling())
    End Sub

    ' --- HOVER EFFECTS ---

    Private Sub Labels_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter, Label6.MouseEnter, Label7.MouseEnter
        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.Gold
        lbl.Top -= 3
        lbl.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave, Label6.MouseLeave, Label7.MouseLeave
        Dim lbl = DirectCast(sender, Label)
        lbl.ForeColor = Color.White
        lbl.Top += 3
        lbl.Cursor = Cursors.Default
    End Sub

    Private Sub Week10Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' Fix the gray background on the labels by matching the dark banner RGB
        Dim bannerBlack As Color = Color.FromArgb(24, 24, 24)
        Label3.BackColor = bannerBlack
        Label6.BackColor = bannerBlack
        Label7.BackColor = bannerBlack
    End Sub
End Class