Public Class Form1

    Private Sub bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bproses.Click
        Dim total_bayar, harga_barang, jumlah_beli As Double
        harga_barang = txthargabarang.Text
        jumlah_beli = txtjumlahbeli.Text
        total_bayar = harga_barang * jumlah_beli
        txttotalbayar.Text = total_bayar
    End Sub

    Private Sub txtuangbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuangbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim kembalian, uang_bayar, total_bayar As Double
            uang_bayar = txtuangbayar.Text
            total_bayar = txttotalbayar.Text
            kembalian = uang_bayar - total_bayar
            txtkembalian.Text = kembalian
        End If
    End Sub

    Private Sub bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbatal.Click
        txtnamabarang.Text = ""
        txthargabarang.Text = ""
        txtjumlahbeli.Text = ""
        txtuangbayar.Text = ""
        txtkembalian.Text = ""
        txttotalbayar.Text = ""
        txtnamabarang.Focus()
    End Sub

    Private Sub bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkeluar.Click
        Me.Close()
    End Sub
End Class
