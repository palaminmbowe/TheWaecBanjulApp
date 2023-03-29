Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.Drawing
Imports System.IO
Public Class FrmPract_Sub

    Dim con As New ConClass
    Dim gcon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon2 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Dim da As New OleDbDataAdapter
    Dim dp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim cmd As New OleDbCommand
    Dim mQuery, mQuery1 As String
    Dim totcand As Integer
    Dim cent, female, description As String


    Private Sub FrmPract_Sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        centers()
    End Sub
    Sub centers()
        da = New OleDbDataAdapter("Select * from CentreTbl ORDER BY CentCode", con.con)
        da.Fill(ds, "CentreTbl")
        CboCentres.DataSource = ds.Tables("CentreTbl")
        CboCentres.DisplayMember = "CentCode"
    End Sub
    Sub getsubjects()

        Dim cmd As New OleDb.OleDbCommand
        Try
            gcon1.Open()
            cmd.CommandText = "select * from Pract_Subjects "
            cmd.Connection = gcon1
            dr = cmd.ExecuteReader

            While dr.Read
                subjcode = dr("PractSubs")
                description = dr("SubName")

                gcon.Open()
                Dim sex As String = "2"
                mQuery = "select Count(*)from CandSubjects where SEX like ('" & sex & "%') and CENTCODE Like ('" & CboCentres.Text & "%') and ('" & subjcode & "') in(SUBJ1,SUBJ2,SUBJ3,SUBJ4,SUBJ5,SUBJ6,SUBJ7,SUBJ8,SUBJ9)"
                cmd = New OleDb.OleDbCommand(mQuery, gcon)
                totcand = cmd.ExecuteScalar()
                gcon.Close()
                Display()
            End While

            dr.Close()
        Catch ex As Exception
            gcon1.Close()
        Finally

        End Try

    End Sub
    Sub getCentres()

        Dim cmd As New OleDb.OleDbCommand
        Dim CentName As String
        Try
            gcon2.Open()
            cmd.CommandText = "select * from CentreTbl where CENTCODE Like ('" & CboCentres.Text & "%') "
            cmd.Connection = gcon2
            dr = cmd.ExecuteReader

            While dr.Read
                CentName = dr("CentName")
                Label9.Text = CentName
            End While

            dr.Close()
        Catch ex As Exception
            gcon2.Close()
        Finally
        End Try


    End Sub

    Sub Display()
        changecode()
       
        If subjcode = "311" Then
            Label4.Text = description
            TextBox1.Text = totcand
        End If

        If subjcode = "312" Then
            Label6.Text = description
            TextBox2.Text = totcand
        End If

    End Sub

    Sub changecode()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        con.OpenConnection()

        cmd.CommandText = "select * from Pract_Subjects where PractSubs like '" & subjcode & "%'"
        cmd.Connection = con.con

        dr = cmd.ExecuteReader
        While dr.Read
            description = dr("SubName")
        End While
        dr.Close()
        con.CloseConnection()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        getsubjects()
    End Sub

    Private Sub CboCentres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentres.SelectedIndexChanged
        getCentres()
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
    Private Const SRCCOPY As Integer = &HCC0020
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
(e.MarginBounds.Height - m_PrintBitmap.Height) \ 2
        e.Graphics.DrawImage(m_PrintBitmap, x, y)

        ' There's only one page.
        e.HasMorePages = False
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        print()
        CboCentres.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label9.Text = ""

    End Sub

End Class