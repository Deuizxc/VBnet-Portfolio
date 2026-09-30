Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class W4_Common
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
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W4_Form.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W4_Basic.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim userName As String = txtDemo.Text.Trim()
        If userName = "" Then userName = "User"


        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = Math.Min(100, ProgressBar1.Value + 25)
        Else
            ProgressBar1.Value = 25
        End If


        Dim selectedMessage As String = ""

        If RadioButton1.Checked Then
            selectedMessage = "Role: Student"
        ElseIf RadioButton2.Checked Then
            selectedMessage = "Role: Admin"
        Else
            selectedMessage = "Role: Unselected"
        End If

        lblStatus.Text = "Name: " & userName & " | " & selectedMessage

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.Top -= 3
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Top += 3
        Button2.Cursor = Cursors.Default
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDemo.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub W4_Common_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class