<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nova_priorid
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nova_priorid))
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.picNvRcd = New System.Windows.Forms.PictureBox()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.imgÍcones = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSv = New System.Windows.Forms.Button()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.txtCnt = New System.Windows.Forms.TextBox()
        Me.lblCnt = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.txtHr = New System.Windows.Forms.DateTimePicker()
        Me.txtDt = New System.Windows.Forms.DateTimePicker()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.lblContato = New System.Windows.Forms.Label()
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(125, 226)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(355, 175)
        Me.txtObs.TabIndex = 3
        '
        'picNvRcd
        '
        Me.picNvRcd.Image = Global.messageFrom.My.Resources.Resources.cliente
        Me.picNvRcd.Location = New System.Drawing.Point(13, 17)
        Me.picNvRcd.Margin = New System.Windows.Forms.Padding(4)
        Me.picNvRcd.Name = "picNvRcd"
        Me.picNvRcd.Size = New System.Drawing.Size(106, 75)
        Me.picNvRcd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNvRcd.TabIndex = 29
        Me.picNvRcd.TabStop = False
        '
        'cmdCnc
        '
        Me.cmdCnc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCnc.ImageKey = "if_Close_1891023.png"
        Me.cmdCnc.ImageList = Me.imgÍcones
        Me.cmdCnc.Location = New System.Drawing.Point(340, 411)
        Me.cmdCnc.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(64, 64)
        Me.cmdCnc.TabIndex = 5
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
        Me.cmdSv.ImageKey = "if_save_1608823.png"
        Me.cmdSv.ImageList = Me.imgÍcones
        Me.cmdSv.Location = New System.Drawing.Point(416, 411)
        Me.cmdSv.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdSv.Name = "cmdSv"
        Me.cmdSv.Size = New System.Drawing.Size(64, 64)
        Me.cmdSv.TabIndex = 4
        Me.cmdSv.UseVisualStyleBackColor = True
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(10, 226)
        Me.lblObs.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(105, 18)
        Me.lblObs.TabIndex = 28
        Me.lblObs.Text = "Observações:"
        '
        'txtCnt
        '
        Me.txtCnt.Location = New System.Drawing.Point(124, 138)
        Me.txtCnt.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCnt.Name = "txtCnt"
        Me.txtCnt.Size = New System.Drawing.Size(355, 26)
        Me.txtCnt.TabIndex = 1
        '
        'lblCnt
        '
        Me.lblCnt.AutoSize = True
        Me.lblCnt.Location = New System.Drawing.Point(48, 141)
        Me.lblCnt.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(67, 18)
        Me.lblCnt.TabIndex = 25
        Me.lblCnt.Text = "Contato:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(54, 106)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 18)
        Me.lblCliente.TabIndex = 24
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(124, 103)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(355, 26)
        Me.txtCliente.TabIndex = 0
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.Location = New System.Drawing.Point(162, 61)
        Me.lblHr.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(64, 18)
        Me.lblHr.TabIndex = 21
        Me.lblHr.Text = "Horário:"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Location = New System.Drawing.Point(180, 19)
        Me.lblDt.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(46, 18)
        Me.lblDt.TabIndex = 19
        Me.lblDt.Text = "Data:"
        '
        'txtHr
        '
        Me.txtHr.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHr.Location = New System.Drawing.Point(238, 55)
        Me.txtHr.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHr.Name = "txtHr"
        Me.txtHr.ShowUpDown = True
        Me.txtHr.Size = New System.Drawing.Size(242, 26)
        Me.txtHr.TabIndex = 27
        Me.txtHr.TabStop = False
        '
        'txtDt
        '
        Me.txtDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDt.Location = New System.Drawing.Point(238, 17)
        Me.txtDt.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDt.Name = "txtDt"
        Me.txtDt.Size = New System.Drawing.Size(242, 26)
        Me.txtDt.TabIndex = 26
        Me.txtDt.TabStop = False
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(124, 171)
        Me.txtProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProd.Multiline = True
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(356, 47)
        Me.txtProd.TabIndex = 2
        '
        'lblContato
        '
        Me.lblContato.AutoSize = True
        Me.lblContato.Location = New System.Drawing.Point(48, 174)
        Me.lblContato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContato.Name = "lblContato"
        Me.lblContato.Size = New System.Drawing.Size(67, 18)
        Me.lblContato.TabIndex = 31
        Me.lblContato.Text = "Produto:"
        '
        'nova_priorid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 486)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.lblContato)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.picNvRcd)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.cmdSv)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.txtCnt)
        Me.Controls.Add(Me.lblCnt)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblHr)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.txtHr)
        Me.Controls.Add(Me.txtDt)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "nova_priorid"
        Me.Text = "Clientes Priorizados"
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtObs As TextBox
    Friend WithEvents picNvRcd As PictureBox
    Friend WithEvents cmdCnc As Button
    Public WithEvents imgÍcones As ImageList
    Friend WithEvents cmdSv As Button
    Friend WithEvents lblObs As Label
    Friend WithEvents txtCnt As TextBox
    Friend WithEvents lblCnt As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblHr As Label
    Friend WithEvents lblDt As Label
    Friend WithEvents txtHr As DateTimePicker
    Friend WithEvents txtDt As DateTimePicker
    Friend WithEvents txtProd As TextBox
    Friend WithEvents lblContato As Label
End Class
