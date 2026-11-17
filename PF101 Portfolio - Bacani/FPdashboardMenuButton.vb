Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows.Forms

Public Class FPdashboardMenuButton
    Inherits Button

    Private symbol As String = ""
    Private accentVisible As Boolean
    Private menuIcon As Bitmap

    <Category("Appearance"), DefaultValue("")>
    Public Property MenuSymbol As String
        Get
            Return symbol
        End Get
        Set(value As String)
            Dim newSymbol As String = If(value, "")
            If symbol = newSymbol Then Return
            symbol = newSymbol
            RefreshMenuIcon()
        End Set
    End Property

    <Category("Appearance"), DefaultValue(False)>
    Public Property ShowAccent As Boolean
        Get
            Return accentVisible
        End Get
        Set(value As Boolean)
            If accentVisible = value Then Return
            accentVisible = value
            Invalidate()
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Shadows ReadOnly Property Image As System.Drawing.Image
        Get
            Return MyBase.Image
        End Get
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        If Not accentVisible OrElse ClientSize.Height <= 2 Then Return

        Using accent As New SolidBrush(Color.FromArgb(190, 22, 49))
            e.Graphics.FillRectangle(accent, 1, 1, 4, ClientSize.Height - 2)
        End Using
    End Sub

    Protected Overrides Sub OnForeColorChanged(e As System.EventArgs)
        MyBase.OnForeColorChanged(e)
        If Not String.IsNullOrEmpty(symbol) Then RefreshMenuIcon()
    End Sub

    Private Sub RefreshMenuIcon()
        Dim previousIcon As Bitmap = menuIcon
        menuIcon = Nothing

        If symbol.Length > 0 Then
            menuIcon = New Bitmap(30, 24)
            Using canvas As Graphics = Graphics.FromImage(menuIcon),
                  symbolFont As New Font("Segoe UI Symbol", 12.0F, FontStyle.Regular),
                  brush As New SolidBrush(ForeColor),
                  alignment As New StringFormat()

                canvas.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                alignment.Alignment = StringAlignment.Center
                alignment.LineAlignment = StringAlignment.Center
                canvas.DrawString(symbol, symbolFont, brush, New RectangleF(0, 0, 22, 24), alignment)
            End Using
        End If

        MyBase.Image = menuIcon
        If previousIcon IsNot Nothing Then previousIcon.Dispose()
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso menuIcon IsNot Nothing Then
            MyBase.Image = Nothing
            menuIcon.Dispose()
            menuIcon = Nothing
        End If

        MyBase.Dispose(disposing)
    End Sub
End Class
