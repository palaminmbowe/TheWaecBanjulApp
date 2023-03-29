Imports System.Data
Imports System.Data.OleDb

Public Class FrmEntryCon
    Dim con As New ConClass
    'Dim con As New SqlConnection("Data Source=TOSHIBA\SQLEXPRESS;Initial Catalog=gabecedbs;Integrated Security=True")

    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim dr As OleDbDataReader
    Dim recno As Integer
    Dim recno1 As Integer
    Private Sub txtCentCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentCode.TextChanged

        ds.Clear()
        da = New OleDbDataAdapter("Select * from CandDetails where CentCode like'" & txtCentCode.Text & "%'", con.con)
        da.Fill(ds, "CandDetails")
        DGCandEntry.DataSource = ds.Tables("CandDetails")
        DGCandEntry.Columns(0).ReadOnly = True
        DGCandEntry.Columns(1).ReadOnly = True

        ''ds.Clear()
        'da = New SqlDataAdapter("select CentCode,Candno from CandSubjects where CentCode='" + txtCentCode.Text + "'", con)
        'da.Fill(ds, "CandSubjects")
        'DGCandEntry.DataSource = ds.Tables("CandSubjects")

        ''DGCandEntry.Columns(8).ReadOnly = True
        ''DGCandEntry.Columns(9).ReadOnly = True
        ''DGCandEntry.Columns(10).ReadOnly = True
        ''DGCandEntry.Columns(11).ReadOnly = True

    End Sub

    Private Sub CmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModify.Click
        'CmdModify.Enabled = False
        'Dim rowsAffected As Integer

        Dim cmd As New OleDbCommand
        con.OpenConnection()
        cmd.CommandText = "Sp_UpdateEntry" ' "update CandDetails set centcode=@CentCode,CandNo=@CandNo,Sex=@Sex,Dob=@Dob,NoOfSubs=@NoOfSubs,SchofChc=@SchofChc,LNAME=@LNAME,FNAME=@FNAME where Candno='" + txtCandNo.Text + "'"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con.con
        'cmd.Parameters.AddWithValue("@Centcode", txtCentCode.Text)
        'cmd.Parameters.AddWithValue("@candno", txtCandNo.Text)
        cmd.Parameters.AddWithValue("@LNAME", txtLname.Text)
        cmd.Parameters.AddWithValue("@FNAME", txtFname.Text)
        cmd.Parameters.AddWithValue("@Sex", txtsex.Text)
        cmd.Parameters.AddWithValue("@Dob", txtDOB.Text)
        cmd.Parameters.AddWithValue("@NoOfSubjs", txtNoofSubs)
        cmd.Parameters.AddWithValue("@SchofChc", txtSchofChc)
        cmd.Parameters.AddWithValue("@subCode5", txtsub5.Text)
        cmd.Parameters.AddWithValue("@subCode6", txtsub6.Text)
        cmd.Parameters.AddWithValue("@subCode7", txtsub7.Text)
        cmd.Parameters.AddWithValue("@subCode8", txtsub8.Text)
        cmd.Parameters.AddWithValue("@subCode9", txtsub9.Text)
        cmd.ExecuteNonQuery()
        con.CloseConnection()

        'If MessageBox.Show("You have selected " & txtTot_Sub.Text & "  subjects. Do you want to change any subject?", "Adding Candidate Record", _
        '  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    CboCentCode.Focus()
        'Else
        '    MsgBox("Record Added")
        'End If

        MsgBox("Record updated")
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        'Dim cmd As New SqlCommand
        'con.OpenConnection()
        'cmd.CommandText = "update CandDetails set centcode=@CentCode,CandNo=@CandNo,Sex=@Sex,Dob=@Dob,NoOfSubs=@NoOfSubs,SchofChc=@SchofChc,LNAME=@LNAME,FNAME=@FNAME where Candno='" + txtCandNo.Text + "'"
        'cmd.Connection = con.con
        ''cmd.Parameters.AddWithValue("@Centcode", txtCentCode.Text)
        ''cmd.Parameters.AddWithValue("@candno", txtCandNo.Text)
        'cmd.Parameters.AddWithValue("@LNAME", txtLname.Text)
        'cmd.Parameters.AddWithValue("@FNAME", txtFname.Text)
        'cmd.Parameters.AddWithValue("@Sex", txtsex.Text)
        'cmd.Parameters.AddWithValue("@Dob", txtDOB.Text)
        'cmd.Parameters.AddWithValue("@NoOfSubs", txtNoofSubs)
        'cmd.Parameters.AddWithValue("@SchofChc", txtSchofChc)
        'cmd.ExecuteNonQuery()
        'rowsAffected = cmd.ExecuteNonQuery
        'con.CloseConnection()
        ''dr.Close()

        ''stop here'Update error connection has not been initialised.  should write a join sql statement

        'recno = txtCandNo.Text
        'Dim cmd1 As New SqlCommand

        ''Stop here Error Message: Conversion from string "update CandSubjects set subjCode" to type 'Double' is not valid.

        'con.OpenConnection()
        'cmd1.Connection = con.con
        'recno = txtCandNo.Text
        'cmd1.CommandText = "update CandSubjects set subjCode1=@subjCode1,subjCode2=@subjCode2,subjCode3=@subjCode3,subjCode4=@subjCode4,subjCode5=@subjCode5,subjCode6=@subjCode6,subjCode7=@subjCode7,subjCode8=@subjCode8,subjCode9=@subjCode9 where CandNo=" + recno + ""
        'cmd1.Parameters.AddWithValue("@subCode1", txtsub1.Text)
        'cmd1.Parameters.AddWithValue("@subCode2", txtsub2.Text)
        'cmd1.Parameters.AddWithValue("@subCode3", txtsub3.Text)
        'cmd1.Parameters.AddWithValue("@subCode4", txtsub4.Text)
        'cmd1.Parameters.AddWithValue("@subCode5", txtsub5.Text)
        'cmd1.Parameters.AddWithValue("@subCode6", txtsub6.Text)
        'cmd1.Parameters.AddWithValue("@subCode7", txtsub7.Text)
        'cmd1.Parameters.AddWithValue("@subCode8", txtsub8.Text)
        'cmd1.Parameters.AddWithValue("@subCode9", txtsub9.Text)
        ''cmd1.ExecuteScalar()
        'cmd1.ExecuteNonQuery()
        'con.CloseConnection()
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&

    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Try
            txtDOB.Clear()
            txtSchofChc.Clear()
            txtsex.Clear()
            txtNoofSubs.Clear()
            txtLname.Clear()
            txtFname.Clear()
            txtsub1.Clear()
            txtsub2.Clear()
            txtsub3.Clear()
            txtsub4.Clear()
            txtsub5.Clear()
            txtsub6.Clear()
            txtsub7.Clear()
            txtsub8.Clear()
            txtsub9.Clear()
            txtCentCode.Focus()

            Dim cmd As New OleDbCommand
            con.OpenConnection()

            cmd.CommandText = "Sp_CandAlltest"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con.con
            'cmd.Parameters.AddWithValue("@CentCode", txtCentCode.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            txtCentCode.Text = dr("CENTCODE")
            txtCandNo.Text = dr("CANDNO")
            txtDOB.Text = dr("DOB")
            txtSchofChc.Text = dr("SCHOFCHC")
            txtsex.Text = dr("sex")
            txtNoofSubs.Text = dr("NoOfSubjs")
            txtLname.Text = dr("LNAME")
            txtFname.Text = dr("FNAME")
            txtsub1.Text = dr("SUBJCODE1")
            txtsub2.Text = dr("SUBJCODE2")
            txtsub3.Text = dr("SUBJCODE3")
            txtsub4.Text = dr("SUBJCODE4")
            txtsub5.Text = dr("SUBJCODE5")
            txtsub6.Text = dr("SUBJCODE6")
            txtsub7.Text = dr("SUBJCODE7")
            txtsub8.Text = dr("SUBJCODE8")
            txtsub9.Text = dr("SUBJCODE9")


            Dim str As String
            str = dr("PHOTO")

            With PictureBox1
                .Image = Image.FromFile(str)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
            dr.Close()
            con.CloseConnection()


            CmdFirst.Enabled = True
            CmdNext.Enabled = True
            CmdPrev.Enabled = True
            CmdLast.Enabled = True
            CmdModify.Enabled = True

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFirst.Click
        'stop here trying navigate the records
        Try
            recno = ds.Tables("CandDetails").Rows.Count = 0
            display1()

            recno1 = ds.Tables("CandSubjects").Rows.Count = 0
            display2()

            CmdLast.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext.Click

        'Try
        recno += 1 ' ds.Tables("CandDetails").Rows.Count + 1
        display1()



        recno1 = ds1.Tables("CandSubject").Rows.Count + 1
        txtCentCode.Text = ds1.Tables("CandSubject").Rows(recno1).Item("CentCode")
        txtCandNo.Text = ds1.Tables("CandSubject").Rows(recno1).Item("CandNo")
        display2()

        recno1 = 0
        'Catch ex As Exception
        MsgBox("Last Record Reached")

        CmdNext.Enabled = False
        CmdPrev.Enabled = True
        CmdFirst.Enabled = True
        CmdLast.Enabled = True

        'End Try
    End Sub

    Private Sub CmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLast.Click
        ' Try
        recno = ds.Tables("CandDetails").Rows.Count - 1
        display1()


        recno1 = ds1.Tables("CandSubject").Rows.Count - 1
        txtCentCode.Text = ds1.Tables("CandSubject").Rows(recno1).Item("CentCode")
        txtCandNo.Text = ds1.Tables("CandSubject").Rows(recno1).Item("CandNo")
        display2()

        'Catch ex As Exception
        MsgBox("Last Record Reached")
        CmdLast.Enabled = False
        CmdFirst.Enabled = True

        'End Try

    End Sub

    Private Sub FrmEntryCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmdModify.Enabled = False
        CmdSearch.Enabled = False
        CmdFirst.Enabled = False
        CmdPrev.Enabled = False
        CmdNext.Enabled = False
        CmdLast.Enabled = False
        CmdPrint.Enabled = False
    End Sub

    Private Sub txtCandNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandNo.TextChanged
        CmdSearch.Enabled = True
    End Sub

    Private Sub txtsub9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsub9.TextChanged
        CmdModify.Enabled = True

    End Sub

    Private Sub CmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrev.Click

        Try
            recno = -1
            display1()

            recno1 = ds1.Tables("CandSubjects").Rows.Count - 1
            display2()

        Catch ex As Exception
            'MsgBox("Last Record Reached")
            CmdNext.Enabled = True

            'CmdPrev.Enabled = False
        End Try
    End Sub
    Private Sub display2()
        txtsub1.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE1")
        txtsub2.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE2")
        txtsub3.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE3")
        txtsub4.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE4")
        txtsub5.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE5")
        txtsub6.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE6")
        txtsub7.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE7")
        txtsub8.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE8")
        txtsub9.Text = ds1.Tables("CandSubjects").Rows(recno1).Item("SUBJCODE9")
    End Sub
    Private Sub display1()
        txtCentCode.Text = ds.Tables("CandDetails").Rows(recno).Item("CentCode")
        txtCandNo.Text = ds.Tables("CandDetails").Rows(recno).Item("CandNo")
        txtDOB.Text = ds.Tables("CandDetails").Rows(recno).Item("Dob")
        txtSchofChc.Text = ds.Tables("CandDetails").Rows(recno).Item("SchofChc")
        txtsex.Text = ds.Tables("CandDetails").Rows(recno).Item("Sex")
        txtNoofSubs.Text = ds.Tables("CandDetails").Rows(recno).Item("NoofSubjs")
        txtLname.Text = ds.Tables("CandDetails").Rows(recno).Item("LName")
        txtFname.Text = ds.Tables("CandDetails").Rows(recno).Item("Fname")
    End Sub

End Class
