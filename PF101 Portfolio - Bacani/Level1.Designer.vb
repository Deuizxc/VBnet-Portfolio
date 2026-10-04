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
        Devil1 = New PictureBox()
        Devil2 = New PictureBox()
        Devil3 = New PictureBox()
        Priest2 = New PictureBox()
        Priest3 = New PictureBox()
        Button1 = New Button()
        CType(Priest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Boat, ComponentModel.ISupportInitialize).BeginInit()
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
        Priest1.BackgroundImageLayout = ImageLayout.Stretch
        Priest1.Image = CType(resources.GetObject("Priest1.Image"), Image)
        Priest1.Location = New Point(715, 299)
        Priest1.Name = "Priest1"
        Priest1.Size = New Size(113, 92)
        Priest1.SizeMode = PictureBoxSizeMode.Zoom
        Priest1.TabIndex = 0
        Priest1.TabStop = False
        ' 
        ' Boat
        ' 
        Boat.BackColor = Color.Transparent
        Boat.BackgroundImageLayout = ImageLayout.Stretch
        Boat.Image = CType(resources.GetObject("Boat.Image"), Image)
        Boat.Location = New Point(523, 360)
        Boat.Name = "Boat"
        Boat.Size = New Size(165, 67)
        Boat.SizeMode = PictureBoxSizeMode.StretchImage
        Boat.TabIndex = 6
        Boat.TabStop = False
        ' 
        ' btnMoveBoat
        ' 
        btnMoveBoat.BackColor = Color.Transparent
        btnMoveBoat.BackgroundImage = CType(resources.GetObject("btnMoveBoat.BackgroundImage"), Image)
        btnMoveBoat.BackgroundImageLayout = ImageLayout.Stretch
        btnMoveBoat.Cursor = Cursors.Hand
        btnMoveBoat.FlatAppearance.BorderSize = 0
        btnMoveBoat.FlatStyle = FlatStyle.Flat
        btnMoveBoat.Location = New Point(473, 493)
        btnMoveBoat.Name = "btnMoveBoat"
        btnMoveBoat.Size = New Size(129, 43)
        btnMoveBoat.TabIndex = 7
        btnMoveBoat.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(879, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 53)
        Label1.TabIndex = 10
        Label1.Text = "Time Left: 60"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Devil1
        ' 
        Devil1.BackColor = Color.Transparent
        Devil1.BackgroundImageLayout = ImageLayout.Stretch
        Devil1.Image = CType(resources.GetObject("Devil1.Image"), Image)
        Devil1.Location = New Point(795, 345)
        Devil1.Name = "Devil1"
        Devil1.Size = New Size(113, 92)
        Devil1.SizeMode = PictureBoxSizeMode.Zoom
        Devil1.TabIndex = 16
        Devil1.TabStop = False
        ' 
        ' Devil2
        ' 
        Devil2.BackColor = Color.Transparent
        Devil2.BackgroundImageLayout = ImageLayout.Stretch
        Devil2.Image = CType(resources.GetObject("Devil2.Image"), Image)
        Devil2.Location = New Point(861, 335)
        Devil2.Name = "Devil2"
        Devil2.Size = New Size(113, 92)
        Devil2.SizeMode = PictureBoxSizeMode.Zoom
        Devil2.TabIndex = 17
        Devil2.TabStop = False
        ' 
        ' Devil3
        ' 
        Devil3.BackColor = Color.Transparent
        Devil3.BackgroundImageLayout = ImageLayout.Stretch
        Devil3.Image = CType(resources.GetObject("Devil3.Image"), Image)
        Devil3.Location = New Point(939, 335)
        Devil3.Name = "Devil3"
        Devil3.Size = New Size(113, 92)
        Devil3.SizeMode = PictureBoxSizeMode.Zoom
        Devil3.TabIndex = 18
        Devil3.TabStop = False
        ' 
        ' Priest2
        ' 
        Priest2.BackColor = Color.Transparent
        Priest2.BackgroundImageLayout = ImageLayout.Stretch
        Priest2.Image = CType(resources.GetObject("Priest2.Image"), Image)
        Priest2.Location = New Point(781, 287)
        Priest2.Name = "Priest2"
        Priest2.Size = New Size(113, 92)
        Priest2.SizeMode = PictureBoxSizeMode.Zoom
        Priest2.TabIndex = 20
        Priest2.TabStop = False
        ' 
        ' Priest3
        ' 
        Priest3.BackColor = Color.Transparent
        Priest3.BackgroundImageLayout = ImageLayout.Stretch
        Priest3.Image = CType(resources.GetObject("Priest3.Image"), Image)
        Priest3.Location = New Point(837, 288)
        Priest3.Name = "Priest3"
        Priest3.Size = New Size(113, 92)
        Priest3.SizeMode = PictureBoxSizeMode.Zoom
        Priest3.TabIndex = 21
        Priest3.TabStop = False
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
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(12, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 33)
        Button1.TabIndex = 23
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Level1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1064, 559)
        Controls.Add(Devil3)
        Controls.Add(Devil2)
        Controls.Add(Devil1)
        Controls.Add(Button1)
        Controls.Add(Priest3)
        Controls.Add(Label1)
        Controls.Add(btnMoveBoat)
        Controls.Add(Boat)
        Controls.Add(Priest2)
        Controls.Add(Priest1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Level1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level1"
        CType(Priest1, ComponentModel.ISupportInitialize).EndInit()
        CType(Boat, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil1, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil2, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil3, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest2, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Priest1 As PictureBox
    Friend WithEvents Boat As PictureBox
    Friend WithEvents btnMoveBoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Devil1 As PictureBox
    Friend WithEvents Devil2 As PictureBox
    Friend WithEvents Devil3 As PictureBox
    Friend WithEvents Priest2 As PictureBox
    Friend WithEvents Priest3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
