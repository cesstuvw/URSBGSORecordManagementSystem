Public Class frmREPORTS
    Private Sub frmREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_return' table. You can move, or remove it, as needed.
        Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
        Me.rptRETURN.RefreshReport()


        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_transaction' table. You can move, or remove it, as needed.
        Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
        Me.rptTRANSAC.RefreshReport()

        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_profile' table. You can move, or remove it, as needed.
        Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
        Me.rptPROFILE.RefreshReport()


        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_itemstock' table. You can move, or remove it, as needed.
        Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemstockTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_itemstock)
        Me.rptITEMST.RefreshReport()

        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_item' table. You can move, or remove it, as needed.
        Me.rptITEM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_item)
        Me.rptITEM.RefreshReport()


        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
        Me.rptUSER.RefreshReport()
        rptUSER.Visible = Enabled


    End Sub

    Private Sub btnUAREP_Click(sender As Object, e As EventArgs) Handles btnUAREP.Click
        INDICATOR.Height = btnUAREP.Height
        INDICATOR.Top = btnUAREP.Top

        rptUSER.Visible = True
        rptITEM.Visible = False
        rptITEMST.Visible = False
        rptPROFILE.Visible = False
        rptRETURN.Visible = False
        rptTRANSAC.Visible = False
    End Sub

    Private Sub btnITEMREP_Click(sender As Object, e As EventArgs) Handles btnITEMREP.Click
        INDICATOR.Height = btnITEMREP.Height
        INDICATOR.Top = btnITEMREP.Top

        rptUSER.Visible = False
        rptITEM.Visible = True
        rptITEMST.Visible = False
        rptPROFILE.Visible = False
        rptRETURN.Visible = False
        rptTRANSAC.Visible = False
    End Sub

    Private Sub btnITSTREP_Click(sender As Object, e As EventArgs) Handles btnITSTREP.Click
        INDICATOR.Height = btnITSTREP.Height
        INDICATOR.Top = btnITSTREP.Top

        rptUSER.Visible = False
        rptITEM.Visible = False
        rptITEMST.Visible = True
        rptPROFILE.Visible = False
        rptRETURN.Visible = False
        rptTRANSAC.Visible = False
    End Sub

    Private Sub btnBPROREP_Click(sender As Object, e As EventArgs) Handles btnBPROREP.Click
        INDICATOR.Height = btnBPROREP.Height
        INDICATOR.Top = btnBPROREP.Top

        rptUSER.Visible = False
        rptITEM.Visible = False
        rptITEMST.Visible = False
        rptPROFILE.Visible = True
        rptRETURN.Visible = False
        rptTRANSAC.Visible = False
    End Sub

    Private Sub btnTRANSREP_Click(sender As Object, e As EventArgs) Handles btnTRANSREP.Click
        INDICATOR.Height = btnTRANSREP.Height
        INDICATOR.Top = btnTRANSREP.Top

        rptUSER.Visible = False
        rptITEM.Visible = False
        rptITEMST.Visible = False
        rptPROFILE.Visible = False
        rptRETURN.Visible = False
        rptTRANSAC.Visible = True
    End Sub

    Private Sub btnRETREP_Click(sender As Object, e As EventArgs) Handles btnRETREP.Click
        INDICATOR.Height = btnRETREP.Height
        INDICATOR.Top = btnRETREP.Top

        rptUSER.Visible = False
        rptITEM.Visible = False
        rptITEMST.Visible = False
        rptPROFILE.Visible = False
        rptRETURN.Visible = True
        rptTRANSAC.Visible = False
    End Sub
End Class