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
        Boat = New PictureBox()
        btnMoveBoat = New Button()
        Label1 = New Label()
        PictureBox23 = New PictureBox()
        Devil1 = New PictureBox()
        Devil2 = New PictureBox()
        Devil3 = New PictureBox()
        Priest2 = New PictureBox()
        Priest3 = New PictureBox()
        CType(Priest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Boat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Priest1
        ' 
        Priest1.BackColor = Color.Transparent
        Priest1.BackgroundImage = CType(resources.GetObject("Priest1.BackgroundImage"), Image)
        Priest1.BackgroundImageLayout = ImageLayout.Stretch
        Priest1.Location = New Point(739, 255)
        Priest1.Name = "Priest1"
        Priest1.Size = New Size(46, 92)
        Priest1.TabIndex = 0
        Priest1.TabStop = False
        ' 
        ' Boat
        ' 
        Boat.BackColor = Color.SaddleBrown
        Boat.Location = New Point(519, 377)
        Boat.Name = "Boat"
        Boat.Size = New Size(142, 50)
        Boat.TabIndex = 6
        Boat.TabStop = False
        ' 
        ' btnMoveBoat
        ' 
        btnMoveBoat.Location = New Point(488, 511)
        btnMoveBoat.Name = "btnMoveBoat"
        btnMoveBoat.Size = New Size(75, 23)
        btnMoveBoat.TabIndex = 7
        btnMoveBoat.Text = "GO"
        btnMoveBoat.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(905, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 10
        Label1.Text = "Time Left: 60"
        ' 
        ' PictureBox23
        ' 
        PictureBox23.Location = New Point(12, 21)
        PictureBox23.Name = "PictureBox23"
        PictureBox23.Size = New Size(100, 23)
        PictureBox23.TabIndex = 12
        PictureBox23.TabStop = False
        ' 
        ' Devil1
        ' 
        Devil1.BackColor = Color.Transparent
        Devil1.BackgroundImage = CType(resources.GetObject("Devil1.BackgroundImage"), Image)
        Devil1.BackgroundImageLayout = ImageLayout.Stretch
        Devil1.Location = New Point(895, 255)
        Devil1.Name = "Devil1"
        Devil1.Size = New Size(58, 92)
        Devil1.TabIndex = 16
        Devil1.TabStop = False
        ' 
        ' Devil2
        ' 
        Devil2.BackColor = Color.Transparent
        Devil2.BackgroundImage = CType(resources.GetObject("Devil2.BackgroundImage"), Image)
        Devil2.BackgroundImageLayout = ImageLayout.Stretch
        Devil2.Location = New Point(947, 255)
        Devil2.Name = "Devil2"
        Devil2.Size = New Size(58, 92)
        Devil2.TabIndex = 17
        Devil2.TabStop = False
        ' 
        ' Devil3
        ' 
        Devil3.BackColor = Color.Transparent
        Devil3.BackgroundImage = CType(resources.GetObject("Devil3.BackgroundImage"), Image)
        Devil3.BackgroundImageLayout = ImageLayout.Stretch
        Devil3.Location = New Point(999, 255)
        Devil3.Name = "Devil3"
        Devil3.Size = New Size(58, 92)
        Devil3.TabIndex = 18
        Devil3.TabStop = False
        ' 
        ' Priest2
        ' 
        Priest2.BackColor = Color.Transparent
        Priest2.BackgroundImage = CType(resources.GetObject("Priest2.BackgroundImage"), Image)
        Priest2.BackgroundImageLayout = ImageLayout.Stretch
        Priest2.Location = New Point(791, 255)
        Priest2.Name = "Priest2"
        Priest2.Size = New Size(46, 92)
        Priest2.TabIndex = 20
        Priest2.TabStop = False
        ' 
        ' Priest3
        ' 
        Priest3.BackColor = Color.Transparent
        Priest3.BackgroundImage = CType(resources.GetObject("Priest3.BackgroundImage"), Image)
        Priest3.BackgroundImageLayout = ImageLayout.Stretch
        Priest3.Location = New Point(843, 255)
        Priest3.Name = "Priest3"
        Priest3.Size = New Size(46, 92)
        Priest3.TabIndex = 21
        Priest3.TabStop = False
        ' 
        ' Level1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1064, 559)
        Controls.Add(Priest3)
        Controls.Add(Devil3)
        Controls.Add(Devil2)
        Controls.Add(Devil1)
        Controls.Add(PictureBox23)
        Controls.Add(Label1)
        Controls.Add(btnMoveBoat)
        Controls.Add(Boat)
        Controls.Add(Priest1)
        Controls.Add(Priest2)
        Name = "Level1"
        Text = "Level1"
        CType(Priest1, ComponentModel.ISupportInitialize).EndInit()
        CType(Boat, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil1, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil2, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil3, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest2, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Priest1 As PictureBox
    Friend WithEvents Boat As PictureBox
    Friend WithEvents btnMoveBoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Devil1 As PictureBox
    Friend WithEvents Devil2 As PictureBox
    Friend WithEvents Devil3 As PictureBox
    Friend WithEvents Priest2 As PictureBox
    Friend WithEvents Priest3 As PictureBox
End Class
