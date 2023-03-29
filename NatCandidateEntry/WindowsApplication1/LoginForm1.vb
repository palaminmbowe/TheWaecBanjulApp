Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class LoginForm1
    Dim gcon6 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim con As New ConClass
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim exno As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        'Dim dr As OleDbDataReader
        '' Try

        ''Opening our connection

        'gcon6.Open()
        ''Let's see if it has written the correct password or not

        'Dim Oledbcom = ("select * from ExaminerLogin_Tbl where USERNAME= '" & txtUsername.Text & "' and EPASSWORD='" & txtPassword.Text & "'")
        'Dim cmd As New OleDbCommand(Oledbcom, gcon6)

        'cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text)
        'cmd.Parameters.AddWithValue("@EPASSWORD", txtPassword.Text)

        'dr = cmd.ExecuteReader
        'If dr.Read Then
        '    examinerno = dr("EXAMINERNO")
        '    myexaminer = Mid(dr("EXAMINERNO"), 5, 3) 'TAD code e.g. 111,112)
        '    myexaminer1 = Mid(dr("EXAMINERNO"), 5, 6) ' CSD code e.g 111222)
        '    USERLEVEL = dr("USERLEVEL")

        '    If USERLEVEL = 1 Then

        '        'examiner
        '        FrmTassMidForm.Examiner.Visible = True
        '        FrmTassMidForm.EnterMarksToolStripMenuItem1.Visible = True
        '        FrmTassMidForm.ListMarksToolStripMenuItem2.Visible = True
        '        FrmTassMidForm.ToolStripStatusLabel3.Text = "as Examiner"
        '    ElseIf USERLEVEL = 2 Then

        '        'subject officer
        '        FrmTassMidForm.SubjectOfficer.Visible = True
        '        FrmTassMidForm.CreateExaminer.Visible = True
        '        FrmTassMidForm.ModifyExaminerToolStripMenuItem.Visible = True
        '        FrmTassMidForm.ListMarksToolStripMenuItem.Visible = True
        '        FrmTassMidForm.ModifyMarksToolStripMenuItem.Visible = True
        '        FrmTassMidForm.ToolStripStatusLabel3.Text = "as Subject Officer"
        '    ElseIf USERLEVEL = 3 Then

        '        'administrator 

        '        FrmTassMidForm.CreateSubjectOfficerToolStripMenuItem.Visible = True
        '        'FrmTassMidForm.ModifyMarkToolStripMenuItem.Visible = True
        '        '   FrmTassMidForm.BackupDatabaseToolStripMenuItem.Visible = True
        '        FrmTassMidForm.ListMarksToolStripMenuItem1.Visible = True
        '        FrmTassMidForm.UpdateUserLevelsToolStripMenuItem.Visible = True
        '        FrmTassMidForm.ToolStripStatusLabel3.Text = " as System Administrator"
        '    End If

        '    username = txtUsername.Text
        '    Timer1.Enabled = True


        '    Dim mylogin As New LoginForm1
        '    FrmTassMidForm.Administrator.Enabled = True

        '    FrmTassMidForm.LoginToolStripMenuItem.Enabled = False
        '    FrmTassMidForm.LogoutToolStripMenuItem.Enabled = True
        '    FrmTassMidForm.ToolStripStatusLabel2.Text = txtUsername.Text & " logged into System"
        '    Me.Text = username

        'Else
        '    MsgBox("Username or Password Not correct.", MsgBoxStyle.Information, Me.Text)

        'End If
        ''Close the open connection
        'gcon6.Close()
        ''Catch ex As Exception

        ''Finally
        '' dr.Close()
        'gcon6.Close()

        ''End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar2.Value += 20
        If (ProgressBar2.Value = 100) Then
            myusername = txtUsername.Text
            username = txtUsername.Text
            Timer1.Enabled = True
        
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub CmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdReset.Click
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub
    Sub ver()
        Try
            'Accessing the examiner no who just at logging time.
            Dim cmd1, cmd2 As New OleDbCommand
            con.OpenConnection()
            cmd1.CommandText = "Select * FROM ExaminerLogin_Tbl where USERNAME='" & txtUsername.Text & "' and EPASSWORD='" & txtPassword.Text & "'"
            cmd1.Connection = con.con
            dr = cmd1.ExecuteReader

            While (dr.Read)
                exno = dr("EXAMINERNO")

            End While
            con.CloseConnection()
        Catch ex As Exception
        Finally
        End Try

    End Sub

   
End Class
