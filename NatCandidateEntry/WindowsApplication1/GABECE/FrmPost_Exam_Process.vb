
Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.Data.OleDb
'Imports System.windows.forms jitDebugging="true" 


Public Class FrmPost_Exam_Process


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

    Dim da As OleDbDataAdapter
    Dim dr, dr1, dr2, dr3, dr4 As OleDbDataReader
    Dim mCmd1, mCmd, cmd, mCmd2, mCmd3, mCmd4, mCmd5 As New OleDbCommand
    Dim mQuery, mQuery1, mQuery2, mQuery3, mQuery4, mQuery5, noofsubs As String
    Dim totcand, reg As Integer
    Dim subjcode, curcentre, nname, schcode, rectype, opcode, idno, lname, fname, unused, description, s1, s2, s3, s4, s5, s6, s7, s8, s9 As String
    Dim schchoice, othername, canName, gender, dob, subj1, subj2, subj3, subj4, subj5, subj6, subj7, subj8, subj9 As String
    Dim ds As New DataSet
    Dim CentName As String
    Dim he As String
    Dim art As Integer
    Dim regs As Integer

    Sub insertinto_SubjectEntry()

        ' Try
        gcon1.Open()
        gcon.Open()
        mCmd1.CommandText = "Select * from PaperDetails where PapCodeTAD1='" & subjcode & "'  "
        mCmd1.Connection = gcon1
        dr = mCmd1.ExecuteReader


        ' While dr.Read
        If dr.Read Then
            papcode = dr("PapCodeTAD1")
            'sample code for expansion of entry file.
            mQuery = "Insert into Subject_Entry_By_Cand1(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE)" _
                              & " values" _
                              & "('" & ExamYear & "','" & centno & "','" & index & "','" & papcode & "')"
            mCmd = New OleDb.OleDbCommand(mQuery, gcon)
            mCmd.ExecuteNonQuery()
        End If
        'End If
        'End While

        dr.Close()
        mCmd1.ExecuteNonQuery()
        ' Catch ex As Exception
        ' Finally
        gcon1.Close()
        gcon.Close()
        ' End Try

    End Sub
    Sub Add_to_SubjEntry() ' creates a each candidate subject entry.  Table to use to create Marks Index file.
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place... KEEP OFF"
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim i As Integer
        ' Try
        gcon6.Open()

        cmd.CommandText = "select * from GBB02OUT where EXAMYEAR like '" & CboExamYear.Text & "%'"
        cmd.Connection = gcon6
        dr = cmd.ExecuteReader

        While dr.Read()

            i += 1
            indrange1 = dr("NOOFSUBS")

            If indrange1 = "7" Then

                For i = 1 To 7
                    subjcode = ""

                    If i = 1 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ1"))
                        insertinto_SubjectEntry()

                    End If

                    If i = 2 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ2"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 3 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ3"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 4 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ4"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 5 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ5"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 6 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ6"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 7 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ7"))
                        insertinto_SubjectEntry()

                    End If
                Next
            End If

            If indrange1 = "8" Then

                For i = 1 To 8
                    subjcode = ""

                    If i = 1 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ1"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 2 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ2"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 3 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ3"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 4 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ4"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 5 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ5"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 6 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ6"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 7 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ7"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 8 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        'subjcode = (dr("SUBJ8"))
                        subjcode = FixNull1(dr("SUBJ8"))
                        insertinto_SubjectEntry()

                    End If
                Next
            End If

            If indrange1 = "9" Then
                For i = 1 To 9
                    subjcode = ""

                    If i = 1 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ1"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 2 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ2"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 3 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ3"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 4 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ4"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 5 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ5"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 6 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ6"))
                        insertinto_SubjectEntry()

                    End If
                    If i = 7 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        subjcode = (dr("SUBJ7"))
                        insertinto_SubjectEntry()
                    End If
                    If i = 8 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        'subjcode = (dr("SUBJ8"))
                        subjcode = FixNull1(dr("SUBJ8"))
                        insertinto_SubjectEntry()

                    End If

                    If i = 9 Then
                        ExamYear = (dr("EXAMYEAR"))
                        centno = (dr("CENTCODE"))
                        index = (dr("INDEXNO"))
                        'subjcode = (dr("SUBJ9"))
                        subjcode = FixNull1(dr("SUBJ9"))
                        insertinto_SubjectEntry()

                    End If
                Next

            End If

        End While
        dr.Close()
        MsgBox("Finished")
        ' Catch ex As Exception
        'Finally
        gcon6.Close()
        'End Try
    End Sub
    Public Function FixNull(ByVal s8) As String
        If s8 Is DBNull.Value Then
            Return ""
        Else
            'NOTE: This will cast value to string if
            'it isn't a string.

            Return s8.ToString
        End If
    End Function

    Public Function FixNull1(ByVal s9) As String
        If s9 Is DBNull.Value Then
            Return ""
        Else
            'NOTE: This will cast value to string if
            'it isn't a string.

            Return s9.ToString
        End If
    End Function

    Sub ClearSubject_Entry_By_Cand()

        gcon1.Open()
        cmd.CommandText = "Delete * from Subject_Entry_By_Cand where EXAMYEAR like '" & CboExamYear.Text & "%' and CENTCODE like '" & CboCentCode.Text & "%'" ' and IndexNo like '" & CandNum & "%' "
        cmd.Connection = gcon1
        cmd.ExecuteNonQuery()
        gcon1.Close()
    End Sub
    Sub ClearGBB02OUT()

        gcon1.Open()
        cmd.CommandText = "Delete * from GBB02OUT" 'where EXAMYEAR like '" & CboExamYear.Text & "%' and CENTCODE like '" & CboCentCode.Text & "%'"
        cmd.Connection = gcon1
        cmd.ExecuteNonQuery()
        gcon1.Close()
    End Sub

    Sub GetExamYear()

        examyr = Now.Year
        CboExamYear.Text = (examyr)

        'Dim dr As OleDbDataReader
        'Dim cmd As New OleDbCommand
        'gcon.Open()
        'cmd.CommandText = "select * from ExamDetails"
        'cmd.Connection = gcon

        'dr = cmd.ExecuteReader
        'While dr.Read
        '    ExamYear = dr("EXAMYEAR")
        '    CboExamYear.Items.Add(dr("EXAMYEAR"))
        'End While

        'dr.Close()
        'gcon.Close()

    End Sub
    Sub centers()
        gcon2.Open()
        ' Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from CentreTbl "
        cmd.Connection = gcon2
        dr = cmd.ExecuteReader
        While dr.Read
            centre = dr("CENTCODE")
            CboCentCode.Items.Add(dr("CENTCODE"))
        End While

        dr.Close()
        gcon2.Close()

    End Sub
    Private Sub FrmCreateCanEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetExamYear()
        centers()
    End Sub
    Sub CandDetails()
        gcon2.Open()
        ' Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "select * from CandDetails where EXAMYEAR like '" & CboExamYear.Text & "%' and CENTCODE like '" & CboCentCode.Text & "%'" ' and IndexNo like '" & CandNum & "%' "
        cmd.Connection = gcon2
        dr = cmd.ExecuteReader
        While dr.Read
            schcode = dr("CENTCODE")
            idno = dr("INDEXNO")
            lname = dr("LNAME")
            fname = dr("FNAME")
            othername = dr("OTHERNAME")
            gender = dr("SEX")
            dob = dr("DOB")
            schchoice = dr("SCHCODE")

        End While

        dr.Close()
        gcon2.Close()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClearGBB02OUT()
        Add_to_EntryFle()
    End Sub
    Sub Add_to_EntryFle() 'combine Candidate Details and Candsubjects into Candsubject Table.
        'Try
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."
        Dim dr, dr1 As OleDbDataReader
        Dim cmd As New OleDbCommand
        rectype = "40"
        opcode = "01"
        unused = "  "

        gcon.Open()
        gcon6.Open()
        gcon1.Open()
        gcon3.Open()

        cmd.CommandText = "select * from CandDetails where EXAMYEAR like '" & CboExamYear.Text & "%'" ' and CENTCODE like '" & CboCentCode.Text & "%'"
        cmd.Connection = gcon1
        dr = cmd.ExecuteReader
        While dr.Read
            ExamYear = (dr("EXAMYEAR"))
            centno = (dr("CENTCODE"))
            index = (dr("INDEXNO"))

            mCmd.CommandText = "select * from CandDetails where EXAMYEAR like '" & ExamYear & "%' and CENTCODE like '" & centno & "%' and INDEXNO like '" & index & "%'"
            mCmd.Connection = gcon
            dr1 = mCmd.ExecuteReader
            While dr1.Read()

                lname = (dr1("LNAME"))
                fname = (dr1("FNAME"))
                othername = (dr1("OTHERNAME"))
                gender = (dr1("SEX"))
                schchoice = (dr1("SCHCODE"))
                dob = (dr1("DOB"))
                canName = (lname & " " & fname & " " & othername)


                mCmd1.CommandText = "select * from CandSubject where EXAMYEAR like '" & ExamYear & "%' and CENTCODE like '" & centno & "%' and INDEXNO like '" & index & "%'"
                mCmd1.Connection = gcon3
                dr3 = mCmd1.ExecuteReader
                While dr3.Read()

                    s1 = (dr3("SUBJ1"))
                    s2 = (dr3("SUBJ2"))
                    s3 = (dr3("SUBJ3"))
                    s4 = (dr3("SUBJ4"))
                    s5 = (dr3("SUBJ5"))
                    s6 = (dr3("SUBJ6"))
                    s7 = (dr3("SUBJ7"))

                    s8 = FixNull(dr3("SUBJ8"))

                    s9 = FixNull1(dr3("SUBJ9"))

                    noofsubs = (dr3("NOOFSUBJS"))

                    mQuery = "insert into GBB02OUT(RECTYPE,CENTCODE,INDEXNO,CANDNAME,SEX,DOB,SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9,NOOFSUBJS,CHOICE,UNUSED)" _
                    & "Values" _
                    & "('" & rectype & "','" & centno & "'," _
                    & "'" & index & "','" & canName & "','" & gender & "','" & dob & "','" & s1 & "','" & s2 & "'," _
                    & "'" & s3 & "','" & s4 & "','" & s5 & "','" & s6 & "','" & s7 & "','" & s8 & "','" & s9 & "'," _
                    & "'" & noofsubs & "','" & schchoice & "','" & unused & "')"

                    mCmd = New OleDb.OleDbCommand(mQuery, gcon6)
                    mCmd.ExecuteNonQuery()

                End While
                dr3.Close()
            End While
            dr1.Close()
        End While


        ' Catch ex As Exception
        gcon1.Close()
        gcon6.Close()
        gcon3.Close()
        MsgBox("Finished")
        'Finally

        'End Try

    End Sub

    Public Function IsDBNull(ByVal dbvalue) As Boolean
        Return dbvalue Is DBNull.Value
    End Function

    Sub ClearFemaleCand()

        gcon1.Open()
        cmd.CommandText = "Delete * from Female_Cand_Entry where EXAMYEAR like '" & CboExamYear.Text & "%' and CENTCODE like '" & CboCentCode.Text & "%'"
        cmd.Connection = gcon1
        cmd.ExecuteNonQuery()
        gcon1.Close()
    End Sub

    Sub Create_Female_Cands() ' Update all Female candidates into Female Candidates Table


        'Try
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."
        ' Dim dr, dr1, dr4 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim cmd5 As New OleDbCommand
        Dim cmd1 As New OleDbCommand

        gcon5.Open()
        gcon1.Open()
        gcon.Open()
        cmd.CommandText = "select * from GBB02OUT where EXAMYEAR = '" & CboExamYear.Text & "' and  ('" & cboSubjects.Text & "') in (SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9)"
        cmd.Connection = gcon1
        dr1 = cmd.ExecuteReader
        While dr1.Read
            ExamYear = (dr1("EXAMYEAR"))
            centno = (dr1("CENTCODE"))
            regs = Mid(centno, 2, 1)
            index = (dr1("INDEXNO"))
            gender = (dr1("SEX"))

            reg = CInt(regs)
            If gender = 2 And reg > 2 Then

                mQuery1 = "insert into Female_Cand_Entry (EXAMYEAR,CENTCODE,INDEXNO,SEX,PRACTSUB) values('" & ExamYear & "','" & centno & "','" & index & "','" & gender & "','" & cboSubjects.Text & "')"
                'mQuery1 = "update Female_Cand_Entry set EXAMYEAR='" & ExamYear & "',CENTCODE='" & centno & "',INDEXNO='" & index & "',SEX='" & gender & "',=Where  (CENTCODE='" & centno & "')and (INDEXNO='" & index & "') and(ARTS='" & art & "')"
                mCmd1 = New OleDb.OleDbCommand(mQuery1, gcon5)
                mCmd1.ExecuteNonQuery()
            End If
        End While
        dr1.Close()

       

        ' Catch ex As Exception
        MsgBox("Finished")
        'Finally
        gcon1.Close()
        gcon.Close()
        gcon2.Close()
        gcon5.Close()
        'gcon6.Close()
        'End Try



    End Sub
    Sub countsubjects()

        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."
        Dim dr1 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim cmd5 As New OleDbCommand
        Dim cmd1 As New OleDbCommand
        Dim cmd6 As New OleDbCommand


        gcon3.Open()
        gcon6.Open()
        gcon1.Open()
        gcon2.Open()

        cmd.CommandText = "select * from Female_Cand_Entry where EXAMYEAR = '" & CboExamYear.Text & "' and  PRACTSUB='" & cboSubjects.Text & "'"
        cmd.Connection = gcon1
        dr1 = cmd.ExecuteReader
        If dr1.Read Then
            'While dr1.Read()
            centno = dr1("CENTCODE")
        End If

        mCmd5.CommandText = "select * from CentreTbl where  Centcode = '" & centno & "'"
        mCmd5.Connection = gcon2

        dr = mCmd5.ExecuteReader

        While (dr.Read())
            CentName = dr("CentName")

            cmd1.CommandText = "select count (*) from Female_Cand_Entry where CENTCODE='" & centno & "'and PRACTSUB='" & cboSubjects.Text & "'"
            cmd1.Connection = gcon6
            totcand = cmd1.ExecuteScalar()
            Display()


            mQuery2 = "Insert into Girl_Prov_Fund(CENTCODE,CENTNAME,ARTS,HECONOMICS) values('" & centno & "','" & CentName & "','" & art & "','" & he & "')"
            mCmd2 = New OleDb.OleDbCommand(mQuery2, gcon2)
            mCmd2.ExecuteNonQuery()
        End While
        'dr1.Close()

        'End While




        ' Catch ex As Exception
        MsgBox("Finished")
        'Finally
        gcon1.Close()
        gcon.Close()
        gcon2.Close()
        gcon5.Close()
        gcon6.Close()
        'End Try



    End Sub

    Sub Create_male_Cands() ' Update all Female candidates into Female Candidates Table
        Try
            Lmesg.Visible = True
            Lmesg.Text = "Please wait whilst transfer takes place..."
            Dim dr, dr1 As OleDbDataReader
            Dim cmd As New OleDbCommand
            Dim sex As String = "1"

            CandDetails()
            gcon.Open()
            gcon1.Open()
            cmd.CommandText = "select * from CandDetails where EXAMYEAR like '" & CboExamYear.Text & "%'"
            cmd.Connection = gcon1
            dr1 = cmd.ExecuteReader
            While dr1.Read
                ExamYear = (dr1("EXAMYEAR"))
                centno = (dr1("CENTCODE"))
                index = (dr1("INDEXNO"))

                cmd.CommandText = "select * from CandDetails where EXAMYEAR like '" & ExamYear & "%' " _
                & "and CENTCODE like '" & centno & "%' and INDEXNO like '" & index & "%' and SEX like '" & sex & "%'"
                cmd.Connection = gcon
                dr = cmd.ExecuteReader
                While dr.Read()
                    gender = (dr("SEX"))
                    mQuery = "Update Male_ Cand_ Entry set SEX= '" & gender & "'" _
                    & " Where ((EXAMYEAR='" & CboExamYear.Text & "')and (CENTCODE='" & centno & "') and(INDEXNO='" & index & "'))"

                    mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                    mCmd.ExecuteNonQuery()

                End While
                dr.Close()
            End While
            dr1.Close()
        Catch ex As Exception

            MsgBox("Finished")
        Finally
            gcon1.Close()
            gcon.Close()
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClearSubject_Entry_By_Cand()
        Add_to_SubjEntry()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'ClearFemaleCand()
        Create_Female_Cands()
    End Sub
    Sub changecode()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        gcon4.Open()

        cmd.CommandText = "select * from Pract_Subjects where PractSubs like '" & subjcode & "%'"
        cmd.Connection = gcon4

        dr = cmd.ExecuteReader
        While dr.Read
            description = dr("SubName")
        End While
        dr.Close()
        gcon4.Close()
    End Sub
    Sub getsubjects()

        Dim cmd As New OleDb.OleDbCommand
        Try
            gcon7.Open()
            cmd.CommandText = "select * from Pract_Subjects "
            cmd.Connection = gcon7
            dr = cmd.ExecuteReader

            While dr.Read
                subjcode = dr("PractSubs")
                description = dr("SubName")

            End While

            dr.Close()
        Catch ex As Exception
            gcon7.Close()
        Finally

        End Try

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        getsubjects()
    End Sub
    Sub Display()

        If subjcode = "311" Then
            he = totcand
        End If

        If subjcode = "312" Then
            art = totcand
        End If
    End Sub
    Sub getregions()
        Dim sex As String = "2"
        Dim cmd1 As New OleDbCommand
        Lmesg.Visible = True
        Lmesg.Text = "Please wait whilst transfer takes place..."
        'Try
        gcon2.Open()
        gcon.Open()
        gcon1.Open()
        gcon5.Open()
        cmd.CommandText = "select * from CentreTbl where CENTCODE LIKE'" & CboCentCode.Text & "%'"
        cmd.Connection = gcon2
        dr1 = cmd.ExecuteReader

        While dr1.Read()
            centcode = dr1("Centcode")
            reg = Mid(centcode, 2, 1)
            CentName = dr1("CentName")

            If reg > 2 Then


                'cmd1.CommandText = "select * from Pract_Subjects "
                'cmd1.Connection = gcon1
                'dr2 = cmd1.ExecuteReader

                'While dr2.Read
                '    subjcode = dr2("PractSubs")
                '    description = dr2("SubName")

                If cboSubjects.Text = "312" Then

                    mQuery = "select Count(*)from Female_Cand_Entry where  CENTCODE like('" & centcode & "%') and PRACTSUB = '" & cboSubjects.Text & "'"
                    cmd = New OleDb.OleDbCommand(mQuery, gcon)
                    totcand = cmd.ExecuteScalar()
                    'Display()
                    art = totcand

                    mQuery1 = "update Girl_Prov_Fund set ARTS='" & art & "' where CENTCODE like('" & centcode & "%')"
                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gcon5)
                    mCmd1.ExecuteNonQuery()

                ElseIf cboSubjects.Text = "311" Then



                    mQuery = "select Count(*)from Female_Cand_Entry where  CENTCODE Like ('" & centcode & "%') and PRACTSUB = '" & cboSubjects.Text & "'"
                    cmd = New OleDb.OleDbCommand(mQuery, gcon)
                    totcand = cmd.ExecuteScalar()
                    he = totcand
                    'Display()
                    'End While

                    'mQuery1 = "Insert into Girl_Prov_Fund(CENTCODE,CENTNAME,HECONOMICS)" _
                    '                              & " values" _
                    '                              & "('" & centcode & "','" & CentName & "','" & he & "')"
                    'mCmd1 = New OleDb.OleDbCommand(mQuery1, gcon5)

                    'mCmd1.ExecuteNonQuery()
                End If
            End If
        End While
        ' End While
        dr1.Close()
        ' Catch ex As Exception

        MsgBox("Finished")
        'Finally
        gcon1.Close()
        gcon.Close()
        gcon2.Close()
        gcon5.Close()
        'End Try

    End Sub
    Sub ClearGirl_Prov_Fund()

        gcon6.Open()
        cmd.CommandText = "Delete * from Girl_Prov_Fund"
        cmd.Connection = gcon6
        cmd.ExecuteNonQuery()
        gcon6.Close()
    End Sub
    Private Sub Regional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regional.Click
        ' ClearGirl_Prov_Fund()
        'countsubjects()
        getregions()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        insertinto_SubjectEntry()
    End Sub
End Class