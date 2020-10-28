<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Latihan1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpanjang = New System.Windows.Forms.TextBox()
        Me.txtlebar = New System.Windows.Forms.TextBox()
        Me.proses = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtluas = New System.Windows.Forms.TextBox()
        Me.txtkeliling = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 91)
        Me.Panel1.TabIndex = 1
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe Print", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(98, 7)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(758, 71)
        Me.title.TabIndex = 1
        Me.title.Text = "LATIHAN OPERATOR ARITMATIKA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mencari Luas dan Keliling Persegi Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Masukan Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Masukan Lebar"
        '
        'txtpanjang
        '
        Me.txtpanjang.Location = New System.Drawing.Point(217, 159)
        Me.txtpanjang.Name = "txtpanjang"
        Me.txtpanjang.Size = New System.Drawing.Size(155, 26)
        Me.txtpanjang.TabIndex = 5
        '
        'txtlebar
        '
        Me.txtlebar.Location = New System.Drawing.Point(217, 204)
        Me.txtlebar.Name = "txtlebar"
        Me.txtlebar.Size = New System.Drawing.Size(155, 26)
        Me.txtlebar.TabIndex = 6
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(58, 297)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(147, 58)
        Me.proses.TabIndex = 7
        Me.proses.Text = "PROSES"
        Me.proses.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Location = New System.Drawing.Point(252, 297)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(147, 58)
        Me.batal.TabIndex = 8
        Me.batal.Text = "BATAL"
        Me.batal.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(159, 393)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(147, 58)
        Me.keluar.TabIndex = 9
        Me.keluar.Text = "KELUAR"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.txtkeliling)
        Me.Panel2.Controls.Add(Me.txtluas)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(537, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 395)
        Me.Panel2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "OUTPUT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Luas Persegi Panjang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keliling Persegi Panjang"
        '
        'txtluas
        '
        Me.txtluas.Location = New System.Drawing.Point(219, 66)
        Me.txtluas.Name = "txtluas"
        Me.txtluas.Size = New System.Drawing.Size(153, 26)
        Me.txtluas.TabIndex = 6
        '
        'txtkeliling
        '
        Me.txtkeliling.Location = New System.Drawing.Point(219, 111)
        Me.txtkeliling.Name = "txtkeliling"
        Me.txtkeliling.Size = New System.Drawing.Size(153, 26)
        Me.txtkeliling.TabIndex = 7
        '
        'Latihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(969, 486)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.proses)
        Me.Controls.Add(Me.txtlebar)
        Me.Controls.Add(Me.txtpanjang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Latihan1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MULTIUSER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpanjang As System.Windows.Forms.TextBox
    Friend WithEvents txtlebar As System.Windows.Forms.TextBox
    Friend WithEvents proses As System.Windows.Forms.Button
    Friend WithEvents batal As System.Windows.Forms.Button
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtkeliling As System.Windows.Forms.TextBox
    Friend WithEvents txtluas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
