<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLOGIN))
        Me.pnlLOGO = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPASS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUSER = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLOGIN = New System.Windows.Forms.Button()
        Me.tmrTIME = New System.Windows.Forms.Timer(Me.components)
        Me.btnSHOW = New System.Windows.Forms.PictureBox()
        Me.btnHIDE = New System.Windows.Forms.PictureBox()
        Me.BTNMINIMIZE = New System.Windows.Forms.PictureBox()
        Me.BTNCLOSE = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnINFO = New System.Windows.Forms.PictureBox()
        Me.pnlINFO = New System.Windows.Forms.Panel()
        Me.pnlLOGO.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnSHOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNMINIMIZE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCLOSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnINFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLOGO
        '
        Me.pnlLOGO.BackColor = System.Drawing.Color.White
        Me.pnlLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlLOGO.Controls.Add(Me.pnlINFO)
        Me.pnlLOGO.Controls.Add(Me.Label3)
        Me.pnlLOGO.Controls.Add(Me.btnINFO)
        Me.pnlLOGO.Controls.Add(Me.Label2)
        Me.pnlLOGO.Controls.Add(Me.Label1)
        Me.pnlLOGO.Controls.Add(Me.PictureBox1)
        Me.pnlLOGO.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLOGO.Location = New System.Drawing.Point(0, 0)
        Me.pnlLOGO.Name = "pnlLOGO"
        Me.pnlLOGO.Size = New System.Drawing.Size(421, 486)
        Me.pnlLOGO.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(163, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(163, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(163, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Record"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(482, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Login."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(485, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Log in with your registered " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "information."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.btnSHOW)
        Me.Panel3.Controls.Add(Me.btnHIDE)
        Me.Panel3.Controls.Add(Me.txtPASS)
        Me.Panel3.Location = New System.Drawing.Point(486, 263)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 33)
        Me.Panel3.TabIndex = 2
        '
        'txtPASS
        '
        Me.txtPASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPASS.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtPASS.Location = New System.Drawing.Point(15, 8)
        Me.txtPASS.Name = "txtPASS"
        Me.txtPASS.Size = New System.Drawing.Size(131, 16)
        Me.txtPASS.TabIndex = 0
        Me.txtPASS.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(523, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "General Service Office’s"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUSER
        '
        Me.txtUSER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUSER.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtUSER.Location = New System.Drawing.Point(16, 8)
        Me.txtUSER.Name = "txtUSER"
        Me.txtUSER.Size = New System.Drawing.Size(153, 16)
        Me.txtUSER.TabIndex = 0
        Me.txtUSER.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.txtUSER)
        Me.Panel2.Location = New System.Drawing.Point(485, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 33)
        Me.Panel2.TabIndex = 1
        '
        'btnLOGIN
        '
        Me.btnLOGIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLOGIN.FlatAppearance.BorderSize = 0
        Me.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLOGIN.Font = New System.Drawing.Font("Arial", 9.4!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOGIN.ForeColor = System.Drawing.Color.White
        Me.btnLOGIN.Location = New System.Drawing.Point(487, 316)
        Me.btnLOGIN.Name = "btnLOGIN"
        Me.btnLOGIN.Size = New System.Drawing.Size(183, 35)
        Me.btnLOGIN.TabIndex = 4
        Me.btnLOGIN.Text = "Log in"
        Me.btnLOGIN.UseVisualStyleBackColor = False
        '
        'tmrTIME
        '
        Me.tmrTIME.Enabled = True
        Me.tmrTIME.Interval = 1000
        '
        'btnSHOW
        '
        Me.btnSHOW.BackColor = System.Drawing.Color.Transparent
        Me.btnSHOW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSHOW.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.eye_fill_1
        Me.btnSHOW.Location = New System.Drawing.Point(150, 8)
        Me.btnSHOW.Name = "btnSHOW"
        Me.btnSHOW.Size = New System.Drawing.Size(18, 18)
        Me.btnSHOW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSHOW.TabIndex = 4
        Me.btnSHOW.TabStop = False
        '
        'btnHIDE
        '
        Me.btnHIDE.BackColor = System.Drawing.Color.Transparent
        Me.btnHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHIDE.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.eye_off_fill_2
        Me.btnHIDE.Location = New System.Drawing.Point(150, 8)
        Me.btnHIDE.Name = "btnHIDE"
        Me.btnHIDE.Size = New System.Drawing.Size(18, 18)
        Me.btnHIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnHIDE.TabIndex = 3
        Me.btnHIDE.TabStop = False
        '
        'BTNMINIMIZE
        '
        Me.BTNMINIMIZE.BackColor = System.Drawing.Color.Transparent
        Me.BTNMINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMINIMIZE.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTNMINIMIZE.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.minimize
        Me.BTNMINIMIZE.Location = New System.Drawing.Point(672, 16)
        Me.BTNMINIMIZE.Name = "BTNMINIMIZE"
        Me.BTNMINIMIZE.Size = New System.Drawing.Size(19, 19)
        Me.BTNMINIMIZE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTNMINIMIZE.TabIndex = 3
        Me.BTNMINIMIZE.TabStop = False
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.BackColor = System.Drawing.Color.Transparent
        Me.BTNCLOSE.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.close
        Me.BTNCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCLOSE.Location = New System.Drawing.Point(696, 16)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(19, 19)
        Me.BTNCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTNCLOSE.TabIndex = 3
        Me.BTNCLOSE.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.systemlogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(140, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnINFO
        '
        Me.btnINFO.BackColor = System.Drawing.Color.Transparent
        Me.btnINFO.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.Info_circle
        Me.btnINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnINFO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnINFO.Location = New System.Drawing.Point(384, 16)
        Me.btnINFO.Name = "btnINFO"
        Me.btnINFO.Size = New System.Drawing.Size(19, 19)
        Me.btnINFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnINFO.TabIndex = 3
        Me.btnINFO.TabStop = False
        '
        'pnlINFO
        '
        Me.pnlINFO.BackgroundImage = Global.URSBGSORecordManagementSystem.My.Resources.Resources.infopanel
        Me.pnlINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlINFO.Location = New System.Drawing.Point(263, 16)
        Me.pnlINFO.Name = "pnlINFO"
        Me.pnlINFO.Size = New System.Drawing.Size(115, 35)
        Me.pnlINFO.TabIndex = 4
        '
        'frmLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(731, 486)
        Me.Controls.Add(Me.btnLOGIN)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BTNMINIMIZE)
        Me.Controls.Add(Me.BTNCLOSE)
        Me.Controls.Add(Me.pnlLOGO)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GSO RECORD MANAGEMENT SYSTEM"
        Me.pnlLOGO.ResumeLayout(False)
        Me.pnlLOGO.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnSHOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHIDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNMINIMIZE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCLOSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnINFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLOGO As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPASS As TextBox
    Friend WithEvents btnHIDE As PictureBox
    Friend WithEvents btnSHOW As PictureBox
    Friend WithEvents BTNCLOSE As PictureBox
    Friend WithEvents BTNMINIMIZE As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUSER As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLOGIN As Button
    Friend WithEvents tmrTIME As Timer
    Friend WithEvents pnlINFO As Panel
    Friend WithEvents btnINFO As PictureBox
End Class
