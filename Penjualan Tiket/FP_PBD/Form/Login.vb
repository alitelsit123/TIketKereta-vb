Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        DTGrid = KontrolPegawai.loginPegawai(TxtPegawai.Text).ToTable
        If DTGrid.Rows.Count > 0 Then
            EntitasPegawai.KodePegawai = DTGrid.Rows(0).Item(0)
            EntitasPegawai.namaPegawai = DTGrid.Rows(0).Item(1)
            EntitasPegawai.passPegawai = DTGrid.Rows(0).Item(2)

            If TxtPassword.Text = EntitasPegawai.passPegawai Then
                FormUtama.Show()
                TxtPassword.Text = ""
                TxtPegawai.Text = ""
                Me.Hide()

            Else
                MessageBox.Show("Password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtPassword.Text = ""
                TxtPegawai.Focus()
            End If
        Else
            MessageBox.Show("Kode tidak Dikenal!", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Text = ""
            TxtPegawai.Text = ""
            TxtPegawai.Focus()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        Me.TxtPassword.PasswordChar = "*"
    End Sub
End Class