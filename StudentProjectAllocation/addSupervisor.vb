﻿Imports MySql.Data.MySqlClient

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
                loadData()
                showInfo("New Supervisor Has Been Created")
                cmdReset.PerformClick()


            Else
                showError("Supervisor could not be added. Duplicate File No ")
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
        Dim adapter As New MySqlDataAdapter("SELECT * FROM supervisors", conn)
        adapter.Fill(ds, "Supervisors")
        allSup.DataSource = ds.Tables(0)

        DisconnectDatabase()
    End Sub

    Private Sub allSup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles allSup.CellContentClick
        Dim row As DataGridViewRow = allSup.CurrentRow
        txtId.Text = row.Cells(0).Value.ToString()
        txtFileNo.Text = row.Cells(2).Value.ToString()
        txtFullName.Text = row.Cells(1).Value.ToString()
        cmdAdd.Visible = False
        cmdUpdate.Visible = True
        cmdDelete.Visible = True
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtId.Text = ""
        txtFileNo.Text = ""
        txtFullName.Text = ""
        cmdAdd.Visible = True
        cmdUpdate.Visible = False
        cmdDelete.Visible = False
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim fileno As String = ""
        Dim fullname As String = ""
        Dim id As String = ""
        Try
            fileno = txtFileNo.Text
            fullname = txtFullName.Text
            id = txtId.Text
            If fileno = "" Or fullname = "" Then
                showError("Please fill all fields")
                Return
            End If
            cmd.CommandText = "UPDATE supervisors SET fullname=@fullname, fileno=@fileno WHERE id=@id"
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@fileno", fileno)
            cmd.Parameters.AddWithValue("@id", id)
            Query()
            If mysqli_num_rows > 0 Then
                loadData()
                showInfo("Supervisor's Details Has Been Updated")
                cmdReset.PerformClick()

            Else
                showError("Supervisor's details could not be updated. Duplicate File No ")
            End If
        Catch ex As Exception
            showError(ex.ToString())
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure you want to delete this Supervisor? " & vbNewLine & "If this Supervisor has any supervisee(s), it's going to be reset." & vbNewLine & "Proceed ?", vbYesNo) = vbYes Then
            Dim id As String = ""
            Try
                id = txtId.Text
                If id = "" Then
                    showError("Invalid Supervisor Selected")
                    Return
                End If
                cmd.CommandText = "DELETE FROM supervisors WHERE id=@id"
                cmd.Parameters.AddWithValue("@id", id)
                Query()
                If mysqli_num_rows > 0 Then
                    cmd.CommandText = "UPDATE students SET supervisor_id = 0 WHERE supervisor_id=@id"
                    cmd.Parameters.AddWithValue("@id", id)
                    Query()
                    loadData()
                    showInfo("Supervisor has been deleted")
                    cmdReset.PerformClick()

                Else
                    showError("Supervisor could not be deleted. ")
                End If
            Catch ex As Exception
                showError(ex.ToString())
            End Try
        Else
            showInfo("Action cancelled.")
        End If


    End Sub
End Class