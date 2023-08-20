Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public Cmd As OdbcCommand
    Public ds As New DataSet
    Public da As OdbcDataAdapter
    Public rd As OdbcDataReader
    Public dt As DataTable

    Private Property Open As OdbcConnection

    Sub koneksi()
        conn = New OdbcConnection("database = perpustakaan; server=localhost; user=root")
        conn = Open()
    End Sub

End Module

