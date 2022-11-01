Public Class Stage2

#Region "Variables"

    Dim lef As Boolean
    Dim rig As Boolean

    'Aliens
    Dim Aliens(29) As PictureBox
    Dim Locations(29) As System.Drawing.Point

    Dim MoveAlien As Integer = 2

    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim whichalien As Integer
    Dim complete As Integer

    Dim score As Integer = 100
#End Region

#Region "timer"
    Private Sub MoveComp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveComp.Tick
        If lef = True Then
            Spaceship.Left = Spaceship.Left - 3
            RestartShort.Left = RestartShort.Left - 3
            If fire1 = False Then
                Short1.Left = Short1.Left - 3
            End If

            If fire2 = False Then
                Short2.Left = Short2.Left - 3
            End If

            If fire3 = False Then
                Short3.Left = Short3.Left - 3
            End If

            If fire4 = False Then
                Short4.Left = Short4.Left - 3
            End If

            If fire5 = False Then
                Short5.Left = Short5.Left - 3
            End If
        End If

        If rig = True Then
            Spaceship.Left = Spaceship.Left + 3
            RestartShort.Left = RestartShort.Left + 3

            If fire1 = False Then
                Short1.Left = Short1.Left + 3
            End If

            If fire2 = False Then
                Short2.Left = Short2.Left + 3
            End If

            If fire3 = False Then
                Short3.Left = Short3.Left + 3
            End If

            If fire4 = False Then
                Short4.Left = Short4.Left + 3
            End If

            If fire5 = False Then
                Short5.Left = Short5.Left + 3
            End If
        End If
        MoveAliens()
        If fire = True Then
            checkshot()
        End If
        moveshort()
    End Sub
#End Region

#Region "Subs"
    Public Sub New()
        InitializeComponent()
        createArray()
    End Sub

    Private Sub createArray()
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
        Aliens(13) = Alien14
        Aliens(14) = Alien15
        Aliens(15) = Alien16
        Aliens(16) = Alien17
        Aliens(17) = Alien18
        Aliens(18) = Alien19
        Aliens(19) = Alien20
        Aliens(20) = Alien21
        Aliens(21) = Alien22
        Aliens(22) = Alien23
        Aliens(23) = Alien24
        Aliens(24) = Alien25
        Aliens(25) = Alien26
        Aliens(26) = Alien27
        Aliens(27) = Alien28
        Aliens(28) = Alien29
        Aliens(29) = Alien30

        For i = 0 To 29
            Locations(i) = Aliens(i).Location
        Next
    End Sub

    Private Sub MoveAliens()
        For i = 0 To 29
            Aliens(i).Left = Aliens(i).Left + MoveAlien
            If Aliens(i).Bounds.IntersectsWith(Spaceship.Bounds) Then
                playerdead()
            End If
        Next

        If Alien30.Left > Me.Width - Alien30.Width Then
            MoveAlien = MoveAlien * -1
            For i = 0 To 29
                Aliens(i).Top = Aliens(i).Top + 20
            Next
        End If

        If Alien1.Left < 0 Then
            MoveAlien = MoveAlien * -1
            For i = 0 To 29
                Aliens(i).Top = Aliens(i).Top + 20
            Next
        End If
    End Sub

    Private Sub checkshot()
        fire = False
        If fire1 = False Then
            fire1 = True
            Short1.Show()
            Exit Sub
        End If

        If fire2 = False Then
            fire2 = True
            Short2.Show()
            Exit Sub
        End If

        If fire3 = False Then
            fire3 = True
            Short3.Show()
            Exit Sub
        End If

        If fire4 = False Then
            fire4 = True
            Short4.Show()
            Exit Sub
        End If

        If fire5 = False Then
            fire5 = True
            Short5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub moveshort()
        If fire1 = True Then
            Short1.Top = Short1.Top - 3
            For i = 0 To 29
                If Short1.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot1hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Short1.Top < 0 Then
                Short1.Hide()
                fire1 = False
                Short1.Location = RestartShort.Location
            End If
        End If

        If fire2 = True Then
            Short2.Top = Short2.Top - 3
            For i = 0 To 29
                If Short2.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot2hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Short2.Top < 0 Then
                Short2.Hide()
                fire2 = False
                Short2.Location = RestartShort.Location
            End If
        End If

        If fire3 = True Then
            Short3.Top = Short3.Top - 3
            For i = 0 To 29
                If Short3.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot3hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Short3.Top < 0 Then
                Short3.Hide()
                fire3 = False
                Short3.Location = RestartShort.Location
            End If
        End If

        If fire4 = True Then
            Short4.Top = Short4.Top - 3
            For i = 0 To 29
                If Short4.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Short4.Top < 0 Then
                Short4.Hide()
                fire4 = False
                Short4.Location = RestartShort.Location
            End If
        End If

        If fire5 = True Then
            Short5.Top = Short5.Top - 3
            For i = 0 To 29
                If Short5.Bounds.IntersectsWith(Aliens(i).Bounds) Then
                    whichalien = i
                    shot5hit()
                    My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
                End If
            Next
            If Short5.Top < 0 Then
                Short5.Hide()
                fire5 = False
                Short5.Location = RestartShort.Location
            End If
        End If
    End Sub

    Private Sub shot1hit()
        fire1 = False
        Short1.Hide()
        Short1.Location = RestartShort.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 30 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            LevelComplete()
        End If
    End Sub

    Private Sub shot2hit()
        fire2 = False
        Short2.Hide()
        Short2.Location = RestartShort.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 30 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            LevelComplete()
        End If
    End Sub

    Private Sub shot3hit()
        fire3 = False
        Short3.Hide()
        Short3.Location = RestartShort.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 30 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            LevelComplete()
        End If
    End Sub

    Private Sub shot4hit()
        fire4 = False
        Short4.Hide()
        Short4.Location = RestartShort.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 30 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            LevelComplete()
        End If
    End Sub

    Private Sub shot5hit()
        fire5 = False
        Short5.Hide()
        Short5.Location = RestartShort.Location
        Aliens(whichalien).Top = Aliens(whichalien).Top + 10000
        complete = complete + 1
        score = score + 2
        lblScore.Text = score
        If complete = 30 Then
            My.Computer.Audio.Play(My.Resources.DONE, AudioPlayMode.Background)
            LevelComplete()
        End If
    End Sub

    Private Sub playerdead()
        MoveComp.Stop()
        Spaceship.Image = My.Resources.Effect
        My.Computer.Audio.Play(My.Resources.Dead, AudioPlayMode.Background)
        MessageBox.Show("Stage 2 failed", "Dead")
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub LevelComplete()
        MoveComp.Stop()
        complete = 0
        MessageBox.Show("Stage 2 clear, Boss Battle. ", "Space Aliens")
        Me.Hide()
        Boss1.Show()
    End Sub
#End Region

#Region "Key Presses"
    Private Sub Form3_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
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

    Private Sub Form3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
#End Region


    Private Sub Stage2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Intro, AudioPlayMode.Background)
        Panel1.Show()
        MoveComp.Enabled = True
        MoveComp.Start()
    End Sub

End Class