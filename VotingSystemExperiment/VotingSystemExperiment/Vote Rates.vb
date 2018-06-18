Imports MySql.Data.MySqlClient
Public Class VoteRate
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private reader As MySqlDataReader
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
                ComboBox1.Items.Add(row.Item("Name").ToString())
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
                ComboBox2.Items.Add(row.Item("PartyListName").ToString())
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT tbl_candidates.c_name, position.Name, tbl_candidates.vote, partylist.PartyListName
                    FROM ((tbl_candidates 
                    INNER JOIN position ON position.c_pos = tbl_candidates.c_pos) 
                    INNER JOIN partylist on partylist.ID = tbl_candidates.p_name)"
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

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        If ComboBox1.Text = "" And ComboBox2.Text <> Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName,tbl_candidates.vote 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
            where partylist.PartyListName='" & ComboBox2.Text & "'"
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
        ElseIf ComboBox2.Text = "" And ComboBox1.Text <> Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName,tbl_candidates.vote
                         FROM ((tbl_candidates 
                         INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
                         INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
                         where position.Name='" & ComboBox1.Text & "'"
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
        ElseIf ComboBox1.Text = Nothing And ComboBox2.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "SELECT tbl_candidates.c_name, position.Name, partylist.PartyListName,tbl_candidates.vote
                    FROM ((tbl_candidates 
                    INNER JOIN position ON position.c_pos = tbl_candidates.c_pos) 
                    INNER JOIN partylist on partylist.ID = tbl_candidates.p_name)"
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
                query = "SELECT tbl_candidates.c_name, position.Name, partylist.PartyListName, tbl_candidates.vote
                    FROM ((tbl_candidates 
                    INNER JOIN position ON position.c_pos = tbl_candidates.c_pos) 
                    INNER JOIN partylist on partylist.ID = tbl_candidates.p_name)
                    where position.Name='" & ComboBox1.Text & "' and partylist.PartyListName='" & ComboBox2.Text & "'"
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
        If ComboBox1.Text = "" And ComboBox2.Text <> Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName,tbl_candidates.vote 
            FROM ((tbl_candidates 
            INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
            INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
            where partylist.PartyListName='" & ComboBox2.Text & "'"
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
        ElseIf ComboBox2.Text = "" And ComboBox1.Text <> Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "Select tbl_candidates.c_name, position.Name, partylist.PartyListName, tbl_candidates.vote 
                         FROM ((tbl_candidates 
                         INNER JOIN position On position.c_pos = tbl_candidates.c_pos) 
                         INNER JOIN partylist On partylist.ID = tbl_candidates.p_name)
                         where position.Name='" & ComboBox1.Text & "'"
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
        ElseIf ComboBox1.Text = Nothing And ComboBox2.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "SELECT tbl_candidates.c_name, position.Name, partylist.PartyListName, tbl_candidates.vote
                    FROM ((tbl_candidates 
                    INNER JOIN position ON position.c_pos = tbl_candidates.c_pos) 
                    INNER JOIN partylist on partylist.ID = tbl_candidates.p_name)"
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
                query = "SELECT tbl_candidates.c_name, position.Name, partylist.PartyListName, tbl_candidates.vote
                    FROM ((tbl_candidates 
                    INNER JOIN position ON position.c_pos = tbl_candidates.c_pos) 
                    INNER JOIN partylist on partylist.ID = tbl_candidates.p_name)
                    where position.Name='" & ComboBox1.Text & "' and partylist.PartyListName='" & ComboBox2.Text & "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowResult.Show()
    End Sub
End Class