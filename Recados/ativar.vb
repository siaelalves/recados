Public Class ativar

    Public Const keyUrl As String = "http://download.siaelcarvalho.com/keys.ml"
    Public DwnClient As New Net.WebClient

    Sub MostrarMensagemDeAtivação()
        MsgBox("Seu produto está ativado. Obrigado :)", MsgBoxStyle.Exclamation, "Ativação")
    End Sub

    Sub MostrarMensagemDeErro()
        MsgBox("Não foi possível ativar o programa. Tente inserir outra chave.", MsgBoxStyle.Critical, "Ativação")
    End Sub

    Function EstáAtivado() As Boolean
        Try
            For Each l In DwnClient.DownloadString(keyUrl).Split(vbCrLf)
                If l.Split(";")(3) = txtCPF.Text Then
                    If l.Split(";")(8) = txtCod.Text Then
                        MostrarMensagemDeAtivação()
                        Return True
                    End If
                End If
            Next
        Catch e As Net.WebException
            MostrarMensagemDeErro()
        End Try
        Return False
    End Function

    Private Sub cmdAtiv_Click(sender As Object, e As EventArgs) Handles cmdAtiv.Click
        My.Settings.Ativado = EstáAtivado()
        My.Settings.Save()
    End Sub

End Class