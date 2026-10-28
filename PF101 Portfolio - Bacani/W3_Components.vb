Imports System.Text.RegularExpressions

Public Class W3_Components
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Try
            W3_IDE.Show()
        Catch ex As Exception
            Dim ide As New W3_IDE()
            ide.Show()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Try
            W3_Programming.Show()
        Catch ex As Exception
            Dim prog As New W3_Programming()
            prog.Show()
        End Try
    End Sub

    Private Sub GreetUser(userName As String)
        Label2.Text = "Hello, " & userName & "! Welcome to my portfolio"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inputName As String = TextBox1.Text.Trim()
        If inputName = "" Then
            Label2.Text = "Error: Please enter a name first."
            Exit Sub
        End If
        GreetUser(inputName)
    End Sub

    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter, Button4.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave, Button4.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        Label2.Text = "Waiting for input"
        TextBox1.Focus()
    End Sub

    Private Sub W3_Components_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        FormatRichText()
    End Sub

    Private Sub FormatRichText()
        Try
            Dim rtb As RichTextBox = Nothing
            If Me.Controls.Find("RichTextBox1", True).Length > 0 Then
                rtb = DirectCast(Me.Controls.Find("RichTextBox1", True)(0), RichTextBox)
            End If
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return

            rtb.SuspendLayout()
            Dim origStart As Integer = rtb.SelectionStart
            Dim origLen As Integer = rtb.SelectionLength

            rtb.SelectAll()
            rtb.SelectionFont = New Font("Segoe UI", 9.0F, FontStyle.Regular)
            rtb.SelectionColor = Color.FromArgb(40, 40, 40)

            Dim mc As MatchCollection = Regex.Matches(rtb.Text, "(?m)^[•\-]\s*([^:]+):")
            For Each m As Match In mc
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^\d+\.\s+.*$|\[.*?\]")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            rtb.Select(origStart, origLen)
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub
End Class