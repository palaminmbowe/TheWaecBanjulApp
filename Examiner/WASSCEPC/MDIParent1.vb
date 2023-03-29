Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO

Namespace Exams.WASSCEPCExaminer

End Namespace

Public Class MDIParent1
    'Connection for 
    ''Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    ''"\\Server1\WAEC Applications\WASSCE EMS" & "\emspwassce.mdb;Jet OLEDB:Database Password=Sawat1me;"


    'Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        "C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringServer As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
    '"\\SVICTD\WAEC Applications\PWASSCE EMS" & "\emspwassce.mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringLocal As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        System.Environment.CurrentDirectory.ToString() & "\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringLocalLocal As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        "C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public serverFile As New FileInfo("\\SVICTD\WAEC Applications\PWASSCE EMS\emspwassce.mdb")
    'Public localFile As New FileInfo("C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb")

    Public connectionString As String

    Public connectionStringServer As String

    Public connectionStringLocal As String

    Public connectionStringLocalLocal As String

    Public serverFile As New FileInfo("\\SVICTD\WAEC Applications\PWASSCE EMS\emspwassce.mdb")
    Public localFile As New FileInfo("C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb")

    Private examYear As String
    Public series As String


    'Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        "C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringServer As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '"\\Server1\WAEC Applications\PWASSCE EMS" & "\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringLocal As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        System.Environment.CurrentDirectory.ToString() & "\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringLocalLocal As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        "C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public serverFile As New FileInfo("\\Server1\WAEC Applications\PWASSCE EMS\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb")
    'Public localFile As New FileInfo("C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb")

    Private connectedToServerP As Boolean

    Public Property CurrentExamYear As String
        Get
            Return examYear
        End Get
        Set(value As String)
            examYear = value
        End Set
    End Property

    Public Property connectedToServer() As Boolean
        Get
            Return connectedToServerP
        End Get
        Set(ByVal value As Boolean)
            connectedToServerP = value
        End Set
    End Property

    Private Function updateConnectionStrings()
        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\EMS\PWASSCE\emspwassce" & examYear & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

        connectionStringServer = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "\\SVICTD\WAEC Applications\PWASSCE EMS" & "\emspwassce.mdb;Jet OLEDB:Database Password=Sawat1me;"

        connectionStringLocal = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
                System.Environment.CurrentDirectory.ToString() & "\emspwassce" & examYear & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

        connectionStringLocalLocal = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
                "C:\EMS\PWASSCE\emspwassce" & examYear & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

        serverFile = New FileInfo("\\SVICTD\WAEC Applications\PWASSCE EMS\emspwassce.mdb")
        localFile = New FileInfo("C:\EMS\PWASSCE\emspwassce" & examYear & ".mdb")
    End Function


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = curuser & "THE WEST AFRICAN EXAMINATIONS COUNCIL - THE GAMBIA      : : :  EXAMINERS MARK SHEET"
        lblVersion.Text = "ver: " & My.Application.Info.Version.ToString()

        MARKSToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False

        Dim mylogin As New LoginForm1
        mylogin.MdiParent = Me
        mylogin.Show()


        'setup file info
        'If (SetupFileInfos()) Then
        '    Console.WriteLine("File infos setup successfully")
        'End If

        'Dim db As New dbConnection3(connectionString)
        Dim db As New dbConnection3(connectionStringLocalLocal)

        'Test for server path
        Try
            db.con.Open()
            connectedToServer = False
            tsslConnection.Text = "Local"
        Catch ex As Exception
            'error in path, switch to local db path
            'If (MessageBox.Show("Error connecting to local db. Please check whether file exist. Do you want to connect to server?",
            '                    "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            '    Exit Sub
            'End If

            connectionString = connectionString
            gcon = New OleDbConnection(connectionString)

            Dim db2 = New dbConnection3(connectionString)

            Try
                db2.con.Open()
                connectedToServer = False
            Catch ex2 As Exception
                Console.WriteLine("Error accessing server db: " & ex2.Message())
                tsslConnection.Text = "Server"
            Finally
                db2.con.Close()
            End Try
        Finally
            db.con.Close()
        End Try

        'Dim mylogin As New LoginForm1
        'mylogin.MdiParent = Me
        'mylogin.Show()

    End Sub

    Private Function GetExamCurrentExamYear() As String
        'Throw New NotImplementedException()
        'Connect to DB
        'Get exam year
        Return CurrentExamYear

    End Function

    Friend Function SetupFileInfos() As Boolean
        Try
            'serverFile = New FileInfo("\\Server1\WAEC Applications\PWASSCE EMS\emspwassce.mdb")
            'localFile = New FileInfo("C:\EMS\PWASSCE\emspwassce" & DateAndTime.Year(Now()).ToString() & ".mdb")
            'Get exam year somehow from the database
            If (updateConnectionStrings()) Then
                Console.WriteLine("Connection strings updated!")
            End If

            localFile = New FileInfo("C:\EMS\PWASSCE\emspwassce" & GetExamCurrentExamYear() & ".mdb")

            If (serverFile.Exists) Then
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
                    serverFile.CopyTo(localFile.FullName)

                    'test 
                    localFile.Refresh()
                    If (localFile.Exists) Then
                        Console.WriteLine("Local file exists")
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error setting up file infos: " & ex.Message)
        End Try
        Return False
    End Function

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Dim mylogin As New LoginForm1
        mylogin.MdiParent = Me
        mylogin.Show()
    End Sub

    Private Sub CREATEEXAMINERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CREATEXAM As New FrmCreate_Examiner_
        CREATEXAM.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MARKSToolStripMenuItem.Visible = False
        MARKSToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        EXAMINERToolStripMenuItem.Visible = False
        ADMINISTRATIONToolStripMenuItem.Enabled = True
        MARKSToolStripMenuItem.Enabled = True
        SubjectToolStripMenuItem.Visible = False
        QUERIESToolStripMenuItem.Visible = False
        AllOCATEPAToolStripMenuItem.Visible = False
        C_E_REPORTToolStripMenuItem.Visible = False
        ToolStripStatusLabel2.Text = ""
        ToolStripStatusLabel1.Text = ""
        ExitToolStripMenuItem.Enabled = True
        tsslConnection.Text = ""

        Dim mylogin As New LoginForm1()
        mylogin.MdiParent = Me
        mylogin.Show()

    End Sub

    Private Sub AddMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMarksToolStripMenuItem.Click
        Dim MARKENTRY As New frmMarks
        MARKENTRY.MdiParent = Me
        MARKENTRY.Show()
    End Sub

    Private Sub ModifyMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyMarksToolStripMenuItem.Click
        Dim modifyentry As New frmModifyMarks
        modifyentry.MdiParent = Me
        modifyentry.Show()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click
        Dim ABOUT As New AboutBox1
        ABOUT.Show()

    End Sub

    Private Sub EXAMINERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXAMINERToolStripMenuItem.Click
        Dim CREATEXAM As New FrmCreate_Examiner_
        CREATEXAM.MdiParent = Me
        CREATEXAM.Show()
    End Sub

    Private Sub QUERIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUERIESToolStripMenuItem.Click


    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Dim myt As New frmSubjectOfficer
        myt.MdiParent = Me
        myt.Show()
    End Sub

    Private Sub AllOCATEPAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllOCATEPAToolStripMenuItem.Click
        Dim allocate As New frmAllocatePapers
        allocate.MdiParent = Me
        allocate.Show()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub MarksOustandingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksOustandingToolStripMenuItem.Click
        Dim QUERIES As New frmQueries
        QUERIES.MdiParent = Me
        QUERIES.Show()
    End Sub

    Private Sub MarksEnteredToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksEnteredToolStripMenuItem.Click
        Dim QUERIES As New frmMarksEnter
        QUERIES.MdiParent = Me
        QUERIES.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ADMINISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADMINISTRATIONToolStripMenuItem.Click

    End Sub

    Private Sub C_E_REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_E_REPORTToolStripMenuItem.Click
        'Dim CEReport As New FrmCEReports
        'CEReport.MdiParent = Me
        'CEReport.Show()
    End Sub
End Class
