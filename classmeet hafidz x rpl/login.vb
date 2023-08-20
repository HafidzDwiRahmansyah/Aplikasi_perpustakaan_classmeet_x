Imports System.Data.Odbc
Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Beranda.Show()
        Me.Hide()

    End Sub
End Class