﻿Public Class frmLogin
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
            If (username = "" Or password = "") Then
                showError("Both Username and Password Fields Are Required")
                Return
            End If
            cmd.CommandText = "SELECT username FROM users WHERE username=@username AND password=@password"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Login()
            If dr.Read() Then
                'If Not obj Is Nothing Then
                'If mysqli_num_rows > 0 Then
                MsgBox("Access Granted", vbInformation, "Success")
                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()
                mdiHome.Show()
                dr.Close()
                conn.Close()
            Else
                MsgBox("Access Denied", vbCritical, "Error")
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString(), vbCritical, "Error")

        End Try
    End Sub
End Class