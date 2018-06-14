Imports MySql.Data.MySqlClient
Public Class Login
    Private query As MySqlCommand
    Private conn As MySqlConnection
    Private READER As MySqlDataReader
    Private comm As MySqlCommand
    Public id As String
    Public id2 As String
    Public id3 As String
    Public id4 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisterForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query3 As String
        conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
        Try
            conn.Open()
            query3 = "SELECT`v_id` FROM `tbl_votingtrail` WHERE `v_id`='" & TextBox1.Text & "'"
            comm = New MySqlCommand(query3, conn)
            READER = comm.ExecuteReader
            Dim count3 As Integer
            count3 = 0
            While READER.Read
                count3 = count3 + 1
            End While
            If count3 = 1 Then
                MsgBox("NAKABOTO KANA! WAG KANG MADAYA!")
            Else
                'check if user and pass is correct
                Dim query As String
                conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
                Try
                    conn.Open()
                    query = "SELECT `Voter_ID`, `PASSWORD` FROM `tbl_voters` WHERE `Voter_ID`='" & TextBox1.Text & "' and `PASSWORD`='" & TextBox2.Text & "'"
                    comm = New MySqlCommand(query, conn)
                    READER = comm.ExecuteReader
                    Dim count As Integer
                    count = 0
                    While READER.Read
                        count = count + 1
                    End While
                    If count = 1 Then
                        'check if the account is admin or voter
                        Dim query1 As String
                        conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
                        Try
                            conn.Open()
                            query1 = "SELECT `ATYPE` FROM `tbl_voters` WHERE `Voter_ID`='" & TextBox1.Text & "' and `ATYPE`='0'"
                            comm = New MySqlCommand(query1, conn)
                            READER = comm.ExecuteReader
                            Dim count1 As Integer
                            count1 = 0
                            While READER.Read
                                count1 = count1 + 1
                            End While
                            If count1 = 1 Then
                                'check if voter is ok to vote or not
                                Dim query2 As String
                                conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
                                Try
                                    conn.Open()
                                    query2 = "SELECT `State` FROM `tbl_voters` WHERE `Voter_ID`='" & TextBox1.Text & "' and `State`='0'"
                                    comm = New MySqlCommand(query2, conn)
                                    READER = comm.ExecuteReader
                                    Dim count2 As Integer
                                    count2 = 0
                                    While READER.Read
                                        count2 = count2 + 1
                                    End While
                                    If count2 = 1 Then
                                        MsgBox("PLEASE WAIT FOR THE ADMIN TO ACTIVATE YOUR ACCOUNT BEFORE YOU CAN USE YOUR ACCOUNT")
                                    Else
                                        TextBox1.Text = Nothing
                                        TextBox2.Text = Nothing
                                        VotingView.Show()
                                    End If
                                    conn.Close()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                Finally
                                    conn.Dispose()
                                End Try
                            Else
                                TextBox1.Text = Nothing
                                TextBox2.Text = Nothing
                                Admin_View.Show()
                            End If
                            conn.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally
                            conn.Dispose()
                        End Try
                    Else
                        MessageBox.Show("WRONG USERNAME OR PASSWORD")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        TextBox1.Text = id
        VotingView.id2 = id

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class