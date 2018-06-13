Imports MySql.Data.MySqlClient
Public Class PartyListView
    Public val As Integer
    Public val2 As Integer
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private Sub PartyListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If val2 = 1 Then
            Me.Size = New Size(456, 474)
            ShowPartylist(DataGridView1, 1)
        End If
        If val2 = 2 Then
            Me.Size = New Size(456, 474)
            ShowPartylist(DataGridView1, 2)
        End If
    End Sub
End Class