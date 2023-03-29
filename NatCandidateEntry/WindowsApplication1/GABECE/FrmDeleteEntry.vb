Imports System.Data
Imports System.Windows.Forms.MessageBox
Imports System.Data.OleDb
Imports System.IO
Public Class FrmDeleteEntry

    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcons As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                 System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim gcon2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                 System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon4 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon5 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon6 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon7 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon8 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon9 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon11 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                 System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon13 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

   
    Dim da As OleDbDataAdapter
    Dim dAdapt As OleDbDataAdapter
    Dim dr As OleDbDataReader

    Dim cmd As OleDbCommand
    Dim mCmd1 As OleDbCommand
    Dim mCmd2 As OleDbCommand
    Dim mCmd3 As OleDbCommand
    Dim mCmd4 As OleDbCommand
    Dim mCmd5 As OleDbCommand
    Dim mQuery As String
    Dim subjcode, curcentre, nname As String
    Dim dSet As DataSet
    Dim ds As New DataSet
    Dim sex, canno, centcode As String
    Dim i As Integer
    Dim range As Integer
    Dim ExceptionMessageBox As Exception
    Private Sub frmDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetExamYear()
        getcenters()

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        Try
            closeconnections()
            Dim Cent As String
            Dim CandNum As String

            CandNum = txtcanno.Text
            Cent = CboCentCode.Text

            nname = Cent + CandNum
            GetExamYear()

            If MessageBox.Show("You have selected " & nname & ". Do you want to Delete this record?", "Candidate Entry Deletion", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                gcon8.Open()

                mQuery = "DELETE from CandDetails WHERE ((EXAMYEAR='" & txtexamyear.Text & "') AND (CENTCODE='" & CboCentCode.Text & "') AND (INDEXNO='" & canno & "'))"

                mCmd1 = New OleDbCommand(mQuery, gcon8)

                mCmd1.ExecuteNonQuery()
                'Me.Close()
                MsgBox("Record Deleted")
            Else
                CboCentCode.Focus()
            End If


            clearform()

        Catch ex As Exception
            gcon8.Close()
            MessageBox.Show(ex.Message)
            gcon8.Close()
        Finally


        End Try

        cmddelete.Enabled = False

    End Sub
    Sub GetExamYear()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon2.Open()
            cmd.CommandText = "select * from CandDetails"
            cmd.Connection = gcon2

            dr = cmd.ExecuteReader
            While dr.Read
                txtexamyear.Text = dr("EXAMYEAR")
            End While

            dr.Close()
        Catch ex As Exception
            gcon2.Close()
        Finally
        End Try

    End Sub
    
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()

    End Sub

    Sub clearform()
        txtSubj1.Clear()
        txtSubj2.Clear()
        txtSubj3.Clear()
        txtSubj4.Clear()
        txtSubj5.Clear()
        txtSubj6.Clear()
        txtSubj7.Clear()
        txtSubj8.Clear()
        txtSubj9.Clear()
        txtLName.Text = ""
        txtFName.Text = ""
        txtOtherName.Text = ""
        txtschcode.Text = ""
        DateTimePicker1.Text = ""
        txtgender.Text = ""
        txtcanno.Text = ""
        txtNoofSubjs.Text = ""
        closeconnections()


    End Sub
  
    'Public Function FixNull(ByVal test As Object) As String()
    '    'Dim nulls As String

    '    'If IsDBNull(test) Then
    '    '    Return (nulls)
    '    'Else
    '    '    Return (test)
    '    'End If
    'End Function

    Sub getcenters()

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
    Sub Getindex()
        ' Dim canno As String

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        gcon.Open()
        curcentre = CboCentCode.Text
        cmd.CommandText = "select * FROM CandDetails where EXAMYEAR Like ('" & txtexamyear.Text & "%') and CENTCODE Like ('" & CboCentCode.Text & "%') "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        ' While dr.Read()
        If dr.Read Then
            ' CboCanNo.Items.Add(dr("INDEXNO"))
            canno = (dr("INDEXNO"))
        End If
        '  End While

        dr.Close()
        gcon.Close()
        ' getpapers()
    End Sub
    Sub changecode1()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon11.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon11

            dr = cmd.ExecuteReader
            While (dr.Read())
                txtSubj1.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon11.Close()
        Finally
        End Try
    End Sub
    Sub changecode2()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon13.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon13

            dr = cmd.ExecuteReader
            While (dr.Read())
                txtSubj2.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon13.Close()
        Finally
        End Try
    End Sub

    Sub changecode3()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon3.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon3

            dr = cmd.ExecuteReader
            While (dr.Read())
                txtSubj3.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon1.Close()
        Finally
        End Try
    End Sub
    Sub changecode4()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon4.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon4

            dr = cmd.ExecuteReader
            While (dr.Read())
                txtSubj4.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon1.Close()
        Finally
        End Try
    End Sub
    Sub changecode5()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon5.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon5

            dr = cmd.ExecuteReader
            While (dr.Read())
                txtSubj5.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon5.Close()
        Finally
        End Try
    End Sub
    Sub changecode6()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon6.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon6

            dr = cmd.ExecuteReader
            While (dr.Read())
                txtSubj6.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon6.Close()
        Finally
        End Try
    End Sub
    Sub changecode7()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon7.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon7

            dr = cmd.ExecuteReader

            While dr.Read()
                txtSubj7.Text = (dr("SubjName"))

            End While

            dr.Close()
        Catch ex As Exception
            gcon7.Close()
        Finally
        End Try
    End Sub
    Sub changecode8()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon8.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon8

            dr = cmd.ExecuteReader
            While dr.Read()
                txtSubj8.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon8.Close()
        Finally
        End Try
    End Sub
    Sub changecode9()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            gcon9.Open()

            cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
            cmd.Connection = gcon9

            dr = cmd.ExecuteReader
            While dr.Read()
                txtSubj9.Text = (dr("SubjName"))
            End While

            dr.Close()
        Catch ex As Exception
            gcon9.Close()
        Finally
        End Try
    End Sub
    Sub getpapers()
        'Try

        Dim cmd As New OleDbCommand
        gcons.Open()
        cmd.CommandText = "select * from CandSubject where EXAMYEAR like('" & txtexamyear.Text & "%') and CENTCODE like( '" & CboCentCode.Text & "%') and INDEXNO like( '" & txtcanno.Text & "%')"
        cmd.Connection = gcons
        dr = cmd.ExecuteReader

        While (dr.Read())
            range = dr("NOOFSUBJS")

            If range = 7 Then
                'Method for candidates pursuing 8 subjects
                subjects7()
            ElseIf range = 8 Then
                'Method for candidates pursuing 9 subjects
                subjects8()
            Else
                subjects9()

            End If
        End While
        dr.Close()
        txtNoofSubjs.Text = range
        gcons.Close()
        ' Catch ex As Exception
        gcons.Close()
        ' End Try
    End Sub
    Sub GetBioDetails()
        Try
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand

            gcon.Open()

            cmd.CommandText = "select * from CandDetails where EXAMYEAR Like ('" & txtexamyear.Text & "%') and CENTCODE like  ('" & CboCentCode.Text & "%') and INDEXNO like( '" & txtcanno.Text & "%')"
            cmd.Connection = gcon

            dr = cmd.ExecuteReader
            If dr.Read() Then

                txtFName.Text = (dr("FNAME"))
                txtLName.Text = (dr("LNAME"))
                txtOtherName.Text = (dr("OTHERNAME"))
                DateTimePicker1.Text = (dr("DOB"))
                txtschcode.Text = (dr("SCHCODE"))
                txtgender.Text = (dr("SEX"))

            End If
            dr.Close()
        Catch ex As Exception

            gcon.Close()
        Finally
        End Try
    End Sub
    Sub subjects7()
        For i = 1 To 7
            subjcode = ""

            If i = 1 Then
                '  Adding(English)
                subjcode = dr("SUBJ1")
                changecode1()

            End If

            If i = 2 Then
                ' Adding(Mathematics)
                subjcode = dr("SUBJ2")
                changecode2()

            End If

            If i = 3 Then
                subjcode = dr("SUBJ3")
                changecode3()

            End If

            If i = 4 Then
                subjcode = dr("SUBJ4")
                changecode4()
            End If

            If i = 5 Then
                subjcode = dr("SUBJ5")
                changecode5()
            End If

            If i = 6 Then
                subjcode = dr("SUBJ6")
                changecode6()
            End If

            If i = 7 Then
                subjcode = dr("SUBJ7")
                changecode7()
            End If

        Next
    End Sub
    Sub subjects8()
        For i = 1 To 8
            subjcode = ""

            If i = 1 Then
                '  Adding(English)
                subjcode = dr("SUBJ1")
                changecode1()

            End If

            If i = 2 Then
                ' Adding(Mathematics)
                subjcode = dr("SUBJ2")
                changecode2()

            End If

            If i = 3 Then
                subjcode = dr("SUBJ3")
                changecode3()

            End If

            If i = 4 Then
                subjcode = dr("SUBJ4")
                changecode4()
            End If

            If i = 5 Then
                subjcode = dr("SUBJ5")
                changecode5()
            End If

            If i = 6 Then
                subjcode = dr("SUBJ6")
                changecode6()
            End If

            If i = 7 Then
                subjcode = dr("SUBJ7")
                changecode7()
            End If
            If i = 8 Then
                subjcode = dr("SUBJ8")
                changecode8()
            End If

        Next
    End Sub
    Sub subjects9()
        For i = 1 To 9
            subjcode = ""

            If i = 1 Then
                '  Adding(English)
                subjcode = dr("SUBJ1")
                changecode1()

            End If

            If i = 2 Then
                ' Adding(Mathematics)
                subjcode = dr("SUBJ2")
                changecode2()

            End If

            If i = 3 Then
                subjcode = dr("SUBJ3")
                changecode3()

            End If

            If i = 4 Then
                subjcode = dr("SUBJ4")
                changecode4()
            End If

            If i = 5 Then
                subjcode = dr("SUBJ5")
                changecode5()
            End If

            If i = 6 Then
                subjcode = dr("SUBJ6")
                changecode6()
            End If

            If i = 7 Then
                subjcode = dr("SUBJ7")
                changecode7()
            End If
            If i = 8 Then
                subjcode = dr("SUBJ8")
                changecode8()
            End If
            If i = 9 Then
                subjcode = dr("SUBJ9")
                changecode9()
            End If

        Next
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        clearform()

    End Sub
    Sub closeconnections()

        gcon.Close()
        gcon1.Close()
        gcon8.Close()
        gcons.Close()

    End Sub
   
    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        closeconnections()
        GetBioDetails()
        getpapers()
        cmddelete.Enabled = True
    End Sub

   
End Class

