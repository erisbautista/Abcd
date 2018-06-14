Imports MySql.Data.MySqlClient
Public Class AddCandidate
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private READER As MySqlDataReader
    Private pos As String
    Private part As String

    Private Sub AddCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT Name
                   FROM position"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapt.SelectCommand = com
            adapt.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                ComboBox2.Items.Add(row.Item("Name").ToString())
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
            sql1 = "SELECT PartyListName
                   FROM partylist"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapt.SelectCommand = com
            adapt.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                ComboBox1.Items.Add(row.Item("PartyListName").ToString())
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BttnAdd_Click(sender As Object, e As EventArgs) Handles BttnAdd.Click
        Dim query1 As String
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
                query1 = "SELECT `ID` FROM partylist WHERE `PartyListName` ='" & ComboBox1.Text & "'"
                com = New MySqlCommand(query1, conn)
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
                com.CommandText = "INSERT INTO `tbl_candidates`(`c_name`, `c_pos`, `p_name`,`profile`,`photo`) VALUES (concat('" & TxtBoxFn.Text & "', + ' ', '" & TxtBoxMN.Text & "', + ' ', '" & TxtBoxLN.Text & "'),'" & pos & "','" & part & "','" & TextBox4.Text & "',@photo)"
                com.Parameters.AddWithValue("@photo", PictureBox1.Image)
                com.ExecuteNonQuery()
                MsgBox("Successfully Added")
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub BttnBrowse_Click(sender As Object, e As EventArgs) Handles BttnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image((*.JPG;,*.PNG;,*.GIF)|*.jpg;,*.png;,*.gif)"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
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