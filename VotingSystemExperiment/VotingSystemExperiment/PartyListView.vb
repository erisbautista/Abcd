Imports MySql.Data.MySqlClient
Public Class PartyListView
    Public val2 As Integer
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Dim currentTime As System.DateTime = System.DateTime.Now
    Public qwe As String
    Private Sub PartyListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If val2 = 1 Then
            Label1.Text = " SUGOD "
            ShowPartylist(DataGridView1, 1)
        End If
        If val2 = 2 Then
            Label1.Text = "VALOR PARTY"
            ShowPartylist(DataGridView1, 2)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = MsgBox("are you use you want to vote straight this partylis?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                com.Connection = conn
                com.CommandText = "UPDATE `tbl_candidates` SET `vote`=`vote`+ 1 WHERE `p_name`='" & val2 & "'"
                com.ExecuteNonQuery()
                MsgBox("THANK YOU FOR YOUR VOTE!",, "SUCCESSFULLY VOTED")
                Try
                    conn.Close()
                    conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                    conn.Open()
                    com.Connection = conn
                    com.CommandText = "INSERT INTO `tbl_trail`(`user`, `action`, `time_act`) VALUES ('" & qwe & "','VOTED','" & currentTime.Date & " " & currentTime.Hour & ":" & currentTime.Minute & "')"
                    Me.Hide()
                    VotingView.Hide()
                    com.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
                Finally
                    conn.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class