Public Class ucUSERACCOUNT
    Private Sub ucUSERACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEDIT.Enabled = False
        btnVIEW.Enabled = False
    End Sub

    Private Sub btnADDUSER_MouseHover(sender As Object, e As EventArgs) Handles btnADDUSER.MouseHover
        btnADDUSER.Image = My.Resources.adduserhover
    End Sub

    Private Sub btnADDUSER_MouseLeave(sender As Object, e As EventArgs) Handles btnADDUSER.MouseLeave
        btnADDUSER.Image = My.Resources.adduser
    End Sub

    Private Sub btnADDUSER_Click(sender As Object, e As EventArgs) Handles btnADDUSER.Click

    End Sub
End Class
