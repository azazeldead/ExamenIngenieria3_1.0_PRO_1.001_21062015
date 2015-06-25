Imports System.Data.SqlClient

Public Class ConexionProducto


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
    Public Sub insertarProducto(ByVal producto As Producto)
        Try
            Dim comandoSQL As New SqlCommand()
            Dim comandoString As String
            comandoString = "Insert into Productos(Codigo, Nombre, Precio, CantidadDisponible, Descripcion) VALUES (@Codigo, @Nombre, @Precio, @CantidadDisponible, @Descripcion)"
            comandoSQL.CommandText = comandoString
            comandoSQL.Connection = oConexion

            comandoSQL.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
            comandoSQL.Parameters("@Codigo").Value = producto.codigo
            comandoSQL.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar))
            comandoSQL.Parameters("@Nombre").Value = producto.nombre
            comandoSQL.Parameters.Add(New SqlParameter("@Precio", SqlDbType.Real))
            comandoSQL.Parameters("@Precio").Value = producto.Precio
            comandoSQL.Parameters.Add(New SqlParameter("@CantidadDisponible", SqlDbType.SmallInt))
            comandoSQL.Parameters("@CantidadDisponible").Value = producto.Cantidad
            comandoSQL.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar))
            comandoSQL.Parameters("@Descripcion").Value = producto.Descripcion


            Dim filasAfectas As Integer

            AbrirConexion()
            filasAfectas = comandoSQL.ExecuteNonQuery()
            CerrarConexion()


        Catch ex As SqlException
            Throw New MeException("El codigo ya ha sido asignado a otro producto")
        End Try
    End Sub


    Public Sub modificarProducto(ByVal producto As Producto)

        Dim comandoSQL As New SqlCommand()
        Dim comandoString As String
        comandoString = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, CantidadDisponible = @CantidadDisponible, Descripcion = @Descripcion WHERE Codigo = @Codigo"
        comandoSQL.CommandText = comandoString
        comandoSQL.Connection = oConexion

        comandoSQL.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
        comandoSQL.Parameters("@Codigo").Value = producto.codigo
        comandoSQL.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar))
        comandoSQL.Parameters("@Nombre").Value = producto.nombre
        comandoSQL.Parameters.Add(New SqlParameter("@Precio", SqlDbType.Real))
        comandoSQL.Parameters("@Precio").Value = producto.Precio
        comandoSQL.Parameters.Add(New SqlParameter("@CantidadDisponible", SqlDbType.SmallInt))
        comandoSQL.Parameters("@CantidadDisponible").Value = producto.Cantidad
        comandoSQL.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar))
        comandoSQL.Parameters("@Descripcion").Value = producto.Descripcion


        AbrirConexion()
        comandoSQL.ExecuteNonQuery()
        CerrarConexion()





    End Sub

    

    Public Sub eliminarProducto(ByVal codigo As String)
        Try

            Dim comandoSQL As New SqlCommand()
            Dim comandoString As String
            comandoString = "Delete FROM Productos WHERE Codigo=@Codigo"
            comandoSQL.CommandText = comandoString
            comandoSQL.Connection = oConexion

            comandoSQL.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
            comandoSQL.Parameters("@Codigo").Value = codigo

            AbrirConexion()
            comandoSQL.ExecuteNonQuery()
            CerrarConexion()
        Catch ex As SqlException
            Throw New MeException("El producto no se puede eliminar porque está asociado")
        End Try
    End Sub

    Public Function cargarTodosProductos() As List(Of Producto)
        Dim listaProducto As New List(Of Producto)
        Dim oDataTable As New DataTable
        Dim objDataAdapter As New SqlDataAdapter("SELECT * FROM Productos", oConexion)

        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Productos")

        oDataTable = objDataSet.Tables("Productos")
        Dim fila As DataRow
        For Each fila In oDataTable.Rows
            Dim producto As New Producto

            producto.codigo = fila.Item("Codigo").ToString.Trim
            producto.nombre = fila.Item("Nombre").ToString.Trim
            producto.Precio = fila.Item("Precio").ToString.Trim
            producto.Cantidad = fila.Item("CantidadDisponible").ToString.Trim
            producto.Descripcion = fila.Item("Descripcion").ToString.Trim
            listaProducto.Add(producto)
        Next
        Return listaProducto
    End Function



    Public Function cargarProducto(ByVal codigo As String) As Producto
        Dim producto As New Producto
        Dim comandoString As String
        Dim dataReader As SqlDataReader
        Dim comandoSQL As New SqlCommand()

        comandoString = "SELECT * FROM Productos WHERE Codigo=@Codigo"
        comandoSQL.CommandText = comandoString
        comandoSQL.Connection = oConexion

        'Crear Parametros
        comandoSQL.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
        comandoSQL.Parameters("@Codigo").Value = codigo

        AbrirConexion()
        dataReader = comandoSQL.ExecuteReader()
        If dataReader.Read Then
            producto.codigo = dataReader("Codigo").ToString.Trim
            producto.nombre = dataReader("Nombre").ToString.Trim
            producto.Precio = dataReader("Precio").ToString.Trim
            producto.Cantidad = dataReader("CantidadDisponible").ToString.Trim
            producto.Descripcion = dataReader("Descripcion").ToString.Trim


        End If

        CerrarConexion()

        Return producto
    End Function







End Class
