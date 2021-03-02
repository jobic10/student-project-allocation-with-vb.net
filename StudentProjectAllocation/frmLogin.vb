Public Class frmLogin
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        If MsgBox("Are you sure you want to quit ?", vbYesNo, "Close Application") = vbYes Then
            End
        End If
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        'ConnectDatabase()
        Dim username As String = ""
        Dim password As String = ""
        Try
            username = txtUsername.Text
            password = txtPassword.Text
        Catch ex As Exception

        End Try
        cmd.CommandText = "SELECT username FROM users WHERE username =@username AND password=@password"
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Query()
        If Not obj Is Nothing Then
            MsgBox("Access Granted", vbInformation, "Success")
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Hide()
            mdiHome.Show()
        Else
            MsgBox("Access Denied", vbCritical, "Error")
        End If
    End Sub
End Class