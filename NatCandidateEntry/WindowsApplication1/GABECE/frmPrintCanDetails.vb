Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class frmPrintCanDetails

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")

    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim gcons As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")

    Dim gconn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                              System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim Pcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                            System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim curcentre As String
    Dim dr As OleDbDataReader
    Dim GendStatus As String
    Dim sex As String
    Dim i As Integer
    Dim img As String
    Dim imglogo As String

    Sub getcent()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        con.Open()

        cmd.CommandText = "select Center from tbl_center"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            cmbCenter.Items.Add(dr("Center"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub Getindex()
        If cmbindex.Items.Count > 0 Then
            cmbindex.Items.Clear()
        End If
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        curcentre = cmbCenter.Text
        cmd.CommandText = "select * FROM CandSubject where EXAMYEAR Like ('" & ExamYear & "%') and  CENTCODE Like ('" & curcentre & "%') "
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While (dr.Read())
            'Cbocanno.Items.Add(dr("INDEXNO"))
        End While

        dr.Close()
        gcon.Close()

    End Sub
    Sub GetExamYear()
        examyr = Now.Year
        txtexamyr.Text = (examyr)

    End Sub

    Sub getpapers()
        Try
            GetExamYear()
            Dim cmd As New OleDbCommand
            gcon.Open()
            cmd.CommandText = "select * from CandSubject where EXAMYEAR Like ('" & txtexamyr.Text & "%') and CENTCODE Like ('" & cmbCenter.Text & "%') and INDEXNO like ('" & cmbindex.Text & "%')"
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
            lbltotsubj.Text = indrange1

        Catch ex As Exception
            dr.Close()  '
        End Try
        gcon.Close()

    End Sub
    Sub GetBioDetails()

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim center As String
        Dim index As String
        Dim exa As String


        center = cmbCenter.Text
        index = cmbindex.Text
        con.Open()

        cmd.CommandText = "select * from CandDetails where EXAMYEAR Like ('" & ExamYear & "%') and CENTCODE = '" & center & "' and INDEXNO = '" & index & "'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            txtfirstname.Text = (dr("FNAME"))
            txtlastname.Text = (dr("LNAME"))
            txtOtherNames.Text = (dr("OTHERNAME"))
            DOB.Text = (dr("DOB"))
            exa = (dr("EXAMYEAR"))
            sex = (dr("Sex"))
            gender()
            If exa = "1" Then
                cmbexamseries.Text = "SCHOOL ====>MAY / JUNE"
            Else
                cmbexamseries.Text = "PRIVATE====>NOVEMBER / DECEMBER"

            End If
        End While

        dr.Close()
        con.Close()

    End Sub
    Sub gender()

        If sex = "1" Then
            GendStatus = "Male"
        ElseIf sex = "2" Then
            GendStatus = "Female"
        ElseIf sex = "3" Then
            GendStatus = "Blind Male"
        ElseIf sex = "4" Then
            GendStatus = "Blind Female"

        End If
        LblGender.Text = GendStatus
    End Sub

    Sub changeCode1()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub1.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode2()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub2.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode3()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub3.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode4()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub4.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode5()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub5.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode6()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub6.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode7()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub7.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode8()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub8.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub
    Sub changeCode9()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand

        con.Open()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While (dr.Read())
            lblsub9.Text = (dr("SubjName"))
        End While

        dr.Close()
        con.Close()
    End Sub

    Sub getLogo()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim cand As String
        cand = "LOGO"

        gcon.Open()
        cmd.CommandText = "select * from pictures WHERE ExamYear Like ('" & ExamYear & "%') and (PictID='" + cand + "')"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While (dr.Read())
            imglogo = (dr("PicPath"))
        End While
        dr.Close()
        gcon.Close()
    End Sub
    Sub getpic()
        'Dim dr As OleDbDataReader
        'Dim cmd As New OleDbCommand
        'Dim cand As String
        'Dim ppath As String
        'cand = cmbCenter.Text + cmbindex.Text

        'gcon.Open()
        'cmd.CommandText = "select * from pictures WHERE ExamYear Like ('" & ExamYear & "%') and (PictID='" + cand + "')"
        'cmd.Connection = gcon
        'dr = cmd.ExecuteReader
        'While (dr.Read())
        '    img = (dr("PicPath"))
        '    ppath = (dr("PicPath"))
        'End While
        'With PictureBox2

        '    .Image = Image.FromFile(ppath)

        '    .SizeMode = PictureBoxSizeMode.CenterImage
        '    .BorderStyle = BorderStyle.FixedSingle

        'End With
        'dr.Close()
        'gcon.Close()
    End Sub
    Sub subjects7()
        For i = 1 To 7
            subjcode = ""

            If i = 1 Then
                subjcode = (dr("SUBJ1"))
                changeCode1()

            End If

            If i = 2 Then

                subjcode = (dr("SUBJ2"))
                changeCode2()

            End If

            If i = 3 Then
                subjcode = (dr("SUBJ3"))
                changeCode3()
            End If

            If i = 4 Then
                subjcode = (dr("Sub4"))
                changeCode4()

            End If

            If i = 5 Then
                subjcode = (dr("SUBJ5"))
                changeCode5()

            End If

            If i = 6 Then
                subjcode = (dr("SUBJ6"))
                changeCode6()
            End If

            If i = 7 Then
                subjcode = (dr("SUBJ7"))
                changeCode7()
            End If

            If i = 8 Then
                subjcode = (dr("SUBJ8"))
                changeCode8()

            End If

            lblsub9.Visible = False
            lbltotsubj.Text = "7"
        Next
    End Sub
    Sub subjects8()
        For i = 1 To 8
            subjcode = ""

            If i = 1 Then
                subjcode = (dr("SUBJ1"))
                changeCode1()

            End If

            If i = 2 Then

                subjcode = (dr("SUBJ2"))
                changeCode2()

            End If

            If i = 3 Then
                subjcode = (dr("SUBJ3"))
                changeCode3()
            End If

            If i = 4 Then
                subjcode = (dr("SUBJ4"))
                changeCode4()

            End If

            If i = 5 Then
                subjcode = (dr("SUBJ5"))
                changeCode5()

            End If

            If i = 6 Then
                subjcode = (dr("SUBJ6"))
                changeCode6()
            End If

            If i = 7 Then
                subjcode = (dr("SUBJ7"))
                changeCode7()
            End If

            If i = 8 Then
                subjcode = (dr("SUBJ8"))
                changeCode8()

            End If

            lblsub9.Visible = False
            lbltotsubj.Text = "8"
        Next
    End Sub
    Sub subjects9()
        For i = 1 To 9
            subjcode = ""

            If i = 1 Then
                subjcode = (dr("SUBJ1"))
                changeCode1()

            End If

            If i = 2 Then
                'Adding Mathematics
                subjcode = (dr("SUBJ2"))
                changeCode2()

            End If

            If i = 3 Then
                subjcode = (dr("SUBJ3"))
                changeCode3()
            End If

            If i = 4 Then
                subjcode = (dr("SUBJ4"))
                changeCode4()

            End If

            If i = 5 Then
                subjcode = (dr("SUBJ5"))
                changeCode5()

            End If

            If i = 6 Then
                subjcode = (dr("SUBJ6"))
                changeCode6()
            End If

            If i = 7 Then
                subjcode = (dr("SUBJ7"))
                changeCode7()
            End If

            If i = 8 Then
                subjcode = (dr("SUBJ8"))
                changeCode8()

            End If
            If i = 9 Then
                subjcode = (dr("SUBJ9"))
                changeCode8()

            End If


        Next
    End Sub

    Private Sub cmbindex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbindex.SelectedIndexChanged
        GetBioDetails()
        getpapers()
        getpic()
    End Sub
    Private Sub frmPrintCanDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getcent()
    End Sub
    Private Sub cmbCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCenter.SelectedIndexChanged
        Getindex()
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Label.Text = "Confirmation of Candidate Entry"
        getLogo()
        'If (RichTextBox1.Text.Length <= 0) Then
        'The West African Examinations Council
        e.Graphics.DrawString(Label1.Text, New Font(Label1.Text, 15, FontStyle.Italic), Brushes.Blue, 200, 80)

        'Image WAEC LOGO
        e.Graphics.DrawImage(Image.FromFile(imglogo), 300, 100, 200, 200)

        'Candidate Picture
        e.Graphics.DrawImage(Image.FromFile(img), 500, 400, 200, 200)
        'WASSCE ENTRY RECEIPT
        e.Graphics.DrawString(Label2.Text, New Font(Label2.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 200, 300)

        'CENTER NAME
        e.Graphics.DrawString(cmbCenter.Text, New Font(cmbCenter.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 25, 350)
        'INDEX NUMBER
        e.Graphics.DrawString(cmbindex.Text, New Font(cmbindex.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 110, 350)
        'CANDIDATE NAME
        e.Graphics.DrawString(txtlastname.Text, New Font(txtlastname.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 160, 350)
        e.Graphics.DrawString(txtfirstname.Text, New Font(txtfirstname.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 300, 350)
        e.Graphics.DrawString(txtOtherNames.Text, New Font(txtOtherNames.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 390, 350)
        'DATE OF BIRTH
        e.Graphics.DrawString("Date of Birth :", New Font(txtgender.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 25, 380)
        e.Graphics.DrawString(DOB.Text, New Font(DOB.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 165, 380)
        'CANDIDATE GENDER
        e.Graphics.DrawString("Gender :", New Font(txtgender.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 300, 380)
        e.Graphics.DrawString(LblGender.Text, New Font(LblGender.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 400, 380)
        'CANDIDATE SUBJECTS
        e.Graphics.DrawString(lblsub1.Text, New Font(lblsub1.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 410)
        e.Graphics.DrawString(lblsub2.Text, New Font(lblsub2.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 440)
        e.Graphics.DrawString(lblsub3.Text, New Font(lblsub3.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 470)
        e.Graphics.DrawString(lblsub4.Text, New Font(lblsub4.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 500)
        e.Graphics.DrawString(lblsub5.Text, New Font(lblsub5.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 530)
        e.Graphics.DrawString(lblsub6.Text, New Font(lblsub6.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 560)
        e.Graphics.DrawString(lblsub7.Text, New Font(lblsub7.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 590)
        e.Graphics.DrawString(lblsub8.Text, New Font(lblsub8.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 25, 620)
        If lbltotsubj.Text = "9" Then
            e.Graphics.DrawString(lblsub9.Text, New Font(lblsub9.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 25, 650)
        End If
        'Total Subjects
        e.Graphics.DrawString("Total Subjects :", New Font(lblsub9.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 25, 680)
        e.Graphics.DrawString(lbltotsubj.Text, New Font(lbltotsubj.Font.FontFamily, 15, FontStyle.Bold), Brushes.Red, 190, 680)

        'Signature 
        e.Graphics.DrawString("Signature :", New Font(lblsub9.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 25, 760)
        e.Graphics.DrawString("...............................", New Font(lbltotsubj.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 130, 760)
        'Date signed
        e.Graphics.DrawString("Date :", New Font(lblsub9.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 430, 760)
        e.Graphics.DrawString("........................", New Font(lbltotsubj.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 480, 760)
        'Footer Line
        e.Graphics.DrawLine(Pens.Blue, 25, 1000, 815, 1000)
        'Footer Text
        e.Graphics.DrawString(Label6.Text, New Font(Label6.Font.FontFamily, 10, FontStyle.Bold), Brushes.DarkBlue, 250, 1020)
        ' End If
    End Sub
    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim a As DialogResult
        a = MessageBox.Show("Do u want to preview the document", "print", MessageBoxButtons.YesNo)
        If (a = DialogResult.Yes) Then
            Dim pd As New PrintDocument
            pd = PrintDocument1
            AddHandler pd.PrintPage, AddressOf Me.PrintDocument1_PrintPage
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        ElseIf (a = DialogResult.No) Then
            Dim pd As PrintDocument
            pd = PrintDocument1
            AddHandler pd.PrintPage, AddressOf Me.PrintDocument1_PrintPage
            PrintDialog1.Document = PrintDocument1
            If (PrintDialog1.ShowDialog() = DialogResult.OK) Then
                PrintDialog1.Document.Print()

            End If

        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class