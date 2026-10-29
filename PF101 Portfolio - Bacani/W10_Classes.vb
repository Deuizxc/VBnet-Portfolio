Imports System.Text.RegularExpressions

Public Class W10_Classes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
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
        Try
            Week10Selector.OpenChildForm(New W10_Errors())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W10_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnInstantiate_Click(sender As Object, e As EventArgs) Handles btnInstantiate.Click
        Try
            Dim engine As Integer
            Dim wheels As Integer

            If Not Integer.TryParse(txtEngine.Text, engine) OrElse Not Integer.TryParse(txtWheels.Text, wheels) Then
                rtbOutput.Clear()
                rtbOutput.SelectionColor = Color.Red
                rtbOutput.AppendText("> ERROR: Initialization Failed!" & vbCrLf)
                rtbOutput.AppendText("> Please input valid numeric values for Engine and Wheels.")
                Exit Sub
            End If

            Dim myCar As New Car(engine, wheels)

            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("Object Memory Instance" & vbCrLf)
            rtbOutput.AppendText("----------------------" & vbCrLf)

            rtbOutput.SelectionColor = Color.LimeGreen
            rtbOutput.AppendText("Status: Active" & vbCrLf)

            rtbOutput.SelectionColor = Color.Cyan
            rtbOutput.AppendText("Type: PF101.Car" & vbCrLf)
            rtbOutput.AppendText("Base: PF101.Vehicle" & vbCrLf)

            rtbOutput.SelectionColor = Color.Gold
            rtbOutput.AppendText("DisplayWheelCount() -> " & myCar.DisplayWheelCount().ToString() & vbCrLf)
            rtbOutput.AppendText("DisplayEngineSize() -> " & myCar.DisplayEngineSize().ToString() & "cc")
        Catch ex As Exception
            rtbOutput.Text = "> ERROR: " & ex.Message
        End Try
    End Sub

    Private Sub btnInstantiate_MouseEnter(sender As Object, e As EventArgs) Handles btnInstantiate.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub btnInstantiate_MouseLeave(sender As Object, e As EventArgs) Handles btnInstantiate.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub FormatRichText(rtb As RichTextBox)
        Try
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
            rtb.SuspendLayout()
            Dim origStart As Integer = rtb.SelectionStart
            Dim origLen As Integer = rtb.SelectionLength

            rtb.SelectAll()
            rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Regular)
            If rtb.BackColor = Color.Black Then
                rtb.SelectionColor = Color.White
            Else
                rtb.SelectionColor = Color.FromArgb(40, 40, 40)
            End If

            Dim mc1 As MatchCollection = Regex.Matches(rtb.Text, "\[.*?\]")
            For Each m As Match In mc1
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 13.0F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•)\s+[^:\r\n]+:")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|Function|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|ByVal|ByRef|Step|Inherits|MustInherit|MyBase|Try|Catch|Finally|Exception)\b"
            Dim mc3 As MatchCollection = Regex.Matches(rtb.Text, kw)
            For Each m As Match In mc3
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(0, 70, 190)
            Next

            rtb.Select(origStart, origLen)
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub
End Class

Public MustInherit Class Vehicle
    Private Property _numberOfWheels As Integer
    Private Property _engineSize As Integer

    Public Sub New(engineSize As Integer, wheels As Integer)
        _numberOfWheels = wheels
        _engineSize = engineSize
    End Sub

    Public Function DisplayWheelCount() As Integer
        Return _numberOfWheels
    End Function

    Public Function DisplayEngineSize() As Integer
        Return _engineSize
    End Function
End Class

Public Class Car
    Inherits Vehicle
    Public Sub New(engineSize As Integer, wheels As Integer)
        MyBase.New(engineSize, wheels)
    End Sub
End Class