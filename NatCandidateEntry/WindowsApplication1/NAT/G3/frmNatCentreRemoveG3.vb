Imports WaecLibrary

Public Class frmNatCentreRemoveG3
    Dim centreNo, centreName As String()
    Dim selectedCentre As String() = {""}

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub New(ByRef centreNo As String(), ByRef centreName As String())
        Me.New()
        Me.centreNo = centreNo
        Me.centreName = centreName

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If DeleteCentre() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Error in deleting centre!")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmNatCentreRemove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Add and setup listview
        AddAndSetupList()

    End Sub

    Private Sub AddAndSetupList()
        Dim list As New ListView()
        Dim i As Integer = 0

        For Each centre As String In Me.centreNo
            'MessageBox.Show("Received centres: " & centre)
            Dim rowItem As New ListViewItem(centre)
            rowItem.SubItems.Add(Me.centreName(i))
            ListViewCentres.Items.Add(rowItem)
            i += 1
        Next

    End Sub

    Private Sub ListViewCentres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewCentres.SelectedIndexChanged
        'get the row and save it in the index passed
        Dim lv As ListView = sender

        Try
            'MessageBox.Show("Selected row is: " & lv.SelectedItems(0).SubItems(0).Text)
            Me.selectedCentre(0) = lv.SelectedItems(0).SubItems(0).Text
            CheckBoxConfirm.Enabled = True

            If CheckBoxConfirm.Checked Then
                btnOk.Enabled = True
            Else
                btnOk.Enabled = False
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Function DeleteCentre() As Boolean
        'MessageBox.Show("about to delete centre!")
        Dim db As New dbConnection3
        Dim result As Integer = 0

        db.connectionString = FrmMain.connectionString

        Dim sourceTable As String = "NatAdminG3"

        Try
            db.con.Open()

            Try
                db.cmd.CommandText = "DELETE * FROM NatAdminG3 WHERE ExamYear = '" & FrmMain.examYear & "' AND CentNo = '" & selectedCentre(0) & "'"
                result = db.cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Try
                db.cmd.CommandText = "DELETE * FROM NatAdminG3ServerLocal WHERE ExamYear = '" & FrmMain.examYear & "' AND CentNo = '" & selectedCentre(0) & "'"
                result = result & db.cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            If result Then
                Return True
            End If

        Catch ex As Exception
            Console.WriteLine("Error deleting centre: " & ex.Message)
        Finally
            db.con.Close()
        End Try

        Return False
    End Function

    Private Sub CheckBoxConfirm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxConfirm.CheckedChanged
        If CheckBoxConfirm.Checked Then
            btnOk.Enabled = True
        Else
            btnOk.Enabled = False
        End If
    End Sub
End Class