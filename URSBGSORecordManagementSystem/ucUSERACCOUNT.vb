Public Class ucUSERACCOUNT
    Private Sub Function_Enabled()
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        txtUSER.Enabled = True
        txtPASS.Enabled = True
        txtCPASS.Enabled = True
        txtLNAME.Enabled = True
        cboUTYPE.Enabled = True
        cboSTATUS.Enabled = True
    End Sub

    Private Sub Function_Disabled()
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        txtUSER.Enabled = False
        txtPASS.Enabled = False
        txtCPASS.Enabled = False
        txtLNAME.Enabled = False
        cboUTYPE.Enabled = False
        cboSTATUS.Enabled = False
    End Sub

    Private Sub Function_Display()
        cboUTYPE.Visible = True
        cboSTATUS.Visible = True
        lblSTATUS.Hide()
        lblUTYPE.Hide()
        lblCPASS.Hide()
        lblUSER.Hide()
        lblLN.Hide()
        lblPASS.Hide()
    End Sub

    Private Sub Function_DontDisplay()
        cboUTYPE.Visible = False
        cboSTATUS.Visible = False
        lblSTATUS.Show()
        lblUTYPE.Show()
        lblCPASS.Show()
        lblUSER.Show()
        lblLN.Show()
        lblPASS.Show()
    End Sub

    Private Sub Function_TextFormat()
        txtPASS.Text = "Password"
        txtCPASS.Text = "Confirm Password"
        txtLNAME.Text = "Login Name"
        cboUTYPE.Text = "User Type"
        cboSTATUS.Text = "Status"
        txtPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtCPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtLNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        cboUTYPE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        cboSTATUS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtPASS.UseSystemPasswordChar = False
        txtCPASS.UseSystemPasswordChar = False
    End Sub

    Private Sub Function_DisabledPanel()
        pnlUS.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlPS.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlCPS.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlLN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlUT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlST.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub Function_EnabledPanel()
        pnlUS.BackColor = Color.White
        pnlPS.BackColor = Color.White
        pnlCPS.BackColor = Color.White
        pnlLN.BackColor = Color.White
        pnlUT.BackColor = Color.White
        pnlST.BackColor = Color.White
    End Sub

    Private Sub Function_Clean()
        pnlCLEANUT.Visible = True
        pnlCLEANUT1.Visible = True
        pnlCLEANUT2.Visible = True
        pnlCLEANUT3.Visible = True
        pnlCLEANST.Visible = True
        pnlCLEANST1.Visible = True
        pnlCLEANST2.Visible = True
        pnlCLEANST3.Visible = True
    End Sub
    Private Sub Function_DisableClean()
        pnlCLEANUT.Visible = False
        pnlCLEANUT1.Visible = False
        pnlCLEANUT2.Visible = False
        pnlCLEANUT3.Visible = False
        pnlCLEANST.Visible = False
        pnlCLEANST1.Visible = False
        pnlCLEANST2.Visible = False
        pnlCLEANST3.Visible = False
    End Sub

    Private Sub ucUSERACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCELDGV.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Me.Tbl_userTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_user)

        If txtPASS.Enabled = False And txtUSER.Enabled = False And txtCPASS.Enabled = False And txtLNAME.Enabled = False And cboSTATUS.Enabled = False And cboUTYPE.Enabled = False Then
            Function_DisabledPanel()
            Function_DontDisplay()
        Else
            Function_EnabledPanel()
        End If

        cboUTYPE.Items.Add("GSO Head")
        cboUTYPE.Items.Add("Staff")

        cboSTATUS.Items.Add("Active")
        cboSTATUS.Items.Add("Inactive")
    End Sub

    Private Sub dgvUSER_Refresh()
        Me.Tbl_userTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_user)
    End Sub

    '---------------------------------- CREATE A NEW ACCOUNT  BUTTON ---------------------------------'
    Private Sub btnCREATE_Click(sender As Object, e As EventArgs) Handles btnCREATE.Click
        btnCANCEL.BackColor = Color.White
        btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        'pnlCLEANST.Visible = False
        'pnlCLEANST1.Visible = False
        'pnlCLEANST2.Visible = False
        'pnlCLEANST3.Visible = False

        'pnlCLEANUT.Visible = False
        'pnlCLEANUT1.Visible = False
        'pnlCLEANUT2.Visible = False
        'pnlCLEANUT3.Visible = False
        Function_DisableClean()

        'btnSAVE.Text = "Save Account"
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        Function_Enabled()
        txtUSER.Focus()
        txtUSER.Text = ""
        btnCANCELDGV.Visible = False
        btnCANCEL.Visible = True
        btnUPDATE.Visible = False
        btnEDIT.Enabled = False
        Function_EnabledPanel()
        Function_Display()
        Function_TextFormat()

        dgvUSER.Enabled = True

        If txtUSER.Text = "" Then
            txtUSER.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    '---------------------------------- SAVE BUTTON ---------------------------------'
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'ERROR TRAPPING
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        If txtUSER.Text = "Username" Or txtPASS.Text = "Password" Or txtCPASS.Text = "Confirm Pass" Or txtLNAME.Text = "Login Name" Or cboUTYPE.Text = "User Type" Or cboSTATUS.Text = "Status" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        If txtPASS.Text <> txtCPASS.Text Then
            MsgBox("Passwords do not match.", vbOKOnly + vbCritical, "Error Saving")
            txtPASS.Focus()
            Exit Sub
        End If

        If cboUTYPE.Text <> "GSO Head" And cboUTYPE.Text <> "Staff" Then
            MsgBox("Unknown user type!", vbOKOnly + vbCritical, "Error Saving")
            cboUTYPE.Focus()
            Exit Sub
        End If

        If cboSTATUS.Text <> "Active" And cboSTATUS.Text <> "Inactive" Then
            MsgBox("Unknown user status!", vbOKOnly + vbCritical, "Error Saving")
            cboSTATUS.Focus()
            Exit Sub
        End If

        If txtUSER.Text <> txtUNCOPY.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_user where username = '" & txtUSER.Text & "' "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Sorry, username already exists.", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                txtUSER.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        'SAVING A NEW PROFILE
        OpenCon()
        cmd.CommandText = "insert into tbl_profile values( @un, @pw, @ln, @ut, @stat)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("un", txtUSER.Text)
        cmd.Parameters.AddWithValue("pw", txtPASS.Text)
        cmd.Parameters.AddWithValue("ln", txtLNAME.Text)
        cmd.Parameters.AddWithValue("ut", cboUTYPE.Text)
        cmd.Parameters.AddWithValue("stat", cboSTATUS.Text)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Account has been Saved!", vbOKOnly + vbInformation, "Saving Successful")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtUSER.Text = "Username"
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEDIT.Enabled = False
        dgvUSER.Enabled = True
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_Clean()
        Function_TextFormat()
        dgvUSER_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        btnCANCEL.Enabled = False
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        txtUSER.Text = "Username"
        txtPASS.Text = "Password"
        txtCPASS.Text = "Confirm Password"
        txtLNAME.Text = "Login Name"
        cboUTYPE.Text = "User Type"
        cboSTATUS.Text = "Status"
        dgvUSER.Enabled = True
        btnEDIT.Enabled = False
        Function_DontDisplay()
        Function_Disabled()
        Function_DisabledPanel()
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
    End Sub


    '---------------------------------- DATA GRID VIEW ---------------------------------'
    Private Sub dgvUSER_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUSER.CellFormatting
        If e.ColumnIndex = 1 Then
            e.Value = New String("●", e.Value.ToString.Length)
        End If
    End Sub

    Public Sub dgvUSER_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUSER.CellClick
        Function_Clean()
        btnEDIT.BackColor = Color.White
        btnCANCEL.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        btnCANCEL.Enabled = True
        btnCANCEL.Visible = True
        btnCANCEL.BringToFront()
        btnEDIT.Enabled = True
        btnCANCELDGV.Visible = False

        Function_Display()
        Function_DisabledPanel()

        txtPASS.UseSystemPasswordChar = True
        txtCPASS.UseSystemPasswordChar = True

        btnSAVE.Enabled = False
        txtUSER.Enabled = False
        txtPASS.Enabled = False
        txtCPASS.Enabled = False
        txtLNAME.Enabled = False
        cboUTYPE.Enabled = False
        cboSTATUS.Enabled = False

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvUSER.Rows(e.RowIndex)
            txtUSER.Text = row.Cells(0).Value
            txtPASS.Text = row.Cells(1).Value
            txtCPASS.Text = row.Cells(1).Value
            txtLNAME.Text = row.Cells(2).Value
            cboUTYPE.Text = row.Cells(3).Value
            cboSTATUS.Text = row.Cells(4).Value
        End If

        'btnSAVE.Text = "Update Account"
        btnUPDATE.Visible = True
        btnUPDATE.Enabled = False
        btnSAVE.Visible = False
    End Sub


    '---------------------------------- EDIT BUTTON ---------------------------------'
    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        btnCANCELDGV.Visible = True
        btnCANCELDGV.Enabled = True
        'btnCANCELDGV.Location = New Point(1242, 572)

        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnEDIT.BackColor = Color.White
        btnCANCELDGV.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#204aff")


        'pnlCLEANST.Visible = False
        'pnlCLEANST1.Visible = False
        'pnlCLEANST2.Visible = False
        'pnlCLEANST3.Visible = False

        'pnlCLEANUT.Visible = False
        'pnlCLEANUT1.Visible = False
        'pnlCLEANUT2.Visible = False
        'pnlCLEANUT3.Visible = False

        Function_DisableClean()

        btnEDIT.Enabled = False
        'btnSAVE.Enabled = True
        'btnSAVE.Text = "Update Account"
        btnUPDATE.Enabled = True
        btnSAVE.Visible = False
        btnCANCEL.Visible = False


        txtUSER.Enabled = False
        txtPASS.Enabled = True
        txtCPASS.Enabled = True
        txtLNAME.Enabled = True

        cboUTYPE.Enabled = True
        cboSTATUS.Enabled = True

        dgvUSER.Enabled = False

        Function_EnabledPanel()
        Function_Display()

        pnlUS.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtPASS.ForeColor = ColorTranslator.FromHtml("#204AFF")
        txtCPASS.ForeColor = ColorTranslator.FromHtml("#204AFF")
        txtLNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        cboUTYPE.ForeColor = ColorTranslator.FromHtml("#204AFF")
        cboSTATUS.ForeColor = ColorTranslator.FromHtml("#204AFF")

        txtPASS.UseSystemPasswordChar = True
        txtCPASS.UseSystemPasswordChar = True

        If btnEDIT.Enabled = True Then
            btnEDIT.BackColor = Color.White
        ElseIf btnEDIT.Enabled = False Then
            btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        End If
    End Sub


    '---------------------------------- UPDATE BUTTON ---------------------------------'
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        'Error Trapping

        If txtPASS.Text <> txtCOPW.Text And txtLNAME.Text <> txtCOLN.Text And cboUTYPE.Text <> cboCOUT.Text And cboSTATUS.Text <> cboCOST.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_user where password = '" & txtPASS.Text & "' and loginname = '" & txtLNAME.Text & "' and usertype = '" & cboUTYPE.Text & "' and status = '" & cboSTATUS.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("No changes have been made.", vbOKOnly + vbInformation, "Update")
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If
        If txtPASS.Text = "Password" Or txtCPASS.Text = "Confirm Pass" Or txtLNAME.Text = "Login Name" Or cboUTYPE.Text = "User Type" Or cboSTATUS.Text = "Status" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Updating")
            Exit Sub
        End If

        If cboUTYPE.Text <> "GSO Head" And cboUTYPE.Text <> "Staff" Then
            MsgBox("Unknown user type!", vbOKOnly + vbCritical, "Error Updating")
            cboUTYPE.Focus()
            Exit Sub
        End If

        If cboSTATUS.Text <> "Active" And cboSTATUS.Text <> "Inactive" Then
            MsgBox("Unknown user status!", vbOKOnly + vbCritical, "Error Updating")
            cboSTATUS.Focus()
            Exit Sub
        End If

        If txtPASS.Text <> txtCPASS.Text Then
            MsgBox("Passwords do not match.", vbOKOnly + vbCritical, "Error Updating")
            txtPASS.Focus()
            Exit Sub
        End If

        'Updating Code
        OpenCon()
        cmd.CommandText = "Update tbl_user set username=@un, password=@pw, loginname=@ln, usertype=@ut, status=@stat where username=@un"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("un", txtUSER.Text)
        cmd.Parameters.AddWithValue("pw", txtPASS.Text)
        cmd.Parameters.AddWithValue("ln", txtLNAME.Text)
        cmd.Parameters.AddWithValue("ut", cboUTYPE.Text)
        cmd.Parameters.AddWithValue("stat", cboSTATUS.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated", vbOKOnly + vbInformation, "Successfully updated")
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")

        txtUSER.Text = "Username"
        btnUPDATE.Enabled = False
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        btnCANCELDGV.Enabled = False
        btnEDIT.Enabled = False
        dgvUSER.Enabled = True
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_Clean()
        Function_TextFormat()
        dgvUSER_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON FOR DGVUSER ---------------------------------'
    Private Sub btnCANCELDGV_Click(sender As Object, e As EventArgs) Handles btnCANCELDGV.Click
        btnEDIT.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnCANCELDGV.Visible = False
        btnCANCELDGV.Enabled = False
        Function_Clean()
        btnCANCELDGV.Enabled = False
        dgvUSER.Enabled = True
        btnEDIT.Enabled = True

        Function_Disabled()
        Function_DisabledPanel()

        btnSAVE.Visible = False
        btnCANCEL.Visible = True
        btnCANCEL.Enabled = True
        btnCANCELDGV.Enabled = False

        btnUPDATE.Visible = True
        btnUPDATE.Enabled = False
    End Sub


    '---------------------------------- SEARCH FUNCTION AND ITS EVENTS ----------------------------------'
    Private Sub txtSEARCH_Enter(sender As Object, e As EventArgs) Handles txtSEARCH.Enter
        If txtSEARCH.Text = "Search user" Then
            txtSEARCH.Text = ""
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCH_Leave(sender As Object, e As EventArgs) Handles txtSEARCH.Leave
        If txtSEARCH.Text = "" Then
            txtSEARCH.Text = "Search user"
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        TbluserBindingSource.Filter = "Username like '%" & txtSEARCH.Text & "%' "

        If txtSEARCH.Text = "Search user" Then
            TbluserBindingSource.RemoveFilter()
        ElseIf txtSEARCH.Text = "" Then
            TbluserBindingSource.Filter = "Username like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub


    '---------------------------------- TXT AND CBO EVENTS ON FOCUS ---------------------------------'
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

    Private Sub txtPASS_Enter(sender As Object, e As EventArgs) Handles txtPASS.Enter
        If txtPASS.Text = "Password" Then
            txtPASS.Text = ""
            txtPASS.ForeColor = ColorTranslator.FromHtml("#204AFF")
            txtPASS.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPASS_Leave(sender As Object, e As EventArgs) Handles txtPASS.Leave
        If txtPASS.Text = "" Then
            txtPASS.Text = "Password"
            txtPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
            txtPASS.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtCPASS_Enter(sender As Object, e As EventArgs) Handles txtCPASS.Enter
        If txtCPASS.Text = "Confirm Password" Then
            txtCPASS.Text = ""
            txtCPASS.ForeColor = ColorTranslator.FromHtml("#204AFF")
            txtCPASS.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtCPASS_Leave(sender As Object, e As EventArgs) Handles txtCPASS.Leave
        If txtCPASS.Text = "" Then
            txtCPASS.Text = "Confirm Password"
            txtCPASS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
            txtCPASS.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtLNAME_Enter(sender As Object, e As EventArgs) Handles txtLNAME.Enter
        If txtLNAME.Text = "Login Name" Then
            txtLNAME.Text = ""
            txtLNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtLNAME_Leave(sender As Object, e As EventArgs) Handles txtLNAME.Leave
        If txtLNAME.Text = "" Then
            txtLNAME.Text = "Login Name"
            txtLNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub cboUTYPE_Enter(sender As Object, e As EventArgs) Handles cboUTYPE.Enter
        If cboUTYPE.Text = "User Type" Then
            cboUTYPE.Text = ""
            cboUTYPE.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub cboUTYPE_Leave(sender As Object, e As EventArgs) Handles cboUTYPE.Leave
        If cboUTYPE.Text = "" Then
            cboUTYPE.Text = "User Type"
            cboUTYPE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub cboSTATUS_Enter(sender As Object, e As EventArgs) Handles cboSTATUS.Enter
        If cboSTATUS.Text = "Status" Then
            cboSTATUS.Text = ""
            cboSTATUS.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub cboSTATUS_Leave(sender As Object, e As EventArgs) Handles cboSTATUS.Leave
        If cboSTATUS.Text = "" Then
            cboSTATUS.Text = "Status"
            cboSTATUS.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub


    '---------------------------------- MOVE CURSOR USING ARROW KEYS ----------------------------------'
    Private Sub txtUSER_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUSER.KeyDown
        If e.KeyCode = Keys.Down Then
            txtPASS.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtPASS.Focus()
        End If
    End Sub

    Private Sub txtPASS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPASS.KeyDown
        If e.KeyCode = Keys.Up Then
            txtUSER.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txtCPASS.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtCPASS.Focus()
        End If
    End Sub

    Private Sub txtCPASS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPASS.KeyDown
        If e.KeyCode = Keys.Up Then
            txtPASS.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txtLNAME.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtLNAME.Focus()
        End If
    End Sub

    Private Sub txtLNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLNAME.KeyDown
        If e.KeyCode = Keys.Up Then
            txtCPASS.Focus()
        End If
    End Sub
End Class
