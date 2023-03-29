Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.IO

Public Class FrmMod_gabEntry

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


    Dim subtot1 As Integer = 0
    Dim subtot2 As Integer = 0
    Dim da As New OleDbDataAdapter
    Dim dp As New OleDbDataAdapter
    Dim i As Integer
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
    Dim subjcode2, SchoolCode, noofsubjs As String
    Dim subjcode3 As String
    Dim Selected_Subjcode2, centcode, Candno, Subjcode, examyear, gen, gen1, change_choice As String
    Dim Selected_Subjcode3, group2sub, group3sub As String
    Dim sb1, sb2, sb3, sb4, sb5, subj As String
    Dim Query1, Query3, Query5 As String
    Dim Query2, Query4, Query6 As New OleDbCommand
    Dim mCmd As OleDbCommand
    Dim mQuery As String
    Dim mCmd1 As OleDbCommand
    Dim centre As String
    Sub closeconnections()
        '  con.Close()
        gcon.Close()
        gcon1.Close()
        gcon5.Close()
        gcon3.Close()
        gcon4.Close()
        gcon2.Close()

    End Sub
    Private Sub Cmdmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModify.Click
        ' Checks for what option of sex has been selected by the candidate
        Gender()
        Dim idno, centid, canname As String
        Dim com = cmd.Connection
        centid = CboCentCode.Text
        idno = cbocanno.Text
        canname = txtLName.Text + txtFName.Text

        con.OpenConnection()
        Query1 = "Update CandDetails set LNAME='" & txtLName.Text & "',FNAME='" & txtFName.Text & "',OTHERNAME='" & txtOtherName.Text & "',SEX='" & sex & "'," _
        & "DOB='" & DateTimePicker1.Text & "',SCHCODE='" & txtscode.Text & "',SCHNAME= '" & txtsname.Text & "'" _
          & " WHERE (((EXAMYEAR='" & txtexamyr.Text & "') and (CENTCODE='" & CboCentCode.Text & "')) and (INDEXNO='" & cbocanno.Text & "'))"
        cmd.Connection = con.con

        Query2 = New OleDb.OleDbCommand(Query1, con.con)

        con.CloseConnection()

        con.OpenConnection()
        Query5 = "Update REGISTER_CANDIDATES set CANDIDATENAME='" & canname & "',NOOFSUBJS='" & txtTot_Sub.Text & "', SUBJ5='" & sb1 & "',SUBJ6='" & sb2 & "',SUBJ7='" & sb3 & "'," _
       & "SUBJ8='" & sb4 & "',SUBJ9='" & sb5 & "',SEX='" & sex & "', DOB='" & DateTimePicker1.Text & "',SCHCHOICE='" & txtscode.Text & "'," _
       & " WHERE (((EXAMYEAR='" & txtexamyr.Text & "') and (CENTCODE='" & CboCentCode.Text & "')) and (INDEXNO='" & cbocanno.Text & "'))"
        cmd.Connection = con.con

        Query6 = New OleDb.OleDbCommand(Query5, con.con)

        con.CloseConnection()

        con.OpenConnection()

        Query3 = "Update SchChcTbl set SCHCODE='" & txtscode.Text & "'" _
          & " WHERE (((EXAMYEAR='" & txtexamyr.Text & "') and (CENTCODE='" & CboCentCode.Text & "')) and (INDEXNO='" & cbocanno.Text & "'))"
       
        cmd.Connection = con.con

        Query4 = New OleDb.OleDbCommand(Query3, con.con)
        con.CloseConnection()

        con.OpenConnection()
        Three_Subjects()
        cmd.CommandText = "update CandSubject set SUBJ5='" & sb1 & "',SUBJ6='" & sb2 & "',SUBJ7='" & sb3 & "'," _
       & "SUBJ8='" & sb4 & "',SUBJ9='" & sb5 & "',NOOFSUBJS='" & txtTot_Sub.Text & "'" _
       & " WHERE (((EXAMYEAR='" & txtexamyr.Text & "') and (CENTCODE='" & CboCentCode.Text & "')) and (INDEXNO='" & cbocanno.Text & "'))"

        cmd.Connection = con.con


        Query2.ExecuteNonQuery()
        Query4.ExecuteNonQuery()
        cmd.ExecuteNonQuery()
        con.CloseConnection()

        'Add_to_transact()
        MsgBox("Record Modified", MsgBoxStyle.Information, Me.Text)
        ClearForNextRec()
        'FrmReceipt.Enabled = True
    End Sub

    Private Sub FrmgabEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Comboboxes for Centcode, Subj group 2 and 3 are populated from the database
        getcentres()
        examsYear()
        get_schoolcode()
        subj2()
        subj3()
        'Initial value of No of Subjects. It is initialised as total Number of Core Subjects = 4.
        txtTot_Sub.Text = subtots

        CmdModify.Enabled = False

    End Sub
    Public Sub get_canddetails()
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()

            cmd.CommandText = "select * from CandDetails Where((EXAMYEAR='" & txtexamyr.Text & "')and (CENTCODE='" & CboCentCode.Text & "') and (INDEXNO='" & cbocanno.Text & "'))"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then
                txtLName.Text = dr("LNAME")
                txtFName.Text = dr("FNAME")
                txtOtherName.Text = dr("OTHERNAME")
                txtsname.Text = dr("SCHNAME")
                txtscode.Text = (dr("SCHCODE"))
                DateTimePicker1.Text = dr("DOB")
                gen = dr("SEX")


                If gen = "2" Then
                    OptFemale.Checked = True
                ElseIf gen = "1" Then
                    OptMale.Checked = True
                ElseIf gen = "3" Then
                    OptBFemale.Checked = True
                ElseIf gen = "4" Then
                    OptBMale.Checked = True
                End If

            End If


            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        End Try

    End Sub
    Private Sub get_schChoice()
        Try
            gcon3.Open()

            cmd.CommandText = "select * from SenSecSchools "
            cmd.Connection = gcon3

            dr = cmd.ExecuteReader
            While dr.Read()
                cboSchname.Items.Add(dr("SCHNAME"))
            End While
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
            gcon2.Open()

            cmd.CommandText = "select * from SenSecSchools "
            cmd.Connection = gcon2

            dr = cmd.ExecuteReader
            While (dr.Read())
                cboSchname.Items.Add(dr("SCHOOLNAME"))
            End While
            dr.Close()
            gcon2.Close()
        Catch ex As Exception
            dr.Close()
            gcon2.Close()
        Finally
        End Try
    End Sub
    Private Sub cmdretrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdretrieve.Click
        ClearListBoxes()
        get_canddetails()
        get_schoolname()
        getpapers()


    End Sub
    Private Sub txtTot_Sub_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTot_Sub.TextChanged

        If (indrange1 >= 7) And (indrange1 < 10) Then
            CmdModify.Enabled = True
        ElseIf indrange1 < 7 Then
            CmdModify.Enabled = False
        End If

    End Sub
    Private Sub txtLName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.Leave


        If (txtLName.Text.Length = 0) Then
            MessageBox.Show("Surname cannot be Emtpy. Please enter a Surname", "Name Validation", MessageBoxButtons.OK)
            'txtLName.Focus()
        ElseIf txtLName.TextLength > 20 Then

            MessageBox.Show("Name cannot be more than 25 characters", "Name Validation", MessageBoxButtons.OK)

        ElseIf txtLName.Text = (";") Or txtLName.Text = ("'") Or txtLName.Text = ("?") Or txtLName.Text = ("<") Or txtLName.Text = (">") Or txtLName.Text = ("\") _
            Or txtLName.Text = ("/") Or txtLName.Text = (".") Or txtLName.Text = ("!") Or txtLName.Text = ("#") Or txtLName.Text = ("@") Or txtLName.Text = (":") Or txtLName.Text = ("=") Then

            MessageBox.Show("Name cannot take characters", "Name Validation", MessageBoxButtons.OK)

            txtLName.Clear()
            txtLName.Focus()
        End If
    End Sub
    Private Sub txtFName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.Leave
        If (txtFName.Text.Length = 0) Then
            txtFName.Focus()

        ElseIf txtFName.TextLength > 20 Then
            MessageBox.Show("Name cannot be more than 25 characters", "Name Validation", MessageBoxButtons.OK)
            'txtLName.Focus()

        ElseIf txtFName.Text = (";") Or txtLName.Text = ("'") Or txtLName.Text = ("?") Or txtLName.Text = ("<") Or txtLName.Text = (">") Or txtLName.Text = ("\") _
            Or txtFName.Text = ("/") Or txtLName.Text = (".") Or txtLName.Text = ("!") Or txtLName.Text = ("#") Or txtLName.Text = ("@") Or txtLName.Text = (":") Or txtLName.Text = ("=") Then

            MessageBox.Show("Name cannot take characters", "Name Validation", MessageBoxButtons.OK)

            txtFName.Clear()
            txtFName.Focus()
        End If


    End Sub
    Public Sub GetIndexNo() 'change to combo box****************
        'This code will load the next indexNo for the next record
        closeconnections()
        cbocanno.Text = ""
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()
            cmd.CommandText = "Select * from CandDetails where CENTCODE like '" & CboCentCode.Text & "%' and EXAMYEAR LIKE '" & txtexamyr.Text & "%'"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            'If dr.Read Then
            While dr.Read()
                cbocanno.Items.Add(dr("INDEXNO"))
            End While
            ' End If
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
    Sub examsYear()

        'examyr = Now.Year
        Dim cmd As New OleDbCommand
        con.OpenConnection()
        cmd.CommandText = "Select * from CandDetails"
        cmd.Connection = con.con
        dr = cmd.ExecuteReader
        While dr.Read()
            txtexamyr.Text = (dr("EXAMYEAR"))
        End While
        con.CloseConnection()


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
        cbocanno.Items.Clear()
        subtot1 = 0
        subtot2 = 0
        txtLName.Clear()
        txtsname.Clear()
        txtscode.Clear()
        txtFName.Clear()
        ListBox1.Items.Clear()
        CboGrp2.SelectedIndex = -1
        ListBox2.Items.Clear()
        CboGrp3.SelectedIndex = -1
        ListBox3.Items.Clear()
        txtTot_Sub.Text = subtots

    End Sub
    Sub ClearListBoxes()
        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.Clear()

        End If
        If ListBox2.Items.Count > 0 Then
            ListBox2.Items.Clear()
        End If


    End Sub
    Private Sub ClearForNextRec()

        CmdModify.Enabled = False
        CboCentCode.Focus()
        txtTot_Sub.Text = subtots
        subtot1 = 0
        subtot2 = 0
        txtLName.Clear()
        txtOtherName.Clear()
        txtFName.Clear()
        txtscode.Clear()
        txtsname.Clear()
        cboSchname.SelectedIndex = -1
        txtschcode.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        OptBFemale.Checked = False
        OptBMale.Checked = False
        OptFemale.Checked = False
        OptMale.Checked = False
    End Sub
    Private Sub CboCentCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentCode.SelectedIndexChanged
        Try
            cbocanno.Items.Clear()
            GetIndexNo()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub GetReligious()
        'Try
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
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
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
    Private Sub Gender()

        If OptMale.Checked = True Then
            sex = 1
        ElseIf OptFemale.Checked = True Then
            sex = 2

        ElseIf OptBMale.Checked = True Then
            sex = 3

        ElseIf OptBFemale.Checked = True Then
            sex = 4

        End If
    End Sub
    Private Sub Three_Subjects()
        Dim i As Integer

        'len is the total no of subjects 

        'ListBox3.Items.Clear()
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f1 As New FrmReceipt
        f1.Enabled = True

    End Sub
    Private Sub getcentres()
        ''getting centcodes for each center
        'Dim cmd As New OleDbCommand
        Dim cent As String
        cent = "7"

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon1.Open()
            cmd.CommandText = "select DISTINCT CENTCODE from CandDetails WHERE CENTCODE LIKE '" & cent & "%'"
            cmd.Connection = gcon1

            dr = cmd.ExecuteReader

            While (dr.Read())
                CboCentCode.Items.Add(dr("CENTCODE"))

            End While

            dr.Close()
        Catch ex As Exception
            gcon1.Close()
        Finally
        End Try

    End Sub
    Sub Add_to_transact()
        Try

            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            gcon.Open()

            getcentres()

            cmd.CommandText = "select * from CandSubject where CENTCODE like '" & centre & "%'"
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
    Sub codereturn1()
        'Variable to store subjcode from the subjects table
        Try
            gcon1.Open()
            Dim dr As OleDbDataReader

            Dim cmd As New OleDbCommand
            cmd.CommandText = "Select * from SubjectTbl where SubjName = '" + CboGrp2.Text + "'"
            cmd.Connection = gcon1
            dr = cmd.ExecuteReader()
            dr.Read()
            'Retrieving SubjCode into Global variable subjcode
            Subjcode = dr("SubjCode")
            dr.Close()
            gcon1.Close()
        Catch ex As Exception

            gcon1.Close()
        End Try

    End Sub
    Sub codereturn2()
        'Variable to store subjcode from the subjects table
        Try
            gcon2.Open()
            Dim dr As OleDbDataReader

            Dim cmd As New OleDbCommand
            cmd.CommandText = "Select * from SubjectsTbl where SubjName = '" + CboGrp3.Text + "'"
            cmd.Connection = gcon2
            dr = cmd.ExecuteReader()
            dr.Read()
            'Retrieving SubjCode into Global variable subjcode
            Subjcode = dr("SubjCode")
            dr.Close()
            gcon2.Close()
        Catch ex As Exception

            gcon2.Close()
        End Try
    End Sub
    Sub get_Papers()

        'Try
        Dim cmd As New OleDbCommand
        gcon.Open()

        cmd.CommandText = "select * from CandSubject Where((EXAMYEAR='" & txtexamyr.Text & "')and (CENTCODE='" & CboCentCode.Text & "') and (INDEXNO='" & cbocanno.Text & "'))"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        ClearListBoxes()
        While (dr.Read())
            noofsubjs = dr("NOOFSUBJS")

            If noofsubjs = 7 Then
                'Method for candidates pursuing 8 subjects
                subjects7()
            ElseIf noofsubjs = 8 Then
                subjects8()
            Else
                'Method for candidates pursuing 9 subjects
                subjects9()

            End If
        End While
    End Sub
    Sub subjects7()
        For i = 1 To 7
            Subjcode = ""

            If i = 1 Then
                'Adding English
                Subjcode = (dr("SUBJ1"))
                subj = (dr("SUBJ1"))
                'ListBox3.Items.Add(dr("SUBJ1"))

            End If

            If i = 2 Then
                'Adding Mathematics
                Subjcode = (dr("SUBJ2"))
                subj = (dr("SUBJ2"))
                'ListBox3.Items.Add(dr("SUBJ2"))


            End If

            If i = 3 Then
                Subjcode = (dr("SUBJ3"))
                subj = (dr("SUBJ3"))
                'ListBox3.Items.Add(dr("SUBJ3"))

            End If

            If i = 4 Then
                Subjcode = (dr("SUBJ4"))
                subj = (dr("SUBJ4"))
                'ListBox3.Items.Add(dr("SUBJ4"))
            End If

            If i = 5 Then
                Subjcode = (dr("SUBJ5"))
                subj = (dr("SUBJ5"))
                ListBox3.Items.Add(dr("SUBJ5"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If

            End If

            If i = 6 Then
                Subjcode = (dr("SUBJ6"))
                subj = (dr("SUBJ6"))
                ListBox3.Items.Add(dr("SUBJ6"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If

            If i = 7 Then
                Subjcode = (dr("SUBJ7"))
                subj = (dr("SUBJ7"))
                ListBox3.Items.Add(dr("SUBJ7"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If

        Next

    End Sub
    Sub subjects8()
        For i = 1 To 8
            Subjcode = ""

            If i = 1 Then
                'Adding English
                Subjcode = (dr("SUBJ1"))
                subj = (dr("SUBJ1"))


            End If

            If i = 2 Then
                'Adding Mathematics
                Subjcode = (dr("SUBJ2"))
                subj = (dr("SUBJ2"))



            End If

            If i = 3 Then
                Subjcode = (dr("SUBJ3"))
                subj = (dr("SUBJ3"))


            End If

            If i = 4 Then
                Subjcode = (dr("SUBJ4"))
                subj = (dr("SUBJ4"))


            End If

            If i = 5 Then
                Subjcode = (dr("SUBJ5"))
                subj = (dr("SUBJ5"))
                ListBox3.Items.Add(dr("SUBJ5"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If

            End If

            If i = 6 Then
                Subjcode = (dr("SUBJ6"))
                subj = (dr("SUBJ6"))
                ListBox3.Items.Add(dr("SUBJ6"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If

            If i = 7 Then
                Subjcode = (dr("SUBJ7"))
                subj = (dr("SUBJ7"))
                ListBox3.Items.Add(dr("SUBJ7"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If

            If i = 8 Then
                Subjcode = (dr("SUBJ8"))
                subj = (dr("SUBJ8"))
                ListBox3.Items.Add(dr("SUBJ8"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If
        Next
    End Sub
    Sub subjects9()
        For i = 1 To 9
            Subjcode = ""

            If i = 1 Then
                'Adding English
                Subjcode = (dr("SUBJ1"))
                subj = (dr("SUBJ1"))
                ' ListBox3.Items.Add(dr("Sub1"))


            End If

            If i = 2 Then
                'Adding Mathematics
                Subjcode = (dr("SUBJ2"))
                subj = (dr("SUBJ2"))
                'ListBox3.Items.Add(dr("SUBJ2"))


            End If

            If i = 3 Then
                Subjcode = (dr("SUBJ3"))
                subj = (dr("SUBJ3"))
                'ListBox3.Items.Add(dr("SUBJ3"))
            End If

            If i = 4 Then
                Subjcode = (dr("SUBJ4"))
                subj = (dr("SUBJ4"))
                ' ListBox3.Items.Add(dr("SUBJ4"))

            End If

            If i = 5 Then
                Subjcode = (dr("SUBJ5"))
                subj = (dr("SUBJ5"))
                ListBox3.Items.Add(dr("SUBJ5"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If

            End If

            If i = 6 Then
                Subjcode = (dr("SUBJ6"))
                subj = (dr("SUBJ6"))
                ListBox3.Items.Add(dr("SUBJ6"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If

            If i = 7 Then
                Subjcode = (dr("SUBJ7"))
                subj = (dr("SUBJ7"))
                ListBox3.Items.Add(dr("SUBJ7"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If
            If i = 8 Then
                Subjcode = (dr("SUBJ8"))
                subj = (dr("SUBJ8"))
                ListBox3.Items.Add(dr("SUBJ8"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If
            If i = 9 Then
                Subjcode = (dr("SUBJ9"))
                subj = (dr("SUBJ9"))
                ListBox3.Items.Add(dr("SUBJ9"))
                Subjcode = Mid(Subjcode, 1, 1)
                If Subjcode = 2 Then
                    changeCode1()
                ElseIf Subjcode = 3 Then
                    changeCode2()

                End If
            End If



        Next
    End Sub
    Sub getpapers()
        '  Try

        Dim cmd As New OleDbCommand
        gcon.Open()
        cmd.CommandText = "select * from CandSubject where EXAMYEAR Like ('" & txtexamyr.Text & "%') and CENTCODE Like ('" & CboCentCode.Text & "%') and INDEXNO like ('" & cbocanno.Text & "%')"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        'ClearListBoxes()
        While (dr.Read())
            indrange1 = dr("NOOFSUBJS")

            If indrange1 = 7 Then
                'Method for candidates pursuing 8 subjects
                subjects7()
            ElseIf indrange1 = 8 Then
                'Method for candidates pursuing 9 subjects
                subjects8()
            Else
                subjects9()

            End If
        End While
        txtTot_Sub.Text = indrange1
        dr.Close()
        gcon.Close()
        'Catch ex As Exception
        gcon.Close()
        'Finally
        'End Try

    End Sub
    Sub changeCode1()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim check1 As String
        'get_grp2()
        gcon4.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subj & "%'"
        cmd.Connection = gcon4

        dr = cmd.ExecuteReader
        While (dr.Read())
            check1 = (dr("SubjCode"))
            If check1 = subj Then
                ListBox1.Items.Add(dr("SubjName"))

            End If
        End While

        dr.Close()
        gcon4.Close()
    End Sub
    Sub changeCode2()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim check1 As String
        gcon5.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subj & "%'"
        cmd.Connection = gcon5

        dr = cmd.ExecuteReader
        While (dr.Read())
            check1 = (dr("SubjCode"))
            If check1 = subj Then
                ListBox2.Items.Add(dr("SubjName"))

            End If
        End While

        dr.Close()
        gcon5.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing Candidate Entry Form", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            CboCentCode.Focus()
        End If

    End Sub
    Private Sub cboSchname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSchname.SelectedIndexChanged
        get_schoolcode()
        If cboSchname.SelectedIndex >= -1 Then
            change_choice = cboSchname.Text
            txtsname.Text = change_choice
        End If
    End Sub
Sub get_schoolcode()
        Try
            gcon5.Open()

            cmd.CommandText = "select * from SenSecSchoolS where SCHOOLNAME='" & cboSchname.Text & "'"

            cmd.Connection = gcon5

            dr = cmd.ExecuteReader

            If dr.Read() Then
                txtschcode.Text = (dr("SCHCODE"))
                txtscode.Text = (dr("SCHCODE"))
            End If

            dr.Close()
            gcon5.Close()
        Catch ex As Exception
            dr.Close()
            gcon5.Close()
        Finally
        End Try
    End Sub

  
End Class
