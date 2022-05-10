﻿Public Class frmMAINMENU
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
        'Me.TransparencyKey = BackColor 'REMOVE BACKCOLOR OF THE FORM

        DoubleBuffered = True
        btnLOGOUTA.Hide()
        btnOUT.Hide()

        btnDASHWasClicked = True
        btnUSERACWasClicked = False
        btnDASH.BackgroundImage = My.Resources.dashboard_menu_selected

        pnlINDICATOR.Height = btnDASH.Height - 3
        pnlINDICATOR.Top = btnDASH.Top

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
        pnlDASHBOARD.Show()
        pnlUSERCONTROL.Hide()

        'pnlUSERCONTROL.Controls.Clear()
        'Dim usercontrol As New ucUSERACCOUNT()
        ''usercontrol.TopLevel = False
        'pnlUSERCONTROL.Controls.Add(usercontrol)
        'usercontrol.Show()

        'Load usercontrol
        'Dim Dashboard As New ucDASHBOARD
        'Dashboard.Parent = pnlUSERCONTROL
        'Dashboard.Show()
        'Dashboard.Dock = DockStyle.Fill

        'pnlUSERCONTROL.Controls.Clear()
        'Dim Dashboard As New ucDASHBOARD()
        ''usercontrol.TopLevel = False
        'pnlUSERCONTROL.Controls.Add(Dashboard)
        'Dashboard.Show()

    End Sub

    Private Sub btnDASH_Click(sender As Object, e As EventArgs) Handles btnDASH.Click
        pnlUSERCONTROL.Hide()
        pnlDASHBOARD.BringToFront()
        pnlDASHBOARD.Show()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()
        btnDASH.FlatAppearance.MouseOverBackColor = btnDASH.BackColor

        btnDASH.BackgroundImage = My.Resources.dashboard_menu_selected
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnDASH.Height - 3
        pnlINDICATOR.Top = btnDASH.Top
        pnlINDICATOR.BringToFront()

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

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu_selected
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        pnlUSERCONTROL.Controls.Clear()
        Dim UserAccount As New ucUSERACCOUNT()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(UserAccount)
        UserAccount.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim UserAccount As New ucUSERACCOUNT
        'UserAccount.Parent = pnlUSERCONTROL
        'UserAccount.Show()
        'UserAccount.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnUSERACC.Height - 3
        pnlINDICATOR.Top = btnUSERACC.Top
        pnlINDICATOR.BringToFront()

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
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()
        pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu_selected
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnITEM.Height - 3
        pnlINDICATOR.Top = btnITEM.Top
        pnlINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = True
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False

        pnlUSERCONTROL.Controls.Clear()
        Dim Item As New ucITEM()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(Item)
        Item.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim Item As New ucITEM
        'Item.Parent = pnlUSERCONTROL
        'Item.Show()
        'Item.Dock = DockStyle.Fill
    End Sub

    Private Sub btnITEMST_Click(sender As Object, e As EventArgs) Handles btnITEMST.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()
        pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu_selected
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnITEMST.Height - 3
        pnlINDICATOR.Top = btnITEMST.Top
        pnlINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = True
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = False
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False

        pnlUSERCONTROL.Controls.Clear()
        Dim ItemStocks As New ucITEMSTOCKS()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(ItemStocks)
        ItemStocks.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim ItemStocks As New ucITEMSTOCKS
        'ItemStocks.Parent = pnlUSERCONTROL
        'ItemStocks.Show()
        'ItemStocks.Dock = DockStyle.Fill
    End Sub

    Private Sub btnBORP_Click(sender As Object, e As EventArgs) Handles btnBORP.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()
        'pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu_selected
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu


        pnlUSERCONTROL.Controls.Clear()
        Dim Borrowers As New ucBORROWERSPROFILE()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(Borrowers)
        Borrowers.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim Borrowers As New ucBORROWERSPROFILE
        'Borrowers.Parent = pnlUSERCONTROL
        'Borrowers.Show()
        'Borrowers.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnBORP.Height - 3
        pnlINDICATOR.Top = btnBORP.Top
        pnlINDICATOR.BringToFront()

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
        'pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu_selected
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        pnlUSERCONTROL.Controls.Clear()
        Dim Transaction As New ucTRANSACTION()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(Transaction)
        Transaction.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim Transaction As New ucTRANSACTION
        'Transaction.Parent = pnlUSERCONTROL
        'Transaction.Show()
        'Transaction.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnTRANSAC.Height - 3
        pnlINDICATOR.Top = btnTRANSAC.Top
        pnlINDICATOR.BringToFront()

        btnDASHWasClicked = False
        btnUSERACWasClicked = False
        btnITEMWasClicked = False
        btnITEMSTWasClicked = False
        btnBORPCWasClicked = False
        btnTRANSACWasClicked = True
        btnSETTWasClicked = False
        btnREPORTSWasClicked = False
    End Sub


    Private Sub btnRET_Click(sender As Object, e As EventArgs) Handles btnRET.Click
        pnlUSERCONTROL.Show()
        pnlUSERCONTROL.BringToFront()
        pnlMENU.BringToFront()
        BTNCLOSE.BringToFront()
        BTNMINIMIZE.BringToFront()
        'pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu_selected
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        pnlUSERCONTROL.Controls.Clear()
        Dim Returning As New ucRETURNING()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(Returning)
        Returning.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim Transaction As New ucTRANSACTION
        'Transaction.Parent = pnlUSERCONTROL
        'Transaction.Show()
        'Transaction.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnRET.Height - 3
        pnlINDICATOR.Top = btnTRANSAC.Top
        pnlINDICATOR.BringToFront()

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
        'pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu_selected
        btnREPORTS.BackgroundImage = My.Resources.reports_menu

        pnlUSERCONTROL.Controls.Clear()
        Dim Settings As New ucSETTINGS()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(Settings)
        Settings.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim Settings As New ucSETTINGS
        'Settings.Parent = pnlUSERCONTROL
        'Settings.Show()
        'Settings.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnSETT.Height - 3
        pnlINDICATOR.Top = btnSETT.Top
        pnlINDICATOR.BringToFront()

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
        'pnlDASHBOARD.SendToBack()

        btnDASH.BackgroundImage = My.Resources.dashboard_menu
        btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        btnITEM.BackgroundImage = My.Resources.item_menu
        btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        btnSETT.BackgroundImage = My.Resources.settings_menu
        btnREPORTS.BackgroundImage = My.Resources.reports_menu_selected

        pnlUSERCONTROL.Controls.Clear()
        Dim Reports As New ucREPORTS()
        'usercontrol.TopLevel = False
        pnlUSERCONTROL.Controls.Add(Reports)
        Reports.Show()

        'Dim i As Integer
        'For i = 0 To 0
        '    pnlUSERCONTROL.Controls.RemoveAt(i)
        'Next

        'Dim Reports As New ucREPORTS
        'Reports.Parent = pnlUSERCONTROL
        'Reports.Show()
        'Reports.Dock = DockStyle.Fill

        'SHOW BUTTON INDICATOR
        pnlINDICATOR.Height = btnREPORTS.Height - 3
        pnlINDICATOR.Top = btnREPORTS.Top
        pnlINDICATOR.BringToFront()

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
        btnOUT.Show()
        btnLOGMENU.Hide()
        btnLOGOUTA.Show()
    End Sub

    Private Sub btnLOGOUTA_Click(sender As Object, e As EventArgs) Handles btnLOGOUTA.Click
        btnOUT.Hide()
        btnLOGMENU.Show()
        btnLOGOUTA.Hide()
    End Sub

    Private Sub btnOUT_Click(sender As Object, e As EventArgs) Handles btnOUT.Click
        Dim response As DialogResult
        response = MsgBox("Do you really want to logout?", vbYesNo + vbQuestion, "Logout")

        If response = MsgBoxResult.Yes Then
            frmLOGIN.Show()
            Me.Close()

        ElseIf MsgBoxResult.No Then
            btnLOGMENU.Show()
            btnLOGOUTA.Hide()
            btnOUT.Hide()
        End If
    End Sub

    Private Sub btnDASH_MouseHover(sender As Object, e As EventArgs) Handles btnDASH.MouseHover
        If btnDASHWasClicked = True Then
            btnDASH.BackgroundImage = My.Resources.dashboard_menu_selected

        ElseIf btnDASHWasClicked = False Then
            btnDASH.BackgroundImage = My.Resources.dashboard_menu_hover
        End If
    End Sub

    Private Sub btnDASH_MouseLeave(sender As Object, e As EventArgs) Handles btnDASH.MouseLeave
        If btnDASHWasClicked = True Then
            btnDASH.BackgroundImage = My.Resources.dashboard_menu_selected

        ElseIf btnDASHWasClicked = False Then
            btnDASH.BackgroundImage = My.Resources.dashboard_menu
        End If
    End Sub

    Private Sub btnUSERACC_MouseHover(sender As Object, e As EventArgs) Handles btnUSERACC.MouseHover
        If btnUSERACWasClicked = True Then
            btnUSERACC.BackgroundImage = My.Resources.useraccount_menu_selected

        ElseIf btnUSERACWasClicked = False Then
            btnUSERACC.BackgroundImage = My.Resources.useraccount_menu_hover
        End If
    End Sub
    Private Sub btnUSERACC_MouseLeave(sender As Object, e As EventArgs) Handles btnUSERACC.MouseLeave
        If btnUSERACWasClicked = True Then
            btnUSERACC.BackgroundImage = My.Resources.useraccount_menu_selected

        ElseIf btnUSERACWasClicked = False Then
            btnUSERACC.BackgroundImage = My.Resources.useraccount_menu
        End If
    End Sub

    Private Sub btnITEM_MouseHover(sender As Object, e As EventArgs) Handles btnITEM.MouseHover
        If btnITEMWasClicked = True Then
            btnITEM.BackgroundImage = My.Resources.item_menu_selected

        ElseIf btnITEMWasClicked = False Then
            btnITEM.BackgroundImage = My.Resources.item_menu_hover
        End If
    End Sub
    Private Sub btnITEM_MouseLeave(sender As Object, e As EventArgs) Handles btnITEM.MouseLeave
        If btnITEMWasClicked = True Then
            btnITEM.BackgroundImage = My.Resources.item_menu_selected

        ElseIf btnITEMWasClicked = False Then
            btnITEM.BackgroundImage = My.Resources.item_menu
        End If
    End Sub

    Private Sub btnITEMST_MouseHover(sender As Object, e As EventArgs) Handles btnITEMST.MouseHover
        If btnITEMSTWasClicked = True Then
            btnITEMST.BackgroundImage = My.Resources.item_stocks_menu_selected

        ElseIf btnITEMSTWasClicked = False Then
            btnITEMST.BackgroundImage = My.Resources.item_stocks_menu_hover
        End If
    End Sub

    Private Sub btnITEMST_MouseLeave(sender As Object, e As EventArgs) Handles btnITEMST.MouseLeave
        If btnITEMSTWasClicked = True Then
            btnITEMST.BackgroundImage = My.Resources.item_stocks_menu_selected

        ElseIf btnITEMSTWasClicked = False Then
            btnITEMST.BackgroundImage = My.Resources.item_stocks_menu
        End If
    End Sub

    Private Sub btnBORP_MouseHover(sender As Object, e As EventArgs) Handles btnBORP.MouseHover
        If btnBORPCWasClicked = True Then
            btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu_selected

        ElseIf btnBORPCWasClicked = False Then
            btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu_hover
        End If
    End Sub
    Private Sub btnBORP_MouseLeave(sender As Object, e As EventArgs) Handles btnBORP.MouseLeave
        If btnBORPCWasClicked = True Then
            btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu_selected

        ElseIf btnBORPCWasClicked = False Then
            btnBORP.BackgroundImage = My.Resources.borrowers_profile_menu
        End If
    End Sub

    Private Sub btnTRANSAC_MouseHover(sender As Object, e As EventArgs) Handles btnTRANSAC.MouseHover
        If btnTRANSACWasClicked = True Then
            btnTRANSAC.BackgroundImage = My.Resources.transaction_menu_selected

        ElseIf btnTRANSACWasClicked = False Then
            btnTRANSAC.BackgroundImage = My.Resources.transaction_menu_hover
        End If
    End Sub
    Private Sub btnTRANSAC_MouseLeave(sender As Object, e As EventArgs) Handles btnTRANSAC.MouseLeave
        If btnTRANSACWasClicked = True Then
            btnTRANSAC.BackgroundImage = My.Resources.transaction_menu_selected

        ElseIf btnTRANSACWasClicked = False Then
            btnTRANSAC.BackgroundImage = My.Resources.transaction_menu
        End If
    End Sub

    Private Sub btnSETT_MouseHover(sender As Object, e As EventArgs) Handles btnSETT.MouseHover, btnRET.MouseHover
        If btnSETTWasClicked = True Then
            btnSETT.BackgroundImage = My.Resources.settings_menu_selected

        ElseIf btnSETTWasClicked = False Then
            btnSETT.BackgroundImage = My.Resources.settings_menu_hover
        End If
    End Sub

    Private Sub btnSETT_MouseLeave(sender As Object, e As EventArgs) Handles btnSETT.MouseLeave, btnRET.MouseLeave
        If btnSETTWasClicked = True Then
            btnSETT.BackgroundImage = My.Resources.settings_menu_selected

        ElseIf btnSETTWasClicked = False Then
            btnSETT.BackgroundImage = My.Resources.settings_menu
        End If
    End Sub

    Private Sub btnREPORTS_MouseHover(sender As Object, e As EventArgs) Handles btnREPORTS.MouseHover
        If btnREPORTSWasClicked = True Then
            btnREPORTS.BackgroundImage = My.Resources.reports_menu_selected

        ElseIf btnREPORTSWasClicked = False Then
            btnREPORTS.BackgroundImage = My.Resources.reports_menu_hover
        End If
    End Sub
    Private Sub btnREPORTS_MouseLeave(sender As Object, e As EventArgs) Handles btnREPORTS.MouseLeave
        If btnREPORTSWasClicked = True Then
            btnREPORTS.BackgroundImage = My.Resources.reports_menu_selected

        ElseIf btnREPORTSWasClicked = False Then
            btnREPORTS.BackgroundImage = My.Resources.reports_menu
        End If
    End Sub

    'WINDOW CONTROLS
    Private Sub BTNMINIMIZE_Click(sender As Object, e As EventArgs) Handles BTNMINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Dim response As DialogResult
        response = MsgBox("Do you really want to exit?", vbYesNo + vbQuestion, "Exit System")

        If response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class


''Private Sub timerLOADING_Tick(sender As Object, e As EventArgs) Handles timerLOADING.Tick
''    If loader.Value < loader.Maximum Then
''        loader.Value = loader.Value + 1
''    Else
''        pnlLOADING.Hide()
''    End If
''End Sub

