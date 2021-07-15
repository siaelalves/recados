<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nova_terceirização
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nova_terceirização))
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.picNvRcd = New System.Windows.Forms.PictureBox()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.imgÍcones = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSv = New System.Windows.Forms.Button()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.lblOS = New System.Windows.Forms.Label()
        Me.lblEmpr = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.txtHr = New System.Windows.Forms.DateTimePicker()
        Me.txtDt = New System.Windows.Forms.DateTimePicker()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblSit = New System.Windows.Forms.Label()
        Me.txtSit = New System.Windows.Forms.ComboBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(28, 109)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 18)
        Me.lblCliente.TabIndex = 47
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(126, 106)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(318, 26)
        Me.txtCliente.TabIndex = 1
        '
        'picNvRcd
        '
        Me.picNvRcd.Image = Global.messageFrom.My.Resources.Resources.if_025_Notebook_183587
        Me.picNvRcd.Location = New System.Drawing.Point(12, 12)
        Me.picNvRcd.Name = "picNvRcd"
        Me.picNvRcd.Size = New System.Drawing.Size(106, 75)
        Me.picNvRcd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNvRcd.TabIndex = 46
        Me.picNvRcd.TabStop = False
        '
        'cmdCnc
        '
        Me.cmdCnc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCnc.ImageKey = "if_Close_1891023.png"
        Me.cmdCnc.ImageList = Me.imgÍcones
        Me.cmdCnc.Location = New System.Drawing.Point(308, 386)
        Me.cmdCnc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(64, 64)
        Me.cmdCnc.TabIndex = 8
        Me.cmdCnc.UseVisualStyleBackColor = True
        '
        'imgÍcones
        '
        Me.imgÍcones.ImageStream = CType(resources.GetObject("imgÍcones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgÍcones.TransparentColor = System.Drawing.Color.Transparent
        Me.imgÍcones.Images.SetKeyName(0, "if_Plus_206460_32x32.ico")
        Me.imgÍcones.Images.SetKeyName(1, "if_Plus_206460_512x512.ico")
        Me.imgÍcones.Images.SetKeyName(2, "if_bin_383180_512.png")
        Me.imgÍcones.Images.SetKeyName(3, "if_39_Exit_Arrow_Door_Signout_Out_Close_2142693.png")
        Me.imgÍcones.Images.SetKeyName(4, "if_4_2135935.png")
        Me.imgÍcones.Images.SetKeyName(5, "_403-Money.png")
        Me.imgÍcones.Images.SetKeyName(6, "if_025_Notebook_183587.png")
        Me.imgÍcones.Images.SetKeyName(7, "if_save_1608823.png")
        Me.imgÍcones.Images.SetKeyName(8, "if_Close_1891023.png")
        '
        'cmdSv
        '
        Me.cmdSv.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdSv.ImageIndex = 7
        Me.cmdSv.ImageList = Me.imgÍcones
        Me.cmdSv.Location = New System.Drawing.Point(380, 386)
        Me.cmdSv.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSv.Name = "cmdSv"
        Me.cmdSv.Size = New System.Drawing.Size(64, 64)
        Me.cmdSv.TabIndex = 7
        Me.cmdSv.UseVisualStyleBackColor = True
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(126, 140)
        Me.txtOS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(318, 26)
        Me.txtOS.TabIndex = 2
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(54, 143)
        Me.lblOS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(35, 18)
        Me.lblOS.TabIndex = 43
        Me.lblOS.Text = "OS:"
        '
        'lblEmpr
        '
        Me.lblEmpr.AutoSize = True
        Me.lblEmpr.Location = New System.Drawing.Point(13, 266)
        Me.lblEmpr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpr.Name = "lblEmpr"
        Me.lblEmpr.Size = New System.Drawing.Size(76, 18)
        Me.lblEmpr.TabIndex = 42
        Me.lblEmpr.Text = "Empresa:"
        '
        'txtEmp
        '
        Me.txtEmp.Location = New System.Drawing.Point(126, 263)
        Me.txtEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(318, 26)
        Me.txtEmp.TabIndex = 4
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.Location = New System.Drawing.Point(208, 55)
        Me.lblHr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(64, 18)
        Me.lblHr.TabIndex = 39
        Me.lblHr.Text = "Horário:"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Location = New System.Drawing.Point(226, 21)
        Me.lblDt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(46, 18)
        Me.lblDt.TabIndex = 38
        Me.lblDt.Text = "Data:"
        '
        'txtHr
        '
        Me.txtHr.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHr.Location = New System.Drawing.Point(284, 49)
        Me.txtHr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHr.Name = "txtHr"
        Me.txtHr.ShowUpDown = True
        Me.txtHr.Size = New System.Drawing.Size(156, 26)
        Me.txtHr.TabIndex = 45
        Me.txtHr.TabStop = False
        '
        'txtDt
        '
        Me.txtDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDt.Location = New System.Drawing.Point(284, 13)
        Me.txtDt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDt.Name = "txtDt"
        Me.txtDt.Size = New System.Drawing.Size(156, 26)
        Me.txtDt.TabIndex = 44
        Me.txtDt.TabStop = False
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(126, 174)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(318, 46)
        Me.txtDesc.TabIndex = 3
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(9, 177)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(84, 18)
        Me.lblDesc.TabIndex = 53
        Me.lblDesc.Text = "Descrição:"
        '
        'lblSit
        '
        Me.lblSit.AutoSize = True
        Me.lblSit.Location = New System.Drawing.Point(15, 299)
        Me.lblSit.Name = "lblSit"
        Me.lblSit.Size = New System.Drawing.Size(74, 18)
        Me.lblSit.TabIndex = 54
        Me.lblSit.Text = "Situação:"
        '
        'txtSit
        '
        Me.txtSit.FormattingEnabled = True
        Me.txtSit.Items.AddRange(New Object() {"Em orçamento", "Finalizado"})
        Me.txtSit.Location = New System.Drawing.Point(126, 296)
        Me.txtSit.Name = "txtSit"
        Me.txtSit.Size = New System.Drawing.Size(318, 26)
        Me.txtSit.TabIndex = 5
        Me.txtSit.Text = "Em orçamento"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(13, 332)
        Me.lblObs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(105, 18)
        Me.lblObs.TabIndex = 57
        Me.lblObs.Text = "Observações:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(126, 332)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(318, 46)
        Me.txtObs.TabIndex = 6
        '
        'nova_terceirização
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 462)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.txtSit)
        Me.Controls.Add(Me.lblSit)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.picNvRcd)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.cmdSv)
        Me.Controls.Add(Me.txtOS)
        Me.Controls.Add(Me.lblOS)
        Me.Controls.Add(Me.lblEmpr)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.lblHr)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.txtHr)
        Me.Controls.Add(Me.txtDt)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "nova_terceirização"
        Me.Text = "Serviços Terceirizados"
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents picNvRcd As PictureBox
    Friend WithEvents cmdCnc As Button
    Friend WithEvents cmdSv As Button
    Friend WithEvents txtOS As TextBox
    Friend WithEvents lblOS As Label
    Friend WithEvents lblEmpr As Label
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents lblHr As Label
    Friend WithEvents lblDt As Label
    Friend WithEvents txtHr As DateTimePicker
    Friend WithEvents txtDt As DateTimePicker
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblSit As Label
    Friend WithEvents txtSit As ComboBox
    Friend WithEvents lblObs As Label
    Friend WithEvents txtObs As TextBox
    Public WithEvents imgÍcones As ImageList
End Class
