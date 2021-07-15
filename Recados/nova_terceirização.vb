Imports messageFrom.Tabelas

Public Class nova_terceirização

    Public Shared ModoDeAbertura As Modo

    Public Enum Modo
        adicionar = 0
        editar = 1
    End Enum

    Sub DefinirValoresPadrão()
        txtDt.Value = Today
        txtHr.Value = Now
        txtCliente.Text = ""
        txtOS.Text = ""
        txtDesc.Text = ""
        txtEmp.Text = ""
        txtSit.Text = ""
        txtObs.Text = ""
    End Sub

    Sub CarregarDadosDaTabela()
        txtDt.Value = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colDataHora")
        txtHr.Value = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colDataHora")
        txtCliente.Text = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colCliente")
        txtOS.Text = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colOS")
        txtDesc.Text = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colDesc")
        txtEmp.Text = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colEmpr")
        txtSit.Text = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colSit")
        txtObs.Text = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")("colObs")
    End Sub

    Public Sub AdicionarTerceirização()
        Dim dr As DataRow = main.Intelidata.Tables("Terceirização").NewRow()
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colCliente") = txtCliente.Text
        dr("colOS") = txtOS.Text
        dr("colDesc") = txtDesc.Text
        dr("colEmpr") = txtEmp.Text
        dr("colSit") = txtSit.Text
        dr("colObs") = txtObs.Text
        main.Intelidata.Tables("Terceirização").Rows.Add(dr)
        main.SalvarBancoDeDados()
    End Sub

    Public Sub EditarTerceirização()
        Dim dr As DataRow = ObterLinhaSelecionada(main.dgvTerc, "Terceirização")
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colCliente") = txtCliente.Text
        dr("colOS") = txtOS.Text
        dr("colDesc") = txtDesc.Text
        dr("colEmpr") = txtEmp.Text
        dr("colSit") = txtSit.Text
        dr("colObs") = txtObs.Text
        dr.AcceptChanges()
        main.Intelidata.Tables("Terceirização").AcceptChanges()
        main.Intelidata.Tables("Terceirização").GetChanges()
        main.SalvarBancoDeDados()
    End Sub





    Private Sub terceirização_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModoDeAbertura = Modo.adicionar Then
            DefinirValoresPadrão()
        Else
            CarregarDadosDaTabela()
        End If
    End Sub

    Private Sub cmdSv_Click(sender As Object, e As EventArgs) Handles cmdSv.Click
        If ModoDeAbertura = Modo.adicionar Then
            AdicionarTerceirização()
        Else
            EditarTerceirização()
        End If
    End Sub
End Class