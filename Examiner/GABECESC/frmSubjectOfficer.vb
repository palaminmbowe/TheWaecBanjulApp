Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.Data.OleDb

Public Class frmSubjectOfficer
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

    Dim subjcode, curcentre, nname As String
    Dim dSet As DataSet
    Dim ds As New DataSet

    Dim db As New dbConnection3(MDIParent1.connectionString)

    Sub Subjects()
        gcon.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from Wasubjects "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read
            CboSubjCode.Items.Add(dr("Description"))
        End While

        dr.Close()
        gcon.Close()

    End Sub

    Private Sub FrmCreate_Examiner__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtExamYear.Text = Now.Year()

        GetCountry()
        gettitles()
        'GetExamYear()
        MyPa = 0

        Subjects()
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
    Sub addlogindetails()
        Dim cmd As New OleDb.OleDbCommand
        gcon.Open()
        Dim Level As Integer
        Level = 2
        Query1 = "Insert into MyUsers(CUserId,CPassword,ExaminerNo,UserLevel)" _
        & "values" _
        & "('" & txtUserName.Text & "','" & TextBox1.Text & "','" & txtexaminer_no.Text & "','" & Level & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()
        gcon.Close()
    End Sub

    Sub addExamBioDetails()
        ' Try
        Dim cmd As New OleDb.OleDbCommand
        Dim EXCODE As String
        Dim title As String
        title = cmbTitle.Text
        EXCODE = CboSubjCode.Text & txtexaminer_no.Text
        gcon.Open()
        Query1 = "Insert into SubjectOfficer(ExamYear,SubjectOffNo,Title,SurName,FirstName,ONames,Sex,Nationality)" _
        & "values" _
        & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & cmbTitle.Text & "','" & txtlname.Text & "'," _
        & "'" & txtfname.Text & "','" & txtoname.Text & "','" & CmbGender.Text & "','" & cmbNational.Text & "')"
        cmd.Connection = gcon
        mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
        mCmd1.ExecuteNonQuery()

        gcon.Close()
        ' End Try
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

    Sub CheckExaminer()

        Try
            db.con.Open()

            db.cmd.CommandText = "select * from SubjectOfficer WHERE SubjectOffNo = '" & txtexaminer_no.Text & "'"
            'cmd.Connection = gcon
            db.dr = db.cmd.ExecuteReader()
            While db.dr.Read
                MyPa = 1
            End While
        Catch ex As Exception
            Console.WriteLine("Error in checkExaminer(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

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
     
     
     
        If cmbTitle.SelectedIndex = -1 Then
            MsgBox("Check a title for Examiner")
            cmbTitle.Focus()
            Exit Sub
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If (txtCPassword.Text = TextBox1.Text) And (txtUserName.Text.Length <> 5) Then
            CheckExaminer()
            If MyPa = 0 And txtexaminer_no.Text.Length = 5 Then
                'Add_Examiner()
                Examiner = txtexaminer_no.Text
                CHECKENTRIES()
                addExamBioDetails()

                addlogindetails()
                MsgBox("Subject Officer added")
                cmbTitle.SelectedIndex = -1
                CmbGender.SelectedIndex = -1
                cmbNational.SelectedIndex = -1
                txtCPassword.Text = ""
                txtexaminer_no.Text = ""
                txtfname.Text = ""
                txtlname.Text = ""
                txtoname.Text = ""
                txtPassword.Text = ""
                txtUserName.Text = ""
                CboSubjCode.SelectedIndex = -1
                TextBox1.Text = ""

            Else
                MyPa = 0
                MsgBox("This Examiner Code cannot be assigned")

            End If
        Else
            MsgBox("Username must be atleast 5 characters and Passwords must be Thesame")
        End If
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Sub CHECKCODE()
        Try
            db.con.Open()

            db.cmd.CommandText = "select * from Wasubjects WHERE Description = '" & CboSubjCode.Text & "'"

            db.dr = db.cmd.ExecuteReader

            If db.dr.Read Then
                txtexaminer_no.Text = db.dr("SubjCode") & "01"
            End If
        Catch ex As Exception
            Console.WriteLine("Error in checkCode: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Private Sub CboSubjCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubjCode.SelectedIndexChanged

        CHECKCODE()

    End Sub

  

    Private Sub cmdmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim modify As New frmModifyExaminer
        modify.Show()

    End Sub


End Class