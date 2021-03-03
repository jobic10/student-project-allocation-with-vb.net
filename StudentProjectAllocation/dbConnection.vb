
Imports MySql.Data.MySqlClient 'Very Important

Module dbConnection

    Public conn As MySqlConnection = New MySqlConnection
    Public conn2 As MySqlConnection = New MySqlConnection
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String
    Public obj As Object
    Public mysqli_num_rows As Integer = -1
    Public Sub ConnectDatabase()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;userid=comsit;port=3306;password=justguess;database=student_project_allocation"
                conn.Open()
            End If

        Catch myerror As Exception
            MsgBox("Connection Error")
            End
        End Try
    End Sub
    Public Sub DisconnectDatabase()
        Try
            conn.Close()
            'dr.Close()
            ds.Clear()
            cmd.Parameters.Clear()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub
    Public Sub Query(Optional ByVal type = "I")
        mysqli_num_rows = -1
        Try
            ConnectDatabase()
            cmd.Connection = conn
            'conn.Open()
            'dr = cmd.ExecuteReader
            type = UCase(type)
            If (type = "I" Or type = "D") Then 'insert/delete
                mysqli_num_rows = cmd.ExecuteNonQuery()
            ElseIf (type = "A") Then
                dr = cmd.ExecuteReader()

                obj = cmd.ExecuteScalar()
            End If
            cmd.Parameters.Clear()

        Catch ex As Exception
            ' showError("Error Occured " & ex.ToString())
        Finally
            If (Not type = "A") Then
                DisconnectDatabase()
            End If
        End Try
    End Sub


End Module
