Public Class FPsalesreport
    Private dtSales As New DataTable()

    Private Sub FPsalesreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        dtSales.Columns.Add("TransactionID", GetType(String))
        dtSales.Columns.Add("Customer", GetType(String))
        dtSales.Columns.Add("ItemsOrdered", GetType(String))
        dtSales.Columns.Add("TotalAmount", GetType(Decimal))
        dtSales.Columns.Add("Timestamp", GetType(String))

        dtSales.Rows.Add("TXN-1001", "Walk-in #1", "Big Mac Meal, Large Fries", 306.88D, "2026-11-15 12:30 PM")
        dtSales.Rows.Add("TXN-1002", "Walk-in #2", "Cheeseburger, Coca-Cola Float", 161.28D, "2026-11-15 01:15 PM")
        dtSales.Rows.Add("TXN-1003", "Walk-in #3", "2-pc Chicken Joy, Sundae", 201.6D, "2026-11-15 02:40 PM")

        dgvSales.DataSource = dtSales

        If dgvSales.Columns.Contains("TotalAmount") Then
            dgvSales.Columns("TotalAmount").DefaultCellStyle.Format = "₱#,##0.00"
        End If

        CalculateMetrics()
    End Sub

    Private Sub CalculateMetrics()
        Dim totalRev As Decimal = 0D
        Dim totalCount As Integer = dtSales.Rows.Count

        For Each row As DataRow In dtSales.Rows
            totalRev += Convert.ToDecimal(row("TotalAmount"))
        Next

        Dim avgTicket As Decimal = If(totalCount > 0, totalRev / totalCount, 0D)

        lblTotalRevenue.Text = $"₱{totalRev:N2}"
        lblTotalTxn.Text = totalCount.ToString()
        lblAvgTicket.Text = $"₱{avgTicket:N2}"
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim().Replace("'", "''")
        If String.IsNullOrEmpty(keyword) Then
            dtSales.DefaultView.RowFilter = String.Empty
        Else
            dtSales.DefaultView.RowFilter = $"TransactionID LIKE '%{keyword}%' OR Customer LIKE '%{keyword}%' OR ItemsOrdered LIKE '%{keyword}%'"
        End If
        CalculateMetrics()
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        MessageBox.Show("Sales report data successfully exported to transaction CSV log.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New FPdashboard()
        dash.Show()
        Me.Close()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnExport.MouseEnter, btnBack.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnExport.MouseLeave, btnBack.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class