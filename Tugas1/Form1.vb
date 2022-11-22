Public Class fInput
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        'tampilkan form 2 / form cetak
        fCetak.Show()
        fCetak.lOutputNama.Text = tbNama.Text
        fCetak.lOutputNpm.Text = tbNpm.Text
        fCetak.lOutputKelas.Text = tbKelas.Text
    End Sub
End Class
