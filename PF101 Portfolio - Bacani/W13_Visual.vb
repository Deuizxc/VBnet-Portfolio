Public Class W13_Visual
    ' MDI Navigation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week13Selector.OpenChildForm(New W13_Memory())
    End Sub

    ' Hover Effects
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

    ' Form Load
    Private Sub W13_Visual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        LoadDocumentationText()
        UpdateSQLPane()
    End Sub

    Private Sub LoadDocumentationText()

    End Sub

    ' --- QUERY BUILDER SIMULATION LOGIC ---

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles chkID.CheckedChanged, chkFirst.CheckedChanged, chkLast.CheckedChanged, chkSalary.CheckedChanged
        UpdateSQLPane()
    End Sub

    Private Sub UpdateSQLPane()
        Dim cols As New List(Of String)
        If chkID.Checked Then cols.Add("ID")
        If chkFirst.Checked Then cols.Add("First_Name")
        If chkLast.Checked Then cols.Add("Last_Name")
        If chkSalary.Checked Then cols.Add("Salary")

        Dim selectString As String = If(cols.Count > 0, String.Join(", ", cols), "*")
        lblSqlPane.Text = "SELECT " & selectString & vbCrLf & "FROM SalesStaff"

        rtbResults.Clear()
        rtbResults.Text = "> Waiting for Command execution..."
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ' Simulate ADO.NET Command executing and DataReader fetching records sequentially
        rtbResults.Clear()

        rtbResults.SelectionColor = Color.DodgerBlue
        rtbResults.AppendText("[Command] Executing query..." & vbCrLf)
        rtbResults.SelectionColor = Color.Orange
        rtbResults.AppendText("[DataReader] Opening forward-only stream..." & vbCrLf & vbCrLf)

        rtbResults.SelectionColor = Color.White

        ' Mock SalesStaff Data
        Dim mockData As New List(Of Dictionary(Of String, String)) From {
            New Dictionary(Of String, String) From {{"ID", "104"}, {"First_Name", "Adrian"}, {"Last_Name", "Adams"}, {"Salary", "$35,007"}},
            New Dictionary(Of String, String) From {{"ID", "114"}, {"First_Name", "Fay"}, {"Last_Name", "Franklin"}, {"Salary", "$56,001"}},
            New Dictionary(Of String, String) From {{"ID", "115"}, {"First_Name", "Adiel"}, {"Last_Name", "Franklin"}, {"Salary", "$41,000"}}
        }

        ' Simulate DataReader.Read() Loop
        Dim rowCount As Integer = 1
        For Each row In mockData
            rtbResults.SelectionColor = Color.LimeGreen
            rtbResults.AppendText("-> Read() Row " & rowCount & ": ")
            rtbResults.SelectionColor = Color.White

            Dim rowOutput As New List(Of String)
            If chkID.Checked Then rowOutput.Add(row("ID"))
            If chkFirst.Checked Then rowOutput.Add(row("First_Name"))
            If chkLast.Checked Then rowOutput.Add(row("Last_Name"))
            If chkSalary.Checked Then rowOutput.Add(row("Salary"))

            ' If nothing selected, show all like SELECT *
            If rowOutput.Count = 0 Then
                rowOutput.Add(row("ID") & " | " & row("First_Name") & " | " & row("Last_Name") & " | " & row("Salary"))
            End If

            rtbResults.AppendText(String.Join(", ", rowOutput) & vbCrLf)
            rowCount += 1
        Next

        rtbResults.SelectionColor = Color.DodgerBlue
        rtbResults.AppendText(vbCrLf & "[DataReader] End of stream reached. Closed.")
    End Sub
End Class