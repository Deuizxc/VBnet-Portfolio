Public Class Level2
    ' Global variables to hold the secret PIN and attempt count
    Private secretCode(2) As String
    Private attempts As Integer = 0
    Private rand As New Random()

    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        ' Setup the input boxes to only accept 1 character
        txtPin1.MaxLength = 1
        txtPin2.MaxLength = 1
        TextBox2.MaxLength = 1
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' Force the Return button to pull its background from the moving data rain
        Button1.Parent = txtPin3 ' (Change btnReturn to your actual button name)
        txtPin1.Parent = txtPin3
        txtPin2.Parent = txtPin3
        TextBox2.Parent = txtPin3

        ' Center the win and lose panels and hide them initially
        win.Left = (Me.ClientSize.Width - win.Width) \ 2
        win.Top = (Me.ClientSize.Height - win.Height) \ 2
        win.Visible = False

        lose.Left = (Me.ClientSize.Width - lose.Width) \ 2
        lose.Top = (Me.ClientSize.Height - lose.Height) \ 2
        lose.Visible = False

        StartNewGame()
    End Sub

    Private Sub StartNewGame()
        ' Reset attempts and UI
        attempts = 0
        UpdateReadouts()

        lstLog.Clear() ' Clears the RichTextBox
        AppendColorText("> TERMINAL ONLINE. WAITING FOR INPUT...", Color.White)
        lstLog.AppendText(vbCrLf) ' Adds a line break

        txtPin1.Clear()
        txtPin2.Clear()
        TextBox2.Clear()

        ' Generate 3 UNIQUE random digits between 0 and 9
        Dim digits As New List(Of Integer)
        While digits.Count < 3
            Dim num As Integer = rand.Next(0, 10)
            If Not digits.Contains(num) Then
                digits.Add(num)
            End If
        End While

        ' Store the digits in our secret array
        secretCode(0) = digits(0).ToString()
        secretCode(1) = digits(1).ToString()
        secretCode(2) = digits(2).ToString()
    End Sub

    ' --- NEW HELPER FUNCTION FOR COLORED TEXT ---
    Private Sub AppendColorText(text As String, textColor As Color)
        lstLog.SelectionStart = lstLog.TextLength
        lstLog.SelectionLength = 0
        lstLog.SelectionColor = textColor
        lstLog.AppendText(text)
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        ' 1. Validate that all boxes have a number
        If txtPin1.Text = "" Or txtPin2.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("SYSTEM ERROR: Enter a digit in all three nodes.", "Terminal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Grab the player's guess
        Dim guess(2) As String
        guess(0) = txtPin1.Text
        guess(1) = txtPin2.Text
        guess(2) = TextBox2.Text

        ' 3. Evaluate the guess and assign specific colors
        Dim feedback(2) As String
        Dim colors(2) As Color
        Dim criticalCount As Integer = 0

        For i As Integer = 0 To 2
            If guess(i) = secretCode(i) Then
                feedback(i) = "CRITICAL"
                colors(i) = Color.Red
                criticalCount += 1
            ElseIf secretCode.Contains(guess(i)) Then
                feedback(i) = "WEAK"
                colors(i) = Color.Yellow
            Else
                feedback(i) = "MISS"
                colors(i) = Color.Cyan
            End If
        Next

        ' 4. Log the attempt and increase security level
        attempts += 1
        UpdateReadouts()

        ' Print the output with multi-colored text on the same line
        AppendColorText($"> {guess(0)} {guess(1)} {guess(2)} : ", Color.White)
        AppendColorText(feedback(0), colors(0))
        AppendColorText(" - ", Color.White)
        AppendColorText(feedback(1), colors(1))
        AppendColorText(" - ", Color.White)
        AppendColorText(feedback(2), colors(2))

        lstLog.AppendText(vbCrLf) ' Drop to a new line for the next guess
        lstLog.ScrollToCaret()    ' Auto-scroll to the bottom

        ' 5. Check for Win or Loss
        If criticalCount = 3 Then
            win.Visible = True
            win.BringToFront()
        ElseIf attempts >= 5 Then
            lose.Visible = True
            lose.BringToFront()
        End If
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        ' Resets the terminal early if the player gets stuck
        AppendColorText("> HACK ABORTED. RESTARTING PROTOCOL...", Color.Cyan)
        lstLog.AppendText(vbCrLf)
        StartNewGame()
    End Sub

    Private Sub UpdateReadouts()
        ' Updates the red stat boxes
        lblAttempts.Text = $"ATTEMPTS: {attempts}/5"
        lblSecurityLevel.Text = $"SECURITY LEVEL: {(attempts * 20)}%"
    End Sub

    ' Restrict input so players can ONLY type numbers, no letters allowed
    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin1.KeyPress, txtPin2.KeyPress, TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub btnDecrypt_MouseEnter(sender As Object, e As EventArgs) Handles btnDecrypt.MouseEnter
        btnDecrypt.Top -= 3
        btnDecrypt.Cursor = Cursors.Hand
    End Sub

    Private Sub btnDecrypt_MouseLeave(sender As Object, e As EventArgs) Handles btnDecrypt.MouseLeave
        btnDecrypt.Top += 3
        btnDecrypt.Cursor = Cursors.Default
    End Sub

    Private Sub btnAbort_MouseEnter(sender As Object, e As EventArgs) Handles btnAbort.MouseEnter
        btnAbort.Top -= 3
        btnAbort.Cursor = Cursors.Hand
    End Sub

    Private Sub btnAbort_MouseLeave(sender As Object, e As EventArgs) Handles btnAbort.MouseLeave
        btnAbort.Top += 3
        btnAbort.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
    End Sub

    Private Sub txtPin3_Click(sender As Object, e As EventArgs) Handles txtPin3.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menu.Show()
        Menu.Update()
    End Sub

    ' Click to dismiss the WIN screen
    Private Sub win_Click(sender As Object, e As EventArgs) Handles win.Click
        win.Visible = False
        ' TODO: Transition to Level 3 or main menu here
    End Sub

    ' Click to dismiss the LOSE screen and reboot the hack
    Private Sub lose_Click(sender As Object, e As EventArgs) Handles lose.Click
        lose.Visible = False
        StartNewGame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        win.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lose.Visible = False
    End Sub
End Class