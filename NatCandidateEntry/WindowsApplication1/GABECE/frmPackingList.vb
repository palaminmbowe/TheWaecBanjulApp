Imports System.Data
Imports System.Data.Sql

Imports System.Data.OleDb
Public Class frmPackingList
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gconn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim Pconn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcons As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                        System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim dr As OleDbDataReader
    Dim dr1 As OleDbDataReader
    Dim dr2 As OleDbDataReader
    Dim dr3 As OleDbDataReader
    Dim mCmd As OleDbCommand
    Dim mCmd1 As OleDbCommand
    Dim pack50 As Integer
    Dim pack15 As Integer
    Dim pack10 As Integer
    Dim pack5 As Integer
    Dim emerg As Integer
    Dim cent As String
    Dim center As String
    Dim subj As String
    Dim indrange1 As String
    Dim grade As String
    Dim mQuery As String
    Dim mQuery1 As String
    Dim Total_Entry As Integer
    Dim ans As Decimal

    Dim remainder As Integer
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim cmd2 As New OleDbCommand

    Dim num As Integer
    Dim numb As String

    Sub expandSubjects()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        cmd.CommandText = "select * from REGISTER_CANDIDATES"
        cmd.Connection = gcon

        dr3 = cmd.ExecuteReader
        MsgBox("start Expansion")

        Dim i As Integer
        While dr3.Read()
            i += 1
            indrange1 = dr3("NOOFSUBJS")

            If indrange1 = "7" Then

                For i = 1 To 7
                    subjcode = ""

                    If i = 1 Then
                        centno = (dr3("CENTCODE"))

                        subjcode = (dr3("SUBJ1"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centcode & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 2 Then
                        centcode = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ2"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 3 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ3"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 4 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ4"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 5 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ5"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 6 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ6"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 7 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ7"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If

                Next

            End If
            

            If indrange1 = "8" Then

                For i = 1 To 8
                    subjcode = ""

                    If i = 1 Then
                        centno = (dr3("CENTCODE"))

                        subjcode = (dr3("SUBJ1"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centcode & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 2 Then
                        centcode = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ2"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 3 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ3"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 4 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ4"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 5 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ5"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 6 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ6"))
                        '  changecode()
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 7 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ7"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 8 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ8"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                Next
            End If

            If indrange1 = "9" Then
                For i = 1 To 9
                    subjcode = ""

                    If i = 1 Then
                        centno = (dr3("CENTCODE"))

                        subjcode = (dr3("SUBJ1"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 2 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ2"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 3 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ3"))

                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 4 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ4"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 5 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ5"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 6 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ6"))
                        '  changecode()
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 7 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ7"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If
                    If i = 8 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ8"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If

                    If i = 9 Then
                        centno = (dr3("CENTCODE"))
                        subjcode = (dr3("SUBJ9"))
                        mQuery = "Insert into ListAll(CENTCODE,SubjCode)" _
                                          & " values" _
                                          & "('" & centno & "','" & subjcode & "')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcon)
                        mCmd.ExecuteNonQuery()
                    End If

                Next

            End If


        End While
        MsgBox("Finish Expansion")

        dr3.Close()
        gcon.Close()

    End Sub

    
    Private Sub cmdExpandSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpandSubjects.Click
        expandSubjects()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PackListByCenter()
    End Sub
    Sub PackingListByPaper()
        Dim cmd As New OleDbCommand
        MsgBox("start Packing List By Paper")
        gconn.Open()
        gcons.Open()
        gcon.Open()
        'Clear all the contents of ListByPaper Table before adding new values
        clearTablelistByPaper()
        cmd1.CommandText = "select * from SubjectTbl"
        cmd1.Connection = gcon
        dr2 = cmd1.ExecuteReader

        While (dr2.Read())
            subjcode = dr2("SubjCode")
            mQuery = "select count(*) from ListAll where SubjCode like ('" & subjcode & "%')"
            mCmd = New OleDb.OleDbCommand(mQuery, gcons)
            num = mCmd.ExecuteScalar()
            'numb = CStr(num)
            If num > 0 Then
                mQuery1 = "Insert into ListByPaper(SubjCode,Total_Entry)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & num & "')"
                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                mCmd1.ExecuteNonQuery()
            End If
        End While
        dr2.Close()
        gcon.Close()
        gcons.Close()
        gconn.Close()
        con.Close()
        'Start of calculating the parameters for packing list by paper
        gcon.Open()
        gconn.Open()
        con.Open()

        'Start Packing List Distribution by Paper
        cmd1.CommandText = "select * from Wasubjects"
        cmd1.Connection = gcon
        dr2 = cmd1.ExecuteReader
        While (dr2.Read())
            subjcode = dr2("SubjCode")
            cmd.CommandText = "select * from ListByPaper where SubjCode='" & subjcode & "'"
            cmd.Connection = con
            dr = cmd.ExecuteReader

            While dr.Read()
                Total_Entry = dr("Total_Entry")

                Select Case Total_Entry
                    Case 50 To 20000
                        num = 50
                        ans = Int(Total_Entry / num)
                        remainder = Total_Entry - (num * Int(ans))
                        pack50 = ans
                        mQuery1 = "UPDATE ListByPaper SET Pack50 ='" & pack50 & "' where SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        ' While remainder > 10

                        If remainder >= 15 Then
                            num = 15
                            Total_Entry = remainder
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack15 = ans
                            mQuery1 = "UPDATE ListByPaper SET Pack15 ='" & pack15 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                        End If
                        If remainder >= 10 And remainder < 15 Then
                            num = 10
                            Total_Entry = remainder
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack10 = ans
                            mQuery1 = "UPDATE ListByPaper SET Pack10 ='" & pack10 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                        End If
                        If remainder >= 5 And remainder < 10 Then
                            num = 5
                            Total_Entry = remainder
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack5 = ans
                            mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                        End If
                        If remainder < 5 And remainder > 0 Then
                            pack5 = 1
                            mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                        End If
                    Case 1 To 49

                        If Total_Entry >= 15 Then
                            num = 15
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack15 = ans
                            mQuery1 = "UPDATE ListByPaper SET Pack15 ='" & pack15 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                            If remainder >= 10 Then
                                num = 10
                                Total_Entry = remainder
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack10 = ans
                                mQuery1 = "UPDATE ListByPaper SET Pack10 ='" & pack10 & "' where SubjCode like ('" & subjcode & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                            If remainder >= 5 Then
                                num = 5
                                Total_Entry = remainder
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack5 = ans
                                mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                            If remainder < 5 And remainder > 0 Then
                                pack5 = 1
                                mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                        End If
                        'Greater than 10 and less than 15
                        If Total_Entry >= 10 And Total_Entry < 15 Then
                            num = 10
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack10 = ans
                            mQuery1 = "UPDATE ListByPaper SET Pack10 ='" & pack10 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()

                            If remainder >= 5 Then
                                num = 5
                                Total_Entry = remainder
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack5 = ans
                                mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                            If remainder < 5 And remainder > 0 Then
                                pack5 = 1
                                mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                        End If
                        'Greater than 5 and less than 10
                        If Total_Entry >= 5 And Total_Entry < 10 Then
                            num = 5
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack5 = ans
                            mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                            If remainder < 5 And remainder > 0 Then
                                pack5 = 1
                                mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                        End If
                        'Less than 5
                        If Total_Entry < 5 Then
                          
                            pack5 = 1
                            mQuery1 = "UPDATE ListByPaper SET Pack5 ='" & pack5 & "' where SubjCode like ('" & subjcode & "%')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                            
                        End If
                End Select
            End While
            dr.Close()
        End While
        MsgBox("Finish Creation of Packing List By Subject")
        dr2.Close()
        con.Close()
        gcon.Close()
        gconn.Close()
    End Sub
    Sub PackListByCenter()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        MsgBox("start Packing List By Center")
        con.Open()
        gconn.Open()
        gcons.Open()
        gcon.Open()
        'All centers
        clearTablelistByCent()
        cmd.CommandText = "select * from Wacenters"
        cmd.Connection = gcons
        dr = cmd.ExecuteReader

        While dr.Read()
            centno = dr("CentCode")
            cmd1.CommandText = "select * from Wasubjects"
            cmd1.Connection = gcon

            dr2 = cmd1.ExecuteReader
            While (dr2.Read())

                subjcode = dr2("SubjCode")
                mQuery = "select count(*) from ListAll where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')"
                mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                num = mCmd.ExecuteScalar()
            
                If num > 0 Then
                    mQuery1 = "Insert into ListByCent(CENTCODE,SubjCode,Total_Entry)" _
                                              & " values" _
                                              & "('" & centno & "','" & subjcode & "','" & num & "')"
                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                    mCmd1.ExecuteNonQuery()
                End If
            End While


            dr2.Close()
        End While
        dr.Close()
        dr2.Close()
        gcon.Close()
        gcons.Close()
        gconn.Close()
        con.Close()
        'Start of calculating the parameters for packing list by Center
        gcon.Open()
        gconn.Open()
        gcons.Open()
        con.Open()
        'Call Center
        cmd.CommandText = "select * from Wacenters"
        cmd.Connection = gcons
        dr3 = cmd.ExecuteReader

        While dr3.Read()
            centno = dr3("CentCode")
            cmd1.CommandText = "select * from Wasubjects"
            cmd1.Connection = gcon
            dr2 = cmd1.ExecuteReader
            MsgBox("Current Center:  " & centno & " Current Subject:  " & subjcode)
            ' MsgBox("Current Subject:  " & subjcode)
            While (dr2.Read())
                subjcode = dr2("SubjCode")
                cmd2.CommandText = "select * from ListByCent where CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                cmd2.Connection = con
                dr = cmd2.ExecuteReader

                While dr.Read()
                    Total_Entry = dr("Total_Entry")

                    Select Case Total_Entry
                        Case 50 To 20000
                            num = 50
                            ans = Int(Total_Entry / num)
                            remainder = Total_Entry - (num * Int(ans))
                            pack50 = ans
                            mQuery1 = "UPDATE ListByCent SET Pack50 ='" & pack50 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                            mCmd1.ExecuteNonQuery()
                            ' While remainder > 10

                            If remainder >= 15 Then
                                num = 15
                                Total_Entry = remainder
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack15 = ans
                                mQuery1 = "UPDATE ListByCent SET Pack15 ='" & pack15 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                            If remainder >= 10 And remainder < 15 Then
                                num = 10
                                Total_Entry = remainder
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack10 = ans
                                mQuery1 = "UPDATE ListByCent SET Pack10 ='" & pack10 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                            If remainder >= 5 And remainder < 10 Then
                                num = 5
                                Total_Entry = remainder
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack5 = ans
                                mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                            If remainder < 5 And remainder > 0 Then
                                pack5 = 1
                                mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                            End If
                        Case 1 To 49

                            If Total_Entry >= 15 Then
                                num = 15
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack15 = ans
                                mQuery1 = "UPDATE ListByCent SET Pack15 ='" & pack15 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                                If remainder >= 10 Then
                                    num = 10
                                    Total_Entry = remainder
                                    ans = Int(Total_Entry / num)
                                    remainder = Total_Entry - (num * Int(ans))
                                    pack10 = ans
                                    mQuery1 = "UPDATE ListByCent SET Pack10 ='" & pack10 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                    mCmd1.ExecuteNonQuery()
                                End If
                                If remainder >= 5 Then
                                    num = 5
                                    Total_Entry = remainder
                                    ans = Int(Total_Entry / num)
                                    remainder = Total_Entry - (num * Int(ans))
                                    pack5 = ans
                                    mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                    mCmd1.ExecuteNonQuery()
                                End If
                                If remainder < 5 And remainder > 0 Then
                                    pack5 = 1
                                    mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                    mCmd1.ExecuteNonQuery()
                                End If
                            End If
                            'Greater than 10 and less than 15
                            If Total_Entry >= 10 And Total_Entry < 15 Then
                                num = 10
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack10 = ans
                                mQuery1 = "UPDATE ListByCent SET Pack10 ='" & pack10 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()

                                If remainder >= 5 Then
                                    num = 5
                                    Total_Entry = remainder
                                    ans = Int(Total_Entry / num)
                                    remainder = Total_Entry - (num * Int(ans))
                                    pack5 = ans
                                    mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                    mCmd1.ExecuteNonQuery()
                                End If
                                If remainder < 5 And remainder > 0 Then
                                    pack5 = 1
                                    mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                    mCmd1.ExecuteNonQuery()
                                End If
                            End If
                            'Greater than 5 and less than 10
                            If Total_Entry >= 5 And Total_Entry < 10 Then
                                num = 5
                                ans = Int(Total_Entry / num)
                                remainder = Total_Entry - (num * Int(ans))
                                pack5 = ans
                                mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()
                                If remainder < 5 And remainder > 0 Then
                                    pack5 = 1
                                    mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                    mCmd1.ExecuteNonQuery()
                                End If
                            End If
                            'Less than 5
                            If Total_Entry < 5 Then

                                pack5 = 1
                                mQuery1 = "UPDATE ListByCent SET Pack5 ='" & pack5 & "' where  CENTCODE='" & centno & "' and SubjCode='" & subjcode & "'"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                                mCmd1.ExecuteNonQuery()

                            End If
                    End Select
                End While
                dr.Close()
            End While
            dr2.Close()
        End While
        MsgBox("Finish Creation of Packing List By Center")

        dr3.Close()
        con.Close()
        gcon.Close()
        gconn.Close()
        gcons.Close()

    End Sub

    Private Sub cmdPackingListByPaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPackingListByPaper.Click
        PackingListByPaper()
    End Sub

    Private Sub cmdViewPackByCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewPackByCenter.Click
        Dim byCenter As New frmPacklistByCenter
        byCenter.Show()

    End Sub

    Private Sub cmdWassceStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWassceStats.Click
        CreateResults()
    End Sub
    Sub CreateResults()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim i As Integer
        gcon.Open()
        gconn.Open()
        MsgBox("start Result Summary")
        con.Open()
        cmd.CommandText = "select * from Wasubjects"
        cmd.Connection = gcon

        dr3 = cmd.ExecuteReader

        While dr3.Read()


            subjcode = dr3("subjcode")

            For i = 1 To 9
                If i = 1 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub1 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade1")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()

                    End While
                    dr2.Close()
                End If
                If i = 2 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub2 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade2")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 3 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub3 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade3")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 4 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub4 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade4")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 5 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub5 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade5")
                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 6 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub6 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade6")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 7 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub7 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade7")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 8 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub8 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade8")

                        mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                          & " values" _
                                          & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                        mCmd1.ExecuteNonQuery()
                    End While
                    dr2.Close()
                End If
                If i = 9 Then

                    cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub9 like ('" & subjcode & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        subj = dr2("Sub9")
                        If subj <> "" Then
                            grade = dr2("Grade9")
                            mQuery1 = "Insert into WaaStat(SubjCode,CENTCODE,IndexNo,Grade)" _
                                              & " values" _
                                              & "('" & subjcode & "','" & centno & "','" & index & "','" & grade & "')"
                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                            mCmd1.ExecuteNonQuery()

                        End If
                    End While
                    dr2.Close()
                End If

            Next

        End While
        MsgBox("Finish Entry Summary")

        dr3.Close()
        gcon.Close()

    End Sub

    Private Sub cmdPerformance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPerformance.Click
        CenterPerform()
    End Sub
    Sub CenterPerform()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim i As Integer
        gcon.Open()
        'gconn.Open()
        gcons.Open()
        MsgBox("start Center Performance")
        con.Open()



        cmd1.CommandText = "select * from Wacenters"
        cmd1.Connection = con
        dr = cmd1.ExecuteReader

        While dr.Read()

            centno = dr("CentCode")
            cmd.CommandText = "select * from Wasubjects"
            cmd.Connection = gcon

            dr3 = cmd.ExecuteReader

            While dr3.Read()
                subjcode = dr3("subjcode")

                For i = 1 To 10
                    If i = 1 Then
                        grade = "1"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        'If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade1 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 2 Then
                        grade = "2"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade2 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 3 Then
                        grade = "3"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade3 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 4 Then
                        grade = "4"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade4 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 5 Then
                        grade = "5"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade5 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        ' End If
                    End If
                    If i = 6 Then
                        grade = "6"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '    If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade6 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 7 Then
                        grade = "7"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade7 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 8 Then
                        grade = "8"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade8 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        'End If
                    End If
                    If i = 9 Then
                        grade = "9"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Grade9 ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        ' End If
                    End If
                    If i = 10 Then
                        grade = "X"
                        mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')and Grade like ('" & grade & "%')"
                        mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                        num = mCmd.ExecuteScalar()
                        numb = CStr(num)
                        '   If numb <> "0" Then
                        mQuery1 = "UPDATE SubStats SET Absent ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        ' End If
                    End If
                    mQuery = "select count(*) from WaaStat where CENTCODE Like ('" & centno & "%') and SubjCode like ('" & subjcode & "%')"
                    mCmd = New OleDb.OleDbCommand(mQuery, gcons)
                    num = mCmd.ExecuteScalar()
                    numb = CStr(num)
                    'If numb <> "0" Then
                    mQuery1 = "UPDATE SubStats SET TotalCand ='" & numb & "' where CENTCODE Like ('" & center & "%')and SubjCode like ('" & subjcode & "%')"
                    mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                    mCmd1.ExecuteNonQuery()

                Next
            End While
            dr3.Close()
        End While
        MsgBox("Finish Center Performance Summary")

        dr.Close()
        gcon.Close()

    End Sub

    Private Sub cmdCentSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCentSubjects.Click
        CenterSubjects()
    End Sub
    Sub CenterSubjects()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim Curcentre As String
        Dim curSubj As String
        'Dim i As Integer
        Curcentre = ""
        curSubj = ""
        gcon.Open()
        gconn.Open()
        MsgBox("start Center Subjects")
        con.Open()
        cmd.CommandText = "select * from Wasubjects"
        cmd.Connection = gcon

        dr3 = cmd.ExecuteReader

        While dr3.Read()

            subjcode = dr3("subjcode")
            ''''

            cmd1.CommandText = "select * from Wacenters"
            cmd1.Connection = con

            dr2 = cmd1.ExecuteReader

            While dr2.Read()
                centno = dr2("CentCode")

                cmd2.CommandText = "select distinct(CENTCODE) from WaaStat "
                cmd2.Connection = con
                dr = cmd2.ExecuteReader

                While dr.Read()
                    ';cent = centno
                    'centno = dr("CentNo")
                    If (Curcentre <> centno) Then
                        mQuery1 = "Insert into SubStats(SubjCode,CENTCODE)" _
                                                     & " values" _
                                                     & "('" & subjcode & "','" & centno & "')"
                        mCmd1 = New OleDb.OleDbCommand(mQuery1, gconn)
                        mCmd1.ExecuteNonQuery()
                        Curcentre = centno
                        curSubj = subjcode
                    End If
                End While
                dr.Close()
            End While
            dr2.Close()

        End While
        MsgBox("Finish Updating Center Subjects")

        dr3.Close()
        con.Close()
        gconn.Close()
        gcon.Close()

    End Sub

    Sub papa()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim dr4 As OleDbDataReader
        Dim cmd4 As New OleDbCommand
        Dim i As Integer
        'Dim t As Integer
        Dim CandName As String
        Dim tot_subj As String = ""
        gcon.Open()
        gconn.Open()
        gcons.Open()
                MsgBox("start Result Summary")
        con.Open()
        cmd.CommandText = "select * from Wacenters"
        cmd.Connection = gcons

        dr3 = cmd.ExecuteReader
        Pconn.Open()
        cmd4.CommandText = "select * from Wasubjects"
        cmd4.Connection = Pconn

        dr4 = cmd4.ExecuteReader
        ''loop one for subjects
        ''Select a subject and search result file for presence of subject
        'While dr4.Read()
        '    For t = 1 To 34

        'loop two for centers
        'select all centers and select where subject code equals selected subject
        While dr3.Read()
            While dr4.Read()
                subjcode = dr4("SubjCode")
                'MsgBox("Current Subject:  " & subjcode)

                If subjcode <> "302" Or subjcode <> "402" Then
                    'Candidate subject 1 to 9
                    For i = 1 To 9
                        If i = 1 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub1 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade1")
                                CandName = dr2("CandName")
                                tot_subj = dr2("tot_subj")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "',tot_subj='" & tot_subj & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 2 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub2 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade2")
                                CandName = dr2("CandName")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 4 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub4 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade4")
                                CandName = dr2("CandName")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 5 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub5 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade5")
                                CandName = dr2("CandName")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 6 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub6 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade6")
                                CandName = dr2("CandName")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 7 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub7 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade6")
                                CandName = dr2("CandName")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 8 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub8 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                grade = dr2("Grade8")
                                CandName = dr2("CandName")

                                cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                cmd1.Connection = gcon

                                dr = cmd1.ExecuteReader
                                While dr.Read
                                    If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                        mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                        mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                        mCmd1.ExecuteNonQuery()
                                    End If
                                End While
                                dr.Close()
                            End While
                            dr2.Close()
                        End If
                        If i = 9 Then

                            cmd.CommandText = "select * from REGISTER_CANDIDATES where Sub9 like ('" & subjcode & "%')"
                            cmd.Connection = gconn
                            dr2 = cmd.ExecuteReader
                            While dr2.Read()
                                centno = dr2("CENTCODE")
                                index = dr2("IndexNo")
                                subj = dr2("Sub9")
                                If subj <> "" Then
                                    grade = dr2("Grade9")
                                    CandName = dr2("CandName")

                                    cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                                    cmd1.Connection = gcon

                                    dr = cmd1.ExecuteReader
                                    While dr.Read
                                        If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        ElseIf tot_subj = "9" And dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                            mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                            mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                            mCmd1.ExecuteNonQuery()
                                        End If
                                    End While
                                    dr.Close()
                                End If ' for nine subjeccts
                            End While 'end while for the dr2

                        End If
                        dr2.Close()
                    Next
                End If
            End While
        End While

        '    Next
        ''close of dr3
        'End While

        MsgBox("Finish results re-arrangement")
        Pconn.Close()
        dr3.Close()
        dr4.Close()
        gcon.Close()

    End Sub
    Sub sawaneh()
        Dim dr3 As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim dr4 As OleDbDataReader
        Dim cmd4 As New OleDbCommand
        'Dim i As Integer
        'Dim t As Integer
        ' Dim CandName As String
        'Dim tot_subj As String
        gcon.Open()
        gconn.Open()
        gcons.Open()
        MsgBox("start Result Summary")
        con.Open()
        cmd.CommandText = "select * from Wacenters"
        cmd.Connection = gcons

        dr3 = cmd.ExecuteReader
        Pconn.Open()
        cmd4.CommandText = "select * from Wasubjects"
        cmd4.Connection = Pconn

        dr4 = cmd4.ExecuteReader

        While dr3.Read()
            centno = dr3("CentCode")
            'index = dr3("IndexNo")
            While dr4.Read()
                subjcode = dr4("SubjCode")
                MsgBox("Current Subject:  " & subjcode)

                If subjcode <> "302" Or subjcode <> "402" Then
                    cmd.CommandText = "select * from waastat where SubjCode like ('" & subjcode & "%')and CENTCODE like ('" & centno & "%')"
                    cmd.Connection = gconn
                    dr2 = cmd.ExecuteReader
                    While dr2.Read()
                        centno = dr2("CENTCODE")
                        index = dr2("IndexNo")
                        grade = dr2("Grade")
                        cmd1.CommandText = "select * from wapmast where CENTCODE Like ('" & centno & "%')and IndexNo like ('" & index & "%')"
                        cmd1.Connection = gcon

                        dr = cmd1.ExecuteReader
                        While dr.Read
                            If dr("Sub3").ToString = "" And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub3='" & subjcode & "',Grade3='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            ElseIf dr("Sub4").ToString = "" And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub4='" & subjcode & "',Grade4='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            ElseIf dr("Sub5").ToString = "" And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub5='" & subjcode & "',Grade5='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            ElseIf dr("Sub6").ToString = "" And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub6='" & subjcode & "',Grade6='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            ElseIf dr("Sub7").ToString = "" And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub7='" & subjcode & "',Grade7='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            ElseIf dr("Sub8").ToString = "" And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub8='" & subjcode & "',Grade8='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            ElseIf dr("Sub9").ToString = "" And dr("Sub8").ToString <> subjcode And dr("Sub7").ToString <> subjcode And dr("Sub6").ToString <> subjcode And dr("Sub5").ToString <> subjcode And dr("Sub4").ToString <> subjcode And dr("Sub3").ToString <> subjcode And dr("Sub2").ToString <> subjcode And dr("Sub1").ToString <> subjcode Then
                                mQuery1 = "Update wapmast set Sub9='" & subjcode & "',Grade9='" & grade & "' where CENTCODE Like ('" & center & "%')and IndexNo like ('" & index & "%')"
                                mCmd1 = New OleDb.OleDbCommand(mQuery1, con)
                                mCmd1.ExecuteNonQuery()
                            End If
                        End While
                        dr.Close()
                    End While
                    dr2.Close()
                End If
                dr2.Close()
            End While
        End While


        MsgBox("Finish results re-arrangement")
        Pconn.Close()
        dr3.Close()
        dr4.Close()
        gcon.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReArrange.Click
        cmdReArrange.Enabled = False
        'papa()
        sawaneh()
        cmdReArrange.Enabled = True
    End Sub
    Sub clearTablelistByCent()
        Pconn.Open()
        mQuery1 = "Delete * from ListByCent"
        mCmd1 = New OleDb.OleDbCommand(mQuery1, Pconn)
        mCmd1.ExecuteNonQuery()
        Pconn.Close()
    End Sub
    Sub clearTablelistByPaper()
        Pconn.Open()
        mQuery1 = "Delete * from ListByPaper"
        mCmd1 = New OleDb.OleDbCommand(mQuery1, Pconn)
        mCmd1.ExecuteNonQuery()
        Pconn.Close()
    End Sub

    Private Sub frmPackingList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdPackingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPackingList.Click

    End Sub
End Class