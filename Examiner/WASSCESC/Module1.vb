Imports System.Data
Imports System.Data.OleDb
Module Module1
    'Public gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              System.Environment.CurrentDirectory.ToString() & "\Wamaster.mdb;Jet OLEDB:Database Password=Sawat1me;")
    'Public gcon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
    '                              "\\server1\CurrentDBs" & "\PWASSCE_EMS_2011.mdb;Jet OLEDB:Database Password=Sawat1me;")

    Public gcon As New OleDbConnection(MDIParent1.connectionString)

    Public curuser As String = ""
    Public curuser1 As String = ""
    Public curuser_va As String = ""
    Public subja As String
    Public candmark As String
    Public candOldMark As String
    Public PaperCode As String
    Public PaperType As String
    Public subb As String
    Public currentindex As String
    Public USERLEVEL As Integer
    Public Examiner As String
    Public cmd As OleDbCommand
    Public EXCODE, EXCODE1, STATUSCODE As String
    Public mCmd As OleDbCommand
    Public mQuery, mQuery1, mQuery2, mQuery3 As String
    Public mCmd1, mCmd2, mCmd3, mCmd4, mCmd5 As OleDbCommand
    Public subject As String
    Public Query1, Query2, Query3, Query4, Query5 As String
    Public num As Integer
    Public Dr2 As OleDbDataReader
    Public Flag As String = "-99"

End Module

