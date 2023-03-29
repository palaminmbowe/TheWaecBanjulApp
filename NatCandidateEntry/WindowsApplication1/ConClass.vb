Imports System.Data
Imports System.Data.OleDb

Public Class ConClass
    ' Public con As New SqlConnection("Data Source=TOSHIBA\SQLEXPRESS;Initial Catalog=gabecedbs;Integrated Security=True")
    Public conP As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
     System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    'Dim gcon1 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    'Dim gcon2 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    'Dim gcon3 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    'Dim gcon4 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")
    'Dim gcon5 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                             System.Environment.CurrentDirectory.ToString() & "\GABECE.mdb")

    Public ReadOnly Property con As OleDbConnection
        Get
            Return conP
        End Get
    End Property



    Public Sub OpenConnection()
        con.Open()
    End Sub
    Public Sub CloseConnection()
        con.Close()
    End Sub
End Class
