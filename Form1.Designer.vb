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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtkode = New System.Windows.Forms.TextBox()
        Me.Txtkaryawan = New System.Windows.Forms.TextBox()
        Me.Cmbjabatan = New System.Windows.Forms.ComboBox()
        Me.Txtkoperasi = New System.Windows.Forms.TextBox()
        Me.Txtasuransi = New System.Windows.Forms.TextBox()
        Me.Lblgajipokok = New System.Windows.Forms.Label()
        Me.Lbltunjjabatan = New System.Windows.Forms.Label()
        Me.Lbltunjkes = New System.Windows.Forms.Label()
        Me.Lbltotalgaji = New System.Windows.Forms.Label()
        Me.Cmdsimpan = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Cmdkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DAFTAR PERHITUNGAN GAJI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Gaji"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gaji Pokok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tunj. Jabatan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tunj Kesehatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Potongan Asuransi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Potongan Koperasi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 596)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Gaji"
        '
        'Txtkode
        '
        Me.Txtkode.Location = New System.Drawing.Point(282, 153)
        Me.Txtkode.Name = "Txtkode"
        Me.Txtkode.Size = New System.Drawing.Size(213, 26)
        Me.Txtkode.TabIndex = 10
        '
        'Txtkaryawan
        '
        Me.Txtkaryawan.Location = New System.Drawing.Point(282, 203)
        Me.Txtkaryawan.Name = "Txtkaryawan"
        Me.Txtkaryawan.Size = New System.Drawing.Size(213, 26)
        Me.Txtkaryawan.TabIndex = 11
        '
        'Cmbjabatan
        '
        Me.Cmbjabatan.FormattingEnabled = True
        Me.Cmbjabatan.Items.AddRange(New Object() {"Manager", "Admin ", "Supervisor"})
        Me.Cmbjabatan.Location = New System.Drawing.Point(282, 258)
        Me.Cmbjabatan.Name = "Cmbjabatan"
        Me.Cmbjabatan.Size = New System.Drawing.Size(213, 28)
        Me.Cmbjabatan.TabIndex = 12
        '
        'Txtkoperasi
        '
        Me.Txtkoperasi.Location = New System.Drawing.Point(282, 538)
        Me.Txtkoperasi.Name = "Txtkoperasi"
        Me.Txtkoperasi.Size = New System.Drawing.Size(213, 26)
        Me.Txtkoperasi.TabIndex = 13
        '
        'Txtasuransi
        '
        Me.Txtasuransi.Location = New System.Drawing.Point(282, 482)
        Me.Txtasuransi.Name = "Txtasuransi"
        Me.Txtasuransi.Size = New System.Drawing.Size(213, 26)
        Me.Txtasuransi.TabIndex = 14
        '
        'Lblgajipokok
        '
        Me.Lblgajipokok.AutoSize = True
        Me.Lblgajipokok.Location = New System.Drawing.Point(278, 315)
        Me.Lblgajipokok.Name = "Lblgajipokok"
        Me.Lblgajipokok.Size = New System.Drawing.Size(72, 20)
        Me.Lblgajipokok.TabIndex = 15
        Me.Lblgajipokok.Text = "======="
        '
        'Lbltunjjabatan
        '
        Me.Lbltunjjabatan.AutoSize = True
        Me.Lbltunjjabatan.Location = New System.Drawing.Point(278, 372)
        Me.Lbltunjjabatan.Name = "Lbltunjjabatan"
        Me.Lbltunjjabatan.Size = New System.Drawing.Size(72, 20)
        Me.Lbltunjjabatan.TabIndex = 16
        Me.Lbltunjjabatan.Text = "======="
        '
        'Lbltunjkes
        '
        Me.Lbltunjkes.AutoSize = True
        Me.Lbltunjkes.Location = New System.Drawing.Point(278, 422)
        Me.Lbltunjkes.Name = "Lbltunjkes"
        Me.Lbltunjkes.Size = New System.Drawing.Size(63, 20)
        Me.Lbltunjkes.TabIndex = 17
        Me.Lbltunjkes.Text = "======"
        '
        'Lbltotalgaji
        '
        Me.Lbltotalgaji.AutoSize = True
        Me.Lbltotalgaji.Location = New System.Drawing.Point(278, 605)
        Me.Lbltotalgaji.Name = "Lbltotalgaji"
        Me.Lbltotalgaji.Size = New System.Drawing.Size(63, 20)
        Me.Lbltotalgaji.TabIndex = 18
        Me.Lbltotalgaji.Text = "======"
        '
        'Cmdsimpan
        '
        Me.Cmdsimpan.Location = New System.Drawing.Point(236, 686)
        Me.Cmdsimpan.Name = "Cmdsimpan"
        Me.Cmdsimpan.Size = New System.Drawing.Size(125, 51)
        Me.Cmdsimpan.TabIndex = 19
        Me.Cmdsimpan.Text = "Simpan"
        Me.Cmdsimpan.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(439, 372)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 20)
        Me.Label15.TabIndex = 20
        '
        'Cmdkeluar
        '
        Me.Cmdkeluar.Location = New System.Drawing.Point(430, 686)
        Me.Cmdkeluar.Name = "Cmdkeluar"
        Me.Cmdkeluar.Size = New System.Drawing.Size(125, 51)
        Me.Cmdkeluar.TabIndex = 22
        Me.Cmdkeluar.Text = "Keluar"
        Me.Cmdkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 765)
        Me.Controls.Add(Me.Cmdkeluar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Cmdsimpan)
        Me.Controls.Add(Me.Lbltotalgaji)
        Me.Controls.Add(Me.Lbltunjkes)
        Me.Controls.Add(Me.Lbltunjjabatan)
        Me.Controls.Add(Me.Lblgajipokok)
        Me.Controls.Add(Me.Txtasuransi)
        Me.Controls.Add(Me.Txtkoperasi)
        Me.Controls.Add(Me.Cmbjabatan)
        Me.Controls.Add(Me.Txtkaryawan)
        Me.Controls.Add(Me.Txtkode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Txtkode As TextBox
    Friend WithEvents Txtkaryawan As TextBox
    Friend WithEvents Cmbjabatan As ComboBox
    Friend WithEvents Txtkoperasi As TextBox
    Friend WithEvents Txtasuransi As TextBox
    Friend WithEvents Lblgajipokok As Label
    Friend WithEvents Lbltunjjabatan As Label
    Friend WithEvents Lbltunjkes As Label
    Friend WithEvents Lbltotalgaji As Label
    Friend WithEvents Cmdsimpan As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Cmdkeluar As Button
End Class
