<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucITEMSTOCKS
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.pnlSEARCH = New System.Windows.Forms.Panel()
        Me.dgvITEM = New System.Windows.Forms.DataGridView()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblitemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.pnlADDED = New System.Windows.Forms.Panel()
        Me.lblADDED = New System.Windows.Forms.Label()
        Me.txtADDEDSTOCK = New System.Windows.Forms.TextBox()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlCODE = New System.Windows.Forms.Panel()
        Me.lblITEMCODE = New System.Windows.Forms.Label()
        Me.txtITEMCODE = New System.Windows.Forms.TextBox()
        Me.pnlNAME = New System.Windows.Forms.Panel()
        Me.lblITEMNAME = New System.Windows.Forms.Label()
        Me.txtITEMNAME = New System.Windows.Forms.TextBox()
        Me.pnlAVAILABLE = New System.Windows.Forms.Panel()
        Me.lblSTOCK = New System.Windows.Forms.Label()
        Me.txtAVAILABLE = New System.Windows.Forms.TextBox()
        Me.Tbl_itemTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter()
        Me.pnlSTOCKID = New System.Windows.Forms.Panel()
        Me.lblSTOCKID = New System.Windows.Forms.Label()
        Me.txtSTOCK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDATE = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSEARCH.SuspendLayout()
        CType(Me.dgvITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlADDED.SuspendLayout()
        Me.pnlCODE.SuspendLayout()
        Me.pnlNAME.SuspendLayout()
        Me.pnlAVAILABLE.SuspendLayout()
        Me.pnlSTOCKID.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ITEM STOCKS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(325, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 511)
        Me.Panel1.TabIndex = 91
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
        'txtSEARCH
        '
        Me.txtSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSEARCH.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSEARCH.Location = New System.Drawing.Point(344, 92)
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(630, 16)
        Me.txtSEARCH.TabIndex = 88
        Me.txtSEARCH.Text = "Search item"
        '
        'pnlSEARCH
        '
        Me.pnlSEARCH.BackColor = System.Drawing.Color.White
        Me.pnlSEARCH.Controls.Add(Me.PictureBox1)
        Me.pnlSEARCH.Location = New System.Drawing.Point(325, 81)
        Me.pnlSEARCH.Name = "pnlSEARCH"
        Me.pnlSEARCH.Size = New System.Drawing.Size(705, 38)
        Me.pnlSEARCH.TabIndex = 90
        '
        'dgvITEM
        '
        Me.dgvITEM.AllowUserToAddRows = False
        Me.dgvITEM.AllowUserToDeleteRows = False
        Me.dgvITEM.AllowUserToResizeColumns = False
        Me.dgvITEM.AllowUserToResizeRows = False
        Me.dgvITEM.AutoGenerateColumns = False
        Me.dgvITEM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvITEM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvITEM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvITEM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvITEM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvITEM.ColumnHeadersHeight = 65
        Me.dgvITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvITEM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemCategoryDataGridViewTextBoxColumn, Me.AvailableStockDataGridViewTextBoxColumn})
        Me.dgvITEM.DataSource = Me.TblitemBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvITEM.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvITEM.EnableHeadersVisualStyles = False
        Me.dgvITEM.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvITEM.Location = New System.Drawing.Point(348, 165)
        Me.dgvITEM.Name = "dgvITEM"
        Me.dgvITEM.ReadOnly = True
        Me.dgvITEM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvITEM.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvITEM.RowHeadersVisible = False
        Me.dgvITEM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvITEM.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvITEM.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvITEM.RowTemplate.DividerHeight = 1
        Me.dgvITEM.RowTemplate.Height = 45
        Me.dgvITEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvITEM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvITEM.Size = New System.Drawing.Size(660, 469)
        Me.dgvITEM.TabIndex = 89
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "ITEM CODE"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ITEM NAME"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ItemCategoryDataGridViewTextBoxColumn
        '
        Me.ItemCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory"
        Me.ItemCategoryDataGridViewTextBoxColumn.HeaderText = "ITEM CATEGORY"
        Me.ItemCategoryDataGridViewTextBoxColumn.Name = "ItemCategoryDataGridViewTextBoxColumn"
        Me.ItemCategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'AvailableStockDataGridViewTextBoxColumn
        '
        Me.AvailableStockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AvailableStockDataGridViewTextBoxColumn.DataPropertyName = "AvailableStock"
        Me.AvailableStockDataGridViewTextBoxColumn.HeaderText = "AVAILABLE STOCK"
        Me.AvailableStockDataGridViewTextBoxColumn.Name = "AvailableStockDataGridViewTextBoxColumn"
        Me.AvailableStockDataGridViewTextBoxColumn.ReadOnly = True
        Me.AvailableStockDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'pnlADDED
        '
        Me.pnlADDED.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlADDED.Controls.Add(Me.lblADDED)
        Me.pnlADDED.Controls.Add(Me.txtADDEDSTOCK)
        Me.pnlADDED.Location = New System.Drawing.Point(1074, 424)
        Me.pnlADDED.Name = "pnlADDED"
        Me.pnlADDED.Size = New System.Drawing.Size(204, 36)
        Me.pnlADDED.TabIndex = 101
        '
        'lblADDED
        '
        Me.lblADDED.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblADDED.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblADDED.Location = New System.Drawing.Point(14, 9)
        Me.lblADDED.Name = "lblADDED"
        Me.lblADDED.Size = New System.Drawing.Size(170, 17)
        Me.lblADDED.TabIndex = 61
        Me.lblADDED.Text = "No of Stock to be Added"
        '
        'txtADDEDSTOCK
        '
        Me.txtADDEDSTOCK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtADDEDSTOCK.Enabled = False
        Me.txtADDEDSTOCK.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADDEDSTOCK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtADDEDSTOCK.Location = New System.Drawing.Point(17, 9)
        Me.txtADDEDSTOCK.Name = "txtADDEDSTOCK"
        Me.txtADDEDSTOCK.Size = New System.Drawing.Size(167, 17)
        Me.txtADDEDSTOCK.TabIndex = 59
        Me.txtADDEDSTOCK.Text = "No of Stock to be Added"
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
        Me.btnCANCEL.Location = New System.Drawing.Point(1242, 492)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCEL.TabIndex = 100
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
        Me.btnSAVE.Location = New System.Drawing.Point(1074, 492)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(158, 36)
        Me.btnSAVE.TabIndex = 99
        Me.btnSAVE.Text = "Add Stock"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'pnlCODE
        '
        Me.pnlCODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCODE.Controls.Add(Me.lblITEMCODE)
        Me.pnlCODE.Controls.Add(Me.txtITEMCODE)
        Me.pnlCODE.Location = New System.Drawing.Point(1074, 274)
        Me.pnlCODE.Name = "pnlCODE"
        Me.pnlCODE.Size = New System.Drawing.Size(204, 36)
        Me.pnlCODE.TabIndex = 98
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
        'pnlNAME
        '
        Me.pnlNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlNAME.Controls.Add(Me.lblITEMNAME)
        Me.pnlNAME.Controls.Add(Me.txtITEMNAME)
        Me.pnlNAME.Location = New System.Drawing.Point(1074, 324)
        Me.pnlNAME.Name = "pnlNAME"
        Me.pnlNAME.Size = New System.Drawing.Size(204, 36)
        Me.pnlNAME.TabIndex = 94
        '
        'lblITEMNAME
        '
        Me.lblITEMNAME.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblITEMNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblITEMNAME.Location = New System.Drawing.Point(14, 9)
        Me.lblITEMNAME.Name = "lblITEMNAME"
        Me.lblITEMNAME.Size = New System.Drawing.Size(170, 17)
        Me.lblITEMNAME.TabIndex = 59
        Me.lblITEMNAME.Text = "Item Name"
        '
        'txtITEMNAME
        '
        Me.txtITEMNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtITEMNAME.Enabled = False
        Me.txtITEMNAME.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITEMNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtITEMNAME.Location = New System.Drawing.Point(17, 9)
        Me.txtITEMNAME.Name = "txtITEMNAME"
        Me.txtITEMNAME.Size = New System.Drawing.Size(167, 17)
        Me.txtITEMNAME.TabIndex = 32
        Me.txtITEMNAME.Text = "Item Name"
        '
        'pnlAVAILABLE
        '
        Me.pnlAVAILABLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlAVAILABLE.Controls.Add(Me.lblSTOCK)
        Me.pnlAVAILABLE.Controls.Add(Me.txtAVAILABLE)
        Me.pnlAVAILABLE.Location = New System.Drawing.Point(1074, 374)
        Me.pnlAVAILABLE.Name = "pnlAVAILABLE"
        Me.pnlAVAILABLE.Size = New System.Drawing.Size(204, 36)
        Me.pnlAVAILABLE.TabIndex = 95
        '
        'lblSTOCK
        '
        Me.lblSTOCK.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblSTOCK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblSTOCK.Location = New System.Drawing.Point(14, 9)
        Me.lblSTOCK.Name = "lblSTOCK"
        Me.lblSTOCK.Size = New System.Drawing.Size(170, 17)
        Me.lblSTOCK.TabIndex = 58
        Me.lblSTOCK.Text = "Available Stock"
        '
        'txtAVAILABLE
        '
        Me.txtAVAILABLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAVAILABLE.Enabled = False
        Me.txtAVAILABLE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAVAILABLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtAVAILABLE.Location = New System.Drawing.Point(17, 9)
        Me.txtAVAILABLE.Name = "txtAVAILABLE"
        Me.txtAVAILABLE.Size = New System.Drawing.Size(167, 17)
        Me.txtAVAILABLE.TabIndex = 36
        Me.txtAVAILABLE.Text = "Availabe Stock"
        '
        'Tbl_itemTableAdapter
        '
        Me.Tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'pnlSTOCKID
        '
        Me.pnlSTOCKID.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlSTOCKID.Controls.Add(Me.lblSTOCKID)
        Me.pnlSTOCKID.Controls.Add(Me.txtSTOCK)
        Me.pnlSTOCKID.Location = New System.Drawing.Point(1074, 223)
        Me.pnlSTOCKID.Name = "pnlSTOCKID"
        Me.pnlSTOCKID.Size = New System.Drawing.Size(204, 36)
        Me.pnlSTOCKID.TabIndex = 98
        '
        'lblSTOCKID
        '
        Me.lblSTOCKID.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblSTOCKID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblSTOCKID.Location = New System.Drawing.Point(14, 9)
        Me.lblSTOCKID.Name = "lblSTOCKID"
        Me.lblSTOCKID.Size = New System.Drawing.Size(170, 17)
        Me.lblSTOCKID.TabIndex = 59
        Me.lblSTOCKID.Text = "Stock ID"
        '
        'txtSTOCK
        '
        Me.txtSTOCK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSTOCK.Enabled = False
        Me.txtSTOCK.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTOCK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSTOCK.Location = New System.Drawing.Point(17, 9)
        Me.txtSTOCK.Name = "txtSTOCK"
        Me.txtSTOCK.Size = New System.Drawing.Size(167, 17)
        Me.txtSTOCK.TabIndex = 33
        Me.txtSTOCK.Text = "Stock ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1070, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 44)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "SELECT AN ITEM TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADD NEW STOCK."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtDATE)
        Me.Panel2.Location = New System.Drawing.Point(1075, 618)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 36)
        Me.Panel2.TabIndex = 101
        Me.Panel2.Visible = False
        '
        'txtDATE
        '
        Me.txtDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDATE.Enabled = False
        Me.txtDATE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtDATE.Location = New System.Drawing.Point(19, 10)
        Me.txtDATE.Name = "txtDATE"
        Me.txtDATE.Size = New System.Drawing.Size(167, 17)
        Me.txtDATE.TabIndex = 59
        Me.txtDATE.Visible = False
        '
        'ucITEMSTOCKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlADDED)
        Me.Controls.Add(Me.pnlSTOCKID)
        Me.Controls.Add(Me.pnlCODE)
        Me.Controls.Add(Me.pnlNAME)
        Me.Controls.Add(Me.pnlAVAILABLE)
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.pnlSEARCH)
        Me.Controls.Add(Me.dgvITEM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnSAVE)
        Me.DoubleBuffered = True
        Me.Name = "ucITEMSTOCKS"
        Me.Size = New System.Drawing.Size(1324, 705)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSEARCH.ResumeLayout(False)
        CType(Me.dgvITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlADDED.ResumeLayout(False)
        Me.pnlADDED.PerformLayout()
        Me.pnlCODE.ResumeLayout(False)
        Me.pnlCODE.PerformLayout()
        Me.pnlNAME.ResumeLayout(False)
        Me.pnlNAME.PerformLayout()
        Me.pnlAVAILABLE.ResumeLayout(False)
        Me.pnlAVAILABLE.PerformLayout()
        Me.pnlSTOCKID.ResumeLayout(False)
        Me.pnlSTOCKID.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents pnlSEARCH As Panel
    Friend WithEvents dgvITEM As DataGridView
    Friend WithEvents pnlADDED As Panel
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents pnlCODE As Panel
    Friend WithEvents txtITEMCODE As TextBox
    Friend WithEvents pnlNAME As Panel
    Friend WithEvents txtITEMNAME As TextBox
    Friend WithEvents pnlAVAILABLE As Panel
    Friend WithEvents txtAVAILABLE As TextBox
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailableStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblitemBindingSource As BindingSource
    Friend WithEvents Ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents Tbl_itemTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter
    Friend WithEvents pnlSTOCKID As Panel
    Friend WithEvents txtSTOCK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtADDEDSTOCK As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDATE As TextBox
    Friend WithEvents lblSTOCKID As Label
    Friend WithEvents lblITEMCODE As Label
    Friend WithEvents lblITEMNAME As Label
    Friend WithEvents lblSTOCK As Label
    Friend WithEvents lblADDED As Label
End Class
