Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Imports System.Drawing.Printing

Public Class FrmReceipt
    Dim con As New ConClass
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & _
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
    Dim pcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon7 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon6 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                             System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon8 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                           System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim CandFee As Integer = 181.5
    Dim GovtFee As Integer = 181.5
    Dim Tot_Fees As Integer = 371.0
    Dim amt_paid As Integer
    Dim da As New OleDbDataAdapter
    Dim dp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim cmd As New OleDbCommand
    Dim Query3, mQuery As String
    Dim SubjCodes As String
    Dim SubjCode, eyear, noofsubjs, currentAmt As String
    Dim I As Integer
    Dim expAmt As Integer
    Dim AmtPaid As String
    Dim bal As Integer
    Dim sub1, sub2, sub3, sub4, sub5, sub6, sub7, sub8, sub9, status As String
    Private Sub FrmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        examYear()
        getCentres()
    End Sub
    Private Sub getCentres()
        'getting centcodes for each center
        Dim cent As String
        cent = "7"
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()
            cmd.CommandText = "Select Distinct CENTCODE From CandDetails where CENTCODE like '" & cent & "%' "
            cmd.Connection = con.con
            dr = cmd.ExecuteReader
            While (dr.Read)
                cbocentNo.Items.Add(dr("CENTCODE"))
            End While
            'End If
            dr.Close()
            con.CloseConnection()
        Catch ex As Exception
            ' dr.Close()
            con.CloseConnection()
        Finally
        End Try
    End Sub
    Sub examYear()

        eyear = Now.Year
        ' txtexyr.Text = eyear
        Dim cmd As New OleDbCommand
        con.OpenConnection()
        cmd.CommandText = "Select * from CandDetails"
        cmd.Connection = con.con
        dr = cmd.ExecuteReader
        While dr.Read()
            txtexyr.Text = (dr("EXAMYEAR"))
        End While
        con.CloseConnection()

    End Sub
    Sub expectamt()
        LblExpectedAmt.Visible = True
        LblExpectedAmt.Text = Tot_Fees
        lblbal.Text = bal

    End Sub
    Private Sub GetCandNO()
        Dim ccount As Integer
        Dim dr2 As OleDbDataReader
        Dim cmd2 As New OleDbCommand

        Dim flag As String

        Dim i As Integer

        flag = "i"
        Try
            gcon.Open()

            cmd2.CommandText = "select distinct(INDEXNO) from CandDetails where  CENTCODE Like ('" & cbocentNo.Text & "%') " 'and SUBJCODE Like ('" & myexaminer1 & "%')and FLAG Like ('" & flag & "%')"
            cmd2.Connection = gcon

            dr2 = cmd2.ExecuteReader

            ccount = dr2.RecordsAffected
            If dr2.HasRows Then
                If CboCandNum.Items.Count > 0 Then
                    CboCandNum.Items.Clear()
                End If
            End If

            'The var i is used to check whether subject has candidates registered
            While (dr2.Read())
                i = 1
                CboCandNum.Items.Add(dr2("INDEXNO"))
            End While

            dr2.Close()
        Catch ex As Exception
            gcon.Close()
        Finally
        End Try
    End Sub

    Private Sub cbocentNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocentNo.SelectedIndexChanged
        GetCandNO()
    End Sub
    Public Sub get_canddetails()
        Try
            Dim cmd As New OleDbCommand
            con.OpenConnection()

            cmd.CommandText = "select * from CandDetails Where((EXAMYEAR='" & txtexyr.Text & "')and (CENTCODE='" & cbocentNo.Text & "') and (INDEXNO='" & CboCandNum.Text & "'))"
            cmd.Connection = con.con
            dr = cmd.ExecuteReader

            If dr.Read() Then

                txtLname.Text = dr("LNAME")
                txtFName.Text = dr("FNAME")
                txtOtherName.Text = dr("OTHERNAME")
                txtSchchc.Text = dr("SCHNAME")
                txtschcode.Text = (dr("SCHCODE"))
                txtDOB.Text = dr("DOB")
                txtgender.Text = dr("SEX")

            End If

            dr.Close()
            con.CloseConnection()

        Catch ex As Exception
            dr.Close()
            con.CloseConnection()
        End Try
        expectamt()
    End Sub

    Sub get_Papers()

        ' Try
        Dim cmd As New OleDbCommand
        con.OpenConnection()

        cmd.CommandText = "select * from CandSubject Where((EXAMYEAR='" & txtexyr.Text & "')and (CENTCODE='" & cbocentNo.Text & "') and (INDEXNO='" & CboCandNum.Text & "'))"
        cmd.Connection = con.con
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
        txtNoofSubjs.Text = noofsubjs
        'Catch ex As Exception
        con.CloseConnection()
        'Finally
        'End Try
    End Sub
    Sub changeCode1()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        gcon1.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon1

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj1.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon1.Close()
    End Sub
    Sub changeCode2()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand


        pcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = pcon

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj2.Text = (dr("SubjName"))
        End While

        dr.Close()
        pcon.Close()
    End Sub
    Sub changeCode3()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand


        gcon2.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon2

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj3.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon2.Close()
    End Sub
    Sub changeCode4()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand


        gcon3.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon3

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj4.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon3.Close()
    End Sub
    Sub changeCode5()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand


        gcon4.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon4

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj5.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon4.Close()
    End Sub
    Sub changeCode6()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand


        gcon5.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon5

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj6.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon5.Close()
    End Sub
    Sub changeCode7()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        gcon6.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon6

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj7.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon6.Close()
    End Sub
    Sub changeCode8()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        gcon7.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon7

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj8.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon7.Close()
    End Sub
    Sub changeCode9()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        gcon1.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = gcon1

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtSubj9.Text = (dr("SubjName"))
        End While

        dr.Close()
        gcon1.Close()
    End Sub
    Sub subjects7()
        For I = 1 To 7
            subjcode = ""
            If I = 1 Then
                'Adding English
                subjcode = (dr("SUBJ1"))
                changeCode1()
            End If

            If I = 2 Then
                'Adding Mathematics
                subjcode = (dr("SUBJ2"))
                changeCode2()
            End If

            If I = 3 Then
                subjcode = (dr("SUBJ3"))
                changeCode3()
            End If

            If I = 4 Then
                subjcode = (dr("SUBJ4"))
                changeCode4()

            End If

            If I = 5 Then
                subjcode = (dr("SUBJ5"))
                changeCode5()
            End If


            If I = 6 Then
                subjcode = (dr("SUBJ6"))
                changeCode6()
            End If

            If I = 7 Then
                subjcode = (dr("SUBJ7"))
                changeCode7()
            End If
        Next

    End Sub
    Sub subjects8()
        For I = 1 To 8
            subjcode = ""

            If I = 1 Then
                'Adding English
                subjcode = (dr("SUBJ1"))
                changeCode1()
            End If

            If I = 2 Then
                'Adding Mathematics
                subjcode = (dr("SUBJ2"))
                changeCode2()
            End If

            If I = 3 Then
                subjcode = (dr("SUBJ3"))
                changeCode3()
            End If

            If I = 4 Then
                subjcode = (dr("SUBJ4"))
                changeCode4()

            End If

            If I = 5 Then
                subjcode = (dr("SUBJ5"))
                changeCode5()
            End If


            If I = 6 Then
                subjcode = (dr("SUBJ6"))
                changeCode6()
            End If

            If I = 7 Then
                subjcode = (dr("SUBJ7"))
                changeCode7()
            End If
            If I = 8 Then
                subjcode = (dr("SUBJ8"))
                changeCode8()
            End If
        Next

    End Sub
    Sub subjects9()
        For I = 1 To 9
            subjcode = ""

            If I = 1 Then
                'Adding English
                subjcode = (dr("SUBJ1"))
                changeCode1()
            End If

            If I = 2 Then
                'Adding Mathematics
                subjcode = (dr("SUBJ2"))
                changeCode2()
            End If

            If I = 3 Then
                subjcode = (dr("SUBJ3"))
                changeCode3()
            End If

            If I = 4 Then
                subjcode = (dr("SUBJ4"))
                changeCode4()

            End If

            If I = 5 Then
                subjcode = (dr("SUBJ5"))
                changeCode5()
            End If


            If I = 6 Then
                subjcode = (dr("SUBJ6"))
                changeCode6()
            End If

            If I = 7 Then
                subjcode = (dr("SUBJ7"))
                changeCode7()
            End If
            If I = 8 Then
                subjcode = (dr("SUBJ8"))
                changeCode8()
            End If
            If I = 9 Then
                subjcode = (dr("SUBJ9"))
                changeCode9()

            End If

        Next
    End Sub
    Sub ClearListBoxes()
        If txtSubj1.TextLength > 0 Then
            txtSubj1.Clear()

        End If
        If txtSubj2.TextLength > 0 Then
            txtSubj2.Clear()

        End If
        If txtSubj3.TextLength > 0 Then
            txtSubj3.Clear()

        End If
        If txtSubj4.TextLength > 0 Then
            txtSubj4.Clear()

        End If
        If txtSubj5.TextLength > 0 Then
            txtSubj5.Clear()

        End If
        If txtSubj6.TextLength > 0 Then
            txtSubj6.Clear()

        End If
        If txtSubj7.TextLength > 0 Then
            txtSubj7.Clear()

        End If
        If txtSubj8.TextLength > 0 Then
            txtSubj8.Clear()

        End If
        If txtSubj9.TextLength > 0 Then
            txtSubj9.Clear()

        End If

    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        get_canddetails()
        get_Papers()
        check_payment_status()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbexit.Click

        If MessageBox.Show("Do you want to Exit?", "Closing Candidate Payment Details", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            cbocentNo.Focus()
        End If

    End Sub
    Sub check_payment_status()
        Try
            gcon8.Open()
            centre = cbocentNo.Text

            index = CboCandNum.Text
            'Searching for the particular candidate
            cmd.CommandText = "select * from Fee_Tbl where EXAMYEAR like '" & txtexyr.Text & "%' and CENTCODE like '" & centre & "%' and INDEXNO like '" & index & "%' "
            cmd.Connection = gcon8

            dr = cmd.ExecuteReader
            '       Dim i As Integer
            While dr.Read()
                LblExpectedAmt.Text = (dr("EXPECTEDAMOUNT"))
                txtAmtPaid.Text = CStr(dr("AMOUNTPAID"))
                expAmt = CInt(dr("EXPECTEDAMOUNT"))
                AmtPaid = CInt(dr("AMOUNTPAID"))
                txtAmtPaid.Text = AmtPaid
                status = (dr("STATUS"))
            End While
            bal = expAmt - AmtPaid

            If bal = 0 Then
                lblbal.ForeColor = Color.Green
                lblbal.Text = bal
                ChkPaid.Checked = True
                ChNPaid.Checked = False
                status = "P"

            Else
                bal = expAmt
                lblbal.Text = bal
                ChNPaid.Checked = True
                ChkPaid.Checked = False
                status = "NP"
            End If

            LblExpectedAmt.Visible = True
            dr.Close()
            gcon8.Close()

        Catch EX As Exception
            gcon8.Close()
        Finally
        End Try
    End Sub

    Private Sub cmdUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        Try
            AmtPaid = CInt(txtAmtPaid.Text)
            currentAmt = currentAmt + AmtPaid


            getupdatefee()
            mQuery2 = "UPDATE Fee_Tbl SET AMOUNTPAID='" & AmtPaid & "',STATUS='" & status & "',OUTBAL='" & bal & "' WHERE EXAMYEAR like '" & txtexyr.Text & "%' and CENTCODE like '" & centre & "%' and INDEXNO like '" & index & "%' "
            mCmd2 = New OleDbCommand(mQuery2, gcon1)
            'Stored transaction details

            gcon1.Open()
            mCmd2.ExecuteNonQuery()
            Lmessage.Text = "Record Updated"

            gcon1.Close()
            'clearform()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            gcon.Close()

            gcon1.Close()
        Finally
        End Try

    End Sub

    Private Sub txtAmtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmtPaid.KeyPress

        If Not AscW(e.KeyChar) <= 47 And Not AscW(e.KeyChar) >= 58 Or AscW(e.KeyChar) = 8 Then
            e.Handled = False
            'checkrange()
        Else
            e.Handled = True


        End If
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim a As DialogResult
        getCandPapers()
        payment_status()


        a = MessageBox.Show("Do u want to preview the document", "print", MessageBoxButtons.YesNo)
        If (a = DialogResult.Yes) Then
            Dim pd As New PrintDocument
            AddHandler pd.PrintPage, AddressOf Me.PrintDocument1_PrintPage
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        ElseIf (a = DialogResult.No) Then
            Dim pd As PrintDocument = Nothing
            AddHandler pd.PrintPage, AddressOf Me.PrintDocument1_PrintPage
            PrintDialog1.Document = PrintDocument1
            If (PrintDialog1.ShowDialog() = DialogResult.OK) Then
                PrintDialog1.Document.Print()
            End If
        End If

        ' receiptNumber()
        AddCandPayment()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Label6.Text = "Candidate Payment Receipt"
        'getLogo()
        If (RichTextBox3.Text.Length <= 0) Then
            ' The West African Examinations Council
            e.Graphics.DrawString(lblwaec.Text, New Font(lblwaec.Text, 15, FontStyle.Italic), Brushes.Blue, 100, 50)
            'Image WAEC LOGO
            e.Graphics.DrawImage(PictureBox1.Image, 300, 100, 200, 200)


            e.Graphics.DrawString(lblcandetails.Text, New Font(lblcandetails.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 200, 300)


            'candidate centre
            e.Graphics.DrawString("Centre No:", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 25, 350)
            e.Graphics.DrawString(cbocentNo.Text, New Font(cbocentNo.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 125, 350)
            e.Graphics.DrawString("Index No.:", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 225, 350)
            e.Graphics.DrawString(CboCandNum.Text, New Font(CboCandNum.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 325, 350)
            'Candidate LName
            e.Graphics.DrawString("Lastname:", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 25, 385)
            e.Graphics.DrawString(txtLname.Text, New Font(txtLname.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 125, 385)
            'Candidate Fname
            e.Graphics.DrawString("Firstname:", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 300, 385)
            e.Graphics.DrawString(txtFName.Text, New Font(txtFName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 400, 385)

            e.Graphics.DrawString("OtherName:", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 600, 385)
            e.Graphics.DrawString(txtOtherName.Text, New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 675, 385)

            'DATE OF BIRTH
            e.Graphics.DrawString("Date of Birth :", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 25, 430)
            e.Graphics.DrawString(txtDOB.Text, New Font(txtDOB.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 165, 430)
            'CANDIDATE GENDER
            e.Graphics.DrawString("Gender :", New Font(txtgender.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 300, 430)
            e.Graphics.DrawString(txtgender.Text, New Font(txtgender.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 400, 430)
            'CANDIDATE SUBJECTS
            e.Graphics.DrawString(txtSubj1.Text, New Font(txtSubj1.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 490)
            e.Graphics.DrawString(txtSubj2.Text, New Font(txtSubj2.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 510)
            e.Graphics.DrawString(txtSubj3.Text, New Font(txtSubj3.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 530)
            e.Graphics.DrawString(txtSubj4.Text, New Font(txtSubj4.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 550)
            e.Graphics.DrawString(txtSubj5.Text, New Font(txtSubj5.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 570)
            e.Graphics.DrawString(txtSubj6.Text, New Font(txtSubj6.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 590)
            e.Graphics.DrawString(txtSubj7.Text, New Font(txtSubj7.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 610)
            e.Graphics.DrawString(txtSubj8.Text, New Font(txtSubj8.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 630)
            If indrange1 = 9 Then
                e.Graphics.DrawString(txtSubj9.Text, New Font(txtSubj9.Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, 25, 650)
            End If
            'Payment Status
            e.Graphics.DrawString("Expected Amount :D ", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 25, 750)
            e.Graphics.DrawString(expAmt, New Font(LblExpectedAmt.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 230, 750)

            e.Graphics.DrawString("Amount Paid : D", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 320, 750)
            e.Graphics.DrawString(txtAmtPaid.Text, New Font(txtAmtPaid.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 510, 750)

            e.Graphics.DrawString("Balance :", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 25, 770)
            e.Graphics.DrawString(bal, New Font(lblbal.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 190, 770)
            'Total Subjects
            e.Graphics.DrawString("Total Subjects :", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 25, 800)
            e.Graphics.DrawString(txtNoofSubjs.Text, New Font(txtNoofSubjs.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 190, 800)
            'Signature 
            e.Graphics.DrawString("Signature :", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 25, 870)
            e.Graphics.DrawString("...............................", New Font(txtNoofSubjs.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 130, 870)
            'Date signed
            e.Graphics.DrawString("Date :", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 430, 870)
            e.Graphics.DrawString("........................", New Font(txtNoofSubjs.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 480, 870)
            'Footer Line
            e.Graphics.DrawLine(Pens.Blue, 25, 1000, 815, 1000)
            'Footer Text
            e.Graphics.DrawString("Candidate Payment Receipt", New Font(txtOtherName.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 250, 1020)

            'e.Graphics.DrawString(subj2.Text, New Font(subj2.Font.FontFamily, 10, FontStyle.Bold), Brushes.DarkBlue, 250, 1020)
            ' e.Graphics.DrawString(receipt, New Font(Label6.Font.FontFamily, 10, FontStyle.Bold), Brushes.DarkBlue, 250, 1020)
        End If
    End Sub
    Sub AddCandPayment()
        'Dim mCmd As OleDbCommand
        'Dim mQuery As String
        'Dim cmd As New OleDbCommand
        'Dim dd As Date
        'Dim recete As Integer

        'dd = Date.Today
        'recete = ((Today.Second) * 17)

        'gcon.Open()
        'mQuery = "Insert into Cand_Transact(EXAMYEAR,CENTCODE,INDEXNO,AMOUNTPAID)" _
        '                                          & " values" _
        '                  & "('" & lblExamYear.Text & "','" & cbocentNo.Text & "','" & index & "','" & amtpay & "')"
        'mCmd = New OleDb.OleDbCommand(mQuery, gcon)
        'mCmd.ExecuteNonQuery()
        'gcon.Close()
    End Sub
    

    Sub getCandPapers()
        'Dim temp As String

        Try

            Dim cmd As New OleDbCommand
            gcon.Open()
            cmd.CommandText = "select * from CandSubject where EXAMYEAR Like ('" & lblExamYear.Text & "%') and CENTCODE Like ('" & cbocentNo.Text & "%') and INDEXNO like ('" & CboCandNum.Text & "%')"
            cmd.Connection = gcon
            dr = cmd.ExecuteReader

            While (dr.Read())
                indrange1 = dr("NOOFSUBJS")

                If indrange1 = 7 Then
                    'Method for candidates pursuing 8 subjects
                    psubjects7()
                ElseIf indrange1 = 8 Then
                    'Method for candidates pursuing 8 subjects
                    psubjects8()
                Else
                    'Method for candidates pursuing 9 subjects
                    psubjects9()

                End If
            End While


        Catch ex As Exception
            dr.Close()  '
        End Try
        gcon.Close()

    End Sub
    Sub psubjects7()
        For I = 1 To 7
            SubjCode = ""

            If I = 1 Then
                'Adding English
                SubjCode = (dr("SUBJ1"))
                pchangeCode1()

            End If

            If I = 2 Then
                SubjCode = (dr("SUBJ2"))
                pchangeCode2()

            End If

            If I = 3 Then
                SubjCode = (dr("SUBJ3"))
                pchangeCode3()
            End If

            If I = 4 Then
                SubjCode = (dr("SUBJ4"))
                pchangeCode4()

            End If

            If I = 5 Then
                SubjCode = (dr("SUBJ5"))
                pchangeCode5()

            End If

            If I = 6 Then
                SubjCode = (dr("SUBJ6"))
                pchangeCode6()

            End If

            If I = 7 Then
                SubjCode = (dr("SUBJ7"))
                pchangeCode7()

            End If
        Next
    End Sub
    Sub psubjects8()
        For I = 1 To 8
            SubjCode = ""

            If I = 1 Then
                'Adding English
                SubjCode = (dr("Sub1"))
                pchangeCode1()

            End If

            If I = 2 Then
                SubjCode = (dr("Sub2"))
                pchangeCode2()

            End If

            If I = 3 Then
                SubjCode = (dr("Sub3"))
                pchangeCode3()
            End If

            If I = 4 Then
                SubjCode = (dr("Sub4"))
                pchangeCode4()

            End If

            If I = 5 Then
                SubjCode = (dr("Sub5"))
                pchangeCode5()

            End If

            If I = 6 Then
                SubjCode = (dr("Sub6"))
                pchangeCode6()

            End If

            If I = 7 Then
                SubjCode = (dr("Sub7"))
                pchangeCode7()

            End If

            If I = 8 Then
                SubjCode = (dr("Sub8"))
                pchangeCode8()
            End If



        Next
    End Sub
    Sub psubjects9()
        For I = 1 To 9
            SubjCode = ""

            If I = 1 Then
                'Adding English
                SubjCode = (dr("Sub1"))
                pchangeCode1()

            End If

            If I = 2 Then
                SubjCode = (dr("Sub2"))
                pchangeCode2()

            End If

            If I = 3 Then
                SubjCode = (dr("Sub3"))
                pchangeCode3()
            End If

            If I = 4 Then
                SubjCode = (dr("Sub4"))
                pchangeCode4()

            End If

            If I = 5 Then
                SubjCode = (dr("Sub5"))
                pchangeCode5()

            End If

            If I = 6 Then
                SubjCode = (dr("Sub6"))
                pchangeCode6()

            End If

            If I = 7 Then
                SubjCode = (dr("Sub7"))
                pchangeCode7()

            End If

            If I = 8 Then
                SubjCode = (dr("Sub8"))
                pchangeCode8()
            End If
            If I = 9 Then
                SubjCode = (dr("Sub8"))
                pchangeCode9()
            End If


        Next
    End Sub
    Sub pchangeCode1()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        ' Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub1 = (dr("SubjName"))
        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode2()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        '  Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub2 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode3()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        ' Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub3 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode4()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        'Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub4 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode5()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        ' Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub5 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode6()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        'Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub6 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode7()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        'Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub7 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode8()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        'Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub8 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub pchangeCode9()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        'Dim check1 As String
        gcon.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & SubjCode & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())

            sub9 = (dr("SubjName"))

        End While

        dr.Close()
        gcon.Close()
    End Sub
    Sub payment_status()
        'Dim dr As OleDbDataReader
        'Dim cmd As New OleDbCommand


        'gcon.Open()

        'centre = cbocentNo.Text
        'Dim status As String

        'index = CboCandNum.Text
        ''Searching for the particular candidate
        'cmd.CommandText = "select * from Cand_payment where ExamYear like '" & lblExamYear.Text & "%' and CentNo like '" & centre & "%' and IndexNo like '" & index & "%' "
        'cmd.Connection = gcon

        'dr = cmd.ExecuteReader
        ''       Dim i As Integer
        'While dr.Read()
        '    expAmt = dr("EXPECTEDAMOUNT")
        '    amtpay = dr("AMOUNTPAID")
        '    bal = expAmt - amtpay

        '    status = dr("Status")
        'End While
        ''bal = expAmt - amtpay
        'LblExpectedAmt.Visible = True
        'dr.Close()
        'gcon.Close()
    End Sub
    Sub CheckCurrentAmt()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        index = CboCandNum.Text
        centre = cbocentNo.Text
        'Dim status As String

        pcon.Open()
        'Searching for the particular candidate
        cmd.CommandText = "select * from Fee_Tbl where EXAMYEAR like '" & txtexyr.Text & "%' and CENTCODE like '" & centre & "%' and INDEXNO like '" & index & "%' "
        cmd.Connection = pcon

        dr = cmd.ExecuteReader
        '       Dim i As Integer
        While dr.Read()
            currentAmt = CInt(dr("AMOUNTPAID"))
            txtAmtPaid.Text = currentAmt
        End While


        dr.Close()
        pcon.Close()
    End Sub
    Sub getreceipt(ByVal receipt As String)
        Dim rece As String
        rece = receipt
        Return
    End Sub

    
    Private Sub getupdatefee()

        bal = expAmt - AmtPaid

       
        If bal = 0 Then
            status = "P"
            ChkPaid.Checked = True
            ChNPaid.Checked = False
        Else
            status = "NP"
            ChNPaid.Checked = True
            ChkPaid.Checked = False
        End If
    End Sub

    Private Sub txtAmtPaid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmtPaid.Leave
        Dim paid As Integer
        Dim bala As Integer
        Dim PA As String
        expAmt = LblExpectedAmt.Text
        PA = txtAmtPaid.Text
        paid = CInt(PA)

        bala = CInt(expAmt) - CInt(paid)
        lblbal.Text = bala
    End Sub
    
End Class

