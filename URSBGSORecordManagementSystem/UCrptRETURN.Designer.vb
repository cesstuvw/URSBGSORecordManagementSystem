<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCrptRETURN
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_returnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUNFILTER = New System.Windows.Forms.Button()
        Me.btnFILTER = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboTYPE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUNDATE = New System.Windows.Forms.Button()
        Me.btnDATE = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtEND = New System.Windows.Forms.DateTimePicker()
        Me.dtSTART = New System.Windows.Forms.DateTimePicker()
        Me.rptRETURN = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbl_returnTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_returnTableAdapter()
        CType(Me.tbl_returnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlREPORT.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_returnBindingSource
        '
        Me.tbl_returnBindingSource.DataMember = "tbl_return"
        Me.tbl_returnBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'ursbgso_dbDataSet
        '
        Me.ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.Panel3)
        Me.pnlREPORT.Controls.Add(Me.rptRETURN)
        Me.pnlREPORT.Controls.Add(Me.Label1)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 58)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 618)
        Me.pnlREPORT.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnUNFILTER)
        Me.Panel3.Controls.Add(Me.btnFILTER)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnUNDATE)
        Me.Panel3.Controls.Add(Me.btnDATE)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(188, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(567, 100)
        Me.Panel3.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Filter by Borrower Type"
        '
        'btnUNFILTER
        '
        Me.btnUNFILTER.BackColor = System.Drawing.Color.White
        Me.btnUNFILTER.FlatAppearance.BorderSize = 0
        Me.btnUNFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUNFILTER.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUNFILTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUNFILTER.Location = New System.Drawing.Point(440, 50)
        Me.btnUNFILTER.Name = "btnUNFILTER"
        Me.btnUNFILTER.Size = New System.Drawing.Size(109, 35)
        Me.btnUNFILTER.TabIndex = 16
        Me.btnUNFILTER.Text = "Unfilter"
        Me.btnUNFILTER.UseVisualStyleBackColor = False
        Me.btnUNFILTER.Visible = False
        '
        'btnFILTER
        '
        Me.btnFILTER.BackColor = System.Drawing.Color.White
        Me.btnFILTER.FlatAppearance.BorderSize = 0
        Me.btnFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFILTER.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFILTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFILTER.Location = New System.Drawing.Point(440, 50)
        Me.btnFILTER.Name = "btnFILTER"
        Me.btnFILTER.Size = New System.Drawing.Size(109, 35)
        Me.btnFILTER.TabIndex = 15
        Me.btnFILTER.Text = "Filter"
        Me.btnFILTER.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cboTYPE)
        Me.Panel1.Location = New System.Drawing.Point(184, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 35)
        Me.Panel1.TabIndex = 14
        '
        'cboTYPE
        '
        Me.cboTYPE.AutoCompleteCustomSource.AddRange(New String() {"GSO Head", "Staff"})
        Me.cboTYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTYPE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTYPE.FormattingEnabled = True
        Me.cboTYPE.Items.AddRange(New Object() {"Student", "Faculty"})
        Me.cboTYPE.Location = New System.Drawing.Point(8, 5)
        Me.cboTYPE.Name = "cboTYPE"
        Me.cboTYPE.Size = New System.Drawing.Size(230, 24)
        Me.cboTYPE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Filter by Date"
        '
        'btnUNDATE
        '
        Me.btnUNDATE.BackColor = System.Drawing.Color.White
        Me.btnUNDATE.FlatAppearance.BorderSize = 0
        Me.btnUNDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUNDATE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUNDATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUNDATE.Location = New System.Drawing.Point(440, 7)
        Me.btnUNDATE.Name = "btnUNDATE"
        Me.btnUNDATE.Size = New System.Drawing.Size(109, 35)
        Me.btnUNDATE.TabIndex = 12
        Me.btnUNDATE.Text = "Unfilter"
        Me.btnUNDATE.UseVisualStyleBackColor = False
        Me.btnUNDATE.Visible = False
        '
        'btnDATE
        '
        Me.btnDATE.BackColor = System.Drawing.Color.White
        Me.btnDATE.FlatAppearance.BorderSize = 0
        Me.btnDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDATE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDATE.Location = New System.Drawing.Point(440, 7)
        Me.btnDATE.Name = "btnDATE"
        Me.btnDATE.Size = New System.Drawing.Size(109, 35)
        Me.btnDATE.TabIndex = 11
        Me.btnDATE.Text = "Filter"
        Me.btnDATE.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtEND)
        Me.Panel2.Controls.Add(Me.dtSTART)
        Me.Panel2.Location = New System.Drawing.Point(136, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 35)
        Me.Panel2.TabIndex = 10
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
        'rptRETURN
        '
        Me.rptRETURN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rptRETURN.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "DataSet_Return"
        ReportDataSource2.Value = Me.tbl_returnBindingSource
        Me.rptRETURN.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptRETURN.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptRETURN.rdlc"
        Me.rptRETURN.Location = New System.Drawing.Point(21, 112)
        Me.rptRETURN.Name = "rptRETURN"
        Me.rptRETURN.ServerReport.BearerToken = Nothing
        Me.rptRETURN.Size = New System.Drawing.Size(716, 487)
        Me.rptRETURN.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RETURN"
        '
        'tbl_returnTableAdapter
        '
        Me.tbl_returnTableAdapter.ClearBeforeFill = True
        '
        'UCrptRETURN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.pnlREPORT)
        Me.Name = "UCrptRETURN"
        Me.Size = New System.Drawing.Size(1324, 705)
        CType(Me.tbl_returnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlREPORT.ResumeLayout(False)
        Me.pnlREPORT.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents rptRETURN As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_returnBindingSource As BindingSource
    Friend WithEvents ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents tbl_returnTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_returnTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUNFILTER As Button
    Friend WithEvents btnFILTER As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboTYPE As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUNDATE As Button
    Friend WithEvents btnDATE As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtEND As DateTimePicker
    Friend WithEvents dtSTART As DateTimePicker
End Class
