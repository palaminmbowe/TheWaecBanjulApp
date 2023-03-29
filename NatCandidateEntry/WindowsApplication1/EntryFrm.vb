Imports System.Data.SqlClient

Public Class FrmgabEntry

    Dim con As New SqlConnection("Data Source=TOSHIBA\SQLEXPRESS;Initial Catalog=gabecedbs;Integrated Security=True")

    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim recno As Integer
    Dim i As Integer
    Dim j As Integer
    Dim English As String = "111"
    Dim Math As String = "112"
    Dim Science As String = "113"
    Dim SES As String = "114"
    'Dim sub1, sub2, sub3,sub4, subj5 As String
    Dim Group2_Subjects(6) As Integer
    Dim Group3_Subjects(5) As Integer
    Dim Sub_item1, Sub_item2, Sub_item3 As Integer
    Dim indexChecked As Integer
    Dim itemChecked As Object
    Dim DBNull As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click

        Dim cmd As New SqlCommand

        'Opens database connection
        con.Open()
        cmd.CommandText = "Sp_CandDetails"  '  Procedure name already define in the database
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@CentCode", CboCentCode.Text)
        cmd.Parameters.AddWithValue("@CandNo", txtCanNo.Text)
        cmd.Parameters.AddWithValue("@Lname", txtLName.Text.ToUpper)
        cmd.Parameters.AddWithValue("@Fname", txtFName.Text.ToUpper)
        cmd.Parameters.AddWithValue("@Dob", DateTimePicker1.Text)
        'cmd.Parameters.AddWithValue("@photo", PictureBox2.ImageLocation)

        'Checks for what option fo sex has been selected by the candidate
        Dim sex As Integer
        If OptMale.Checked = True Then
            sex = 1
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptFemale.Checked = True Then
            sex = 2
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptBMale.Checked = True Then
            sex = 3
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptBFemale.Checked = True Then
            sex = 4
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptDMale.Checked = True Then
            sex = 5
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptDFemale.Checked = True Then
            sex = 6
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptHMale.Checked = True Then
            sex = 7
            cmd.Parameters.AddWithValue("@Sex", sex)
        ElseIf OptHFemale.Checked Then
            sex = 8
            cmd.Parameters.AddWithValue("@Sex", sex)
        End If

        cmd.Parameters.AddWithValue("@SubCode1", English)
        cmd.Parameters.AddWithValue("@SubCode2", Math)
        cmd.Parameters.AddWithValue("@SubCode3", Science)
        cmd.Parameters.AddWithValue("@SubCode4", SES)
        'Checking for the subjects selected 

        
        'Next
        Try
            cmd.Parameters.AddWithValue("@SubCode5", ChkLBSub1.CheckedItems(i))
            cmd.Parameters.AddWithValue("@SubCode6", ChkLBSub1.CheckedItems(i))
            cmd.Parameters.AddWithValue("@SubCode7", (ChkLBSub1.CheckedItems(i))) ' Or (ChkLBSub2.CheckedItems(j)))
            cmd.Parameters.AddWithValue("@SubCode8", (ChkLBSub2.CheckedItems(j))) ' Or ("@SubCode8" = DBNull)) '(ChkLBSub21.CheckedItems=.Item=<> (i)))
            cmd.Parameters.AddWithValue("@SubCode9", (ChkLBSub2.CheckedItems(j))) ' Or ("@SubCode9" = DBNull))
            cmd.Parameters.AddWithValue("@NoOfSubs", TextBox1.Text)
            cmd.Parameters.AddWithValue("@SchofChc", CboSchofChc.Text)
            cmd.ExecuteNonQuery() ' This command execute by sending the details to each field define in the database table based on the stored procedure.

            MsgBox("Record Added")
            CboCentCode.Focus()
            CboCentCode.Focus()
            'txtCanNo.Text
            txtLName.Clear()
            txtFName.Clear()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmgabEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Access the CentDetails from the data base for CentCode in the Candidates Detail Table.
        da = New SqlDataAdapter("Select * from CentDetails", con)
        da.Fill(ds, "CentDetails")
        CboCentCode.DataSource = ds.Tables("CentDetails")
        CboCentCode.DisplayMember = "CentCode"

        GetIndexNo() '(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCanNo.TextChanged
        Dim num As Integer
        Dim cmd As New SqlCommand
        'Opens database connection
        con.Open()
        cmd.CommandText = ("Select * max (CandNo)from CandDetails where CentCode=@CentCode")
        cmd.Connection = con
        num = cmd.ExecuteScalar() '= CommandType.TableDirect
        'num =("cmd") con))
        txtCanNo.Text = num + 1
        txtCanNo.Text = "CandNo"
        Format(txtCanNo.Text, "000")
        ''con.Close()

        'Initial value of No of Subjects. It is initialised as total Number of Core Subjects=4.
        Sub_item1 = 4
        TextBox1.Text = Sub_item1

    End Sub

    Private Sub CboSchofChc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboSchofChc.Click
        da = New SqlDataAdapter("Select * from Sch_ChcDetails", con)
        da.Fill(ds, "Sch_ChcDetails")
        CboSchofChc.DataSource = ds.Tables("Sch_ChcDetails")
        CboSchofChc.DisplayMember = "SchCode"

    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub ChkLBSub1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChkLBSub1.ItemCheck
        Sub_item1 = ChkLBSub1.CheckedItems.Count + 1
        Sub_item3 = 4 + Sub_item1 + Sub_item2
        TextBox1.Text = Sub_item3
        'MessageBox.Show("You selected " & ChkLBSub1.Items(e.Index).ToString())

        'Checking for the subjects choosen in checklistbox 1

        If (Sub_item1 = 3) Then 'Or (Sub_item1 = 2) 
            MsgBox("Please Select a subject from Group3 to satify your subject combination")
            ChkLBSub2.SelectedIndex = 0
            ChkLBSub1.Enabled = False
        Else
            ChkLBSub1.Enabled = True
        End If
        Try
            Group2_Subjects(= {"211","212","213","214","215","216","217"}
            Dim i As Integer
            'i = ChkLBSub1().CheckedItems.Item(i)
            For i = 0 To Group2_Subjects(i)
                ' ChkLBSub1.CheckedItems.Item(i)
                If ChkLBSub1.SelectedIndex = 0 = True Then '"211  -  Arabic" Then
                    Group2_Subjects(i) = "211"
                ElseIf ChkLBSub1.SelectedIndex = 1 = True Then '"212  -  French" Then
                    Group2_Subjects(i) = "212"
                ElseIf ChkLBSub1.SelectedIndex = 2 = True Then  '"213  -  IRK" Then
                    Group2_Subjects(i) = "213"
                ElseIf ChkLBSub1.SelectedIndex = 3 = True Then '"214  -  CRE" Then
                    Group2_Subjects(i) = "214"
                ElseIf ChkLBSub1.SelectedIndex = 4 = True Then '"215  -  Agric_Sci" Then
                    Group2_Subjects(i) = "215"
                ElseIf ChkLBSub1.SelectedIndex = 5 = True Then '"216  -  Phy_Edu" Then
                    Group2_Subjects(i) = "216"
                ElseIf ChkLBSub1.SelectedIndex = 6 = True Then '"217  -  Lit_In_Eng" Then
                    Group2_Subjects(i) = "217"
                    'Else
                    '   Group2_Subjects(i) = DBNull
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ChkLBSub2_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChkLBSub2.ItemCheck
        Dim j As Integer
        Dim iSelect As Integer
        'Adds the selected subjects plus the core subjects previously initialised as 4.
        Sub_item2 = ChkLBSub2.CheckedItems.Count + 1
        Sub_item3 = 4 + Sub_item1 + Sub_item2
        TextBox1.Text = Sub_item3
        'MessageBox.Show("You selected " & ChkLBSub2.Items(e.Index).ToString())
        Try
            ' j = ChkLBSub2().CheckedItems.Item(j)

            For j = 1 To Group3_Subjects(5) '.Length - 1

                If ChkLBSub2.SelectedIndex = 0 = True Then '"311  -  Home_Eco" Then
                    Group3_Subjects(j) = "311"
                ElseIf ChkLBSub2.SelectedIndex = 1 = True Then ' "312  -  Arts_Craft" Then
                    Group3_Subjects(j) = "312"
                ElseIf ChkLBSub2.SelectedIndex = 2 = True Then '"313  -  Tech_Drawing" Then
                    Group3_Subjects(j) = "313"
                ElseIf ChkLBSub2.SelectedIndex = 3 = True Then '"314  -  Metalwork" Then
                    Group3_Subjects(j) = "314"
                ElseIf ChkLBSub2.SelectedIndex = 4 = True Then  '"315  -  Woodwork" Then
                    Group3_Subjects(j) = "315"
                Else
                    Group3_Subjects(j) = DBNull
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text >= 7 And TextBox1.Text <= 9) Then
            CmdAdd.Enabled = True
        Else
            CmdAdd.Enabled = False

        End If
    End Sub

    Public Sub GetIndexNo() '(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCanNo.TextChanged
        Dim num As Integer
        Dim cmd As New SqlCommand
        'Opens database connection
        con.Open()
        cmd.CommandText = ("Select * max CandNo where CentCode=@CentCode")
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        num = da.Fill(ds, "CandDetails")
        txtCanNo.Text = num + 1
        txtCanNo.Text = "CandNo"

    End Sub

    Private Sub txtLName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLName.TextChanged
        'validating text box
        txtLName.Focus()
        If (txtLName.Text.Length = 0) Then
            MsgBox("Name Cannot be empty")

        End If
    End Sub

End Class