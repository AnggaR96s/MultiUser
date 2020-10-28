<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbsatuan = New System.Windows.Forms.ComboBox()
        Me.txtjumlahbeli = New System.Windows.Forms.TextBox()
        Me.txthargabarang = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bproses = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bkeluar = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttotalbayar = New System.Windows.Forms.TextBox()
        Me.txtuangbayar = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latihan Operator Aritmatika"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbsatuan)
        Me.GroupBox1.Controls.Add(Me.txtjumlahbeli)
        Me.GroupBox1.Controls.Add(Me.txthargabarang)
        Me.GroupBox1.Controls.Add(Me.txtnamabarang)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Penjualan"
        '
        'cmbsatuan
        '
        Me.cmbsatuan.FormattingEnabled = True
        Me.cmbsatuan.Items.AddRange(New Object() {"=PILIH=", "Pack", "Lusin", "Botol", "Buah", "Unit"})
        Me.cmbsatuan.Location = New System.Drawing.Point(316, 129)
        Me.cmbsatuan.Name = "cmbsatuan"
        Me.cmbsatuan.Size = New System.Drawing.Size(355, 28)
        Me.cmbsatuan.TabIndex = 7
        '
        'txtjumlahbeli
        '
        Me.txtjumlahbeli.Location = New System.Drawing.Point(316, 170)
        Me.txtjumlahbeli.Name = "txtjumlahbeli"
        Me.txtjumlahbeli.Size = New System.Drawing.Size(355, 26)
        Me.txtjumlahbeli.TabIndex = 6
        '
        'txthargabarang
        '
        Me.txthargabarang.Location = New System.Drawing.Point(316, 86)
        Me.txthargabarang.Name = "txthargabarang"
        Me.txthargabarang.Size = New System.Drawing.Size(355, 26)
        Me.txthargabarang.TabIndex = 5
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(316, 36)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(355, 26)
        Me.txtnamabarang.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jumlah Beli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Barang"
        '
        'bproses
        '
        Me.bproses.Location = New System.Drawing.Point(63, 322)
        Me.bproses.Name = "bproses"
        Me.bproses.Size = New System.Drawing.Size(140, 51)
        Me.bproses.TabIndex = 2
        Me.bproses.Text = "Proses"
        Me.bproses.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.Location = New System.Drawing.Point(297, 322)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(140, 51)
        Me.bbatal.TabIndex = 3
        Me.bbatal.Text = "Batal"
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'bkeluar
        '
        Me.bkeluar.Location = New System.Drawing.Point(525, 322)
        Me.bkeluar.Name = "bkeluar"
        Me.bkeluar.Size = New System.Drawing.Size(140, 51)
        Me.bkeluar.TabIndex = 4
        Me.bkeluar.Text = "Keluar"
        Me.bkeluar.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.FormattingEnabled = True
        Me.Output.ItemHeight = 20
        Me.Output.Location = New System.Drawing.Point(12, 413)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(704, 204)
        Me.Output.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Uang Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 569)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Kembalian"
        '
        'txttotalbayar
        '
        Me.txttotalbayar.Location = New System.Drawing.Point(328, 452)
        Me.txttotalbayar.Name = "txttotalbayar"
        Me.txttotalbayar.Size = New System.Drawing.Size(355, 26)
        Me.txttotalbayar.TabIndex = 8
        '
        'txtuangbayar
        '
        Me.txtuangbayar.Location = New System.Drawing.Point(328, 508)
        Me.txtuangbayar.Name = "txtuangbayar"
        Me.txtuangbayar.Size = New System.Drawing.Size(355, 26)
        Me.txtuangbayar.TabIndex = 11
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(328, 566)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(355, 26)
        Me.txtkembalian.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(195, 639)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(324, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "15101152610366 ANGGA ROMI SAPUTRA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(276, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Rp."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(293, 455)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Rp."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(293, 511)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Rp."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(293, 569)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Rp."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 668)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.txtuangbayar)
        Me.Controls.Add(Me.txttotalbayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.bkeluar)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bproses)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Latihan Operator Aritmatika"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbsatuan As System.Windows.Forms.ComboBox
    Friend WithEvents txtjumlahbeli As System.Windows.Forms.TextBox
    Friend WithEvents txthargabarang As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bproses As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bkeluar As System.Windows.Forms.Button
    Friend WithEvents Output As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttotalbayar As System.Windows.Forms.TextBox
    Friend WithEvents txtuangbayar As System.Windows.Forms.TextBox
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
