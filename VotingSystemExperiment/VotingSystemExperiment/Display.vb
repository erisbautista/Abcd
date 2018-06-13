Imports MySql.Data.MySqlClient
Module Display

    Sub Combo(ByRef num As Integer, ByRef combobox As ComboBox)
        combobox.Items.Clear()
        Dim conn As New MySqlConnection
        Dim sql As String
        Dim adapts As New MySqlDataAdapter
        Dim com As New MySqlCommand
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT c_name 
                   FROM tbl_candidates 
                    where c_pos='" & num & "'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                combobox.Items.Add(row.Item("c_name").ToString())
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
