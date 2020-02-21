<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lHora = New System.Windows.Forms.Label()
        Me.lApellido = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.bProveedor = New System.Windows.Forms.Button()
        Me.bArticulo = New System.Windows.Forms.Button()
        Me.bCliente = New System.Windows.Forms.Button()
        Me.bUsuario = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Controls.Add(Me.bProveedor)
        Me.Panel1.Controls.Add(Me.bUsuario)
        Me.Panel1.Controls.Add(Me.bCliente)
        Me.Panel1.Controls.Add(Me.bArticulo)
        Me.Panel1.Controls.Add(Me.lHora)
        Me.Panel1.Controls.Add(Me.lApellido)
        Me.Panel1.Controls.Add(Me.lNombre)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2115, 234)
        Me.Panel1.TabIndex = 0
        '
        'lHora
        '
        Me.lHora.AutoSize = True
        Me.lHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHora.Location = New System.Drawing.Point(573, 145)
        Me.lHora.Name = "lHora"
        Me.lHora.Size = New System.Drawing.Size(86, 29)
        Me.lHora.TabIndex = 4
        Me.lHora.Text = "Label1"
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido.Location = New System.Drawing.Point(797, 64)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(128, 29)
        Me.lApellido.TabIndex = 3
        Me.lApellido.Text = "APELLIDO"
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.Location = New System.Drawing.Point(573, 64)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(119, 29)
        Me.lNombre.TabIndex = 2
        Me.lNombre.Text = "NOMBRE"
        '
        'timer
        '
        '
        'bProveedor
        '
        Me.bProveedor.Location = New System.Drawing.Point(1470, 63)
        Me.bProveedor.Name = "bProveedor"
        Me.bProveedor.Size = New System.Drawing.Size(95, 111)
        Me.bProveedor.TabIndex = 1
        Me.bProveedor.Text = "PROVEEDORES"
        Me.bProveedor.UseVisualStyleBackColor = True
        '
        'bArticulo
        '
        Me.bArticulo.Location = New System.Drawing.Point(1571, 63)
        Me.bArticulo.Name = "bArticulo"
        Me.bArticulo.Size = New System.Drawing.Size(95, 111)
        Me.bArticulo.TabIndex = 5
        Me.bArticulo.Text = "ARTICULOS"
        Me.bArticulo.UseVisualStyleBackColor = True
        '
        'bCliente
        '
        Me.bCliente.Location = New System.Drawing.Point(1672, 63)
        Me.bCliente.Name = "bCliente"
        Me.bCliente.Size = New System.Drawing.Size(95, 111)
        Me.bCliente.TabIndex = 6
        Me.bCliente.Text = "CLIENTES"
        Me.bCliente.UseVisualStyleBackColor = True
        '
        'bUsuario
        '
        Me.bUsuario.Location = New System.Drawing.Point(1773, 63)
        Me.bUsuario.Name = "bUsuario"
        Me.bUsuario.Size = New System.Drawing.Size(95, 111)
        Me.bUsuario.TabIndex = 7
        Me.bUsuario.Text = "USUARIOS"
        Me.bUsuario.UseVisualStyleBackColor = True
        '
        'bCerrar
        '
        Me.bCerrar.Location = New System.Drawing.Point(1912, 3)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(200, 231)
        Me.bCerrar.TabIndex = 8
        Me.bCerrar.Text = "CERRAR CAJA"
        Me.bCerrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Gasolinera_r.My.Resources.Resources.logo
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(11, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(459, 226)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(1519, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(597, 778)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Controls.Add(Me.Button18)
        Me.Panel4.Controls.Add(Me.Button17)
        Me.Panel4.Controls.Add(Me.Button16)
        Me.Panel4.Controls.Add(Me.Button15)
        Me.Panel4.Controls.Add(Me.Button14)
        Me.Panel4.Controls.Add(Me.Button13)
        Me.Panel4.Controls.Add(Me.Button12)
        Me.Panel4.Controls.Add(Me.Button11)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Location = New System.Drawing.Point(2, 306)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(617, 454)
        Me.Panel4.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 107)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "7"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 107)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "8"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(239, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 107)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "9"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(357, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 107)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "CANTIDAD"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 107)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(121, 116)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 107)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(239, 116)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 107)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(357, 116)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 107)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "ELMINAR"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(475, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(112, 107)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(475, 116)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(112, 107)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(3, 229)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(112, 107)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(121, 229)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(112, 107)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(239, 229)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(112, 107)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(3, 342)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(112, 107)
        Me.Button14.TabIndex = 12
        Me.Button14.Text = "Button14"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(121, 340)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(112, 107)
        Me.Button15.TabIndex = 13
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(239, 340)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(112, 107)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "Button16"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(357, 229)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(112, 218)
        Me.Button17.TabIndex = 15
        Me.Button17.Text = "Button17"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(475, 229)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(112, 218)
        Me.Button18.TabIndex = 16
        Me.Button18.Text = "Button18"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2112, 998)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.Text = "PRINCIPAL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lApellido As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents timer As Timer
    Friend WithEvents lHora As Label
    Friend WithEvents bCerrar As Button
    Friend WithEvents bProveedor As Button
    Friend WithEvents bUsuario As Button
    Friend WithEvents bCliente As Button
    Friend WithEvents bArticulo As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
