Public Class ClsEntPegawai

    Private kode As String
    Private nama As String
    Private pass As String

    Public Property KodePegawai() As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property
    Public Property namaPegawai() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property passPegawai() As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property

End Class
