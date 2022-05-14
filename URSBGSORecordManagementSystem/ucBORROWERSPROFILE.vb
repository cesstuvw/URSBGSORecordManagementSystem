Public Class ucBORROWERSPROFILE
    Dim username As String = frmMAINMENU.lblUSERNAME.Text

    Private Sub actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_activity values (@un, @act, @dt)"
        With cmd.Parameters
            .Clear()

            .AddWithValue("un", username.Replace("@", ""))
            .AddWithValue("act", activity)
            .AddWithValue("dt", Date.Now())
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Function_Enabled()
        txtID.Enabled = True
        txtFNAME.Enabled = True
        txtMNAME.Enabled = True
        txtLNAME.Enabled = True
        cboTYPE.Enabled = True
        txtCONTACT.Enabled = True
    End Sub

    Private Sub Function_Disabled()
        txtID.Enabled = False
        txtFNAME.Enabled = False
        txtMNAME.Enabled = False
        txtLNAME.Enabled = False
        cboTYPE.Enabled = False
        txtCONTACT.Enabled = False
    End Sub

    Private Sub Function_Display()
        cboTYPE.Visible = True
        lblID.Hide()
        lblFN.Hide()
        lblMN.Hide()
        lblLN.Hide()
        lblTYPE.Hide()
        lblCONTACT.Hide()
    End Sub

    Private Sub Function_DontDisplay()
        cboTYPE.Visible = False
        lblID.Show()
        lblFN.Show()
        lblMN.Show()
        lblLN.Show()
        lblTYPE.Show()
        lblCONTACT.Show()
    End Sub

    Private Sub Function_TextFormat()
        'txtID.Text = "Borrower's ID"
        txtFNAME.Text = "First Name"
        txtMNAME.Text = "Middle Name"
        txtLNAME.Text = "Last Name"
        cboTYPE.Text = "Borrower Type"
        txtCONTACT.Text = "Contact No."

        'txtID.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtFNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtMNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtLNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        cboTYPE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtCONTACT.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub

    Private Sub Function_DisabledPanel()
        pnlID.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlFN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlMN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlLN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlTYPE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlCON.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub Function_EnabledPanel()
        pnlID.BackColor = Color.White
        pnlFN.BackColor = Color.White
        pnlMN.BackColor = Color.White
        pnlLN.BackColor = Color.White
        pnlTYPE.BackColor = Color.White
        pnlCON.BackColor = Color.White
    End Sub

    Private Sub Function_Clean()
        pnlCLEANUT.Visible = True
        pnlCLEANUT1.Visible = True
        pnlCLEANUT2.Visible = True
        pnlCLEANUT3.Visible = True
    End Sub

    Private Sub Function_DisableClean()
        pnlCLEANUT.Visible = False
        pnlCLEANUT1.Visible = False
        pnlCLEANUT2.Visible = False
        pnlCLEANUT3.Visible = False
    End Sub

    Private Sub dgvPROFILE_Refresh()
        Me.Tbl_profileTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_profile)
    End Sub

    Private Sub ucBORROWERSPROFILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCELDGV.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Me.Tbl_profileTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_profile)

        cboTYPE.Items.Add("Faculty")
        cboTYPE.Items.Add("Student")
    End Sub


    '---------------------------------- CREATE A NEW PROFILE  BUTTON ---------------------------------'
    Private Sub btnCREATE_Click(sender As Object, e As EventArgs) Handles btnCREATE.Click
        btnCANCEL.BackColor = Color.White
        btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        Function_DisableClean()

        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        Function_Enabled()
        txtID.Focus()
        txtID.Text = ""
        Function_EnabledPanel()
        Function_Display()
        Function_TextFormat()
        btnCANCELDGV.Visible = False
        btnCANCEL.Visible = True
        btnUPDATE.Visible = False
        btnEDIT.Enabled = False

        dgvPROFILE.Enabled = True

        If txtID.Text = "" Then
            txtID.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If

    End Sub


    '---------------------------------- SAVE BUTTON ---------------------------------'
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'ERROR TRAPPING
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        If txtID.Text = "Borrower ID" Or txtFNAME.Text = "First Name" Or txtLNAME.Text = "Last Name" Or cboTYPE.Text = "Borrower Type" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            btnCANCEL.Enabled = True
            Exit Sub
        End If

        If cboTYPE.Text <> "Faculty" And cboTYPE.Text <> "Student" Then
            MsgBox("Unknown borrower type!", vbOKOnly + vbCritical, "Error Saving")
            cboTYPE.Focus()
            Exit Sub
        End If

        If txtCONTACT.Text.Length < 11 Then
            MsgBox("Invalid contact number!", vbOKOnly + vbCritical, "Error Saving")
            txtCONTACT.Focus()
            Exit Sub
        End If

        If txtID.Text <> txtCOCON.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_profile where borrowersid = '" & txtID.Text & "' "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Sorry, borrower ID already exists.", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                txtID.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        If txtMNAME.Text = "Middle Name" Then
            txtMNAME.Text = ""
        End If

        'SAVING A NEW USER
        OpenCon()
        cmd.CommandText = "insert into tbl_profile values( @id, @fn, @mn, @ln, @ty, @cn)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txtID.Text)
        cmd.Parameters.AddWithValue("fn", txtFNAME.Text)
        cmd.Parameters.AddWithValue("mn", txtMNAME.Text)
        cmd.Parameters.AddWithValue("ln", txtLNAME.Text)
        cmd.Parameters.AddWithValue("ty", cboTYPE.Text)
        cmd.Parameters.AddWithValue("cn", txtCONTACT.Text)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Profile has been Saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added a new profile. Name: " + txtLNAME.Text + "," + txtFNAME.Text + txtMNAME.Text
        actlog()
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCELDGV.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtID.Text = "Borrower ID"
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEDIT.Enabled = False
        dgvPROFILE.Enabled = True
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_Clean()
        Function_TextFormat()
        dgvPROFILE_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.Enabled = False
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        btnSAVE.Enabled = False
        txtID.Text = "Borrower ID"
        Function_TextFormat()
        dgvPROFILE.Enabled = True
        btnEDIT.Enabled = False
        Function_DontDisplay()
        Function_Disabled()
        Function_DisabledPanel()
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        txtID.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub


    '---------------------------------- DATA GRID VIEW ---------------------------------'
    Private Sub dgvPROFILE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPROFILE.CellClick
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

        btnSAVE.Enabled = False
        Function_Disabled()
        btnCANCELDGV.Enabled = False
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvPROFILE.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value
            txtFNAME.Text = row.Cells(1).Value
            txtMNAME.Text = row.Cells(2).Value
            txtLNAME.Text = row.Cells(3).Value
            cboTYPE.Text = row.Cells(4).Value
            txtCONTACT.Text = row.Cells(5).Value
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

        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnEDIT.BackColor = Color.White
        btnCANCELDGV.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#204aff")

        Function_DisableClean()

        btnEDIT.Enabled = False
        'btnSAVE.Enabled = True
        'btnSAVE.Text = "Update Account"
        btnUPDATE.Enabled = True
        btnSAVE.Visible = False
        btnCANCEL.Visible = False


        txtID.Enabled = False
        txtFNAME.Enabled = True
        txtMNAME.Enabled = True
        txtLNAME.Enabled = True
        cboTYPE.Enabled = True
        txtCONTACT.Enabled = True

        dgvPROFILE.Enabled = False

        Function_EnabledPanel()
        Function_Display()

        pnlID.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtFNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        txtMNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        txtLNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        cboTYPE.ForeColor = ColorTranslator.FromHtml("#204AFF")
        txtCONTACT.ForeColor = ColorTranslator.FromHtml("#204AFF")

        If btnEDIT.Enabled = True Then
            btnEDIT.BackColor = Color.White
        ElseIf btnEDIT.Enabled = False Then
            btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        End If
    End Sub


    '---------------------------------- UPDATE BUTTON ---------------------------------'
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        If txtFNAME.Text <> txtCOFN.Text And txtLNAME.Text <> txtCOLN.Text And txtMNAME.Text <> txtCOMN.Text And cboTYPE.Text <> cboCOTY.Text And txtCONTACT.Text <> txtCOCON.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_profile where fname = '" & txtFNAME.Text & "' and mname = '" & txtMNAME.Text & "' and lname = '" & txtLNAME.Text & "' and contactno = '" & txtCONTACT.Text & "' and borrowerstype = '" & cboTYPE.Text & "' "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("No changes have been made.", vbOKOnly + vbInformation, "Update")
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If

        'Error Trapping
        If txtFNAME.Text = "First Name" Or txtLNAME.Text = "Last Name" Or cboTYPE.Text = "Borrower Type" Or txtCONTACT.Text = "Contact No." Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Updating")
            Exit Sub
        End If

        If cboTYPE.Text <> "Faculty" And cboTYPE.Text <> "Student" Then
            MsgBox("Unknown user type!", vbOKOnly + vbCritical, "Error Updating")
            cboTYPE.Focus()
            Exit Sub
        End If

        If txtMNAME.Text = "Middle Name" Then
            txtMNAME.Text = ""
        End If

        OpenCon()
        cmd.CommandText = "Update tbl_profile set borrowersid = @id, fname = @fn, mname = @mn, lname = @ln, borrowerstype = @ty, contactno = @cn where borrowersid = @id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txtID.Text)
        cmd.Parameters.AddWithValue("fn", txtFNAME.Text)
        cmd.Parameters.AddWithValue("mn", txtMNAME.Text)
        cmd.Parameters.AddWithValue("ln", txtLNAME.Text)
        cmd.Parameters.AddWithValue("ty", cboTYPE.Text)
        cmd.Parameters.AddWithValue("cn", txtCONTACT.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated", vbOKOnly + vbInformation, "Successfully updated")
        activity = "Updated an existing profile. Name: " + txtLNAME.Text + "," + " " + txtFNAME.Text + " " + txtMNAME.Text
        actlog()
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCELDGV.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtID.Text = "Borrower ID"
        btnUPDATE.Enabled = False
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        btnCANCELDGV.Enabled = False
        btnEDIT.Enabled = False
        dgvPROFILE.Enabled = True
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_Clean()
        Function_TextFormat()
        dgvPROFILE_Refresh()
    End Sub

    '---------------------------------- CANCEL BUTTON FOR DGVUSER ---------------------------------'
    Private Sub btnCANCELDGV_Click(sender As Object, e As EventArgs) Handles btnCANCELDGV.Click
        btnEDIT.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        btnCANCELDGV.Visible = False
        btnCANCELDGV.Enabled = False
        Function_Clean()
        btnCANCELDGV.Enabled = False
        dgvPROFILE.Enabled = True
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
        If txtSEARCH.Text = "Search profile" Then
            txtSEARCH.Text = ""
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCH_Leave(sender As Object, e As EventArgs) Handles txtSEARCH.Leave
        If txtSEARCH.Text = "" Then
            txtSEARCH.Text = "Search profile"
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        TblprofileBindingSource.Filter = "Lname like '%" & txtSEARCH.Text & "%' "

        If txtSEARCH.Text = "Search profile" Then
            TblprofileBindingSource.RemoveFilter()
        ElseIf txtSEARCH.Text = "" Then
            TblprofileBindingSource.Filter = "lname like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub


    '---------------------------------- TXT AND CBO EVENTS ON FOCUS ---------------------------------'
    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter
        If txtID.Text = "Borrower ID" Then
            txtID.Text = ""
            txtID.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        If txtID.Text = "" Then
            txtID.Text = "Borrower ID"
            txtID.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtFNAME_Enter(sender As Object, e As EventArgs) Handles txtFNAME.Enter
        If txtFNAME.Text = "First Name" Then
            txtFNAME.Text = ""
            txtFNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtFNAME_Leave(sender As Object, e As EventArgs) Handles txtFNAME.Leave
        If txtFNAME.Text = "" Then
            txtFNAME.Text = "First Name"
            txtFNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtMNAME_Enter(sender As Object, e As EventArgs) Handles txtMNAME.Enter
        If txtMNAME.Text = "Middle Name" Then
            txtMNAME.Text = ""
            txtMNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtMNAME_Leave(sender As Object, e As EventArgs) Handles txtMNAME.Leave
        If txtMNAME.Text = "" Then
            txtMNAME.Text = "Middle Name"
            txtMNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtLNAME_Enter(sender As Object, e As EventArgs) Handles txtLNAME.Enter
        If txtLNAME.Text = "Last Name" Then
            txtLNAME.Text = ""
            txtLNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtLNAME_Leave(sender As Object, e As EventArgs) Handles txtLNAME.Leave
        If txtLNAME.Text = "" Then
            txtLNAME.Text = "Last Name"
            txtLNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub cboTYPE_Enter(sender As Object, e As EventArgs) Handles cboTYPE.Enter
        If cboTYPE.Text = "Borrower Type" Then
            cboTYPE.Text = ""
            cboTYPE.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub cboTYPE_Leave(sender As Object, e As EventArgs) Handles cboTYPE.Leave
        If cboTYPE.Text = "" Then
            cboTYPE.Text = "Borrower Type"
            cboTYPE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtCONTACT_Enter(sender As Object, e As EventArgs) Handles txtCONTACT.Enter
        If txtCONTACT.Text = "Contact No." Then
            txtCONTACT.Text = ""
            txtCONTACT.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtCONTACT_Leave(sender As Object, e As EventArgs) Handles txtCONTACT.Leave
        If txtCONTACT.Text = "" Then
            txtCONTACT.Text = "Contact No."
            txtCONTACT.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtCONTACT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCONTACT.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    '---------------------------------- MOVE CURSOR USING ARROW KEYS ----------------------------------'
    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Down Then
            txtFNAME.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtFNAME.Focus()
        End If
    End Sub

    Private Sub txtFNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFNAME.KeyDown
        If e.KeyCode = Keys.Up Then
            txtID.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txtMNAME.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtMNAME.Focus()
        End If
    End Sub

    Private Sub txtMNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMNAME.KeyDown
        If e.KeyCode = Keys.Up Then
            txtFNAME.Focus()
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
            txtMNAME.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txtCONTACT.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            txtCONTACT.Focus()
        End If
    End Sub

    Private Sub txtCONTACT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCONTACT.KeyDown
        If e.KeyCode = Keys.Up Then
            txtLNAME.Focus()
        End If
    End Sub

End Class
