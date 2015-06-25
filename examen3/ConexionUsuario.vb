Imports System.Data.SqlClient

Public Class ConexionUsuario
    Private oConexion As SqlConnection

    ''' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        oConexion = New SqlConnection(My.Settings.Conexion)
    End Sub

    ''' <summary>
    ''' Método para abrir la conexión a la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AbrirConexion()
        If oConexion.State = ConnectionState.Closed Then
            oConexion.Open()
        End If
    End Sub

    ''' <summary>
    ''' Método para cerrar la conexión a la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CerrarConexion()
        If oConexion.State = ConnectionState.Open Then
            oConexion.Close()
        End If
    End Sub


    Public Function cargarUsuario(ByVal id As String) As Usuario
        Dim usuario As New Usuario
        Dim comandoString As String
        Dim dataReader As SqlDataReader
        Dim comandoSQL As New SqlCommand()

        comandoString = "SELECT * FROM Usuario WHERE Codigo=@Codigo"
        comandoSQL.CommandText = comandoString
        comandoSQL.Connection = oConexion

        'Crear Parametros
        comandoSQL.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
        comandoSQL.Parameters("@Codigo").Value = id

        AbrirConexion()
        dataReader = comandoSQL.ExecuteReader()
        If dataReader.Read Then
            usuario.Codigo = dataReader("Codigo").ToString.Trim
            usuario.Nombre = dataReader("Nombre").ToString.Trim
            usuario.Contraseña = dataReader("Clave").ToString.Trim

        End If
        CerrarConexion()

        Return usuario
    End Function

End Class
