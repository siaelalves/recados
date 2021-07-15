<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class novo_credito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(novo_credito))
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.picNvRcd = New System.Windows.Forms.PictureBox()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.cmdSv = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.txtHr = New System.Windows.Forms.DateTimePicker()
        Me.txtDt = New System.Windows.Forms.DateTimePicker()
        Me.lblCredAt = New System.Windows.Forms.Label()
        Me.lblCredNv = New System.Windows.Forms.Label()
        Me.lblCredAtValor = New System.Windows.Forms.Label()
        Me.lblCredNvValor = New System.Windows.Forms.Label()
        Me.imgÍcones = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(15, 108)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 18)
        Me.lblCliente.TabIndex = 30
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(84, 105)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(356, 26)
        Me.txtCliente.TabIndex = 16
        '
        'picNvRcd
        '
        Me.picNvRcd.Image = Global.messageFrom.My.Resources.Resources._403_Money
        Me.picNvRcd.Location = New System.Drawing.Point(12, 12)
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
        Me.cmdCnc.Location = New System.Drawing.Point(304, 280)
        Me.cmdCnc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(64, 64)
        Me.cmdCnc.TabIndex = 23
        Me.cmdCnc.UseVisualStyleBackColor = True
        '
        'cmdSv
        '
        Me.cmdSv.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdSv.ImageKey = "if_save_1608823.png"
        Me.cmdSv.ImageList = Me.imgÍcones
        Me.cmdSv.Location = New System.Drawing.Point(376, 280)
        Me.cmdSv.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSv.Name = "cmdSv"
        Me.cmdSv.Size = New System.Drawing.Size(64, 64)
        Me.cmdSv.TabIndex = 22
        Me.cmdSv.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(116, 175)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(324, 26)
        Me.txtValor.TabIndex = 18
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(28, 178)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(80, 18)
        Me.lblValor.TabIndex = 25
        Me.lblValor.Text = "Valor:   R$"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Location = New System.Drawing.Point(9, 142)
        Me.lblProd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(67, 18)
        Me.lblProd.TabIndex = 24
        Me.lblProd.Text = "Produto:"
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(84, 139)
        Me.txtProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(356, 26)
        Me.txtProd.TabIndex = 17
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.Location = New System.Drawing.Point(208, 55)
        Me.lblHr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(64, 18)
        Me.lblHr.TabIndex = 21
        Me.lblHr.Text = "Horário:"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Location = New System.Drawing.Point(226, 21)
        Me.lblDt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(46, 18)
        Me.lblDt.TabIndex = 19
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
        Me.txtHr.TabIndex = 27
        '
        'txtDt
        '
        Me.txtDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDt.Location = New System.Drawing.Point(284, 13)
        Me.txtDt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDt.Name = "txtDt"
        Me.txtDt.Size = New System.Drawing.Size(156, 26)
        Me.txtDt.TabIndex = 26
        '
        'lblCredAt
        '
        Me.lblCredAt.AutoSize = True
        Me.lblCredAt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredAt.Location = New System.Drawing.Point(80, 215)
        Me.lblCredAt.Name = "lblCredAt"
        Me.lblCredAt.Size = New System.Drawing.Size(112, 19)
        Me.lblCredAt.TabIndex = 31
        Me.lblCredAt.Text = "Crédito atual:"
        '
        'lblCredNv
        '
        Me.lblCredNv.AutoSize = True
        Me.lblCredNv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredNv.Location = New System.Drawing.Point(80, 244)
        Me.lblCredNv.Name = "lblCredNv"
        Me.lblCredNv.Size = New System.Drawing.Size(114, 19)
        Me.lblCredNv.TabIndex = 32
        Me.lblCredNv.Text = "Crédito novo:"
        Me.lblCredNv.Visible = False
        '
        'lblCredAtValor
        '
        Me.lblCredAtValor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredAtValor.Location = New System.Drawing.Point(328, 215)
        Me.lblCredAtValor.Name = "lblCredAtValor"
        Me.lblCredAtValor.Size = New System.Drawing.Size(112, 19)
        Me.lblCredAtValor.TabIndex = 33
        Me.lblCredAtValor.Text = "R$0,00"
        Me.lblCredAtValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCredNvValor
        '
        Me.lblCredNvValor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredNvValor.Location = New System.Drawing.Point(328, 244)
        Me.lblCredNvValor.Name = "lblCredNvValor"
        Me.lblCredNvValor.Size = New System.Drawing.Size(112, 19)
        Me.lblCredNvValor.TabIndex = 34
        Me.lblCredNvValor.Text = "R$0,00"
        Me.lblCredNvValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCredNvValor.Visible = False
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
        'novo_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 355)
        Me.Controls.Add(Me.lblCredNvValor)
        Me.Controls.Add(Me.lblCredAtValor)
        Me.Controls.Add(Me.lblCredNv)
        Me.Controls.Add(Me.lblCredAt)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.picNvRcd)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.cmdSv)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.lblHr)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.txtHr)
        Me.Controls.Add(Me.txtDt)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "novo_credito"
        Me.Text = "Adicionar Crédito"
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents picNvRcd As PictureBox
    Friend WithEvents cmdCnc As Button
    Friend WithEvents cmdSv As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents lblProd As Label
    Friend WithEvents txtProd As TextBox
    Friend WithEvents lblHr As Label
    Friend WithEvents lblDt As Label
    Friend WithEvents txtHr As DateTimePicker
    Friend WithEvents txtDt As DateTimePicker
    Friend WithEvents lblCredAt As Label
    Friend WithEvents lblCredNv As Label
    Friend WithEvents lblCredAtValor As Label
    Friend WithEvents lblCredNvValor As Label
    Public WithEvents imgÍcones As ImageList
End Class
