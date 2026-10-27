Public Class W1415_Dataset
    ' Simulate the DataSet memory structure
    Private dsMemory As New DataSet("MemoryCache")

    ' MDI Navigation & Hover
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week14_15Selector.OpenChildForm(New W1415_Archi())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week14_15Selector.OpenChildForm(New W1415_Row())
    End Sub

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

    Private Sub W1415_Dataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    ' --- DATA ADAPTER SIMULATOR LOGIC ---
    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        rtbTerminal.Clear()
        rtbTerminal.SelectionColor = Color.DodgerBlue
        rtbTerminal.AppendText("[1] INITIALIZING OLEDB CONNECTION..." & vbCrLf)
        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("Provider: Microsoft.Jet.OLEDB.4.0;" & vbCrLf)
        rtbTerminal.AppendText("Data Source: C:\AddressBook.mdb" & vbCrLf)
        rtbTerminal.AppendText("State: ")
        rtbTerminal.SelectionColor = Color.Gold
        rtbTerminal.AppendText("OPEN" & vbCrLf & vbCrLf)

        rtbTerminal.SelectionColor = Color.DodgerBlue
        rtbTerminal.AppendText("[2] EXECUTING da.Fill(ds, ""tblContacts"")" & vbCrLf)
        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("-> Retrieving Records..." & vbCrLf)

        ' Build mock table
        Dim dt As New DataTable("tblContacts")
        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Section", GetType(String))
        dt.Rows.Add("ST-30351", "Jeff Mcaee", "SBIT2C")
        dt.Rows.Add("ST-30352", "Makoto Niijima", "SBIT2C")

        ' Clear and add to ensure clean reset on multiple clicks
        dsMemory.Tables.Clear()
        dsMemory.Tables.Add(dt)

        rtbTerminal.AppendText("-> DataSet Populated." & vbCrLf)
        rtbTerminal.AppendText("Connection State: ")
        rtbTerminal.SelectionColor = Color.Gray
        rtbTerminal.AppendText("CLOSED" & vbCrLf & vbCrLf)

        btnIterate.Enabled = True
    End Sub

    Private Sub btnIterate_Click(sender As Object, e As EventArgs) Handles btnIterate.Click
        rtbTerminal.AppendText(vbCrLf)
        rtbTerminal.SelectionColor = Color.LimeGreen
        rtbTerminal.AppendText("[3] NESTED ITERATION OUTPUT" & vbCrLf)
        rtbTerminal.SelectionColor = Color.White

        ' Exact nested loop structure from the Week 14-15 lecture
        For Each table As DataTable In dsMemory.Tables
            rtbTerminal.AppendText("--- Table: " & table.TableName & " ---" & vbCrLf)
            For Each row As DataRow In table.Rows
                Dim rowData As New List(Of String)
                For Each column As DataColumn In table.Columns
                    rowData.Add(row(column).ToString())
                Next
                rtbTerminal.AppendText(String.Join(" | ", rowData) & vbCrLf)
            Next
        Next
    End Sub
End Class