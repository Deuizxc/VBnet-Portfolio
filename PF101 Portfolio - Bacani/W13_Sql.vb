Public Class W13_Sql
    ' Dummy database for simulation
    Private mockDatabase As New DataTable("Payroll")

    ' MDI Navigation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Week13Selector.OpenChildForm(New W13_Database())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week13Selector.OpenChildForm(New W13_Memory())
    End Sub

    ' Hover Effects
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub W13_Sql_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' 1. Populate the left white box with stylized text
        LoadDocumentationText()

        ' 2. Initialize Mock Database (Matching Lecture Examples)
        InitializeMockDatabase()

        ' 3. Setup Dropdown
        cboScenario.Items.Add("1. Basic Data Retrieval (SELECT)")
        cboScenario.Items.Add("2. Calculated Columns & Aliases (AS)")
        cboScenario.Items.Add("3. Filtering Records (WHERE)")
        cboScenario.Items.Add("4. Sorting Records (ORDER BY DESC)")
        cboScenario.SelectedIndex = 0
    End Sub

    Private Sub LoadDocumentationText()

    End Sub

    Private Sub InitializeMockDatabase()
        mockDatabase.Columns.Add("ID", GetType(Integer))
        mockDatabase.Columns.Add("Last_Name", GetType(String))
        mockDatabase.Columns.Add("First_Name", GetType(String))
        mockDatabase.Columns.Add("hrsWorked", GetType(Integer))
        mockDatabase.Columns.Add("Rate", GetType(Decimal))

        mockDatabase.Rows.Add(104, "Niijima", "Makoto", 40, 20.5)
        mockDatabase.Rows.Add(114, "Kennedy", "Leon", 45, 25.0)
        mockDatabase.Rows.Add(115, "Magdua", "Vencel", 20, 15.0)
        mockDatabase.Rows.Add(120, "Furton", "Andrei", 50, 28.0)
    End Sub

    Private Sub cboScenario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboScenario.SelectedIndexChanged
        ' Update the SQL Terminal preview based on selection
        lblSqlTerminal.Text = ""
        Select Case cboScenario.SelectedIndex
            Case 0
                lblSqlTerminal.Text = "SELECT ID, Last_Name, Rate" & vbCrLf & "FROM Payroll"
            Case 1
                lblSqlTerminal.Text = "SELECT Last_Name," & vbCrLf & "(hrsWorked * Rate) AS payAmount" & vbCrLf & "FROM Payroll"
            Case 2
                lblSqlTerminal.Text = "SELECT Last_Name, hrsWorked," & vbCrLf & "(hrsWorked * Rate) AS payAmount" & vbCrLf & "FROM Payroll" & vbCrLf & "WHERE payAmount > 1000"
            Case 3
                lblSqlTerminal.Text = "SELECT Last_Name, Rate" & vbCrLf & "FROM Payroll" & vbCrLf & "ORDER BY Rate DESC"
        End Select

        ' Clear grid until they click execute
        dgvResults.DataSource = Nothing
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ' We clone the database structure to safely manipulate it for the simulation
        Dim dtSim As DataTable = mockDatabase.Copy()
        Dim dv As DataView = dtSim.DefaultView

        Select Case cboScenario.SelectedIndex
            Case 0 ' Basic Select
                dgvResults.DataSource = dv.ToTable(False, "ID", "Last_Name", "Rate")

            Case 1 ' Alias & Calculated Column
                dtSim.Columns.Add("payAmount", GetType(Decimal), "hrsWorked * Rate")
                dgvResults.DataSource = dtSim.DefaultView.ToTable(False, "Last_Name", "payAmount")

            Case 2 ' WHERE Clause (Over 1000)
                dtSim.Columns.Add("payAmount", GetType(Decimal), "hrsWorked * Rate")
                dv.RowFilter = "payAmount > 1000"
                dgvResults.DataSource = dv.ToTable(False, "Last_Name", "hrsWorked", "payAmount")

            Case 3 ' ORDER BY DESC
                dv.Sort = "Rate DESC"
                dgvResults.DataSource = dv.ToTable(False, "Last_Name", "Rate")
        End Select

        ' Format UI of DataGrid
        dgvResults.ClearSelection()
    End Sub
End Class