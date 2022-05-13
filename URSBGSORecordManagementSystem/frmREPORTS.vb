Public Class frmREPORTS
    'REMOVE SCREEN FLICKERING WHEN CHANGING PANELS
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub frmREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_return' table. You can move, or remove it, as needed.
        'Me.rptRETURN.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.tbl_returnTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_return)
        'Me.rptRETURN.RefreshReport()


        ''TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_transaction' table. You can move, or remove it, as needed.
        'Me.rptTRANSAC.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.tbl_transactionTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_transaction)
        'Me.rptTRANSAC.RefreshReport()

        ''TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_profile' table. You can move, or remove it, as needed.
        'Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
        'Me.rptPROFILE.RefreshReport()


        ''TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_itemstock' table. You can move, or remove it, as needed.
        'Me.rptITEMST.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.tbl_itemstockTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_itemstock)
        'Me.rptITEMST.RefreshReport()

        ''TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_item' table. You can move, or remove it, as needed.
        'Me.rptITEM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.tbl_itemTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_item)
        'Me.rptITEM.RefreshReport()


        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
        Me.rptUSER.RefreshReport()

        'HIDE USERCONTROL PANEL TO SHOW DASHBOARD 
        pnlUA.Show()
        pnlREP.Hide()
    End Sub

    'FILTER BUTTONS
    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        If cboUSERTYPE.Text = "" Then
            Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
            btnFILTER.Visible = True

        ElseIf cboUSERTYPE.Text = "GSO Head" Or cboUSERTYPE.Text = "Staff" Then
            Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_userTableAdapter.FillByUserType(Me.ursbgso_dbDataSet.tbl_user, cboUSERTYPE.Text)
            Me.rptUSER.RefreshReport()
            btnUNFILTER.Visible = True
            btnFILTER.Visible = False
        End If
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
        Me.rptUSER.RefreshReport()
        btnUNFILTER.Visible = False
        btnFILTER.Visible = True
        cboUSERTYPE.Text = ""
    End Sub

    'BUTTON PANEL
    Private Sub btnUAREP_Click(sender As Object, e As EventArgs) Handles btnUAREP.Click
        pnlREP.Hide()

        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
        Me.rptUSER.RefreshReport()

        INDICATOR.Height = btnUAREP.Height
        INDICATOR.Top = btnUAREP.Top
    End Sub

    Private Sub btnACTREP_Click(sender As Object, e As EventArgs) Handles btnACTREP.Click
        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim activitylog As New UCrptACTIVITY()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(activitylog)
        activitylog.Show()

        INDICATOR.Height = btnACTREP.Height
        INDICATOR.Top = btnACTREP.Top
    End Sub

    Private Sub btnITEMREP_Click(sender As Object, e As EventArgs) Handles btnITEMREP.Click
        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim item As New UCrptITEM()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(item)
        item.Show()

        INDICATOR.Height = btnITEMREP.Height
        INDICATOR.Top = btnITEMREP.Top
    End Sub

    Private Sub btnITSTREP_Click(sender As Object, e As EventArgs) Handles btnITSTREP.Click
        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim itemst As New UCrptITEMSTOCK()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(itemst)
        itemst.Show()

        INDICATOR.Height = btnITSTREP.Height
        INDICATOR.Top = btnITSTREP.Top
    End Sub

    Private Sub btnBPROREP_Click(sender As Object, e As EventArgs) Handles btnBPROREP.Click
        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim profile As New UCrptPROFILE()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(profile)
        profile.Show()

        INDICATOR.Height = btnBPROREP.Height
        INDICATOR.Top = btnBPROREP.Top
    End Sub

    Private Sub btnTRANSREP_Click(sender As Object, e As EventArgs) Handles btnTRANSREP.Click
        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim transac As New UCrptTRANSAC()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(transac)
        transac.Show()

        INDICATOR.Height = btnTRANSREP.Height
        INDICATOR.Top = btnTRANSREP.Top
    End Sub

    'Private Sub btnRETREP_Click(sender As Object, e As EventArgs) Handles btnRETREP.Click
    '    INDICATOR.Height = btnRETREP.Height
    '    INDICATOR.Top = btnRETREP.Top

    '    rptUSER.Visible = False
    '    rptITEM.Visible = False
    '    rptITEMST.Visible = False
    '    rptPROFILE.Visible = False
    '    rptRETURN.Visible = True
    '    rptTRANSAC.Visible = False
    'End Sub
End Class