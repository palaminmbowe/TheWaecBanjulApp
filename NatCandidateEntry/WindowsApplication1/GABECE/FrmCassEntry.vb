Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmCassEntry
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon7 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon8 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")


    Dim con As New ConClass
    Dim dAdapt, da As OleDbDataAdapter
    Dim log As Integer
    Dim mCmd, mCmd1 As OleDbCommand
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim PaperCodes_Tot As Integer
    Dim recno As Integer
    Dim Max_Mark As Integer = 101
    Dim Min_Mark As Integer = 0
    Dim SchoolCode, CentCode, CandName, CandNo, subj, Subjcode, YMrk2, YMrk3, sub1, ONAME, LNAME, FNAME, centre, mQuery As String
    Dim Len As Integer
    Dim gtot_Cand_Entry As Integer
    Dim Sch_Cand_Entry As Integer
    Dim Tot_Cand_Entry As Integer
    Dim Outstanding_Entry As Integer
    Dim Outstanding_Entry1 As Integer
    Dim EntryIn As Integer
    Dim EntryOut As Integer
    Dim English As String = "111"
    Dim Mathematics As String = "112"
    Dim Science As String = "113"
    Dim SES As String = "114"
    Dim Subjcodes As String
    Dim Flag As Integer
    Dim fla As String = "c"
    Dim flags As String = "i"

    Private Sub FrmCassEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Button5.Enabled = True
        Button5.Hide()
        CmdAdd.Enabled = False
        CmdClear.Enabled = False
        examsYear()
        getcenters()
        getPapcodes()
        'getTrans()

    End Sub
    Private Sub txtYear2Mark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear2Mark.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtYear2Mark_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear2Mark.Leave
        'This code checks for the value entered in the text box to prevent user entering 000, 
        'Absent and more than 100

        Try
            If txtYear2Mark.Text > Min_Mark And txtYear2Mark.Text < Max_Mark Then 'Then

            Else  ' mark is out of range
                MessageBox.Show("Cass Mark must be between " & 0 & " and " & 100 & ".", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear2Mark.Clear()
                txtYear2Mark.Focus()
            End If
            If (txtYear2Mark.Text.Length > 3) Or (txtYear2Mark.Text.Length < 3) Then
                'Else 'did not enter three digits
                'MessageBox.Show("Please enter 3 digits", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear2Mark.Clear()
                txtYear2Mark.Focus()

            End If

        Catch ex As Exception
        End Try

    End Sub
    Private Sub txtYear3Mark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear3Mark.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
            'checkrange()
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtYear3Mark_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear3Mark.Leave
        'This code validates the Cass Marks textboxes for 0 entry, Absent and marks more than 100

        Try
            If (txtYear3Mark.Text.Length > 3) Or (txtYear3Mark.Text.Length < 3) Then
                'did not enter three digits
                txtYear3Mark.Clear()
                'MessageBox.Show("Please enter 3 digits", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear3Mark.Focus()
                'End If
            ElseIf txtYear3Mark.Text > Min_Mark And txtYear3Mark.Text < Max_Mark Then
                CmdAdd.Focus()
                CmdAdd.Enabled = True
                'End If

            Else ' mark is out of range
                'MessageBox.Show("Cass Mark must be between " & Min_Mark & " and " & Max_Mark & ".", "CassMark Entry Validation", MessageBoxButtons.OK)
                MessageBox.Show("Cass Mark must be between 1 and 100", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear3Mark.Clear()
                txtYear3Mark.Focus()

            End If

        Catch ex As Exception
        Finally

        End Try

    End Sub
    Sub examsYear()

        ' examyr = Now.Year
        Dim cmd As New OleDbCommand
        con.OpenConnection()
        cmd.CommandText = "Select * from CandDetails"
        cmd.Connection = con.con
        dr = cmd.ExecuteReader
        While dr.Read()
            txtexamyr.Text = (dr("EXAMYEAR"))
        End While
        con.CloseConnection()


    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click

        If txtYear2Mark.Text = "" Or txtYear3Mark.Text = "" Then
            MsgBox("Missing Marks")
            txtYear2Mark.Focus()
        Else

            If CboCanNo.Items.Count < 1 Then
                MsgBox("Index number missing")
                CboCanNo.Focus()

            Else
                If CboSubjName.SelectedIndex = -1 Then
                    MsgBox("Subject not selected")
                    CboSubjName.Focus()
                Else
                    CmdAdd.Enabled = True

                    Try
                        examyr = Trim(txtexamyr.Text)
                        CentCode = Trim(CboCentCode.Text)
                        CandNo = Trim(CboCanNo.Text)
                        Subjcode = Trim(CboSubjName.Text)
                        CandName = Trim(txtLName.Text)
                        YMrk2 = txtYear2Mark.Text
                        YMrk3 = txtYear3Mark.Text

                        If CboSubjName.SelectedIndex = 0 Then
                            Subjcodes = English
                        ElseIf CboSubjName.SelectedIndex = 1 Then
                            Subjcodes = Mathematics
                        ElseIf CboSubjName.SelectedIndex = 2 Then
                            Subjcodes = Science
                        ElseIf CboSubjName.SelectedIndex = 3 Then
                            Subjcodes = SES
                        End If

                        con.OpenConnection()
                        Dim cmd As New OleDbCommand
                        cmd.CommandText = "Insert into CassMarks(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE,Year2Mrk,Year3Mrk,SUBJNAME) values('" & examyr & "','" & CentCode & "', '" & CandNo & "','" & Subjcodes & "','" & YMrk2 & "','" & YMrk3 & "','" & Subjcode & "')"
                        cmd.Connection = con.con
                        cmd.ExecuteNonQuery()
                        con.CloseConnection()
                        MsgBox("Record Added.")

                    Catch ex As Exception
                        con.CloseConnection()

                    End Try

                    con.OpenConnection() 'updating the transaction file

                    Dim com As New OleDbCommand

                    com.Connection = con.con

                    com.CommandText = "UPDATE Transact SET Flag='" + fla + "'" _
                          & " WHERE (((CENTCODE='" + CboCentCode.Text + "') and (INDEXNO='" + CboCanNo.Text + "'))and (SUBJCODE='" + Subjcodes + "'))"

                    com.ExecuteNonQuery()
                    con.CloseConnection()
                    
                    Try

                        Cand_By_Cand()

                        CboCanNo.Enabled = True
                        txtLName.Enabled = True
                        CboCentCode.Enabled = True

                        'ClearForm()
                        CboSubjName.SelectedIndex = PaperCodes_Tot

                    Catch ex As Exception
                        MsgBox("Record Already Exist.")
                    Finally
                    End Try
                End If
            End If
        End If

    End Sub
    Public Sub ClearForm()

        'clears the form for new candidate entry

        CboCentCode.Enabled = True
        CboSubjName.SelectedIndex = 0
        CboCanNo.SelectedIndex = -1
        CboCentCode.Focus()
        txtLName.Text = ""
        txtYear2Mark.Text = ""
        txtYear3Mark.Text = ""
        PaperCodes_Tot = 0
        CmdAdd.Enabled = False
        CboCanNo.SelectedIndex = 0


    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing CassMarks Form", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            CboCentCode.Focus()
        End If

    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearForm()

    End Sub
    Private Sub GetCandName()
        Try
            Dim cmd As New OleDbCommand

            gcon7.Open()
            cmd.CommandText = "select * from CandDetails where  INDEXNO='" + CboCanNo.Text + "' and CENTCODE='" + CboCentCode.Text + "'"
            cmd.Connection = gcon7
            dr = cmd.ExecuteReader
            dr.Read()
            LNAME = dr("LNAME")
            FNAME = dr("FNAME")
            ONAME = dr("OTHERNAME")
            txtLName.Text = LNAME + " " + FNAME + " " + ONAME
            dr.Close()
            gcon7.Close()

        Catch ex As Exception

            gcon7.Close()
        End Try

    End Sub
    Private Sub ValidateForm()

        If CboCentCode.Text = "" Or _
            CboCanNo.Text = "" Or _
            CboSubjName.Text = "" Or _
            txtLName.Text = "" Or _
            txtYear2Mark.Text = "" Or _
            txtYear2Mark.Text = "000" Or _
            txtYear3Mark.Text = "" Or _
            txtYear3Mark.Text = "000" Then

            MsgBox("Please Enter all the details", MsgBoxStyle.Critical)

            'ClearForm()
            CboCentCode.Focus()
            CmdAdd.Enabled = False
            'Else
            '   
        End If
    End Sub
    Private Sub CboCanNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCanNo.SelectedIndexChanged

        GetCandName()
        If CmdClear.Enabled = False Then
            CmdClear.Enabled = True
        End If

    End Sub
    Private Sub UpdateCandEntry()
        'Gives the total candidate entry outstanding.
        Dim cmd As New OleDbCommand

        Try
            gcon8.Open()

            cmd.CommandText = "Select Count(CENTCODE)from CandDetails where CENTCODE like '" & CboCentCode.Text & "%'"
            cmd.Connection = gcon8
            gtot_Cand_Entry = cmd.ExecuteScalar
            ' gcon8.Close()

        Catch ex As Exception

        Finally
            gcon8.Close()
        End Try

    End Sub
    Private Sub UpdateMarkEntry()

        'calculate the no of records in a centre.  Example the total amount of candidates times 4 for core subjects.

        Dim cmd As New OleDbCommand
        Try
            con.OpenConnection()
            cmd.CommandText = "Select COUNT (INDEXNO) from Transact where CENTCODE LIKE'" & CboCentCode.Text & "%' and FLAG LIKE '" & flags & "%'"
            cmd.Connection = con.con
            Sch_Cand_Entry = cmd.ExecuteScalar

            Tot_Cand_Entry = Sch_Cand_Entry

            'con.CloseConnection()

            Outstanding_Entry = Sch_Cand_Entry
            Label1.Text = ("The Number of Outstanding Marks = " & Outstanding_Entry & "")

        Catch ex As Exception

        Finally
            con.CloseConnection()
        End Try

    End Sub
    Private Sub ListInCand()
        'List candididates with complete marks.
        Dim cmd As New OleDbCommand
        Dim Entry As Integer
        Try
            con.OpenConnection()
            cmd.CommandText = "Select COUNT(INDEXNO) from CassMarks where CENTCODE='" & CboCentCode.Text & "'"
            cmd.Connection = con.con
            Entry = cmd.ExecuteScalar
            EntryIn = (Entry \ 4)
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
            cmd.CommandText = "Select Count(INDEXNO) from Transact where CENTCODE='" & CboCentCode.Text & "'"
            cmd.Connection = con.con
            EntryOut = cmd.ExecuteScalar
            con.CloseConnection()
            Outstanding_Entry1 = (EntryOut - EntryIn)
            Label1.Text = ("The Number of Outstanding Marks = " & Outstanding_Entry1 & " ")

        Catch ex As Exception
            con.CloseConnection()
        Finally
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f4 As New FrmModifyCass
        f4.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UpdateCandEntry()
        UpdateMarkEntry()


    End Sub
    Private Sub cmdOCand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOCand.Click
        'displaying candidate with incomplete records on the gridview..
        Try

            Dim f3 As New FrmIncompleteMarks
            f3.Show()

        Catch ex As Exception
        Finally
        End Try

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Outstanding_Entry1 < 1 Then
            Label1.BackColor = Color.Tomato
        End If

        If Outstanding_Entry < 1 Then
            Label1.BackColor = Color.Tomato
        End If
    End Sub
    Private Sub getCentres()
        'getting centcodes for each center
        Dim cent As String
        cent = "7"
        Try
            Dim cmd As New OleDbCommand
            gcon8.Open()
            cmd.CommandText = "Select * From CentreTbl where CENTCODE like  '" & cent & "%'"
            cmd.Connection = gcon8
            dr = cmd.ExecuteReader
            While (dr.Read)
                SchoolCode = CboCentCode.Items.Add(dr("CENTCODE"))
            End While
            dr.Close()
            gcon8.Close()
        Catch ex As Exception
            dr.Close()
            gcon8.Close()
        Finally
        End Try

    End Sub
    Private Sub getPapcodes()
        Dim cmd As New OleDbCommand
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        gcon7.Open()
        sub1 = "11"
        cmd.CommandText = "Select * from SubjectTbl where PapCode like '" & sub1 & "%'"
        cmd.Connection = gcon7
        dr = cmd.ExecuteReader
        While (dr.Read())
            CboSubjName.Items.Add(dr("SubjName"))
        End While
        dr.Close()
        gcon7.Close()
    End Sub
    Sub nextindex()


        'Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim num As Integer
        num = CboCanNo.SelectedItem
        CboCanNo.Text = Val(num + 1)

        gcon7.Open()
        psearchcode()

        ' cmd.CommandText = "select Count(*) from CassMarks where CentNo like '" & searchcandidate & "%'"
        cmd.CommandText = "select * from Transact where EXAMYEAR Like ('" & ExamYear & "%') and CENTCODE Like ('" & CboCentCode.Text & "%') and INDEXNO like ('" & CboCanNo.Text & "%')and SUBJCODE like ('" & subj & "%')"

        cmd.Connection = gcon7

        dr = cmd.ExecuteReader
        'While 
        If (dr.Read()) Then
            'CboCanNo.Items.Add(dr("ndexNo")
            num += 1
            CboCanNo.SelectedItem = num
            'GetCandName()
        End If
        If PaperCodes_Tot = 0 Then
            CboCanNo.Items.Add(num)
        End If
        dr.Close()
        gcon7.Close()
    End Sub
    Private Sub getcandno1()
        'getting candididate no
        Dim flag As String
        psearchcode()
        flag = "i"

        CboCanNo.Items.Clear()
        CentCode = CboCentCode.Text
        Dim cmd As New OleDbCommand

        con.OpenConnection()
        cmd.CommandText = "select distinct INDEXNO FROM Transact Where EXAMYEAR Like ('" & txtexamyr.Text & "%')and CENTCODE Like ('" & CboCentCode.Text & "%') and flag like ('" & flag & "%')"
        ' cmd.CommandText = "select * from Transact where EXAMYEAR Like ('" & txtexamyr.Text & "%')and CENTCODE Like ('" & CboCentCode.Text & "%') and flag like ('" & flag & "%')"

        cmd.Connection = con.con
        dr = cmd.ExecuteReader

        ' ccount = dr.RecordsAffected
        If dr.HasRows Then
            If CboCanNo.Items.Count > 0 Then
                CboCanNo.Items.Clear()

            End If
        End If

        While dr.Read()
            CboCanNo.Items.Add(dr("INDEXNO"))
        End While
        dr.Close()
        con.CloseConnection()

    End Sub
    
    Sub psearchcode()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjName like '" & CboSubjName.Text & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())
            subj = (dr("SubjCode"))
        End While


        dr.Close()
        gcon.Close()

    End Sub

    Private Sub CboCentCode_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentCode.SelectedIndexChanged
        getcandno1()
    End Sub
    Private Sub Complete_Recs()
        Try
            Dim cflag As String = "c"
            If (Outstanding_Entry1 < 1) Then
                Dim f5 As New FrmCompleteTMarks

                f5.Show()

                ds.Clear()
                ' da = New OleDb.OleDbDataAdapter("Select CassMarks.CentCode,CassMarks.CandNo,CassMarks.CandName FROM CassMarks WHERE EXISTS(SELECT Cand2009.CandNo FROM Cand2009 WHERE(Cand2009.CandNo= CassMarks.CandNo and (CentCode='" & CboCentCode.Text & "' and SubjName='" & CboSubjName.Text & "')))", con.con)
                da = New OleDb.OleDbDataAdapter("Select Transact.CENTCODE,Transact.INDEXNO,Transact.SUBJCODE FROM Transact WHERE FLAG like '" & cflag & "'", con.con)

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
            Dim f5 As New FrmCompleteMarks
            f5.Show()
            'Complete_Recs()
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
    Sub Add_to_transact()
        Try
            Button5.Enabled = True

            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            gcon.Open()

            getcenters()

            cmd.CommandText = "select * from Cand2009 where CentCode like '" & centre & "%'"
            cmd.Connection = gcon

            dr = cmd.ExecuteReader

            Dim i As Integer
            While dr.Read()
                i += 1

                For i = 1 To 4
                    Subjcode = ""

                    If i = 1 Then
                        CentCode = (dr("CentCode"))
                        CandNo = (dr("CandNo"))
                        Subjcode = (dr("SubjCode1"))
                        changecode()
                        mQuery = "Insert into Transact(CentCode,CandNo,SubjCode)" _
                                            & " values" _
                                            & "('" & CentCode & "','" & CandNo & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If
                    If i = 2 Then
                        CentCode = (dr("CentCode"))
                        CandNo = (dr("CandNo"))
                        Subjcode = (dr("SubjCode2"))
                        changecode()
                        mQuery = "Insert into Transact(CentCode,CandNo,SubjCode)" _
                                            & " values" _
                                            & "('" & CentCode & "','" & CandNo & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If
                    If i = 3 Then
                        CentCode = (dr("CentCode"))
                        CandNo = (dr("CandNo"))
                        Subjcode = (dr("SubjCode3"))
                        changecode()
                        mQuery = "Insert into Transact(CentCode,CandNo,SubjCode)" _
                                            & " values" _
                                            & "('" & CentCode & "','" & CandNo & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If
                    If i = 4 Then
                        CentCode = (dr("CentCode"))
                        CandNo = (dr("CandNo"))
                        Subjcode = (dr("SubjCode4"))
                        changecode()
                        mQuery = "Insert into Transact(CentCode,CandNo,SubjCode)" _
                                            & " values" _
                                            & "('" & CentCode & "','" & CandNo & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If

                Next
            End While
            MsgBox("finished")
            Button5.Enabled = False
            Button5.Hide()
        Catch ex As Exception
        Finally
        End Try

    End Sub
    Sub closeconnections()


        gcon.Close()
        gcon1.Close()
        gcon7.Close()
        gcon8.Close()
       
    End Sub
    Sub getcenters()

        closeconnections()
        Dim cent As String
        cent = "7"

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon1.Open()
            cmd.CommandText = "select DISTINCT CENTCODE from Transact WHERE CENTCODE LIKE '" & cent & "%'"
            cmd.Connection = gcon1

            dr = cmd.ExecuteReader

            While (dr.Read())
                CboCentCode.Items.Add(dr("CENTCODE"))
                If dr.HasRows Then
                Else
                    MsgBox("There exist no data")
                End If
            End While

            dr.Close()
        Catch ex As Exception
            gcon1.Close()
        Finally
        End Try
    End Sub
    Sub changecode()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon1.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & Subjcode & "%'"
        cmd.Connection = gcon1

        dr = cmd.ExecuteReader
        While (dr.Read())
            Subjcode = (dr("SubjName"))
        End While


        dr.Close()
        gcon1.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'displaying candidate with incomplete records on the gridview..
        Try
            Dim f2 As New FrmCassGV
            f2.Show()

        Catch ex As Exception
        Finally
        End Try

    End Sub
    Private Sub getTrans()
        closeconnections()
        Dim CentAvailable As Integer
        Dim cmd As New OleDbCommand
        gcon1.Open()
        cmd.CommandText = "select count (CENTCODE) from Transact" ' where Center='" & CboCentCode.Text & "'"
        cmd.Connection = gcon1
        CentAvailable = cmd.ExecuteScalar
        gcon1.Close()

    End Sub

    Private Sub Cand_By_Cand()
        Try
            If PaperCodes_Tot < 3 Then
                PaperCodes_Tot += 1
                txtLName.Enabled = True
                txtYear2Mark.Focus()
                txtYear2Mark.Clear()
                txtYear3Mark.Clear()

            Else
                ClearForm()
                MsgBox("Enter Next Candidate Marks")
                '
                CboCanNo.Enabled = True
                txtLName.Clear()
                txtLName.Enabled = True
                CboCentCode.Enabled = True
                txtYear2Mark.Clear()
                txtYear3Mark.Clear()
                CboCentCode.Focus()
                PaperCodes_Tot = 0
            End If

            CboSubjName.SelectedIndex = PaperCodes_Tot

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Add_to_transact()
    End Sub

    Private Sub CboSubjName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubjName.SelectedIndexChanged
       '
    End Sub
End Class


