Imports MySql.Data.MySqlClient

Public Class addStudent
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim regno As String = ""
        Dim fullname As String = ""
        Try
            regno = txtRegNo.Text
            fullname = txtFullName.Text
            If regno = "" Or fullname = "" Then
                showError("Please fill all fields")
                Return
            End If
            cmd.CommandText = "INSERT INTO students (fullname, regno) VALUES (@fullname,@regno)"
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@regno", regno)
            Query()
            If mysqli_num_rows > 0 Then
                loadData()
                showInfo("New Student Has Been Created")
                cmdReset.PerformClick()


            Else
                showError("Student could not be added. Duplicate Regno No ")
            End If
        Catch ex As Exception
            showError(ex.ToString())
        End Try
    End Sub

    Private Sub addSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Public Sub loadData()
        ConnectDatabase()
        Dim ds As New DataSet()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM students", conn)
        adapter.Fill(ds, "Students")
        allSup.DataSource = ds.Tables(0)

        DisconnectDatabase()
    End Sub

    Private Sub allSup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles allSup.CellContentClick
        Dim row As DataGridViewRow = allSup.CurrentRow
        txtId.Text = row.Cells(0).Value.ToString()
        txtRegNo.Text = row.Cells(2).Value.ToString()
        txtFullName.Text = row.Cells(1).Value.ToString()
        cmdAdd.Visible = False
        cmdUpdate.Visible = True
        cmdDelete.Visible = True
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtId.Text = ""
        txtRegNo.Text = ""
        txtFullName.Text = ""
        cmdAdd.Visible = True
        cmdUpdate.Visible = False
        cmdDelete.Visible = False
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim regno As String = ""
        Dim fullname As String = ""
        Dim id As String = ""
        Try
            regno = txtRegNo.Text
            fullname = txtFullName.Text
            id = txtId.Text
            If regno = "" Or fullname = "" Then
                showError("Please fill all fields")
                Return
            End If
            cmd.CommandText = "UPDATE students SET fullname=@fullname, regno=@regno WHERE id=@id"
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@regno", regno)
            cmd.Parameters.AddWithValue("@id", id)
            Query()
            If mysqli_num_rows > 0 Then
                loadData()
                showInfo("Student's Details Has Been Updated")
                cmdReset.PerformClick()

            Else
                showError("Student's details could not be updated. Duplicate Reg No ")
            End If
        Catch ex As Exception
            showError(ex.ToString())
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure you want to delete this Student? ", vbYesNo) = vbYes Then
            Dim id As String = ""
            Try
                id = txtId.Text
                If id = "" Then
                    showError("Invalid Student Selected")
                    Return
                End If
                cmd.CommandText = "DELETE FROM students WHERE id=@id"
                cmd.Parameters.AddWithValue("@id", id)
                Query()
                If mysqli_num_rows > 0 Then
                    loadData()
                    showInfo("Student has been deleted")
                    cmdReset.PerformClick()

                Else
                    showError("Student could not be deleted. ")
                End If
            Catch ex As Exception
                showError(ex.ToString())
            End Try
        Else
            showInfo("Action cancelled.")
        End If


    End Sub
End Class