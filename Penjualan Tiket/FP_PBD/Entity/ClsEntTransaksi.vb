Public Class ClsEntTransaksi
    Private kode As String
    Private kereta As String
    Private induk As String
    Private tiket As Integer
    Private pegawai As String
    Private nama As String

    Public Property kodenota As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property kodekereta As String
        Get
            Return kereta
        End Get
        Set(value As String)
            kereta = value
        End Set
    End Property
    Public Property nomorinduk As String
        Get
            Return induk
        End Get
        Set(value As String)
            induk = value
        End Set
    End Property

    Public Property jumlahtiket As String
        Get
            Return tiket
        End Get
        Set(value As String)
            tiket = value
        End Set
    End Property
    Public Property no_pegawai As String
        Get
            Return pegawai
        End Get
        Set(value As String)
            pegawai = value
        End Set
    End Property
    Public Property namaPegawai As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
End Class