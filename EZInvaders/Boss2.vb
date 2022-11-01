Public Class Boss2

#Region "Variables"
    Dim lef As Boolean
    Dim rig As Boolean
    Dim up As Boolean
    Dim down As Boolean

    Dim Aliens(1) As PictureBox
    Dim Movealien As Integer = 3
    Dim whichalien As Integer

    Dim BossAlien(0) As PictureBox
    Dim MoveBoss As Integer = 3

    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim bShot(0) As Boolean
    Dim bShot2(0) As Label

    Dim bShotx(0) As Boolean
    Dim bShot2x(0) As Label

    Dim AiShot(1) As Boolean
    Dim AiShot2(1) As Label

    Dim Ran As Integer
    Dim count As Integer
    Dim score As Integer = 296

    Dim msg As String
#End Region

#Region "Key presses"
    Private Sub Boss2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

        If e.KeyValue = Keys.Up Then
            up = True
        End If

        If e.KeyValue = Keys.Down Then
            down = True
        End If
    End Sub

    Private Sub Boss2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Left Then
            lef = False
        End If

        If e.KeyValue = Keys.Right Then
            rig = False
        End If

        If e.KeyValue = Keys.A Then
            fire = False
        End If

        If e.KeyValue = Keys.Up Then
            up = False
        End If

        If e.KeyValue = Keys.Down Then
            down = False
        End If
    End Sub
#End Region

#Region "Timer"
    Private Sub MoveComp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveComp.Tick
        If lef = True Then
            SpaceShip.Left = SpaceShip.Left - 3
            Restartshot.Left = Restartshot.Left - 3
            If fire1 = False Then
                shot1.Left = shot1.Left - 3
            End If

            If fire2 = False Then
                shot2.Left = shot2.Left - 3
            End If

            If fire3 = False Then
                shot3.Left = shot3.Left - 3
            End If

            If fire4 = False Then
                shot4.Left = shot4.Left - 3
            End If

            If fire5 = False Then
                shot5.Left = shot5.Left - 3
            End If
        End If

        If rig = True Then
            SpaceShip.Left = SpaceShip.Left + 3
            Restartshot.Left = Restartshot.Left + 3
            If fire1 = False Then
                shot1.Left = shot1.Left + 3
            End If

            If fire2 = False Then
                shot2.Left = shot2.Left + 3
            End If

            If fire3 = False Then
                shot3.Left = shot3.Left + 3
            End If

            If fire4 = False Then
                shot4.Left = shot4.Left + 3
            End If

            If fire5 = False Then
                shot5.Left = shot5.Left + 3
            End If
        End If

        If up = True Then
            SpaceShip.Top = SpaceShip.Top - 3
            Restartshot.Top = Restartshot.Top - 3
            If fire1 = False Then
                shot1.Top = shot1.Top - 3
            End If

            If fire2 = False Then
                shot2.Top = shot2.Top - 3
            End If

            If fire3 = False Then
                shot3.Top = shot3.Top - 3
            End If

            If fire4 = False Then
                shot4.Top = shot4.Top - 3
            End If

            If fire5 = False Then
                shot5.Top = shot5.Top - 3
            End If
        End If

        If down = True Then
            SpaceShip.Top = SpaceShip.Top + 3
            Restartshot.Top = Restartshot.Top + 3
            If fire1 = False Then
                shot1.Top = shot1.Top + 3
            End If

            If fire2 = False Then
                shot2.Top = shot2.Top + 3
            End If

            If fire3 = False Then
                shot3.Top = shot3.Top + 3
            End If

            If fire4 = False Then
                shot4.Top = shot4.Top + 3
            End If

            If fire5 = False Then
                shot5.Top = shot5.Top + 3
            End If
        End If

        MoveAliens()
        MoveBossAlien()

        If fire = True Then
            Checkshot()
        End If

        Moveshot()
        MoveAlienShot()
        MoveBossShot()
    End Sub
