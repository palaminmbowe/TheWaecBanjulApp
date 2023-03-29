Imports System.Data.OleDb
Public Class ViewMarks
    'Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                                System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    'Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                               System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")

    Public gcon As New OleDbConnection(MDIParent1.connectionString)
    Public con As New OleDbConnection(MDIParent1.connectionString)

    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim subj As String
    Dim ExamYear As String


    Private Sub ViewCandidates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ExamYear = Now.Year
        popsubject()
        loadcenter()
        con.Open()
        If curuser = "SAWANEH" Then
            da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Mark from TassMarks order by IndexNo", con)
        Else
            da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Mark from TassMarks where ExaminerNo Like ('" & Examiner & "%')order by IndexNo", con)
        End If

        ds.Clear()
        da.Fill(ds, "TassMarks")
        DataGridView1.DataSource = ds.Tables("TassMarks")
        con.Close()
    End Sub


    Sub popsubject()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        subb = Mid(curuser, 5, 3)
        If curuser = "SAWANEH" Then
            cmd.CommandText = "select distinct(SubjCode) from TassMarks"
        Else
            cmd.CommandText = "select distinct(SubjCode) from TassMarks where SubjCode Like ('" & subb & "%')"
        End If
        cmd.Connection = con

        dr = cmd.ExecuteReader
        If CmbSubject.Items.Count > 0 Then
            CmbSubject.Items.Clear()
        End If
        While (dr.Read())
            cmbSubject.Items.Add(dr("SubjCode"))

        End While

        dr.Close()
        con.Close()
        'getSubLongname()

    End Sub
    Sub getSubLongname()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where SubjCode like '" & subb & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        CmbSubject.Items.Clear()
        While (dr.Read())
            CmbSubject.Items.Add(dr("Description"))
        End While


        dr.Close()
        con.Close()
    End Sub
    Sub subjects()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        cmd.CommandText = "select * from TassMarks "
        cmd.Connection = con

        dr = cmd.ExecuteReader
        If cmbSubject.Items.Count > 0 Then
            cmbSubject.Items.Clear()
        End If
        While (dr.Read())
            cmbSubject.Items.Add(dr("SubjCode"))
        End While

        dr.Close()
        con.Close()


    End Sub
    Sub getindexes()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim center As String

        center = cmbcenter.SelectedItem
        gcon.Open()
        If CmbSubject.Text = "" Then
            CmbSubject.Focus()
        Else

            cmd.CommandText = "select * from Tassmarks where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & cmbcenter.Text & "%') and SubjCode Like ('" & cmbSubject.Text & "%')"
            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                If cmbindex.Items.Count > 0 Then
                    cmbindex.Items.Clear()

                End If
            End If

            'The var i is used to check whether subject has candidates registered
            While (dr.Read())

                cmbIndex.Items.Add(dr("IndexNo"))
            End While

            dr.Close()

        End If
        gcon.Close()

    End Sub
    Sub psearchcode()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where Description like '" & CmbSubject.Text & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            subj = (dr("SubjCode"))
        End While
        dr.Close()
        con.Close()

    End Sub
    Sub loadcenter()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        If con.State = ConnectionState.Open Then
            con.Close()
        Else
            con.Open()
        End If
        cmd.CommandText = "select distinct(CentNo) from TassMarks where ExaminerNo like '" & Examiner & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        If cmbcenter.Items.Count > 0 Then
            cmbcenter.Items.Clear()
        End If
        While (dr.Read())
            cmbcenter.Items.Add(dr("CentNo"))
        End While

        dr.Close()
        con.Close()
    End Sub

    Private Sub cmbcenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcenter.SelectedIndexChanged
        popsubject()
        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Mark from TassMarks order by CentNo,IndexNo", con)
        da.Fill(ds, "CentNo")
        DataGridView1.DataSource = ds.Tables("TassMarks")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub cmbindex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbindex.SelectedIndexChanged
        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Mark from TassMarks where ExamYear Like ('" & ExamYear & "%') and  CentNo like ('" & Trim(cmbcenter.Text) & "%') and IndexNo like ('" & Trim(cmbindex.Text) & "%') order by IndexNo", con)
        ds.Clear()
        da.Fill(ds, "TassMarks")
        DataGridView1.DataSource = ds.Tables("TassMarks")
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Mark from TassMarks where ExamYear Like ('" & ExamYear & "%') and  CentNo like ('" & Trim(cmbcenter.Text) & "%') and IndexNo like ('" & Trim(cmbindex.Text) & "%') order by IndexNo", con)
        ds.Clear()
        da.Fill(ds, "TassMarks")

        DataGridView1.DataSource = ds.Tables("TassMarks")
        getindexes()

    End Sub
End Class