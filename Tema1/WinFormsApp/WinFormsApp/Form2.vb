Public Class Form2
    Private Sub tiempoDTP_ValueChanged(sender As Object, e As EventArgs) Handles tiempoDTP.ValueChanged
        labelTiempo.Text = tiempoDTP.Value
    End Sub
End Class