Imports System.Text.RegularExpressions

Public Class W8_File

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Try
            Week8Selector.Show()
            Week8Selector.Update()
        Catch ex As Exception
            Dim w8 As New Week8Selector()
            w8.Show()
            w8.Update()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Try
            W8_Color.Show()
        Catch ex As Exception
            Dim frm As New W8_Color()
            frm.Show()
        End Try
    End Sub

    Private Sub W8_File_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AudioManager.AttachSounds(Me)
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        lvDetails.View = View.Details
        lvDetails.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lvDetails.FullRowSelect = True
        lvDetails.GridLines = False
        lvDetails.OwnerDraw = True
        lvDetails.BackColor = Color.FromArgb(25, 25, 25)

        lvDetails.Columns.Clear()
        lvDetails.Columns.Add("Name", 140)
        lvDetails.Columns.Add("Type", 80)
        lvDetails.Columns.Add("Size", 60)

        BuildTree()

        tvCategories.ExpandAll()
        If tvCategories.Nodes.Count > 1 Then
            tvCategories.SelectedNode = tvCategories.Nodes(1)
        End If

        FormatRichText(RichTextBox1)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    End Sub

    Private Sub BuildTree()
        tvCategories.Nodes.Clear()

        Dim nodeC As TreeNode = tvCategories.Nodes.Add("Local Disk (C:)")
        nodeC.Nodes.Add("Program Files")
        nodeC.Nodes.Add("Users")

        Dim nodeD As TreeNode = tvCategories.Nodes.Add("External Storage (D:)")
        nodeD.Nodes.Add("Game Backups")
        nodeD.Nodes.Add("Media Library")
        nodeD.Nodes.Add("Documents")
    End Sub

    Private Sub tvCategories_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvCategories.AfterSelect
        If e.Node Is Nothing Then Exit Sub

        lvDetails.Items.Clear()

        AddListItem("Resident_Evil_6.exe", "Application", "26.0 GB")
        AddListItem("Persona_5_Royal.iso", "Disk Image", "42.5 GB")
        AddListItem("Aphrodite.mp3", "Audio", "4.5 MB")

        If lvDetails.Columns.Count >= 3 AndAlso lvDetails.View = View.Details Then
            Dim w As Integer = lvDetails.ClientSize.Width
            If w > 50 Then
                lvDetails.Columns(0).Width = CInt(w * 0.45)
                lvDetails.Columns(1).Width = CInt(w * 0.35)
                lvDetails.Columns(2).Width = w - lvDetails.Columns(0).Width - lvDetails.Columns(1).Width - 2
            End If
        End If

        If lvDetails.Items.Count > 0 Then
            lvDetails.Items(0).Selected = True
        End If
    End Sub

    Private Sub lvDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDetails.SelectedIndexChanged
        If lvDetails.SelectedItems.Count > 0 Then
        End If
    End Sub

    Private Sub btnExpand_Click(sender As Object, e As EventArgs) Handles btnExpand.Click
        If tvCategories.Nodes.Count > 0 AndAlso tvCategories.Nodes(0).IsExpanded Then
            tvCategories.CollapseAll()
            lblFeedback.Text = "Executed: TreeView Collapsed"
        Else
            tvCategories.ExpandAll()
            lblFeedback.Text = "Executed: TreeView Expanded"
        End If
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If lvDetails.View = View.Details Then
            lvDetails.View = View.List
            lblFeedback.Text = "Executed: ListView Mode = List"
        Else
            lvDetails.View = View.Details
            lblFeedback.Text = "Executed: ListView Mode = Details"
            If lvDetails.Columns.Count >= 3 Then
                Dim w As Integer = lvDetails.ClientSize.Width
                If w > 50 Then
                    lvDetails.Columns(0).Width = CInt(w * 0.45)
                    lvDetails.Columns(1).Width = CInt(w * 0.35)
                    lvDetails.Columns(2).Width = w - lvDetails.Columns(0).Width - lvDetails.Columns(1).Width - 2
                End If
            End If
        End If
    End Sub

    Private Sub AddListItem(itemName As String, itemType As String, itemSize As String)
        Dim itm As New ListViewItem(itemName)
        itm.ForeColor = Color.White
        itm.UseItemStyleForSubItems = False

        Dim subType As ListViewItem.ListViewSubItem = itm.SubItems.Add(itemType)
        subType.ForeColor = Color.LightGray

        Dim subSize As ListViewItem.ListViewSubItem = itm.SubItems.Add(itemSize)
        subSize.ForeColor = Color.Gray

        lvDetails.Items.Add(itm)
    End Sub

    Private Sub ToggleButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnExpand.MouseEnter, btnToggle.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub ToggleButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnExpand.MouseLeave, btnToggle.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub lvDetails_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvDetails.DrawColumnHeader
        Using brush As New SolidBrush(Color.FromArgb(45, 45, 45))
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using
        ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.Flat)
        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.White, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    Private Sub lvDetails_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles lvDetails.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub lvDetails_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lvDetails.DrawSubItem
        e.DrawDefault = True
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

            Dim kw As String = "\b(Class|Sub|Function|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|ByVal|ByRef|Step)\b"
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