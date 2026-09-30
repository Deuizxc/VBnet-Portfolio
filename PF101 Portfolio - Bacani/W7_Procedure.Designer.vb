<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W7_Procedure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W7_Procedure))
        Button1 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        lblInit = New Label()
        btnByVal = New Button()
        btnByRef = New Button()
        btnFunc = New Button()
        btnResetP = New Button()
        lblDisplay = New Label()
        lblExecOutput = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("p5hatty", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 33)
        Button1.TabIndex = 13
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(12, 418)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 20)
        Button6.TabIndex = 22
        Button6.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(129, 44)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(272, 360)
        RichTextBox1.TabIndex = 36
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(458, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 20)
        Label2.TabIndex = 40
        Label2.Text = "PROCEDURE AND FUNCTION RUNNER"
        ' 
        ' lblInit
        ' 
        lblInit.AutoSize = True
        lblInit.BackColor = Color.Transparent
        lblInit.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInit.ForeColor = Color.White
        lblInit.Location = New Point(430, 102)
        lblInit.Name = "lblInit"
        lblInit.Size = New Size(157, 20)
        lblInit.TabIndex = 41
        lblInit.Text = "Initial Variable: num = 10"
        ' 
        ' btnByVal
        ' 
        btnByVal.BackColor = Color.Black
        btnByVal.FlatStyle = FlatStyle.Flat
        btnByVal.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnByVal.ForeColor = Color.White
        btnByVal.Location = New Point(28, 21)
        btnByVal.Name = "btnByVal"
        btnByVal.Size = New Size(102, 25)
        btnByVal.TabIndex = 46
        btnByVal.Text = "Sub ByVal"
        btnByVal.UseVisualStyleBackColor = False
        ' 
        ' btnByRef
        ' 
        btnByRef.BackColor = Color.Black
        btnByRef.FlatStyle = FlatStyle.Flat
        btnByRef.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnByRef.ForeColor = Color.White
        btnByRef.Location = New Point(162, 21)
        btnByRef.Name = "btnByRef"
        btnByRef.Size = New Size(102, 25)
        btnByRef.TabIndex = 47
        btnByRef.Text = "Sub ByRef"
        btnByRef.UseVisualStyleBackColor = False
        ' 
        ' btnFunc
        ' 
        btnFunc.BackColor = Color.Black
        btnFunc.FlatStyle = FlatStyle.Flat
        btnFunc.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFunc.ForeColor = Color.White
        btnFunc.Location = New Point(28, 69)
        btnFunc.Name = "btnFunc"
        btnFunc.Size = New Size(102, 25)
        btnFunc.TabIndex = 48
        btnFunc.Text = "Function (+5)"
        btnFunc.UseVisualStyleBackColor = False
        ' 
        ' btnResetP
        ' 
        btnResetP.BackColor = Color.Black
        btnResetP.FlatStyle = FlatStyle.Flat
        btnResetP.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnResetP.ForeColor = Color.White
        btnResetP.Location = New Point(162, 69)
        btnResetP.Name = "btnResetP"
        btnResetP.Size = New Size(102, 25)
        btnResetP.TabIndex = 49
        btnResetP.Text = "Reset"
        btnResetP.UseVisualStyleBackColor = False
        ' 
        ' lblDisplay
        ' 
        lblDisplay.AutoSize = True
        lblDisplay.BackColor = Color.Transparent
        lblDisplay.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplay.ForeColor = Color.White
        lblDisplay.Location = New Point(430, 273)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(146, 20)
        lblDisplay.TabIndex = 50
        lblDisplay.Text = "Current Value of 'num':"
        ' 
        ' lblExecOutput
        ' 
        lblExecOutput.BackColor = Color.Transparent
        lblExecOutput.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExecOutput.ForeColor = Color.White
        lblExecOutput.Location = New Point(430, 317)
        lblExecOutput.Name = "lblExecOutput"
        lblExecOutput.Size = New Size(295, 77)
        lblExecOutput.TabIndex = 51
        lblExecOutput.Text = "Executed Routine:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(btnByVal)
        Panel1.Controls.Add(btnByRef)
        Panel1.Controls.Add(btnResetP)
        Panel1.Controls.Add(btnFunc)
        Panel1.Location = New Point(430, 134)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(295, 122)
        Panel1.TabIndex = 52
        ' 
        ' W7_Procedure
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(lblExecOutput)
        Controls.Add(lblDisplay)
        Controls.Add(lblInit)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W7_Procedure"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W7_Procedure"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInit As Label
    Friend WithEvents btnByVal As Button
    Friend WithEvents btnByRef As Button
    Friend WithEvents btnFunc As Button
    Friend WithEvents btnResetP As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblExecOutput As Label
    Friend WithEvents Panel1 As Panel
End Class
