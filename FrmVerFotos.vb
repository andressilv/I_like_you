Public Class FrmVerFotos
    Dim objetousuario As New Usuarios
    Dim TUUSUARIO As New DataTable
    Dim contar As Integer = 0
    Dim ULTIMO As Integer
    Dim OBFILA As DataRow


    Private Sub FrmVerFotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TUUSUARIO = objetousuario.OBTENER
        Dim FILA() As DataRow = TUUSUARIO.Select("mujeres='NO'")

        If (FILA.Length > 0) Then
            MessageBox.Show("filas: " & FILA.Length.ToString())
        End If

        ULTIMO = TUUSUARIO.Rows.Count - 1
        LNombre.Text = TUUSUARIO.Rows(contar)("nombre")
        PBFoto.Load("FOTOS/" & TUUSUARIO.Rows(contar)("foto"))
    End Sub


    Private Sub BAvanzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAvanzar.Click
        contar = contar + 1
        If contar > ULTIMO Then
            contar = 0
        End If
        LNombre.Text = TUUSUARIO.Rows(contar)("nombre")
        PBFoto.Load("FOTOS/" & TUUSUARIO.Rows(contar)("foto"))
    End Sub
    
End Class
