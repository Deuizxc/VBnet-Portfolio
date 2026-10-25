Public Class W1112_Net
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week11_12Selector.OpenChildForm(New W1112_Classes())
    End Sub

    Private Sub W1112_Net_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        cboLanguage.Items.Add("Visual Basic (.vb)")
        cboLanguage.Items.Add("C# (.cs)")
        cboLanguage.Items.Add("J# (.jsl)")
        cboLanguage.SelectedIndex = 0


    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button7.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button7.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
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

    Private Sub btnCompile_Click(sender As Object, e As EventArgs) Handles btnCompile.Click
        rtbOutput.Clear()
        rtbOutput.SelectionColor = Color.DodgerBlue
        rtbOutput.AppendText("> Analyzing " & cboLanguage.SelectedItem.ToString() & " source code..." & vbCrLf)

        rtbOutput.SelectionColor = Color.White
        rtbOutput.AppendText("> Passing to Language Compiler..." & vbCrLf)
        rtbOutput.AppendText("> Converting to Common Intermediate Language (CIL)..." & vbCrLf)

        rtbOutput.SelectionColor = Color.LimeGreen
        rtbOutput.AppendText(vbCrLf & "[CLR STATUS]: Active" & vbCrLf)
        rtbOutput.AppendText("-> JIT Compiler executed successfully." & vbCrLf)
        rtbOutput.AppendText("-> Base Class Library (BCL) linked." & vbCrLf)
        rtbOutput.AppendText("-> Output: Hello World")


    End Sub
End Class