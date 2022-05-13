Public Class ucITEMSTOCKS
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
        txtSTOCK.Enabled = False
        txtITEMCODE.Enabled = False
        txtITEMNAME.Enabled = False
        txtAVAILABLE.Enabled = False
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
    End Sub

    Private Sub Function_Display()
        lblADDED.Hide()
        lblITEMCODE.Hide()
        lblITEMNAME.Hide()
        lblSTOCK.Hide()
        lblSTOCKID.Hide()
    End Sub

    Private Sub Function_DontDisplay()
        lblADDED.Show()
        lblITEMCODE.Show()
        lblITEMNAME.Show()
        lblSTOCK.Show()
        lblSTOCKID.Show()
    End Sub

    Private Sub Function_TextFormat()
        txtSTOCK.Text = "Stock ID"
        txtITEMCODE.Text = "Item Code"
        txtITEMNAME.Text = "Item Name"
        txtADDEDSTOCK.Text = "No of Stock to be Added"
        txtAVAILABLE.Text = "Available Stock"
        txtSTOCK.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITEMNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITEMCODE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtAVAILABLE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub

    Private Sub Function_DisabledPanel()
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlNAME.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlADDED.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlSTOCKID.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlAVAILABLE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub Function_EnabledPanel()
        pnlCODE.BackColor = Color.White
        pnlNAME.BackColor = Color.White

        pnlSTOCKID.BackColor = Color.White
        pnlAVAILABLE.BackColor = Color.White
    End Sub

    Private Sub dgvITEMSTOCK_Refresh()
        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_itemstock"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(StockID) from tbl_itemstock"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtSTOCK.Text = getno + 1
        Else
            txtSTOCK.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub dgvITEM_Refresh()
        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)
    End Sub

    Private Sub ucITEMSTOCKS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Me.Tbl_itemTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_item)

        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
    End Sub

    '---------------------------------- DATA GRID VIEW ---------------------------------'
    Private Sub dgvITEM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvITEM.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvITEM.Rows(e.RowIndex)
            txtITEMCODE.Text = row.Cells(0).Value
            txtITEMNAME.Text = row.Cells(1).Value
            txtAVAILABLE.Text = row.Cells(3).Value
        End If

        Getmax()
        txtDATE.Text = Format(Date.Now, "yyyy-MM-dd")
        Function_Display()
        txtADDEDSTOCK.Enabled = True
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        pnlADDED.BackColor = Color.White
        btnSAVE.BackColor = ColorTranslator.FromHtml("#204AFF")
        btnCANCEL.BackColor = Color.White
        txtADDEDSTOCK.Focus()
    End Sub

    '---------------------------------- SAVE BUTTON ---------------------------------'
    'ERROR TRAPPING
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If txtADDEDSTOCK.Text = "No of Stock to be Added" Then
            MsgBox("Please put the number of stock to be added.", vbOKOnly + vbCritical, "Error Saving")
            txtADDEDSTOCK.Focus()
            Exit Sub
        End If

        If txtADDEDSTOCK.Text < 1 Then
            MsgBox("Invalid number of added stock!", vbOKOnly + vbCritical, "Error Saving")
            txtADDEDSTOCK.Focus()
        End If

        Dim qtyupdate As Integer
        qtyupdate = Val(txtAVAILABLE.Text) + Val(txtADDEDSTOCK.Text)
        OpenCon()
        cmd.CommandText = "update tbl_item set availablestock = @avails where itemcode = @icode"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("avails", qtyupdate)
        cmd.Parameters.AddWithValue("icode", txtITEMCODE.Text)
        cmd.ExecuteNonQuery()
        con.Close()


        'SAVING A NEW USER
        OpenCon()
        cmd.CommandText = "insert into tbl_itemstock values(@stkid, @itemc, @itemn, @addstk, @dateadd)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("stkid", txtSTOCK.Text)
        cmd.Parameters.AddWithValue("itemc", txtITEMCODE.Text)
        cmd.Parameters.AddWithValue("itemn", txtITEMNAME.Text)
        cmd.Parameters.AddWithValue("addstk", txtADDEDSTOCK.Text)
        cmd.Parameters.AddWithValue("dateadd", txtDATE.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Stock Added!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new stock for Item: " + txtITEMNAME.Text
        actlog()
        txtADDEDSTOCK.Enabled = False
        Function_TextFormat()
        Function_DontDisplay()
        Function_DisabledPanel()
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        dgvITEM_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        txtADDEDSTOCK.Enabled = False
        Function_TextFormat()
        Function_DontDisplay()
        Function_DisabledPanel()
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
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


    '---------------------------------- TXT EVENTS -----------------------------------'
    Private Sub txtADDEDSTOCK_Enter(sender As Object, e As EventArgs) Handles txtADDEDSTOCK.Enter
        If txtADDEDSTOCK.Text = "No of Stock to be Added" Then
            txtADDEDSTOCK.Text = ""
            txtADDEDSTOCK.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub TXTaddedstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtADDEDSTOCK.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub
End Class
