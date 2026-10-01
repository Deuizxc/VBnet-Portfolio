Imports System.Reflection.Emit
Imports System.Windows

Public Class Lessons
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Week2Selector.Show()
        Week2Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Portfolio.Show()
        Portfolio.Update()
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.Left -= 2
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.Left += 2
        Button7.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Week3Selector.Show()
        Week3Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Week4Selector.Show()
        Week4Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Week5Selector.Show()
        Week5Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week6Selector.Show()
        Week6Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Week7Selector.Show()
        Week7Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Week8Selector.Show()
        Week8Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Week9Selector.Show()
        Week9Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Week10Selector.Show()
        Week10Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Week11_12Selector.Show()
        Week11_12Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Week13Selector.Show()
        Week13Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Week14_15Selector.Show()
        Week14_15Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
        AudioManager.AttachSounds(Me)

        GetType(FlowLayoutPanel).InvokeMember("DoubleBuffered",
            Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.SetProperty,
            Nothing, FlowLayoutPanel1, New Object() {True})
    End Sub

    Private Sub LessonButton_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter, Button6.MouseEnter, Button8.MouseEnter, Button9.MouseEnter, Button10.MouseEnter, Button11.MouseEnter, Button12.MouseEnter, Button13.MouseEnter, Button14.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.Margin = New Padding(3, 0, 3, 6)
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub LessonButton_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave, Button8.MouseLeave, Button9.MouseLeave, Button10.MouseLeave, Button11.MouseLeave, Button12.MouseLeave, Button13.MouseLeave, Button14.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.Margin = New Padding(3, 3, 3, 3)
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Level1.Show()
        Level1.Update()
        Hide()
    End Sub
End Class