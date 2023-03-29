Imports WaecLibrary
Imports System.IO
Imports System.Threading
Public Class ConnectionHelper
    Dim db As dbConnection2
    Friend frmNatG8 As frmNat
    Friend frmNat_G3 As frmNatG3
    Friend frmNat_G5 As frmNatG5
    Friend frmNat_G5B As frmNatG5Bigger
    Public examYear As String

    Public connectionString As String = My.Resources.CString1 &
            My.Resources.dbPathLocal + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"

    Public connectionStringServer As String = My.Resources.CString1 &
            My.Resources.dbPathServer + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"

    Public connectionStringServerFull As String = My.Resources.CString1 &
            My.Resources.dbPathServerFull + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"

    Public connectionStringLocalLocal As String = My.Resources.CString1 &
            My.Resources.dbPathLocal + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"

    Public connectionStringNat8 As String = My.Resources.CString1 &
            Environment.CurrentDirectory + "\GABECE.mdb" + ";"

    Public serverFile As New FileInfo(My.Resources.dbPathServer + My.Resources.dbName)
    Public serverFileFull As New FileInfo(My.Resources.dbPathServerFull + My.Resources.dbName)
    Public serverFileEmpty As New FileInfo(My.Resources.dbPathServer + "Empty" + My.Resources.dbName)
    Public localFile As New FileInfo(My.Resources.dbPathLocal + My.Resources.dbName)

    Public connectedToServer As Boolean = False

    Private tCheckForConnection As Thread

    Private frmNatTools As frmNatTools

    Public userName As String
    Public userMachineName As String

    Friend Sub InitialLoad()
        'tsslVersion.Text = "" & My.Application.Info.CompanyName & "  Ver: " & My.Application.Info.Version.ToString() & " | "
        userName = Environment.UserName
        userMachineName = Environment.MachineName
        'tsslPcName.Text = userMachineName
        'tsslUserName.Text = userName

        'TassMarksToolStripMenuItem.Visible = False

        'get curent exam Year
        Dim currentMonth As Integer = DateAndTime.Now().Month

        If (currentMonth > 7) Then
            examYear = DateAndTime.Now().Year + 1
        Else
            examYear = DateAndTime.Now().Year
        End If

        'MessageBox.Show($"User = {userName.ToLower()}")

        If (userName.ToLower() = "palamin" Or userName.ToLower() = "palam") Then
            connectionStringServer = connectionStringServerFull
            serverFile = serverFileFull
        End If

        'setup up thread
        tCheckForConnection = New Thread(AddressOf CheckServerConnection) With {
            .Name = "tConnection"
        }

        'CheckForIllegalCrossThreadCalls = False

        SetupFileInfos()
    End Sub

    Sub CheckServerConnection()
        If (File.Exists(serverFile.FullName)) Then
            'tssbServerConnection.Image = My.Resources.Ok16x16
            'tssbServerConnection.BackColor = Color.Green
            connectedToServer = True
            'tssbServerConnection.Text = "Connected"
        Else
            'tssbServerConnection.Image = My.Resources.Warning16x16
            'tssbServerConnection.BackColor = Color.Red
            connectedToServer = False
            'tssbServerConnection.Text = "Not Connected"
        End If

    End Sub

    Private Function SetupFileInfos() As Boolean
        Try
            Try
                If (localFile.Exists) Then
                    Return True
                Else
                    If (Not serverFileEmpty.Exists) Then
                        MessageBox.Show("Please connect to the server for initial run.", "Initial Run", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If

            Catch ex As Exception
                Console.WriteLine("Local file failed: " + ex.Message)
            End Try

            If (serverFileEmpty.Exists) Then
                If (localFile.Exists) Then
                    Return True
                Else
                    ' copy local server file to local file
                    Try
                        Dim di As DirectoryInfo = New DirectoryInfo(localFile.DirectoryName)
                        If (Not di.Exists) Then
                            di.Create()
                        End If
                    Catch ex As Exception
                        Console.WriteLine("Error in creating directory: " & localFile.DirectoryName & " : " & ex.Message)
                    End Try
                    serverFileEmpty.CopyTo(localFile.FullName)

                    'test 
                    localFile.Refresh()
                    If (localFile.Exists) Then
                        'Console.WriteLine("Local file exists")
                        Return True
                    Else
                        MessageBox.Show("Cannot access local drive: " + localFile.FullName.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If

        Catch ex As Exception
            Console.WriteLine("Error setting up file infos: " & ex.Message)

        End Try
        Return False
    End Function

End Class
