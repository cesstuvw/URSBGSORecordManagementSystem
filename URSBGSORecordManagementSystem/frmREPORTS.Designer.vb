<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmREPORTS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_returnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.tbl_transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_profileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_itemstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_itemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.INDICATOR = New System.Windows.Forms.Panel()
        Me.btnRETREP = New System.Windows.Forms.Button()
        Me.btnTRANSREP = New System.Windows.Forms.Button()
        Me.btnBPROREP = New System.Windows.Forms.Button()
        Me.btnITSTREP = New System.Windows.Forms.Button()
        Me.btnITEMREP = New System.Windows.Forms.Button()
        Me.btnACTREP = New System.Windows.Forms.Button()
        Me.btnUAREP = New System.Windows.Forms.Button()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.rptRETURN = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptTRANSAC = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptPROFILE = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptITEMST = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptITEM = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptUSER = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_userTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_userTableAdapter()
        Me.tbl_itemTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter()
        Me.tbl_itemstockTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_itemstockTableAdapter()
        Me.tbl_profileTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_profileTableAdapter()
        Me.tbl_transactionTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_transactionTableAdapter()
        Me.tbl_returnTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_returnTableAdapter()
        CType(Me.tbl_returnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_profileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_itemstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlREPORT.SuspendLayout()
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
        'tbl_transactionBindingSource
        '
        Me.tbl_transactionBindingSource.DataMember = "tbl_transaction"
        Me.tbl_transactionBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'tbl_profileBindingSource
        '
        Me.tbl_profileBindingSource.DataMember = "tbl_profile"
        Me.tbl_profileBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'tbl_itemstockBindingSource
        '
        Me.tbl_itemstockBindingSource.DataMember = "tbl_itemstock"
        Me.tbl_itemstockBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'tbl_itemBindingSource
        '
        Me.tbl_itemBindingSource.DataMember = "tbl_item"
        Me.tbl_itemBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'tbl_userBindingSource
        '
        Me.tbl_userBindingSource.DataMember = "tbl_user"
        Me.tbl_userBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(327, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "REPORTS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.INDICATOR)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnRETREP)
        Me.Panel1.Controls.Add(Me.btnTRANSREP)
        Me.Panel1.Controls.Add(Me.btnBPROREP)
        Me.Panel1.Controls.Add(Me.btnITSTREP)
        Me.Panel1.Controls.Add(Me.btnITEMREP)
        Me.Panel1.Controls.Add(Me.btnACTREP)
        Me.Panel1.Controls.Add(Me.btnUAREP)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 707)
        Me.Panel1.TabIndex = 23
        '
        'INDICATOR
        '
        Me.INDICATOR.BackColor = System.Drawing.Color.White
        Me.INDICATOR.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.INDICATOR.Location = New System.Drawing.Point(282, 85)
        Me.INDICATOR.Name = "INDICATOR"
        Me.INDICATOR.Size = New System.Drawing.Size(5, 42)
        Me.INDICATOR.TabIndex = 25
        '
        'btnRETREP
        '
        Me.btnRETREP.BackColor = System.Drawing.Color.Transparent
        Me.btnRETREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRETREP.FlatAppearance.BorderSize = 0
        Me.btnRETREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRETREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnRETREP.ForeColor = System.Drawing.Color.White
        Me.btnRETREP.Location = New System.Drawing.Point(277, 349)
        Me.btnRETREP.Name = "btnRETREP"
        Me.btnRETREP.Size = New System.Drawing.Size(217, 42)
        Me.btnRETREP.TabIndex = 3
        Me.btnRETREP.Text = "           Return"
        Me.btnRETREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRETREP.UseVisualStyleBackColor = False
        '
        'btnTRANSREP
        '
        Me.btnTRANSREP.BackColor = System.Drawing.Color.Transparent
        Me.btnTRANSREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTRANSREP.FlatAppearance.BorderSize = 0
        Me.btnTRANSREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTRANSREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnTRANSREP.ForeColor = System.Drawing.Color.White
        Me.btnTRANSREP.Location = New System.Drawing.Point(274, 305)
        Me.btnTRANSREP.Name = "btnTRANSREP"
        Me.btnTRANSREP.Size = New System.Drawing.Size(217, 42)
        Me.btnTRANSREP.TabIndex = 3
        Me.btnTRANSREP.Text = "           Transaction"
        Me.btnTRANSREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTRANSREP.UseVisualStyleBackColor = False
        '
        'btnBPROREP
        '
        Me.btnBPROREP.BackColor = System.Drawing.Color.Transparent
        Me.btnBPROREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBPROREP.FlatAppearance.BorderSize = 0
        Me.btnBPROREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPROREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnBPROREP.ForeColor = System.Drawing.Color.White
        Me.btnBPROREP.Location = New System.Drawing.Point(277, 261)
        Me.btnBPROREP.Name = "btnBPROREP"
        Me.btnBPROREP.Size = New System.Drawing.Size(217, 42)
        Me.btnBPROREP.TabIndex = 3
        Me.btnBPROREP.Text = "           Borrower's Profile"
        Me.btnBPROREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBPROREP.UseVisualStyleBackColor = False
        '
        'btnITSTREP
        '
        Me.btnITSTREP.BackColor = System.Drawing.Color.Transparent
        Me.btnITSTREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnITSTREP.FlatAppearance.BorderSize = 0
        Me.btnITSTREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnITSTREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnITSTREP.ForeColor = System.Drawing.Color.White
        Me.btnITSTREP.Location = New System.Drawing.Point(277, 217)
        Me.btnITSTREP.Name = "btnITSTREP"
        Me.btnITSTREP.Size = New System.Drawing.Size(217, 42)
        Me.btnITSTREP.TabIndex = 3
        Me.btnITSTREP.Text = "           Item Stock"
        Me.btnITSTREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnITSTREP.UseVisualStyleBackColor = False
        '
        'btnITEMREP
        '
        Me.btnITEMREP.BackColor = System.Drawing.Color.Transparent
        Me.btnITEMREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnITEMREP.FlatAppearance.BorderSize = 0
        Me.btnITEMREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnITEMREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnITEMREP.ForeColor = System.Drawing.Color.White
        Me.btnITEMREP.Location = New System.Drawing.Point(277, 173)
        Me.btnITEMREP.Name = "btnITEMREP"
        Me.btnITEMREP.Size = New System.Drawing.Size(217, 42)
        Me.btnITEMREP.TabIndex = 3
        Me.btnITEMREP.Text = "           Item"
        Me.btnITEMREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnITEMREP.UseVisualStyleBackColor = False
        '
        'btnACTREP
        '
        Me.btnACTREP.BackColor = System.Drawing.Color.Transparent
        Me.btnACTREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnACTREP.FlatAppearance.BorderSize = 0
        Me.btnACTREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnACTREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnACTREP.ForeColor = System.Drawing.Color.White
        Me.btnACTREP.Location = New System.Drawing.Point(277, 129)
        Me.btnACTREP.Name = "btnACTREP"
        Me.btnACTREP.Size = New System.Drawing.Size(217, 42)
        Me.btnACTREP.TabIndex = 3
        Me.btnACTREP.Text = "           Activity Log"
        Me.btnACTREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnACTREP.UseVisualStyleBackColor = False
        '
        'btnUAREP
        '
        Me.btnUAREP.BackColor = System.Drawing.Color.Transparent
        Me.btnUAREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUAREP.FlatAppearance.BorderSize = 0
        Me.btnUAREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUAREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnUAREP.ForeColor = System.Drawing.Color.White
        Me.btnUAREP.Location = New System.Drawing.Point(277, 85)
        Me.btnUAREP.Name = "btnUAREP"
        Me.btnUAREP.Size = New System.Drawing.Size(217, 42)
        Me.btnUAREP.TabIndex = 3
        Me.btnUAREP.Text = "           User Account"
        Me.btnUAREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUAREP.UseVisualStyleBackColor = False
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.rptRETURN)
        Me.pnlREPORT.Controls.Add(Me.rptTRANSAC)
        Me.pnlREPORT.Controls.Add(Me.rptPROFILE)
        Me.pnlREPORT.Controls.Add(Me.rptITEMST)
        Me.pnlREPORT.Controls.Add(Me.rptITEM)
        Me.pnlREPORT.Controls.Add(Me.rptUSER)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 51)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 618)
        Me.pnlREPORT.TabIndex = 25
        '
        'rptRETURN
        '
        ReportDataSource1.Name = "DataSet_RETURN"
        ReportDataSource1.Value = Me.tbl_returnBindingSource
        Me.rptRETURN.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptRETURN.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptRETURN.rdlc"
        Me.rptRETURN.Location = New System.Drawing.Point(20, 17)
        Me.rptRETURN.Name = "rptRETURN"
        Me.rptRETURN.ServerReport.BearerToken = Nothing
        Me.rptRETURN.Size = New System.Drawing.Size(718, 581)
        Me.rptRETURN.TabIndex = 5
        Me.rptRETURN.Visible = False
        '
        'rptTRANSAC
        '
        ReportDataSource2.Name = "DataSet_TRANSACTION"
        ReportDataSource2.Value = Me.tbl_transactionBindingSource
        Me.rptTRANSAC.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptTRANSAC.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptTRANSAC.rdlc"
        Me.rptTRANSAC.Location = New System.Drawing.Point(20, 17)
        Me.rptTRANSAC.Name = "rptTRANSAC"
        Me.rptTRANSAC.ServerReport.BearerToken = Nothing
        Me.rptTRANSAC.Size = New System.Drawing.Size(718, 581)
        Me.rptTRANSAC.TabIndex = 4
        Me.rptTRANSAC.Visible = False
        '
        'rptPROFILE
        '
        ReportDataSource3.Name = "DataSet_BorrowersProfile"
        ReportDataSource3.Value = Me.tbl_profileBindingSource
        Me.rptPROFILE.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rptPROFILE.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptPROFILE.rdlc"
        Me.rptPROFILE.Location = New System.Drawing.Point(20, 17)
        Me.rptPROFILE.Name = "rptPROFILE"
        Me.rptPROFILE.ServerReport.BearerToken = Nothing
        Me.rptPROFILE.Size = New System.Drawing.Size(718, 581)
        Me.rptPROFILE.TabIndex = 3
        Me.rptPROFILE.Visible = False
        '
        'rptITEMST
        '
        ReportDataSource4.Name = "DataSet_ITEMSTOCK"
        ReportDataSource4.Value = Me.tbl_itemstockBindingSource
        Me.rptITEMST.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rptITEMST.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptITEMST.rdlc"
        Me.rptITEMST.Location = New System.Drawing.Point(20, 17)
        Me.rptITEMST.Name = "rptITEMST"
        Me.rptITEMST.ServerReport.BearerToken = Nothing
        Me.rptITEMST.Size = New System.Drawing.Size(718, 581)
        Me.rptITEMST.TabIndex = 2
        Me.rptITEMST.Visible = False
        '
        'rptITEM
        '
        ReportDataSource5.Name = "DataSet_ITEM"
        ReportDataSource5.Value = Me.tbl_itemBindingSource
        Me.rptITEM.LocalReport.DataSources.Add(ReportDataSource5)
        Me.rptITEM.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptITEM.rdlc"
        Me.rptITEM.Location = New System.Drawing.Point(20, 17)
        Me.rptITEM.Name = "rptITEM"
        Me.rptITEM.ServerReport.BearerToken = Nothing
        Me.rptITEM.Size = New System.Drawing.Size(718, 581)
        Me.rptITEM.TabIndex = 1
        Me.rptITEM.Visible = False
        '
        'rptUSER
        '
        ReportDataSource6.Name = "DataSet_USERACCOUNT"
        ReportDataSource6.Value = Me.tbl_userBindingSource
        Me.rptUSER.LocalReport.DataSources.Add(ReportDataSource6)
        Me.rptUSER.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptUSERACCOUNT.rdlc"
        Me.rptUSER.Location = New System.Drawing.Point(20, 17)
        Me.rptUSER.Name = "rptUSER"
        Me.rptUSER.ServerReport.BearerToken = Nothing
        Me.rptUSER.Size = New System.Drawing.Size(718, 581)
        Me.rptUSER.TabIndex = 0
        '
        'tbl_userTableAdapter
        '
        Me.tbl_userTableAdapter.ClearBeforeFill = True
        '
        'tbl_itemTableAdapter
        '
        Me.tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'tbl_itemstockTableAdapter
        '
        Me.tbl_itemstockTableAdapter.ClearBeforeFill = True
        '
        'tbl_profileTableAdapter
        '
        Me.tbl_profileTableAdapter.ClearBeforeFill = True
        '
        'tbl_transactionTableAdapter
        '
        Me.tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'tbl_returnTableAdapter
        '
        Me.tbl_returnTableAdapter.ClearBeforeFill = True
        '
        'frmREPORTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1324, 705)
        Me.Controls.Add(Me.pnlREPORT)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmREPORTS"
        Me.Text = "frmREPORTS"
        CType(Me.tbl_returnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_profileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_itemstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlREPORT.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRETREP As Button
    Friend WithEvents btnTRANSACREP As Button
    Friend WithEvents btnBPROREP As Button
    'Friend WithEvents btnTRANSACREP As Button
    Friend WithEvents btnITEMREP As Button
    Friend WithEvents btnACTREP As Button
    Friend WithEvents btnUAREP As Button
    Friend WithEvents INDICATOR As Panel
    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents rptUSER As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_userBindingSource As BindingSource
    Friend WithEvents ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents tbl_userTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents rptITEM As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_itemBindingSource As BindingSource
    Friend WithEvents tbl_itemTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_itemTableAdapter
    Friend WithEvents rptITEMST As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_itemstockBindingSource As BindingSource
    Friend WithEvents tbl_itemstockTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_itemstockTableAdapter
    Friend WithEvents rptPROFILE As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_profileBindingSource As BindingSource
    Friend WithEvents tbl_profileTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_profileTableAdapter
    Friend WithEvents rptTRANSAC As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transactionBindingSource As BindingSource
    Friend WithEvents tbl_transactionTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_transactionTableAdapter
    Friend WithEvents rptRETURN As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_returnBindingSource As BindingSource
    Friend WithEvents tbl_returnTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_returnTableAdapter
    Friend WithEvents btnTRANSREP As Button
    Friend WithEvents btnITSTREP As Button
End Class
