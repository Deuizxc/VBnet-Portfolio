Public Class W2_Polymorphism


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Week2Selector.Show()
        Week2Selector.Update()
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        W2_Interfaces.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        W2_Inheritance.Show()
    End Sub

    Private Sub W2_Polymorphism_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Choose an action"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myPet As Animal = New Cat()
        Label1.Text = "Morgana says: " & myPet.MakeSound()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myPet As Animal = New Dog()
        Label1.Text = "Koromaru says: " & myPet.MakeSound()

    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.Red
        Button4.Top -= 3
        Button4.Cursor = Cursors.Hand
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
        Button4.Top += 3
        Button4.Cursor = Cursors.Default
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.Red
        Button5.Top -= 3
        Button5.Cursor = Cursors.Hand
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Black
        Button5.Top += 3
        Button5.Cursor = Cursors.Default
    End Sub


End Class



Public Class Animal
    Public Overridable Function MakeSound() As String
        Return "Some generic sound"
    End Function
End Class

Public Class Cat
    Inherits Animal
    Public Overrides Function MakeSound() As String
        Return "Meow, meooow!"
    End Function
End Class

Public Class Dog
    Inherits Animal
    Public Overrides Function MakeSound() As String
        Return "Arf! Arf!"
    End Function

End Class