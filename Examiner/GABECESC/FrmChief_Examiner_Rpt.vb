Public Class FrmCEReports
    Private Property myProcess As Process
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Try
            If curuser1 = "00001" Then
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\Commercial Section.docx")
            ElseIf curuser1 = "00002" Then
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\General Subjects.docx")
            ElseIf curuser1 = "00003" Then
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\Languages.docx")
            ElseIf curuser1 = "00004" Then
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\Mathematics Section.docx")
            ElseIf curuser1 = "00005" Then
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\Science Section.docx")
            ElseIf curuser1 = "00006" Then
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\Tech & Voc Subjs.docx")
            Else : curuser1 = "00007"
                myProcess = Process.Start("\\Server1\Chief Examiner Reports\Home Science.docx")
            End If

        Catch e1 As Exception
            MessageBox.Show("Error:" + e1.Message)
        End Try
        Me.Close()
    End Sub
End Class