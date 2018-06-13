Imports MySql.Data.MySqlClient
Public Class candidate
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private Sub candidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name) "
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

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        If ComboBox1.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)"
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
        ElseIf ComboBox2.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
                         FROM ((tbl_candidates 
                         INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
                         INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
                         where partylist.`PartyListName`='" & ComboBox1.Text & "'"
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
        Else
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
                         FROM ((tbl_candidates 
                         INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
                         INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
                         where partylist.`PartyListName`='" & ComboBox1.Text & "' and position.Name='" & ComboBox2.Text & "'"
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
        End If
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        If ComboBox2.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)"
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
        ElseIf ComboBox1.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
                         FROM ((tbl_candidates 
                         INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
                         INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
                         where partylist.`PartyListName`='" & ComboBox1.Text & "'"
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
        Else
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
                         FROM ((tbl_candidates 
                         INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
                         INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
                         where partylist.`PartyListName`='" & ComboBox1.Text & "' and position.Name='" & ComboBox2.Text & "'"
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
        End If
    End Sub

    Private Sub BttnDelete_Click(sender As Object, e As EventArgs) Handles BttnDelete.Click
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Try
            con.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `tbl_candidates` WHERE `tbl_candidates`.`c_name`='" & TextBox2.Text & "'"
            Dim result = MsgBox("ARE YOU SURE YOU WANT TO DELETE THIS CANDIDATE?", MessageBoxButtons.YesNo, "DELETING RECORD")
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name) "
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox2.Text = DataGridView1.Item(0, i).Value
    End Sub

    Private Sub RegisterBttn_Click(sender As Object, e As EventArgs) Handles RegisterBttn.Click
        AddCandidate.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ModifyBttn_Click(sender As Object, e As EventArgs) Handles ModifyBttn.Click
        AddCandidate.Show()
    End Sub

End Class