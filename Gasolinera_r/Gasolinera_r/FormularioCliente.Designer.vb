<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCliente
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
        Me.lId = New System.Windows.Forms.Label()
        Me.lDni = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.lApellido1 = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido1 = New System.Windows.Forms.TextBox()
        Me.tbApellido2 = New System.Windows.Forms.TextBox()
        Me.lApellido2 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.lFecha = New System.Windows.Forms.Label()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bIforme = New System.Windows.Forms.Button()
        Me.bCarnet = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.IdcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Repsol_dbDataSet = New Gasolinera_r.repsol_dbDataSet1()
        Me.ClientesTableAdapter = New Gasolinera_r.repsol_dbDataSet1TableAdapters.clientesTableAdapter()
        Me.lTItulo = New System.Windows.Forms.Label()
        Me.epNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epApellido1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epApellido2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epDni = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repsol_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epApellido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epApellido2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epDni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lId
        '
        Me.lId.AutoSize = True
        Me.lId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lId.ForeColor = System.Drawing.SystemColors.Control
        Me.lId.Location = New System.Drawing.Point(112, 274)
        Me.lId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lId.Name = "lId"
        Me.lId.Size = New System.Drawing.Size(52, 36)
        Me.lId.TabIndex = 0
        Me.lId.Text = "ID:"
        '
        'lDni
        '
        Me.lDni.AutoSize = True
        Me.lDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDni.ForeColor = System.Drawing.SystemColors.Control
        Me.lDni.Location = New System.Drawing.Point(335, 274)
        Me.lDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDni.Name = "lDni"
        Me.lDni.Size = New System.Drawing.Size(74, 36)
        Me.lDni.TabIndex = 1
        Me.lDni.Text = "DNI:"
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTelefono.ForeColor = System.Drawing.SystemColors.Control
        Me.lTelefono.Location = New System.Drawing.Point(105, 439)
        Me.lTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(182, 36)
        Me.lTelefono.TabIndex = 2
        Me.lTelefono.Text = "TELÉFONO:"
        '
        'lApellido1
        '
        Me.lApellido1.AutoSize = True
        Me.lApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido1.ForeColor = System.Drawing.SystemColors.Control
        Me.lApellido1.Location = New System.Drawing.Point(105, 352)
        Me.lApellido1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lApellido1.Name = "lApellido1"
        Me.lApellido1.Size = New System.Drawing.Size(194, 36)
        Me.lApellido1.TabIndex = 3
        Me.lApellido1.Text = "APELLIDO 1:"
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.ForeColor = System.Drawing.SystemColors.Control
        Me.lNombre.Location = New System.Drawing.Point(713, 274)
        Me.lNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(154, 36)
        Me.lNombre.TabIndex = 4
        Me.lNombre.Text = "NOMBRE:"
        '
        'tbId
        '
        Me.tbId.Enabled = False
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(176, 274)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(84, 37)
        Me.tbId.TabIndex = 5
        '
        'tbDni
        '
        Me.tbDni.Enabled = False
        Me.tbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDni.Location = New System.Drawing.Point(423, 274)
        Me.tbDni.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDni.MaxLength = 9
        Me.tbDni.Name = "tbDni"
        Me.tbDni.Size = New System.Drawing.Size(245, 37)
        Me.tbDni.TabIndex = 6
        '
        'tbNombre
        '
        Me.tbNombre.Enabled = False
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(888, 274)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombre.MaxLength = 15
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(245, 37)
        Me.tbNombre.TabIndex = 7
        '
        'tbApellido1
        '
        Me.tbApellido1.Enabled = False
        Me.tbApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido1.Location = New System.Drawing.Point(315, 352)
        Me.tbApellido1.Margin = New System.Windows.Forms.Padding(4)
        Me.tbApellido1.MaxLength = 20
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(271, 37)
        Me.tbApellido1.TabIndex = 8
        '
        'tbApellido2
        '
        Me.tbApellido2.Enabled = False
        Me.tbApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido2.Location = New System.Drawing.Point(861, 351)
        Me.tbApellido2.Margin = New System.Windows.Forms.Padding(4)
        Me.tbApellido2.MaxLength = 20
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(271, 37)
        Me.tbApellido2.TabIndex = 10
        '
        'lApellido2
        '
        Me.lApellido2.AutoSize = True
        Me.lApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido2.ForeColor = System.Drawing.SystemColors.Control
        Me.lApellido2.Location = New System.Drawing.Point(651, 352)
        Me.lApellido2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lApellido2.Name = "lApellido2"
        Me.lApellido2.Size = New System.Drawing.Size(194, 36)
        Me.lApellido2.TabIndex = 9
        Me.lApellido2.Text = "APELLIDO 2:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Enabled = False
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(315, 439)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono.MaxLength = 9
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(271, 37)
        Me.tbTelefono.TabIndex = 11
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEmail.ForeColor = System.Drawing.SystemColors.Control
        Me.lEmail.Location = New System.Drawing.Point(613, 439)
        Me.lEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(114, 36)
        Me.lEmail.TabIndex = 12
        Me.lEmail.Text = "EMAIL:"
        '
        'tbEmail
        '
        Me.tbEmail.Enabled = False
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(740, 439)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEmail.MaxLength = 40
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(393, 37)
        Me.tbEmail.TabIndex = 13
        '
        'tbFecha
        '
        Me.tbFecha.Enabled = False
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(384, 523)
        Me.tbFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(271, 37)
        Me.tbFecha.TabIndex = 14
        '
        'lFecha
        '
        Me.lFecha.AutoSize = True
        Me.lFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.lFecha.Location = New System.Drawing.Point(105, 523)
        Me.lFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lFecha.Name = "lFecha"
        Me.lFecha.Size = New System.Drawing.Size(258, 36)
        Me.lFecha.TabIndex = 15
        Me.lFecha.Text = "FECHA DE ALTA:"
        '
        'bNuevo
        '
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Location = New System.Drawing.Point(108, 143)
        Me.bNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(244, 87)
        Me.bNuevo.TabIndex = 16
        Me.bNuevo.Tag = "1"
        Me.bNuevo.Text = "NUEVO CLIENTE"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.Location = New System.Drawing.Point(423, 144)
        Me.bModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(244, 87)
        Me.bModificar.TabIndex = 17
        Me.bModificar.Tag = "2"
        Me.bModificar.Text = "MODIFICAR CLIENTE"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(737, 143)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(244, 87)
        Me.bBuscar.TabIndex = 18
        Me.bBuscar.Tag = "3"
        Me.bBuscar.Text = "BUSCAR CLIENTE"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'bBorrar
        '
        Me.bBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBorrar.Location = New System.Drawing.Point(1073, 143)
        Me.bBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(244, 87)
        Me.bBorrar.TabIndex = 19
        Me.bBorrar.Tag = "4"
        Me.bBorrar.Text = "BORRAR CLIENTE"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'bIforme
        '
        Me.bIforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIforme.Location = New System.Drawing.Point(1375, 143)
        Me.bIforme.Margin = New System.Windows.Forms.Padding(4)
        Me.bIforme.Name = "bIforme"
        Me.bIforme.Size = New System.Drawing.Size(244, 87)
        Me.bIforme.TabIndex = 20
        Me.bIforme.Text = "GENERAR INFORME"
        Me.bIforme.UseVisualStyleBackColor = True
        '
        'bCarnet
        '
        Me.bCarnet.Location = New System.Drawing.Point(1676, 143)
        Me.bCarnet.Margin = New System.Windows.Forms.Padding(4)
        Me.bCarnet.Name = "bCarnet"
        Me.bCarnet.Size = New System.Drawing.Size(244, 87)
        Me.bCarnet.TabIndex = 21
        Me.bCarnet.Text = "CREAR CARNET"
        Me.bCarnet.UseVisualStyleBackColor = True
        '
        'bAceptar
        '
        Me.bAceptar.Enabled = False
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(1195, 309)
        Me.bAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(268, 52)
        Me.bAceptar.TabIndex = 22
        Me.bAceptar.Text = "ACEPTAR"
        Me.bAceptar.UseVisualStyleBackColor = True
        Me.bAceptar.Visible = False
        '
        'bCancelar
        '
        Me.bCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.Location = New System.Drawing.Point(1195, 389)
        Me.bCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(268, 49)
        Me.bCancelar.TabIndex = 23
        Me.bCancelar.Text = "CANCELAR"
        Me.bCancelar.UseVisualStyleBackColor = True
        Me.bCancelar.Visible = False
        '
        'bVolver
        '
        Me.bVolver.Location = New System.Drawing.Point(1748, 897)
        Me.bVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(268, 49)
        Me.bVolver.TabIndex = 24
        Me.bVolver.Text = "VOLVER"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.FechaDeAltaDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.ClientesBindingSource
        Me.dgvClientes.Location = New System.Drawing.Point(360, 629)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidth = 51
        Me.dgvClientes.Size = New System.Drawing.Size(1159, 304)
        Me.dgvClientes.TabIndex = 25
        '
        'IdcDataGridViewTextBoxColumn
        '
        Me.IdcDataGridViewTextBoxColumn.DataPropertyName = "id_c"
        Me.IdcDataGridViewTextBoxColumn.HeaderText = "id_c"
        Me.IdcDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdcDataGridViewTextBoxColumn.Name = "IdcDataGridViewTextBoxColumn"
        Me.IdcDataGridViewTextBoxColumn.Width = 125
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "dni"
        Me.DniDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        Me.Apellido1DataGridViewTextBoxColumn.Width = 125
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        Me.Apellido2DataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDeAltaDataGridViewTextBoxColumn
        '
        Me.FechaDeAltaDataGridViewTextBoxColumn.DataPropertyName = "fecha de alta"
        Me.FechaDeAltaDataGridViewTextBoxColumn.HeaderText = "fecha de alta"
        Me.FechaDeAltaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDeAltaDataGridViewTextBoxColumn.Name = "FechaDeAltaDataGridViewTextBoxColumn"
        Me.FechaDeAltaDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.Repsol_dbDataSet
        '
        'Repsol_dbDataSet
        '
        Me.Repsol_dbDataSet.DataSetName = "repsol_dbDataSet"
        Me.Repsol_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'lTItulo
        '
        Me.lTItulo.AutoSize = True
        Me.lTItulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTItulo.ForeColor = System.Drawing.SystemColors.Control
        Me.lTItulo.Location = New System.Drawing.Point(707, 27)
        Me.lTItulo.Name = "lTItulo"
        Me.lTItulo.Size = New System.Drawing.Size(610, 69)
        Me.lTItulo.TabIndex = 26
        Me.lTItulo.Text = "GESTIÓN CLIENTES"
        '
        'epNombre
        '
        Me.epNombre.ContainerControl = Me
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
        'epDni
        '
        Me.epDni.ContainerControl = Me
        '
        'bLimpiar
        '
        Me.bLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Location = New System.Drawing.Point(907, 523)
        Me.bLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(227, 69)
        Me.bLimpiar.TabIndex = 27
        Me.bLimpiar.Text = "LIMPIAR CAMPOS"
        Me.bLimpiar.UseVisualStyleBackColor = True
        '
        'FormularioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1924, 961)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.lTItulo)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bCarnet)
        Me.Controls.Add(Me.bIforme)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bNuevo)
        Me.Controls.Add(Me.lFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.lEmail)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbApellido2)
        Me.Controls.Add(Me.lApellido2)
        Me.Controls.Add(Me.tbApellido1)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbDni)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.lApellido1)
        Me.Controls.Add(Me.lTelefono)
        Me.Controls.Add(Me.lDni)
        Me.Controls.Add(Me.lId)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormularioCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormularioCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repsol_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epApellido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epApellido2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epDni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lId As Label
    Friend WithEvents lDni As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents lApellido1 As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbDni As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido1 As TextBox
    Friend WithEvents tbApellido2 As TextBox
    Friend WithEvents lApellido2 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lEmail As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents lFecha As Label
    Friend WithEvents bNuevo As Button
    Friend WithEvents bModificar As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents bBorrar As Button
    Friend WithEvents bIforme As Button
    Friend WithEvents bCarnet As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents bVolver As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Repsol_dbDataSet As repsol_dbDataSet1
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As repsol_dbDataSet1TableAdapters.clientesTableAdapter
    Friend WithEvents IdcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lTItulo As Label
    Friend WithEvents epNombre As ErrorProvider
    Friend WithEvents epApellido1 As ErrorProvider
    Friend WithEvents epApellido2 As ErrorProvider
    Friend WithEvents epTelefono As ErrorProvider
    Friend WithEvents epEmail As ErrorProvider
    Friend WithEvents epDni As ErrorProvider
    Friend WithEvents bLimpiar As Button
End Class
