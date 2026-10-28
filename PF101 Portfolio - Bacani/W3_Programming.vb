Public Class W3_Programming
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week3Selector.Show()
            Week3Selector.Update()
        Catch ex As Exception
            Dim w3 As New Week3Selector()
            w3.Show()
            w3.Update()
        End Try
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
        Try
            W3_Components.Show()
        Catch ex As Exception
            Dim comp As New W3_Components()
            comp.Show()
        End Try
    End Sub

    Private Sub W3_Programming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        FormatText()
    End Sub

    Private Sub FormatText()
        Try
            Dim rtb As RichTextBox = Nothing
            If Me.Controls.Find("RichTextBox1", True).Length > 0 Then
                rtb = DirectCast(Me.Controls.Find("RichTextBox1", True)(0), RichTextBox)
            End If
            If rtb Is Nothing Then Return
            rtb.Clear()

            Dim boldFont As New Font("Segoe UI", 9.0F, FontStyle.Bold)
            Dim regFont As New Font("Segoe UI", 9.0F, FontStyle.Regular)
            Dim redColor As Color = Color.FromArgb(190, 20, 20)
            Dim darkColor As Color = Color.FromArgb(20, 20, 20)

            rtb.SelectionFont = boldFont
            rtb.SelectionColor = redColor
            rtb.AppendText("• Visual Basic & C#: ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = darkColor
            rtb.AppendText("Used for enterprise Windows desktop and web applications." & vbCrLf & vbCrLf)

            rtb.SelectionFont = boldFont
            rtb.SelectionColor = redColor
            rtb.AppendText("• C & C++: ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = darkColor
            rtb.AppendText("High-performance, system-level execution; C++ introduces OOP features." & vbCrLf & vbCrLf)

            rtb.SelectionFont = boldFont
            rtb.SelectionColor = redColor
            rtb.AppendText("• Java: ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = darkColor
            rtb.AppendText("Cross-platform runtime environment; standard for enterprise tools and OOP architecture." & vbCrLf & vbCrLf)

            rtb.SelectionFont = boldFont
            rtb.SelectionColor = redColor
            rtb.AppendText("• Python: ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = darkColor
            rtb.AppendText("High-level, rapid scripting language for automation, data, and tool development." & vbCrLf & vbCrLf)

            rtb.SelectionFont = boldFont
            rtb.SelectionColor = redColor
            rtb.AppendText("• PHP: ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = darkColor
            rtb.AppendText("Server-side scripting language designed for dynamic applications." & vbCrLf & vbCrLf)

            rtb.SelectionFont = boldFont
            rtb.SelectionColor = redColor
            rtb.AppendText("• JavaScript: ")
            rtb.SelectionFont = regFont
            rtb.SelectionColor = darkColor
            rtb.AppendText("Core client-side language powering interactive user interfaces.")
        Catch ex As Exception
        End Try
    End Sub
End Class