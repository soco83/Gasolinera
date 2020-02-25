Imports System.Data.SqlClient

Public Class Gestion_db
    'En esta clase se realiza todo los necesario para gestionar los datos de la base de datos.




    'Se crea la conexion con la base de datos.
    Public con As New SqlConnection()

    Sub New(con As SqlConnection)
        Me.con = con

    End Sub
    'se crea el dataset para guardar en memoria las busquedas de las querys.

    Public dataSet As New DataSet


    'se crea el metodo para registrar una direccion. se pasa por parametro una array de string para guardar los datos necesarios

    Public Function guardarDireccion(datos() As String) As Integer
        'se crea la variable estatica para el id y se le suma 1 antes de realizar el registro
        Dim id As Integer
        Dim comandoId As New SqlCommand("select count(*) from empleados", con)


        'se abre la conexion
        con.Open()


        id = Val(comandoId.ExecuteScalar) + 1


        Dim ordenDb As String = "insert into direccion values (@id,@tipo,@nombre,@numero,@piso,@letra,@cp,@ciudad,@provincia)"
        'se crea el comando a utilizar para guardar el registro
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
        Dim id As Integer
        Dim comandoId As New SqlCommand("select count(*) from empleados", con)


        'se abre la conexion
        con.Open()


        id = Val(comandoId.ExecuteScalar) + 1

        Dim ordenDb As String = "insert into contacto values (@id,@nombre,@apellido1,@apellido2,@telefono)"

        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@nombre", datos(0))
        comando.Parameters.AddWithValue("@apellido1", datos(1))
        comando.Parameters.AddWithValue("@apellido2", datos(2))
        comando.Parameters.AddWithValue("@telefono", datos(3))

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
        Dim id As Integer
        Dim comandoId As New SqlCommand("select count(*) from empleados", con)


        'se abre la conexion
        con.Open()


        id = Val(comandoId.ExecuteScalar) + 1

        Dim ordenDb As String = "insert into empleados values (@id,@dni,@contraseña,@nombre,@apellido1,@apellido2,@telefono,@email,@direccion,@rol)"
        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@dni", datos(0))
        comando.Parameters.AddWithValue("@contraseña", datos(1))
        comando.Parameters.AddWithValue("@nombre", datos(2))
        comando.Parameters.AddWithValue("@apellido1", datos(3))
        comando.Parameters.AddWithValue("@apellido2", datos(4))
        comando.Parameters.AddWithValue("@telefono", datos(5))
        comando.Parameters.AddWithValue("@email", datos(6))
        comando.Parameters.AddWithValue("@direccion", guardarDireccion(direccion))
        comando.Parameters.AddWithValue("@rol", rol)


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
        Dim id As Integer
        Dim comandoId As New SqlCommand("select count(*) from proveedores", con)


        'se abre la conexion
        con.Open()


        id = Val(comandoId.ExecuteScalar) + 1

        Dim ordenDb As String = "insert into proveedores values(@id,@nif,@nombre,@contacto,@direccion,@email)"

        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro

        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@nif", datos(0))
        comando.Parameters.AddWithValue("@razon", datos(1))
        comando.Parameters.AddWithValue("@nombre", datos(2))
        comando.Parameters.AddWithValue("@contacto", guardarContacto(contacto))
        comando.Parameters.AddWithValue("@direccion", guardarDireccion(direccion))
        comando.Parameters.AddWithValue("@email", datos(3))




        Try
            'se ejecuta la query
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        'se cierra la conexion
        con.Close()
    End Sub

    Public Function calcularID() As Integer

        Dim id As Integer
        Dim ordenDb As String = "Select count(*) from clientes"


    End Function


    '------------------------------------------------------------------------------------------------------------------------------
    'Se crea el metodo para guardar clientes en la base de datos.
    Public Sub guardarCliente(datos() As String)
        'se crea la variable estatica para el id y se le suma 1 antes de realizar el registro
        Dim id As Integer
        Dim comandoId As New SqlCommand("select count(*) from clientes", con)


        'se abre la conexion
        con.Open()


        id = Val(comandoId.ExecuteScalar) + 1

        Dim ordenDb As String = "insert into clientes values(@id,@dni,@nombre,@apellido1,@apellido2,@telefono,@fecha,@email)"

        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro

        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@dni", datos(0))
        comando.Parameters.AddWithValue("@nombre", datos(1))
        comando.Parameters.AddWithValue("@apellido1", datos(2))
        comando.Parameters.AddWithValue("@apellido2", datos(3))
        comando.Parameters.AddWithValue("@telefono", datos(4))
        comando.Parameters.AddWithValue("@fecha", datos(5))
        comando.Parameters.AddWithValue("@email", datos(6))



        Try
            'se ejecuta la query
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        'se cierra la conexion
        con.Close()

    End Sub

    '----------------------------------------------------------------------------------------------------------------

    'en este apartado se realizaran  las modificaciones de la base de datos.


    'Este metodo modifica la direccion se pasa por parametro los datos a modificar y el id del registro que se quiera modificar.
    Public Function modificarDireccion(datos() As String, id As Integer) As Integer

        'se crea la sentencia para modificar el registro
        Dim ordenDb As String = "update direccion set  tipo=@tipo, nombre=@nombre, numero=@numero, piso=@piso, letra=@letra, cp=@cp, ciudad=@ciudad, provincia=@provincia where id_d=@id"
        'se crea el comando a utilizar para guardar el registro
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


    '-------------------------------------------------------------------------------------------------------------------------------

    'Se crea el metodo para modificar los contactos de la base de datos
    Private Function modificarContacto(datos() As String, id As Integer) As Integer



        Dim ordenDb As String = "update contacto set nombre=@nombre, apellido1=@apellido1, apellido2=@apellido2, telefono=@telefono where id_c=@id"

        'se crea el comando a utilizar para guardar el registro
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

    '---------------------------------------------------------------------------------------------------------------------------------------------

    'Se crea un metodo para modificar los empleados. se pasa por parametro los datos para la tabla, los id  y el rol. 
    Public Sub modificarEmpleado(datos() As String, id As Integer, direccion() As String, id_d As Integer, rol As Integer)

        Dim ordenDb As String = "update empleados set dni=@dni, contraseña=@contraseña, nombre=@nombre, apellido1=@apellido1, apellido2=@apellido2, telefono=@telefono, email=@email, direccion=@direccion, rol=@rol where id_e=@id"
        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro
        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@dni", datos(0))
        comando.Parameters.AddWithValue("@contraseña", datos(1))
        comando.Parameters.AddWithValue("@nombre", datos(2))
        comando.Parameters.AddWithValue("@apellido1", datos(3))
        comando.Parameters.AddWithValue("@apellido2", datos(4))
        comando.Parameters.AddWithValue("@telefono", datos(5))
        comando.Parameters.AddWithValue("@email", datos(6))
        comando.Parameters.AddWithValue("@direccion", modificarDireccion(direccion, id_d))
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


    '---------------------------------------------------------------------------------------------------------------------------------

    'Se crea el metodo para modificar proveedores. se pasa por parametro los datos y los id.

    Public Sub modificarProveedor(id As Integer, datos() As String, id_d As Integer, direccion() As String, id_c As Integer, contacto() As String)

        'Se realiza la sentencia para modificar la tabla proveedores.

        Dim ordenDb As String = "update proveedores set nif=@nif, nombre=@nombre, contacto=@contacto, direccion=@direccion, email=@email where id_p=id"

        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro

        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@nif", datos(0))
        comando.Parameters.AddWithValue("@razon", datos(1))
        comando.Parameters.AddWithValue("@nombre", datos(2))
        comando.Parameters.AddWithValue("@contacto", modificarContacto(contacto, id_c))
        comando.Parameters.AddWithValue("@direccion", modificarDireccion(direccion, id_d))
        comando.Parameters.AddWithValue("@email", datos(3))

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

    '---------------------------------------------------------------------------------------------------------------------

    'Se crea el metodo para modificar clientes.  se pasa por parametros los datos y el id.
    Public Sub modificarCliente(datos() As String, id As Integer)
        'Se realiza la sentencia para modificar el cliente
        Dim ordenDb As String = "update clientes set din=@dni, nombre=@nombre, apellido1=@apellido1, apellido2=@apellido, telefono=@telefono, fecha=@fecha, email=@email where id_c=@id"

        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro

        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@dni", datos(0))
        comando.Parameters.AddWithValue("@nombre", datos(1))
        comando.Parameters.AddWithValue("@apellido1", datos(2))
        comando.Parameters.AddWithValue("@apellido2", datos(3))
        comando.Parameters.AddWithValue("@telefono", datos(4))
        comando.Parameters.AddWithValue("@fecha", datos(5))
        comando.Parameters.AddWithValue("email", datos(6))
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


    '------------------------------------------------------------------------------------------------------------------------------------------

    'Se crea el metodo para modificar los articulos. Se pasa por parametros los datos y el id
    Public Sub modificarArticulo(datos() As String, id As Integer)
        'se realiza la sentencia para poder modificar los datos
        Dim ordenDb As String = "update articulos(nombre,stock,precio) set nombre=@nombre, stock=@stock, precio=@precio"

        'se crea el comando a utilizar para guardar el registro
        Dim comando As New SqlCommand(ordenDb, con)

        'Se añaden los datos por el array que se pasa por parametro

        comando.Parameters.AddWithValue("@id", id)
        comando.Parameters.AddWithValue("@nombre", datos(0))
        comando.Parameters.AddWithValue("@stock", datos(1))
        comando.Parameters.AddWithValue("@precio", datos(2))

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

    '------------------------------------------------------------------------------------------------------------------------------

    'Se crean los métodos de para eliminar registros.

    'Se crea el metodo para eliminar la direccion. se pasa por parametro el id del registro.
    Private Sub eliminarDireccion(id As Integer)
        'Se realiza la sentencia apra eliminar un registro.
        Dim ordenDb As String = "delete from direccion where id_d=@id"

        'Se crea el comando a utilizar
        Dim comando As New SqlCommand(ordenDb, con)

        comando.Parameters.AddWithValue("@id", id)





        con.Open()
        comando.ExecuteNonQuery()
        con.Close()

    End Sub

    'Se crea el metodo para eliminar un registro de contacto. Se pasa por parametro el id dle registro.
    Private Sub eliminarContacto(id As Integer)
        'Se realiza la sentencia para eliminar un registro.
        Dim ordenDb As String = "delete from contacto where id_c=@id"


        Dim comando As New SqlCommand(ordenDb, con)

        comando.Parameters.AddWithValue("@id", id)





        con.Open()
        comando.ExecuteNonQuery()
        con.Close()

    End Sub


    '--------------------------------------------------------------------------------------------------------------------------
    'Se crea el metodo para para eliminar empleados. Se pasa por parametro los id.

    Public Sub eliminarEmpleado(id As Integer, id_d As Integer)
        'Se elimina primero la direccion del empleado.
        eliminarDireccion(id_d)

        'se realiza la sentencia para eliminar un registro.
        Dim ordenDb As String = "delete from empleados where id=@id"

        'Se crean el comando para borrar el registro de empleados.

        Dim comando As New SqlCommand(ordenDb, con)

        comando.Parameters.AddWithValue("@id", id)


        Dim res As Integer = MsgBox("El registro se borrará. ¿desea borrarlo?", 36, "Borrar registro")

        If res = 6 Then
            con.Open()
            comando.ExecuteNonQuery()
            con.Close()
        End If

    End Sub

    '------------------------------------------------------------------------------------------------------------

    'Se crea el metodo para borrar clientes. Se pasa por parametro los id.
    Public Sub eliminarProveedores(id As Integer, id_d As Integer, id_c As Integer)
        'se elimina primero el contacto y la direccion.
        eliminarDireccion(id_d)
        eliminarContacto(id_c)

        'Se realiza la sentencia para eliminar el registro
        Dim ordenDb As String = "delete from proveedores where id=@id"

        'Se crean el comando para borrar el registro de empleados.

        Dim comando As New SqlCommand(ordenDb, con)

        comando.Parameters.AddWithValue("@id", id)


        Dim res As Integer = MsgBox("El registro se borrará. ¿desea borrarlo?", 36, "Borrar registro")

        If res = 6 Then
            con.Open()
            comando.ExecuteNonQuery()
            con.Close()
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------

    'Se crea el metodo para borrar clientes. Se pasa por parametro el id

    Public Sub eliminarCliente(id As Integer)
        'Se realiza la sentencia para eliminar el registro
        Dim ordenDb As String = "delete from clientes where id=@id"

        'Se crean el comando para borrar el registro de empleados.

        Dim comando As New SqlCommand(ordenDb, con)

        comando.Parameters.AddWithValue("@id", id)


        Dim res As Integer = MsgBox("El registro se borrará. ¿desea borrarlo?", 36, "Borrar registro")

        If res = 6 Then
            con.Open()
            comando.ExecuteNonQuery()
            con.Close()
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------
    'Se crean los metodos encargados de las busquedas para cualquier tabla.

    'Se crea el metodo para la busqueda del cliente por id.
    Public Function buscarIdCliente(id As Integer) As DataSet
        'se crea el dataset para guardar los datos de la busqueda.
        Dim dataset As New DataSet
        'Se crea el comando para selecciolnar a través del id.
        Dim comando As New SqlCommand("select * from clientes where id_c=@id", con)
        'Se crea el adaptador para colocar los resultados en el dataset.
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = comando
        comando.Parameters.AddWithValue("@id", id)
        adapter.Fill(dataset, "id")
        Return dataset

    End Function
    'Se crea el metodo para la busqueda del empleado por id.
    Public Function buscarIdEmpleados(id As Integer) As DataSet
        'se crea el dataset para guardar los datos de la busqueda.
        Dim dataset As New DataSet
        'Se crea el comando para selecciolnar a través del id.
        Dim comando As New SqlCommand("select * from empleados where id_e=@id", con)
        'Se crea el adaptador para colocar los resultados en el dataset.
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = comando
        comando.Parameters.AddWithValue("@id", id)
        adapter.Fill(dataset, "id")
        Return dataset

    End Function

    'Se crea el metodo para la busqueda del proveedor por id.
    Public Function buscarIdProveedores(id As Integer) As DataSet
        'se crea el dataset para guardar los datos de la busqueda.
        Dim dataset As New DataSet
        'Se crea el comando para selecciolnar a través del id.
        Dim comando As New SqlCommand("select * from empleados where id_p=@id", con)
        'Se crea el adaptador para colocar los resultados en el dataset.
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = comando
        comando.Parameters.AddWithValue("@id", id)
        adapter.Fill(dataset, "id")
        Return dataset

    End Function

    'Se crea el metodo para la busqueda del articulo por id.
    Public Function buscarIdArticulo(id As Integer) As DataSet
        'se crea el dataset para guardar los datos de la busqueda.
        Dim dataset As New DataSet
        'Se crea el comando para selecciolnar a través del id.
        Dim comando As New SqlCommand("select * from empleados where id_a=@id", con)
        'Se crea el adaptador para colocar los resultados en el dataset.
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = comando
        comando.Parameters.AddWithValue("@id", id)
        adapter.Fill(dataset, "id")
        Return dataset

    End Function

    'Se crea el metodo para la busqueda por nombre.
    Public Function buscarNombre(nombre As String, tabla As String) As DataSet
        'se crea el dataset para guardar los datos de la busqueda.
        Dim dataset As New DataSet
        'Se crea el comando para selecciolnar a través del id.
        Dim comando As New SqlCommand("select * from " & tabla & " where nombre=@nombre", con)
        'Se crea el adaptador para colocar los resultados en el dataset.
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = comando
        comando.Parameters.AddWithValue("@nombre", nombre)
        adapter.Fill(dataset, "id")
        Return dataset

    End Function

    'Se crea el metodo para la busqueda por dni
    Public Function buscarDni(dni As String, tabla As String) As DataSet
        'se crea el dataset para guardar los datos de la busqueda.
        Dim dataset As New DataSet
        'Se crea el comando para selecciolnar a través del id.
        Dim comando As New SqlCommand("select * from " & tabla & " where dni=@dni", con)
        'Se crea el adaptador para colocar los resultados en el dataset.
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = comando
        comando.Parameters.AddWithValue("@dni", dni)
        adapter.Fill(dataset, "id")
        Return dataset

    End Function


End Class
