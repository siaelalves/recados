Imports messageFrom.Tabelas


Public Class novo_credito

    Public Shared ModoDeAbertura As Modo

    Public Enum Modo
        adicionar = 0
        editar = 1
    End Enum

    Sub DefinirValoresPadrão()
        txtDt.Value = Today
        txtHr.Value = Now
        txtCliente.Text = ""
        txtProd.Text = ""
        txtValor.Text = 0
    End Sub

    Overloads Function FormatarEmDinheiro(ByVal texto As String) As Double
        Try
            Return Convert.ToDouble(texto)
        Catch ex As Exception
            Return Convert.ToDouble(0)
        End Try
    End Function

    Sub CarregarDadosDaTabela()
        txtDt.Value = ObterLinhaSelecionada(main.dgvClientes, "Créditos")("colDataHora")
        txtHr.Value = ObterLinhaSelecionada(main.dgvClientes, "Créditos")("colDataHora")
        txtCliente.Text = ObterLinhaSelecionada(main.dgvClientes, "Créditos")("colCliente")
        txtProd.Text = ObterLinhaSelecionada(main.dgvClientes, "Créditos")("colProd")
        txtValor.Text = ObterLinhaSelecionada(main.dgvClientes, "Créditos")("colValor")
        lblCredAtValor.Text = "R$" & AtualizarCrédito(txtCliente.Text)
        lblCredNvValor.Text = "R$" & AtualizarCrédito(txtCliente.Text)
    End Sub

    Public Sub AdicionarCrédito()
        Dim dr As DataRow = main.Intelidata.Tables("Créditos").NewRow()
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colCliente") = txtCliente.Text
        dr("colProd") = txtProd.Text
        dr("colValor") = FormatarEmDinheiro(txtValor.Text)
        main.Intelidata.Tables("Créditos").Rows.Add(dr)
        main.SalvarBancoDeDados()
    End Sub

    Public Sub EditarCrédito()
        Dim dr As DataRow = ObterLinhaSelecionada(main.dgvClientes, "Créditos")
        dr("colDataHora") = txtDt.Value.Date.Add(txtHr.Value.TimeOfDay)
        dr("colCliente") = txtCliente.Text
        dr("colProd") = txtProd.Text
        dr("colValor") = FormatarEmDinheiro(txtValor.Text)
        dr.AcceptChanges()
        main.Intelidata.Tables("Créditos").AcceptChanges()
        main.Intelidata.Tables("Créditos").GetChanges()
        main.SalvarBancoDeDados()
    End Sub

    Function AtualizarCrédito(ByVal cliente As String) As Double
        Dim valor As Double
        valor = 0
        For Each p As DataRow In main.Intelidata.Tables("Créditos").Rows
            If p("colCliente") = cliente Then
                valor = valor + p("colValor")
            End If
        Next
        Return valor
    End Function





    Private Sub novo_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModoDeAbertura = Modo.adicionar Then
            DefinirValoresPadrão()
        Else
            CarregarDadosDaTabela()
        End If
    End Sub

    Private Sub cmdSv_Click(sender As Object, e As EventArgs) Handles cmdSv.Click
        If ModoDeAbertura = Modo.adicionar Then
            AdicionarCrédito()
        Else
            EditarCrédito()
        End If
    End Sub
End Class