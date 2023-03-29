Public Class FrmCompleteMarks
    Dim con As New ConClass
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub FrmCompleteMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TxtCentCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentCode.TextChanged
        Dim cflag As String = "c"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from Transact where FLAG like'" & cflag & "%' order by SUBJCODE,INDEXNO", con.con)
        da.Fill(ds, "Transact")
        Complete_Recs.DataSource = ds.Tables("Transact")
        Complete_Recs.ReadOnly = True
    End Sub

    Private Sub txtCandNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandNo.TextChanged
        Dim cflag As String = "c"

        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from Transact where INDEXNO like'" & txtCandNo.Text & "%' and FLAG like '" & cflag & "'", con.con)
        da.Fill(ds, "Transact")
        Complete_Recs.DataSource = ds.Tables("Transact")
        Complete_Recs.ReadOnly = True
    End Sub
End Class