Imports System.Data.SqlClient
Imports Librera_validaciones
Public Class FormularioEmpleado


    Dim con As New SqlConnection("server=localhost\SQLExpress ; database=repsol_db ; Integrated Security = true")
    Dim valida As New Validaciones
    Dim gestionDB As New Gestion_db(con)


    'Se crea un adaptador para el dataset.
    Dim adapter As New SqlDataAdapter("select e.*,d.tipo,d.nombre,d.numero,d.piso,d.letra,d.cp,d.ciudad,d.provincia from empleados e inner join direccion d on e.direccion=d.cod_d", con)


    'Se crea el dataset para  poder guardar todo lo necesario de la base de datos. 
    Dim dataSet As New DataSet


    'Variable que almacena el tag del botón del formulario que ha sido pulsado(Crear, Modificar, Buscar y Borrar)
    'para saber a que método se debe llamar cuando se pulse el botón aceptar
    Dim botonPulsado As Integer

    Private Sub FormularioEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'se llama al metodo cargarDatos
        cargarDatos()
        bConfirmar.Visible = False
        bCancelar.Visible = False



    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bCrear.Click

        botonPulsado = bCrear.Tag

        tbDni.Enabled = True
        tbContrasenna.Enabled = True
        tbConfirmContrasenna.Enabled = True
        tbApellido1.Enabled = True
        tbApellido2.Enabled = True
        tbTelefono.Enabled = True
        tbEmail.Enabled = True
        cbRol.Enabled = True
        cbTipo.Enabled = True
        tbNombreCalle.Enabled = True
        tbNumero.Enabled = True
        tbPiso.Enabled = True
        tbLetra.Enabled = True
        tbCp.Enabled = True
        tbCiudad.Enabled = True
        tbProvincia.Enabled = True


        bConfirmar.Visible = True
        bCancelar.Visible = True

    End Sub


    Public Sub cargarDatos()

        'Se limpia el dataset para no repetir registros a la hora de mostrar los datos
        dataSet.Clear()

        'otra forma a ver si asi no hay problemas.
        'con el adapter se llena el dataset.
        adapter.Fill(dataSet, "empleados")

        'despues se añade los datos al datagridview.
        dgvEmpleado.DataSource = dataSet
        dgvEmpleado.DataMember = "empleados"

    End Sub
    Public Sub limpiarCampos()

        tbId.Clear()
        tbDni.Clear()
        tbConfirmContrasenna.Clear()
        tbApellido1.Clear()
        tbApellido2.Clear()
        tbTelefono.Clear()
        tbEmail.Clear()
        cbRol.SelectedIndex = -1
        cbTipo.SelectedIndex = -1
        tbNombreCalle.Clear()
        tbNumero.Clear()
        tbPiso.Clear()
        tbPiso.Clear()
        tbCp.Clear()
        tbCiudad.Clear()
        tbProvincia.Clear()



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

    Private Sub tbNombreCalle_Validated(sender As Object, e As EventArgs) Handles tbNombreCalle.Validated

        If (valida.validarPalabra(tbNombreCalle.Text)) Then
            epNombreCallle.SetError(tbNombreCalle, String.Empty)
        ElseIf (tbNombreCalle.Text.Trim.Equals("")) Then
            epNombreCallle.SetError(tbNombreCalle, String.Empty)
            tbNombreCalle.Text = ""
        End If
        epNombreCallle.SetError(tbTelefono, "No es un nombre de correo electrónico válida")
    End Sub

    Private Sub tbNumero_Validated(sender As Object, e As EventArgs) Handles tbNumero.Validated

        If (valida.validarNumero(tbNumero.Text)) Then
            epNumero.SetError(tbNumero, String.Empty)
        ElseIf (tbNumero.Text.Trim.Equals("")) Then
            epNumero.SetError(tbNumero, String.Empty)
            tbNumero.Text = ""
        End If
        epNombreCallle.SetError(tbTelefono, "No es un numero de correo electrónico válida")
    End Sub






    'Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click

    '    limpiarCampos()

    '    tbDni.Enabled = False
    '    tbNombre.Enabled = False
    '    tbApellido1.Enabled = False
    '    tbApellido2.Enabled = False
    '    tbTelefono.Enabled = False
    '    tbEmail.Enabled = False
    '    tbNombreCalle.Enabled = False
    '    tbNumero.Enabled = False
    '    tbPiso.Enabled = False
    '    tbPiso.Enabled = False
    '    tbCp.Enabled = False
    '    tbCiudad.Enabled = False
    '    tbProvincia.Enabled = False
    '    cbRol.Enabled = False
    '    cbTipo.Enabled = False
    '    bAceptar.Visible = False
    '    bCancelar.Visible = False

    '    epDni.SetError(tbDni, String.Empty)
    '    epNombre.SetError(tbNombre, String.Empty)
    '    epApellido1.SetError(tbApellido1, String.Empty)
    '    epApellido2.SetError(tbApellido2, String.Empty)
    '    epTelefono.SetError(tbTelefono, String.Empty)
    '    epEmail.SetError(tbEmail, String.Empty)

    'End Sub
End Class