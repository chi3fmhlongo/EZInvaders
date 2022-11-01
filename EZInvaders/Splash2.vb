Public Class Splash2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False
            Timer1.Stop()
            Stage2.Show()
        End If
        Label2.Text = ProgressBar1.Value & " %"
    End Sub

    Private Sub form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class