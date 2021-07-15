Public Class Tabelas

    Overloads Shared Sub AdicionarLinha(ByVal tabela As DataTable, ByVal linha As DataRow)
        tabela.Rows.Add(linha)
        tabela.AcceptChanges()
    End Sub

    Overloads Shared Sub AdicionarLinha(ByVal tabela As String, ByVal linha As DataRow)
        main.Intelidata.Tables(tabela).Rows.Add(linha)
        main.Intelidata.Tables(tabela).AcceptChanges()
    End Sub

    Overloads Shared Sub AdicionarLinha(ByVal tabela As DataTable, ParamArray dadosDaTabela() As Object)
        Dim dr As DataRow = tabela.NewRow()
        For i As Integer = 0 To UBound(dadosDaTabela)
            dr(i) = dadosDaTabela(i)
        Next
        tabela.AcceptChanges()
    End Sub

    Overloads Shared Sub AdicionarLinha(ByVal tabela As String, ParamArray dadosDaTabela() As Object)
        Dim dr As DataRow = main.Intelidata.Tables(tabela).NewRow()
        For i As Integer = 0 To UBound(dadosDaTabela)
            dr(i) = dadosDaTabela(i)
        Next
        main.Intelidata.Tables(tabela).AcceptChanges()
    End Sub

    ''' <summary>
    ''' Obtém o número de colunas de uma tabela.
    ''' </summary>
    ''' <param name="tabela">Tabela desejada para obter o número de colunas.</param>
    ''' <returns></returns>
    Overloads Shared Function NúmeroDeColunas(ByVal tabela As DataTable) As Integer
        Return tabela.Columns.Count
    End Function

    ''' <summary>
    ''' Obtém o número de colunas de uma tabela.
    ''' </summary>
    ''' <param name="tabela">Tabela desejada para obter o número de colunas.</param>
    ''' <returns></returns>
    Overloads Shared Function NúmeroDeColunas(ByVal tabela As String) As Integer
        Return main.Intelidata.Tables(tabela).Columns.Count
    End Function

    ''' <summary>
    ''' Obtém o número de linhas de uma tabela.
    ''' </summary>
    ''' <param name="tabela">Tabela desejada para obter o número de linhas.</param>
    ''' <returns></returns>
    Overloads Shared Function NúmeroDeLinhas(ByVal tabela As DataTable) As Integer
        Return tabela.Rows.Count
    End Function

    ''' <summary>
    ''' Obtém o número de linhas de uma tabela.
    ''' </summary>
    ''' <param name="tabela">Tabela desejada para obter o número de linhas.</param>
    ''' <returns></returns>
    Overloads Shared Function NúmeroDeLinhas(ByVal tabela As String) As Integer
        Return main.Intelidata.Tables(tabela).Rows.Count
    End Function

    ''' <summary>
    ''' Obtém o número de linhas exibidas no datagrid.
    ''' </summary>
    ''' <param name="tabela">Datagrid desejado para obter o número de linhas. 
    ''' O número de linhas será obtido de acordo com o que está exibido na tabela.</param>
    ''' <returns></returns>
    Overloads Shared Function NúmeroDeLinhas(ByVal tabela As DataGridView) As Integer
        Return tabela.RowCount()
    End Function

    ''' <summary>
    ''' Obtém os dados de uma linha especificada.
    ''' </summary>
    ''' <param name="tabela">Nome da tabela à qual a linha pertence.</param>
    ''' <param name="linha">Número da linha desejada.</param>
    ''' <returns></returns>
    Overloads Shared Function ObterLinhaDaTabela(ByVal tabela As String, ByVal linha As Integer) As DataRow
        Dim dr As DataRow = main.Intelidata.Tables(tabela).Rows(linha)
        Return dr
    End Function

    ''' <summary>
    ''' Obtém os dados de uma linha especificada.
    ''' </summary>
    ''' <param name="tabela">Nome da tabela à qual a linha pertence.</param>
    ''' <param name="linha">Número da linha desejada.</param>
    ''' <returns></returns>
    Overloads Shared Function ObterLinhaDaTabela(ByVal tabela As DataTable, ByVal linha As Integer) As DataRow
        Dim dr As DataRow = tabela.Rows(linha)
        Return dr
    End Function

    ''' <summary>
    ''' Obtém os dados de uma linha especificada.
    ''' </summary>
    ''' <param name="tabela">Nome da tabela à qual a linha pertence.</param>
    ''' <param name="id">Número da linha desejada.</param>
    ''' <returns></returns>
    Overloads Shared Function ObterLinhaDaTabelaComID(ByVal tabela As String, ByVal id As Integer) As DataRow
        For Each dr As DataRow In main.Intelidata.Tables(tabela).Rows
            If id = dr("colID") Then
                Return dr
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Obtém os dados de uma linha especificada.
    ''' </summary>
    ''' <param name="tabela">Nome da tabela à qual a linha pertence.</param>
    ''' <param name="id">Número da linha desejada.</param>
    ''' <returns></returns>
    Overloads Shared Function ObterLinhaDaTabelaComID(ByVal tabela As DataTable, ByVal id As Integer) As DataRow
        For Each dr As DataRow In tabela.Rows
            If id = dr("colID") Then
                Return dr
            End If
        Next
        Return Nothing
    End Function

    Overloads Shared Function ObterLinhaSelecionada(ByVal dgv As DataGridView, ByVal table As DataTable) As DataRow
        Dim id As Integer = dgv(0, dgv.SelectedRows.Item(0).Index).Value
        Return table.Select("colID = " & id.ToString)(0)
    End Function

    Overloads Shared Function ObterLinhaSelecionada(ByVal dgv As DataGridView, ByVal tabela As String) As DataRow
        Dim id As Integer = dgv(0, dgv.SelectedRows.Item(0).Index).Value
        Return main.Intelidata.Tables(tabela).Select("colID = " & id.ToString)(0)
    End Function

    Overloads Shared Function ÚltimoIDdeProduto(ByVal tabela As DataTable) As Integer
        Dim i As Integer = 0
        For Each dr As DataRow In tabela.Rows
            If Int(dr("colID")) = 0 Then
                Exit For
            End If
            If Int(dr("colID")) > i Then
                i = Int(dr("colID"))
            End If
        Next dr
        Return i
    End Function

    Overloads Shared Function ÚltimoIDdeProduto(ByVal tabela As String) As Integer
        Dim i As Integer = 0
        For Each dr As DataRow In main.Intelidata.Tables(tabela).Rows
            If Int(dr("colID")) = 0 Then
                Exit For
            End If
            If Int(dr("colID")) > i Then
                i = Int(dr("colID"))
            End If
        Next dr
        Return i
    End Function

    ''' <summary>
    ''' Compara todos os valores de uma coluna em cada uma das linhas de uma tabela especificada e 
    ''' retorna qual o maior valor da tabela.
    ''' </summary>
    ''' <param name="tabela">Nome da tabela.</param>
    ''' <param name="coluna">Nome da coluna. Deve armazenar valores do tipo Integer.</param>
    ''' <returns></returns>
    Overloads Shared Function ObterMaiorValorDeTabelaEmColuna(ByVal tabela As DataTable, ByVal coluna As String) As Integer
        Dim nv As Integer = 0
        Dim pv As Integer = 0
        For Each r As DataRow In tabela.Rows
            nv = Int(r(coluna))
            If nv > pv Then pv = nv
        Next
        Return pv
    End Function

    Overloads Shared Function ObterMaiorValorDeTabelaEmColuna(ByVal tabela As String, ByVal coluna As String) As Integer
        Dim nv As Integer = 0
        Dim pv As Integer = 0
        For Each r As DataRow In main.Intelidata.Tables(tabela).Rows
            nv = Int(r(coluna))
            If nv > pv Then pv = nv
        Next
        Return pv
    End Function

    Shared Function NúmeroDeLinhasSelecionadas(ByVal tabela As DataGridView) As Integer
        Return tabela.SelectedRows.Count
    End Function

    Overloads Shared Sub ExcluirLinha(ByVal tabela As DataGridView)
        If tabela.SelectedRows.Count > 0 Then
            Dim dr As DataGridViewRow = tabela.SelectedRows.Item(0)
            tabela.Rows.Remove(dr)
            main.SalvarBancoDeDados()
        End If
    End Sub

    Overloads Shared Sub ExcluirLinha(ByVal grade As DataGridView, ByVal tabela As DataTable)
        If grade.SelectedRows.Count > 0 Then
            tabela.Rows.RemoveAt(grade.SelectedRows(0).Index)
            main.SalvarBancoDeDados()
        End If
    End Sub

    Overloads Shared Sub ExcluirLinha(ByVal grade As DataGridView, ByVal tabela As String)
        If grade.SelectedRows.Count > 0 Then
            main.Intelidata.Tables(tabela).Rows.RemoveAt(grade.SelectedRows(0).Index)
            main.SalvarBancoDeDados()
        End If
    End Sub

    Overloads Shared Sub ExcluirLinha(ByVal grade As DataGridView, ByVal tabela As DataTable,
                                      ByVal filtro As String)
        If grade.SelectedRows.Count > 0 Then
            For Each dr As DataRow In tabela.Select(filtro)
                dr.Delete()
            Next
            tabela.AcceptChanges()
            main.SalvarBancoDeDados()
        End If
    End Sub

    Overloads Shared Sub ExcluirLinha(ByVal grade As DataGridView, ByVal tabela As String,
                                      ByVal filtro As String)
        If grade.SelectedRows.Count > 0 Then
            For Each dr As DataRow In main.Intelidata.Tables(tabela).Select(filtro)
                dr.Delete()
            Next
            main.Intelidata.Tables(tabela).AcceptChanges()
            main.SalvarBancoDeDados()
        End If
    End Sub

    Overloads Shared Function Pesquisar(ByVal tabela As String,
                     ByVal expressãoParaPesquisar As String) As DataView
        Dim dt As DataView = New DataView(main.Intelidata.Tables(tabela))
        dt.RowFilter = expressãoParaPesquisar
        Return dt
    End Function

    Overloads Shared Function Pesquisar(ByVal tabela As String,
                     ByVal coluna As String, ByVal expressãoParaPesquisar As String) As DataView
        Dim dt As DataView = New DataView(main.Intelidata.Tables(tabela))
        dt.RowFilter = String.Concat(coluna, " LIKE '%", expressãoParaPesquisar, "%'")
        Return dt
    End Function

    Overloads Shared Function Pesquisar(ByVal tabela As DataTable,
                     ByVal coluna As String, ByVal expressãoParaPesquisar As String) As DataView
        Dim dt As DataView = New DataView(tabela)
        dt.RowFilter = String.Concat(coluna, " LIKE '%", expressãoParaPesquisar, "%'")
        Return dt
    End Function

    Overloads Shared Function Pesquisar(ByVal tabela As String,
                     ByVal estadoDaLinha As DataViewRowState) As DataView
        Dim dt As DataView = New DataView(main.Intelidata.Tables(tabela))
        dt.RowStateFilter = estadoDaLinha
        Return dt
    End Function

    Overloads Shared Function Pesquisar(ByVal tabela As DataTable,
                     ByVal estadoDaLinha As DataViewRowState) As DataView
        Dim dt As DataView = New DataView(tabela)
        dt.RowStateFilter = DataViewRowState.Added Or DataViewRowState.ModifiedCurrent
        Return dt
    End Function

    ''' <summary>
    ''' Apaga todas as linhas da tabela.
    ''' </summary>
    ''' <param name="tabela">Tabela para esvaziar.</param>
    Overloads Shared Sub EsvaziarTabela(ByVal tabela As DataTable)
        tabela.Clear()
    End Sub

    ''' <summary>
    ''' Apaga todas as linhas da tabela.
    ''' </summary>
    ''' <param name="tabela">Nome da tabela para esvaziar.</param>
    Overloads Shared Sub EsvaziarTabela(ByVal tabela As String)
        main.Intelidata.Tables(tabela).Clear()
    End Sub

End Class
