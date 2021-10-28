Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OlahDataTiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataTiketToolStripMenuItem.Click
        FormTiket.Show()
    End Sub

    Private Sub TransaksiPnejualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPnejualanToolStripMenuItem.Click
        FormPenjualan.Show()

    End Sub
End Class