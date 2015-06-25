<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMantenimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lb_codigo = New System.Windows.Forms.Label()
        Me.lb_nombre = New System.Windows.Forms.Label()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.GrpB_DatosProducto = New System.Windows.Forms.GroupBox()
        Me.Txt_DescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Lbl_DescripcionProducto = New System.Windows.Forms.Label()
        Me.Txt_PrecioProducto = New System.Windows.Forms.TextBox()
        Me.Lbl_CantidadProducto = New System.Windows.Forms.Label()
        Me.Txt_CodigoProducto = New System.Windows.Forms.TextBox()
        Me.Lbl_CodigoProducto = New System.Windows.Forms.Label()
        Me.Txt_CantidadProducto = New System.Windows.Forms.TextBox()
        Me.Lbl_PrecioProducto = New System.Windows.Forms.Label()
        Me.Txt_NombreProducto = New System.Windows.Forms.TextBox()
        Me.Lbl_NombreProducto = New System.Windows.Forms.Label()
        Me.DtGrdV_Productos = New System.Windows.Forms.DataGridView()
        Me.txt_BuscaProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_EliminarProducto = New System.Windows.Forms.Button()
        Me.cmd_ModicarProducto = New System.Windows.Forms.Button()
        Me.cmd_AgregarProducto = New System.Windows.Forms.Button()
        Me.GrpB_TablaProductos = New System.Windows.Forms.GroupBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GrpB_DatosProducto.SuspendLayout()
        CType(Me.DtGrdV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpB_TablaProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_codigo
        '
        Me.Lb_codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_codigo.AutoSize = True
        Me.Lb_codigo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_codigo.Location = New System.Drawing.Point(828, 28)
        Me.Lb_codigo.Name = "Lb_codigo"
        Me.Lb_codigo.Size = New System.Drawing.Size(54, 19)
        Me.Lb_codigo.TabIndex = 12
        Me.Lb_codigo.Text = "Codigo"
        '
        'lb_nombre
        '
        Me.lb_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_nombre.AutoSize = True
        Me.lb_nombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre.Location = New System.Drawing.Point(933, 28)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(60, 19)
        Me.lb_nombre.TabIndex = 11
        Me.lb_nombre.Text = "Nombre"
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(855, 9)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(141, 19)
        Me.lbl_bienvenido.TabIndex = 10
        Me.lbl_bienvenido.Text = "Bienvenido al sistema:"
        '
        'GrpB_DatosProducto
        '
        Me.GrpB_DatosProducto.Controls.Add(Me.Txt_DescripcionProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Lbl_DescripcionProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Txt_PrecioProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Lbl_CantidadProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Txt_CodigoProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Lbl_CodigoProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Txt_CantidadProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Lbl_PrecioProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Txt_NombreProducto)
        Me.GrpB_DatosProducto.Controls.Add(Me.Lbl_NombreProducto)
        Me.GrpB_DatosProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpB_DatosProducto.Location = New System.Drawing.Point(0, 50)
        Me.GrpB_DatosProducto.Name = "GrpB_DatosProducto"
        Me.GrpB_DatosProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpB_DatosProducto.Size = New System.Drawing.Size(335, 425)
        Me.GrpB_DatosProducto.TabIndex = 32
        Me.GrpB_DatosProducto.TabStop = False
        Me.GrpB_DatosProducto.Text = "PRODUCTO"
        '
        'Txt_DescripcionProducto
        '
        Me.Txt_DescripcionProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DescripcionProducto.Location = New System.Drawing.Point(151, 190)
        Me.Txt_DescripcionProducto.MaxLength = 49
        Me.Txt_DescripcionProducto.Multiline = True
        Me.Txt_DescripcionProducto.Name = "Txt_DescripcionProducto"
        Me.Txt_DescripcionProducto.Size = New System.Drawing.Size(185, 67)
        Me.Txt_DescripcionProducto.TabIndex = 7
        '
        'Lbl_DescripcionProducto
        '
        Me.Lbl_DescripcionProducto.AutoSize = True
        Me.Lbl_DescripcionProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DescripcionProducto.Location = New System.Drawing.Point(0, 207)
        Me.Lbl_DescripcionProducto.Name = "Lbl_DescripcionProducto"
        Me.Lbl_DescripcionProducto.Size = New System.Drawing.Size(144, 19)
        Me.Lbl_DescripcionProducto.TabIndex = 11
        Me.Lbl_DescripcionProducto.Text = "Descripción Producto:"
        Me.Lbl_DescripcionProducto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_PrecioProducto
        '
        Me.Txt_PrecioProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PrecioProducto.Location = New System.Drawing.Point(151, 110)
        Me.Txt_PrecioProducto.MaxLength = 15
        Me.Txt_PrecioProducto.Name = "Txt_PrecioProducto"
        Me.Txt_PrecioProducto.Size = New System.Drawing.Size(184, 26)
        Me.Txt_PrecioProducto.TabIndex = 4
        Me.Txt_PrecioProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_CantidadProducto
        '
        Me.Lbl_CantidadProducto.AutoSize = True
        Me.Lbl_CantidadProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CantidadProducto.Location = New System.Drawing.Point(9, 145)
        Me.Lbl_CantidadProducto.Name = "Lbl_CantidadProducto"
        Me.Lbl_CantidadProducto.Size = New System.Drawing.Size(135, 19)
        Me.Lbl_CantidadProducto.TabIndex = 9
        Me.Lbl_CantidadProducto.Text = "Cantidad Disponible:"
        Me.Lbl_CantidadProducto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_CodigoProducto
        '
        Me.Txt_CodigoProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CodigoProducto.Location = New System.Drawing.Point(150, 44)
        Me.Txt_CodigoProducto.MaxLength = 30
        Me.Txt_CodigoProducto.Name = "Txt_CodigoProducto"
        Me.Txt_CodigoProducto.Size = New System.Drawing.Size(185, 26)
        Me.Txt_CodigoProducto.TabIndex = 2
        Me.Txt_CodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_CodigoProducto
        '
        Me.Lbl_CodigoProducto.AutoSize = True
        Me.Lbl_CodigoProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CodigoProducto.Location = New System.Drawing.Point(27, 47)
        Me.Lbl_CodigoProducto.Name = "Lbl_CodigoProducto"
        Me.Lbl_CodigoProducto.Size = New System.Drawing.Size(117, 19)
        Me.Lbl_CodigoProducto.TabIndex = 4
        Me.Lbl_CodigoProducto.Text = "Código Producto:"
        Me.Lbl_CodigoProducto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_CantidadProducto
        '
        Me.Txt_CantidadProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CantidadProducto.Location = New System.Drawing.Point(151, 142)
        Me.Txt_CantidadProducto.MaxLength = 10
        Me.Txt_CantidadProducto.Name = "Txt_CantidadProducto"
        Me.Txt_CantidadProducto.Size = New System.Drawing.Size(184, 26)
        Me.Txt_CantidadProducto.TabIndex = 5
        Me.Txt_CantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_PrecioProducto
        '
        Me.Lbl_PrecioProducto.AutoSize = True
        Me.Lbl_PrecioProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PrecioProducto.Location = New System.Drawing.Point(33, 113)
        Me.Lbl_PrecioProducto.Name = "Lbl_PrecioProducto"
        Me.Lbl_PrecioProducto.Size = New System.Drawing.Size(111, 19)
        Me.Lbl_PrecioProducto.TabIndex = 2
        Me.Lbl_PrecioProducto.Text = "Precio Producto:"
        Me.Lbl_PrecioProducto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_NombreProducto
        '
        Me.Txt_NombreProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreProducto.Location = New System.Drawing.Point(151, 78)
        Me.Txt_NombreProducto.MaxLength = 50
        Me.Txt_NombreProducto.Name = "Txt_NombreProducto"
        Me.Txt_NombreProducto.Size = New System.Drawing.Size(184, 26)
        Me.Txt_NombreProducto.TabIndex = 3
        Me.Txt_NombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_NombreProducto
        '
        Me.Lbl_NombreProducto.AutoSize = True
        Me.Lbl_NombreProducto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NombreProducto.Location = New System.Drawing.Point(21, 81)
        Me.Lbl_NombreProducto.Name = "Lbl_NombreProducto"
        Me.Lbl_NombreProducto.Size = New System.Drawing.Size(123, 19)
        Me.Lbl_NombreProducto.TabIndex = 0
        Me.Lbl_NombreProducto.Text = "Nombre Producto:"
        Me.Lbl_NombreProducto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DtGrdV_Productos
        '
        Me.DtGrdV_Productos.AllowUserToAddRows = False
        Me.DtGrdV_Productos.AllowUserToDeleteRows = False
        Me.DtGrdV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrdV_Productos.Location = New System.Drawing.Point(73, 25)
        Me.DtGrdV_Productos.Name = "DtGrdV_Productos"
        Me.DtGrdV_Productos.ReadOnly = True
        Me.DtGrdV_Productos.Size = New System.Drawing.Size(502, 362)
        Me.DtGrdV_Productos.TabIndex = 0
        '
        'txt_BuscaProducto
        '
        Me.txt_BuscaProducto.Location = New System.Drawing.Point(511, 20)
        Me.txt_BuscaProducto.Name = "txt_BuscaProducto"
        Me.txt_BuscaProducto.Size = New System.Drawing.Size(214, 20)
        Me.txt_BuscaProducto.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(376, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Buscar por nombre:"
        '
        'cmd_EliminarProducto
        '
        Me.cmd_EliminarProducto.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.cmd_EliminarProducto.Location = New System.Drawing.Point(730, 460)
        Me.cmd_EliminarProducto.Name = "cmd_EliminarProducto"
        Me.cmd_EliminarProducto.Size = New System.Drawing.Size(70, 35)
        Me.cmd_EliminarProducto.TabIndex = 29
        Me.cmd_EliminarProducto.Text = "Eliminar"
        Me.cmd_EliminarProducto.UseVisualStyleBackColor = True
        '
        'cmd_ModicarProducto
        '
        Me.cmd_ModicarProducto.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.cmd_ModicarProducto.Location = New System.Drawing.Point(832, 460)
        Me.cmd_ModicarProducto.Name = "cmd_ModicarProducto"
        Me.cmd_ModicarProducto.Size = New System.Drawing.Size(78, 35)
        Me.cmd_ModicarProducto.TabIndex = 30
        Me.cmd_ModicarProducto.Text = "Modificar"
        Me.cmd_ModicarProducto.UseVisualStyleBackColor = True
        '
        'cmd_AgregarProducto
        '
        Me.cmd_AgregarProducto.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.cmd_AgregarProducto.Location = New System.Drawing.Point(934, 460)
        Me.cmd_AgregarProducto.Name = "cmd_AgregarProducto"
        Me.cmd_AgregarProducto.Size = New System.Drawing.Size(70, 35)
        Me.cmd_AgregarProducto.TabIndex = 28
        Me.cmd_AgregarProducto.Text = "Agregar"
        Me.cmd_AgregarProducto.UseVisualStyleBackColor = True
        '
        'GrpB_TablaProductos
        '
        Me.GrpB_TablaProductos.Controls.Add(Me.DtGrdV_Productos)
        Me.GrpB_TablaProductos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpB_TablaProductos.Location = New System.Drawing.Point(367, 50)
        Me.GrpB_TablaProductos.Name = "GrpB_TablaProductos"
        Me.GrpB_TablaProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpB_TablaProductos.Size = New System.Drawing.Size(637, 394)
        Me.GrpB_TablaProductos.TabIndex = 31
        Me.GrpB_TablaProductos.TabStop = False
        Me.GrpB_TablaProductos.Text = "TABLA INFORMATIVA"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(749, 32)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(85, 13)
        Me.LblCodigo.TabIndex = 35
        Me.LblCodigo.Text = "Codigo Usuario: "
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(888, 32)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(50, 13)
        Me.LblNombre.TabIndex = 36
        Me.LblNombre.Text = "Nombre: "
        '
        'MenuMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 501)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.GrpB_DatosProducto)
        Me.Controls.Add(Me.txt_BuscaProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_EliminarProducto)
        Me.Controls.Add(Me.cmd_ModicarProducto)
        Me.Controls.Add(Me.cmd_AgregarProducto)
        Me.Controls.Add(Me.GrpB_TablaProductos)
        Me.Controls.Add(Me.Lb_codigo)
        Me.Controls.Add(Me.lb_nombre)
        Me.Controls.Add(Me.lbl_bienvenido)
        Me.Name = "MenuMantenimiento"
        Me.Text = "MenuMantenimiento"
        Me.GrpB_DatosProducto.ResumeLayout(False)
        Me.GrpB_DatosProducto.PerformLayout()
        CType(Me.DtGrdV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpB_TablaProductos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_bienvenido As System.Windows.Forms.Label
    Friend WithEvents GrpB_DatosProducto As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_DescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_DescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents Txt_PrecioProducto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_CantidadProducto As System.Windows.Forms.Label
    Friend WithEvents Txt_CodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_CodigoProducto As System.Windows.Forms.Label
    Friend WithEvents Txt_CantidadProducto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_PrecioProducto As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_NombreProducto As System.Windows.Forms.Label
    Friend WithEvents DtGrdV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_BuscaProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_EliminarProducto As System.Windows.Forms.Button
    Friend WithEvents cmd_ModicarProducto As System.Windows.Forms.Button
    Friend WithEvents cmd_AgregarProducto As System.Windows.Forms.Button
    Friend WithEvents GrpB_TablaProductos As System.Windows.Forms.GroupBox
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
End Class
