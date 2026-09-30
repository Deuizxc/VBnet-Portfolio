<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level1))
        Priest1 = New PictureBox()
        Priest2 = New PictureBox()
        Priest3 = New PictureBox()
        Devil1 = New PictureBox()
        Devil2 = New PictureBox()
        Devil3 = New PictureBox()
        Boat = New PictureBox()
        btnMoveBoat = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox23 = New PictureBox()
        CType(Priest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Boat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Priest1
        ' 
        Priest1.BackColor = Color.Cyan
        Priest1.Location = New Point(607, 429)
        Priest1.Name = "Priest1"
        Priest1.Size = New Size(40, 60)
        Priest1.TabIndex = 0
        Priest1.TabStop = False
        ' 
        ' Priest2
        ' 
        Priest2.BackColor = Color.Cyan
        Priest2.Location = New Point(653, 429)
        Priest2.Name = "Priest2"
        Priest2.Size = New Size(40, 60)
        Priest2.TabIndex = 1
        Priest2.TabStop = False
        ' 
        ' Priest3
        ' 
        Priest3.BackColor = Color.Cyan
        Priest3.Location = New Point(699, 429)
        Priest3.Name = "Priest3"
        Priest3.Size = New Size(40, 60)
        Priest3.TabIndex = 2
        Priest3.TabStop = False
        ' 
        ' Devil1
        ' 
        Devil1.BackColor = Color.Red
        Devil1.Location = New Point(791, 429)
        Devil1.Name = "Devil1"
        Devil1.Size = New Size(40, 60)
        Devil1.TabIndex = 3
        Devil1.TabStop = False
        ' 
        ' Devil2
        ' 
        Devil2.BackColor = Color.Red
        Devil2.Location = New Point(837, 429)
        Devil2.Name = "Devil2"
        Devil2.Size = New Size(40, 60)
        Devil2.TabIndex = 4
        Devil2.TabStop = False
        ' 
        ' Devil3
        ' 
        Devil3.BackColor = Color.Red
        Devil3.Location = New Point(745, 429)
        Devil3.Name = "Devil3"
        Devil3.Size = New Size(40, 60)
        Devil3.TabIndex = 5
        Devil3.TabStop = False
        ' 
        ' Boat
        ' 
        Boat.BackColor = Color.SaddleBrown
        Boat.Location = New Point(472, 483)
        Boat.Name = "Boat"
        Boat.Size = New Size(120, 50)
        Boat.TabIndex = 6
        Boat.TabStop = False
        ' 
        ' btnMoveBoat
        ' 
        btnMoveBoat.Location = New Point(345, 29)
        btnMoveBoat.Name = "btnMoveBoat"
        btnMoveBoat.Size = New Size(75, 23)
        btnMoveBoat.TabIndex = 7
        btnMoveBoat.Text = "GO"
        btnMoveBoat.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Green
        PictureBox1.Location = New Point(598, 495)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 50)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(679, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 10
        Label1.Text = "Time Left: 60"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Green
        PictureBox2.Location = New Point(-7, 495)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(283, 50)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox23
        ' 
        PictureBox23.Location = New Point(6, 29)
        PictureBox23.Name = "PictureBox23"
        PictureBox23.Size = New Size(100, 23)
        PictureBox23.TabIndex = 12
        PictureBox23.TabStop = False
        ' 
        ' Level1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(883, 545)
        Controls.Add(PictureBox23)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnMoveBoat)
        Controls.Add(Boat)
        Controls.Add(Devil3)
        Controls.Add(Devil2)
        Controls.Add(Devil1)
        Controls.Add(Priest3)
        Controls.Add(Priest2)
        Controls.Add(Priest1)
        Name = "Level1"
        Text = "Level1"
        CType(Priest1, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest2, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest3, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil1, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil2, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil3, ComponentModel.ISupportInitialize).EndInit()
        CType(Boat, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Priest1 As PictureBox
    Friend WithEvents Priest2 As PictureBox
    Friend WithEvents Priest3 As PictureBox
    Friend WithEvents Devil1 As PictureBox
    Friend WithEvents Devil2 As PictureBox
    Friend WithEvents Devil3 As PictureBox
    Friend WithEvents Boat As PictureBox
    Friend WithEvents btnMoveBoat As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
End Class
