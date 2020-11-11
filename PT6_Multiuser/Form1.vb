Public Class PT6_15101152610366_AnggaRomiSaputra

    Private Sub ckodetiket_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckodetiket.SelectedIndexChanged
        If ckodetiket.Text = "KT001" Then
            ttujuan.Text = "Jakarta"
            tnopenerbangan.Text = "GA150"
            thargatiket.Text = 1520000
        ElseIf ckodetiket.Text = "KT002" Then
            ttujuan.Text = "Medan"
            tnopenerbangan.Text = "GA675"
            thargatiket.Text = 1100000
        ElseIf ckodetiket.Text = "KT003" Then
            ttujuan.Text = "Bali"
            tnopenerbangan.Text = "GA8770"
            thargatiket.Text = 1850000
        Else : ttujuan.Text = "Batam"
            tnopenerbangan.Text = "GA844"
            thargatiket.Text = 1000000
        End If
    End Sub

    Private Sub bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bproses.Click
        Dim totalbayar, hargatiket, jumlahtiket As Double
        hargatiket = thargatiket.Text
        jumlahtiket = tjumlahtiket.Text
        totalbayar = hargatiket * jumlahtiket
        ttotalbayar.Text = totalbayar
    End Sub

    Private Sub bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbatal.Click
        txtnotransaksi.Text = ""
        ttujuan.Text = ""
        tnopenerbangan.Text = ""
        tjumlahtiket.Text = ""
        thargatiket.Text = ""
        ttotalbayar.Text = ""
        txtnotransaksi.Focus()
    End Sub

    Private Sub bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkeluar.Click
        Me.Close()
    End Sub
End Class
