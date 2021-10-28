Imports System.Data.OleDb

Public Class ClsCtlTiket : Implements InfProses

    Public Function KodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_kereta,3)) from tiket", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KR" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntTiket
        data = Ob
        CMD = New OleDbCommand(" Insert into Tiket values('" & data.KodeTiket & "','" & data.namaKereta & "','" & data.JurusanKereta & "'," & data.hargaTiket & "," & data.stokTiket & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntTiket
        data = Ob
        CMD = New OleDbCommand("update tiket set nama_kereta= '" & data.namaKereta & "',jurusan='" & data.JurusanKereta & "',harga=" & data.hargaTiket & ",stok=" & data.stokTiket & " where kode_kereta='" & data.KodeTiket & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from tiket " & " where kode_kereta='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Tiket", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Tiket")
            Dim grid As New DataView(DTS.Tables("Tabel_Tiket"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekBarangDirefrensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kode_kereta) from detail_tiket " & "where kode_kereta='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function

End Class
