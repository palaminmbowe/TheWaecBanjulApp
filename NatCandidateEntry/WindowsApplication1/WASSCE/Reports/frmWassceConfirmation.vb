Imports WaecLibrary

Public Class frmWassceConfirmation
    Dim db As New dbConnection2
    Dim dbName = "wamaster.mdb"
    Dim dbPath = System.Environment.CurrentDirectory.ToString()

    Private Sub frmWassceConfirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            crpWassceConfirmation1.Database.Tables("BioDetails").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName
            crpWassceConfirmation1.Database.Tables("Cand_subjects").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName
            crpWassceConfirmation1.Database.Tables("Wacenters").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName

            crpWassceConfirmation1.Database.Tables("BioDetails").ApplyLogOnInfo(crpWassceConfirmation1.Database.Tables("BioDetails").LogOnInfo)
            crpWassceConfirmation1.Database.Tables("Cand_subjects").ApplyLogOnInfo(crpWassceConfirmation1.Database.Tables("Cand_subjects").LogOnInfo)
            crpWassceConfirmation1.Database.Tables("Wacenters").ApplyLogOnInfo(crpWassceConfirmation1.Database.Tables("Wacenters").LogOnInfo)

            crpWassceConfirmation1.VerifyDatabase()
            crpWassceConfirmation1.Refresh()

            'txtServer.Text = crpWassceConfirmation1.Database.Tables("BioDetails").LogOnInfo.ConnectionInfo.ServerName

            crvWassceConfirmation.ReportSource = crpWassceConfirmation1

        Catch ex As Exception
            MessageBox.Show("Oops something went wrong: " & ex.Message)
        End Try

    End Sub

    Private Sub txtServer_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtServer.DragDrop
        MessageBox.Show("I saw that!")
    End Sub
End Class