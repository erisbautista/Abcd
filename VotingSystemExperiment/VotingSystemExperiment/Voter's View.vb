Imports MySql.Data.MySqlClient
Public Class VotingView
    Private conn As New MySqlConnection
    Private read As MySqlDataReader
    Private sql As String
    Private adapts As New MySqlDataAdapter
    Private com As New MySqlCommand

    Private Sub BttnPartyList1_Click(sender As Object, e As EventArgs) Handles BttnPartyList1.Click

    End Sub

    Private Sub VotingView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PresidentBttn_Click(sender As Object, e As EventArgs) Handles PresidentBttn.Click
        Panel1.Show()
    End Sub
End Class
