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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.pnlSEARCH = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlCODE = New System.Windows.Forms.Panel()
        Me.lblITEMCODE = New System.Windows.Forms.Label()
        Me.txtITEMCODE = New System.Windows.Forms.TextBox()
        Me.btnCANCELDGV = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.pnlNAME = New System.Windows.Forms.Panel()
        Me.lblITEMNAME = New System.Windows.Forms.Label()
        Me.txtITEMNAME = New System.Windows.Forms.TextBox()
        Me.pnlAVAILABLE = New System.Windows.Forms.Panel()
        Me.lblSTOCK = New System.Windows.Forms.Label()
        Me.txtAVAILABLE = New System.Windows.Forms.TextBox()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlCATEGORY = New System.Windows.Forms.Panel()
        Me.lblCATEGORY = New System.Windows.Forms.Label()
        Me.pnlCLEANUT3 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT2 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT1 = New System.Windows.Forms.Panel()
        Me.pnlCLEANUT = New System.Windows.Forms.Panel()
        Me.cboCATEGORY = New System.Windows.Forms.ComboBox()
        Me.dgvITEM = New System.Windows.Forms.DataGridView()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblitemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.Tbl_itemTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter()
        Me.txtCOITNM = New System.Windows.Forms.TextBox()
        Me.cboCOCAT = New System.Windows.Forms.ComboBox()
        Me.pnlSEARCH.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCODE.SuspendLayout()
        Me.pnlNAME.SuspendLayout()
        Me.pnlAVAILABLE.SuspendLayout()
        Me.pnlCATEGORY.SuspendLayout()
        CType(Me.dgvITEM, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtSEARCH
        '
        Me.txtSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSEARCH.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSEARCH.Location = New System.Drawing.Point(344, 92)
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(630, 16)
        Me.txtSEARCH.TabIndex = 60
        Me.txtSEARCH.Text = "Search item"
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
        'pnlCODE
        '
        Me.pnlCODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCODE.Controls.Add(Me.lblITEMCODE)
        Me.pnlCODE.Controls.Add(Me.txtITEMCODE)
        Me.pnlCODE.Location = New System.Drawing.Point(1074, 256)
        Me.pnlCODE.Name = "pnlCODE"
        Me.pnlCODE.Size = New System.Drawing.Size(204, 36)
        Me.pnlCODE.TabIndex = 84
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
        Me.btnADD.TabIndex = 76
        Me.btnADD.Text = "Add a New Item"
        Me.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'pnlNAME
        '
        Me.pnlNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlNAME.Controls.Add(Me.lblITEMNAME)
        Me.pnlNAME.Controls.Add(Me.txtITEMNAME)
        Me.pnlNAME.Location = New System.Drawing.Point(1074, 306)
        Me.pnlNAME.Name = "pnlNAME"
        Me.pnlNAME.Size = New System.Drawing.Size(204, 36)
        Me.pnlNAME.TabIndex = 77
        '
        'lblITEMNAME
        '
        Me.lblITEMNAME.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblITEMNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblITEMNAME.Location = New System.Drawing.Point(16, 10)
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
        Me.txtITEMNAME.Location = New System.Drawing.Point(19, 10)
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
        Me.pnlAVAILABLE.Location = New System.Drawing.Point(1074, 406)
        Me.pnlAVAILABLE.Name = "pnlAVAILABLE"
        Me.pnlAVAILABLE.Size = New System.Drawing.Size(204, 36)
        Me.pnlAVAILABLE.TabIndex = 80
        '
        'lblSTOCK
        '
        Me.lblSTOCK.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblSTOCK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblSTOCK.Location = New System.Drawing.Point(16, 10)
        Me.lblSTOCK.Name = "lblSTOCK"
        Me.lblSTOCK.Size = New System.Drawing.Size(170, 17)
        Me.lblSTOCK.TabIndex = 59
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
        Me.txtAVAILABLE.Text = "Available Stock"
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
        'pnlCATEGORY
        '
        Me.pnlCATEGORY.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlCATEGORY.Controls.Add(Me.lblCATEGORY)
        Me.pnlCATEGORY.Controls.Add(Me.pnlCLEANUT3)
        Me.pnlCATEGORY.Controls.Add(Me.pnlCLEANUT2)
        Me.pnlCATEGORY.Controls.Add(Me.pnlCLEANUT1)
        Me.pnlCATEGORY.Controls.Add(Me.pnlCLEANUT)
        Me.pnlCATEGORY.Controls.Add(Me.cboCATEGORY)
        Me.pnlCATEGORY.Location = New System.Drawing.Point(1074, 356)
        Me.pnlCATEGORY.Name = "pnlCATEGORY"
        Me.pnlCATEGORY.Size = New System.Drawing.Size(204, 36)
        Me.pnlCATEGORY.TabIndex = 87
        '
        'lblCATEGORY
        '
        Me.lblCATEGORY.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblCATEGORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lblCATEGORY.Location = New System.Drawing.Point(16, 9)
        Me.lblCATEGORY.Name = "lblCATEGORY"
        Me.lblCATEGORY.Size = New System.Drawing.Size(170, 17)
        Me.lblCATEGORY.TabIndex = 92
        Me.lblCATEGORY.Text = "Item Category"
        '
        'pnlCLEANUT3
        '
        Me.pnlCLEANUT3.Location = New System.Drawing.Point(178, 0)
        Me.pnlCLEANUT3.Name = "pnlCLEANUT3"
        Me.pnlCLEANUT3.Size = New System.Drawing.Size(26, 36)
        Me.pnlCLEANUT3.TabIndex = 91
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
        Me.cboCATEGORY.AutoCompleteCustomSource.AddRange(New String() {"Audio", "Appliances", "Furnitures & Decorations", "Rooms/Venue", "Cleaning Tools", "Gardening Tools", "Sports"})
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvITEM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvITEM.ColumnHeadersHeight = 65
        Me.dgvITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvITEM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemCategoryDataGridViewTextBoxColumn, Me.AvailableStockDataGridViewTextBoxColumn})
        Me.dgvITEM.DataSource = Me.TblitemBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvITEM.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvITEM.EnableHeadersVisualStyles = False
        Me.dgvITEM.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvITEM.Location = New System.Drawing.Point(348, 165)
        Me.dgvITEM.Name = "dgvITEM"
        Me.dgvITEM.ReadOnly = True
        Me.dgvITEM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvITEM.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvITEM.RowHeadersVisible = False
        Me.dgvITEM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvITEM.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvITEM.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvITEM.RowTemplate.DividerHeight = 1
        Me.dgvITEM.RowTemplate.Height = 45
        Me.dgvITEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvITEM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvITEM.Size = New System.Drawing.Size(660, 469)
        Me.dgvITEM.TabIndex = 61
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
        'Tbl_itemTableAdapter
        '
        Me.Tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'txtCOITNM
        '
        Me.txtCOITNM.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCOITNM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCOITNM.Location = New System.Drawing.Point(1165, 47)
        Me.txtCOITNM.Name = "txtCOITNM"
        Me.txtCOITNM.Size = New System.Drawing.Size(93, 13)
        Me.txtCOITNM.TabIndex = 88
        Me.txtCOITNM.Visible = False
        '
        'cboCOCAT
        '
        Me.cboCOCAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboCOCAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCOCAT.FormattingEnabled = True
        Me.cboCOCAT.Location = New System.Drawing.Point(1155, 81)
        Me.cboCOCAT.Name = "cboCOCAT"
        Me.cboCOCAT.Size = New System.Drawing.Size(121, 21)
        Me.cboCOCAT.TabIndex = 89
        Me.cboCOCAT.Visible = False
        '
        'ucITEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.cboCOCAT)
        Me.Controls.Add(Me.txtCOITNM)
        Me.Controls.Add(Me.pnlCATEGORY)
        Me.Controls.Add(Me.pnlCODE)
        Me.Controls.Add(Me.btnCANCELDGV)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.pnlNAME)
        Me.Controls.Add(Me.pnlAVAILABLE)
        Me.Controls.Add(Me.dgvITEM)
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.pnlSEARCH)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.btnCANCEL)
        Me.DoubleBuffered = True
        Me.Name = "ucITEM"
        Me.Size = New System.Drawing.Size(1324, 705)
        Me.pnlSEARCH.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCODE.ResumeLayout(False)
        Me.pnlCODE.PerformLayout()
        Me.pnlNAME.ResumeLayout(False)
        Me.pnlNAME.PerformLayout()
        Me.pnlAVAILABLE.ResumeLayout(False)
        Me.pnlAVAILABLE.PerformLayout()
        Me.pnlCATEGORY.ResumeLayout(False)
        CType(Me.dgvITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents pnlSEARCH As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlCODE As Panel
    Friend WithEvents txtITEMCODE As TextBox
    Friend WithEvents btnCANCELDGV As Button
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents pnlNAME As Panel
    Friend WithEvents txtITEMNAME As TextBox
    Friend WithEvents pnlAVAILABLE As Panel
    Friend WithEvents txtAVAILABLE As TextBox
    Friend WithEvents btnEDIT As Button
    Friend WithEvents lblITEMCODE As Label
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents pnlCATEGORY As Panel
    Friend WithEvents pnlCLEANUT1 As Panel
    Friend WithEvents pnlCLEANUT As Panel
    Friend WithEvents cboCATEGORY As ComboBox
    Friend WithEvents pnlCLEANUT2 As Panel
    Friend WithEvents lblITEMNAME As Label
    Friend WithEvents pnlCLEANUT3 As Panel
    Friend WithEvents dgvITEM As DataGridView
    Friend WithEvents lblCATEGORY As Label
    Friend WithEvents TblitemBindingSource As BindingSource
    Friend WithEvents Ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents Tbl_itemTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter
    Friend WithEvents lblSTOCK As Label
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailableStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtCOITNM As TextBox
    Friend WithEvents cboCOCAT As ComboBox
End Class
