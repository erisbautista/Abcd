Imports MySql.Data.MySqlClient
Public Class UpdateCandidate
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private READER As MySqlDataReader
    Public z As String
    Private pos As String
    Private part As String
    Private Sub BttnAdd_Click(sender As Object, e As EventArgs) Handles BttnAdd.Click
        Dim query As String
        Dim dsToBeFilled As New DataSet
        If ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Or TxtBoxLN.Text = Nothing Or TxtBoxFn.Text = Nothing Or TxtBoxMN.Text = Nothing Or TextBox4.Text = Nothing Then
            MsgBox("PLEASE FILL UP ALL THE FORM FIRST!")
        Else
            conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
            Try
                conn.Open()
                query = "SELECT `c_pos` FROM `position` WHERE `Name`='" & ComboBox2.Text & "'"
                com = New MySqlCommand(query, conn)
                adapt.SelectCommand = com
                adapt.Fill(dsToBeFilled)
                READER = com.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While
                If count = 1 Then
                    For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                        pos = row.Item("c_pos").ToString()
                    Next
                Else

                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
            Try
                conn.Open()
                query = "SELECT `ID` FROM partylist WHERE `PartyListName` ='" & ComboBox1.Text & "'"
                com = New MySqlCommand(query, conn)
                adapt.SelectCommand = com
                adapt.Fill(dsToBeFilled)
                READER = com.ExecuteReader
                Dim count1 As Integer
                count1 = 0
                While READER.Read
                    count1 = count1 + 1
                End While
                If count1 = 1 Then
                    For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                        part = row.Item("ID").ToString()
                    Next
                Else

                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            Try
                conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
                conn.Open()
                com.Connection = conn
                com.CommandText = "UPDATE `tbl_candidates` SET `c_name`=concat('" & TxtBoxLN.Text & "', + ' ', '" & TxtBoxFn.Text & "', + ' ', '" & TxtBoxMN.Text & "'),`c_pos`='" & pos & "',`p_name`='" & part & "', `profile`='" & TextBox4.Text & "',`photo`=@photo) where `c_name`='" & z & "'"
                com.Parameters.AddWithValue("@photo", PictureBox1.Image)
                com.ExecuteNonQuery()
                MsgBox("Successfully MODIFIED")
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Dim arrImage() As Byte
        Dim profile As String
        Try
            PictureBox1.Image = Nothing
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `photo`, `profile` FROM `tbl_candidates` WHERE `c_name` ='" & z & "'"
            conn.Open()
            com = New MySqlCommand(sql, conn)
            READER = com.ExecuteReader()
            READER.Read()
            arrImage = READER.Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            If mstream Is Nothing Then

            Else
                PictureBox1.Image = Image.FromStream(mstream)
            End If
            profile = READER.Item("profile")
            TextBox4.Text = profile
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Dim sql2 As String
        Dim dsToBeFilled2 As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql2 = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM((tbl_candidates 
            INNER Join position On position.c_pos = tbl_candidates.c_pos) 
            INNER Join partylist On partylist.ID = tbl_candidates.p_name) 
            where `c_name`='" & z & "'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql2
            adapt.SelectCommand = com
            adapt.Fill(dsToBeFilled2)
            For Each row As DataRow In dsToBeFilled2.Tables(0).Rows
                ComboBox2.Text = row.Item("Name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Dim sql1 As String
        Dim dsToBeFilled1 As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql1 = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM((tbl_candidates 
            INNER Join position On position.c_pos = tbl_candidates.c_pos) 
            INNER Join partylist On partylist.ID = tbl_candidates.p_name) 
            where `c_name`='" & z & "'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapt.SelectCommand = com
            adapt.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                ComboBox1.Text = row.Item("PartyListName").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Dim strArr As String()
        If z.Contains(" ") Then
            strArr = z.Split(" ")
            If strArr.Length = 3 Then
                TxtBoxFn.Text = strArr(0)
                TxtBoxLN.Text = strArr(2)
                TxtBoxMN.Text = strArr(1)
            ElseIf strArr.Length = 2 Then
                TxtBoxFn.Text = strArr(0)
                TxtBoxLN.Text = strArr(1)
            ElseIf strArr.Length = 4 Then
                TxtBoxFn.Text = strArr(0) & " " & strArr(1)
                TxtBoxLN.Text = strArr(3)
                TxtBoxMN.Text = strArr(2)
            End If
        Else
                TxtBoxFn.Text = z
            TxtBoxLN.Text = ""
            TxtBoxMN.Text = ""
        End If
    End Sub

    Private Sub BttnClear_Click(sender As Object, e As EventArgs) Handles BttnClear.Click
        Dim result = MsgBox("ARE YOU  USE YOU WANT TO CLEAR ALL THE INFORMATION INSERTED?", MessageBoxButtons.YesNo, " CLEARING CANNOT BE UNDO!")
        If result = DialogResult.Yes Then
            PictureBox1.Image = Nothing
            TextBox4.Text = Nothing
            TxtBoxFn.Text = Nothing
            TxtBoxLN.Text = Nothing
            TxtBoxMN.Text = Nothing
            ComboBox1.Text = Nothing
            ComboBox2.Text = Nothing
        End If
    End Sub
End Class