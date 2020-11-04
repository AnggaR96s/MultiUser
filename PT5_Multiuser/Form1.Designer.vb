<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PT5_Multiuser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.title = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.GroupBox()
        Me.cmbkode = New System.Windows.Forms.ComboBox()
        Me.txtjumlahbeli = New System.Windows.Forms.TextBox()
        Me.txthargabarang = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProsesBox = New System.Windows.Forms.GroupBox()
        Me.bkeluar = New System.Windows.Forms.Button()
        Me.bbersih = New System.Windows.Forms.Button()
        Me.bproses = New System.Windows.Forms.Button()
        Me.OutputBox = New System.Windows.Forms.GroupBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txtuangbayar = New System.Windows.Forms.TextBox()
        Me.txttotalbayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.InputBox.SuspendLayout()
        Me.ProsesBox.SuspendLayout()
        Me.OutputBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 75)
        Me.Panel1.TabIndex = 0
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(174, 25)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(520, 29)
        Me.title.TabIndex = 0
        Me.title.Text = "PROGRAM LOGIKA IF - PENJUALAN BARANG"
        '
        'InputBox
        '
        Me.InputBox.Controls.Add(Me.cmbkode)
        Me.InputBox.Controls.Add(Me.txtjumlahbeli)
        Me.InputBox.Controls.Add(Me.txthargabarang)
        Me.InputBox.Controls.Add(Me.txtnamabarang)
        Me.InputBox.Controls.Add(Me.txtnama)
        Me.InputBox.Controls.Add(Me.Label5)
        Me.InputBox.Controls.Add(Me.Label4)
        Me.InputBox.Controls.Add(Me.Label3)
        Me.InputBox.Controls.Add(Me.Label2)
        Me.InputBox.Controls.Add(Me.Label1)
        Me.InputBox.Location = New System.Drawing.Point(12, 92)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(866, 209)
        Me.InputBox.TabIndex = 1
        Me.InputBox.TabStop = False
        Me.InputBox.Text = "Input"
        '
        'cmbkode
        '
        Me.cmbkode.FormattingEnabled = True
        Me.cmbkode.Items.AddRange(New Object() {"=Pilih=", "BRG001", "BRG002", "BRG003", "BRG004", "BRG005"})
        Me.cmbkode.Location = New System.Drawing.Point(398, 64)
        Me.cmbkode.Name = "cmbkode"
        Me.cmbkode.Size = New System.Drawing.Size(268, 28)
        Me.cmbkode.TabIndex = 9
        Me.cmbkode.SelectedItem = "=Pilih="
        '
        'txtjumlahbeli
        '
        Me.txtjumlahbeli.Location = New System.Drawing.Point(398, 164)
        Me.txtjumlahbeli.Name = "txtjumlahbeli"
        Me.txtjumlahbeli.Size = New System.Drawing.Size(268, 26)
        Me.txtjumlahbeli.TabIndex = 8
        '
        'txthargabarang
        '
        Me.txthargabarang.Location = New System.Drawing.Point(398, 128)
        Me.txthargabarang.Name = "txthargabarang"
        Me.txthargabarang.Size = New System.Drawing.Size(268, 26)
        Me.txthargabarang.TabIndex = 7
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(398, 95)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(268, 26)
        Me.txtnamabarang.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(398, 32)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(268, 26)
        Me.txtnama.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Beli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pembeli"
        '
        'ProsesBox
        '
        Me.ProsesBox.Controls.Add(Me.bkeluar)
        Me.ProsesBox.Controls.Add(Me.bbersih)
        Me.ProsesBox.Controls.Add(Me.bproses)
        Me.ProsesBox.Location = New System.Drawing.Point(12, 316)
        Me.ProsesBox.Name = "ProsesBox"
        Me.ProsesBox.Size = New System.Drawing.Size(866, 84)
        Me.ProsesBox.TabIndex = 2
        Me.ProsesBox.TabStop = False
        Me.ProsesBox.Text = "Proses"
        '
        'bkeluar
        '
        Me.bkeluar.Location = New System.Drawing.Point(623, 25)
        Me.bkeluar.Name = "bkeluar"
        Me.bkeluar.Size = New System.Drawing.Size(160, 41)
        Me.bkeluar.TabIndex = 2
        Me.bkeluar.Text = "KELUAR"
        Me.bkeluar.UseVisualStyleBackColor = True
        '
        'bbersih
        '
        Me.bbersih.Location = New System.Drawing.Point(353, 22)
        Me.bbersih.Name = "bbersih"
        Me.bbersih.Size = New System.Drawing.Size(160, 41)
        Me.bbersih.TabIndex = 1
        Me.bbersih.Text = "BERSIH"
        Me.bbersih.UseVisualStyleBackColor = True
        '
        'bproses
        '
        Me.bproses.Location = New System.Drawing.Point(62, 25)
        Me.bproses.Name = "bproses"
        Me.bproses.Size = New System.Drawing.Size(160, 41)
        Me.bproses.TabIndex = 0
        Me.bproses.Text = "PROSES"
        Me.bproses.UseVisualStyleBackColor = True
        '
        'OutputBox
        '
        Me.OutputBox.Controls.Add(Me.txtkembalian)
        Me.OutputBox.Controls.Add(Me.txtuangbayar)
        Me.OutputBox.Controls.Add(Me.txttotalbayar)
        Me.OutputBox.Controls.Add(Me.Label8)
        Me.OutputBox.Controls.Add(Me.Label7)
        Me.OutputBox.Controls.Add(Me.Label6)
        Me.OutputBox.Location = New System.Drawing.Point(12, 421)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(866, 133)
        Me.OutputBox.TabIndex = 3
        Me.OutputBox.TabStop = False
        Me.OutputBox.Text = "Output"
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(398, 97)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(268, 26)
        Me.txtkembalian.TabIndex = 12
        '
        'txtuangbayar
        '
        Me.txtuangbayar.Location = New System.Drawing.Point(398, 65)
        Me.txtuangbayar.Name = "txtuangbayar"
        Me.txtuangbayar.Size = New System.Drawing.Size(268, 26)
        Me.txtuangbayar.TabIndex = 11
        '
        'txttotalbayar
        '
        Me.txttotalbayar.Location = New System.Drawing.Point(398, 28)
        Me.txttotalbayar.Name = "txttotalbayar"
        Me.txttotalbayar.Size = New System.Drawing.Size(268, 26)
        Me.txttotalbayar.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Kembalian"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Uang Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Bayar"
        '
        'PT5_Multiuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 566)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.ProsesBox)
        Me.Controls.Add(Me.InputBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PT5_Multiuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT5_Multiuser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.InputBox.ResumeLayout(False)
        Me.InputBox.PerformLayout()
        Me.ProsesBox.ResumeLayout(False)
        Me.OutputBox.ResumeLayout(False)
        Me.OutputBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents InputBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbkode As System.Windows.Forms.ComboBox
    Friend WithEvents txtjumlahbeli As System.Windows.Forms.TextBox
    Friend WithEvents txthargabarang As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents ProsesBox As System.Windows.Forms.GroupBox
    Friend WithEvents bkeluar As System.Windows.Forms.Button
    Friend WithEvents bbersih As System.Windows.Forms.Button
    Friend WithEvents bproses As System.Windows.Forms.Button
    Friend WithEvents OutputBox As System.Windows.Forms.GroupBox
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents txtuangbayar As System.Windows.Forms.TextBox
    Friend WithEvents txttotalbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

    Private Sub cmbkode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkode.SelectedIndexChanged
        If cmbkode.Text = "BRG001" Then
            txtnamabarang.Text = "Tepung Terigu"
            txthargabarang.Text = "45500"
        ElseIf cmbkode.Text = "BRG002" Then
            txtnamabarang.Text = "Minyak Goreng"
            txthargabarang.Text = "15000"
        ElseIf cmbkode.Text = "BRG003" Then
            txtnamabarang.Text = "Pepsodent"
            txthargabarang.Text = "10300"
        ElseIf cmbkode.Text = "BRG004" Then
            txtnamabarang.Text = "Beras"
            txthargabarang.Text = "145000"
        ElseIf cmbkode.Text = "BRG005" Then
            txtnamabarang.Text = "Nugget Ayam"
            txthargabarang.Text = "25000"
        End If
    End Sub

    Private Sub bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bproses.Click
        Dim hargabarang, jumlahbeli, totalbayar As Double
        hargabarang = txthargabarang.Text
        jumlahbeli = txtjumlahbeli.Text
        totalbayar = hargabarang * jumlahbeli
        txttotalbayar.Text = totalbayar
    End Sub

    Private Sub txtuangbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuangbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim uangbayar, totalbayar, uangkembalian As Double
            uangbayar = txtuangbayar.Text
            totalbayar = txttotalbayar.Text
            uangkembalian = uangbayar - totalbayar
            txtkembalian.Text = uangkembalian
        End If
    End Sub

    Private Sub bbersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbersih.Click
        cmbkode.SelectedItem = "=Pilih="
        txtnama.Text = ""
        txtnamabarang.Text = ""
        txthargabarang.Text = ""
        txtjumlahbeli.Text = ""
        txttotalbayar.Text = ""
        txtuangbayar.Text = ""
        txtkembalian.Text = ""

        txtnama.Focus()
    End Sub

    Private Sub bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkeluar.Click
        Me.Close()
    End Sub
End Class
