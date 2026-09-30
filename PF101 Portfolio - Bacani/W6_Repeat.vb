Public Class W6_Repeat

    Private Sub W6_Repeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        RadioButton1.Checked = True
        ListBox1.Items.Clear()
        Label3.Text = "Total Iterations: -"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week6Selector.Show()
        Week6Selector.Update()
        Me.Hide()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.Top -= 3
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Top += 3
        Button2.Cursor = Cursors.Default
    End Sub

    ' Button 3
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.Top -= 3
        Button3.Cursor = Cursors.Hand
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Top += 3
        Button3.Cursor = Cursors.Default
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W6_Date.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W6_Classes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

        Dim maxCount As Integer

        ' Input validation: ensure the user entered a positive whole number
        If Not Integer.TryParse(TextBox1.Text, maxCount) OrElse maxCount <= 0 Then
            MessageBox.Show("Please enter a valid positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.SelectAll()
            TextBox1.Focus()
            Exit Sub
        End If

        Dim iterations As Integer = 0

        ' Check which loop mode is selected
        If RadioButton1.Checked Then
            ' 1. Do While
            Dim i As Integer = 0
            Do While i < maxCount
                ListBox1.Items.Add("Do While: Item " & (i + 1))
                i += 1
                iterations += 1
            Loop

        ElseIf RadioButton2.Checked Then
            ' 2. For...Next
            For i As Integer = 0 To maxCount - 1
                ListBox1.Items.Add("For...Next: Item " & (i + 1))
                iterations += 1
            Next

        ElseIf RadioButton3.Checked Then
            ' 3. Do Until
            Dim i As Integer = 0
            Do Until i = maxCount
                ListBox1.Items.Add("Do Until: Item " & (i + 1))
                i += 1
                iterations += 1
            Loop

        ElseIf RadioButton4.Checked Then
            ' 4. Nested Loop (e.g. 2 Outer cycles x maxCount Inner cycles)
            For outer As Integer = 1 To 2
                For inner As Integer = 1 To maxCount
                    ListBox1.Items.Add("Outer " & outer & " -> Inner " & inner)
                    iterations += 1
                Next
            Next
        End If

        ' Update the iterations counter label
        Label3.Text = "Total Iterations: " & iterations.ToString()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
        Label3.Text = "Total Iterations: -"
        TextBox1.Focus()
    End Sub

End Class