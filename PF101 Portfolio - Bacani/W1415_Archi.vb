Public Class W1415_Archi
    ' RETURN BUTTON (Closes MDI Child)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' CONTINUE BUTTON (Swaps to W1415_Dataset)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week14_15Selector.OpenChildForm(New W1415_Dataset())
    End Sub

    ' HOVER EFFECTS (Unified & Clean)
    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button7.MouseEnter
        Dim btn = DirectCast(sender, Button)
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.Top -= 3
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button7.MouseLeave
        Dim btn = DirectCast(sender, Button)
        btn.Top += 3
        btn.Cursor = Cursors.Default
    End Sub

    Private Sub W1415_Archi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        rbApproach2.Checked = True ' Default to Best Practice
    End Sub

    ' --- VIEWMODEL BUILDER DEMO LOGIC ---
    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        rtbOutput.Clear()

        rtbOutput.SelectionColor = Color.DodgerBlue
        rtbOutput.AppendText("[Builder] Generating OrderSummary..." & vbCrLf & vbCrLf)

        If rbApproach1.Checked Then
            ' Simulate Approach 1: Direct Embedding (Leaks Data)
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("class OrderSummary {" & vbCrLf)
            rtbOutput.AppendText("  public Order obOrder = {" & vbCrLf)
            rtbOutput.AppendText("    OrderNum: 88472," & vbCrLf)
            rtbOutput.AppendText("    Lines: 4," & vbCrLf)
            rtbOutput.SelectionColor = Color.Red
            rtbOutput.AppendText("    DB_Hash: ""0x8F9A""," & vbCrLf)
            rtbOutput.AppendText("    SysFlags: 00110" & vbCrLf)
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("  }" & vbCrLf)
            rtbOutput.AppendText("}" & vbCrLf & vbCrLf)

            rtbOutput.SelectionColor = Color.Red
            rtbOutput.AppendText("WARNING: Backend data leaked!")

        ElseIf rbApproach2.Checked Then
            ' Simulate Approach 2: Selective Mapping (Clean & Secure)
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("class OrderSummary {" & vbCrLf)
            rtbOutput.AppendText("  public int OrderNum = 88472;" & vbCrLf)
            rtbOutput.AppendText("  public int Lines = 4;" & vbCrLf)
            rtbOutput.AppendText("}" & vbCrLf & vbCrLf)

            rtbOutput.SelectionColor = Color.LimeGreen
            rtbOutput.AppendText("SUCCESS: Model is clean & secure.")
        End If
    End Sub
End Class