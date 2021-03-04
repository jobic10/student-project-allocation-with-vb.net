Imports MySql.Data.MySqlClient
Public Class frmAllocation
    Private Sub cmdAllocate_Click(sender As Object, e As EventArgs) Handles cmdAllocate.Click
        If MsgBox("This action re-shuffles previous allocation" & "Proceed?", vbYesNo) = vbYes Then
            'For Each Student, Select Supervisor At Random And Allocate. Then Refresh The Table
            Try
                'DisconnectDatabase()
                'dr.Close()
                conn.Close()
                cmd.CommandText = "SELECT * FROM students"
                Try
                    If Not dr.IsClosed Then
                        dr.Close()
                    End If

                Catch ex As Exception

                End Try
                Query("A")
                conn2.ConnectionString = "server=localhost;userid=comsit;port=3306;password=justguess;database=student_project_allocation"

                Do While dr.Read
                    Dim c As MySqlCommand = New MySqlCommand

                    c.CommandText = "UPDATE students SET supervisor_id = (SELECT id FROM supervisors ORDER BY RAND() LIMIT 1)"
                    If conn2.State = ConnectionState.Closed Then
                        conn2.Open()
                    End If
                    c.Connection = conn2
                    c.ExecuteNonQuery()
                    'd 'r_2 = c.ExecuteReader()
                    'showInfo(dr.Item("fullname").ToString() & " For " & dr_2.Item("id").ToString())
                    'c.Parameters.Clear()
                    'dr_2.Close()
                Loop
                loadData()

            Catch ex As Exception
                showError(ex.ToString())
            Finally
                'dr.Close()
                conn2.Close()

            End Try
        Else
            showInfo("Action Halted")
        End If
    End Sub
    Public Sub loadData()
        'DisconnectDatabase()
        'dr.Close()
        Try
            If Not dr.IsClosed Then
                dr.Close()
            End If
        Catch ex As Exception

        End Try

        ConnectDatabase()
        Dim ds As New DataSet()
        Dim ds2 As New DataSet()
        Dim adapter As New MySqlDataAdapter("SELECT students.fullname as 'Full Name', students.regno as 'Matric No', supervisors.fullname as 'Supervisor' FROM students INNER JOIN supervisors ON supervisors.id = students.supervisor_id", conn)
        Dim adapter2 As New MySqlDataAdapter("SELECT supervisors.fullname as 'Supervisor Full Name', Count(students.supervisor_id) as 'Allocated Students'  FROM supervisors left JOin students ON students.supervisor_id = supervisors.id group by supervisors.id", conn)
        adapter.Fill(ds, "Students")
        adapter2.Fill(ds2, "Supervisors")
        gridStudents.DataSource = ds.Tables(0)
        gridSupervisor.DataSource = ds2.Tables(0)
        DisconnectDatabase()
    End Sub

    Private Sub frmAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        DisconnectDatabase()
    End Sub

    Private Sub cmdViewStudents_Click(sender As Object, e As EventArgs) Handles cmdViewStudents.Click
        gridStudents.Visible = Not gridStudents.Visible
    End Sub

    Private Sub cmdViewSupervisors_Click(sender As Object, e As EventArgs) Handles cmdViewSupervisors.Click
        gridSupervisor.Visible = Not gridSupervisor.Visible
    End Sub
End Class