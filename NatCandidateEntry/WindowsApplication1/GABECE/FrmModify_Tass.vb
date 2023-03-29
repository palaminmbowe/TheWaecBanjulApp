Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmModify_Tass
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

    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd, mCmd1, cmd1 As New OleDbCommand
    Dim dr, dr1 As OleDbDataReader
    Dim PaperCodes_Tot As Integer
    Dim tot_mark As Integer = 0
    Dim recno As Integer
    Dim Max_Mark As Integer = 100
    Dim Min_Mark As Integer = 0
    Dim SchoolCode, CentCode, CandName, CandNo, Subjcode, Subjcode1, sub1, mQuery1, mQuery2, ModifyDate, mysubject, examyr As String
    Dim countFound As Integer
    Dim Len As Integer
    Dim mrk As String
    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        'Try

        Dim CentCode As String = CboCenCode.Text
        Dim CandNo As String = CboCanNo.Text
        Dim Subjcode As String = Trim(CboSubName.Text)


        'absentMark()

        validate_Mark()
        ValidateForm()
        con.OpenConnection()
        gcon1.Open()
        mQuery1 = "update TASSMARKS set MARK= '" & mrk & "' Where CENTCODE='" & CentCode & "' and INDEXNO='" & CandNo & "' and PAPERCODE='" & sub1 & "'"
        cmd.Connection = con.con
        cmd = New OleDb.OleDbCommand(mQuery1, con.con)

        mQuery2 = "update Audit_Trail set MOD_MRK= '" & mrk & "', DATE_MRK_MODIFIED= '" & ModifyDate & "' Where CENTCODE='" & CentCode & "' and INDEXNO='" & CandNo & "' and PAPERCODE='" & sub1 & "'"
        cmd1.Connection = gcon1
        cmd1 = New OleDb.OleDbCommand(mQuery2, gcon1)

        gcon5.Open()
        Query5 = "UPDATE Subject_Entry_By_Cand SET FLAG='" & mrk & "' WHERE CENTCODE='" & CentCode & "' and INDEXNO='" & CandNo & "' and SUBJCODE='" & myexaminer1 & "'"
        mCmd1.Connection = gcon5
        mCmd1 = New OleDb.OleDbCommand(Query5, gcon5)

        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()
        mCmd1.ExecuteNonQuery()

        con.CloseConnection()
        gcon1.Close()
        gcon5.Close()
        MsgBox("Record Update Successful")

        CmdClear.Enabled = True
        ClearForm()
        CboCanNo.Text = ""

        'Catch ex As Exception

        'Finally
        con.CloseConnection()
        gcon1.Close()
        gcon5.Close()
        'End Try

        ClearForm()
        cmdModify.Enabled = True

    End Sub
    Sub absentMark()
        If ChkAbs.Checked = True Then
            'abs = "  A"
        End If
    End Sub

    Private Sub FrmModify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdModify.Enabled = False
        ExamYear()
        getSubjects()
        CentreCode()
        Me.Text = myusername.ToUpper + ":  " + examinerno
    End Sub

    Private Sub CboCentCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCenCode.SelectedIndexChanged
        getCanNo()

    End Sub

    Private Sub getCanNo()
        CboCanNo.Items.Clear()

        con.OpenConnection()
        cmd.CommandText = "select * from TASSMARKS Where CENTCODE='" & CboCenCode.Text & "' and PAPERCODE='" & sub1 & "'"
        cmd.Connection = con.con
        dr = cmd.ExecuteReader
        While dr.Read()
            CboCanNo.Items.Add(dr("INDEXNO"))
        End While

        dr.Close()
        con.CloseConnection()

    End Sub

    Private Sub CboCandNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCanNo.SelectedIndexChanged

        GetCandName()

        If CmdClear.Enabled = False Then
            CmdClear.Enabled = True

        End If
    End Sub
    Public Sub ValidateForm()

        If CboCenCode.Text = "" Or _
            CboCanNo.Text = "" Or _
            CboSubName.Text = "" Or _
            txtLName.Text = "" Then
            MsgBox("Please Enter all the details", MsgBoxStyle.Critical)
            CboCenCode.Focus()
        Else
            cmdModify.Enabled = True
        End If
        If txtMark.Text = "" And ChkAbs.Checked = False Then
            MsgBox("Please enter a mark")
        End If
    End Sub
    Public Sub ClearForm()

        'clears the form for new candidate entry
        CboCenCode.Enabled = True
        CboSubName.Enabled = True
        CboCenCode.SelectedIndex = 0
        CboCanNo.SelectedIndex = 0
        CboSubName.SelectedIndex = 0
        txtLName.Text = ""
        txtMark.Text = ""
        ChkAbs.Checked = False
        cmdModify.Enabled = False


    End Sub
    Public Sub GetCandName()

        Try
            Dim cmd As New OleDbCommand

            con.OpenConnection()
            cmd.CommandText = "select * from GBB02OUT where INDEXNO='" & CboCanNo.Text & "' and CENTCODE='" & CboCenCode.Text & "'"

            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            dr.Read()
            txtLName.Text = dr("CANDNAME")
            SchoolCode = dr("CENTCODE")
            dr.Close()
            con.CloseConnection()

        Catch ex As Exception

            'Centcode is not correct
            If (SchoolCode <> CboCenCode.Text) Then
                MsgBox(" Please enter a correct Centcode")

            End If

            con.CloseConnection()
        End Try
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing TassMarks Form", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            CboCenCode.Focus()
        End If
    End Sub
    Public Sub RetrieveRecord()

        Try
            gcon.Open()

            cmd.CommandText = "Select * from ExaminerLogin_Tbl"
            cmd.Connection = gcon
            dr1 = cmd.ExecuteReader

            While (dr1.Read)
                examinerno = dr1("EXAMINERNO")
                username = dr1("USERNAME")

                If username = myusername Then

                    con.OpenConnection()
                    cmd.CommandText = "select * from TASSMARKS Where CENTCODE = '" & CboCenCode.Text & "' and INDEXNO = '" & CboCanNo.Text & "' and PAPERCODE ='" & sub1 & "'"

                    cmd.Connection = con.con
                    dr = cmd.ExecuteReader

                    If dr.Read() Then
                        txtMark.Text = dr("MARK")
                        If txtMark.Text = "  A" Then
                            ChkAbs.Checked = True
                        End If
                    Else

                        MsgBox("No mark available for modification.")
                    End If
                    con.CloseConnection()
                End If
            End While
            Me.Text = username
            dr.Close()
            gcon.Close()

            GetCandName()

        Catch ex As Exception
            dr.Close()
            gcon.Close()
            con.CloseConnection()
        End Try

    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearForm()
    End Sub

    Private Sub CboSubName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubName.SelectedIndexChanged
        RetrieveRecord()
    End Sub

    Private Sub txtYear2Mark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMark.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Sub validate_Mark()
        'Try
        Dim abs As String = "  A"
        mrk = CStr(txtMark.Text)
        If mrk < (CStr(Max_Mark)) Then
        End If
        ' mark is out of range
        If mrk > (CStr(Max_Mark)) Then
            MessageBox.Show("Mark cannot be more than " & Max_Mark & ".", "TassMark Entry Validation", MessageBoxButtons.OK)
        Else

            mrk = abs

            ' txtMark.Clear()
            'txtMark.Focus()
        End If
        ' End If

        'Catch ex As Exception
        ' Finally
        ' End Try

    End Sub

    Private Sub txtMark_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMark.Leave
        Try

            If txtMark.Text > CStr(Max_Mark) Then
                MsgBox("Mark cannot be more that " & Max_Mark & "")
                txtMark.Clear()
                'txtMark.Focus()
            End If

            If txtMark.Text.Length > 3 Then
                MsgBox("Mark cannot be more than 3 digits")
                txtMark.Clear()
                txtMark.Focus()
            End If

            If txtMark.Text.Length = 3 Then
                ChkAbs.Enabled = False
                cmdModify.Enabled = True
            End If
            

        Catch ex As Exception
        Finally
        End Try

    End Sub

    Private Sub ExamYear()
        Dim cmd As New OleDbCommand
        examyr = Now.Year
        ModifyDate = Now.Date
        txtexamyr.Text = (examyr)

    End Sub
    Private Sub display()
        '
        CboCenCode.Text = ds.Tables("TASSMARKS").Rows(recno).Item("CENTCODE")
        CboCanNo.Text = ds.Tables("TASSMARKS").Rows(recno).Item("INDEXNO")
        'CboSubName.Text = ds.Tables("TASSMARKS").Rows(recno).Item("SubjName")
        GetCandName()
        txtMark.Text = ds.Tables("TASSMARKS").Rows(recno).Item("MARK")

    End Sub
    Private Sub CentreCode()
        'getSubjects()
        Dim cmd As New OleDbCommand
        gcon4.Open()

        cmd.CommandText = "Select distinct CENTCODE From TASSMARKS"

        cmd.Connection = gcon4
        dr = cmd.ExecuteReader
        While (dr.Read)
            CboCenCode.Items.Add(dr("CENTCODE"))

        End While
        dr.Close()
        con.CloseConnection()

    End Sub
    Private Sub getSubjects()
        'getting examiner username and subjectcode to load subjectname
        Try
            Dim cmd, cmd1 As New OleDbCommand
            Dim dr1 As OleDbDataReader

            gcon.Open()
            con.OpenConnection()
            cmd.CommandText = "Select * from ExaminerLogin_Tbl where USERNAME='" & username & "'"
            cmd.Connection = gcon
            dr1 = cmd.ExecuteReader
            If dr1.Read Then
                username = dr1("USERNAME")
                examinerno = dr1("EXAMINERNO")

            End If
            If username = myusername Then

                cmd1.CommandText = "Select * From PaperDetails where PapCodeCSD like '" & myexaminer & "%'"

                cmd1.Connection = con.con
                dr = cmd1.ExecuteReader

                'While dr.Read()
                If dr.Read Then
                    CboSubName.Items.Add(dr("PapName"))
                    sub1 = (dr("PapCodeCSD"))
                    'End While
                End If
            End If

            dr1.Close()
            ' End If

            dr.Close()
            con.CloseConnection()
            gcon.Close()

        Catch ex As Exception
            con.CloseConnection()
            gcon.Close()

        Finally
        End Try
    End Sub

    Private Sub ChkAbs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAbs.CheckedChanged
        If ChkAbs.Checked = True Then
            txtMark.Enabled = False
            cmdModify.Enabled = True
        End If
        If ChkAbs.Checked = False Then
            txtMark.Enabled = True
            cmdModify.Enabled = True
        End If
    End Sub

    
    Private Sub txtMark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMark.TextChanged
        If txtMark.Text = "" Then
            ChkAbs.Enabled = True
            cmdModify.Enabled = True
        End If
    End Sub
End Class