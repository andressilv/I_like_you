
Imports System.Data.OleDb


Public Class Usuarios

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable
    Dim FILA As DataRow
   
    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Usuarios"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(1) As DataColumn
        VEC(0) = TABLA.Columns("mi_usuario")
        TABLA.PrimaryKey = VEC
    End Sub

    Public Sub New(ByVal miUsuario As Int32)
    End Sub

    Public Sub VALIDAR()
        If FrmIdentificarse.TBEmail.Text = FILA("email") And FrmIdentificarse.TBPalabra.Text = FILA("palabra") Then
            FrmVerFotos.Show()
        End If

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
    Public Sub GRABAR()

        FILA = TABLA.NewRow
        TABLA.Rows.Add(FILA)

        FILA("nombre") = FrmNuevoUsuario.TBNombre.Text
        FILA("sexo") = FrmNuevoUsuario.CBSexo.SelectedIndex
        FILA("email") = FrmNuevoUsuario.TBEmail.Text
        FILA("palabra") = FrmNuevoUsuario.TBPalabra.Text
        FILA("hombres") = FrmNuevoUsuario.CHHombres.Checked = True
        FILA("mujeres") = FrmNuevoUsuario.CHMujeres.Checked = True
        FILA("foto") = FrmNuevoUsuario.TBFoto.Text

    End Sub
End Class
