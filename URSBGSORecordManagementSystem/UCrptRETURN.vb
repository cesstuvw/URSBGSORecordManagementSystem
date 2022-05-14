Public Class UCrptRETURN
    Private Sub UCrptRETURN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:   This line Of code loads data into the ursbgso_dbDataSet.tbl_return' table. You can move, or remove it, as needed.
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
        Me.rptRETURN.RefreshReport()
    End Sub

    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        If cboTYPE.Text = "" Then
            Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
            btnFILTER.Visible = True

        Else
            Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_returnTableAdapter.FillByType(Me.ursbgso_dbDataSet.tbl_return, cboTYPE.Text)
            Me.rptRETURN.RefreshReport()
            btnUNFILTER.Visible = True
            btnFILTER.Visible = False
        End If
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
        Me.rptRETURN.RefreshReport()
        btnUNFILTER.Visible = False
        btnFILTER.Visible = True
        cboTYPE.Text = ""
    End Sub


    Private Sub btnFILTERD_Click(sender As Object, e As EventArgs) Handles btnFILTERD.Click
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.FillByDateR(Me.ursbgso_dbDataSet.tbl_return, dtDATETIME.Value.ToShortDateString, dtDATETIME1.Value.ToShortDateString)
        Me.rptRETURN.RefreshReport()
        btnFILTERD.Visible = False
        btnUNFILTERD.Visible = True
    End Sub

    Private Sub btnUNFILTERD_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
        Me.rptRETURN.RefreshReport()
        btnFILTERD.Visible = True
        btnUNFILTERD.Visible = False
    End Sub
End Class
