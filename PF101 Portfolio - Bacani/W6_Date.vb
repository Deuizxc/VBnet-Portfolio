Public Class W6_Date
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week6Selector.Show()
        Week6Selector.Update()
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        W6_Repeat.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = DateTime.Now.ToString("hh:mm tt dddd, dd MMMM yyyy")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pickedDate As Date = DateTimePicker1.Value
        Dim currentDate As Date = DateTime.Now

        ' DatePart extraction
        Dim weekNum As Long = DatePart(DateInterval.WeekOfYear, pickedDate)
        Label2.Text = "Week of Year: " & weekNum.ToString()

        ' DateDiff calculation
        Dim diff As Long = DateDiff(DateInterval.Month, pickedDate, currentDate)
        Label3.Text = "Difference in Months: " & Math.Abs(diff).ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "Click below to fetch system time"
        Label2.Text = "Week of Year: -"
        Label3.Text = "Difference in Months: -"
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub
    Private Sub W6_Date_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
End Class