<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBORROWERSPROFILE
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.txtCOCON = New System.Windows.Forms.TextBox()
        Me.pnlID = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cboCOTY = New System.Windows.Forms.ComboBox()
        Me.txtCOMN = New System.Windows.Forms.TextBox()
        Me.txtCOFN = New System.Windows.Forms.TextBox()
        Me.txtCOID = New System.Windows.Forms.TextBox()
        Me.btnCANCELDGV = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnCREATE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlCON = New System.Windows.Forms.Panel()
        Me.lblCONTACT = New System.Windows.Forms.Label()
        Me.txtCONTACT = New System.Windows.Forms.TextBox()
        Me.dgvPROFILE = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowersTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.pnlSEARCH = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlFN = New System.Windows.Forms.Panel()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.txtFNAME = New System.Windows.Forms.TextBox()
        Me.pnlMN = New System.Windows.Forms.Panel()
        Me.lblMN = New System.Windows.Forms.Label()
        Me.txtMNAME = New System.Windows.Forms.TextBox()
        Me.pnlLN = New System.Windows.Forms.Panel()
        Me.lblLN = New System.Windows.Forms.Label()
        Me.txtLNAME = New System.Windows.Forms.TextBox()
        Me.pnlTYPE = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT3 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT1 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT2 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT = New System.Windows.Forms.Panel()
        Me.lblTYPE = New System.Windows.Forms.Label()
        Me.cboTYPE = New System.Windows.Forms.ComboBox()
        Me.txtCOLN = New System.Windows.Forms.TextBox()
        Me.Tbl_profileTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_profileTableAdapter()
        Me.pnlID.SuspendLayout()
        Me.pnlCON.SuspendLayout()
        CType(Me.dgvPROFILE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSEARCH.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFN.SuspendLayout()
        Me.pnlMN.SuspendLayout()
        Me.pnlLN.SuspendLayout()
        Me.pnlTYPE.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "BORROWER'S PROFILE"
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
        Me.btnEDIT.TabIndex = 65
        Me.btnEDIT.Text = "Edit Profile"
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
        Me.btnCANCEL.Location = New System.Drawing.Point(1242, 572)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCEL.TabIndex = 75
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'txtCOCON
        '
        Me.txtCOCON.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOCON.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOCON.Location = New System.Drawing.Point(1173, 47)
        Me.txtCOCON.Name = "txtCOCON"
        Me.txtCOCON.Size = New System.Drawing.Size(98, 13)
        Me.txtCOCON.TabIndex = 78
        Me.txtCOCON.Visible = False
        '
        'pnlID
        '
        Me.pnlID.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlID.Controls.Add(Me.lblID)
        Me.pnlID.Controls.Add(Me.txtID)
        Me.pnlID.Location = New System.Drawing.Point(1074, 256)
        Me.pnlID.Name = "pnlID"
        Me.pnlID.Size = New System.Drawing.Size(204, 36)
        Me.pnlID.TabIndex = 77
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(14, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(175, 17)
        Me.lblID.TabIndex = 64
        Me.lblID.Text = "Borrower's ID"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(17, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(170, 17)
        Me.txtID.TabIndex = 34
        Me.txtID.Text = "Borrower's ID"
        '
        'cboCOTY
        '
        Me.cboCOTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboCOTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCOTY.FormattingEnabled = True
        Me.cboCOTY.Location = New System.Drawing.Point(1150, 85)
        Me.cboCOTY.Name = "cboCOTY"
        Me.cboCOTY.Size = New System.Drawing.Size(121, 21)
        Me.cboCOTY.TabIndex = 84
        Me.cboCOTY.Visible = False
        '
        'txtCOMN
        '
        Me.txtCOMN.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOMN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOMN.Location = New System.Drawing.Point(1173, 27)
        Me.txtCOMN.Name = "txtCOMN"
        Me.txtCOMN.Size = New System.Drawing.Size(98, 13)
        Me.txtCOMN.TabIndex = 81
        Me.txtCOMN.Visible = False
        '
        'txtCOFN
        '
        Me.txtCOFN.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOFN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOFN.Location = New System.Drawing.Point(1074, 47)
        Me.txtCOFN.Name = "txtCOFN"
        Me.txtCOFN.Size = New System.Drawing.Size(93, 13)
        Me.txtCOFN.TabIndex = 83
        Me.txtCOFN.Visible = False
        '
        'txtCOID
        '
        Me.txtCOID.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOID.Location = New System.Drawing.Point(1074, 28)
        Me.txtCOID.Name = "txtCOID"
        Me.txtCOID.Size = New System.Drawing.Size(93, 13)
        Me.txtCOID.TabIndex = 82
        Me.txtCOID.Visible = False
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
        Me.btnCANCELDGV.Location = New System.Drawing.Point(1242, 572)
        Me.btnCANCELDGV.Name = "btnCANCELDGV"
        Me.btnCANCELDGV.Size = New System.Drawing.Size(36, 36)
        Me.btnCANCELDGV.TabIndex = 74
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
        Me.btnUPDATE.Location = New System.Drawing.Point(1074, 572)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(158, 36)
        Me.btnUPDATE.TabIndex = 72
        Me.btnUPDATE.Text = "Update Profile"
        Me.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUPDATE.UseVisualStyleBackColor = False
        Me.btnUPDATE.Visible = False
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
        Me.btnSAVE.Location = New System.Drawing.Point(1074, 572)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(158, 36)
        Me.btnSAVE.TabIndex = 73
        Me.btnSAVE.Text = "Save Profile"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSAVE.UseVisualStyleBackColor = False
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
        Me.btnCREATE.TabIndex = 66
        Me.btnCREATE.Text = "Create a New Profile"
        Me.btnCREATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCREATE.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(325, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 511)
        Me.Panel1.TabIndex = 76
        '
        'pnlCON
        '
        Me.pnlCON.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCON.Controls.Add(Me.lblCONTACT)
        Me.pnlCON.Controls.Add(Me.txtCONTACT)
        Me.pnlCON.Location = New System.Drawing.Point(1074, 504)
        Me.pnlCON.Name = "pnlCON"
        Me.pnlCON.Size = New System.Drawing.Size(204, 36)
        Me.pnlCON.TabIndex = 68
        '
        'lblCONTACT
        '
        Me.lblCONTACT.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblCONTACT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblCONTACT.Location = New System.Drawing.Point(14, 9)
        Me.lblCONTACT.Name = "lblCONTACT"
        Me.lblCONTACT.Size = New System.Drawing.Size(170, 17)
        Me.lblCONTACT.TabIndex = 62
        Me.lblCONTACT.Text = "Contact No."
        '
        'txtCONTACT
        '
        Me.txtCONTACT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCONTACT.Enabled = False
        Me.txtCONTACT.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtCONTACT.Location = New System.Drawing.Point(17, 9)
        Me.txtCONTACT.Name = "txtCONTACT"
        Me.txtCONTACT.Size = New System.Drawing.Size(167, 17)
        Me.txtCONTACT.TabIndex = 37
        Me.txtCONTACT.Text = "Contact No."
        '
        'dgvPROFILE
        '
        Me.dgvPROFILE.AllowUserToAddRows = False
        Me.dgvPROFILE.AllowUserToDeleteRows = False
        Me.dgvPROFILE.AllowUserToResizeColumns = False
        Me.dgvPROFILE.AllowUserToResizeRows = False
        Me.dgvPROFILE.AutoGenerateColumns = False
        Me.dgvPROFILE.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvPROFILE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPROFILE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPROFILE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPROFILE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPROFILE.ColumnHeadersHeight = 65
        Me.dgvPROFILE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPROFILE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FNameDataGridViewTextBoxColumn, Me.MNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.BorrowersTypeDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn})
        Me.dgvPROFILE.DataSource = Me.TblprofileBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPROFILE.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPROFILE.EnableHeadersVisualStyles = False
        Me.dgvPROFILE.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvPROFILE.Location = New System.Drawing.Point(348, 165)
        Me.dgvPROFILE.Name = "dgvPROFILE"
        Me.dgvPROFILE.ReadOnly = True
        Me.dgvPROFILE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPROFILE.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPROFILE.RowHeadersVisible = False
        Me.dgvPROFILE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPROFILE.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPROFILE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPROFILE.RowTemplate.DividerHeight = 1
        Me.dgvPROFILE.RowTemplate.Height = 45
        Me.dgvPROFILE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPROFILE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPROFILE.Size = New System.Drawing.Size(660, 469)
        Me.dgvPROFILE.TabIndex = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BorrowersID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "FName"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MNameDataGridViewTextBoxColumn
        '
        Me.MNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MNameDataGridViewTextBoxColumn.DataPropertyName = "MName"
        Me.MNameDataGridViewTextBoxColumn.HeaderText = "MIDDLE NAME"
        Me.MNameDataGridViewTextBoxColumn.Name = "MNameDataGridViewTextBoxColumn"
        Me.MNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "LName"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BorrowersTypeDataGridViewTextBoxColumn
        '
        Me.BorrowersTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BorrowersTypeDataGridViewTextBoxColumn.DataPropertyName = "BorrowersType"
        Me.BorrowersTypeDataGridViewTextBoxColumn.HeaderText = "TYPE"
        Me.BorrowersTypeDataGridViewTextBoxColumn.Name = "BorrowersTypeDataGridViewTextBoxColumn"
        Me.BorrowersTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BorrowersTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "CONTACT NO."
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        Me.ContactNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TblprofileBindingSource
        '
        Me.TblprofileBindingSource.DataMember = "tbl_profile"
        Me.TblprofileBindingSource.DataSource = Me.Ursbgso_dbDataSet
        '
        'Ursbgso_dbDataSet
        '
        Me.Ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.Ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSEARCH.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSEARCH.Location = New System.Drawing.Point(344, 92)
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(630, 16)
        Me.txtSEARCH.TabIndex = 62
        Me.txtSEARCH.Text = "Search profile"
        '
        'pnlSEARCH
        '
        Me.pnlSEARCH.BackColor = System.Drawing.Color.White
        Me.pnlSEARCH.Controls.Add(Me.PictureBox1)
        Me.pnlSEARCH.Location = New System.Drawing.Point(325, 81)
        Me.pnlSEARCH.Name = "pnlSEARCH"
        Me.pnlSEARCH.Size = New System.Drawing.Size(705, 38)
        Me.pnlSEARCH.TabIndex = 64
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
        'pnlFN
        '
        Me.pnlFN.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlFN.Controls.Add(Me.lblFN)
        Me.pnlFN.Controls.Add(Me.txtFNAME)
        Me.pnlFN.Location = New System.Drawing.Point(1074, 306)
        Me.pnlFN.Name = "pnlFN"
        Me.pnlFN.Size = New System.Drawing.Size(204, 36)
        Me.pnlFN.TabIndex = 71
        '
        'lblFN
        '
        Me.lblFN.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblFN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblFN.Location = New System.Drawing.Point(14, 9)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(170, 17)
        Me.lblFN.TabIndex = 59
        Me.lblFN.Text = "First Name"
        '
        'txtFNAME
        '
        Me.txtFNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFNAME.Enabled = False
        Me.txtFNAME.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtFNAME.Location = New System.Drawing.Point(17, 9)
        Me.txtFNAME.Name = "txtFNAME"
        Me.txtFNAME.Size = New System.Drawing.Size(167, 17)
        Me.txtFNAME.TabIndex = 33
        Me.txtFNAME.Text = "First Name"
        '
        'pnlMN
        '
        Me.pnlMN.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlMN.Controls.Add(Me.lblMN)
        Me.pnlMN.Controls.Add(Me.txtMNAME)
        Me.pnlMN.Location = New System.Drawing.Point(1074, 356)
        Me.pnlMN.Name = "pnlMN"
        Me.pnlMN.Size = New System.Drawing.Size(204, 36)
        Me.pnlMN.TabIndex = 70
        '
        'lblMN
        '
        Me.lblMN.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblMN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblMN.Location = New System.Drawing.Point(14, 9)
        Me.lblMN.Name = "lblMN"
        Me.lblMN.Size = New System.Drawing.Size(170, 17)
        Me.lblMN.TabIndex = 59
        Me.lblMN.Text = "Middle Name"
        '
        'txtMNAME
        '
        Me.txtMNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMNAME.Enabled = False
        Me.txtMNAME.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtMNAME.Location = New System.Drawing.Point(17, 9)
        Me.txtMNAME.Name = "txtMNAME"
        Me.txtMNAME.Size = New System.Drawing.Size(167, 17)
        Me.txtMNAME.TabIndex = 34
        Me.txtMNAME.Text = "Middle Name"
        '
        'pnlLN
        '
        Me.pnlLN.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlLN.Controls.Add(Me.lblLN)
        Me.pnlLN.Controls.Add(Me.txtLNAME)
        Me.pnlLN.Location = New System.Drawing.Point(1074, 406)
        Me.pnlLN.Name = "pnlLN"
        Me.pnlLN.Size = New System.Drawing.Size(204, 36)
        Me.pnlLN.TabIndex = 69
        '
        'lblLN
        '
        Me.lblLN.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblLN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblLN.Location = New System.Drawing.Point(14, 9)
        Me.lblLN.Name = "lblLN"
        Me.lblLN.Size = New System.Drawing.Size(170, 17)
        Me.lblLN.TabIndex = 59
        Me.lblLN.Text = "Last Name"
        '
        'txtLNAME
        '
        Me.txtLNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLNAME.Enabled = False
        Me.txtLNAME.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtLNAME.Location = New System.Drawing.Point(17, 9)
        Me.txtLNAME.Name = "txtLNAME"
        Me.txtLNAME.Size = New System.Drawing.Size(167, 17)
        Me.txtLNAME.TabIndex = 36
        Me.txtLNAME.Text = "Last Name"
        '
        'pnlTYPE
        '
        Me.pnlTYPE.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlTYPE.Controls.Add(Me.pnlCLEANUT3)
        Me.pnlTYPE.Controls.Add(Me.pnlCLEANUT1)
        Me.pnlTYPE.Controls.Add(Me.pnlCLEANUT2)
        Me.pnlTYPE.Controls.Add(Me.pnlCLEANUT)
        Me.pnlTYPE.Controls.Add(Me.lblTYPE)
        Me.pnlTYPE.Controls.Add(Me.cboTYPE)
        Me.pnlTYPE.Location = New System.Drawing.Point(1074, 456)
        Me.pnlTYPE.Name = "pnlTYPE"
        Me.pnlTYPE.Size = New System.Drawing.Size(204, 36)
        Me.pnlTYPE.TabIndex = 67
        '
        'pnlCLEANUT3
        '
        Me.pnlCLEANUT3.Location = New System.Drawing.Point(178, 0)
        Me.pnlCLEANUT3.Name = "pnlCLEANUT3"
        Me.pnlCLEANUT3.Size = New System.Drawing.Size(26, 36)
        Me.pnlCLEANUT3.TabIndex = 90
        Me.pnlCLEANUT3.Visible = False
        '
        'pnlCLEANUT1
        '
        Me.pnlCLEANUT1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCLEANUT1.Location = New System.Drawing.Point(0, 5)
        Me.pnlCLEANUT1.Name = "pnlCLEANUT1"
        Me.pnlCLEANUT1.Size = New System.Drawing.Size(19, 27)
        Me.pnlCLEANUT1.TabIndex = 88
        Me.pnlCLEANUT1.Visible = False
        '
        'pnlCLEANUT2
        '
        Me.pnlCLEANUT2.Location = New System.Drawing.Point(10, 26)
        Me.pnlCLEANUT2.Name = "pnlCLEANUT2"
        Me.pnlCLEANUT2.Size = New System.Drawing.Size(185, 10)
        Me.pnlCLEANUT2.TabIndex = 62
        Me.pnlCLEANUT2.Visible = False
        '
        'pnlCLEANUT
        '
        Me.pnlCLEANUT.Location = New System.Drawing.Point(9, 0)
        Me.pnlCLEANUT.Name = "pnlCLEANUT"
        Me.pnlCLEANUT.Size = New System.Drawing.Size(185, 9)
        Me.pnlCLEANUT.TabIndex = 63
        Me.pnlCLEANUT.Visible = False
        '
        'lblTYPE
        '
        Me.lblTYPE.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblTYPE.Location = New System.Drawing.Point(17, 9)
        Me.lblTYPE.Name = "lblTYPE"
        Me.lblTYPE.Size = New System.Drawing.Size(170, 17)
        Me.lblTYPE.TabIndex = 61
        Me.lblTYPE.Text = "Borrower's Type"
        '
        'cboTYPE
        '
        Me.cboTYPE.AutoCompleteCustomSource.AddRange(New String() {"Faculty", "Student"})
        Me.cboTYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboTYPE.Enabled = False
        Me.cboTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTYPE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboTYPE.FormattingEnabled = True
        Me.cboTYPE.Location = New System.Drawing.Point(17, 6)
        Me.cboTYPE.Name = "cboTYPE"
        Me.cboTYPE.Size = New System.Drawing.Size(173, 25)
        Me.cboTYPE.TabIndex = 35
        Me.cboTYPE.Text = "Borrower's Type"
        Me.cboTYPE.Visible = False
        '
        'txtCOLN
        '
        Me.txtCOLN.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOLN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOLN.Location = New System.Drawing.Point(1173, 66)
        Me.txtCOLN.Name = "txtCOLN"
        Me.txtCOLN.Size = New System.Drawing.Size(98, 13)
        Me.txtCOLN.TabIndex = 83
        Me.txtCOLN.Visible = False
        '
        'Tbl_profileTableAdapter
        '
        Me.Tbl_profileTableAdapter.ClearBeforeFill = True
        '
        'ucBORROWERSPROFILE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.txtCOCON)
        Me.Controls.Add(Me.pnlID)
        Me.Controls.Add(Me.cboCOTY)
        Me.Controls.Add(Me.txtCOMN)
        Me.Controls.Add(Me.txtCOLN)
        Me.Controls.Add(Me.txtCOFN)
        Me.Controls.Add(Me.txtCOID)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.btnCREATE)
        Me.Controls.Add(Me.pnlCON)
        Me.Controls.Add(Me.dgvPROFILE)
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.pnlSEARCH)
        Me.Controls.Add(Me.pnlFN)
        Me.Controls.Add(Me.pnlMN)
        Me.Controls.Add(Me.pnlLN)
        Me.Controls.Add(Me.pnlTYPE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnCANCELDGV)
        Me.DoubleBuffered = True
        Me.Name = "ucBORROWERSPROFILE"
        Me.Size = New System.Drawing.Size(1324, 705)
        Me.pnlID.ResumeLayout(False)
        Me.pnlID.PerformLayout()
        Me.pnlCON.ResumeLayout(False)
        Me.pnlCON.PerformLayout()
        CType(Me.dgvPROFILE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSEARCH.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFN.ResumeLayout(False)
        Me.pnlFN.PerformLayout()
        Me.pnlMN.ResumeLayout(False)
        Me.pnlMN.PerformLayout()
        Me.pnlLN.ResumeLayout(False)
        Me.pnlLN.PerformLayout()
        Me.pnlTYPE.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents txtCOCON As TextBox
    Friend WithEvents pnlID As Panel
    Friend WithEvents cboCOTY As ComboBox
    Friend WithEvents txtCOMN As TextBox
    Friend WithEvents txtCOFN As TextBox
    Friend WithEvents txtCOID As TextBox
    Friend WithEvents btnCANCELDGV As Button
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnCREATE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlCON As Panel
    Friend WithEvents dgvPROFILE As DataGridView
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents pnlSEARCH As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlFN As Panel
    Friend WithEvents pnlMN As Panel
    Friend WithEvents txtMNAME As TextBox
    Friend WithEvents pnlLN As Panel
    Friend WithEvents txtLNAME As TextBox
    Friend WithEvents pnlTYPE As Panel
    Friend WithEvents txtCONTACT As TextBox
    Friend WithEvents cboTYPE As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFNAME As TextBox
    Friend WithEvents lblTYPE As Label
    Friend WithEvents pnlCLEANUT1 As Panel
    Friend WithEvents pnlCLEANUT2 As Panel
    Friend WithEvents pnlCLEANUT As Panel
    Friend WithEvents pnlCLEANUT3 As Panel
    Friend WithEvents txtCOLN As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblFN As Label
    Friend WithEvents lblMN As Label
    Friend WithEvents lblLN As Label
    Friend WithEvents lblCONTACT As Label
    Friend WithEvents BorrowersIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowersTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblprofileBindingSource As BindingSource
    Friend WithEvents Ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents Tbl_profileTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_profileTableAdapter
End Class
