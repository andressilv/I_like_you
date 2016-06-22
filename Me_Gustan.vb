
Imports System.Data.OleDb

Public Class Me_Gustan

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable



    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Me_Gustan"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(2) As DataColumn
        VEC(0) = TABLA.Columns("mi_usuario")
        VEC(1) = TABLA.Columns("el_usuario")
        TABLA.PrimaryKey = VEC
    End Sub
 
End Class
