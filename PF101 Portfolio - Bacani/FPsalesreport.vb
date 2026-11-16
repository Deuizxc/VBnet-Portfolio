Imports System.Globalization
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Text

Public Class FPsalesreport
    Private dtSales As New DataTable()

    Private Sub FPsalesreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        dtSales.Columns.Add("TransactionID", GetType(String))
        dtSales.Columns.Add("Customer", GetType(String))
        dtSales.Columns.Add("ItemsOrdered", GetType(String))
        dtSales.Columns.Add("TotalAmount", GetType(Decimal))
        dtSales.Columns.Add("Timestamp", GetType(String))

        Try
            For Each order In KioskDatabase.GetOrders(completedOnly:=True)
                Dim items As String = String.Join(", ", order.Items.Select(
                    Function(item) $"{item.Quantity} × {item.ProductName}"))
                Dim completedAt = order.CompletedAt.GetValueOrDefault(order.PlacedAt)
                dtSales.Rows.Add(order.OrderNumber, "Walk-in", items, order.Total,
                                 completedAt.ToString("yyyy-MM-dd h:mm tt"))
            Next
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "Sales could not be loaded.", ex)
        End Try

        dgvSales.DataSource = dtSales

        If dgvSales.Columns.Contains("TotalAmount") Then
            dgvSales.Columns("TotalAmount").DefaultCellStyle.Format = "₱#,##0.00"
        End If

        CalculateMetrics()
    End Sub

    Private Sub CalculateMetrics()
        Dim totalRev As Decimal = 0D
        Dim totalCount As Integer = dtSales.DefaultView.Count

        For Each row As DataRowView In dtSales.DefaultView
            totalRev += Convert.ToDecimal(row("TotalAmount"))
        Next

        Dim avgTicket As Decimal = If(totalCount > 0, totalRev / totalCount, 0D)

        lblTotalRevenue.Text = $"₱{totalRev:N2}"
        lblTotalTxn.Text = totalCount.ToString()
        lblAvgTicket.Text = $"₱{avgTicket:N2}"
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = System.Text.RegularExpressions.Regex.Replace(txtSearch.Text.Trim(), "[\[\]\*%]", "[$0]").Replace("'", "''")
        If String.IsNullOrEmpty(keyword) Then
            dtSales.DefaultView.RowFilter = String.Empty
        Else
            dtSales.DefaultView.RowFilter = $"TransactionID LIKE '%{keyword}%' OR Customer LIKE '%{keyword}%' OR ItemsOrdered LIKE '%{keyword}%'"
        End If
        CalculateMetrics()
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using dialog As New SaveFileDialog With {
            .Filter = "CSV files (*.csv)|*.csv", .FileName = "PhantomKiosk-Sales.csv"
        }
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            Try
                Using writer As New StreamWriter(dialog.FileName, False, New UTF8Encoding(True))
                    writer.WriteLine("Order Number,Customer,Items,Total,Completed At")
                    For Each row As DataRowView In dtSales.DefaultView
                        writer.WriteLine(String.Join(",", CsvField(CStr(row("TransactionID"))),
                            CsvField(CStr(row("Customer"))), CsvField(CStr(row("ItemsOrdered"))),
                            CDec(row("TotalAmount")).ToString("0.00", CultureInfo.InvariantCulture),
                            CsvField(CStr(row("Timestamp")))))
                    Next
                End Using
                MessageBox.Show(Me, "Sales report exported.")
            Catch ex As Exception
                KioskDatabase.ShowDatabaseError(Me, "The sales report could not be exported.", ex)
            End Try
        End Using
    End Sub

    Private Function CsvField(value As String) As String
        Dim quote As String = ChrW(34).ToString()
        Return quote & value.Replace(quote, quote & quote) & quote
    End Function

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
