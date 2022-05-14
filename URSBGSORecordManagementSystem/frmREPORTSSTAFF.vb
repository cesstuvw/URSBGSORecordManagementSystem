Public Class frmREPORTSSTAFF
    'REMOVE SCREEN FLICKERING WHEN CHANGING PANELS
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub frmREPORTSSTAFF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_profile' table. You can move, or remove it, as needed.
        Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
        Me.rptPROFILE.RefreshReport()

        'HIDE USERCONTROL PANEL TO SHOW BP PANEL
        pnlBP.Show()
        pnlREPS.Hide()
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

    'BUTTON PANEL
    Private Sub btnBPROREP_Click(sender As Object, e As EventArgs) Handles btnBPROREP.Click
        INDICATOR.Height = btnBPROREP.Height
        INDICATOR.Top = btnBPROREP.Top

        pnlREPS.Hide()

        Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_profileTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_profile)
        Me.rptPROFILE.RefreshReport()

    End Sub

    Private Sub btnTRANSREP_Click(sender As Object, e As EventArgs) Handles btnTRANSREP.Click
        INDICATOR.Height = btnTRANSREP.Height
        INDICATOR.Top = btnTRANSREP.Top

        pnlREPS.Show()

        pnlREPS.Controls.Clear()
        Dim transac As New UCrptTRANSAC()
        'usercontrol.TopLevel = False
        pnlREPS.Controls.Add(transac)
        transac.Show()
    End Sub

    Private Sub btnRETREP_Click(sender As Object, e As EventArgs) Handles btnRETREP.Click
        INDICATOR.Height = btnRETREP.Height
        INDICATOR.Top = btnRETREP.Top

        pnlREPS.Show()

        pnlREPS.Controls.Clear()
        Dim returnn As New UCrptRETURN()
        'usercontrol.TopLevel = False
        pnlREPS.Controls.Add(returnn)
        returnn.Show()
    End Sub
End Class