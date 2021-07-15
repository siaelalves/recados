<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tarefas
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbTrf = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstchkTrf = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdTrfLimpar = New System.Windows.Forms.Button()
        Me.cmdTrfExc = New System.Windows.Forms.Button()
        Me.lblTrf = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDv = New System.Windows.Forms.RadioButton()
        Me.chkImp = New System.Windows.Forms.RadioButton()
        Me.chkMtImp = New System.Windows.Forms.RadioButton()
        Me.chkUrg = New System.Windows.Forms.RadioButton()
        Me.lblNvTrf = New System.Windows.Forms.Label()
        Me.cmdNvTrf = New System.Windows.Forms.Button()
        Me.txtNvTrf = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tbTrf.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.tbTrf)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(698, 377)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(192, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(690, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbTrf
        '
        Me.tbTrf.Controls.Add(Me.SplitContainer1)
        Me.tbTrf.Location = New System.Drawing.Point(4, 22)
        Me.tbTrf.Name = "tbTrf"
        Me.tbTrf.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTrf.Size = New System.Drawing.Size(690, 351)
        Me.tbTrf.TabIndex = 2
        Me.tbTrf.Text = "TAREFAS"
        Me.tbTrf.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstchkTrf)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTrfLimpar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTrfExc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTrf)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkDv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkImp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkMtImp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkUrg)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblNvTrf)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdNvTrf)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNvTrf)
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 345)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 11
        '
        'lstchkTrf
        '
        Me.lstchkTrf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstchkTrf.CheckBoxes = True
        Me.lstchkTrf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstchkTrf.Enabled = False
        Me.lstchkTrf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstchkTrf.FullRowSelect = True
        Me.lstchkTrf.GridLines = True
        Me.lstchkTrf.HideSelection = False
        Me.lstchkTrf.Location = New System.Drawing.Point(6, 28)
        Me.lstchkTrf.Name = "lstchkTrf"
        Me.lstchkTrf.Size = New System.Drawing.Size(306, 260)
        Me.lstchkTrf.TabIndex = 14
        Me.lstchkTrf.UseCompatibleStateImageBehavior = False
        Me.lstchkTrf.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tarefas"
        Me.ColumnHeader1.Width = 493
        '
        'cmdTrfLimpar
        '
        Me.cmdTrfLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrfLimpar.Enabled = False
        Me.cmdTrfLimpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrfLimpar.Location = New System.Drawing.Point(76, 294)
        Me.cmdTrfLimpar.Name = "cmdTrfLimpar"
        Me.cmdTrfLimpar.Size = New System.Drawing.Size(115, 48)
        Me.cmdTrfLimpar.TabIndex = 13
        Me.cmdTrfLimpar.Text = "LIMPAR LISTA"
        Me.cmdTrfLimpar.UseVisualStyleBackColor = True
        '
        'cmdTrfExc
        '
        Me.cmdTrfExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrfExc.Enabled = False
        Me.cmdTrfExc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrfExc.Location = New System.Drawing.Point(197, 294)
        Me.cmdTrfExc.Name = "cmdTrfExc"
        Me.cmdTrfExc.Size = New System.Drawing.Size(115, 48)
        Me.cmdTrfExc.TabIndex = 12
        Me.cmdTrfExc.Text = "REMOVER DA LISTA"
        Me.cmdTrfExc.UseVisualStyleBackColor = True
        '
        'lblTrf
        '
        Me.lblTrf.AutoSize = True
        Me.lblTrf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrf.Location = New System.Drawing.Point(3, 6)
        Me.lblTrf.Name = "lblTrf"
        Me.lblTrf.Size = New System.Drawing.Size(120, 18)
        Me.lblTrf.TabIndex = 11
        Me.lblTrf.Text = "Lista de tarefas:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 126)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Recurso a ser implementado pelo desenvolvedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkDv
        '
        Me.chkDv.AutoSize = True
        Me.chkDv.Enabled = False
        Me.chkDv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDv.Location = New System.Drawing.Point(11, 144)
        Me.chkDv.Name = "chkDv"
        Me.chkDv.Size = New System.Drawing.Size(259, 22)
        Me.chkDv.TabIndex = 6
        Me.chkDv.TabStop = True
        Me.chkDv.Text = "Deve ser feito, mas pode esperar"
        Me.chkDv.UseVisualStyleBackColor = True
        '
        'chkImp
        '
        Me.chkImp.AutoSize = True
        Me.chkImp.Enabled = False
        Me.chkImp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkImp.Location = New System.Drawing.Point(11, 116)
        Me.chkImp.Name = "chkImp"
        Me.chkImp.Size = New System.Drawing.Size(99, 22)
        Me.chkImp.TabIndex = 5
        Me.chkImp.TabStop = True
        Me.chkImp.Text = "Importante"
        Me.chkImp.UseVisualStyleBackColor = True
        '
        'chkMtImp
        '
        Me.chkMtImp.AutoSize = True
        Me.chkMtImp.Enabled = False
        Me.chkMtImp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMtImp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkMtImp.Location = New System.Drawing.Point(11, 88)
        Me.chkMtImp.Name = "chkMtImp"
        Me.chkMtImp.Size = New System.Drawing.Size(142, 22)
        Me.chkMtImp.TabIndex = 4
        Me.chkMtImp.TabStop = True
        Me.chkMtImp.Text = "Muito importante"
        Me.chkMtImp.UseVisualStyleBackColor = True
        '
        'chkUrg
        '
        Me.chkUrg.AutoSize = True
        Me.chkUrg.Enabled = False
        Me.chkUrg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUrg.ForeColor = System.Drawing.Color.Red
        Me.chkUrg.Location = New System.Drawing.Point(11, 60)
        Me.chkUrg.Name = "chkUrg"
        Me.chkUrg.Size = New System.Drawing.Size(81, 22)
        Me.chkUrg.TabIndex = 3
        Me.chkUrg.TabStop = True
        Me.chkUrg.Text = "Urgente"
        Me.chkUrg.UseVisualStyleBackColor = True
        '
        'lblNvTrf
        '
        Me.lblNvTrf.AutoSize = True
        Me.lblNvTrf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNvTrf.Location = New System.Drawing.Point(8, 6)
        Me.lblNvTrf.Name = "lblNvTrf"
        Me.lblNvTrf.Size = New System.Drawing.Size(92, 18)
        Me.lblNvTrf.TabIndex = 2
        Me.lblNvTrf.Text = "Nova tarefa:"
        '
        'cmdNvTrf
        '
        Me.cmdNvTrf.Enabled = False
        Me.cmdNvTrf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNvTrf.Location = New System.Drawing.Point(11, 172)
        Me.cmdNvTrf.Name = "cmdNvTrf"
        Me.cmdNvTrf.Size = New System.Drawing.Size(188, 35)
        Me.cmdNvTrf.TabIndex = 1
        Me.cmdNvTrf.Text = "Acrescentar à lista"
        Me.cmdNvTrf.UseVisualStyleBackColor = True
        '
        'txtNvTrf
        '
        Me.txtNvTrf.Enabled = False
        Me.txtNvTrf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNvTrf.Location = New System.Drawing.Point(11, 28)
        Me.txtNvTrf.Name = "txtNvTrf"
        Me.txtNvTrf.Size = New System.Drawing.Size(407, 26)
        Me.txtNvTrf.TabIndex = 0
        '
        'tarefas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 403)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "tarefas"
        Me.Text = "tarefas"
        Me.TabControl1.ResumeLayout(False)
        Me.tbTrf.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbTrf As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstchkTrf As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdTrfLimpar As System.Windows.Forms.Button
    Friend WithEvents cmdTrfExc As System.Windows.Forms.Button
    Friend WithEvents lblTrf As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkDv As System.Windows.Forms.RadioButton
    Friend WithEvents chkImp As System.Windows.Forms.RadioButton
    Friend WithEvents chkMtImp As System.Windows.Forms.RadioButton
    Friend WithEvents chkUrg As System.Windows.Forms.RadioButton
    Friend WithEvents lblNvTrf As System.Windows.Forms.Label
    Friend WithEvents cmdNvTrf As System.Windows.Forms.Button
    Friend WithEvents txtNvTrf As System.Windows.Forms.TextBox
End Class
