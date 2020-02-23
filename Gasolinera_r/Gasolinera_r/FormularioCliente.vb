Imports Librera_validaciones

Public Class FormularioCliente

    Dim valida As New Validaciones

    'Variable que almacena el tag del botón del formulario que ha sido pulsado(Crear, Modificar, Buscar y Borrar)
    'para saber a que método se debe llamar cuando se pulse el botón aceptar
    Dim botonPulsado As Integer


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lEmail.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tbFecha.TextChanged

    End Sub

    Private Sub FormularioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Repsol_dbDataSet1.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Repsol_dbDataSet1.clientes)

    End Sub


    'Evento del botón bNuevo que dispone para crear clientes
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


    'Evento del botón bAceptar. Según que tipo de operación se haya pulsado antes llamará a un método
    'o a otro usando la variable de control botonPulsado
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click

        Select Case botonPulsado

            Case bNuevo.Tag

                'Se comprueba que no puede estar vacio ninguno de los campos obligatorios
                If (tbDni.Text.Trim.Equals("") Or tbNombre.Text.Trim.Equals("") Or tbApellido1.Text.Trim.Equals("")) Then

                    MsgBox("Asegúrate de rellenar todos los campos obligatorios", MsgBoxStyle.OkOnly, "Campos vacíos")
                ElseIf (Not valida.validarPalabra(tbNombre.Text)) Then

                End If
                Dim datos() As String
                datos(0) = tbDni.Text
                datos(1) = tbNombre.Text
                datos(2) = tbApellido1.Text
                datos(3) = tbApellido2.Text
                datos(4) = tbTelefono.Text
        End Select
    End Sub
End Class