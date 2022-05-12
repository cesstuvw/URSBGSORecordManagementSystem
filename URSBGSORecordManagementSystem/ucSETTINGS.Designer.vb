<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSETTINGS
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCODE = New System.Windows.Forms.Panel()
        Me.lblCODE = New System.Windows.Forms.Label()
        Me.txtCATCODE = New System.Windows.Forms.TextBox()
        Me.btnCANCELDGV = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCATEGORY = New System.Windows.Forms.DataGridView()
        Me.CategoryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.pnlNAME = New System.Windows.Forms.Panel()
        Me.lblCATNAME = New System.Windows.Forms.Label()
        Me.txtCATNAME = New System.Windows.Forms.TextBox()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.pnlSEARCH = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.Tbl_categoryTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_categoryTableAdapter()
        Me.txtCOCN = New System.Windows.Forms.TextBox()
        Me.pnlCODE.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCATEGORY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNAME.SuspendLayout()
        Me.pnlSEARCH.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SETTINGS"
        '
        'pnlCODE
        '
        Me.pnlCODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCODE.Controls.Add(Me.lblCODE)
        Me.pnlCODE.Controls.Add(Me.txtCATCODE)
        Me.pnlCODE.Location = New System.Drawing.Point(1074, 256)
        Me.pnlCODE.Name = "pnlCODE"
        Me.pnlCODE.Size = New System.Drawing.Size(204, 36)
        Me.pnlCODE.TabIndex = 98
        '
        'lblCODE
        '
        Me.lblCODE.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblCODE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblCODE.Location = New System.Drawing.Point(14, 9)
        Me.lblCODE.Name = "lblCODE"
        Me.lblCODE.Size = New System.Drawing.Size(170, 17)
        Me.lblCODE.TabIndex = 61
        Me.lblCODE.Text = "Category Code"
        '
        'txtCATCODE
        '
        Me.txtCATCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCATCODE.Enabled = False
        Me.txtCATCODE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATCODE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtCATCODE.Location = New System.Drawing.Point(17, 9)
        Me.txtCATCODE.Name = "txtCATCODE"
        Me.txtCATCODE.Size = New System.Drawing.Size(167, 17)
        Me.txtCATCODE.TabIndex = 33
        Me.txtCATCODE.Text = "Category Code"
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
        Me.btnCANCELDGV.Location = New System.Drawing.Point(1242, 375)
        Me.btnCANCELDGV.Name = "btnCANCELDGV"
        Me.btnCANCELDGV.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCELDGV.TabIndex = 97
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
        Me.btnUPDATE.Location = New System.Drawing.Point(1074, 375)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(158, 36)
        Me.btnUPDATE.TabIndex = 96
        Me.btnUPDATE.Text = "Update Category"
        Me.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUPDATE.UseVisualStyleBackColor = False
        Me.btnUPDATE.Visible = False
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
        Me.btnEDIT.TabIndex = 92
        Me.btnEDIT.Text = "Edit Category"
        Me.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnADD.FlatAppearance.BorderSize = 0
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnADD.Font = New System.Drawing.Font("Arial", 9.8!, System.Drawing.FontStyle.Bold)
        Me.btnADD.ForeColor = System.Drawing.Color.White
        Me.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnADD.Location = New System.Drawing.Point(1072, 144)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(204, 36)
        Me.btnADD.TabIndex = 93
        Me.btnADD.Text = "Add a New Category"
        Me.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnADD.UseVisualStyleBackColor = False
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
        'dgvCATEGORY
        '
        Me.dgvCATEGORY.AllowUserToAddRows = False
        Me.dgvCATEGORY.AllowUserToDeleteRows = False
        Me.dgvCATEGORY.AllowUserToResizeColumns = False
        Me.dgvCATEGORY.AllowUserToResizeRows = False
        Me.dgvCATEGORY.AutoGenerateColumns = False
        Me.dgvCATEGORY.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvCATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCATEGORY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCATEGORY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCATEGORY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCATEGORY.ColumnHeadersHeight = 65
        Me.dgvCATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCATEGORY.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryCodeDataGridViewTextBoxColumn, Me.CategoryNameDataGridViewTextBoxColumn})
        Me.dgvCATEGORY.DataSource = Me.TblcategoryBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCATEGORY.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCATEGORY.EnableHeadersVisualStyles = False
        Me.dgvCATEGORY.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvCATEGORY.Location = New System.Drawing.Point(348, 165)
        Me.dgvCATEGORY.Name = "dgvCATEGORY"
        Me.dgvCATEGORY.ReadOnly = True
        Me.dgvCATEGORY.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCATEGORY.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCATEGORY.RowHeadersVisible = False
        Me.dgvCATEGORY.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCATEGORY.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCATEGORY.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCATEGORY.RowTemplate.DividerHeight = 1
        Me.dgvCATEGORY.RowTemplate.Height = 45
        Me.dgvCATEGORY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCATEGORY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCATEGORY.Size = New System.Drawing.Size(660, 469)
        Me.dgvCATEGORY.TabIndex = 89
        '
        'CategoryCodeDataGridViewTextBoxColumn
        '
        Me.CategoryCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoryCodeDataGridViewTextBoxColumn.DataPropertyName = "CategoryCode"
        Me.CategoryCodeDataGridViewTextBoxColumn.HeaderText = "CATEGORY CODE"
        Me.CategoryCodeDataGridViewTextBoxColumn.Name = "CategoryCodeDataGridViewTextBoxColumn"
        Me.CategoryCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CategoryNameDataGridViewTextBoxColumn
        '
        Me.CategoryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.HeaderText = "CATEGORY NAME"
        Me.CategoryNameDataGridViewTextBoxColumn.Name = "CategoryNameDataGridViewTextBoxColumn"
        Me.CategoryNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblcategoryBindingSource
        '
        Me.TblcategoryBindingSource.DataMember = "tbl_category"
        Me.TblcategoryBindingSource.DataSource = Me.Ursbgso_dbDataSet
        '
        'Ursbgso_dbDataSet
        '
        Me.Ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.Ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlNAME
        '
        Me.pnlNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlNAME.Controls.Add(Me.lblCATNAME)
        Me.pnlNAME.Controls.Add(Me.txtCATNAME)
        Me.pnlNAME.Location = New System.Drawing.Point(1074, 306)
        Me.pnlNAME.Name = "pnlNAME"
        Me.pnlNAME.Size = New System.Drawing.Size(204, 36)
        Me.pnlNAME.TabIndex = 94
        '
        'lblCATNAME
        '
        Me.lblCATNAME.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblCATNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblCATNAME.Location = New System.Drawing.Point(14, 9)
        Me.lblCATNAME.Name = "lblCATNAME"
        Me.lblCATNAME.Size = New System.Drawing.Size(170, 17)
        Me.lblCATNAME.TabIndex = 60
        Me.lblCATNAME.Text = "Category Name"
        '
        'txtCATNAME
        '
        Me.txtCATNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCATNAME.Enabled = False
        Me.txtCATNAME.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtCATNAME.Location = New System.Drawing.Point(17, 9)
        Me.txtCATNAME.Name = "txtCATNAME"
        Me.txtCATNAME.Size = New System.Drawing.Size(167, 17)
        Me.txtCATNAME.TabIndex = 32
        Me.txtCATNAME.Text = "Category Name"
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
        Me.txtSEARCH.Text = "Search category"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(325, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 511)
        Me.Panel1.TabIndex = 91
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
        Me.btnSAVE.Location = New System.Drawing.Point(1074, 375)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(158, 36)
        Me.btnSAVE.TabIndex = 99
        Me.btnSAVE.Text = "Save Category"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSAVE.UseVisualStyleBackColor = False
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
        Me.btnCANCEL.Location = New System.Drawing.Point(1242, 375)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCEL.TabIndex = 100
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'Tbl_categoryTableAdapter
        '
        Me.Tbl_categoryTableAdapter.ClearBeforeFill = True
        '
        'txtCOCN
        '
        Me.txtCOCN.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOCN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOCN.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOCN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOCN.Location = New System.Drawing.Point(1168, 103)
        Me.txtCOCN.Name = "txtCOCN"
        Me.txtCOCN.Size = New System.Drawing.Size(108, 16)
        Me.txtCOCN.TabIndex = 104
        Me.txtCOCN.Visible = False
        '
        'ucSETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.txtCOCN)
        Me.Controls.Add(Me.pnlCODE)
        Me.Controls.Add(Me.btnCANCELDGV)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.dgvCATEGORY)
        Me.Controls.Add(Me.pnlNAME)
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.pnlSEARCH)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "ucSETTINGS"
        Me.Size = New System.Drawing.Size(1324, 705)
        Me.pnlCODE.ResumeLayout(False)
        Me.pnlCODE.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCATEGORY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNAME.ResumeLayout(False)
        Me.pnlNAME.PerformLayout()
        Me.pnlSEARCH.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents pnlCODE As Panel
    Friend WithEvents txtCATCODE As TextBox
    Friend WithEvents btnCANCELDGV As Button
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvCATEGORY As DataGridView
    Friend WithEvents pnlNAME As Panel
    Friend WithEvents txtCATNAME As TextBox
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents pnlSEARCH As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents TblcategoryBindingSource As BindingSource
    Friend WithEvents Ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents Tbl_categoryTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_categoryTableAdapter
    Friend WithEvents CategoryCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblCODE As Label
    Friend WithEvents lblCATNAME As Label
    Friend WithEvents txtCOCN As TextBox
End Class
