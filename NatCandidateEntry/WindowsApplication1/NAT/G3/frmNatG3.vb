Imports System.Collections
Imports System.IO
Imports WaecLibrary
Imports System.Data.SqlClient

Public Class frmNatG3
    Private db As New dbConnection3
    Dim connected As Boolean
    Dim dbName = My.Resources.dbName
    Dim dbPath = System.Environment.CurrentDirectory.ToString()
    Dim sourceTable As String = "NATGRADE3"
    Dim centNo, centName As String
    Dim enableFeedback = False
    Dim listEmpty As Boolean = True
    Dim skipCheckForFields As Boolean = False
    Dim regCentres, regCentresNames As String()
    Dim examYear As String

    Dim connectionHelper As ConnectionHelper = New ConnectionHelper()

    Public connectionString As String = ConnectionHelper.connectionString

    Public connectionStringServer As String = connectionHelper.connectionStringServer

    Public connectionStringLocalLocal As String = connectionHelper.connectionStringLocalLocal

    Public serverFile As New FileInfo(My.Resources.dbPathServer + My.Resources.dbName)
    Public localFile As New FileInfo(My.Resources.dbPathLocal + My.Resources.dbName)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        connectionHelper = New ConnectionHelper()

        connectionHelper.InitialLoad()
        examYear = connectionHelper.examYear

        'End If
        If DoNatInitialSetup() Then
            Dim frmFirstRun As New frmNATSetupG3
            Dim result As Integer = frmFirstRun.ShowDialog()

            DoNatInitialSetup()

            If result = DialogResult.OK Then
                'all okay continue loading 
                'Me.Show()
                'Dim newFrmNat As New frmNat()
                'newFrmNat.MdiParent = FrmMain
                'newFrmNat.Show()

                'Me.Close()
            Else
                MessageBox.Show("Cannot continue with the initial setup. Please try again!", "Initial setup error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.Close()
                Exit Sub
            End If
        Else
            'Me.MdiParent = FrmMain

            'If Not Me.Visible Then
            '    Me.Show()
            'End If

        End If
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
                        'Console.WriteLine("Local file exists")
                        Return True
                    Else
                        MessageBox.Show("Cannot access local drive: " + localFile.FullName.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
            Try
                If (localFile.Exists) Then
                    Return True
                Else
                    MessageBox.Show("Please connect to the server for initial run.")
                End If

            Catch ex As Exception
                Console.WriteLine("Local file failed: " + ex.Message)
            End Try
        Catch ex As Exception
            Console.WriteLine("Error setting up file infos: " & ex.Message)

        End Try
        Return False
    End Function

    Function DoNatInitialSetup() As Boolean
        'connect to db and check for natadmin table, if empty, then return true else false
        checkForConnection(dbName, dbPath)
        'MessageBox.Show("Db string is: " & db.connectionString)
        Try
            db.con.Open()

            db.cmd.CommandText = "SELECT COUNT(CentNo) FROM NatAdminG3;"
            Dim total As Integer = db.cmd.ExecuteScalar()
            ReDim regCentres(total - 1), regCentresNames(total - 1)


            db.cmd.CommandText = "SELECT CentNo, CentName FROM NatAdminG3 ORDER BY CentNo;"
            db.dr = db.cmd.ExecuteReader()

            If db.dr.HasRows Then
                Dim i As Integer = 0
                While db.dr.Read()
                    regCentres(i) = db.dr(0)
                    regCentresNames(i) = db.dr(1)
                    i += 1
                End While

                If total > 1 Then
                    'More than one centre found, show dialog to pick centre
                    'MessageBox.Show("More than one centre found = " & total)
                    centNo = regCentres(0)
                    centName = regCentresNames(0)
                    lblCentNo.Text = centNo
                    lblCentName.Text = centName
                    txtCentNo.Text = centNo
                    'ChangeCentre()
                ElseIf total = 1 Then
                    'has rows, fill in basic details.
                    centNo = regCentres(0)
                    centName = regCentresNames(0)
                    lblCentNo.Text = centNo
                    lblCentName.Text = centName
                    txtCentNo.Text = centNo
                End If

                Try
                    ComboBoxCentres.Items.AddRange(regCentres)
                    'ComboBoxCentres.SelectedIndex = 0
                    ComboBoxCentres.SelectedIndex = ComboBoxCentres.Items.Count - 1
                    lblTotalCentres.Text = "Total = " & regCentres.Length
                Catch ex As Exception

                End Try

                Return False
            Else
                'does not have any row, table empty
                Return True
            End If

        Catch ex As Exception
            Console.WriteLine("Error in DoNatInitialSetup(): " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Function

    Private Sub SetUpConnection(ByVal dbName As String, ByVal dbPath As String)
        'Me.db.dbName = dbName & ".mdb"
        'Me.db.dbPath = dbPath & "\"
    End Sub

    Private Sub checkForConnection(ByVal dbName As String, ByVal dbPath As String)
        SetUpConnection(dbName, dbPath)
        connectionHelper.CheckServerConnection()

        db.connectionString = connectionString
        connected = db.isConnected()

        If connected Then
            btnConnected.BackColor = Color.Indigo
        Else
            btnConnected.BackColor = Color.Red
        End If
    End Sub

    Private Sub frmNatG3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lblVersion.Text = "Ver: " & My.Application.Info.Version.ToString() & " | " & _
        '            My.Application.Info.WorkingSet.ToString()
        lblVersion.Text = "" & My.Application.Info.CompanyName & "  Ver: " & My.Application.Info.Version.ToString() & " | " &
                    My.Application.Info.WorkingSet.ToString()
        Initialise()
    End Sub

    'Private Function CheckAndLoadFiles()
    '    If (File.Exists(serverFile.FullName)) Then
    '        'tssbServerConnection.Image = My.Resources.Ok16x16
    '        tssbServerConnection.BackColor = Color.Green
    '        connectedToServer = True
    '        tssbServerConnection.Text = "Connected"
    '    Else
    '        'tssbServerConnection.Image = My.Resources.Warning16x16
    '        tssbServerConnection.BackColor = Color.Red
    '        connectedToServer = False
    '        tssbServerConnection.Text = "Not Connected"
    '    End If
    'End Function

    Sub Initialise()
        checkForConnection(dbName, dbPath)
        connectionHelper.CheckServerConnection()
        cbGrade.SelectedIndex = 0
        cBoxBlind.Checked = True
        cBoxBlind.Checked = False
        txtBlind.Text = "0"
        nudAttempts.Value = 1
        UpdateCandidateList()
        txtIndexNo.Text = "001"
        'timer.Enabled = False
        dtpDob.CustomFormat = "dd-MM-yyyy"
        lblHeader.Text = connectionHelper.examYear + " " + lblHeader.Text
        btnNew.PerformClick()
    End Sub

    Sub UpdateCandidateList()
        'UpdateListViewCandidate()
        Try
            ListViewCandidates.Items.Clear()
            ListBoxIndexNo.Items.Clear()
        Catch ex As Exception

        End Try


        Try
            db.con1.Open()
            db.cmd1.CommandText = "SELECT CentNo, IndexNo, LastName, FirstName, Initial, Dob, " & _
                "Sex, Disability, Attempts, UpdatedToServer FROM NATGRADE3  WHERE CentNo = '" & txtCentNo.Text & "' ORDER BY CentNo, IndexNo;"
            db.dr1 = db.cmd1.ExecuteReader()

            If db.dr1.HasRows Then
                listEmpty = False
                ListBoxIndexNo.Items.Clear()
                While db.dr1.Read()
                    Dim rowItem As New ListViewItem()

                    ListBoxIndexNo.Items.Add(db.dr1("IndexNo"))
                    rowItem = New ListViewItem(String.Concat(db.dr1(0), db.dr1(1)), 0)
                    rowItem.SubItems.AddRange(New String() {db.dr1(2), db.dr1(3), db.dr1(4), db.dr1(5), db.dr1(6), db.dr1(7), db.dr1(8), db.dr1(9)})

                    If (db.dr1(9).ToString().ToLower() = "false") Then
                        rowItem.BackColor = Color.PaleVioletRed
                    End If

                    ListViewCandidates.Items.Add(rowItem)
                End While
            Else
                ListBoxIndexNo.Items.Clear()
                ListBoxIndexNo.Items.Add(Strings.Format("{0}", "No records found!"))
                Console.WriteLine("No records were found. It looks like no candidates have been entered yet. Please use the spaces below to enter your candidates.", _
                                "No records found!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIndexNo.Text = "001"
                btnAddCandidate.Enabled = True
                setButtonMode(1)
            End If

        Catch ex As Exception
            Console.WriteLine("Error in getting list of students: " & ex.Message)
        Finally
            db.con1.Close()
        End Try

        resetFields()

    End Sub

    Sub UpdateListViewCandidate()
        ListViewCandidates.Items.Clear()
    End Sub

    Sub setButtonMode(ByVal mode As Byte)
        ResetButtons()

        Select Case mode
            Case 0
                'update mode
                btnUpdate.BackColor = Color.DarkSeaGreen
                btnUpdate.Enabled = True
                lblUpdateFeedback.Image = My.Resources.Left_16x16
                lblUpdateFeedback1.Image = My.Resources.Right_16x16

                btnAddCandidate.Enabled = False
                btnAddCandidate.BackColor = Color.PaleVioletRed
                lblAddCandFeedback.Image = Nothing
                lblAddCandFeedback1.Image = Nothing

                delCand.Enabled = True
                delCand.BackColor = Color.DarkSeaGreen
                lblDeleteCandFeedback.Image = My.Resources.Left_16x16
                lblDeleteCandFeedback1.Image = My.Resources.Right_16x16

            Case 1
                'Add mode
                btnUpdate.BackColor = Color.PaleVioletRed
                btnUpdate.Enabled = False
                lblUpdateFeedback.Image = Nothing
                lblUpdateFeedback1.Image = Nothing

                btnAddCandidate.Enabled = True
                btnAddCandidate.BackColor = Color.DarkSeaGreen
                lblAddCandFeedback.Image = My.Resources.Left_16x16
                lblAddCandFeedback1.Image = My.Resources.Right_16x16

                delCand.Enabled = False
                delCand.BackColor = Color.PaleVioletRed
                lblDeleteCandFeedback.Image = Nothing
                lblDeleteCandFeedback1.Image = Nothing

            Case 2
                'delete mode
                btnUpdate.BackColor = Color.PaleVioletRed
                btnUpdate.Enabled = False
                lblUpdateFeedback.Image = Nothing
                lblUpdateFeedback1.Image = Nothing

                btnAddCandidate.Enabled = False
                btnAddCandidate.BackColor = Color.PaleVioletRed
                lblAddCandFeedback.Image = Nothing
                lblAddCandFeedback1.Image = Nothing

                delCand.Enabled = True
                delCand.BackColor = Color.DarkSeaGreen
                lblDeleteCandFeedback.Image = My.Resources.Left_16x16
                lblDeleteCandFeedback1.Image = My.Resources.Right_16x16
            Case Else

        End Select

    End Sub

    Private Sub resetFields()
        skipCheckForFields = True



        txtFirstName.Text = ""
        txtFirstName.BackColor = Color.White
        lblFirstNameFeedback.Image = Nothing

        txtInitial.Text = ""
        txtInitial.BackColor = Color.White
        lblInitialFeedback.Image = Nothing

        dtpDob.Value = Now()
        'txtDob2.Text = "dd-mm-yyyy"
        txtDob2.Text = ""

        lblDobFeedback.Image = Nothing

        cbSex.SelectedIndex = -1
        lblSexFeedback.Image = Nothing

        cBoxBlind.Checked = False
        txtBlind.Text = "0"
        lblBlindInfo.Image = Nothing

        cbDisability.SelectedIndex = -1

        txtAttempts.Text = "1"
        nudAttempts.Value = 1
        lblAttemptsFeedback.Image = Nothing

        txtDOB.Text = Now()
        lblDobFeedback.Image = Nothing

        enableFeedback = False
        skipCheckForFields = False

        'txtLastName.Text = ""
        txtLastName.BackColor = Color.White
        lblLastNameFeedback.Image = Nothing
        txtLastName.SelectAll()
    End Sub

    Sub ResetButtons()
        btnUpdate.Enabled = False
        btnUpdate.BackColor = Color.SkyBlue
        lblUpdateFeedback.Image = Nothing
        lblUpdateFeedback1.Image = Nothing

        Try
            If Strings.Left(ListBoxIndexNo.Items(0), 2).ToLower() = "no" Then
                btnAddCandidate.Enabled = True
            Else
                btnAddCandidate.Enabled = False
            End If
        Catch ex As Exception
            btnAddCandidate.Enabled = True
        End Try

        btnAddCandidate.BackColor = Color.SkyBlue
        lblAddCandFeedback.Image = Nothing
        lblAddCandFeedback1.Image = Nothing

        delCand.Enabled = False
        delCand.BackColor = Color.SkyBlue
        lblDeleteCandFeedback.Image = Nothing
        lblDeleteCandFeedback1.Image = Nothing

    End Sub

    Private Sub btnConnected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnected.Click, btnConnected.MouseEnter
        checkForConnection(dbName, dbPath)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        '
        'resetFields()

        For i As Integer = 0 To ListBoxIndexNo.Items.Count - 1
            If ListBoxIndexNo.Items(i).ToString() = txtIndexNo.Text Then
                ListBoxIndexNo.SelectedIndex = i
                Exit For
            ElseIf i = ListBoxIndexNo.Items.Count - 1 Then
                ListBoxIndexNo.ClearSelected()
            End If
        Next
        updateCandidateDetails()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim result As Short

        If Not CheckForFields() Then
            Exit Sub
        End If

        Try
            If Not db.con.State = ConnectionState.Open Then
                db.con.Open()
            End If

            txtCandName.Text = String.Concat(txtLastName.Text.ToUpper().Trim(), " ", txtFirstName.Text.ToUpper().Trim(), " ", txtInitial.Text.ToUpper().Trim())

            db.cmd.CommandText = "UPDATE NATGRADE3 SET CandName = '" & txtCandName.Text & "', LastName = '" & txtLastName.Text & "', FirstName = '" & txtFirstName.Text &
                "', Initial = '" & txtInitial.Text & "', Sex = '" & cbSex.SelectedItem.ToString() & "', Disability = '" & txtBlind.Text & "', Dob = '" & txtDOB.Text &
                "', Attempts = '" & nudAttempts.Value.ToString() & "', DateModified = Now(), UpdatedToServer = False WHERE ExamYear = '" & connectionHelper.examYear & "' AND CentNo = '" & txtCentNo.Text & "' AND IndexNo = '" & txtIndexNo.Text & "';"

            result = db.cmd.ExecuteNonQuery



        Catch ex As Exception
            Console.WriteLine("sql = " & db.cmd.CommandText)
            Console.WriteLine("Error : " + ex.Message)
            MessageBox.Show("Error !!! Please check fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        Finally
            db.con.Close()
        End Try

        If Result Then
            MessageBox.Show("Updated !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateCandidateList()
            btnNew.PerformClick()
        Else
            MessageBox.Show("Failed to update !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtCentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentNo.TextChanged
        If Strings.Left(txtCentNo.Text, 1) = "3" Then
            cbGrade.SelectedIndex = 0
            txtCentNo.BackColor = Color.White
            'ElseIf Strings.Left(txtCentNo.Text, 1) = "5" Then
            'cbGrade.SelectedIndex = 1
            'txtCentNo.BackColor = Color.White
        Else
            txtCentNo.BackColor = Color.Yellow
        End If

        'If Len(txtCentNo.Text) = 5 Then
        '    txtIndexNo.Focus()
        'End If
        'txtIndexNo.Text = ""
        'resetFields()

    End Sub

    Private Sub txtIndexNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIndexNo.TextChanged
        If Len(txtIndexNo.Text) >= 3 Then
            If (txtIndexNo.Text < "001") Or (txtIndexNo.Text > "999") Then
                MessageBox.Show("Index number: '" & txtIndexNo.Text & "' is not VALID! Please check and retry", _
                                               "Index number not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIndexNo.Text = ""
                ResetButtons()
                txtIndexNo.Focus()
                Exit Sub
            End If

            If ListBoxIndexNo.Items.Contains(txtIndexNo.Text) Then
                'modifying cadidate
                setButtonMode(0)
                lblInfo.Text = ""
                'btnRefresh.PerformClick()
            Else
                'adding new
                'DialogResult = MessageBox.Show("Index number: " & txtIndexNo.Text & " is not in the list, do you want to add a new candidate with this index number?", _
                '                               "Index number not found", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                lblInfo.Text = "Info: Index number: " & txtIndexNo.Text & " is not in the list!"
                DialogResult = Windows.Forms.DialogResult.Yes

                Select Case DialogResult
                    Case DialogResult.Yes
                        'Dim lastEntry As String = Strings.Right("000" + (CInt(ListBoxIndexNo.Items(ListBoxIndexNo.Items.Count - 1)) + 1).ToString(), 3)
                        'txtIndexNo.Text = lastEntry
                        setButtonMode(1)
                        resetFields()
                        txtLastName.Focus()
                    Case DialogResult.No
                        txtIndexNo.Text = ""
                        resetFields()
                        txtIndexNo.Focus()
                End Select

            End If
        End If


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        resetFields()
        txtLastName.Focus()
    End Sub

    Private Sub btnAddCandidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCandidate.Click
        'insert candidate
        If CheckForFields() Then
            If addCandidate2() Then
                btnReload.PerformClick()
                btnNew.PerformClick()
            End If
        End If

    End Sub

    Function CheckForFields() As Boolean
        If skipCheckForFields Then
            Return False
        End If

        Dim allOkay, fieldsChecked As Byte

        If txtLastName.Text = "" Then
            txtLastName.BackColor = Color.PaleVioletRed
            lblLastNameFeedback.Image = My.Resources.Delete_red_16x16
            fieldsChecked += 1
        Else
            txtLastName.BackColor = Color.White
            lblLastNameFeedback.Image = My.Resources.Ok_Round_Green_16x16
            allOkay += 1
            fieldsChecked += 1
        End If

        If txtFirstName.Text = "" Then
            txtFirstName.BackColor = Color.PaleVioletRed
            lblFirstNameFeedback.Image = My.Resources.Delete_red_16x16
            fieldsChecked += 1
        Else
            txtFirstName.BackColor = Color.White
            lblFirstNameFeedback.Image = My.Resources.Ok_Round_Green_16x16
            allOkay += 1
            fieldsChecked += 1
        End If

        'If (DateAndTime.Year(dtpDob.Value) = DateAndTime.Year(dtpNow.Value)) And (DateAndTime.Month(dtpDob.Value) = DateAndTime.Month(dtpNow.Value)) And _
        '    (DateAndTime.Day(dtpDob.Value) = DateAndTime.Day(dtpNow.Value)) Then
        '    'date not changed
        '    lblDobFeedback.Image = My.Resources.Delete_red_16x16
        '    fieldsChecked += 1
        'Else
        '    lblDobFeedback.Image = My.Resources.Ok_Round_Green_16x16
        '    allOkay += 1
        '    fieldsChecked += 1
        'End If

        If (txtDob2.TextLength < 10) Or (txtDob2.TextLength > 10) Then

            lblDobFeedback.Image = My.Resources.Delete_red_16x16
            fieldsChecked += 1
        ElseIf (txtDob2.TextLength = 10) And (Strings.Right(txtDob2.Text, 1) = "y") Then
            lblDobFeedback.Image = My.Resources.Delete_red_16x16
            fieldsChecked += 1
        Else
            lblDobFeedback.Image = My.Resources.Ok_Round_Green_16x16
            allOkay += 1
            fieldsChecked += 1
        End If

        If cbSex.SelectedIndex = -1 Then
            lblSexFeedback.Image = My.Resources.Delete_red_16x16
            fieldsChecked += 1
        Else
            lblSexFeedback.Image = My.Resources.Ok_Round_Green_16x16
            allOkay += 1
            fieldsChecked += 1
        End If

        If cBoxBlind.Checked Then
            lblBlindInfo.Image = Nothing
        Else
            lblBlindInfo.Image = My.Resources.Warning16x16
        End If

        If txtInitial.Text = "" Then
            lblInitialFeedback.Image = My.Resources.Warning16x16
        Else
            lblInitialFeedback.Image = Nothing
        End If

        If allOkay = fieldsChecked Then
            'all okay, return true
            lblErrorFeedback.Text = ""
            Return True
        Else
            lblErrorFeedback.Text = "Please check the fields marked with ""X"""
            enableFeedback = True
            Return False
        End If
    End Function

    Private Sub autoIncrementIndexNo()
        If cbAutoIncIndexNo.Checked Then
            btnNext.PerformClick()
        End If

    End Sub

    Private Sub delCand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delCand.Click
        If txtCentNo.Text = "" Or txtIndexNo.Text = "" Then
            MessageBox.Show("Enter valid centre no and index number please!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not CheckForFields() Then
            Exit Sub
        End If
        Try
            If Not connected Then
                SetUpConnection(dbName, dbPath)
            End If

            db.con.Open()

            db.cmd.CommandText = "Delete * From NATGRADE3 WHERE ExamYear = '" & connectionHelper.examYear & "' AND CentNo = '" & txtCentNo.Text & "' AND IndexNo = '" & txtIndexNo.Text & "';"

            If MessageBox.Show("Are you sure you want to delete candidate " & String.Concat(txtCentNo.Text, txtIndexNo.Text), _
                               "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim result As Short = db.cmd.ExecuteNonQuery

                If result Then
                    MessageBox.Show("Deleted !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnReload.PerformClick()
                    btnPrevious.PerformClick()
                Else
                    MessageBox.Show("Failed to update !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Console.WriteLine("sql = " & db.cmd.CommandText)
            Console.WriteLine("Error : " + ex.Message)
            MessageBox.Show("Error !!! Please check fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            db.con.Close()
        End Try

    End Sub

    Private Function addCandidate2() As Boolean
        Try
            If Not db.isConnected Then
                SetUpConnection(dbName, dbPath)
            End If

            db.con.Open()

            Dim sqlString As String = ""

            'updateToServer - don't forget
            'sqlString += "INSERT INTO NatGrade3 (CentNo, IndexNO, CandName, LastName, FirstName, Initial, Sex, Disability, Dob, Attempts, ReCalculate) VALUES " & _
            '        "('" & txtCentNo.Text & "', '" & txtIndexNo.Text & "', '" & txtCandName.Text & "', '" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & _
            '        txtInitial.Text & "', '"
            sqlString = "INSERT INTO NatGrade3 (ExamYear, CentNo, IndexNO, CandName, LastName, FirstName, Initial, Sex, Disability, Dob, Attempts, DateCreated, DateModified, pcName, userName) VALUES " &
                    "('" & examYear & "','" & txtCentNo.Text & "', '" & txtIndexNo.Text & "', '" & txtCandName.Text.Trim & "', '" & txtLastName.Text.Trim & "', '" & txtFirstName.Text.Trim & "', '" &
                    txtInitial.Text.Trim & "', '"
            If cbSex.SelectedIndex = -1 Then
                sqlString += "', '"
            ElseIf cbSex.SelectedIndex = 0 Then
                sqlString += "F', '"
            ElseIf cbSex.SelectedIndex = 1 Then
                sqlString += "M', '"
            End If

            If txtBlind.Text = "" Then
                sqlString += "', '"
            Else
                sqlString += Strings.Left(txtBlind.Text, 1) & "', '"
            End If

            sqlString += txtDob2.Text & "', '" & txtAttempts.Text & "'"

            sqlString += ", Now(), Now(), '" + Environment.MachineName + "', '" + Environment.UserName + "');"

            db.cmd.CommandText = sqlString

            Dim result As Short = db.cmd.ExecuteNonQuery()

            If result Then
                MessageBox.Show("Candidate added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'btnReload.PerformClick()
                'btnLast.PerformClick()
                'btnNext.PerformClick()
                'btnNew.PerformClick()
                Return True
            Else
                MessageBox.Show("Failed to add candidate", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Console.WriteLine("sql = " & db.cmd.CommandText)
            Console.WriteLine("Error : " + ex.Message)
            MessageBox.Show("Error !!! Please check fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            db.con.Close()
        End Try
        Return False

    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        resetFields()

        If txtCentNo.Text = "" Then
            txtCentNo.Text = centNo
        End If

        If txtIndexNo.Text = "" Then
            txtIndexNo.Text = "001"
            btnRefresh.PerformClick()
            Exit Sub
        End If

        Dim temp As Integer = CInt(txtIndexNo.Text) + 1

        If temp < 10 Then
            txtIndexNo.Text = "00" & temp.ToString()
        ElseIf temp < 100 Then
            txtIndexNo.Text = "0" & temp.ToString()
        Else
            txtIndexNo.Text = "" & temp.ToString()
        End If
        'btnRefresh.PerformClick()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        resetFields()

        If txtCentNo.Text = "" Then
            txtCentNo.Text = centNo
        End If

        If txtIndexNo.Text = "" Then
            txtIndexNo.Text = "001"
        End If

        Dim temp As Integer = CInt(txtIndexNo.Text) - 1
        If temp <= 0 Then
            txtIndexNo.Text = "001"
        ElseIf temp < 10 Then
            txtIndexNo.Text = "00" & temp.ToString()
        ElseIf temp < 100 Then
            txtIndexNo.Text = "0" & temp.ToString()
        Else
            txtIndexNo.Text = "" & temp.ToString()
        End If
        btnRefresh.PerformClick()
    End Sub

    Private Sub txtDOB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDOB.TextChanged
        'If txtDOB.TextLength = 2 Or txtDOB.TextLength = 5 Then
        '    'txtDOB.AppendText("/")
        'End If
    End Sub

    Private Sub dtpDob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDob.ValueChanged
        txtDOB.Text = String.Format("{0}-{1}-{2}", _
                                    Strings.Right(("00" & DateAndTime.Day(dtpDob.Value).ToString()), 2), _
                                    Strings.Right(("00" & DateAndTime.Month(dtpDob.Value).ToString()), 2), _
                                    DateAndTime.Year(dtpDob.Value))
        txtDob2.Text = txtDOB.Text
        If (txtLastName.Text <> "") Or txtFirstName.Text <> "" Then
            CheckForFields()
        End If

    End Sub

    Private Sub nudAttempts_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudAttempts.ValueChanged
        txtAttempts.Text = nudAttempts.Value.ToString()
    End Sub

    Private Sub cBoxBlind_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxBlind.CheckedChanged
        If cBoxBlind.Checked Then
            txtBlind.Text = 1
        Else
            txtBlind.Text = 0
        End If
    End Sub

    'Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    'End Sub

    Private Sub ListBoxIndexNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIndexNo.SelectedIndexChanged, ListBoxIndexNo.SelectedValueChanged, ListBoxIndexNo.Click
        'update with candidate details
        'updateCandidateDetails()
    End Sub

    Function updateCandidateDetails() As Boolean
        Try
            If Strings.Left(ListBoxIndexNo.SelectedItem.ToString(), 2).ToLower() = "no" Then
                listEmpty = True
                Return False
            End If
        Catch ex As Exception
        End Try


        Try
            If db.con.State = ConnectionState.Closed Then
                db.con.Open()
            End If

            db.cmd.CommandText = "SELECT CentNo, IndexNo, LastName, FirstName, Initial, " &
                "Sex, Disability, Dob, Attempts, UpdatedToServer FROM NATGRADE3 WHERE IndexNo = '" &
                ListBoxIndexNo.SelectedItem.ToString() & "' AND CentNo = '" & txtCentNo.Text & "' ORDER BY CentNo, IndexNo;"

            If Not db.dr.IsClosed() Then
                db.dr.Close()
            End If

            db.dr = db.cmd.ExecuteReader()

            Dim i As Integer = 0

            While db.dr.Read()
                txtIndexNo.Text = db.dr("IndexNo")
                txtLastName.Text = db.dr("LastName")
                txtFirstName.Text = db.dr("FirstName")
                txtInitial.Text = db.dr("Initial")

                Try
                    cbSex.SelectedItem = db.dr("Sex")
                Catch ex As Exception
                End Try

                Try
                    'cBoxBlind.Checked = CInt(db.dr("Disability"))
                    cbDisability.SelectedIndex = CInt(db.dr("Disability"))
                Catch ex As Exception
                End Try

                Try
                    'MessageBox.Show("dob received is: " & db.dr("Dob"))
                    dtpDob.Value = db.dr("Dob")
                    txtDob2.Text = txtDOB.Text
                Catch ex As Exception
                End Try

                nudAttempts.Value = CInt(db.dr("Attempts"))

                i += 1
            End While

            listEmpty = False
        Catch ex As Exception
            Console.WriteLine("Error in getting list of students: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Function

    Private Sub UpdateCandName(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged, txtFirstName.TextChanged
        Dim tb As TextBox = sender

        If tb.Text = "" Then
            Exit Sub
        End If

        If tb.Text(tb.TextLength - 1) = " " And tb.Name = "txtLastName" Then
            'space detected
            tb.Text = tb.Text.Trim()
            ProcessTabKey(True)
        End If

        If (tb.Text(tb.TextLength - 1).ToString().ToLower < "a") Or (tb.Text(tb.TextLength - 1).ToString().ToLower > "z") Then
            tb.BackColor = Color.PaleVioletRed
            Exit Sub
        Else
            tb.BackColor = Color.White
            tb.Text = tb.Text.ToUpper()
        End If
        'For i As Integer = 0 To tb.TextLength - 1

        'Next

        tb.Text = Trim(tb.Text)
        tb.Select(tb.TextLength, 0)

        txtCandName.Text = String.Concat(txtLastName.Text.ToUpper().Trim(), " ", txtFirstName.Text.ToUpper().Trim(), " ", txtInitial.Text.ToUpper().Trim())
    End Sub

    Private Sub txtInitial_TextChanged(sender As Object, e As EventArgs) Handles txtInitial.TextChanged
        Dim tb As TextBox = sender

        If tb.Text = "" Then
            txtCandName.Text = String.Concat(txtLastName.Text.ToUpper().Trim(), " ", txtFirstName.Text.ToUpper().Trim(), " ", txtInitial.Text.ToUpper().Trim())
            Exit Sub
        End If

        If ((tb.Text(tb.TextLength - 1) = " ") Or (tb.Text(tb.TextLength - 1).ToString().ToLower() >= "a") Or (tb.Text(tb.TextLength - 1).ToString().ToLower() <= "z")) Then
            tb.BackColor = Color.White
            tb.Text = tb.Text.ToUpper()
        Else
            tb.BackColor = Color.PaleVioletRed
            Exit Sub
        End If

        tb.Select(tb.TextLength, 0)

        txtCandName.Text = String.Concat(txtLastName.Text.ToUpper().Trim(), " ", txtFirstName.Text.ToUpper().Trim(), " ", txtInitial.Text.ToUpper().Trim())
    End Sub

    Private Sub lblInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInfo.TextChanged
        If lblInfo.Text = "" Then
            lblInfo.BackColor = Color.Transparent
        Else
            lblInfo.BackColor = Color.PaleGoldenrod
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click

        'update with candidate details
        UpdateCandidateList()
        'ListBoxIndexNo.SelectedIndex = 0
        'btnPrevious.PerformClick()
        'updateCandidateDetails()

        'update total records count
        UpdateTotals()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        resetFields()

        Try
            ListBoxIndexNo.SelectedIndex = ListBoxIndexNo.Items.Count - 1
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        resetFields()

        Try
            ListBoxIndexNo.SelectedIndex = 0
        Catch ex As Exception
        End Try

    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        If Not enableFeedback Then
            lblErrorFeedback.Visible = False
            Return
        End If

        If lblErrorFeedback.Visible = True Then
            lblErrorFeedback.Visible = False
        Else
            lblErrorFeedback.Visible = True
        End If
    End Sub

    Private Sub cbSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSex.SelectedIndexChanged
        CheckForFields()
        txtDob2.Focus()
    End Sub

    Private Sub lblErrorFeedback_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblErrorFeedback.TextChanged
        If lblErrorFeedback.Text = "" Then
            timer.Enabled = False
        Else
            timer.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'btbNew
        'Try
        '    'btnReload.PerformClick()
        '    btnLast.PerformClick()
        '    btnNext.PerformClick()
        'Catch ex As Exception

        'End Try

        If listEmpty Then
            txtIndexNo.Text = "001"
            Exit Sub
        End If

        resetFields()

        If txtCentNo.Text = "" Then
            txtCentNo.Text = centNo
        End If

        If txtIndexNo.Text = "" Then
            txtIndexNo.Text = "001"
            'btnRefresh.PerformClick()
            Exit Sub
        End If
        'Dim temp As Integer = CInt(txtIndexNo.Text) + 1
        Dim temp As Integer = CInt(ListBoxIndexNo.Items.Count) + 1

        txtIndexNo.Text = Strings.Right("00" & temp.ToString(), 3)

        'btnRefresh.PerformClick()

    End Sub

    Private Sub ListViewCandidates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewCandidates.Click
        Dim obj As Object = Strings.Left(Strings.Right(ListViewCandidates.SelectedItems.Item(0).ToString(), 4), 3)
        If ListBoxIndexNo.Items.Contains(obj) Then
            'MessageBox.Show("index changed to: " & obj.ToString())
            ListBoxIndexNo.SelectedItem = obj.ToString()
        End If
    End Sub

    Private Sub txtDob2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDob2.Enter
        Dim txt As TextBox = sender
        txt.SelectAll()
    End Sub

    Private Sub txtDob2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDob2.TextChanged
        Dim txt As TextBox = sender

        Try
            Select Case txt.TextLength
                Case 1
                    If (Strings.Right(txt.Text, 1) < "0") Or (Strings.Right(txt.Text, 1) > "3") Then
                        txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                        Exit Select
                    End If
                Case 2
                    If (Strings.Right(txt.Text, 1) < "0") Or (Strings.Right(txt.Text, 1) > "9") Then
                        'txt.Text = txt.Text.Remove(txt.TextLength - 1, 1)
                        txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                        Exit Select
                    End If

                    If txt.TextLength = 2 Then
                        txt.Text += "-"
                    End If
                Case 4
                    If (Strings.Right(txt.Text, 1) < "0") Or (Strings.Right(txt.Text, 1) > "1") Then
                        txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                    End If
                Case 5

                    Select Case txt.Text(3)
                        Case "0"
                            If (Strings.Right(txt.Text, 1) < "0") Or (Strings.Right(txt.Text, 1) > "9") Then
                                txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                                Exit Select
                            End If
                        Case "1"
                            If (Strings.Right(txt.Text, 1) < "0") Or (Strings.Right(txt.Text, 1) > "2") Then
                                txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                                Exit Select
                            End If
                    End Select

                    If txt.TextLength = 5 Then
                        Select Case Strings.Mid(txt.Text, 4, 2)
                            Case "02"
                                If (Strings.Mid(txt.Text, 1, 2) > 29) Then
                                    MessageBox.Show("February does not have more than 29 days! Please date again.", "Day Error", _
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txt.Text = ""
                                End If
                            Case "09", "04", "06", "11"
                                If (Strings.Mid(txt.Text, 1, 2) > 30) Then
                                    MessageBox.Show(DateAndTime.MonthName(CInt(Strings.Mid(txt.Text, 4, 2))) & " has only 30 days! Please date again.", _
                                                    "Day Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txt.Text = ""
                                End If
                            Case Else

                        End Select

                        txt.Text += "-"
                    End If
                Case 7
                    If (Strings.Right(txt.Text, 1) < "1") Or (Strings.Right(txt.Text, 1) > "2") Then
                        txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                        Exit Select
                    End If
                Case 8
                    'Select Case txt.Text(6)
                    '    Case "1"
                    '        If (Strings.Right(txt.Text, 1) <> "9") Then
                    '            txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                    '            Exit Select
                    '        End If
                    '    Case "2"
                    '        If (Strings.Right(txt.Text, 1) <> "0") Then
                    '            txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                    '            Exit Select
                    '        End If
                    '    Case Else

                    'End Select


                Case 9
                    Select Case Strings.Mid(txt.Text, 7, 2)
                        Case "19"
                            If (Strings.Right(txt.Text, 1) <> "9") And (Strings.Right(txt.Text, 1) <> "8") Then
                                txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                                Exit Select
                            End If
                        Case "20"
                            If (Strings.Right(txt.Text, 1) > Strings.Mid(DateAndTime.Now().Year().ToString(), 3, 1)) Then
                                txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                                Exit Select
                            End If
                        Case Else

                    End Select


                Case 10
                    If (Strings.Mid(txt.Text, 9, 1) = "y") Then
                        Exit Select
                    End If

                    If (Strings.Right(txt.Text, 1) < "0") Or (Strings.Right(txt.Text, 1) > "9") Then
                        txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                        Exit Select
                    End If

                    If txt.TextLength = 10 Then
                        Try
                            dtpDob.Value = txt.Text
                            txt.Select(txt.TextLength, 0)
                            CheckForFields()
                            ProcessTabKey(True)
                            btnAddCandidate.Focus()
                            Return
                        Catch ex As Exception
                        End Try

                    End If
                Case Is > 10
                    txt.Text = txt.Text.Substring(0, txt.TextLength - 1)
                    Exit Select
            End Select
        Catch ex As Exception
            MessageBox.Show("Please check Date of birth field!", "Date of birth error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        txt.Select(txt.TextLength, 0)
        CheckForFields()

    End Sub

    Private Sub txtDob2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDob2.KeyDown
        Dim txt As TextBox = sender
        e.Handled = True
        If e.KeyCode = 8 Then
            If (txt.TextLength = 6) Then
                txt.Text = Strings.Left(txt.Text, 4)
            ElseIf (txt.TextLength = 3) Then
                txt.Text = Strings.Left(txt.Text, 1)
            End If

        End If
    End Sub

    Private Sub lblDobFeedback_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDobFeedback.VisibleChanged
        txtDobExample.Visible = lblDobFeedback.Visible
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnChangeCentre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeCentre.Click
        ChangeCentre()
    End Sub

    Private Sub ChangeCentre()
        Dim frm As frmNatCentreChangeG3
        Dim selectedCentre() As String = {"-1"}

        frm = New frmNatCentreChangeG3(regCentres, regCentresNames, selectedCentre)

        Dim result As Integer = frm.ShowDialog()
        ' result = 1 --> okay clicked
        ' result = 2 --> canceled clicked
        If result = 1 Then
            'change centre code in txtbox and also name
            txtCentNo.Text = selectedCentre(0)
            For i As Integer = 0 To regCentres.Length - 1
                If regCentres(i) = selectedCentre(0) Then
                    txtCentNo.Text = regCentres(i)
                    lblCentNo.Text = regCentres(i)
                    lblCentName.Text = regCentresNames(i)
                    resetFields()
                    btnReload.PerformClick()
                    Exit Sub
                End If
            Next
        Else
            'no change of centre, do nothing
        End If
    End Sub

    Private Sub btnAddRemoveCentres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRemoveCentres.Click
        Dim frmAdd As New frmNATSetupG3
        Dim result As Integer = frmAdd.ShowDialog()

        If result = DialogResult.OK Then
            'all okay continue loading 
            'Me.Show()
            'Me.Close()
            Dim newFrmNatG3 As New frmNatG3
            'newFrmNatG3.MdiParent = FrmMain
            newFrmNatG3.Show()
            Me.Close()
            'btnReload.PerformClick()
            'ComboBoxCentres.SelectedIndex = ComboBoxCentres.Items.Count - 1
        Else
            'MessageBox.Show("Error in adding centre. Please try again!", "Error in adding centre", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.Close()
        End If
    End Sub

    Private Sub btnRemoveCentre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveCentre.Click
        'Me.Visible = False
        Dim frm As frmNatCentreRemoveG3
        Dim selectedCentre() As String = {"-1"}

        frm = New frmNatCentreRemoveG3(regCentres, regCentresNames)

        Dim result As Integer = frm.ShowDialog()
        ' result = 1 --> okay clicked
        ' result = 2 --> canceled clicked
        If result = 1 Then
            'change centre code in txtbox and also name
            'txtCentNo.Text = selectedCentre(0)
            'Me.frmNatQuery_Load(New Object(), New System.EventArgs())

            Dim newFrmNat1 As New frmNatG3()
            'newFrmNat1.MdiParent = FrmMain
            Try
                newFrmNat1.Show()
                Me.Close()
            Catch ex As Exception

            End Try
        Else
            'no change of centre, do nothing
            'Me.Visible = True
            'Dim newFrmNat1 As New frmNat()
            'newFrmNat1.MdiParent = FrmMain
            'Try
            '    newFrmNat1.Show()
            'Catch ex As Exception

            'End Try
        End If
    End Sub

    Private Sub ComboBoxCentres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxCentres.SelectedIndexChanged
        txtCentNo.Text = ComboBoxCentres.SelectedItem.ToString()
        For i As Integer = 0 To regCentres.Length - 1
            If regCentres(i) = txtCentNo.Text Then
                txtCentNo.Text = regCentres(i)
                lblCentNo.Text = regCentres(i)
                lblCentName.Text = regCentresNames(i)
                resetFields()
                btnReload.PerformClick()
                Exit Sub
            End If
        Next

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not db.isConnected Then
            MessageBox.Show("db connected: " & db.connectionString)
            Exit Sub
        End If

        'Dim frmNatCR As New frmNatCandidateReport(db)
        'frmNatCR.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateServerG3.Click
        If Not connectionHelper.connectedToServer Then
            'Return
        End If

        'MessageBox.Show("Sorry, but the operation is not yet possible.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If UpdateToServer() Then
            MessageBox.Show("Update Completed", "completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnReload.PerformClick()
        Else
            MessageBox.Show("Failed to update server", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub cbSex_Enter(sender As System.Object, e As System.EventArgs) Handles cbSex.Enter
        cbSex.DroppedDown = True
    End Sub

    Private Sub cbDisability_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbDisability.SelectedIndexChanged
        txtBlind.Text = cbDisability.SelectedIndex().ToString()
    End Sub

    Private Sub ListViewCandidates_ColumnClick(sender As System.Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewCandidates.ColumnClick
        Select Case e.Column
            Case 0
                If ListViewCandidates.Sorting = System.Windows.Forms.SortOrder.Ascending Then
                    ListViewCandidates.Sorting = System.Windows.Forms.SortOrder.Descending
                Else
                    ListViewCandidates.Sorting = System.Windows.Forms.SortOrder.Ascending
                End If
        End Select
        ListViewCandidates.Refresh()
    End Sub

    Private Function UpdateToServer() As Boolean

        Try
            Dim sqls As New List(Of String)
            Dim totalAffected As Integer
            db.con.Open()

            Try
                'check to see whether connected to server first.
                If (Not File.Exists(My.Resources.dbPathServer + My.Resources.dbName)) Then
                    MessageBox.Show("Cannot connect to server. Please check connection", "cannot find server", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot connect to server. Please check connection", "cannot find server", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End Try


            'update DateModified for blank fields
            sqls.Add("UPDATE NATGRADE3 SET DateModified = Now() WHERE DateModified IS NULL")

            sqls.Add("UPDATE NATGRADE3 SET pcName = '" + Environment.MachineName + "', userName = '" + Environment.UserName + "' WHERE (pcName Is NULL) OR (userName IS NULL);")

            'Insert NatAdminG3
            sqls.Add(
                "INSERT INTO NatAdminG3S ( ExamYear, CentNo, CentName, Location, Owner, [Password], SchoolListed, DateFirstUsed, ContactName, ContactPhoneNumber, ClusterId ) " +
                "SELECT NatAdminG3.ExamYear, NatAdminG3.CentNo, NatAdminG3.CentName, NatAdminG3.Location, NatAdminG3.Owner, NatAdminG3.Password, NatAdminG3.SchoolListed, NatAdminG3.DateFirstUsed, NatAdminG3.ContactName, NatAdminG3.ContactPhoneNumber, NatAdminG3.ClusterId " +
                "FROM NatAdminG3 LEFT JOIN NatAdminG3S ON (NatAdminG3.CentNo = NatAdminG3S.CentNo) AND (NatAdminG3.ExamYear = NatAdminG3S.ExamYear) WHERE NatAdminG3S.DateFirstUsed IS NULL;"
                )

            'Insert NatGrade3
            sqls.Add(
                "INSERT INTO NATGRADE3S ( ExamYear, CentNo, IndexNo, CandName, LastName, FirstName, Initial, Sex, Disability, Dob, Attempts, DateCreated, DateModified, pcName, userName ) " +
                "SELECT NATGRADE3.ExamYear, NATGRADE3.CentNo, NATGRADE3.IndexNo, NATGRADE3.CandName, NATGRADE3.LastName, NATGRADE3.FirstName, NATGRADE3.Initial, NATGRADE3.Sex, NATGRADE3.Disability, NATGRADE3.Dob, NATGRADE3.Attempts, NATGRADE3.DateCreated, NATGRADE3.DateModified, NATGRADE3.pcName, NATGRADE3.userName " +
                "FROM NATGRADE3 LEFT JOIN NATGRADE3S ON (NATGRADE3.IndexNo = NATGRADE3S.IndexNo) AND (NATGRADE3.CentNo = NATGRADE3S.CentNo) AND (NATGRADE3.ExamYear = NATGRADE3S.ExamYear) WHERE NATGRADE3S.DateCreated IS NULL;"
                )

            'Check for those that haven't been transferred
            'update tables

            'get mismatch data
            db.cmd.CommandText = "SELECT NATGRADE3.ExamYear, NATGRADE3.CentNo, NATGRADE3.IndexNo " +
                "FROM NATGRADE3 INNER JOIN NATGRADE3S ON (NATGRADE3.DateCreated = NATGRADE3S.DateCreated) AND (NATGRADE3.IndexNo = NATGRADE3S.IndexNo) AND (NATGRADE3.CentNo = NATGRADE3S.CentNo) AND (NATGRADE3.ExamYear = NATGRADE3S.ExamYear) " +
                "WHERE (NATGRADE3.DateModified <> NATGRADE3S.DateModified);"

            If (Not db.dr.IsClosed()) Then
                db.dr.Close()
            End If

            db.dr = db.cmd.ExecuteReader()

            While (db.dr.Read())
                sqls.Add(
                    "UPDATE NATGRADE3S INNER JOIN NATGRADE3 ON (NATGRADE3S.DateCreated = NATGRADE3.DateCreated) AND (NATGRADE3S.IndexNo = NATGRADE3.IndexNo) AND (NATGRADE3S.CentNo = NATGRADE3.CentNo) AND (NATGRADE3S.ExamYear = NATGRADE3.ExamYear) " +
                    "SET NATGRADE3S.CandName = NATGRADE3.CandName, NATGRADE3S.LastName = NATGRADE3.LastName, " +
                    "NATGRADE3S.FirstName = NATGRADE3.FirstName, NATGRADE3S.Initial = NATGRADE3.Initial, NATGRADE3S.Sex = NATGRADE3.Sex, " +
                    "NATGRADE3S.Disability = NATGRADE3.Disability, NATGRADE3S.Dob = NATGRADE3.Dob, NATGRADE3S.Attempts = NATGRADE3.Attempts, " +
                    "NATGRADE3S.DateCreated = NATGRADE3.DateCreated, NATGRADE3S.DateModified = NATGRADE3.DateModified " +
                    "WHERE (NATGRADE3S.ExamYear = '" + db.dr("ExamYear") + "') AND (NATGRADE3S.CentNo = '" + db.dr("CentNo") + "') AND (NATGRADE3S.IndexNo = '" + db.dr("IndexNo") + "')"
                    )
            End While

            If (Not db.dr.IsClosed()) Then
                db.dr.Close()
            End If
            'update NatAdminG3

            'Update NatGrade3

            'Clean up and append username and pcname and 
            'update updated flag
            sqls.Add(
                "UPDATE NATGRADE3 INNER JOIN NATGRADE3S ON (NATGRADE3.DateCreated = NATGRADE3S.DateCreated) " +
                "AND (NATGRADE3.DateModified = NATGRADE3S.DateModified) AND (NATGRADE3.IndexNo = NATGRADE3S.IndexNo) " +
                "AND (NATGRADE3.CentNo = NATGRADE3S.CentNo) AND (NATGRADE3.ExamYear = NATGRADE3S.ExamYear) " +
                "SET NATGRADE3.UpdatedToServer = True, NATGRADE3S.pcName = '" + Environment.UserName + "', NATGRADE3S.userName = '" + Environment.MachineName + "' " +
                "WHERE NATGRADE3.UpdatedToServer = False"
                )

            'update local copy from server
            sqls.Add(
                "INSERT INTO NatAdminG3 ( ExamYear, CentNo, CentName, Location, Owner, [Password], SchoolListed, DateFirstUsed, ContactName, ContactPhoneNumber, ClusterId ) " &
                "SELECT NatAdminG3S.ExamYear, NatAdminG3S.CentNo, NatAdminG3S.CentName, NatAdminG3S.Location, NatAdminG3S.Owner, NatAdminG3S.Password, NatAdminG3S.SchoolListed, NatAdminG3S.DateFirstUsed, NatAdminG3.ContactName, NatAdminG3.ContactPhoneNumber, NatAdminG3.ClusterId " &
                "FROM NatAdminG3S LEFT JOIN NatAdminG3 ON (NatAdminG3S.CentNo = NatAdminG3.CentNo) AND (NatAdminG3S.ExamYear = NatAdminG3.ExamYear) " &
                "WHERE (((NatAdminG3.ExamYear) Is Null) AND ((NatAdminG3.CentNo) Is Null)); "
                )

            sqls.Add(
                "INSERT INTO NATGRADE3 ( ExamYear, CentNo, IndexNo, CandName, LastName, FirstName, Initial, Sex, Disability, Dob, Attempts, UpdatedToServer, DateCreated, DateModified, pcName, userName, NewRecord, NewRecord1 ) " &
                "SELECT NATGRADE3S.ExamYear, NATGRADE3S.CentNo, NATGRADE3S.IndexNo, NATGRADE3S.CandName, NATGRADE3S.LastName, NATGRADE3S.FirstName, NATGRADE3S.Initial, NATGRADE3S.Sex, NATGRADE3S.Disability, NATGRADE3S.Dob, NATGRADE3S.Attempts, NATGRADE3S.UpdatedToServer, NATGRADE3S.DateCreated, NATGRADE3S.DateModified, NATGRADE3S.pcName, NATGRADE3S.userName, NATGRADE3S.NewRecord, NATGRADE3S.NewRecord1 " &
                "FROM NATGRADE3S LEFT JOIN NATGRADE3 ON (NATGRADE3S.IndexNo = NATGRADE3.IndexNo) And (NATGRADE3S.CentNo = NATGRADE3.CentNo) And (NATGRADE3S.ExamYear = NATGRADE3.ExamYear) " &
                "WHERE (((NATGRADE3.ExamYear) Is Null) And ((NATGRADE3.CentNo) Is Null) And ((NATGRADE3.IndexNo) Is Null));"
                )

            'run sqls
            Dim transaction As OleDb.OleDbTransaction

            transaction = db.con.BeginTransaction(IsolationLevel.ReadCommitted)
            db.cmd.Transaction = transaction

            For Each sql As String In sqls
                db.cmd.CommandText = sql

                Try
                    totalAffected += db.cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine("Error in UpdateToServer: " + ex.Message)
                    'MessageBox.Show(ex.Message)
                End Try
            Next

            'commit transaction
            transaction.Commit()

            'Update local from server

            MessageBox.Show("Total Affected: " + totalAffected.ToString())

            Return True
        Catch ex As Exception
            MessageBox.Show("Error Connecting to DATABASE!", "connecting error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.con.Close()
        End Try
        Return False
    End Function

    Private Sub ButtonSync_Click(sender As Object, e As EventArgs) 
        ' updates local copy from server db
    End Sub

    Private Sub ListBoxIndexNo_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxIndexNo.DoubleClick, ListViewCandidates.DoubleClick
        updateCandidateDetails()
    End Sub

    Private Sub TrimTextBox_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave, txtInitial.Leave
        Dim tb As TextBox = sender

        tb.Text = tb.Text.Trim
    End Sub

    Private Sub buttonCheckProgress_Click(sender As Object, e As EventArgs) Handles buttonCheckProgress.Click
        Dim frm As FormCheckProgress = New FormCheckProgress()
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub btnUpdateServerG3_MouseHover(sender As Object, e As EventArgs) Handles btnUpdateServerG3.MouseHover
        connectionHelper.CheckServerConnection()
        If (connectionHelper.connectedToServer) Then
            'btnUpdateServerG3.BackColor = Color.Green
            btnUpdateServerG3.UseVisualStyleBackColor = True
        Else
            btnUpdateServerG3.BackColor = Color.Red
        End If
    End Sub

    Private Function UpdateTotals() As Boolean
        Try
            lblTotalRecordsCentre.Text = ListViewCandidates.Items.Count.ToString()

            If Not db.isConnected Then
                SetUpConnection(dbName, dbPath)
            End If

            db.con4.Open()
            db.cmd4.CommandText = "SELECT COUNT(CentNo) from NATGrade3;"

            'If (Not db.dr4.IsClosed) Then
            '    db.dr4.Close()
            'End If

            lblTotalRecords.Text = db.cmd4.ExecuteScalar().ToString()

            'While db.dr4.Read()
            '    lblTotalRecords.Text = db.dr4(0)
            'End While

            Return True
        Catch ex As Exception
            Console.WriteLine("Error getting totals: " & ex.Message)
        Finally
            db.con4.Close()
        End Try
        Return False
    End Function
End Class