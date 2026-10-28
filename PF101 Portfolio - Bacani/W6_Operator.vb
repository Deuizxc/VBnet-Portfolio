Imports System.Text.RegularExpressions

Public Class W6_Operator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week6Selector.Show()
            Week6Selector.Update()
        Catch ex As Exception
            Dim w6 As New Week6Selector()
            w6.Show()
            w6.Update()
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
        Hide()
        Try
            W6_Classes.Show()
        Catch ex As Exception
            Dim frm As New W6_Classes()
            frm.Show()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Try
            W6_Selection.Show()
        Catch ex As Exception
            Dim frm As New W6_Selection()
            frm.Show()
        End Try
    End Sub

    Private Sub W6_Operator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        With dgvTruthTable
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromArgb(15, 15, 15)
            .GridColor = Color.FromArgb(50, 50, 50)
            .BorderStyle = BorderStyle.FixedSingle
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 20, 20)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 34
            .DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 35, 35)
            .DefaultCellStyle.SelectionForeColor = Color.White
            .RowTemplate.Height = 34
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

        radAnd.Checked = True
        BuildTruthTable()
        FormatRichText(RichTextBox1)
    End Sub

    Private Sub Operator_CheckedChanged(sender As Object, e As EventArgs) Handles radAnd.CheckedChanged, radOr.CheckedChanged, radXor.CheckedChanged, radNot.CheckedChanged
        Dim rad = TryCast(sender, RadioButton)
        If rad IsNot Nothing AndAlso rad.Checked Then
            BuildTruthTable()
        End If
    End Sub

    Private Sub BuildTruthTable()
        dgvTruthTable.Columns.Clear()
        dgvTruthTable.Rows.Clear()

        If radNot.Checked Then
            dgvTruthTable.Columns.Add("colExp", "Expression")
            dgvTruthTable.Columns.Add("colRes", "Not Expr")
            dgvTruthTable.RowTemplate.Height = 44

            For Each col As DataGridViewColumn In dgvTruthTable.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

            Dim states() As Boolean = {True, False}
            For Each stateItem As Boolean In states
                Dim res As Boolean = Not stateItem
                Dim rowIndex As Integer = dgvTruthTable.Rows.Add(stateItem.ToString(), res.ToString().ToUpper())
                dgvTruthTable.Rows(rowIndex).Height = 44
                ColorizeRow(rowIndex, res)
            Next
            lblRule.Text = "Rule: Reverses the logical value: makes a true expression false and a false expression true."
        Else
            dgvTruthTable.RowTemplate.Height = 34

            Dim opName As String = "AND"
            If radOr.Checked Then opName = "OR"
            If radXor.Checked Then opName = "XOR"

            dgvTruthTable.Columns.Add("colExp1", "Expr 1")
            dgvTruthTable.Columns.Add("colExp2", "Expr 2")
            dgvTruthTable.Columns.Add("colRes", $"A {opName} B")

            For Each col As DataGridViewColumn In dgvTruthTable.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

            Dim combinations As New List(Of Tuple(Of Boolean, Boolean)) From {
                Tuple.Create(True, True),
                Tuple.Create(True, False),
                Tuple.Create(False, True),
                Tuple.Create(False, False)
            }

            For Each combo In combinations
                Dim a As Boolean = combo.Item1
                Dim b As Boolean = combo.Item2
                Dim res As Boolean = False

                If radAnd.Checked Then
                    res = a And b
                    lblRule.Text = "Rule: Both expressions must be true for the overall expression to be true."
                ElseIf radOr.Checked Then
                    res = a Or b
                    lblRule.Text = "Rule: One or both expressions must be true for the overall expression to be true."
                ElseIf radXor.Checked Then
                    res = a Xor b
                    lblRule.Text = "Rule: Exactly one expression must be true (False if both are true or false)."
                End If

                Dim rowIndex As Integer = dgvTruthTable.Rows.Add(a.ToString(), b.ToString(), res.ToString().ToUpper())
                dgvTruthTable.Rows(rowIndex).Height = 34
                ColorizeRow(rowIndex, res)
            Next
        End If

        Dim totalRowHeight As Integer = 0
        For Each row As DataGridViewRow In dgvTruthTable.Rows
            totalRowHeight += row.Height
        Next
        dgvTruthTable.Height = dgvTruthTable.ColumnHeadersHeight + totalRowHeight + 2
        dgvTruthTable.ClearSelection()
    End Sub

    Private Sub ColorizeRow(rowIndex As Integer, result As Boolean)
        Dim resCell = dgvTruthTable.Rows(rowIndex).Cells("colRes")
        If result Then
            resCell.Style.ForeColor = Color.LimeGreen
        Else
            resCell.Style.ForeColor = Color.FromArgb(255, 75, 75)
        End If
        resCell.Style.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    End Sub

    Private Sub FormatRichText(rtb As RichTextBox)
        Try
            If rtb Is Nothing OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
            rtb.SuspendLayout()
            Dim origStart As Integer = rtb.SelectionStart
            Dim origLen As Integer = rtb.SelectionLength

            rtb.Text = rtb.Text

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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^\d+\.\s+[^:\r\n]+:?")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim mc3 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^[•]\s*[^:\r\n]+:?")
            For Each m As Match In mc3
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|VB\.Net|MessageBox|Show|IsNumeric|Empty|Trim|ToUpper|ToLower)\b"
            Dim mc4 As MatchCollection = Regex.Matches(rtb.Text, kw)
            For Each m As Match In mc4
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