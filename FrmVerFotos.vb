Imports System.Windows.Forms.Button

Public Class FrmVerFotos
    Dim objetousuario As New Usuarios
    Dim TUUSUARIO As New DataTable
    Dim contar As Integer
    Dim fila() As DataRow
    Dim tablaFiltrada As DataTable
    Dim objetomegusta As Me_Gustan


    Private Sub FrmVerFotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'obtiene toda la tabla. el de indice 0 es nuestro usuario
        TUUSUARIO = objetousuario.OBTENER
        mostrarUsuario(TUUSUARIO.Rows(INGRESO)("nombre"), TUUSUARIO.Rows(INGRESO)("foto"))
    End Sub

    Private Sub mostrarUsuario(ByVal nombre As String, ByVal foto As String)
        LNombre.Text = nombre
        PBFoto.Load("FOTOS/" & foto)
    End Sub


    Private Sub BAvanzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAvanzar.Click
        tablaFiltrada = objetousuario.obtenerFiltrada(TUUSUARIO)
        contar = contar + 1
        If contar > tablaFiltrada.Rows.Count - 1 Then
            contar = 0
        End If
    
        mostrarUsuario(tablaFiltrada(contar)("nombre"), tablaFiltrada(contar)("foto"))


    End Sub

    Private Function obtenerListaFiltrada()
        'fila = TUUSUARIO.Select("mujeres=" & "'" & TUUSUARIO.Rows(0)("sexo").ToString() & "'")
        fila = TUUSUARIO.Select("mujeres='M'")
        If (fila.Length > 0) Then
            MessageBox.Show("filas(deberia ser  5): " & fila.Length.ToString())
        End If
        Return fila
    End Function
    Private Sub MEGUSTAFOTO()
        BMeGustaSiNo.Image = IL.Images("CORAZON_ROJO.png")
    End Sub
    Private Sub BMeGustaSiNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMeGustaSiNo.Click
        MEGUSTAFOTO()

    End Sub
End Class
