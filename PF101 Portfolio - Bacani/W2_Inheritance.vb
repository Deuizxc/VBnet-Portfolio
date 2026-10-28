Public Class W2_Inheritance

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
        W2_Encapsulation.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        W2_Polymorphism.Show()
    End Sub

    Private Sub W2_Inheritance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        LoadDocumentationText()
    End Sub

    Private Sub LoadDocumentationText()
        RichTextBox1.Clear()

        Dim titleFont As New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Dim labelFont As New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Dim bodyFont As New Font("Segoe UI", 8.5F, FontStyle.Regular)
        Dim kwFont As New Font("Consolas", 8.5F, FontStyle.Bold)

        Dim redColor As Color = Color.FromArgb(190, 20, 20)
        Dim blueColor As Color = Color.FromArgb(0, 70, 190)
        Dim darkColor As Color = Color.FromArgb(20, 20, 20)
        Dim bodyColor As Color = Color.FromArgb(50, 50, 50)

        ' Header
        RichTextBox1.SelectionFont = titleFont
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("[ INHERITANCE ]" & vbCrLf & vbCrLf)

        ' Bullet 1: Base Class
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("• ")
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Base Class (Parent): ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Defines shared attributes and general behaviors common to all subclasses." & vbCrLf & vbCrLf)

        ' Bullet 2: Derived Class
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("• ")
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Derived Class (Child): ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Reuses logic using the ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = blueColor
        RichTextBox1.AppendText("Inherits ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("clause without re-writing code." & vbCrLf & vbCrLf)

        ' Bullet 3: Protected Modifier
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("• ")
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Protected Modifier: ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Restricts visibility to the base class and its descendants only.")
    End Sub

End Class