Imports MySql.Data.MySqlClient
Public Class VoteRate
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private Sub AdminAccountview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT tbl_candidates.c_name, position.Name, tbl_candidates.vote, partylist.PartyListName
                    FROM ((tbl_candidates 
                    INNER JOIN position ON position.c_pos = tbl_candidates.c_pos) 
                    INNER JOIN partylist on partylist.ID = tbl_candidates.p_name) 
                    ORDER BY `tbl_candidates`.`vote` DESC"
            com = New MySqlCommand(query, conn)
            adapt.SelectCommand = com
            adapt.Fill(data)
            source.DataSource = data
            DataGridView1.DataSource = source
            adapt.Update(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub
End Class