Public Class addSupervisor
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim fileno As String = ""
        Dim fullname As String = ""
        Try
            fileno = txtFileNo.Text
            fullname = txtFullName.Text
            If fileno = "" Or fullname = "" Then
                showError("Please fill all fields")
                Return
            End If
            cmd.CommandText = "INSERT INTO supervisors (fullname, fileno) VALUES (@fullname,@fileno)"
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@fileno", fileno)
            Query()
            If mysqli_num_rows > 0 Then
                showInfo("New Supervisor Has Been Created")
            Else
                showError("Supervisor could not be added. Duplicate File No ")
            End If
        Catch ex As Exception
            showError(ex.ToString())
        End Try
    End Sub
End Class