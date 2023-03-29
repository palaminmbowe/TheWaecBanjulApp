Imports System.Data
Imports System.Data.OleDb
Public Class frmAllocatePapers
    'Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    'Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    Public gcon As New OleDbConnection(MDIParent1.connectionString)
    Public con As New OleDbConnection(MDIParent1.connectionString)

    Dim ExamYear As String
    Dim indrange1, subjcode, centno, index As String
    Dim exno, examiner_Allo As String
    Dim alot As Integer = 0

    Dim subj As String
    Dim PAP As String

    Dim db As New dbConnection3(MDIParent1.connectionString)

    Dim paperNumber As String

    Dim tAllocate As Threading.Thread


    Private Sub frmAllocatePapers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtExamYear.Text = Now.Year()
        paperNumber = curuser.Substring(0, 3)
        GetExaminer()
        getCent()
        'getPapers()
    End Sub

    Sub getCent()
        Try
            db.con.Open()

            'db.cmd.CommandText = "SELECT CentNo, Description FROM wacenters ORDER BY Centno"

            db.cmd.CommandText = "SELECT wacenters.CentNo, wacenters.Description FROM wacenters INNER JOIN Cand_Subjects ON wacenters.CentNo = Cand_Subjects.CentNo WHERE (((Cand_Subjects.[Sub1]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub2]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub3]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub4]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub5]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub6]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub7]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub8]) In ('" & paperNumber & "'))) OR (((Cand_Subjects.[Sub9]) In ('" & paperNumber & "'))) GROUP BY wacenters.CentNo, wacenters.Description ORDER BY wacenters.CentNo;"

            db.dr = db.cmd.ExecuteReader()
            While (db.dr.Read())
                cmbCenter.Items.Add(String.Concat(db.dr("CentNo"), " - ", db.dr("Description")))
            End While

        Catch ex As Exception
            Console.WriteLine("Error in getcent(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub ResetFields()
        CmbSubject.Items.Clear()
        CmbSubject.ResetText()
        cmbCenter.ResetText()
        txtTotalAvailable.Text = ""
        cbStart.ResetText()
        cbStop.ResetText()
        CmbExaminerno.ResetText()
        pbProgress.Value = 0

    End Sub

    Sub getPapers()

        subj = Mid(curuser, 1, 3)

        PaperCode = ""
        CmbSubject.Items.Clear()

        Try
            db.con.Open()
            'db.cmd.CommandText = "select * from Wapapers where PaperCode Like ('" & subj & "%')"
            db.cmd.CommandText = "select * from WSubjNdx where left(PaperCode, 3) = '" & Strings.Left(subj, 3) & "'"
            db.dr = db.cmd.ExecuteReader()

            While db.dr.Read()
                PAP = Mid(db.dr("PaperCode"), 1, 3)
                If PAP = subj Then
                    PaperCode = Trim(db.dr("PaperCode"))
                    'PaperType = Trim(db.dr("PaperType"))

                    'If ((PaperType <> "OBJECTIVE") And (PaperCode <> "302343")) Then
                    '    CmbSubject.Items.Add(db.dr("PaperCode"))
                    'End If

                    If ((Strings.Mid(PaperCode, 5, 1) <> "1") And (PaperCode <> "302343")) Then
                        CmbSubject.Items.Add(String.Concat(db.dr("PaperCode"), " - ", db.dr("SubjName")))
                    End If

                End If
            End While

        Catch ex As Exception
            Console.WriteLine("Error in getPapers: " & ex.Message)
        Finally
            db.con.Close()
        End Try

        If CmbSubject.Items.Count = 1 Then
            CmbSubject.SelectedIndex = 0
        End If

    End Sub
    Sub gETsubjects()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand

        gcon.Open()
        cmd.CommandText = "select * from wapapers"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        CmbSubject.Items.Clear()
        While dr.Read()
            PaperCode = Trim(dr("PaperCode"))
            PaperType = Trim(dr("PaperType"))
            If ((PaperType <> "OBJECTIVE") And (PaperCode <> "302343")) Then
                CmbSubject.Items.Add(dr("PaperCode"))
            End If

        End While

        dr.Close()
        gcon.Close()

    End Sub

    Sub gETIndexes()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        Dim examno, subj As String
        examno = "NA"
        gcon.Open()
        subj = Mid(curuser, 1, 3)
        cmd.CommandText = "select * from ExpandedEntry where CentNo Like ('" & cmbCenter.Text & "%') and SubjCode Like ('" & CmbSubject.Text & "%')and ExaminerNo Like ('" & examno & "%')"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        cbStart.Items.Clear()
        cbStop.Items.Clear()
        While dr.Read()
            cbStop.Items.Add(dr("IndexNo"))
            cbStart.Items.Add(dr("IndexNo"))
        End While

        dr.Close()
        gcon.Close()

    End Sub

    Sub GetExaminer()
        Try
            db.con.Open()

            'Dim examno As String

            'examno = "NA"
            'db.cmd.CommandText = "select * from ExamBiodetails where (mid(ExaminerNo, 5 ,3)) = '" & Strings.Left(curuser, 3) & "';"
            db.cmd.CommandText = "SELECT ExamYear, ExaminerNo, SurName, FirstName, ONames, TadExaminerNo " &
                "FROM ExamBiodetails " &
                "where (mid(ExaminerNo, 5 ,3)) = '" & Strings.Left(curuser, 3) & "' " &
                "ORDER BY ExaminerNo;"

            db.dr = db.cmd.ExecuteReader
            CmbExaminerno.Items.Clear()

            While db.dr.Read()
                ' exno = (dr("ExaminerNo"))
                ' examiner_Allo = Mid(exno, 5, 6)
                'CmbExaminerno.Items.Add(db.dr("ExaminerNo") & " - " & db.dr("FirstName") & Space(1) & db.dr("SurName"))
                CmbExaminerno.Items.Add($"{db.dr("ExaminerNo")} - {db.dr("FirstName")} {db.dr("ONames")} {db.dr("SurName")}")
            End While

        Catch ex As Exception
            Console.WriteLine("Error in GetExaminer(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub

    Sub Allocate()
        con.Open()
        Dim com As New OleDbCommand
        com.Connection = con

        com.CommandText = "UPDATE ExpandedEntry SET ExaminerNo='" + curuser + "'WHERE ExamYear Like ('" & txtExamYear.Text & "%')and CentNo=('" + cmbCenter.Text + "') and IndexNo=('" + currentindex + "') and SubjCode=('" + CmbSubject.Text + "')"
        com.ExecuteNonQuery()
        con.Close()
        'MsgBox("Record Updated")

    End Sub

    Private Sub CmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSubject.SelectedIndexChanged
        getthenumbers()
        If cbStart.Items.Count > 0 Then
            cbStart.SelectedIndex = 0
            cbStop.SelectedIndex = cbStart.Items.Count - 1
            cbStop.SelectAll()
            cbStop.Focus()
        End If
        'GetExaminer()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocate.Click
        If CmbSubject.SelectedIndex = -1 Then
            MsgBox("YOU MUST SELECT A PAPER TO ALLOCATE")
            '  ComboBox4.Focus()
            Exit Sub
        End If

        If CmbExaminerno.SelectedItem = "" Then
            MessageBox.Show("Please select an examiner!", "Select Examiner", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        btnAllocate.Enabled = False

        If MessageBox.Show( _
            "About to start allocation:" & vbNewLine & "" & _
            vbTab & "Start: " & cbStart.Text & vbTab & "Stop: " & cbStop.Text & vbNewLine & _
            "to " & vbNewLine & vbNewLine & Strings.Mid(CmbExaminerno.SelectedItem, 16) & vbNewLine & vbNewLine & _
            "Do you want to continue with the allocation?", "Please confirm", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            'tAllocate = New Threading.Thread(AddressOf AddExpanded)
            'tAllocate.Start()
            '====================================================================================================================================
            'AddExpanded()
            Try
                db.con.Open()
                db.con1.Open()
                db.con2.Open()

                Dim min, max As Integer
                Dim subj As String

                min = CInt(cbStart.Text)
                max = CInt(cbStop.Text)

                pbProgress.Value = 0
                pbProgress.Maximum = CInt(txtTotalAvailable.Text)

                subj = Mid(CmbSubject.Text, 1, 3)
                ExamYear = Now.Year()
                db.cmd.CommandText = "select * from Cand_Subjects where ('" & subj & _
                    "' in (Sub1,Sub2,Sub3,Sub4,Sub5,Sub6,Sub7,Sub8,Sub9)) and (CentNo = '" & Strings.Left(cmbCenter.SelectedItem, 7) & "') AND " & _
                    "(IndexNo >= '" & cbStart.Text & "') AND (IndexNo <= '" & cbStop.Text & "') "

                Try
                    If (Not db.dr.IsClosed) Then
                        db.dr.Close()
                    End If
                Catch ex As Exception

                End Try

                db.dr = db.cmd.ExecuteReader()

                GroupBox1.Text = "Please wait whilst transfer takes place..."

                While db.dr.Read()

                    'If ((CInt(db.dr("IndexNo")) >= min) And (CInt(db.dr("IndexNo")) <= max)) Then
                    If ((db.dr("IndexNo") >= cbStart.Text) And (db.dr("IndexNo") <= cbStop.Text)) Then
                        pbProgress.PerformStep()
                        pbProgress.Refresh()

                        centno = (db.dr("CentNo"))
                        index = (db.dr("IndexNo"))

                        '====================================================================================================================================
                        'CreatePapersForSubjects()
                        Try
                            subjcode = Strings.Left(CmbSubject.Text, 6)
                            db.cmd1.CommandText = "select PaperCode, SubjName as PaperName, PapType as PaperType from Wsubjndx where PaperCode = " & Strings.Left(CmbSubject.Text, 6) & ""

                            Try
                                If (Not db.dr1.IsClosed) Then
                                    db.dr1.Close()
                                End If
                            Catch ex As Exception

                            End Try


                            db.dr1 = db.cmd1.ExecuteReader()

                            alot = 0
                            While (db.dr1.Read())
                                PaperCode = (db.dr1("PaperCode").ToString())
                                PaperType = (db.dr1("PaperType").ToString())
                                Dim eng As String
                                Dim eng2 As String

                                eng2 = "302"

                                eng = Mid(PaperCode, 1, 3)

                                If ((Strings.Mid(PaperCode, 5, 1) <> "1") And (PaperCode <> "302333")) Then
                                    alot += 1
                                    currentindex = index

                                    Try


                                        Dim sqlStatement As String = "Insert into ExpandedEntry(ExamYear,CentNo,IndexNo,SubjCode,ExaminerNo)" _
                                            & " values" _
                                            & "('" & ExamYear & "','" & centno & "','" & db.dr("IndexNo") & "','" & db.dr1("PaperCode") & "','" & _
                                            Trim(Strings.Left(CmbExaminerno.Text, 13)) & "')"

                                        db.cmd2.CommandText = sqlStatement
                                        Dim result As Integer
                                        result = db.cmd2.ExecuteNonQuery()

                                    Catch ex As Exception
                                        MessageBox.Show(index & " cannot be reallocated!")
                                        Console.WriteLine("Error in running sql in CreatePapersForSubjects: " & ex.Message)
                                    Finally

                                    End Try
                                End If
                            End While
                        Catch ex As Exception
                            Console.WriteLine("Error in running sql in CreatePapersForSubjects: " & ex.Message)
                        Finally

                        End Try
                        '====================================================================================================================================
                    End If
                End While
            Catch ex As Exception
                Console.WriteLine("Error in AddExpanded(): " & ex.Message)
            Finally
                db.con.Close()
                db.con1.Close()
                db.con2.Close()
            End Try

            pbProgress.Value = pbProgress.Maximum
            MessageBox.Show("Allocation has been completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'ResetFields()
            CmbSubject.Items.Clear()
            CmbSubject.ResetText()
            cmbCenter.ResetText()
            txtTotalAvailable.Text = ""
            cbStart.ResetText()
            cbStop.ResetText()
            'CmbExaminerno.ResetText()
            pbProgress.Value = 0

        End If

        btnAllocate.Enabled = True
        cmbCenter.DroppedDown = True
    End Sub

    Sub Add_to_transact()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        ' getcenters()
        ExamYear = Now.Year
        cmd.CommandText = "select * from Cand_Subjects "

        cmd.Connection = gcon

        dr = cmd.ExecuteReader

        GroupBox1.Text = "Please wait whilst transfer takes place..."

        Dim i As Integer
        While dr.Read()
            i += 1
            indrange1 = dr("tot_subj")

            If indrange1 = "8" Then

                For i = 1 To 8
                    subjcode = ""

                    If i = 1 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub1"))
                        CreatePapersForSubjects()
                    End If
                    If i = 2 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub2"))
                        CreatePapersForSubjects()
                    End If
                    If i = 3 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub3"))
                        CreatePapersForSubjects()
                    End If
                    If i = 4 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub4"))
                        CreatePapersForSubjects()
                    End If
                    If i = 5 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub5"))
                        CreatePapersForSubjects()
                    End If
                    If i = 6 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub6"))
                        CreatePapersForSubjects()
                    End If
                    If i = 7 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub7"))
                        CreatePapersForSubjects()
                    End If
                    If i = 8 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub8"))
                        CreatePapersForSubjects()
                    End If


                Next

            End If
            If indrange1 = "9" Then
                For i = 1 To 9
                    subjcode = ""


                    If i = 1 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub1"))
                        CreatePapersForSubjects()
                    End If
                    If i = 2 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub2"))
                        CreatePapersForSubjects()
                    End If
                    If i = 3 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub3"))
                        CreatePapersForSubjects()
                    End If
                    If i = 4 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub4"))
                        CreatePapersForSubjects()
                    End If
                    If i = 5 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub5"))
                        CreatePapersForSubjects()
                    End If
                    If i = 6 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub6"))
                        CreatePapersForSubjects()
                    End If
                    If i = 7 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub7"))
                        CreatePapersForSubjects()
                    End If
                    If i = 8 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub8"))
                        CreatePapersForSubjects()
                    End If


                    If i = 9 Then
                        centno = (dr("CentNo"))
                        index = (dr("IndexNo"))
                        subjcode = (dr("Sub9"))
                        CreatePapersForSubjects()
                    End If

                Next

            End If


        End While

        dr.Close()
        gcon.Close()

    End Sub

    Sub CreatePapersForSubjects()
        Dim db2 As New dbConnection3(MDIParent1.connectionString)

        Try
            If CmbSubject.SelectedIndex = -1 Then
                MsgBox("YOU MUST SELECT A PAPER TO ALLOCATE")
                '  ComboBox4.Focus()
                Exit Sub
            End If

            db2.con.Open()

            subjcode = Strings.Left(CmbSubject.Text, 6)
            db2.cmd.CommandText = "select * from Wapapers where PaperCode = '" & Strings.Left(CmbSubject.Text, 6) & "'"

            db2.dr = db2.cmd.ExecuteReader()

            alot = 0
            While (db.dr.Read())
                PaperCode = (db2.dr("PaperCode"))
                PaperType = (db2.dr("PaperType"))
                Dim eng As String
                Dim eng2 As String

                eng2 = "302"

                eng = Mid(PaperCode, 1, 3)
                If ((Strings.Mid(PaperCode, 5, 1) <> "1") And (PaperCode <> "302343")) Then
                    alot += 1
                    currentindex = index

                    Try
                        db.con1.Open()

                        Dim sqlStatement As String = "Insert into ExpandedEntry(ExamYear,CentNo,IndexNo,SubjCode,ExaminerNo)" _
                            & " values" _
                            & "('" & ExamYear & "','" & centno & "','" & index & "','" & PaperCode & "','" & _
                            Trim(Strings.Left(CmbExaminerno.Text, 13)) & "')"

                        db2.cmd1.CommandText = sqlStatement
                        Dim result As Integer
                        result = db2.cmd1.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show(index & " cannot be reallocated!")
                        Console.WriteLine("Error in running sql in CreatePapersForSubjects: " & ex.Message)
                    Finally
                        db2.con1.Close()
                    End Try
                End If
            End While
        Catch ex As Exception
            Console.WriteLine("Error in running sql in CreatePapersForSubjects: " & ex.Message)
        Finally
            db2.dr.Close()
        End Try

    End Sub

    Sub AddExpanded()
        'Control.CheckForIllegalCrossThreadCalls = False

        Try
            db.con.Open()

            Dim min, max As Integer
            Dim subj As String

            min = CInt(cbStart.Text)
            max = CInt(cbStop.Text)
            pbProgress.Value = 0

            pbProgress.Maximum = CInt(txtTotalAvailable.Text)

            subj = Mid(CmbSubject.Text, 1, 3)
            ExamYear = Now.Year()
            db.cmd.CommandText = "select * from Cand_Subjects where ('" & subj & _
                "' in (Sub1,Sub2,Sub3,Sub4,Sub5,Sub6,Sub7,Sub8,Sub9)) and (CentNo = '" & Strings.Left(cmbCenter.SelectedItem, 7) & "') AND " & _
                "(IndexNo >= '" & cbStart.Text & "') AND (IndexNo <= '" & cbStop.Text & "') "

            db.dr = db.cmd.ExecuteReader()

            GroupBox1.Text = "Please wait whilst transfer takes place..."

            While db.dr.Read()

                'If ((CInt(db.dr("IndexNo")) >= min) And (CInt(db.dr("IndexNo")) <= max)) Then
                If ((db.dr("IndexNo") >= cbStart.Text) And (db.dr("IndexNo") <= cbStop.Text)) Then
                    pbProgress.PerformStep()
                    pbProgress.Refresh()

                    centno = (db.dr("CentNo"))
                    index = (db.dr("IndexNo"))
                    CreatePapersForSubjects()

                End If

            End While



        Catch ex As Exception
            Console.WriteLine("Error in AddExpanded(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

        pbProgress.Value = pbProgress.Maximum

    End Sub

    Sub getthenumbers()

        Try
            db.con.Open()

            subjcode = Mid(CmbSubject.Text, 1, 3)
            ExamYear = Now.Year()
            db.cmd.CommandText = "select Distinct IndexNo from Cand_Subjects where('" & subjcode & _
                "' in (Sub1,Sub2,Sub3,Sub4,Sub5,Sub6,Sub7,Sub8,Sub9)) AND (CentNo='" & Strings.Left(cmbCenter.Text, 7) & "')"
            Dim range As Integer = 0

            db.dr = db.cmd.ExecuteReader()

            GroupBox1.Text = "Please wait whilst transfer takes place..."
            cbStart.Items.Clear()
            cbStop.Items.Clear()

            range = 0

            While db.dr.Read()
                range += 1
                index = (db.dr("IndexNo"))
                cbStart.Items.Add(db.dr("IndexNo"))
                cbStop.Items.Add(db.dr("IndexNo"))
            End While

            txtTotalAvailable.Text = range

        Catch ex As Exception
            Console.WriteLine("Error in GetTheNumbers(): " & ex.Message)
        Finally
            db.con.Close()
        End Try

    End Sub

    Private Sub cmbCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCenter.SelectedIndexChanged
        getPapers()
    End Sub

    Private Sub txtExamYear_TextChanged(sender As Object, e As EventArgs) Handles txtExamYear.TextChanged
        lblExamYear.Text = "WASSCE " & txtExamYear.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStop.SelectedIndexChanged
        If CInt(cbStop.Text) < CInt(cbStart.Text) Then
            MsgBox("Invalid range selected")
            cbStop.Focus()

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStart.SelectedIndexChanged
        Try
            If cbStop.SelectedIndex <> -1 Then
                If CInt(cbStop.Text) < CInt(cbStart.Text) Then
                    MsgBox("Invalid range selected")
                    cbStop.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbExaminerno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbExaminerno.SelectedIndexChanged

    End Sub

    Private Sub CmbExaminerno_MouseHover(sender As Object, e As EventArgs) Handles CmbExaminerno.MouseHover
        CmbExaminerno.DroppedDown = True
    End Sub
End Class