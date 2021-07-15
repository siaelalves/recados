Public Class licenca

    Private Sub licenca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTt.Text = My.Application.Info.Title
        lblvrs.Text = My.Application.Info.Version.ToString
        lblcopy.Text = My.Application.Info.Copyright
        txtLic.Rtf = My.Resources.licenca
    End Sub
End Class