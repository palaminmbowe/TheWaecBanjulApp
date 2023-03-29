Public Class FrmIncompleteTMarks

    Dim con As New ConClass
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TxtCentCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentCode.TextChanged

        Dim cflag As String = "i"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from Subject_Entry_By_Cand where FLAG like'" & cflag & "%' and SUBJCODE like '" & myexaminer1 & "%' and CENTCODE ='" & TxtCentCode.Text & "' order by SUBJCODE,CENTCODE,INDEXNO", con.con)
        da.Fill(ds, "Subject_Entry_By_Cand")
        Incomplete_Recs.DataSource = ds.Tables("Subject_Entry_By_Cand")
        Incomplete_Recs.ReadOnly = True
    End Sub

    Private Sub txtCandNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandNo.TextChanged
        Dim cflag As String = "i"

        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from Subject_Entry_By_Cand where INDEXNO like'" & txtCandNo.Text & "%' and FLAG like '" & cflag & "'and SUBJCODE LIKE '" & myexaminer1 & "%' and CENTCODE ='" & TxtCentCode.Text & "'", con.con)
        da.Fill(ds, "Subject_Entry_By_Cand")
        Incomplete_Recs.DataSource = ds.Tables("Subject_Entry_By_Cand")
        Incomplete_Recs.ReadOnly = True
    End Sub


End Class