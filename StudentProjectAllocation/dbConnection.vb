
Imports MySql.Data.MySqlClient 'Very Important

Module dbConnection

    Public conn As MySqlConnection = New MySqlConnection
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String
    Public obj As Object
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
        Catch myerror As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub
    Public Sub Query()
        Try
            ConnectDatabase()
            cmd.Connection = conn
            'conn.Open()
            'dr = cmd.ExecuteReader
            obj = cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "Error Occured")
        Finally
            DisconnectDatabase()
        End Try
    End Sub
End Module
