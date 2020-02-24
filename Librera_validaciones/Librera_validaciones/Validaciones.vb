Imports System.Text.RegularExpressions

Public Class Validaciones
    'clase donde se encuentran todos los metodos para validar campos

    'valida todo tipo de palabras que no contengan numeros. se utiliza expresiones regulares para ello 
    Public Function validarPalabra(pal As String) As Boolean
        'se utiliza la clase regex y el metodo ismatch que devuelve un boolean
        Return Regex.IsMatch(pal, "^([a-zñáéíóú]+[\s]*)+$")
    End Function

    'valida números de telefono (fijos y movil), se utiliza expresiones regulares
    Public Function validarTelefono(num As String) As Boolean
        'se utiliza la clase regex y el metodo ismatch que devuelve un boolean
        Return Regex.IsMatch(num, "^[9|6]{1}([\d]{2}[-]*){3}[\d]{2}$")
    End Function

    'valida direcciones de email.
    Public Function validarMail(ByVal mail As String) As Boolean
        ' retorna true o false 
        'se utiliza la clase regex y el metodo ismatch que devuelve un boolean
        Return Regex.IsMatch(mail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function


    'validar un numero, que no contenga ningun tipo de caracter o caracter especial.
    Public Function validarNumero(num As String) As Boolean
        'se utiliza la clase regex y el metodo ismatch que devuelve un boolean
        Return Regex.IsMatch(num, "^([0-9]*)$")
    End Function

    'se añade la letra necesaria al nif, no hace falta incluirla cuando se añada el DNI
    Public Function letraNif(ByVal dni As Integer) As Char
        Dim x2 As Integer
        Dim y As Integer
        Dim nletra As Integer
        Dim letra As Char
        x2 = (dni / 23)
        y = (x2 * 23)
        nletra = dni - y
        Dim tab() As Char = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "O", "H", "L", "C", "K", "E", "G", "V"}
        letra = tab(nletra)

        Return letra
    End Function
End Class
