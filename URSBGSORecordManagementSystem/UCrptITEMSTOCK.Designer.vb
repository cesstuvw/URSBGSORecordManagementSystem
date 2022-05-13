<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCrptITEMSTOCK
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.pnlREPORT = New System.Windows.Forms.Panel()
        Me.rptITEMM = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtDATETIME1 = New System.Windows.Forms.DateTimePicker()
        Me.dtDATETIME = New System.Windows.Forms.DateTimePicker()
        Me.pnlREPORT.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlREPORT
        '
        Me.pnlREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlREPORT.Controls.Add(Me.rptITEMM)
        Me.pnlREPORT.Controls.Add(Me.Label1)
        Me.pnlREPORT.Location = New System.Drawing.Point(531, 58)
        Me.pnlREPORT.Name = "pnlREPORT"
        Me.pnlREPORT.Size = New System.Drawing.Size(756, 618)
        Me.pnlREPORT.TabIndex = 28
        '
        'rptITEMM
        '
        Me.rptITEMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rptITEMM.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet_ITEM"
        ReportDataSource1.Value = Nothing
        Me.rptITEMM.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptITEMM.LocalReport.ReportEmbeddedResource = "URSBGSORecordManagementSystem.rptITEM.rdlc"
        Me.rptITEMM.Location = New System.Drawing.Point(21, 72)
        Me.rptITEMM.Name = "rptITEMM"
        Me.rptITEMM.ServerReport.BearerToken = Nothing
        Me.rptITEMM.Size = New System.Drawing.Size(716, 527)
        Me.rptITEMM.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ITEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(747, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Filter by Date"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1156, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 35)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Unfilter"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1156, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 35)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtDATETIME1)
        Me.Panel1.Controls.Add(Me.dtDATETIME)
        Me.Panel1.Location = New System.Drawing.Point(849, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 35)
        Me.Panel1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(137, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "to"
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
        'UCrptITEMSTOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlREPORT)
        Me.Name = "UCrptITEMSTOCK"
        Me.Size = New System.Drawing.Size(1324, 705)
        Me.pnlREPORT.ResumeLayout(False)
        Me.pnlREPORT.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlREPORT As Panel
    Friend WithEvents rptITEMM As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dtDATETIME1 As DateTimePicker
    Friend WithEvents dtDATETIME As DateTimePicker
End Class
