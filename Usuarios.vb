
Imports System.Data.OleDb


Public Class Usuarios

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable
    Dim FILA As DataRow
    Dim filanueva As DataRow

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

                FILA = TABLA.Rows(CONTAR)
                INGRESO = CONTAR
                FrmVerFotos.Show()

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

    Public Sub GRABAR()

        FILA = TABLA.NewRow


        FILA("nombre") = FrmNuevoUsuario.TBNombre.Text
        FILA("sexo") = FrmNuevoUsuario.CBSexo.SelectedIndex
        FILA("email") = FrmNuevoUsuario.TBEmail.Text
        FILA("palabra") = FrmNuevoUsuario.TBPalabra.Text
        FILA("hombres") = FrmNuevoUsuario.CHHombres.Checked = True
        FILA("mujeres") = FrmNuevoUsuario.CHMujeres.Checked = True
        FILA("foto") = FrmNuevoUsuario.TBFoto.Text

        TABLA.Rows.Add(FILA)

    End Sub
End Class
