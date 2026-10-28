Public Class W1415_Database
    ' MDI Navigation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week14_15Selector.OpenChildForm(New W1415_Row())
    End Sub

    ' Hover Effects
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub W1415_Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        cboKeyType.Items.Add("Use Identity Columns (Local)")
        cboKeyType.Items.Add("Use GUID Identifiers (Global)")
        cboKeyType.SelectedIndex = 0
    End Sub

    ' --- SYNCHRONIZATION DISPATCHER LOGIC ---
    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        rtbTerminal.Clear()

        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("Target: CustomerOrders Table" & vbCrLf)
        rtbTerminal.AppendText("Executing DataAdapter.Update()..." & vbCrLf & vbCrLf)

        ' 1. Process Deletes First
        rtbTerminal.SelectionColor = Color.DodgerBlue
        rtbTerminal.AppendText("[1] Resolving DataViewRowState.Deleted" & vbCrLf)
        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("-> Executing ")
        rtbTerminal.SelectionColor = Color.Orange
        rtbTerminal.AppendText("DeleteCommand ")
        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("on Row 1..." & vbCrLf)
        rtbTerminal.AppendText("-> Record removed." & vbCrLf & vbCrLf)

        ' 2. Process Inserts Next
        rtbTerminal.SelectionColor = Color.DodgerBlue
        rtbTerminal.AppendText("[2] Resolving DataViewRowState.Added" & vbCrLf)
        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("-> Executing ")
        rtbTerminal.SelectionColor = Color.Orange
        rtbTerminal.AppendText("InsertCommand ")
        rtbTerminal.SelectionColor = Color.White
        rtbTerminal.AppendText("for New Record..." & vbCrLf)

        ' Key Generation Logic
        rtbTerminal.AppendText("-> Fetching Key via UpdateRowSource.")
        rtbTerminal.SelectionColor = Color.Gold
        rtbTerminal.AppendText("FirstReturnedRecord" & vbCrLf)

        rtbTerminal.SelectionColor = Color.LimeGreen
        If cboKeyType.SelectedIndex = 0 Then
            ' Identity Column Simulation
            rtbTerminal.AppendText("-> Success! Assigned Identity ID: 1042" & vbCrLf & vbCrLf)
        Else
            ' GUID Simulation
            Dim newGuid As Guid = Guid.NewGuid()
            rtbTerminal.AppendText("-> Success! Assigned GUID:" & vbCrLf)
            rtbTerminal.AppendText("-> " & newGuid.ToString().ToUpper() & vbCrLf & vbCrLf)
        End If

        rtbTerminal.SelectionColor = Color.DodgerBlue
        rtbTerminal.AppendText("[3] SYNC COMPLETE.")

        ' Scroll to bottom
        rtbTerminal.SelectionStart = rtbTerminal.Text.Length
        rtbTerminal.ScrollToCaret()
    End Sub
End Class