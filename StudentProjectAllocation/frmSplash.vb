Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'Center the current form
        Me.TopMost = True 'Since loader does not have menu controls, allow it stay on top of others
    End Sub

    Private Sub timerHome_Tick(sender As Object, e As EventArgs) Handles timerHome.Tick
        If barLoading.Value < 100 Then
            barLoading.Value = barLoading.Value + CInt(Int((6 * Rnd()) + 1))
            lblProgress.Text = "Loading " & barLoading.Value
        Else
            timerHome.Enabled = False
            End
        End If
    End Sub
End Class
