Public Class ucRETURNING
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
        btnSAVE.Enabled = True
        btnCANCEL.Enabled = True
        txtNO.Enabled = True
        txtRNO.Enabled = True
        txtFULLNAME.Enabled = True
        txtTYPE.Enabled = True
        txtITCODE.Enabled = True
        txtITNAME.Enabled = True
        txtQUAN.Enabled = True
        txtDATE.Enabled = True

    End Sub

    Private Sub Function_Disabled()
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        txtNO.Enabled = False
        txtRNO.Enabled = False
        txtFULLNAME.Enabled = False
        txtTYPE.Enabled = False
        txtITCODE.Enabled = False
        txtITNAME.Enabled = False
        txtQUAN.Enabled = False
        txtDATE.Enabled = False
    End Sub

    Private Sub Function_DisplayUser()
        lblTRANSAC.Hide()
        lblRETURN.Hide()
        lblFULL.Hide()
        lblQUAN.Hide()
        lblFULL.Hide()
        lblTYPE.Hide()
        lblDATE.Hide()
        lblNO.Hide()
    End Sub

    Private Sub Function_DontDisplayUser()
        lblTRANSAC.Show()
        lblRETURN.Show()
        lblFULL.Show()
        lblQUAN.Show()
        lblFULL.Show()
        lblTYPE.Show()
        lblDATE.Show()
        lblNO.Show()
    End Sub

    Private Sub Function_DontDisplayTans()
        lblTRANSAC.Hide()
        lblRETURN.Hide()
        lblFULL.Hide()
        lblQUAN.Hide()
        lblFULL.Hide()
        lblDATE.Hide()
        lblNO.Hide()
    End Sub

    Private Sub Function_DontDisplayItem()
        lblCODE.Show()
        lblNAME.Show()
        lblQUAN.Show()
        'lblNO.Show()
    End Sub

    Private Sub Function_TextFormat()

        txtNO.Text = "Transaction No."
        txtRNO.Text = "Borrower ID"
        txtFULLNAME.Text = "Full Name"
        txtTYPE.Text = "Borrower Type"
        txtITNAME.Text = "Item Name"
        txtITCODE.Text = "Item Code"
        txtQUAN.Text = "Quantity"
        txtDATE.Text = "Date Borrowed"

        txtNO.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtFULLNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtTYPE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITCODE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtITNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtQUAN.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        txtDATE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub

    Private Sub Function_DisabledPanel()
        pnlNO.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlFULL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlNAME.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    'Private Sub Function_EnabledPanel()
    '    pnlNO.BackColor = Color.White
    '    pnlID.BackColor = Color.White
    '    pnlFULL.BackColor = Color.White
    '    pnlTYPE.BackColor = Color.White
    '    pnlCODE.BackColor = Color.White
    '    pnlNAME.BackColor = Color.White
    '    lblQUAN.BackColor = Color.White
    '    pnlSTOCK.BackColor = Color.White

    'End Sub

    Private Sub dgvRETURN_Refresh()
        Me.Tbl_returnTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_return)
    End Sub

    Private Sub dgvTRANSAC_Refresh()
        Me.Tbl_transactionTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_transaction)
    End Sub


    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_return"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(ReturnNo) from tbl_return"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtRNO.Text = getno + 1
        Else
            txtRNO.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub ucRETURNING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")


        Me.Tbl_returnTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_return)
    End Sub

    '---------------------------------- SELECT USER BUTTON ---------------------------------'
    Private Sub btnSEL_Click(sender As Object, e As EventArgs) Handles btnSEL.Click
        btnCANCEL.BackColor = Color.White
        btnITEM.BackColor = Color.White
        lblNO.Hide()
        Getmax()
        pnlITEM.Visible = True

        Me.Tbl_transactionTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_transaction)
        btnITEM.Enabled = True
        btnCANCEL.Enabled = True
    End Sub

    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        lblNO.Show()
        btnCANCEL.Enabled = False
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.Enabled = False
        Function_TextFormat()
        Function_Disabled()
        Function_DisabledPanel()
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Function_TextFormat()
        Function_DontDisplayUser()
        Function_DontDisplayItem()
        btnITEM.Enabled = False
        btnITEM.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If txtRNO.Text = "Return No." Or txtNO.Text = "Transaction No." Or txtFULLNAME.Text = "Full Name" Or txtITCODE.Text = "Item Code" Or txtITNAME.Text = "Item Name" Or txtQUAN.Text = "Quantity" Or txtDATE.Text = "Date Borrowed" Then
            MsgBox("Please select a transaction", vbOKOnly + vbCritical, "Error saving")
            Exit Sub
        End If

        Dim updateqty = ""
        OpenCon()
        cmd.CommandText = "Select * from tbl_item where Itemcode = '" & txtITCODE.Text & "' "
        dr = cmd.ExecuteReader
        While dr.Read
            updateqty = dr.Item("availablestock") + Val(txtQUAN.Text)
        End While
        con.Close()

        OpenCon()
        cmd.CommandText = "update tbl_item set availablestock = @availstk where Itemcode = @itc"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("availstk", updateqty)
        cmd.Parameters.AddWithValue("itc", txtITCODE.Text)
        cmd.ExecuteNonQuery()
        con.Close()


        OpenCon()
        cmd.CommandText = "insert into tbl_return values(@rno, @tno, @fulln, @btype, @itemc, @itemn, @qty, @bdate, @rdate)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("rno", txtRNO.Text)
        cmd.Parameters.AddWithValue("tno", txtNO.Text)
        cmd.Parameters.AddWithValue("fulln", txtFULLNAME.Text)
        cmd.Parameters.AddWithValue("btype", txtTYPE.Text)
        cmd.Parameters.AddWithValue("itemc", txtITCODE.Text)
        cmd.Parameters.AddWithValue("itemn", txtITNAME.Text)
        cmd.Parameters.AddWithValue("qty", txtQUAN.Text)
        cmd.Parameters.AddWithValue("bdate", txtDATE.Text)
        cmd.Parameters.AddWithValue("rdate", Format(Date.Now, "yyyy-MM-dd"))
        cmd.ExecuteNonQuery()
        con.Close()


        OpenCon()
        cmd.CommandText = "Delete from tbl_transaction where TransNo = @transno and itemname = @itemname"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("transno", txtNO.Text)
        cmd.Parameters.AddWithValue("itemname", txtITNAME.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        dgvTRANSAC_Refresh()


        MsgBox("Returned successfully", vbOKOnly + vbInformation, "Transaction Recorded")
        activity = "Returned an item. Item: " + txtITNAME.Text + "|" + "Quantity:" + txtQUAN.Text
        actlog()
        Function_TextFormat()
        btnSEL.Enabled = True
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        Function_DontDisplayUser()
        Function_DontDisplayItem()
        dgvRETURN_Refresh()
        dgvTRANSAC_Refresh()
    End Sub


    '---------------------------------- SEARCH FUNCTION AND ITS EVENTS ----------------------------------'

    Private Sub txtSEARCH_Enter(sender As Object, e As EventArgs) Handles txtSEARCH.Enter, txtREMOVE.Enter
        If txtSEARCH.Text = "Search name" Then
            txtSEARCH.Text = ""
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCH_Leave(sender As Object, e As EventArgs) Handles txtSEARCH.Leave, txtREMOVE.Leave
        If txtSEARCH.Text = "" Then
            txtSEARCH.Text = "Search name"
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        TblreturnBindingSource.Filter = "BorrowersName like '%" & txtSEARCH.Text & "%' "

        If txtSEARCH.Text = "Search name" Then
            TblreturnBindingSource.RemoveFilter()
        ElseIf txtSEARCH.Text = "" Then
            TblreturnBindingSource.Filter = "BorrowersName like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub txtSEARCHNAME_Enter(sender As Object, e As EventArgs) Handles txtSEARCHNAME.Enter
        If txtSEARCHNAME.Text = "Search name" Then
            txtSEARCHNAME.Text = ""
            txtSEARCHNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCHNAME_Leave(sender As Object, e As EventArgs) Handles txtSEARCHNAME.Leave
        If txtSEARCHNAME.Text = "" Then
            txtSEARCHNAME.Text = "Search name"
            txtSEARCHNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCHNAME_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCHNAME.TextChanged
        TbltransactionBindingSource.Filter = "BorrowersName like '%" & txtSEARCHNAME.Text & "%' "

        If txtSEARCHNAME.Text = "Search name" Then
            TbltransactionBindingSource.RemoveFilter()
        ElseIf txtSEARCHNAME.Text = "" Then
            TbltransactionBindingSource.Filter = "BorrowersName like '%" & txtSEARCHNAME.Text & "%' "
        End If
    End Sub

    Private Sub dgvTRANSAC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTRANSAC.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvTRANSAC.Rows(e.RowIndex)
            txtNO.Text = row.Cells(0).Value
            txtFULLNAME.Text = row.Cells(2).Value
            txtTYPE.Text = row.Cells(3).Value
            txtITCODE.Text = row.Cells(4).Value
            txtITNAME.Text = row.Cells(5).Value
            txtQUAN.Text = row.Cells(6).Value
            txtDATE.Text = row.Cells(7).Value
        End If
        pnlITEM.Visible = False
        Function_DisplayUser()
        lblCODE.Hide()
        lblNAME.Hide()
        lblQUAN.Hide()
        btnSAVE.Enabled = True
        btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")
    End Sub
End Class
