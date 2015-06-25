Public Class LogicaProducto
    Private acceso As New ConexionProducto
    Public Sub InsertarProducto(ByVal nuevoProducto As Producto)
        Try
            acceso.insertarProducto(nuevoProducto)
        Catch ex As MeException
            Throw New MeException("El codigo de producto ya existe")
        End Try
    End Sub


    Public Sub ModificarProducto(ByVal producto As Producto)
        acceso.modificarProducto(producto)
    End Sub


    Public Sub EliminarProducto(ByVal codigo As String)
        Try
            acceso.eliminarProducto(codigo)
        Catch ex As MeException
            Throw New MeException("El producto no se puede eliminar ya que esta asociado")
        End Try
    End Sub


    Public Function ConsultarProducto(ByVal pk As String) As Producto
        Return acceso.cargarProducto(pk)
    End Function

   

    Public Function ListarProductos() As List(Of Producto)
        Return acceso.cargarTodosProductos
    End Function

End Class
