Imports System.Data.OleDb
Public Class frmQueries
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

        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Flag as Mark from ExpandedEntry where Flag Like ('" & Flag & "%') order by IndexNo", con)

        ds.Clear()
        da.Fill(ds, "ExpandedEntry")
        DataGridView1.DataSource = ds.Tables("ExpandedEntry")
        con.Close()
    End Sub


    Sub popsubject()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        subb = Mid(curuser, 5, 3)
        cmd.CommandText = "select distinct(SubjCode) from ExpandedEntry"

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
        'getSubLongname()

    End Sub
    Sub getSubLongname()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where SubjCode like '" & subb & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        cmbSubject.Items.Clear()
        While (dr.Read())
            cmbSubject.Items.Add(dr("Description"))
        End While


        dr.Close()
        con.Close()
    End Sub
    Sub subjects()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        cmd.CommandText = "select * from ExpandedEntry "
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
        If cmbSubject.Text = "" Then
            cmbSubject.Focus()
        Else

            cmd.CommandText = "select * from ExpandedEntry where ExamYear Like ('" & ExamYear & "%')and CentNo Like ('" & cmbcenter.Text & "%') and SubjCode Like ('" & cmbSubject.Text & "%') and Flag Like ('" & Flag & "%')"
            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                If cmbindex.Items.Count > 0 Then
                    cmbindex.Items.Clear()

                End If
            End If

            'The var i is used to check whether subject has candidates registered
            While (dr.Read())

                cmbindex.Items.Add(dr("IndexNo"))
            End While

            dr.Close()

        End If
        gcon.Close()

    End Sub
    Sub psearchcode()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.Open()

        cmd.CommandText = "select * from Wasubjects where Description like '" & cmbSubject.Text & "%'"
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
        cmd.CommandText = "select distinct(CentNo) from ExpandedEntry "
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
        con.Open()

        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Flag as Mark from ExpandedEntry where CentNo Like ('" & cmbcenter.Text & "%') and Flag Like ('" & Flag & "%') order by IndexNo", con)

        ds.Clear()
        da.Fill(ds, "ExpandedEntry")
        DataGridView1.DataSource = ds.Tables("ExpandedEntry")
        con.Close()
    End Sub

    Private Sub cmbindex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbindex.SelectedIndexChanged
        con.Open()

        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Flag as Mark from ExpandedEntry where CentNo Like ('" & cmbcenter.Text & "%') and SubjCode Like ('" & cmbSubject.Text & "%') and IndexNo Like ('" & cmbindex.Text & "%') and Flag Like ('" & Flag & "%')  order by IndexNo", con)

        ds.Clear()
        da.Fill(ds, "ExpandedEntry")
        DataGridView1.DataSource = ds.Tables("ExpandedEntry")
        con.Close()
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        con.Open()

        da = New OleDb.OleDbDataAdapter("select ExamYear,CentNo,IndexNo,SubjCode,Flag as Mark from ExpandedEntry where CentNo Like ('" & cmbcenter.Text & "%') and SubjCode Like ('" & cmbSubject.Text & "%') and Flag Like ('" & Flag & "%')  order by IndexNo", con)

        ds.Clear()
        da.Fill(ds, "ExpandedEntry")
        DataGridView1.DataSource = ds.Tables("ExpandedEntry")
        con.Close()
        getindexes()

    End Sub
End Class