#End Region
#Region "Subs"
    Public Sub New()
        InitializeComponent()
        CreateArray()
        BossArray()
        AlienShotArray()
        BossShotArray()
    End Sub

    Private Sub CreateArray()
        Aliens(0) = Alien1
        Aliens(1) = Alien2
    End Sub

    Private Sub BossArray()
        BossAlien(0) = Boss
    End Sub

    Private Sub AlienShotArray()
        AiShot2(0) = AlienShot1
        AiShot2(1) = AlienShot2
    End Sub

    Private Sub BossShotArray()
        bShot2(0) = BossShot3
        bShot2x(0) = BossShot4
    End Sub

    Private Sub MoveAliens()
        For i = 0 To 1
            Aliens(i).Left = Aliens(i).Left + Movealien
            If AiShot(i) = False Then
                AiShot2(i).Left = AiShot2(i).Left + Movealien
            End If
        Next

        If Alien2.Left > Me.Width - Alien2.Width Then
            Movealien = Movealien * -1
            For i = 0 To 1
                Aliens(i).Top = Aliens(i).Top + 25
                If AiShot(i) = False Then
                    AiShot2(i).Top = AiShot2(i).Top + 25
                End If
            Next
        End If

        If Alien1.Left < 0 Then
            Movealien = Movealien * -1
            For i = 0 To 1
                Aliens(i).Top = Aliens(i).Top + 25
                If AiShot(i) = False Then
                    AiShot2(i).Top = AiShot2(i).Top + 25
                End If
            Next
        End If
    End Sub

    Private Sub MoveBossAlien()
        For i = 0 To UBound(BossAlien)
            BossAlien(i).Left = BossAlien(i).Left + MoveBoss
            If bShot(i) = False Then
                bShot2(i).Left = bShot2(i).Left + MoveBoss
            End If

            If bShotx(i) = False Then
                bShot2x(i).Left = bShot2x(i).Left + MoveBoss
            End If
        Next

        If Boss.Left > Me.Width - Boss.Width Then
            MoveBoss = MoveBoss * -1
            For i = 0 To UBound(BossAlien)
                BossAlien(i).Top = BossAlien(i).Top + 25
                If bShot(i) = False Then
                    bShot2(i).Top = bShot2(i).Top + 25
                End If

                If bShotx(i) = False Then
                    bShot2x(i).Top = bShot2x(i).Top + 25
                End If
            Next
        End If

        If Boss.Left < 0 Then
            MoveBoss = MoveBoss * -1
            For i = 0 To UBound(BossAlien)
                BossAlien(i).Top = BossAlien(i).Top + 25
                If bShot(i) = False Then
                    bShot2(i).Top = bShot2(i).Top + 25
                End If

                If bShotx(i) = False Then
                    bShot2x(i).Top = bShot2x(i).Top + 25
                End If
            Next
        End If
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

            For i = 0 To 1
                If shot1.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot1hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next

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

            For i = 0 To 1
                If shot2.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot2hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next

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

            For i = 0 To 1
                If shot3.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot3hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next

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

            For i = 0 To 1
                If shot4.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next

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

            For i = 0 To 1
                If shot5.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot5hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next

            If Shot5.Top < 0 Then
                Shot5.Hide()
                fire5 = False
                Shot5.Location = RestartShot.Location
            End If
        End If

        For i As Integer = 0 To UBound(Aliens)
            If count = 10 Then
                Aliens(i).Top = Aliens(i).Top + 10000
            End If
        Next
        
        If count = 40 Then
            StageComplete()
            Boss.Top = Boss.Top + 10000
        End If
    End Sub

    Private Sub shot1hit()
        fire1 = False
        shot1.Hide()
        shot1.Location = Restartshot.Location
        count = count + 1
        score = score + 3
        lblScore.Text = score
    End Sub

    Private Sub shot2hit()
        fire2 = False
        shot2.Hide()
        shot2.Location = Restartshot.Location
        count = count + 1
        score = score + 1
        lblScore.Text = score
    End Sub

    Private Sub shot3hit()
        fire3 = False
        Shot3.Hide()
        shot3.Location = Restartshot.Location
        count = count + 1
        score = score + 1
        lblScore.Text = score
    End Sub

    Private Sub shot4hit()
        fire4 = False
        Shot4.Hide()
        shot4.Location = Restartshot.Location
        count = count + 1
        score = score + 1
        lblScore.Text = score
    End Sub

    Private Sub shot5hit()
        fire5 = False
        Shot5.Hide()
        shot5.Location = Restartshot.Location
        count = count + 1
        score = score + 1
        lblScore.Text = score
    End Sub

    Private Sub StageComplete()
        My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.Background)
        MoveComp.Stop()
        Boss.Image = My.Resources.Effect
        msg = InputBox("Congratulation Earth is saved. Please Enter Your NAME", "Space Aliens")
        Me.Hide()
        LastSplash.Show()
    End Sub

    Private Sub PlayerDead()
        MoveComp.Stop()
        SpaceShip.Image = My.Resources.Effect
        My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
        MessageBox.Show("Final Stage failed", "Space Aliens")
        Me.Hide()
        MainForm.Show()
    End Sub

    'alienshot
    Private Sub MoveAlienShot()
        For i = 0 To UBound(AiShot2)
            If AiShot(i) = False Then
                Ran = CInt(Int((150 * Rnd()) + 1))
                If Ran = 150 Then
                    AiShot(i) = True
                    AiShot2(i).Show()
                    'dead alien 
                    If Aliens(i).Top > 1000 Then
                        AiShot(i) = False
                        AiShot2(i).Hide()
                    End If
                    My.Computer.Audio.Play(My.Resources.shoot, AudioPlayMode.Background)
                End If
            End If
        Next

        For i = 0 To UBound(AiShot2)
            If AiShot(i) = True Then
                AiShot2(i).Top = AiShot2(i).Top + 3
                If AiShot2(i).Bounds.IntersectsWith(SpaceShip.Bounds) Then
                    PlayerDead()
                End If

                If AiShot2(i).Top > Me.Height Then
                    AiShot(i) = False
                    AiShot2(i).Hide()
                    AiShot2(i).Location = Aliens(i).Location
                    AiShot2(i).Top = AiShot2(i).Top + 80
                    AiShot2(i).Left = AiShot2(i).Left + 50
                End If
            End If
        Next

    End Sub

    'Bossshot
    Private Sub MoveBossShot()
        For i = 0 To UBound(bShot2)
            If bShot(i) = False Then
                Ran = CInt(Int((50 * Rnd()) + 1))
                If Ran = 50 Then
                    bShot(i) = True
                    bShot2(i).Show()
                    'dead alien 
                    If BossAlien(i).Top > 1000 Then
                        bShot(i) = False
                        bShot2(i).Hide()
                    End If
                    My.Computer.Audio.Play(My.Resources.shoot, AudioPlayMode.Background)
                End If
            End If
        Next

        For i = 0 To UBound(bShot2)
            If bShot(i) = True Then
                bShot2(i).Top = bShot2(i).Top + 3
                If bShot2(i).Bounds.IntersectsWith(SpaceShip.Bounds) Then
                    PlayerDead()
                End If

                If bShot2(i).Top > Me.Height Then
                    bShot(i) = False
                    bShot2(i).Hide()
                    bShot2(i).Location = BossAlien(i).Location
                    bShot2(i).Top = bShot2(i).Top + 100
                    bShot2(i).Left = bShot2(i).Left + 45
                End If
            End If
        Next


        For i = 0 To UBound(bShot2x)
            If bShotx(i) = False Then
                Ran = CInt(Int((50 * Rnd()) + 1))
                If Ran = 50 Then
                    bShotx(i) = True
                    bShot2x(i).Show()
                    'dead alien 
                    If BossAlien(i).Top > 1000 Then
                        bShotx(i) = False
                        bShot2x(i).Hide()
                    End If
                    My.Computer.Audio.Play(My.Resources.shoot, AudioPlayMode.Background)
                End If
            End If
        Next

        For i = 0 To UBound(bShot2x)
            If bShotx(i) = True Then
                bShot2x(i).Top = bShot2x(i).Top + 3
                If bShot2x(i).Bounds.IntersectsWith(SpaceShip.Bounds) Then
                    PlayerDead()
                End If

                If bShot2x(i).Top > Me.Height Then
                    bShotx(i) = False
                    bShot2x(i).Hide()
                    bShot2x(i).Location = BossAlien(i).Location
                    bShot2x(i).Top = bShot2x(i).Top + 100
                    bShot2x(i).Left = bShot2x(i).Left + 45
                End If
            End If
        Next

    End Sub
#End Region
End Class