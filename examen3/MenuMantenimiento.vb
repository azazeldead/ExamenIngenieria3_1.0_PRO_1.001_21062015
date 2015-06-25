Public Class MenuMantenimiento
    Private oProducto As New Producto
    Private oProductoLibro As New Producto
    Private listaProductos As New List(Of Producto)
    Private oLogicaProducto As New LogicaProducto
    


    Private Sub cmd_EliminarProducto_Click(sender As Object, e As EventArgs) Handles cmd_EliminarProducto.Click
        Dim oLogicaProducto As New LogicaProducto
        Try
            oLogicaProducto.EliminarProducto(Txt_CodigoProducto.Text)
            limpiar()
            CargarProductos()
            MessageBox.Show("Producto Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("No se puede Eliminar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub CargarProductos()

        listaProductos = oLogicaProducto.ListarProductos
        DtGrdV_Productos.DataSource = listaProductos


        DtGrdV_Productos.Columns(0).HeaderText = "Código"
        DtGrdV_Productos.Columns(1).HeaderText = "Nombre"
        DtGrdV_Productos.Columns(2).HeaderText = "Descripción"
        DtGrdV_Productos.Columns(3).HeaderText = "Precio"
        DtGrdV_Productos.Columns(4).HeaderText = "Cantidad"


        DtGrdV_Productos.AutoSizeColumnsMode = _
         DataGridViewAutoSizeColumnMode.AllCells


        With Me.DtGrdV_Productos
            .RowsDefaultCellStyle.BackColor = Color.Wheat
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DeepSkyBlue
        End With

    End Sub
    Public Sub CargarProductos(ByVal Lista As List(Of Producto))

        DtGrdV_Productos.DataSource = Lista

        DtGrdV_Productos.Columns(0).HeaderText = "Código"
        DtGrdV_Productos.Columns(1).HeaderText = "Nombre"
        DtGrdV_Productos.Columns(2).HeaderText = "Descripción"
        DtGrdV_Productos.Columns(3).HeaderText = "Precio"
        DtGrdV_Productos.Columns(4).HeaderText = "Cantidad"
        With Me.DtGrdV_Productos
            .RowsDefaultCellStyle.BackColor = Color.Wheat
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DeepSkyBlue
        End With

    End Sub
    Private Sub limpiar()

        Txt_CantidadProducto.Clear()
        Txt_DescripcionProducto.Clear()
        Txt_NombreProducto.Clear()
        Txt_PrecioProducto.Clear()
        Txt_CodigoProducto.Clear()
    End Sub

    Private Sub MenuMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CargarProductos()
        cmd_ModicarProducto.Enabled = False
        cmd_EliminarProducto.Enabled = False

        Me.DtGrdV_Productos.DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub
    Private Sub txt_BuscaProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BuscaProducto.TextChanged
        Dim listaCopia As New List(Of Producto)
        If txt_BuscaProducto.Text.Trim.Length <> 0 Then
            For Each producto As Producto In listaProductos

                If producto.nombre.ToString.ToUpper().Contains(txt_BuscaProducto.Text.ToUpper()) Then
                    listaCopia.Add(producto)
                End If
            Next
            DtGrdV_Productos.DataSource = listaCopia
        Else
            DtGrdV_Productos.DataSource = listaProductos
        End If
    End Sub
    Private Sub DtGrdV_Productos_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtGrdV_Productos.CellMouseClick

        cmd_ModicarProducto.Enabled = False
        cmd_EliminarProducto.Enabled = False
        cmd_AgregarProducto.Enabled = True
        Txt_CodigoProducto.Enabled = True
        limpiar()

    End Sub
    Private Sub DtGrdV_Productos_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtGrdV_Productos.CellMouseDoubleClick
        Try
            cmd_ModicarProducto.Enabled = True
            cmd_EliminarProducto.Enabled = True
            Txt_CodigoProducto.Enabled = False
            cmd_AgregarProducto.Enabled = False


            Dim renglon As Integer = Me.DtGrdV_Productos.CurrentCell.RowIndex
            Txt_CodigoProducto.Text = Me.DtGrdV_Productos.Item(0, renglon).Value
            Txt_NombreProducto.Text = Me.DtGrdV_Productos.Item(1, renglon).Value
            Txt_DescripcionProducto.Text = Me.DtGrdV_Productos.Item(2, renglon).Value
            Txt_PrecioProducto.Text = Me.DtGrdV_Productos.Item(3, renglon).Value
            Txt_CantidadProducto.Text = Me.DtGrdV_Productos.Item(4, renglon).Value


            

        Catch es As MeException
            MessageBox.Show(es.Message)

        Catch ex As Exception
            MessageBox.Show("No hay datos para seleccionar")

        End Try
    End Sub

    Private Sub cmd_AgregarProducto_Click(sender As Object, e As EventArgs) Handles cmd_AgregarProducto.Click
        Try


            oProducto.codigo = Txt_CodigoProducto.Text
            oProducto.nombre = Txt_NombreProducto.Text
            oProducto.Precio = Txt_PrecioProducto.Text
            oProducto.Cantidad = Txt_CantidadProducto.Text
            oProducto.Descripcion = Txt_DescripcionProducto.Text

            Dim oLogica As New LogicaProducto

            oLogica.InsertarProducto(oProducto)

            MessageBox.Show("Producto Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            CargarProductos()

        Catch ex As MeException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmd_ModicarProducto_Click(sender As Object, e As EventArgs) Handles cmd_ModicarProducto.Click
        Try

            oProducto.codigo = Txt_CodigoProducto.Text
            oProducto.nombre = Txt_NombreProducto.Text
            oProducto.Precio = Txt_PrecioProducto.Text
            oProducto.Cantidad = Txt_CantidadProducto.Text
            oProducto.Descripcion = Txt_DescripcionProducto.Text
            



            Dim oLogica As New LogicaProducto

            oLogica.ModificarProducto(oProducto)
            MessageBox.Show("Producto Modificado", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            limpiar()
            CargarProductos()
        Catch ex As MeException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub Txt_CantidadProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CantidadProducto.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub Txt_CodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CodigoProducto.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub Txt_PrecioProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_PrecioProducto.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub
    
End Class