Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmCassGV

    Dim con As New ConClass
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from CassMarks where CENTCODE like'" & TxtCentCode.Text & "%'", con.con)
        da.Fill(ds, "CassMarks")
        CassGV.DataSource = ds.Tables("CassMarks")

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentCode.TextChanged

        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from CassMarks where CENTCODE like'" & TxtCentCode.Text & "%' order by SUBJCODE,INDEXNO", con.con)
        da.Fill(ds, "CassMarks")
        CassGV.DataSource = ds.Tables("CassMarks")
        CassGV.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If MessageBox.Show("Do you want to Exit?", "Closing CassMarks Form", _
        ' MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Me.Close()
        'Else
        'TxtCentCode.Focus()
        'End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandNo.TextChanged
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from CassMarks where INDEXNO like'" & txtCandNo.Text & "%'order by SUBJCODE,INDEXNO ", con.con)
        da.Fill(ds, "CassMarks")
        CassGV.DataSource = ds.Tables("CassMarks")
    End Sub

End Class