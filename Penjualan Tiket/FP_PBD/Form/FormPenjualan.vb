Imports System.Data.OleDb


Public Class FormPenjualan
    Dim modeProses As Integer
    Dim baris As Integer
    Dim da As String
    Dim defharga As String
    Private r As New Random()
    Dim last = 0
    Dim activeType As String

    Private Sub IsiBox(br As Integer)
        Dim pegawai = New Login
        LblPegawai.Text = pegawai.TxtPegawai.Text
        If br < DTGrid.Rows.Count Then
            With DGPenjualan.Rows(br)
                TxtJumlah.Text = ""
                CMBKereta.Text = ""
                CMBKdkereta.Text = ""
                CMBJurusan.Text = ""
                TxtHarga.Text = ""
            End With
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPenjualan.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPenjualan.Rows(baris).Selected = True
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolTransaksi.tampilData.ToTable
        DGPenjualan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPenjualan.Rows(DTGrid.Rows.Count - 1).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FormUtama
        Call RefreshGrid()
        Call tampilcombo()
        KD_Nota.Enabled = False
        CMBJurusan.Enabled = False
        CMBKdkereta.Enabled = False
        TxtJumlah.Text = 0
        RdEkonomi.Checked = True
    End Sub
    Sub tampilcombo()
        Dim adapter As New OleDbDataAdapter("SELECT * FROM Tiket WHERE nama_kereta LIKE '%" & CMBKereta.Text & "%'", BUKAKONEKSI)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        With CMBKereta
            .ValueMember = "kode_kereta"
            .DisplayMember = "nama_kereta"
            .DataSource = dt
        End With

    End Sub

    Private Sub CMBKereta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBKereta.SelectedIndexChanged
        Dim adapter As New OleDbDataAdapter("SELECT * FROM Tiket WHERE nama_kereta LIKE '%" & CMBKereta.Text & "%'", BUKAKONEKSI)
        Dim dt As New DataTable()
        Dim kdbaru As New ClsCtlTransaksi
        adapter.Fill(dt)
        With CMBJurusan
            .ValueMember = "kode_kereta"
            .DisplayMember = "jurusan"
            .DataSource = dt
        End With
        With CMBKdkereta
            .ValueMember = "kode_kereta"
            .DisplayMember = "kode_kereta"
            .DataSource = dt
        End With
        TxtHarga.Text = Convert.ToString(dt.Rows(0)("harga"))
        defharga = dt.Rows(0)("harga")
        KD_Nota.Text = kdbaru.NotaBaru
        Call refreshTotal()
    End Sub
    Public Sub resetForm()
        CMBKereta.SelectedIndex = 0
        TxtJumlah.Text = 0
        RdEkonomi.Checked = True
        Call RefreshGrid()

    End Sub
    Public Sub refreshTotal()
        If RdEkonomi.Checked Then
            TxtHarga.Text = CInt(defharga) * 1
        ElseIf RdBisnis.Checked Then
            TxtHarga.Text = CInt(defharga) * 2
        ElseIf RdEksekutif.Checked Then
            TxtHarga.Text = CInt(defharga) * 3
        ElseIf RdExpress.Checked Then
            TxtHarga.Text = CInt(defharga) * 4
        End If

        If IsNumeric(TxtJumlah.Text) Then
            TxtTotal.Text = TxtJumlah.Text * TxtHarga.Text
        Else
            TxtTotal.Text = TxtHarga.Text
        End If


    End Sub
    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxtJumlah.TextChanged
        If IsNumeric(TxtJumlah.Text) Then
            TxtTotal.Text = TxtJumlah.Text * TxtHarga.Text
        Else
            TxtTotal.Text = 0
        End If
    End Sub
    Public Function randomNum() As Integer
        Dim ii As Integer
        ii = r.Next(1, 9999)
        Return ii
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kdbaru As New ClsCtlTransaksi

        Dim adapter As New OleDbDataAdapter("SELECT * FROM Tiket WHERE nama_kereta LIKE '%" & CMBKereta.Text & "%'", BUKAKONEKSI)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        Console.WriteLine(dt.Rows(0)("kode_kereta"))
        'With EntitasTransaksi
        '.jumlahtiket = TxtJumlah.Text
        '.kodekereta = Rd
        'End With
        'Call RefreshGrid()

        With EntitasTransaksi
            .jumlahtiket = TxtJumlah.Text
            .kodekereta = dt.Rows(0)("kode_kereta")
            .kodenota = kdbaru.NotaBaru
            .nomorinduk = TxtNIK.Text
            .no_pegawai = EntitasPegawai.KodePegawai
            .namaPegawai = TxtNama.Text
        End With
        KontrolTransaksi.InsertData(EntitasTransaksi)
        Call printNota()
        Call RefreshGrid()
    End Sub
    Public Sub printNota()
        Dim adapter As New OleDbDataAdapter("SELECT TOP 1 * FROM detail_tiket ORDER BY TGL_TRANSAKSI DESC", BUKAKONEKSI)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        Nota.nama = TxtNama.Text
        Nota.nama_kereta = CMBKereta.Text
        Nota.nik = TxtNIK.Text
        Nota.kode_tiket = KD_Nota.Text
        Nota.tanggal = dt.Rows(0)("TGL_TRANSAKSI")
        If RdEkonomi.Checked Then
            Nota.tipe = RdEkonomi.Text
        ElseIf RdBisnis.Checked Then
            Nota.tipe = RdBisnis.Text
        ElseIf RdEksekutif.Checked Then
            Nota.tipe = RdEksekutif.Text
        ElseIf RdExpress.Checked Then
            Nota.tipe = RdExpress.Text
        End If
        Nota.tujuan = CMBJurusan.Text
        Nota.Show()
    End Sub

    Private Sub RdBisnis_CheckedChanged(sender As Object, e As EventArgs) Handles RdBisnis.CheckedChanged
        Call refreshTotal()
    End Sub

    Private Sub RdEkonomi_CheckedChanged(sender As Object, e As EventArgs) Handles RdEkonomi.CheckedChanged
        Call refreshTotal()
    End Sub

    Private Sub RdEksekutif_CheckedChanged(sender As Object, e As EventArgs) Handles RdEksekutif.CheckedChanged
        Call refreshTotal()
    End Sub

    Private Sub RdExpress_CheckedChanged(sender As Object, e As EventArgs) Handles RdExpress.CheckedChanged
        Call refreshTotal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call resetForm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Close()
    End Sub

    Private Sub KD_Nota_TextChanged(sender As Object, e As EventArgs) Handles KD_Nota.TextChanged

    End Sub
End Class