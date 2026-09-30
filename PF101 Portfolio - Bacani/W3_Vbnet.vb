Public Class W3_Vbnet
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
        W3_IDE.Show()
    End Sub

    Private Sub btnrun_Click(sender As Object, e As EventArgs) Handles btnrun.Click
        Dim cmdCommands As String = "/k @echo off & title PF101 Execution Terminal & " &
                                "echo ============================================================== & " &
                                "echo             PF101 .NET RUNTIME EXECUTION ENVIRONMENT           & " &
                                "echo ============================================================== & " &
                                "echo [STATUS]    : Showcasing Output.. OK & " &
                                "echo [TARGET]    : Console Application Module & " &
                                "echo -------------------------------------------------------------- & " &
                                "echo [OUTPUT]   -^> Hello, World! & " &
                                "echo -------------------------------------------------------------- & " &
                                "echo Process exited with code 0 (0x0). & " &
                                "echo. & pause"

        Process.Start("cmd.exe", cmdCommands)
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub btnrun_MouseEnter(sender As Object, e As EventArgs) Handles btnrun.MouseEnter
        btnrun.Top -= 3
        btnrun.Cursor = Cursors.Hand
    End Sub

    Private Sub btnrun_MouseLeave(sender As Object, e As EventArgs) Handles btnrun.MouseLeave
        btnrun.Top += 3
        btnrun.Cursor = Cursors.Default
    End Sub

    Private Sub W3_Vbnet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class