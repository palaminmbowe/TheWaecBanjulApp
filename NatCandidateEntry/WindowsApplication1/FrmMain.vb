Imports System.Windows.Forms
Imports WaecLibrary
Imports System.IO
Imports System.Threading

Public Class FrmMain
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

    Private Sub CassMarksEntryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksEntryFormToolStripMenuItem.Click
        'Try
        '    Dim ff As New FrmCassEntry()
        '    ff.MdiParent = Me
        '    ff.Show()
        'Catch ex As Exception
        'Finally
        'End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CassMarskModificationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarskModificationFormToolStripMenuItem.Click
        'Dim FrmModifyCass As New FrmModifyCass()
        'FrmModifyCass.MdiParent = Me
        'FrmModifyCass.Show()
    End Sub
    Private Sub CassMarksCompleteRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksCompleteRecordsToolStripMenuItem.Click
        'Dim FrmCompleteMarks As New FrmCompleteMarks()
        'FrmCompleteMarks.MdiParent = Me
        'FrmCompleteMarks.Show()
    End Sub

    Private Sub CassMarksIncompleteRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksIncompleteRecordsToolStripMenuItem.Click
        'Dim FrmIncompleteMarks As New FrmIncompleteMarks()
        'FrmIncompleteMarks.MdiParent = Me
        'FrmIncompleteMarks.Show()
    End Sub

    Private Sub ViewAllCandidatesWithMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim FrmCassGV As New FrmCassGV()
        'FrmCassGV.MdiParent = Me
        'FrmCassGV.Show()

    End Sub

    Private Sub AboutApplicationToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutApplicationToolStripMenuItem.Click
        'Dim About As New Form1
        'About.MdiParent = Me
        'About.Show()
    End Sub

    Private Sub CassMarksAllMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksAllMarksToolStripMenuItem.Click
        'Dim FrmCassGV As New FrmCassGV()
        'FrmCassGV.MdiParent = Me
        'FrmCassGV.Show()
    End Sub

    Private Sub CandidateSujectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateSujectToolStripMenuItem.Click
        'Dim FrmPost_Exam_Process As New FrmPost_Exam_Process
        'FrmPost_Exam_Process.MdiParent = Me
        'FrmPost_Exam_Process.Show()
    End Sub

    Private Sub CreateExaminersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateExaminersToolStripMenuItem.Click
        'Dim FrmCreate_Examiner As New FrmCreate_Examiner_
        'FrmCreate_Examiner.MdiParent = Me
        'FrmCreate_Examiner.Show()
    End Sub

    Private Sub GirlsFundedEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GirlsFundedEntriesToolStripMenuItem.Click
        'Dim FrmPract_Sub As New FrmPract_Sub
        'FrmPract_Sub.MdiParent = Me
        'FrmPract_Sub.Show()
    End Sub

    Private Sub ByRegionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByRegionToolStripMenuItem.Click
        'Dim FrmPost_Exam_Process As New FrmPost_Exam_Process
        'FrmPost_Exam_Process.MdiParent = Me
        'FrmPost_Exam_Process.Show()
    End Sub

    Private Sub EntrySummaryByCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntrySummaryByCentreToolStripMenuItem.Click
        'Dim FrmCreate_Entries_Labels As New FrmCreate_Entries_Sumries
        'FrmCreate_Entries_Sumries.MdiParent = Me
        'FrmCreate_Entries_Sumries.Show()
    End Sub

    Private Sub TassMarkEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TassMarkEntryToolStripMenuItem.Click
        'Dim FrmTassEntry As New FrmTassEntry
        'FrmTassEntry.MdiParent = Me
        'FrmTassEntry.Show()
    End Sub

    Private Sub AddCandidateEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCandidateEntryToolStripMenuItem.Click
        'Dim FrmgabEntry As New FrmgabEntry
        'FrmgabEntry.MdiParent = Me
        'FrmgabEntry.Show()
    End Sub

    Private Sub ModifyCandidateEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyCandidateEntryToolStripMenuItem.Click
        'Dim FrmMod_gabEntry As New FrmMod_gabEntry
        'FrmMod_gabEntry.MdiParent = Me
        'FrmMod_gabEntry.Show()
    End Sub

    Private Sub DeleteCandidateEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCandidateEntryToolStripMenuItem.Click
        'Dim FrmDeleteEntry As New FrmDeleteEntry
        'FrmDeleteEntry.MdiParent = Me
        'FrmDeleteEntry.Show()
    End Sub

    Private Sub CandidateRegistrationPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateRegistrationPaymentToolStripMenuItem.Click
        'Try
        '    Dim FRec As New FrmReceipt()
        '    FRec.MdiParent = Me
        '    FRec.Show()
        'Catch ex As Exception
        'Finally
        'End Try
    End Sub

    Private Sub SummaryOfPaymentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryOfPaymentDetailsToolStripMenuItem.Click
        'Dim Fsec As New frmPrintReceipt()
        'Try
        '    Fsec.MdiParent = Me
        '    Fsec.Show()
        'Catch ex As Exception
        'Finally
        'End Try
    End Sub


    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsslVersion.Text = "" & My.Application.Info.CompanyName & "  Ver: " & My.Application.Info.Version.ToString() & " | "
        userName = Environment.UserName
        userMachineName = Environment.MachineName
        tsslPcName.Text = userMachineName
        tsslUserName.Text = userName

        TassMarksToolStripMenuItem.Visible = False

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

        CheckForIllegalCrossThreadCalls = False

        SetupFileInfos()
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

    Private Sub SubBySubCanEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubBySubCanEntryToolStripMenuItem.Click
        'Dim FrmPost_Exam_Process As New FrmPost_Exam_Process
        'FrmPost_Exam_Process.MdiParent = Me
        'FrmPost_Exam_Process.Show()
    End Sub

    Private Sub LabelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelsToolStripMenuItem.Click
        'Dim FrmCreate_Entries_Labels As New FrmCreate_Entries_Labels
        'FrmCreate_Entries_Labels.MdiParent = Me
        'FrmCreate_Entries_Labels.Show()
    End Sub

    Private Sub CanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    frmNatG8.Close()
        'Catch ex As Exception
        'End Try

        Try
            frmNatG8 = New frmNat
            'frmNatG8.MdiParent = Me
            frmNatG8.Close()
        Catch ex As Exception

        End Try

        Dim frmNatG81 As frmNat = New frmNat
        frmNatG81.MdiParent = Me
        frmNatG81.Show()
    End Sub

    Private Sub PrintConfirmationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintConfirmationToolStripMenuItem.Click
        'Dim frm As New frmGabeceConfirmation
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub ConfirmationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmationToolStripMenuItem.Click
        'Dim frm As New frmWassceConfirmation
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub CandidateRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateRegistrationToolStripMenuItem.Click
        Try
            frmNatG3 = New frmNatG3
            frmNatG3.MdiParent = Me
            frmNatG3.Close()
        Catch ex As Exception
        End Try

        Dim frmNatG31 As frmNatG3 = New frmNatG3
        frmNatG31.MdiParent = Me
        frmNatG31.Show()
    End Sub

    Private Sub CandidateRegistrationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateRegistrationToolStripMenuItem2.Click
        'Try
        '    frmNatG8.Close()
        'Catch ex As Exception
        'End Try

        'Try
        '    frmNatG8 = New frmNat
        '    'frmNatG8.MdiParent = Me
        '    frmNatG8.Close()
        'Catch ex As Exception

        'End Try

        'Dim frmNatG81 As frmNat = New frmNat
        'frmNatG81.MdiParent = Me
        'frmNatG81.Show()

        Try
            frmNatG8 = New frmNat
            frmNatG8.MdiParent = Me
            frmNatG8.Close()
        Catch ex As Exception

        End Try

        Dim frmNatG81 As frmNat = New frmNat
        frmNatG81.MdiParent = Me
        frmNatG81.Show()
    End Sub

    Private Sub AddCandidateEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCandidateEntryToolStripMenuItem1.Click
        'Dim FrmgabEntry As New FrmgabEntry
        'FrmgabEntry.MdiParent = Me
        'FrmgabEntry.Show()
    End Sub

    Private Sub ModifyCandidateEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyCandidateEntryToolStripMenuItem1.Click
        'Dim FrmMod_gabEntry As New FrmMod_gabEntry
        'FrmMod_gabEntry.MdiParent = Me
        'FrmMod_gabEntry.Show()
    End Sub

    Private Sub DeleteCandidateEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCandidateEntryToolStripMenuItem1.Click
        'Dim FrmDeleteEntry As New FrmDeleteEntry
        'FrmDeleteEntry.MdiParent = Me
        'FrmDeleteEntry.Show()
    End Sub

    Private Sub CandidateRegistrationPaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateRegistrationPaymentToolStripMenuItem1.Click
        'Try
        '    Dim FRec As New FrmReceipt()
        '    FRec.MdiParent = Me
        '    FRec.Show()
        'Catch ex As Exception
        'Finally
        'End Try
    End Sub

    Private Sub CassMarksEntryFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksEntryFormToolStripMenuItem1.Click
        'Try
        '    Dim ff As New FrmCassEntry()
        '    ff.MdiParent = Me
        '    ff.Show()
        'Catch ex As Exception
        'Finally
        'End Try
    End Sub

    Private Sub CassMarskModificationFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarskModificationFormToolStripMenuItem1.Click
        'Dim FrmModifyCass As New FrmModifyCass()
        'FrmModifyCass.MdiParent = Me
        'FrmModifyCass.Show()
    End Sub

    Private Sub CassMarksCompleteRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksCompleteRecordsToolStripMenuItem1.Click
        'Dim FrmCompleteMarks As New FrmCompleteMarks()
        'FrmCompleteMarks.MdiParent = Me
        'FrmCompleteMarks.Show()
    End Sub

    Private Sub CassMarksIncompleteRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksIncompleteRecordsToolStripMenuItem1.Click
        'Dim FrmIncompleteMarks As New FrmIncompleteMarks()
        'FrmIncompleteMarks.MdiParent = Me
        'FrmIncompleteMarks.Show()
    End Sub

    Private Sub CassMarksAllMarksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CassMarksAllMarksToolStripMenuItem1.Click
        'Dim FrmCassGV As New FrmCassGV()
        'FrmCassGV.MdiParent = Me
        'FrmCassGV.Show()
    End Sub

    Private Sub SummaryOfPaymentDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryOfPaymentDetailsToolStripMenuItem1.Click
        'Dim Fsec As New frmPrintReceipt()
        'Try
        '    Fsec.MdiParent = Me
        '    Fsec.Show()
        'Catch ex As Exception
        'Finally
        'End Try
    End Sub

    Private Sub PrintConfirmationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintConfirmationToolStripMenuItem1.Click
        'Dim frm As New frmGabeceConfirmation
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub CandidateRegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateRegistrationToolStripMenuItem1.Click
        Try
            frmNat_G5 = New frmNatG5 With {
                .MdiParent = Me
            }
            frmNat_G5.Close()
        Catch ex As Exception
        End Try

        Dim frmNatG51 As frmNatG5 = New frmNatG5
        frmNatG51.MdiParent = Me
        frmNatG51.Show()

    End Sub

    Private Sub ReportsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem3.Click

    End Sub

    Private Sub Grade3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Grade3ToolStripMenuItem1.Click
        Try
            frmNatG3 = New frmNatG3
            frmNatG3.MdiParent = Me
            frmNatG3.Close()
        Catch ex As Exception
        End Try

        Dim frmNatG31 As frmNatG3 = New frmNatG3
        frmNatG31.MdiParent = Me
        frmNatG31.Show()
    End Sub

    Private Sub Grade5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Grade5ToolStripMenuItem1.Click

    End Sub

    Private Sub Grade8ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Grade8ToolStripMenuItem1.Click
        Try
            frmNatG8 = New frmNat
            frmNatG8.MdiParent = Me
            frmNatG8.Close()
        Catch ex As Exception

        End Try

        Dim frmNatG81 As frmNat = New frmNat
        frmNatG81.MdiParent = Me
        frmNatG81.Show()
    End Sub

    Private Sub timerCheckServer_Tick(sender As Object, e As EventArgs) Handles timerCheckServer.Tick
        'CheckServerConnection()
        'Try

        '    If (tCheckForConnection.IsAlive) Then
        '        'tCheckForConnection.Join()
        '        Return
        '    Else
        '        Try
        '            tCheckForConnection = New Thread(AddressOf CheckServerConnection)
        '            tCheckForConnection.Start()
        '        Catch ex As Exception

        '        End Try

        '    End If

        'Catch ex As Exception
        '    Console.WriteLine("Error in tCheckForConnection: " + ex.Message)
        'End Try
    End Sub

    Sub CheckServerConnection()
        If (File.Exists(serverFile.FullName)) Then
            'tssbServerConnection.Image = My.Resources.Ok16x16
            tssbServerConnection.BackColor = Color.Green
            connectedToServer = True
            tssbServerConnection.Text = "Connected"
        Else
            'tssbServerConnection.Image = My.Resources.Warning16x16
            tssbServerConnection.BackColor = Color.Red
            connectedToServer = False
            tssbServerConnection.Text = "Not Connected"
        End If

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Try
            If (frmNatTools.Visible = False) Then
                frmNatTools.Show()
            End If
            Exit Sub
        Catch ex As Exception

        End Try

        frmNatTools = New frmNatTools()
        frmNatTools.Show()
    End Sub

    Private Sub NormalFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalFormToolStripMenuItem.Click
        Try
            frmNat_G5 = New frmNatG5
            frmNat_G5.MdiParent = Me
            frmNat_G5.Close()
        Catch ex As Exception
        End Try

        Dim frmNatG51 As frmNatG5 = New frmNatG5
        frmNatG51.MdiParent = Me
        frmNatG51.Show()
    End Sub

    Private Sub BiggerFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiggerFormToolStripMenuItem.Click
        Try
            frmNat_G5B = New frmNatG5Bigger
            frmNat_G5B.MdiParent = Me
            frmNat_G5B.Close()
        Catch ex As Exception
        End Try

        Dim frmNatG51 As frmNatG5Bigger = New frmNatG5Bigger
        frmNatG51.MdiParent = Me
        frmNatG51.Show()
    End Sub
End Class
