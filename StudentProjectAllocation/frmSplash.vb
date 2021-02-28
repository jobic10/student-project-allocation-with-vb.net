Public Class frmSplash
    Dim msgs() As String = {"Please wait ", "Please wait  . ", "Please wait  .. ", "Please wait  ... ", "System is being initialized", "Program files are being loaded", "Almost done"}
    Dim I As Integer = -1
    Dim newVal As Integer = 0

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'Center the current form
        Me.TopMost = True 'Since loader does not have menu controls, allow it stay on top of others

    End Sub

    Private Sub timerHome_Tick(sender As Object, e As EventArgs) Handles timerHome.Tick

        If barLoading.Value < 100 Then
            newVal = CInt(Int((10 * Rnd()) + 1))
            If (barLoading.Value + newVal) > 100 Then
                barLoading.Value = 100
            Else
                barLoading.Value = barLoading.Value + newVal
            End If
            lblProgress.Text = "Loading " & barLoading.Value & " %"
        Else
            Me.Hide()
            frmLogin.Show()
            timerHome.Enabled = False
        End If
    End Sub

    Private Sub timerStatus_Tick(sender As Object, e As EventArgs) Handles timerStatus.Tick
        If I >= msgs.Count - 1 Then
            I = 0
        Else
            I = I + 1
        End If
        lblStatus.Text = msgs(I)
    End Sub
End Class
