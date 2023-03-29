Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class LoginForm2
    Dim gcon6 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim con As New ConClass
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim exno, who As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        Try

            'Opening our connection

            gcon6.Open()
            'Let's see if it has written the correct password or not

            Dim Oledbcom = ("select * from Admin_Logins where USERNAME= '" & txtUsername.Text & "' and EPASSWORD='" & txtPassword.Text & "'")
            Dim cmd As New OleDbCommand(Oledbcom, gcon6)

            cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text)
            cmd.Parameters.AddWithValue("@EPASSWORD", txtPassword.Text)

            dr = cmd.ExecuteReader
            If dr.Read Then
                username = txtUsername.Text
                Timer1.Enabled = True
            Else
                MsgBox("This user does not exist in the database.", MsgBoxStyle.Information, Me.Text)

            End If
            'Close the open connection

        Catch ex As Exception
            gcon6.Close()
        Finally
            dr.Close()
            gcon6.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '""" stopped""""
        ver()
        '  ' ProgressBar2.Value += 20
        'If (ProgressBar2.Value = 100) Then
        'MyModule1.myusername = txtUsername.Text
        FrmTassMidForm.Show()
        FrmTassMidForm.Text = txtUsername.Text.ToUpper + ": " + who
        Timer1.Stop()
        'Windows.Forms.ToolStripMenuItem. = False
        'Me.Close()
        ' End If
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
            cmd1.CommandText = "Select * FROM Admin_Logins where USERNAME='" & txtUsername.Text & "' and EPASSWORD='" & txtPassword.Text & "'"
            cmd1.Connection = con.con
            dr = cmd1.ExecuteReader


            While (dr.Read)
                who = dr("STATUS")
                subjoffno = dr("OFFICERNO")
            End While
            con.CloseConnection()
        Catch ex As Exception
        Finally
        End Try

    End Sub


End Class
