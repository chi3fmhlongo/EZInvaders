Public Class Boss1

#Region "Variables"
    Dim lef As Boolean
    Dim rig As Boolean

    Dim bossspeed As Integer
    Dim bossDrop As Integer
    Dim IRight As Boolean

    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim count As Integer

    Dim BossBattleship(0) As PictureBox

    Dim AiShot(0) As Boolean
    Dim AiShot2(0) As Label

    Dim Ran As Integer
    Dim complete As Integer

    Dim score As Integer = 160
#End Region

#Region "Timer"
    Private Sub MoveComp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveComp.Tick
        If lef = True Then
            Spaceship.Left = Spaceship.Left - 3
            RestartShot.Left = RestartShot.Left - 3

            If fire1 = False Then
                shot1.Left = shot1.Left - 3
            End If

            If fire2 = False Then
                shot2.Left = shot2.Left - 3
            End If

            If fire3 = False Then
                Shot3.Left = Shot3.Left - 3
            End If

            If fire4 = False Then
                Shot4.Left = Shot4.Left - 3
            End If

            If fire5 = False Then
                Shot5.Left = Shot5.Left - 3
            End If
        End If

        If rig = True Then
            Spaceship.Left = Spaceship.Left + 3
            RestartShot.Left = RestartShot.Left + 3

            If fire1 = False Then
                shot1.Left = shot1.Left + 3
            End If

            If fire2 = False Then
                shot2.Left = shot2.Left + 3
            End If

            If fire3 = False Then
                Shot3.Left = Shot3.Left + 3
            End If

            If fire4 = False Then
                Shot4.Left = Shot4.Left + 3
            End If

            If fire5 = False Then
                Shot5.Left = Shot5.Left + 3
            End If
        End If
        MoveBoss()

        If fire = True Then
            Checkshot()
        End If

        Moveshot()
        MoveAlienShot()
        'checkgameover()
    End Sub
#End Region

