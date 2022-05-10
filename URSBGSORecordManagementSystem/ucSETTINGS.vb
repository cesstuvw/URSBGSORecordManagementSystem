Public Class ucSETTINGS
    Private Sub Function_Enabled()
        txtCATCODE.Enabled = False
        txtCATNAME.Enabled = True
        btnCANCEL.Enabled = True
        btnSAVE.Enabled = True
    End Sub

    Private Sub Function_Disabled()
        txtCATCODE.Enabled = False
        txtCATNAME.Enabled = False
    End Sub

    Private Sub Function_Display()
        lblCODE.Hide()
        lblCATNAME.Hide()
    End Sub

    Private Sub Function_DontDisplay()
        lblCODE.Show()
        lblCATNAME.Show()
    End Sub

    Private Sub Function_TextFormat()
        txtCATNAME.Text = "Category Name"
        txtCATCODE.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
    End Sub

    Private Sub Function_DisabledPanel()
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        pnlNAME.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub Function_EnabledPanel()
        pnlNAME.BackColor = Color.White
        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_category"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(CategoryCode) from tbl_category"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtCATCODE.Text = getno + 1
        Else
            txtCATCODE.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub dgvCATEGORY_Refresh()
        Me.Tbl_categoryTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_category)
    End Sub

    Private Sub ucSETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCELDGV.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")

        Me.Tbl_categoryTableAdapter.Fill(Me.Ursbgso_dbDataSet.tbl_category)
    End Sub


    '---------------------------------- CREATE A NEW CATEGORY BUTTON ---------------------------------'
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Getmax()

        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")

        btnCANCEL.BackColor = Color.White
        btnSAVE.BackColor = ColorTranslator.FromHtml("#204aff")

        Function_Enabled()
        Function_EnabledPanel()
        Function_Display()
        Function_TextFormat()
        btnUPDATE.Visible = False
        btnCANCELDGV.Visible = False
        btnCANCEL.Visible = True
        btnSAVE.Visible = True
        btnSAVE.Enabled = True

        btnEDIT.Enabled = False
        txtCATNAME.Text = ""
        txtCATNAME.Focus()

        If txtCATNAME.Text = "" Then
            txtCATNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If

        dgvCATEGORY.Enabled = True
    End Sub


    '---------------------------------- SAVE BUTTON ---------------------------------'
    'ERROR TRAPPING
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If txtCATNAME.Text = "Category Name" Then
            MsgBox("Please enter a category name!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        If txtCATNAME.Text <> txtCOCN.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_category where categoryname  = '" & txtCATNAME.Text & "' "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Sorry, that category already exists.", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                txtCATNAME.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        'Saving item
        OpenCon()
        cmd.CommandText = "insert into tbl_category values( @itemc, @itemn)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("itemc", txtCATCODE.Text)
        cmd.Parameters.AddWithValue("itemn", txtCATNAME.Text)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Item has been Saved!", vbOKOnly + vbInformation, "Saving Successful")
        txtCATCODE.Text = "Category Code"
        btnSAVE.Enabled = False
        btnCANCEL.Enabled = False
        btnEDIT.Enabled = False
        dgvCATEGORY.Enabled = True
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_TextFormat()
        dgvCATEGORY_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON ---------------------------------'
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        btnEDIT.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnCANCELDGV.Visible = False
        btnCANCELDGV.Enabled = False
        btnCANCELDGV.Enabled = False
        btnEDIT.Enabled = True
        btnSAVE.Enabled = False

        btnCANCEL.Enabled = False
        btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnCANCEL.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        btnUPDATE.Visible = False
        btnSAVE.Visible = True
        dgvCATEGORY.Enabled = True
        btnEDIT.Enabled = False
        Function_DontDisplay()
        Function_Disabled()
        Function_DisabledPanel()
        txtCATCODE.Text = "Category Code"
        txtCATNAME.Text = "Category Name"
        btnSAVE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
    End Sub


    '---------------------------------- DATA GRID VIEW ---------------------------------'
    Private Sub dgvCATEGORY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCATEGORY.CellClick
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
        txtCATCODE.Enabled = False
        txtCATNAME.Enabled = False

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvCATEGORY.Rows(e.RowIndex)
            txtCATCODE.Text = row.Cells(0).Value
            txtCATNAME.Text = row.Cells(1).Value

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

        btnEDIT.Enabled = False
        btnUPDATE.Enabled = True
        btnSAVE.Visible = False
        btnCANCEL.Visible = False

        txtCATCODE.Enabled = False
        txtCATNAME.Enabled = True

        dgvCATEGORY.Enabled = False

        Function_EnabledPanel()
        Function_Display()

        pnlCODE.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        txtCATNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")

        If btnEDIT.Enabled = True Then
            btnEDIT.BackColor = Color.White
        ElseIf btnEDIT.Enabled = False Then
            btnEDIT.BackColor = ColorTranslator.FromHtml("#f0f0f0")
        End If
    End Sub


    '---------------------------------- UPDATE BUTTON ---------------------------------'
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        'Error Trapping
        If txtCATNAME.Text = "Category Name" Then
            MsgBox("Please enter a category name!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        If txtCATCODE.Text <> txtCOCN.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_category where categoryname = '" & txtCATNAME.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("No changes have been made.", vbOKOnly + vbInformation, "Update")
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If

        OpenCon()
        cmd.CommandText = "Update tbl_category Set CategoryCode = @catcode, CategoryName = @catname where CategoryCode = @catcode"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("catcode", txtCATCODE.Text)
        cmd.Parameters.AddWithValue("catname", txtCATNAME.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated", vbOKOnly + vbInformation, "Successfully updated")


        txtCATCODE.Text = "Category Code"
        txtCATNAME.Text = "Category Name"

        btnUPDATE.Visible = False
        btnSAVE.Visible = True

        Function_Disabled()
        Function_Disabled()
        Function_DisabledPanel()
        Function_DontDisplay()
        Function_TextFormat()
        btnUPDATE.Enabled = False
        btnCANCELDGV.Enabled = False
        btnEDIT.Enabled = False
        dgvCATEGORY.Enabled = True
        dgvCATEGORY_Refresh()
    End Sub


    '---------------------------------- CANCEL BUTTON FOR DGVUSER ---------------------------------'
    Private Sub btnCANCELDGV_Click(sender As Object, e As EventArgs) Handles btnCANCELDGV.Click
        btnEDIT.BackColor = Color.White
        btnUPDATE.BackColor = ColorTranslator.FromHtml("#AEBAEC")
        btnCANCELDGV.Visible = False
        btnCANCELDGV.Enabled = False
        btnCANCELDGV.Enabled = False
        dgvCATEGORY.Enabled = True
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
        If txtSEARCH.Text = "Search category" Then
            txtSEARCH.Text = ""
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtSEARCH_Leave(sender As Object, e As EventArgs) Handles txtSEARCH.Leave
        If txtSEARCH.Text = "" Then
            txtSEARCH.Text = "Search category"
            txtSEARCH.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        TblcategoryBindingSource.Filter = "CategoryName Like '%" & txtSEARCH.Text & "%' "

        If txtSEARCH.Text = "Search category" Then
            TblcategoryBindingSource.RemoveFilter()

        ElseIf txtSEARCH.Text = "" Then
            TblcategoryBindingSource.Filter = "CategoryName like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub



    '---------------------------------- TXT AND CBO EVENTS ON FOCUS ---------------------------------'
    Private Sub txtCATNAME_Enter(sender As Object, e As EventArgs) Handles txtCATNAME.Enter
        If txtCATNAME.Text = "Category Name" Then
            txtCATNAME.Text = ""
            txtCATNAME.ForeColor = ColorTranslator.FromHtml("#204AFF")
        End If
    End Sub

    Private Sub txtCATNAME_Leave(sender As Object, e As EventArgs) Handles txtCATNAME.Leave
        If txtCATNAME.Text = "" Then
            txtCATNAME.Text = "Category Name"
            txtCATNAME.ForeColor = ColorTranslator.FromHtml("#A9B0DA")
        End If
    End Sub
End Class
