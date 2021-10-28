Public Class Nota
    Public nama, nik, nama_kereta, kode_tiket, tipe, tujuan, tanggal As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles TxtNama.Click

    End Sub

    Private Sub TxtKereta_Click(sender As Object, e As EventArgs) Handles TxtKereta.Click

    End Sub

    Private Sub Nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtKereta.Text = nama_kereta
        TxtNama.Text = nama
        TxtNik.Text = nik
        TxtTanggal.Text = tanggal
        TxtTipe.Text = tipe
        TxtTujuan.Text = tujuan
        TxtKodeTiket.Text = kode_tiket

        GetFormImage(False).Save("D:\code\vb\New folder\" & kode_tiket & ".jpg")
        Call Close()
    End Sub

    Private Function GetFormImage(ByVal include_borders As Boolean) As Bitmap
        Dim wid As Integer = Me.Width
        Dim hgt As Integer = Me.Height
        Dim bm As New Bitmap(wid, hgt)
        Me.DrawToBitmap(bm, New Rectangle(0, 0, wid, hgt))
        wid = Me.ClientSize.Width
        hgt = Me.ClientSize.Height
        Dim bm2 As New Bitmap(wid, hgt)
        Dim pt As New Point(0, 0)
        pt = PointToScreen(pt)
        Dim dx As Integer = pt.X - Me.Left
        Dim dy As Integer = pt.Y - Me.Top
        Dim gr As Graphics = Graphics.FromImage(bm2)
        gr.DrawImage(bm, 0, 0, New Rectangle(dx, dy, wid, hgt), GraphicsUnit.Pixel)
        Return bm
    End Function

End Class