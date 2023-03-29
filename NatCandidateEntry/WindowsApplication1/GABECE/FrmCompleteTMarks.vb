Public Class FrmCompleteTMarks
    Dim con As New ConClass
    Dim cflag, mflag, A As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TxtCentCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentCode.TextChanged
        
        Dim cflag As String = "c"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from TASSMARKS where PAPERCODE = '" & myexaminer1 & "'and Flag like'" & cflag & "%'and  CENTCODE ='" & TxtCentCode.Text & "'order by PAPERCODE,CENTCODE,INDEXNO", con.con)
        da.Fill(ds, "TASSMARKS")
        Complete_Recs.DataSource = ds.Tables("TASSMARKS")
        Complete_Recs.ReadOnly = True
    End Sub

    Private Sub txtCandNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandNo.TextChanged
        Dim cflag As String = "c"

        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from Subject_Entry_By_Cand where INDEXNO like'" & txtCandNo.Text & "%' and Flag like '" & mflag & "'", con.con)
        da.Fill(ds, "Subject_Entry_By_Cand")
        Complete_Recs.DataSource = ds.Tables("Subject_Entry_By_Cand")
        Complete_Recs.ReadOnly = True
    End Sub
End Class