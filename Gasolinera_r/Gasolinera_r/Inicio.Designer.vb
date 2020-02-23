<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.lContinuar = New System.Windows.Forms.Label()
        Me.pRegistro = New System.Windows.Forms.Panel()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.bEntrar = New System.Windows.Forms.Button()
        Me.lContraseña = New System.Windows.Forms.Label()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.pRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lContinuar
        '
        Me.lContinuar.AutoSize = True
        Me.lContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContinuar.Location = New System.Drawing.Point(534, 600)
        Me.lContinuar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lContinuar.Name = "lContinuar"
        Me.lContinuar.Size = New System.Drawing.Size(525, 36)
        Me.lContinuar.TabIndex = 0
        Me.lContinuar.Text = "Pulse cualquier tecla para continuar"
        '
        'pRegistro
        '
        Me.pRegistro.BackColor = System.Drawing.Color.Transparent
        Me.pRegistro.Controls.Add(Me.tbUsuario)
        Me.pRegistro.Controls.Add(Me.tbPassword)
        Me.pRegistro.Controls.Add(Me.bEntrar)
        Me.pRegistro.Controls.Add(Me.lContraseña)
        Me.pRegistro.Controls.Add(Me.lUsuario)
        Me.pRegistro.Location = New System.Drawing.Point(505, 161)
        Me.pRegistro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pRegistro.Name = "pRegistro"
        Me.pRegistro.Size = New System.Drawing.Size(489, 236)
        Me.pRegistro.TabIndex = 1
        Me.pRegistro.Visible = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(197, 33)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbUsuario.MaxLength = 12
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(189, 32)
        Me.tbUsuario.TabIndex = 4
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(197, 95)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbPassword.MaxLength = 12
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(189, 32)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'bEntrar
        '
        Me.bEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEntrar.Location = New System.Drawing.Point(181, 161)
        Me.bEntrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bEntrar.Name = "bEntrar"
        Me.bEntrar.Size = New System.Drawing.Size(137, 54)
        Me.bEntrar.TabIndex = 2
        Me.bEntrar.Text = "ENTRAR"
        Me.bEntrar.UseVisualStyleBackColor = True
        '
        'lContraseña
        '
        Me.lContraseña.AutoSize = True
        Me.lContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContraseña.Location = New System.Drawing.Point(71, 98)
        Me.lContraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lContraseña.Name = "lContraseña"
        Me.lContraseña.Size = New System.Drawing.Size(130, 26)
        Me.lContraseña.TabIndex = 1
        Me.lContraseña.Text = "Contraseña:"
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuario.Location = New System.Drawing.Point(71, 36)
        Me.lUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(93, 26)
        Me.lUsuario.TabIndex = 0
        Me.lUsuario.Text = "Usuario:"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.Gasolinera_r.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1524, 781)
        Me.Controls.Add(Me.pRegistro)
        Me.Controls.Add(Me.lContinuar)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Inicio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIO"
        Me.pRegistro.ResumeLayout(False)
        Me.pRegistro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lContinuar As Label
    Friend WithEvents pRegistro As Panel
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents bEntrar As Button
    Friend WithEvents lContraseña As Label
    Friend WithEvents lUsuario As Label
End Class
