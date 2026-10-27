Public Class W1415_Row
    Private dtMock As New DataTable("Students")
    Private currentRowIndex As Integer = 0

    ' MDI Navigation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week14_15Selector.OpenChildForm(New W1415_Dataset())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week14_15Selector.OpenChildForm(New W1415_Database())
    End Sub

    ' Hover Effects
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub W1415_Row_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' 1. Initialize Mock DataTable with a NULL value
        dtMock.Columns.Add("ID", GetType(Integer))
        dtMock.Columns.Add("Name", GetType(String))
        dtMock.Columns.Add("Age", GetType(Integer))

        dtMock.Rows.Add(1, "Ryuji", 17)
        dtMock.Rows.Add(2, "Makoto", 18)

        ' Create a row with a NULL age using DBNull.Value
        Dim nullRow As DataRow = dtMock.NewRow()
        nullRow("ID") = 3
        nullRow("Name") = "Lavenza"
        nullRow("Age") = DBNull.Value
        dtMock.Rows.Add(nullRow)

        UpdateRowDisplay()
    End Sub

    ' --- ROW NAVIGATION ---
    Private Sub UpdateRowDisplay()
        Dim row As DataRow = dtMock.Rows(currentRowIndex)
        Dim ageDisplay As String = If(row.IsNull("Age"), "NULL", row("Age").ToString())

        lblRowData.Text = $"[Row {currentRowIndex}] ID: {row("ID")} | Name: {row("Name")} | Age: {ageDisplay}"

        btnPrev.Enabled = (currentRowIndex > 0)
        btnNext.Enabled = (currentRowIndex < dtMock.Rows.Count - 1)
        rtbTerminal.Clear()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentRowIndex > 0 Then
            currentRowIndex -= 1
            UpdateRowDisplay()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentRowIndex < dtMock.Rows.Count - 1 Then
            currentRowIndex += 1
            UpdateRowDisplay()
        End If
    End Sub

    ' --- THREE-VALUED LOGIC SIMULATOR ---
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        rtbTerminal.Clear()

        Dim row As DataRow = dtMock.Rows(currentRowIndex)

        rtbTerminal.SelectionColor = Color.DodgerBlue
        rtbTerminal.AppendText($"Evaluating: Is {row("Name")}'s Age >= 18?" & vbCrLf & vbCrLf)

        If row.IsNull("Age") Then
            ' Null evaluation triggers Three-Valued Logic
            rtbTerminal.SelectionColor = Color.LimeGreen
            rtbTerminal.AppendText("Result: UNKNOWN" & vbCrLf & vbCrLf)
            rtbTerminal.SelectionColor = Color.LightGray
            rtbTerminal.AppendText("Because the age is NULL, the relational database cannot determine if it is >= 18. It evaluates to neither True nor False.")
        Else
            ' Standard evaluation
            Dim age As Integer = Convert.ToInt32(row("Age"))
            rtbTerminal.SelectionColor = Color.White
            If age >= 18 Then
                rtbTerminal.AppendText("Result: TRUE" & vbCrLf & vbCrLf)
                rtbTerminal.SelectionColor = Color.LightGray
                rtbTerminal.AppendText($"{row("Name")} is 18 or older.")
            Else
                rtbTerminal.AppendText("Result: FALSE" & vbCrLf & vbCrLf)
                rtbTerminal.SelectionColor = Color.LightGray
                rtbTerminal.AppendText($"{row("Name")} is under 18.")
            End If
        End If
    End Sub
End Class