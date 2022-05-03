Public Class ucUSERACCOUNT
    Private Sub ucUSERACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_userTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_user)

        'btnEDIT.Enabled = False
        'btnVIEW.Enabled = False
    End Sub

    Private Sub btnADDUSER_MouseHover(sender As Object, e As EventArgs) Handles btnADDUSER.MouseHover, PictureBox1.MouseHover, PictureBox8.MouseHover, PictureBox7.MouseHover, PictureBox6.MouseHover, PictureBox3.MouseHover, PictureBox2.MouseHover
        btnADDUSER.Image = My.Resources.adduserhover
    End Sub

    Private Sub btnADDUSER_MouseLeave(sender As Object, e As EventArgs) Handles btnADDUSER.MouseLeave, PictureBox1.MouseLeave, PictureBox8.MouseLeave, PictureBox7.MouseLeave, PictureBox6.MouseLeave, PictureBox3.MouseLeave, PictureBox2.MouseLeave
        btnADDUSER.Image = My.Resources.adduser
    End Sub

    Private Sub btnADDUSER_Click(sender As Object, e As EventArgs) Handles btnADDUSER.Click, PictureBox1.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox3.Click, PictureBox2.Click

    End Sub
End Class
