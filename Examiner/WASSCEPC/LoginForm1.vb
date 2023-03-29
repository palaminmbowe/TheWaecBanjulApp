Imports System.Data
Imports System.Data.OleDb

Public Class LoginForm1
    Dim examYear, series As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonOk.Click
        'Dim dr2 As OleDb.OleDbDataReader
        'Dim cmd As New OleDb.OleDbCommand

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            buttonOk.Enabled = False
            Exit Sub
        End If

        If (MDIParent1.serverFile.Exists) Then
            Console.WriteLine("Server File exists!")
            If (MDIParent1.localFile.Exists) Then
                Console.WriteLine("Local File exists!")
            Else
                'pass year to parent to create file
                MDIParent1.CurrentExamYear = examYear
                If (MDIParent1.SetupFileInfos()) Then
                    Console.WriteLine("Local File Created!")
                Else
                    Console.WriteLine("Cannot create local file !")
                End If
            End If
        End If

        Dim CUserId As String
        Dim db As New dbConnection3(MDIParent1.connectionString)
        'Dim db As New dbConnection3("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '        "C:\EMS\PWASSCE\emspwassce" & examYear & ".mdb;Jet OLEDB:Database Password=Sawat1me;")

        Try
            'gcon.Open()
            db.con.Open()
            db.cmd.CommandText = "select * from MyUsers where CUserId = '" & UsernameTextBox.Text & "' AND CPassword='" & PasswordTextBox.Text & "'"
            'cmd.Connection = gcon
            db.dr = db.cmd.ExecuteReader()

            If db.dr.Read Then
                curuser = db.dr("ExaminerNo")
                curuser1 = Mid(curuser, 1, 5)
                ' MDIParent1.C_E_REPORTToolStripMenuItem.Visible = True
                USERLEVEL = db.dr("UserLevel")
                CUserId = db.dr("CUserId")

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
                    MDIParent1.ToolStripStatusLabel2.Text = " as Examiner"

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

                'Get exam year from server

                Me.Close()
            Else
                MsgBox("Username/Password not correct")
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.Focus()
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
        ComboBoxExamYear.Items.AddRange({Now.Year().ToString(), (Now.Year() - 1).ToString()})
        ComboBoxExamYear.SelectedItem = "Select Year"
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

    Private Sub ComboBoxExamYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxExamYear.SelectedIndexChanged
        examYear = ComboBoxExamYear.SelectedItem
        ComboBoxSeries.Enabled = True
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        PasswordTextBox.Enabled = True
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        buttonOk.Enabled = True
    End Sub

    Private Sub ComboBoxSeries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSeries.SelectedIndexChanged
        series = ComboBoxSeries.SelectedItem().ToString().Substring(0, 1)
        UsernameTextBox.Enabled = True

    End Sub
End Class
