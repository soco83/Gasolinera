Public Class Proveedor

    Dim id As Integer
    Dim nif As String
    Dim razonSocial As String
    Dim nombre As String
    Dim direccion As String
    Dim telefono As String
    Dim email As String


    Public Sub New(ByVal id As Integer, ByVal nif As String, ByVal razonSocial As String, ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String)
        Me.id = id
        Me.nif = nif
        Me.razonSocial = razonSocial
        Me.nombre = nombre
        Me.direccion = direccion
        Me.telefono = telefono
        Me.email = email
    End Sub


    Public Function getId() As Integer

        Return id

    End Function


    Public Sub setNif(ByVal nif As String)

        Me.nif = nif

    End Sub


    Public Function getNif() As String

        Return nif

    End Function


    Public Sub setRazonSocial(ByVal razonSocial As String)

        Me.razonSocial = razonSocial

    End Sub


    Public Function getRazonSocial() As String

        Return razonSocial

    End Function


    Public Sub setNombre(ByVal nombre As String)

        Me.nombre = nombre

    End Sub


    Public Function getNombre() As Long

        Return nombre

    End Function


    Public Sub setDireccion(ByVal direccion As String)

        Me.direccion = direccion

    End Sub


    Public Function getDireccion() As String

        Return direccion

    End Function

    Public Sub setTelefono(ByVal telefono As String)

        Me.telefono = telefono

    End Sub


    Public Function getTelefono() As Long

        Return telefono

    End Function

    Public Sub setEmail(ByVal email As String)

        Me.email = email

    End Sub


    Public Function getEmail() As Long

        Return email

    End Function


End Class
