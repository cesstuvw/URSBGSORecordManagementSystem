<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucITEM
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvUSER = New System.Windows.Forms.DataGridView()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.pnlSEARCH = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlITEMCODE = New System.Windows.Forms.Panel()
        Me.lblITEMCODE = New System.Windows.Forms.Label()
        Me.txtITEMCODE = New System.Windows.Forms.TextBox()
        Me.btnCANCELDGV = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnCREATE = New System.Windows.Forms.Button()
        Me.pnlPS = New System.Windows.Forms.Panel()
        Me.lblITEMNAME = New System.Windows.Forms.Label()
        Me.txtPASS = New System.Windows.Forms.TextBox()
        Me.pnlLN = New System.Windows.Forms.Panel()
        Me.lblSTOCK = New System.Windows.Forms.Label()
        Me.txtAVAILABLE = New System.Windows.Forms.TextBox()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlUT = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT3 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT2 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT1 = New System.Windows.Forms.Panel()
        Me.lblCATEGORY = New System.Windows.Forms.Label()
        Me.pnlCLEANUT = New System.Windows.Forms.Panel()
        Me.cboCATEGORY = New System.Windows.Forms.ComboBox()
        Me.TblitemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.Tbl_itemTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter()
        Me.AvailableStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUSER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSEARCH.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlITEMCODE.SuspendLayout()
        Me.pnlPS.SuspendLayout()
        Me.pnlLN.SuspendLayout()
        Me.pnlUT.SuspendLayout()
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(327, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ITEM"
        '
        'dgvUSER
        '
        Me.dgvUSER.AllowUserToAddRows = False
        Me.dgvUSER.AllowUserToDeleteRows = False
        Me.dgvUSER.AllowUserToResizeColumns = False
        Me.dgvUSER.AllowUserToResizeRows = False
        Me.dgvUSER.AutoGenerateColumns = False
        Me.dgvUSER.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvUSER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUSER.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUSER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUSER.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUSER.ColumnHeadersHeight = 65
        Me.dgvUSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUSER.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemCategoryDataGridViewTextBoxColumn, Me.AvailableStockDataGridViewTextBoxColumn})
        Me.dgvUSER.DataSource = Me.TblitemBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUSER.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUSER.EnableHeadersVisualStyles = False
        Me.dgvUSER.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvUSER.Location = New System.Drawing.Point(348, 165)
        Me.dgvUSER.Name = "dgvUSER"
        Me.dgvUSER.ReadOnly = True
        Me.dgvUSER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUSER.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUSER.RowHeadersVisible = False
        Me.dgvUSER.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvUSER.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUSER.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvUSER.RowTemplate.DividerHeight = 1
        Me.dgvUSER.RowTemplate.Height = 45
        Me.dgvUSER.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvUSER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvUSER.Size = New System.Drawing.Size(660, 469)
        Me.dgvUSER.TabIndex = 61
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSEARCH.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSEARCH.Location = New System.Drawing.Point(344, 92)
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(630, 16)
        Me.txtSEARCH.TabIndex = 60
        Me.txtSEARCH.Text = "Search user"
        '
        'pnlSEARCH
        '
        Me.pnlSEARCH.BackColor = System.Drawing.Color.White
        Me.pnlSEARCH.Controls.Add(Me.PictureBox1)
        Me.pnlSEARCH.Location = New System.Drawing.Point(325, 81)
        Me.pnlSEARCH.Name = "pnlSEARCH"
        Me.pnlSEARCH.Size = New System.Drawing.Size(705, 38)
        Me.pnlSEARCH.TabIndex = 62
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.testsearch
        Me.PictureBox1.Location = New System.Drawing.Point(665, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(325, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 511)
        Me.Panel1.TabIndex = 74
        '
        'pnlITEMCODE
        '
        Me.pnlITEMCODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlITEMCODE.Controls.Add(Me.lblITEMCODE)
        Me.pnlITEMCODE.Controls.Add(Me.txtITEMCODE)
        Me.pnlITEMCODE.Location = New System.Drawing.Point(1074, 256)
        Me.pnlITEMCODE.Name = "pnlITEMCODE"
        Me.pnlITEMCODE.Size = New System.Drawing.Size(204, 36)
        Me.pnlITEMCODE.TabIndex = 84
        '
        'lblITEMCODE
        '
        Me.lblITEMCODE.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblITEMCODE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblITEMCODE.Location = New System.Drawing.Point(14, 9)
        Me.lblITEMCODE.Name = "lblITEMCODE"
        Me.lblITEMCODE.Size = New System.Drawing.Size(170, 17)
        Me.lblITEMCODE.TabIndex = 57
        Me.lblITEMCODE.Text = "Item Code"
        '
        'txtITEMCODE
        '
        Me.txtITEMCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtITEMCODE.Enabled = False
        Me.txtITEMCODE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITEMCODE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtITEMCODE.Location = New System.Drawing.Point(17, 9)
        Me.txtITEMCODE.Name = "txtITEMCODE"
        Me.txtITEMCODE.Size = New System.Drawing.Size(167, 17)
        Me.txtITEMCODE.TabIndex = 33
        Me.txtITEMCODE.Text = "Item Code"
        '
        'btnCANCELDGV
        '
        Me.btnCANCELDGV.BackColor = System.Drawing.Color.White
        Me.btnCANCELDGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCANCELDGV.Enabled = False
        Me.btnCANCELDGV.FlatAppearance.BorderSize = 0
        Me.btnCANCELDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCANCELDGV.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnCANCELDGV.ForeColor = System.Drawing.Color.White
        Me.btnCANCELDGV.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.cancel_button_icon
        Me.btnCANCELDGV.Location = New System.Drawing.Point(1242, 474)
        Me.btnCANCELDGV.Name = "btnCANCELDGV"
        Me.btnCANCELDGV.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCELDGV.TabIndex = 83
        Me.btnCANCELDGV.UseVisualStyleBackColor = False
        Me.btnCANCELDGV.Visible = False
        '
        'btnUPDATE
        '
        Me.btnUPDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUPDATE.Enabled = False
        Me.btnUPDATE.FlatAppearance.BorderSize = 0
        Me.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUPDATE.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnUPDATE.ForeColor = System.Drawing.Color.White
        Me.btnUPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUPDATE.Location = New System.Drawing.Point(1074, 474)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(158, 36)
        Me.btnUPDATE.TabIndex = 82
        Me.btnUPDATE.Text = "Update Item"
        Me.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUPDATE.UseVisualStyleBackColor = False
        Me.btnUPDATE.Visible = False
        '
        'btnCREATE
        '
        Me.btnCREATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCREATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCREATE.FlatAppearance.BorderSize = 0
        Me.btnCREATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCREATE.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnCREATE.ForeColor = System.Drawing.Color.White
        Me.btnCREATE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCREATE.Location = New System.Drawing.Point(1072, 144)
        Me.btnCREATE.Name = "btnCREATE"
        Me.btnCREATE.Size = New System.Drawing.Size(204, 36)
        Me.btnCREATE.TabIndex = 76
        Me.btnCREATE.Text = "Add New Item"
        Me.btnCREATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCREATE.UseVisualStyleBackColor = False
        '
        'pnlPS
        '
        Me.pnlPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlPS.Controls.Add(Me.lblITEMNAME)
        Me.pnlPS.Controls.Add(Me.txtPASS)
        Me.pnlPS.Location = New System.Drawing.Point(1074, 306)
        Me.pnlPS.Name = "pnlPS"
        Me.pnlPS.Size = New System.Drawing.Size(204, 36)
        Me.pnlPS.TabIndex = 77
        '
        'lblITEMNAME
        '
        Me.lblITEMNAME.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblITEMNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblITEMNAME.Location = New System.Drawing.Point(16, 10)
        Me.lblITEMNAME.Name = "lblITEMNAME"
        Me.lblITEMNAME.Size = New System.Drawing.Size(170, 17)
        Me.lblITEMNAME.TabIndex = 57
        Me.lblITEMNAME.Text = "Item Name"
        '
        'txtPASS
        '
        Me.txtPASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPASS.Enabled = False
        Me.txtPASS.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtPASS.Location = New System.Drawing.Point(19, 10)
        Me.txtPASS.Name = "txtPASS"
        Me.txtPASS.Size = New System.Drawing.Size(167, 17)
        Me.txtPASS.TabIndex = 32
        Me.txtPASS.Text = "Password"
        '
        'pnlLN
        '
        Me.pnlLN.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlLN.Controls.Add(Me.lblSTOCK)
        Me.pnlLN.Controls.Add(Me.txtAVAILABLE)
        Me.pnlLN.Location = New System.Drawing.Point(1074, 406)
        Me.pnlLN.Name = "pnlLN"
        Me.pnlLN.Size = New System.Drawing.Size(204, 36)
        Me.pnlLN.TabIndex = 80
        '
        'lblSTOCK
        '
        Me.lblSTOCK.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblSTOCK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblSTOCK.Location = New System.Drawing.Point(16, 10)
        Me.lblSTOCK.Name = "lblSTOCK"
        Me.lblSTOCK.Size = New System.Drawing.Size(170, 17)
        Me.lblSTOCK.TabIndex = 57
        Me.lblSTOCK.Text = "Available Stock"
        '
        'txtAVAILABLE
        '
        Me.txtAVAILABLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAVAILABLE.Enabled = False
        Me.txtAVAILABLE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAVAILABLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtAVAILABLE.Location = New System.Drawing.Point(19, 10)
        Me.txtAVAILABLE.Name = "txtAVAILABLE"
        Me.txtAVAILABLE.Size = New System.Drawing.Size(167, 17)
        Me.txtAVAILABLE.TabIndex = 36
        Me.txtAVAILABLE.Text = "Availabe Stock"
        '
        'btnEDIT
        '
        Me.btnEDIT.BackColor = System.Drawing.Color.White
        Me.btnEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEDIT.Enabled = False
        Me.btnEDIT.FlatAppearance.BorderSize = 0
        Me.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEDIT.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnEDIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEDIT.Location = New System.Drawing.Point(1072, 195)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(204, 36)
        Me.btnEDIT.TabIndex = 75
        Me.btnEDIT.Text = "Edit Item"
        Me.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.Color.White
        Me.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCANCEL.Enabled = False
        Me.btnCANCEL.FlatAppearance.BorderSize = 0
        Me.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCANCEL.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnCANCEL.ForeColor = System.Drawing.Color.White
        Me.btnCANCEL.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.cancel_button_icon
        Me.btnCANCEL.Location = New System.Drawing.Point(1242, 474)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCEL.TabIndex = 86
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSAVE.Enabled = False
        Me.btnSAVE.FlatAppearance.BorderSize = 0
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSAVE.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSAVE.Location = New System.Drawing.Point(1074, 474)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(158, 36)
        Me.btnSAVE.TabIndex = 85
        Me.btnSAVE.Text = "Save Item"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'pnlUT
        '
        Me.pnlUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT3)
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT2)
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT1)
        Me.pnlUT.Controls.Add(Me.lblCATEGORY)
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT)
        Me.pnlUT.Controls.Add(Me.cboCATEGORY)
        Me.pnlUT.Location = New System.Drawing.Point(1074, 356)
        Me.pnlUT.Name = "pnlUT"
        Me.pnlUT.Size = New System.Drawing.Size(204, 36)
        Me.pnlUT.TabIndex = 87
        '
        'pnlCLEANUT3
        '
        Me.pnlCLEANUT3.Location = New System.Drawing.Point(178, 0)
        Me.pnlCLEANUT3.Name = "pnlCLEANUT3"
        Me.pnlCLEANUT3.Size = New System.Drawing.Size(26, 36)
        Me.pnlCLEANUT3.TabIndex = 59
        Me.pnlCLEANUT3.Visible = False
        '
        'pnlCLEANUT2
        '
        Me.pnlCLEANUT2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCLEANUT2.Location = New System.Drawing.Point(-1, 5)
        Me.pnlCLEANUT2.Name = "pnlCLEANUT2"
        Me.pnlCLEANUT2.Size = New System.Drawing.Size(19, 27)
        Me.pnlCLEANUT2.TabIndex = 89
        Me.pnlCLEANUT2.Visible = False
        '
        'pnlCLEANUT1
        '
        Me.pnlCLEANUT1.Location = New System.Drawing.Point(4, 26)
        Me.pnlCLEANUT1.Name = "pnlCLEANUT1"
        Me.pnlCLEANUT1.Size = New System.Drawing.Size(185, 10)
        Me.pnlCLEANUT1.TabIndex = 59
        Me.pnlCLEANUT1.Visible = False
        '
        'lblCATEGORY
        '
        Me.lblCATEGORY.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblCATEGORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblCATEGORY.Location = New System.Drawing.Point(16, 9)
        Me.lblCATEGORY.Name = "lblCATEGORY"
        Me.lblCATEGORY.Size = New System.Drawing.Size(170, 17)
        Me.lblCATEGORY.TabIndex = 61
        Me.lblCATEGORY.Text = "Item Category"
        '
        'pnlCLEANUT
        '
        Me.pnlCLEANUT.Location = New System.Drawing.Point(3, 0)
        Me.pnlCLEANUT.Name = "pnlCLEANUT"
        Me.pnlCLEANUT.Size = New System.Drawing.Size(185, 9)
        Me.pnlCLEANUT.TabIndex = 59
        Me.pnlCLEANUT.Visible = False
        '
        'cboCATEGORY
        '
        Me.cboCATEGORY.AutoCompleteCustomSource.AddRange(New String() {"GSO Head", "Staff"})
        Me.cboCATEGORY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCATEGORY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboCATEGORY.Enabled = False
        Me.cboCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCATEGORY.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCATEGORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboCATEGORY.FormattingEnabled = True
        Me.cboCATEGORY.Location = New System.Drawing.Point(16, 6)
        Me.cboCATEGORY.Name = "cboCATEGORY"
        Me.cboCATEGORY.Size = New System.Drawing.Size(173, 25)
        Me.cboCATEGORY.TabIndex = 35
        Me.cboCATEGORY.Text = "Item Category"
        Me.cboCATEGORY.Visible = False
        '
        'TblitemBindingSource
        '
        Me.TblitemBindingSource.DataMember = "tbl_item"
        Me.TblitemBindingSource.DataSource = Me.Ursbgso_dbDataSet
        '
        'Ursbgso_dbDataSet
        '
        Me.Ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.Ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_itemTableAdapter
        '
        Me.Tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'AvailableStockDataGridViewTextBoxColumn
        '
        Me.AvailableStockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AvailableStockDataGridViewTextBoxColumn.DataPropertyName = "AvailableStock"
        Me.AvailableStockDataGridViewTextBoxColumn.HeaderText = "AVAILABLE STOCK"
        Me.AvailableStockDataGridViewTextBoxColumn.Name = "AvailableStockDataGridViewTextBoxColumn"
        Me.AvailableStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCategoryDataGridViewTextBoxColumn
        '
        Me.ItemCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory"
        Me.ItemCategoryDataGridViewTextBoxColumn.HeaderText = "ITEM CATEGORY"
        Me.ItemCategoryDataGridViewTextBoxColumn.Name = "ItemCategoryDataGridViewTextBoxColumn"
        Me.ItemCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ITEM NAME"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "ITEM CODE"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ucITEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.pnlUT)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.pnlITEMCODE)
        Me.Controls.Add(Me.btnCANCELDGV)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.btnCREATE)
        Me.Controls.Add(Me.pnlPS)
        Me.Controls.Add(Me.pnlLN)
        Me.Controls.Add(Me.dgvUSER)
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.pnlSEARCH)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "ucITEM"
        Me.Size = New System.Drawing.Size(1324, 705)
        CType(Me.dgvUSER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSEARCH.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlITEMCODE.ResumeLayout(False)
        Me.pnlITEMCODE.PerformLayout()
        Me.pnlPS.ResumeLayout(False)
        Me.pnlPS.PerformLayout()
        Me.pnlLN.ResumeLayout(False)
        Me.pnlLN.PerformLayout()
        Me.pnlUT.ResumeLayout(False)
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvUSER As DataGridView
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents pnlSEARCH As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlITEMCODE As Panel
    Friend WithEvents txtITEMCODE As TextBox
    Friend WithEvents btnCANCELDGV As Button
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnCREATE As Button
    Friend WithEvents pnlPS As Panel
    Friend WithEvents lblITEMNAME As Label
    Friend WithEvents txtPASS As TextBox
    Friend WithEvents pnlLN As Panel
    Friend WithEvents txtAVAILABLE As TextBox
    Friend WithEvents btnEDIT As Button
    Friend WithEvents lblITEMCODE As Label
    Friend WithEvents lblSTOCK As Label
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents pnlUT As Panel
    Friend WithEvents pnlCLEANUT3 As Panel
    Friend WithEvents pnlCLEANUT1 As Panel
    Friend WithEvents pnlCLEANUT As Panel
    Friend WithEvents cboCATEGORY As ComboBox
    Friend WithEvents lblCATEGORY As Label
    Friend WithEvents pnlCLEANUT2 As Panel
    Friend WithEvents TblitemBindingSource As BindingSource
    Friend WithEvents Ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents Tbl_itemTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailableStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
