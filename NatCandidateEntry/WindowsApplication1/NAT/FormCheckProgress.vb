Public Class FormCheckProgress
    Dim dgOriginal As DataGridView = New DataGridView()

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        FillDataTableAdapters()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub FormCheckProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetNat3.qryNat3TotalByUser' table. You can move, or remove it, as needed.
        Me.QryNat3TotalByUserTableAdapter.Fill(Me.DataSetNat3.qryNat3TotalByUser, ComboBox1.Text.ToString())
        'TODO: This line of code loads data into the 'DataSetNat3.qryNat3UsernamePcname' table. You can move, or remove it, as needed.
        Me.QryNat3UsernamePcnameTableAdapter.Fill(DataSetNat3.qryNat3UsernamePcname)

        ComboBox1.SelectedIndex = -1

        DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
    End Sub

    Private Sub FillDataTableAdapters()
        'TODO: This line of code loads data into the 'DataSetNat3.qryNat3TotalByUser' table. You can move, or remove it, as needed.
        Me.QryNat3TotalByUserTableAdapter.Fill(Me.DataSetNat3.qryNat3TotalByUser, ComboBox1.Text.ToString())

        LoadChart()
    End Sub

    Private Sub LoadChart()
        Chart1.Series.Clear()
        Me.Chart1.Series.Add(ComboBox1.Text.ToString())

        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If

        Try
            For Each r As DataGridViewRow In DataGridView1.Rows
                Chart1.Series(ComboBox1.Text.ToString()).Points.AddXY(r.Cells(2).Value, r.Cells(3).Value)
            Next
        Catch ex As Exception

        End Try

        'Chart1.Series(ComboBox1.Text.ToString()).Points.AddXY(DataGridView1.Rows(0).Cells(2).Value, DataGridView1.Rows(0).Cells(3).Value)
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim m As ContextMenu = New ContextMenu()
            m.MenuItems.Add(New MenuItem("Copy"))
            Dim currentMouseOverrow = DataGridView1.HitTest(e.X, e.Y).RowIndex
            m.Show(DataGridView1, New Point(e.X, e.Y))
            If DataGridView1.GetCellCount(DataGridViewElementStates.Selected) Then
                Try
                    Clipboard.SetDataObject(DataGridView1.GetClipboardContent())
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub


    Private Sub DataGridView1_Validated(sender As Object, e As EventArgs) Handles DataGridView1.Validated
        'MessageBox.Show("Data source validated")
        'plot graph
    End Sub

    Private Sub Chart1_DoubleClick(sender As Object, e As EventArgs) Handles Chart1.DoubleClick
        Dim frm As FormChartFull = New FormChartFull(ComboBox1.Text.ToString(), DataGridView1)
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub
End Class