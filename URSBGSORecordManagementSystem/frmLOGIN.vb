Public Class frmLOGIN
    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.TransparencyKey = BackColor 'REMOVE BACKCOLOR OF THE FORM
        btnSHOW.Hide() 'BTNSHOW IS A CUSTOMIZED BUTTON USING PICTUREBOX 
        btnHIDE.Hide() 'BTNHIDE IS A CUSTOMIZED BUTTON USING PICTUREBOX 
        pnlINFO.Hide()

        roundedFORM(Me)
        roundedPANELIN(pnlLOGO)
    End Sub

    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        Dim status As String = "Active"

        'ADMIN AND STAFF LOGIN
        OpenCon()

        cmd.CommandText = "Select * from tbl_user where username = '" & txtUSER.Text & "' and password = '" & txtPASS.Text & "' and status = '" & status & "'"
        cmd.ExecuteNonQuery()

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr(3) = "GSO Head" Then
                frmMAINMENU.lblUSERTYPE.Text = "GSO Head"
                frmMAINMENU.lblGREETINGS.Text = "Hello, GSO Head"

                frmMAINMENU.Show()
                Me.Close()
            ElseIf dr(3) = "Staff" Then
                frmMAINMENU.lblUSERTYPE.Text = "Staff"
                frmMAINMENU.lblGREETINGS.Text = "Hello, Staff"
                frmMAINMENU.Show()

                'HIDE OR DISABLE BUTTON
                frmMAINMENU.btnUSERACC.Hide()
                frmMAINMENU.btnITEM.Hide()
                frmMAINMENU.btnSETT.Hide()

                'MOVE BUTTONS ON NAVIGATION BAR
                frmMAINMENU.btnBORP.Location = New Point(0, 204)
                frmMAINMENU.btnTRANSAC.Location = New Point(0, 249)
                frmMAINMENU.btnREPORTS.Location = New Point(0, 294)

                Me.Close()
            End If
        Else
            MsgBox("The username or password is incorrect.", vbOKOnly + vbCritical, "Login Error")
            txtUSER.Text = "Username"
            txtPASS.Text = "Password"
            txtPASS.UseSystemPasswordChar = False
            txtUSER.Focus()
            txtUSER.Text = ""
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
                If dr(3) = "GSO Head" Then
                    frmMAINMENU.lblUSERTYPE.Text = "GSO Head"
                    frmMAINMENU.lblGREETINGS.Text = "Hello, GSO Head"

                    frmMAINMENU.Show()
                    Me.Close()
                ElseIf dr(3) = "Staff" Then
                    frmMAINMENU.lblUSERTYPE.Text = "Staff"
                    frmMAINMENU.lblGREETINGS.Text = "Hello, Staff"
                    frmMAINMENU.Show()

                    'HIDE OR DISABLE BUTTON
                    frmMAINMENU.btnUSERACC.Hide()
                    frmMAINMENU.btnITEM.Hide()
                    frmMAINMENU.btnSETT.Hide()

                    'MOVE BUTTONS ON NAVIGATION BAR
                    frmMAINMENU.btnBORP.Location = New Point(0, 204)
                    frmMAINMENU.btnTRANSAC.Location = New Point(0, 249)
                    frmMAINMENU.btnREPORTS.Location = New Point(0, 294)

                    Me.Close()
                End If
            Else
                MsgBox("The username or password is incorrect.", vbOKOnly + vbCritical, "Login Error")
                txtUSER.Text = "Username"
                txtPASS.Text = "Password"
                txtPASS.UseSystemPasswordChar = False
                txtUSER.Focus()
                txtUSER.Text = ""
                txtUSER.ForeColor = ColorTranslator.FromHtml("#204AFF")
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
    Private Sub btnMINIMIZE_Click(sender As Object, e As EventArgs) Handles BTNMINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Me.Close()
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

    Private Sub btnLOGIN_MouseHover(sender As Object, e As EventArgs) Handles btnLOGIN.MouseHover
        btnLOGIN.BackgroundImage = My.Resources.loginbtnhover
    End Sub

    Private Sub btnLOGIN_MouseLeave(sender As Object, e As EventArgs) Handles btnLOGIN.MouseLeave
        btnLOGIN.BackgroundImage = My.Resources.loginbtn
    End Sub

    Private Sub btnSHOW_MouseHover(sender As Object, e As EventArgs) Handles btnSHOW.MouseHover
        btnSHOW.Image = My.Resources.showhover
    End Sub

    Private Sub btnSHOW_MouseLeave(sender As Object, e As EventArgs) Handles btnSHOW.MouseLeave
        btnSHOW.Image = My.Resources.show
    End Sub

    Private Sub btnHIDE_MouseHover(sender As Object, e As EventArgs) Handles btnHIDE.MouseHover
        btnHIDE.Image = My.Resources.hidehover
    End Sub

    Private Sub btnHIDE_MouseLeave(sender As Object, e As EventArgs) Handles btnHIDE.MouseLeave
        btnHIDE.Image = My.Resources.hide
    End Sub

    Private Sub btnINFO_MouseHover(sender As Object, e As EventArgs) Handles btnINFO.MouseHover
        pnlINFO.Show()
        btnINFO.Image = My.Resources.Info_circle_hover
    End Sub

    Private Sub btnINFO_MouseLeave(sender As Object, e As EventArgs) Handles btnINFO.MouseLeave
        pnlINFO.Hide()
        btnINFO.Image = My.Resources.Info_circle
    End Sub
End Class
