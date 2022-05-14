Public Class frmREPORTSHEAD

    Dim active As Boolean = False

    'REMOVE SCREEN FLICKERING WHEN CHANGING PANELS
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub frmREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If frmMAINMENU.lblUSERTYPE.Text = "Staff" Then
        '    pnlREP.Show()
        '    pnlUA.Hide()
        '    active = True
        '    pnlUA.Visible = False

        '    btnUAREP.Hide()
        '    btnACTREP.Hide()
        '    btnITEMREP.Hide()
        '    btnITSTREP.Hide()

        '    btnBPROREP.Location = New Point(268, 85)
        '    btnTRANSREP.Location = New Point(268, 128)
        '    btnRETREP.Location = New Point(268, 171)
        'End If


        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_user' table. You can move, or remove it, as needed.
        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
        Me.rptUSER.RefreshReport()

        'HIDE USERCONTROL PANEL TO SHOW UA PANEL
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
        INDICATOR.Height = btnUAREP.Height
        INDICATOR.Top = btnUAREP.Top

        pnlREP.Hide()

        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_user)
        Me.rptUSER.RefreshReport()

    End Sub

    Private Sub btnACTREP_Click(sender As Object, e As EventArgs) Handles btnACTREP.Click
        INDICATOR.Height = btnACTREP.Height
        INDICATOR.Top = btnACTREP.Top

        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim activitylog As New UCrptACTIVITY()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(activitylog)
        activitylog.Show()

    End Sub

    Private Sub btnITEMREP_Click(sender As Object, e As EventArgs) Handles btnITEMREP.Click
        INDICATOR.Height = btnITEMREP.Height
        INDICATOR.Top = btnITEMREP.Top

        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim item As New UCrptITEM()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(item)
        item.Show()
    End Sub

    Private Sub btnITSTREP_Click(sender As Object, e As EventArgs) Handles btnITSTREP.Click
        INDICATOR.Height = btnITSTREP.Height
        INDICATOR.Top = btnITSTREP.Top

        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim itemst As New UCrptITEMSTOCK()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(itemst)
        itemst.Show()
    End Sub

    Private Sub btnBPROREP_Click(sender As Object, e As EventArgs) Handles btnBPROREP.Click
        pnlREP.Show()

        INDICATOR.Height = btnBPROREP.Height
        INDICATOR.Top = btnBPROREP.Top


        pnlREP.Controls.Clear()
        Dim profile As New UCrptPROFILE()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(profile)
        profile.Show()

        active = True
    End Sub

    Private Sub btnTRANSREP_Click(sender As Object, e As EventArgs) Handles btnTRANSREP.Click
        INDICATOR.Height = btnTRANSREP.Height
        INDICATOR.Top = btnTRANSREP.Top

        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim transac As New UCrptTRANSAC()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(transac)
        transac.Show()

    End Sub

    Private Sub btnRETREP_Click(sender As Object, e As EventArgs) Handles btnRETREP.Click
        INDICATOR.Height = btnRETREP.Height
        INDICATOR.Top = btnRETREP.Top

        pnlREP.Show()

        pnlREP.Controls.Clear()
        Dim returnn As New UCrptRETURN()
        'usercontrol.TopLevel = False
        pnlREP.Controls.Add(returnn)
        returnn.Show()
    End Sub
End Class