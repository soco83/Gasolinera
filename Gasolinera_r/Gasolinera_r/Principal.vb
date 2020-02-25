Public Class Principal

    Dim formularioCliente As New FormularioCliente
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lHora.Text = Now.ToLocalTime

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        timer.Start()

    End Sub

    Private Sub bCerrar_Click(sender As Object, e As EventArgs) Handles bCerrar.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles b6.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles b3.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles bDel.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles bDown.Click

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles bEfectivo.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles bUp.Click

    End Sub

    Private Sub bCliente_Click(sender As Object, e As EventArgs) Handles bCliente.Click
        formularioCliente = New FormularioCliente
        formularioCliente.Show()
        Me.Hide()
    End Sub

    Private Sub bUsuario_Click(sender As Object, e As EventArgs) Handles bUsuario.Click
        Dim formularioEmpleado As New FormularioEmpleado
        formularioEmpleado.Show()
        Me.Hide()

    End Sub
End Class