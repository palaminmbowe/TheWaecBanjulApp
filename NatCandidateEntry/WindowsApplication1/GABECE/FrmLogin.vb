Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmLogin

    Dim con As New ConClass
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim cmd As New OleDbCommand

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        'Try
        'Opening our connection
        con.OpenConnection()
        'Let's see if it has written the correct password or not
        Dim sqlcom = ("select * from LoginDetails where Username= '" & txtUsername.Text & "' and Password='" & txtPassword.Text & "';")
        Dim cmd As New OleDbCommand(sqlcom, con.con)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Timer1.Enabled = True
        Else

            con.CloseConnection()
            dr.Close()
            MsgBox("Sign In as New User")
        End If
        CmdAddNewUser.Enabled = True

        'Close the open connection

        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar2.Value += 5
        If (ProgressBar2.Value = 100) Then
            FrmMain.Show()
            Timer1.Stop()
            Me.Hide()

        End If

    End Sub

    Private Sub CmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdReset.Click
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub AddNewUser()
        Try
            'If MessageBox.Show("This user does not exist. Do you want to add this new user", "Add New User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            con.OpenConnection()
            Dim cmd As New OleDbCommand
            cmd.CommandText = "Insert into LoginDetails(username,password) values('" & txtUsername.Text & "', '" & txtPassword.Text & "')"
            cmd.Connection = con.con
            cmd.ExecuteNonQuery()
            con.CloseConnection()
            'Else
            'con.CloseConnection()
            'Me.txtUsername.Focus()
            'End If

        Catch ex As Exception
            con.CloseConnection()
            MsgBox("Record not added")
        Finally
        End Try
    End Sub

    Private Sub cmdAddNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewUser.Click
        AddNewUser()
    End Sub
End Class

