
Imports System.Data
'Imports Microsoft.SqlServer.MessageBox
Imports System.IO
Imports System.Data.OleDb

Public Class FrmSubject_Officer
    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                       System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim con As New ConClass
     Dim cmd,cmd1 As New OleDbCommand
    Dim examinno, papcode, suboff, examinerno, examinerpap, gen, gen1 As String
    Dim subjcode, curcentre, examyr, nname, gender, mypap, sCode, currentNo, currentNo1, chief, examinerno_Status As String
    Dim dSet As DataSet

    Sub GetExamYear()
        examyr = Now.Year
        txtexamyr.Text = (examyr)

    End Sub
    Private Sub FrmCreate_Examiner__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetExamYear()
        Marked_Pap()
        getstatus()

    End Sub
    Sub get_officerno()
        Dim result As Integer


        Dim recno As Integer
        Dim cmd As New OleDbCommand
        suboff = CboSubjCode.Text
        Try

            gcon3.Open()
            cmd.CommandText = "Select count (EXAMINERNO) from Subject_Officer where SUBJCODE='" & CboSubjCode.Text & "' and STATUS like '" & CboStatus.Text & "' "
            cmd.Connection = gcon3
            recno = cmd.ExecuteScalar

            getstatuscode()
            If recno = 1 Then ' subject officer is already created.  

                If MessageBox.Show("Do you want to create another Subject Officer for " + suboff, "Creating a Subject Officer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) Then
                    If (result = Windows.Forms.DialogResult.Yes) Then
                        If result = 6 Then
                            recno = recno + 1
                            txtofficer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))
                        ElseIf recno = 2 Then
                            MessageBox.Show(suboff + " Already have two Subject Officers", Me.Text)
                        End If
                        Exit Sub
                        'Else
                        '    recno = recno + 1
                        '    txtofficer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))

                    End If
                End If
            End If
            getstatuscode()
            recno = recno + 1
            txtofficer_no.Text = sCode + CboSubjCode.Text + (Format(recno, "000"))

            gcon3.Close()
        Catch ex As Exception
        Finally
            gcon3.Close()
        End Try
    End Sub

    Sub Marked_Pap()
        'Accessing Papcode from Subjects Table to fill the Papcode depending what paper the examiner is marking
        Dim cmd1, cmd2 As New OleDbCommand
        Try
            gcon.Open()
            cmd1.CommandText = "Select * from SubjectTbl ORDER BY PapCode"

            cmd1.Connection = gcon
            dr = cmd1.ExecuteReader
            While (dr.Read())
                examinerpap = (dr("PapCode"))
                CboSubjCode.Items.Add(dr("PapCode"))
            End While
            dr.Close()
            gcon.Close()
        Catch ex As Exception
            gcon.Close()
        End Try
    End Sub
    Sub Marked_Pap1()
        'Accessing Papcode from Subjects Table to fill the Papcode depending what paper the examiner is marking
        Dim cmd1, cmd2 As New OleDbCommand
        Try
            gcon.Open()
            cmd1.CommandText = "Select * from SubjectTbl where PapCode='" & CboSubjCode.Text & "'"

            cmd1.Connection = gcon
            dr = cmd1.ExecuteReader
            While (dr.Read())
                CboSubjName.Items.Add(dr("SubjName"))
            End While
            dr.Close()
            gcon.Close()
        Catch ex As Exception
            gcon.Close()
        End Try
    End Sub
    Sub Add_SubjOff()

        Try
            USERLEVEL = 2
            If rdbMale.Checked Then
                gender = rdbMale.Text.ToUpper
            Else
                If rdbFemale.Checked Then

                    gender = rdbFemale.Text.ToUpper
                End If

            End If

            'insert into Examiner Detials table
            gcon1.Open()
            Query1 = "Insert into Examiner_Biodts (EXAMYEAR,STATUS,SUBJCODE,EXAMINERNO,OTHERNAME,GENDER)" _
            & "values ('" & txtexamyr.Text & "','" & CboStatus.Text & "','" & CboSubjCode.Text & "','" & txtofficer_no.Text & "'," _
            & "'" & txtoname.Text.ToUpper & "','" & gender & "')"
            cmd.Connection = gcon1
            mCmd1 = New OleDb.OleDbCommand(Query1, gcon1)

            gcon3.Open()
            Query3 = "Insert into Subject_Officer(EXAMYEAR,STATUS,SUBJCODE,EXAMINERNO,OTHERNAME,GENDER)" _
           & "values ('" & txtexamyr.Text & "','" & CboStatus.Text & "','" & CboSubjCode.Text & "','" & txtofficer_no.Text & "'," _
           & "'" & txtoname.Text.ToUpper & "','" & gender & "')"
            cmd.Connection = gcon3
            mCmd3 = New OleDb.OleDbCommand(Query3, gcon3)
            'insert into Login table 

            gcon2.Open()
            Query2 = "Insert into ExaminerLogin_Tbl(USERNAME,EXAMINERNO,EPASSWORD,USERLEVEL)" _
           & "values" _
           & "('" & txtusername.Text & "','" & txtofficer_no.Text & "','" & txtpassword.Text & "','" & CInt(USERLEVEL) & "')"
            cmd.Connection = gcon2
            mCmd2 = New OleDb.OleDbCommand(Query2, gcon2)


            mCmd3.ExecuteNonQuery()
            mCmd2.ExecuteNonQuery()

            MsgBox("Thank you for adding your Record.", MsgBoxStyle.Information, Me.Text)
            gcon3.Close()
            gcon2.Close()
            gcon1.Close()

        Catch ex As Exception

        Finally
            gcon3.Close()
            gcon2.Close()
            gcon1.Close()
        End Try

        ClearForm()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If validateform() = True Then
            Add_SubjOff()
        Else
            If validateform() = False Then

            End If
        End If
        Exit Sub
        ClearForm()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub CboSubjCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubjCode.SelectedIndexChanged
        get_officerno()
        Marked_Pap1()
    End Sub
    Sub getstatuscode()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box

        Dim cmd1 As New OleDbCommand
        Try
            con.OpenConnection()

            cmd1.CommandText = "Select * FROM Status_Tbl where Status='" & CboStatus.Text & "'  "
            cmd1.Connection = con.con
            dr = cmd1.ExecuteReader
            While (dr.Read())
                sCode = dr("Status_Code")
            End While
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
        Finally
            con.CloseConnection()
        End Try

    End Sub
    Sub getstatus()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Dim cmd1, cmd2 As New OleDbCommand
        Dim statusname As String = "SUBJ"
        con.OpenConnection()
        cmd1.CommandText = "Select * FROM Status_Tbl where Status LIKE '" & statusname & "%'  "
        cmd1.Connection = con.con
        dr = cmd1.ExecuteReader
        While (dr.Read())
            CboStatus.Items.Add(dr("Status"))
        End While
        con.CloseConnection()
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        If txtusername.TextLength > 6 Then
            MsgBox("Username cannot be more than 6 characters ", MsgBoxStyle.Information, Me.Text)
            txtusername.Focus()
        End If

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtpassword.TextLength > 6 Then
            MsgBox("Password must be 6 characters ", MsgBoxStyle.Information, Me.Text)
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtoname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) And (Asc(e.KeyChar) = 32) And (Asc(e.KeyChar) = 8) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtoname_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtoname.Text.Length > 25 Then
            MsgBox("Other Names cannot be more than 25 characters.", MsgBoxStyle.Information, Me.Text)
            txtoname.Text = ""
            txtoname.Focus()
        End If
    End Sub
    Public Function validateform() As Boolean

        If CboStatus.Text = "" Then
            MsgBox("Please Select Status.", MsgBoxStyle.Information, Me.Text)
            CboStatus.Focus()
        End If
        If CboSubjCode.Text = "" Then
            MsgBox("Please Select a Subject Code.", MsgBoxStyle.Information, Me.Text)
            CboSubjCode.Focus()
        End If

        If txtusername.Text = "" Then
            MsgBox("Please enter Security Details.", MsgBoxStyle.Information, Me.Text)
            txtusername.Text = ""
            txtusername.Focus()
        End If
        If txtpassword.Text = "" Then
            MsgBox("Please enter Security Details.", MsgBoxStyle.Information, Me.Text)
            txtpassword.Text = ""
            txtpassword.Focus()
        End If
        If txtconfpass.Text = "" Then
            MsgBox("Please enter Security Details.", MsgBoxStyle.Information, Me.Text)
            txtconfpass.Text = ""
            txtconfpass.Focus()
            '  End If
            validateform = False
            Exit Function
            txtoname.Focus()
        Else
            validateform = True
            cmdsave.Enabled = True
        End If

    End Function

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        ClearForm()
    End Sub

    Public Sub ClearForm()

        'clears the form for new candidate entry

        CboStatus.SelectedIndex = -1
        CboSubjCode.SelectedIndex = -1
        txtofficer_no.Text = ""
        txtoname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtconfpass.Text = ""
        rdbFemale.Checked = False
        rdbMale.Checked = False

    End Sub

    Private Sub txtoccup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) = 8) Then ' And (Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtconfpass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtconfpass.Leave
        If txtconfpass.Text <> txtpassword.Text Then
            MsgBox("Please confirm your password.", MsgBoxStyle.Information, Me.Text)
            txtconfpass.Text = ""
            'txtconfpass.Focus()
        End If
    End Sub

    Private Sub CboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboStatus.SelectedIndexChanged

    End Sub
End Class