
Public Class Usuario

    Private varCodigo As String
    Public Property Codigo() As String
        Get
            Return varCodigo
        End Get
        Set(ByVal value As String)
            If value.ToString = String.Empty Then
                Throw New MeException("Debe ingresar el código de usuario")
            End If

            If IsNumeric(value) = False Then
                Throw New MeException("El código debe ser númerico")
            End If

            varCodigo = value
        End Set
    End Property


    Private varNombre As String
    Public Property Nombre() As String
        Get
            Return varNombre
        End Get
        Set(ByVal value As String)
            If Not value.Trim = String.Empty Then

                If value.Trim.Length >= 2 Then

                    For Each letra As Char In value
                        If Char.IsNumber(letra) Then
                            Throw New MeException("El Nombre no puede tener números ni símbolos")
                        End If

                    Next
                    varNombre = value

                Else
                    Throw New MeException("El nombre debe tener al menos dos letras")
                End If
            Else
                Throw New MeException("El nombre no puede estar vacío")
            End If
        End Set
    End Property



    Private varContrasena As String
    Public Property Contraseña() As String
        Get
            Return varContrasena
        End Get
        Set(ByVal value As String)
            If Not value.Trim = String.Empty Then

                If value.Trim.Length < 4 Then

                    Throw New MeException("La contraseña debe tener al menos cuatro letras")
                End If
            Else
                Throw New MeException("La contraseña no puede estar vacía")
            End If

            varContrasena = value
        End Set
    End Property



End Class
