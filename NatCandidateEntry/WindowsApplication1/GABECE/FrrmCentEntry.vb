Imports System.Data.SqlClient

Public Class FrmCentEntry
    Dim con As New SqlConnection("Data Source=TOSHIBA\SQLEXPRESS;Initial Catalog=gabecedbs;Integrated Security=True")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim recno As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        da = New SqlDataAdapter("Select * from CentDetails", con)
        da.Fill(ds, "CentDetails")
        txtCentCode.Text = ds.Tables("CentDetails").Rows(recno).Item("CentCode")
        txtCentName.Text = ds.Tables("CentDetails").Rows(recno).Item("CentName")
        txtCentAdd.Text = ds.Tables("CentDetails").Rows(recno).Item("CentAddress")
    End Sub


    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim cmd As New SqlCommand
        con.Open()
        cmd.CommandText = "Sp_CentDetails"
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@CentCode", txtCentCode.Text)
        cmd.Parameters.AddWithValue("@CentName", txtCentName.Text)
        cmd.Parameters.AddWithValue("@CentAddress", txtCentAdd.Text)

        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Record Saved")
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Try
            'txtCentCode.Clear()
            'txtCentName.Clear()
            'txtCentAdd.Clear()
            txtCentCode.Focus()
            Dim cmd As New SqlCommand
            con.Open()
            cmd.CommandText = "select * from CentDetails where CentCode= @CentCode"
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@CentCode", txtCentCode.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            txtCentCode.Text = dr("CentCode")
            txtCentName.Text = dr("CentName")
            txtCentAdd.Text = dr("CentAddress")

            If txtCentCode.Text <> dr("CentCode") Then

                MsgBox("Records not in Table. Please type another Center Code.")
            End If

            dr.Close()
            con.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        txtCentCode.Text = ""
        txtCentName.Text = ""
        txtCentAdd.Text = ""
        txtCentCode.Focus()

    End Sub

    Private Sub CmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModify.Click
        Dim cmd As New SqlCommand
        con.Open()
        cmd.CommandText = "update CentDetails set CentCode=@CentCode,CentName=@CentName,CentAddress=@CentAddress Where CentCode=@CentCode"
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@CentCode", txtCentCode.Text)
        cmd.Parameters.AddWithValue("@CentName", txtCentName.Text)
        cmd.Parameters.AddWithValue("@CentAddress", txtCentAdd.Text)
        cmd.ExecuteScalar()
        con.Close()
        MsgBox("Record Updated")

    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub CmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFirst.Click
        recno = 0
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
            MsgBox("This the first Record")

        End Try
    End Sub

    Private Sub CmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLast.Click
        Try
            recno = ds.Tables("CentDetails").Rows.Count - 1
            Display()
           
            MsgBox("Last Record Reached")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Display()
        txtCentCode.Text = ds.Tables("CentDetails").Rows(recno).Item("CentCode")
        txtCentName.Text = ds.Tables("CentDetails").Rows(recno).Item("CentName")
        txtCentAdd.Text = ds.Tables("CentDetails").Rows(recno).Item("CentAddress")
    End Sub
End Class