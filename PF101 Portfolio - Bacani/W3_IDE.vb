Public Class W3_IDE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week3Selector.Show()
        Week3Selector.Update()
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
        W3_Components.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W3_Vbnet.Show()
    End Sub

    Private Sub W3_IDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Label1.Text = "Click a window above to inspect its role."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "[ TOOLBOX ]" & vbCrLf & vbCrLf &
                  "• Common Controls: Button, Label, TextBox" & vbCrLf &
                  "• Containers: Panel, GroupBox" & vbCrLf & vbCrLf &
                  "Role: Provides drag-and-drop UI controls used to design forms."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "[ SOLUTION EXPLORER ]" & vbCrLf & vbCrLf &
                  "📁 Solution 'PortfolioApp'" & vbCrLf &
                  "   ├── 📄 W3_IDE.vb" & vbCrLf &
                  "   └── 📄 W3_Programming.vb" & vbCrLf & vbCrLf &
                  "Role: Manages project files, forms, modules, and dependencies."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "[ PROPERTIES WINDOW ]" & vbCrLf & vbCrLf &
                  "• Name: Button1" & vbCrLf &
                  "• BackColor: Black" & vbCrLf &
                  "• Text: 'Confirm'" & vbCrLf & vbCrLf &
                  "Role: Inspects and customizes control properties at design time."
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.Text = "[ ERROR LIST & OUTPUT ]" & vbCrLf & vbCrLf &
                  "✓ Build Succeeded: 0 Errors, 0 Warnings" & vbCrLf &
                  "• Output: Build finished successfully." & vbCrLf & vbCrLf &
                  "Role: Displays compilation status, errors, and warning codes."
    End Sub

    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class