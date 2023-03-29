Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmModifyCass
    'Dim con As New ConClass
    Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    'Dim ClassError As New ClassError
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim PaperCodes_Tot As Integer
    Dim tot_mark As Integer = 0
    Dim recno As Integer
    Dim Max_Mark As Integer = 101
    Dim Min_Mark As Integer = 0
    Dim CandName, CentCode, SchoolCode, CandNo, Subjcode, YMrk2, YMrk3, Fmrk As String
    Dim countFound As Integer
    Dim Len As Integer
    Dim LNAME, FNAME, sub1 As String
    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        ' Try

        Dim CentCode As String = CboCentCode.Text
        Dim CandNo As String = CboCandNo.Text
        Dim Subjcode As String = Trim(CboSubName.Text)
        Dim cmd As New OleDbCommand


        gcon1.Open()
        cmd.CommandText = "update CassMarks set Year2Mrk= '" + txtYear2Mark.Text + "',Year3Mrk='" + txtYear3Mark.Text + "' Where    ((CENTCODE='" & CentCode & "')and (INDEXNO='" & CandNo & "') and(SubjName='" & Subjcode & "'))"
        cmd.Connection = gcon1
        cmd.ExecuteNonQuery()
        gcon1.Close()
        ValidateForm()
        MsgBox("Record Update Successful")
        CmdClear.Enabled = True
        ClearForm()
        CboCandNo.Text = ""

        ' Catch ex As Exception
        ' End Try
    End Sub

    Private Sub FrmModify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdModify.Enabled = False

        SubjName()
        CentreCode()

    End Sub

    Private Sub getCanNo()

        CboCandNo.Items.Clear()
        gcon1.Open()

        cmd.CommandText = "select Distinct INDEXNO from CassMarks Where(CENTCODE='" & CboCentCode.Text & "')"
        cmd.Connection = gcon1
        dr = cmd.ExecuteReader
        While dr.Read()
            CboCandNo.Items.Add(dr("INDEXNO"))
        End While
        dr.Close()
        gcon1.Close()

    End Sub

    Public Sub ValidateForm()

        If CboCentCode.Text = "" Or _
            CboCandNo.Text = "" Or _
            CboSubName.Text = "" Or _
            txtLName.Text = "" Or _
            txtYear2Mark.Text = "" Or _
            txtYear2Mark.Text = "000" Or _
            txtYear3Mark.Text = "" Or _
            txtYear3Mark.Text = "000" Then

            MsgBox("Please Enter all the details", MsgBoxStyle.Critical)
            CboCentCode.Focus()
        Else
            cmdModify.Enabled = True
        End If
    End Sub
    Public Sub ClearForm()

        'clears the form for new candidate entry
        CboCentCode.Enabled = True
        CboSubName.Enabled = True
        CboCandNo.SelectedIndex = 0
        CboCentCode.Focus()
        txtLName.Text = ""
        txtYear2Mark.Text = ""
        txtYear3Mark.Text = ""
        PaperCodes_Tot = 0
        cmdModify.Enabled = False


    End Sub
    Private Sub GetCandName()
        Try
            Dim cmd As New OleDbCommand

            gcon1.Open()
            cmd.CommandText = "select * from CandDetails where  INDEXNO='" + CboCandNo.Text + "' and CENTCODE='" + CboCentCode.Text + "'"
            cmd.Connection = gcon1
            dr = cmd.ExecuteReader
            dr.Read()
            LNAME = dr("LNAME")
            FNAME = dr("FNAME")
            txtLName.Text = LNAME + " " + FNAME
            dr.Close()
            gcon1.Close()

        Catch ex As Exception

            'Centcode is not correct
            If (SchoolCode <> CboCentCode.Text) Then
                MsgBox(" Please enter a correct Centcode")
            Else ' centcode is correct

            End If

            gcon1.Close()
        End Try

    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing CassMarks Form", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            CboCentCode.Focus()
        End If
    End Sub
    Public Sub RetrieveRecord()
        Try

            Subjcode = Trim(CboSubName.Text)

            gcon1.Open()
            'cmd.CommandText = "select SubjName from CassMarks where CandNo='" + CboCanNo.Text + "' and CentCode='" + CboCenCode.Text + "'"

            cmd.CommandText = "select * from CassMarks Where((CENTCODE='" + CboCentCode.Text + "')and (INDEXNO='" + CboCandNo.Text + "')and(SubjName='" + CboSubName.Text + "'))"
            cmd.Connection = gcon1
            dr = cmd.ExecuteReader

            If dr.Read() Then

                txtYear2Mark.Text = dr("Year2Mrk")
                txtYear3Mark.Text = dr("Year3Mrk")
            Else
                MsgBox("No mark available for modification")
            End If

            'end of modification
            dr.Close()
            gcon1.Close()

            GetCandName()

        Catch ex As Exception
            dr.Close()
            gcon1.Close()
        End Try

    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearForm()
    End Sub

    Private Sub CboSubName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSubName.SelectedIndexChanged

        RetrieveRecord()
    End Sub

    Private Sub txtYear2Mark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear2Mark.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtYear2Mark_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear2Mark.Leave
        'This code checks for the value entered in the text box to prevent user entering 000, 
        'Absent and more than 100

        Try
            If txtYear2Mark.Text > Min_Mark And txtYear2Mark.Text < Max_Mark Then 'Then

            Else  ' mark is out of range
                MessageBox.Show("Cass Mark must be between " & 0 & " and " & 100 & ".", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear2Mark.Clear()
                txtYear2Mark.Focus()
            End If
            If (txtYear2Mark.Text.Length > 3) Or (txtYear2Mark.Text.Length < 3) Then
                'Else 'did not enter three digits
                MessageBox.Show("Please enter 3 digits", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear2Mark.Clear()
                'txtYear2Mark.Focus()

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtYear2Mark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear2Mark.TextChanged
        cmdModify.Enabled = True
    End Sub

    Private Sub txtYear3Mark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear3Mark.KeyPress
        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
            'checkrange()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtYear3Mark_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear3Mark.Leave
        'This code validates the Cass Marks textboxes for 0 entry, Absent and marks more than 100

        Try
            'If IsNumeric(txtYear3Mark.Text) Then

            If txtYear3Mark.Text > Min_Mark And txtYear3Mark.Text < Max_Mark Then

            Else ' mark is out of range
                MessageBox.Show("Cass Mark must be between " & Min_Mark & " and " & Max_Mark & ".", "CassMark Entry Validation", MessageBoxButtons.OK)
                txtYear3Mark.Clear()

            End If
            If (txtYear3Mark.Text.Length > 3) Or (txtYear3Mark.Text.Length < 3) Then
                'did not enter three digits
                txtYear3Mark.Clear()

                MessageBox.Show("Please enter 3 digits", "CassMark Entry Validation", MessageBoxButtons.OK)
            End If

            ValidateForm()

        Catch ex As Exception
        Finally
            'txtYear3Mark.Focus()


        End Try
    End Sub

    Private Sub txtYear3Mark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear3Mark.TextChanged
        cmdModify.Enabled = True
    End Sub

    Private Sub CmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'da = New OleDbDataAdapter("Select * from CassMarks", con.con)
        'da.Fill(ds, "Transact")
        'recno = ds.Tables("Transact").Rows.Count = 0
        'display()

    End Sub

    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    recno += 1
        '    display()
        'Catch ex As Exception
        '    If MsgBox("Last Record Reached") Then
        '    End If
        'Finally
        'End Try
    End Sub

    Private Sub CmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    recno -= 1
        '    display()
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub CmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    recno = ds.Tables("CassMarks").Rows.Count - 1
        '    display()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub display()
        '
        CboCentCode.Text = ds.Tables("Transact").Rows(recno).Item("CENTCODE")
        CboCandNo.Text = ds.Tables("Transact").Rows(recno).Item("INDEXNO")
        CboSubName.Text = ds.Tables("Transact").Rows(recno).Item("SubjName")
        GetCandName()
        txtYear2Mark.Text = ds.Tables("CassMarks").Rows(recno).Item("Year2Mrk")
        txtYear3Mark.Text = ds.Tables("CassMarks").Rows(recno).Item("Year3Mrk")
    End Sub
    Private Sub SubjName()
        'Accessing Papcode from Subjects Table to fill the Papcode Combo box
        Dim cmd1 As New OleDbCommand
        gcon1.Open()
        cmd1.CommandText = "Select DISTINCT SubjName from CassMarks "
        cmd1.Connection = gcon1
        dr = cmd1.ExecuteReader
        While (dr.Read())
            CboSubName.Items.Add(dr("SubjName"))
        End While
        dr.Close()
        gcon1.Close()
    End Sub
    Private Sub CentreCode()

        'Dim Subjcode As String = Trim(CboSubName.Text)

        Dim cmd As New OleDbCommand
        gcon1.Open()
        cmd.CommandText = "Select DISTINCT CENTCODE From CassMarks " 'where CentCode='" & CboCenCode.Text & "'"
        cmd.Connection = gcon1
        dr = cmd.ExecuteReader
        While (dr.Read)
            CboCentCode.Items.Add(dr("CENTCODE"))

        End While
        dr.Close()
        gcon1.Close()

    End Sub

    Private Sub CboCentCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentCode.SelectedIndexChanged
        getCanNo()
    End Sub

    Private Sub CboCandNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCandNo.SelectedIndexChanged

        GetCandName()

        If CmdClear.Enabled = False Then
            CmdClear.Enabled = True

        End If
    End Sub
End Class