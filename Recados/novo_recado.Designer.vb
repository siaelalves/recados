<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class novo_recado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(novo_recado))
        Me.txtRsp = New System.Windows.Forms.TextBox()
        Me.lblRsp = New System.Windows.Forms.Label()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.picNvRcd = New System.Windows.Forms.PictureBox()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.cmdSv = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtCnt = New System.Windows.Forms.TextBox()
        Me.lblCnt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuem = New System.Windows.Forms.TextBox()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.txtHr = New System.Windows.Forms.DateTimePicker()
        Me.txtDt = New System.Windows.Forms.DateTimePicker()
        Me.imgÍcones = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRsp
        '
        Me.txtRsp.Location = New System.Drawing.Point(149, 104)
        Me.txtRsp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRsp.Name = "txtRsp"
        Me.txtRsp.Size = New System.Drawing.Size(356, 26)
        Me.txtRsp.TabIndex = 0
        '
        'lblRsp
        '
        Me.lblRsp.AutoSize = True
        Me.lblRsp.Location = New System.Drawing.Point(39, 107)
        Me.lblRsp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRsp.Name = "lblRsp"
        Me.lblRsp.Size = New System.Drawing.Size(102, 18)
        Me.lblRsp.TabIndex = 15
        Me.lblRsp.Text = "Responsável:"
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(149, 210)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(356, 167)
        Me.txtMsg.TabIndex = 3
        '
        'picNvRcd
        '
        Me.picNvRcd.Image = Global.messageFrom.My.Resources.Resources.if_4_2135935
        Me.picNvRcd.Location = New System.Drawing.Point(12, 12)
        Me.picNvRcd.Name = "picNvRcd"
        Me.picNvRcd.Size = New System.Drawing.Size(106, 75)
        Me.picNvRcd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNvRcd.TabIndex = 13
        Me.picNvRcd.TabStop = False
        '
        'cmdCnc
        '
        Me.cmdCnc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCnc.ImageKey = "if_Close_1891023.png"
        Me.cmdCnc.ImageList = Me.imgÍcones
        Me.cmdCnc.Location = New System.Drawing.Point(369, 384)
        Me.cmdCnc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(64, 64)
        Me.cmdCnc.TabIndex = 5
        Me.cmdCnc.UseVisualStyleBackColor = True
        '
        'cmdSv
        '
        Me.cmdSv.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdSv.ImageKey = "if_save_1608823.png"
        Me.cmdSv.ImageList = Me.imgÍcones
        Me.cmdSv.Location = New System.Drawing.Point(441, 384)
        Me.cmdSv.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSv.Name = "cmdSv"
        Me.cmdSv.Size = New System.Drawing.Size(64, 64)
        Me.cmdSv.TabIndex = 4
        Me.cmdSv.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(51, 210)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(90, 18)
        Me.lblMsg.TabIndex = 9
        Me.lblMsg.Text = "Mensagem:"
        '
        'txtCnt
        '
        Me.txtCnt.Location = New System.Drawing.Point(149, 174)
        Me.txtCnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCnt.Name = "txtCnt"
        Me.txtCnt.Size = New System.Drawing.Size(356, 26)
        Me.txtCnt.TabIndex = 2
        '
        'lblCnt
        '
        Me.lblCnt.AutoSize = True
        Me.lblCnt.Location = New System.Drawing.Point(74, 177)
        Me.lblCnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(67, 18)
        Me.lblCnt.TabIndex = 6
        Me.lblCnt.Text = "Contato:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 141)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Recado de quem:"
        '
        'txtQuem
        '
        Me.txtQuem.Location = New System.Drawing.Point(149, 138)
        Me.txtQuem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuem.Name = "txtQuem"
        Me.txtQuem.Size = New System.Drawing.Size(356, 26)
        Me.txtQuem.TabIndex = 1
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.Location = New System.Drawing.Point(266, 54)
        Me.lblHr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(64, 18)
        Me.lblHr.TabIndex = 3
        Me.lblHr.Text = "Horário:"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Location = New System.Drawing.Point(284, 20)
        Me.lblDt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(46, 18)
        Me.lblDt.TabIndex = 2
        Me.lblDt.Text = "Data:"
        '
        'txtHr
        '
        Me.txtHr.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHr.Location = New System.Drawing.Point(342, 48)
        Me.txtHr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHr.Name = "txtHr"
        Me.txtHr.ShowUpDown = True
        Me.txtHr.Size = New System.Drawing.Size(163, 26)
        Me.txtHr.TabIndex = 7
        '
        'txtDt
        '
        Me.txtDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDt.Location = New System.Drawing.Point(342, 12)
        Me.txtDt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDt.Name = "txtDt"
        Me.txtDt.Size = New System.Drawing.Size(163, 26)
        Me.txtDt.TabIndex = 6
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
        'novo_recado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCnc
        Me.ClientSize = New System.Drawing.Size(522, 466)
        Me.Controls.Add(Me.lblRsp)
        Me.Controls.Add(Me.txtRsp)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.picNvRcd)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.cmdSv)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtCnt)
        Me.Controls.Add(Me.lblCnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuem)
        Me.Controls.Add(Me.lblHr)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.txtHr)
        Me.Controls.Add(Me.txtDt)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "novo_recado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anotar recado"
        CType(Me.picNvRcd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRsp As TextBox
    Friend WithEvents lblRsp As Label
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents picNvRcd As PictureBox
    Friend WithEvents cmdCnc As Button
    Friend WithEvents cmdSv As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents txtCnt As TextBox
    Friend WithEvents lblCnt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuem As TextBox
    Friend WithEvents lblHr As Label
    Friend WithEvents lblDt As Label
    Friend WithEvents txtHr As DateTimePicker
    Friend WithEvents txtDt As DateTimePicker
    Public WithEvents imgÍcones As ImageList
End Class
