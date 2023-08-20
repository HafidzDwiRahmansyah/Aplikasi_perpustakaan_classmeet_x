Imports System.Data.Odbc

Public Class pinjam

    Dim DataSet As DataTable

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()

    End Sub
    Sub tampilDataGridView1()
        da = New OdbcDataAdapter(" Select Kode_pinjam, kode_buku, nama_pinjam, jumlah_pinjam From tbl_peminjam", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_peminjam")

        DataGridView1.DataSource = ds.Tables("tbl_pinjam")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosongkan()
        Call tampilDataGridView1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Dim simpan As String = "insert into [sheet1$] values ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        Cmd = New OdbcCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("data barang telah disimpan", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call kosongkan()
        Call tampilDataGridView1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim edit As String = "update [sheet1$] set kode pinjam ='" & TextBox2.Text & "' where val(kode) = '" & TextBox1.Text & "'"
        Cmd = New OdbcCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("data barang telah diubah", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call kosongkan()
        Call tampilDataGridView1()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Function Sheet1() As Data.DataSet
        Throw New NotImplementedException
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Beranda.Show()
        Me.Hide()

    End Sub
End Class