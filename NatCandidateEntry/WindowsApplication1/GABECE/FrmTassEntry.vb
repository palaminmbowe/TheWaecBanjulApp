Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmTassEntry
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon4 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon5 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                 System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim con As New ConClass
    Dim log As Integer
    Dim centre As String
    Dim dr, dr1, dr2 As OleDbDataReader
    Dim Max_Mark, Min_Mark, recno, PaperCodes_Tot As Integer
    Dim CentCode, CandName, CandNo, Papcode, SchoolCode, examyr, subj1, candsubj As String
    Dim Pap1Mrk, Pap2Mrk, Pap3Mrk, PapName, PapType, Paptp, Papno, sub1, Absent, CurrentSubj As String
    Dim CreationDate, ModifyDate As Date
    Dim gtot_Cand_Entry, Sch_Cand_Entry, Tot_Cand_Entry, Outstanding_Entry, Outstanding_Entry1 As Integer
    Dim EntryIn, EntryOut, noofcands As Integer
    Dim Flag As Integer
    Dim Query1, Query3, Query5, Subjcodes As String
    Dim Query2, Query4 As New OleDbCommand

    Private Sub FrmTassEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmSubject_Officer.getstatuscode()
        CmdAdd.Enabled = False
        CmdClear.Enabled = False
        ExamYear()
        Me.Text = myusername.ToUpper + ":  " + examinerno
    End Sub

    Private Sub txtMark1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMark1.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMark1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMark1.Leave
        'This code checks for the value entered in the text box to prevent user entering 000, 
        'Absent and more than 100
        Try
            If (CInt(txtMark1.Text)) > Min_Mark And (CInt(txtMark1.Text)) < Max_Mark Then 'Then
                If (txtMark1.Text.Length > 3) Or (txtMark1.Text.Length < 3) Then
                    'Else 'did not enter three digits
                    MessageBox.Show("Please enter 3 digits", "TassMark Entry Validation", MessageBoxButtons.OK)
                    txtMark1.Clear()
                    txtMark1.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim fla As String
        Dim cmd1 As New OleDbCommand
        fla = "c"
        Try
            'checkpapcodes()

            If CboCanNo.Items.Count < 1 Then
                MsgBox("Index number missing")
                CboCanNo.Focus()
            Else
                If CboSubjName.SelectedIndex = -1 Then
                    MsgBox("Subject not selected")
                    Exit Sub
                    CboSubjName.Focus()
                Else

                    If txtMark1.Text = "" And ChkAbs.Checked = False Then
                        MsgBox("Missing Marks")
                        txtMark1.Focus()
                    Else

                        CmdAdd.Enabled = True
                    End If
                End If
            End If

            MyModule1.candsubj = Mid(subjcode, 1, 3)

            CentCode = CboCentCode.Text
            CandNo = CboCanNo.Text
            Pap1Mrk = txtMark1.Text
            absentMark()

            'insert into Tassmarks table
            gcon.Open()
            Dim cmd As New OleDbCommand
            Query1 = "Insert into TASSMARKS(EXAMYEAR,CENTCODE,INDEXNO,PAPERCODE,EXAMINERNO,MARK,FLAG)" _
                                        & " values" _
                                        & "('" & examyr & "','" & CentCode & "','" & CandNo & "','" & cbosubjcode.Text & "','" & examinerno & "','" & Pap1Mrk & "','" & fla & "')"
            cmd.Connection = gcon
            Query2 = New OleDb.OleDbCommand(Query1, gcon)

            'Insert into audit trail
            gcon4.Open()

            Query3 = "Insert into Audit_Trail(EXAMYEAR,CENTCODE,INDEXNO,PAPERCODE,EXAMINERNO,DATE_MRK_CREATED,FIRSTMRK,FLAG)" _
                                            & " values" _
                                            & "('" & examyr & "','" & CentCode & "','" & CandNo & "','" & cbosubjcode.Text & "','" & examinerno & "','" & CreationDate & "','" & Pap1Mrk & "','" & fla & "')"
            cmd1.Connection = gcon4
            Query4 = New OleDb.OleDbCommand(Query3, gcon4)
            Query2.ExecuteNonQuery()
            Query4.ExecuteNonQuery()
            gcon.Close()
            gcon4.Close()
            MsgBox("Record has been added.", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox("Record Already Exist. ", MsgBoxStyle.Information, Me.Text)
        Finally
            gcon.Close()
            gcon4.Close()
        End Try

        Dim mCmd1 As New OleDbCommand
        gcon5.Open()

        Query5 = "UPDATE Subject_Entry_By_Cand SET FLAG='" & Pap1Mrk & "' WHERE CENTCODE='" & CboCentCode.Text & "'" _
        & "and INDEXNO='" & CboCanNo.Text & "' and SUBJCODE='" & myexaminer1 & "' and EXAMINERNO='" & examinerno & "'"
        mCmd1 = New OleDb.OleDbCommand(Query5, gcon5)
        mCmd1.Connection = gcon5
        mCmd1.ExecuteNonQuery()
        gcon5.Close()
        Countmarksoustanding()
        ClearForm()
        CmdAdd.Enabled = True
        Countmarksoustanding()
        'getindexes()

    End Sub
    Sub absentMark()
        If ChkAbs.Checked = True Then
            Pap1Mrk = "  A"
        End If
    End Sub

    Public Sub ClearForm()

        'clears the form for new candidate entry
        CboCentCode.Enabled = True
        'CboCentCode.Focus()
        CboCanNo.SelectedIndex = 0
        txtLName.Clear()
        lblSubjName.Text = ""
        lblSubjcode.Text = ""
        txtMark1.Text = ""
        getindexes()
        CboCanNo.Focus()
        CboCanNo.SelectedIndex = 0
        CmdAdd.Enabled = False
        ChkAbs.Enabled = True
        If ChkAbs.Checked Then
            ChkAbs.Checked = False
        End If
        txtMark1.Focus()
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearForm()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing TassMark Form", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            CboCentCode.Focus()
        End If

    End Sub

    Private Sub GetCandName()
        'get candidate name doing subject
        getCentres()
        Try
            Dim cmd As New OleDbCommand

            con.OpenConnection()
            cmd.CommandText = "select DISTINCT CANDNAME from GBB02OUT where CENTCODE='" & CboCentCode.Text & "' and INDEXNO='" & CboCanNo.Text & "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            While dr.Read()
                txtLName.Text = dr("CANDNAME")
            End While
        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        Finally

        End Try

    End Sub
    Private Sub ValidateForm()

        If CboCentCode.Text = "" Or _
            CboCanNo.Text = "" Or _
            txtLName.Text = "" Or _
            txtMark1.Text = "" Then

            MsgBox("Please Enter all the details", MsgBoxStyle.Critical)

            'ClearForm()
            CboCentCode.Focus()

        End If
    End Sub
    Private Sub CboCanNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCanNo.SelectedIndexChanged
        GetCandName()
    End Sub
    Private Sub UpdateCandEntry()
        'Gives the total candidate entry outstanding.
        Dim cmd As New OleDbCommand
        Try
            con.OpenConnection()

            cmd.CommandText = "Select Count(CENTCODE)from Subject_Entry_By_Cands where CentCode='" & CboCentCode.Text & "'"
            cmd.Connection = con.con
            gtot_Cand_Entry = cmd.ExecuteScalar
            con.CloseConnection()

        Catch ex As Exception
            con.CloseConnection()
        Finally
        End Try

    End Sub
    Private Sub UpdateMarkEntry()

        'calculate the no of records in a centre.  Example the total amount of candidates times 4 for core subjects.

        Dim cmd As New OleDbCommand
        Try
            con.OpenConnection()
            cmd.CommandText = "Select COUNT (INDEXNO) from Subject_Entry_By_Cand where CentCode='" & CboCentCode.Text & "'"
            cmd.Connection = con.con
            Sch_Cand_Entry = cmd.ExecuteScalar

            'Tot_Cand_Entry = (Sch_Cand_Entry * 4)
            con.CloseConnection()
            ' Outstanding_Entry = (Tot_Cand_Entry - gtot_Cand_Entry)

            Outstanding_Entry = (gtot_Cand_Entry - Sch_Cand_Entry)
            'Label1.Text = ("The Number of Outstanding Marks = " & Outstanding_Entry & "")

        Catch ex As Exception
            con.CloseConnection()
        Finally
        End Try

    End Sub
    Private Sub ListInCand()
        'List candididates with complete marks.
        Dim cmd As New OleDbCommand
        Dim Entry As Integer
        Try
            con.OpenConnection()
            cmd.CommandText = "Select COUNT(INDEXNO) from TassMarks where CentCode='" & CboCentCode.Text & "'"
            cmd.Connection = con.con
            Entry = cmd.ExecuteScalar
            'EntryIn = (Entry \ 4)
            con.CloseConnection()

        Catch ex As Exception
            con.CloseConnection()
        Finally
        End Try
    End Sub
    Private Sub ListOutCand()
        ' list outstanding records on button click

        Dim cmd As New OleDbCommand
        Try
            con.OpenConnection()
            cmd.CommandText = "Select Count(INDEXNO) from Subject_Entry_By_Cand where CentCode='" & CboCentCode.Text & "'"
            cmd.Connection = con.con
            EntryOut = cmd.ExecuteScalar
            con.CloseConnection()
            Outstanding_Entry1 = (EntryOut - EntryIn)
            'Label1.Text = ("The Number of Outstanding Marks = " & Outstanding_Entry1 & " ")

        Catch ex As Exception
            con.CloseConnection()
        Finally
        End Try
    End Sub
    Private Sub CmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f4 As New FrmModify_Tass
        f4.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateCandEntry()
        UpdateMarkEntry()

    End Sub
    Private Sub cmdOCand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOCand.Click
        'displaying candidate with incomplete records on the gridview..
        Try
            Dim f3 As New FrmIncompleteTMarks
            f3.Show()

        Catch ex As Exception
        Finally
        End Try

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Outstanding_Entry1 < 1 Then
            ' Label1.BackColor = Color.Tomato
        End If

        If Outstanding_Entry < 1 Then
            'Label1.BackColor = Color.Tomato
        End If
    End Sub
    Private Sub getCentres()
        'CboCentCode.Items.Clear()
        getPapcodes()
        'getting Centers for each selected subject

        Dim cent As String
        cent = "7"
        Try

            Dim cmd As New OleDbCommand
            con.OpenConnection()
            cmd.CommandText = "Select DISTINCT CENTCODE From Subject_Entry_By_Cand where " _
            & " SUBJCODE='" & myexaminer1 & "'  and EXAMINERNO ='" & examinerno & "' ORDER BY CENTCODE"

            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            While (dr.Read)
                CboCentCode.Items.Add(dr("CENTCODE"))
            End While
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception

        Finally
            dr.Close()
            con.CloseConnection()
        End Try


    End Sub
    Private Sub getSubjects()
        'getting examiner username and subjectcode to load subjectname
        Try
            Dim cmd As New OleDbCommand
            Dim dr As OleDbDataReader
            con.OpenConnection()
            cmd.CommandText = "Select * From PaperDetails where PapCodeCSD ='" & myexaminer1 & "'"

            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then
                CboSubjName.Items.Add(dr("PapName"))
            End If
            dr.Close()
            con.CloseConnection()
            gcon.Close()

        Catch ex As Exception

        Finally
            con.CloseConnection()
            gcon.Close()
        End Try

    End Sub
    Private Sub getSubjectsco()
        'getting examiner username and subjectcode to load subjectname
        Try
            Dim cmd As New OleDbCommand
            Dim dr1 As OleDbDataReader
            con.OpenConnection()
            cmd.CommandText = "Select * From PaperDetails where PapCodeCSD ='" & myexaminer1 & "'"

            cmd.Connection = con.con
            dr1 = cmd.ExecuteReader

            If dr1.Read() Then
                'CboSubjName.Items.Add(dr("PapName"))
                cbosubjcode.Items.Add(dr1("PapCodeCSD"))
            End If
            dr1.Close()
        Catch ex As Exception
            con.CloseConnection()
        Finally

            con.CloseConnection()

        End Try

    End Sub
    Sub getallocation()
        Try
            gcon.Open()
            Query3 = "select Count(*)from Subject_Entry_By_Cand where EXAMINERNO=('" & examinerno & "')and SUBJCODE = '" & myexaminer1 & "' "
            cmd = New OleDb.OleDbCommand(Query3, gcon)
            totcandid = cmd.ExecuteScalar()

            txttotscript.Text = totcandid
            gcon.Close()
        Catch ex As Exception
        Finally
            gcon.Close()
        End Try
    End Sub
    Sub Countmarksoustanding()
        Try
            gcon.Open()
            Dim Flag As String = "i"

            Dim cmd As New OleDb.OleDbCommand

            cmd.CommandText = "select count (*) from Subject_Entry_By_Cand where ExaminerNo=('" & examinerno & "') and SubjCode='" & myexaminer1 & "' and Flag='" & Flag & "' "
            cmd.Connection = gcon
            txtoutscript.Text = cmd.ExecuteScalar

            gcon.Close()
        Catch ex As Exception
        Finally
            gcon.Close()
        End Try
    End Sub
    Private Sub getPapcodes()
        Try
            'Accessing Papcode from Subjects Table to fill the Papcode Combo box

            gcon5.Open()

            Dim cmd, cmd1 As New OleDbCommand

            cmd1.CommandText = "Select * from PaperDetails where PapName= '" & CboSubjName.Text & "' "
            cmd1.Connection = gcon5
            dr = cmd1.ExecuteReader

            While dr.Read()

                Papno = Mid(dr("PapCodeCSD"), 6, 1)
                CurrentSubj = Mid(dr("PapCodeTAD"), 1, 3)
                PapType = dr("PapType")
                PapName = dr("PapName")


                Max_Mark = dr("Max_Mark")
                '2 papers
                If Papno = 2 Then
                    Paptp = Mid(dr("PapCodeCSD"), 5, 1)
                    If Paptp = 2 Then
                        'Essay
                        clearlabels()
                        lblSubjName.Text = PapName
                        lblSubjcode.Text = PapType

                    End If
                End If

                '3 papers
                If Papno = 3 Then
                    Paptp = Mid(dr("PapCodeCSD"), 5, 1)
                    If Paptp = 2 Then
                        'Essay
                        clearlabels()
                        lblSubjName.Text = PapName
                        lblSubjcode.Text = PapType

                    End If

                    If Paptp = 3 Then
                        'Essay
                        clearlabels()
                        lblSubjName.Text = PapName
                        lblSubjcode.Text = PapType

                    End If
                End If

                '4 papers
                If Papno = 4 Then
                    Paptp = Mid(dr("PapCodeCSD"), 5, 1)

                    'Essay
                    If Paptp = 2 Then
                        'Essay
                        clearlabels()
                        lblSubjName.Text = PapName
                        lblSubjcode.Text = PapType

                    End If

                    If Paptp = 3 Then
                        'Essay
                        clearlabels()
                        lblSubjName.Text = PapName
                        lblSubjcode.Text = PapType

                    End If

                    If Paptp = 4 Then
                        clearlabels()
                        lblSubjName.Text = PapName
                        lblSubjcode.Text = PapType

                    End If
                End If

            End While
            dr.Close()
            gcon5.Close()
        Catch ex As Exception
            gcon5.Close()
        Finally
        End Try
    End Sub

    Private Sub ExamYear()
        Dim cmd As New OleDbCommand
        examyr = Now.Year
        CreationDate = Now.Date
        txtexamyr.Text = (examyr)

    End Sub
    Private Sub CboCentCode_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentCode.SelectedIndexChanged
        getindexes()
    End Sub
    Private Sub Complete_Recs()
        Try
            Dim cflag As String = "c"
            If (Outstanding_Entry1 < 1) Then
                Dim f5 As New FrmCompleteTMarks

                f5.Show()

                ds.Clear()
                da = New OleDb.OleDbDataAdapter("Select Transact.CentCode,Transact.CandNo,Transact.SubjCode FROM Transact WHERE Flag like '" & cflag & "'", con.con)

                da.Fill(ds, "CassMarks")
                f5.Complete_Recs.DataSource = ds.Tables("CassMarks")

            ElseIf (Outstanding_Entry1 = 0) Then
                MessageBox.Show("All Candidates for '" + CboCentCode.Text + "' has been entered.")
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Private Sub CompleteRecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteRecs.Click
        Try
            Dim f5 As New FrmCompleteTMarks
            f5.Show()

        Catch ex As Exception
        Finally
        End Try

    End Sub
    Private Sub incompleteRecs()
        Try
            Dim iflag As String = "i"
            If (Outstanding_Entry1 < 1) Then
                Dim f3 As New FrmIncompleteMarks
                f3.Show()

                ds.Clear()
                da = New OleDb.OleDbDataAdapter("Select Transact.CentCode,Transact.CandNo,Transact.SubjCode FROM Transact WHERE Flag like '" & iflag & "'", con.con)

                da.Fill(ds, "CassMarks")

                f3.Incomplete_Recs.DataSource = ds.Tables("CassMarks")

            ElseIf (Outstanding_Entry1 = 0) Then
                MessageBox.Show("All Candidates for '" + CboCentCode.Text + "' has been entered.")

            End If

        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdviewall_marks.Click
        'displaying candidate with incomplete records on the gridview..
        Try
            Dim f2 As New FrmTassGV
            f2.Show()

        Catch ex As Exception
        Finally
        End Try

    End Sub

    Private Sub CboSubjName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubjName.SelectedIndexChanged
        uncheck()
        getPapcodes()
        getSubjectsco()
        getCentres()
        getallocation()
        Countmarksoustanding()
        CmdClear.Enabled = True
    End Sub
    Sub uncheck()
        clearlabels()
    End Sub
    Sub clearlabels()
        lblSubjcode.Text = ""
        lblSubjName.Text = ""
    End Sub
    Sub clearSubjects()
        CboSubjName.Items.Clear()
        cbosubjcode.Items.Clear()
    End Sub

    Private Sub txtexamyr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtexamyr.TextChanged
        getSubjects()
    End Sub

    Private Sub ChkAbs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAbs.CheckedChanged
        If ChkAbs.Checked = True Then
            txtMark1.Enabled = False
            CmdAdd.Enabled = True
            CmdAdd.Focus()
        End If
        If ChkAbs.Checked = False Then
            txtMark1.Enabled = True
            CmdAdd.Enabled = True
            CmdAdd.Focus()
        End If
    End Sub

    Private Sub txtMark1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMark1.TextChanged
        Try
            If txtMark1.Text > CStr(Max_Mark) Then
                MsgBox("Mark cannot be more that " & Max_Mark & "")
                txtMark1.Clear()
                txtMark1.Focus()
            End If
            If txtMark1.Text.Length = 3 Then
                ChkAbs.Enabled = False
                CmdAdd.Enabled = True
                CmdAdd.Focus()

            End If
            If txtMark1.Text = "" Then
                ChkAbs.Enabled = True
                CmdAdd.Enabled = True
                CmdAdd.Focus()

            End If
        Catch ex As Exception
        Finally
        End Try

    End Sub
    Sub getindexes()

        Dim ccount As Integer
        Dim dr2 As OleDbDataReader
        Dim cmd2 As New OleDbCommand

        Dim flag As String

        Dim i As Integer
       
        flag = "i"
        Try
            gcon.Open()
            If cbosubjcode.Text = "" Then
                cbosubjcode.Focus()
            Else

                cmd2.CommandText = "select distinct(INDEXNO) from Subject_Entry_By_Cand where  CENTCODE Like ('" & CboCentCode.Text & "%') and SUBJCODE Like ('" & myexaminer1 & "%')and FLAG Like ('" & flag & "%')"
                cmd2.Connection = gcon

                dr2 = cmd2.ExecuteReader

                ccount = dr2.RecordsAffected
                If dr2.HasRows Then
                    If CboCanNo.Items.Count > 0 Then
                        CboCanNo.Items.Clear()
                    End If
                End If

                'The var i is used to check whether subject has candidates registered
                While (dr2.Read())
                    i = 1
                    CboCanNo.Items.Add(dr2("INDEXNO"))
                End While

                dr2.Close()

            End If
            If i <> 1 Then
                MsgBox("No Candidate registered for " + cbosubjcode.Text)
            Else
                cbosubjcode.SelectedIndex = 0
            End If
        Catch ex As Exception
        Finally
            gcon.Close()
        End Try
    End Sub
End Class


