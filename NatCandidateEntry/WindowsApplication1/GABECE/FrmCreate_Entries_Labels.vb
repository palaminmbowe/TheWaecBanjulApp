Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.Drawing
Imports System.IO

Public Class FrmCreate_Entries_Labels

    'THIS PROGRAM PRINTS GABECE LABELS FOR PACKING OF CODES.
    'IT CALLS THE DATA FROM THE PACKING LIST BY CENTRE.

    Dim con As New ConClass
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon3 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")


    Dim da As New OleDbDataAdapter
    Dim dp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr, dr1, dr2 As OleDbDataReader
    Dim cmd As New OleDbCommand
    Dim mQuery, mQuery1 As String
    Dim totcand, reminder, books As Integer
    Dim cent, female, description, code, descrip, descrip1, subjcode1, yearnow, CentName, curcent, pappos As String
    Dim i As Integer

    Sub centers()
        da = New OleDbDataAdapter("Select * from CentreTbl ORDER BY CentCode", con.con)
        da.Fill(ds, "CentreTbl")
        cbocentcode.DataSource = ds.Tables("CentreTbl")
        cbocentcode.DisplayMember = "CentCode"
    End Sub
    Sub subjects()
        da = New OleDbDataAdapter("Select * from PaperDetails ORDER BY PapCodeTAD", con.con)
        da.Fill(ds, "PaperDetails")
        cbosubjcode.DataSource = ds.Tables("PaperDetails")
        cbosubjcode.DisplayMember = "PapCodeCSD"
    End Sub
    Sub getsubjects()

        Dim cmd As New OleDb.OleDbCommand
        Dim dr1 As OleDbDataReader

        Try
            gcon1.Open()
            cmd.CommandText = "select * from PaperDetails where PapCodeCSD=('" & cbosubjcode.Text & "')"
            cmd.Connection = gcon1
            dr2 = cmd.ExecuteReader

            While dr2.Read()
                subjcode = dr2("PapCodeCSD")
                subjcode1 = Mid(dr2("PapCodeCSD"), 1, 3)
                pappos = Mid(dr2("PapCodeCSD"), 5, 1)
                description = dr2("PapName")
                descrip = dr2("PapType")
            End While
            '*********** working code*******************

            gcon.Open()
            mQuery = "select * from Pack_Paper where CENTCODE = ('" & cbocentcode.Text & "') and SUBJCODE LIKE ('" & subjcode1 & "%')"
            cmd = New OleDb.OleDbCommand(mQuery, gcon)
            dr1 = cmd.ExecuteReader

            While dr1.Read()
                totcand = dr1("NOOFCAND")
                books = dr1("NOOFBOOKS")

                Display()
                cbocentcode.Visible = False
                cbosubjcode.Visible = False


            End While
            If dr1.HasRows Then
            Else

                MsgBox("Center " & cbocentcode.Text & " " + " is not offering " & subjcode1 & "")
            End If
            gcon.Close()
            gcon1.Close()
            ' dr1.Close()
        Catch ex As Exception
            gcon.Close()
            gcon1.Close()
        Finally

        End Try

    End Sub
    Sub nextcentno()

        'Dim cmd As New OleDbCommand
        'Dim num As Integer
        'num = CInt(cbocentcode.SelectedIndex)
        'cbocentcode.Text = Val(cbocentcode.Text + 1)

        'gcon2.Open()
        '' psearchcode()


        'cmd.CommandText = "select * from CentreTbl where  CENTCODE = ('" & cbocentcode.Text & "') " 'and  SUBJCODE like ('" & subj & "%')"

        'cmd.Connection = gcon2

        'dr = cmd.ExecuteReader
        ''While 
        'If (dr.Read()) Then
        '    'cmbSubject.Items.Add(dr("IndexNo")
        '    num += 1
        '    cbocentcode.SelectedIndex = num
        '    'getsubjects()

        'End If

        'dr.Close()
        'gcon.Close()
    End Sub
    Sub getCentres()

        Dim cmd As New OleDb.OleDbCommand

        Try
            gcon3.Open()
            cmd.CommandText = "select * from CentreTbl  where Centcode ='" & cbocentcode.Text & "'"
            cmd.Connection = gcon3
            dr2 = cmd.ExecuteReader

            While dr2.Read
                centno = dr2("Centcode")
                CentName = dr2("CentName")
            End While
            gcon3.Close()
            'dr2.Close()
        Catch ex As Exception
            gcon3.Close()
        Finally
        End Try


    End Sub

    Sub Display()
        getCentres()
        If subjcode = cbosubjcode.Text Then
            lblsubcode.Text = Mid(subjcode, 1, 4)
            lblnoofcand.Text = totcand

            If pappos = "1" Then
                lblsubtitle.Text = description + ", " + descrip
            Else
                If pappos = "2" Then
                    lblsubtitle.Text = description + ", " + descrip
                Else
                    If pappos = "3" Then
                        lblsubtitle.Text = description + ", " + descrip
                    End If
                End If

            End If

            lblcentnum.Text = centno 'cbocentcode.Text
            lblcentname.Text = CentName
            lblnoofbook.Text = books
        End If

    End Sub
    Sub changecode()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.OpenConnection()

        cmd.CommandText = "select * from SubjectTbl where SubjCode like '" & subjcode & "%'"
        cmd.Connection = con.con

        dr = cmd.ExecuteReader
        While dr.Read
            description = dr("SubjName")
            code = dr("PapCode")
        End While
        dr.Close()
        con.CloseConnection()
    End Sub

    Private Sub FrmCreate_Entries_Sumries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getexamyr()
        centers()
        subjects()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        getsubjects()

    End Sub
    Sub getexamyr()

        examyr = Now.Year
        lblexamyr.Text = examyr

    End Sub

    Sub print()
        ' Copy the form's image into a bitmap.
        m_PrintBitmap = GetFormImage()

        ' Make a PrintDocument and print.
        m_PrintDocument = New Printing.PrintDocument
        m_PrintDocument.Print()
    End Sub
    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal _
  hdcDest As IntPtr, ByVal nXDest As Integer, ByVal _
   nYDest As Integer, ByVal nWidth As Integer, ByVal _
  nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc _
   As Integer, ByVal nYSrc As Integer, ByVal dwRop As  _
  System.Int32) As Boolean
    Private Const SRCCOPY As Integer = &HCC0030
    ' Variables used to print.
    Private m_PrintBitmap As Bitmap
    Private WithEvents m_PrintDocument As Printing.PrintDocument

    ' Print the picture.
    Private Sub btnPrint_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs)
        ' Copy the form's image into a bitmap.
        m_PrintBitmap = GetFormImage()

        ' Make a PrintDocument and print.
        m_PrintDocument = New Printing.PrintDocument
        m_PrintDocument.Print()
    End Sub
    Private Function GetFormImage() As Bitmap
        ' Get this form's Graphics object.
        Dim me_gr As Graphics = Me.CreateGraphics

        ' Make a Bitmap to hold the image.
        Dim bm As New Bitmap(Me.ClientSize.Width, _
            Me.ClientSize.Height, me_gr)
        'Dim bm_gr As Graphics = me_gr.FromImage(bm)
        Dim bm_gr As Graphics = Graphics.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc
        'Get the form's hDC. We must do this after 
        ' creating the new Bitmap, which uses me_gr.
        Dim me_hdc As IntPtr = me_gr.GetHdc

        ' BitBlt the form's image onto the Bitmap.
        BitBlt(bm_hdc, 0, 0, Me.ClientSize.Width, _
            Me.ClientSize.Height, _
             me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)
        ' Return the result.
        Return bm
    End Function
    ' Print the form image.
    Private Sub m_PrintDocument_PrintPage(ByVal sender As _
        Object, ByVal e As  _
 System.Drawing.Printing.PrintPageEventArgs) Handles _
        m_PrintDocument.PrintPage
        ' Draw the image centered.
        Dim x As Integer = e.MarginBounds.X + _
                    (e.MarginBounds.Width - m_PrintBitmap.Width) \ 2
        Dim y As Integer = e.MarginBounds.Y + _
