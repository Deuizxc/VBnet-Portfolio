Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class FPdashboard
    Private Sub FPdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Private Sub btnKiosk_Click(sender As Object, e As EventArgs) Handles btnKiosk.Click
        Dim kioskForm As New FPkiosk()
        kioskForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim invForm As New FPinventory()
        invForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Using ordersForm As New FPorders()
            ordersForm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim repForm As New FPsalesreport()
        repForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class
