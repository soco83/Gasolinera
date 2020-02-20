Imports System.Data.SqlClient

Public Class gestion_db
    'En esta clase se realiza todo los necesario para gestionar los datos de la base de datos.




    'Se crea la conexion con la base de datos.
    Public con As New SqlConnection("server=localhost\SQLExpress ; database=repsol_db ; Integrated Security = True")

    'se crea el dataset para guardar en memoria las busquedas de las querys.

    Public dataSet As New DataSet


    'se crea el metodo para registrar una direccion. se pasa por parametro una array de string para guardar los datos necesarios

    Public Function guardarDireccion(datos() As String) As Integer
        'se crea la variable estatica para el id y se le suma 1 antes de realizar el registro
        Static id As Integer = 0
        id += id
        Dim ordenDb As String = "insert into direccion values (@id,@tipo,@nombre,@numero,@piso,@letra,@cp,@ciudad,@provincia)"
        'se crea el comando ha utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@tipo", datos(0))
        comando.Parameters.AddWithValue("@nombre", datos(1))
        comando.Parameters.AddWithValue("@numero", datos(2))
        comando.Parameters.AddWithValue("@piso", datos(3))
        comando.Parameters.AddWithValue("@letra", datos(4))
        comando.Parameters.AddWithValue("@cp", datos(5))
        comando.Parameters.AddWithValue("@ciudad", datos(6))
        comando.Parameters.AddWithValue("@provincia", datos(7))

        'se abre la conexion 
        con.Open()
        Try
            'se ejecuta la query 
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)

        End Try
        'se cierra la conexion
        con.Close()
        'se retorna el id para poder pasarselo a las tablas que contengan la foreign key.
        Return id

    End Function

    '-----------------------------------------------------------------------------------------------
    'se crea el metodo para registrar un contacto de los proveedores.
    Private Function guardarContacto(datos() As String) As Integer
        'se crea la variable estatica para el id y se le suma 1 antes de realizar el registro
        Static id As Integer = 0
        id += id

        Dim ordenDb As String = "insert into contacto values (@id,@nombre,@apellido1,@apellido2,@telefono)"

        'se crea el comando ha utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@nombre", datos(0))
        comando.Parameters.AddWithValue("@apellido1", datos(1))
        comando.Parameters.AddWithValue("@apellido2", datos(2))
        comando.Parameters.AddWithValue("@telefono", datos(3))
        'se abre la conexion 
        con.Open()
        Try
            'se ejecuta la query 
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)

        End Try
        'se cierra la conexion
        con.Close()
        'se retorna el id para poder pasarselo a las tablas que contengan la foreign key.
        Return id
    End Function


    '--------------------------------------------------------------------------------------------------------
    'se crea el metodo para registrar un empleado. Se pasa por parametro los datos basicos del empleado, los datos de la direccion, y el indice del combobox para el rol.
    Public Sub guardarEmpleado(datos() As String, direccion() As String, rol As Integer)
        'se crea la variable estatica para el id y se le suma 1 antes de realizar el registro
        Static id As Integer = 0
        id += id

        Dim ordenDb As String = "insert into empleados values (@id,@dni,@nombre,@apellido1,@apellido2,@telefono,@direccion,@rol)"
        'se crea el comando ha utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@dni", datos(0))
        comando.Parameters.AddWithValue("@nombre", datos(1))
        comando.Parameters.AddWithValue("@apellido1", datos(2))
        comando.Parameters.AddWithValue("@apellido2", datos(3))
        comando.Parameters.AddWithValue("@telefono", datos(4))
        comando.Parameters.AddWithValue("@direccion", guardarDireccion(direccion))
        comando.Parameters.AddWithValue("@rol", rol)

        'se abre la conexion
        con.Open()

        Try
            'se ejecuta la query
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        'se cierra la conexion
        con.Close()


    End Sub

    '------------------------------------------------------------------------------------------------
    'se crea el metodo para registrar un proveedor. Se le pasa por parametro una array con los datos básicos y un array para la direccion

    Public Sub guardarProveedor(datos() As String, direccion() As String, contacto() As String)

        'se crea la variable estatica para el id y se le suma 1 antes de realizar el registro
        Static id As Integer = 0
        id += id

        Dim ordenDb As String = "insert into proveedores values(@id,@nombre,@contacto)"

        'se crea el comando ha utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@nombre", datos(0))
        comando.Parameters.AddWithValue("@contacto", guardarContacto(contacto))
        comando.Parameters.AddWithValue("@direccion", guardarDireccion(direccion))

        'se abre la conexion
        con.Open()

        Try
            'se ejecuta la query
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        'se cierra la conexion
        con.Close()
    End Sub




End Class
