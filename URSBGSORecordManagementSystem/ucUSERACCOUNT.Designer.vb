<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucUSERACCOUNT
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
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.pnlSEARCH = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlPS = New System.Windows.Forms.Panel()
        Me.lblPASS = New System.Windows.Forms.Label()
        Me.txtPASS = New System.Windows.Forms.TextBox()
        Me.pnlCPS = New System.Windows.Forms.Panel()
        Me.lblCPASS = New System.Windows.Forms.Label()
        Me.txtCPASS = New System.Windows.Forms.TextBox()
        Me.pnlLN = New System.Windows.Forms.Panel()
        Me.lblLN = New System.Windows.Forms.Label()
        Me.txtLNAME = New System.Windows.Forms.TextBox()
        Me.pnlUT = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT3 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT1 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT = New System.Windows.Forms.Panel()
        Me.lblUTYPE = New System.Windows.Forms.Label()
        Me.cboUTYPE = New System.Windows.Forms.ComboBox()
        Me.pnlST = New System.Windows.Forms.Panel()
        Me.lblSTATUS = New System.Windows.Forms.Label()
        Me.pnlCLEANST3 = New System.Windows.Forms.Panel()
        Me.pnlCLEANST1 = New System.Windows.Forms.Panel()
        Me.pnlCLEANST = New System.Windows.Forms.Panel()
        Me.cboSTATUS = New System.Windows.Forms.ComboBox()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnCREATE = New System.Windows.Forms.Button()
        Me.txtUNCOPY = New System.Windows.Forms.TextBox()
        Me.pnlUS = New System.Windows.Forms.Panel()
        Me.txtUSER = New System.Windows.Forms.TextBox()
        Me.btnCANCELDGV = New System.Windows.Forms.Button()
        Me.pnlCLEANST2 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT2 = New System.Windows.Forms.Panel()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.txtCOPW = New System.Windows.Forms.TextBox()
        Me.txtCOLN = New System.Windows.Forms.TextBox()
        Me.txtCOCPW = New System.Windows.Forms.TextBox()
        Me.cboCOST = New System.Windows.Forms.ComboBox()
        Me.cboCOUT = New System.Windows.Forms.ComboBox()
        Me.Tbl_userTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_userTableAdapter()
        Me.lblUSER = New System.Windows.Forms.Label()
        CType(Me.dgvUSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSEARCH.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPS.SuspendLayout()
        Me.pnlCPS.SuspendLayout()
        Me.pnlLN.SuspendLayout()
        Me.pnlUT.SuspendLayout()
        Me.pnlST.SuspendLayout()
        Me.pnlUS.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER ACCOUNT"
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
        Me.dgvUSER.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.LoginnameDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvUSER.DataSource = Me.TbluserBindingSource
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
        Me.dgvUSER.TabIndex = 29
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LoginnameDataGridViewTextBoxColumn
        '
        Me.LoginnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LoginnameDataGridViewTextBoxColumn.DataPropertyName = "loginname"
        Me.LoginnameDataGridViewTextBoxColumn.HeaderText = "LOGIN NAME"
        Me.LoginnameDataGridViewTextBoxColumn.Name = "LoginnameDataGridViewTextBoxColumn"
        Me.LoginnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoginnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "USER TYPE"
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsertypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TbluserBindingSource
        '
        Me.TbluserBindingSource.DataMember = "tbl_user"
        Me.TbluserBindingSource.DataSource = Me.Ursbgso_dbDataSet
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
        Me.txtSEARCH.TabIndex = 28
        Me.txtSEARCH.Text = "Search user"
        '
        'pnlSEARCH
        '
        Me.pnlSEARCH.BackColor = System.Drawing.Color.White
        Me.pnlSEARCH.Controls.Add(Me.PictureBox1)
        Me.pnlSEARCH.Location = New System.Drawing.Point(325, 81)
        Me.pnlSEARCH.Name = "pnlSEARCH"
        Me.pnlSEARCH.Size = New System.Drawing.Size(705, 38)
        Me.pnlSEARCH.TabIndex = 48
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
        'pnlPS
        '
        Me.pnlPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlPS.Controls.Add(Me.lblPASS)
        Me.pnlPS.Controls.Add(Me.txtPASS)
        Me.pnlPS.Location = New System.Drawing.Point(1074, 306)
        Me.pnlPS.Name = "pnlPS"
        Me.pnlPS.Size = New System.Drawing.Size(204, 36)
        Me.pnlPS.TabIndex = 51
        '
        'lblPASS
        '
        Me.lblPASS.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblPASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblPASS.Location = New System.Drawing.Point(16, 10)
        Me.lblPASS.Name = "lblPASS"
        Me.lblPASS.Size = New System.Drawing.Size(170, 17)
        Me.lblPASS.TabIndex = 57
        Me.lblPASS.Text = "Password"
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
        'pnlCPS
        '
        Me.pnlCPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCPS.Controls.Add(Me.lblCPASS)
        Me.pnlCPS.Controls.Add(Me.txtCPASS)
        Me.pnlCPS.Location = New System.Drawing.Point(1074, 356)
        Me.pnlCPS.Name = "pnlCPS"
        Me.pnlCPS.Size = New System.Drawing.Size(204, 36)
        Me.pnlCPS.TabIndex = 51
        '
        'lblCPASS
        '
        Me.lblCPASS.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblCPASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblCPASS.Location = New System.Drawing.Point(16, 10)
        Me.lblCPASS.Name = "lblCPASS"
        Me.lblCPASS.Size = New System.Drawing.Size(170, 17)
        Me.lblCPASS.TabIndex = 56
        Me.lblCPASS.Text = "Confirm Password"
        '
        'txtCPASS
        '
        Me.txtCPASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCPASS.Enabled = False
        Me.txtCPASS.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtCPASS.Location = New System.Drawing.Point(19, 10)
        Me.txtCPASS.Name = "txtCPASS"
        Me.txtCPASS.Size = New System.Drawing.Size(167, 17)
        Me.txtCPASS.TabIndex = 34
        Me.txtCPASS.Text = "Confirm Password"
        '
        'pnlLN
        '
        Me.pnlLN.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlLN.Controls.Add(Me.lblLN)
        Me.pnlLN.Controls.Add(Me.txtLNAME)
        Me.pnlLN.Location = New System.Drawing.Point(1074, 406)
        Me.pnlLN.Name = "pnlLN"
        Me.pnlLN.Size = New System.Drawing.Size(204, 36)
        Me.pnlLN.TabIndex = 51
        '
        'lblLN
        '
        Me.lblLN.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblLN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblLN.Location = New System.Drawing.Point(16, 10)
        Me.lblLN.Name = "lblLN"
        Me.lblLN.Size = New System.Drawing.Size(170, 17)
        Me.lblLN.TabIndex = 57
        Me.lblLN.Text = "Login Name"
        '
        'txtLNAME
        '
        Me.txtLNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLNAME.Enabled = False
        Me.txtLNAME.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtLNAME.Location = New System.Drawing.Point(19, 10)
        Me.txtLNAME.Name = "txtLNAME"
        Me.txtLNAME.Size = New System.Drawing.Size(167, 17)
        Me.txtLNAME.TabIndex = 36
        Me.txtLNAME.Text = "Login Name"
        '
        'pnlUT
        '
        Me.pnlUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT3)
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT1)
        Me.pnlUT.Controls.Add(Me.pnlCLEANUT)
        Me.pnlUT.Controls.Add(Me.lblUTYPE)
        Me.pnlUT.Controls.Add(Me.cboUTYPE)
        Me.pnlUT.Location = New System.Drawing.Point(1074, 456)
        Me.pnlUT.Name = "pnlUT"
        Me.pnlUT.Size = New System.Drawing.Size(204, 36)
        Me.pnlUT.TabIndex = 51
        '
        'pnlCLEANUT3
        '
        Me.pnlCLEANUT3.Location = New System.Drawing.Point(178, 0)
        Me.pnlCLEANUT3.Name = "pnlCLEANUT3"
        Me.pnlCLEANUT3.Size = New System.Drawing.Size(26, 36)
        Me.pnlCLEANUT3.TabIndex = 59
        Me.pnlCLEANUT3.Visible = False
        '
        'pnlCLEANUT1
        '
        Me.pnlCLEANUT1.Location = New System.Drawing.Point(4, 26)
        Me.pnlCLEANUT1.Name = "pnlCLEANUT1"
        Me.pnlCLEANUT1.Size = New System.Drawing.Size(185, 10)
        Me.pnlCLEANUT1.TabIndex = 59
        Me.pnlCLEANUT1.Visible = False
        '
        'pnlCLEANUT
        '
        Me.pnlCLEANUT.Location = New System.Drawing.Point(3, 0)
        Me.pnlCLEANUT.Name = "pnlCLEANUT"
        Me.pnlCLEANUT.Size = New System.Drawing.Size(185, 9)
        Me.pnlCLEANUT.TabIndex = 59
        Me.pnlCLEANUT.Visible = False
        '
        'lblUTYPE
        '
        Me.lblUTYPE.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblUTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblUTYPE.Location = New System.Drawing.Point(16, 9)
        Me.lblUTYPE.Name = "lblUTYPE"
        Me.lblUTYPE.Size = New System.Drawing.Size(170, 17)
        Me.lblUTYPE.TabIndex = 58
        Me.lblUTYPE.Text = "User Type"
        '
        'cboUTYPE
        '
        Me.cboUTYPE.AutoCompleteCustomSource.AddRange(New String() {"GSO Head", "Staff"})
        Me.cboUTYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUTYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboUTYPE.Enabled = False
        Me.cboUTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUTYPE.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboUTYPE.FormattingEnabled = True
        Me.cboUTYPE.Location = New System.Drawing.Point(16, 6)
        Me.cboUTYPE.Name = "cboUTYPE"
        Me.cboUTYPE.Size = New System.Drawing.Size(173, 25)
        Me.cboUTYPE.TabIndex = 35
        Me.cboUTYPE.Text = "User Type"
        Me.cboUTYPE.Visible = False
        '
        'pnlST
        '
        Me.pnlST.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlST.Controls.Add(Me.lblSTATUS)
        Me.pnlST.Controls.Add(Me.pnlCLEANST3)
        Me.pnlST.Controls.Add(Me.pnlCLEANST1)
        Me.pnlST.Controls.Add(Me.pnlCLEANST)
        Me.pnlST.Controls.Add(Me.cboSTATUS)
        Me.pnlST.Location = New System.Drawing.Point(1074, 504)
        Me.pnlST.Name = "pnlST"
        Me.pnlST.Size = New System.Drawing.Size(204, 36)
        Me.pnlST.TabIndex = 51
        '
        'lblSTATUS
        '
        Me.lblSTATUS.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblSTATUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblSTATUS.Location = New System.Drawing.Point(16, 9)
        Me.lblSTATUS.Name = "lblSTATUS"
        Me.lblSTATUS.Size = New System.Drawing.Size(170, 17)
        Me.lblSTATUS.TabIndex = 60
        Me.lblSTATUS.Text = "Status"
        '
        'pnlCLEANST3
        '
        Me.pnlCLEANST3.Location = New System.Drawing.Point(178, 0)
        Me.pnlCLEANST3.Name = "pnlCLEANST3"
        Me.pnlCLEANST3.Size = New System.Drawing.Size(26, 36)
        Me.pnlCLEANST3.TabIndex = 59
        Me.pnlCLEANST3.Visible = False
        '
        'pnlCLEANST1
        '
        Me.pnlCLEANST1.Location = New System.Drawing.Point(4, 26)
        Me.pnlCLEANST1.Name = "pnlCLEANST1"
        Me.pnlCLEANST1.Size = New System.Drawing.Size(185, 10)
        Me.pnlCLEANST1.TabIndex = 59
        Me.pnlCLEANST1.Visible = False
        '
        'pnlCLEANST
        '
        Me.pnlCLEANST.Location = New System.Drawing.Point(3, 0)
        Me.pnlCLEANST.Name = "pnlCLEANST"
        Me.pnlCLEANST.Size = New System.Drawing.Size(185, 9)
        Me.pnlCLEANST.TabIndex = 59
        Me.pnlCLEANST.Visible = False
        '
        'cboSTATUS
        '
        Me.cboSTATUS.AutoCompleteCustomSource.AddRange(New String() {"Active", "Inactive"})
        Me.cboSTATUS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSTATUS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboSTATUS.Enabled = False
        Me.cboSTATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSTATUS.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSTATUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboSTATUS.Location = New System.Drawing.Point(16, 6)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Size = New System.Drawing.Size(173, 25)
        Me.cboSTATUS.TabIndex = 33
        Me.cboSTATUS.Text = "Status"
        Me.cboSTATUS.Visible = False
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
        Me.btnSAVE.TabIndex = 52
        Me.btnSAVE.Text = "Save Account"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSAVE.UseVisualStyleBackColor = False
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
        Me.btnEDIT.TabIndex = 49
        Me.btnEDIT.Text = "Edit Account"
        Me.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(325, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 511)
        Me.Panel1.TabIndex = 54
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
        Me.btnCANCEL.TabIndex = 53
        Me.btnCANCEL.UseVisualStyleBackColor = False
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
        Me.btnCREATE.TabIndex = 49
        Me.btnCREATE.Text = "Create a New Account"
        Me.btnCREATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCREATE.UseVisualStyleBackColor = False
        '
        'txtUNCOPY
        '
        Me.txtUNCOPY.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUNCOPY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUNCOPY.Location = New System.Drawing.Point(1125, 106)
        Me.txtUNCOPY.Name = "txtUNCOPY"
        Me.txtUNCOPY.Size = New System.Drawing.Size(98, 13)
        Me.txtUNCOPY.TabIndex = 56
        Me.txtUNCOPY.Visible = False
        '
        'pnlUS
        '
        Me.pnlUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlUS.Controls.Add(Me.lblUSER)
        Me.pnlUS.Controls.Add(Me.txtUSER)
        Me.pnlUS.Location = New System.Drawing.Point(1074, 256)
        Me.pnlUS.Name = "pnlUS"
        Me.pnlUS.Size = New System.Drawing.Size(204, 36)
        Me.pnlUS.TabIndex = 55
        '
        'txtUSER
        '
        Me.txtUSER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUSER.Enabled = False
        Me.txtUSER.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtUSER.Location = New System.Drawing.Point(17, 9)
        Me.txtUSER.Name = "txtUSER"
        Me.txtUSER.Size = New System.Drawing.Size(167, 17)
        Me.txtUSER.TabIndex = 33
        Me.txtUSER.Text = "Username"
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
        Me.btnCANCELDGV.TabIndex = 53
        Me.btnCANCELDGV.UseVisualStyleBackColor = False
        Me.btnCANCELDGV.Visible = False
        '
        'pnlCLEANST2
        '
        Me.pnlCLEANST2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCLEANST2.Location = New System.Drawing.Point(1072, 507)
        Me.pnlCLEANST2.Name = "pnlCLEANST2"
        Me.pnlCLEANST2.Size = New System.Drawing.Size(19, 27)
        Me.pnlCLEANST2.TabIndex = 59
        Me.pnlCLEANST2.Visible = False
        '
        'pnlCLEANUT2
        '
        Me.pnlCLEANUT2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCLEANUT2.Location = New System.Drawing.Point(1074, 462)
        Me.pnlCLEANUT2.Name = "pnlCLEANUT2"
        Me.pnlCLEANUT2.Size = New System.Drawing.Size(19, 27)
        Me.pnlCLEANUT2.TabIndex = 59
        Me.pnlCLEANUT2.Visible = False
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
        Me.btnUPDATE.TabIndex = 52
        Me.btnUPDATE.Text = "Update Account"
        Me.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUPDATE.UseVisualStyleBackColor = False
        Me.btnUPDATE.Visible = False
        '
        'txtCOPW
        '
        Me.txtCOPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOPW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOPW.Location = New System.Drawing.Point(980, 48)
        Me.txtCOPW.Name = "txtCOPW"
        Me.txtCOPW.Size = New System.Drawing.Size(93, 13)
        Me.txtCOPW.TabIndex = 60
        Me.txtCOPW.Visible = False
        '
        'txtCOLN
        '
        Me.txtCOLN.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOLN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOLN.Location = New System.Drawing.Point(1079, 73)
        Me.txtCOLN.Name = "txtCOLN"
        Me.txtCOLN.Size = New System.Drawing.Size(93, 13)
        Me.txtCOLN.TabIndex = 60
        Me.txtCOLN.Visible = False
        '
        'txtCOCPW
        '
        Me.txtCOCPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOCPW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOCPW.Location = New System.Drawing.Point(1079, 47)
        Me.txtCOCPW.Name = "txtCOCPW"
        Me.txtCOCPW.Size = New System.Drawing.Size(93, 13)
        Me.txtCOCPW.TabIndex = 60
        Me.txtCOCPW.Visible = False
        '
        'cboCOST
        '
        Me.cboCOST.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboCOST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCOST.FormattingEnabled = True
        Me.cboCOST.Location = New System.Drawing.Point(1178, 74)
        Me.cboCOST.Name = "cboCOST"
        Me.cboCOST.Size = New System.Drawing.Size(121, 21)
        Me.cboCOST.TabIndex = 61
        Me.cboCOST.Visible = False
        '
        'cboCOUT
        '
        Me.cboCOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboCOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCOUT.FormattingEnabled = True
        Me.cboCOUT.Location = New System.Drawing.Point(1178, 47)
        Me.cboCOUT.Name = "cboCOUT"
        Me.cboCOUT.Size = New System.Drawing.Size(121, 21)
        Me.cboCOUT.TabIndex = 61
        Me.cboCOUT.Visible = False
        '
        'Tbl_userTableAdapter
        '
        Me.Tbl_userTableAdapter.ClearBeforeFill = True
        '
        'lblUSER
        '
        Me.lblUSER.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblUSER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblUSER.Location = New System.Drawing.Point(14, 9)
        Me.lblUSER.Name = "lblUSER"
        Me.lblUSER.Size = New System.Drawing.Size(170, 17)
        Me.lblUSER.TabIndex = 56
        Me.lblUSER.Text = "Username"
        '
        'ucUSERACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.cboCOUT)
        Me.Controls.Add(Me.cboCOST)
        Me.Controls.Add(Me.txtCOCPW)
        Me.Controls.Add(Me.txtCOLN)
        Me.Controls.Add(Me.txtCOPW)
        Me.Controls.Add(Me.pnlCLEANST2)
        Me.Controls.Add(Me.pnlCLEANUT2)
        Me.Controls.Add(Me.txtUNCOPY)
        Me.Controls.Add(Me.pnlUS)
        Me.Controls.Add(Me.btnCANCELDGV)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.btnCREATE)
        Me.Controls.Add(Me.dgvUSER)
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlSEARCH)
        Me.Controls.Add(Me.pnlPS)
        Me.Controls.Add(Me.pnlST)
        Me.Controls.Add(Me.pnlUT)
        Me.Controls.Add(Me.pnlLN)
        Me.Controls.Add(Me.pnlCPS)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "ucUSERACCOUNT"
        Me.Size = New System.Drawing.Size(1324, 705)
        CType(Me.dgvUSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSEARCH.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPS.ResumeLayout(False)
        Me.pnlPS.PerformLayout()
        Me.pnlCPS.ResumeLayout(False)
        Me.pnlCPS.PerformLayout()
        Me.pnlLN.ResumeLayout(False)
        Me.pnlLN.PerformLayout()
        Me.pnlUT.ResumeLayout(False)
        Me.pnlST.ResumeLayout(False)
        Me.pnlUS.ResumeLayout(False)
        Me.pnlUS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvUSER As DataGridView
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents pnlSEARCH As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEDIT As Button
    Friend WithEvents pnlPS As Panel
    Friend WithEvents pnlCPS As Panel
    Friend WithEvents pnlLN As Panel
    Friend WithEvents pnlUT As Panel
    Friend WithEvents pnlST As Panel
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCPASS As TextBox
    Friend WithEvents txtLNAME As TextBox
    Friend WithEvents cboUTYPE As ComboBox
    Friend WithEvents cboSTATUS As ComboBox
    Friend WithEvents btnCREATE As Button
    Friend WithEvents lblCPASS As Label
    Friend WithEvents txtUNCOPY As TextBox
    Friend WithEvents txtPASS As TextBox
    Friend WithEvents pnlUS As Panel
    Friend WithEvents lblUTYPE As Label
    Friend WithEvents lblPASS As Label
    Friend WithEvents txtUSER As TextBox
    Friend WithEvents btnCANCELDGV As Button
    Friend WithEvents pnlCLEANUT1 As Panel
    Friend WithEvents pnlCLEANUT As Panel
    Friend WithEvents pnlCLEANST3 As Panel
    Friend WithEvents pnlCLEANST1 As Panel
    Friend WithEvents pnlCLEANST As Panel
    Friend WithEvents pnlCLEANST2 As Panel
    Friend WithEvents pnlCLEANUT3 As Panel
    Friend WithEvents pnlCLEANUT2 As Panel
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents txtCOPW As TextBox
    Friend WithEvents txtCOLN As TextBox
    Friend WithEvents txtCOCPW As TextBox
    Friend WithEvents cboCOST As ComboBox
    Friend WithEvents lblLN As Label
    Friend WithEvents cboCOUT As ComboBox
    Friend WithEvents lblSTATUS As Label
    Friend WithEvents TbluserBindingSource As BindingSource
    Friend WithEvents Ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents Tbl_userTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblUSER As Label
End Class
