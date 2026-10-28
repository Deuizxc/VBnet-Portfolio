Public Class W2_Classes

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week2Selector.Show()
        Week2Selector.Update()
        Me.Hide()
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.Red
        Button7.Top -= 3
        Button7.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black
        Button7.Top += 3
        Button7.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        W2_Encapsulation.Show()
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Left -= 4
        Button2.Cursor = Cursors.Default
    End Sub

    Private Sub W2_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Title
        RichTextBox1.SelectionFont = titleFont
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("[ CLASSES & OBJECTS ]" & vbCrLf & vbCrLf)

        ' Bullet 1: Class Definition
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("• ")
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Class (Blueprint): ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("The design template defining attributes and actions. Holds ")
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("no memory ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("on its own." & vbCrLf & vbCrLf)

        ' Bullet 2: Object Definition
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("• ")
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("Object (Instance): ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("The living instance allocated in RAM via the ")
        RichTextBox1.SelectionFont = kwFont
        RichTextBox1.SelectionColor = blueColor
        RichTextBox1.AppendText("New ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("keyword to store actual data values." & vbCrLf & vbCrLf)

        ' Bullet 3: State & Behavior
        RichTextBox1.SelectionFont = labelFont
        RichTextBox1.SelectionColor = darkColor
        RichTextBox1.AppendText("• ")
        RichTextBox1.SelectionColor = redColor
        RichTextBox1.AppendText("State vs Behavior: ")
        RichTextBox1.SelectionFont = bodyFont
        RichTextBox1.SelectionColor = bodyColor
        RichTextBox1.AppendText("Variables store the state; methods define the behavior.")
    End Sub

End Class