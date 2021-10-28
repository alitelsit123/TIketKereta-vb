<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTiket
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
        Me.DGTiket = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSelesai = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtJurusan = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-34, -57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 30)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Toko Apa Aja"
        '
        'DGTiket
        '
        Me.DGTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTiket.Location = New System.Drawing.Point(21, 260)
        Me.DGTiket.Name = "DGTiket"
        Me.DGTiket.Size = New System.Drawing.Size(393, 245)
        Me.DGTiket.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnUbah)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Controls.Add(Me.BtnSelesai)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 479)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'BtnHapus
        '
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(31, 234)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(94, 34)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(31, 77)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(94, 27)
        Me.BtnUbah.TabIndex = 7
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(31, 25)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(94, 27)
        Me.BtnTambah.TabIndex = 6
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnSelesai
        '
        Me.BtnSelesai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSelesai.Location = New System.Drawing.Point(31, 283)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(94, 34)
        Me.BtnSelesai.TabIndex = 5
        Me.BtnSelesai.Text = "Selesai"
        Me.BtnSelesai.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(31, 176)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(94, 34)
        Me.BtnBatal.TabIndex = 4
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(31, 126)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(94, 34)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtJurusan)
        Me.GroupBox1.Controls.Add(Me.TxtStok)
        Me.GroupBox1.Controls.Add(Me.TxtKode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 225)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(133, 134)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(100, 20)
        Me.TxtHarga.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Harga"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(134, 65)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(166, 20)
        Me.TxtNama.TabIndex = 7
        '
        'TxtJurusan
        '
        Me.TxtJurusan.Location = New System.Drawing.Point(134, 104)
        Me.TxtJurusan.Name = "TxtJurusan"
        Me.TxtJurusan.Size = New System.Drawing.Size(100, 20)
        Me.TxtJurusan.TabIndex = 6
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(133, 176)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(100, 20)
        Me.TxtStok.TabIndex = 5
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(134, 29)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(100, 20)
        Me.TxtKode.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok Tiket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jurusan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Kereta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "KodeKereta"
        '
        'FormTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 517)
        Me.Controls.Add(Me.DGTiket)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTiket"
        Me.Text = "FormTiket"
        CType(Me.DGTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DGTiket As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSelesai As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtJurusan As TextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
End Class