(e.MarginBounds.Height - m_PrintBitmap.Height) \ 30
        e.Graphics.DrawImage(m_PrintBitmap, x, y)

        ' There's only one page.
        e.HasMorePages = False
        ' e.HasMorePages = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        print()
        clear()
    End Sub

    Sub clear()
        lblcentname.Text = ""
        lblcentnum.Text = ""
        lblnoofbook.Text = ""
        lblsubcode.Text = ""
        lblsubtitle.Text = ""
        lblnoofcand.Text = ""
        cbocentcode.Visible = True
        cbosubjcode.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub
    'Sub getsubjects()

    '    Dim cmd As New OleDb.OleDbCommand
    '    ' Try
    '    gcon1.Open()
    '    'cmd.CommandText = "select * from SubjectTbl where SubjCode=('" & cbocentcode.Text & "')"
    '    cmd.CommandText = "select * from Paper where SubjCode=('" & cbocentcode.Text & "')"
    '    cmd.Connection = gcon1
    '    dr = cmd.ExecuteReader

    '    While dr.Read
    '        subjcode = dr("SubjCode")
    '        description = dr("SubjName")

    '        gcon.Open()
    '        Dim sex As String = "2"
    '        mQuery = "select Count(*)from Subject_Entry_By_Cand1 where CENTCODE = ('" & cbocentcode.Text & "') and SUBJCODE LIKE ('" & cbocentcode.Text & "%')"

    '        cmd = New OleDb.OleDbCommand(mQuery, gcon)
    '        totcand = cmd.ExecuteScalar()
    '        gcon.Close()
    '        Display()
    '    End While

    '    dr.Close()
    '    ' Catch ex As Exception
    '    gcon1.Close()
    '    'Finally

    '    'End Try

    'End Sub

End Class