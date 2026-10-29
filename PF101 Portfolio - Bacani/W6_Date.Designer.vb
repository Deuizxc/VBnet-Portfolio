<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class W6_Date
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W6_Date))
        Button1 = New Button()
        Button6 = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Button4 = New Button()
        Label4 = New Label()
        Label5 = New Label()
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
        Button1.Font = New Font("p5hatty", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        RichTextBox1.Font = New Font("Franklin Gothic Book", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(178, 44)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(245, 229)
        RichTextBox1.TabIndex = 34
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Book", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(479, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 20)
        Label1.TabIndex = 35
        Label1.Text = "// Click below to get system time"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(494, 220)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 33)
        Button2.TabIndex = 36
        Button2.Text = "SYSTEM TIME"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = Color.White
        DateTimePicker1.CalendarMonthBackground = Color.Black
        DateTimePicker1.CalendarTitleBackColor = Color.Red
        DateTimePicker1.CalendarTitleForeColor = Color.White
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(494, 54)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(100, 23)
        DateTimePicker1.TabIndex = 37
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(610, 50)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 30)
        Button3.TabIndex = 38
        Button3.Text = "CALCULATE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(479, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 39
        Label2.Text = "Week of Year: -"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(479, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 15)
        Label3.TabIndex = 40
        Label3.Text = "Difference in Months: -"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(190), CByte(20), CByte(20))
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(616, 220)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 33)
        Button4.TabIndex = 41
        Button4.Text = "RESET"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Trebuchet MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(218, 370)
        Label4.Name = "Label4"
        Label4.Size = New Size(342, 36)
        Label4.TabIndex = 42
        Label4.Text = "Select a target date from the picker, then click the " & vbCrLf & "button to calculate its week number and month difference."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Franklin Gothic Book", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(479, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 20)
        Label5.TabIndex = 43
        Label5.Text = "// Chose a date"
        ' 
        ' W6_Date
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button6)
        Controls.Add(Button1)
        ForeColor = SystemColors.ControlDarkDark
        FormBorderStyle = FormBorderStyle.None
        Name = "W6_Date"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W6_Date"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class