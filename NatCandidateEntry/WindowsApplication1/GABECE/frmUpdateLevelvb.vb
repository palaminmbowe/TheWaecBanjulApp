
Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.IO
Imports System.Data.OleDb


Public Class frmUpdateLevelvb

    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim cmd As New OleDbCommand

    Private Sub frmUpdateLevelvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getusers()
    End Sub
    Sub getusers()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Dim cmd1, cmd2 As New OleDbCommand
        gcon.Open()
        cmd1.CommandText = "Select * FROM ExaminerLogin_Tbl  "
        cmd1.Connection = gcon
        dr = cmd1.ExecuteReader
        cmbUsers.Items.Clear()
        While (dr.Read())
            cmbUsers.Items.Add(dr("USERNAME"))
        End While
        gcon.Close()
        'MsgBox("Please select Your Status and Subject Code and Click on Retrieve Record.", MsgBoxStyle.Information)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'update into Login table 
        gcon.Open()
        Query2 = "update ExaminerLogin_Tbl set USERLEVEL='" & CInt(ComboBox1.Text) & "'" _
              & "where ((USERNAME='" & cmbUsers.Text & "'))"
        cmd.Connection = gcon
        mCmd2 = New OleDb.OleDbCommand(Query2, gcon)
        mCmd2.ExecuteNonQuery()
        MsgBox("User Level of " + ComboBox1.Text + " has been updated")
    End Sub
End Class