Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.IO

Public Class FrmgabEntry

    Dim con As New ConClass
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                 System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon4 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                               System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon5 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                            System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcons As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                          System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")


    Dim subtot1 As Integer = 0
    Dim subtot2 As Integer = 0
    Dim da As New OleDbDataAdapter
    Dim dp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim cmd As New OleDbCommand
    Dim recno As Integer
    Dim subtots As Integer = 4
    Dim sex As Integer
    Dim English As String = "111"
    Dim Math As String = "112"
    Dim Science As String = "113"
    Dim SES As String = "114"
    Dim Len As Integer
    Dim Len1 As Integer
    Dim SubjectsArray(Len) As String
    Dim SubjectsArray1(Len1) As String
    Dim subjcode2, SchoolCode As String
    Dim subjcode3 As String
    Dim Selected_Subjcode2, centcode, Candno, Subjcode, examyear As String
    Dim Selected_Subjcode3 As String
    Dim sb1, sb2, sb3, sb4, sb5 As String
    Dim Query1, Query3, Query7 As String
    Dim Query2, Query4, Query6, Query8 As New OleDbCommand
    Dim mCmd As OleDbCommand
    Dim mQuery As String
    Dim mCmd1 As OleDbCommand
    Dim centre As String
    Dim CheckDate As String
    Dim CheckDate1 As Integer
    Dim Status As String = "NP"
    Dim expAmt As String = "371.00"
    Dim GovtFees As String
    Dim CandFee As String
    Dim OutBal As String = "371.00"
    Dim AmtPaid As String
    Dim dif As Integer

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        ' Checks for what option of sex has been selected by the candidate
        closeconnections()
        If txtFName.Text = "" Then
            MsgBox("First Name cannot be empty")
            txtFName.Focus()
            Exit Sub
        End If

            If txtLName.Text = "" Then
            MsgBox("last Name cannot be empty")
            txtLName.Focus()
            Exit Sub
        End If
        If txtexamyr.Text = "" Then
            MsgBox("Please Enter Exam Year.")
            txtexamyr.Focus()
            Exit Sub
        End If
        If cboSchname.SelectedIndex = -1 Then
            MsgBox("Choice of School not selected")
            cboSchname.Focus()
            Exit Sub
        End If

        'CheckDate = Mid(DateTimePicker1.Value, 7, 4)

        'CheckDate1 = CInt(CheckDate)
        'dif = examyr - CheckDate

        'If dif < 10 Then
        'MsgBox("Wrong Date Value")
        'Exit Sub
        'End If

        Gender()
        Dim idno, centid, name As String
        Dim com = cmd.Connection
        centid = CboCentCode.Text
        idno = txtCanNo.Text
        name = txtLName.Text + " " + txtFName.Text + " " + txtOtherName.Text

        Dim newSchoolName As String = cboSchname.Text

        newSchoolName = Strings.Replace(newSchoolName, "'", "''")

        Query1 = "Insert into CandDetails(EXAMYEAR,CENTCODE,INDEXNO,LNAME,FNAME,OTHERNAME,SEX,DOB,SCHCODE,SCHNAME)" _
        & "values" _
        & "('" & txtexamyr.Text & "', '" & centid & "', '" & idno & "','" & txtLName.Text & "','" & txtFName.Text & "','" & txtOtherName.Text & "','" & sex & "','" & DateTimePicker1.Text & "'," _
        & "'" & txtschcode.Text & "','" & Strings.Replace(cboSchname.Text, "'", "''") & "')"
        cmd.Connection = con.con

        Query3 = "Insert into SchChcTbl(EXAMYEAR,CENTCODE,INDEXNO,SCHCODE)" _
        & "values" _
        & "('" & txtexamyr.Text & "', '" & centid & "', '" & idno & "', '" & txtschcode.Text & "')"
        cmd.Connection = con.con

        Three_Subjects()
        Query5 = "Insert into CandSubject(EXAMYEAR,CENTCODE,INDEXNO,SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9,NOOFSUBJS)" _
                        & "values" _
                        & "('" & txtexamyr.Text & "','" & centid & "', '" & idno & "','" & English & "', '" & Math & "','" & Science & "','" & SES & "','" & sb1 & "','" & sb2 & "','" & sb3 & "','" & sb4 & "','" & sb5 & "','" & txtTot_Sub.Text & "')"

        cmd.Connection = con.con

        Query7 = "Insert into REGISTER_CANDIDATES(EXAMYEAR,CENTCODE,INDEXNO,CANDIDATENAME,NOOFSUBJS,SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9,DOB,SEX,SCHCHOICE)" _
        & "values" _
        & "('" & txtexamyr.Text & "','" & centid & "', '" & idno & "','" & name & "','" & txtTot_Sub.Text & "','" & English & "', '" & Math & "','" & Science & "','" & SES & "','" & sb1 & "','" & sb2 & "','" & sb3 & "','" & sb4 & "','" & sb5 & "','" & DateTimePicker1.Text & "','" & sex & "', '" & txtschcode.Text & "')"
        cmd.Connection = con.con

        Query2 = New OleDb.OleDbCommand(Query1, con.con)
        Query4 = New OleDb.OleDbCommand(Query3, con.con)
        Query6 = New OleDb.OleDbCommand(Query5, con.con)
        Query8 = New OleDb.OleDbCommand(Query7, con.con)

        con.CloseConnection()
        gcon2.Close()
        gcon3.Close()
        gcon4.Close()

        Try
            con.OpenConnection()
            gcon2.Open()
            gcon3.Open()
            gcon4.Open()

            Query2.ExecuteNonQuery()

            ''to update CandDetailsOrg
            'Query2.CommandText = "Insert into CandDetailsorg(EXAMYEAR,CENTCODE,INDEXNO,LNAME,FNAME,OTHERNAME,SEX,DOB,SCHCODE,SCHNAME)" _
            '    & " values" _
            '    & "('" & txtexamyr.Text & "', '" & centid & "', '" & idno & "','" & txtLName.Text & "','" & txtFName.Text & "','" & txtOtherName.Text & "','" & sex & "','" & DateTimePicker1.Text & "'," _
            '    & "'" & txtschcode.Text & "','" & cboSchname.Text & "')"

            'Query2.ExecuteNonQuery()

            Query4.ExecuteNonQuery()
            Query6.ExecuteNonQuery()
            Query8.ExecuteNonQuery()

            Add_to_transact()
            Add_Cand_Payment()
            MsgBox("Record Added", MsgBoxStyle.Information, Me.Text)
            ClearForNextRec()
            GetIndexNo()
            FrmReceipt.Enabled = True
        Catch ex As Exception
            Console.WriteLine("Exception in Adding candidate. Error is: " + ex.Message())
        Finally
        End Try

        'Clear sbs
        ClearSbs()

        txtLName.Focus()
    End Sub

    Sub ClearSbs()
        sb1 = Nothing
        sb2 = Nothing
        sb3 = Nothing
        sb4 = Nothing
        sb5 = Nothing
    End Sub
    Sub closeconnections()
       
        gcon.Close()
        gcon1.Close()
        gcon2.Close()
        gcon3.Close()
        gcon4.Close()
        gcon5.Close()
        gcons.Close()

    End Sub
    Private Sub FrmgabEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Comboboxes for Centcode, Subj group 2 and 3 are populated from the database

        cent()
        GetIndexNo()
        get_schoolname()
        subj2()
        subj3()
        getexamyr()
        examseries()

        'Initial value of No of Subjects. It is initialised as total Number of Core Subjects = 4.
        txtTot_Sub.Text = subtots
        CmdAdd.Enabled = False

        InitialiseComponents()

    End Sub

    Sub InitialiseComponents()
        'fill exam year
        FillExamYear()

        DateTimePicker1.Value = ""

    End Sub

    Sub FillExamYear()
        If Now().Month > 9 Then
            txtexamyr.Text = Now.Year() + 1
        ElseIf Now().Month < 4 Then
            txtexamyr.Text = Now.Year()
        End If

    End Sub

    Sub getexamyr()
        examyr = Now.Year
    End Sub
    Private Sub get_schChoice()
        Try
            gcon3.Open()

            cmd.CommandText = "select * from SenSecSchools "
            cmd.Connection = gcon3

            dr = cmd.ExecuteReader
            While dr.Read()
                ' CboSchofChc.Items.Add(dr("SCHCODE"))
            End While
            dr.Close()
            gcon2.Close()
        Catch ex As Exception
            dr.Close()
            gcon2.Close()
        Finally
        End Try
    End Sub
    Private Sub txtTot_Sub_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTot_Sub.TextChanged

        If (txtTot_Sub.Text >= 7) And (txtTot_Sub.Text < 10) Then
            txtTot_Sub.BackColor = Color.Green
            CmdAdd.Enabled = True
            CmdAdd.Focus()
        ElseIf txtTot_Sub.Text < 7 Or txtTot_Sub.Text > 9 Then
            CmdAdd.Enabled = False
            txtTot_Sub.BackColor = Color.Red
        End If

    End Sub
    Private Sub txtLName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLName.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Return Then
            txtFName.Focus()
        End If
    End Sub
    Private Sub txtLName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtFName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFName.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Return Then
            txtOtherName.Focus()
        End If
    End Sub
    Private Sub txtFName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 8 And Asc(e.KeyChar) <= 32) Then
            ''''''''''''''Process it if want
        Else
            ''''''''''''''If other than alphabets or space make it blank
            e.KeyChar = ""
        End If
    End Sub
    Private Sub CmdPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' PHOTO FOR GABECE DOES NOT EXIST YET

        '' Use an OpenFileDialog to enable the user.EventArgs) Handles CmdPicture.Click
        '' database. 
        'With OpenFileDialog1
        '    .InitialDirectory = "E:\My Pictures\"
        '    .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
        '    .FilterIndex = 4
        'End With

        '' display the image centered in the PictureBox and display the full path of the image.
        'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    With PictureBox2
        '        .Image = Image.FromFile(OpenFileDialog1.FileName)
        '        .SizeMode = PictureBoxSizeMode.CenterImage
        '        .BorderStyle = BorderStyle.Fixed3D
        '    End With
        '    lblFilePath.Text = OpenFileDialog1.FileName

        'End If
    End Sub
    Public Sub GetIndexNo()
        'This code will load the next indexNo for the next record
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()
            cmd.CommandText = "Select max(INDEXNO)from CandDetails where CENTCODE='" & CboCentCode.Text & "'"

            cmd.Connection = con.con

            Dim recno As Integer

            recno = cmd.ExecuteScalar
            recno = recno + 1
            txtCanNo.Text = (Format(recno, "000"))
            CboCentCode.Focus()
            con.CloseConnection()

        Catch ex As Exception
            con.CloseConnection()
        End Try
    End Sub
    Private Sub CboGrp2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboGrp2.SelectedIndexChanged
        ValidateGrp2()
    End Sub
    Private Sub ValidateGrp2()

        Try
            con.OpenConnection()
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            cmd.CommandText = "Select * from SubjectTbl where SubjName= '" + CboGrp2.Text + "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader()
            dr.Read()
            subjcode2 = dr("SubjCode")
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
            con.CloseConnection()
        End Try

        If txtTot_Sub.Text < 9 Then
            If subtot1 < 4 Then

                GetReligious()

            End If
        Else
            MsgBox("You cannot have more then 9 subjects")
        End If

    End Sub
    Private Sub CboGrp3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboGrp3.SelectedIndexChanged
        ValidateGrp3()
    End Sub
    Private Sub ValidateGrp3()
        Try
            Dim dr As OleDbDataReader
            con.OpenConnection()
            Dim cmd As New OleDbCommand

            cmd.CommandText = "Select * from SubjectTbl where SubjName= '" + CboGrp3.Text + "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader()
            dr.Read()
            subjcode3 = dr("SubjCode")
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
            con.CloseConnection()
        End Try
        Try
            If (txtTot_Sub.Text < 9) Then

                If (subtot1 <= 4) And (subtot2 <= 4) Then

                    'If (subtot1 >= 1) And (subtot2 <= 2) Then
                    If (ListBox2.Items.Contains(CboGrp3.SelectedItem)) = True Then
                        MsgBox("You have already selected " & CboGrp3.SelectedItem)

                    Else
                        ListBox2.Items.Add(CStr(CboGrp3.SelectedItem))
                        ListBox3.Items.Add(subjcode3)
                        txtTot_Sub.Text += 1
                        subtot2 += 1
                    End If
                End If
            Else
                MsgBox("You cannot have more then 9 Subjects")
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Sub subj2()

        Try

            Dim cmd As New OleDbCommand
            Dim sub2 As String
            sub2 = "21"
            con.OpenConnection()
            cmd.CommandText = "Select * from SubjectTbl where SubjCode like '" & sub2 & "%'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            While (dr.Read())
                CboGrp2.Items.Add(dr("SubjName"))
            End While
            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        End Try

    End Sub
    Sub subj3()

        Try
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            Dim sub3 As String
            sub3 = "31"
            con.OpenConnection()
            cmd.CommandText = "Select * from SubjectTbl where SubjCode like '" & sub3 & "%'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            While (dr.Read())
                CboGrp3.Items.Add(dr("SubjName"))
            End While
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cent()

        da = New OleDbDataAdapter("Select * from CentreTbl", con.con)
        da.Fill(ds, "CentreTbl")
        CboCentCode.DataSource = ds.Tables("CentreTbl")
        CboCentCode.DisplayMember = "CentCode"


    End Sub
    Sub examseries()
        da = New OleDbDataAdapter("Select * from ExamDetails", con.con)
        da.Fill(ds, "ExamDetails")

    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Try

            ' Removes unwanted selected items
            Dim i As Integer
            i = ListBox1.SelectedIndex

            con.OpenConnection()
            cmd.CommandText = "select SubjCode from SubjectTbl where SubjName='" + ListBox1.Text + "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            dr.Read()
            Selected_Subjcode2 = (dr("SubjCode"))
            ListBox1.Items.RemoveAt(i)
            ListBox3.Items.Remove(Selected_Subjcode2)
            subtot1 -= 1
            txtTot_Sub.Text -= 1
            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            MsgBox("You have not selected any subject& " & ex.Message)
        Finally
        End Try


    End Sub
    Private Sub ListBox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDoubleClick

        Dim i As Integer
        i = ListBox2.SelectedIndex

        Try
            con.OpenConnection()
            cmd.CommandText = "select SubjCode from SubjectTbl where SubjName='" + ListBox2.Text + "'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            dr.Read()
            Selected_Subjcode3 = dr("SubjCode")
            ListBox2.Items.RemoveAt(i)
            ListBox3.Items.Remove(Selected_Subjcode3)
            subtot2 -= 1
            txtTot_Sub.Text -= 1
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
            MsgBox("You have not selected any subject " & ex.Message)
        End Try

        '**********************working bacup***********************
        '    subjcode3 = ListBox2.SelectedIndex

        '    ListBox2.IsAccessible = True
        '    ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        '    ListBox3.Items.Remove(subjcode3)
        '    subtot2 -= 1
        '    txtTot_Sub.Text -= 1

    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        CboCentCode.Focus()
        subtot1 = 0
        subtot2 = 0
        txtLName.Clear()
        txtFName.Clear()
        ListBox1.Items.Clear()
        CboGrp2.SelectedIndex = 0
        ListBox2.Items.Clear()
        CboGrp3.SelectedIndex = 0
        ListBox3.Items.Clear()
        txtTot_Sub.Text = subtots

    End Sub
    Private Sub ClearForNextRec()

        CmdAdd.Enabled = False
        CboCentCode.Focus()
        GetIndexNo()
        txtTot_Sub.Text = subtots
        subtot1 = 0
        subtot2 = 0
        txtLName.Clear()
        txtOtherName.Clear()
        txtFName.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        cboSchname.SelectedIndex = -1
        txtschcode.Clear()
        DateTimePicker1.ResetText()
        OptMale.Checked = True


    End Sub
    Private Sub CboCentCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentCode.SelectedIndexChanged
        Try
            GetIndexNo()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub GetReligious()
        Try
            If ListBox1.Items.Contains(CboGrp2.SelectedItem) = True Then
                MsgBox("Already selected " & CboGrp2.SelectedItem)
            Else

                If (ListBox1.Items.Contains("Islamic Religious Knowledge") And (CboGrp2.SelectedItem = ("Christian Religious Knowledge"))) Then
                    MsgBox("You cannot select both Islamic and Christian Religious Knowledge")
                Else

                    If (ListBox1.Items.Contains("Christian Religious Knowledge") And (CboGrp2.SelectedItem = ("Islamic Religious Knowledge"))) Then
                        MsgBox("You cannot select both Islamic and Christian Religious Knowledge")
                    Else

                        ListBox1.Items.Add(CStr(CboGrp2.SelectedItem))
                        ListBox3.Items.Add(subjcode2)
                        txtTot_Sub.Text += 1
                        subtot1 += 1
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Private Function IsValidForm() As Boolean

        ' Check to make sure each field has a valid value

        'If CboCentCode.Text = "" Or _
        '    txtCanNo.Text = "" Or _
        '    txtLName.Text = "" Or _
        '    txtFName.Text = "" Or _
        '    sex = "0" Or _
        '    'lblFilePath.Text = "" Or _
        '    ListBox1.Items.Count < 2 Or _
        '    ListBox2.Items.Count < 1 Then
        '    CboCentCode.Focus()

        '    MsgBox("Please enter a valid value for each field.", MsgBoxStyle.Exclamation, Me.Text)
        '    Return False
        'Else
        '    Return True
        'End If

        'MsgBox("Record Added")
    End Function
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing Candidate Entry Form", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            CboCentCode.Focus()
        End If

    End Sub
    Private Sub Gender()

        If OptMale.Checked = True Then
            sex = 1
        ElseIf OptFemale.Checked = True Then
            sex = 2

        ElseIf OptBMale.Checked = True Then
            sex = 3

        ElseIf OptBFemale.Checked = True Then
            sex = 4

            'ElseIf OptDMale.Checked = True Then
            '    sex = 5

            'ElseIf OptDFemale.Checked = True Then
            '    sex = 6

            'ElseIf OptHMale.Checked = True Then
            '    sex = 7

            'ElseIf OptHFemale.Checked Then
            '    sex = 8

        End If
    End Sub
    Private Sub Three_Subjects()
        Dim i As Integer

        'len is the total no of subjects 
        Len = 0
        Len = ListBox3.Items.Count - 1
        Dim SubjectsArray(Len) As String


        For i = 0 To ListBox3.Items.Count - 1
            SubjectsArray(i) = ListBox3.Items(i).ToString()
        Next
        If Len = 2 Then
            sb1 = SubjectsArray(0)
            sb2 = SubjectsArray(1)
            sb3 = SubjectsArray(2)

        ElseIf Len = 3 Then
            sb1 = SubjectsArray(0)
            sb2 = SubjectsArray(1)
            sb3 = SubjectsArray(2)
            sb4 = SubjectsArray(3)
        Else
            Len = 4
            sb1 = SubjectsArray(0)
            sb2 = SubjectsArray(1)
            sb3 = SubjectsArray(2)
            sb4 = SubjectsArray(3)
            sb5 = SubjectsArray(4)


        End If
    End Sub
    Private Sub btnFpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f1 As New FrmReceipt
        f1.Enabled = True

    End Sub
    Private Sub getcentres()
        'getting centcodes for each center
        Dim cent As String
        cent = "7"
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()
            cmd.CommandText = "Select * From CandSubject where CENTCODE like  '" & cent & "%'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            While (dr.Read)
                centre = (dr("CENTCODE"))
            End While
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        Finally
        End Try

    End Sub
    Sub Add_Cand_Payment()
        closeconnections()
        Dim dr1 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim reg As String
        ' Dim expAmt As Integer
        Dim candfee As Integer

        'Try
        gcons.Open()

        getcentres()

        cmd.CommandText = "select * from CandDetails where CENTCODE like '" & centre & "%' and INDEXNO LIKE '" & txtCanNo.Text & "%'"
        cmd.Connection = gcons
        dr1 = cmd.ExecuteReader
        While dr1.Read()

            reg = Mid(dr1("CENTCODE"), 2, 1)
            sex = (dr1("SEX"))

            'If centcode > 2 And sex = 2 Then
            If reg > 2 And sex = 2 Then
                GovtFees = "185.50"
                candfee = "185.50"
            End If
        End While


        mQuery = "Insert into Fee_Tbl(GOVTFEES,CANDFEES,EXPECTEDAMOUNT,OUTBAL,STATUS,CENTCODE,INDEXNO,EXAMYEAR)" _
                                                 & " values" _
                         & "('" & GovtFees & "','" & candfee & "','" & expAmt & "','" & OutBal & "','" & Status & "','" & CboCentCode.Text & "','" & txtCanNo.Text & "','" & examyear & "')"
        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
        mCmd.ExecuteNonQuery()
        dr1.Close()
        gcons.Close()
        'Catch ex As Exception
        gcons.Close()
        ' Finally
        ' End Try

    End Sub
    Sub Add_to_transact()
        closeconnections()
        Try

            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            gcon.Open()

            getcentres()

            cmd.CommandText = "select * from CandSubject where CENTCODE like '" & CboCentCode.Text & "%' and INDEXNO LIKE '" & txtCanNo.Text & "'"
            cmd.Connection = gcon

            dr = cmd.ExecuteReader

            Dim i As Integer
            While dr.Read()
                i += 1

                For i = 1 To 4
                    Subjcode = ""

                    If i = 1 Then
                        examyear = (dr("EXAMYEAR"))
                        centcode = (dr("CENTCODE"))
                        Candno = (dr("INDEXNO"))
                        Subjcode = (dr("SUBJ1"))
                        changecode()
                        mQuery = "Insert into Transact(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE)" _
                                            & " values" _
                                            & "('" & examyear & "','" & centcode & "','" & Candno & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If
                    If i = 2 Then
                        examyear = (dr("EXAMYEAR"))
                        centcode = (dr("CENTCODE"))
                        Candno = (dr("INDEXNO"))
                        Subjcode = (dr("SUBJ2"))
                        changecode()
                        mQuery = "Insert into Transact(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE)" _
                                            & " values" _
                                            & "('" & examyear & "','" & centcode & "','" & Candno & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If
                    If i = 3 Then
                        examyear = (dr("EXAMYEAR"))
                        centcode = (dr("CENTCODE"))
                        Candno = (dr("INDEXNO"))
                        Subjcode = (dr("SUBJ3"))
                        changecode()
                        mQuery = "Insert into Transact(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE)" _
                                            & " values" _
                                            & "('" & examyear & "','" & centcode & "','" & Candno & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If
                    If i = 4 Then
                        examyear = (dr("EXAMYEAR"))
                        centcode = (dr("CENTCODE"))
                        Candno = (dr("INDEXNO"))
                        Subjcode = (dr("SUBJ4"))
                        changecode()
                        mQuery = "Insert into Transact(EXAMYEAR,CENTCODE,INDEXNO,SUBJCODE)" _
                                             & " values" _
                                             & "('" & examyear & "','" & centcode & "','" & Candno & "','" & Subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()

                    End If

                Next
            End While

        Catch ex As Exception
        Finally
        End Try

    End Sub
    Sub changecode()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon1.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & Subjcode & "%'"
        cmd.Connection = gcon1

        dr = cmd.ExecuteReader
        While (dr.Read())
            Subjcode = (dr("SubjCode"))
        End While

        dr.Close()
        gcon1.Close()
    End Sub
    Sub get_schoolcode()
        Try
            gcon2.Open()

            Dim name As String = cboSchname.Text.ToUpper
            name = Strings.Replace(name, "'", "''")
            cmd.CommandText = "select * from SenSecSchools where SCHOOLNAME='" & name & "'"
            cmd.Connection = gcon2

            dr = cmd.ExecuteReader
            If dr.Read Then
                txtschcode.Text = (dr("SCHCODE"))
            End If
           
            dr.Close()
            gcon2.Close()
        Catch ex As Exception
            dr.Close()
            gcon2.Close()
        Finally
        End Try
    End Sub
    Sub get_schoolname()
        Try
            gcon5.Open()

            cmd.CommandText = "select SCHCODE, SCHOOLNAME, SCHADDRESS from SenSecSchoolS ORDER BY SchoolName"
            cmd.Connection = gcon5
            dr = cmd.ExecuteReader

            While dr.Read
                cboSchname.Items.Add(dr("SCHOOLNAME"))
            End While

            dr.Close()
            gcon5.Close()
        Catch ex As Exception
            dr.Close()
            gcon5.Close()
        Finally
        End Try
    End Sub
    Private Sub cboSchname_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSchname.SelectedIndexChanged
        get_schoolcode()
    End Sub
    Private Sub txtOtherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOtherName.KeyDown
        If e.KeyCode = Keys.Return Then
            DateTimePicker1.Focus()
        End If
    End Sub
    Public Sub PrintAccessReport(ByVal sReportName As String, Optional ByVal sQryName As String = "", Optional ByVal sSQL As String = "")
        '        Dim oAccess As New Access.ApplicationClass
        '        oAccess.Visible = True
        '        oAccess.OpenCurrentDatabase("C:\PathTo\Your\Database.mdb")
        '        oAccess.DoCmd.Minimize()
        '        'Create new query if needed
        '        If sQryName.Length > 0 And sSQL.Length > 0 Then
        '            Try
        '                'oAccess.CurrentDb.QueryDefs.Delete(sQryName)
        '                oAccess.DoCmd.DeleteObject(Access.AcObjectType.acQuery, sQryName)
        '            Catch
        '                'Close and reopen the Access object if above statement failed
        '                oAccess.Visible = False
        '                oAccess.Quit(Access.AcQuitOption.acQuitSaveNone)
        '                System.Runtime.InteropServices.Marshal.ReleaseComObject(oAccess)
        '                oAccess.Visible = True
        '                oAccess.OpenCurrentDatabase("C:\PathTo\Your\Database.mdb")
        '                oAccess.DoCmd.Minimize()
        '            End Try
        '            oAccess.CurrentDb.CreateQueryDef(sQryName, sSQL)
        '        End If
        '        'Preview the report
        'oAccess.DoCmd.OpenReport(sReportName, Access.AcView.acViewPreview, , , 
        'Access.AcWindowMode.acDialog)
        '        'Close the Access Instance
        '        If Not oAccess Is Nothing Then
        '            ' Call Access Quit method without saving any changes.
        '            oAccess.Quit(Access.AcQuitOption.acQuitSaveNone)
        '            ' Use Marshal class' ReleaseComObject to release the Access instance.
        '            System.Runtime.InteropServices.Marshal.ReleaseComObject(oAccess)
        '            ' Dereference the oAccess variable.
        '            oAccess = Nothing
        '        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim d As Date
        Try
            d = DateTimePicker1.Text
            lblDisplayDate.Text = String.Format("{0} {1}, {2}", d.Day, MonthName(d.Month), d.Year)
        Catch ex As Exception
        End Try

    End Sub

End Class
