Public Class FrmNuevoUsuario
    Dim objusuario As New Usuarios
    Private Sub BPuntitos_Click(sender As System.Object, e As System.EventArgs) Handles BPuntitos.Click
        OFD.FileName = ""
        OFD.ShowDialog()
    End Sub

    Private Sub TBPalabra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPalabra.TextChanged

    End Sub

    Private Sub FrmNuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        objusuario.GRABAR()

    End Sub
End Class