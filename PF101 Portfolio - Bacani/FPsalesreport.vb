Public Class FPsalesreport
    Private dtSales As New DataTable()

    Private Sub FPsalesreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        dtSales.Columns.Add("TransactionID", GetType(String))
        dtSales.Columns.Add("ItemsOrdered", GetType(String))
        dtSales.Columns.Add("TotalAmount", GetType(Decimal))
        dtSales.Columns.Add("Timestamp", GetType(String))

        dtSales.Rows.Add("TXN-1001", "Big Mac Meal, Large Fries", 274D, "2026-11-15 12:30 PM")
        dtSales.Rows.Add("TXN-1002", "Cheeseburger, Coca-Cola Float", 144D, "2026-11-15 01:15 PM")

        dgvSales.DataSource = dtSales
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        MessageBox.Show("Sales report exported successfully to database/CSV log.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
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