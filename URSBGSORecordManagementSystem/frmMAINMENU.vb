Public Class frmMAINMENU

    Dim btnDASHWasClicked As Boolean = False
    Dim btnUSERACWasClicked As Boolean = False
    Dim btnITEMWasClicked As Boolean = False
    Dim btnITEMSTWasClicked As Boolean = False
    Dim btnBORPCWasClicked As Boolean = False
    Dim btnTRANSACWasClicked As Boolean = False
    Dim btnSETTWasClicked As Boolean = False
    Dim btnREPORTSWasClicked As Boolean = False

    'REMOVE SCREEN FLICKERING WHEN CHANGING PANNELS
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub frmMAINMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor 'REMOVE BACKCOLOR OF THE FORM

        DoubleBuffered = True
        btnLOGOUTA.Hide()
        pnlLOGOUT.Hide()

        btnDASHWasClicked = True

        btnINDICATOR.Height = btnDASH.Height
        btnINDICATOR.Top = btnDASH.Top

        'UI
        btnDASH.FlatAppearance.MouseOverBackColor = btnDASH.BackColor
        btnUSERACC.FlatAppearance.MouseOverBackColor = btnUSERACC.BackColor
        btnITEM.FlatAppearance.MouseOverBackColor = btnITEM.BackColor
        btnITEMST.FlatAppearance.MouseOverBackColor = btnITEMST.BackColor
        btnBORP.FlatAppearance.MouseOverBackColor = btnBORP.BackColor
        btnTRANSAC.FlatAppearance.MouseOverBackColor = btnTRANSAC.BackColor
        btnSETT.FlatAppearance.MouseOverBackColor = btnSETT.BackColor
        btnREPORTS.FlatAppearance.MouseOverBackColor = btnREPORTS.BackColor
        btnDASH.FlatAppearance.MouseDownBackColor = btnDASH.BackColor
        btnUSERACC.FlatAppearance.MouseDownBackColor = btnUSERACC.BackColor
        btnITEM.FlatAppearance.MouseDownBackColor = btnITEM.BackColor
        btnITEMST.FlatAppearance.MouseDownBackColor = btnITEMST.BackColor
        btnBORP.FlatAppearance.MouseDownBackColor = btnBORP.BackColor
        btnTRANSAC.FlatAppearance.MouseDownBackColor = btnTRANSAC.BackColor
        btnSETT.FlatAppearance.MouseDownBackColor = btnSETT.BackColor
        btnREPORTS.FlatAppearance.MouseDownBackColor = btnREPORTS.BackColor

        'HIDE USERCONTROL PANEL TO SHOW DASHBOARD 
        pnlUSERCONTROL.Hide()

        'LOAD USERCONTROL
        Dim usercontrol As New ucUSERACCOUNT
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill
        btnDASH.BackgroundImage = My.Resources.dashboardmnmn
    End Sub


    Private Sub btnDASH_Click(sender As Object, e As EventArgs) Handles btnDASH.Click
        pnlUSERCONTROL.Hide()
        btnDASH.FlatAppearance.MouseOverBackColor = btnDASH.BackColor

        btnDASH.BackgroundImage = My.Resources.dashboardmnmn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnDASH.Height
        btnINDICATOR.Top = btnDASH.Top

        btnDASHWasClicked = True
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnUSERACC_Click(sender As Object, e As EventArgs) Handles btnUSERACC.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnUSERACC.BackgroundImage = My.Resources.useraccountmnmn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucUSERACCOUNT
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnUSERACC.Height
        btnINDICATOR.Top = btnUSERACC.Top
        btnINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = True
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnITEM_Click(sender As Object, e As EventArgs) Handles btnITEM.Click
        DoubleBuffered = True
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnITEM.BackgroundImage = My.Resources.itemmnmn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucITEM
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnITEM.Height
        btnINDICATOR.Top = btnITEM.Top
        btnINDICATOR.BringToFront()


        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = True
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnITEMST_Click(sender As Object, e As EventArgs) Handles btnITEMST.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnITEMST.BackgroundImage = My.Resources.itemstocksmnmn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucITEMSTOCKS
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnITEMST.Height
        btnINDICATOR.Top = btnITEMST.Top
        btnINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = True
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnBORP_Click(sender As Object, e As EventArgs) Handles btnBORP.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnBORP.BackgroundImage = My.Resources.borrowersprofilemnmn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucBORROWERSPROFILE
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnBORP.Height
        btnINDICATOR.Top = btnBORP.Top
        btnINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = True
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnTRANSAC_Click(sender As Object, e As EventArgs) Handles btnTRANSAC.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnTRANSAC.BackgroundImage = My.Resources.transactionmnmn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucTRANSACTION
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnTRANSAC.Height
        btnINDICATOR.Top = btnTRANSAC.Top
        btnINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = True
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnSETT_Click(sender As Object, e As EventArgs) Handles btnSETT.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnSETT.BackgroundImage = My.Resources.settingsmnmn
        btnREPORTS.BackgroundImage = My.Resources.reportsmnfn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucSETTINGS
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnSETT.Height
        btnINDICATOR.Top = btnSETT.Top
        btnINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = True
        btnREPORTSWasClicked = False
    End Sub

    Private Sub btnREPORTS_Click(sender As Object, e As EventArgs) Handles btnREPORTS.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()

        btnREPORTS.BackgroundImage = My.Resources.reportsmnmn
        btnSETT.BackgroundImage = My.Resources.settingsmnfn
        btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        btnITEM.BackgroundImage = My.Resources.itemmnfn
        btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn

        Dim i As Integer
        For i = 0 To 0
            pnlUSERCONTROL.Controls.RemoveAt(i)
        Next

        Dim usercontrol As New ucREPORTS
        usercontrol.Parent = pnlUSERCONTROL
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        btnINDICATOR.Height = btnREPORTS.Height
        btnINDICATOR.Top = btnREPORTS.Top
        btnINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = True
    End Sub

    Private Sub btnLOGMENU_Click(sender As Object, e As EventArgs) Handles btnLOGMENU.Click
        pnlLOGOUT.Show()
        btnLOGMENU.Hide()
        btnLOGOUTA.Show()
    End Sub

    Private Sub btnLOGOUTA_Click(sender As Object, e As EventArgs) Handles btnLOGOUTA.Click
        pnlLOGOUT.Hide()
        btnLOGMENU.Show()
        btnLOGOUTA.Hide()
    End Sub

    Private Sub pnlLOGOUT_Click(sender As Object, e As EventArgs) Handles pnlLOGOUT.Click
        Dim response As DialogResult
        response = MsgBox("Do you really want to logout?", vbYesNo + vbQuestion, "Logout")

        If response = MsgBoxResult.Yes Then
            Me.Close()
            frmLOGIN.Show()

        ElseIf MsgBoxResult.No Then
            btnLOGMENU.Hide()
            btnLOGOUTA.Hide()
            pnlLOGOUT.Hide()
        End If
    End Sub

    Private Sub btnLOGOUT_Click(sender As Object, e As EventArgs) Handles btnLOGOUT.Click
        Dim response As DialogResult
        response = MsgBox("Do you really want to logout?", vbYesNo + vbQuestion, "Logout")

        If response = MsgBoxResult.Yes Then
            frmLOGIN.Show()
            Me.Close()

        ElseIf MsgBoxResult.No Then
            btnLOGMENU.Show()
            btnLOGOUTA.Hide()
            pnlLOGOUT.Hide()
        End If
    End Sub



    Private Sub btnDASH_MouseHover(sender As Object, e As EventArgs) Handles btnDASH.MouseHover
        If btnDASHWasClicked = True Then
            btnDASH.BackgroundImage = My.Resources.dashboardmnmn

        ElseIf btnDASHWasClicked = False Then
            btnDASH.BackgroundImage = My.Resources.dashboardhover
        End If
    End Sub

    Private Sub btnDASH_MouseLeave(sender As Object, e As EventArgs) Handles btnDASH.MouseLeave
        If btnDASHWasClicked = True Then
            btnDASH.BackgroundImage = My.Resources.dashboardmnmn

        ElseIf btnDASHWasClicked = False Then
            btnDASH.BackgroundImage = My.Resources.dashboardmnfn
        End If
    End Sub

    Private Sub btnUSERACC_MouseHover(sender As Object, e As EventArgs) Handles btnUSERACC.MouseHover
        If btnUSERACWasClicked = True Then
            btnUSERACC.BackgroundImage = My.Resources.useraccountmnmn

        ElseIf btnUSERACWasClicked = False Then
            btnUSERACC.BackgroundImage = My.Resources.useraccounthover
        End If
    End Sub
    Private Sub btnUSERACC_MouseLeave(sender As Object, e As EventArgs) Handles btnUSERACC.MouseLeave
        If btnUSERACWasClicked = True Then
            btnUSERACC.BackgroundImage = My.Resources.useraccountmnmn

        ElseIf btnUSERACWasClicked = False Then
            btnUSERACC.BackgroundImage = My.Resources.useraccountmnfn
        End If
    End Sub

    Private Sub btnITEM_MouseHover(sender As Object, e As EventArgs) Handles btnITEM.MouseHover
        If btnITEMWasClicked = True Then
            btnITEM.BackgroundImage = My.Resources.itemmnmn

        ElseIf btnITEMWasClicked = False Then
            btnITEM.BackgroundImage = My.Resources.itemhover
        End If
    End Sub
    Private Sub btnITEM_MouseLeave(sender As Object, e As EventArgs) Handles btnITEM.MouseLeave
        If btnITEMWasClicked = True Then
            btnITEM.BackgroundImage = My.Resources.itemmnmn

        ElseIf btnITEMWasClicked = False Then
            btnITEM.BackgroundImage = My.Resources.itemmnfn
        End If
    End Sub

    Private Sub btnITEMST_MouseHover(sender As Object, e As EventArgs) Handles btnITEMST.MouseHover
        If btnITEMSTWasClicked = True Then
            btnITEMST.BackgroundImage = My.Resources.itemstocksmnmn

        ElseIf btnITEMstWasClicked = False Then
            btnITEMST.BackgroundImage = My.Resources.itemstockshover
        End If
    End Sub

    Private Sub btnITEMST_MouseLeave(sender As Object, e As EventArgs) Handles btnITEMST.MouseLeave
        If btnITEMSTWasClicked = True Then
            btnITEMST.BackgroundImage = My.Resources.itemstocksmnmn

        ElseIf btnITEMSTWasClicked = False Then
            btnITEMST.BackgroundImage = My.Resources.itemstocksmnfn
        End If
    End Sub

    Private Sub btnBORP_MouseHover(sender As Object, e As EventArgs) Handles btnBORP.MouseHover
        If btnBORPCWasClicked = True Then
            btnBORP.BackgroundImage = My.Resources.borrowersprofilemnmn

        ElseIf btnBORPCWasClicked = False Then
            btnBORP.BackgroundImage = My.Resources.borrowersprofilehover
        End If
    End Sub
    Private Sub btnBORP_MouseLeave(sender As Object, e As EventArgs) Handles btnBORP.MouseLeave
        If btnBORPCWasClicked = True Then
            btnBORP.BackgroundImage = My.Resources.borrowersprofilemnmn

        ElseIf btnBORPCWasClicked = False Then
            btnBORP.BackgroundImage = My.Resources.borrowersprofilemngn
        End If
    End Sub

    Private Sub btnTRANSAC_MouseHover(sender As Object, e As EventArgs) Handles btnTRANSAC.MouseHover
        If btnTRANSACWasClicked = True Then
            btnTRANSAC.BackgroundImage = My.Resources.transactionmnmn

        ElseIf btnTRANSACWasClicked = False Then
            btnTRANSAC.BackgroundImage = My.Resources.transaction_hover
        End If
    End Sub
    Private Sub btnTRANSAC_MouseLeave(sender As Object, e As EventArgs) Handles btnTRANSAC.MouseLeave
        If btnTRANSACWasClicked = True Then
            btnTRANSAC.BackgroundImage = My.Resources.transactionmnmn

        ElseIf btnTRANSACWasClicked = False Then
            btnTRANSAC.BackgroundImage = My.Resources.transactionmnfn
        End If
    End Sub

    Private Sub btnSETT_MouseHover(sender As Object, e As EventArgs) Handles btnSETT.MouseHover
        If btnSETTWasClicked = True Then
            btnSETT.BackgroundImage = My.Resources.settingsmnmn

        ElseIf btnSETTWasClicked = False Then
            btnSETT.BackgroundImage = My.Resources.settingshover
        End If
    End Sub

    Private Sub btnSETT_MouseLeave(sender As Object, e As EventArgs) Handles btnSETT.MouseLeave
        If btnSETTWasClicked = True Then
            btnSETT.BackgroundImage = My.Resources.settingsmnmn

        ElseIf btnSETTWasClicked = False Then
            btnSETT.BackgroundImage = My.Resources.settingsmnfn
        End If
    End Sub

    Private Sub btnREPORTS_MouseHover(sender As Object, e As EventArgs) Handles btnREPORTS.MouseHover
        If btnREPORTSWasClicked = True Then
            btnREPORTS.BackgroundImage = My.Resources.reportsmnmn

        ElseIf btnREPORTSWasClicked = False Then
            btnREPORTS.BackgroundImage = My.Resources.reportshover
        End If
    End Sub
    Private Sub btnREPORTS_MouseLeave(sender As Object, e As EventArgs) Handles btnREPORTS.MouseLeave
        If btnREPORTSWasClicked = True Then
            btnREPORTS.BackgroundImage = My.Resources.reportsmnmn

        ElseIf btnREPORTSWasClicked = False Then
            btnREPORTS.BackgroundImage = My.Resources.reportsmnfn
        End If
    End Sub

    'WINDOW CONTROLS
    Private Sub BTNMINIMIZE_Click(sender As Object, e As EventArgs) Handles BTNMINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Me.Close()
    End Sub
End Class


''Private Sub timerLOADING_Tick(sender As Object, e As EventArgs) Handles timerLOADING.Tick
''    If loader.Value < loader.Maximum Then
''        loader.Value = loader.Value + 1
''    Else
''        pnlLOADING.Hide()
''    End If
''End Sub

