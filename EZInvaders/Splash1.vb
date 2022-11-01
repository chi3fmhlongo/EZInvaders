Public Class Splash1
    Dim progress As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Stop()
            Stage1.Show()
        End If
        Label2.Text = ProgressBar1.Value & " %"

        
    End Sub

    Private Sub Splash1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Label2.Text = ProgressBar1.Value & " %"
    End Sub
End Class