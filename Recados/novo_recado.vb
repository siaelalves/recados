Imports messageFrom.Tabelas

Public Class novo_recado

    Public Shared modoDeAbertura As Modo

    Enum Modo
        adicionar = 0
        editar = 1
    End Enum

    Sub DefinirValoresPadrão()
        txtDt.Value = Today
        txtHr.Value = Now
        txtRsp.Text = ""
        txtQuem.Text = ""
        txtCnt.Text = ""
        txtMsg.Text = ""
    End Sub

    Sub CarregarDadosDaTabela()
        txtDt.Value = ObterLinhaSelecionada(main.dgvRec, "Recados")("colDataHora")
        txtHr.Value = ObterLinhaSelecionada(main.dgvRec, "Recados")("colDataHora")
        txtRsp.Text = ObterLinhaSelecionada(main.dgvRec, "Recados")("colResp")
        txtQuem.Text = ObterLinhaSelecionada(main.dgvRec, "Recados")("colQuem")
        txtCnt.Text = ObterLinhaSelecionada(main.dgvRec, "Recados")("colTel")
        txtMsg.Text = ObterLinhaSelecionada(main.dgvRec, "Recados")("colMsg")
    End Sub

    Public Sub AdicionarRecado()
        Dim dr As DataRow = main.Intelidata.Tables("Recados").NewRow()
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colResp") = txtRsp.Text
        dr("colQuem") = txtQuem.Text
        dr("colTel") = txtCnt.Text
        dr("colMsg") = txtMsg.Text
        main.Intelidata.Tables("Recados").Rows.Add(dr)
        main.Intelidata.Tables("Recados").AcceptChanges()
        main.Intelidata.Tables("Recados").GetChanges()
        main.SalvarBancoDeDados()
    End Sub

    Public Sub EditarRecado()
        Dim dr As DataRow = ObterLinhaSelecionada(main.dgvRec, "Recados")
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colResp") = txtRsp.Text
        dr("colQuem") = txtQuem.Text
        dr("colTel") = txtCnt.Text
        dr("colMsg") = txtMsg.Text
        dr.AcceptChanges()
        main.Intelidata.Tables("Recados").AcceptChanges()
        main.Intelidata.Tables("Recados").GetChanges()
        main.SalvarBancoDeDados()
    End Sub





    Private Sub novo_recado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modoDeAbertura = Modo.adicionar Then
            DefinirValoresPadrão()
        Else
            CarregarDadosDaTabela()
        End If
    End Sub

    Private Sub cmdSv_Click(sender As Object, e As EventArgs) Handles cmdSv.Click
        If modoDeAbertura = Modo.adicionar Then
            AdicionarRecado()
        Else
            EditarRecado()
        End If
    End Sub
End Class