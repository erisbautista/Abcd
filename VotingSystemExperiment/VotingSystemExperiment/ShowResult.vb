Imports MySql.Data.MySqlClient
Public Class ShowResult
    Private READER As MySqlDataReader
    Private adapt As New MySqlDataAdapter
    Private b As String
    Private c As String
    Private Sub ShowResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='1')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='1')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", PresName, P)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='2')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='2')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", VSName, V)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='3')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='3')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", SecName, S)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='4')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='4')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", TreaName, T)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='5')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='5')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", AudName, A)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='6')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='6')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", PIOName, PIO)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='6')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='6')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", PIOName2, PIO2)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='7')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='7')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", POName, PO)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='7')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='7')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", POName2, PO2)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='8')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='8')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", G8, G8Vote)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='8')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='8')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", G81, G8Vote2)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='9')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='9')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", G9, G9Vote)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='9')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='9')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", G91, G9Vote2)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='10')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='10')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", G10, G10Vote)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='10')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='10')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", G101, G10Vote2)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='11')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='11')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", G11, G11Vote)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='11')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='11')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", G111, G11Vote2)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='12')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='12')samp1 ORDER by `vote` desc LIMIT 1)", "c_name", "vote", G12, G12Vote)
        Code("SELECT `c_name`,`vote` FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='12')samp WHERE `vote` = (SELECT vote FROM (SELECT * FROM tbl_candidates WHERE `c_pos`='12')samp1 ORDER by `vote` desc LIMIT 1,1)", "c_name", "vote", G121, G12Vote2)
    End Sub
End Class