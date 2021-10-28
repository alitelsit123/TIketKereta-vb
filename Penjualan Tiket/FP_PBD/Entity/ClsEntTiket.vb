Public Class ClsEntTiket

    Private kode As String
    Private nama As String
    Private jurusan As String
    Private harga As Integer
    Private stok As Integer



    Public Property KodeTiket() As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property namaKereta() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property JurusanKereta() As String
        Get
            Return jurusan
        End Get
        Set(value As String)
            jurusan = value
        End Set
    End Property



    Public Property hargaTiket() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property stokTiket() As Integer
        Get
            Return stok
        End Get
        Set(value As Integer)
            stok = value
        End Set
    End Property

End Class
