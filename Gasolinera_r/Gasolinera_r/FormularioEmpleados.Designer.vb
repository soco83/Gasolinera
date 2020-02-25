<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.lId = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.lDni = New System.Windows.Forms.Label()
        Me.tbConfirmContrasenna = New System.Windows.Forms.TextBox()
        Me.tbApellido1 = New System.Windows.Forms.TextBox()
        Me.lApellido1 = New System.Windows.Forms.Label()
        Me.tbApellido2 = New System.Windows.Forms.TextBox()
        Me.lApellido2 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.lDireccion = New System.Windows.Forms.Label()
        Me.lRol = New System.Windows.Forms.Label()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bInforme = New System.Windows.Forms.Button()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.lTipo = New System.Windows.Forms.Label()
        Me.tbNombreCalle = New System.Windows.Forms.TextBox()
        Me.lNombreCalle = New System.Windows.Forms.Label()
        Me.tbCp = New System.Windows.Forms.TextBox()
        Me.lCp = New System.Windows.Forms.Label()
        Me.lNumero = New System.Windows.Forms.Label()
        Me.tbNumero = New System.Windows.Forms.TextBox()
        Me.tbPiso = New System.Windows.Forms.TextBox()
        Me.lPiso = New System.Windows.Forms.Label()
        Me.tbLetra = New System.Windows.Forms.TextBox()
        Me.lLetra = New System.Windows.Forms.Label()
        Me.tbCiudad = New System.Windows.Forms.TextBox()
        Me.lCiudad = New System.Windows.Forms.Label()
        Me.tbProvincia = New System.Windows.Forms.TextBox()
        Me.lProvincia = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bConfirmar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbContrasenna = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.epNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epContrasenna = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epConfirmContrasenna = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epApellido1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epApellido2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epNombreCallle = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epNumero = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epPiso = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epCp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epLetra = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epCiuidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epProvincia = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epContrasenna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epConfirmContrasenna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epApellido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epApellido2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epNombreCallle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epPiso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epCp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epCiuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.ForeColor = System.Drawing.SystemColors.Control
        Me.lTitulo.Location = New System.Drawing.Point(23, 243)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(242, 29)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "Gestión Empleados"
        '
        'lId
        '
        Me.lId.AutoSize = True
        Me.lId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lId.ForeColor = System.Drawing.SystemColors.Control
        Me.lId.Location = New System.Drawing.Point(108, 302)
        Me.lId.Name = "lId"
        Me.lId.Size = New System.Drawing.Size(30, 20)
        Me.lId.TabIndex = 1
        Me.lId.Text = "ID:"
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(156, 302)
        Me.tbId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(56, 26)
        Me.tbId.TabIndex = 2
        '
        'tbDni
        '
        Me.tbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDni.Location = New System.Drawing.Point(156, 345)
        Me.tbDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbDni.Name = "tbDni"
        Me.tbDni.Size = New System.Drawing.Size(168, 26)
        Me.tbDni.TabIndex = 1
        '
        'lDni
        '
        Me.lDni.AutoSize = True
        Me.lDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDni.ForeColor = System.Drawing.SystemColors.Control
        Me.lDni.Location = New System.Drawing.Point(97, 348)
        Me.lDni.Name = "lDni"
        Me.lDni.Size = New System.Drawing.Size(41, 20)
        Me.lDni.TabIndex = 3
        Me.lDni.Text = "DNI:"
        '
        'tbConfirmContrasenna
        '
        Me.tbConfirmContrasenna.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmContrasenna.Location = New System.Drawing.Point(249, 529)
        Me.tbConfirmContrasenna.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbConfirmContrasenna.Name = "tbConfirmContrasenna"
        Me.tbConfirmContrasenna.Size = New System.Drawing.Size(168, 26)
        Me.tbConfirmContrasenna.TabIndex = 4
        '
        'tbApellido1
        '
        Me.tbApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido1.Location = New System.Drawing.Point(156, 605)
        Me.tbApellido1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(168, 26)
        Me.tbApellido1.TabIndex = 5
        '
        'lApellido1
        '
        Me.lApellido1.AutoSize = True
        Me.lApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido1.ForeColor = System.Drawing.SystemColors.Control
        Me.lApellido1.Location = New System.Drawing.Point(19, 611)
        Me.lApellido1.Name = "lApellido1"
        Me.lApellido1.Size = New System.Drawing.Size(105, 20)
        Me.lApellido1.TabIndex = 7
        Me.lApellido1.Text = "APELLIDO 1:"
        '
        'tbApellido2
        '
        Me.tbApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido2.Location = New System.Drawing.Point(156, 654)
        Me.tbApellido2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(168, 26)
        Me.tbApellido2.TabIndex = 6
        '
        'lApellido2
        '
        Me.lApellido2.AutoSize = True
        Me.lApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido2.ForeColor = System.Drawing.SystemColors.Control
        Me.lApellido2.Location = New System.Drawing.Point(19, 654)
        Me.lApellido2.Name = "lApellido2"
        Me.lApellido2.Size = New System.Drawing.Size(105, 20)
        Me.lApellido2.TabIndex = 9
        Me.lApellido2.Text = "APELLIDO 2:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(156, 703)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(168, 26)
        Me.tbTelefono.TabIndex = 7
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTelefono.ForeColor = System.Drawing.SystemColors.Control
        Me.lTelefono.Location = New System.Drawing.Point(25, 703)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(98, 20)
        Me.lTelefono.TabIndex = 11
        Me.lTelefono.Text = "TELÉFONO:"
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(156, 761)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(268, 26)
        Me.tbEmail.TabIndex = 8
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEmail.ForeColor = System.Drawing.SystemColors.Control
        Me.lEmail.Location = New System.Drawing.Point(76, 764)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(62, 20)
        Me.lEmail.TabIndex = 13
        Me.lEmail.Text = "EMAIL:"
        '
        'lDireccion
        '
        Me.lDireccion.AutoSize = True
        Me.lDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDireccion.ForeColor = System.Drawing.SystemColors.Control
        Me.lDireccion.Location = New System.Drawing.Point(592, 336)
        Me.lDireccion.Name = "lDireccion"
        Me.lDireccion.Size = New System.Drawing.Size(108, 20)
        Me.lDireccion.TabIndex = 17
        Me.lDireccion.Text = "DIRECCION"
        '
        'lRol
        '
        Me.lRol.AutoSize = True
        Me.lRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRol.ForeColor = System.Drawing.SystemColors.Control
        Me.lRol.Location = New System.Drawing.Point(92, 826)
        Me.lRol.Name = "lRol"
        Me.lRol.Size = New System.Drawing.Size(46, 20)
        Me.lRol.TabIndex = 15
        Me.lRol.Text = "ROL:"
        '
        'cbRol
        '
        Me.cbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"Administrador", "Propietario", "Vendedor"})
        Me.cbRol.Location = New System.Drawing.Point(156, 826)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(121, 28)
        Me.cbRol.TabIndex = 19
        '
        'bCrear
        '
        Me.bCrear.Location = New System.Drawing.Point(903, 285)
        Me.bCrear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(134, 57)
        Me.bCrear.TabIndex = 20
        Me.bCrear.Text = "CREAR EMPLEADO"
        Me.bCrear.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Location = New System.Drawing.Point(903, 376)
        Me.bModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(134, 57)
        Me.bModificar.TabIndex = 21
        Me.bModificar.Text = "MODIFICAR EMPLEADO"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(903, 468)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(134, 57)
        Me.bBuscar.TabIndex = 22
        Me.bBuscar.Text = "BUSCAR EMPLEADO"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'bBorrar
        '
        Me.bBorrar.Location = New System.Drawing.Point(903, 574)
        Me.bBorrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(134, 57)
        Me.bBorrar.TabIndex = 23
        Me.bBorrar.Text = "BORRAR EMPLEADO"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'bInforme
        '
        Me.bInforme.Location = New System.Drawing.Point(903, 727)
        Me.bInforme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bInforme.Name = "bInforme"
        Me.bInforme.Size = New System.Drawing.Size(134, 57)
        Me.bInforme.TabIndex = 24
        Me.bInforme.Text = "GENERAR INFORME"
        Me.bInforme.UseVisualStyleBackColor = True
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Location = New System.Drawing.Point(1087, 243)
        Me.dgvEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.RowHeadersWidth = 51
        Me.dgvEmpleado.RowTemplate.Height = 24
        Me.dgvEmpleado.Size = New System.Drawing.Size(790, 574)
        Me.dgvEmpleado.TabIndex = 25
        '
        'cbTipo
        '
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Calle", "Avenida", "Plaza", "Carretera", "Camino"})
        Me.cbTipo.Location = New System.Drawing.Point(626, 389)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 28)
        Me.cbTipo.TabIndex = 27
        '
        'lTipo
        '
        Me.lTipo.AutoSize = True
        Me.lTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTipo.ForeColor = System.Drawing.SystemColors.Control
        Me.lTipo.Location = New System.Drawing.Point(555, 393)
        Me.lTipo.Name = "lTipo"
        Me.lTipo.Size = New System.Drawing.Size(49, 20)
        Me.lTipo.TabIndex = 26
        Me.lTipo.Text = "TIPO:"
        '
        'tbNombreCalle
        '
        Me.tbNombreCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreCalle.Location = New System.Drawing.Point(626, 458)
        Me.tbNombreCalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbNombreCalle.Name = "tbNombreCalle"
        Me.tbNombreCalle.Size = New System.Drawing.Size(180, 26)
        Me.tbNombreCalle.TabIndex = 9
        '
        'lNombreCalle
        '
        Me.lNombreCalle.AutoSize = True
        Me.lNombreCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreCalle.ForeColor = System.Drawing.SystemColors.Control
        Me.lNombreCalle.Location = New System.Drawing.Point(516, 462)
        Me.lNombreCalle.Name = "lNombreCalle"
        Me.lNombreCalle.Size = New System.Drawing.Size(83, 20)
        Me.lNombreCalle.TabIndex = 28
        Me.lNombreCalle.Text = "NOMBRE:"
        '
        'tbCp
        '
        Me.tbCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCp.Location = New System.Drawing.Point(706, 596)
        Me.tbCp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbCp.Name = "tbCp"
        Me.tbCp.Size = New System.Drawing.Size(115, 26)
        Me.tbCp.TabIndex = 13
        '
        'lCp
        '
        Me.lCp.AutoSize = True
        Me.lCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCp.ForeColor = System.Drawing.SystemColors.Control
        Me.lCp.Location = New System.Drawing.Point(649, 600)
        Me.lCp.Name = "lCp"
        Me.lCp.Size = New System.Drawing.Size(38, 20)
        Me.lCp.TabIndex = 32
        Me.lCp.Text = "C.P:"
        '
        'lNumero
        '
        Me.lNumero.AutoSize = True
        Me.lNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumero.ForeColor = System.Drawing.SystemColors.Control
        Me.lNumero.Location = New System.Drawing.Point(524, 532)
        Me.lNumero.Name = "lNumero"
        Me.lNumero.Size = New System.Drawing.Size(30, 20)
        Me.lNumero.TabIndex = 30
        Me.lNumero.Text = "Nº:"
        '
        'tbNumero
        '
        Me.tbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumero.Location = New System.Drawing.Point(569, 528)
        Me.tbNumero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbNumero.Name = "tbNumero"
        Me.tbNumero.Size = New System.Drawing.Size(59, 26)
        Me.tbNumero.TabIndex = 10
        '
        'tbPiso
        '
        Me.tbPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPiso.Location = New System.Drawing.Point(706, 527)
        Me.tbPiso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbPiso.Name = "tbPiso"
        Me.tbPiso.Size = New System.Drawing.Size(59, 26)
        Me.tbPiso.TabIndex = 11
        '
        'lPiso
        '
        Me.lPiso.AutoSize = True
        Me.lPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPiso.ForeColor = System.Drawing.SystemColors.Control
        Me.lPiso.Location = New System.Drawing.Point(634, 532)
        Me.lPiso.Name = "lPiso"
        Me.lPiso.Size = New System.Drawing.Size(51, 20)
        Me.lPiso.TabIndex = 34
        Me.lPiso.Text = "PISO:"
        '
        'tbLetra
        '
        Me.tbLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLetra.Location = New System.Drawing.Point(569, 596)
        Me.tbLetra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbLetra.Name = "tbLetra"
        Me.tbLetra.Size = New System.Drawing.Size(59, 26)
        Me.tbLetra.TabIndex = 12
        '
        'lLetra
        '
        Me.lLetra.AutoSize = True
        Me.lLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLetra.ForeColor = System.Drawing.SystemColors.Control
        Me.lLetra.Location = New System.Drawing.Point(489, 596)
        Me.lLetra.Name = "lLetra"
        Me.lLetra.Size = New System.Drawing.Size(65, 20)
        Me.lLetra.TabIndex = 36
        Me.lLetra.Text = "LETRA:"
        '
        'tbCiudad
        '
        Me.tbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCiudad.Location = New System.Drawing.Point(597, 660)
        Me.tbCiudad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbCiudad.Name = "tbCiudad"
        Me.tbCiudad.Size = New System.Drawing.Size(168, 26)
        Me.tbCiudad.TabIndex = 14
        '
        'lCiudad
        '
        Me.lCiudad.AutoSize = True
        Me.lCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCiudad.ForeColor = System.Drawing.SystemColors.Control
        Me.lCiudad.Location = New System.Drawing.Point(497, 661)
        Me.lCiudad.Name = "lCiudad"
        Me.lCiudad.Size = New System.Drawing.Size(76, 20)
        Me.lCiudad.TabIndex = 38
        Me.lCiudad.Text = "CIUDAD:"
        '
        'tbProvincia
        '
        Me.tbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProvincia.Location = New System.Drawing.Point(597, 727)
        Me.tbProvincia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbProvincia.Name = "tbProvincia"
        Me.tbProvincia.Size = New System.Drawing.Size(168, 26)
        Me.tbProvincia.TabIndex = 15
        '
        'lProvincia
        '
        Me.lProvincia.AutoSize = True
        Me.lProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProvincia.ForeColor = System.Drawing.SystemColors.Control
        Me.lProvincia.Location = New System.Drawing.Point(464, 730)
        Me.lProvincia.Name = "lProvincia"
        Me.lProvincia.Size = New System.Drawing.Size(101, 20)
        Me.lProvincia.TabIndex = 40
        Me.lProvincia.Text = "PROVINCIA:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.Gasolinera_r.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 160)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'bConfirmar
        '
        Me.bConfirmar.Location = New System.Drawing.Point(470, 885)
        Me.bConfirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bConfirmar.Name = "bConfirmar"
        Me.bConfirmar.Size = New System.Drawing.Size(134, 57)
        Me.bConfirmar.TabIndex = 43
        Me.bConfirmar.Text = "CONFIRMAR"
        Me.bConfirmar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(672, 885)
        Me.bCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(134, 57)
        Me.bCancelar.TabIndex = 44
        Me.bCancelar.Text = "CANCELAR"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(55, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "NOMBRE:"
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(156, 394)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(168, 26)
        Me.tbNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(19, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "CONTRASEÑA:"
        '
        'tbContrasenna
        '
        Me.tbContrasenna.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContrasenna.Location = New System.Drawing.Point(156, 482)
        Me.tbContrasenna.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbContrasenna.Name = "tbContrasenna"
        Me.tbContrasenna.Size = New System.Drawing.Size(168, 26)
        Me.tbContrasenna.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(19, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "CONFIRMAR CONTRASEÑA:"
        '
        'epNombre
        '
        Me.epNombre.ContainerControl = Me
        '
        'epContrasenna
        '
        Me.epContrasenna.ContainerControl = Me
        '
        'epConfirmContrasenna
        '
        Me.epConfirmContrasenna.ContainerControl = Me
        '
        'epApellido1
        '
        Me.epApellido1.ContainerControl = Me
        '
        'epApellido2
        '
        Me.epApellido2.ContainerControl = Me
        '
        'epTelefono
        '
        Me.epTelefono.ContainerControl = Me
        '
        'epEmail
        '
        Me.epEmail.ContainerControl = Me
        '
        'epNombreCallle
        '
        Me.epNombreCallle.ContainerControl = Me
        '
        'epNumero
        '
        Me.epNumero.ContainerControl = Me
        '
        'epPiso
        '
        Me.epPiso.ContainerControl = Me
        '
        'epCp
        '
        Me.epCp.ContainerControl = Me
        '
        'epLetra
        '
        Me.epLetra.ContainerControl = Me
        '
        'epCiuidad
        '
        Me.epCiuidad.ContainerControl = Me
        '
        'epProvincia
        '
        Me.epProvincia.ContainerControl = Me
        '
        'FormularioEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbContrasenna)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bConfirmar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbProvincia)
        Me.Controls.Add(Me.lProvincia)
        Me.Controls.Add(Me.tbCiudad)
        Me.Controls.Add(Me.lCiudad)
        Me.Controls.Add(Me.tbLetra)
        Me.Controls.Add(Me.lLetra)
        Me.Controls.Add(Me.tbPiso)
        Me.Controls.Add(Me.lPiso)
        Me.Controls.Add(Me.tbCp)
        Me.Controls.Add(Me.lCp)
        Me.Controls.Add(Me.tbNumero)
        Me.Controls.Add(Me.lNumero)
        Me.Controls.Add(Me.tbNombreCalle)
        Me.Controls.Add(Me.lNombreCalle)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.lTipo)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Controls.Add(Me.bInforme)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bCrear)
        Me.Controls.Add(Me.cbRol)
        Me.Controls.Add(Me.lDireccion)
        Me.Controls.Add(Me.lRol)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.lEmail)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.lTelefono)
        Me.Controls.Add(Me.tbApellido2)
        Me.Controls.Add(Me.lApellido2)
        Me.Controls.Add(Me.tbApellido1)
        Me.Controls.Add(Me.lApellido1)
        Me.Controls.Add(Me.tbConfirmContrasenna)
        Me.Controls.Add(Me.tbDni)
        Me.Controls.Add(Me.lDni)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lId)
        Me.Controls.Add(Me.lTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormularioEmpleado"
        Me.Text = "FormularioEmpleados"
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epContrasenna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epConfirmContrasenna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epApellido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epApellido2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epNombreCallle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epPiso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epCp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epLetra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epCiuidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitulo As Label
    Friend WithEvents lId As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbDni As TextBox
    Friend WithEvents lDni As Label
    Friend WithEvents tbConfirmContrasenna As TextBox
    Friend WithEvents tbApellido1 As TextBox
    Friend WithEvents lApellido1 As Label
    Friend WithEvents tbApellido2 As TextBox
    Friend WithEvents lApellido2 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lTelefono As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lEmail As Label
    Friend WithEvents lDireccion As Label
    Friend WithEvents lRol As Label
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents bCrear As Button
    Friend WithEvents bModificar As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents bBorrar As Button
    Friend WithEvents bInforme As Button
    Friend WithEvents dgvEmpleado As DataGridView
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents lTipo As Label
    Friend WithEvents tbNombreCalle As TextBox
    Friend WithEvents lNombreCalle As Label
    Friend WithEvents tbCp As TextBox
    Friend WithEvents lCp As Label
    Friend WithEvents lNumero As Label
    Friend WithEvents tbNumero As TextBox
    Friend WithEvents tbPiso As TextBox
    Friend WithEvents lPiso As Label
    Friend WithEvents tbLetra As TextBox
    Friend WithEvents lLetra As Label
    Friend WithEvents tbCiudad As TextBox
    Friend WithEvents lCiudad As Label
    Friend WithEvents tbProvincia As TextBox
    Friend WithEvents lProvincia As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bConfirmar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbContrasenna As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents epNombre As ErrorProvider
    Friend WithEvents epContrasenna As ErrorProvider
    Friend WithEvents epConfirmContrasenna As ErrorProvider
    Friend WithEvents epApellido1 As ErrorProvider
    Friend WithEvents epApellido2 As ErrorProvider
    Friend WithEvents epTelefono As ErrorProvider
    Friend WithEvents epEmail As ErrorProvider
    Friend WithEvents epNombreCallle As ErrorProvider
    Friend WithEvents epNumero As ErrorProvider
    Friend WithEvents epPiso As ErrorProvider
    Friend WithEvents epCp As ErrorProvider
    Friend WithEvents epLetra As ErrorProvider
    Friend WithEvents epCiuidad As ErrorProvider
    Friend WithEvents epProvincia As ErrorProvider
End Class
