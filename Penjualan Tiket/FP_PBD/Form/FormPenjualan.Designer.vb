<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBKereta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RdEkonomi = New System.Windows.Forms.RadioButton()
        Me.RdEksekutif = New System.Windows.Forms.RadioButton()
        Me.RdBisnis = New System.Windows.Forms.RadioButton()
        Me.RdExpress = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LblPegawai = New System.Windows.Forms.Label()
        Me.aldwmnjiolkawd = New System.Windows.Forms.Label()
        Me.CMBJurusan = New System.Windows.Forms.ComboBox()
        Me.CMBKdkereta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.KD_Nota = New System.Windows.Forms.TextBox()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jurusan"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(125, 66)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(210, 20)
        Me.TxtNama.TabIndex = 3
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(125, 97)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(210, 20)
        Me.TxtNIK.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Kereta"
        '
        'CMBKereta
        '
        Me.CMBKereta.FormattingEnabled = True
        Me.CMBKereta.Location = New System.Drawing.Point(125, 162)
        Me.CMBKereta.Name = "CMBKereta"
        Me.CMBKereta.Size = New System.Drawing.Size(210, 21)
        Me.CMBKereta.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jenis Tiket"
        '
        'RdEkonomi
        '
        Me.RdEkonomi.AutoSize = True
        Me.RdEkonomi.Checked = True
        Me.RdEkonomi.Location = New System.Drawing.Point(125, 244)
        Me.RdEkonomi.Name = "RdEkonomi"
        Me.RdEkonomi.Size = New System.Drawing.Size(66, 17)
        Me.RdEkonomi.TabIndex = 9
        Me.RdEkonomi.TabStop = True
        Me.RdEkonomi.Text = "Ekonomi"
        Me.RdEkonomi.UseVisualStyleBackColor = True
        '
        'RdEksekutif
        '
        Me.RdEksekutif.AutoSize = True
        Me.RdEksekutif.Location = New System.Drawing.Point(125, 280)
        Me.RdEksekutif.Name = "RdEksekutif"
        Me.RdEksekutif.Size = New System.Drawing.Size(69, 17)
        Me.RdEksekutif.TabIndex = 10
        Me.RdEksekutif.TabStop = True
        Me.RdEksekutif.Text = "Eksekutif"
        Me.RdEksekutif.UseVisualStyleBackColor = True
        '
        'RdBisnis
        '
        Me.RdBisnis.AutoSize = True
        Me.RdBisnis.Location = New System.Drawing.Point(259, 244)
        Me.RdBisnis.Name = "RdBisnis"
        Me.RdBisnis.Size = New System.Drawing.Size(52, 17)
        Me.RdBisnis.TabIndex = 11
        Me.RdBisnis.TabStop = True
        Me.RdBisnis.Text = "Bisnis"
        Me.RdBisnis.UseVisualStyleBackColor = True
        '
        'RdExpress
        '
        Me.RdExpress.AutoSize = True
        Me.RdExpress.Location = New System.Drawing.Point(259, 280)
        Me.RdExpress.Name = "RdExpress"
        Me.RdExpress.Size = New System.Drawing.Size(62, 17)
        Me.RdExpress.TabIndex = 12
        Me.RdExpress.TabStop = True
        Me.RdExpress.Text = "Express"
        Me.RdExpress.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Jumlah Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Bayar"
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(125, 321)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(210, 20)
        Me.TxtHarga.TabIndex = 16
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(125, 357)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(210, 20)
        Me.TxtJumlah.TabIndex = 17
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(125, 402)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(210, 20)
        Me.TxtTotal.TabIndex = 18
        '
        'DGPenjualan
        '
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(366, 48)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.Size = New System.Drawing.Size(347, 370)
        Me.DGPenjualan.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Beli"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(195, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(529, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LblPegawai
        '
        Me.LblPegawai.AutoSize = True
        Me.LblPegawai.Location = New System.Drawing.Point(512, 22)
        Me.LblPegawai.Name = "LblPegawai"
        Me.LblPegawai.Size = New System.Drawing.Size(39, 13)
        Me.LblPegawai.TabIndex = 23
        Me.LblPegawai.Text = "Label9"
        '
        'aldwmnjiolkawd
        '
        Me.aldwmnjiolkawd.AutoSize = True
        Me.aldwmnjiolkawd.Location = New System.Drawing.Point(43, 133)
        Me.aldwmnjiolkawd.Name = "aldwmnjiolkawd"
        Me.aldwmnjiolkawd.Size = New System.Drawing.Size(66, 13)
        Me.aldwmnjiolkawd.TabIndex = 24
        Me.aldwmnjiolkawd.Text = "Kode Kereta"
        '
        'CMBJurusan
        '
        Me.CMBJurusan.FormattingEnabled = True
        Me.CMBJurusan.Location = New System.Drawing.Point(125, 198)
        Me.CMBJurusan.Name = "CMBJurusan"
        Me.CMBJurusan.Size = New System.Drawing.Size(210, 21)
        Me.CMBJurusan.TabIndex = 26
        '
        'CMBKdkereta
        '
        Me.CMBKdkereta.FormattingEnabled = True
        Me.CMBKdkereta.Location = New System.Drawing.Point(125, 130)
        Me.CMBKdkereta.Name = "CMBKdkereta"
        Me.CMBKdkereta.Size = New System.Drawing.Size(210, 21)
        Me.CMBKdkereta.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "No_Nota"
        '
        'KD_Nota
        '
        Me.KD_Nota.Location = New System.Drawing.Point(125, 30)
        Me.KD_Nota.Name = "KD_Nota"
        Me.KD_Nota.Size = New System.Drawing.Size(210, 20)
        Me.KD_Nota.TabIndex = 29
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 474)
        Me.Controls.Add(Me.KD_Nota)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CMBKdkereta)
        Me.Controls.Add(Me.CMBJurusan)
        Me.Controls.Add(Me.aldwmnjiolkawd)
        Me.Controls.Add(Me.LblPegawai)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RdExpress)
        Me.Controls.Add(Me.RdBisnis)
        Me.Controls.Add(Me.RdEksekutif)
        Me.Controls.Add(Me.RdEkonomi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CMBKereta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMBKereta As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RdEkonomi As RadioButton
    Friend WithEvents RdEksekutif As RadioButton
    Friend WithEvents RdBisnis As RadioButton
    Friend WithEvents RdExpress As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents DGPenjualan As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LblPegawai As Label
    Friend WithEvents aldwmnjiolkawd As Label
    Friend WithEvents CMBJurusan As ComboBox
    Friend WithEvents CMBKdkereta As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents KD_Nota As TextBox
End Class
