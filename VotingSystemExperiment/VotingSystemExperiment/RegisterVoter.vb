Imports MySql.Data.MySqlClient
Public Class RegisterVoter
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Public val As String
    Public val1 As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ModifyBttn.Click
        Modify.Show()
    End Sub

    Private Sub RegisterBttn_Click(sender As Object, e As EventArgs) Handles RegisterBttn.Click
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Try
            con.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE `tbl_voters`
                                SET `State`='1'
                                WHERE  `Voter_ID`='" & TextBox2.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub RegisterVoter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `State`, `Fname`, `MName`, `Lname`,`Year`,`Section` 
                     FROM `tbl_voters` 
                     where `ATYPE`='0'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `State`, `Fname`, `MName`, `Lname`,`Year`,`Section`, `State` 
                    FROM `tbl_voters` 
                    where `Voter_ID`='" & TextBox1.Text & "'"
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim query1 As String
        Dim data1 As New DataTable
        Dim source1 As New BindingSource
        If TextBox1.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query1 = "SELECT `Voter_ID`, `State`, `Fname`, `MName`, `Lname`,`Year`,`Section`, `State` FROM `tbl_voters` where ATYPE='0'"
                com = New MySqlCommand(query1, conn)
                adapt.SelectCommand = com
                adapt.Fill(data1)
                source1.DataSource = data1
                DataGridView1.DataSource = source1
                adapt.Update(data1)
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
            cmd.CommandText = "DELETE FROM `tbl_voters` WHERE `Voter_ID`= '" & TextBox2.Text & "'"
            Dim result = MsgBox("ARE YOU SURE YOU WANT TO DELETE THIS VOTER?", MessageBoxButtons.YesNo, "DELETING RECORD")
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
        Finally
            con.Close()
        End Try
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "SELECT `Voter_ID`, `State`, `Fname`, `MName`, `Lname`,`Year`,`Section`, `State` FROM `tbl_voters`"
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
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            Modify.id = row.Cells(0).Value.ToString()
            Modify.fn = row.Cells(1).Value.ToString()
            Modify.mn = row.Cells(2).Value.ToString()
            Modify.ln = row.Cells(3).Value.ToString()
            Modify.yr = row.Cells(4).Value.ToString()
            Modify.sc = row.Cells(5).Value.ToString()
            Modify.val = TextBox2.Text
            Modify.val1 = val
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `State`, `Fname`, `MName`, `Lname`,`Year`,`Section`, `State` FROM `tbl_voters` where `ATYPE`='0'"
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