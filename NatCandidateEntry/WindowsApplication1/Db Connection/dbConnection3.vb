Imports System.Data.OleDb
Imports System.Data.Odbc

Public Class dbConnection3
    Private dbNameP As String
    Private dbPathP As String
    Private dbUserIdP As String
    Private dbPasswordP As String

    Private connected As Boolean
    Private connectionType As Short '0 = no pass     1 = pass    2 = pass + name
    Private connectionStringP As String

    Public con, con1, con2, con3, con4 As New OleDb.OleDbConnection
    Public cmd, cmd1, cmd2, cmd3, cmd4 As New OleDb.OleDbCommand
    Public dr, dr1, dr2, dr3, dr4 As OleDb.OleDbDataReader

    Sub New(ByVal newConnectionString As String)
        Me.connectionString = newConnectionString
    End Sub

    Sub New()
        Me.connectionType = -1
    End Sub

    Sub New(ByVal dbName As String, ByVal dbPath As String)
        Me.connectionType = 0
        Me.dbNameP = dbName
        Me.dbPathP = dbPath
        Me.connected = connectToDB()
    End Sub

    Sub New(ByVal dbName As String, ByVal dbPath As String, ByVal dbPassword As String)
        Me.connectionType = 1
        Me.dbPasswordP = dbPassword
        Me.dbNameP = dbName
        Me.dbPathP = dbPath
        Me.connected = connectToDB()
    End Sub

    Sub New(ByVal dbName As String, ByVal dbPath As String, ByVal dbPassword As String, ByVal dbUserId As String)
        Me.connectionType = 2
        Me.dbPasswordP = dbPassword
        Me.dbNameP = dbName
        Me.dbPathP = dbPath
        Me.dbUserIdP = dbUserId

        Me.connected = connectToDB()
    End Sub

    Public Property dbName() As String
        Get
            Return dbNameP
        End Get
        Set(ByVal value As String)
            dbNameP = value
            connectToDB()
        End Set
    End Property

    Public Property connectionString As String
        Get
            Return connectionStringP
        End Get
        Set(ByVal value As String)
            connectionStringP = value
            connectToDBWithConnectionString()
        End Set
    End Property


    Public Property dbPath() As String
        Get
            Return dbPathP
        End Get
        Set(ByVal value As String)
            dbPathP = value
        End Set
    End Property


    Function connectToDB() As Boolean

        If (dbNameP = "") Or (dbPathP = "") Then
            MessageBox.Show("Please set database name and or path", _
                            "Connect Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Select Case connectionType
            Case -1
                Return False
            Case 0
                DoConnectToDB()
            Case 1
                If (dbPasswordP = "") Then
                    MessageBox.Show("Please check database password", _
                                    "Connect Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Console.WriteLine("Please check database username and or password")
                    Return False
                End If
                Return DoConnectToDB()
            Case 2
                If (dbUserIdP = "") Or (dbPasswordP = "") Then
                    MessageBox.Show("Please check database username and or password", _
                                    "Connect Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Console.WriteLine("Please check database username and or password")
                    Return False
                End If
            Case Else
                Return False
        End Select

        If Me.connectionStringP = "" Then
            Return False
        End If

    End Function

    Function DoConnectToDB() As Boolean
        'Dim connectionString As String = ""
        'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccess2007file.accdb;Jet OLEDB:Database Password=MyDbPassword;

        If (Right(dbName, 3) = "mdb") Then
            Console.WriteLine("Connecting to .mdb database")

            connectionStringP = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                              "Data Source=" & String.Concat(dbPathP, "\\", dbNameP, ";")
            If connectionType = 1 Then
                connectionStringP += String.Format("Jet OLEDB:Database Password={0};", dbPasswordP)
            End If
        ElseIf (Right(dbNameP, 5) = "accdb") Then
            Console.WriteLine("Connecting to .accdb database")
            connectionStringP = String.Format("{0};{1};", "Provider=Microsoft.ACE.OLEDB.12.0", _
                                    "Data Source=" & String.Concat(dbPathP, "\", dbNameP))
            If connectionType = 1 Then
                connectionStringP += String.Format("Jet OLEDB:Database Password={0}", dbPasswordP)
            End If
        Else
            Console.WriteLine("***** Unknown database extension: '" & dbName & "'.")
            Return False
        End If

        If Me.connectionStringP = "" Then
            Return False
        End If

        Return setupConnections()

    End Function

    Private Function connectToDBWithConnectionString() As Boolean
        setupConnections()
    End Function

    Private Function setupConnections() As Boolean
        con = New OleDbConnection(connectionString)
        con1 = New OleDbConnection(connectionString)
        con2 = New OleDbConnection(connectionString)
        con3 = New OleDbConnection(connectionString)
        con4 = New OleDbConnection(connectionString)

        cmd.Connection = con
        cmd1.Connection = con1
        cmd2.Connection = con2
        cmd3.Connection = con3
        cmd4.Connection = con4

        Try
            Try
                con.Open()
                connected = True
                Console.WriteLine("Successfully  connected to " & dbName & "!!!")
                connectionStringP = con.ConnectionString
                connected = True
                Return True
            Catch ex As Exception
                Console.WriteLine("Connection open error: " + ex.Message)
            End Try

            Return False
        Catch ex As Exception
            Console.WriteLine("Error Connecting to database: " + ex.Message)
            connected = False
            Return False
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

    Public Function isConnected() As Boolean
        Return connected
    End Function

End Class
