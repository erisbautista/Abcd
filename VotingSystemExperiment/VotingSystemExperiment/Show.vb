Imports MySql.Data.MySqlClient
Module Show
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private read As MySqlDataReader
    Private adapt As New MySqlDataAdapter
    Private name As String
    Private pos As Integer
    Private query As String
    Dim arrImage() As Byte
    Sub ShowPartylist(ByRef DGV As DataGridView, ByRef val As Integer)
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        query = " Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name) 
            WHERE tbl_candidates.p_name ='" & val & "'"
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            conn.Open()
            com.Connection = conn
            com.CommandText = query
            adapt.SelectCommand = com
            adapt.Fill(data)
            source.DataSource = data
            DGV.DataSource = source
            adapt.Update(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
