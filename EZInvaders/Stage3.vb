Public Class Stage3

#Region "Variables"
    Dim lef As Boolean
    Dim rig As Boolean
    Dim up As Boolean
    Dim down As Boolean

    Dim Aliens(37) As PictureBox

    Dim AiShot(37) As Boolean
    Dim AiShot2(37) As Label

    Dim Movealien As Integer = 2

    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim whichalien As Integer
    Dim complete As Integer

    Dim score As Integer = 220

    Dim Ran As Integer
#End Region

#Region "Keys pressed"
    Private Sub Form7_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Left Then
            lef = False
        End If

        If e.KeyValue = Keys.Right Then
            rig = False
        End If

        If e.KeyValue = Keys.Up Then
            up = False
        End If

        If e.KeyValue = Keys.Down Then
            down = False
        End If

        If e.KeyValue = Keys.A Then
            fire = False
        End If
    End Sub

    Private Sub Form7_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Left Then
            lef = True
        End If

        If e.KeyValue = Keys.Right Then
            rig = True
        End If

        If e.KeyValue = Keys.Up Then
            up = True
        End If

        If e.KeyValue = Keys.Down Then
            down = True
        End If

        If e.KeyValue = Keys.A Then
            fire = True
            My.Computer.Audio.Play(My.Resources.Shot, AudioPlayMode.Background)
        End If
    End Sub
#End Region

#Region "Timer"
    Private Sub MoveComp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveComp.Tick
        If lef = True Then
            Spaceship.Left = Spaceship.Left - 3
            Restartshot.Left = Restartshot.Left - 3
            If fire1 = False Then
                Shot1.Left = Shot1.Left - 3
            End If

            If fire2 = False Then
                Shot2.Left = Shot2.Left - 3
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
            Restartshot.Left = Restartshot.Left + 3

            If fire1 = False Then
                Shot1.Left = Shot1.Left + 3
            End If

            If fire2 = False Then
                Shot2.Left = Shot2.Left + 3
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

        If up = True Then
            Spaceship.Top = Spaceship.Top - 3
            Restartshot.Top = Restartshot.Top - 3

            If fire1 = False Then
                Shot1.Top = Shot1.Top - 3
            End If

            If fire2 = False Then
                Shot2.Top = Shot2.Top - 3
            End If

            If fire3 = False Then
                Shot3.Top = Shot3.Top - 3
            End If

            If fire4 = False Then
                Shot4.Top = Shot4.Top - 3
            End If

            If fire5 = False Then
                Shot5.Top = Shot5.Top - 3
            End If
        End If

        If down = True Then
            Spaceship.Top = Spaceship.Top + 3
            Restartshot.Top = Restartshot.Top + 3

            If fire1 = False Then
                Shot1.Top = Shot1.Top + 3
            End If

            If fire2 = False Then
                Shot2.Top = Shot2.Top + 3
            End If

            If fire3 = False Then
                Shot3.Top = Shot3.Top + 3
            End If

            If fire4 = False Then
                Shot4.Top = Shot4.Top + 3
            End If

            If fire5 = False Then
                Shot5.Top = Shot5.Top + 3
            End If
        End If

        'If Spaceship.Left < 0 Then
        '    Spaceship.Left = Spaceship.Left + 3
        '    Restartshot.Left = Restartshot.Left + 3

        '    If fire1 = False Then
        '        Shot1.Left = Shot1.Left + 3
        '    End If

        '    If fire2 = False Then
        '        Shot2.Left = Shot2.Left + 3
        '    End If

        '    If fire3 = False Then
        '        Shot3.Left = Shot3.Left + 3
        '    End If

        '    If fire4 = False Then
        '        Shot4.Left = Shot4.Left + 3
        '    End If

        '    If fire5 = False Then
        '        Shot5.Left = Shot5.Left + 3
        '    End If
        'End If

        'If Spaceship.Left > Me.Width - Spaceship.Width Then
        '    Spaceship.Left = Spaceship.Left - 3
        '    Restartshot.Left = Restartshot.Left - 3

        '    If fire1 = False Then
        '        Shot1.Left = Shot1.Left - 3
        '    End If

        '    If fire2 = False Then
        '        Shot2.Left = Shot2.Left - 3
        '    End If

        '    If fire3 = False Then
        '        Shot3.Left = Shot3.Left - 3
        '    End If

        '    If fire4 = False Then
        '        Shot4.Left = Shot4.Left - 3
        '    End If

        '    If fire5 = False Then
        '        Shot5.Left = Shot5.Left - 3
        '    End If
        'End If

        MoveAliens()
        If fire = True Then
            Checkshot()
        End If
        Moveshot()
        MoveAlienShot()
    End Sub
