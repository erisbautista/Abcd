Imports MySql.Data.MySqlClient
Public Class Modify
    Public val As String
    Public val1 As String
    Private query As MySqlCommand
    Private conn As MySqlConnection
    Private READER As MySqlDataReader
    Private com As MySqlCommand
    Private adapt As New MySqlDataAdapter
    Public id As String
    Public fn As String
    Public ln As String
    Public mn As String
    Public yr As String
    Public sc As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result = MsgBox("ARE YOU SURE YOU WANT TO CLEAR?", MessageBoxButtons.YesNo,)
        If result = DialogResult.Yes Then
            TxtBoxFN.Text = Nothing
            TxtBoxLN.Text = Nothing
            TxtBoxMN.Text = Nothing
            TxtBoxPW.Text = Nothing
            TxtBoxVID.Text = Nothing
            TxtConPW.Text = Nothing
            CBSection.Text = Nothing
            CBYear.Text = Nothing
        End If
    End Sub

    Private Sub TxtConPW_TextChanged(sender As Object, e As EventArgs) Handles TxtConPW.TextChanged
        If TxtBoxPW.Text = TxtConPW.Text Then
            Panel4.Visible = True
            Panel3.Visible = False
        Else
            Panel3.Visible = True
            Panel4.Visible = False
        End If
    End Sub

    Private Sub BttnProceed_Click(sender As Object, e As EventArgs) Handles BttnProceed.Click
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Try
            con.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            con.Open()
            If Panel4.Visible = True Then
                cmd.Connection = con
                cmd.CommandText = "UPDATE `tbl_voters` SET `Voter_ID`='" & TxtBoxVID.Text & "',`Fname`='" & TxtBoxFN.Text & "',`MName`='" & TxtBoxMN.Text & "',`Lname`='" & TxtBoxLN.Text & "',`PASSWORD`='" & TxtBoxPW.Text & "',`Year`='" & CBYear.Text & "',`Section`='" & CBSection.Text & "' WHERE `Voter_ID`='" & id & "'"
                cmd.ExecuteNonQuery()
            Else
                MsgBox("PASSWORD DOESNT MATCH!")
                con.Close()
            End If
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try
        Me.Hide()
    End Sub

    Private Sub Modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxFN.Text = fn
        TxtBoxLN.Text = ln
        TxtBoxMN.Text = mn
        TxtBoxVID.Text = id
        CBSection.Text = sc
        CBYear.Text = yr
    End Sub
End Class