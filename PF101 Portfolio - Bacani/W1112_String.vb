Public Class W1112_String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week11_12Selector.OpenChildForm(New W1112_Classes())
    End Sub

    Private Sub W1112_String_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True


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
    Private Sub UpdateOutput(title As String, result As String)
        rtbOutput.Clear()
        rtbOutput.SelectionColor = Color.DodgerBlue
        rtbOutput.AppendText("[" & title & "]" & vbCrLf)
        rtbOutput.SelectionColor = Color.White
        rtbOutput.AppendText("Result: ")
        rtbOutput.SelectionColor = Color.LimeGreen
        rtbOutput.AppendText(result)
    End Sub
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
    Private Sub btnUCase_Click(sender As Object, e As EventArgs) Handles btnUCase.Click
        UpdateOutput("UCase()", UCase(txtInput.Text))
    End Sub

    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        ' Add artificial spaces to show Trim working if user didn't add any
        Dim rawStr As String = "   " & txtInput.Text & "   "
        UpdateOutput("Trim()", Trim(rawStr))
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        UpdateOutput("StrReverse()", StrReverse(txtInput.Text))
    End Sub

    Private Sub btnCurrency_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        Try
            Dim val As Double = Convert.ToDouble(txtInput.Text.Trim())
            UpdateOutput("FormatCurrency()", FormatCurrency(val))
        Catch ex As Exception
            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.Red
            rtbOutput.AppendText("[ERROR]" & vbCrLf & "Input must be numeric to format as currency.")
        End Try
    End Sub
End Class