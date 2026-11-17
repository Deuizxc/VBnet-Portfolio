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

    Private Sub StyleDashboardMenu(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim firstStaffSlot As Integer = Math.Min(btnOrders.Top, btnInventory.Top)
        Dim secondStaffSlot As Integer = Math.Max(btnOrders.Top, btnInventory.Top)
        btnOrders.Top = firstStaffSlot
        btnInventory.Top = secondStaffSlot

        StyleMenuButton(btnKiosk, "Start Order", "▶", isPrimary:=True)
        StyleMenuButton(btnOrders, "Order Queue", "☷")
        StyleMenuButton(btnInventory, "Manage Inventory", "▣")
        StyleMenuButton(btnReports, "Sales Reports", "▥")
        StyleMenuButton(btnClose, "Exit", "↪", isExit:=True)

        btnKiosk.TabIndex = 0
        btnOrders.TabIndex = 1
        btnInventory.TabIndex = 2
        btnReports.TabIndex = 3
        btnClose.TabIndex = 4

        Dim exitWidth As Integer = CInt(btnReports.Width * 0.34)
        Dim exitHeight As Integer = CInt(btnReports.Height * 0.66)
        btnClose.Size = New Size(exitWidth, exitHeight)
        btnClose.Left = btnReports.Right - exitWidth
        btnClose.Top = btnReports.Bottom + CInt(btnReports.Height * 0.44)
    End Sub

    Private Sub StyleMenuButton(button As Button,
                                caption As String,
                                symbol As String,
                                Optional isPrimary As Boolean = False,
                                Optional isExit As Boolean = False)
        Dim crimson As Color = Color.FromArgb(190, 22, 49)
        Dim menuFont As New Font("Segoe UI", If(isPrimary, 13.0F, 11.0F), FontStyle.Bold)
        Dim icon As Bitmap = CreateMenuIcon(symbol, If(isPrimary, Color.White, Color.Gainsboro))

        button.Text = caption
        button.Font = menuFont
        button.ForeColor = If(isExit, Color.Gainsboro, Color.White)
        button.BackColor = If(isPrimary, crimson, Color.FromArgb(22, 22, 24))
        button.FlatStyle = FlatStyle.Flat
        button.UseVisualStyleBackColor = False
        button.Cursor = Cursors.Hand
        button.Padding = New Padding(16, 0, 12, 0)

        button.FlatAppearance.BorderSize = 1
        button.FlatAppearance.BorderColor = If(isPrimary, crimson, Color.FromArgb(84, 47, 53))
        button.FlatAppearance.MouseOverBackColor =
            If(isPrimary, Color.FromArgb(211, 34, 61), Color.FromArgb(42, 30, 34))
        button.FlatAppearance.MouseDownBackColor =
            If(isPrimary, Color.FromArgb(154, 16, 37), Color.FromArgb(54, 31, 38))

        button.ImageAlign = ContentAlignment.MiddleLeft
        button.TextAlign = ContentAlignment.MiddleLeft
        button.TextImageRelation = TextImageRelation.ImageBeforeText
        button.Image = icon

        AddHandler button.Disposed,
            Sub(disposedSender, disposedArgs)
                icon.Dispose()
                menuFont.Dispose()
            End Sub

        If Not isPrimary AndAlso Not isExit Then
            AddHandler button.Paint,
                Sub(paintSender, paintArgs)
                    Using accent As New SolidBrush(crimson)
                        paintArgs.Graphics.FillRectangle(accent, 1, 1, 4, button.ClientSize.Height - 2)
                    End Using
                End Sub
        End If
    End Sub

    Private Function CreateMenuIcon(symbol As String, ink As Color) As Bitmap
        Dim icon As New Bitmap(30, 24)

        Using canvas As Graphics = Graphics.FromImage(icon),
              symbolFont As New Font("Segoe UI Symbol", 12.0F, FontStyle.Regular),
              brush As New SolidBrush(ink),
              alignment As New StringFormat()

            canvas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            alignment.Alignment = StringAlignment.Center
            alignment.LineAlignment = StringAlignment.Center
            canvas.DrawString(symbol, symbolFont, brush, New RectangleF(0, 0, 22, 24), alignment)
        End Using

        Return icon
    End Function
End Class
