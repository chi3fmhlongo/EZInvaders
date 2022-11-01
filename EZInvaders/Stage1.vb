Public Class Stage1
    Dim SRight As Boolean 'Shooter moving right
    Dim SLeft As Boolean  'Shooter moving left
    Dim ShooterSpeed As Integer  'How much the shooter moves
    Dim ShotSpeed As Integer  'How much the shot moves
    Dim InvaderSpeed As Integer  'How much the invaders move
    Dim InvaderDrop As Integer  ' How much the invaders drop
    Const NumOfInvaders As Integer = 50  'how many invaders there are
    Dim IRight(NumOfInvaders) As Boolean  'if the invaders are moving right or left
    Dim Invaders(NumOfInvaders) As PictureBox 'Makes the invader array
    Dim x As Integer  'Used as a counter variable
    Dim ShotDown As Integer 'Number of invaders shot down
    Dim Paused As Boolean  '

    Dim score As Integer

    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick
        'when the timer tickes: 
        MoveShooter()
        FireShot()
        MoveInvader()
        CheckHit()
        CheckGameOver()
        GameComplete()
    End Sub

    Private Sub FormMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then ' if the right arrow key is pressed
            SRight = True
            SLeft = False
        End If
        If e.KeyValue = Keys.Left Then ' if the left arrow key is pressed
            SLeft = True
            SRight = False
        End If

        If e.KeyValue = Keys.A And Shot.Visible = False Then ' if the space is pressed and the shot has not been fired
            My.Computer.Audio.Play(My.Resources.Shot, AudioPlayMode.Background)
            Shot.Top = Shooter.Top ' shot comes out the shooters top
            Shot.Left = Shooter.Left + (Shooter.Width / 2) - (Shot.Width / 2) 'shot is centered in the shooter
            Shot.Visible = True
        End If

    End Sub

    Private Sub MoveShooter()
        If SRight = True And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then
            Shooter.Left += ShooterSpeed 'shooter moves to the right
        End If
        If SLeft = True And Shooter.Left > Me.ClientRectangle.Left Then
            Shooter.Left -= ShooterSpeed 'shooter moves to the left
        End If
    End Sub

    Private Sub FormMain_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            SRight = False ' shooter is not moving to the right
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = False ' shooter is not moving to the left
        End If
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInvaders()
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        Paused = False ' game is not paused
        ShotSpeed = 10 ' how fast the shot moves
        ShooterSpeed = 8 ' how fast the shooter moves
        Shot.Visible = False

        For Me.x = 1 To NumOfInvaders
            IRight(x) = True ' invaders are set to move right 
            Invaders(x).Left = (-50 * x) - (x * 50) 'how much the invaders are spaced from each other
            Invaders(x).Top = 0 'the invaders are at the top of the window
            Invaders(x).Visible = True
        Next

        InvaderSpeed = 3  'how much the invaders move
        InvaderDrop = 50  'how much the invaders drop
        ShotDown = 0   'start with 0 invaders shot down
        SRight = False  'shooter is not moving
        SLeft = False   'shooter is not moving
        My.Computer.Audio.Play(My.Resources.Intro, AudioPlayMode.Background)
        TimerMain.Enabled = True 'timer must be inabled to play the game
    End Sub

    Private Sub FireShot()
        If Shot.Visible = True Then
            Shot.Top -= ShotSpeed ' shot moves up
        End If

        If Shot.Top + Shot.Height < Me.ClientRectangle.Top Then
            Shot.Visible = False ' shot hits the top of the window and is ready to fire
        End If
    End Sub

    Private Sub MoveInvader()
        For Me.x = 1 To NumOfInvaders
            If IRight(x) = True Then
                Invaders(x).Left += InvaderSpeed ' moves invaders to the right
            Else
                Invaders(x).Left -= InvaderSpeed ' moves invaders to the left
            End If

            If Invaders(x).Left + Invaders(x).Width > Me.ClientRectangle.Width And IRight(x) = True Then
                ' invaders hit right side of the window and drop
                IRight(x) = False
                Invaders(x).Top += InvaderDrop
            End If

            If Invaders(x).Left < Me.ClientRectangle.Left And IRight(x) = False Then
                ' invaders hit left side of the window and drop
                IRight(x) = True
                Invaders(x).Top += InvaderDrop
            End If
        Next
    End Sub

    Private Sub CheckGameOver()
        For Me.x = 1 To NumOfInvaders
            If Invaders(x).Top + Invaders(x).Height >= Shooter.Top And Invaders(x).Visible = True Then
                TimerMain.Enabled = False
                Me.x = NumOfInvaders
                My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
                Shooter.Image = My.Resources.Effect
                MessageBox.Show("Game Over", "Space Aliens")
                PlayAgain()
                Shooter.Image = My.Resources.shooting11
            End If

        Next
    End Sub

    Private Sub GameComplete()
        If ShotDown = NumOfInvaders Then
            TimerMain.Stop()
            My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.Background)
            'i have to write a message here
            MessageBox.Show("Stage 1 clear. moving on to Stage 2", "Space Aliens", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Splash2.Show()
        End If

    End Sub

    Private Sub CheckHit()
        For Me.x = 1 To NumOfInvaders
            If (Shot.Top + Shot.Height >= Invaders(x).Top) And (Shot.Top <= Invaders(x).Top + Invaders(x).Height) And (Shot.Left + Shot.Width >= Invaders(x).Left) And (Shot.Left <= Invaders(x).Left + Invaders(x).Width) And Shot.Visible = True And Invaders(x).Visible = True Then
                Invaders(x).Visible = False
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                Shot.Visible = False
                ShotDown += 1
                score = score + 2
                lblScore.Text = score
            End If
        Next
    End Sub

    Private Sub LoadInvaders()
        For Me.x = 1 To NumOfInvaders  'dynamically makes invaders 
            Invaders(x) = New PictureBox
            Invaders(x).Image = My.Resources.ship2
            Invaders(x).Width = 50
            Invaders(x).Height = 50
            Invaders(x).BackColor = Color.Transparent
            Controls.Add(Invaders(x))
        Next

    End Sub

    Private Sub FormMain_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "P" Or e.KeyChar = "p" Then
            If Paused = True Then  'unpauses game
                TimerMain.Enabled = True
                Paused = False
            Else
                TimerMain.Enabled = False 'pauses game
                Paused = True
            End If
        End If
    End Sub

    Private Sub PlayAgain()
        Dim Result = MsgBox("Would you like to play again?", MsgBoxStyle.YesNo)

        If Result = MsgBoxResult.Yes Then
            LoadSettings() 'resets and restarts game
        Else
            Me.Close()  ' quits game
        End If
    End Sub
End Class
