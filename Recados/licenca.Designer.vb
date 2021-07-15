<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class licenca
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
        Me.txtLic = New System.Windows.Forms.RichTextBox()
        Me.lblTt = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblvrs = New System.Windows.Forms.Label()
        Me.lblcopy = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLic
        '
        Me.txtLic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLic.Location = New System.Drawing.Point(15, 140)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.ReadOnly = True
        Me.txtLic.Size = New System.Drawing.Size(500, 391)
        Me.txtLic.TabIndex = 0
        Me.txtLic.Text = ""
        '
        'lblTt
        '
        Me.lblTt.AutoSize = True
        Me.lblTt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTt.Location = New System.Drawing.Point(115, 9)
        Me.lblTt.Name = "lblTt"
        Me.lblTt.Size = New System.Drawing.Size(226, 27)
        Me.lblTt.TabIndex = 1
        Me.lblTt.Text = "[Título do aplicativo]"
        '
        'picIcon
        '
        Me.picIcon.Location = New System.Drawing.Point(12, 9)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(97, 87)
        Me.picIcon.TabIndex = 2
        Me.picIcon.TabStop = False
        '
        'lblvrs
        '
        Me.lblvrs.AutoSize = True
        Me.lblvrs.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvrs.Location = New System.Drawing.Point(115, 52)
        Me.lblvrs.Name = "lblvrs"
        Me.lblvrs.Size = New System.Drawing.Size(99, 27)
        Me.lblvrs.TabIndex = 3
        Me.lblvrs.Text = "[Versão]"
        '
        'lblcopy
        '
        Me.lblcopy.AutoSize = True
        Me.lblcopy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcopy.Location = New System.Drawing.Point(12, 108)
        Me.lblcopy.Name = "lblcopy"
        Me.lblcopy.Size = New System.Drawing.Size(83, 18)
        Me.lblcopy.TabIndex = 4
        Me.lblcopy.Text = "[Copyright]"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(12, 544)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(44, 13)
        Me.lblKey.TabIndex = 5
        Me.lblKey.Text = "[Chave]"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 565)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(89, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "[Email licenciado]"
        '
        'licenca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 587)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblcopy)
        Me.Controls.Add(Me.lblvrs)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblTt)
        Me.Controls.Add(Me.txtLic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "licenca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licença"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLic As System.Windows.Forms.RichTextBox
    Friend WithEvents lblTt As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblvrs As System.Windows.Forms.Label
    Friend WithEvents lblcopy As System.Windows.Forms.Label
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
End Class
