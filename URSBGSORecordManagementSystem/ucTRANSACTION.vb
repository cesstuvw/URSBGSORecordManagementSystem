Public Class ucTRANSACTION
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

    Private Sub Function_Disabled()
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        txtNO.Enabled = False
        txtID.Enabled = False
        txtFULLNAME.Enabled = False
        txtTYPE.Enabled = False
        txtITCODE.Enabled = False
        txtITNAME.Enabled = False
        txtCAT.Enabled = False
        txtQUAN.Enabled = False
    End Sub

    Private Sub Function_DisplayBorrower()
        lblID.Hide()
        lblFULL.Hide()
        lblTYPE.Hide()
    End Sub

    Private Sub Function_DontDisplayBorrower()
        lblID.Show()
        lblFULL.Show()
        lblTYPE.Show()
    End Sub


    Private Sub Function_DisplayItem()
        lblCODE.Hide()
        lblNAME.Hide()
        lblQUAN.Hide()
        lblCAT.Hide()
        'lblNO.Hide()
        lblSTOCK.Hide()
    End Sub

    Private Sub Function_DontDisplayItem()
        lblCODE.Show()
        lblNAME.Show()
        lblQUAN.Show()
        lblCAT.Show()
        'lblNO.Show()
        lblSTOCK.Show()
    End Sub

    Private Sub Function_TextFormat()
        txtNO.Text = "Transaction No."
        txtID.Text = "Borrower ID"
        txtFULLNAME.Text = "Full Name"
        txtTYPE.Text = "Borrower Type"
        txtITNAME.Text = "Item Name"
        txtITCODE.Text = "Item Code"
        txtCAT.Text = "Item Category"
        txtQUAN.Text = "Quantity"
        txtSTOCK.Text = "Available Stock"

        txtNO.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtID.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtFULLNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtTYPE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITCODE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtCAT.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtQUAN.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtSTOCK.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub

    Private Sub Function_DisabledPanel()
        pnlNO.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlID.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlFULL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlTYPE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlNAME.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlCAT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlQUAN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlSTOCK.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub dgvITEMCART_Refresh()
        Me.Tbl_itemcartTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_itemcart)
    End Sub

    Private Sub dgvITEM_Refresh()
        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_transaction"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(TransNo) from tbl_transaction"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtNO.Text = getno + 1
        Else
            txtNO.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub ucTRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnITEM.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnREMOVE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnADD.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Me.Tbl_itemcartTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_itemcart)

        If dgvTRANSAC.Rows.Count <> 0 Then

            btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
            btnSAVE.Enabled = True
        ElseIf dgvTRANSAC.Rows.Count = 0 Then
            btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
            btnSAVE.Enabled = False
        End If
    End Sub


    '---------------------------------- ADD BORROWER BUTTON ---------------------------------'
    Private Sub btnBORROWER_Click(sender As Object, e As EventArgs) Handles btnBORROWER.Click
        btnCANCEL.BackColor = Color.White
        btnITEM.BackColor = Color.White
        lblNO.Hide()
        Getmax()
        pnlBG.Visible = True
        dgvPROFILE.Visible = True
        txtSEARCHPROF.Visible = True
        txtSEARCHITEM.Visible = False
        dgvITEM.Visible = False

        Me.Tbl_profileTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_profile)
        btnITEM.Enabled = True
        btnCANCEL.Enabled = True

        If dgvTRANSAC.Rows.Count <> 0 Then

            btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
            btnSAVE.Enabled = True
        ElseIf dgvTRANSAC.Rows.Count = 0 Then
            btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
            btnSAVE.Enabled = False
        End If
    End Sub


    '---------------------------------- ADD ITEM BUTTON ---------------------------------'
    Private Sub btnITEM_Click(sender As Object, e As EventArgs) Handles btnITEM.Click
        'btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        txtQUAN.BackColor = Color.White
        btnADD.BackColor = ColorTranslator.FromHtml("#204aff")
        lblQUAN.Hide()
        pnlQUAN.BackColor = Color.White
        pnlBG.Visible = True
        dgvPROFILE.Visible = False
        txtSEARCHPROF.Visible = False
        dgvITEM.Visible = True
        txtSEARCHITEM.Visible = True
        txtQUAN.Enabled = True

        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)

        btnSAVE.Enabled = False
        btnCANCEL.Enabled = True
        txtQUAN.Focus()
        btnADD.Enabled = True

        If dgvTRANSAC.Rows.Count <> 0 Then

            btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
            btnSAVE.Enabled = True
        ElseIf dgvTRANSAC.Rows.Count = 0 Then
            btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
            btnSAVE.Enabled = False
        End If
    End Sub


    '---------------------------------- ADD TRANSACTION BUTTON ---------------------------------'
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        If txtITNAME.Text <> txtCOITNAME.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_itemcart where ItemName = '" & txtITNAME.Text & "' "
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                MsgBox("Sorry, you have a same Item on your cart", vbOKOnly + vbCritical, "Error Add Item")
                con.Close()
                lblCODE.Show()
                lblNAME.Show()
                lblCAT.Show()
                lblSTOCK.Show()
                lblQUAN.Show()
                txtQUAN.Enabled = False
                pnlQUAN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
                Function_DontDisplayItem()
                btnADD.Enabled = False
                btnADD.BackColor = ColorTranslator.FromHtml("#AEBAEC")
                Exit Sub
            End If
            con.Close()
        End If


        If txtSTOCK.Text = "0" Then
            MsgBox("No stock available", vbOKOnly + vbCritical, "Transaction failed!")
            Function_DontDisplayItem()
            Function_DisabledPanel()
            txtQUAN.Text = "Quantity"
            txtQUAN.Enabled = False
            pnlQUAN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
            Exit Sub
        End If

        If Val(txtSTOCK.Text) < Val(txtQUAN.Text) Then
            MsgBox("This item is not enough for borrowing or it's out of stock", vbOKOnly + vbCritical, "Transaction failed!")
            Function_DontDisplayItem()
            Function_DisabledPanel()
            txtQUAN.Text = "Quantity"
            txtQUAN.Enabled = False
            pnlQUAN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
            Exit Sub
        End If

        If txtQUAN.Text = "0" Then
            MsgBox("Please input a quantity that is greater than zero", vbOKOnly + vbCritical, "Transaction failed!")
            txtQUAN.Focus()
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "insert into tbl_itemcart (TransNo, BorrowersID, BorrowersName, BorrowersType, Itemcode, Itemname, Quantity, DateBorrowed) values (@transno, @bid, @fulln, @btype, @itemc, @itemn, @qty, @dateb)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("transno", txtNO.Text)
        cmd.Parameters.AddWithValue("bid", txtID.Text)
        cmd.Parameters.AddWithValue("fulln", txtFULLNAME.Text)
        cmd.Parameters.AddWithValue("btype", txtTYPE.Text)
        cmd.Parameters.AddWithValue("itemc", txtITCODE.Text)
        cmd.Parameters.AddWithValue("itemn", txtITNAME.Text)
        cmd.Parameters.AddWithValue("qty", txtQUAN.Text)
        cmd.Parameters.AddWithValue("dateb", Format(Date.Now, "yyyy/MM/dd"))
        cmd.ExecuteNonQuery()
        con.Close()

        btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
        btnITEM.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlQUAN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnADD.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        lblNO.Show()
        lblCODE.Show()
        lblNAME.Show()
        lblCAT.Show()
        lblSTOCK.Show()
        lblQUAN.Show()
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = False

        Function_DisabledPanel()
        btnITEM.Enabled = False
        btnADD.Enabled = False
        Function_DontDisplayItem()
        Function_DontDisplayBorrower()
        Function_TextFormat()
        dgvITEMCART_Refresh()
        Function_TextFormat()

        If dgvTRANSAC.Rows.Count <> 0 Then

            btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
            btnSAVE.Enabled = True
        ElseIf dgvTRANSAC.Rows.Count = 0 Then
            btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
            btnSAVE.Enabled = False
        End If
    End Sub


    '---------------------------------- SAVE TRANSACTION BUTTON ---------------------------------'
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Dim i As Integer
        For i = 0 To dgvTRANSAC.Rows.Count - 1
            OpenCon()
            cmd.CommandText = "insert into tbl_transaction (TransNo, BorrowersID, BorrowersName, BorrowersType, Itemcode, Itemname, Quantity, DateBorrowed) values (@tno, @bid, @fulln, @btype, @itemc, @itemn, @qty, @dborrow)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("tno", dgvTRANSAC.Rows(i).Cells(0).Value.ToString)
            cmd.Parameters.AddWithValue("bid", dgvTRANSAC.Rows(i).Cells(1).Value.ToString)
            cmd.Parameters.AddWithValue("fulln", dgvTRANSAC.Rows(i).Cells(2).Value.ToString)
            cmd.Parameters.AddWithValue("btype", dgvTRANSAC.Rows(i).Cells(3).Value.ToString)
            cmd.Parameters.AddWithValue("itemc", dgvTRANSAC.Rows(i).Cells(4).Value.ToString)
            cmd.Parameters.AddWithValue("itemn", dgvTRANSAC.Rows(i).Cells(5).Value.ToString)
            cmd.Parameters.AddWithValue("qty", dgvTRANSAC.Rows(i).Cells(6).Value.ToString)
            cmd.Parameters.AddWithValue("dborrow", dgvTRANSAC.Rows(i).Cells(7).Value.ToString)
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        Dim updateqty As Integer
        For i = 0 To dgvTRANSAC.Rows.Count - 1
            OpenCon()
            cmd.CommandText = "Select * from tbl_item where Itemcode = '" & dgvTRANSAC.Rows(i).Cells(4).Value.ToString & "' "
            dr = cmd.ExecuteReader
            While dr.Read
                updateqty = dr.Item("availablestock") - dgvTRANSAC.Rows(i).Cells(6).Value.ToString
            End While
            con.Close()

            OpenCon()
            cmd.CommandText = "update tbl_item set availablestock = @availstk where Itemcode = @itc"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("availstk", updateqty)
            cmd.Parameters.AddWithValue("itc", dgvTRANSAC.Rows(i).Cells(4).Value.ToString)
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        MsgBox("Transaction has been Recorded ", vbOKOnly + vbInformation, "Transaction Recorded")
        activity = "Made a transaction. Item: " + txtITNAME.Text + "|" + "Quantity:" + txtQUAN.Text
        actlog()
        OpenCon()
        cmd.CommandText = "delete from tbl_itemcart"
        cmd.ExecuteNonQuery()
        con.Close()
        dgvITEMCART_Refresh()
        dgvITEM_Refresh()
        btnSAVE.Enabled = False
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        txtQUAN.Enabled = False
        lblQUAN.Show()
        pnlQUAN.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.Enabled = False
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub


    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        lblNO.Show()
        btnCANCEL.Enabled = False
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnADD.Enabled = False
        btnSAVE.Enabled = False
        txtID.Text = "Borrower ID"
        Function_TextFormat()
        dgvPROFILE.Enabled = True
        Function_Disabled()
        Function_DisabledPanel()
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnADD.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        txtID.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        Function_TextFormat()
        Function_DontDisplayBorrower()
        Function_DontDisplayItem()
        btnITEM.Enabled = False
        btnITEM.BackColor = ColorTranslator.FromHtml("#f0f0f0")

        If dgvTRANSAC.Rows.Count <> 0 Then

            btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
            btnSAVE.Enabled = True
        ElseIf dgvTRANSAC.Rows.Count = 0 Then
            btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
            btnSAVE.Enabled = False
        End If
    End Sub


    '---------------------------------- DATA GRID VIEW ---------------------------------'
    Private Sub DGVPROFILE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPROFILE.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvPROFILE.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value
            txtFULLNAME.Text = row.Cells(1).Value.ToString + " " + row.Cells(2).Value.ToString + " " + row.Cells(3).Value.ToString
            txtTYPE.Text = row.Cells(4).Value
        End If
        pnlBG.Visible = False
        Function_DisplayBorrower()
    End Sub

    Private Sub DGVITEM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvITEM.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvITEM.Rows(e.RowIndex)
            txtITCODE.Text = row.Cells(0).Value
            txtITNAME.Text = row.Cells(1).Value
            txtCAT.Text = row.Cells(2).Value
            txtSTOCK.Text = row.Cells(3).Value
        End If
        Function_DisplayItem()
        pnlBG.Visible = False
        txtQUAN.Focus()
    End Sub

    Private Sub dgvTRANSAC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTRANSAC.CellClick
        btnREMOVE.Enabled = True
        btnREMOVE.BackColor = Color.White
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvTRANSAC.Rows(e.RowIndex)
            txtREMOVE.Text = row.Cells(5).Value
        End If
    End Sub

    'REMOVE BUTTON
    Private Sub btnREMOVE_Click(sender As Object, e As EventArgs) Handles btnREMOVE.Click
        Dim result
        result = MsgBox("Do you really want to remove this item?", vbYesNo + vbQuestion, "Transaction Removal")
        If result = DialogResult.Yes Then
            OpenCon()
            cmd.CommandText = "Delete from tbl_itemcart where ItemName = @item"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("item", txtREMOVE.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            btnREMOVE.Enabled = False
            btnREMOVE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
            dgvITEMCART_Refresh()
        End If

        If dgvTRANSAC.Rows.Count <> 0 Then

            btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
            btnSAVE.Enabled = True
        ElseIf dgvTRANSAC.Rows.Count = 0 Then
            btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
            btnSAVE.Enabled = False
        End If
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
        TblitemcartBindingSource.Filter = "ItemName like '%" & txtSEARCH.Text & "%' "

        If txtSEARCH.Text = "Search item" Then
            TblitemcartBindingSource.RemoveFilter()
        ElseIf txtSEARCH.Text = "" Then
            TblitemcartBindingSource.Filter = "ItemName like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub txtSEARCHITEM_Enter(sender As Object, e As EventArgs) Handles txtSEARCHITEM.Enter
        If txtSEARCHITEM.Text = "Search item" Then
            txtSEARCHITEM.Text = ""
            txtSEARCHITEM.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCHITEM_Leave(sender As Object, e As EventArgs) Handles txtSEARCHITEM.Leave
        If txtSEARCHITEM.Text = "" Then
            txtSEARCHITEM.Text = "Search item"
            txtSEARCHITEM.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCHITEM_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCHITEM.TextChanged
        TblitemBindingSource.Filter = "ItemName Like '%" & txtSEARCHITEM.Text & "%' "

        If txtSEARCHITEM.Text = "Search item" Then
            TblitemBindingSource.RemoveFilter()

        ElseIf txtSEARCHITEM.Text = "" Then
            TblitemBindingSource.Filter = "ItemName like '%" & txtSEARCHITEM.Text & "%' "
        End If
    End Sub

    Private Sub txtSEARCHPROF_Enter(sender As Object, e As EventArgs) Handles txtSEARCHPROF.Enter
        If txtSEARCHPROF.Text = "Search profile" Then
            txtSEARCHPROF.Text = ""
            txtSEARCHPROF.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCHPROF_Leave(sender As Object, e As EventArgs) Handles txtSEARCHPROF.Leave
        If txtSEARCHPROF.Text = "" Then
            txtSEARCHPROF.Text = "Search profile"
            txtSEARCHPROF.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCHPROF_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCHPROF.TextChanged
        TblprofileBindingSource.Filter = "Lname like '%" & txtSEARCHPROF.Text & "%' "

        If txtSEARCHPROF.Text = "Search profile" Then
            TblprofileBindingSource.RemoveFilter()
        ElseIf txtSEARCHPROF.Text = "" Then
            TblprofileBindingSource.Filter = "lname like '%" & txtSEARCHPROF.Text & "%' "
        End If
    End Sub
    '---------------------------------- TXT EVENTS ON FOCUS ---------------------------------'
    Private Sub txtQUAN_Enter(sender As Object, e As EventArgs) Handles txtQUAN.Enter
        If txtQUAN.Text = "Quantity" Then
            txtQUAN.Text = ""
            txtQUAN.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtQUAN_Leave(sender As Object, e As EventArgs) Handles txtQUAN.Leave
        If txtQUAN.Text = "" Then
            txtQUAN.Text = "Quantity"
            txtQUAN.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub TXTQUAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQUAN.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub pnlBG_Click(sender As Object, e As EventArgs) Handles pnlBG.Click
        pnlBG.Visible = False
    End Sub
End Class
