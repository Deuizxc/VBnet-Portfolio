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

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim repForm As New FPsalesreport()
        repForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnKiosk.MouseEnter, btnInventory.MouseEnter, btnReports.MouseEnter, btnClose.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnKiosk.MouseLeave, btnInventory.MouseLeave, btnReports.MouseLeave, btnClose.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
End Class