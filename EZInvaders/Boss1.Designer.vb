<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boss1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boss1))
        Me.MoveComp = New System.Windows.Forms.Timer(Me.components)
        Me.RestartShot = New System.Windows.Forms.Label()
        Me.shot1 = New System.Windows.Forms.Label()
        Me.shot2 = New System.Windows.Forms.Label()
        Me.Shot3 = New System.Windows.Forms.Label()
        Me.Shot4 = New System.Windows.Forms.Label()
        Me.Shot5 = New System.Windows.Forms.Label()
        Me.BossShot = New System.Windows.Forms.Label()
        Me.Boss = New System.Windows.Forms.PictureBox()
        Me.Spaceship = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spaceship, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RestartShot
        '
        Me.RestartShot.BackColor = System.Drawing.Color.White
        Me.RestartShot.Location = New System.Drawing.Point(375, 468)
        Me.RestartShot.Name = "RestartShot"
        Me.RestartShot.Size = New System.Drawing.Size(5, 15)
        Me.RestartShot.TabIndex = 2
        Me.RestartShot.Visible = False
        '
        'shot1
        '
        Me.shot1.BackColor = System.Drawing.Color.White
        Me.shot1.Location = New System.Drawing.Point(375, 468)
        Me.shot1.Name = "shot1"
        Me.shot1.Size = New System.Drawing.Size(5, 15)
        Me.shot1.TabIndex = 3
        Me.shot1.Visible = False
        '
        'shot2
        '
        Me.shot2.BackColor = System.Drawing.Color.White
        Me.shot2.Location = New System.Drawing.Point(375, 468)
        Me.shot2.Name = "shot2"
        Me.shot2.Size = New System.Drawing.Size(5, 15)
        Me.shot2.TabIndex = 4
        Me.shot2.Visible = False
        '
        'Shot3
        '
        Me.Shot3.BackColor = System.Drawing.Color.White
        Me.Shot3.Location = New System.Drawing.Point(375, 468)
        Me.Shot3.Name = "Shot3"
        Me.Shot3.Size = New System.Drawing.Size(5, 15)
        Me.Shot3.TabIndex = 5
        Me.Shot3.Visible = False
        '
        'Shot4
        '
        Me.Shot4.BackColor = System.Drawing.Color.White
        Me.Shot4.Location = New System.Drawing.Point(375, 468)
        Me.Shot4.Name = "Shot4"
        Me.Shot4.Size = New System.Drawing.Size(5, 15)
        Me.Shot4.TabIndex = 6
        Me.Shot4.Visible = False
        '
        'Shot5
        '
        Me.Shot5.BackColor = System.Drawing.Color.White
        Me.Shot5.Location = New System.Drawing.Point(375, 468)
        Me.Shot5.Name = "Shot5"
        Me.Shot5.Size = New System.Drawing.Size(5, 15)
        Me.Shot5.TabIndex = 7
        Me.Shot5.Visible = False
        '
        'BossShot
        '
        Me.BossShot.BackColor = System.Drawing.Color.White
        Me.BossShot.Location = New System.Drawing.Point(62, 33)
        Me.BossShot.Name = "BossShot"
        Me.BossShot.Size = New System.Drawing.Size(5, 15)
        Me.BossShot.TabIndex = 8
        Me.BossShot.Visible = False
        '
        'Boss
        '
        Me.Boss.BackColor = System.Drawing.Color.Transparent
        Me.Boss.Image = Global.SpaceAliens.My.Resources.Resources.william2
        Me.Boss.Location = New System.Drawing.Point(4, -24)
        Me.Boss.Name = "Boss"
        Me.Boss.Size = New System.Drawing.Size(128, 131)
        Me.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Boss.TabIndex = 1
        Me.Boss.TabStop = False
        '
        'Spaceship
        '
        Me.Spaceship.Image = Global.SpaceAliens.My.Resources.Resources.shootig21
        Me.Spaceship.Location = New System.Drawing.Point(333, 456)
        Me.Spaceship.Name = "Spaceship"
        Me.Spaceship.Size = New System.Drawing.Size(89, 75)
        Me.Spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Spaceship.TabIndex = 0
        Me.Spaceship.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Gungsuh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(70, 4)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 16)
        Me.lblScore.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gungsuh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 9
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
        Me.PictureBox4.TabIndex = 15
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
        Me.PictureBox3.TabIndex = 14
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
        Me.PictureBox2.TabIndex = 13
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
        Me.PictureBox1.TabIndex = 12
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
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lives"
        '
        'Boss1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(863, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.BossShot)
        Me.Controls.Add(Me.Shot5)
        Me.Controls.Add(Me.Shot4)
        Me.Controls.Add(Me.Shot3)
        Me.Controls.Add(Me.shot2)
        Me.Controls.Add(Me.shot1)
        Me.Controls.Add(Me.RestartShot)
        Me.Controls.Add(Me.Spaceship)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Boss)
        Me.KeyPreview = True
        Me.Name = "Boss1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stage 2 Boss"
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spaceship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Spaceship As System.Windows.Forms.PictureBox
    Friend WithEvents Boss As System.Windows.Forms.PictureBox
    Friend WithEvents MoveComp As System.Windows.Forms.Timer
    Friend WithEvents RestartShot As System.Windows.Forms.Label
    Friend WithEvents shot1 As System.Windows.Forms.Label
    Friend WithEvents shot2 As System.Windows.Forms.Label
    Friend WithEvents Shot3 As System.Windows.Forms.Label
    Friend WithEvents Shot4 As System.Windows.Forms.Label
    Friend WithEvents Shot5 As System.Windows.Forms.Label
    Friend WithEvents BossShot As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