#End Region

#Region "Subs"
    Public Sub New()
        InitializeComponent()
        createarray()
        AlienShotarray()
    End Sub

    Private Sub createarray()
        Aliens(0) = Alien1
        Aliens(1) = Alien2
        Aliens(2) = Alien3
        Aliens(3) = Alien4
        Aliens(4) = Alien5
        Aliens(5) = Alien6
        Aliens(6) = Alien7
        Aliens(7) = Alien8
        Aliens(8) = Alien9
        Aliens(9) = Alien10
        Aliens(10) = Alien11
        Aliens(11) = Alien12
        Aliens(12) = Alien13
        Aliens(13) = Alien15
        Aliens(14) = Alien16
        Aliens(15) = Alien17
        Aliens(16) = Alien18
        Aliens(17) = Alien19
        Aliens(18) = Alien20
        Aliens(19) = Alien21
        Aliens(20) = Alien22
        Aliens(21) = Alien23
        Aliens(22) = Alien24
        Aliens(23) = Alien25
        Aliens(24) = Alien26
        Aliens(25) = Alien28
        Aliens(26) = Alien29
        Aliens(27) = Alien30
        Aliens(28) = Alien31
        Aliens(29) = Alien32
        Aliens(30) = Alien33
        Aliens(31) = Alien34
        Aliens(32) = Alien35
        Aliens(33) = Alien36
        Aliens(34) = Alien37
        Aliens(35) = Alien38
        Aliens(36) = Alien39
        Aliens(37) = Alien40
        


    End Sub

    Private Sub AlienShotarray()

        AiShot2(0) = Alienshot1
        AiShot2(1) = AlienShot2
        AiShot2(2) = AlienShot3
        AiShot2(3) = AlienShot4
        AiShot2(4) = AlienShot5
        AiShot2(5) = AlienShot6
        AiShot2(6) = AlienShot7
        AiShot2(7) = Alienshot8
        AiShot2(8) = Alienshot9
        AiShot2(9) = Alienshot10
        AiShot2(10) = Alienshot11
        AiShot2(11) = Alienshot12
        AiShot2(12) = Alienshot13
        AiShot2(13) = Alienshot15
        AiShot2(14) = Alienshot16
        AiShot2(15) = Alienshot17
        AiShot2(16) = Alienshot18
        AiShot2(17) = Alienshot19
        AiShot2(18) = Alienshot20
        AiShot2(19) = Alienshot21
        AiShot2(20) = Alienshot22
        AiShot2(21) = Alienshot23
        AiShot2(22) = Alienshot24
        AiShot2(23) = Alienshot25
        AiShot2(24) = Alienshot26
        AiShot2(25) = Alienshot28
        AiShot2(26) = Alienshot29
        AiShot2(27) = Alienshot30
        AiShot2(28) = Alienshot31
        AiShot2(29) = Alienshot32
        AiShot2(30) = Alienshot33
        AiShot2(31) = Alienshot34
        AiShot2(32) = Alienshot35
        AiShot2(33) = Alienshot36
        AiShot2(34) = Alienshot37
        AiShot2(35) = Alienshot38
        AiShot2(36) = Alienshot39
        AiShot2(37) = Alienshot40

    End Sub

    Private Sub MoveAliens()
        For i = 0 To 37
            Aliens(i).Left = Aliens(i).Left + Movealien
            If AiShot(i) = False Then
                AiShot2(i).Left = AiShot2(i).Left + Movealien
            End If
            If Aliens(i).Bounds.IntersectsWith(Spaceship.Bounds) Then
                PlayerDead()
            End If
        Next

        If Alien13.Left > Me.Width - Alien13.Width Then
            Movealien = Movealien * -1
            For i = 0 To 37
                Aliens(i).Top = Aliens(i).Top + 25
                If AiShot(i) = False Then
                    AiShot2(i).Top = AiShot2(i).Top + 25
                End If
            Next
        End If

        If Alien1.Left < 0 Then
            Movealien = Movealien * -1
            For i = 0 To 37
                Aliens(i).Top = Aliens(i).Top + 25
                If AiShot(i) = False Then
                    AiShot2(i).Top = AiShot2(i).Top + 25
                End If
            Next
        End If
    End Sub

    Private Sub Checkshot()
        fire = False

        If fire1 = False Then
            fire1 = True
            Shot1.Show()
            Exit Sub
        End If

        If fire2 = False Then
            fire2 = True
            Shot2.Show()
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
            Shot1.Top = Shot1.Top - 3
            For i = 0 To 37
                If Shot1.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot1hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Shot1.Top < 0 Then
                Shot1.Hide()
                fire1 = False
                Shot1.Location = Restartshot.Location
            End If
        End If

        If fire2 = True Then
            Shot2.Top = Shot2.Top - 3
            For i = 0 To 37
                If Shot2.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot2hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Shot2.Top < 0 Then
                Shot2.Hide()
                fire2 = False
                Shot2.Location = Restartshot.Location
            End If
        End If

        If fire3 = True Then
            Shot3.Top = Shot3.Top - 3
            For i = 0 To 37
                If Shot3.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot3hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Shot3.Top < 0 Then
                Shot3.Hide()
                fire3 = False
                Shot3.Location = Restartshot.Location
            End If
        End If

        If fire4 = True Then
            Shot4.Top = Shot4.Top - 3
            For i = 0 To 37
                If Shot4.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Shot4.Top < 0 Then
                Shot4.Hide()
                fire4 = False
                Shot4.Location = Restartshot.Location
            End If
        End If

        If fire5 = True Then
            Shot5.Top = Shot5.Top - 3
            For i = 0 To 37
                If Shot5.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot5hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Shot5.Top < 0 Then
                Shot5.Hide()
                fire5 = False
                Shot5.Location = Restartshot.Location
            End If
        End If
    End Sub

    Private Sub shot1hit()
        fire1 = False
        Shot1.Hide()
        Shot1.Location = Restartshot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 38 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            StageComplete()
        End If
    End Sub

    Private Sub shot2hit()
        fire2 = False
        Shot2.Hide()
        Shot2.Location = Restartshot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 38 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            StageComplete()
        End If
    End Sub

    Private Sub shot3hit()
        fire3 = False
        Shot3.Hide()
        Shot3.Location = Restartshot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 38 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            StageComplete()
        End If
    End Sub

    Private Sub shot4hit()
        fire4 = False
        Shot4.Hide()
        Shot4.Location = Restartshot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 38 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            StageComplete()
        End If
    End Sub

    Private Sub shot5hit()
        fire5 = False
        Shot5.Hide()
        Shot5.Location = Restartshot.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 38 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            StageComplete()
        End If
    End Sub

    Private Sub PlayerDead()
        MoveComp.Stop()
        Spaceship.Image = My.Resources.Effect
        My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
        MessageBox.Show("Final Stage failed", "Space Aliens")
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub StageComplete()
        My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.Background)
        MessageBox.Show("Final Boss approaches", "Space Aliens")
        MoveComp.Enabled = False
        MoveComp.Stop()
        Me.Hide()
        Boss2.Show()
    End Sub

    'fire
    Private Sub MoveAlienShot()
        For i = 0 To 37
            If AiShot(i) = False Then
                Ran = CInt(Int((2000 * Rnd()) + 1))
                If Ran = 2000 Then
                    AiShot(i) = True
                    AiShot2(i).Show()
                    'dead alien 
                    If Aliens(i).Top > 1000 Then
                        AiShot(i) = False
                        AiShot2(i).Hide()
                    End If
                    'My.Computer.Audio.Play(My.Resources.shoot, AudioPlayMode.Background)
                End If
            End If
        Next

        For i = 0 To 37
            If AiShot(i) = True Then
                AiShot2(i).Top = AiShot2(i).Top + 3
                If AiShot2(i).Bounds.IntersectsWith(Spaceship.Bounds) Then
                    PlayerDead()
                End If

                If AiShot2(i).Top > Me.Height Then
                    AiShot(i) = False
                    AiShot2(i).Hide()
                    AiShot2(i).Location = Aliens(i).Location
                    AiShot2(i).Top = AiShot2(i).Top + 50
                    AiShot2(i).Left = AiShot2(i).Left + 30
                End If
            End If
        Next
    End Sub
#End Region

    Private Sub Stage3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Intro, AudioPlayMode.Background)
    End Sub
End Class