Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.IO


Public Class FrmSubEntry

    Dim con As New ConClass 'SqlConnection("Data Source=TOSHIBA\SQLEXPRESS;Initial Catalog=gabecedbs;Integrated Security=True")

    
    Dim da As New OleDbDataAdapter
    Dim dp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim cmd As New OleDbCommand
    Dim recno As Integer


    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim cmd As New OleDbCommand
        con.OpenConnection()
        cmd.CommandText = "Sp_SubjDetails"
        cmd.Connection = con.con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@SubCode", txtSubCode.Text)
        cmd.Parameters.AddWithValue("@SubName", txtSubName.Text)
        cmd.Parameters.AddWithValue("@PapCode", txtPapCode.Text)

        cmd.ExecuteNonQuery()
        con.CloseConnection()

        MsgBox("Record saved")
        ClearForm()

    End Sub

    Private Sub FrmSubEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSubCode.Focus()

    End Sub

    Private Sub CmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModify.Click
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()
            cmd.CommandText = "update SubjDetails set SubCode=@SubCode,SubName=@SubName,PapCode=@PapCode Where SubCode=@SubCode"
            cmd.Connection = con.con
            cmd.Parameters.AddWithValue("@SubCode", txtSubCode.Text)
            cmd.Parameters.AddWithValue("@SubName", txtSubName.Text)
            cmd.Parameters.AddWithValue("@PapCode", txtPapCode.Text)
            cmd.ExecuteScalar()
            con.CloseConnection()
            MsgBox("Record Updated")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        'Try

        txtSubCode.Focus()
        Dim cmd As New OleDbCommand
        con.OpenConnection()
        cmd.CommandText = "select * from SubjDetails where SubCode= @SubCode"
        cmd.Connection = con.con
        cmd.Parameters.AddWithValue("@SubCode", txtSubCode.Text)
        dr = cmd.ExecuteReader
        dr.Read()
        txtSubCode.Text = dr("SubCode")
        txtSubName.Text = dr("SubName")
        txtPapCode.Text = dr("PapCode")

        If txtSubCode.Text <> dr("SubCode") Then

            MsgBox("Records not in Table. Please type another Subject Code.")
        End If

        dr.Close()
        con.CloseConnection()
        'Catch ex As Exception
        'End Try


    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
        MsgBox("Do you want to close the form", MessageBoxButtons.YesNoCancel)


    End Sub
    Private Sub ClearForm()
        txtSubCode.Clear()
        txtSubName.Clear()
        txtPapCode.Clear()
    End Sub

    Private Sub CmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFirst.Click

        da = New OleDbDataAdapter("Select * from SubjDetails", con.con)
        da.Fill(ds, "SubjDetails")
        recno = ds.Tables("SubjDetails").Rows.Count = 0
        Display()

    End Sub

    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext.Click
        recno += 1
        Try
            Display()

        Catch ex As Exception
            MsgBox("Last Record Reached")
            recno = 0
        End Try


    End Sub

    Private Sub CmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrev.Click
        Try
            recno -= 1
            Display()

        Catch ex As Exception
            MsgBox("This is the first Record")

        End Try
    End Sub

    Private Sub CmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLast.Click
        Try
            recno = ds.Tables("SubjDetails").Rows.Count - 1
            Display()

            MsgBox("Last Record Reached")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Display()
        txtSubCode.Text = ds.Tables("SubjDetails").Rows(recno).Item("SubCode")
        txtSubName.Text = ds.Tables("SubjDetails").Rows(recno).Item("SubName")
        txtPapCode.Text = ds.Tables("SubjDetails").Rows(recno).Item("PapCode")
    End Sub
End Class