﻿Public Class UCrptACTIVITY
    Private Sub rptACTIVITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_activity' table. You can move, or remove it, as needed.
        Me.rptACT.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_activityTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_activity)
        Me.rptACT.RefreshReport()

    End Sub

    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        Me.rptACT.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_activityTableAdapter.FillByDateTime(Me.ursbgso_dbDataSet.tbl_activity, dtDATETIME.Value.ToShortDateString, dtDATETIME1.Value.ToShortDateString)
        btnFILTER.Visible = False
        btnUNFILTER.Visible = True
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptACT.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_activityTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_activity)
        Me.rptACT.RefreshReport()
        btnFILTER.Visible = True
        btnUNFILTER.Visible = False
    End Sub
End Class