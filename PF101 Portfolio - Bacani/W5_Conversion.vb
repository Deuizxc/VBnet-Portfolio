Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class W5_Conversion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week5Selector.Show()
        Week5Selector.Update()
        Me.Hide()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.Top -= 3
        Button1.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.Top += 3
        Button1.Cursor = Cursors.Default
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        W5_Operator.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W5_Scope.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInputNumber.TextChanged

    End Sub

    Private Sub btnConvertTest_Click(sender As Object, e As EventArgs) Handles btnConvertTest.Click
        If String.IsNullOrWhiteSpace(txtInputNumber.Text) Then Exit Sub

        Dim rawDecimal As Decimal = Decimal.Parse(txtInputNumber.Text)
        lblParsed.Text = "// Parsed (Decimal): " & rawDecimal.ToString("F2")

        Dim roundedInt As Integer = Convert.ToInt32(rawDecimal)
        lblIntConverted.Text = "// Convert.ToInt32: " & roundedInt.ToString() & " (Rounded)"

        Dim widenedDouble As Double = roundedInt
        lblDoubleImplicit.Text = "// Implicit (Double): " & widenedDouble.ToString("F1")
    End Sub
    Private Sub btnConverTest_MouseEnter(sender As Object, e As EventArgs) Handles btnConvertTest.MouseEnter
        btnConvertTest.Top -= 3
        btnConvertTest.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnConvertTest.MouseLeave
        btnConvertTest.Top += 3
        btnConvertTest.Cursor = Cursors.Default
    End Sub
    Private Sub W5_Conversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class