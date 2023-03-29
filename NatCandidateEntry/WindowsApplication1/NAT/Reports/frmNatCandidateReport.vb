Imports System.Data.OleDb
Imports System.Environment
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports WaecLibrary

Public Class frmNatCandidateReport
    Dim db As New dbConnection3
    Dim dbName = "GABECE.mdb"
    Dim dbPath = System.Environment.CurrentDirectory.ToString()
    Dim connected As Boolean

    Dim ds As DataSet
    Dim tableNames() As String = {"NatAdmin", "NATGRADE8"}

    'Dim ds As New DataSet
    Dim NatGrade8Adapter As OleDbDataAdapter

    Sub New(ByRef db As dbConnection3)
        Me.InitializeComponent()
        'Me.db.connectionString = db.con.ConnectionString
        Me.db = db
        'Me.db.dbPath = dbPath
        'Me.db.dbName = dbName
        'MessageBox.Show("Db string is: " & db.connectionString)
    End Sub

    Private Sub frmNatCandidateReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not db.isConnected() Then
            MessageBox.Show("Connection Error. Please check.", "Cannot connect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ds = New DataSet

        If SetupDataSet() Then

            rptCandidates1.SetDataSource(ds)

            rptCandidates1.VerifyDatabase()
            rptCandidates1.Refresh()

            crvNat8Candidates.ReportSource = rptCandidates1
        End If

        'ds = New DataSet("NatGrade8")
        'ds = New localDs()

        'NatGrade8Adapter = New OleDbDataAdapter


        'saveTables()
        'updateTables()
        'Dim row As DataRow = ds.Tables("NatGrade8").Rows.Item(0)

        'MessageBox.Show(row(0) & " | " & row(1) & " | " & row(2) & " | " & row(3) & " | " & row(4))

        ''Try
        ''    'Dim rptDoc As New ReportDocument
        ''    'rptDoc.Load("Reports\rptCandidates.rpt")
        ''    'rptDoc.SetDataSource(ds)
        ''    'crvNat8Candidates.ReportSource = rptDoc

        ''    'rptCandidates1.SetDataSource(ds)
        ''    'rptCandidates1.VerifyDatabase()
        ''    'rptCandidates1.ReadRecords()
        ''    'txtRptInfo.Text = rptCandidates1.Database.Tables("NatAdmin").LogOnInfo.ReportName

        ''    'rptCandidates1.Database.Tables("NatAdmin").SetDataSource(ds)
        ''    'rptCandidates1.Database.Tables("NATGRADE8").SetDataSource(ds)

        ''    'txtRptDbName.Text = db.dbPath & db.dbName
        ''    'rptCandidates1.Database.Tables("NATGRADE8").LogOnInfo.ConnectionInfo.ServerName = db.dbPath & db.dbName
        ''    'rptCandidates1.Database.Tables("NatAdmin").LogOnInfo.ConnectionInfo.ServerName = db.dbPath & db.dbName

        ''    'rptCandidates1.Database.Tables("NATGRADE8").ApplyLogOnInfo(rptCandidates1.Database.Tables("NATGRADE8").LogOnInfo)
        ''    'rptCandidates1.Database.Tables("NatAdmin").ApplyLogOnInfo(rptCandidates1.Database.Tables("NatAdmin").LogOnInfo)



        ''Catch ex As Exception
        ''    MessageBox.Show("There was an error generating report! Please try again: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''End Try
    End Sub

    Private Function SetupDataSet() As Boolean

        'Dim da As System.Data.IDbDataAdapter
        Dim dsAdapter As New List(Of OleDb.OleDbDataAdapter)
        Dim sqlForTables() As String = {"SELECT * FROM NatAdmin", "SELECT * FROM NATGRADE8"}

        Try
            For i As Integer = 0 To sqlForTables.Length - 1
                dsAdapter.Add(New OleDb.OleDbDataAdapter)
                dsAdapter(i).SelectCommand = New OleDb.OleDbCommand(sqlForTables(i), Me.db.con)
                dsAdapter(i).Fill(ds, tableNames(i))
                'dsAdapter(i).Fill(ds)
                dsAdapter(i).Dispose()
            Next
            Return True

        Catch ex As Exception
            Console.WriteLine("Error in setupDataSet(): " & ex.Message)
        End Try

        Return False
    End Function

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'rptCandidates1.Database.Tables("NATGRADE8").ApplyLogOnInfo(rptCandidates1.Database.Tables("NATGRADE8").LogOnInfo)
        'MessageBox.Show(rptCandidates1.Database.Tables("NATGRADE8").LogOnInfo.ConnectionInfo.ServerName.ToString())

        'rptCandidates1.VerifyDatabase()
        'rptCandidates1.Refresh()
        'crvNat8Candidates.ReportSource = rptCandidates1
    End Sub

    Sub updateTables()
        'Dim sqlStatements As List(Of String)

        'Try
        '    db.con.Open()
        '    sqlStatements = New List(Of String)
        '    'ds = New DataSet()
        '    'ds.Tables.Remove("NatAdmin")
        '    'ds.Tables.Remove("NATGRADE8")

        '    Dim tableNames() As String = {"NatAdmin", "NATGrade8"}

        '    sqlStatements.Add("SELECT * " & _
        '        "FROM NatAdmin ORDER BY CentNo;")

        '    sqlStatements.Add("SELECT (CentNo + IndexNo), LastName, FirstName, Initial, Sex, Blind, Dob, Attempts " & _
        '        "FROM NATGRADE8;")

        '    ds.Tables(0).Clear()
        '    ds.Tables(1).Clear()

        '    For i As Integer = 0 To sqlStatements.Count - 1
        '        db.cmd.CommandText = sqlStatements(i)
        '        db.cmd.Connection = db.con

        '        'db.dr = cmd.ExecuteReader()

        '        ds.Load(db.dr, LoadOption.OverwriteChanges, tableNames(i))
        '        'NatGrade8Adapter.SelectCommand = New OleDbCommand(sqlStatements(i), db.con)
        '        'NatGrade8Adapter.Fill(ds, tableNames(i))
        '        If Not db.dr.IsClosed Then
        '            db.dr.Close()
        '        End If
        '    Next
        '    NatGrade8Adapter.Dispose()

        'Catch ex As Exception
        '    Console.WriteLine("Error getting info table: " & ex.Message)
        'Finally
        '    db.con.Close()
        'End Try
    End Sub

    Private Sub checkForConnection(ByVal dbName As String, ByVal dbPath As String)
        'SetUpConnection(dbName, dbPath)
        connected = db.isConnected()

        'If connected Then
        '    btnConnected.BackColor = Color.MidnightBlue
        'Else
        '    btnConnected.BackColor = Color.Red
        'End If
    End Sub

    Private Sub saveTables()
        '    Dim sqlStatements As List(Of String)

        '    If Not connected Then
        '        MessageBox.Show("Connection Error: Cannot connect!", "connection error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '        Exit Sub
        '    End If

        '    Try
        '        db.con.Open()
        '        sqlStatements = New List(Of String)
        '        'ds = New DataSet()
        '        'ds.Tables.Remove("NatAdmin")
        '        'ds.Tables.Remove("NATGRADE8")

        '        Dim tableNames() As String = {"NatAdmin", "NATGrade8"}

        '        sqlStatements.Add("SELECT * " & _
        '            "FROM NatAdmin ORDER BY CentNo;")

        '        sqlStatements.Add("SELECT (CentNo + IndexNo), LastName, FirstName, Initial, Sex, Blind, Dob, Attempts " & _
        '            "FROM NATGRADE8;")

        '        For i As Integer = 0 To sqlStatements.Count - 1
        '            'ds.Tables.Add(tableNames(i))
        '            'NatGrade8Adapter.SelectCommand = New OleDbCommand(sqlStatements(i), db.con)
        '            'NatGrade8Adapter.Fill(ds, tableNames(i))
        '        Next
        '        NatGrade8Adapter.Dispose()

        '        'Dim natAdminTA As New localDsTableAdapters.NatAdminTableAdapter
        '        'Dim natGrade8 As New localDsTableAdapters.NATGRADE8TableAdapter

        '        'natAdminTA.GetData()
        '        'natGrade8.GetData()

        '    Catch ex As Exception
        '        Console.WriteLine("Error getting info from subjects table: " & ex.Message)
        '    Finally
        '        db.con.Close()
        '    End Try
    End Sub
End Class