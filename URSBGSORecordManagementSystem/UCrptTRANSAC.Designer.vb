﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCrptTRANSAC
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rptTRANSAC = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtDATETIME = New System.Windows.Forms.DateTimePicker()
        Me.dtDATETIME1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFILTER = New System.Windows.Forms.Button()
        Me.btnUNFILTER = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.ursbgso_dbDataSet = New URSBGSORecordManagementSystem.ursbgso_dbDataSet()
        Me.tbl_transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_transactionTableAdapter = New URSBGSORecordManagementSystem.ursbgso_dbDataSetTableAdapters.tbl_transactionTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.pnlREPORT.SuspendLayout()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptTRANSAC
        '
        Me.rptTRANSAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rptTRANSAC.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet_TRANSACTION"
        ReportDataSource1.Value = Me.tbl_transactionBindingSource
        Me.rptTRANSAC.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptTRANSAC.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptTRANSAC.rdlc"
        Me.rptTRANSAC.Location = New System.Drawing.Point(21, 72)
        Me.rptTRANSAC.Name = "rptTRANSAC"
        Me.rptTRANSAC.ServerReport.BearerToken = Nothing
        Me.rptTRANSAC.Size = New System.Drawing.Size(716, 527)
        Me.rptTRANSAC.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtDATETIME1)
        Me.Panel2.Controls.Add(Me.dtDATETIME)
        Me.Panel2.Location = New System.Drawing.Point(322, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 35)
        Me.Panel2.TabIndex = 2
        '
        'dtDATETIME
        '
        Me.dtDATETIME.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtDATETIME.CustomFormat = "yyyy-MM-dd"
        Me.dtDATETIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDATETIME.Location = New System.Drawing.Point(16, 8)
        Me.dtDATETIME.Name = "dtDATETIME"
        Me.dtDATETIME.Size = New System.Drawing.Size(110, 20)
        Me.dtDATETIME.TabIndex = 6
        Me.dtDATETIME.Value = New Date(2022, 5, 5, 0, 0, 0, 0)
        '
        'dtDATETIME1
        '
        Me.dtDATETIME1.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtDATETIME1.CustomFormat = "yyyy-MM-dd"
        Me.dtDATETIME1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDATETIME1.Location = New System.Drawing.Point(165, 8)
        Me.dtDATETIME1.Name = "dtDATETIME1"
        Me.dtDATETIME1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtDATETIME1.Size = New System.Drawing.Size(110, 20)
        Me.dtDATETIME1.TabIndex = 6
        Me.dtDATETIME1.Value = New Date(2022, 5, 10, 0, 0, 0, 0)
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
        Me.Label1.Size = New System.Drawing.Size(126, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TRANSACTION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(223, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter by Date"
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.Label3)
        Me.pnlREPORT.Controls.Add(Me.Label1)
        Me.pnlREPORT.Controls.Add(Me.btnUNFILTER)
        Me.pnlREPORT.Controls.Add(Me.btnFILTER)
        Me.pnlREPORT.Controls.Add(Me.Panel2)
        Me.pnlREPORT.Controls.Add(Me.rptTRANSAC)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 58)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 618)
        Me.pnlREPORT.TabIndex = 28
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
        'tbl_transactionTableAdapter
        '
        Me.tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'UCrptTRANSAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.pnlREPORT)
        Me.Name = "UCrptTRANSAC"
        Me.Size = New System.Drawing.Size(1324, 705)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlREPORT.ResumeLayout(False)
        Me.pnlREPORT.PerformLayout()
        CType(Me.ursbgso_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptTRANSAC As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtDATETIME1 As DateTimePicker
    Friend WithEvents dtDATETIME As DateTimePicker
    Friend WithEvents btnFILTER As Button
    Friend WithEvents btnUNFILTER As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents tbl_transactionBindingSource As BindingSource
    Friend WithEvents ursbgso_dbDataSet As ursbgso_dbDataSet
    Friend WithEvents tbl_transactionTableAdapter As ursbgso_dbDataSetTableAdapters.tbl_transactionTableAdapter
End Class
