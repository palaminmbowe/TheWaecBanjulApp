Imports System.Data.OleDb
Module MyModule1

    Public USERLEVEL, totcandid As Integer
    Public dr As OleDb.OleDbDataReader
    Public cmd, cmd1, cmd2, mCmd1, mCmd2, mCmd3, mCmd4, mCmd5, mCmd6 As OleDbCommand
    Public centre, index As String
    Public currentindex As String
    Public ExamYear, candsubj, centcode, subjcode, examinerno, centno, papcode, papcode1, papcode2 As String
    Public indrange1 As Integer
    Public username, myusername, Query1, Query2, mQuery2, Query3, Query4, Query5, Query6 As String
    Public myexaminer, mysubjoff, myexaminer1, who, subjoffno, examyr As String
    Public da As OleDb.OleDbDataAdapter
    Public ds As DataSet

End Module
