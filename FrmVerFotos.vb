Public Class FrmVerFotos
    Dim objetousuario As New Usuarios
    Dim TUUSUARIO As New DataTable
    Dim contar As Integer = 0
    Dim ULTIMO As Integer
    Dim fila() As DataRow
    Dim tablaFiltrada As DataTable


    Private Sub FrmVerFotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'obtiene toda la tabla. el de indice 0 es nuestro usuario
        TUUSUARIO = objetousuario.OBTENER


        ULTIMO = TUUSUARIO.Rows.Count - 1
        'MessageBox.Show("ultimo: " & ULTIMO.ToString())
        mostrarMiUsuario()
    End Sub

    Private Sub mostrarMiUsuario()
        LNombre.Text = TUUSUARIO.Rows(0)("nombre")
        PBFoto.Load("FOTOS/" & TUUSUARIO.Rows(0)("foto"))
    End Sub


    Private Sub BAvanzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAvanzar.Click
        tablaFiltrada = objetousuario.obtenerFiltrada(TUUSUARIO)


        For i = 0 To tablaFiltrada.Rows.Count - 1

            MessageBox.Show("mujeres :" & i.ToString() & tablaFiltrada(i)("nombre").ToString())

        Next


        contar = contar + 1
        If contar > ULTIMO Then
            contar = 0
        End If
        LNombre.Text = fila(contar)("nombre")
        PBFoto.Load("FOTOS/" & fila(contar)("foto"))
    End Sub

    Private Function obtenerListaFiltrada()
        'fila = TUUSUARIO.Select("mujeres=" & "'" & TUUSUARIO.Rows(0)("sexo").ToString() & "'")
        fila = TUUSUARIO.Select("mujeres='M'")
        If (fila.Length > 0) Then
            MessageBox.Show("filas(deberia ser  5): " & fila.Length.ToString())
        End If
        Return fila
    End Function

End Class
