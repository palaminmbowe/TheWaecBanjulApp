Imports WaecLibrary

Public Class frmNATSetupG5

    Private db As New dbConnection2
    Dim connected As Boolean
    Dim dbName = "GABECE"
    Dim dbPath = System.Environment.CurrentDirectory.ToString()
    Dim sourceTable As String = "NATGrade5"
    'Dim connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '        My.Resources.dbPathLocal + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"
    Dim connectionString = My.Resources.CString1 &
            My.Resources.dbPathLocal + My.Resources.dbName + ";Jet OLEDB:Database Password=Waec@Nat;"

    Dim CentNo, CentName, CentAddress, CentLoc, CentOwner As String()
    Dim schoolListed As Integer
    Dim connectionHelper As ConnectionHelper


    Private Sub frmNATSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkForConnection(dbName, dbPath)

        updateNatAdminG5ServerLocal()

        populateCentres()

        connectionHelper = New ConnectionHelper()
        connectionHelper.InitialLoad()

    End Sub

    Private Sub updateNatAdminG5ServerLocal()
        Try
            db.con.Open()

            db.cmd.CommandText = "INSERT INTO NatAdminG5ServerLocal ( ExamYear, CentNo ) " &
                "Select NatAdminG5Server.ExamYear, NatAdminG5Server.CentNo " &
                "From NatAdminG5Server LEFT Join NatAdminG5ServerLocal On NatAdminG5Server.CentNo = NatAdminG5ServerLocal.CentNo " &
                "Where (((NatAdminG5ServerLocal.CentNo) Is Null)); "

            Dim result As Integer = db.cmd.ExecuteNonQuery()
            Console.WriteLine("Result of " & db.cmd.CommandText & " = " & result)

        Catch ex As Exception
            Console.WriteLine("Error in populating centres: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Sub populateCentres()
        Try
            db.con.Open()

            'get count of centres

            'db.cmd.CommandText = "SELECT COUNT(CentNO) FROM NATCentresG5"
            db.cmd.CommandText = "SELECT COUNT(NATCentresG5.CentNO) FROM NATCentresG5 " &
            "LEFT JOIN NatAdminG5ServerLocal On NATCentresG5.CentNo = NatAdminG5ServerLocal.CentNo " &
            "WHERE (((NatAdminG5ServerLocal.CentNo) Is Null)) "


            Dim totalCentres As Integer = db.cmd.ExecuteScalar() - 1

            'MessageBox.Show("Total Centres are: " & totalCentres)

            ReDim CentNo(totalCentres), CentName(totalCentres), CentAddress(totalCentres), CentLoc(totalCentres), CentOwner(totalCentres)

            'db.cmd.CommandText = "SELECT CentNo, CentName, Location, Owner, CentAddress FROM NATCentresG5 ORDER BY CentNo;"
            db.cmd.CommandText = "SELECT NATCentresG5.CentNo, NATCentresG5.CentName, NATCentresG5.Location, NATCentresG5.Owner, NATCentresG5.CentAddress " &
                "FROM NATCentresG5 LEFT JOIN NatAdminG5ServerLocal ON NATCentresG5.CentNo = NatAdminG5ServerLocal.CentNo " &
                "WHERE (((NatAdminG5ServerLocal.CentNo) Is Null)) ORDER BY NATCentresG5.CentNo;"


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
            Catch ex As Exception
                Console.WriteLine("Error in adding to list: " & ex.Message)
            End Try

        Catch ex As Exception
            Console.WriteLine("Error in populating centres: " & ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub

    Private Sub SetUpConnection(ByVal dbName As String, ByVal dbPath As String)
        Me.db.connectionString = connectionString

    End Sub

    Private Sub checkForConnection(ByVal dbName As String, ByVal dbPath As String)
        If Not connected Then
            SetUpConnection(dbName, dbPath)
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
                FrmMain.frmNat_G5.DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
            End Try

            'MessageBox.Show("frmNat Dialog result before returning is: " & frmNat.DialogResult)
            Me.Close()
        Else
            Dim result As Integer = MessageBox.Show("There was an error saving your Centre Information. Are you trying to add the same centre twice?", "Data failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            CheckBoxConfirm.Checked = False

            If result = DialogResult.Retry Then
                Exit Sub
            ElseIf result = DialogResult.Cancel Then
                'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                FrmMain.frmNat_G5.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
            sqlString(0) = "DELETE * FROM NatAdminG5;"

            Dim newAddress As String = Replace(txtCentName.Text, "'", "''")

            'check for quotes and replace

            sqlString(1) = "INSERT INTO NatAdminG5 (ExamYear, CentNo, CentName, Location, Owner, SchoolListed, ContactName, ContactPhoneNumber) VALUES ('" & ConnectionHelper.examYear & "', '" &
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

            sqlString(1) += $",'{txtContactName.Text}', '{txtContactPhoneNumber.Text}' );"

            sqlString(2) = "INSERT INTO NatAdminG3ServerLocal (ExamYear, CentNo) VALUES ('" & ConnectionHelper.examYear & "', '" & txtCentNo.Text & "')"

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
            CheckBoxConfirm.BackColor = Color.DarkGoldenrod
            OK_Button.BackColor = Color.PaleVioletRed
        Else
            CheckBoxConfirm.Checked = False
        End If
    End Sub

    Function checkForFields() As Boolean
        Dim allOkay As Boolean = False

        If ((txtCentNo.Text = "") Or (txtCentNo.Text < "50000") Or (txtCentNo.Text) > "59999") Then
            txtCentNo.BackColor = Color.PaleVioletRed
            MessageBox.Show("An invalid centre number was entered! Please that your centre number is not empty! It should start with 3 and be 5 digits in length." & _
                            vbNewLine & vbNewLine & "The last four (4) digits are the same as your GABECE centre number except that it should start with a six (6).", "Invalid Centre Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtCentNo.Text = ""
            Return False
        ElseIf (Strings.Left(txtCentNo.Text, 1) <> 5) Then
            MessageBox.Show("Your centre number should start with a 5.", _
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
            gbLocation.BackColor = Color.DarkGoldenrod
        End If


        If (rbGovernment.Checked = False) And (rbMission.Checked = False) And (rbPrivate.Checked = False) Then
            gbOwner.BackColor = Color.PaleVioletRed
            Return False
        Else
            gbOwner.BackColor = Color.DarkGoldenrod
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