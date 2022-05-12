Public Class ucITEM
    Private Sub Function_Enabled()
        txtITEMCODE.Enabled = False
        txtITEMNAME.Enabled = True
        cboCATEGORY.Enabled = True
        txtAVAILABLE.Enabled = True
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
    End Sub

    Private Sub Function_Disabled()
        txtITEMCODE.Enabled = False
        txtITEMNAME.Enabled = False
        cboCATEGORY.Enabled = False
        txtAVAILABLE.Enabled = False
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
    End Sub

    Private Sub Function_Display()
        cboCATEGORY.Visible = True
        lblITEMCODE.Hide()
        lblITEMNAME.Hide()
        lblCATEGORY.Hide()
        lblSTOCK.Hide()
    End Sub

    Private Sub Function_DontDisplay()
        cboCATEGORY.Visible = False
        lblITEMCODE.Show()
        lblITEMNAME.Show()
        lblCATEGORY.Show()
        lblSTOCK.Show()
    End Sub

    Private Sub Function_TextFormat()
        cboCATEGORY.Text = "Item Category"
        txtAVAILABLE.Text = "Available Stock"
        cboCATEGORY.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtAVAILABLE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub

    Private Sub Function_DisabledPanel()
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlNAME.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlCATEGORY.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlAVAILABLE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub Function_EnabledPanel()
        'pnlCODE.BackColor = Color.White
        pnlNAME.BackColor = Color.White
        pnlCATEGORY.BackColor = Color.White
        pnlAVAILABLE.BackColor = Color.White
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

    Private Sub dgvITEM_Refresh()
        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_item"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(ItemCode) from tbl_item"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtITEMCODE.Text = getno + 1
        Else
            txtITEMCODE.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub ucITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCELDGV.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)

        'cboCATEGORY.Items.Add("Audio")
        'cboCATEGORY.Items.Add("Appliances")
        'cboCATEGORY.Items.Add("Furnitures & Decarations")
        'cboCATEGORY.Items.Add("Rooms/Venue")
        'cboCATEGORY.Items.Add("Cleaning Tools")
        'cboCATEGORY.Items.Add("Gardening Tools")
        'cboCATEGORY.Items.Add("Sports")

        OpenCon()
        cmd.CommandText = "Select * from tbl_category"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboCATEGORY.Items.Add(dr.Item("CategoryName"))
            End While
        End If
        con.Close()
    End Sub


    '---------------------------------- ADD A NEW ITEM BUTTON  ---------------------------------'
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Getmax()
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtAVAILABLE.ForeColor = ColorTranslator.FromHtml("#204AFF")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")

        btnCANCEL.BackColor = Color.White
        btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")

        Function_Enabled()
        Function_DisableClean()
        Function_EnabledPanel()
        Function_Display()
        Function_TextFormat()
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        btnEDIT.Enabled = False

        txtITEMNAME.Focus()
        txtITEMNAME.Text = ""
        If txtITEMNAME.Text = "" Then
            txtITEMNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If

        dgvITEM.Enabled = True
    End Sub

    '---------------------------------- SAVE BUTTON ---------------------------------'
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'ERROR TRAPPING
        If txtITEMCODE.Text = "Item Code" Or txtITEMNAME.Text = "Item Name" Or cboCATEGORY.Text = "Item Category" Or txtAVAILABLE.Text = "Available Stock" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            btnCANCEL.Enabled = True
            Exit Sub
        End If

        If txtITEMNAME.Text <> txtCOITNM.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_item where ItemName = '" & txtITEMNAME.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Item already exist!", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                btnCANCEL.Enabled = True
                txtITEMNAME.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        'Saving item
        OpenCon()
        cmd.CommandText = "insert into tbl_item values( @itemc,@itemn,@itemcat,@available)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("itemc", txtITEMCODE.Text)
        cmd.Parameters.AddWithValue("itemn", txtITEMNAME.Text)
        cmd.Parameters.AddWithValue("itemcat", cboCATEGORY.Text)
        cmd.Parameters.AddWithValue("available", txtAVAILABLE.Text)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Item has been Saved!", vbOKOnly + vbInformation, "Saving Successful")
        txtITEMCODE.Text = "Item Code"
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEDIT.Enabled = False
        dgvITEM.Enabled = True
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_Clean()
        Function_TextFormat()
        dgvITEM_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        btnEDIT.Enabled = True
        btnCANCEL.Enabled = False
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        dgvITEM.Enabled = True
        btnEDIT.Enabled = False
        Function_DontDisplay()
        Function_Disabled()
        Function_DisabledPanel()
        txtITEMCODE.Text = "Item Code"
        txtAVAILABLE.Text = "Available Stock"
        cboCATEGORY.Text = "Item Category"
        txtITEMNAME.Text = "Item Name"
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
    End Sub


    '---------------------------------- DATA GRID VIEW ---------------------------------'
    Private Sub dgvITEM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvITEM.CellClick
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
        'Function_Disabled()
        txtITEMCODE.Enabled = False
        txtITEMNAME.Enabled = False
        cboCATEGORY.Enabled = False
        txtAVAILABLE.Enabled = False

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvITEM.Rows(e.RowIndex)
            txtITEMCODE.Text = row.Cells(0).Value
            txtITEMNAME.Text = row.Cells(1).Value
            cboCATEGORY.Text = row.Cells(2).Value
            txtAVAILABLE.Text = row.Cells(3).Value
        End If

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
        btnUPDATE.Enabled = True
        btnSAVE.Visible = False
        btnCANCEL.Visible = False

        txtITEMCODE.Enabled = False
        txtITEMNAME.Enabled = True
        cboCATEGORY.Enabled = True
        txtAVAILABLE.Enabled = False

        cboCATEGORY.Enabled = True

        dgvITEM.Enabled = False

        Function_EnabledPanel()
        Function_Display()

        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlAVAILABLE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtITEMNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        cboCATEGORY.ForeColor = ColorTranslator.FromHtml("#204AFF")

        If btnEDIT.Enabled = True Then
            btnEDIT.BackColor = Color.White
        ElseIf btnEDIT.Enabled = False Then
            btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        End If
    End Sub

    '---------------------------------- UPDATE BUTTON ---------------------------------'
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        'Error trapping
        If txtITEMNAME.Text = "Item Name" Or cboCATEGORY.Text = "Item Category" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Updating")
            btnCANCELDGV.Enabled = True
            Exit Sub
        End If

        If txtITEMNAME.Text <> txtCOITNM.Text Then
            MsgBox("Item already exist!", vbOKOnly + vbCritical, "Error Saving")
            btnCANCELDGV.Enabled = True
            Exit Sub
        End If

        If txtITEMNAME.Text <> txtCOITNM.Text And cboCATEGORY.Text <> cboCOCAT.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_item where itemname = '" & txtITEMNAME.Text & "' and itemcategory = '" & cboCATEGORY.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("No changes have been made.", vbOKOnly + vbInformation, "Update")
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If

        OpenCon()
        cmd.CommandText = "Update tbl_item Set Itemcode = @itmcode, ItemName = @itmname, ItemCategory = @itmcat where Itemcode = @itmcode"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("itmcode", txtITEMCODE.Text)
        cmd.Parameters.AddWithValue("itmname", txtITEMNAME.Text)
        cmd.Parameters.AddWithValue("itmcat", cboCATEGORY.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated", vbOKOnly + vbInformation, "Successfully updated")


        txtITEMCODE.Text = "Item Code"
        txtAVAILABLE.Text = "Available Stock"
        cboCATEGORY.Text = "Item Category"
        txtITEMNAME.Text = "Item Name"

        btnUPDATE.Visible = False
        btnSAVE.Visible = True

        Function_Disabled()
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_Clean()
        Function_TextFormat()
        btnUPDATE.Enabled = False
        btnCANCELDGV.Enabled = False
        btnEDIT.Enabled = False
        dgvITEM.Enabled = True
        dgvITEM_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON FOR DGVUSER ---------------------------------'
    Private Sub btnCANCELDGV_Click(sender As Object, e As EventArgs) Handles btnCANCELDGV.Click
        btnEDIT.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnCANCELDGV.Visible = False
        btnCANCELDGV.Enabled = False
        Function_Clean()
        btnCANCELDGV.Enabled = False
        dgvITEM.Enabled = True
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
        If txtSEARCH.Text = "Search item" Then
            txtSEARCH.Text = ""
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCH_Leave(sender As Object, e As EventArgs) Handles txtSEARCH.Leave
        If txtSEARCH.Text = "" Then
            txtSEARCH.Text = "Search item"
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        TblitemBindingSource.Filter = "ItemName Like '%" & txtSEARCH.Text & "%' "

        If txtSEARCH.Text = "Search item" Then
            TblitemBindingSource.RemoveFilter()

        ElseIf txtSEARCH.Text = "" Then
            TblitemBindingSource.Filter = "ItemName like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub


    '---------------------------------- TXT AND CBO EVENTS ON FOCUS ---------------------------------'
    Private Sub txtITEMNAME_Enter(sender As Object, e As EventArgs) Handles txtITEMNAME.Enter
        If txtITEMNAME.Text = "Item Name" Then
            txtITEMNAME.Text = ""
            txtITEMNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtITEMNAME_Leave(sender As Object, e As EventArgs) Handles txtITEMNAME.Leave
        If txtITEMNAME.Text = "" Then
            txtITEMNAME.Text = "Item Name"
            txtITEMNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtAVAILABLE_Enter(sender As Object, e As EventArgs) Handles txtAVAILABLE.Enter
        If txtAVAILABLE.Text = "Available Stock" Then
            txtAVAILABLE.Text = ""
            txtAVAILABLE.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtAVAILABLE_Leave(sender As Object, e As EventArgs) Handles txtAVAILABLE.Leave
        If txtAVAILABLE.Text = "" Then
            txtAVAILABLE.Text = "Available Stock"
            txtAVAILABLE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub cbocategory_Enter(sender As Object, e As EventArgs) Handles cboCATEGORY.Enter
        If cboCATEGORY.Text = "Item Category" Then
            cboCATEGORY.Text = ""
            cboCATEGORY.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub cbocategory_Leave(sender As Object, e As EventArgs) Handles cboCATEGORY.Leave
        If cboCATEGORY.Text = "" Then
            cboCATEGORY.Text = "Item Category"
            cboCATEGORY.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtAVAILABLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAVAILABLE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
