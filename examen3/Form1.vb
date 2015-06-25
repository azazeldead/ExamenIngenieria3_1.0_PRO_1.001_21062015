Public Class Form1

  
    Private oLogicaUsuario As New LogicaUsuario

    Private Sub cmd_ingresar_Click(sender As Object, e As EventArgs) Handles cmd_ingresar.Click
        Dim usuarioCopia As New Usuario
        Dim usuario As New Usuario
        Try

            usuarioCopia.Codigo = txt_codigo.Text

            usuario = oLogicaUsuario.ConsultarUsuario(usuarioCopia.Codigo)

            If (usuario.Contraseña = txt_Contrasena.Text = "1234") Then
                MenuMantenimiento.Show()
                Dim codigo As String = usuario.Codigo
                MenuMantenimiento.Lb_codigo.Text = codigo
                MenuMantenimiento.lb_nombre.Text = usuario.Nombre

                Limpiar()



            Else
                MessageBox.Show("Código de Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Limpiar()

            End If

        Catch ex As MeException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub Limpiar()
        txt_codigo.Clear()
        txt_Contrasena.Clear()

    End Sub

    
End Class
