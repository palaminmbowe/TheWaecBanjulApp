Imports System.Data.OleDb
Imports System.Data.Odbc

Public Class dbConnection2
    Private dbNameP As String
    Private dbPathP As String
    Private dbUserIdP As String
    Private dbPasswordP As String

    Private connected As Boolean
    Private connectionStringP As String

    Public con, con1, con2, con3, con4 As New OleDb.OleDbConnection
    Public cmd, cmd1, cmd2, cmd3, cmd4 As New OleDb.OleDbCommand
    Public dr, dr1, dr2, dr3, dr4 As OleDb.OleDbDataReader

    Sub New()
    End Sub

    Sub New(ByVal newConnectionString As String)
        connectionString = newConnectionString
    End Sub
    Public Property connectionString() As String
        Get
            Return connectionStringP
        End Get
        Set(ByVal value As String)
            connectionStringP = value
            setConnectionString()
        End Set
    End Property

    Public Property dbName() As String
        Get
            Return dbNameP
        End Get
        Set(ByVal value As String)
            dbNameP = value
            If dbPath <> "" Then
                connectToDB()
            End If
        End Set
    End Property

    Public Property dbPath() As String
        Get
            Return dbPathP
        End Get
        Set(ByVal value As String)
            dbPathP = value
            If dbName <> "" Then
                connectToDB()
            End If
        End Set
    End Property

    Public Property dbUserId() As String
        Get
            Return dbUserIdP
        End Get
        Set(ByVal value As String)
            dbUserIdP = value
            If dbPasswordP <> "" Then
                connectToDBWithPassword()
            End If
        End Set
    End Property

    Public Property dbPassword() As String
        Get
            Return dbPasswordP
        End Get
        Set(ByVal value As String)
            dbPasswordP = value
            If dbUserIdP <> "" Then
                connectToDBWithPassword()
            End If
        End Set
    End Property


    Private Function connectToDB() As Boolean
        Try
            If dbNameP = "" Or dbPath = "" Then
                MessageBox.Show("Please set database name and or path", _
                                "Connect Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine("Please set database name and or path Connect Error")
                Return False
            End If

            If (Right(dbName, 3) = "mdb") Then
                Console.WriteLine("Connecting to .mdb database")

                con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                          String.Concat("", dbPathP) & String.Concat("\", dbNameP))
                con1 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                          String.Concat("", dbPathP) & String.Concat("\", dbNameP))
                con2 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                          String.Concat("", dbPathP) & String.Concat("\", dbNameP))
                con3 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                          String.Concat("", dbPathP) & String.Concat("\", dbNameP))
                con4 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                          String.Concat("", dbPathP) & String.Concat("\", dbNameP))

                'cmd.Connection = con
                'cmd1.Connection = con1
                'cmd2.Connection = con2
                'cmd3.Connection = con3
                'cmd4.Connection = con4

                Try
                    Try
                        con.Open()
                    Catch ex As Exception
                        Console.WriteLine("Connection already open: " + ex.Message)
                    End Try

                    Console.WriteLine("Successfully  connected to mdb !!!")
                    connected = True

                    'connectionString = con.ConnectionString
                    Return True
                Catch ex As Exception
                    Console.WriteLine("Error Connecting to database: " + ex.Message)
                    connected = False
                    Return False
                Finally
                    con.Close()
                End Try

            ElseIf (Right(dbNameP, 5) = "accdb") Then
                Console.WriteLine("Connecting to .accdb database")
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con1 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con2 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con3 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con4 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)

                Return checkForConnection()
            Else
                Console.WriteLine("***** Unknown database extension '" & dbName & "'.")
            End If

        Catch ex As Exception
            Console.WriteLine("Error Connecting to database: " + ex.Message)
            connected = False
            Return False
        Finally
            checkForConnection()
        End Try



    End Function

    Function connectToDBWithPassword() As Boolean
        Try
            If dbNameP = "" Or dbPath = "" Then
                MessageBox.Show("Please set database name and or path", _
                                "Connect Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine("Please set database name and or path Connect Error")
                Return False
            End If

            If (Right(dbName, 3) = "mdb") Then
                Console.WriteLine("Connecting to .mdb database")

                Dim connectionString As String = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                          String.Concat("", dbPathP, "\", dbNameP) & _
                                          String.Format("; Jet OLEDB:Database Password={1};", dbUserIdP, dbPasswordP))

                'Dim connectionString1 As String = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                '                          String.Concat("", dbPathP, "\", dbNameP) & _
                '                          String.Format("; User Id={0}; Password={1};", dbUserIdP, dbPasswordP))

                con = New OleDbConnection(connectionString)

                con1 = New OleDbConnection(connectionString)
                con2 = New OleDbConnection(connectionString)
                con3 = New OleDbConnection(connectionString)
                con4 = New OleDbConnection(connectionString)

                Try
                    Try
                        con.Open()
                    Catch ex As Exception
                        Console.WriteLine("Connection already open: " + ex.Message)
                    End Try

                    Console.WriteLine("Successfully  connected to mdb !!!")
                    connected = True
                    connectionString = con.ConnectionString
                    Return True
                Catch ex As Exception
                    Console.WriteLine("Error Connecting to database: " + ex.Message)
                    connected = False
                    Return False
                Finally
                    con.Close()
                End Try

            ElseIf (Right(dbNameP, 5) = "accdb") Then
                Console.WriteLine("Connecting to .accdb database")
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con1 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con2 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con3 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)
                con4 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPathP & dbNameP)

                Return checkForConnection()
            Else
                Console.WriteLine("***** Unknown database extension '" & dbName & "'.")
            End If

        Catch ex As Exception
            Console.WriteLine("Error Connecting to database: " + ex.Message)
            connected = False
            Return False
        Finally
        End Try
    End Function

    Private Function checkForConnection()
        Try
            cmd.Connection = con
            cmd1.Connection = con1
            cmd2.Connection = con2
            cmd3.Connection = con3
            cmd4.Connection = con4

            con.Open()
            Console.WriteLine("Successfully connected to accdB !!!")
            connected = True
            connectionStringP = con.ConnectionString
            Return True
        Catch ex As Exception
            Console.WriteLine("Error Connecting to database: " + ex.Message)
            connected = False
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Private Function setConnectionString()
        con.ConnectionString = Me.connectionStringP
        con1.ConnectionString = Me.connectionStringP
        con2.ConnectionString = Me.connectionStringP
        con3.ConnectionString = Me.connectionStringP
        con4.ConnectionString = Me.connectionStringP
        Return checkForConnection()
    End Function

    Public Function isConnected() As Boolean
        checkForConnection()
        Return connected
    End Function

    Function closeDr(ByRef dReader As OleDbDataReader) As Boolean
        Try
            dReader.Close()
            Return True
        Catch ex As Exception
            Console.WriteLine("Data Reader already closed")
        End Try
    End Function
End Class

'Try
'Catch ex As Exception
'    Console.WriteLine("Error Connecting to database: " + ex.Message)
'Finally

'End Try