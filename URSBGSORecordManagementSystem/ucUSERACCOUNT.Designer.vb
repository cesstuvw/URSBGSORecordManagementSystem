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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUSERACCOUNT))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.btnADDUSER = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnEDIT = New System.Windows.Forms.PictureBox()
        Me.btnVIEW = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnADDUSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "USER ACCOUNT"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.searchbar
        Me.PictureBox4.Location = New System.Drawing.Point(318, 87)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(211, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSEARCH.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtSEARCH.Location = New System.Drawing.Point(335, 95)
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(102, 16)
        Me.txtSEARCH.TabIndex = 25
        Me.txtSEARCH.Text = "Search user"
        '
        'btnADDUSER
        '
        Me.btnADDUSER.BackColor = System.Drawing.Color.Transparent
        Me.btnADDUSER.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.adduser
        Me.btnADDUSER.Location = New System.Drawing.Point(800, 87)
        Me.btnADDUSER.Name = "btnADDUSER"
        Me.btnADDUSER.Size = New System.Drawing.Size(111, 32)
        Me.btnADDUSER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnADDUSER.TabIndex = 24
        Me.btnADDUSER.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.tablebg
        Me.PictureBox5.Location = New System.Drawing.Point(318, 144)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(593, 470)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'btnEDIT
        '
        Me.btnEDIT.BackColor = System.Drawing.Color.Transparent
        Me.btnEDIT.Image = CType(resources.GetObject("btnEDIT.Image"), System.Drawing.Image)
        Me.btnEDIT.Location = New System.Drawing.Point(705, 87)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(84, 32)
        Me.btnEDIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEDIT.TabIndex = 24
        Me.btnEDIT.TabStop = False
        '
        'btnVIEW
        '
        Me.btnVIEW.BackColor = System.Drawing.Color.Transparent
        Me.btnVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVIEW.Image = CType(resources.GetObject("btnVIEW.Image"), System.Drawing.Image)
        Me.btnVIEW.Location = New System.Drawing.Point(610, 87)
        Me.btnVIEW.Name = "btnVIEW"
        Me.btnVIEW.Size = New System.Drawing.Size(84, 32)
        Me.btnVIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnVIEW.TabIndex = 24
        Me.btnVIEW.TabStop = False
        '
        'ucUSERACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.finalmainmenubg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.txtSEARCH)
        Me.Controls.Add(Me.btnVIEW)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.btnADDUSER)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "ucUSERACCOUNT"
        Me.Size = New System.Drawing.Size(954, 662)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnADDUSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents btnADDUSER As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnEDIT As PictureBox
    Friend WithEvents btnVIEW As PictureBox
End Class
