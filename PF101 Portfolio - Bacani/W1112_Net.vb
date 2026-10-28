Imports System.Text.RegularExpressions

Public Class W1112_Net
    Private Sub W1112_Net_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()

            cboLanguage.Items.Clear()
            cboLanguage.Items.Add("1. Visual Basic .NET (.vb)")
            cboLanguage.Items.Add("2. Visual C# .NET (.cs)")
            cboLanguage.Items.Add("3. Visual J# .NET (.jsl)")
            cboLanguage.SelectedIndex = 0

            rtbOutput.Text = "> Select a language above to inspect its source code on the left, then click Execute..."
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Week11_12Selector.OpenChildForm(New W1112_Classes())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button7.MouseEnter
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

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button7.MouseLeave
        Try
            Dim btn = DirectCast(sender, Button)
            btn.Top += 3
            btn.Cursor = Cursors.Default
            If btn.Name = "Button1" Then btn.ForeColor = Color.Black
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLanguage.SelectedIndexChanged
        Try
            RichTextBox1.Clear()
            RichTextBox1.AppendText("[ .NET FRAMEWORK & CLI ]" & vbCrLf)
            RichTextBox1.AppendText("• CLR: Executes code, manages memory & security." & vbCrLf &
                                    "• BCL: Pre-built class library (System.Console)." & vbCrLf &
                                    "• CLI: Compiles 70+ languages into unified CIL." & vbCrLf & vbCrLf)

            Select Case cboLanguage.SelectedIndex
                Case 0
                    RichTextBox1.AppendText("[ SOURCE CODE: Module1.vb ]" & vbCrLf)
                    RichTextBox1.AppendText("Imports System" & vbCrLf &
                                            "Module Program" & vbCrLf &
                                            "    Sub Main()" & vbCrLf &
                                            "        Dim msg As String = ""Phantom""" & vbCrLf &
                                            "        Console.WriteLine(msg)" & vbCrLf &
                                            "    End Sub" & vbCrLf &
                                            "End Module")
                    Label1.Text = """In VB.NET, the vbc.exe compiler translates Sub Main() and Console.WriteLine() into standard CIL bytecode."""
                Case 1
                    RichTextBox1.AppendText("[ SOURCE CODE: Program.cs ]" & vbCrLf)
                    RichTextBox1.AppendText("using System;" & vbCrLf &
                                            "class Program {" & vbCrLf &
                                            "    static void Main() {" & vbCrLf &
                                            "        string msg = ""Phantom"";" & vbCrLf &
                                            "        Console.WriteLine(msg);" & vbCrLf &
                                            "    }" & vbCrLf &
                                            "}")
                    Label1.Text = """Even with C# curly braces and semicolons, csc.exe compiles this into the exact same CIL instructions as VB!"""
                Case 2
                    RichTextBox1.AppendText("[ SOURCE CODE: Program.jsl ]" & vbCrLf)
                    RichTextBox1.AppendText("import System.*;" & vbCrLf &
                                            "public class Program {" & vbCrLf &
                                            "    public static void main(String[] a) {" & vbCrLf &
                                            "        String msg = ""Phantom"";" & vbCrLf &
                                            "        Console.WriteLine(msg);" & vbCrLf &
                                            "    }" & vbCrLf &
                                            "}")
                    Label1.Text = """J# uses Java-style syntax, yet it still calls the shared .NET Base Class Library (System.Console)!"""
            End Select
            FormatRichText(RichTextBox1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCompile_Click(sender As Object, e As EventArgs) Handles btnCompile.Click
        Try
            Dim compilerName As String = "vbc.exe (VB Compiler)"
            If cboLanguage.SelectedIndex = 1 Then compilerName = "csc.exe (C# Compiler)"
            If cboLanguage.SelectedIndex = 2 Then compilerName = "vjc.exe (J# Compiler)"

            rtbOutput.Clear()
            rtbOutput.SelectionColor = Color.DodgerBlue
            rtbOutput.AppendText("[1] COMPILER: " & compilerName & vbCrLf)

            rtbOutput.SelectionColor = Color.Silver
            rtbOutput.AppendText("  IL_0000: ldstr ""Phantom""" & vbCrLf)
            rtbOutput.AppendText("  IL_0005: call Console.WriteLine" & vbCrLf)
            rtbOutput.AppendText("  IL_000a: ret" & vbCrLf & vbCrLf)

            rtbOutput.SelectionColor = Color.Gold
            rtbOutput.AppendText("[2] CLR JIT & BCL EXECUTION:" & vbCrLf)
            rtbOutput.SelectionColor = Color.White
            rtbOutput.AppendText("  -> Linked BCL: mscorlib.dll" & vbCrLf)
            rtbOutput.AppendText("  -> Security & Memory: Verified" & vbCrLf & vbCrLf)

            rtbOutput.SelectionColor = Color.LimeGreen
            rtbOutput.AppendText("[OUTPUT]: Phantom")

            Label1.Text = """See? Whether it's VB, C#, or J#, the Common Language Runtime (CLR) translates the code into the exact same CIL!"""
        Catch ex As Exception
        End Try
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

            Dim mc2 As MatchCollection = Regex.Matches(rtb.Text, "(?m)^(?:\d+\.|\•|\-)\s+[^:\r\n]+:")
            For Each m As Match In mc2
                rtb.Select(m.Index, m.Length)
                rtb.SelectionFont = New Font("Segoe UI", 11.25F, FontStyle.Bold)
                rtb.SelectionColor = Color.FromArgb(190, 20, 20)
            Next

            Dim kw As String = "\b(Class|Sub|Function|End|Private|Public|Handles|Dim|As|String|Integer|Double|Decimal|If|ElseIf|Else|Then|Return|True|False|Const|Select|Case|Mod|Do|While|Until|Loop|For|Next|To|Boolean|Char|Byte|Long|Short|New|ByVal|ByRef|Step|Inherits|MustInherit|MyBase|Try|Catch|Finally|Exception|UCase|Trim|StrReverse|FormatCurrency|Imports|Module|using|class|static|void|string|import|public|main)\b"
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