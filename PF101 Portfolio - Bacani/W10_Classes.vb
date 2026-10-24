Public Class W10_Classes
    ' RETURN BUTTON (Closes the MDI Child)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    ' CONTINUE BUTTON (Swaps to next MDI Child)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week10Selector.OpenChildForm(New W10_Errors())
    End Sub

    Private Sub W10_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub btnInstantiate_Click(sender As Object, e As EventArgs) Handles btnInstantiate.Click
        Try
            Dim engine As Integer = Integer.Parse(txtEngine.Text)
            Dim wheels As Integer = Integer.Parse(txtWheels.Text)

            ' Instantiating object from inherited abstract class structure
            Dim myCar As New Car(engine, wheels)

            rtbOutput.Clear()
            rtbOutput.AppendText("Object Memory Instance" & vbCrLf)
            rtbOutput.AppendText("----------------------" & vbCrLf)
            rtbOutput.AppendText("Status: Active" & vbCrLf)
            rtbOutput.AppendText("Type: PF101.Car" & vbCrLf)
            rtbOutput.AppendText("Base: PF101.Vehicle" & vbCrLf)
            rtbOutput.AppendText("DisplayWheelCount() -> " & myCar.DisplayWheelCount().ToString() & vbCrLf)
            rtbOutput.AppendText("DisplayEngineSize() -> " & myCar.DisplayEngineSize().ToString() & "cc")
        Catch ex As Exception
            rtbOutput.Text = "> ERROR: Invalid numeric input!"
        End Try
    End Sub
End Class

' Abstract Base Class implementing MustInherit and Sub New constructor
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

' Derived Class inheriting Vehicle
Public Class Car
    Inherits Vehicle
    Public Sub New(engineSize As Integer, wheels As Integer)
        MyBase.New(engineSize, wheels)
    End Sub
End Class