Public Class Cliente

    Dim id As Integer
    Dim dni As String
    Dim nombre As String
    Dim apellidos As String
    Dim telefono As String
    Dim email As String
    Dim direccion As String

    Public Sub New(ByVal id As Integer, ByVal dni As String, ByVal nombre As String, ByVal apellidos As String)
        Me.id = id
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
    End Sub

    Public Sub New(ByVal id As Integer, ByVal dni As String, ByVal nombre As String, ByVal apellidos As String, ByVal telefono As String, ByVal email As String, ByVal direccion As String)
        Me.id = id
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.telefono = telefono
        Me.email = email
        Me.direccion = direccion
    End Sub


    Public Sub New(ByVal id As Integer, ByVal dni As String, ByVal nombre As String, ByVal apellidos As String, ByVal telefono As String, ByVal email As String)
        Me.id = id
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.telefono = telefono
        Me.email = email
    End Sub


    Public Function getId() As Long

        Return id

    End Function


    Public Sub setDni(ByVal dni As String)

        Me.dni = dni

    End Sub


    Public Function getDni() As String

        Return dni

    End Function


    Public Sub setNombre(ByVal nombre As String)

        Me.nombre = nombre

    End Sub


    Public Function getNombre() As String

        Return nombre

    End Function


    Public Sub setApellidos(ByVal apellidos As String)

        Me.apellidos = apellidos

    End Sub


    Public Function getApellidos() As String

        Return apellidos

    End Function


    Public Sub setTelefono(ByVal telefono As String)

        Me.telefono = telefono

    End Sub


    Public Function getTelefono() As String

        Return telefono

    End Function


    Public Sub setEmail(ByVal email As String)

        Me.email = email

    End Sub


    Public Function getEmail() As String

        Return email

    End Function


    Public Sub setDireccion(ByVal direccion As String)

        Me.direccion = direccion

    End Sub


    Public Function getDireccion() As String

        Return direccion

    End Function


End Class
