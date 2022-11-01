<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boss2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boss2))
        Me.MoveComp = New System.Windows.Forms.Timer(Me.components)
        Me.Restartshot = New System.Windows.Forms.Label()
        Me.shot1 = New System.Windows.Forms.Label()
        Me.shot2 = New System.Windows.Forms.Label()
        Me.shot3 = New System.Windows.Forms.Label()
        Me.shot4 = New System.Windows.Forms.Label()
        Me.shot5 = New System.Windows.Forms.Label()
        Me.AlienShot2 = New System.Windows.Forms.Label()
        Me.AlienShot1 = New System.Windows.Forms.Label()
        Me.BossShot3 = New System.Windows.Forms.Label()
        Me.Alien1 = New System.Windows.Forms.PictureBox()
        Me.Alien2 = New System.Windows.Forms.PictureBox()
        Me.Boss = New System.Windows.Forms.PictureBox()
        Me.SpaceShip = New System.Windows.Forms.PictureBox()
        Me.BossShot4 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoveComp
        '
        Me.MoveComp.Enabled = True
        Me.MoveComp.Interval = 10
        '
        'Restartshot
        '
        Me.Restartshot.BackColor = System.Drawing.Color.White
        Me.Restartshot.Location = New System.Drawing.Point(395, 474)
        Me.Restartshot.Name = "Restartshot"
        Me.Restartshot.Size = New System.Drawing.Size(4, 12)
        Me.Restartshot.TabIndex = 4
        Me.Restartshot.Visible = False
        '
        'shot1
        '
        Me.shot1.BackColor = System.Drawing.Color.White
        Me.shot1.Location = New System.Drawing.Point(395, 474)
        Me.shot1.Name = "shot1"
        Me.shot1.Size = New System.Drawing.Size(4, 12)
        Me.shot1.TabIndex = 5
        Me.shot1.Visible = False
        '
        'shot2
        '
        Me.shot2.BackColor = System.Drawing.Color.White
        Me.shot2.Location = New System.Drawing.Point(395, 474)
        Me.shot2.Name = "shot2"
        Me.shot2.Size = New System.Drawing.Size(4, 12)
        Me.shot2.TabIndex = 6
        Me.shot2.Visible = False
        '
        'shot3
        '
        Me.shot3.BackColor = System.Drawing.Color.White
        Me.shot3.Location = New System.Drawing.Point(395, 474)
        Me.shot3.Name = "shot3"
        Me.shot3.Size = New System.Drawing.Size(4, 12)
        Me.shot3.TabIndex = 7
        Me.shot3.Visible = False
        '
        'shot4
        '
        Me.shot4.BackColor = System.Drawing.Color.White
        Me.shot4.Location = New System.Drawing.Point(395, 474)
        Me.shot4.Name = "shot4"
        Me.shot4.Size = New System.Drawing.Size(4, 12)
        Me.shot4.TabIndex = 8
        Me.shot4.Visible = False
        '
        'shot5
        '
        Me.shot5.BackColor = System.Drawing.Color.White
        Me.shot5.Location = New System.Drawing.Point(395, 474)
        Me.shot5.Name = "shot5"
        Me.shot5.Size = New System.Drawing.Size(4, 12)
        Me.shot5.TabIndex = 9
        Me.shot5.Visible = False
        '
        'AlienShot2
        '
        Me.AlienShot2.BackColor = System.Drawing.Color.White
        Me.AlienShot2.Location = New System.Drawing.Point(535, 84)
        Me.AlienShot2.Name = "AlienShot2"
        Me.AlienShot2.Size = New System.Drawing.Size(4, 12)
        Me.AlienShot2.TabIndex = 10
        Me.AlienShot2.Visible = False
        '
        'AlienShot1
        '
        Me.AlienShot1.BackColor = System.Drawing.Color.White
        Me.AlienShot1.Location = New System.Drawing.Point(273, 84)
        Me.AlienShot1.Name = "AlienShot1"
        Me.AlienShot1.Size = New System.Drawing.Size(4, 12)
        Me.AlienShot1.TabIndex = 11
        Me.AlienShot1.Visible = False
        '
        'BossShot3
        '
        Me.BossShot3.BackColor = System.Drawing.Color.Yellow
        Me.BossShot3.Location = New System.Drawing.Point(376, 9)
        Me.BossShot3.Name = "BossShot3"
        Me.BossShot3.Size = New System.Drawing.Size(4, 12)
        Me.BossShot3.TabIndex = 15
        Me.BossShot3.Visible = False
        '
        'Alien1
        '
        Me.Alien1.Image = Global.SpaceAliens.My.Resources.Resources.REDBOSS
        Me.Alien1.Location = New System.Drawing.Point(240, 12)
        Me.Alien1.Name = "Alien1"
        Me.Alien1.Size = New System.Drawing.Size(70, 90)
        Me.Alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien1.TabIndex = 3
        Me.Alien1.TabStop = False
        '
        'Alien2
        '
        Me.Alien2.Image = Global.SpaceAliens.My.Resources.Resources.REDBOSS
        Me.Alien2.Location = New System.Drawing.Point(501, 12)
        Me.Alien2.Name = "Alien2"
        Me.Alien2.Size = New System.Drawing.Size(71, 90)
        Me.Alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien2.TabIndex = 2
        Me.Alien2.TabStop = False
        '
        'Boss
        '
        Me.Boss.Image = Global.SpaceAliens.My.Resources.Resources.william1
        Me.Boss.Location = New System.Drawing.Point(363, -58)
        Me.Boss.Name = "Boss"
        Me.Boss.Size = New System.Drawing.Size(96, 127)
        Me.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Boss.TabIndex = 1
        Me.Boss.TabStop = False
        '
        'SpaceShip
        '
        Me.SpaceShip.Image = Global.SpaceAliens.My.Resources.Resources.F5S4
        Me.SpaceShip.Location = New System.Drawing.Point(366, 462)
        Me.SpaceShip.Name = "SpaceShip"
        Me.SpaceShip.Size = New System.Drawing.Size(63, 68)
        Me.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpaceShip.TabIndex = 0
        Me.SpaceShip.TabStop = False
        '
        'BossShot4
        '
        Me.BossShot4.BackColor = System.Drawing.Color.Yellow
        Me.BossShot4.Location = New System.Drawing.Point(440, 12)
        Me.BossShot4.Name = "BossShot4"
        Me.BossShot4.Size = New System.Drawing.Size(4, 12)
        Me.BossShot4.TabIndex = 16
        Me.BossShot4.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Gungsuh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(67, 5)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 16)
        Me.lblScore.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gungsuh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Score"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(838, 62)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(838, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(838, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(838, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gungsuh", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(792, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Lives"
        '
        'Boss2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(863, 533)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BossShot4)
        Me.Controls.Add(Me.BossShot3)
        Me.Controls.Add(Me.AlienShot1)
        Me.Controls.Add(Me.AlienShot2)
        Me.Controls.Add(Me.shot5)
        Me.Controls.Add(Me.shot4)
        Me.Controls.Add(Me.shot3)
        Me.Controls.Add(Me.shot2)
        Me.Controls.Add(Me.shot1)
        Me.Controls.Add(Me.Restartshot)
        Me.Controls.Add(Me.Alien1)
        Me.Controls.Add(Me.Alien2)
        Me.Controls.Add(Me.Boss)
        Me.Controls.Add(Me.SpaceShip)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Boss2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stage 3 Boss"
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SpaceShip As System.Windows.Forms.PictureBox
    Friend WithEvents Boss As System.Windows.Forms.PictureBox
    Friend WithEvents Alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien1 As System.Windows.Forms.PictureBox
    Friend WithEvents MoveComp As System.Windows.Forms.Timer
    Friend WithEvents Restartshot As System.Windows.Forms.Label
    Friend WithEvents shot1 As System.Windows.Forms.Label
    Friend WithEvents shot2 As System.Windows.Forms.Label
    Friend WithEvents shot3 As System.Windows.Forms.Label
    Friend WithEvents shot4 As System.Windows.Forms.Label
    Friend WithEvents shot5 As System.Windows.Forms.Label
    Friend WithEvents AlienShot2 As System.Windows.Forms.Label
    Friend WithEvents AlienShot1 As System.Windows.Forms.Label
    Friend WithEvents BossShot3 As System.Windows.Forms.Label
    Friend WithEvents BossShot4 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
