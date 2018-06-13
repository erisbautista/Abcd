Imports MySql.Data.MySqlClient
Module getImage
    Sub getIm(ByRef pic As PictureBox, ByRef combobox As ComboBox)
        Dim conn As New MySqlConnection
        Dim read As MySqlDataReader
        Dim sql As String
        Dim adapts As New MySqlDataAdapter
        Dim com As New MySqlCommand
        Dim dsToBeFilled As New DataSet
        Dim arrImage() As Byte
        Try
            pic.Image = Nothing
            conn.ConnectionString = "server=localhost; 
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            conn.Open()
            sql = "SELECT `photo` 
                   FROM tbl_candidates 
                   where c_name='" & combobox.Text & "'"
            com = New MySqlCommand(sql, conn)
            read = com.ExecuteReader()
            read.Read()
            arrImage = read.Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pic.Image = Image.FromStream(mstream)
            read.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
