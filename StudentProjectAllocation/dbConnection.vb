
Imports MySql.Data.MySqlClient 'Very Important

Module dbConnection

    Sub Main()
        Dim Connexion As New MySqlConnection
        Dim db_name As String = "stockage"
        Dim db_host As String = "localhost"
        Dim db_username As String = "pma"
        Dim db_password As String = "pmapass"

        If Not Connexion Is Nothing Then Connexion.Close() 'to close already open connections
        Connexion.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", db_host, db_username, db_password, db_name)

        Try
            Connexion.Open()
            Console.WriteLine("Connected to server " + db_host)

            Dim Commande As MySqlCommand
            Dim Requete As String = "UPDATE client SET nom_client ='client unknown' WHERE nom_client is null"

            Commande = New MySqlCommand(Requete, Connexion)
            Console.WriteLine("there was " & Commande.ExecuteNonQuery() & " lines changed")
            Connexion.Close()
            Console.WriteLine("Disconnected from server " + db_host)

        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)

        Finally
            Connexion.Dispose()

        End Try
    End Sub
End Module
