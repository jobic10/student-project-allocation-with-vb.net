Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'Center the current form
        Me.TopMost = True 'Since loader does not have menu controls, allow it stay on top of others
    End Sub
End Class
