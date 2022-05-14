<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmREPORTSHEAD
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
        Me.tbl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
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
        Me.pnlUA = New System.Windows.Forms.Panel()
        Me.pnlREP = New System.Windows.Forms.Panel()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.rptUSER = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUNFILTER = New System.Windows.Forms.Button()
        Me.btnFILTER = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboUSERTYPE = New System.Windows.Forms.ComboBox()
        Me.tbl_userTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_userTableAdapter()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlUA.SuspendLayout()
        Me.pnlREPORT.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_userBindingSource
        '
        Me.tbl_userBindingSource.DataMember = "tbl_user"
        Me.tbl_userBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'ursbgso_dbDataSet
        '
        Me.ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnRETREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.return_menu_reports
        Me.btnRETREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRETREP.FlatAppearance.BorderSize = 0
        Me.btnRETREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRETREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnRETREP.ForeColor = System.Drawing.Color.White
        Me.btnRETREP.Location = New System.Drawing.Point(268, 343)
        Me.btnRETREP.Name = "btnRETREP"
        Me.btnRETREP.Size = New System.Drawing.Size(280, 42)
        Me.btnRETREP.TabIndex = 3
        Me.btnRETREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRETREP.UseVisualStyleBackColor = False
        '
        'btnTRANSREP
        '
        Me.btnTRANSREP.BackColor = System.Drawing.Color.Transparent
        Me.btnTRANSREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.transaction_menu_reports
        Me.btnTRANSREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTRANSREP.FlatAppearance.BorderSize = 0
        Me.btnTRANSREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTRANSREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnTRANSREP.ForeColor = System.Drawing.Color.White
        Me.btnTRANSREP.Location = New System.Drawing.Point(268, 300)
        Me.btnTRANSREP.Name = "btnTRANSREP"
        Me.btnTRANSREP.Size = New System.Drawing.Size(280, 42)
        Me.btnTRANSREP.TabIndex = 3
        Me.btnTRANSREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTRANSREP.UseVisualStyleBackColor = False
        '
        'btnBPROREP
        '
        Me.btnBPROREP.BackColor = System.Drawing.Color.Transparent
        Me.btnBPROREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.profile_menu_reports
        Me.btnBPROREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBPROREP.FlatAppearance.BorderSize = 0
        Me.btnBPROREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPROREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnBPROREP.ForeColor = System.Drawing.Color.White
        Me.btnBPROREP.Location = New System.Drawing.Point(268, 257)
        Me.btnBPROREP.Name = "btnBPROREP"
        Me.btnBPROREP.Size = New System.Drawing.Size(280, 42)
        Me.btnBPROREP.TabIndex = 3
        Me.btnBPROREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBPROREP.UseVisualStyleBackColor = False
        '
        'btnITSTREP
        '
        Me.btnITSTREP.BackColor = System.Drawing.Color.Transparent
        Me.btnITSTREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.itemstocks_menu_reports
        Me.btnITSTREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnITSTREP.FlatAppearance.BorderSize = 0
        Me.btnITSTREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnITSTREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnITSTREP.ForeColor = System.Drawing.Color.White
        Me.btnITSTREP.Location = New System.Drawing.Point(268, 214)
        Me.btnITSTREP.Name = "btnITSTREP"
        Me.btnITSTREP.Size = New System.Drawing.Size(280, 42)
        Me.btnITSTREP.TabIndex = 3
        Me.btnITSTREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnITSTREP.UseVisualStyleBackColor = False
        '
        'btnITEMREP
        '
        Me.btnITEMREP.BackColor = System.Drawing.Color.Transparent
        Me.btnITEMREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.item_menu_reports
        Me.btnITEMREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnITEMREP.FlatAppearance.BorderSize = 0
        Me.btnITEMREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnITEMREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnITEMREP.ForeColor = System.Drawing.Color.White
        Me.btnITEMREP.Location = New System.Drawing.Point(268, 171)
        Me.btnITEMREP.Name = "btnITEMREP"
        Me.btnITEMREP.Size = New System.Drawing.Size(280, 42)
        Me.btnITEMREP.TabIndex = 3
        Me.btnITEMREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnITEMREP.UseVisualStyleBackColor = False
        '
        'btnACTREP
        '
        Me.btnACTREP.BackColor = System.Drawing.Color.Transparent
        Me.btnACTREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.activitylog_menu_reports
        Me.btnACTREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnACTREP.FlatAppearance.BorderSize = 0
        Me.btnACTREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnACTREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnACTREP.ForeColor = System.Drawing.Color.White
        Me.btnACTREP.Location = New System.Drawing.Point(268, 128)
        Me.btnACTREP.Name = "btnACTREP"
        Me.btnACTREP.Size = New System.Drawing.Size(280, 42)
        Me.btnACTREP.TabIndex = 3
        Me.btnACTREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnACTREP.UseVisualStyleBackColor = False
        '
        'btnUAREP
        '
        Me.btnUAREP.BackColor = System.Drawing.Color.Transparent
        Me.btnUAREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.useraccount_menu_reports
        Me.btnUAREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUAREP.FlatAppearance.BorderSize = 0
        Me.btnUAREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUAREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnUAREP.ForeColor = System.Drawing.Color.White
        Me.btnUAREP.Location = New System.Drawing.Point(268, 85)
        Me.btnUAREP.Name = "btnUAREP"
        Me.btnUAREP.Size = New System.Drawing.Size(280, 42)
        Me.btnUAREP.TabIndex = 3
        Me.btnUAREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUAREP.UseVisualStyleBackColor = False
        '
        'pnlUA
        '
        Me.pnlUA.Controls.Add(Me.pnlREP)
        Me.pnlUA.Controls.Add(Me.pnlREPORT)
        Me.pnlUA.Location = New System.Drawing.Point(0, 0)
        Me.pnlUA.Name = "pnlUA"
        Me.pnlUA.Size = New System.Drawing.Size(1324, 705)
        Me.pnlUA.TabIndex = 26
        '
        'pnlREP
        '
        Me.pnlREP.Location = New System.Drawing.Point(0, 0)
        Me.pnlREP.Name = "pnlREP"
        Me.pnlREP.Size = New System.Drawing.Size(1324, 705)
        Me.pnlREP.TabIndex = 27
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.rptUSER)
        Me.pnlREPORT.Controls.Add(Me.Label3)
        Me.pnlREPORT.Controls.Add(Me.Label1)
        Me.pnlREPORT.Controls.Add(Me.btnUNFILTER)
        Me.pnlREPORT.Controls.Add(Me.btnFILTER)
        Me.pnlREPORT.Controls.Add(Me.Panel2)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 58)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 618)
        Me.pnlREPORT.TabIndex = 26
        '
        'rptUSER
        '
        Me.rptUSER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rptUSER.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet_USERACCOUNT"
        ReportDataSource1.Value = Me.tbl_userBindingSource
        Me.rptUSER.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptUSER.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptUSERACCOUNT.rdlc"
        Me.rptUSER.Location = New System.Drawing.Point(21, 72)
        Me.rptUSER.Name = "rptUSER"
        Me.rptUSER.ServerReport.BearerToken = Nothing
        Me.rptUSER.Size = New System.Drawing.Size(716, 527)
        Me.rptUSER.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(349, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter by User Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USER ACCOUNT"
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
        Me.btnUNFILTER.TabIndex = 4
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
        Me.Panel2.Controls.Add(Me.cboUSERTYPE)
        Me.Panel2.Location = New System.Drawing.Point(473, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 35)
        Me.Panel2.TabIndex = 2
        '
        'cboUSERTYPE
        '
        Me.cboUSERTYPE.AutoCompleteCustomSource.AddRange(New String() {"GSO Head", "Staff"})
        Me.cboUSERTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUSERTYPE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUSERTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboUSERTYPE.FormattingEnabled = True
        Me.cboUSERTYPE.Items.AddRange(New Object() {"GSO Head", "Staff"})
        Me.cboUSERTYPE.Location = New System.Drawing.Point(7, 5)
        Me.cboUSERTYPE.Name = "cboUSERTYPE"
        Me.cboUSERTYPE.Size = New System.Drawing.Size(127, 24)
        Me.cboUSERTYPE.TabIndex = 2
        '
        'tbl_userTableAdapter
        '
        Me.tbl_userTableAdapter.ClearBeforeFill = True
        '
        'frmREPORTSHEAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1324, 705)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlUA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmREPORTSHEAD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmREPORTS"
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlUA.ResumeLayout(False)
        Me.pnlREPORT.ResumeLayout(False)
        Me.pnlREPORT.PerformLayout()
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents btnTRANSREP As Button
    Friend WithEvents btnITSTREP As Button
    Friend WithEvents pnlUA As Panel
    Friend WithEvents tbl_userBindingSource As BindingSource
    Friend WithEvents ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents tbl_userTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUNFILTER As Button
    Friend WithEvents btnFILTER As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboUSERTYPE As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlREP As Panel
    Friend WithEvents rptUSER As Microsoft.Reporting.WinForms.ReportViewer
End Class
