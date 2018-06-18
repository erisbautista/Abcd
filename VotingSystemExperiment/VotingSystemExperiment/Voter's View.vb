Imports MySql.Data.MySqlClient
Public Class VotingView
    Private conn As New MySqlConnection
    Private read As MySqlDataReader
    Private sql As String
    Private adapts As New MySqlDataAdapter
    Private com As New MySqlCommand
    Dim temp As Integer
    Public id As String
    Public id2 As String
    Public id3 As String
    Public id4 As String
    Public val2 As Integer
    Private Sub BttnPartyList1_Click(sender As Object, e As EventArgs) Handles BttnPartyList1.Click
        PartyListView.val2 = 1
        PartyListView.Show()
    End Sub

    Private Sub VotingView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PresidentBttn_Click(sender As Object, e As EventArgs) Handles PresidentBttn.Click
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Panel2.Hide()
        Panel1.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='1' and `p_name`='1'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                Button1.Text = row.Item("c_name").ToString()
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
            sql1 = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='1' and `p_name`='2'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                Button2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(Pic1, Button1, Pic2, Button2)
    End Sub

    Private Sub VicePresidentBttn_Click(sender As Object, e As EventArgs) Handles VicePresidentBttn.Click
        Panel2.Hide()
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Panel1.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='2' and `p_name`='1'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                Button1.Text = row.Item("c_name").ToString()


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
            sql1 = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='2' and `p_name`='2'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                Button2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(Pic1, Button1, Pic2, Button2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        temp = 1
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        temp = 2
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub BttnPartyList2_Click(sender As Object, e As EventArgs) Handles BttnPartyList2.Click
        PartyListView.val2 = 2
        PartyListView.Show()
    End Sub

    Private Sub SecBttn_Click(sender As Object, e As EventArgs) Handles SecBttn.Click
        Panel2.Hide()
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Panel1.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='3' and `p_name`='1'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                Button1.Text = row.Item("c_name").ToString()
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
            sql1 = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='3' and `p_name`='2'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                Button2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(Pic1, Button1, Pic2, Button2)
    End Sub

    Private Sub TreasurerBttn_Click(sender As Object, e As EventArgs) Handles TreasurerBttn.Click
        Panel2.Hide()
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Panel1.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='4' and `p_name`='1'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                Button1.Text = row.Item("c_name").ToString()
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
            sql1 = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='4' and `p_name`='2'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                Button2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(Pic1, Button1, Pic2, Button2)
    End Sub

    Private Sub AudBttn_Click(sender As Object, e As EventArgs) Handles AudBttn.Click
        Panel2.Hide()
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Panel1.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='5' and `p_name`='1'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                Button1.Text = row.Item("c_name").ToString()
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
            sql1 = "SELECT `c_name` FROM `tbl_candidates` WHERE `c_pos` ='5' and `p_name`='2'"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql1
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled1)
            For Each row As DataRow In dsToBeFilled1.Tables(0).Rows
                Button2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(Pic1, Button1, Pic2, Button2)
    End Sub

    Private Sub G8Bttn_Click(sender As Object, e As EventArgs) Handles G8Bttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '8' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '8' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '8' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '8' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub PIOBttn_Click(sender As Object, e As EventArgs) Handles PIOBttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '6' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '6' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '6' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '6' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub G9Bttn_Click(sender As Object, e As EventArgs) Handles G9Bttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '9' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '9' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '9' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '9' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub G10Bttn_Click(sender As Object, e As EventArgs) Handles G10Bttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '10' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '10' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '10' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '10' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub G11Bttn_Click(sender As Object, e As EventArgs) Handles G11Bttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '11' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '11' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '11' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '11' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub POBttn_Click(sender As Object, e As EventArgs) Handles POBttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '7' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '7' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '7' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '7' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub G12Bttn_Click(sender As Object, e As EventArgs) Handles G12Bttn.Click
        PicCan1.Image = Nothing
        PicCan2.Image = Nothing
        PicCan3.Image = Nothing
        PicCan4.Image = Nothing
        Panel1.Hide()
        Panel2.Show()
        Dim sql As String
        Dim dsToBeFilled As New DataSet
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '12' LIMIT 1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan1.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '12' LIMIT 1,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan2.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '12' LIMIT 2,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan3.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.ConnectionString = "server=localhost;
                                     user=root; 
                                     database=wbvoting; 
                                     SslMode=none"
            sql = "SELECT `c_name` from tbl_candidates WHERE `c_pos` = '12' LIMIT 3,1"
            conn.Open()
            com.Connection = conn
            com.CommandText = sql
            adapts.SelectCommand = com
            adapts.Fill(dsToBeFilled)
            For Each row As DataRow In dsToBeFilled.Tables(0).Rows
                BttnCan4.Text = row.Item("c_name").ToString()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to the database: " & myerror.Message)
        Finally
            conn.Close()
        End Try
        getIm(PicCan1, BttnCan1, PicCan2, BttnCan2)
        getIm(PicCan3, BttnCan3, PicCan4, BttnCan4)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If temp = 1 Then
            Dim query As String
            Dim data As New DataTable
            Dim source As New BindingSource
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = " INSERT INTO 
                             `tbl_votingtrail`(`id`, `v_id`, `action`,  `pos_qty`, `pid`)
                              VALUES('','" & id2 & "','" & Button1.Text & "','" & 1 & "','" & 1 & "')"
            Dim n As String = MsgBox("Do you really want to vote this person?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
            If n = vbYes Then
                MsgBox("Proceed to next candidates to vote....")
                Me.Show() 'Form Name.show()
                com = New MySqlCommand(query, conn)
                adapts.SelectCommand = com
                adapts.Fill(data)
                adapts.Update(data)
                conn.Close()
            End If

        End If
        If temp = 2 Then
            Dim query1 As String
            Dim data1 As New DataTable
            Dim source1 As New BindingSource
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query1 = " INSERT INTO 
                             `tbl_votingtrail`( `v_id`, `action`,  `pos_qty`, `pid`)
                              VALUES('" & id2 & "','" & Button2.Text & "','" & 1 & "','" & 1 & "')"
                Dim n As String = MsgBox("Do you really want to vote this person?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
                If n = vbYes Then
                    MsgBox("Proceed to next candidates to vote....")
                    com = New MySqlCommand(query1, conn)
                    adapts.SelectCommand = com
                    adapts.Fill(data1)
                    adapts.Update(data1)
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            End Try
        End If
    End Sub
End Class
