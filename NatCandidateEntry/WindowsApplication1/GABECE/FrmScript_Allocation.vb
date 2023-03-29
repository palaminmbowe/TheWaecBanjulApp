Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.IO
Imports System.Data.OleDb

Public Class FrmScript_Allocation
    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                       System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim subjcode, curcentre, nname, examinerpap, examinerpap1, examScript, centcode1, fname, lname As String
    Dim totcandid, range, min, max, Cuindex As Integer
    Dim mCmd1, mCmd2, cmd As New OleDbCommand
    Dim alot As Integer = 0
    Private Sub FrmScript_Allocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetExamYear()
        Marked_Pap()
        getCentres()
    End Sub
    Sub GetExamYear()
        examyr = Now.Year
        txtexamyr.Text = (examyr)

    End Sub
    Sub getexaminerno()
        ''Accessing Papcode from Subjects Table to fill the Papcode depending what paper the examiner is marking
        Dim cmd1, cmd2 As New OleDbCommand

        ' Try
        gcon1.Open()
        cmd1.CommandText = "Select * from Examiner_Biodts where SUBJCODE like '" & myexaminer & "%' "
        cmd1.Connection = gcon1
        dr = cmd1.ExecuteReader

        While (dr.Read())
            examinerno = dr("EXAMINERNO")
            ' CboExaminerNo.Items.Add(dr("EXAMINERNO"))
            fname = dr("FIRSTNAME")
            lname = dr("LASTNAME")
            cboExaminerStatus.Items.Add(fname & " " & lname)
            CboExaminerNo.Items.Add(examinerno)
        End While
        dr.Close()
        gcon1.Close()
        'Catch ex As Exception
        'Finally
        gcon1.Close()
        'End Try

    End Sub
    Sub Marked_Pap()

        ''Accessing Papcode from Subjects Table to fill the Papcode depending what paper the examiner is marking
        Dim cmd1, cmd2 As New OleDbCommand

        Try

            cboSubjCode.Items.Clear()
            gcon.Open()
            cmd1.CommandText = "Select * from PaperDetails where PapCodeCSD like '" & myexaminer & "%'"
            cmd1.Connection = gcon
            dr = cmd1.ExecuteReader
            '
            While dr.Read
                'If dr.Read Then
                examinerpap = (Mid(dr("PapCodeCSD"), 5, 1))
                examinerpap1 = (Mid(dr("PapCodeCSD"), 1, 3))

                If examinerpap1 = myexaminer Then
                    If examinerpap <> 1 Then

                        cboSubjCode.Items.Add(dr("PapCodeCSD"))
                    End If
                End If
                'End If
            End While
            dr.Close()
            gcon.Close()
        Catch ex As Exception
        Finally
            gcon.Close()
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Me.Close()
    End Sub

    Private Sub getCentres()
        'getting Centers for each selected subject

        Dim cent As String
        cent = "7"
        Try

            Dim cmd As New OleDbCommand
            gcon1.Open()
            cmd.CommandText = "Select DISTINCT CENTCODE From CentreTbl where CENTCODE like'" & cent & "%' ORDER BY CENTCODE"

            cmd.Connection = gcon1
            dr = cmd.ExecuteReader
            While (dr.Read)
                cboCentCode.Items.Add(dr("CENTCODE"))
            End While
            dr.Close()
            gcon1.Close()
        Catch ex As Exception
            dr.Close()
            gcon1.Close()
        Finally
        End Try

    End Sub

    Sub searchcanno()
        Try

            cboRange1.Items.Clear()
            CboRange2.Items.Clear()

            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand

            examScript = Mid(myexaminer1, 1, 3)
            gcon1.Open()

            cmd.CommandText = "select * from GBB02OUT where  CENTCODE ='" & cboCentCode.Text & "' and ('" & examScript & "')in(SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9) ORDER BY INDEXNO"
            cmd.Connection = gcon1
            dr = cmd.ExecuteReader

            range = 0
            While dr.Read()
                range += 1
                index = (dr("INDEXNO"))
                cboRange1.Items.Add(dr("INDEXNO"))
                CboRange2.Items.Add(dr("INDEXNO"))

            End While
            TextBox1.Text = range
            If dr.Read Then
            Else
                MsgBox("Centre " + cboCentCode.Text + " did not register candidates for " + myexaminer1, Me.Text)
            End If

            dr.Close()
            gcon1.Close()
        Catch ex As Exception

        Finally
            gcon1.Close()
        End Try

    End Sub

    Private Sub cboCentCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentCode.SelectedIndexChanged
        searchcanno()

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        MsgBox("Start")
        AddExpanded()
        MsgBox("Finish")


    End Sub

    Sub getexaminer_status()
        Try
            Dim cmd As New OleDbCommand
            gcon1.Open()

            cmd.CommandText = "Select * from Examiner_Biodts where EXAMINERNO='" & CboExaminerNo.Text & "'"
            cmd.Connection = gcon1
            dr = cmd.ExecuteReader
            While (dr.Read)
                fname = dr("FirstName")
                lname = dr("SurName")

                cboExaminerStatus.Items.Add(fname & " " & lname)
            End While
            dr.Close()
            gcon1.Close()
        Catch ex As Exception

        Finally
            dr.Close()
            gcon1.Close()
        End Try

    End Sub

    Private Sub cboSubjCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubjCode.SelectedIndexChanged
        getthenumbers()
        getexaminerno()
    End Sub

    Sub CreatePapersForSubjects()
        Try
            If CboExaminerNo.SelectedIndex = -1 Then
                MsgBox("YOU MUST SELECT EXAMINER TO ALLOCATE PAPERS TO")
                CboExaminerNo.Focus()
                Exit Sub

            End If

            If cboExaminerStatus.SelectedIndex = -1 Then
                MsgBox("YOU MUST SELECT A PAPER TO ALLOCATE")
                cboExaminerStatus.Focus()
                Exit Sub

            End If

            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand

            min = CInt(cboRange1.Text)
            max = CInt(CboRange2.Text)
            examinerpap = CboExaminerNo.Text
            centcode1 = cboCentCode.Text

            gcon2.Open()
            gcon1.Open()

            '            mCmd1.CommandText = "Select * from PaperDetails where PapCodeTAD1='" & myexaminer & "'"
            mCmd1.CommandText = "Select * from PaperDetails where PapCodeCSD='" & cboSubjCode.Text & "'"

            mCmd1.Connection = gcon1
            dr = mCmd1.ExecuteReader
            alot = 0
            While dr.Read()
                papcode = dr("PapCodeCsd")
                'papcode1 = Mid(papcode, 1, 3)
                'papcode2 = Mid(papcode, 5, 1)
                'If papcode2 > 1 Then
                alot += 1
                currentindex = index
                Query1 = "Insert into Subject_Entry_By_Cand(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE,EXAMINERNO)" _
                  & " values" _
                   & "('" & ExamYear & "','" & centno & "','" & index & "','" & cboSubjCode.Text & "','" & CboExaminerNo.Text & "')"
                cmd = New OleDb.OleDbCommand(Query1, gcon2)
                cmd.ExecuteNonQuery()
                'End If
            End While

            dr.Close()
            gcon2.Close()
            gcon1.Close()
        Catch ex As Exception
            'MessageBox.Show(currentindex & " cannot be reallocated")
        Finally
            dr.Close()
            gcon2.Close()
            gcon1.Close()

        End Try

    End Sub
    Sub AddExpanded()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim min, max As Integer
        Dim subj As String
        min = CInt(cboRange1.Text)
        max = CInt(CboRange2.Text)

        gcon.Open()
        subj = Mid(cboSubjCode.Text, 1, 3)
        ExamYear = Now.Year
        cmd.CommandText = "select * from GBB02OUT where  '" & subj & "' in (SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9) and CENTCODE='" & cboCentCode.Text & "'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader

        'GroupBox1.Text = "Please wait whilst transfer takes place..."
        While dr.Read()

            If CInt(dr("INDEXNO")) >= min And CInt(dr("INDEXNO")) <= max Then
                centno = (dr("CENTCODE"))
                index = (dr("INDEXNO"))
                CreatePapersForSubjects()
            End If

        End While

        dr.Close()
        gcon.Close()

    End Sub

    Sub getthenumbers()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        subjcode = Mid(cboSubjCode.Text, 1, 3)
        ExamYear = Now.Year
        cmd.CommandText = "select Distinct(INDEXNO) from GBB02OUT where  '" & subjcode & "' in (SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9) and CENTCODE='" & cboCentCode.Text & "'"
        Dim range As Integer = 0

        cmd.Connection = gcon

        dr = cmd.ExecuteReader

        ' GroupBox1.Text = "Please wait whilst transfer takes place..."
        cboRange1.Items.Clear()
        CboRange2.Items.Clear()
        range = 0
        While dr.Read()
            range += 1
            cboRange1.Items.Add(dr("INDEXNO"))
            CboRange2.Items.Add(dr("INDEXNO"))
        End While
        TextBox1.Text = range
        dr.Close()
        gcon.Close()

    End Sub

End Class