<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ativar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ativar))
        Me.cmdAtiv = New System.Windows.Forms.Button()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.lblDigite = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'cmdAtiv
        '
        Me.cmdAtiv.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAtiv.Location = New System.Drawing.Point(58, 181)
        Me.cmdAtiv.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAtiv.Name = "cmdAtiv"
        Me.cmdAtiv.Size = New System.Drawing.Size(96, 31)
        Me.cmdAtiv.TabIndex = 7
        Me.cmdAtiv.Text = "Ativar"
        Me.cmdAtiv.UseVisualStyleBackColor = True
        '
        'cmdCnc
        '
        Me.cmdCnc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCnc.Location = New System.Drawing.Point(159, 181)
        Me.cmdCnc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(96, 31)
        Me.cmdCnc.TabIndex = 8
        Me.cmdCnc.Text = "Cancelar"
        Me.cmdCnc.UseVisualStyleBackColor = True
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(18, 94)
        Me.lblCPF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(41, 18)
        Me.lblCPF.TabIndex = 9
        Me.lblCPF.Text = "CPF"
        '
        'txtCPF
        '
        Me.txtCPF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(67, 91)
        Me.txtCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(188, 26)
        Me.txtCPF.TabIndex = 4
        Me.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblDigite
        '
        Me.lblDigite.Location = New System.Drawing.Point(18, 12)
        Me.lblDigite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDigite.Name = "lblDigite"
        Me.lblDigite.Size = New System.Drawing.Size(237, 61)
        Me.lblDigite.TabIndex = 5
        Me.lblDigite.Text = "Digite o código de permissão:"
        Me.lblDigite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(22, 136)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCod.Mask = "AAAAA-AAAAA-AAAAA-AAAAA"
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(233, 26)
        Me.txtCod.TabIndex = 6
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCod.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ativar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 235)
        Me.Controls.Add(Me.cmdAtiv)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.lblDigite)
        Me.Controls.Add(Me.txtCod)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ativar"
        Me.Text = "Ativação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAtiv As Button
    Friend WithEvents cmdCnc As Button
    Friend WithEvents lblCPF As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents lblDigite As Label
    Friend WithEvents txtCod As MaskedTextBox
End Class
