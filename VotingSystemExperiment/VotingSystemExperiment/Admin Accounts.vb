Imports MySql.Data.MySqlClient
Public Class AdminViewer
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Public id As String
    Public fn As String
    Public ln As String
    Public mn As String
    Private Sub AdminViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.Close()
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `Fname`, `MName`, `Lname`, `ATYPE` FROM `tbl_voters`"
            com = New MySqlCommand(query, conn)
            adapt.SelectCommand = com
            adapt.Fill(data)
            source.DataSource = data
            DataGridView1.DataSource = source
            adapt.Update(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BttnDelete_Click(sender As Object, e As EventArgs) Handles BttnDelete.Click
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Try
            conn.Close()
            con.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `tbl_voters` WHERE `Voter_ID`= '" & TextBox2.Text & "'"
            Dim result = MsgBox("ARE YOU SURE YOU WANT TO DELETE THIS VOTER?", MessageBoxButtons.YesNo, "DELETING RECORD")
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
        End Try
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        If TextBoxUS.Text = Nothing Then
            Try
                conn.Close()
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "SELECT `Voter_ID`, `State`, `Fname`, `MName`, `Lname`,`Year`,`Section` FROM `tbl_voters`"
                com = New MySqlCommand(query, conn)
                adapt.SelectCommand = com
                adapt.Fill(data)
                source.DataSource = data
                DataGridView1.DataSource = source
                adapt.Update(data)
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub ModifyBttn_Click(sender As Object, e As EventArgs) Handles ModifyBttn.Click
        Try
            conn.Close()
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            com.Connection = conn
            If ComboBox1.Text = "Administrator" Then
                com.CommandText = "UPDATE `tbl_voters` Set `Voter_ID`='" & TextBoxUS.Text & "',`Fname`='" & TextBoxFN.Text & "',`MName`='" & TextBoxMN.Text & "',`Lname`='" & TextBoxLN.Text & "',`PASSWORD`='" & TextBoxPW.Text & "',`ATYPE`='1' Where `Voter_ID`='" & TextBox2.Text & "'"
                com.ExecuteNonQuery()
                MsgBox("INFO UPDATED!")
                conn.Close()
            ElseIf ComboBox1.Text = "Voter" Then
                com.CommandText = "UPDATE `tbl_voters` Set `Voter_ID`='" & TextBoxUS.Text & "',`Fname`='" & TextBoxFN.Text & "',`MName`='" & TextBoxMN.Text & "',`Lname`='" & TextBoxLN.Text & "',`PASSWORD`='" & TextBoxPW.Text & "',`ATYPE`='0' Where `Voter_ID`='" & TextBox2.Text & "'"
                com.ExecuteNonQuery()
                MsgBox("INFO UPDATED!")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error While inserting record On table..." & ex.Message, "Insert Records")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub RegisterBttn_Click(sender As Object, e As EventArgs) Handles RegisterBttn.Click
        Try
            conn.Close()
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            com.Connection = conn
            If ComboBox1.Text = "Administrator" Then
                com.CommandText = "INSERT INTO `tbl_voters`(`Voter_ID`, `Fname`, `MName`, `Lname`, `PASSWORD`, `ATYPE`) VALUES ('" & TextBoxUS.Text & "','" & TextBoxFN.Text & "','" & TextBoxMN.Text & "','" & TextBoxLN.Text & "','" & TextBoxPW.Text & "','1')"
                com.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY ADDED!")
                conn.Close()
            ElseIf ComboBox1.Text = "Voter" Then
                com.CommandText = "INSERT INTO `tbl_voters`(`Voter_ID`, `Fname`, `MName`, `Lname`, `PASSWORD`, `ATYPE`) VALUES ('" & TextBoxUS.Text & "','" & TextBoxFN.Text & "','" & TextBoxMN.Text & "','" & TextBoxLN.Text & "','" & TextBoxPW.Text & "','0')"
                com.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY ADDED!")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error While inserting record On table..." & ex.Message, "Insert Records")
        End Try
        TextBoxLN.Text = Nothing
        TextBoxFN.Text = Nothing
        TextBoxMN.Text = Nothing
        TextBoxUS.Text = Nothing
        TextBoxPW.Text = Nothing
        ComboBox1.Text = Nothing
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox2.Text = DataGridView1.Item(0, i).Value
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBoxLN.Text = row.Cells(3).Value.ToString()
            TextBoxFN.Text = row.Cells(1).Value.ToString()
            TextBoxMN.Text = row.Cells(2).Value.ToString()
            TextBoxUS.Text = row.Cells(0).Value.ToString()
            If row.Cells(4).Value.ToString = True Then
                ComboBox1.Text = ComboBox1.Items(0)
            Else
                ComboBox1.Text = ComboBox1.Items(1)
            End If
        Catch ex As Exception
        End Try
        Dim query As String
        Dim reader As MySqlDataReader
        conn.Close()
        conn = New MySqlConnection("server=127.0.0.1; user=root;  database=wbvoting; port=3306; SslMode=none")
        Try
            conn.Open()
            query = "Select * FROM `tbl_voters` where `Voter_ID`='" & TextBoxUS.Text & "'"
            com = New MySqlCommand(query, conn)
            reader = com.ExecuteReader
            While reader.Read()
                TextBoxPW.Text = reader("PASSWORD").ToString()
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.Close()
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `Fname`, `MName`, `Lname`, `ATYPE` FROM `tbl_voters`"
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