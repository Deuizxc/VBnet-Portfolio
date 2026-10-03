Public Class W8_Color
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week8Selector.Show()
        Week8Selector.Update()
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
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W8_File.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W8_Dialog.Show()
    End Sub
    Private WithEvents ColorDialog1 As New ColorDialog()
    Private WithEvents FontDialog1 As New FontDialog()

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FontDialog1.ShowColor = False
        FontDialog1.ShowEffects = True
        FontDialog1.MinSize = 8
        FontDialog1.MaxSize = 20

        ColorDialog1.AllowFullOpen = True

        ResetFormatting()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ColorDialog1.Color = lblSample.ForeColor

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            lblSample.ForeColor = ColorDialog1.Color
            lblColorInfo.Text = "Color: " & ColorDialog1.Color.Name
            lblFeedback.ForeColor = Color.LimeGreen
            lblFeedback.Text = "Executed: lblSample.ForeColor = " & ColorDialog1.Color.Name
        Else
            lblFeedback.ForeColor = Color.Orange
            lblFeedback.Text = "Executed: Color selection cancelled"
        End If
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        FontDialog1.Font = lblSample.Font

        If FontDialog1.ShowDialog() = DialogResult.OK Then
            lblSample.Font = FontDialog1.Font
            lblFontInfo.Text = "Font: " & FontDialog1.Font.Name & ", " & CInt(FontDialog1.Font.SizeInPoints).ToString() & "pt"
            lblFeedback.ForeColor = Color.LimeGreen
            lblFeedback.Text = "Executed: Font -> " & FontDialog1.Font.Name & " (" & CInt(FontDialog1.Font.SizeInPoints).ToString() & "pt)"
        Else
            lblFeedback.ForeColor = Color.Orange
            lblFeedback.Text = "Executed: Font selection cancelled"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFormatting()
    End Sub
    Private Sub OptionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnColor.MouseEnter, btnFont.MouseEnter, btnReset.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub OptionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnColor.MouseLeave, btnFont.MouseLeave, btnReset.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
    Private Sub ResetFormatting()
        lblSample.ForeColor = Color.White
        lblSample.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)
        lblColorInfo.Text = "Color: White"
        lblFontInfo.Text = "Font: Segoe UI, 11pt"
        lblFeedback.ForeColor = Color.LimeGreen
        lblFeedback.Text = "Executed: Ready"
    End Sub
    Private Sub W8_Color_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class