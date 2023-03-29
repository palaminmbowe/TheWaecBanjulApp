
Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.Data.OleDb

Public Class FrmCreate_Examiner_
    'Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                                   System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    'Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    'Dim Hon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")
    'Dim Ton As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")
    'Dim gcon1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    Public gcon As New OleDbConnection(MDIParent1.connectionString)
    Public con As New OleDbConnection(MDIParent1.connectionString)

    Public Hon As New OleDbConnection(MDIParent1.connectionString)
    Public Ton As New OleDbConnection(MDIParent1.connectionString)
    Public gcon1 As New OleDbConnection(MDIParent1.connectionString)

    Dim MyPa As Integer
    Dim da As OleDbDataAdapter
    Dim dAdapt As OleDbDataAdapter
    Dim dr As OleDbDataReader
    
    Dim subjcode, curcentre, nname, examinno, currentno, currentno1, status, status1 As String
    Dim dSet As DataSet
    Dim ds As New DataSet

    Dim db As New dbConnection3(MDIParent1.connectionString)

    Const TAD_EXAMINER_NUMBER_LENGTH = 7

    Sub Subjects()
        'Dim PAPTYPE As String
        Dim cus As String

        Try
            db.con.Open()

            cus = Mid(curuser, 1, 3)

            db.cmd.CommandText = "select * from wsubjndx where PaperCode like '" & Strings.Mid(curuser, 1, 3) & "%'"
            db.dr = db.cmd.ExecuteReader()

            While db.dr.Read
                If db.dr("PapType") <> "OBJECTIVE" Then
                    subjcode = db.dr("PaperCode")
                    CboSubjCode.Items.Add(db.dr("PaperCode"))
                End If
            End While
        Catch ex As Exception
        Finally
            db.con.Close()
        End Try

    End Sub
    
    Private Sub FrmCreate_Examiner__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtExamYear.Text = MDIParent1.CurrentExamYear
        GetStatus()
        GetCountry()
        gettitles()
        'GetExamYear()
        MyPa = 0

        Subjects()
        cmbTitle.DroppedDown = True
    End Sub

    Sub gettitles()
        Try
            db.con.Open()

            db.cmd.CommandText = "select * from titles"
            db.dr = db.cmd.ExecuteReader
            While db.dr.Read
                cmbTitle.Items.Add(Trim(db.dr("Title")))
            End While
        Catch ex As Exception
            Console.WriteLine("Error in GetStatus(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub addlogindetails()
        Try
            db.con.Open()

            Dim Level As Integer

            Level = 1

            db.cmd.CommandText = "Insert into MyUsers(CUserId,CPassword,ExaminerNo,UserLevel)" _
            & "values" _
            & "('" & txtUserName.Text & "','" & txtPassword.Text & "','" & txtexaminer_no.Text & "','" & Level & "')"

            Dim result = db.cmd.ExecuteNonQuery()

            If result Then
                Console.WriteLine("Success")
            End If
        Catch ex As Exception
            Console.WriteLine("Error in addLoginDetails(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub
    Sub addExamBioDetails()
        Try
            db.con.Open()

            Dim EXCODE As String
            Dim title As String
            title = cmbTitle.Text
            EXCODE = CboSubjCode.Text & txtexaminer_no.Text

            db.cmd.CommandText = "Insert into ExamBiodetails(ExamYear,ExaminerNo,Title,SurName,FirstName,ONames,Sex,Nationality,Occupation, TadExaminerNo)" _
            & "values" _
            & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & cmbTitle.Text & "','" & txtlname.Text & "'," _
            & "'" & txtfname.Text & "','" & txtoname.Text & "','" & CmbGender.Text & "','" & cmbNational.Text & "','" & txtoccup.Text & "', '" & txtExaminerTADNo.Text & "')"

            'mCmd1 = New OleDb.OleDbCommand(Query1, gcon)
            'mCmd1.ExecuteNonQuery()
            Dim result As Integer
            result = db.cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error in addExamBioDetails(): " & ex.Message())
            MessageBox.Show("Error saving exam biodetails(): ")
        Finally
            db.con.Close()
        End Try
    End Sub
    Sub addExamAddress()
        Try
            db.con.Open()

            'Dim EXCODE As String
            'EXCODE = CboSubjCode.Text & txtexaminer_no.Text

            'db.cmd.CommandText = "Insert into ExamAddress(ExamYear,ExaminerNo,WCity,OffNum,Mobile,RTown,Locality,Street,CName,Htel)" _
            '    & "values" _
            '    & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & txtwcity.Text & "','" & txttel_off.Text & "'," _
            '    & "'" & txtwtel_mob.Text & "','" & txtrtel_home.Text & "')" '& txtrcity.Text & "','" & txtrlocal.Text & "','" & txtrstreet.Text & "','" & txtrcomp_name.Text & "'


            db.cmd.CommandText = "Insert into ExamAddress(ExamYear,ExaminerNo,WCity,OffNum,Mobile,Htel)" _
            & "values" _
            & "('" & txtExamYear.Text & "', '" & txtexaminer_no.Text & "','" & txtwcity.Text & "','" & txttel_off.Text & "'," _
            & "'" & txtwtel_mob.Text & "','" & txtrtel_home.Text & "')" '& txtrcity.Text & "','" & txtrlocal.Text & "','" & txtrstreet.Text & "','" & txtrcomp_name.Text & "'

            Dim result As Integer = db.cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error in addExamAddress(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub
    Sub addQualificationDetail1()
        Dim cmd As New OleDb.OleDbCommand
        Dim EXCODE As String
        EXCODE = CboSubjCode.Text & txtexaminer_no.Text
        gcon.Open()
        Query1 = "Insert into EXAMINER_QUA(ExamYear,ExaminerNo,Qualification1,MajorSubject,Year1)" _
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
    Sub ClearForm()
        CboSubjCode.SelectedIndex = -1
        CmbGender.SelectedIndex = -1
        cmbTitle.SelectedIndex = -1
        cmbNational.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

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
        '   txtrcity.Text = ""
        '  txtrlocal.Text = ""
        '  txtrstreet.Text = ""
        '  txtrcomp_name.Text = ""
        txtrtel_home.Text = ""
        txtqyr2.Text = ""
        txtqyr1.Text = ""
        txtqyr3.Text = ""
        txtExaminerTADNo.Text = ""

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
        Try
            db.con.Open()

            db.cmd.CommandText = "select * from ExaminerType "
            db.dr = db.cmd.ExecuteReader
            While db.dr.Read
                'centcode = dr("CENTCODE")
                cmbStatus.Items.Add(db.dr("Description"))
            End While
        Catch ex As Exception
            Console.WriteLine("Error in GetStatus(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub GetCountry()
        Try
            db.con.Open()
            db.cmd.CommandText = "select * from Countries "
            db.dr = db.cmd.ExecuteReader
            While db.dr.Read
                'centcode = dr("CENTCODE")
                cmbNational.Items.Add(db.dr("Country"))
            End While
        Catch ex As Exception
            Console.WriteLine("Error in GetStatus(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub GeteXCODE()
        Try
            db.con.Open()
            db.cmd.CommandText = "select * from ExaminerType WHERE Description = '" & cmbStatus.Text & "'"
            db.dr = db.cmd.ExecuteReader()

            While db.dr.Read()
                STATUSCODE = (db.dr("StatusID"))
            End While

            txtexaminer_no.Text = STATUSCODE
            EXCODE1 = STATUSCODE
        Catch ex As Exception
            Console.WriteLine("Error in GetExCode(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
        
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
        Try
            db.con.Open()

            db.cmd.CommandText = "select * from ExamBiodetails WHERE ExaminerNo='" & txtexaminer_no.Text & "'"
            db.dr = db.cmd.ExecuteReader()

            MyPa = 0

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

    Function CheckAllFields() As Boolean

        If cmbTitle.SelectedIndex = -1 Then
            MsgBox("Check a title for Examiner")
            cmbTitle.Focus()
            cmbTitle.BackColor = Color.PaleVioletRed
            Return False
        Else
            cmbTitle.BackColor = Color.White
        End If

        If txtlname.Text.Length < 2 Or txtlname.Text = "" Then
            MsgBox("you must Enter a Last Name")
            txtlname.Focus()
            txtlname.BackColor = Color.PaleVioletRed
            Return False
        Else
            txtlname.BackColor = Color.White
        End If

        If txtfname.Text.Length < 2 Or txtfname.Text = "" Then
            MsgBox("you must Enter a First Name")
            txtfname.Focus()
            txtfname.BackColor = Color.PaleVioletRed
            Return False
        Else
            txtfname.BackColor = Color.White
        End If

        If CmbGender.SelectedIndex = -1 Then
            MsgBox("Select Gender of Examiner")
            CmbGender.Focus()
            CmbGender.BackColor = Color.PaleVioletRed
            Return False
        Else
            CmbGender.BackColor = Color.White
        End If

        If cmbNational.SelectedIndex = -1 Then
            MsgBox("Select Nationality of Examiner")
            cmbNational.Focus()
            cmbNational.BackColor = Color.PaleVioletRed
            Return False
        Else
            cmbNational.BackColor = Color.White
        End If

        If txtoccup.Text.Length < 2 Or txtoccup.Text = "" Then
            MsgBox("you must Enter Occupation")
            txtoccup.Focus()
            txtoccup.BackColor = Color.PaleVioletRed
            Return False
        Else
            txtoccup.BackColor = Color.White
        End If

        If txtmsubj.Text.Length < 2 Or txtmsubj.Text = "" Then
            MsgBox("you must Enter Major")
            txtmsubj.Focus()
            txtmsubj.BackColor = Color.PaleVioletRed
            Return False
        Else
            txtmsubj.BackColor = Color.White
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MsgBox("Select Status of Examiner")
            cmbStatus.Focus()
            cmbStatus.BackColor = Color.PaleVioletRed
            Return False
        Else
            cmbStatus.BackColor = Color.White
        End If

        If CboSubjCode.SelectedIndex = -1 Then
            MsgBox("Select subject please")
            CboSubjCode.BackColor = Color.PaleVioletRed
            Return False
        Else
            CboSubjCode.BackColor = Color.White
        End If

        If txtExaminerTADNo.Text.Length <> TAD_EXAMINER_NUMBER_LENGTH Then
            MsgBox("Kindly enter the Examiner's number. It should be seven (7) digits.")
            Return False
        End If

        Return True
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If Not CheckAllFields() Then
            Return
        End If

        If txtCPassword.Text = txtPassword.Text And txtUserName.Text.Length >= 5 Then
            checkexaminer()
            If MyPa = 0 And txtexaminer_no.Text.Length = 12 Then
                'Add_Examiner()
                Examiner = txtexaminer_no.Text
                CHECKENTRIES()
                addExamBioDetails()
                addExamAddress()
                If txtqual1.Text.Length > 5 Then
                    addQualificationDetail1()
                End If
                If txtqual2.Text.Length > 5 Then
                    updatequali2()
                    'addQualificationDetail2()
                End If
                If txtqual3.Text.Length > 5 Then
                    updatequali3()
                    ' addQualificationDetail3()
                End If
                addlogindetails()
                MessageBox.Show("Examiner successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MsgBox("Examiner added")
                ClearForm()
            End If

        Else
            MsgBox("Username must be atleast 5 characters and Passwords must be The same")
        End If
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Sub CHECKCODE()
        '  Try
        examinno = EXCODE1 & CboSubjCode.Text
        'examinno = CboSubjCode.Text

        Try
            db.con.Open()

            'cmd.CommandText = "select * from ExamBiodetails WHERE (mid(ExaminerNo, 1 ,10)) = '" & txtexaminer_no.Text & "" & CboSubjCode.Text & "'  "= '" & examinno & "'")

            'db.cmd.CommandText = "select * from ExamBiodetails WHERE ExaminerNo like = '" & examinno & "'%" '(mid(ExaminerNo, 1 ,10))  = '" & Strings.Right(examinno, 3) & "';"

            db.cmd.CommandText = "SELECT DISTINCT VAL(select COUNT(*) from ExamBiodetails WHERE (LEFT(ExaminerNo, 10) = '" & examinno & _
                "')) + 1 FROM ExamBiodetails"

            'db.dr = db.cmd.ExecuteReader()

            Dim indexNo As Object = db.cmd.ExecuteScalar()

            'indexNo = Strings.Right(String.Concat("00", CStr(indexNo)), 2)
            examinno = String.Concat(examinno, Strings.Right(String.Concat("00", CStr(indexNo)), 2))
            txtexaminer_no.Text = examinno

            ''If db.dr.Read Then
            ''    ' While dr.Read
            ''    status = Mid(db.dr("ExaminerNo"), 1, 4)
            ''    If Mid((db.dr("ExaminerNo")), 1, 4) = "0000" Then
            ''        If status = "0000" Then
            ''            MsgBox("Chief Examiner already selected for subject")
            ''            Exit Sub
            ''        End If

            ''        If Mid((db.dr("ExaminerNo")), 1, 4) = "0001" Then
            ''            'If status = "0001" Then
            ''            getIndexNumber()
            ''            'EXCODE = num
            ''            'txtexaminer_no.Text = STATUSCODE & txtexaminer_no.Text & EXCODE
            ''            'currentno = dr("ExaminerNo")
            ''            'currentno1 = Mid((currentno), 11, 2)
            ''            'num = (CInt(currentno1))
            ''            'num = num + 1
            ''            txtexaminer_no.Text = examinno & (Format(num, "00"))
            ''        End If

            ''        '  If Mid((dr("ExaminerNo")), 1, 4) = "0002" Then
            ''        If status = "0002" Then
            ''            status1 = Mid(status, 1, 3)
            ''            'currentno = dr("ExaminerNo")
            ''            getIndexNumber()
            ''            'currentno1 = Mid((currentno), 11, 2)
            ''            'num = (CInt(currentno1))
            ''            'num = num + 1
            ''            txtexaminer_no.Text = currentno & (Format(num, "00"))
            ''            ' End If
            ''        Else
            ''            num = num + 1
            ''            txtexaminer_no.Text = status1 & num '(Format(num, "00"))
            ''        End If
            ''    End If
            ''    '   End While
            ''End If
            ' ''    Catch
            ' '' Finally
            ' ''End Try
        Catch ex As Exception
            Console.WriteLine("Error in CheckCode(): " & ex.Message)
            MessageBox.Show("Error generating examiner number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.con.Close()
        End Try
        
    End Sub
    Sub getIndexNumber()
        'sosseh commented 
        'Variable to store subjcode from the subjects table
        Try
            con.Open()
            Dim cmd As New OleDbCommand

            mQuery = "Select MAX(ExaminerNo) from ExamBiodetails where ExaminerNo like'" & examinno & "%'" ' '" & EXCODE1 & "%'"

            mCmd = New OleDb.OleDbCommand(mQuery, con)
            num = mCmd.ExecuteScalar()

            num = Format(num, Style:="00")
            num = num + 1
            con.Close()
        Catch ex As Exception
            Console.WriteLine("Error in getIndexNumber: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub txtExaminerTADNo_TextChanged(sender As Object, e As EventArgs) Handles txtExaminerTADNo.TextChanged
        If txtExaminerTADNo.Text.Length <> TAD_EXAMINER_NUMBER_LENGTH Then
            txtExaminerTADNo.BackColor = Color.PaleVioletRed
        Else
            txtExaminerTADNo.BackColor = Color.White
            txtCPassword.Text = Strings.Mid(txtExaminerTADNo.Text, 5, 3)
            txtPassword.Text = Strings.Mid(txtExaminerTADNo.Text, 5, 3)
        End If
    End Sub

    Private Sub CboSubjCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubjCode.SelectedIndexChanged
        CHECKCODE()
        Try
            txtUserName.Enabled = True
            txtExaminerTADNo.Text = Strings.Left(CboSubjCode.SelectedItem.ToString(), 4)
            txtUserName.Text = txtlname.Text.ToLower() + Strings.Left(CboSubjCode.SelectedItem.ToString(), 4)
            txtUserName.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        GeteXCODE()
        'CboSubjCode.DroppedDown = True
    End Sub

    Private Sub cmdmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        Dim modify As New frmModifyExaminer
        modify.Show()

    End Sub
    Sub updatequali2()
        con.Open()
        mQuery2 = "UPDATE EXAMINER_QUA SET Qualification2='" & txtqual2.Text & "',Year2='" & txtqyr2.Text & "'" _
              & " WHERE (ExaminerNo='" + Examiner + "')"
        mCmd = New OleDb.OleDbCommand(mQuery2, con)
        mCmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub updatequali3()
        con.Open()
        mQuery3 = "UPDATE EXAMINER_QUA SET Qualification3='" & txtqual3.Text & "',Year3='" & txtqyr3.Text & "'" _
              & " WHERE (ExaminerNo='" + Examiner + "')"
        mCmd = New OleDb.OleDbCommand(mQuery3, con)
        mCmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub cmbTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTitle.SelectedIndexChanged
        txtlname.Focus()
    End Sub

    Private Sub CmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGender.SelectedIndexChanged
        cmbNational.Focus()
        'cmbNational.DroppedDown = True
    End Sub
End Class