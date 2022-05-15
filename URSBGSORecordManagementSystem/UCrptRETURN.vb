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


    Private Sub btnDATE_Click(sender As Object, e As EventArgs) Handles btnDATE.Click
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.FillByDateR(Me.ursbgso_dbDataSet.tbl_return, dtSTART.Value.ToShortDateString, dtEND.Value.ToShortDateString)
        Me.rptRETURN.RefreshReport()
        btnDATE.Visible = False
        btnUNDATE.Visible = True
    End Sub

    Private Sub btnUNDATE_Click(sender As Object, e As EventArgs) Handles btnUNDATE.Click
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
        Me.rptRETURN.RefreshReport()
        btnDATE.Visible = True
        btnUNDATE.Visible = False
    End Sub

    'Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
    '    Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '    Me.tbl_itemstockTableAdapter.FillByAdded(Me.ursbgso_dbDataSet.tbl_itemstock, dtSTART.Value.ToShortDateString, dtEND.Value.ToShortDateString)
    '    Me.rptITEMST.RefreshReport()
    '    btnFILTER.Visible = False
    '    btnUNFILTER.Visible = True
    'End Sub

    'Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
    '    Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '    Me.tbl_itemstockTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_itemstock)
    '    Me.rptITEMST.RefreshReport()
    '    btnFILTER.Visible = True
    '    btnUNFILTER.Visible = False
    'End Sub
End Class
