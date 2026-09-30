<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W7_Array
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W7_Array))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Button7 = New Button()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(695, 418)
        Button7.Name = "Button7"
        Button7.Size = New Size(93, 20)
        Button7.TabIndex = 23
        Button7.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(125, 43)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(239, 317)
        RichTextBox1.TabIndex = 34
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(445, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 20)
        Label2.TabIndex = 39
        Label2.Text = "ARRAY MEMORY INSPECTOR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(396, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 20)
        Label1.TabIndex = 40
        Label1.Text = "Dim intHours(6) As Integer"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(396, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 41
        Label3.Text = "Index:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(396, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 42
        Label4.Text = "Value:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.LimeGreen
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(396, 123)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ScrollBars = ScrollBars.None
        DataGridView1.Size = New Size(294, 53)
        DataGridView1.TabIndex = 43
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Black
        ComboBox1.ForeColor = Color.White
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(448, 197)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(186, 23)
        ComboBox1.TabIndex = 44
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(445, 279)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 21)
        Button3.TabIndex = 45
        Button3.Text = "SET"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(559, 279)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 21)
        Button2.TabIndex = 46
        Button2.Text = "RESET"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(396, 314)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 47
        Label5.Text = "Feedback:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(445, 234)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(189, 23)
        TextBox1.TabIndex = 48
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(396, 340)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 20)
        Label6.TabIndex = 49
        Label6.Text = "Executed: intHours(0) = 0"
        ' 
        ' W7_Array
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button7)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "W7_Array"
        StartPosition = FormStartPosition.CenterScreen
        Text = "W7_Array"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
End Class
