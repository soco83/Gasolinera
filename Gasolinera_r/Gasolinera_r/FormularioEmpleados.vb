Imports Librera_validaciones
Imports System.Data.SqlClient

Public Class FormularioEmpleado


    Dim con As New SqlConnection("server=localhost\SQLExpress01 ; database=repsol_db ; Integrated Security = true")
    Dim valida As New Validaciones
    Dim gestionDB As New Gestion_db(con)


    'Se crea un adaptador para el dataset.
    Dim adapter As New SqlDataAdapter("select * from empleados", con)


    'Se crea el dataset para  poder guardar todo lo necesario de la base de datos. 
    Dim dataSet As New DataSet


    'Variable que almacena el tag del botón del formulario que ha sido pulsado(Crear, Modificar, Buscar y Borrar)
    'para saber a que método se debe llamar cuando se pulse el botón aceptar
    Dim botonPulsado As Integer

    Private Sub FormularioEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'se llama al metodo cargarDatos
        cargarDatos()

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
        tbNombre.Clear()
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