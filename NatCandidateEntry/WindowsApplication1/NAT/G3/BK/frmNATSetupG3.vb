Imports WaecLibrary

Public Class frmNATSetupG3
    Private db As New dbConnection3
    Dim connected As Boolean
    Dim dbName = My.Resources.dbName
    Dim dbPath = My.Resources.dbPathLocal
    Dim sourceTable As String = "NATGrade3"
    Dim connectionString = My.Resources.CString1 &
            My.Resources.dbPathLocal + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"

    Dim CentNo, CentName, CentAddress, CentLoc, CentOwner As String()
    Dim schoolListed As Integer
    Dim connectionHelper As ConnectionHelper


    Private Sub frmNATSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkForConnection(dbName, dbPath)

        updateNatAdminG3ServerLocal()

        populateCentres()

        connectionHelper = New ConnectionHelper()
        connectionHelper.InitialLoad()

    End Sub

    Private Sub updateNatAdminG3ServerLocal()
        Try
            db.con.Open()

            db.cmd.CommandText = "INSERT INTO NatAdminG3ServerLocal ( ExamYear, CentNo ) " &
                "Select NatAdminG3Server.ExamYear, NatAdminG3Server.CentNo " &
                "From NatAdminG3Server LEFT Join NatAdminG3ServerLocal On NatAdminG3Server.CentNo = NatAdminG3ServerLocal.CentNo " &
                "Where (((NatAdminG3ServerLocal.CentNo) Is Null)); "

            Dim result As Integer = db.cmd.ExecuteNonQuery()
            Console.WriteLine("Result of " & db.cmd.CommandText & " = " & result)

        Catch ex As Exception
            Console.WriteLine("Error in populating centres: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub populateCentres()

        'update to exclude centres that have been already updated.

        Try
            db.con.Open()
            'get count of centres

            db.cmd.CommandText = "SELECT COUNT(NATCentresG3.CentNO) FROM NATCentresG3 " ' &
            '"LEFT JOIN NatAdminG3ServerLocal On NATCentresG3.CentNo = NatAdminG3ServerLocal.CentNo " &
            '"WHERE (((NatAdminG3ServerLocal.CentNo) Is Null)) "
            db.cmd.CommandText = "SELECT COUNT(*) FROM NATCentresG3 " &
            "RIGHT JOIN NatAdminG3Server ON NATCentresG3.CentNo = NatAdminG3Server.CentNo;"

            lblTotalCentres.Text = db.cmd.ExecuteScalar()

            'get count of centres

            db.cmd.CommandText = "SELECT COUNT(NATCentresG3.CentNO) FROM NATCentresG3 " &
            "LEFT JOIN NatAdminG3ServerLocal On NATCentresG3.CentNo = NatAdminG3ServerLocal.CentNo " &
            "WHERE (((NatAdminG3ServerLocal.CentNo) Is Null)) "

            Dim totalCentres As Integer = db.cmd.ExecuteScalar() - 1

            'MessageBox.Show("Total Centres are: " & totalCentres)

            ReDim CentNo(totalCentres), CentName(totalCentres), CentAddress(totalCentres), CentLoc(totalCentres), CentOwner(totalCentres)

            'db.cmd.CommandText = "SELECT CentNo, CentName, Location, Owner, CentAddress FROM NATCentresG3 ORDER BY CentNo;"
            db.cmd.CommandText = "SELECT NATCentresG3.CentNo, NATCentresG3.CentName, NATCentresG3.Location, NATCentresG3.Owner, NATCentresG3.CentAddress " &
                "FROM NATCentresG3 LEFT JOIN NatAdminG3ServerLocal ON NATCentresG3.CentNo = NatAdminG3ServerLocal.CentNo " &
                "WHERE (((NatAdminG3ServerLocal.CentNo) Is Null)) ORDER BY NATCentresG3.CentNo;"

            db.dr = db.cmd.ExecuteReader()

            Dim i As Integer = 0
            While db.dr.Read()
                Try
                    CentNo(i) = db.dr(0).ToString().Trim()
                    CentName(i) = db.dr(1).ToString().Trim()

                    Try
                        CentLoc(i) = db.dr(2)
                    Catch ex As Exception
                    End Try

                    Try
                        CentOwner(i) = db.dr(3)
                    Catch ex As Exception
                    End Try

                    Try
                        CentAddress(i) = db.dr(4)
                    Catch ex As Exception
                    End Try


                Catch ex As Exception

                End Try

                i += 1
            End While

            ListBoxCentreNo.Items.Clear()
            Try
                ListBoxCentreNo.Items.AddRange(CentNo)
                lblTotalCentresRemaining.Text = ListBoxCentreNo.Items.Count
            Catch ex As Exception
                Console.WriteLine("Error in adding to list " & ex.Message)
            End Try

        Catch ex As Exception
            Console.WriteLine("Error in populating centres: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Private Sub SetUpConnection()
        Me.db.connectionString = connectionString
    End Sub

    Private Sub checkForConnection(ByVal dbName As String, ByVal dbPath As String)
        If Not connected Then
            SetUpConnection()
            connected = db.isConnected()
        Else
            Console.WriteLine("Connected!")
        End If

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'save data to db
        If SaveCentreData() Then
            MessageBox.Show("Your Centre Information has be successfully saved. Click okay to continue.", "Data saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Try
                FrmMain.frmNat_G3.DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
            End Try

            'MessageBox.Show("frmNat Dialog result before returning Is: " & frmNat.DialogResult)
            Me.Close()
        Else
            Dim result As Integer = MessageBox.Show("There was an error saving your Centre Information. Are you trying to add the same centre twice?", "Data failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            CheckBoxConfirm.Checked = False

            If result = DialogResult.Retry Then
                Exit Sub
            ElseIf result = DialogResult.Cancel Then
                'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                FrmMain.frmNat_G3.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End If
    End Sub

    Function SaveCentreData() As Boolean
        ' Connect to db and save info
        Try
            db.con.Open()

            Dim sqlString(2) As String

            'empty table first
            sqlString(0) = "DELETE * FROM NatAdminG3;"

            Dim newAddress As String = Replace(txtCentName.Text, "'", "''")

            'check for quotes and replace

            sqlString(1) = "INSERT INTO NatAdminG3 (ExamYear, CentNo, CentName, Location, Owner, SchoolListed) VALUES ('" & ConnectionHelper.examYear & "', '" &
                txtCentNo.Text & "','" & newAddress & "','"
            If rbRural.Checked Then
                sqlString(1) += "R'"
            Else
                sqlString(1) += "U'"
            End If

            If rbGovernment.Checked Then
                sqlString(1) += ",'G'"
            ElseIf rbMission.Checked Then
                sqlString(1) += ",'M'"
            ElseIf rbPrivate.Checked Then
                sqlString(1) += ",'P'"
            End If

            If cBoxCentreNotListed.Checked Then
                sqlString(1) += ",-1"
            Else
                sqlString(1) += ",0"
            End If

            sqlString(1) += ");"

            sqlString(2) = "INSERT INTO NatAdminG3ServerLocal (ExamYear, CentNo) VALUES ('" & connectionHelper.examYear & "', '" & txtCentNo.Text & "')"

            For i As Integer = 1 To 2
                db.cmd.CommandText = sqlString(i)
                Dim result As Integer = db.cmd.ExecuteNonQuery()
                Console.WriteLine("Result of " & sqlString(i) & " = " & result)
            Next

            Return True

        Catch ex As Exception
            Console.WriteLine("Error in DoNatInitialSetup(): " & ex.Message)
            'MessageBox.Show("Error in processing. Are you trying to add the same centre twice?", "Error adding centre", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.con.Close()
        End Try
        Return False
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListBoxCentreNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxCentreNo.SelectedIndexChanged
        Dim index As Integer = ListBoxCentreNo.SelectedIndex

        Try
            txtCentNo.Text = String.Concat("", Strings.Right(CentNo(index), 5))
            txtCentName.Text = CentName(index).ToUpper().Trim()
            Try
                txtCentAddress.Text = CentAddress(index).ToUpper().Trim()
            Catch ex As Exception
            End Try


            If CentLoc(index) = "U" Then
                rbUrban.Checked = True
            ElseIf CentLoc(index) = "R" Then
                rbRural.Checked = True
            End If


            Select Case CentOwner(index).ToUpper()
                Case "G"
                    rbGovernment.Checked = True
                Case "P"
                    rbPrivate.Checked = True
                Case "M"
                    rbMission.Checked = True
                Case Else

            End Select
        Catch ex As Exception
            Console.WriteLine("exception filling details" & ex.Message)
        End Try

    End Sub

    Private Sub CheckBoxConfirm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxConfirm.CheckedChanged
        If CheckBoxConfirm.Checked = False Then
            OK_Button.Enabled = False
            OK_Button.BackColor = Color.SkyBlue
            Exit Sub
        End If

        If checkForFields() Then
            OK_Button.Enabled = True
            'OK_Button.PerformClick()
            CheckBoxConfirm.BackColor = Color.Indigo
            OK_Button.BackColor = Color.PaleVioletRed
        Else
            CheckBoxConfirm.Checked = False
        End If
    End Sub

    Function checkForFields() As Boolean
        Dim allOkay As Boolean = False

        If ((txtCentNo.Text = "") Or (txtCentNo.Text < "30000") Or (txtCentNo.Text) > "39999") Then
            txtCentNo.BackColor = Color.PaleVioletRed
            MessageBox.Show("An invalid centre number was entered! Please that your centre number is not empty! It should start with 3 and be 5 digits in length." & _
                            vbNewLine & vbNewLine & "The last four (4) digits are the same as your GABECE centre number except that it should start with a six (6).", "Invalid Centre Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtCentNo.Text = ""
            Return False
        ElseIf (Strings.Left(txtCentNo.Text, 1) <> 3) Then
            MessageBox.Show("Your centre number should start with a 3.", _
                            "Error, please check!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCentNo.BackColor = Color.PaleVioletRed
            txtCentNo.Text = ""
            Return False
        ElseIf (txtCentNo.TextLength <> 5) Then
            txtCentNo.BackColor = Color.PaleVioletRed
            MessageBox.Show("Your centre number should be five (5) digits long.", _
                            "Error, please check!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCentNo.Text = ""
            Return False
        Else
            txtCentNo.BackColor = Color.LightGreen
            txtCentName.Focus()
        End If

        If txtCentName.Text = "" Then
            txtCentName.BackColor = Color.PaleVioletRed
            Return False
        Else
            txtCentName.BackColor = Color.LightGreen
            txtCentAddress.Focus()
        End If

        If txtCentAddress.Text = "" Then
            txtCentAddress.BackColor = Color.PaleVioletRed
            Return False
        Else
            txtCentAddress.BackColor = Color.LightGreen
            gbLocation.Focus()
        End If

        If (rbRural.Checked = False) And (rbUrban.Checked = False) Then
            gbLocation.BackColor = Color.PaleVioletRed
            Return False
        Else
            gbLocation.BackColor = Color.Indigo
        End If


        If (rbGovernment.Checked = False) And (rbMission.Checked = False) And (rbPrivate.Checked = False) Then
            gbOwner.BackColor = Color.PaleVioletRed
            Return False
        Else
            gbOwner.BackColor = Color.Indigo
        End If

        CheckBoxConfirm.BackColor = Color.PaleVioletRed

        allOkay = True

        If allOkay Then
            OK_Button.Enabled = True
            Return True
        Else
            OK_Button.Enabled = False
        End If
    End Function

    Private Sub txtCentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentNo.TextChanged
        Dim i As Integer = 0
        For Each c As Char In txtCentNo.Text
            If (c < "0") Or (c > "9") Then
                txtCentNo.Text = txtCentNo.Text.Remove(i)
                'txtCentNo.AppendText("")
                txtCentNo.SelectionStart = i
                txtCentNo.SelectionLength = 0
                Exit Sub
            End If
            i += 1
        Next

        If (txtCentNo.TextLength = 5) Then
            CheckBoxConfirm.Checked = True
        End If
    End Sub

    Private Sub cBoxCentreNotListed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxCentreNotListed.CheckedChanged
        If cBoxCentreNotListed.Checked Then
            'clear fields and set focus to centNo
            clearFields()
            txtCentNo.Focus()
        ElseIf cBoxCentreNotListed.Checked = False Then
            populateCentres()
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Sub clearFields()
        txtCentNo.Text = ""
        txtCentName.Text = ""
        txtCentAddress.Text = ""

        txtCentNo.BackColor = Color.White
        txtCentName.BackColor = Color.White
        txtCentAddress.BackColor = Color.White

        rbGovernment.Checked = False
        rbMission.Checked = False
        rbPrivate.Checked = False
        rbRural.Checked = False
        rbUrban.Checked = False

        gbLocation.BackColor = Color.MidnightBlue
        gbOwner.BackColor = Color.MidnightBlue
    End Sub

    Private Sub txtCentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentName.TextChanged
        checkForFields()
        txtCentName.Focus()

    End Sub

    Private Sub txtCentAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentAddress.TextChanged
        checkForFields()
        txtCentAddress.Focus()
    End Sub

    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRural.CheckedChanged, rbUrban.CheckedChanged, rbPrivate.CheckedChanged, rbMission.CheckedChanged, rbGovernment.CheckedChanged
        checkForFields()
    End Sub
End Class