Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class FPorders
    Friend NotInheritable Class OrderItem
        Friend ReadOnly Property ProductName As String
        Friend ReadOnly Property UnitPrice As Decimal
        Friend ReadOnly Property Quantity As Integer

        Friend Sub New(productName As String, unitPrice As Decimal, quantity As Integer)
            Me.ProductName = productName
            Me.UnitPrice = unitPrice
            Me.Quantity = quantity
        End Sub
    End Class

    Private Enum OrderStatus
        [New]
        Preparing
        Ready
        Completed
    End Enum

    Private NotInheritable Class KioskOrder
        Public Property OrderNumber As String
        Public Property PlacedAt As Date
        Public Property Total As Decimal
        Public Property Status As OrderStatus
        Public Property Items As List(Of OrderItem)
    End Class

    ' The kiosk and staff screen run in the same application.
    Private Shared ReadOnly Orders As New List(Of KioskOrder)()

    Friend Shared Function PlaceOrder(items As List(Of OrderItem), total As Decimal) As String
        Dim order As New KioskOrder With {
            .OrderNumber = $"ORD-{Orders.Count + 1:0000}",
            .PlacedAt = Date.Now,
            .Total = total,
            .Status = OrderStatus.[New],
            .Items = New List(Of OrderItem)(items)
        }
        Orders.Add(order)
        Return order.OrderNumber
    End Function

    Private Sub FPorders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True

        For Each order In Orders
            Dim rowIndex = dgvOrders.Rows.Add(order.OrderNumber,
                                             order.PlacedAt.ToString("h:mm tt"),
                                             order.Status.ToString(),
                                             order.Total)
            dgvOrders.Rows(rowIndex).Tag = order
        Next

        If dgvOrders.Rows.Count > 0 Then
            dgvOrders.CurrentCell = dgvOrders.Rows(0).Cells(0)
        End If
        ShowSelectedOrder()
    End Sub

    Private Sub dgvOrders_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrders.SelectionChanged
        ShowSelectedOrder()
    End Sub

    Private Sub ShowSelectedOrder()
        dgvOrderItems.Rows.Clear()

        Dim order As KioskOrder = Nothing
        If dgvOrders.SelectedRows.Count > 0 Then
            order = TryCast(dgvOrders.SelectedRows(0).Tag, KioskOrder)
        End If

        If order Is Nothing Then
            lblOrderNumber.Text = If(Orders.Count = 0, "No orders yet", "Select an order")
            lblOrderStatus.Text = If(Orders.Count = 0, "Place an order from the customer kiosk.", "")
            lblOrderTotal.Text = ""
            btnAdvance.Text = "UPDATE STATUS"
            btnAdvance.Enabled = False
            Return
        End If

        lblOrderNumber.Text = order.OrderNumber
        lblOrderStatus.Text = $"Status: {order.Status}   |   {order.PlacedAt:MMM d, h:mm tt}"
        lblOrderTotal.Text = $"Order total: ₱{order.Total:N2}"

        For Each item In order.Items
            dgvOrderItems.Rows.Add(item.ProductName, item.Quantity, item.UnitPrice * item.Quantity)
        Next

        btnAdvance.Enabled = order.Status <> OrderStatus.Completed
        Select Case order.Status
            Case OrderStatus.[New]
                btnAdvance.Text = "START PREPARING"
            Case OrderStatus.Preparing
                btnAdvance.Text = "MARK READY"
            Case OrderStatus.Ready
                btnAdvance.Text = "COMPLETE ORDER"
            Case OrderStatus.Completed
                btnAdvance.Text = "ORDER COMPLETED"
        End Select
    End Sub

    Private Sub btnAdvance_Click(sender As Object, e As EventArgs) Handles btnAdvance.Click
        If dgvOrders.SelectedRows.Count = 0 Then Return

        Dim row As DataGridViewRow = dgvOrders.SelectedRows(0)
        Dim order = TryCast(row.Tag, KioskOrder)
        If order Is Nothing Then Return

        Select Case order.Status
            Case OrderStatus.[New]
                order.Status = OrderStatus.Preparing
            Case OrderStatus.Preparing
                order.Status = OrderStatus.Ready
            Case OrderStatus.Ready
                order.Status = OrderStatus.Completed
            Case Else
                Return
        End Select

        row.Cells(colStatus.Index).Value = order.Status.ToString()
        ShowSelectedOrder()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub
End Class
