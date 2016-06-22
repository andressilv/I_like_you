Public Class FrmIdentificarse
    Dim objlogin As New Usuarios
    Dim OBJUSUARIO As New Usuarios

    Private Sub BIniciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIniciarSesion.Click

        OBJUSUARIO.VALIDAR(TBPalabra.Text, TBEmail.Text)
    End Sub

    Private Sub FrmIdentificarse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkNuevoUsuario_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkNuevoUsuario.LinkClicked
        Dim fnu As New FrmNuevoUsuario
        fnu.ShowDialog()

    End Sub
End Class
