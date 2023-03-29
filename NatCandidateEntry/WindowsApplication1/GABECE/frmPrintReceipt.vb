Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class frmPrintReceipt
    Dim img As String
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                       System.Environment.CurrentDirectory.ToString() & "\Gabece.mdb")

    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\Gabece.mdb")
    Dim gcons As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                    System.Environment.CurrentDirectory.ToString() & "\Gabece.mdb")

    Dim gconn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                              System.Environment.CurrentDirectory.ToString() & "\Gabece.mdb")
    Dim mCmd As OleDbCommand
    Dim mQuery As String
    Dim num As Integer
    Dim ExpectedAmount As Integer
    Dim AmountPaid As Integer
    Dim ExpectedAmount1 As Integer
    Dim AmountPaid1 As Integer
    Dim Balance As Integer
    Dim outbal As Integer
    Dim outbal1 As Integer
    Dim eyear As String
    Dim cent As String
    Dim imglogo As String
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
    Sub getcenter()
        GetExamYear()
        cboSchoolcode.Items.Clear()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()

        cmd.CommandText = "select DISTINCT CENTCODE from CandDetails WHERE  EXAMYEAR like '" & txtexyr.Text & "%'" 'and CENTCODE LIKE '" & cboschool & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader

        While (dr.Read())
            cboSchoolcode.Items.Add(dr("CENTCODE"))

        End While
        dr.Close()
        gcon.Close()
    End Sub
    Sub getcenterName()
        Dim nname As String = ""
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        cmd.CommandText = "select * from CentreTbl WHERE CENTCODE like '" & cboSchoolcode.Text & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())
            nname = (dr("CentName"))
        End While
        txtschoolcode.Text = cboSchoolcode.Text + "   " + nname

        dr.Close()
        gcon.Close()
    End Sub
    Sub GetExamYear()

        'eyear = Now.Year
        'txtexyr.Text = eyear
        Dim cmd As New OleDbCommand
        gcon.Open()
        cmd.CommandText = "Select * from CandDetails"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While dr.Read()
            txtexyr.Text = (dr("EXAMYEAR"))
        End While
        gcon.Close()

    End Sub

    Private Sub frmPrintReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetExamYear()
        getcenter()
        'getTotalCand()
        'getExpectedAmount()
        'getAmountPaid()
        Dim di As Date
        'getBalance()
        di = Date.Today
        Label7.Text = di


    End Sub
    Sub getTotalCand()
        gcons.Open()

        mQuery = "select count(*) from CandDetails where EXAMYEAR Like ('" & txtexyr.Text & "%') and CENTCODE like ('" & cboSchoolcode.Text & "%')"
        mCmd = New OleDbCommand(mQuery, gcons)
        num = mCmd.ExecuteScalar()

        txtTotalCand.Text = num
        gcons.Close()
    End Sub
    Sub getExpectedAmount()
        ExpectedAmount1 = 0
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        cmd.CommandText = "select * from Fee_Tbl WHERE CENTCODE like '" & cboSchoolcode.Text & "%' and EXAMYEAR LIKE '" & txtexyr.Text & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())
            ExpectedAmount = CInt(dr("EXPECTEDAMOUNT"))
            ExpectedAmount1 += ExpectedAmount

        End While
        txtExpAmt.Text = ExpectedAmount1
        dr.Close()
        gcon.Close()
    End Sub
    Sub getAmountPaid()
        txtAmtPaid.Text = ""
        AmountPaid1 = 0

        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        gcon.Open()
        cmd.CommandText = "select *from Fee_Tbl WHERE CENTCODE like '" & cboSchoolcode.Text & "%' and EXAMYEAR LIKE '" & txtexyr.Text & "%'"
        cmd.Connection = gcon

        dr = cmd.ExecuteReader
        While (dr.Read())
            AmountPaid = (dr("AMOUNTPAID"))
            AmountPaid1 += AmountPaid
        End While

        txtAmtPaid.Text = AmountPaid1
        dr.Close()
        gcon.Close()
    End Sub
    Sub getBalance()

        Balance = ExpectedAmount1 - AmountPaid1

        If Balance <> 0 Then

            txtOutBal.ForeColor = Color.Red
            txtOutBal.Text = (Balance)
        Else
            txtOutBal.ForeColor = Color.Green
            txtOutBal.Text = "NIL"

        End If
    End Sub
    Sub getpic()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim cand As String
        cand = "LOGO"

        gcon.Open()
        cmd.CommandText = "select * from pictures WHERE ExamYear Like ('" & ExamYear & "%') and (PictID='" + cand + "')"
        cmd.Connection = gcon
        dr = cmd.ExecuteReader
        While (dr.Read())
            img = (dr("PicPath"))
        End While
        dr.Close()
        gcon.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Label6.Text = "This receipt MUST be presented along with a Bank Payment Slip"

        If (RichTextBox1.Text.Length <= 0) Then
            'The West African Examinations Council
            e.Graphics.DrawString(Label1.Text, New Font(Label1.Text, 15, FontStyle.Bold), Brushes.Blue, 150, 80)
            'Image WAEC LOGO
            e.Graphics.DrawImage(PictureBox1.Image, 300, 100, 200, 200)

            'WASSCE CANDIDATE ENTRY DETAILS
            e.Graphics.DrawString(Label2.Text, New Font(Label2.Font.FontFamily, 15, FontStyle.Bold), Brushes.Blue, 200, 300)
            'DATE OF PRINTING
            e.Graphics.DrawString(Label7.Text, New Font(Label7.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 600, 350)

            'SCHOOL
            e.Graphics.DrawString(Label5.Text, New Font(Label5.Font.FontFamily, 10, FontStyle.Bold), Brushes.Chocolate, 25, 350)
            'School Name
            e.Graphics.DrawString(txtschoolcode.Text, New Font(txtschoolcode.Font.FontFamily, 10, FontStyle.Bold), Brushes.Black, 150, 350)
            'NUMBER OF CANDIDATES
            e.Graphics.DrawString(Label4.Text, New Font(Label4.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 25, 450)
            e.Graphics.DrawString(txtTotalCand.Text, New Font(txtTotalCand.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 270, 450)

            e.Graphics.DrawString(lblAmount.Text, New Font(lblAmount.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 25, 480)
            e.Graphics.DrawString(txtExpAmt.Text, New Font(txtExpAmt.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 250, 480)

            e.Graphics.DrawString(Label12.Text, New Font(Label12.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 25, 510)
            e.Graphics.DrawString(txtAmtPaid.Text, New Font(txtAmtPaid.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 200, 510)

            e.Graphics.DrawString(Label3.Text, New Font(Label3.Font.FontFamily, 15, FontStyle.Bold), Brushes.Chocolate, 25, 540)
            e.Graphics.DrawString(txtOutBal.Text, New Font(txtOutBal.Font.FontFamily, 15, FontStyle.Bold), Brushes.Black, 270, 540)
            'Footer Line
            e.Graphics.DrawLine(Pens.Blue, 25, 1000, 750, 1000)
            'Footer Text
            e.Graphics.DrawString(Label6.Text, New Font(Label6.Font.FontFamily, 15, FontStyle.Bold), Brushes.DarkBlue, 100, 1020)
        End If
    End Sub

    Private Sub cboSchoolcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSchoolcode.SelectedIndexChanged
        clear()
        getcenterName()
        getTotalCand()
        getExpectedAmount()
        getAmountPaid()
        getBalance()
    End Sub
    Sub clear()
        txtOutBal.Text = ""
        txtschoolcode.Text = ""
        txtAmtPaid.Text = ""
        txtExpAmt.Text = ""
        txtTotalCand.Text = ""
    End Sub
End Class