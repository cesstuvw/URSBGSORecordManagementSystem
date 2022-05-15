Public Class UCrptTRANSAC
    Private Sub UCrptTRANSAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_transaction' table. You can move, or remove it, as needed.
        Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
        Me.rptTRANSAC.RefreshReport()
    End Sub

    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        If cboTYPE.Text = "" Then
            Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
            btnFILTER.Visible = True

        Else
            Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_transactionTableAdapter.FillByType(Me.ursbgso_dbDataSet.tbl_transaction, cboTYPE.Text)
            Me.rptTRANSAC.RefreshReport()
            btnUNFILTER.Visible = True
            btnFILTER.Visible = False
        End If
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
        Me.rptTRANSAC.RefreshReport()
        btnUNFILTER.Visible = False
        btnFILTER.Visible = True
        cboTYPE.Text = ""
    End Sub


    Private Sub btnFILTERD_Click(sender As Object, e As EventArgs) Handles btnFILTERD.Click
        Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.FillByDateBorrowed(Me.ursbgso_dbDataSet.tbl_transaction, dtDATETIME.Value.ToShortDateString, dtDATETIME1.Value.ToShortDateString)
        Me.rptTRANSAC.RefreshReport()
        btnFILTERD.Visible = False
        btnUNFILTERD.Visible = True
    End Sub

    Private Sub btnUNFILTERD_Click(sender As Object, e As EventArgs) Handles btnUNFILTERD.Click
        Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
        Me.rptTRANSAC.RefreshReport()
        btnFILTERD.Visible = True
        btnUNFILTERD.Visible = False
    End Sub
End Class
