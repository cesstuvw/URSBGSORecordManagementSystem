Public Class frmLOGIN

    Dim status As String = "Active"
    Dim username As String = ""

    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.TransparencyKey = BackColor 'REMOVE BACKCOLOR OF THE FORM
        btnSHOW.Hide() 'BTNSHOW IS A CUSTOMIZED BUTTON USING PICTUREBOX 
        btnHIDE.Hide() 'BTNHIDE IS A CUSTOMIZED BUTTON USING PICTUREBOX 
        pnlINFO.Hide()
    End Sub

    Private Sub actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_activity values (@un, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", txtUSER.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Date.Now())
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        'ADMIN AND STAFF LOGIN
        OpenCon()

        cmd.CommandText = "Select * from tbl_user where username = '" & txtUSER.Text & "' and password = '" & txtPASS.Text & "' and status = '" & status & "'"
        cmd.ExecuteNonQuery()

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()

            If dr(0) = txtUSER.Text And dr(3) = "GSO Head" Then
                username = txtUSER.Text
                activity = "Logged-in"
                actlog()
                frmMAINMENU.lblUSERNAME.Text = "@" + username
                frmMAINMENU.lblUSERTYPE.Text = "GSO Head"
                frmMAINMENU.lblGREETINGS.Text = "Hello, GSO Head"
                frmMAINMENU.lblLOGGED.Text = Format(TimeOfDay, "hh:mm tt")
                frmMAINMENU.Show()
                Me.Close()

            ElseIf dr(0) = txtUSER.Text And dr(3) = "Staff" Then
                username = txtUSER.Text
                activity = "Logged-In"
                actlog()
                frmMAINMENU.lblUSERNAME.Text = "@" + username
                frmMAINMENU.lblUSERTYPE.Text = "Staff"
                frmMAINMENU.lblGREETINGS.Text = "Hello, Staff"
                frmMAINMENU.lblLOGGED.Text = Format(TimeOfDay, "hh:mm tt")
                frmMAINMENU.Show()


                'HIDE OR DISABLE BUTTON
                frmMAINMENU.btnUSERACC.Hide()
                frmMAINMENU.btnITEM.Hide()
                frmMAINMENU.btnSETT.Hide()
                frmREPORTSHEAD.btnUAREP.Hide()
                frmREPORTSHEAD.btnACTREP.Hide()
                frmREPORTSHEAD.btnITEMREP.Hide()
                frmREPORTSHEAD.btnITSTREP.Hide()

                'MOVE BUTTONS ON NAVIGATION BAR
                frmMAINMENU.btnBORP.Location = New Point(0, 211)
                frmMAINMENU.btnTRANSAC.Location = New Point(0, 256)
                frmMAINMENU.btnRET.Location = New Point(0, 301)
                frmMAINMENU.btnREPORTS.Location = New Point(0, 346)
                frmREPORTSHEAD.btnBPROREP.Location = New Point(268, 85)
                frmREPORTSHEAD.btnTRANSREP.Location = New Point(268, 128)
                frmREPORTSHEAD.btnRETREP.Location = New Point(268, 171)
                Me.Close()
            End If

            'If dr(3) = "GSO Head" Then
            '    activity = "Logged-In"
            '    actlog()
            '    frmMAINMENU.lblUSERTYPE.Text = "GSO Head"
            '    frmMAINMENU.lblGREETINGS.Text = "Hello, GSO Head"

            '    frmMAINMENU.Show()
            '    Me.Close()
            'ElseIf dr(3) = "Staff" Then
            '    activity = "Logged-In"
            '    actlog()
            '    frmMAINMENU.lblUSERTYPE.Text = "Staff"
            '    frmMAINMENU.lblGREETINGS.Text = "Hello, Staff"
            '    frmMAINMENU.Show()

            '    'HIDE OR DISABLE BUTTON
            '    frmMAINMENU.btnUSERACC.Hide()
            '    frmMAINMENU.btnITEM.Hide()
            '    frmMAINMENU.btnSETT.Hide()

            '    'MOVE BUTTONS ON NAVIGATION BAR
            '    frmMAINMENU.btnBORP.Location = New Point(0, 211)
            '    frmMAINMENU.btnTRANSAC.Location = New Point(0, 256)
            '    frmMAINMENU.btnRET.Location = New Point(0, 301)
            '    frmMAINMENU.btnREPORTS.Location = New Point(0, 346)

            '    Me.Close()



        Else
            MsgBox("The username or password is incorrect.", vbOKOnly + vbCritical, "Login Error")
            txtUSER.Text = "Username"
            txtPASS.Text = "Password"
            txtPASS.UseSystemPasswordChar = False
            btnSHOW.Hide()
            btnHIDE.Hide()
            txtUSER.Focus()
            'txtUSER.Text = ""
            txtUSER.ForeColor = ColorTranslator.FromHtml("#204AFF")
            txtPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
        con.Close()
    End Sub

    'TXTUSER EVENTS
    Private Sub txtUSER_Enter(sender As Object, e As EventArgs) Handles txtUSER.Enter
        If txtUSER.Text = "Username" Then
            txtUSER.Text = ""
            txtUSER.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtUSER_Leave(sender As Object, e As EventArgs) Handles txtUSER.Leave
        If txtUSER.Text = "" Then
            txtUSER.Text = "Username"
            txtUSER.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtUSER_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUSER.KeyDown
        If e.KeyCode = Keys.Down Then
            txtPASS.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtPASS.Focus()
        End If
    End Sub

    'txtPASS EVENTS
    Private Sub txtPASS_Enter(sender As Object, e As EventArgs) Handles txtPASS.Enter
        If txtPASS.Text = "Password" Then
            txtPASS.Text = ""
            txtPASS.ForeColor = ColorTranslator.FromHtml("#204AFF")
            txtPASS.UseSystemPasswordChar = True
            btnSHOW.Hide()
        End If
    End Sub

    Private Sub txtPASS_Leave(sender As Object, e As EventArgs) Handles txtPASS.Leave
        If txtPASS.Text = "" Then
            txtPASS.Text = "Password"
            txtPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
            txtPASS.UseSystemPasswordChar = False
            btnSHOW.Hide()
        End If
    End Sub

    Private Sub txtPASS_TextChanged(sender As Object, e As EventArgs) Handles txtPASS.TextChanged
        If txtPASS.Text = "" Then
            btnSHOW.Hide()
        Else
            btnSHOW.Show()
        End If
    End Sub

    Private Sub txtPASS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPASS.KeyDown
        If e.KeyCode = Keys.Up Then
            txtUSER.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim status As String = "Active"

            'ADMIN AND STAFF LOGIN
            OpenCon()


            cmd.CommandText = "Select * from tbl_user where username = '" & txtUSER.Text & "' and password = '" & txtPASS.Text & "' and status = '" & status & "'"
            cmd.ExecuteNonQuery()

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr(0) = txtUSER.Text And dr(3) = "GSO Head" Then
                    username = txtUSER.Text
                    activity = "Logged-in"
                    actlog()
                    frmMAINMENU.lblUSERNAME.Text = "@" + username
                    frmMAINMENU.lblUSERTYPE.Text = "GSO Head"
                    frmMAINMENU.lblGREETINGS.Text = "Hello, GSO Head"
                    frmMAINMENU.lblLOGGED.Text = Format(TimeOfDay, "hh:mm tt")
                    frmMAINMENU.Show()
                    Me.Close()

                ElseIf dr(0) = txtUSER.Text And dr(3) = "Staff" Then
                    username = txtUSER.Text
                    activity = "Logged-In"
                    actlog()
                    frmMAINMENU.lblUSERNAME.Text = "@" + username
                    frmMAINMENU.lblUSERTYPE.Text = "Staff"
                    frmMAINMENU.lblGREETINGS.Text = "Hello, Staff"
                    frmMAINMENU.lblLOGGED.Text = Format(TimeOfDay, "hh:mm tt")
                    frmMAINMENU.Show()

                    'HIDE OR DISABLE BUTTON
                    frmMAINMENU.btnUSERACC.Hide()
                    frmMAINMENU.btnITEM.Hide()
                    frmMAINMENU.btnSETT.Hide()
                    frmREPORTSHEAD.btnUAREP.Hide()
                    frmREPORTSHEAD.btnACTREP.Hide()
                    frmREPORTSHEAD.btnITEMREP.Hide()
                    frmREPORTSHEAD.btnITSTREP.Hide()

                    'MOVE BUTTONS ON NAVIGATION BAR
                    frmMAINMENU.btnBORP.Location = New Point(0, 211)
                    frmMAINMENU.btnTRANSAC.Location = New Point(0, 256)
                    frmMAINMENU.btnRET.Location = New Point(0, 301)
                    frmMAINMENU.btnREPORTS.Location = New Point(0, 346)
                    frmREPORTSHEAD.btnBPROREP.Location = New Point(268, 85)
                    frmREPORTSHEAD.btnTRANSREP.Location = New Point(268, 128)
                    frmREPORTSHEAD.btnRETREP.Location = New Point(268, 171)

                    Me.Close()
                End If
            Else
                MsgBox("The username or password is incorrect.", vbOKOnly + vbCritical, "Login Error")
                txtUSER.Text = "Username"
                txtPASS.Text = "Password"
                btnSHOW.Hide()
                btnHIDE.Hide()
                txtPASS.UseSystemPasswordChar = False
                txtUSER.Focus()
                txtUSER.ForeColor = ColorTranslator.FromHtml("#204AFF")
                txtPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
            End If
            con.Close()
        End If
    End Sub

    'SHOW TEXT FORMAT OF PASSWORD
    Private Sub btnSHOW_Click(sender As Object, e As EventArgs) Handles btnSHOW.Click
        txtPASS.UseSystemPasswordChar = False
        btnHIDE.Show()
        btnSHOW.Hide()
    End Sub

    Private Sub btnHIDE_Click(sender As Object, e As EventArgs) Handles btnHIDE.Click
        txtPASS.UseSystemPasswordChar = True
        btnSHOW.Show()
        btnHIDE.Hide()
    End Sub

    'WINDOW CONTROLS
    Private Sub BTNMINIMIZE_Click(sender As Object, e As EventArgs) Handles BTNMINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Dim response As DialogResult
        response = MsgBox("Do you really want to exit?", vbYesNo + vbQuestion, "Exit System")

        If response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'UI EVENTS
    Private Sub btnMINIMIZE_MouseHover(sender As Object, e As EventArgs) Handles BTNMINIMIZE.MouseHover
        BTNMINIMIZE.Image = My.Resources.minimizehover
    End Sub

    Private Sub btnMINIMIZE_MouseLeave(sender As Object, e As EventArgs) Handles BTNMINIMIZE.MouseLeave
        BTNMINIMIZE.Image = My.Resources.minimize
    End Sub

    Private Sub btnCLOSE_MouseHover(sender As Object, e As EventArgs) Handles BTNCLOSE.MouseHover
        BTNCLOSE.Image = My.Resources.closehover
    End Sub

    Private Sub btnCLOSE_MouseLeave(sender As Object, e As EventArgs) Handles BTNCLOSE.MouseLeave
        BTNCLOSE.Image = My.Resources.close
    End Sub

    Private Sub btnINFO_MouseHover(sender As Object, e As EventArgs) Handles btnINFO.MouseHover
        pnlINFO.Show()
        btnINFO.Image = My.Resources.Info_circle_hover
    End Sub

    Private Sub btnINFO_MouseLeave(sender As Object, e As EventArgs) Handles btnINFO.MouseLeave
        pnlINFO.Hide()
        btnINFO.Image = My.Resources.Info_circle
    End Sub


    'LOAD TIME OR CLOCK TO AVOID GLITCHY DISPLAY ONCE MAINMENU IS SHOWN
    Private Sub tmrTIME_Tick(sender As Object, e As EventArgs) Handles tmrTIME.Tick
        frmMAINMENU.lblTIME.Text = Format(TimeOfDay, "hh:mm")
        frmMAINMENU.lblTIMEPERIOD.Text = Format(TimeOfDay, "tt")
        frmMAINMENU.lblMONTH.Text = Format(DateTime.Today.ToString("MMM"))
        frmMAINMENU.lblTODAY.Text = Format(DateTime.Today.ToString("dddd"))
        frmMAINMENU.lblDAY.Text = Format(DateTime.Today.ToString("dd"))
    End Sub
End Class
