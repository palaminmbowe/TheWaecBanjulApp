Public Class FormChartFull

    Dim LocalChart As System.Windows.Forms.DataVisualization.Charting.Chart

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(seriesName As String, DataGridView1 As DataGridView)
        ' This call is required by the designer.
        Me.New()

        SetData(seriesName, DataGridView1)
    End Sub
    Private Sub FormChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chart1 = LocalChart
        'Chart1.Update()
    End Sub
    Private Sub SetData(seriesName As String, DataGridView1 As DataGridView)
        Chart1 = New DataVisualization.Charting.Chart()

        Me.Chart1.Series.Add(seriesName)

        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If

        Try
            For Each r As DataGridViewRow In DataGridView1.Rows
                Chart1.Series(seriesName).Points.AddXY(r.Cells(2).Value, r.Cells(3).Value)
            Next
        Catch ex As Exception
        End Try

        'Chart1 = LocalChart
        Chart1.Update()
    End Sub
End Class