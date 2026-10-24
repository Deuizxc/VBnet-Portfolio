Public Class W10_Handling
    ' RETURN BUTTON
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

    ' PREVIOUS BUTTON (Swaps to previous MDI Child)
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week10Selector.OpenChildForm(New W10_Errors())
    End Sub

    Private Sub W10_Handling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' Populate the demo combobox
        cboOp.Items.Clear()
        cboOp.Items.Add("1. Valid Math Operation (100 / 2)")
        cboOp.Items.Add("2. Divide by Zero (100 / 0)")
        cboOp.Items.Add("3. Uninitialized Object (Null Reference)")
        cboOp.SelectedIndex = 0

        rtbOutput.Text = "> Awaiting execution trace..."
    End Sub

    ' This tag forces Visual Studio's debugger to ignore the errors and let the Catch blocks handle them!
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        rtbOutput.Clear()
        rtbOutput.SelectionColor = Color.White
        rtbOutput.AppendText("Initiating Try Structure..." & vbCrLf & vbCrLf)

        Try
            ' 1. THE TRY BLOCK
            rtbOutput.SelectionColor = Color.DodgerBlue
            rtbOutput.AppendText("[ACTIVE] TRY:" & vbCrLf)
            rtbOutput.AppendText(" -> Attempting operation..." & vbCrLf)

            If cboOp.SelectedIndex = 0 Then
                ' Valid Execution
                Dim result As Integer = 100 / 2
                rtbOutput.AppendText(" -> Success: Result is " & result & vbCrLf & vbCrLf)

            ElseIf cboOp.SelectedIndex = 1 Then
                ' Triggers a DivideByZeroException using variables to bypass compiler checks
                Dim zero As Integer = 0
                Dim result As Integer = 100 \ zero

            ElseIf cboOp.SelectedIndex = 2 Then
                ' Triggers a NullReferenceException
                Dim dummyObj As Control = Nothing
                Dim temp As String = dummyObj.Name
            End If

        Catch ex As DivideByZeroException
            ' 2A. SPECIFIC CATCH BLOCK
            rtbOutput.SelectionColor = Color.Orange
            rtbOutput.AppendText(vbCrLf & "[CAUGHT] CATCH (DivideByZero):" & vbCrLf)
            rtbOutput.AppendText(" -> " & ex.Message & vbCrLf & vbCrLf)

        Catch ex As NullReferenceException
            ' 2B. SPECIFIC CATCH BLOCK
            rtbOutput.SelectionColor = Color.Orange
            rtbOutput.AppendText(vbCrLf & "[CAUGHT] CATCH (NullReference):" & vbCrLf)
            rtbOutput.AppendText(" -> " & ex.Message & vbCrLf & vbCrLf)

        Catch ex As Exception
            ' 2C. GENERIC CATCH BLOCK
            rtbOutput.SelectionColor = Color.Red
            rtbOutput.AppendText(vbCrLf & "[CAUGHT] CATCH (Generic Exception):" & vbCrLf)
            rtbOutput.AppendText(" -> " & ex.Message & vbCrLf & vbCrLf)

        Finally
            ' 3. THE FINALLY BLOCK
            rtbOutput.SelectionColor = Color.LimeGreen
            rtbOutput.AppendText("[ACTIVE] FINALLY:" & vbCrLf)
            rtbOutput.AppendText(" -> Cleaning up resources..." & vbCrLf)
            rtbOutput.AppendText(" -> Execution cycle completed.")
        End Try
    End Sub
End Class