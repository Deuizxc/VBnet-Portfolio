Imports System.Text.RegularExpressions

Public Class W1415_Database

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Week14_15Selector.OpenChildForm(New W1415_Row())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button6.MouseEnter
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

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button6.MouseLeave
        Try
            Dim btn = DirectCast(sender, Button)
            btn.Top += 3
            btn.Cursor = Cursors.Default
            If btn.Name = "Button1" Then btn.ForeColor = Color.Black
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W1415_Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
            cboKeyType.Items.Add("Use Identity Columns (Local)")
            cboKeyType.Items.Add("Use GUID Identifiers (Global)")
            cboKeyType.SelectedIndex = 0
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        Try
            rtbTerminal.Clear()
            rtbTerminal.SelectionColor = Color.White
            rtbTerminal.AppendText("Target: CustomerOrders Table" & vbCrLf)
            rtbTerminal.AppendText("Executing DataAdapter.Update()..." & vbCrLf & vbCrLf)

            rtbTerminal.SelectionColor = Color.DodgerBlue
            rtbTerminal.AppendText("[1] Resolving DataViewRowState.Deleted" & vbCrLf)
            rtbTerminal.SelectionColor = Color.White
            rtbTerminal.AppendText("-> Executing ")
            rtbTerminal.SelectionColor = Color.Orange
            rtbTerminal.AppendText("DeleteCommand ")
            rtbTerminal.SelectionColor = Color.White
            rtbTerminal.AppendText("on Row 1..." & vbCrLf)
            rtbTerminal.AppendText("-> Record removed." & vbCrLf & vbCrLf)

            rtbTerminal.SelectionColor = Color.DodgerBlue
            rtbTerminal.AppendText("[2] Resolving DataViewRowState.Added" & vbCrLf)
            rtbTerminal.SelectionColor = Color.White
            rtbTerminal.AppendText("-> Executing ")
            rtbTerminal.SelectionColor = Color.Orange
            rtbTerminal.AppendText("InsertCommand ")
            rtbTerminal.SelectionColor = Color.White
            rtbTerminal.AppendText("for New Record..." & vbCrLf)

            rtbTerminal.AppendText("-> Fetching Key via UpdateRowSource.")
            rtbTerminal.SelectionColor = Color.Gold
            rtbTerminal.AppendText("FirstReturnedRecord" & vbCrLf)

            rtbTerminal.SelectionColor = Color.LimeGreen
            If cboKeyType.SelectedIndex = 0 Then
                rtbTerminal.AppendText("-> Success! Assigned Identity ID: 1042" & vbCrLf & vbCrLf)
            Else
                Dim newGuid As Guid = Guid.NewGuid()
                rtbTerminal.AppendText("-> Success! Assigned GUID:" & vbCrLf)
                rtbTerminal.AppendText("-> " & newGuid.ToString().ToUpper() & vbCrLf & vbCrLf)
            End If

            rtbTerminal.SelectionColor = Color.DodgerBlue
            rtbTerminal.AppendText("[3] SYNC COMPLETE.")

            rtbTerminal.SelectionStart = rtbTerminal.Text.Length
            rtbTerminal.ScrollToCaret()
        Catch ex As Exception
        End Try
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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•|\-)\s*([^\r\n]+)")
            Dim startPos2 As Integer = 0
            For Each m As Match In mc2
                Dim fullLine As String = m.Groups(1).Value.Trim()
                Dim parts() As String = fullLine.Split(New Char() {":"c}, 2)

                Dim headerText As String = ""
                If parts.Length > 1 Then
                    headerText = m.Value.Substring(0, m.Value.IndexOf(parts(0)) + parts(0).Length + 1)
                Else
                    headerText = m.Value
                End If

                Dim pos As Integer = rtb.Find(headerText, startPos2, RichTextBoxFinds.None)
                If pos <> -1 Then
                    rtb.Select(pos, headerText.Length)
                    rtb.SelectionFont = boldFont
                    rtb.SelectionColor = redColor
                    startPos2 = pos + headerText.Length
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