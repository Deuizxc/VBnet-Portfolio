Public Class W7_Array

    Private intHours(6) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week7Selector.Show()
        Week7Selector.Update()
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
        W7_Dimension.Show()
    End Sub

    Private Sub W7_Array_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

        With DataGridView1
            .Columns.Clear()
            .Rows.Clear()
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromArgb(15, 15, 15)
            .GridColor = Color.FromArgb(60, 60, 60)
            .BorderStyle = BorderStyle.FixedSingle
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ScrollBars = ScrollBars.None

            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 20, 20)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 24

            .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .DefaultCellStyle.ForeColor = Color.LimeGreen
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 35, 35)
            .DefaultCellStyle.SelectionForeColor = Color.LimeGreen

            For i As Integer = 0 To 6
                Dim colIdx As Integer = .Columns.Add($"col{i}", $"({i})")
                .Columns(colIdx).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Rows.Add()
            .Rows(0).Height = 28
        End With

        ComboBox1.Items.Clear()
        For i As Integer = 0 To 6
            ComboBox1.Items.Add(i.ToString())
        Next
        ComboBox1.SelectedIndex = 0

        ResetArray()
    End Sub

    Private Sub ResetArray()
        For i As Integer = 0 To 6
            intHours(i) = 0
            DataGridView1.Rows(0).Cells(i).Value = "0"
        Next

        Label6.ForeColor = Color.LimeGreen
        Label6.Text = "Executed: Default Initialization (All elements = 0)"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedIdx As Integer
        Dim enteredValue As Integer

        If Not Integer.TryParse(ComboBox1.Text.Trim(), selectedIdx) Then
            Label6.ForeColor = Color.Red
            Label6.Text = "Error: Please select a valid index (0 to 6)."
            Exit Sub
        End If

        If selectedIdx < 0 OrElse selectedIdx > intHours.GetUpperBound(0) Then
            Label6.ForeColor = Color.Red
            Label6.Text = $"Error: Index {selectedIdx} is out of bounds (0 to 6)."
            Exit Sub
        End If

        If Integer.TryParse(TextBox1.Text.Trim(), enteredValue) Then
            intHours(selectedIdx) = enteredValue
            DataGridView1.Rows(0).Cells(selectedIdx).Value = enteredValue.ToString()

            Label6.ForeColor = Color.LimeGreen
            Label6.Text = $"Executed: intHours({selectedIdx}) = {enteredValue}"

            TextBox1.Clear()
            TextBox1.Focus()
        Else
            Label6.ForeColor = Color.Red
            Label6.Text = "Error: Please enter a valid integer."
        End If
    End Sub

    ' Button 2
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResetArray()
        TextBox1.Clear()
    End Sub

End Class