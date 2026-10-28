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
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        Label1.Text = "Choose an action"
        LoadDocumentationText()
    End Sub

    Private Sub LoadDocumentationText()
        Try
            RichTextBox2.Clear()

            Dim titleFont As New Font("Segoe UI", 9.5F, FontStyle.Bold)
            Dim labelFont As New Font("Segoe UI", 8.5F, FontStyle.Bold)
            Dim bodyFont As New Font("Segoe UI", 8.5F, FontStyle.Regular)
            Dim kwFont As New Font("Consolas", 8.5F, FontStyle.Bold)

            Dim redColor As Color = Color.FromArgb(190, 20, 20)
            Dim blueColor As Color = Color.FromArgb(0, 70, 190)
            Dim darkColor As Color = Color.FromArgb(20, 20, 20)
            Dim bodyColor As Color = Color.FromArgb(50, 50, 50)

            ' Header
            RichTextBox2.SelectionFont = titleFont
            RichTextBox2.SelectionColor = redColor
            RichTextBox2.AppendText("[ POLYMORPHISM ]" & vbCrLf & vbCrLf)

            ' Point 1
            RichTextBox2.SelectionFont = labelFont
            RichTextBox2.SelectionColor = darkColor
            RichTextBox2.AppendText("1. Many Forms:" & vbCrLf)
            RichTextBox2.SelectionFont = bodyFont
            RichTextBox2.SelectionColor = bodyColor
            RichTextBox2.AppendText("The ability of distinct derived objects to respond to the same method invocation with custom implementations." & vbCrLf & vbCrLf)

            ' Point 2
            RichTextBox2.SelectionFont = labelFont
            RichTextBox2.SelectionColor = darkColor
            RichTextBox2.AppendText("2. Overridable vs Overrides:" & vbCrLf)
            RichTextBox2.SelectionFont = bodyFont
            RichTextBox2.SelectionColor = bodyColor
            RichTextBox2.AppendText("• Base method marked ")
            RichTextBox2.SelectionFont = kwFont
            RichTextBox2.SelectionColor = blueColor
            RichTextBox2.AppendText("Overridable")
            RichTextBox2.SelectionFont = bodyFont
            RichTextBox2.SelectionColor = bodyColor
            RichTextBox2.AppendText("." & vbCrLf)
            RichTextBox2.AppendText("• Subclass replaces it with ")
            RichTextBox2.SelectionFont = kwFont
            RichTextBox2.SelectionColor = blueColor
            RichTextBox2.AppendText("Overrides")
            RichTextBox2.SelectionFont = bodyFont
            RichTextBox2.SelectionColor = bodyColor
            RichTextBox2.AppendText("." & vbCrLf & vbCrLf)

            ' Point 3
            RichTextBox2.SelectionFont = labelFont
            RichTextBox2.SelectionColor = darkColor
            RichTextBox2.AppendText("3. Dynamic Method Binding:" & vbCrLf)
            RichTextBox2.SelectionFont = bodyFont
            RichTextBox2.SelectionColor = bodyColor
            RichTextBox2.AppendText("Even when treated as a generic ")
            RichTextBox2.SelectionFont = kwFont
            RichTextBox2.SelectionColor = redColor
            RichTextBox2.AppendText("Animal")
            RichTextBox2.SelectionFont = bodyFont
            RichTextBox2.SelectionColor = bodyColor
            RichTextBox2.AppendText(", the runtime executes the actual type's sound.")
        Catch ex As Exception
            ' Fallback to avoid crashing the form instantiation if GDI/RichEdit fails
        End Try
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

' Helper classes MUST remain below the Form class
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