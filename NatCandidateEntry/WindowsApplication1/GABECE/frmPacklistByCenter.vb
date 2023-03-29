Imports System.Data
Imports System.Data.Sql

Imports System.Data.OleDb
Public Class frmPacklistByCenter
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim gconn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim gcons As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                        System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmPacklistByCenter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da = New OleDb.OleDbDataAdapter("select * from ListByCent order by CentNo,SubjCode", con)
        da.Fill(ds, "ListByCent")
        DataGridView1.DataSource = ds.Tables("ListByCent")
        DataGridView1.ReadOnly = True
    End Sub
End Class