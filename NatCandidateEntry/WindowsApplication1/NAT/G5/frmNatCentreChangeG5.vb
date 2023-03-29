Public Class frmNatCentreChangeG5

    Dim centreNo, centreName As String()
    Dim selectedCentre As String()

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub New(ByRef centreNo As String(), ByRef centreName As String(), ByRef selectedCentre As String())
        Me.New()

        Me.centreNo = centreNo
        Me.centreName = centreName
        Me.selectedCentre = selectedCentre
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmNatCentreChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub ListViewCentres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewCentres.SelectedIndexChanged, ListViewCentres.DoubleClick
        'get the row and save it in the index passed
        Dim lv As ListView = sender

        Try
            For i As Integer = 0 To Me.centreNo.Length - 1
                'MessageBox.Show("Selected row is: " & lv.SelectedItems(0).SubItems(0).ToString())
                Me.selectedCentre(0) = lv.SelectedItems(0).SubItems(0).Text
            Next
            btnOk.Enabled = True
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ListViewCentres_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewCentres.MouseDoubleClick

    End Sub
End Class