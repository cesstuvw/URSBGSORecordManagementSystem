Public Class UCrptITEM
    Private Sub rptITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ursbgso_dbDataSet.tbl_item' table. You can move, or remove it, as needed.
        Me.rptITEMM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_item)
        Me.rptITEMM.RefreshReport()

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

    Private Sub btnFILTER_Click(sender As Object, e As EventArgs) Handles btnFILTER.Click
        If cboCATEGORY.Text = "" Then
            Me.rptITEMM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_itemTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_item)
            btnFILTER.Visible = True

        Else
            Me.rptITEMM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.tbl_itemTableAdapter.FillByCategory(Me.ursbgso_dbDataSet.tbl_item, cboCATEGORY.Text)
            Me.rptITEMM.RefreshReport()
            btnUNFILTER.Visible = True
            btnFILTER.Visible = False
        End If
    End Sub

    Private Sub btnUNFILTER_Click(sender As Object, e As EventArgs) Handles btnUNFILTER.Click
        Me.rptITEMM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemTableAdapter.Fill(Me.ursbgso_dbDataSet.tbl_item)
        Me.rptITEMM.RefreshReport()
        btnUNFILTER.Visible = False
        btnFILTER.Visible = True
        cboCATEGORY.Text = ""
    End Sub
End Class
