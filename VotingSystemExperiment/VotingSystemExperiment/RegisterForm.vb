Imports MySql.Data.MySqlClient
Public Class RegisterForm
    Private query As MySqlCommand
    Private conn As MySqlConnection
    Private READER As MySqlDataReader
    Private comm As MySqlCommand
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtBoxPW.Text = Nothing
        Dim num As Integer
        For z As Integer = 0 To 8
            Randomize()
            num = Int(9 * Rnd())
            TxtBoxPW.Text = TxtBoxPW.Text & num
        Next
    End Sub

    Private Sub BttnProceed_Click(sender As Object, e As EventArgs) Handles BttnProceed.Click
        Dim query As String
        If TxtBoxFN.Text = Nothing Or TxtBoxLN.Text = Nothing Or TxtBoxMN.Text = Nothing Or TxtBoxPW.Text = Nothing Or TxtBoxVID.Text = Nothing Then
            MsgBox("LAGYAN MO LAHAT WAG KANG TAMAD!")
        Else
            conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
            conn.Open()
                query = "SELECT `Voter_ID` FROM `tbl_voters` where `Voter_ID`='" & TxtBoxVID.Text & "'"
                comm = New MySqlCommand(query, conn)
                READER = comm.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While
            If count = 1 Then
                MessageBox.Show("EMAIL ALREADY TAKEN")
                conn.Close()
            Else
                conn.Close()

                Try
                    conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                    conn.Open()
                    comm.Connection = conn
                    comm.CommandText = "INSERT INTO `tbl_voters`( `Voter_ID`, `Fname`, `MName`, `Lname`, `PASSWORD`,`Year`,`Section`) 
                                VALUES ('" & TxtBoxVID.Text & " ', '" & TxtBoxFN.Text & "', '" & TxtBoxMN.Text & "' , '" & TxtBoxLN.Text & "', '" & TxtBoxPW.Text & "','" & CBYear.Text & "','" & CBSection.Text & "')"
                    MsgBox("Please Remember The ID and PASSWORD this will be used to login to the system:
                    ID =" & TxtBoxVID.Text & " 
                    Password = " & TxtBoxPW.Text & "
                    AND PLEASE WAIT FOR YOUR FACILITATOR TO ACTIVATE YOUR ACCOUNT!")
                    comm.ExecuteNonQuery()
                    Me.Hide()
                Catch ex As Exception
                    MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub
End Class