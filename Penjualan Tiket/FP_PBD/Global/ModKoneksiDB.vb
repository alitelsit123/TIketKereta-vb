Imports System.Data.OleDb
Module ModKoneksiDB
    Public DTR As OleDbDataReader
    Public CMD As OleDbCommand
    Public DTA As OleDbDataAdapter
    Public DTS As DataSet
    Public DTT As DataTable
    Public DTGrid As New DataTable
    Public strKon = "Provider=SQLNCLI11;Data Source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=TIKET_SUKASUKA"
    Public koneksi As New OleDbConnection(strKon)
    Public Function BUKAKONEKSI() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()

        Catch ex As Exception

        End Try
        Return koneksi
    End Function
    Public Function TUTUPKONEKSI() As OleDbConnection
        koneksi.Close()
        Return koneksi
    End Function
End Module
