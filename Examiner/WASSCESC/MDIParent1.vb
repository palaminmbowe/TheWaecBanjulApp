Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO

Public Class MDIParent1
    'Connection for 
    ''Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    ''"\\Server1\WAEC Applications\WASSCE EMS" & "\emswassce.mdb;Jet OLEDB:Database Password=Sawat1me;"


    'Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        "C:\EMS\WASSCE\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            "C:\EMS\WASSCE\emswassce" & DateAndTime.Year(Now()).ToString() & ".accdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringServer As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _
    '"\\Server1\WAEC Applications\WASSCE EMS" & "\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public connectionStringServer As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
    '"\\Svictd\WAEC Applications\WASSCE EMS" & "\emswassce.mdb;Jet OLEDB:Database Password=Sawat1me;"
    Public connectionStringServer As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
    "\\Svictd\WAEC Applications\WASSCE EMS" & "\emswassce.accdb;Jet OLEDB:Database Password=Sawat1me;"


    'Public connectionStringLocal As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
    '        System.Environment.CurrentDirectory.ToString() & "\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"
    Public connectionStringLocal As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            System.Environment.CurrentDirectory.ToString() & "\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb;Jet OLEDB:Database Password=Sawat1me;"

    Public connectionStringLocalLocal As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            "C:\EMS\WASSCE\emswassce" & DateAndTime.Year(Now()).ToString() & ".accdb;Jet OLEDB:Database Password=Sawat1me;"

    'Public serverFile As New FileInfo("\\Server1\WAEC Applications\WASSCE EMS\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb")
    Public serverFile As New FileInfo("\\Svictd\WAEC Applications\WASSCE EMS\emswassce.accdb")
    Public localFile As New FileInfo("C:\EMS\WASSCE\emswassce" & DateAndTime.Year(Now()).ToString() & ".accdb")


    Private connectedToServerP As Boolean

    Public currentTADExaminerNo As String
    Public currentGeneralSubjectCode As String

    Dim ds As New DataSet()

    Public Property connectedToServer() As Boolean
        Get
            Return connectedToServerP
        End Get
        Set(ByVal value As Boolean)
            connectedToServerP = value
        End Set
    End Property


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

        'setup file info
        If (SetupFileInfos()) Then
            Console.WriteLine("File infos setup successfully")
        Else
            Me.Close()
            Exit Sub
        End If

        'Dim db As New dbConnection3(connectionString)
        Dim db As New dbConnection3(connectionStringLocalLocal)

        'Test for server path
        Try
            db.con.Open()
            connectedToServer = False
            tsslConnection.Text = "Local"
        Catch ex As Exception
            'error in path, switch to local db path
            If (MessageBox.Show("Error connecting to local db. Please check whether file exist. Do you want to connect to server?",
                                "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

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

        Dim mylogin As New LoginForm1
        mylogin.MdiParent = Me
        mylogin.Show()

    End Sub

    Private Function SetupFileInfos() As Boolean
        Try
            'serverFile = New FileInfo("\\Server1\WAEC Applications\WASSCE EMS\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb")
            'localFile = New FileInfo("C:\EMS\WASSCE\emswassce" & DateAndTime.Year(Now()).ToString() & ".mdb")

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
                        Return True
                    End If
                End If
            Else
                MessageBox.Show($"Cannot connect to server. Please check connection and try again! \n({serverFile.FullName} - {localFile.FullName}", "Cannot Connect", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub MARKSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MARKSToolStripMenuItem.Click

    End Sub

    Private Sub UpdateAllMarksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateAllMarksToolStripMenuItem.Click
        Dim dbS As New dbConnection3(connectionStringServer)
        Dim db As New dbConnection3(connectionString)
        Dim tableName As String = "TassMarks"
        Dim sql As String = "SELECT ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, BackedUp From " &
            tableName & " WHERE updated = " & False & ";"

        UseWaitCursor = True

        Try
            dbS.con.Open()
            db.con4.Open()

            '--------------------------------------
            db.cmd4.CommandText = "Delete * from TassMarks WHERE Trim(Mark) = '' OR Mark IS NULL;"
            If (db.cmd4.ExecuteNonQuery()) Then
                'success with local
                Console.WriteLine("Removed blank marks")
            End If

            db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) " & _
                "SET TassMarks.updated = True, TassMarksServer.Mark = TassMarks.Mark " & _
                    "WHERE ((TassMarks.Mark)<>([TassMarksServer].[Mark]));"
            If (db.cmd4.ExecuteNonQuery()) Then
                'success with local
                Console.WriteLine("Updated changed marks")
            End If

            db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = True " & _
                    "WHERE ((TassMarks.Mark)=([TassMarksServer].[Mark]));"
            If (db.cmd4.ExecuteNonQuery()) Then
                'success with local
                Console.WriteLine("Updated updates")
            End If
            '--------------------------------------

            sql = "SELECT ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, BackedUp From " & _
                tableName & " WHERE updated = False;"

            Threading.Thread.Sleep(3000)

            If (FillDS(tableName, sql)) Then

                'okay got something. Is it empty
                If (ds.Tables(tableName).Rows.Count < 1) Then
                    Console.WriteLine("No rows retruned")
                Else
                    'some records to process
                    For Each dr As DataRow In ds.Tables(tableName).Rows
                        If (dr("updated") = True) Then
                            Console.WriteLine("Record already there")
                        End If
                        Try
                            dbS.cmd.CommandText = "" & _
                            "INSERT INTO TassMarks (ExamYear, CentNo, IndexNo, SubjCode, Mark, ExaminerNo, Oldmark, ModiDate, updated, PcName) VALUES " & _
                            "('" & dr("ExamYear") & "', '" & dr("CentNo") & "', '" & dr("IndexNo") & "', '" & dr("SubjCode") & "', '" & _
                            dr("Mark") & "', '" & dr("ExaminerNo") & "', '" & dr("Oldmark") & "', '" & dr("ModiDate") & "', " & True & ", '" & Environment.MachineName & "');"
                            'db.cmd4.CommandText = "UPDATE TassMarks SET updated = " & True & " WHERE ((ExamYear = '" & dr("ExamYear") & _
                            '    "') AND (CentNo = '" & dr("CentNo") & "') AND (IndexNo = '" & dr("IndexNo") & "') AND (SubjCode = '" & dr("SubjCode") & "'));"

                            'ok, now run updates
                            If (dbS.cmd.ExecuteNonQuery()) Then
                            Else
                                Console.WriteLine("Update failed")
                            End If
                        Catch ex As Exception
                            Console.WriteLine("Error Updating Server: " + ex.Message)
                        End Try
                    Next
                End If

            End If

            db.cmd4.CommandText = "UPDATE TassMarks INNER JOIN TassMarksServer ON (TassMarks.SubjCode = TassMarksServer.SubjCode) AND (TassMarks.IndexNo = TassMarksServer.IndexNo) AND (TassMarks.CentNo = TassMarksServer.CentNo) AND (TassMarks.ExamYear = TassMarksServer.ExamYear) SET TassMarks.updated = True " & _
                    "WHERE ((TassMarks.Mark)=([TassMarksServer].[Mark]));"
            If (db.cmd4.ExecuteNonQuery()) Then
                'success with local
                Console.WriteLine("Updated updates")
            End If

        Catch ex As Exception
            Console.WriteLine("Error saving marks to db: " + ex.Message)
        Finally
            db.con4.Close()
            dbS.con.Close()
            UseWaitCursor = False
        End Try

        MessageBox.Show("Update Completed")

    End Sub

    Private Function FillDS(ByVal tableName As String, ByVal sqlString As String) As Boolean
        Dim db As New dbConnection3(connectionString)
        Try
            'try to remove table
            Try
                ds.Tables.Remove(tableName)
            Catch ex As Exception
                'table most likely does not exist
            End Try

            Dim da As New OleDbDataAdapter(sqlString, db.con.ConnectionString)
            da.SelectCommand.CommandText = sqlString
            da.Fill(ds, tableName)
            da.Dispose()
            Return True
        Catch ex As Exception
            Console.WriteLine("Error filling ds with: " & sqlString)
        End Try
        Return False
    End Function
End Class