#Region "Keys"
    Private Sub Form5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Left Then
            lef = True
        End If

        If e.KeyValue = Keys.Right Then
            rig = True
        End If

        If e.KeyValue = Keys.A Then
            fire = True
            My.Computer.Audio.Play(My.Resources.Shot, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Form5_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Left Then
            lef = False
        End If
        If e.KeyValue = Keys.Right Then
            rig = False
        End If

        If e.KeyValue = Keys.A Then
            fire = False
        End If
    End Sub
#End Region

#Region "Subs"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        createarray()
        AlienShotarray()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub createarray()
        BossBattleship(0) = Boss
    End Sub

    Private Sub MoveBoss()
        If IRight = True Then
            Boss.Left += bossspeed
            If AiShot(0) = False Then
                AiShot2(0).Left = AiShot2(0).Left + bossspeed
            End If
        Else
            Boss.Left -= bossspeed
            If AiShot(0) = False Then
                AiShot2(0).Left = AiShot2(0).Left - bossspeed
            End If
        End If

        If Boss.Left + Boss.Width > Me.ClientRectangle.Width Then
            IRight = False
            Boss.Top += bossDrop
            If AiShot(0) = False Then
                AiShot2(0).Top = AiShot2(0).Top + bossDrop
            End If
        End If

        If Boss.Left < Me.ClientRectangle.Left Then
            IRight = True
            Boss.Top += bossDrop
            If AiShot(0) = False Then
                AiShot2(0).Top = AiShot2(0).Top + bossDrop
            End If
        End If

        If Boss.Bounds.IntersectsWith(Spaceship.Bounds) Then
            checkgameover()
        End If
    End Sub

    Private Sub StageComplete()
        My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.Background)
        MoveComp.Stop()
        Boss.Image = My.Resources.Effect
        MessageBox.Show("Boss Defeated, Stage 2 Clear", "Space Aliens")
        Me.Hide()
        Splash3.Show()
    End Sub

    Private Sub checkgameover()
        MoveComp.Stop()
        Spaceship.Image = My.Resources.Effect
        My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
        MessageBox.Show("Game Over", "Dead")
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Checkshot()
        fire = False

        If fire1 = False Then
            fire1 = True
            shot1.Show()
            Exit Sub
        End If

        If fire2 = False Then
            fire2 = True
            shot2.Show()
            Exit Sub
        End If

        If fire3 = False Then
            fire3 = True
            Shot3.Show()
            Exit Sub
        End If

        If fire4 = False Then
            fire4 = True
            Shot4.Show()
            Exit Sub
        End If

        If fire5 = False Then
            fire5 = True
            Shot5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub Moveshot()
        If fire1 = True Then
            shot1.Top = shot1.Top - 3

            If shot1.Bounds.IntersectsWith(Boss.Bounds) Then
                shot1hit()
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
            End If

            If shot1.Top < 0 Then
                shot1.Hide()
                fire1 = False
                shot1.Location = RestartShot.Location
            End If
        End If

        If fire2 = True Then
            shot2.Top = shot2.Top - 3
            If shot2.Bounds.IntersectsWith(Boss.Bounds) Then
                shot2hit()
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
            End If
            If shot2.Top < 0 Then
                shot2.Hide()
                fire2 = False
                shot2.Location = RestartShot.Location
            End If
        End If

        If fire3 = True Then
            Shot3.Top = Shot3.Top - 3
            If Shot3.Bounds.IntersectsWith(Boss.Bounds) Then
                shot3hit()
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
            End If
            If Shot3.Top < 0 Then
                Shot3.Hide()
                fire3 = False
                Shot3.Location = RestartShot.Location
            End If
        End If

        If fire4 = True Then
            Shot4.Top = Shot4.Top - 3
            If Shot4.Bounds.IntersectsWith(Boss.Bounds) Then
                shot4hit()
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
            End If
            If Shot4.Top < 0 Then
                Shot4.Hide()
                fire4 = False
                Shot4.Location = RestartShot.Location
            End If
        End If

        If fire5 = True Then
            Shot5.Top = Shot5.Top - 3
            If Shot5.Bounds.IntersectsWith(Boss.Bounds) Then
                shot5hit()
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
            End If
            If Shot5.Top < 0 Then
                Shot5.Hide()
                fire5 = False
                Shot5.Location = RestartShot.Location
            End If
        End If

        'making the boss to dissapear after 20 hit
        If count = 20 Then
            StageComplete()
            Boss.Top = Boss.Top + 10000
        End If

    End Sub

    Private Sub shot1hit()
        fire1 = False
        shot1.Hide()
        shot1.Location = RestartShot.Location
        count = count + 1
        score = score + 3
        lblScore.Text = score
    End Sub

    Private Sub shot2hit()
        fire2 = False
        shot2.Hide()
        shot2.Location = RestartShot.Location
        count = count + 1
        score = score + 3
        lblScore.Text = score
    End Sub

    Private Sub shot3hit()
        fire3 = False
        Shot3.Hide()
        Shot3.Location = RestartShot.Location
        count = count + 1
        score = score + 3
        lblScore.Text = score
    End Sub

    Private Sub shot4hit()
        fire4 = False
        Shot4.Hide()
        Shot4.Location = RestartShot.Location
        count = count + 1
        score = score + 3
        lblScore.Text = score
    End Sub

    Private Sub shot5hit()
        fire5 = False
        Shot5.Hide()
        Shot5.Location = RestartShot.Location
        count = count + 1
        score = score + 3
        lblScore.Text = score
    End Sub

    Private Sub AlienShotarray()
        AiShot2(0) = BossShot
    End Sub

    Private Sub MoveAlienShot()
        For i = 0 To UBound(AiShot2)
            If AiShot(i) = False Then
                Ran = CInt(Int((150 * Rnd()) + 1))
                If Ran = 150 Then
                    AiShot(i) = True
                    AiShot2(i).Show()
                    My.Computer.Audio.Play(My.Resources.shoot, AudioPlayMode.Background)
                End If
            End If
        Next

        For i = 0 To 0
            If AiShot(i) = True Then
                AiShot2(i).Top = AiShot2(i).Top + 3
                If AiShot2(i).Bounds.IntersectsWith(Spaceship.Bounds) Then
                    checkgameover()
                End If

                If AiShot2(i).Top > Me.Height Then
                    AiShot(i) = False
                    AiShot2(i).Hide()
                    AiShot2(i).Location = AiShot2(i).Location
                    AiShot2(i).Top = AiShot2(i).Top + 50
                    AiShot2(i).Left = AiShot2(i).Left + 30
                End If
            End If
        Next
    End Sub

#End Region


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IRight = True
        bossspeed = 3
        bossDrop = 50
    End Sub


End Class