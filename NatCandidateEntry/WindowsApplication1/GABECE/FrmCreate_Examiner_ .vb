
Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.IO
Imports System.Data.OleDb

Public Class FrmCreate_Examiner_
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
    Dim Query1, Query2, mQuery2, Query3, Query4, Query5, Query6, examinno, papcode, examinerno, examinerpap, examinerpap1, gen, gen1, stitle, title As String
    Dim subjcode, curcentre, examyr, nname, gender, sCode, currentNo, currentNo1, examinerno_Status, currentsubj As String
    Dim dSet As DataSet
    Dim ds As New DataSet
    Dim recno, num As Integer
    Dim chief As String
    Dim assistantchief As String
    Dim asstexaminer As String
    
    Sub GetExamYear()
        examyr = Now.Year
        txtexamyr.Text = (examyr)

    End Sub
    Private Sub FrmCreate_Examiner__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetExamYear()
        getstatus()
        Marked_Pap()
    End Sub
    
    Sub get_examinerno()
        Try
            Dim recno As Integer
            Dim cmd, cmd1 As New OleDbCommand
            Dim dr As OleDbDataReader
            chief = "0000"
            assistantchief = "0001"
            asstexaminer = "0002"


            gcon2.Open()
            cmd.CommandText = "Select * from Examiner_Biodts where SUBJCODE='" & CboSubjCode.Text & "' and STATUS like '" & CboStatus.Text & "' "
            cmd.Connection = gcon2
            dr = cmd.ExecuteReader


            While dr.Read()

                currentNo = dr("EXAMINERNO")
                currentNo1 = Mid((currentNo), 11, 3)
                examinerno_Status = Mid(dr("EXAMINERNO"), 1, 4)

                recno = (CInt(currentNo1))

                txtexaminer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))

            End While
            recno = recno + 1
            txtexaminer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))

            gcon3.Close()

        Catch ex As Exception
        Finally
            gcon2.Close()

        End Try
    End Sub
    Sub get_cheifexaminerno()
        Try
            Dim recno As Integer
            Dim cmd, cmd1 As New OleDbCommand
            Dim dr As OleDbDataReader
           

            gcon2.Open()
            cmd.CommandText = "Select * from Examiner_Biodts  "
            cmd.Connection = gcon2
            dr = cmd.ExecuteReader

            If dr.Read Then

                currentNo = dr("EXAMINERNO")
                currentNo1 = Mid((currentNo), 11, 3)
                examinerno_Status = Mid(dr("EXAMINERNO"), 1, 4)
                currentsubj = Mid((currentNo), 5, 6)
                title = dr("STATUS")
                recno = (CInt(currentNo1))
            Else
                getstatuscode()

                gcon3.Close()
            End If

        Catch ex As Exception
        Finally
            gcon2.Close()

        End Try
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
    Sub Add_Examiner()
        Dim cmd As New OleDb.OleDbCommand
     
        Try
            USERLEVEL = 1
            gcon1.Open()
            If rdbMale.Checked Then
                gender = rdbMale.Text.ToUpper
            Else
                If rdbFemale.Checked Then

                    gender = rdbFemale.Text.ToUpper
                End If

            End If

            'insert into Examiner Detials table

            Query1 = "Insert into Examiner_Biodts(EXAMYEAR,STATUS,SUBJCODE,EXAMINERNO,TITLE,LASTNAME,FIRSTNAME,OTHERNAME,GENDER,NATIONALITY,OCCUP,MAJORSUBJ)" _
            & "values ('" & txtexamyr.Text & "','" & CboStatus.Text & "','" & CboSubjCode.Text & "','" & txtexaminer_no.Text & "','" & CboTitle.Text & "','" & txtlname.Text & " '," _
            & "'" & txtfname.Text & "','" & txtoname.Text & "','" & gender & "','" & CboNational.Text & "','" & txtoccup.Text & "','" & txtmsubj.Text & "')"
            cmd.Connection = gcon1
            mCmd1 = New OleDb.OleDbCommand(Query1, gcon1)

            'insert into Login table 

            gcon2.Open()
            Query2 = "Insert into ExaminerLogin_Tbl(USERNAME,EXAMINERNO,EPASSWORD,USERLEVEL)" _
           & "values" _
           & "('" & txtusername.Text & "','" & txtexaminer_no.Text & "','" & txtpassword.Text & "','" & CInt(USERLEVEL) & "')"
            cmd.Connection = gcon2
            mCmd2 = New OleDb.OleDbCommand(Query2, gcon2)


            'insert into Experience table 

            ' gcon5.Open()
            ' Query3 = "Insert into ExaminerMarking_Exp(EXAMINERNO,MARKEDSUBJ,NOOFYRS)" _
            '& "values" _
            '& "('" & txtexaminer_no.Text & "','" & txtMrkSubj.Text & "','" & txtNoofyrs.Text & "')"
            ' cmd.Connection = gcon5
            ' mCmd4 = New OleDb.OleDbCommand(Query3, gcon5)

            'insert into Examiner Address
            gcon3.Open()
            Query4 = "Insert into Examiner_Add(EXAMYEAR,EXAMINERNO,WCITY,RCITY,RLOCALITY,STREETNAME,OFFTEL,MOBILE)" _
           & "values" _
           & "('" & txtexamyr.Text & "','" & txtexaminer_no.Text & "','" & txtwcity.Text & "','" & txtrcity.Text & "','" & txtrlocal.Text & "'," _
           & "'" & txtrstreet.Text & "','" & txttel_off.Text & "','" & txtwtel_mob.Text & "')"

            cmd.Connection = gcon3

            mCmd3 = New OleDb.OleDbCommand(Query4, gcon3)

            mCmd1.ExecuteNonQuery()
            mCmd2.ExecuteNonQuery()
            mCmd3.ExecuteNonQuery()


            Qualif1()

            If txtqual2.Text <> "" Then
                Qualif2()
            End If
            If txtqual3.Text <> "" Then
                Qualif3()
            End If
            MsgBox("Thank you for adding your Record.", MsgBoxStyle.Information, Me.Text)
            gcon1.Close()
            gcon2.Close()
            gcon3.Close()
            gcon5.Close()
        Catch ex As Exception
            gcon1.Close()
            gcon2.Close()
            gcon3.Close()
            gcon5.Close()
        Finally
        End Try

        ClearForm()
    End Sub
    Sub Qualif1()
        Try
            gcon.Open()

            Query4 = "Insert into Examiner_Qualif(EXAMYEAR,EXAMINERNO,QUALIF1,YROBTAINED1)" _
           & "values" _
           & "('" & txtexamyr.Text & "', '" & txtexaminer_no.Text & "','" & txtqual1.Text & "','" & txtqyr1.Text & "')"

            mCmd4 = New OleDb.OleDbCommand(Query4, gcon)
            mCmd4.ExecuteNonQuery()
            gcon.Close()
        Catch ex As Exception
            gcon.Close()
        Finally
        End Try
    End Sub
    Sub Qualif2()
        Dim cmd As New OleDb.OleDbCommand
        gcon4.Open()

        Query5 = "update Examiner_Qualif set QUALIF2='" & txtqual2.Text & "',YROBTAINED2='" & txtqyr2.Text & "'where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
        cmd.Connection = gcon4

        mCmd5 = New OleDb.OleDbCommand(Query5, gcon4)
        mCmd5.ExecuteNonQuery()
        gcon4.Close()
    End Sub
    Sub Qualif3()
        Dim cmd As New OleDb.OleDbCommand
        gcon6.Open()

        Query6 = "update Examiner_Qualif set QUALIF3='" & txtqual3.Text & "',YROBTAINED3='" & txtqyr3.Text & "'where ((EXAMINERNO='" & txtexaminer_no.Text & "')and(EXAMYEAR='" & txtexamyr.Text & "'))"
        cmd.Connection = gcon5

        mCmd6 = New OleDb.OleDbCommand(Query6, gcon5)
        mCmd6.ExecuteNonQuery()
        gcon6.Close()
    End Sub
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If validateform() = True Then
            Add_Examiner()
        Else
            If validateform() = False Then

            End If
        End If
        Exit Sub

    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub CboSubjCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubjCode.SelectedIndexChanged
        Dim cmd, cmd1 As New OleDbCommand
        Dim dr As OleDbDataReader
        chief = "0000"
        assistantchief = "0001"
        asstexaminer = "0002"


        gcon8.Open()
        cmd1.CommandText = "Select * FROM Status_Tbl where Status='" & CboStatus.Text & "'  "
        cmd1.Connection = gcon8
        dr = cmd1.ExecuteReader
        While dr.Read()
            sCode = dr("Status_Code")
            stitle = dr("status")
        End While
        gcon8.Close()
        If sCode = chief Then
            get_cheifexaminerno()
        End If
        If sCode = assistantchief Then
            get_cheifexaminerno()
        End If
        If sCode = asstexaminer Then
            get_examinerno()
        End If
    End Sub
    Sub getstatuscode()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Dim cmd1, cmd2 As New OleDbCommand
       
      
        If sCode = chief Then

            If examinerno_Status = chief Then
                MsgBox("Chief Examiner For this Subject Already Exist")
                Exit Sub
            End If
        End If
        If examinerno_Status <> chief Then
            If CboStatus.Text = stitle Then

                txtexaminer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))
            End If
        End If

        If sCode = assistantchief Then
            If examinerno_Status = assistantchief Then
                MsgBox("Assistant Chief Examiner For this Subject Already Exist")
                Exit Sub
            End If
        End If
        If examinerno_Status <> assistantchief Then
            If CboStatus.Text = stitle Then

                txtexaminer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))

            End If

        End If


    End Sub
    Sub getstatus()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Dim cmd1, cmd2 As New OleDbCommand
        Dim ass As String
        Try

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
            MsgBox("Username cannot be more than 6 characters ", MsgBoxStyle.Information, Me.Text)
            txtusername.Focus()
        End If

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtpassword.TextLength > 6 Then
            MsgBox("Password must be 6 characters ", MsgBoxStyle.Information, Me.Text)
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txttel_off_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_off.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttel_off_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttel_off.Leave
        If txttel_off.Text.Length > 7 Or txttel_off.Text.Length < 7 Then
            MsgBox("Tele. No. cannot be more or less than 7 digits.", MsgBoxStyle.Information, Me.Text)
            txttel_off.Text = ""
            txttel_off.Focus()
        End If
    End Sub

    Private Sub txtwtel_mob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwtel_mob.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtrtel_home_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtrtel_home_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txtrtel_home.Text.Length > 7 Or txtrtel_home.Text.Length < 7 Then
        '    MsgBox("Tele. No. cannot be more or less than 7 digits.", MsgBoxStyle.Information, Me.Text)
        '    txtrtel_home.Text = ""
        '    txtrtel_home.Focus()
        'End If
    End Sub

    Private Sub txtwtel_mob_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtwtel_mob.Leave
        If txtwtel_mob.Text.Length > 7 Or txtwtel_mob.Text.Length < 7 Then
            MsgBox("Tele. No. cannot be more or less than 7 digits.", MsgBoxStyle.Information, Me.Text)
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
            'txtlname.Text = ""
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

    Private Sub txtrcomp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'enter only numbers for compound No.
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtrcomp_name_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txtrcomp_name.Text.Length > 3 Then
        '    MsgBox(" Compound No. should not be more than 3 digits.", MsgBoxStyle.Information, Me.Text)
        '    txtrcomp_name.Text = ""
        '    txtrcomp_name.Focus()
        'End If
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
            If txtwtel_mob.Text.Length < 7 Then
                MsgBox("Please supply details of work place.", MsgBoxStyle.Information, Me.Text)
                txtwtel_mob.Focus()
            End If
        End If
        If txttel_off.Text = "" Then
            If txttel_off.Text.Length < 7 Then
                MsgBox("Please supply details of work place.", MsgBoxStyle.Information, Me.Text)
                txttel_off.Focus()
            End If
        End If

        If txtrlocal.Text = "" Then
            MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
            txtrlocal.Focus()
        End If
        'If txtrcomp_name.Text = "" Then
        '    MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
        '    txtrcomp_name.Focus()
        'End If
        'If txtrtel_home.Text = "" Or txtrtel_home.Text.Length < 7 Then

        '    MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
        '    txtrcomp_name.Focus()
        'End If

        'If txtrstreet.Text = "" Then
        '    MsgBox("Please supply residential details.", MsgBoxStyle.Information, Me.Text)
        '    txtrcomp_name.Focus()
        'End If

        If txtqual1.Text = "" Or txtqyr1.Text = "" Then
            MsgBox("Please supply qualifications.", MsgBoxStyle.Information, Me.Text)


            'If txtMrkSubj.Text = "" Or txtNoofyrs.Text = "" Then
            '    MsgBox("Please Marking Experience Details.", MsgBoxStyle.Information, Me.Text)

            validateform = False
            Exit Function
            txtlname.Focus()
        Else
            validateform = True
            cmdsave.Enabled = True
        End If

    End Function

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        ClearForm()
    End Sub

    Public Sub ClearForm()

        'clears the form for new candidate entry
        CboTitle.SelectedIndex = 1
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
        'txtrcomp_name.Text = ""
        txtrlocal.Text = ""
        txtrstreet.Text = ""
        ' txtrtel_home.Text = ""
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
        ' txtMrkSubj.Text = ""
        '  txtNoofyrs.Text = ""
        CboTitle.Focus()
    End Sub

    Private Sub txtoccup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoccup.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtconfpass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtconfpass.Leave
        If txtconfpass.Text <> txtpassword.Text Then
            MsgBox("Please confirm your password.", MsgBoxStyle.Information, Me.Text)
            txtconfpass.Text = ""
            txtconfpass.Focus()
        End If
    End Sub

    Sub UQualif2()
        'Dim cmd As New OleDb.OleDbCommand
        'Try
        '    gcon4.Open()

        '    Query5 = "Insert into Examiner_Qualif(EXAMYEAR,EXAMINERNO,QUALIF,YROBTAINED)" _
        '   & "values" _
        '   & "('" & txtexamyr.Text & "', '" & txtexaminer_no.Text & "','" & txtqual2.Text & "','" & txtqyr2.Text & "')"
        '    cmd.Connection = gcon4

        '    mCmd5 = New OleDb.OleDbCommand(Query5, gcon4)
        '    mCmd5.ExecuteNonQuery()
        '    gcon4.Close()
        'Catch ex As Exception
        '    gcon4.Close()
        'Finally
        'End Try
    End Sub
    Sub UQualif3()
        'Dim cmd As New OleDb.OleDbCommand
        'Try
        '    gcon5.Open()

        '    Query6 = "Insert into Examiner_Qualif(EXAMYEAR,EXAMINERNO,QUALIF,YROBTAINED)" _
        '   & "values" _
        '   & "('" & txtexamyr.Text & "', '" & txtexaminer_no.Text & "', '" & txtqual3.Text & "','" & txtqyr3.Text & "')"
        '    cmd.Connection = gcon5

        '    mCmd6 = New OleDb.OleDbCommand(Query6, gcon5)
        '    mCmd6.ExecuteNonQuery()
        '    gcon5.Close()
        'Catch ex As Exception
        '    gcon5.Close()
        'Finally
        'End Try
    End Sub

    Private Sub txtqyr1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqyr1.Leave
        Try
            If txtqyr1.Text < 1960 Or txtqyr1.Text > Now.Year Then
                MsgBox("Please check year of Graduation.")
                txtqyr1.Text = ""
                txtqyr1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtqyr2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqyr2.Leave
        Try
            If txtqyr2.Text < 1960 Or txtqyr2.Text > Now.Year Then
                MsgBox("Please check year of Graduation.")
                txtqyr2.Text = ""
                txtqyr2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtqyr3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqyr3.Leave
        Try
            If txtqyr3.Text < 1960 Or txtqyr3.Text > Now.Year Then
                MsgBox("Please check year of Graduation.")
                txtqyr3.Text = ""
                txtqyr3.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

   
End Class