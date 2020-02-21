Public Class Principal
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lHora.Text = Now.ToLocalTime

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        timer.Start()

    End Sub


End Class