<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_Contrasena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.cmd_ingresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Times New Roman", 26.0!)
        Me.lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_titulo.Location = New System.Drawing.Point(167, 218)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(269, 40)
        Me.lbl_titulo.TabIndex = 6
        Me.lbl_titulo.Text = "Ingreso al sistema"
        '
        'txt_Contrasena
        '
        Me.txt_Contrasena.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.txt_Contrasena.Location = New System.Drawing.Point(256, 324)
        Me.txt_Contrasena.Name = "txt_Contrasena"
        Me.txt_Contrasena.Size = New System.Drawing.Size(215, 29)
        Me.txt_Contrasena.TabIndex = 8
        Me.txt_Contrasena.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(152, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(117, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código Usuario:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.txt_codigo.Location = New System.Drawing.Point(256, 286)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(215, 29)
        Me.txt_codigo.TabIndex = 7
        '
        'cmd_ingresar
        '
        Me.cmd_ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmd_ingresar.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.cmd_ingresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_ingresar.Location = New System.Drawing.Point(246, 377)
        Me.cmd_ingresar.Name = "cmd_ingresar"
        Me.cmd_ingresar.Size = New System.Drawing.Size(102, 30)
        Me.cmd_ingresar.TabIndex = 11
        Me.cmd_ingresar.Text = "Ingresar"
        Me.cmd_ingresar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.cmd_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.txt_Contrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.cmd_ingresar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_Contrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents cmd_ingresar As System.Windows.Forms.Button

End Class
