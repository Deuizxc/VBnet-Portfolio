Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class FPcheckout
    Public Sub New()
        InitializeComponent()
        cmbOrderType.Items.AddRange(New Object() {"Dine In", "Takeout"})
        cmbOrderType.SelectedIndex = 0
        cmbPaymentMethod.Items.Add(KioskDatabase.PayAtCounter)
        cmbPaymentMethod.SelectedIndex = 0
    End Sub

    Friend ReadOnly Property PaymentMethod As String
        Get
            Return CStr(cmbPaymentMethod.SelectedItem)
        End Get
    End Property

    Friend ReadOnly Property DiningOption As String
        Get
            Return CStr(cmbOrderType.SelectedItem)
        End Get
    End Property

    Friend Sub SetOrder(items As List(Of KioskDatabase.OrderLine))
        dgvReview.Rows.Clear()
        Dim subtotal As Decimal = 0D
        For Each item In items
            Dim amount = item.UnitPrice * item.Quantity
            dgvReview.Rows.Add(item.ProductName, item.Quantity, amount)
            subtotal += amount
        Next
        Dim tax = KioskDatabase.CalculateTax(subtotal)
        lblBreakdown.Text = $"Subtotal ₱{subtotal:N2}  +  Tax ₱{tax:N2}"
        lblTotal.Text = $"Total: ₱{subtotal + tax:N2}"
    End Sub
End Class
