Imports MySql.Data.MySqlClient
Module getImage
    Private conn As New MySqlConnection
    Private read As MySqlDataReader
    Private adapts As New MySqlDataAdapter
    Private com As New MySqlCommand
    Sub getIm(ByRef pic As PictureBox, ByRef button1 As Button, ByRef pic2 As PictureBox, ByRef button2 As Button)
        Dim sql As String
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
                   where c_name='" & button1.Text & "'"
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
        Dim sql1 As String
        Dim dsToBeFilled1 As New DataSet
        Dim arrImage1() As Byte
        Try
            pic2.Image = Nothing
            conn.Close()
            conn.ConnectionString = "server=localhost; 
                                     user=root; 
                                     database=wbvoting; 
                                     port=3306;
                                     SslMode=none"
            conn.Open()
            sql1 = "SELECT `photo` 
                   FROM tbl_candidates 
                   where c_name='" & button2.Text & "'"
            com = New MySqlCommand(sql1, conn)
            read = com.ExecuteReader()
            read.Read()
            arrImage1 = read.Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage1)
            pic2.Image = Image.FromStream(mstream)
            read.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module


