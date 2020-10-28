Public Class Latihan1

    Private Sub proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proses.Click
        Dim Luas, Keliling, Panjang, Lebar As Integer
        Panjang = txtpanjang.Text
        Lebar = txtlebar.Text
        Luas = Panjang * Lebar
        Keliling = (2 * Panjang) + (2 * Lebar)
        txtluas.Text = Luas
        txtkeliling.Text = Keliling
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        txtpanjang.Text = ""
        txtlebar.Text = ""
        txtluas.Text = ""
        txtkeliling.Text = ""
        txtpanjang.Focus()
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class
