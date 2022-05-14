Public Class UCrptITEMSTOCK
    Private Sub UCrptITEMSTOCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_itemstock' table. You can move, or remove it, as needed.
        Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemstockTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_itemstock)
        Me.rptITEMST.RefreshReport()
    End Sub


    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemstockTableAdapter.FillByAdded(Me.ursbgso_dbDataSet.tbl_itemstock, dtSTART.Value.ToShortDateString, dtEND.Value.ToShortDateString)
        Me.rptITEMST.RefreshReport()
        btnFILTER.Visible = False
        btnUNFILTER.Visible = True
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemstockTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_itemstock)
        Me.rptITEMST.RefreshReport()
        btnFILTER.Visible = True
        btnUNFILTER.Visible = False
    End Sub
End Class
