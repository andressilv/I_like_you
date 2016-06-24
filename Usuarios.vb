
Imports System.Data.OleDb


Public Class Usuarios

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable
    Dim FILAs As DataRow
    Dim filanueva As DataRow
    Dim COMENTARIO As Me_Gustan
    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Usuarios"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(1) As DataColumn
        VEC(0) = TABLA.Columns("mi_usuario")
        TABLA.PrimaryKey = VEC
    End Sub



    Public Sub VALIDAR(ByVal PALABRA As String, ByVal EMAIL As String)

        Dim CONTAR = 0


        For Each BUSCAR In TABLA.Rows
            If FrmIdentificarse.TBPalabra.Text = TABLA.Rows(CONTAR)("palabra") And FrmIdentificarse.TBEmail.Text = TABLA.Rows(CONTAR)("email") Then

                FILAs = TABLA.Rows(CONTAR)
                INGRESO = CONTAR
                FrmVerFotos.Show()
                'COMENTARIO.MEGUSTAESTE()

                Exit For
            Else
                CONTAR = CONTAR + 1
            End If

        Next
    End Sub

    Public Sub AVANZAR()
        Dim contar As Integer

        FrmVerFotos.LNombre.Text = TABLA.Rows(contar)("nombre")
        FrmVerFotos.PBFoto.Load("FOTOS/" & TABLA.Rows(contar)("foto"))

        MEGUSTA = contar
        contar = contar + 1

    End Sub

    Public Function OBTENER() As DataTable

        Return TABLA

    End Function

    Public Function obtenerFiltrada(ByVal tabla As DataTable) As DataTable

        Dim interes1 As String = tabla.Rows(INGRESO)("mujeres").ToString()
        Dim interes2 As String = tabla.Rows(INGRESO)("hombres").ToString()

        Dim tablaFiltrada As DataTable = New DataTable()
        tablaFiltrada.Columns.Add("nombre")
        tablaFiltrada.Columns.Add("foto")
        Dim opcionF As Integer
        Dim opcionM As Integer

        For i = 1 To tabla.Rows.Count - 1

            If interes1.CompareTo("SI") = 0 Then
                opcionF = tabla.Rows(i)("sexo").ToString().CompareTo("F")
            Else
                opcionF = -1
            End If


            If interes2.CompareTo("SI") = 0 Then
                opcionM = tabla.Rows(i)("sexo").ToString().CompareTo("M") 'debería dar igual a 0
            Else
                opcionM = -1
            End If


            If (opcionF = 0) Then
                filanueva = tablaFiltrada.NewRow
                filanueva("nombre") = tabla.Rows(i)("nombre").ToString()
                filanueva("foto") = tabla.Rows(i)("foto").ToString()
                tablaFiltrada.Rows.Add(filanueva)
            End If
            If (opcionM = 0) Then
                filanueva = tablaFiltrada.NewRow
                filanueva("nombre") = tabla.Rows(i)("nombre").ToString()
                filanueva("foto") = tabla.Rows(i)("foto").ToString()
                tablaFiltrada.Rows.Add(filanueva)
            End If


        Next
        Return tablaFiltrada
    End Function

    Public Sub GRABAR(ByVal NOMBRE As String, ByVal EMAIL As String, ByVal PALABRA As String, ByVal SEXO As String, ByVal HOMBRES As String, ByVal MUJERES As String, ByVal FOTO As String)
        Dim filas As DataRow


        Dim auxsexo As String
        Dim corroborarnumerousuario As Long
        filas = TABLA.NewRow
        filas("mi_usuario") = 0

        corroborarnumerousuario = FILAs("mi_usuario")

        filas("nombre") = NOMBRE

        FILAs("email") = EMAIL

        FILAs("palabra") = PALABRA
        If SEXO = "FEMENINO" Then
            auxsexo = "F"
        Else
            auxsexo = "M"

        End If

        FILAs("sexo") = AuxSexo
        filas("foto") = FOTO



        FILAs("mujeres") = MUJERES
        FILAs("hombres") = HOMBRES
        TABLA.Rows.Add(FILAs)


        Actualizar()

    End Sub

    Private Sub Actualizar()
        Dim MAGIGO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub
End Class
