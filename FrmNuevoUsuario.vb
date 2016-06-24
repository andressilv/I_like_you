Public Class FrmNuevoUsuario
    Dim objusuario As New Usuarios
    Private Sub BPuntitos_Click(sender As System.Object, e As System.EventArgs) Handles BPuntitos.Click

        OFD.FileName = "Archivos de texto|*.jpg"
        OFD.InitialDirectory = "D:\"
        OFD.FileName = ""
        OFD.ShowDialog()
        TBFoto.Text = OFD.SafeFileName

        Dim RUTA As String
        RUTA = OFD.FileName

        My.Computer.FileSystem.CopyFile(RUTA, ("FOTOS\" & TBFoto.Text))

    End Sub

    Private Sub TBPalabra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPalabra.TextChanged
        If CHVer.Checked = False Then

            TBPalabra.PasswordChar = ("*")
        Else
            TBPalabra.PasswordChar = ("")
        End If
    End Sub

    Private Sub FrmNuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBSexo.SelectedIndex = 1
    End Sub
    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Dim objetousuario As New Usuarios
        Dim HOMBRES = "NO"
        Dim MUJERES = "NO"
        If CHHombres.Checked = True Then
            HOMBRES = "SI"
        End If

        If CHMujeres.Checked = True Then
            MUJERES = "SI"
        End If
        objetousuario.GRABAR(TBNombre.Text, TBEmail.Text, TBPalabra.Text, CBSexo.Text, HOMBRES, MUJERES, TBFoto.Text)
    End Sub

    Private Sub CHVer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHVer.CheckedChanged
        If CHVer.Checked = False Then

            TBPalabra.PasswordChar = ("*")
        Else
            TBPalabra.PasswordChar = ("")
        End If
    End Sub
End Class