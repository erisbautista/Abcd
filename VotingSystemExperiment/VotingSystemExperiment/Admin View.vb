Imports MySql.Data.MySqlClient
Public Class Admin_View
    Public val As String
    Public val2 As String
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        candidate.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegisterVoter.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VoteRate.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminViewer.Show()
    End Sub
End Class