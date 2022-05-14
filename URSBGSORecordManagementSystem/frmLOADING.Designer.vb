<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLOADING
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pbLOADER = New System.Windows.Forms.PictureBox()
        CType(Me.pbLOADER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLOADER
        '
        Me.pbLOADER.BackColor = System.Drawing.Color.Transparent
        Me.pbLOADER.Image = Global.URSBGSORecordManagementSystem.My.Resources.Resources.loading
        Me.pbLOADER.Location = New System.Drawing.Point(440, 256)
        Me.pbLOADER.Name = "pbLOADER"
        Me.pbLOADER.Size = New System.Drawing.Size(101, 101)
        Me.pbLOADER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLOADER.TabIndex = 0
        Me.pbLOADER.TabStop = False
        '
        'frmLOADING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(954, 662)
        Me.Controls.Add(Me.pbLOADER)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLOADING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLOADING"
        CType(Me.pbLOADER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbLOADER As PictureBox
End Class
