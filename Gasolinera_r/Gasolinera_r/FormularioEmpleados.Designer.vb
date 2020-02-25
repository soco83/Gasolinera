<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioEmpleado
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
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.lId = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.lDni = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lNombre = New System.Windows.Forms.Label()
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
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.ForeColor = System.Drawing.SystemColors.Control
        Me.lTitulo.Location = New System.Drawing.Point(33, 42)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(291, 36)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "Gestión Empleados"
        '
        'lId
        '
        Me.lId.AutoSize = True
        Me.lId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lId.ForeColor = System.Drawing.SystemColors.Control
        Me.lId.Location = New System.Drawing.Point(75, 247)
        Me.lId.Name = "lId"
        Me.lId.Size = New System.Drawing.Size(37, 25)
        Me.lId.TabIndex = 1
        Me.lId.Text = "ID:"
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(118, 243)
        Me.tbId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(56, 30)
        Me.tbId.TabIndex = 2
        '
        'tbDni
        '
        Me.tbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDni.Location = New System.Drawing.Point(118, 312)
        Me.tbDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbDni.Name = "tbDni"
        Me.tbDni.Size = New System.Drawing.Size(168, 30)
        Me.tbDni.TabIndex = 4
        '
        'lDni
        '
        Me.lDni.AutoSize = True
        Me.lDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDni.ForeColor = System.Drawing.SystemColors.Control
        Me.lDni.Location = New System.Drawing.Point(61, 316)
        Me.lDni.Name = "lDni"
        Me.lDni.Size = New System.Drawing.Size(51, 25)
        Me.lDni.TabIndex = 3
        Me.lDni.Text = "DNI:"
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(118, 382)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(168, 30)
        Me.tbNombre.TabIndex = 6
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.ForeColor = System.Drawing.SystemColors.Control
        Me.lNombre.Location = New System.Drawing.Point(8, 386)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(104, 25)
        Me.lNombre.TabIndex = 5
        Me.lNombre.Text = "NOMBRE:"
        '
        'tbApellido1
        '
        Me.tbApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido1.Location = New System.Drawing.Point(118, 450)
        Me.tbApellido1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(168, 30)
        Me.tbApellido1.TabIndex = 8
        '
        'lApellido1
        '
        Me.lApellido1.AutoSize = True
        Me.lApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido1.ForeColor = System.Drawing.SystemColors.Control
        Me.lApellido1.Location = New System.Drawing.Point(-19, 454)
        Me.lApellido1.Name = "lApellido1"
        Me.lApellido1.Size = New System.Drawing.Size(131, 25)
        Me.lApellido1.TabIndex = 7
        Me.lApellido1.Text = "APELLIDO 1:"
        '
        'tbApellido2
        '
        Me.tbApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido2.Location = New System.Drawing.Point(118, 514)
        Me.tbApellido2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(168, 30)
        Me.tbApellido2.TabIndex = 10
        '
        'lApellido2
        '
        Me.lApellido2.AutoSize = True
        Me.lApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido2.ForeColor = System.Drawing.SystemColors.Control
        Me.lApellido2.Location = New System.Drawing.Point(-19, 518)
        Me.lApellido2.Name = "lApellido2"
        Me.lApellido2.Size = New System.Drawing.Size(131, 25)
        Me.lApellido2.TabIndex = 9
        Me.lApellido2.Text = "APELLIDO 2:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(118, 581)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(168, 30)
        Me.tbTelefono.TabIndex = 12
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTelefono.ForeColor = System.Drawing.SystemColors.Control
        Me.lTelefono.Location = New System.Drawing.Point(-14, 584)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(126, 25)
        Me.lTelefono.TabIndex = 11
        Me.lTelefono.Text = "TELÉFONO:"
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(118, 644)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(268, 30)
        Me.tbEmail.TabIndex = 14
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEmail.ForeColor = System.Drawing.SystemColors.Control
        Me.lEmail.Location = New System.Drawing.Point(34, 647)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(78, 25)
        Me.lEmail.TabIndex = 13
        Me.lEmail.Text = "EMAIL:"
        '
        'lDireccion
        '
        Me.lDireccion.AutoSize = True
        Me.lDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDireccion.ForeColor = System.Drawing.SystemColors.Control
        Me.lDireccion.Location = New System.Drawing.Point(450, 190)
        Me.lDireccion.Name = "lDireccion"
        Me.lDireccion.Size = New System.Drawing.Size(131, 25)
        Me.lDireccion.TabIndex = 17
        Me.lDireccion.Text = "DIRECCION"
        '
        'lRol
        '
        Me.lRol.AutoSize = True
        Me.lRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRol.ForeColor = System.Drawing.SystemColors.Control
        Me.lRol.Location = New System.Drawing.Point(54, 712)
        Me.lRol.Name = "lRol"
        Me.lRol.Size = New System.Drawing.Size(58, 25)
        Me.lRol.TabIndex = 15
        Me.lRol.Text = "ROL:"
        '
        'cbRol
        '
        Me.cbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Location = New System.Drawing.Point(118, 709)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(121, 33)
        Me.cbRol.TabIndex = 19
        '
        'bCrear
        '
        Me.bCrear.Location = New System.Drawing.Point(765, 243)
        Me.bCrear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(134, 57)
        Me.bCrear.TabIndex = 20
        Me.bCrear.Text = "CREAR EMPLEADO"
        Me.bCrear.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Location = New System.Drawing.Point(765, 334)
        Me.bModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(134, 57)
        Me.bModificar.TabIndex = 21
        Me.bModificar.Text = "MODIFICAR EMPLEADO"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(765, 426)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(134, 57)
        Me.bBuscar.TabIndex = 22
        Me.bBuscar.Text = "BUSCAR EMPLEADO"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'bBorrar
        '
        Me.bBorrar.Location = New System.Drawing.Point(765, 532)
        Me.bBorrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(134, 57)
        Me.bBorrar.TabIndex = 23
        Me.bBorrar.Text = "BORRAR EMPLEADO"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'bInforme
        '
        Me.bInforme.Location = New System.Drawing.Point(765, 685)
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
        Me.dgvEmpleado.Location = New System.Drawing.Point(1027, 243)
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
        Me.cbTipo.Location = New System.Drawing.Point(484, 243)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 33)
        Me.cbTipo.TabIndex = 27
        '
        'lTipo
        '
        Me.lTipo.AutoSize = True
        Me.lTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTipo.ForeColor = System.Drawing.SystemColors.Control
        Me.lTipo.Location = New System.Drawing.Point(413, 247)
        Me.lTipo.Name = "lTipo"
        Me.lTipo.Size = New System.Drawing.Size(65, 25)
        Me.lTipo.TabIndex = 26
        Me.lTipo.Text = "TIPO:"
        '
        'tbNombreCalle
        '
        Me.tbNombreCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreCalle.Location = New System.Drawing.Point(484, 312)
        Me.tbNombreCalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbNombreCalle.Name = "tbNombreCalle"
        Me.tbNombreCalle.Size = New System.Drawing.Size(180, 30)
        Me.tbNombreCalle.TabIndex = 29
        '
        'lNombreCalle
        '
        Me.lNombreCalle.AutoSize = True
        Me.lNombreCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreCalle.ForeColor = System.Drawing.SystemColors.Control
        Me.lNombreCalle.Location = New System.Drawing.Point(374, 316)
        Me.lNombreCalle.Name = "lNombreCalle"
        Me.lNombreCalle.Size = New System.Drawing.Size(104, 25)
        Me.lNombreCalle.TabIndex = 28
        Me.lNombreCalle.Text = "NOMBRE:"
        '
        'tbCp
        '
        Me.tbCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCp.Location = New System.Drawing.Point(564, 450)
        Me.tbCp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbCp.Name = "tbCp"
        Me.tbCp.Size = New System.Drawing.Size(115, 30)
        Me.tbCp.TabIndex = 33
        '
        'lCp
        '
        Me.lCp.AutoSize = True
        Me.lCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCp.ForeColor = System.Drawing.SystemColors.Control
        Me.lCp.Location = New System.Drawing.Point(507, 454)
        Me.lCp.Name = "lCp"
        Me.lCp.Size = New System.Drawing.Size(51, 25)
        Me.lCp.TabIndex = 32
        Me.lCp.Text = "C.P:"
        '
        'lNumero
        '
        Me.lNumero.AutoSize = True
        Me.lNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumero.ForeColor = System.Drawing.SystemColors.Control
        Me.lNumero.Location = New System.Drawing.Point(382, 386)
        Me.lNumero.Name = "lNumero"
        Me.lNumero.Size = New System.Drawing.Size(39, 25)
        Me.lNumero.TabIndex = 30
        Me.lNumero.Text = "Nº:"
        '
        'tbNumero
        '
        Me.tbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumero.Location = New System.Drawing.Point(427, 382)
        Me.tbNumero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbNumero.Name = "tbNumero"
        Me.tbNumero.Size = New System.Drawing.Size(59, 30)
        Me.tbNumero.TabIndex = 31
        '
        'tbPiso
        '
        Me.tbPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPiso.Location = New System.Drawing.Point(564, 381)
        Me.tbPiso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbPiso.Name = "tbPiso"
        Me.tbPiso.Size = New System.Drawing.Size(59, 30)
        Me.tbPiso.TabIndex = 35
        '
        'lPiso
        '
        Me.lPiso.AutoSize = True
        Me.lPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPiso.ForeColor = System.Drawing.SystemColors.Control
        Me.lPiso.Location = New System.Drawing.Point(492, 386)
        Me.lPiso.Name = "lPiso"
        Me.lPiso.Size = New System.Drawing.Size(66, 25)
        Me.lPiso.TabIndex = 34
        Me.lPiso.Text = "PISO:"
        '
        'tbLetra
        '
        Me.tbLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLetra.Location = New System.Drawing.Point(427, 450)
        Me.tbLetra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbLetra.Name = "tbLetra"
        Me.tbLetra.Size = New System.Drawing.Size(59, 30)
        Me.tbLetra.TabIndex = 37
        '
        'lLetra
        '
        Me.lLetra.AutoSize = True
        Me.lLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLetra.ForeColor = System.Drawing.SystemColors.Control
        Me.lLetra.Location = New System.Drawing.Point(347, 450)
        Me.lLetra.Name = "lLetra"
        Me.lLetra.Size = New System.Drawing.Size(82, 25)
        Me.lLetra.TabIndex = 36
        Me.lLetra.Text = "LETRA:"
        '
        'tbCiudad
        '
        Me.tbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCiudad.Location = New System.Drawing.Point(455, 514)
        Me.tbCiudad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbCiudad.Name = "tbCiudad"
        Me.tbCiudad.Size = New System.Drawing.Size(168, 30)
        Me.tbCiudad.TabIndex = 39
        '
        'lCiudad
        '
        Me.lCiudad.AutoSize = True
        Me.lCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCiudad.ForeColor = System.Drawing.SystemColors.Control
        Me.lCiudad.Location = New System.Drawing.Point(355, 515)
        Me.lCiudad.Name = "lCiudad"
        Me.lCiudad.Size = New System.Drawing.Size(94, 25)
        Me.lCiudad.TabIndex = 38
        Me.lCiudad.Text = "CIUDAD:"
        '
        'tbProvincia
        '
        Me.tbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProvincia.Location = New System.Drawing.Point(455, 581)
        Me.tbProvincia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbProvincia.Name = "tbProvincia"
        Me.tbProvincia.Size = New System.Drawing.Size(168, 30)
        Me.tbProvincia.TabIndex = 41
        '
        'lProvincia
        '
        Me.lProvincia.AutoSize = True
        Me.lProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProvincia.ForeColor = System.Drawing.SystemColors.Control
        Me.lProvincia.Location = New System.Drawing.Point(322, 584)
        Me.lProvincia.Name = "lProvincia"
        Me.lProvincia.Size = New System.Drawing.Size(127, 25)
        Me.lProvincia.TabIndex = 40
        Me.lProvincia.Text = "PROVINCIA:"
        '
        'FormularioEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
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
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.tbDni)
        Me.Controls.Add(Me.lDni)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lId)
        Me.Controls.Add(Me.lTitulo)
        Me.Font = New System.Drawing.Font("Alef", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormularioEmpleado"
        Me.Text = "FormularioEmpleados"
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitulo As Label
    Friend WithEvents lId As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbDni As TextBox
    Friend WithEvents lDni As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lNombre As Label
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
End Class
