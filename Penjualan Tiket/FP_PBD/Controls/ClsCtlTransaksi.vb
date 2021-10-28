Imports System.Data.OleDb

Public Class ClsCtlTransaksi : Implements InfProses

    Public Function NotaBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(no_nota,3)) as kode from detail_tiket", BUKAKONEKSI)
            Dim dt As New DataTable()
            DTA.Fill(dt)

            If IsDBNull(dt.Rows(0)("kode")) Then
                baru = "N" & Strings.Right("000" & 1, 4)
            Else
                kodeakhir = dt.Rows(0)("kode")
                baru = "N" & Strings.Right("000" & kodeakhir + 1, 4)
            End If

            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntTransaksi
        data = Ob

        CMD = New OleDbCommand(" Insert into PELANGGAN values('" & data.nomorinduk & "','" & data.namaPegawai & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)

        CMD = New OleDbCommand(" Insert into DETAIL_TIKET values('" & data.kodenota & "','" & data.kodekereta & "','" & data.nomorinduk & "','" & data.jumlahtiket & "', '" & data.no_pegawai & "',GETDATE())", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from DETAIL_TIKET", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Tiket")
            Dim grid As New DataView(DTS.Tables("Tabel_Tiket"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
