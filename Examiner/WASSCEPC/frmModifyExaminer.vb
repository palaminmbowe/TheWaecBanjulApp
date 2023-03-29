Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.Data.OleDb

Public Class frmModifyExaminer
    'Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                                   System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    'Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    'Dim Hon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")
    'Dim Ton As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    Public gcon As New OleDbConnection(MDIParent1.connectionString)
    Public con As New OleDbConnection(MDIParent1.connectionString)

    Public Hon As New OleDbConnection(MDIParent1.connectionString)
    Public Ton As New OleDbConnection(MDIParent1.connectionString)

    Dim MyPa As Integer
    Dim da As OleDbDataAdapter
    Dim dAdapt As OleDbDataAdapter
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim EXCODE, STATUSCODE As String
    Dim mCmd As OleDbCommand
    Dim mQuery, mQuery1, mQuery2, mQuery3 As String
    Dim mCmd1, mCmd2, mCmd3, mCmd4, mCmd5 As OleDbCommand
    Dim num As Integer
    Dim Query1, Query2, Query3, Query4, Query5 As String

    Dim subjcode, curcentre, nname As String
    Dim dSet As DataSet
    Dim ds As New DataSet

    Sub Subjects()
        gcon.Open()
        Dim cus As String
        cus = Mid(curuser, 1, 3)

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from wsubjndx where PaperCode like '" & cus & "%'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            subjcode = dr("PaperCode")
            CboSubjCode.Items.Add(dr("PaperCode"))
        End While

        dr.Close()
        gcon.Close()

    End Sub

    Private Sub FrmCreate_Examiner__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtExamYear.Text = MDIParent1.CurrentExamYear
        GetStatus()
        GetCountry()
        gettitles()

        'GetExamYear()
        MyPa = 0

        Subjects()
    End Sub
    Sub addlogindetails()
        Dim cmd As New OleDb.OleDbCommand
        gcon.Open()
        Query1 = "Insert into MyUsers(CUserId,CPassword,ExaminerNo)" _
        & "values" _
        & "('" & txtUserName.Text & "','" & TextBox1.Text & "','" & txtexaminer_no.Text & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()
        gcon.Close()
    End Sub
    Sub addExamBioDetails()
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim EXCODE As String
            Dim title As String
            title = cmbTitle.Text
            EXCODE = CboSubjCode.Text & txtexaminer_no.Text
            gcon.Open()
            Query1 = "Insert into ExamBiodetails(ExamYear,ExaminerNo,Title,SurName,FirstName,ONames,Sex,Nationality,Occupation)" _
            & "values" _
            & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & cmbTitle.Text & "','" & txtlname.Text & "'," _
            & "'" & txtfname.Text & "','" & txtoname.Text & "','" & CmbGender.Text & "','" & cmbNational.Text & "','" & txtoccup.Text & "')"
            cmd.Connection = gcon
            mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
            mCmd1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            gcon.Close()
        End Try
    End Sub
    Sub addExamAddress()
        Dim cmd As New OleDb.OleDbCommand
        Dim EXCODE As String
        EXCODE = CboSubjCode.Text & txtexaminer_no.Text
        gcon.Open()
        Query1 = "Insert into ExamAddress(ExamYear,ExaminerNo,WCity,OffNum,Mobile,RTown,Locality,Street,CName,Htel)" _
        & "values" _
        & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & txtwcity.Text & "','" & txttel_off.Text & "'," _
        & "'" & txtwtel_mob.Text & "','" & txtrcity.Text & "','" & txtrlocal.Text & "','" & txtrstreet.Text & "','" & txtrcomp_name.Text & "','" & txtrtel_home.Text & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()
        gcon.Close()
    End Sub
    Sub addQualificationDetail1()
        Dim cmd As New OleDb.OleDbCommand
        Dim EXCODE As String
        EXCODE = CboSubjCode.Text & txtexaminer_no.Text
        gcon.Open()
        Query1 = "Insert into EXAMINER_QUA(ExamYear,ExaminerNo,Qualification,MajorSubject,YearOb)" _
        & "values" _
        & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & txtqual1.Text & "','" & txtmsubj.Text & "'," _
        & "'" & txtqyr1.Text & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()
        gcon.Close()
    End Sub
    Sub addQualificationDetail2()
        Dim cmd As New OleDb.OleDbCommand
        Dim EXCODE As String
        EXCODE = CboSubjCode.Text & txtexaminer_no.Text
        gcon.Open()
        Query1 = "Insert into EXAMINER_QUA(ExamYear,ExaminerNo,Qualification,MajorSubject,YearOb)" _
        & "values" _
        & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & txtqual2.Text & "','" & txtmsubj.Text & "'," _
        & "'" & txtqyr2.Text & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()
        gcon.Close()
    End Sub
    Sub addQualificationDetail3()
        Dim cmd As New OleDb.OleDbCommand
        Dim EXCODE As String
        EXCODE = CboSubjCode.Text & txtexaminer_no.Text
        gcon.Open()
        Query1 = "Insert into EXAMINER_QUA(ExamYear,ExaminerNo,Qualification,MajorSubject,YearOb)" _
        & "values" _
        & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & txtqual3.Text & "','" & txtmsubj.Text & "'," _
        & "'" & txtqyr3.Text & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()
        gcon.Close()
    End Sub
    Sub Centres()
        gcon.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from CentreTbl "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            'centcode = dr("CENTCODE")
            CboSubjCode.Items.Add(dr("SUBJCODE"))
        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub GetStatus()
        gcon.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from ExaminerType "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            'centcode = dr("CENTCODE")
            cmbStatus.Items.Add(dr("Description"))
        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub GetCountry()
        gcon.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from Countries "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            'centcode = dr("CENTCODE")
            cmbNational.Items.Add(dr("Country"))
        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub GeteXCODE()
        gcon.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from ExaminerType WHERE Description='" & cmbStatus.Text & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            STATUSCODE = (dr("StatusID"))
        End While
        txtexaminer_no.Text = STATUSCODE
        EXCODE = STATUSCODE
        dr.Close()
        gcon.Close()

    End Sub
    Sub Cands()
        gcon.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from SubjectTbl "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            subjcode = dr("SUBJCODE")
            CboSubjCode.Items.Add(dr("SUBJCODE"))
        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub checkexaminer()
        gcon.Open()
        ' Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from ExamBiodetails WHERE ExaminerNo='" & txtexaminer_no.Text & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            MyPa = 1
        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub CHECKENTRIES()
        If txtlname.Text.Length < 2 Or txtlname.Text = "" Then
            MsgBox("you must Enter a Last Name")
            txtlname.Focus()
            Exit Sub
        End If
        If txtfname.Text.Length < 2 Or txtfname.Text = "" Then
            MsgBox("you must Enter a Last Name")
            txtfname.Focus()

        End If
        If CmbGender.SelectedIndex = -1 Then
            MsgBox("Select Gender of Examiner")
            CmbGender.Focus()
            Exit Sub
        End If
        If cmbNational.SelectedIndex = -1 Then
            MsgBox("Select Nationality of Examiner")
            cmbNational.Focus()
            Exit Sub
        End If
        If cmbStatus.SelectedIndex = -1 Then
            MsgBox("Select Status of Examiner")
            cmbStatus.Focus()
            Exit Sub
        End If
        If txtmsubj.Text.Length < 2 Or txtmsubj.Text = "" Then
            MsgBox("you must Enter Major")
            txtfname.Focus()
            Exit Sub
        End If
        If txtoccup.Text.Length < 2 Or txtoccup.Text = "" Then
            MsgBox("you must Enter Occupation")
            txtfname.Focus()
            Exit Sub
        End If
        If cmbTitle.SelectedIndex = -1 Then
            MsgBox("Check a title for Examiner")
            cmbTitle.Focus()
            Exit Sub
        End If
        GroupBox4.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Examiner = InputBox("Enter Examiner Number to Search For")
        'storing the text entered in a string
        If Examiner.Length > 0 Then
            GetExaminer()
        End If
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Sub clearall()
        MsgBox("Examiner not found")
        txtlname.Text = ""
        txtfname.Text = ""
        txtoname.Text = ""
        CmbGender.SelectedIndex = -1
        cmbNational.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        CboSubjCode.SelectedIndex = -1
        txtexaminer_no.Text = ""
        txtoccup.Text = ""
        txtUserName.Text = ""
        txtqual1.Text = ""
        txtqyr1.Text = ""
        txtqual2.Text = ""
        txtqyr2.Text = ""
        txtqual3.Text = ""
        txtqyr3.Text = ""
        txtmsubj.Text = ""
        txtwcity.Text = ""
        txttel_off.Text = ""
        txtwtel_mob.Text = ""
        txtrcity.Text = ""
        txtrlocal.Text = ""
        txtrstreet.Text = ""
        txtrcomp_name.Text = ""
        txtrtel_home.Text = ""
    End Sub
    Sub CHECKCODE()

        gcon.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from ExamBiodetails WHERE ExaminerNo='" & EXCODE & CboSubjCode.Text & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        If dr.Read Then
            If Mid((dr("ExaminerNo")), 1, 4) = "0000" Then
                MsgBox("Chief Examiner already selected for subject")
                gcon.Close()
                Exit Sub
            End If
            If Mid((dr("ExaminerNo")), 1, 4) = "0001" Then
                getIndexNumber()
                EXCODE = num
                txtexaminer_no.Text = STATUSCODE & txtexaminer_no.Text & EXCODE
            End If
            If Mid((dr("ExaminerNo")), 1, 4) = "0002" Then
                getIndexNumber()
                EXCODE = num
                txtexaminer_no.Text = STATUSCODE & txtexaminer_no.Text & EXCODE
            End If
        Else
            txtexaminer_no.Text = STATUSCODE & CboSubjCode.Text & "01"
        End If

        dr.Close()
        gcon.Close()

    End Sub
    Sub getIndexNumber()

        'Variable to store subjcode from the subjects table
        Try
            con.Open()
            Dim cmd As New OleDbCommand

            mQuery = "Select MAX(ExaminerNo) from ExamBiodetails where ExaminerNo like '" & EXCODE & "%'"

            mCmd = New OleDb.OleDbCommand(mQuery, con)
            num = mCmd.ExecuteScalar()

            num = Format(num, Style:="00")
            num = num + 1
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try

    End Sub
    Private Sub CboSubjCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboSubjCode.Leave
        '  CHECKCODE()
    End Sub
    Private Sub cmbStatus_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStatus.Leave
        '  GeteXCODE()
        CHECKCODE()
    End Sub
    Private Sub cmdmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        editrecords()
        ClearForm()
    End Sub

    Sub GetExaminer()
        gcon.Open()
        Dim title As String
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from ExamBiodetails WHERE ExaminerNo='" & Examiner & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        If dr.Read Then
            ' While dr.Read
            txtExamYear.Text = (dr("ExamYear"))
            title = Trim(dr("Title"))
            If title = "Mr." Then
                cmbTitle.SelectedIndex = 0
            ElseIf title = "Mrs." Then
                cmbTitle.SelectedIndex = 1
            ElseIf title = "Miss." Then
                cmbTitle.SelectedIndex = 2
            ElseIf title = "Dr." Then
                cmbTitle.SelectedIndex = 3
            ElseIf title = "Prof." Then
                cmbTitle.SelectedIndex = 4
            End If
            txtlname.Text = (dr("SurName"))
            txtfname.Text = (dr("FirstName"))
            txtoname.Text = (dr("ONames"))
            CmbGender.Text = (dr("Sex"))
            cmbNational.Text = (dr("Nationality"))
            txtoccup.Text = (dr("Occupation"))
            txtexaminer_no.Text = Examiner
            'End While
            dr.Close()
            gcon.Close()
            If Mid(Examiner, 1, 4) = "0000" Then
                cmbStatus.SelectedIndex = 0
            ElseIf Mid(Examiner, 1, 4) = "0001" Then
                cmbStatus.SelectedIndex = 1
            ElseIf Mid(Examiner, 1, 4) = "0002" Then
                cmbStatus.SelectedIndex = 2
            End If
            '''''
            CboSubjCode.Text = Mid(Examiner, 5, 6)
            GetQuali()
            GetContactDetails()
            GetUserName()

        Else
            clearall()
            gcon.Close()
        End If

    End Sub
    Sub GetContactDetails()
        gcon.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from ExamAddress WHERE ExaminerNo='" & Examiner & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            txtwcity.Text = (dr("WCity"))
            txttel_off.Text = (dr("OffNum"))
            txtwtel_mob.Text = (dr("Mobile"))
            txtrcity.Text = (dr("RTown"))
            txtrlocal.Text = (dr("Locality"))
            txtrstreet.Text = (dr("Street"))
            txtrcomp_name.Text = (dr("CName"))
            txtrtel_home.Text = (dr("Htel"))

        End While
        dr.Close()
        gcon.Close()

    End Sub
    Sub GetUserName()
        gcon.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from MyUsers WHERE ExaminerNo='" & Examiner & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            txtUserName.Text = (dr("CUserId"))
        End While
        dr.Close()
        gcon.Close()

    End Sub
    Sub GetQuali()
        gcon.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from EXAMINER_QUA WHERE ExaminerNo='" & Examiner & "'"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            txtqual1.Text = (dr("Qualification1"))
            txtqyr1.Text = (dr("Year1"))
            If IsDBNull(dr("Qualification2")) = False Then
                txtqual2.Text = (dr("Qualification2"))
                txtqyr2.Text = (dr("Year2"))
            End If
            If IsDBNull(dr("Qualification3")) = False Then
                txtqual3.Text = (dr("Qualification3"))
                txtqyr3.Text = (dr("Year3"))
            End If

            txtmsubj.Text = (dr("MajorSubject"))

        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub gettitles()

        gcon.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from titles"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            cmbTitle.Items.Add(Trim(dr("Title")))
        End While

        dr.Close()
        gcon.Close()


    End Sub
    Sub editrecords()
        con.Open()
        mQuery = "UPDATE ExamBiodetails SET Title='" & cmbTitle.Text & "',SurName='" & txtlname.Text & "',FirstName='" & txtfname.Text & "'" _
                 & ",ONames='" & txtoname.Text & "',Sex='" & CmbGender.Text & "',Nationality='" & cmbNational.Text & "',Occupation='" & txtoccup.Text & "'" _
                 & " WHERE (ExaminerNo='" + Examiner + "')"

        mQuery1 = "UPDATE ExamAddress SET WCity='" & txtwcity.Text & "',OffNum='" & txttel_off.Text & "',Mobile='" & txtwtel_mob.Text & "'" _
                & ",RTown='" & txtrcity.Text & "',Locality='" & txtrlocal.Text & "',Street='" & txtrstreet.Text & "',CName='" & txtrcomp_name.Text & "',Htel='" & txtrtel_home.Text & "'" _
                & " WHERE (ExaminerNo='" + Examiner + "')"

        mQuery2 = "UPDATE EXAMINER_QUA SET Qualification1='" & txtqual1.Text & "',Qualification2='" & txtqual2.Text & "',Qualification3='" & txtqual3.Text & "',Year1='" & txtqyr1.Text & "'" _
               & ",Year2='" & txtqyr2.Text & "',Year3='" & txtqyr3.Text & "'" _
               & " WHERE (ExaminerNo='" + Examiner + "')"
        mCmd = New OleDb.OleDbCommand(mQuery, con)
        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
        mCmd2 = New OleDb.OleDbCommand(mQuery2, con)
        mCmd.ExecuteNonQuery()
        mCmd1.ExecuteNonQuery()
        mCmd2.ExecuteNonQuery()
        con.Close()
        MsgBox("RECORD UPDATED")
    End Sub
    Sub ClearForm()
        txtfname.Text = ""
        txtoname.Text = ""
        txtlname.Text = ""
        txtUserName.Text = ""
        txtCPassword.Text = ""
        txtwcity.Text = ""
        TextBox1.Text = ""
        txtoccup.Text = ""
        txttel_off.Text = ""
        txtexaminer_no.Text = ""
        txtqual1.Text = ""
        txtqual2.Text = ""
        txtqual3.Text = ""
        txtmsubj.Text = ""
        txtwtel_mob.Text = ""
        txtrcity.Text = ""
        txtrlocal.Text = ""
        txtrstreet.Text = ""
        txtrcomp_name.Text = ""
        txtrtel_home.Text = ""
        txtqyr2.Text = ""
        txtqyr1.Text = ""
        txtqyr3.Text = ""
        CboSubjCode.SelectedIndex = -1
        CmbGender.SelectedIndex = -1
        cmbTitle.SelectedIndex = -1
        cmbNational.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

    End Sub
End Class