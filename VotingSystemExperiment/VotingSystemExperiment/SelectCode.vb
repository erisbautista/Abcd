Imports MySql.Data.MySqlClient
Module SelectCode
    Private READER As MySqlDataReader
    Private adapt As New MySqlDataAdapter
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Sub Code(ByRef query As String, ByRef b As String, ByRef c As String, ByRef label1 As Label, ByRef label2 As Label)
        b = Nothing
        c = Nothing
        conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
        Try
            conn.Open()
            com = New MySqlCommand(query, conn)
            READER = com.ExecuteReader
            READER.Read()
            b = READER.Item("c_name")
            c = READER.Item("vote")
            label1.Text = b
            label2.Text = c
            READER.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            conn.Close()
        End Try
    End Sub
End Module
