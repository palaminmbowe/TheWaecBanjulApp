Imports System.Data
Imports System.Data.OleDb
Public Class frmModifyMarks
    'Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")
    'Dim gcons As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                                   System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")


    'Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    Public gcon As New OleDbConnection(MDIParent1.connectionString)
    Public con As New OleDbConnection(MDIParent1.connectionString)

    Public Hon As New OleDbConnection(MDIParent1.connectionString)
    Public Ton As New OleDbConnection(MDIParent1.connectionString)
    Public gcons As New OleDbConnection(MDIParent1.connectionString)


    Dim indrange As String  ' Varibale holding the index number range for a center
    Dim indrange1 As String ' Variable holding total number of subjects for a candidate
    Dim dr, DR2 As OleDbDataReader
    Dim subj As String ' Subject description container
    Dim da As OleDbDataAdapter
    Dim dAdapt As OleDbDataAdapter
    Dim log As Integer
    Dim mCmd As OleDbCommand
    Dim mQuery As String
    Dim mCmd1 As OleDbCommand
    Dim mQuery1 As String
    Dim cents As Integer
    Dim dSet As DataSet
    'Total number of Expected marks for a center
    Dim marks As Integer
    Dim ExamYear As String
    Dim Yr1 As Integer '
    Dim Yr2 As Integer
    Dim Yr3 As Integer
    Dim tlength As Integer 'Length of mark enter for candidte
    Dim searchcandidate As String
    Dim search As String ' Container for candidate number to seek for
    Dim num As Integer 'Number of Completed Marks
    Dim i As Integer
    Dim m, Mamxmark As Integer
    Dim SubjCode As String
    Dim CreateDate As Date
    Dim nn, mm, oo, pp, qq, rr As Integer
    Dim ModiDate As Date
    Dim centre, centno, index, sub1, papcodes As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' centers()
        Me.Text = curuser & "                 " & Me.Text

        getcent()
        '  txtExamYear.Text = Year(Now())
        m = 0
        '  popsubject()
        ' CheckConversion()
        txtExamYear.Text = Now.Year
        'chkAdd.Checked = True

        ModiDate = Now.Date
    End Sub
    Sub centers()
        gcon.Open()
        ' Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand

        cmd.CommandText = "select count (*) from tbl_center "
        cmd.Connection = gcon
        cents = cmd.ExecuteScalar
        gcon.Close()
    End Sub
    'Methods to load name,centers,subjects
    Sub getname()
        ' This method will load the candidate Name from the Master File
        Try

            Dim cmd1 As New OleDbCommand

            Dim center As String
            Dim index As String
            con.Open()
            center = cmbCenter.SelectedText
            index = cmbIndex.Text


            cmd1.CommandText = "select * from details where CentNo Like ('" & cmbCenter.Text & "%') and IndexNo like ('" & cmbIndex.Text & "%')"

            cmd1.Connection = con

            DR2 = cmd1.ExecuteReader
            If DR2.Read() Then
                txtCandName.Text = DR2("CandName")
            Else
                MsgBox("Invalid Index Number")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            DR2.Close()
            con.Close() '
        End Try

    End Sub

    Sub getthemark()
        ' This method will load the candidate Name from the Master File
        Try

            Dim cmd As New OleDbCommand
            Dim center As String
            Dim index As String
            gcon.Open()
            center = cmbCenter.SelectedText
            index = cmbIndex.Text


            cmd.CommandText = "select * from TassMarks where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & cmbCenter.Text & "%') and IndexNo like ('" & cmbIndex.Text & "%')and SubjCode like ('" & subj & "%')"

            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtYr1.Text = dr("Mark")
                If txtYr1.Text = "  A" Then
                    CheckBox1.CheckState = CheckState.Checked
                    txtYr1.Text = ""
                End If
            Else
                MsgBox("No Mark entered for selected Candidate")
                Exit Sub
            End If

        Catch ex As Exception


            dr.Close()  '
        End Try
        gcon.Close()

    End Sub
    Sub themark()
        ' This method will load the candidate Name from the Master File
        Try

            Dim cmd As New OleDbCommand
            Dim center As String
            Dim index As String
            gcon.Open()
            center = cmbCenter.SelectedText
            index = cmbIndex.Text


            cmd.CommandText = "select * from TassMarks where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & cmbCenter.Text & "%') and IndexNo like ('" & cmbIndex.Text & "%')and SubjCode like ('" & CmbSubject.Text & "%')"

            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtYr1.Enabled = True
                txtYr1.Text = dr("Mark")
                candOldMark = txtYr1.Text
                If txtYr1.Text = "  A" Then

                    CheckBox1.CheckState = CheckState.Checked
                    txtYr1.Text = ""
                End If
            Else
                MsgBox("No Mark entered for selected Candidate")
                txtYr1.Enabled = False
                Exit Sub
            End If

        Catch ex As Exception


            dr.Close()  '
        End Try
        gcon.Close()

    End Sub
    Sub returnsubcode()
        Dim cmd As New OleDbCommand

        con.Open()
        cmd.CommandText = "select * from Wapapers where PaperCode Like ('" & CmbSubject.Text & "%')"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        If dr.Read() Then
            Label8.Text = dr("PaperName")
            Label9.Text = dr("PaperType")
        End If

        dr.Close()
        con.Close()


    End Sub


    Sub clearcenters()
        cmbCenter.Items.Clear()

    End Sub
    Sub clearindex()
        cmbIndex.Items.Clear()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmbIndex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIndex.SelectedIndexChanged

        getname()
        themark()
        txtYr1.Focus()
        oo = 1

    End Sub

    'Leave events to make sure the right data formats have been captured
    Private Sub txtYr1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYr1.Leave
        tlength = txtYr1.Text.Length
        If tlength = 0 Then
            Exit Sub
        End If
        If tlength <> 3 Then

            setMarks(txtYr1)
        End If

        Yr1 = CInt(txtYr1.Text)

        If Yr1 > 0 And Yr1 < 101 Then
            'txtYr2.Focus()
        Else ' mark is out of range
            ' MessageBox.Show("Cass Mark must be between " & Min_Mark & " and " & Max_Mark & ".", "CassMark Entry Validation", MessageBoxButtons.OK)
            MessageBox.Show("Invalid Mark entered")
            txtYr1.Clear()
            txtYr1.Focus()
            '   txtYear2Mark.Focus()

        End If


    End Sub

    Private Sub frmentry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        'Cursor goes to the next control when you press Enter Key
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
        '**********
    End Sub
    'Events to restrict user to enter valid Numbers only ->  0 - 9
    Private Sub txtYr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYr1.KeyPress


        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
            'checkrange()
        Else
            e.Handled = True

        End If

    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Try


            getMaxMark()
            'Check if mark is absent
            If CheckBox1.CheckState = CheckState.Checked Then
                txtYr1.Text = "  A"

                If mm <> 1 Then
                    MsgBox("You must select a Center")
                    cmbCenter.Focus()
                    Exit Sub

                End If
                If nn <> 1 Then
                    MsgBox("You must select a Subject")
                    CmbSubject.Focus()
                    Exit Sub

                End If
                If oo <> 1 Then
                    MsgBox("You must select an index number")
                    cmbIndex.Focus()
                    Exit Sub

                End If
                If pp <> 1 Then
                    MsgBox("You must select paper code")
                    GroupBox4.Focus()
                    Exit Sub

                End If
                If cmbIndex.Items.Count < 1 Then
                    MsgBox("index number missing")
                    cmbCenter.Focus()
                End If
                ExamYear = CStr(Now.Year)
                CreateDate = Now.Date
                candmark = txtYr1.Text
                editmark()
                UpdateAuditRecord()
                UpdateExpandedRecord()
                log += 1
                Lmessage.Visible = True
                cmdSave.Enabled = True

                Lmesg.Visible = True
            Else
                'if candidate has mark
                If CInt(txtYr1.Text) <= Mamxmark = True Then

                    If mm <> 1 Then
                        MsgBox("You must select a Center")
                        cmbCenter.Focus()
                        Exit Sub

                    End If
                    If nn <> 1 Then
                        MsgBox("You must select a Subject")
                        CmbSubject.Focus()
                        Exit Sub

                    End If
                    If oo <> 1 Then
                        MsgBox("You must select an index number")
                        cmbIndex.Focus()
                        Exit Sub

                    End If
                    If pp <> 1 Then
                        MsgBox("You must select paper code")
                        GroupBox4.Focus()
                        Exit Sub

                    End If
                    If cmbIndex.Items.Count < 1 Then
                        MsgBox("index number missing")
                        cmbCenter.Focus()
                        Exit Sub
                    End If

                End If
                ExamYear = CStr(Now.Year)
                CreateDate = Now.Date
                candmark = txtYr1.Text
                editmark()
                UpdateAuditRecord()
                UpdateExpandedRecord()
                log += 1
                Lmessage.Visible = True
                cmdSave.Enabled = True

                Lmesg.Visible = True
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            CmbSubject.Items.Clear()
            cmbIndex.Items.Clear()
            txtCandName.Text = ""
            txtYr1.Text = ""
            cmbCenter.Focus()
           
        End Try


    End Sub
    Sub AddRecord()

        gcon.Open()
        Using cmd As New OleDb.OleDbCommand("Insert Into TassMarks (ExamYear, CentNo, IndexNo,SubjCode, Mark,ExaminerNo,ModiDate) Values  (@ExamYear, @centno, @IndexNo,@SubjCode, @Mark,@ExaminerNo,@ModiDate)", gcon)
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ExamYear", OleDbType.VarChar)).Value = ExamYear
            cmd.Parameters.Add(New OleDb.OleDbParameter("@centno", OleDbType.VarChar)).Value = cmbCenter.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@IndexNo", OleDbType.VarChar)).Value = cmbIndex.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@SubjCode", OleDbType.VarChar)).Value = CmbSubject.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Mark", OleDbType.VarChar)).Value = txtYr1.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ExaminerNo", OleDbType.VarChar)).Value = curuser
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ModiDate", OleDbType.Date)).Value = CreateDate
            cmd.ExecuteNonQuery()
        End Using
        UpdateRecord()
        Lmessage.Text = "Mark Added"
        MsgBox("RECORD ADDED")
        gcon.Close()
    End Sub
    Sub UpdateRecord()

        con.Open()
        Dim com As New OleDbCommand
        com.Connection = con

        com.CommandText = "UPDATE ExpandedEntry SET Flag='" + txtYr1.Text + "'" _
              & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + cmbCenter.Text + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + Label8.Text + "'))"

        com.ExecuteNonQuery()
        con.Close()

    End Sub
    Sub AuditRecord()

        gcons.Open()
        Using cmd As New OleDb.OleDbCommand("Insert Into AuditTrail (ExamYear, CentNo, IndexNo,SubjCode, Mark,ExaminerNo,ModiDate) Values  (@ExamYear, @centno, @IndexNo,@SubjCode, @Mark,@ExaminerNo,@ModiDate)", gcons)
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ExamYear", OleDbType.VarChar)).Value = ExamYear
            cmd.Parameters.Add(New OleDb.OleDbParameter("@centno", OleDbType.VarChar)).Value = cmbCenter.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@IndexNo", OleDbType.VarChar)).Value = cmbIndex.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@SubjCode", OleDbType.VarChar)).Value = CmbSubject.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Mark", OleDbType.VarChar)).Value = txtYr1.Text
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ExaminerNo", OleDbType.VarChar)).Value = curuser
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ModiDate", OleDbType.Date)).Value = CreateDate
            cmd.ExecuteNonQuery()
        End Using
        gcons.Close()
    End Sub
    Sub EditRecord()
        Try
            If txtYr1.Text = "" Then
                MsgBox("Missing Mark")
                txtYr1.Focus()
            Else
                If cmbCenter.Items.Count < 1 Then
                    MsgBox("Center number missing")
                    cmbCenter.Focus()

                Else
                    If cmbIndex.Items.Count < 1 Then
                        MsgBox("index number missing")
                        cmbCenter.Focus()

                    Else
                        If CmbSubject.SelectedIndex = -1 Then
                            MsgBox("Subject not selected")
                            cmbCenter.Focus()
                        Else

                            con.Open()
                            Dim com As New OleDbCommand
                            com.Connection = con

                            com.CommandText = "UPDATE TassMarks SET Mark='" + txtYr1.Text + "',ExaminerNo='" + curuser + "',ModiDate='" + ModiDate + "'" _
                                  & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + cmbCenter.Text + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + Label8.Text + "'))"

                            com.ExecuteNonQuery()
                            Lmessage.Text = "Record Updated"
                            log += 1
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

            MsgBox("Cannot Update at this time")

        Finally

        End Try
        ' dr.Close()
        con.Close()
    End Sub
    Sub getMark()
        ExamYear = txtExamYear.Text

        Try
            Dim cmd As New OleDbCommand
            Dim center As String
            Dim index As String
            gcon.Open()
            center = cmbCenter.SelectedText
            index = cmbIndex.Text
            cmd.CommandText = "select * from TassMarks where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & cmbCenter.Text & "%') and IndexNo like ('" & cmbIndex.Text & "%') and SubjCode like ('" & Label8.Text & "%')"
            cmd.Connection = gcon
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtYr1.Text = dr("Mark")
            Else
                MsgBox("Candidate has no mark for selected subject")
                Exit Sub
            End If

        Catch ex As Exception
            dr.Close()  '
        End Try
        gcon.Close()
    End Sub
    Sub getMaxMark()
        ExamYear = txtExamYear.Text

        Try
            Dim cmd As New OleDbCommand
            Dim center As String
            Dim index As String
            gcon.Open()
            center = cmbCenter.SelectedText
            index = cmbIndex.Text
            cmd.CommandText = "select * from WSUBJNDX where PaperCode Like ('" & Label8.Text & "%')"
            cmd.Connection = gcon
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Mamxmark = dr("MaxScore")
            End If

        Catch ex As Exception
            dr.Close()  '
        End Try
        gcon.Close()
    End Sub

    Sub searchcode()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where Description like '" & CmbSubject.Text & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            subj = (dr("Description"))
        End While
        dr.Close()
        con.Close()

    End Sub
    Sub psearchcodes()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where Description like '" & CmbSubject.Text & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            subj = (dr("SubjCode"))
        End While
        dr.Close()
        con.Close()

    End Sub

    Private Sub cmbCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCenter.SelectedIndexChanged
        'getcent()
        popsubject()
        mm = 1
    End Sub

    ' Checks for the number of marks enter for a center
    Sub CheckCompletemarks()
        Dim cmd As New OleDbCommand
        con.Open()
        cmd.CommandText = "select Count(*) from CassMarks where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & cmbCenter.Text & "%')"
        cmd.Connection = con
        num = cmd.ExecuteScalar
        con.Close()
    End Sub
    'Check for expected number of subjects for Candidate
    Sub CheckExpectedSubjects()
        Try
            If CmbSubject.Items.Count > 0 Then
                CmbSubject.Items.Clear()
                'ListBox1.Items.Clear()

            End If

            Dim cmd As New OleDbCommand
            Dim center As String
            Dim index As String
            ' Dim incomplete As Integer
            gcon.Open()
            center = cmbCenter.SelectedText
            index = cmbIndex.Text
            cmd.CommandText = "select * from Cand_subjects where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & cmbCenter.Text & "%') and IndexNo LIKE ('" & cmbIndex.Text & "%')"
            cmd.Connection = gcon
            dr = cmd.ExecuteScalar

            indrange1 = CInt(dr("tot_subj"))


        Catch ex As Exception
            dr.Close()  '
        End Try
        gcon.Close()
    End Sub
    ' Checks for completed number of subjects for a candidate
    Sub CheckCompletedSubjects()
        Dim cmd As New OleDbCommand
        con.Open()
        cmd.CommandText = "select Count(*) from CassMarks where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & cmbCenter.Text & "%') and IndexNo LIKE ('" & cmbIndex.Text & "%')"
        cmd.Connection = con
        num = cmd.ExecuteScalar
        con.Close()
    End Sub


    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click

        CmbSubject.Items.Clear()
        cmbIndex.Items.Clear()
        txtCandName.Text = ""
        txtYr1.Text = ""
        cmbCenter.Focus()

    End Sub

    Sub setMarks(ByVal txtMark As TextBox)

        Select Case tlength
            Case 1
                txtMark.Text = "00" & Val(txtMark.Text.Trim)
            Case 2
                txtMark.Text = "0" & Val(txtMark.Text.Trim)
        End Select
    End Sub
    Sub nextindex()


        'Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim num As Integer
        num = cmbIndex.SelectedItem
        cmbIndex.Text = Val(cmbIndex.Text + 1)

        con.Open()
        psearchcodes()

        ' cmd.CommandText = "select Count(*) from CassMarks where CentNo like '" & searchcandidate & "%'"
        cmd.CommandText = "select * from Transact where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & cmbCenter.Text & "%') and IndexNo like ('" & cmbIndex.Text & "%')and Subject like ('" & subj & "%')"

        cmd.Connection = con

        dr = cmd.ExecuteReader
        'While 
        If (dr.Read()) Then
            'cmbSubject.Items.Add(dr("IndexNo")
            num += 1
            cmbIndex.SelectedItem = num
            getname()


        End If

        dr.Close()
        con.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        '  Dim showreport As MyReports
        Dim viewmarks As New ViewMarks
        viewmarks.Show()
        'Dim frm1 As New CasMyGrid
        'frm1.Show()

    End Sub

    Sub getcenters()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        cmd.CommandText = "select CentNo from wacenters where ExamYear Like '" & ExamYear & "%' CentNo Like '" & cmbCenter.Text & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            centre = Mid(Trim(dr("CentNo")), 1, 3)
            cmbCenter.Items.Add(dr("CentNo"))
        End While

        dr.Close()
        con.Close()
    End Sub

    'This method populates the subject combobox
    Sub popsubject()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()
        Dim subb As String
        subb = Mid(curuser, 1, 3)
        If curuser = "SAWANEH" Then
            cmd.CommandText = "select Distinct(SubjCode) from ExpandedEntry"
        Else
            cmd.CommandText = "select Distinct(SubjCode) from ExpandedEntry where SubjCode Like ('" & subb & "%')"
        End If

        'cmd.CommandText = "select * from Wasubjects where SubjCode Like ('" & subb & "%')"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        If CmbSubject.Items.Count > 0 Then
            CmbSubject.Items.Clear()

        End If
        While (dr.Read())
            CmbSubject.Items.Add(dr("SubjCode"))
        End While

        dr.Close()
        con.Close()


    End Sub
    Sub getindexes()
        Dim subja As String
        Dim ccount As Integer
        Dim dr2 As OleDbDataReader
        Dim cmd2 As New OleDbCommand
        Dim center As String
        Dim flag As String

        Dim i As Integer
        subja = CmbSubject.SelectedItem
        center = cmbCenter.SelectedItem
        flag = "-99"
        psearchcodes()
        gcon.Open()
        If CmbSubject.Text = "" Then
            CmbSubject.Focus()
        Else

            cmd2.CommandText = "select distinct(IndexNo) from ExpandedEntry where  CentNo Like ('" & cmbCenter.Text & "%') and SubjCode Like ('" & subject & "%')and Flag not Like ('" & flag & "%')"
            cmd2.Connection = gcon

            dr2 = cmd2.ExecuteReader

            ccount = dr2.RecordsAffected
            If dr2.HasRows Then
                If cmbIndex.Items.Count > 0 Then
                    cmbIndex.Items.Clear()
                End If
            End If

            'The var i is used to check whether subject has candidates registered
            While (dr2.Read())
                i = 1
                cmbIndex.Items.Add(dr2("IndexNo"))
            End While

            dr2.Close()

        End If
        If i <> 1 Then
            MsgBox("No Candidate registered for " + CmbSubject.Text)
   
        End If
        gcon.Close()

    End Sub
    Sub getpapers()
        Dim subja As String
        Dim ccount As Integer
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim center As String
        Dim flag As String

        Dim i As Integer

        gcon.Open()
        'subja = CmbSubject.SelectedText
        subja = CmbSubject.SelectedItem
        center = cmbCenter.SelectedItem
        flag = "i"
        psearchcodes()
        If CmbSubject.Text = "" Then
            CmbSubject.Focus()
        Else

            cmd.CommandText = "select * from wsubjndx where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & cmbCenter.Text & "%') and Subject like ('" & subj & "%')and flag like ('" & flag & "%')"
            cmd.Connection = gcon

            dr = cmd.ExecuteReader

            ccount = dr.RecordsAffected
            If dr.HasRows Then
                If cmbIndex.Items.Count > 0 Then
                    cmbIndex.Items.Clear()

                End If
            End If

            'The var i is used to check whether subject has candidates registered
            While (dr.Read())
                i = 1
                cmbIndex.Items.Add(dr("IndexNo"))
            End While

            dr.Close()

        End If
        If i <> 1 Then
            MsgBox("No Candidate registered for " + CmbSubject.Text)
        End If
        gcon.Close()

    End Sub


    Private Sub CmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSubject.SelectedIndexChanged
        ExamYear = txtExamYear.Text
        returnsubcode()
        getindexes()
        'getthepapers()
        CountAllocated()
        Countmarksoustanding()
        nn = 1
    End Sub
    Private Sub txtYr1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYr1.TextChanged
        CheckBox1.Enabled = False
        If txtYr1.Text.Length = 3 Then
            'txtYr2.Focus()
        End If

    End Sub

    Sub getcent()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        Dim subjofficer As String
        subjofficer = Mid(curuser, 1, 3)

        con.Open()

        Dim i As Integer = 0

        'cmd.CommandText = "select Distinct(CentNo) from ExpandedEntry where ExaminerNo like ('" & subjofficer & "%') order by Centno"
        cmd.CommandText = "select Distinct(CentNo) from ExpandedEntry"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        cmbCenter.Items.Clear()


        While (dr.Read())
            cmbCenter.Items.Add(dr("CentNo"))
            i = 1
        End While
        If i = 0 Then
            MsgBox("First Allocate Papers and Enter Marks in order to modify")

        End If
        dr.Close()
        con.Close()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            txtYr1.Text = ""
            txtYr1.Enabled = False
        Else
            txtYr1.Enabled = True
            txtYr1.Focus()

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtYr1.Clear()
        txtYr1.Enabled = True
        CheckBox1.Enabled = True


    End Sub


    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pp = 1
    End Sub


    Private Sub cmdChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChanges.Click
        EditRecord()

    End Sub

    'cREATE EXPANDED FILE
    Sub Add_to_transact()
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        ' getcenters()
        ExamYear = Now.Year
        cmd.CommandText = "select * from Cand_Subjects "

        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."

        Dim i As Integer
        While dr.Read()
            i += 1
            indrange1 = dr("tot_subj")

            If indrange1 = "8" Then

                For i = 1 To 8
                    SubjCode = ""

                    If i = 1 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub1"))
                        CreatePapersForSubjects()
                    End If
                    If i = 2 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub2"))
                        CreatePapersForSubjects()
                    End If
                    If i = 3 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub3"))
                        CreatePapersForSubjects()
                    End If
                    If i = 4 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub4"))
                        CreatePapersForSubjects()
                    End If
                    If i = 5 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub5"))
                        CreatePapersForSubjects()
                    End If
                    If i = 6 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub6"))
                        CreatePapersForSubjects()
                    End If
                    If i = 7 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub7"))
                        CreatePapersForSubjects()
                    End If
                    If i = 8 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub8"))
                        CreatePapersForSubjects()
                    End If


                Next

            End If
            If indrange1 = "9" Then
                For i = 1 To 9
                    SubjCode = ""


                    If i = 1 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub1"))
                        CreatePapersForSubjects()
                    End If
                    If i = 2 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub2"))
                        CreatePapersForSubjects()
                    End If
                    If i = 3 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub3"))
                        CreatePapersForSubjects()
                    End If
                    If i = 4 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub4"))
                        CreatePapersForSubjects()
                    End If
                    If i = 5 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub5"))
                        CreatePapersForSubjects()
                    End If
                    If i = 6 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub6"))
                        CreatePapersForSubjects()
                    End If
                    If i = 7 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub7"))
                        CreatePapersForSubjects()
                    End If
                    If i = 8 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub8"))
                        CreatePapersForSubjects()
                    End If


                    If i = 9 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        SubjCode = (dr("Sub9"))
                        CreatePapersForSubjects()
                    End If

                Next

            End If


        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub CreatePapersForSubjects()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from Wapapers where PaperCode like '" & SubjCode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            PaperCode = (dr("PaperCode"))
            PaperType = (dr("PaperType"))
            Dim eng As String
            Dim eng2 As String
            eng2 = "302"
            eng = Mid(PaperCode, 1, 3)
            If ((PaperType <> "OBJECTIVE") And (PaperCode <> "302343")) Then
                mQuery = "Insert into ExpandedEntry(ExamYear,CentNo,IndexNo,SubjCode)" _
                                   & " values" _
                                   & "('" & ExamYear & "','" & centno & "','" & index & "','" & PaperCode & "')"
                mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                mCmd.ExecuteNonQuery()
            End If

        End While

        dr.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Start")
        Add_to_transact()
        MsgBox("Finish")
    End Sub
    Sub UpdateBiodetails()
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        ' getcenters()
        ExamYear = Now.Year
        cmd.CommandText = "select * from sawa "

        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."

        Dim i As Integer
        While dr.Read()
            i += 1
            Dim CandName As String
            Dim Sex, DD, MM, YR As String

            ExamYear = Now.Year
            centno = dr("CentNo")
            index = dr("IndexNo")
            CandName = dr("CandName")
            Sex = dr("Sex")
            DD = dr("DD")
            MM = dr("MM")
            YR = dr("YR")

            mQuery = "Insert into details(ExamYear,CentNo,IndexNo,CandName,Sex,DD,MM,YR)" _
                                   & " values" _
                                   & "('" & ExamYear & "','" & centno & "','" & index & "','" & CandName & "','" & Sex & "','" & DD & "','" & MM & "','" & YR & "')"
            mCmd = New OleDb.OleDbCommand(mQuery, gcon)
            mCmd.ExecuteNonQuery()
        End While

        dr.Close()
        gcon.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Start")
        UpdateBiodetails()
        MsgBox("Finish")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Start Creation")
        Add_to_transact()
        MsgBox("Finish")

    End Sub
    Sub CountAllocated()
        gcon.Open()
        ' Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand

        cmd.CommandText = "select count (*) from ExpandedEntry where ExaminerNo=('" & curuser & "') and SubjCode='" & CmbSubject.Text & "' "
        cmd.Connection = gcon
        TextBox1.Text = cmd.ExecuteScalar
        gcon.Close()
    End Sub
    Sub Countmarksoustanding()
        gcon.Open()
        Dim Flag As String = "-99"

        ' Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand

        cmd.CommandText = "select count (*) from ExpandedEntry where ExaminerNo=('" & curuser & "') and SubjCode='" & CmbSubject.Text & "' and Flag='" & Flag & "' "
        cmd.Connection = gcon
        TextBox2.Text = cmd.ExecuteScalar
        gcon.Close()
    End Sub
    Sub UpdateExpandedRecord()

        con.Open()
        Dim com As New OleDbCommand
        com.Connection = con

        com.CommandText = "UPDATE ExpandedEntry SET Flag='" + txtYr1.Text + "'" _
              & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + cmbCenter.Text + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + CmbSubject.Text + "') and ExaminerNo=('" & curuser & "'))"
        com.ExecuteNonQuery()
        con.Close()

    End Sub
    Sub editmark()
        con.Open()
        Dim com As New OleDbCommand
        com.Connection = con

        com.CommandText = "UPDATE TassMarks SET Mark='" + candmark + "',Oldmark='" + candOldMark + "',ExaminerNo='" + curuser + "',ModiDate='" + ModiDate + "'" _
              & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + cmbCenter.Text + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + CmbSubject.Text + "'))"

        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Updated")

    End Sub
    Sub UpdateAuditRecord()
        con.Open()
        Dim com As New OleDbCommand
        com.Connection = con
        ModiDate = Now.Date
        com.CommandText = "UPDATE AuditTrail SET NewMark='" + candmark + "',ExaminerNo='" + curuser + "',ModiDate='" + ModiDate + "'" _
              & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + cmbCenter.Text + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + CmbSubject.Text + "'))"

        com.ExecuteNonQuery()
        con.Close()


    End Sub
End Class
