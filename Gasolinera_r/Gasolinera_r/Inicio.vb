Public Class Inicio

    Dim principal As Principal

    Private Sub Inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        lContinuar.Visible = False
        pRegistro.Visible = True
    End Sub



    Private Sub bEntrar_Click(sender As Object, e As EventArgs) Handles bEntrar.Click
        principal = New Principal
        principal.Show()
        Me.Hide()
        tbUsuario.Clear()
        tbPassword.Clear()


    End Sub
End Class
