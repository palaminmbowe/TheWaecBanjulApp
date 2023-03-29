Imports System.Math
Imports System.Data
Imports System.Data.OleDb

Public Class frmModerateCass
    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")
    Dim gcons As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")

    Dim gconn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                   System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")


    Dim pcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                       System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb")

    Dim dr As OleDbDataReader

    Dim dr2 As OleDbDataReader

    Dim mCmd As OleDbCommand
    Dim mQuery As String
    Dim cmd As New OleDbCommand
    'Cass MArks
    Dim txtYr1 As Integer
    Dim txtYr2 As Integer
    Dim txtYr3 As Integer
    Dim ModCass As Integer
    Dim tlength As String
    Dim center As String
    Dim RawCass As Decimal
    Dim RawCas As String
    Dim Sd_Cass As Decimal
    Dim Sd_Tass As Decimal
    Dim MeanCass As Decimal
    Dim MeanTass As Decimal

    Dim subject As String


    Private Sub cmdCassModerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCassModerate.Click

        cmdCassModerate.Text = "Please Keep off!"
        System.Windows.Forms.Form.ActiveForm.Text = "MODERATION OF CASS IN INPROGRESS..."
        Dim CassAgg As String ' flag for CassMarks
        Dim ModCassAggre As Integer
        Dim remark As String
        cmdCassModerate.Enabled = False
        gcon.Open()
        cmd.CommandText = "select * from WAA05OUT"
        cmd.Connection = gcon
        CassAgg = " 11"
        remark = "Mark Greater than 100"
        dr = cmd.ExecuteReader
        While (dr.Read())
            center = dr("CentNo")
            index = dr("IndexNo")
            subject = dr("SubjCode")
            txtYr1 = CInt(dr("Yr1"))
            txtYr2 = CInt(dr("Yr2"))
            txtYr3 = CInt(dr("Yr3"))
            'The total cass Mark for the 3 years
            RawCass = (txtYr1 + txtYr2 + txtYr3) / 3

            GetCassParameters()
            'Moderated Cass Marks 
            ModCassAggre = Abs((Sd_Tass / Sd_Cass) * (((RawCass - MeanCass))) + MeanTass)

            tlength = CStr(ModCassAggre)
            tlength = tlength.Length

            If ModCassAggre <= 100 Then

                ModCassAggre = CStr(FormatNumber(Round(ModCassAggre)))
                If ModCassAggre = 100 Then
                    RawCas = ModCassAggre
                ElseIf tlength = 1 Then

                    RawCas = "00" & ModCassAggre
                Else
                    RawCas = "0" & ModCassAggre
                End If

            Else
                RawCas = "085"
            End If
            mQuery = "UPDATE WAA05OUT SET RawCass ='" & RawCas & "',CassAgg='" & CassAgg & "' where CentNo Like ('" & center & "%') and IndexNo like ('" & index & "%')and SubjCode like ('" & subject & "%')"
            mCmd = New OleDb.OleDbCommand(mQuery, gcon)
            mCmd.ExecuteNonQuery()
        End While
        dr.Close()
        gcon.Close()
        MsgBox("finished Aggregating CassMArks")
        Me.Close()
    End Sub
    Sub GetCassParameters()

        Dim cmd As New OleDb.OleDbCommand
        pcon.Open()
        cmd.CommandText = "select * from StatsTable where SubjCode Like ('" & subject & "%') "
        cmd.Connection = pcon
        dr2 = cmd.ExecuteReader
        '        While (dr.Read())
        If dr2.Read Then

            Sd_Cass = CInt(dr2("Sd_Cass"))
            Sd_Tass = CInt(dr2("Sd_Tass"))
            MeanCass = CInt(dr2("MeanCass"))
            MeanTass = CInt(dr2("MeanTass"))
        End If

        dr2.Close()
        pcon.Close()

    End Sub
End Class