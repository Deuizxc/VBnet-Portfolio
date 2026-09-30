Public Class W5_Operator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week5Selector.Show()
        Week5Selector.Update()
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
        W5_Conversion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalcDivision.Click
        If String.IsNullOrWhiteSpace(txtMinutes.Text) Then Exit Sub

        Dim totalMinutes As Integer = Integer.Parse(txtMinutes.Text)

        Dim normalDiv As Double = totalMinutes / 60
        lblNormalDiv.Text = "Normal (/) : " & normalDiv.ToString("F2") & " hrs"

        Dim hours As Integer = totalMinutes \ 60
        lblIntDiv.Text = "Integer (\) : " & hours.ToString() & " hrs"

        Dim remainingMinutes As Integer = totalMinutes Mod 60
        lblMod.Text = "Mod (Remainder): " & remainingMinutes.ToString() & " mins"
    End Sub

    Private Sub W5_Operator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter, Button7.MouseEnter, Button5.MouseEnter, Button4.MouseEnter, Button8.MouseEnter, btnCalcDivision.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave, Button7.MouseLeave, Button5.MouseLeave, Button4.MouseLeave, Button8.MouseLeave, btnCalcDivision.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub Arithmetic_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button7.Click, Button5.Click, Button4.Click, Button8.Click
        Dim num1 As Double
        Dim num2 As Double

        If Double.TryParse(TextBox1.Text.Trim(), num1) AndAlso Double.TryParse(TextBox2.Text.Trim(), num2) Then
            Dim btn = DirectCast(sender, Button)
            Dim result As Double = 0

            Select Case btn.Name
                Case "Button3"
                    result = num1 + num2
                    Label3.Text = $"Results: {num1} + {num2} = {result}"

                Case "Button7"
                    result = num1 - num2
                    Label3.Text = $"Results: {num1} - {num2} = {result}"

                Case "Button5"
                    result = num1 * num2
                    Label3.Text = $"Results: {num1} * {num2} = {result}"

                Case "Button4"
                    If num2 = 0 Then
                        Label3.Text = "Results: Cannot divide by zero!"
                        Exit Sub
                    End If
                    result = Math.Round(num1 / num2, 2)
                    Label3.Text = $"Results: {num1} / {num2} = {result}"

                Case "Button8"
                    result = num1 ^ num2
                    Label3.Text = $"Results: {num1} ^ {num2} = {result}"
            End Select
        Else
            Label3.Text = "Results: Enter valid numbers!"
        End If
    End Sub
End Class