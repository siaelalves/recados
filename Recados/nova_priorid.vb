Imports messageFrom.Tabelas

Public Class nova_priorid

    Public Shared ModoDeAbertura As Modo

    Public Enum Modo
        adicionar = 0
        editar = 1
    End Enum

    Sub DefinirValoresPadrão()
        txtDt.Value = Today
        txtHr.Value = Now
        txtCliente.Text = ""
        txtCnt.Text = ""
        txtProd.Text = ""
        txtObs.Text = ""
    End Sub

    Sub CarregarDadosDaTabela()
        txtDt.Value = ObterLinhaSelecionada(main.dgvPrior, "Prioridade")("colDataHora")
        txtHr.Value = ObterLinhaSelecionada(main.dgvPrior, "Prioridade")("colDataHora")
        txtCliente.Text = ObterLinhaSelecionada(main.dgvPrior, "Prioridade")("colCliente")
        txtCnt.Text = ObterLinhaSelecionada(main.dgvPrior, "Prioridade")("colTel")
        txtObs.Text = ObterLinhaSelecionada(main.dgvPrior, "Prioridade")("colObs")
    End Sub

    Public Sub AdicionarClientePrioritário()
        Dim dr As DataRow = main.Intelidata.Tables("Prioridade").NewRow()
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colCliente") = txtCliente.Text
        dr("colCnt") = txtCnt.Text
        dr("colObs") = txtObs.Text
        main.Intelidata.Tables("Prioridade").Rows.Add(dr)
        main.SalvarBancoDeDados()
    End Sub

    Public Sub EditarClientePriorizado()
        Dim dr As DataRow = ObterLinhaSelecionada(main.dgvTerc, "Prioridade")
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colCliente") = txtCliente.Text
        dr("colCnt") = txtCnt.Text
        dr("colObs") = txtObs.Text
        dr.AcceptChanges()
        main.Intelidata.Tables("Prioridade").AcceptChanges()
        main.Intelidata.Tables("Prioridade").GetChanges()
        main.SalvarBancoDeDados()
    End Sub

    Private Sub nova_priorid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModoDeAbertura = Modo.adicionar Then
            DefinirValoresPadrão()
        Else
            CarregarDadosDaTabela()
        End If
    End Sub

    Private Sub cmdSv_Click(sender As Object, e As EventArgs) Handles cmdSv.Click
        If ModoDeAbertura = Modo.adicionar Then
            AdicionarClientePrioritário()
        Else
            EditarClientePriorizado()
        End If
    End Sub
End Class