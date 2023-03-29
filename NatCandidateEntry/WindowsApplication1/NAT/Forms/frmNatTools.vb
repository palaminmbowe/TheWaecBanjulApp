Imports WaecLibrary

Public Class frmNatTools
    Dim db As dbConnection4
    Dim ListViewAll As New ListView
    Private Sub frmNatTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New dbConnection4(FrmMain.connectionString)
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton.CheckedChanged
        ListBoxUsers.Visible = False
    End Sub

    Private Sub RadioButtonUser_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUser.CheckedChanged
        ListBoxUsers.Visible = True
    End Sub

    Function GetData()
        ' gets all records and saves them in listviewAll
        ListViewAll.Items.Clear()

        Return False
    End Function
End Class