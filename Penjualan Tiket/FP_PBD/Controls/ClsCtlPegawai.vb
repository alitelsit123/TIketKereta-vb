Imports System.Data.OleDb

Public Class ClsCtlPegawai
    Public Function loginPegawai(kode As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from pegawai where kode_pegawai='" & kode & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_kasir")
            Dim grid As New DataView(DTS.Tables("cari_kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
