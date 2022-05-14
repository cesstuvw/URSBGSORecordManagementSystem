<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmREPORTSSTAFF
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_profileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.INDICATOR = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRETREP = New System.Windows.Forms.Button()
        Me.btnTRANSREP = New System.Windows.Forms.Button()
        Me.btnBPROREP = New System.Windows.Forms.Button()
        Me.tbl_profileTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_profileTableAdapter()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboTYPE = New System.Windows.Forms.ComboBox()
        Me.btnFILTER = New System.Windows.Forms.Button()
        Me.btnUNFILTER = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rptPROFILE = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlBP = New System.Windows.Forms.Panel()
        Me.pnlREPS = New System.Windows.Forms.Panel()
        CType(Me.tbl_profileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlREPORT.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlBP.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_profileBindingSource
        '
        Me.tbl_profileBindingSource.DataMember = "tbl_profile"
        Me.tbl_profileBindingSource.DataSource = Me.ursbgso_dbDataSet
        '
        'ursbgso_dbDataSet
        '
        Me.ursbgso_dbDataSet.DataSetName = "ursbgso_dbDataSet"
        Me.ursbgso_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.INDICATOR)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnRETREP)
        Me.Panel1.Controls.Add(Me.btnTRANSREP)
        Me.Panel1.Controls.Add(Me.btnBPROREP)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 707)
        Me.Panel1.TabIndex = 24
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
        'btnRETREP
        '
        Me.btnRETREP.BackColor = System.Drawing.Color.Transparent
        Me.btnRETREP.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.return_menu_reports
        Me.btnRETREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRETREP.FlatAppearance.BorderSize = 0
        Me.btnRETREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRETREP.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnRETREP.ForeColor = System.Drawing.Color.White
        Me.btnRETREP.Location = New System.Drawing.Point(268, 171)
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
        Me.btnTRANSREP.Location = New System.Drawing.Point(268, 128)
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
        Me.btnBPROREP.Location = New System.Drawing.Point(268, 85)
        Me.btnBPROREP.Name = "btnBPROREP"
        Me.btnBPROREP.Size = New System.Drawing.Size(280, 42)
        Me.btnBPROREP.TabIndex = 3
        Me.btnBPROREP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBPROREP.UseVisualStyleBackColor = False
        '
        'tbl_profileTableAdapter
        '
        Me.tbl_profileTableAdapter.ClearBeforeFill = True
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.rptPROFILE)
        Me.pnlREPORT.Controls.Add(Me.Label3)
        Me.pnlREPORT.Controls.Add(Me.Label1)
        Me.pnlREPORT.Controls.Add(Me.btnUNFILTER)
        Me.pnlREPORT.Controls.Add(Me.btnFILTER)
        Me.pnlREPORT.Controls.Add(Me.Panel2)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 58)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 618)
        Me.pnlREPORT.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cboTYPE)
        Me.Panel2.Location = New System.Drawing.Point(473, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 35)
        Me.Panel2.TabIndex = 2
        '
        'cboTYPE
        '
        Me.cboTYPE.AutoCompleteCustomSource.AddRange(New String() {"GSO Head", "Staff"})
        Me.cboTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTYPE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTYPE.FormattingEnabled = True
        Me.cboTYPE.Items.AddRange(New Object() {"Student", "Faculty"})
        Me.cboTYPE.Location = New System.Drawing.Point(7, 5)
        Me.cboTYPE.Name = "cboTYPE"
        Me.cboTYPE.Size = New System.Drawing.Size(127, 24)
        Me.cboTYPE.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BORROWER'S PROFILE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(325, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter by Borrower Type"
        '
        'rptPROFILE
        '
        Me.rptPROFILE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rptPROFILE.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "DataSet_BorrowersProfile"
        ReportDataSource2.Value = Me.tbl_profileBindingSource
        Me.rptPROFILE.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptPROFILE.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptPROFILE.rdlc"
        Me.rptPROFILE.Location = New System.Drawing.Point(21, 72)
        Me.rptPROFILE.Name = "rptPROFILE"
        Me.rptPROFILE.ServerReport.BearerToken = Nothing
        Me.rptPROFILE.Size = New System.Drawing.Size(716, 527)
        Me.rptPROFILE.TabIndex = 6
        '
        'pnlBP
        '
        Me.pnlBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlBP.Controls.Add(Me.pnlREPS)
        Me.pnlBP.Controls.Add(Me.pnlREPORT)
        Me.pnlBP.Location = New System.Drawing.Point(0, 0)
        Me.pnlBP.Name = "pnlBP"
        Me.pnlBP.Size = New System.Drawing.Size(1324, 705)
        Me.pnlBP.TabIndex = 27
        '
        'pnlREPS
        '
        Me.pnlREPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlREPS.Location = New System.Drawing.Point(0, 0)
        Me.pnlREPS.Name = "pnlREPS"
        Me.pnlREPS.Size = New System.Drawing.Size(1324, 705)
        Me.pnlREPS.TabIndex = 31
        '
        'frmREPORTSSTAFF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1324, 705)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmREPORTSSTAFF"
        Me.Text = "frmREPORTSTAFF"
        CType(Me.tbl_profileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlREPORT.ResumeLayout(False)
        Me.pnlREPORT.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlBP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents INDICATOR As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRETREP As Button
    Friend WithEvents btnTRANSREP As Button
    Friend WithEvents btnBPROREP As Button
    Friend WithEvents tbl_profileBindingSource As BindingSource
    Friend WithEvents ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents tbl_profileTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_profileTableAdapter
    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents rptPROFILE As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUNFILTER As Button
    Friend WithEvents btnFILTER As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cboTYPE As ComboBox
    Friend WithEvents pnlBP As Panel
    Friend WithEvents pnlREPS As Panel
End Class
