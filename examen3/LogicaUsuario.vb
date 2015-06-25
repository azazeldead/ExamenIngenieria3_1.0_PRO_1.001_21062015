Public Class LogicaUsuario
    Public acceso As New ConexionUsuario
    Public Function ConsultarUsuario(ByVal pk As Integer) As Usuario
        Return acceso.cargarUsuario(pk)
    End Function

End Class
