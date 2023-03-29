Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmTassGV

    Dim con As New ConClass
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProcessingYear()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("Select * from TASSMARKS  where PAPERCODE like'" & myexaminer1 & "%'", con.con)
        da.Fill(ds, "TASSMARKS")
        TassGV.DataSource = ds.Tables("TASSMARKS")

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCentCode.TextChanged
        Try
            ds.Clear()
            da = New OleDb.OleDbDataAdapter("Select * from TASSMARKS where CENTCODE like'" & TxtCentCode.Text & "%'and PAPERCODE LIKE '" & myexaminer1 & "%'", con.con) ' order by SUBJCODE,INDEXNO",)
            da.Fill(ds, "TASSMARKS")
            TassGV.DataSource = ds.Tables("TASSMARKS")
            TassGV.ReadOnly = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandNo.TextChanged
        Try
            ds.Clear()
            da = New OleDb.OleDbDataAdapter("Select * from TASSMARKS where INDEXNO like '" & txtCandNo.Text & "%' and PAPERCODE LIKE '" & myexaminer1 & "%'", con.con)
            da.Fill(ds, "TASSMARKS")
            TassGV.DataSource = ds.Tables("TASSMARKS")
            TassGV.ReadOnly = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ProcessingYear()

        Dim cmd As New OleDbCommand
        Dim CreationDate As Date
        Dim examyr As String
        examyr = Now.Year
        CreationDate = Now.Date
        txtexamyear.Text = (examyr)
    End Sub

    Private Sub txtexamyear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtexamyear.TextChanged

    End Sub
End Class