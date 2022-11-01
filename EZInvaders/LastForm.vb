Public Class LastSplash
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False
            Timer1.Stop()
            Form1.Show()
        End If
        Label3.Text = ProgressBar1.Value & " %"
    End Sub
End Class