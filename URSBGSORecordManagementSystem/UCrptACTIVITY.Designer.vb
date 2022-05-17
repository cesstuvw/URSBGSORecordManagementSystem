<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCrptACTIVITY
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbl_activityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.btnUNFILTER = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFILTER = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtEND = New System.Windows.Forms.DateTimePicker()
        Me.dtSTART = New System.Windows.Forms.DateTimePicker()
        Me.rptACT = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_activityTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_activityTableAdapter()
        Me.btnDGV = New System.Windows.Forms.Button()
        Me.pnlDGV = New System.Windows.Forms.Panel()
        Me.btnHIDEDGV = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvPROFILE = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblactivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvITEM = New System.Windows.Forms.DataGridView()
        CType(Me.tbl_activityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlREPORT.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlDGV.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvPROFILE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblactivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_activityBindingSource
        '
        Me.tbl_activityBindingSource.DataMember = "tbl_activity"
        Me.tbl_activityBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'ursbgso_dbDataSet
        '
        Me.ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.btnUNFILTER)
        Me.pnlREPORT.Controls.Add(Me.Label3)
        Me.pnlREPORT.Controls.Add(Me.Label1)
        Me.pnlREPORT.Controls.Add(Me.btnFILTER)
        Me.pnlREPORT.Controls.Add(Me.Panel2)
        Me.pnlREPORT.Controls.Add(Me.rptACT)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 105)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 571)
        Me.pnlREPORT.TabIndex = 27
        '
        'btnUNFILTER
        '
        Me.btnUNFILTER.BackColor = System.Drawing.Color.White
        Me.btnUNFILTER.FlatAppearance.BorderSize = 0
        Me.btnUNFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUNFILTER.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUNFILTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUNFILTER.Location = New System.Drawing.Point(629, 20)
        Me.btnUNFILTER.Name = "btnUNFILTER"
        Me.btnUNFILTER.Size = New System.Drawing.Size(109, 35)
        Me.btnUNFILTER.TabIndex = 6
        Me.btnUNFILTER.Text = "Unfilter"
        Me.btnUNFILTER.UseVisualStyleBackColor = False
        Me.btnUNFILTER.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(220, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter by Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ACTIVITY LOG"
        '
        'btnFILTER
        '
        Me.btnFILTER.BackColor = System.Drawing.Color.White
        Me.btnFILTER.FlatAppearance.BorderSize = 0
        Me.btnFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFILTER.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFILTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFILTER.Location = New System.Drawing.Point(629, 20)
        Me.btnFILTER.Name = "btnFILTER"
        Me.btnFILTER.Size = New System.Drawing.Size(109, 35)
        Me.btnFILTER.TabIndex = 3
        Me.btnFILTER.Text = "Filter"
        Me.btnFILTER.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtEND)
        Me.Panel2.Controls.Add(Me.dtSTART)
        Me.Panel2.Location = New System.Drawing.Point(322, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 35)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(137, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "to"
        '
        'dtEND
        '
        Me.dtEND.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtEND.CustomFormat = "yyyy-MM-dd"
        Me.dtEND.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEND.Location = New System.Drawing.Point(165, 8)
        Me.dtEND.Name = "dtEND"
        Me.dtEND.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtEND.Size = New System.Drawing.Size(110, 20)
        Me.dtEND.TabIndex = 6
        Me.dtEND.Value = New Date(2022, 5, 10, 0, 0, 0, 0)
        '
        'dtSTART
        '
        Me.dtSTART.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtSTART.CustomFormat = "yyyy-MM-dd"
        Me.dtSTART.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSTART.Location = New System.Drawing.Point(16, 8)
        Me.dtSTART.Name = "dtSTART"
        Me.dtSTART.Size = New System.Drawing.Size(110, 20)
        Me.dtSTART.TabIndex = 6
        Me.dtSTART.Value = New Date(2022, 5, 5, 0, 0, 0, 0)
        '
        'rptACT
        '
        Me.rptACT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rptACT.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "DataSet_ActLog"
        ReportDataSource2.Value = Me.tbl_activityBindingSource
        Me.rptACT.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptACT.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptACTLOG.rdlc"
        Me.rptACT.Location = New System.Drawing.Point(21, 72)
        Me.rptACT.Name = "rptACT"
        Me.rptACT.ServerReport.BearerToken = Nothing
        Me.rptACT.Size = New System.Drawing.Size(716, 478)
        Me.rptACT.TabIndex = 0
        '
        'tbl_activityTableAdapter
        '
        Me.tbl_activityTableAdapter.ClearBeforeFill = True
        '
        'btnDGV
        '
        Me.btnDGV.BackColor = System.Drawing.Color.White
        Me.btnDGV.FlatAppearance.BorderSize = 0
        Me.btnDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDGV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDGV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDGV.Location = New System.Drawing.Point(531, 55)
        Me.btnDGV.Name = "btnDGV"
        Me.btnDGV.Size = New System.Drawing.Size(109, 35)
        Me.btnDGV.TabIndex = 6
        Me.btnDGV.Text = "VIEW TABLE"
        Me.btnDGV.UseVisualStyleBackColor = False
        '
        'pnlDGV
        '
        Me.pnlDGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlDGV.Controls.Add(Me.btnHIDEDGV)
        Me.pnlDGV.Controls.Add(Me.Panel6)
        Me.pnlDGV.Location = New System.Drawing.Point(0, 0)
        Me.pnlDGV.Name = "pnlDGV"
        Me.pnlDGV.Size = New System.Drawing.Size(1324, 705)
        Me.pnlDGV.TabIndex = 107
        Me.pnlDGV.Visible = False
        '
        'btnHIDEDGV
        '
        Me.btnHIDEDGV.BackColor = System.Drawing.Color.White
        Me.btnHIDEDGV.FlatAppearance.BorderSize = 0
        Me.btnHIDEDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHIDEDGV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHIDEDGV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHIDEDGV.Location = New System.Drawing.Point(531, 55)
        Me.btnHIDEDGV.Name = "btnHIDEDGV"
        Me.btnHIDEDGV.Size = New System.Drawing.Size(109, 35)
        Me.btnHIDEDGV.TabIndex = 105
        Me.btnHIDEDGV.Text = "HIDE TABLE"
        Me.btnHIDEDGV.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel6.Controls.Add(Me.dgvPROFILE)
        Me.Panel6.Controls.Add(Me.dgvITEM)
        Me.Panel6.Location = New System.Drawing.Point(531, 107)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(756, 520)
        Me.Panel6.TabIndex = 104
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPROFILE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPROFILE.ColumnHeadersHeight = 65
        Me.dgvPROFILE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPROFILE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.ActivityDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn})
        Me.dgvPROFILE.DataSource = Me.TblactivityBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPROFILE.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPROFILE.EnableHeadersVisualStyles = False
        Me.dgvPROFILE.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvPROFILE.Location = New System.Drawing.Point(21, 21)
        Me.dgvPROFILE.Name = "dgvPROFILE"
        Me.dgvPROFILE.ReadOnly = True
        Me.dgvPROFILE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPROFILE.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPROFILE.RowHeadersVisible = False
        Me.dgvPROFILE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPROFILE.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvPROFILE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPROFILE.RowTemplate.DividerHeight = 1
        Me.dgvPROFILE.RowTemplate.Height = 45
        Me.dgvPROFILE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPROFILE.Size = New System.Drawing.Size(714, 478)
        Me.dgvPROFILE.TabIndex = 107
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ActivityDataGridViewTextBoxColumn
        '
        Me.ActivityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ActivityDataGridViewTextBoxColumn.DataPropertyName = "Activity"
        Me.ActivityDataGridViewTextBoxColumn.HeaderText = "ACTIVITY"
        Me.ActivityDataGridViewTextBoxColumn.Name = "ActivityDataGridViewTextBoxColumn"
        Me.ActivityDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActivityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "DATE AND TIME"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        Me.DateTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblactivityBindingSource
        '
        Me.TblactivityBindingSource.DataMember = "tbl_activity"
        Me.TblactivityBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'dgvITEM
        '
        Me.dgvITEM.AllowUserToAddRows = False
        Me.dgvITEM.AllowUserToDeleteRows = False
        Me.dgvITEM.AllowUserToResizeColumns = False
        Me.dgvITEM.AllowUserToResizeRows = False
        Me.dgvITEM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvITEM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvITEM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvITEM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvITEM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvITEM.ColumnHeadersHeight = 65
        Me.dgvITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvITEM.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvITEM.EnableHeadersVisualStyles = False
        Me.dgvITEM.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvITEM.Location = New System.Drawing.Point(22, 22)
        Me.dgvITEM.Name = "dgvITEM"
        Me.dgvITEM.ReadOnly = True
        Me.dgvITEM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvITEM.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvITEM.RowHeadersVisible = False
        Me.dgvITEM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvITEM.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvITEM.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvITEM.RowTemplate.DividerHeight = 1
        Me.dgvITEM.RowTemplate.Height = 45
        Me.dgvITEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvITEM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvITEM.Size = New System.Drawing.Size(892, 432)
        Me.dgvITEM.TabIndex = 62
        Me.dgvITEM.Visible = False
        '
        'UCrptACTIVITY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.pnlDGV)
        Me.Controls.Add(Me.btnDGV)
        Me.Controls.Add(Me.pnlREPORT)
        Me.Name = "UCrptACTIVITY"
        Me.Size = New System.Drawing.Size(1324, 705)
        CType(Me.tbl_activityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlREPORT.ResumeLayout(False)
        Me.pnlREPORT.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlDGV.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvPROFILE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblactivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvITEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFILTER As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtSTART As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtEND As DateTimePicker
    Friend WithEvents rptACT As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_activityBindingSource As BindingSource
    Friend WithEvents ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents tbl_activityTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_activityTableAdapter
    Friend WithEvents btnUNFILTER As Button
    Friend WithEvents btnDGV As Button
    Friend WithEvents pnlDGV As Panel
    Friend WithEvents btnHIDEDGV As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvPROFILE As DataGridView
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblactivityBindingSource As BindingSource
    Friend WithEvents dgvITEM As DataGridView
End Class
