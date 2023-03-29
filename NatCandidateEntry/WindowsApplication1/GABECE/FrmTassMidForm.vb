Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class FrmTassMidForm
    Dim gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                  System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Dim gcon1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                                       System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    Private Sub FrmTassMidForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = username & "THE WEST AFRICAN EXAMINATIONS COUNCIL - THE GAMBIA      : : :  EXAMINERS MARK SHEET"


        Administrator.Visible = True
        CreateSubjectOfficerToolStripMenuItem.Visible = False
        ' ModifyMarkToolStripMenuItem.Visible = False
        BackupDatabaseToolStripMenuItem.Visible = False
        ListMarksToolStripMenuItem1.Visible = False
        UpdateUserLevelsToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CassMarksEntryForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim ff As New FrmCassEntry()
            ff.MdiParent = Me
            ff.Show()
        Catch ex As Exception
        Finally
        End Try

    End Sub

    Private Sub Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitForms.Click
        Me.Close()
    End Sub

    Private Sub CassMarskModificationForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmModifyCass As New FrmModifyCass()
        FrmModifyCass.MdiParent = Me
        FrmModifyCass.Show()
    End Sub
    Private Sub CassMarksCompleteRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmCompleteTMarks As New FrmCompleteTMarks()
        FrmCompleteMarks.MdiParent = Me
        FrmCompleteMarks.Show()
    End Sub

    Private Sub CassMarksIncompleteRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmIncompleteMarks As New FrmIncompleteMarks()
        FrmIncompleteMarks.MdiParent = Me
        FrmIncompleteMarks.Show()
    End Sub

    Private Sub ViewAllCandidatesWithMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmCassGV As New FrmCassGV()
        FrmCassGV.MdiParent = Me
        FrmCassGV.Show()

    End Sub

    Private Sub AboutApplication_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutApplicationToolStripMenuItem.Click
        Dim About As New Form1
        About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub CassMarksAllMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmCassGV As New FrmCassGV()
        FrmCassGV.MdiParent = Me
        FrmCassGV.Show()
    End Sub

    Private Sub CandidateSuject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmPost_Exam_Process As New FrmPost_Exam_Process
        FrmPost_Exam_Process.MdiParent = Me
        FrmPost_Exam_Process.Show()
    End Sub

    Private Sub CreateExaminers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmCreate_Examiner As New FrmCreate_Examiner_
        FrmCreate_Examiner.MdiParent = Me
        FrmCreate_Examiner.Show()
    End Sub

    Private Sub GirlsFundedEntries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmPract_Sub As New FrmPract_Sub
        FrmPract_Sub.MdiParent = Me
        FrmPract_Sub.Show()
    End Sub

    Private Sub ByRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmPost_Exam_Process As New FrmPost_Exam_Process
        FrmPost_Exam_Process.MdiParent = Me
        FrmPost_Exam_Process.Show()
    End Sub
    Private Sub EntrySummaryByCentre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmCreate_Entries_Labels As New FrmCreate_Entries_Sumries
        FrmCreate_Entries_Sumries.MdiParent = Me
        FrmCreate_Entries_Sumries.Show()
    End Sub
    Private Sub TassMarkEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmTassEntry As New FrmTassEntry
        FrmTassEntry.MdiParent = Me
        FrmTassEntry.Show()
    End Sub
    
    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim LoginForm1 As New LoginForm1
        LoginForm1.MdiParent = Me
        LoginForm1.Show()
    End Sub
    Private Sub CreateExaminer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateExaminer.Click
        Dim FrmCreate_Examiner As New FrmCreate_Examiner_
        FrmCreate_Examiner_.MdiParent = Me
        FrmCreate_Examiner_.Show()
    End Sub
    Private Sub ModifyExaminer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmModfy_Examiner As New FrmModify_Examiner_
        FrmModify_Examiner_.MdiParent = Me
        FrmModify_Examiner_.Show()
        MsgBox("Please select Your Status and Subject Code and Click on Retrieve Record.", MsgBoxStyle.Information, Me.Text)

    End Sub
    Private Sub ModifyExaminer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyExaminerToolStripMenuItem.Click
        Dim FrmModfy_Examiner As New FrmModify_Examiner_
        FrmModify_Examiner_.MdiParent = Me
        FrmModify_Examiner_.Show()
        MsgBox("Please select Your Status and Subject Code and Click on Retrieve Record.", MsgBoxStyle.Information, Me.Text)

    End Sub
    Private Sub ModifyMarks1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmModify_Tass As New FrmModify_Tass
        FrmModify_Tass.MdiParent = Me
        FrmModify_Tass.Show()
    End Sub
    Private Sub ModifyMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyMarksToolStripMenuItem.Click
        Dim FrmModify_Tass As New FrmModify_Tass
        FrmModify_Tass.MdiParent = Me
        FrmModify_Tass.Show()
    End Sub
   
    Private Sub ListMarks1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMarksToolStripMenuItem1.Click
        Dim FrmTassGV As New FrmTassGV
        FrmTassGV.MdiParent = Me
        FrmTassGV.Show()
    End Sub

    Private Sub CreateSubjectOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateSubjectOfficerToolStripMenuItem.Click
        Dim FrmSubject_Officer As New FrmSubject_Officer
        FrmSubject_Officer.MdiParent = Me
        FrmSubject_Officer.Show()
    End Sub

    Private Sub EnterMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmTassEntry As New FrmTassEntry
        FrmTassEntry.MdiParent = Me
        FrmTassEntry.Show()
    End Sub

    Private Sub ListMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMarksToolStripMenuItem.Click
        Dim FrmTassGV As New FrmTassGV
        FrmTassGV.MdiParent = Me
        FrmTassGV.Show()
    End Sub

    Private Sub EnterMarks1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterMarksToolStripMenuItem1.Click
        Dim FrmTassEntry As New FrmTassEntry
        FrmTassEntry.MdiParent = Me
        FrmTassEntry.Show()
    End Sub

    Private Sub ListMarks2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMarksToolStripMenuItem2.Click
        Dim FrmTassGV As New FrmTassGV
        FrmTassGV.MdiParent = Me
        FrmTassGV.Show()
    End Sub
    Private Sub UpdateUserLevelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateUserLevelsToolStripMenuItem.Click
        Dim frmUpdateLevelvb As New frmUpdateLevelvb
        frmUpdateLevelvb.MdiParent = Me
        frmUpdateLevelvb.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

        Dim mylogin As New LoginForm1
        mylogin.Show()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False

        'Examiner
        Examiner.Visible = False
        EnterMarksToolStripMenuItem1.Visible = False
        ListMarksToolStripMenuItem2.Visible = False

        'subject officer
        SubjectOfficer.Visible = False
        ModifyExaminerToolStripMenuItem.Visible = False
        ListMarksToolStripMenuItem.Visible = False
        ModifyMarksToolStripMenuItem.Visible = False

        'administrator
        CreateSubjectOfficerToolStripMenuItem.Visible = False
        BackupDatabaseToolStripMenuItem.Visible = False
        ListMarksToolStripMenuItem1.Visible = False
        UpdateUserLevelsToolStripMenuItem.Visible = False
        ToolStripStatusLabel2.Text = ""
        ToolStripStatusLabel3.Text = ""

    End Sub

    Private Sub CreateExaminerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmCreate_Examiner_ As New FrmCreate_Examiner_
        FrmCreate_Examiner_.MdiParent = Me
        FrmCreate_Examiner_.Show()
    End Sub

    Private Sub ModifyExaminerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmModify_Examiner_ As New FrmModify_Examiner_
        FrmModify_Examiner_.MdiParent = Me
        FrmModify_Examiner_.Show()
    End Sub

    Private Sub ModifyMarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmModify_Tass As New FrmModify_Tass
        FrmModify_Tass.MdiParent = Me
        FrmModify_Tass.Show()

    End Sub

    Private Sub AllocatScriptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllocatScriptsToolStripMenuItem.Click
        Dim FrmScript_Allocation As New FrmScript_Allocation
        FrmScript_Allocation.MdiParent = Me
        FrmScript_Allocation.Show()
    End Sub
End Class
