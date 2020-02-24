Imports System.Data.SqlClient
Imports Librera_validaciones

Public Class FormularioCliente
    Dim con As New SqlConnection("server=localhost\SQLExpress ; database=repsol_db ; Integrated Security = true")
    Dim valida As New Validaciones
    Dim gestionDB As New Gestion_db(con)

    'Se crea un adaptador para el dataset.
    Dim adapter As New SqlDataAdapter("select * from clientes", con)

    'Se crea el dataset para  poder guardar todo lo necesario de la base de datos. 
    Dim dataSet As New DataSet

    'Variable que almacena el tag del botón del formulario que ha sido pulsado(Crear, Modificar, Buscar y Borrar)
    'para saber a que método se debe llamar cuando se pulse el botón aceptar
    Dim botonPulsado As Integer


    Private Sub FormularioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Repsol_dbDataSet1.clientes' Puede moverla o quitarla según sea necesario.
        'ClientesTableAdapter.Fill(Repsol_dbDataSet.clientes)


        'se llama al metodo cargarDatos
        cargarDatos()


    End Sub


    'Evento del botón bNuevo que dispone el formulario para crear clientes
    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click

        botonPulsado = bNuevo.Tag

        tbDni.Enabled = True
        tbNombre.Enabled = True
        tbApellido1.Enabled = True
        tbApellido2.Enabled = True
        tbTelefono.Enabled = True
        tbEmail.Enabled = True

        bAceptar.Visible = True
        bCancelar.Visible = True

    End Sub

    'este es el evento de pulsar el boton de modificar.
    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        botonPulsado = bModificar.Tag

        tbDni.Enabled = True
        tbNombre.Enabled = True
        tbApellido1.Enabled = True
        tbApellido2.Enabled = True
        tbTelefono.Enabled = True
        tbEmail.Enabled = True

        bAceptar.Visible = True
        bCancelar.Visible = True

        sacarDatos()
    End Sub
    'Evento del botón bAceptar. Según que tipo de operación se haya pulsado antes llamará a un método
    'o a otro usando la variable de control botonPulsado
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click

        Select Case botonPulsado

            'En el caso de que se haya pulsado el botón de crear un nuevo cliente
            Case bNuevo.Tag

                If (epDni.GetError(tbDni).Count = 0 And epNombre.GetError(tbNombre).Count = 0 And epApellido1.GetError(tbApellido1).Count = 0 And epApellido2.GetError(tbApellido2).Count = 0 And epTelefono.GetError(tbTelefono).Count = 0 And epEmail.GetError(tbEmail).Count = 0) Then
                    Dim datos(6) As String
                    datos(0) = tbDni.Text
                    datos(1) = tbNombre.Text
                    datos(2) = tbApellido1.Text
                    datos(3) = tbApellido2.Text
                    datos(4) = tbTelefono.Text
                    datos(5) = Now.ToShortDateString
                    datos(6) = tbEmail.Text

                    'Se guarda el nuevo cliente en la base de datos
                    Try
                        gestionDB.guardarCliente(datos)

                        MsgBox("Cliente creado satisfactoriamente")
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Information, "Error al guardar")
                    End Try

                    cargarDatos()
                    limpiarCampos()
                    bAceptar.Visible = False
                    bCancelar.Visible = False

                End If

            'En el caso de que se haya pulsado el botón de modificar un cliente
            Case bModificar.Tag
                If (epDni.GetError(tbDni).Count = 0 And epNombre.GetError(tbNombre).Count = 0 And epApellido1.GetError(tbApellido1).Count = 0 And epApellido2.GetError(tbApellido2).Count = 0 And epTelefono.GetError(tbTelefono).Count = 0 And epEmail.GetError(tbEmail).Count = 0) Then
                    Dim datos(5) As String
                    datos(0) = tbDni.Text
                    datos(0) = tbNombre.Text
                    datos(1) = tbApellido1.Text
                    datos(2) = tbApellido2.Text
                    datos(3) = tbTelefono.Text
                    datos(4) = Now.ToShortDateString
                    datos(5) = tbEmail.Text

                    'Se modifica el cliente en la base de datos.

                    gestionDB.modificarCliente(datos, tbId.Text)
                    cargarDatos()
                    limpiarCampos()
                    bAceptar.Visible = False
                    bCancelar.Visible = False
                End If
            'En el caso de que se haya pulsado el botón de buscar un cliente
            Case bBuscar.Tag

            'En el caso de que se haya pulsado el botón de borrar un cliente
            Case bBorrar.Tag


        End Select
    End Sub


    Private Sub tbId_Validated(sender As Object, e As EventArgs) Handles tbId.Validated

    End Sub


    'Evento que permite que el botón que aceptará cualquier cambio en la base de datos tiene los campos obligatorios
    'correctos

    'FALTA POR METER LA VALIDACIÓN DEL DNI

    Private Sub botonEnabled(sender As Object, e As EventArgs) Handles tbDni.Validated, tbNombre.Validated, tbApellido1.Validated

        If (valida.validarPalabra(tbNombre.Text) And valida.validarPalabra(tbApellido1.Text)) Then
            bAceptar.Enabled = True
        Else
            bAceptar.Enabled = False
        End If

    End Sub



    'Evento que comrpueba que el dni tiene el formato correcto

    'FALTA POR METER LA VALIDACIÓN DEL DNI

    Private Sub tbDni_Validated(sender As Object, e As EventArgs) Handles tbDni.Validated

    End Sub


    'Evento que comprueba que el TextBox del nombre del cliente es válido, en el caso de que no lo sea o esté
    'vacio mostrará el ErrorProvieder que orientará al usuario
    Private Sub tbNombre_Validated(sender As Object, e As EventArgs) Handles tbNombre.Validated

        If (valida.validarPalabra(tbNombre.Text)) Then
            epNombre.SetError(Me.tbNombre, String.Empty)
            tbNombre.Text = tbNombre.Text.Trim
        Else
            epNombre.SetError(Me.tbNombre, "El campo está vacío o hay carácteres no admitidos")
        End If

    End Sub


    'Evento que comprueba que el TextBox del primer apellido del cliente es válido, en el caso de que no lo sea o esté
    'vacio mostrará el ErrorProvieder que orientará al usuario
    Private Sub tbApellido1_Validated(sender As Object, e As EventArgs) Handles tbApellido1.Validated

        If (valida.validarPalabra(tbApellido1.Text)) Then
            epApellido1.SetError(tbApellido1, String.Empty)
            tbApellido1.Text = tbApellido1.Text.Trim
        Else
            epApellido1.SetError(tbApellido1, "El campo está vacío o hay carácteres no admitidos")
        End If

    End Sub


    'Evento que comprueba que el TextBox del segundo apellido del cliente es válido y si no es así muestra
    'al usuario el ErrorProvieder que le orientará. Admite que el campo esté vacio
    'debido a que no es necesario este dato para crear cliente
    Private Sub tbApellido2_Validated(sender As Object, e As EventArgs) Handles tbApellido2.Validated

        If (valida.validarPalabra(tbApellido2.Text)) Then
            epApellido2.SetError(tbApellido2, String.Empty)
            tbApellido2.Text = tbApellido2.Text.Trim
        ElseIf (tbApellido2.Text.Trim.Equals("")) Then
            epApellido2.SetError(tbApellido2, String.Empty)
            tbApellido2.Text = ""
        Else
            epApellido2.SetError(tbApellido2, "Hay carácteres no admitidos")
        End If

    End Sub


    'Evento que comprueba que el TextBox del teléfono del cliente es válido y si no es así muestra
    'al usuario el ErrorProvieder que le orientará. Admite que el campo esté vacio
    'debido a que no es necesario este dato para crear cliente
    Private Sub tbTelefono_Validated(sender As Object, e As EventArgs) Handles tbTelefono.Validated

        If (valida.validarTelefono(tbTelefono.Text)) Then
            epTelefono.SetError(tbTelefono, String.Empty)
        ElseIf (tbTelefono.Text.Trim.Equals("")) Then
            epTelefono.SetError(tbTelefono, String.Empty)
            tbTelefono.Text = ""
        Else
            epTelefono.SetError(tbTelefono, "No es un número de teléfono válido")
        End If

    End Sub


    'Evento que comprueba que el TextBox del email del cliente es válido y si no es así muestra
    'al usuario el ErrorProvieder que le orientará. Admite que el campo esté vacio
    'debido a que no es necesario este dato para crear cliente
    Private Sub tbEmail_Validated(sender As Object, e As EventArgs) Handles tbEmail.Validated

        If (valida.validarMail(tbEmail.Text)) Then
            epEmail.SetError(tbEmail, String.Empty)
        ElseIf (tbEmail.Text.Trim.Equals("")) Then
            epEmail.SetError(tbEmail, String.Empty)
            tbEmail.Text = ""
        Else
            epEmail.SetError(tbTelefono, "No es una dirección de correo electrónico válida")
        End If


    End Sub


    'Evento del botón bLimpiar que deja en blanco todos los campos del formulario
    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click

        limpiarCampos()

    End Sub


    'Evento pensado para volver a poner el en su forma original
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click

        limpiarCampos()

        tbDni.Enabled = False
        tbNombre.Enabled = False
        tbApellido1.Enabled = False
        tbApellido2.Enabled = False
        tbTelefono.Enabled = False
        tbEmail.Enabled = False

        bAceptar.Visible = False
        bCancelar.Visible = False

    End Sub

    'Se crea el metodo para pasar los datos seleccionados del datagridview a los campos.
    Public Sub sacarDatos()
        tbId.Text = dgvClientes.CurrentRow.Cells.Item(0).Value
        tbDni.Text = dgvClientes.CurrentRow.Cells.Item(1).Value
        tbNombre.Text = dgvClientes.CurrentRow.Cells.Item(2).Value
        tbApellido1.Text = dgvClientes.CurrentRow.Cells.Item(3).Value
        tbApellido2.Text = dgvClientes.CurrentRow.Cells.Item(4).Value
        tbTelefono.Text = dgvClientes.CurrentRow.Cells.Item(5).Value
        tbEmail.Text = dgvClientes.CurrentRow.Cells.Item(7).Value
        tbFecha.Text = dgvClientes.CurrentRow.Cells.Item(6).Value
    End Sub

    'Método que limpia todos los TextBox del formulario
    Public Sub limpiarCampos()

        tbId.Clear()
        tbDni.Clear()
        tbNombre.Clear()
        tbApellido1.Clear()
        tbApellido2.Clear()
        tbTelefono.Clear()
        tbEmail.Clear()
        tbFecha.Clear()

    End Sub

    'Metodo para recargar la tabla cada vez que se haga algún tipo de modificiacion en la misma.
    Public Sub cargarDatos()

        'otra forma a ver si asi no hay problemas.
        'con el adapter se llena el dataset.
        adapter.Fill(dataSet, "clientes")

        'despues se añade los datos al datagridview.
        dgvClientes.DataSource = dataSet
        dgvClientes.DataMember = "clientes"
    End Sub


End Class