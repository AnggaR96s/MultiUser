<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PT6_15101152610366_AnggaRomiSaputra
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnotransaksi = New System.Windows.Forms.TextBox()
        Me.dtgltransaksi = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ckodetiket = New System.Windows.Forms.ComboBox()
        Me.ttujuan = New System.Windows.Forms.TextBox()
        Me.tnopenerbangan = New System.Windows.Forms.TextBox()
        Me.thargatiket = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tjumlahtiket = New System.Windows.Forms.TextBox()
        Me.ttotalbayar = New System.Windows.Forms.TextBox()
        Me.bproses = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bkeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 83)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perusahaan Penerbangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Garuda Indonesia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtgltransaksi)
        Me.GroupBox1.Controls.Add(Me.txtnotransaksi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 107)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Penjualan Tiket Pesawat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tgl. Transaksi"
        '
        'txtnotransaksi
        '
        Me.txtnotransaksi.Location = New System.Drawing.Point(155, 49)
        Me.txtnotransaksi.Name = "txtnotransaksi"
        Me.txtnotransaksi.Size = New System.Drawing.Size(182, 26)
        Me.txtnotransaksi.TabIndex = 2
        '
        'dtgltransaksi
        '
        Me.dtgltransaksi.Location = New System.Drawing.Point(552, 47)
        Me.dtgltransaksi.Name = "dtgltransaksi"
        Me.dtgltransaksi.Size = New System.Drawing.Size(200, 26)
        Me.dtgltransaksi.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bkeluar)
        Me.GroupBox2.Controls.Add(Me.bbatal)
        Me.GroupBox2.Controls.Add(Me.bproses)
        Me.GroupBox2.Controls.Add(Me.ttotalbayar)
        Me.GroupBox2.Controls.Add(Me.tjumlahtiket)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.thargatiket)
        Me.GroupBox2.Controls.Add(Me.tnopenerbangan)
        Me.GroupBox2.Controls.Add(Me.ttujuan)
        Me.GroupBox2.Controls.Add(Me.ckodetiket)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 215)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data tiket"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kode Tiket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tujuan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "No Penerbangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Harga Tiket"
        '
        'ckodetiket
        '
        Me.ckodetiket.FormattingEnabled = True
        Me.ckodetiket.Items.AddRange(New Object() {"KT001", "KT002", "KT003", "KT004"})
        Me.ckodetiket.Location = New System.Drawing.Point(174, 43)
        Me.ckodetiket.Name = "ckodetiket"
        Me.ckodetiket.Size = New System.Drawing.Size(163, 28)
        Me.ckodetiket.TabIndex = 4
        '
        'ttujuan
        '
        Me.ttujuan.Location = New System.Drawing.Point(174, 82)
        Me.ttujuan.Name = "ttujuan"
        Me.ttujuan.Size = New System.Drawing.Size(163, 26)
        Me.ttujuan.TabIndex = 5
        '
        'tnopenerbangan
        '
        Me.tnopenerbangan.Location = New System.Drawing.Point(174, 120)
        Me.tnopenerbangan.Name = "tnopenerbangan"
        Me.tnopenerbangan.Size = New System.Drawing.Size(163, 26)
        Me.tnopenerbangan.TabIndex = 6
        '
        'thargatiket
        '
        Me.thargatiket.Location = New System.Drawing.Point(174, 161)
        Me.thargatiket.Name = "thargatiket"
        Me.thargatiket.Size = New System.Drawing.Size(163, 26)
        Me.thargatiket.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Jumlah Tiket"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Bayar"
        '
        'tjumlahtiket
        '
        Me.tjumlahtiket.Location = New System.Drawing.Point(589, 43)
        Me.tjumlahtiket.Name = "tjumlahtiket"
        Me.tjumlahtiket.Size = New System.Drawing.Size(163, 26)
        Me.tjumlahtiket.TabIndex = 10
        '
        'ttotalbayar
        '
        Me.ttotalbayar.Location = New System.Drawing.Point(589, 82)
        Me.ttotalbayar.Name = "ttotalbayar"
        Me.ttotalbayar.Size = New System.Drawing.Size(163, 26)
        Me.ttotalbayar.TabIndex = 11
        '
        'bproses
        '
        Me.bproses.Location = New System.Drawing.Point(406, 139)
        Me.bproses.Name = "bproses"
        Me.bproses.Size = New System.Drawing.Size(103, 48)
        Me.bproses.TabIndex = 12
        Me.bproses.Text = "PROSES"
        Me.bproses.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.Location = New System.Drawing.Point(539, 139)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(103, 48)
        Me.bbatal.TabIndex = 13
        Me.bbatal.Text = "BATAL"
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'bkeluar
        '
        Me.bkeluar.Location = New System.Drawing.Point(666, 139)
        Me.bkeluar.Name = "bkeluar"
        Me.bkeluar.Size = New System.Drawing.Size(103, 48)
        Me.bkeluar.TabIndex = 14
        Me.bkeluar.Text = "KELUAR"
        Me.bkeluar.UseVisualStyleBackColor = True
        '
        'PT6_15101152610366_AnggaRomiSaputra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PT6_15101152610366_AnggaRomiSaputra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT6 Multiuser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgltransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnotransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bkeluar As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bproses As System.Windows.Forms.Button
    Friend WithEvents ttotalbayar As System.Windows.Forms.TextBox
    Friend WithEvents tjumlahtiket As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents thargatiket As System.Windows.Forms.TextBox
    Friend WithEvents tnopenerbangan As System.Windows.Forms.TextBox
    Friend WithEvents ttujuan As System.Windows.Forms.TextBox
    Friend WithEvents ckodetiket As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
