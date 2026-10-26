Public Class W1112_Net
    ' RETURN BUTTON (Closes MDI Child)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' CONTINUE BUTTON (Swaps to W1112_Classes)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Week11_12Selector.OpenChildForm(New W1112_Classes())
    End Sub

    ' HOVER EFFECTS (Unified & Clean - No Double Jump)
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

    Private Sub W1112_Net_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        cboLanguage.Items.Clear()
        cboLanguage.Items.Add("1. Visual Basic .NET (.vb)")
        cboLanguage.Items.Add("2. Visual C# .NET (.cs)")
        cboLanguage.Items.Add("3. Visual J# .NET (.jsl)")
        cboLanguage.SelectedIndex = 0

        rtbOutput.Text = "> Select a language above to inspect its source code on the left, then click Execute..."
    End Sub

    ' Updates the Left White Panel with Concept Notes + Selected Language Source Code
    Private Sub cboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLanguage.SelectedIndexChanged
        RichTextBox1.Clear()

        ' 1. Concept Summary Header
        RichTextBox1.SelectionFont = New Font("Segoe UI", 8.75F, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.FromArgb(190, 20, 20)
        RichTextBox1.AppendText("[ .NET FRAMEWORK & CLI ]" & vbCrLf)

        RichTextBox1.SelectionFont = New Font("Segoe UI", 8.25F, FontStyle.Regular)
        RichTextBox1.SelectionColor = Color.Black
        RichTextBox1.AppendText("• CLR: Executes code, manages memory & security." & vbCrLf &
                                "• BCL: Pre-built class library (System.Console)." & vbCrLf &
                                "• CLI: Compiles 70+ languages into unified CIL." & vbCrLf & vbCrLf)

        ' 2. Dynamic Source Code Display on the Left Side
        RichTextBox1.SelectionFont = New Font("Segoe UI", 8.75F, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.FromArgb(30, 30, 30)

        Select Case cboLanguage.SelectedIndex
            Case 0 ' VB.NET
                RichTextBox1.AppendText("[ SOURCE CODE: Module1.vb ]" & vbCrLf)
                RichTextBox1.SelectionFont = New Font("Consolas", 8.25F, FontStyle.Regular)
                RichTextBox1.SelectionColor = Color.DarkBlue
                RichTextBox1.AppendText(
                    "Imports System" & vbCrLf &
                    "Module Program" & vbCrLf &
                    "    Sub Main()" & vbCrLf &
                    "        Dim msg As String = ""Phantom""" & vbCrLf &
                    "        Console.WriteLine(msg)" & vbCrLf &
                    "    End Sub" & vbCrLf &
                    "End Module")

                Label1.Text = """In VB.NET, the vbc.exe compiler translates Sub Main() and Console.WriteLine() into standard CIL bytecode."""

            Case 1 ' C#
                RichTextBox1.AppendText("[ SOURCE CODE: Program.cs ]" & vbCrLf)
                RichTextBox1.SelectionFont = New Font("Consolas", 8.25F, FontStyle.Regular)
                RichTextBox1.SelectionColor = Color.DarkGreen
                RichTextBox1.AppendText(
                    "using System;" & vbCrLf &
                    "class Program {" & vbCrLf &
                    "    static void Main() {" & vbCrLf &
                    "        string msg = ""Phantom"";" & vbCrLf &
                    "        Console.WriteLine(msg);" & vbCrLf &
                    "    }" & vbCrLf &
                    "}")

                Label1.Text = """Even with C# curly braces and semicolons, csc.exe compiles this into the exact same CIL instructions as VB!"""

            Case 2 ' J#
                RichTextBox1.AppendText("[ SOURCE CODE: Program.jsl ]" & vbCrLf)
                RichTextBox1.SelectionFont = New Font("Consolas", 8.25F, FontStyle.Regular)
                RichTextBox1.SelectionColor = Color.Maroon
                RichTextBox1.AppendText(
                    "import System.*;" & vbCrLf &
                    "public class Program {" & vbCrLf &
                    "    public static void main(String[] a) {" & vbCrLf &
                    "        String msg = ""Phantom"";" & vbCrLf &
                    "        Console.WriteLine(msg);" & vbCrLf &
                    "    }" & vbCrLf &
                    "}")

                Label1.Text = """J# uses Java-style syntax, yet it still calls the shared .NET Base Class Library (System.Console)!"""
        End Select
    End Sub

    ' Outputs the Compiled CIL & CLR Execution Trace on the Right Black Side
    Private Sub btnCompile_Click(sender As Object, e As EventArgs) Handles btnCompile.Click
        Dim compilerName As String = "vbc.exe (VB Compiler)"
        If cboLanguage.SelectedIndex = 1 Then compilerName = "csc.exe (C# Compiler)"
        If cboLanguage.SelectedIndex = 2 Then compilerName = "vjc.exe (J# Compiler)"

        rtbOutput.Clear()

        ' Step 1: Compiler -> CIL
        rtbOutput.SelectionColor = Color.DodgerBlue
        rtbOutput.AppendText("[1] COMPILER: " & compilerName & vbCrLf)

        rtbOutput.SelectionColor = Color.Silver
        rtbOutput.AppendText("  IL_0000: ldstr ""Phantom""" & vbCrLf)
        rtbOutput.AppendText("  IL_0005: call Console.WriteLine" & vbCrLf)
        rtbOutput.AppendText("  IL_000a: ret" & vbCrLf & vbCrLf)

        ' Step 2: CLR & BCL Link
        rtbOutput.SelectionColor = Color.Gold
        rtbOutput.AppendText("[2] CLR JIT & BCL EXECUTION:" & vbCrLf)
        rtbOutput.SelectionColor = Color.White
        rtbOutput.AppendText("  -> Linked BCL: mscorlib.dll" & vbCrLf)
        rtbOutput.AppendText("  -> Security & Memory: Verified" & vbCrLf & vbCrLf)

        ' Step 3: Final Console Output
        rtbOutput.SelectionColor = Color.LimeGreen
        rtbOutput.AppendText("[OUTPUT]: Phantom")

        Label1.Text = """See? Whether it's VB, C#, or J#, the Common Language Runtime (CLR) translates the code into the exact same CIL!"""
    End Sub
End Class