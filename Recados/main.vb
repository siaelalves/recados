Imports messageFrom.Tabelas

Public Class main

    Public Shared Intelidata As New DataSet()
    Public Shared tRecados As New DataTable("Recados")
    Public Shared tCréditos As New DataTable("Créditos")
    Public Shared tTerceirização As New DataTable("Terceirização")
    Public Shared tPrioridade As New DataTable("Prioridade")
    Public Shared filtro As String

    Public Shared selected As String
    Public Shared PastaDeRecados As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Siael Carvalho\Recados"
    Public Shared ArquivoDeRecados As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Siael Carvalho\Recados\RecFile.xml"
    Public Shared RecID As Integer = 0
    Public Shared RecID_file As String = PastaDeRecados & "\recid.ini"

    Public dtrec_r As DataRow()
    Public importancia As Color

    Sub CarregarTabelas()
        Intelidata.Tables.Add(tRecados)
        Intelidata.Tables.Add(tCréditos)
        Intelidata.Tables.Add(tTerceirização)
        Intelidata.Tables.Add(tPrioridade)
    End Sub

    Sub CarregarTabelaDeRecados()
        Dim dc As New DataColumn()
        dc.ColumnName = "colID"
        dc.AutoIncrement = True
        dc.AutoIncrementSeed = 0
        dc.AutoIncrementStep = 1

        tRecados.Columns.Add(dc)
        tRecados.Columns.Add("colDataHora", GetType(Date))
        tRecados.Columns.Add("colResp", GetType(String))
        tRecados.Columns.Add("colQuem", GetType(String))
        tRecados.Columns.Add("colTel", GetType(String))
        tRecados.Columns.Add("colMsg", GetType(String))
    End Sub

    Sub CarregarTabelaDeCréditos()

        Dim dc As New DataColumn()
        dc.ColumnName = "colID"
        dc.AutoIncrement = True
        dc.AutoIncrementSeed = 0
        dc.AutoIncrementStep = 1

        tCréditos.Columns.Add(dc)
        tCréditos.Columns.Add("colDataHora", GetType(Date))
        tCréditos.Columns.Add("colCliente", GetType(String))
        tCréditos.Columns.Add("colProd", GetType(String))
        tCréditos.Columns.Add("colValor", GetType(Double))
    End Sub

    Sub CarregarTabelaDeTerceirização()
        Dim dc As New DataColumn()
        dc.ColumnName = "colID"
        dc.AutoIncrement = True
        dc.AutoIncrementSeed = 0
        dc.AutoIncrementStep = 1

        tTerceirização.Columns.Add(dc)
        tTerceirização.Columns.Add("colDataHora", GetType(Date))
        tTerceirização.Columns.Add("colCliente", GetType(String))
        tTerceirização.Columns.Add("colOS", GetType(String))
        tTerceirização.Columns.Add("colDesc", GetType(String))
        tTerceirização.Columns.Add("colEmpr", GetType(String))
        tTerceirização.Columns.Add("colSit", GetType(String))
        tTerceirização.Columns.Add("colObs", GetType(String))
    End Sub

    Sub CarregarTabelaDePrioridades()
        Dim dc As New DataColumn()
        dc.ColumnName = "colID"
        dc.AutoIncrement = True
        dc.AutoIncrementSeed = 0
        dc.AutoIncrementStep = 1

        tPrioridade.Columns.Add(dc)
        tPrioridade.Columns.Add("colDataHora", GetType(Date))
        tPrioridade.Columns.Add("colCliente", GetType(String))
        tPrioridade.Columns.Add("colCnt", GetType(String))
        tPrioridade.Columns.Add("colObs", GetType(String))
    End Sub

    Function DiretórioExiste(ByVal pasta As String) As Boolean
        Return IO.Directory.Exists(pasta)
    End Function

    Sub CriarDiretório(ByVal pasta As String)
        IO.Directory.CreateDirectory(pasta)
    End Sub

    Sub ExcluirDiretório(ByVal pasta As String)
        IO.Directory.Delete(pasta)
    End Sub

    Function ArquivoExiste(ByVal arquivo As String) As Boolean
        Return IO.File.Exists(arquivo)
    End Function

    Sub CriarArquivo(ByVal arquivo As String)
        Dim fls As New IO.FileStream(ArquivoDeRecados, IO.FileMode.CreateNew)
        fls.Close()
    End Sub

    Sub ExcluirArquivo(ByVal arquivo As String)
        IO.File.Delete(arquivo)
    End Sub

    Sub CriarBancoDeDados()
        If DiretórioExiste(PastaDeRecados) = False Then
            If ArquivoExiste(ArquivoDeRecados) = False Then
                CriarDiretório(PastaDeRecados)
                CriarArquivo(ArquivoDeRecados)
                CarregarTabelaDeRecados()
                CarregarTabelaDeCréditos()
                CarregarTabelaDeTerceirização()
                CarregarTabelaDePrioridades()
                CarregarTabelas()
            End If
        Else
            If ArquivoExiste(ArquivoDeRecados) = False Then
                CriarArquivo(ArquivoDeRecados)
                CarregarTabelaDeRecados()
                CarregarTabelaDeCréditos()
                CarregarTabelaDeTerceirização()
                CarregarTabelaDePrioridades()
                CarregarTabelas()
            Else
                CarregarTabelaDeRecados()
                CarregarTabelaDeCréditos()
                CarregarTabelaDeTerceirização()
                CarregarTabelaDePrioridades()
                CarregarTabelas()
            End If
        End If
    End Sub

    Function ExisteBancoDeDados() As Boolean
        If DiretórioExiste(PastaDeRecados) = True Then
            If ArquivoExiste(ArquivoDeRecados) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function

    Sub DesativarBotões()
        If NúmeroDeLinhas(dgvRec) = 0 Then
            DesativarBotãoDeExcluirRecados()
        Else
            AtivarBotãoDeExcluirRecados()
        End If
        If NúmeroDeLinhas(dgvClientes) = 0 Then
            DesativarBotãoDeExcluirCréditos()
        Else
            AtivarBotãoDeExcluirCréditos()
        End If
        If NúmeroDeLinhas(dgvTerc) = 0 Then
            DesativarBotãoDeExcluirTerceirização()
        Else
            AtivarBotãoDeExcluirTerceirização()
        End If
        If NúmeroDeLinhas(dgvPrior) = 0 Then
            DesativarBotãoExcluirPrioridade()
        Else
            AtivarBotãoExcluirPrioridade()
        End If
        cmdAtiv.Visible = Not (My.Settings.Ativado)
    End Sub

    Sub OcultarColunasDeRecados()
        dgvRec.Columns(0).Visible = False 'ID
        dgvRec.Columns(1).Visible = True 'Data
        dgvRec.Columns(2).Visible = True 'Responsável
        dgvRec.Columns(3).Visible = True 'Quem
        dgvRec.Columns(4).Visible = True 'Contato
        dgvRec.Columns(5).Visible = False 'Mensagem
    End Sub

    Sub OcultarColunasDeCréditos()
        dgvClientes.Columns(0).Visible = False 'ID
        dgvClientes.Columns(1).Visible = True 'Cliente
        dgvClientes.Columns(2).Visible = True 'Produto
        dgvClientes.Columns(3).Visible = True 'Valor
    End Sub

    Sub OcultarColunasDeTerceirização()
        dgvTerc.Columns(0).Visible = False 'ID
        dgvTerc.Columns(1).Visible = True 'Data
        dgvTerc.Columns(2).Visible = True 'Cliente
        dgvTerc.Columns(3).Visible = True 'OS
        dgvTerc.Columns(4).Visible = False 'Descrição
        dgvTerc.Columns(5).Visible = True  'Empresa
        dgvTerc.Columns(6).Visible = True  'Situação
        dgvTerc.Columns(7).Visible = False 'Observação
    End Sub

    Sub OcultarColunasDosPriorizados()
        dgvTerc.Columns(0).Visible = False 'ID
        dgvTerc.Columns(1).Visible = True 'Data
        dgvTerc.Columns(2).Visible = True 'Cliente
        dgvTerc.Columns(3).Visible = True  'Contato
        dgvTerc.Columns(4).Visible = False 'Observação
    End Sub

    Public Sub CarregarRecados()
        dgvRec.DataSource = Intelidata
        dgvRec.DataMember = "Recados"
    End Sub
    '
    Public Sub CarregarCréditos()
        dgvClientes.DataSource = Intelidata
        dgvClientes.DataMember = "Créditos"
    End Sub

    Public Sub CarregarServiçosTerceirizados()
        dgvTerc.DataSource = Intelidata
        dgvTerc.DataMember = "Terceirização"
    End Sub

    Public Sub CarregarClientesPriorizados()
        dgvPrior.DataSource = Intelidata
        dgvPrior.DataMember = "Prioridade"
    End Sub

    Public Sub SalvarBancoDeDados()
        Intelidata.WriteXml(ArquivoDeRecados, XmlWriteMode.WriteSchema)
    End Sub

    Public Sub CarregarBancoDeDados()
        Intelidata.ReadXml(ArquivoDeRecados, XmlReadMode.IgnoreSchema)
    End Sub

    Public Sub RenomearTextoDasColunasDeRecados()
        dgvRec.Columns(0).HeaderText = "ID"
        dgvRec.Columns(1).HeaderText = "Data e Hora"
        dgvRec.Columns(2).HeaderText = "Responsável"
        dgvRec.Columns(3).HeaderText = "De Quem"
        dgvRec.Columns(4).HeaderText = "Contato"
        dgvRec.Columns(5).HeaderText = "Mensagem"
    End Sub

    Public Sub RenomearTextoDasColunasDeCréditos()
        dgvClientes.Columns(0).HeaderText = "ID"
        dgvClientes.Columns(1).HeaderText = "Data e Hora"
        dgvClientes.Columns(2).HeaderText = "Cliente"
        dgvClientes.Columns(3).HeaderText = "Produto"
        dgvClientes.Columns(4).HeaderText = "Valor"
    End Sub

    Public Sub RenomearTextoDasColunasDeTerceirização()
        dgvTerc.Columns(0).HeaderText = "ID"
        dgvTerc.Columns(1).HeaderText = "Data e Hora"
        dgvTerc.Columns(2).HeaderText = "Cliente"
        dgvTerc.Columns(3).HeaderText = "OS"
        dgvTerc.Columns(4).HeaderText = "Descrição"
        dgvTerc.Columns(5).HeaderText = "Empresa"
        dgvTerc.Columns(6).HeaderText = "Situação"
        dgvTerc.Columns(7).HeaderText = "Observação"
    End Sub

    Public Sub RenomearTextoDasColunasDosPriorizados()
        dgvPrior.Columns(0).HeaderText = "ID"
        dgvPrior.Columns(1).HeaderText = "Data e Hora"
        dgvPrior.Columns(2).HeaderText = "Cliente"
        dgvPrior.Columns(3).HeaderText = "Contato"
        dgvPrior.Columns(4).HeaderText = "Observação"
    End Sub

    Sub DesativarBotãoDeExcluirRecados()
        cmdExcRec.Enabled = False
    End Sub

    Sub AtivarBotãoDeExcluirRecados()
        cmdExcRec.Enabled = True
    End Sub

    Sub DesativarBotãoDeExcluirCréditos()
        cmdExcCred.Enabled = False
    End Sub

    Sub AtivarBotãoDeExcluirCréditos()
        cmdExcCred.Enabled = True
    End Sub

    Sub DesativarBotãoDeExcluirTerceirização()
        cmdExcTerc.Enabled = False
    End Sub

    Sub AtivarBotãoDeExcluirTerceirização()
        cmdExcTerc.Enabled = True
    End Sub

    Sub DesativarBotãoExcluirPrioridade()
        cmdExcPrior.Enabled = False
    End Sub

    Sub AtivarBotãoExcluirPrioridade()
        cmdExcPrior.Enabled = True
    End Sub

    Function EstáAtivado() As Boolean
        Return My.Settings.Ativado
    End Function





    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do While EstáAtivado() = False
            ativar.ShowDialog()
            If EstáAtivado() = False Then Application.Exit()
        Loop

        If ExisteBancoDeDados() = False Then
            CriarBancoDeDados()
            SalvarBancoDeDados()
        Else
            CarregarBancoDeDados()
        End If

        CarregarRecados()
        CarregarCréditos()
        CarregarServiçosTerceirizados()
        CarregarClientesPriorizados()

        RenomearTextoDasColunasDeRecados()
        RenomearTextoDasColunasDeCréditos()
        RenomearTextoDasColunasDeTerceirização()
        RenomearTextoDasColunasDosPriorizados()

        OcultarColunasDeRecados()
        OcultarColunasDeCréditos()
        OcultarColunasDeTerceirização()
        OcultarColunasDosPriorizados()

        DesativarBotões()
    End Sub
    '
    Private Sub main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F8 Or e.KeyData = Keys.Delete Then
            cmdExc_Click(sender, e)
            Return
        End If
    End Sub
    '
    Private Sub dgvRec_SelectedChanged(sender As Object, e As EventArgs) Handles dgvRec.SelectionChanged

    End Sub
    '
    Private Sub dgvRec_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.RowIndex = -1 And dgvRec.SelectedRows.Count > 0 Then
            selected = dgvRec.SelectedRows(0).Cells("ID").Value.ToString()
        End If
    End Sub
    '
    Private Sub cmdFc_Click(sender As Object, e As EventArgs) Handles cmdFcRec.Click
        Me.Close()
    End Sub
    '
    Private Sub cmdExc_Click(sender As Object, e As EventArgs) Handles cmdExcRec.Click
        If MsgBox("Tem certeza que deseja excluir este recado? Ele não poderá ser recuperado.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Excluir recado") = MsgBoxResult.Yes Then
            ExcluirLinha(dgvRec, "Recados")
            SalvarBancoDeDados()
            CarregarRecados()
            OcultarColunasDeRecados()
            RenomearTextoDasColunasDeRecados()
        Else

        End If
    End Sub

    Private Sub lstchkTrf_ItemChecked(sender As Object, e As ItemCheckedEventArgs)
        If e.Item.Checked = True Then
            e.Item.Font = New Font(e.Item.Font.Name, e.Item.Font.Size, FontStyle.Strikeout)
        Else
            e.Item.Font = New Font(e.Item.Font.Name, e.Item.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub chkUrg_CheckedChanged(sender As Object, e As EventArgs)
        importancia = Color.Red
    End Sub

    Private Sub chkMtImp_CheckedChanged(sender As Object, e As EventArgs)
        importancia = Color.Orange
    End Sub

    Private Sub chkImp_CheckedChanged(sender As Object, e As EventArgs)
        importancia = Color.Green
    End Sub

    Private Sub chkDv_CheckedChanged(sender As Object, e As EventArgs)
        importancia = Color.Black
    End Sub

    Private Sub cmdNvCred_Click(sender As Object, e As EventArgs) Handles cmdNvCred.Click
        novo_credito.ModoDeAbertura = novo_credito.Modo.adicionar
        If novo_credito.ShowDialog() = DialogResult.OK Then
            CarregarCréditos()
            RenomearTextoDasColunasDeCréditos()
            OcultarColunasDeCréditos()
        End If
    End Sub

    Private Sub cmdNvTerc_Click(sender As Object, e As EventArgs) Handles cmdNvTerc.Click
        nova_terceirização.ModoDeAbertura = nova_terceirização.Modo.adicionar
        If nova_terceirização.ShowDialog() = DialogResult.OK Then
            CarregarServiçosTerceirizados()
            RenomearTextoDasColunasDeTerceirização()
            OcultarColunasDeTerceirização()
        End If
    End Sub

    Private Sub cmdNvRec_Click(sender As Object, e As EventArgs) Handles cmdNvRec.Click
        novo_recado.modoDeAbertura = novo_recado.Modo.adicionar
        If novo_recado.ShowDialog() = DialogResult.OK Then
            CarregarRecados()
            RenomearTextoDasColunasDeRecados()
            OcultarColunasDeRecados()
        End If
    End Sub

    Private Sub dgvRec_DoubleClick(sender As Object, e As EventArgs) Handles dgvRec.DoubleClick
        If dgvRec.SelectedRows.Count = 1 Then
            novo_recado.modoDeAbertura = novo_recado.Modo.editar
            If novo_recado.ShowDialog = DialogResult.OK Then
                novo_recado.EditarRecado()
            End If
        End If
    End Sub

    Private Sub dgvRec_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvRec.RowsAdded
        If NúmeroDeLinhas(dgvRec) = 0 Then
            DesativarBotãoDeExcluirRecados()
        Else
            AtivarBotãoDeExcluirRecados()
        End If
    End Sub

    Private Sub dgvRec_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvRec.RowsRemoved
        If NúmeroDeLinhas(dgvRec) = 0 Then
            DesativarBotãoDeExcluirRecados()
        Else
            AtivarBotãoDeExcluirRecados()
        End If
    End Sub

    Private Sub dgvClientes_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvClientes.RowsAdded
        If NúmeroDeLinhas(dgvClientes) = 0 Then
            DesativarBotãoDeExcluirCréditos()
        Else
            AtivarBotãoDeExcluirCréditos()
        End If
    End Sub

    Private Sub dgvClientes_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvClientes.RowsRemoved
        If NúmeroDeLinhas(dgvClientes) = 0 Then
            DesativarBotãoDeExcluirCréditos()
        Else
            AtivarBotãoDeExcluirCréditos()
        End If
    End Sub

    Private Sub dgvTerc_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTerc.RowsAdded
        If NúmeroDeLinhas(dgvTerc) = 0 Then
            DesativarBotãoDeExcluirTerceirização()
        Else
            AtivarBotãoDeExcluirTerceirização()
        End If
    End Sub

    Private Sub dgvTerc_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTerc.RowsRemoved
        If NúmeroDeLinhas(dgvTerc) = 0 Then
            DesativarBotãoDeExcluirTerceirização()
        Else
            AtivarBotãoDeExcluirTerceirização()
        End If
    End Sub

    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        If dgvClientes.SelectedRows.Count = 1 Then
            novo_credito.ModoDeAbertura = novo_credito.Modo.editar
            If novo_credito.ShowDialog = DialogResult.OK Then
                novo_credito.EditarCrédito()
            End If
        End If
    End Sub

    Private Sub dgvTerc_DoubleClick(sender As Object, e As EventArgs) Handles dgvTerc.DoubleClick
        If dgvTerc.SelectedRows.Count = 1 Then
            nova_terceirização.ModoDeAbertura = nova_terceirização.Modo.editar
            If nova_terceirização.ShowDialog = DialogResult.OK Then
                nova_terceirização.EditarTerceirização()
            End If
        End If
    End Sub

    Private Sub cmdExcTerc_Click(sender As Object, e As EventArgs) Handles cmdExcTerc.Click
        If NúmeroDeLinhasSelecionadas(dgvTerc) = 1 Then
            If MsgBox("Tem certeza que deseja excluir esta saída para serviço terceirizado? Ela não poderá ser recuperado.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Excluir saída") = MsgBoxResult.Yes Then
                ExcluirLinha(dgvTerc, "Terceirização")
            End If
        End If
    End Sub

    Private Sub cmdExcCred_Click(sender As Object, e As EventArgs) Handles cmdExcCred.Click
        If NúmeroDeLinhasSelecionadas(dgvClientes) = 1 Then
            If MsgBox("Tem certeza que deseja excluir esta entrada de crédito? Ela não poderá ser recuperada.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Excluir crédito") = MsgBoxResult.Yes Then
                ExcluirLinha(dgvClientes, "Créditos")
            End If
        End If
    End Sub

    Private Sub txtPesqRec_TextChanged(sender As Object, e As EventArgs) Handles txtPesqRec.TextChanged
        filtro = txtPesqRec.Text
        dgvRec.DataSource = Pesquisar("Recados", "colQuem", filtro)
    End Sub

    Private Sub cmdFiltroTodos_Click(sender As Object, e As EventArgs) Handles cmdFiltroTodos.Click
        filtro = ""
        dgvRec.DataSource = Pesquisar("Recados", "colQuem", filtro)
    End Sub

    Private Sub cmdFiltroSemana_Click(sender As Object, e As EventArgs) Handles cmdFiltroSemana.Click
        filtro &= "colDataHora > " & Today.Subtract(New TimeSpan(7, 0, 0, 0))
        dgvRec.DataSource = Pesquisar("Recados", "colQuem", filtro)
    End Sub

    Private Sub cmdFiltroHoje_Click(sender As Object, e As EventArgs) Handles cmdFiltroHoje.Click
        filtro &= "colDataHora=" & Today.ToString
        dgvRec.DataSource = Pesquisar("Recados", "colQuem", filtro)
    End Sub

    Private Sub cmdFiltroMês_Click(sender As Object, e As EventArgs) Handles cmdFiltroMês.Click
        filtro &= "colDataHora=/" & Today.Month & "/"
        dgvRec.DataSource = Pesquisar("Recados", "colQuem", filtro)
    End Sub

    Private Sub cmdAtiv_Click(sender As Object, e As EventArgs) Handles cmdAtiv.Click
        ativar.ShowDialog()
    End Sub

    Private Sub cmdAdPrior_Click(sender As Object, e As EventArgs) Handles cmdAdPrior.Click
        nova_priorid.ModoDeAbertura = nova_priorid.Modo.adicionar
        If nova_priorid.ShowDialog() = DialogResult.OK Then
            CarregarClientesPriorizados()
            RenomearTextoDasColunasDosPriorizados()
            OcultarColunasDosPriorizados()
        End If
    End Sub
End Class
