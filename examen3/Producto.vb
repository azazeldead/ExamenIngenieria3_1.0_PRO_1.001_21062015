Public Class Producto

    Private codigoProducto As String
    Public Property codigo() As String
        Get
            Return codigoProducto
        End Get
        Set(ByVal value As String)
            If value.ToString = String.Empty Then
                Throw New MeException("Debe ingresar el código")
            End If

            If IsNumeric(value) = False Then
                Throw New MeException("El código debe ser númerico")
            End If

            codigoProducto = value
        End Set
    End Property


    Private nombreProducto As String
    Public Property nombre() As String
        Get
            Return nombreProducto
        End Get
        Set(ByVal value As String)

            If Not value.Trim = String.Empty Then

                If value.Trim.Length < 2 Then

                    Throw New MeException("El nombre debe tener al menos dos letras")
                End If
            Else
                Throw New MeException("El nombre no puede estar vacío")
            End If
            nombreProducto = value
        End Set
    End Property


    Private varDescripcion As String
    Public Property Descripcion() As String
        Get
            Return varDescripcion
        End Get
        Set(ByVal value As String)
            If Not value.Trim = String.Empty Then

                If value.Trim.Length < 2 Then

                    Throw New MeException("La descripción debe tener al menos dos letras")
                End If
            Else
                Throw New MeException("La descripción no puede estar vacía")
            End If

            varDescripcion = value
        End Set
    End Property



    Private varPrecio As String
    Public Property Precio() As String
        Get
            Return varPrecio
        End Get
        Set(ByVal value As String)
            If value.ToString = String.Empty Then
                Throw New MeException("Debe ingresar el precio")
            End If

            If IsNumeric(value) = False Then
                Throw New MeException("El precio debe ser númerico")
            End If
            If value <= 0 Then
                Throw New MeException("El precio debe ser mayor a 0")
            End If

            varPrecio = value
        End Set
    End Property


    Private varCantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return varCantidad
        End Get
        Set(ByVal value As Integer)
            If value.ToString = String.Empty Then
                Throw New MeException("Debe ingresar la cantidad de producto")
            End If

            If IsNumeric(value) = False Then
                Throw New MeException("La cantidad debe ser númerico")
            End If

            If value < 0 Then
                Throw New MeException("La cantidad debe ser mayor a 0")
            End If

            varCantidad = value
        End Set
    End Property



End Class
