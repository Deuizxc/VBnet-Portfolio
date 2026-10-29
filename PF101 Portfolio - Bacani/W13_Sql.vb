Imports System.Text.RegularExpressions

Public Class W13_Sql

    Private mockDatabase As New DataTable("Payroll")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week13Selector.OpenChildForm(New W13_Database())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Week13Selector.OpenChildForm(New W13_Memory())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter
        Try
            Dim btn = DirectCast(sender, Button)
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent
            btn.Top -= 3
            btn.Cursor = Cursors.Hand
            If btn.Name = "Button1" Then btn.ForeColor = Color.Red
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Try
            Dim btn = DirectCast(sender, Button)
            btn.Top += 3
            btn.Cursor = Cursors.Default
            If btn.Name = "Button1" Then btn.ForeColor = Color.Black
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W13_Sql_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            FormatRichText(RichTextBox1)
            InitializeMockDatabase()
            cboScenario.Items.Add("1. Basic Data Retrieval (SELECT)")
            cboScenario.Items.Add("2. Calculated Columns & Aliases (AS)")
            cboScenario.Items.Add("3. Filtering Records (WHERE)")
            cboScenario.Items.Add("4. Sorting Records (ORDER BY DESC)")
            cboScenario.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InitializeMockDatabase()
        Try
            mockDatabase.Columns.Add("ID", GetType(Integer))
            mockDatabase.Columns.Add("Last_Name", GetType(String))
            mockDatabase.Columns.Add("First_Name", GetType(String))
            mockDatabase.Columns.Add("hrsWorked", GetType(Integer))
            mockDatabase.Columns.Add("Rate", GetType(Decimal))

            mockDatabase.Rows.Add(104, "Niijima", "Makoto", 40, 20.5)
            mockDatabase.Rows.Add(114, "Kennedy", "Leon", 45, 25.0)
            mockDatabase.Rows.Add(115, "Magdua", "Vencel", 20, 15.0)
            mockDatabase.Rows.Add(120, "Furton", "Andrei", 50, 28.0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboScenario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboScenario.SelectedIndexChanged
        Try
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
            dgvResults.DataSource = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Try
            Dim dtSim As DataTable = mockDatabase.Copy()
            Dim dv As DataView = dtSim.DefaultView

            Select Case cboScenario.SelectedIndex
                Case 0
                    dgvResults.DataSource = dv.ToTable(False, "ID", "Last_Name", "Rate")
                Case 1
                    dtSim.Columns.Add("payAmount", GetType(Decimal), "hrsWorked * Rate")
                    dgvResults.DataSource = dtSim.DefaultView.ToTable(False, "Last_Name", "payAmount")
                Case 2
                    dtSim.Columns.Add("payAmount", GetType(Decimal), "hrsWorked * Rate")
                    dv.RowFilter = "payAmount > 1000"
                    dgvResults.DataSource = dv.ToTable(False, "Last_Name", "hrsWorked", "payAmount")
                Case 3
                    dv.Sort = "Rate DESC"
                    dgvResults.DataSource = dv.ToTable(False, "Last_Name", "Rate")
            End Select
            dgvResults.ClearSelection()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExecute_MouseEnter(sender As Object, e As EventArgs) Handles btnExecute.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub btnExecute_MouseLeave(sender As Object, e As EventArgs) Handles btnExecute.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub FormatRichText(rtb As RichTextBox)
        Try
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
            rtb.SuspendLayout()

            rtb.SelectAll()
            rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Regular)
            If rtb.BackColor = Color.Black Then
                rtb.SelectionColor = Color.White
            Else
                rtb.SelectionColor = Color.FromArgb(40, 40, 40)
            End If

            Dim redColor As Color = Color.FromArgb(190, 20, 20)
            Dim blueColor As Color = Color.FromArgb(0, 70, 190)
            Dim titleFont As New Font("Segoe UI", 13.0F, FontStyle.Bold)
            Dim boldFont As New Font("Segoe UI", 11.25F, FontStyle.Bold)

            Dim mc1 As MatchCollection = Regex.Matches(rtb.Text, "\[.*?\]")
            Dim startPos1 As Integer = 0
            For Each m As Match In mc1
                Dim pos As Integer = rtb.Find(m.Value, startPos1, RichTextBoxFinds.None)
                If pos <> -1 Then
                    rtb.Select(pos, m.Value.Length)
                    rtb.SelectionFont = titleFont
                    rtb.SelectionColor = redColor
                    startPos1 = pos + m.Value.Length
                End If
            Next

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•|\-)\s*[^:\r\n]+:")
            Dim startPos2 As Integer = 0
            For Each m As Match In mc2
                Dim searchStr As String = m.Value.Replace(vbCr, "").Replace(vbLf, "")
                Dim pos As Integer = rtb.Find(searchStr, startPos2, RichTextBoxFinds.None)
                If pos <> -1 Then
                    rtb.Select(pos, searchStr.Length)
                    rtb.SelectionFont = boldFont
                    rtb.SelectionColor = redColor
                    startPos2 = pos + searchStr.Length
                End If
            Next

            Dim kw() As String = {"Class", "Sub", "Function", "End", "Private", "Public", "Handles", "Dim", "As", "String", "Integer", "Double", "Decimal", "If", "ElseIf", "Else", "Then", "Return", "True", "False", "Const", "Select", "Case", "Mod", "Do", "While", "Until", "Loop", "For", "Next", "To", "Boolean", "Char", "Byte", "Long", "Short", "New", "ByVal", "ByRef", "Step", "Inherits", "MustInherit", "MyBase", "Try", "Catch", "Finally", "Exception", "UCase", "Trim", "StrReverse", "FormatCurrency", "Imports", "Module", "using", "class", "static", "void", "string", "import", "public", "main", "SELECT", "FROM", "WHERE", "ORDER", "BY", "DESC", "AS"}
            For Each word In kw
                Dim pos As Integer = 0
                Do
                    pos = rtb.Find(word, pos, RichTextBoxFinds.WholeWord Or RichTextBoxFinds.MatchCase)
                    If pos <> -1 Then
                        rtb.Select(pos, word.Length)
                        If rtb.SelectionColor <> redColor Then
                            rtb.SelectionFont = boldFont
                            rtb.SelectionColor = blueColor
                        End If
                        pos += word.Length
                    End If
                Loop While pos <> -1
            Next

            rtb.Select(0, 0)
            rtb.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub
End Class