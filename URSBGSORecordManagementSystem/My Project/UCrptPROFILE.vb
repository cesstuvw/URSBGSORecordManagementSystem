Public Class UCrptPROFILE
    Private Sub UCrptPROFILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_profile' table. You can move, or remove it, as needed.
        Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
        Me.rptPROFILE.RefreshReport()
    End Sub

    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        If cboTYPE.Text = "" Then
            Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
            btnFILTER.Visible = True

        Else
            Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_profileTableAdapter.FillByType(Me.ursbgso_dbDataSet.tbl_profile, cboTYPE.Text)
            Me.rptPROFILE.RefreshReport()
            btnUNFILTER.Visible = True
            btnFILTER.Visible = False
        End If
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
        Me.rptPROFILE.RefreshReport()
        btnUNFILTER.Visible = False
        btnFILTER.Visible = True
        cboTYPE.Text = ""
    End Sub
End Class
