Public Class Empleado

    Dim id As Integer
    Dim dni As String
    Dim nombre As String
    Dim apellidos As String
    Dim rol As String
    Dim telefono As String
    Dim email As String
    Dim direccion As String

    Public Sub New(ByVal id As Integer, ByVal dni As String, ByVal nombre As String, ByVal apellidos As String, ByVal rol As String)
        Me.id = id
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.rol = rol
    End Sub


    Public Sub New(ByVal id As Integer, ByVal dni As String, ByVal nombre As String, ByVal apellidos As String, ByVal rol As String, ByVal telefono As String, ByVal email As String, ByVal direccion As String)
        Me.id = id
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.rol = rol
        Me.telefono = telefono
        Me.email = email
        Me.direccion = direccion
    End Sub



End Class
