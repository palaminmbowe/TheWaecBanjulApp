Imports System.Data
Imports WaecLibrary

Public Class frmGabeceConfirmation
    Dim db As New dbConnection3()
    Dim dbName = "GABECE.mdb"
    Dim dbPath = System.Environment.CurrentDirectory.ToString()
    Dim tableNames() As String = {"CandDetails", "CandSubject", "SenSecSchools", "CentreTbl"}

    Dim ds As DataSet


    Private Sub rptGabeceConfirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db = New dbConnection3(dbName, dbPath)
        If db.isConnected() Then
            'MessageBox.Show("Db Connected to: " & db.connectionString)
        End If

        ds = New DataSet

        If setupDataSet() Then

            rptGabeceConfirmation31.SetDataSource(ds)

            rptGabeceConfirmation31.VerifyDatabase()
            rptGabeceConfirmation31.Refresh()

            crvGabeceConfirmation.ReportSource = rptGabeceConfirmation31
        End If



        'rptGabeceConfirmation21.Database.Tables("CandDetails").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName
        'rptGabeceConfirmation21.Database.Tables("CandSubject").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName
        'rptGabeceConfirmation21.Database.Tables("SenSecSchools").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName
        'rptGabeceConfirmation21.Database.Tables("CentreTbl").LogOnInfo.ConnectionInfo.ServerName = dbPath & "\" & dbName

        'rptGabeceConfirmation21.Database.Tables("CandDetails").ApplyLogOnInfo(rptGabeceConfirmation21.Database.Tables("CandDetails").LogOnInfo)
        'rptGabeceConfirmation21.Database.Tables("CandSubject").ApplyLogOnInfo(rptGabeceConfirmation21.Database.Tables("CandSubject").LogOnInfo)
        'rptGabeceConfirmation21.Database.Tables("SenSecSchools").ApplyLogOnInfo(rptGabeceConfirmation21.Database.Tables("SenSecSchools").LogOnInfo)
        'rptGabeceConfirmation21.Database.Tables("CentreTbl").ApplyLogOnInfo(rptGabeceConfirmation21.Database.Tables("CentreTbl").LogOnInfo)


    End Sub

    Private Function SetupDataSet() As Boolean

        'Dim da As System.Data.IDbDataAdapter
        Dim dsAdapter As New List(Of OleDb.OleDbDataAdapter)
        Dim sqlForTables() As String = {"SELECT * FROM CandDetails", "SELECT * FROM CandSubject", _
                                        "SELECT * FROM SenSecSchools", "SELECT * FROM CentreTbl"}

        Try
            For i As Integer = 0 To sqlForTables.Length - 1
                dsAdapter.Add(New OleDb.OleDbDataAdapter)
                dsAdapter(i).SelectCommand = New OleDb.OleDbCommand(sqlForTables(i), Me.db.con)
                dsAdapter(i).Fill(ds, tableNames(i))
                dsAdapter(i).Dispose()
            Next
            Return True

        Catch ex As Exception
            Console.WriteLine("Error in setupDataSet(): " & ex.Message)
        End Try

        Return False
    End Function
End Class