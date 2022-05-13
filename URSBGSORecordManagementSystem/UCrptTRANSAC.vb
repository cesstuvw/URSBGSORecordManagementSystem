Public Class UCrptTRANSAC
    Private Sub UCrptTRANSAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_transaction' table. You can move, or remove it, as needed.
        Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
        Me.rptTRANSAC.RefreshReport()
    End Sub
End Class
