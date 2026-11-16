Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class FPorders
    Private Sub FPorders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        ReloadOrders()
    End Sub

    Private Sub ReloadOrders(Optional selectedId As Long = 0)
        Dim orders As List(Of KioskDatabase.OrderRecord)
        Try
            orders = KioskDatabase.GetOrders()
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "Orders could not be loaded.", ex)
            Return
        End Try

        dgvOrders.Rows.Clear()
        Dim selection As Integer = 0
        For Each order In orders
            Dim rowIndex = dgvOrders.Rows.Add(order.OrderNumber,
                                             order.PlacedAt.ToString("h:mm tt"),
                                             order.Status,
                                             If(order.Status = "Cancelled", "—", order.PaymentStatus),
                                             order.Total)
            dgvOrders.Rows(rowIndex).Tag = order
            If order.Id = selectedId Then selection = rowIndex
        Next

        If dgvOrders.Rows.Count > 0 Then
            dgvOrders.CurrentCell = dgvOrders.Rows(selection).Cells(0)
        End If
        ShowSelectedOrder()
    End Sub

    Private Sub dgvOrders_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrders.SelectionChanged
        ShowSelectedOrder()
    End Sub

    Private Sub ShowSelectedOrder()
        dgvOrderItems.Rows.Clear()

        Dim order = SelectedOrder()
        Dim awaitingPayment As Boolean = order IsNot Nothing AndAlso
            order.Status = "New" AndAlso order.PaymentStatus = "Unpaid"
        btnMarkPaid.Enabled = awaitingPayment
        btnCancelOrder.Enabled = awaitingPayment

        If order Is Nothing Then
            lblOrderNumber.Text = If(dgvOrders.Rows.Count = 0, "No orders yet", "Select an order")
            lblOrderStatus.Text = If(dgvOrders.Rows.Count = 0, "Place an order from the customer kiosk.", "")
            lblOrderTotal.Text = ""
            lblPayment.Text = ""
            lblDiningOption.Text = ""
            btnAdvance.Text = "UPDATE STATUS"
            btnAdvance.Enabled = False
            Return
        End If

        lblOrderNumber.Text = order.OrderNumber
        lblOrderStatus.Text = $"Status: {order.Status}   |   {order.PlacedAt:MMM d, h:mm tt}"
        lblOrderTotal.Text = $"Order total: ₱{order.Total:N2}"
        lblPayment.Text = $"Payment: {order.PaymentStatus}"
        If order.PaymentMethod <> "" Then lblPayment.Text &= $" · {order.PaymentMethod}"
        lblDiningOption.Text = If(order.DiningOption = "", "", $"Order type: {order.DiningOption}")

        For Each item In order.Items
            dgvOrderItems.Rows.Add(item.ProductName, item.Quantity, item.UnitPrice * item.Quantity)
        Next

        btnAdvance.Enabled = order.Status <> "Completed" AndAlso order.Status <> "Cancelled" AndAlso
            order.PaymentStatus <> "Unpaid"
        Select Case order.Status
            Case "New"
                btnAdvance.Text = If(awaitingPayment, "AWAITING PAYMENT", "START PREPARING")
            Case "Preparing"
                btnAdvance.Text = "MARK READY"
            Case "Ready"
                btnAdvance.Text = "COMPLETE ORDER"
            Case "Completed"
                btnAdvance.Text = "ORDER COMPLETED"
            Case "Cancelled"
                btnAdvance.Text = "ORDER CANCELLED"
        End Select
    End Sub

    Private Sub btnAdvance_Click(sender As Object, e As EventArgs) Handles btnAdvance.Click
        If dgvOrders.SelectedRows.Count = 0 Then Return

        Dim row As DataGridViewRow = dgvOrders.SelectedRows(0)
        Dim order = TryCast(row.Tag, KioskDatabase.OrderRecord)
        If order Is Nothing Then Return

        Dim nextStatus As String
        Select Case order.Status
            Case "New"
                nextStatus = "Preparing"
            Case "Preparing"
                nextStatus = "Ready"
            Case "Ready"
                nextStatus = "Completed"
            Case Else
                Return
        End Select

        Try
            If Not KioskDatabase.UpdateOrderStatus(order.Id, order.Status, nextStatus) Then
                MessageBox.Show(Me, "This order was updated. The queue will reload.")
                ReloadOrders(order.Id)
                Return
            End If
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The order status could not be saved.", ex)
            Return
        End Try

        order.Status = nextStatus
        row.Cells(colStatus.Index).Value = nextStatus
        ShowSelectedOrder()
    End Sub

    Private Function SelectedOrder() As KioskDatabase.OrderRecord
        If dgvOrders.SelectedRows.Count = 0 Then Return Nothing
        Return TryCast(dgvOrders.SelectedRows(0).Tag, KioskDatabase.OrderRecord)
    End Function

    Private Sub btnMarkPaid_Click(sender As Object, e As EventArgs) Handles btnMarkPaid.Click
        Dim order = SelectedOrder()
        If order Is Nothing Then Return
        If MessageBox.Show(Me, $"Confirm that ₱{order.Total:N2} was received for {order.OrderNumber}.",
                           "Mark as Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return

        Try
            If Not KioskDatabase.MarkOrderPaid(order.Id) Then
                MessageBox.Show(Me, "The order is no longer awaiting payment.")
            End If
            ReloadOrders(order.Id)
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "Payment status could not be saved.", ex)
        End Try
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Dim order = SelectedOrder()
        If order Is Nothing Then Return
        If MessageBox.Show(Me, $"Cancel {order.OrderNumber} and return its items to stock?",
                           "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return

        Try
            If Not KioskDatabase.CancelUnpaidOrder(order.Id) Then
                MessageBox.Show(Me, "The order is no longer awaiting payment.")
            End If
            ReloadOrders(order.Id)
        Catch ex As Exception
            KioskDatabase.ShowDatabaseError(Me, "The order could not be cancelled.", ex)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub
End Class
