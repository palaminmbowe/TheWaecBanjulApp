
Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.Data.OleDb
Imports System.IO

Public Class FrmModify_Examiner_
    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                       System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon4 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon5 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon6 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                               System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon7 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon8 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon9 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                               System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")


    Dim con As New ConClass
    Dim da As OleDbDataAdapter
    Dim dAdapt As OleDbDataAdapter
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim mCmd1, mCmd2, mCmd3, mCmd4, mCmd5, mCmd6 As OleDbCommand
    Dim Query1, Query2, mQuery2, Query3, Query4, Query5, Query6, examinno, papcode, examinerno, examinerpap, examinerpap1, gen1, myeno, gen, exTBM As String
    Dim subjcode, curcentre, examyr, nname, gender, sCode, currentNo, currentNo1, chief, examinerno_Status As String
    Dim dSet As DataSet
    Dim ds As New DataSet

    Sub GetExamYear()
        examyr = Now.Year
        txtexamyr.Text = (examyr)

    End Sub
    Private Sub FrmCreate_Examiner__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetExamYear()
        Marked_Pap()
        getstatus()
    End Sub

    Sub Marked_Pap()

        'Accessing Papcode from Subjects Table to fill the Papcode depending what paper the examiner is marking
        Dim cmd1, cmd2 As New OleDbCommand
        Try
            CboSubjCode.Items.Clear()
            gcon.Open()
            cmd1.CommandText = "Select * from PaperDetails where PapCodeCSD like '" & myexaminer & "%'"
            cmd1.Connection = gcon
            dr = cmd1.ExecuteReader
            While dr.Read
                examinerpap = (Mid(dr("PapCodeCSD"), 5, 1))
                examinerpap1 = (Mid(dr("PapCodeCSD"), 1, 3))
                If examinerpap1 = myexaminer And examinerpap <> 1 Then
                    CboSubjCode.Items.Add(dr("PapCodeCSD"))
                End If

            End While

            dr.Close()
            gcon.Close()

        Catch ex As Exception
        Finally

            gcon.Close()
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Sub getstatuscode()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Try
            Dim cmd1, cmd2 As New OleDbCommand
            con.OpenConnection()
            cmd1.CommandText = "Select * FROM Status_Tbl where Status='" & CboStatus.Text & "'  "
            cmd1.Connection = con.con
            dr = cmd1.ExecuteReader
            While (dr.Read())
                sCode = dr("Status_Code")
            End While
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
        Finally
            dr.Close()
            con.CloseConnection()
        End Try
    End Sub

    Sub getstatus()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Try
            Dim cmd1 As New OleDbCommand
            Dim ass As String
            ass = "00"
            con.OpenConnection()
            cmd1.CommandText = "Select * FROM Status_Tbl where Status_Code  LIKE '" & ass & "%'"
            cmd1.Connection = con.con
            dr = cmd1.ExecuteReader
            While (dr.Read())
                CboStatus.Items.Add(dr("Status"))
            End While
            con.CloseConnection()
        Catch ex As Exception
        Finally
            con.CloseConnection()
        End Try
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        If txtusername.TextLength > 6 Then
            MsgBox("Username cannot be more than 6 characters.", MsgBoxStyle.Information, Me.Text)
            Exit Sub
            txtusername.Focus()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtpassword.TextLength > 6 Then
            MsgBox("Password cannot be more than 6 characters.", MsgBoxStyle.Information, Me.Text)
            txtpassword.Text = ""
            Exit Sub
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtconfpass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtconfpass.Leave
        If txtconfpass.TextLength > 6 Then
            If txtconfpass.Text <> txtpassword.Text Then
                MsgBox("Please confirm your password.", MsgBoxStyle.Information, Me.Text)
                txtconfpass.Text = ""
                txtconfpass.Focus()
            End If
        End If
    End Sub

    Private Sub txttel_off_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_off.KeyPress
        'accepts only numbers.
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttel_off_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttel_off.Leave
        If txttel_off.Text.Length > 7 Then
            MsgBox("Telephone No. cannot be more that 7 digits.", MsgBoxStyle.Information, Me.Text)
            txttel_off.Text = ""
            txttel_off.Focus()
        End If
    End Sub

    Private Sub txtwtel_mob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwtel_mob.KeyPress
        'accepts only numbers.
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'accepts only numbers
    Private Sub txtrtel_home_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrtel_home.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtrtel_home_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrtel_home.Leave
        If txtrtel_home.Text.Length > 7 Then
            MsgBox("Telephone No. cannot be more that 7 digits.", MsgBoxStyle.Information, Me.Text)
            txtrtel_home.Text = ""
            txtrtel_home.Focus()
        End If
    End Sub

    Private Sub txtwtel_mob_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtwtel_mob.Leave
        If txtwtel_mob.Text.Length > 7 Then
            MsgBox("Telephone No. cannot be more that 7 digits.", MsgBoxStyle.Information, Me.Text)
            txtwtel_mob.Text = ""
            txtwtel_mob.Focus()
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlname.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtoname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoname.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtlname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlname.Leave
        If txtlname.Text.Length > 25 Then
            MsgBox("LastName cannot be more than 25 characters.", MsgBoxStyle.Information, Me.Text)
            txtlname.Text = ""
            txtlname.Focus()
        End If
    End Sub

    Private Sub txtoname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtoname.Leave
        If txtoname.Text.Length > 25 Then
            MsgBox("Other Names cannot be more than 25 characters.", MsgBoxStyle.Information, Me.Text)
            txtoname.Text = ""
            txtoname.Focus()
        End If
    End Sub

    Private Sub txtfname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Leave
        If txtfname.Text.Length > 25 Then
            MsgBox("First Name cannot be more than 25 characters.", MsgBoxStyle.Information, Me.Text)
            txtfname.Text = ""
            txtfname.Focus()
        End If
    End Sub

    Private Sub txtwcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwcity.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtrcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrcity.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtrstreet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrstreet.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtrcomp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrcomp_name.KeyPress
        'enter only numbers for compound No.
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtrcomp_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrcomp_name.TextChanged
        If txtrcomp_name.Text.Length > 3 Then
            MsgBox(" Compound No. should not be more than 3 digits.", MsgBoxStyle.Information, Me.Text)
            txtrcomp_name.Text = ""
            txtrcomp_name.Focus()
        End If
    End Sub
    Sub GETEXAMINER()

        gcon.Open()
        Dim cmd As New OleDbCommand

        cmd.CommandText = "select Distinct EXAMINERNO FROM Examiner_Biodts Where((STATUS='" & CboStatus.Text & "')and (SUBJCODE='" & CboSubjCode.Text & "'))"

        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read()
            exTBM = dr("EXAMINERNO")
            myeno = dr("EXAMINERNO")
        End While
        gcon.Close()


    End Sub
    Sub Biodts()

        GETEXAMINER()
        Try
            con.OpenConnection()
            Dim cmd As New OleDbCommand


            cmd.CommandText = "select * from Examiner_Biodts Where ((EXAMINERNO='" & exTBM & "') and (STATUS='" & CboStatus.Text & "')and (SUBJCODE='" & CboSubjCode.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then

                txtexaminer_no.Text = dr("EXAMINERNO")
                CboTitle.Text = dr("TITLE")
                txtlname.Text = dr("LASTNAME")
                txtfname.Text = dr("FIRSTNAME")
                txtoname.Text = dr("OTHERNAME")
                txtmsubj.Text = dr("MAJORSUBJ")
                currentNo1 = Mid((currentNo), 1, 4)
                gen = dr("GENDER")
                gen1 = (Mid(gen, 1, 1))
                If gen1 = "F" Then
                    rdbFemale.Checked = True
                Else
                    rdbMale.Checked = True
                End If
                CboNational.Text = dr("NATIONALITY")
                txtoccup.Text = dr("OCCUP")
            Else
                MsgBox("Examiner does not exist", MsgBoxStyle.Information, Me.Text)
            End If

            dr.Close()
            con.CloseConnection()
        Catch ex As Exception

        Finally
            dr.Close()
            con.CloseConnection()
        End Try

    End Sub

    Public Sub getAdd()
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()

            cmd.CommandText = "select * from Examiner_Add Where((EXAMYEAR='" & txtexamyr.Text & "')and (EXAMINERNO='" & txtexaminer_no.Text & "'))"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then
                txtwcity.Text = dr("WCITY")
                txtrcity.Text = dr("RCITY")
                txtrlocal.Text = dr("RLOCALITY")
                txtrstreet.Text = dr("STREETNAME")
                txtrcomp_name.Text = dr("COMPOUNDNAME")
                txtwtel_mob.Text = dr("MOBILE")
                txtrtel_home.Text = dr("HOMETEL")
                txttel_off.Text = dr("OFFTEL")

            End If

            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        End Try

    End Sub
    Sub getQualif()
        GETEXAMINER()
        Try
            Dim cmd As New OleDbCommand

            con.OpenConnection()

            cmd.CommandText = "select * from Examiner_Qualif Where EXAMINERNO  ='" & exTBM & "'"

            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read Then

                txtqual1.Text = CStr(dr("QUALIF1"))
                txtqyr1.Text = CStr(dr("YROBTAINED1"))

                txtqual2.Text = (CStr(dr("QUALIF2")))
                txtqyr2.Text = (CStr(dr("YROBTAINED2")))
                txtqual3.Text = (CStr(dr("QUALIF3")))
                txtqyr3.Text = (CStr(dr("YROBTAINED3")))
            End If


            con.CloseConnection()
        Catch ex As Exception
        Finally
            dr.Close()
            con.CloseConnection()
        End Try

    End Sub
    Sub getLogin()
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()

            cmd.CommandText = "select * from ExaminerLogin_Tbl Where EXAMINERNO='" & txtexaminer_no.Text & "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then

                txtusername.Text = dr("USERNAME")
                txtconfpass.Text = dr("EPASSWORD")
                txtpassword.Text = dr("EPASSWORD")

            End If
            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            'dr.Close()
            'con.CloseConnection()
        Finally
            dr.Close()
            con.CloseConnection()
        End Try

    End Sub
    Sub getExpr()
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()

            cmd.CommandText = "select * from ExaminerMarking_Exp Where  EXAMINERNO='" & txtexaminer_no.Text & "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then

                txtMrkSubj.Text = dr("MARKEDSUBJ")
                txtNoofyrs.Text = CStr(dr("NOOFYRS"))

            End If

            'end of modification
            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        Finally
        End Try
    End Sub
    Private Sub cmdretexrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdretexrec.Click
        Biodts()
        getAdd()
        getExpr()
        getLogin()
        getQualif()
    End Sub
    Private Sub btnupdateexm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateexm.Click
        If validateform() = True Then
            Add_Examiner()
        Else
            If validateform() = False Then

            End If
        End If
        Exit Sub
    End Sub
    Sub Add_Examiner()
        Try
            gcon7.Open()
            Dim cmd As New OleDbCommand
            If rdbMale.Checked Then
                gender = rdbMale.Text.ToUpper
            Else
                If rdbFemale.Checked Then

                    gender = rdbFemale.Text.ToUpper
                End If

            End If
            gender = rdbMale.Text.ToUpper
            gender = rdbFemale.Text.ToUpper


            'insert into Examiner Detials table
            Query1 = "update Examiner_Biodts set STATUS='" & CboStatus.Text & "',SUBJCODE='" & CboSubjCode.Text & "'," _
            & "TITLE='" & CboTitle.Text & "',LASTNAME='" & txtlname.Text.ToUpper & " '," _
            & "FIRSTNAME='" & txtfname.Text.ToUpper & "',OTHERNAME='" & txtoname.Text.ToUpper & "',GENDER='" & gender & "',NATIONALITY='" & CboNational.Text & "'," _
            & "OCCUP='" & txtoccup.Text.ToUpper & "',MAJORSUBJ='" & txtmsubj.Text.ToUpper & "' where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
            cmd.Connection = gcon7
            mCmd1 = New OleDb.OleDbCommand(Query1, gcon7)

            'update into Login table 
            gcon8.Open()
            Query2 = "update ExaminerLogin_Tbl set USERNAME='" & txtusername.Text & "',EPASSWORD='" & txtpassword.Text & "'" _
                  & "where ((EXAMINERNO='" & txtexaminer_no.Text & "'))"
            cmd.Connection = gcon8
            mCmd2 = New OleDb.OleDbCommand(Query2, gcon8)

            'update into Experience table 
            gcon9.Open()
            Query3 = "update ExaminerMarking_Exp set MARKEDSUBJ='" & txtMrkSubj.Text & "',NOOFYRS='" & txtNoofyrs.Text & "'" _
            & "where ((EXAMINERNO='" & txtexaminer_no.Text & "'))"
            cmd.Connection = gcon9
            mCmd4 = New OleDb.OleDbCommand(Query3, gcon9)

            'update into Examiner Address
            gcon.Open()
            Query4 = "update Examiner_Add set WCITY='" & txtwcity.Text.ToUpper & "',RCITY='" & txtrcity.Text.ToUpper & "',RLOCALITY='" & txtrlocal.Text.ToUpper & "'," _
            & "STREETNAME='" & txtrstreet.Text.ToUpper & "',COMPOUNDNAME='" & txtrcomp_name.Text.ToUpper & "',OFFTEL='" & txttel_off.Text & "'," _
            & "MOBILE='" & txtwtel_mob.Text & "',HOMETEL='" & txtrtel_home.Text & "' where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
            cmd.Connection = gcon
            mCmd3 = New OleDb.OleDbCommand(Query4, gcon)

            mCmd1.ExecuteNonQuery()
            mCmd2.ExecuteNonQuery()
            mCmd3.ExecuteNonQuery()
            mCmd4.ExecuteNonQuery()

            gcon.Close()
            gcon1.Close()
            gcon7.Close()
            gcon8.Close()
            gcon9.Close()

            'update into Examiner Qualification
            UQualif1()

            If txtqual2.Text <> "" Then
                UQualif2()
            End If
            If txtqual3.Text <> "" Then
                UQualif3()
            End If

            MsgBox("Examiner Record has been updated.", MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
        Finally
            gcon.Close()
            gcon1.Close()
            gcon7.Close()
            gcon8.Close()
            gcon9.Close()

        End Try
        ClearForm()
    End Sub
        sub UQualif1()
        gcon.Open()

        Query4 = "update Examiner_Qualif set QUALIF1='" & txtqual1.Text & "',EXAMINERNO='" & txtexaminer_no.Text & "',YROBTAINED1='" & txtqyr1.Text & "' where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
        mCmd4 = New OleDb.OleDbCommand(Query4, gcon)
        mCmd4.ExecuteNonQuery()
        gcon.Close()

    End Sub
    Sub UQualif2()
        Dim cmd As New OleDb.OleDbCommand
        gcon4.Open()

        Query5 = "update Examiner_Qualif set QUALIF2='" & txtqual2.Text & "',YROBTAINED2='" & txtqyr2.Text & "'where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
        cmd.Connection = gcon4

        mCmd5 = New OleDb.OleDbCommand(Query5, gcon4)
        mCmd5.ExecuteNonQuery()
        gcon4.Close()
    End Sub
    Sub UQualif3()
        Dim cmd As New OleDb.OleDbCommand
        gcon5.Open()

        Query6 = "update Examiner_Qualif set QUALIF3='" & txtqual3.Text & "',YROBTAINED3='" & txtqyr3.Text & "'where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
        cmd.Connection = gcon5

        mCmd6 = New OleDb.OleDbCommand(Query6, gcon5)
        mCmd6.ExecuteNonQuery()
        gcon5.Close()
    End Sub
    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        ClearForm()
    End Sub
    Public Sub ClearForm()

        'clears the form for new candidate entry
        CboTitle.SelectedIndex = -1
        CboStatus.SelectedIndex = -1
        CboSubjCode.SelectedIndex = -1
        txtexaminer_no.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtoname.Text = ""
        CboNational.SelectedIndex = -1
        txtoccup.Text = ""
        txtmsubj.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtconfpass.Text = ""
        rdbFemale.Checked = False
        rdbMale.Checked = False
        txtrcomp_name.Text = ""
        txtrlocal.Text = ""
        txtrstreet.Text = ""
        txtrtel_home.Text = ""
        txtwcity.Text = ""
        txtwtel_mob.Text = ""
        txttel_off.Text = ""
        txtrcity.Text = ""
        txtqual1.Text = ""
        txtqual2.Text = ""
        txtqual3.Text = ""
        txtqyr1.Text = ""
        txtqyr2.Text = ""
        txtqyr3.Text = ""
        txtMrkSubj.Text = ""
        txtNoofyrs.Text = ""


    End Sub
    Public Function validateform() As Boolean


        If CboTitle.Text = "" Then
            MsgBox("Please Select Title.", MsgBoxStyle.Information, Me.Text)
            CboTitle.Focus()
        End If
        If CboStatus.Text = "" Then
            MsgBox("Please Select Status.", MsgBoxStyle.Information, Me.Text)
            CboStatus.Focus()
        End If
        If CboSubjCode.Text = "" Then
            MsgBox("Please Select a Subject Code.", MsgBoxStyle.Information, Me.Text)
            CboSubjCode.Focus()
        End If

        If txtlname.Text = "" Then
            MsgBox("Please Enter Personal Details.", MsgBoxStyle.Information, Me.Text)
            txtlname.Focus()
        End If

        If txtfname.Text = "" Or CboNational.Text = "" Then
            MsgBox("Please Enter Personal Details.", MsgBoxStyle.Information, Me.Text)
            txtfname.Focus()
        End If
        If CboNational.Text = "" Then
            MsgBox("Please Enter Personal Details.", MsgBoxStyle.Information, Me.Text)
            CboNational.Focus()
        End If
        If txtoccup.Text = "" Then
            MsgBox("Please supply Occupation?", MsgBoxStyle.Question, Me.Text)
            txtoccup.Focus()
        End If
        If txtmsubj.Text = "" Then
            MsgBox("Please supply major subject.", MsgBoxStyle.Information, Me.Text)

            txtmsubj.Focus()
        End If
        If txtusername.Text = "" Then
            MsgBox("Please enter Security Details.", MsgBoxStyle.Information, Me.Text)
            txtusername.Text = ""
            txtusername.Focus()
        End If
        If txtpassword.Text = "" Then
            MsgBox("Please enter Security Details.", MsgBoxStyle.Information, Me.Text)
            txtpassword.Text = ""
            txtpassword.Focus()
        End If
        If txtconfpass.Text = "" Then
            MsgBox("Please enter Security Details.", MsgBoxStyle.Information, Me.Text)
            txtconfpass.Text = ""
            txtconfpass.Focus()
        End If

        If txtwcity.Text = "" Or txtwtel_mob.Text = "" Then
            MsgBox("Please supply details of work place.", MsgBoxStyle.Information, Me.Text)
            txtwcity.Focus()
        End If
        If txtwtel_mob.Text = "" Then

            MsgBox("Please supply details of work place.", MsgBoxStyle.Information, Me.Text)
            txtwtel_mob.Focus()
        End If

        If txttel_off.Text = "" Then
            MsgBox("Please supply details of work place.", MsgBoxStyle.Information, Me.Text)
            txttel_off.Focus()
        End If


        If txtrlocal.Text = "" Then
            MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
            txtrlocal.Focus()
        End If
        If txtrcomp_name.Text = "" Then
            MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
            txtrcomp_name.Focus()
        End If
        If txtrtel_home.Text = "" Then
            MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
            txtrcomp_name.Focus()
        End If

        If txtrstreet.Text = "" Then
            MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
            txtrcomp_name.Focus()
        End If

        If txtqual1.Text = "" Or txtqyr1.Text = "" Then
            MsgBox("Please supply qualifications.", MsgBoxStyle.Information, Me.Text)
        End If

        If txtMrkSubj.Text = "" Or txtNoofyrs.Text = "" Then
            MsgBox("Please Marking Experience Details.", MsgBoxStyle.Information, Me.Text)

            validateform = False
            Exit Function
            txtlname.Focus()
        Else
            validateform = True
            btnupdateexm.Enabled = True
        End If

    End Function
    Private Sub txtqyr1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqyr1.Leave
        If txtqyr1.Text < 1960 Or txtqyr1.Text > Now.Year Then
            MsgBox("Please check year of Graduation.")
            txtqyr1.Text = ""
            txtqyr1.Focus()
        End If

    End Sub
    Private Sub txtqyr2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqyr2.Leave
        If txtqyr2.Text < 1960 Or txtqyr2.Text > Now.Year Then
            MsgBox("Please check year of Graduation.")
            txtqyr2.Text = ""
            txtqyr2.Focus()
        End If

    End Sub
    Private Sub txtqyr3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqyr3.Leave

        If txtqyr3.Text < 1960 Or txtqyr3.Text > Now.Year Then
            MsgBox("Please check year of Graduation.")
            txtqyr3.Text = ""
            txtqyr3.Focus()
        End If

    End Sub

End Class

