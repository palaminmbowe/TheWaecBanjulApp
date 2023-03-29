Imports System.Data
Imports System.Data.OleDb

Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Dim dr2 As OleDb.OleDbDataReader
        'Dim cmd As New OleDb.OleDbCommand

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            OK.Enabled = False
            Exit Sub
        End If

        If (MDIParent1.serverFile.Exists) Then
            Console.WriteLine("Server File exists!")
            If (MDIParent1.localFile.Exists) Then
                Console.WriteLine("Local File exists!")
            End If
        End If

        Dim CUserId As String
        Dim db As New dbConnection3(MDIParent1.connectionString)
        Dim tadExaminerNumber As String

        'retrieve TADExaminerNumber
        Try
            'gcon.Open()
            db.con.Open()
            'db.cmd.CommandText = "select * from MyUsers where CUserId = '" & UsernameTextBox.Text & "' AND CPassword='" & PasswordTextBox.Text & "'"



            'Select  MyUsers.CUserId, MyUsers.CPassword, MyUsers.ExaminerNo, MyUsers.UserLevel, ExamBiodetails.TadExaminerNo
            'From MyUsers INNER Join ExamBiodetails On MyUsers.ExaminerNo = ExamBiodetails.ExaminerNo
            'Where (((MyUsers.CUserId) = "XXX"))
            'Group By MyUsers.CUserId, MyUsers.CPassword, MyUsers.ExaminerNo, MyUsers.UserLevel, ExamBiodetails.TadExaminerNo;

            db.cmd.CommandText = "select MyUsers.CUserId, MyUsers.CPassword, MyUsers.ExaminerNo, MyUsers.UserLevel, ExamBiodetails.TadExaminerNo from MyUsers  INNER Join ExamBiodetails On MyUsers.ExaminerNo = ExamBiodetails.ExaminerNo " &
                "where MyUsers.CUserId = '" & UsernameTextBox.Text & "' AND CPassword='" & PasswordTextBox.Text & "'"
            'cmd.Connection = gcon
            db.dr = db.cmd.ExecuteReader()

            If db.dr.Read Then
                curuser = db.dr("ExaminerNo")
                curuser1 = Mid(curuser, 1, 5)
                ' MDIParent1.C_E_REPORTToolStripMenuItem.Visible = True
                USERLEVEL = db.dr("UserLevel")
                CUserId = db.dr("CUserId")
                tadExaminerNumber = db.dr("TadExaminerNo")
                MDIParent1.currentTADExaminerNo = tadExaminerNumber
                MDIParent1.currentGeneralSubjectCode = tadExaminerNumber.Substring(0, 3)

                If USERLEVEL = 3 Then
                    'ADMINISTRATORS
                    MDIParent1.EXAMINERToolStripMenuItem.Visible = True
                    MDIParent1.MARKSToolStripMenuItem.Visible = True
                    MDIParent1.SubjectToolStripMenuItem.Visible = True
                    MDIParent1.ToolStripStatusLabel2.Text = " as System Administrator"

                ElseIf USERLEVEL = 2 Then
                    'SUBJECT OFFICERS
                    MDIParent1.ModifyMarksToolStripMenuItem.Visible = True
                    MDIParent1.EXAMINERToolStripMenuItem.Visible = True
                    MDIParent1.QUERIESToolStripMenuItem.Visible = True
                    MDIParent1.MARKSToolStripMenuItem.Visible = True
                    MDIParent1.MARKSToolStripMenuItem.Enabled = True
                    MDIParent1.AddMarksToolStripMenuItem.Visible = False
                    MDIParent1.AllOCATEPAToolStripMenuItem.Visible = True
                    MDIParent1.ToolStripStatusLabel2.Text = " as Subject Officer"
                ElseIf USERLEVEL = 1 Then
                    'EXAMINERS
                    MDIParent1.MARKSToolStripMenuItem.Visible = True
                    MDIParent1.MARKSToolStripMenuItem.Enabled = True
                    MDIParent1.AddMarksToolStripMenuItem.Visible = True
                    MDIParent1.ToolStripStatusLabel2.Text = $" as Examiner: {tadExaminerNumber}"

                End If

                Select Case MDIParent1.connectedToServer
                    Case True
                        MDIParent1.tsslConnection.Text = "Server"
                    Case False
                        MDIParent1.tsslConnection.Text = "Local"
                    Case Else
                        MDIParent1.tsslConnection.Text = "Connection Failed"
                End Select

                Dim mylogin As New LoginForm1

                MDIParent1.ADMINISTRATIONToolStripMenuItem.Enabled = True

                MDIParent1.LoginToolStripMenuItem.Enabled = False
                MDIParent1.LogoutToolStripMenuItem.Enabled = True
                MDIParent1.ToolStripStatusLabel1.Text = UsernameTextBox.Text & " logged into System"
                MDIParent1.ExitToolStripMenuItem.Enabled = False
                Me.Text = curuser
                Me.Close()
            Else
                MsgBox("Username/Password not correct")
                'UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                PasswordTextBox.Focus()
            End If

        Catch ex As Exception
            Console.WriteLine("Error in LoginForm1: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbConnectToServer.Checked = True
    End Sub

    Private Sub SetDbPath(sender As System.Object, e As System.EventArgs) Handles rbConnectToServer.CheckedChanged, rbConnectToLocal.CheckedChanged
        Dim rb As RadioButton = sender

        If Not rb.Checked Then
            Exit Sub
        End If

        'Select Case rb.Text.ToLower()
        '    Case "server"
        '        'set path to server
        '        MDIParent1.connectionString = MDIParent1.connectionStringServer
        '        MDIParent1.tsslConnection.Text = "Server"
        '        MDIParent1.connectedToServer = True
        '    Case "local"
        '        'set path to local
        '        MDIParent1.connectionString = MDIParent1.connectionStringLocalLocal
        '        MDIParent1.tsslConnection.Text = "Local"
        '        MDIParent1.connectedToServer = False
        'End Select

    End Sub
End Class
