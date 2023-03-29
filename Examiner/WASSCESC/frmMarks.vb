Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.Threading.Tasks

Public Class frmMarks
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

    Dim db As New dbConnection3(MDIParent1.connectionString)
    Dim ds As New DataSet()

    Dim count As Integer
    Dim currentCentNo
    Dim currentSubject

    Dim threadSaveMarksToServer As Thread

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

        If cmbCenter.Items.Count = 1 Then
            cmbCenter.SelectedIndex = 0
        End If

        If (getMaxMark()) Then
            lblMaximumMark.Text = Strings.Right("000" + Mamxmark.ToString(), 3)
        End If

        Countmarksoustanding()

        'btnSaveToServer.PerformClick()

        threadSaveMarksToServer = New Thread(New ThreadStart(AddressOf SaveMarksToServer))
    End Sub

    Function UpdateExaminerAllocationDetails(examinerNumber As String) As Boolean
        'connect to db, retrieve allocation and outstanding for examiner

        Return True
    End Function

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


            cmd1.CommandText = "select * from details where CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo like ('" & cmbIndex.Text & "%')"

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


            cmd.CommandText = "select * from TassMarks where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo like ('" & cmbIndex.Text & "%')and SubjCode like ('" & subj & "%')"

            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtMark.Text = dr("Mark")
                If txtMark.Text = "  A" Then
                    chkbAbsent.CheckState = CheckState.Checked
                    txtMark.Text = ""
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


            cmd.CommandText = "select * from TassMarks where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo like ('" & cmbIndex.Text & "%')and SubjCode like ('" & subj & "%')"

            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtMark.Enabled = True
                txtMark.Text = dr("Mark")
                If txtMark.Text = "  A" Then
                    chkbAbsent.CheckState = CheckState.Checked
                    txtMark.Text = ""
                End If
            Else
                MsgBox("No Mark entered for selected Candidate")
                txtMark.Enabled = False
                Exit Sub
            End If

        Catch ex As Exception


            dr.Close()  '
        End Try
        gcon.Close()

    End Sub

    Sub returnsubcode()

        Try
            db.con.Open()

            db.cmd.CommandText = "select PaperName, PaperType from Wapapers where PaperCode ='" & Strings.Left(CmbSubject.Text, 6) & "'"

            db.dr = db.cmd.ExecuteReader()

            While db.dr.Read()
                lblPaperName.Text = db.dr("PaperName")
                lblPaperType.Text = db.dr("PaperType")
            End While

        Catch ex As Exception
            Console.WriteLine("Error in returnsubCode(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

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
        txtMark.Focus()
        oo = 1

    End Sub

    'Leave events to make sure the right data formats have been captured
    Private Sub txtYr1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMark.Leave
        tlength = txtMark.Text.Length

        If tlength = 0 Then
            Exit Sub
        End If

        If tlength <> 3 Then
            setMarks(txtMark)
        End If

        Try
            Yr1 = CInt(txtMark.Text)
        Catch ex As Exception

        End Try

        If Yr1 > 0 And Yr1 < 101 Then
        End If
        'txtYr2.Focus()
        'sosseh
        '' Else
        If Yr1 < 0 And Yr1 > 101 Then
            ' mark is out of range
            ' MessageBox.Show("Cass Mark must be between " & Min_Mark & " and " & Max_Mark & ".", "CassMark Entry Validation", MessageBoxButtons.OK)
            MessageBox.Show("Invalid Mark entered")
            txtMark.Clear()
            txtMark.Focus()
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
    Private Sub txtYr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMark.KeyPress
        'MessageBox.Show(e.KeyChar)

        If Chr(AscW(e.KeyChar)).ToString.ToUpper() = "A" Then
            chkbAbsent.Checked = True
            Exit Sub
        End If

        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
            'checkrange()
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        count += 1
        rtbDisplay.AppendText(vbNewLine + Strings.Left("" + count.ToString() + " : " + cmbCenter.SelectedItem().ToString(), 11) + cmbIndex.SelectedItem + " - " + txtMark.Text + " ... ")

        Try
            'Check if mark is absent
            If chkbAbsent.CheckState = CheckState.Checked Then
                txtMark.Text = "  A"
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
                'sosseh modified
                'If pp <> 1 Then'
                '    MsgBox("You must select paper code")
                '    GroupBox4.Focus()
                '    Exit Sub

                'End If
                If cmbIndex.Items.Count < 1 Then
                    MsgBox("index number missing")
                    cmbCenter.Focus()
                End If
                ExamYear = CStr(Now.Year)
                CreateDate = Now.Date

                AddRecord()
                AuditRecord()
                UpdateExpandedRecord()
                log += 1
                Lmessage.Visible = True
                cmdSave.Enabled = True
                rtbDisplay.AppendText("success")
                'Lmesg.Visible = True
            Else
                'if canidate has mark
                If (CInt(txtMark.Text) <= Mamxmark) Then
                    If mm <> 1 Then
                        MsgBox("You must select a Center")
                        cmbCenter.Focus()
                        Exit Sub

                    ElseIf nn <> 1 Then
                        MsgBox("You must select a Subject")
                        CmbSubject.Focus()
                        Exit Sub

                    ElseIf oo <> 1 Then
                        MsgBox("You must select an index number")
                        cmbIndex.Focus()
                        Exit Sub

                    ElseIf cmbIndex.Items.Count < 1 Then
                        MsgBox("index number missing")
                        cmbCenter.Focus()
                        Exit Sub
                    End If

                Else
                    ' more than maximum mark
                    rtbDisplay.AppendText("mark entered greater than maximum mark (" + lblMaximumMark.Text + ")")
                    MessageBox.Show("The mark you have entered is more than the MAXIMUM MARK. Please check.", "Check Mark", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub
                End If
                ExamYear = CStr(Now.Year)
                CreateDate = Now.Date

                AddRecord()
                AuditRecord()
                UpdateExpandedRecord()
                log += 1
                Lmessage.Visible = True
                cmdSave.Enabled = False
                rtbDisplay.AppendText("success")
                'Lmesg.Visible = True
            End If
        Catch ex As Exception
            con.Close()
            rtbDisplay.AppendText("failed")
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            Countmarksoustanding()
            cmbCenter.Focus()
            con.Close()
            txtCandName.Text = ""
            txtCandName.Text = ""
            txtMark.Text = ""
            chkbAbsent.Enabled = True
            If chkbAbsent.Checked Then
                chkbAbsent.Checked = False
            End If

            ReloadCandidate()

        End Try
        rtbDisplay.ScrollToCaret()

    End Sub

    Private Sub ReloadCandidate()
        cmbIndex.Items.Clear()
        getindexes()
        cmbIndex.Focus()
        ' cmbIndex.SelectedIndex = 0
        getname()
        Countmarksoustanding()
        txtMark.Focus()
    End Sub

    'make a function
    Sub AddRecord()
        Try
            db.con.Open()

            db.cmd.CommandText = "Insert Into TassMarks (ExamYear, CentNo, IndexNo,SubjCode, Mark,ExaminerNo,ModiDate, PcName, TadExaminerNo) Values  (" &
                "'" & ExamYear & "', '" & Strings.Left(cmbCenter.Text, 7) & "', '" & cmbIndex.Text &
                "','" & Strings.Left(CmbSubject.Text, 6) & "', '" & txtMark.Text & "', '" & curuser & "', '" & CreateDate & "', '', '')"

            Dim result As Integer
            result = db.cmd.ExecuteNonQuery()

            If result Then
                UpdateRecord()
                Lmessage.Text = "Mark Added"
                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            Console.WriteLine("Error in returnsubCode(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub

    Sub UpdateRecord()
        Try
            db.con1.Open()

            'con.Open()
            'Dim com As New OleDbCommand
            'com.Connection = con

            db.cmd1.CommandText = "UPDATE ExpandedEntry SET Flag='" + txtMark.Text + "'" _
                  & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + Strings.Left(cmbCenter.Text, 7) + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + lblPaperName.Text + "'))"

            Dim result As Integer
            result = db.cmd1.ExecuteNonQuery()
            'con.Close()
        Catch ex As Exception
            Console.WriteLine("Error in UpdateRecord(): " & ex.Message)
        Finally
            db.con1.Close()
        End Try

    End Sub

    Sub AuditRecord()
        '" &  & "'
        Try
            db.con.Open()

            'gcons.Open()
            Using cmd As New OleDb.OleDbCommand("Insert Into AuditTrail (ExamYear, CentNo, IndexNo,SubjCode, Mark,ExaminerNo,CreateDate) Values  (@ExamYear, @centno, @IndexNo,@SubjCode, @Mark,@ExaminerNo,@CreateDate)", db.con)
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ExamYear", OleDbType.VarChar)).Value = ExamYear
                cmd.Parameters.Add(New OleDb.OleDbParameter("@centno", OleDbType.VarChar)).Value = Strings.Left(cmbCenter.Text, 7)
                cmd.Parameters.Add(New OleDb.OleDbParameter("@IndexNo", OleDbType.VarChar)).Value = cmbIndex.Text
                cmd.Parameters.Add(New OleDb.OleDbParameter("@SubjCode", OleDbType.VarChar)).Value = Strings.Left(CmbSubject.Text, 6)
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Mark", OleDbType.VarChar)).Value = txtMark.Text
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ExaminerNo", OleDbType.VarChar)).Value = curuser
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CreateDate", OleDbType.Date)).Value = CreateDate
                Dim result As Integer = cmd.ExecuteNonQuery()
            End Using
            'gcons.Close()

        Catch ex As Exception
            Console.WriteLine("Error in AuditRecord(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub

    Sub EditRecord()
        Try
            If txtMark.Text = "" Then
                MessageBox.Show("Please enter a mark", "Enter Mark", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMark.Focus()
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

                            Try
                                con.Open()
                                Dim com As New OleDbCommand
                                com.Connection = con

                                com.CommandText = "UPDATE TassMarks SET Mark='" + txtMark.Text + "',ExaminerNo='" + curuser + "',ModiDate='" + ModiDate + "'" _
                                      & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + Strings.Left(cmbCenter.Text, 7) + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + lblPaperName.Text + "'))"

                                com.ExecuteNonQuery()
                                Lmessage.Text = "Record Updated"
                                log += 1
                            Catch ex As Exception
                                Console.WriteLine("Error in EdidRecord:" & ex.Message)
                            Finally
                                con.Close()
                            End Try

                        End If
                    End If
                End If
            End If
        Catch ex As Exception

            MsgBox("Cannot Update at this time")

        Finally
        End Try
        ' dr.Close()

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
            cmd.CommandText = "select * from TassMarks where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo like ('" & cmbIndex.Text & "%') and SubjCode like ('" & lblPaperName.Text & "%')"
            cmd.Connection = gcon
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txtMark.Text = dr("Mark")
            Else
                MsgBox("Candidate has no mark for selected subject")
                Exit Sub
            End If

        Catch ex As Exception
            dr.Close()  '
        End Try
        gcon.Close()
    End Sub

    Function getMaxMark() As Boolean
        ExamYear = txtExamYear.Text

        Try
            Dim cmd As New OleDbCommand
            Dim center As String
            Dim index As String
            gcon.Open()
            center = Strings.Left(cmbCenter.SelectedItem.ToString(), 7)
            index = cmbIndex.Text
            cmd.CommandText = "select * from WSUBJNDX where PaperCode = " & Strings.Left(CmbSubject.SelectedItem.ToString(), 6) & ";"
            cmd.Connection = gcon
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Mamxmark = dr("MaxScore")
            End If
            lblMaximumMark.Text = Strings.Right("000" + Mamxmark.ToString(), 3)
            Return True
        Catch ex As Exception
            'dr.Close()
            Console.WriteLine("Error getting maximum mark: " + ex.Message)
        Finally
            gcon.Close()
        End Try
        Return False
    End Function

    Sub searchcode()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where Description like '" & Strings.Left(CmbSubject.Text, 6) & "%'"
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

        cmd.CommandText = "select * from Wasubjects where Description like '" & Strings.Left(CmbSubject.Text, 6) & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            subj = (dr("SubjCode"))
        End While
        dr.Close()
        con.Close()

    End Sub

    Private Sub cmbCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCenter.SelectedIndexChanged
        Try
            currentCentNo = cmbCenter.SelectedItem.ToString().Substring(0, 7)
        Catch ex As Exception

        End Try


        getMaxMark()
        popsubject()
        Countmarksoustanding()

        mm = 1
        If CmbSubject.Items.Count = 1 Then
            CmbSubject.SelectedIndex = 0
        End If
        rtbDisplay.AppendText(vbNewLine + "------------------------------")
        rtbDisplay.AppendText(vbNewLine + vbNewLine + cmbCenter.SelectedItem().ToString() + vbNewLine)

    End Sub

    ' Checks for the number of marks enter for a center
    Sub CheckCompletemarks()
        Dim cmd As New OleDbCommand
        con.Open()
        cmd.CommandText = "select Count(*) from CassMarks where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%')"
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
            cmd.CommandText = "select * from Cand_subjects where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo LIKE ('" & cmbIndex.Text & "%')"
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
        cmd.CommandText = "select Count(*) from CassMarks where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo LIKE ('" & cmbIndex.Text & "%')"
        cmd.Connection = con
        num = cmd.ExecuteScalar
        con.Close()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        CmbSubject.Items.Clear()
        cmbIndex.Items.Clear()
        txtCandName.Text = ""
        txtMark.Text = ""
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
        cmd.CommandText = "select * from Transact where ExamYear Like ('" & ExamYear & "%') and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and IndexNo like ('" & cmbIndex.Text & "%')and Subject like ('" & subj & "%')"

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

    Private Sub viewcomplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New Casfrmquery
        'frm.Show()
    End Sub

    Sub getcenters()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        cmd.CommandText = "select CentNo from wacenters where ExamYear Like '" & ExamYear & "%' CentNo Like '" & Strings.Left(cmbCenter.Text, 7) & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            centre = Mid(Trim(dr("CentNo")), 1, 3)
            cmbCenter.Items.Add(dr("CentNo"))
        End While

        dr.Close()
        con.Close()
    End Sub

    Sub changecodes()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            SubjCode = (dr("Description"))
        End While


        dr.Close()
        con.Close()
    End Sub

    Sub CheckConversion()
        Dim cmd As New OleDbCommand
        con.Open()
        cmd.CommandText = "select Count(*) from tbl_center"
        cmd.Connection = con
        num = cmd.ExecuteScalar
        con.Close()
    End Sub

    'This method populates the subject combobox
    Sub popsubject()

        Try
            db.con.Open()

            'Dim dr As OleDb.OleDbDataReader
            'Dim cmd As New OleDb.OleDbCommand
            'con.Open()
            Dim subb As String
            subb = Mid(curuser, 5, 6)

            'If curuser = "SAWANEH" Then
            '    cmd.CommandText = "select * from Wasubjects"
            'Else
            '    cmd.CommandText = "select Distinct(SubjCode) from ExpandedEntry where SubjCode Like ('" & subb & "%')"
            'End If

            'db.cmd.CommandText = "select Distinct(SubjCode) from ExpandedEntry where SubjCode Like ('" & subb & "%')"

            db.cmd.CommandText = "SELECT DISTINCT ExpandedEntry.SubjCode, Wapapers.PaperName, Wapapers.PaperType " &
                "FROM ExpandedEntry INNER JOIN Wapapers ON left(ExpandedEntry.SubjCode, 6) = left(Wapapers.PaperCode, 6) " &
                "where left(ExpandedEntry.SubjCode, 6) = '" & subb & "'"
            'cmd.CommandText = "select * from Wasubjects where SubjCode Like ('" & subb & "%')"
            'cmd.Connection = con

            db.dr = db.cmd.ExecuteReader()
            If CmbSubject.Items.Count > 0 Then
                CmbSubject.Items.Clear()
            End If

            While (db.dr.Read())
                CmbSubject.Items.Add(db.dr("SubjCode") & String.Concat(" - ", db.dr("PaperName"), "(" & db.dr("PaperType") & ")"))
            End While

        Catch ex As Exception
            Console.WriteLine("Error in popsubject(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub getindexes()
        Dim subja As String
        Dim ccount As Integer
        'Dim dr2 As OleDbDataReader
        Dim cmd2 As New OleDbCommand
        Dim center As String
        Dim flag As String

        Dim i As Integer
        subja = Strings.Left(CmbSubject.SelectedItem, 6)
        center = Strings.Left(cmbCenter.SelectedItem, 7)
        flag = "-99"
        psearchcodes()

        'gcon.Open()
        If CmbSubject.Text = "" Then
            CmbSubject.Focus()
        Else

            Try
                db.con.Open()

                'cmd2.Connection = gcon
                db.cmd.CommandText = "select distinct(IndexNo) from ExpandedEntry where  CentNo like('" & Strings.Left(cmbCenter.Text, 7) & "%') and SubjCode like('" & subja & "%')and Flag Like ('" & flag & "%')"


                db.dr = db.cmd.ExecuteReader

                ccount = db.dr.RecordsAffected
                If db.dr.HasRows Then
                    If cmbIndex.Items.Count > 0 Then
                        cmbIndex.Items.Clear()
                    End If
                End If

                'The var i is used to check whether subject has candidates registered
                While (db.dr.Read())
                    i = 1
                    cmbIndex.Items.Add(db.dr("IndexNo"))
                End While

                'dr2.Close()
            Catch ex As Exception
                Console.WriteLine("Error in getindexes(): " & ex.Message)
            Finally
                db.con.Close()
            End Try


        End If

        If i <> 1 Then
            MessageBox.Show("You have finished your allocation for " + CmbSubject.Text & vbNewLine & vbNewLine &
                   "Please select a different centre if you have more other centres to key their marks.",
                   "current centre done", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UseWaitCursor = True
            'save marks
            btnSaveToServer.PerformClick()
            UseWaitCursor = False


            'check if examiner is a chief examiner to linked to the chief examiner reports
            If curuser1.Contains("0000") Then
                Dim CEReport As New FrmCEReports
                CEReport.Show()
            End If
        Else
            cmbIndex.SelectedIndex = 0
        End If
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
        subja = Strings.Left(CmbSubject.SelectedItem, 6)
        center = Strings.Left(cmbCenter.SelectedItem, 7)
        flag = "i"
        psearchcodes()
        If CmbSubject.Text = "" Then
            CmbSubject.Focus()
        Else

            cmd.CommandText = "select * from wsubjndx where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & Strings.Left(cmbCenter.Text, 7) & "%') and Subject like ('" & subj & "%')and flag like ('" & flag & "%')"
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
        getMaxMark()
    End Sub

    Private Sub txtYr1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMark.TextChanged
        'CheckBox1.Enabled = False
        If Strings.Left(txtMark.Text, 1).ToUpper() = "A" Then

        End If

        If txtMark.Text.Length = 3 Then
            'txtYr2.Focus()
            cmdSave.Enabled = True
            cmdSave.Focus()
            chkbAbsent.Enabled = False
        Else
            cmdSave.Enabled = False
            txtMark.BackColor = Color.PaleVioletRed
        End If

        'If txtMark.Text.Length = 3 Then
        '    chkbAbsent.Enabled = False

        'End If

        If txtMark.Text = "" Then
            chkbAbsent.Enabled = True
        End If

    End Sub

    Sub getcent()
        Try
            db.con.Open()

            Dim i As Integer = 0
            'db.cmd.CommandText = "select Distinct(CentNo) from ExpandedEntry where ExaminerNo=('" & curuser & "') order by Centno"

            db.cmd.CommandText = "select Distinct ExpandedEntry.CentNo, Wacenters.Description from ExpandedEntry " &
                "Inner Join Wacenters on (ExpandedEntry.CentNo = Wacenters.CentNo) " &
                "where (ExaminerNo = '" & curuser & "') order by ExpandedEntry.Centno"

            db.dr = db.cmd.ExecuteReader()
            cmbCenter.Items.Clear()

            If Not db.dr.HasRows Then
                MessageBox.Show("No paper Allocated to you, Please Contact your Subject Officer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            While (db.dr.Read())
                cmbCenter.Items.Add(db.dr("CentNo") & " - " & db.dr("Description"))
            End While

        Catch ex As Exception
            Console.WriteLine("Error in getCent(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub ChangeCode()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from Wasubjects where subjcode like '" & SubjCode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub1 = (dr("Description"))
        End While

        dr.Close()
        con.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        getindexes()
        ' Label9.Text = "Subject Description 1"

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbAbsent.CheckedChanged

        'If CheckBox1.Checked = True Then

        '    txtYr1.Text = ""
        '    txtYr1.Enabled = False
        'Else
        '    txtYr1.Enabled = True
        '    txtYr1.Focus()

        'End If

        If chkbAbsent.Checked = True Then
            txtMark.Text = "ABSENT"
            txtMark.Enabled = False
            cmdSave.Enabled = True
            cmdSave.Focus()
        ElseIf chkbAbsent.Checked = False Then
            txtMark.Text = ""
            txtMark.Enabled = True
            cmdSave.Enabled = False
            txtMark.SelectAll()
            txtMark.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'txtYr1.Clear()
        'txtYr1.Enabled = True
        'CheckBox1.Enabled = True


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
        'Dim table As New DataTable()
        'Try
        '    gcon.Open()
        '    ' Dim dr As OleDb.OleDbDataReader
        '    Dim cmd As New OleDb.OleDbCommand

        '    'cmd.CommandText = "select count (*) from ExpandedEntry where ExaminerNo='" & curuser & "' and SubjCode='" & Strings.Left(CmbSubject.Text, 6) & "' "

        '    cmd.CommandText = "SELECT ExpandedEntry.CentNo, Count(ExpandedEntry.IndexNo) AS TotalOutstanding FROM ExpandedEntry WHERE (((ExpandedEntry.[ExaminerNo])=('" & curuser & "')) AND ((ExpandedEntry.[SubjCode])='" & Strings.Left(CmbSubject.Text, 6) & "')) and Flag = '-99' GROUP BY ExpandedEntry.CentNo;"

        '    cmd.Connection = gcon
        '    table.Load(cmd.ExecuteReader())
        '    DataGridViewFeedback.DataSource = table

        'Catch ex As Exception

        'Finally
        '    gcon.Close()
        'End Try



    End Sub

    Private Function DeleteCurrentCandidate() As Boolean
        ' use currentCent No
        Dim subjectCode = Strings.Left(CmbSubject.Text, 6)
        Dim indexNumber = cmbIndex.Text

        If Not MessageBox.Show(Me, "Do you want to log this script as MISSING?", "Missing Script", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Return False
        End If

        'connect to db and remove candidates. use examiner number found in curUser
        Try
            db.con.Open()

            db.cmd.CommandText = "DELETE ExpandedEntry.*, ExpandedEntry.CentNo, ExpandedEntry.IndexNo, ExpandedEntry.ExaminerNo, ExpandedEntry.Flag " &
            "FROM ExpandedEntry " &
            "WHERE (((ExpandedEntry.CentNo)='" & currentCentNo &
                    "') AND ((ExpandedEntry.IndexNo)='" & indexNumber &
                    "') AND ((ExpandedEntry.ExaminerNo)='" & curuser &
                    "') AND ((ExpandedEntry.Flag)='-99'));"
            If db.cmd.ExecuteNonQuery() Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine("Error in countMarksOustanding(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

        Return False
    End Function

    Private Sub ButtonMissingMark_Click(sender As Object, e As EventArgs) Handles ButtonMissingMark.Click
        'REMOVES SELECTED INDEX NUMBER FOR ALLOCATION IF MAKR HAS NOT BEEN ENTERED.

        If DeleteCurrentCandidate() Then
            ReloadCandidate()
            MessageBox.Show("Record Removed")
        End If
    End Sub

    Sub Countmarksoustanding()
        Dim table As New DataTable()
        Dim tableAllocated As New DataTable()

        Try
            db.con.Open()

            'Dim cmd As New OleDb.OleDbCommand

            'cmd.CommandText = "select count (*)Then from ExpandedEntry where ExaminerNo='" & curuser & "' and SubjCode='" & Strings.Left(CmbSubject.Text, 6) & "' "

            db.cmd.CommandText = "SELECT ExpandedEntry.CentNo AS SchoolNo, Count(ExpandedEntry.IndexNo) AS TotalOutstanding " &
                                    "FROM ExpandedEntry WHERE (((ExpandedEntry.[ExaminerNo])=('" &
                                    curuser & "')) AND  Flag = '-99') GROUP BY ExpandedEntry.CentNo;"
            table.Load(db.cmd.ExecuteReader())

            db.cmd.CommandText = "SELECT ExpandedEntry.CentNo AS SchoolNo, Count(ExpandedEntry.IndexNo) AS Allocated " &
                                    "FROM ExpandedEntry WHERE (((ExpandedEntry.[ExaminerNo])=('" &
                                    curuser & "'))) GROUP BY ExpandedEntry.CentNo;"
            tableAllocated.Load(db.cmd.ExecuteReader())

            DataGridViewFeedback.DataSource = table
            DataGridViewAllocated.DataSource = tableAllocated

        Catch ex As Exception
            Console.WriteLine("Error in countMarksOustanding(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub

    Sub UpdateExpandedRecord()
        Try
            db.con.Open()

            db.cmd.CommandText = "UPDATE ExpandedEntry SET Flag='" + txtMark.Text + "'" _
                  & " WHERE ((ExamYear Like ('" & ExamYear & "%'))and (CentNo='" + Strings.Left(cmbCenter.Text, 7) + "') and (IndexNo='" + cmbIndex.Text + "') and (SubjCode='" + Strings.Left(CmbSubject.Text, 6) + "') and ExaminerNo=('" & curuser & "'))"
            Dim result As Integer = db.cmd.ExecuteNonQuery()

            If result Then

            End If

        Catch ex As Exception
            Console.WriteLine("Error in ExpandedEntry(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSaveToServer_Click(sender As Object, e As EventArgs) Handles btnSaveToServer.Click
        Try
            '---- using thread
            If threadSaveMarksToServer.IsAlive Then
                Console.WriteLine($"Saving in progress: {threadSaveMarksToServer.ToString()}")
            Else
                threadSaveMarksToServer.Start()
            End If

            '--- using db async methods
            'btnSaveToServer.Text = "SAVING..."
            'Dim result = SaveMarksToServerAsnyc()

            'If result.IsCompleted Then
            '    btnSaveToServer.Text = "SAVE"
            'End If
        Catch ex As Exception
            btnSaveToServer.Text = "!SAVING..."
        End Try
    End Sub

    'Private Async Function RunSaveAsync() As Task(Of Boolean)
    '    Try
    '        Dim result As Boolean = Await SaveMarksToServerAsnyc()
    '        Return result
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Private Async Function SaveMarksToServerAsnyc() As Task(Of Boolean)
        Dim dbS As New dbConnection3(MDIParent1.connectionStringServer)
        'btnSaveToServer.Text = "Saving"
        Dim tableName As String = "TassMarks"
        Dim sql As String = "SELECT ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, BackedUp From " &
            tableName & " WHERE updated = False;"

        Try
            dbS.con.Open()
            db.con4.Open()

            If (FillDS(tableName, sql)) Then

                'okay got something. Is it empty
                If (ds.Tables(tableName).Rows.Count < 1) Then
                    Console.WriteLine("No rows retruned")
                Else
                    'some records to process
                    For Each dr As DataRow In ds.Tables(tableName).Rows
                        If (dr("updated") = True) Then
                            Console.WriteLine("Record already there")
                            Continue For
                        End If
                        Try
                            dbS.cmd.CommandText = "" &
                            "INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " &
                            "('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" &
                            dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & Environment.MachineName & "');"
                            'db.cmd4.CommandText = "UPDATE TassMarks SET updated = " & True & " WHERE ((ExamYear = '" & dr("ExamYear") & _
                            '    "') AND (CentNo = '" & dr("CentNo") & "') AND (IndexNo = '" & dr("IndexNo") & "') AND (SubjCode = '" & dr("SubjCode") & "'));"

                            'ok, now run updates
                            If (Await dbS.cmd.ExecuteNonQueryAsync()) Then
                                db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " &
                                    "SET TassMarks.updated = True " &
                                    "WHERE ((TassMarks.Mark)=([TassMarksServer].[Mark]));"
                                If (Await db.cmd4.ExecuteNonQueryAsync()) Then
                                    'success with local
                                    Console.WriteLine("Updated updates")
                                    Return True
                                End If
                            Else
                                Console.WriteLine("Update failed")
                            End If
                        Catch ex As Exception
                            Console.WriteLine("Error Updating Server: " + ex.Message)
                        End Try
                    Next
                End If

            End If

        Catch ex As Exception
            Console.WriteLine("Error saving marks to db: " + ex.Message)
            Return False
        Finally
            db.con4.Close()
            dbS.con.Close()
        End Try
        Return True
    End Function

    Private Sub SaveMarksToServer()
        'UseWaitCursor = True
        'get outstanding marks
        Dim dbS As New dbConnection3(MDIParent1.connectionStringServer)
        'btnSaveToServer.Text = "Saving"
        Dim tableName As String = "TassMarks"
        Dim sql As String = "SELECT ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, BackedUp From " &
            tableName & " WHERE updated = False;"

        Try
            dbS.con.Open()
            db.con4.Open()

            '--------------------------------------
            'db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " &
            '    "SET TassMarks.updated = True, TassMarksServer.Mark = TassMarks.Mark " &
            '        "WHERE ((TassMarks.Mark)<>([TassMarksServer].[Mark]));"
            'If (db.cmd4.ExecuteNonQuery()) Then
            '    'success with local
            '    Console.WriteLine("Updated changed marks")
            'End If

            'db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " &
            '    "SET TassMarks.updated = True " &
            '        "WHERE (((TassMarks.Mark)=([TassMarksServer].[Mark])));"
            'If (db.cmd4.ExecuteNonQuery()) Then
            '    'success with local
            '    Console.WriteLine("Updated updates")
            'End If
            '--------------------------------------

            'Threading.Thread.Sleep(1500)

            If (FillDS(tableName, sql)) Then

                'okay got something. Is it empty
                If (ds.Tables(tableName).Rows.Count < 1) Then
                    Console.WriteLine("No rows retruned")
                Else
                    'some records to process
                    For Each dr As DataRow In ds.Tables(tableName).Rows
                        If (dr("updated") = True) Then
                            Console.WriteLine("Record already there")
                            Continue For
                        End If
                        Try
                            dbS.cmd.CommandText = "" &
                            "INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " &
                            "('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" &
                            dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & Environment.MachineName & "');"
                            'db.cmd4.CommandText = "UPDATE TassMarks SET updated = " & True & " WHERE ((ExamYear = '" & dr("ExamYear") & _
                            '    "') AND (CentNo = '" & dr("CentNo") & "') AND (IndexNo = '" & dr("IndexNo") & "') AND (SubjCode = '" & dr("SubjCode") & "'));"

                            'ok, now run updates
                            If (dbS.cmd.ExecuteNonQuery()) Then
                            Else
                                Console.WriteLine("Update failed")
                            End If
                        Catch ex As Exception
                            Console.WriteLine("Error Updating Server: " + ex.Message)
                        End Try
                    Next
                End If

            End If

            db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " &
                "SET TassMarks.updated = True " &
                    "WHERE ((TassMarks.Mark)=([TassMarksServer].[Mark]));"
            If (db.cmd4.ExecuteNonQuery()) Then
                'success with local
                Console.WriteLine("Updated updates")
            End If

            'If (FillDS(tableName, sql)) Then

            '    'okay got something. Is it empty
            '    If (ds.Tables(tableName).Rows.Count < 1) Then
            '        Console.WriteLine("No rows retruned")
            '    End If

            '    'some records to process
            '    For Each dr As DataRow In ds.Tables(tableName).Rows
            '        Try
            '            dbS.cmd.CommandText = "" & _
            '            "INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " & _
            '            "('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" & _
            '            dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & Environment.MachineName & "');"
            '            'db.cmd4.CommandText = "UPDATE TassMarks SET updated = " & True & " WHERE ((ExamYear = '" & dr("ExamYear") & _
            '            '    "') AND (CentNo = '" & dr("CentNo") & "') AND (IndexNo = '" & dr("IndexNo") & "') AND (SubjCode = '" & dr("SubjCode") & "'));"

            '            'ok, now run updates
            '            If (dbS.cmd.ExecuteNonQuery()) Then
            '                'success with server
            '                'If (db.cmd4.ExecuteNonQuery()) Then
            '                '    'success with local
            '                '    Console.WriteLine("Update success")
            '                '    UseWaitCursor = False
            '                'End If
            '            Else
            '                Console.WriteLine("Update failed")
            '            End If
            '        Catch ex As Exception
            '            Console.WriteLine("Error Updating Server: " + ex.Message)
            '        End Try
            '    Next
            'End If

            'Try

            '    db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer " & _
            '        "ON (TassMarksServer.SubjCode = TassMarks.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND " & _
            '        "(TassMarksServer.CentNo = TassMarks.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " & _
            '        "SET TassMarksServer.Mark = [TassMarks].[Mark], TassMarks.updated = True WHERE TassMarks.updated = False;"

            '    If (db.cmd4.ExecuteNonQuery()) Then
            '        'success with local
            '        Console.WriteLine("Update success")
            '        UseWaitCursor = False
            '    End If
            'Catch ex As Exception

            'End Try

            ''some records to process
            'For Each dr As DataRow In ds.Tables(tableName).Rows
            '    Try
            '        dbS.cmd.CommandText = "" & _
            '        "INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " & _
            '        "('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" & _
            '        dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & Environment.MachineName & "');"
            '        'db.cmd4.CommandText = "UPDATE TassMarks SET updated = " & True & " WHERE ((ExamYear = '" & dr("ExamYear") & _
            '        '    "') AND (CentNo = '" & dr("CentNo") & "') AND (IndexNo = '" & dr("IndexNo") & "') AND (SubjCode = '" & dr("SubjCode") & "'));"

            '        'ok, now run updates
            '        If (dbS.cmd.ExecuteNonQuery()) Then
            '            'success with server
            '            'If (db.cmd4.ExecuteNonQuery()) Then
            '            '    'success with local
            '            '    Console.WriteLine("Update success")
            '            '    UseWaitCursor = False
            '            'End If
            '        Else
            '            Console.WriteLine("Update failed")
            '        End If
            '    Catch ex As Exception
            '        Console.WriteLine("Error saving: " & ex.Message)
            '        'dbS.cmd.CommandText = "" & _
            '        '"INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " & _
            '        '"('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" & _
            '        'dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & _
            '        'Environment.MachineName & "');"

            '        '    db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer " & _
            '        '        "ON (TassMarksServer.SubjCode = TassMarks.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND " & _
            '        '        "(TassMarksServer.CentNo = TassMarks.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " & _
            '        '        "SET TassMarksServer.Mark = [TassMarks].[Mark], TassMarks.updated = True;"

            '        '    If (db.cmd4.ExecuteNonQuery()) Then
            '        '        'success with local
            '        '        Console.WriteLine("Update success")
            '        '        UseWaitCursor = False
            '        '    End If
            '    End Try

            'Next

            'Try
            '    db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = False " & _
            '            "WHERE (((TassMarks.Mark)<>[TassMarksServer].[Mark]));"
            '    If (db.cmd4.ExecuteNonQuery()) Then
            '        'success with local
            '        Console.WriteLine("Updated updates")
            '    End If

            '    db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer " & _
            '        "ON (TassMarksServer.SubjCode = TassMarks.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND " & _
            '        "(TassMarksServer.CentNo = TassMarks.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " & _
            '        "SET TassMarksServer.Mark = [TassMarks].[Mark], TassMarks.updated = True WHERE TassMarks.updated = False;"

            '    If (db.cmd4.ExecuteNonQuery()) Then
            '        'success with local
            '        Console.WriteLine("Update success")
            '        UseWaitCursor = False
            '    End If
            'Catch ex As Exception

            'End Try
        Catch ex As Exception
            Console.WriteLine("Error saving marks to db: " + ex.Message)
        Finally
            db.con4.Close()
            dbS.con.Close()
            'UseWaitCursor = False
            'btnSaveToServer.Text = "Save"
            'threadSaveMarksToServer.Abort()
        End Try

        'UseWaitCursor = False
        'btnSaveToServer.Text = "Save"
    End Sub

    'save marks in the background
    'Private Sub SaveMarksToServer()
    '    'UseWaitCursor = True
    '    'get outstanding marks
    '    Dim dbS As New dbConnection3(MDIParent1.connectionStringServer)
    '    btnSaveToServer.Text = "Saving"
    '    Dim tableName As String = "TassMarks"
    '    Dim sql As String = "SELECT ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, BackedUp From " &
    '        tableName & " WHERE updated = " & False & ";"

    '    If (FillDS(tableName, sql)) Then
    '        'okay got something. Is it empty
    '        If (ds.Tables(tableName).Rows.Count < 1) Then
    '            'nothing returned, exit
    '            'MessageBox.Show("All records updated.", "Nothing returned", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            btnSaveToServer.Text = "Save"
    '            'Exit Sub
    '        End If

    '        Try
    '            dbS.con.Open()
    '            db.con4.Open()

    '            '--------------------------------------
    '            db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = False " & _
    '                "WHERE (((TassMarks.Mark)<>[TassMarksServer].[Mark]));"
    '            If (db.cmd4.ExecuteNonQuery()) Then
    '                'success with local
    '                Console.WriteLine("Updated updates")
    '            End If

    '            db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = True " & _
    '                    "WHERE (((TassMarks.Mark)=[TassMarksServer].[Mark]));"
    '            If (db.cmd4.ExecuteNonQuery()) Then
    '                'success with local
    '                Console.WriteLine("Updated updates")
    '            End If
    '            '--------------------------------------

    '            'some records to process
    '            For Each dr As DataRow In ds.Tables(tableName).Rows
    '                Try


    '                    dbS.cmd.CommandText = "" & _
    '                    "INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " & _
    '                    "('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" & _
    '                    dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & Environment.MachineName & "');"
    '                    db.cmd4.CommandText = "UPDATE TassMarks SET updated = " & True & " WHERE ((ExamYear = '" & dr("ExamYear") & _
    '                        "') AND (CentNo = '" & dr("CentNo") & "') AND (IndexNo = '" & dr("IndexNo") & "') AND (SubjCode = '" & dr("SubjCode") & "'));"

    '                    'ok, now run updates
    '                    If (dbS.cmd.ExecuteNonQuery()) Then
    '                        'success with server
    '                        If (db.cmd4.ExecuteNonQuery()) Then
    '                            'success with local
    '                            Console.WriteLine("Update success")
    '                            UseWaitCursor = False
    '                        End If
    '                    Else
    '                        Console.WriteLine("Update failed")
    '                    End If
    '                Catch ex As Exception
    '                    Console.WriteLine("Error Updating Server: " + ex.Message)
    '                End Try
    '            Next

    '            Try
    '                'db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = False " & _
    '                '        "WHERE (((TassMarks.Mark)<>[TassMarksServer].[Mark]));"
    '                'If (db.cmd4.ExecuteNonQuery()) Then
    '                '    'success with local
    '                '    Console.WriteLine("Updated updates")
    '                'End If

    '                'db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = True " & _
    '                '        "WHERE (((TassMarks.Mark)=[TassMarksServer].[Mark]));"
    '                'If (db.cmd4.ExecuteNonQuery()) Then
    '                '    'success with local
    '                '    Console.WriteLine("Updated updates")
    '                'End If

    '                db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer " & _
    '                    "ON (TassMarksServer.SubjCode = TassMarks.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND " & _
    '                    "(TassMarksServer.CentNo = TassMarks.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " & _
    '                    "SET TassMarksServer.Mark = [TassMarks].[Mark], TassMarks.updated = True WHERE TassMarks.updated = False;"

    '                If (db.cmd4.ExecuteNonQuery()) Then
    '                    'success with local
    '                    Console.WriteLine("Update success")
    '                    UseWaitCursor = False
    '                End If
    '            Catch ex As Exception

    '            End Try
    '        Catch ex As Exception
    '            Console.WriteLine("Error saving marks to db: " + ex.Message)
    '        Finally
    '            db.con4.Close()
    '            dbS.con.Close()
    '            UseWaitCursor = False
    '            btnSaveToServer.Text = "Save"
    '        End Try
    '    End If
    '    UseWaitCursor = False
    '    btnSaveToServer.Text = "Save"
    'End Sub

    Private Function FillDS(ByVal tableName As String, ByVal sqlString As String) As Boolean
        Try
            'try to remove table
            Try
                ds.Tables.Remove(tableName)
            Catch ex As Exception
                'table most likely does not exist
            End Try

            Dim da As New OleDbDataAdapter(sqlString, db.con.ConnectionString)
            da.SelectCommand.CommandText = sqlString
            da.Fill(ds, tableName)
            da.Dispose()
            Return True
        Catch ex As Exception
            Console.WriteLine("Error filling ds with: " & sqlString)
        End Try
        Return False
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub timerSaveToDb_Tick(sender As Object, e As EventArgs) Handles timerSaveToDb.Tick
        Try
            btnSaveToServer.PerformClick()
        Catch ex As Exception
            Console.WriteLine("Error in timerSaveToDb(): " + ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmMarks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'UseWaitCursor = True
        ''SaveMarksToServer()
        'UseWaitCursor = False
    End Sub
End Class

'Try
'            db.con.Open()


'        Catch ex As Exception
'            Console.WriteLine("Error in returnsubCode(): " & ex.Message)
'        Finally
'            db.con.Close()
'        End Try