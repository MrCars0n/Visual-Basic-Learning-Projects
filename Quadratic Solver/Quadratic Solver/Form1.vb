Public Class Form1

    Private Sub NUPxsq_ValueChanged(sender As Object, e As EventArgs) Handles NUPa.ValueChanged
        a.Text = NUPa.Value
    End Sub

    Private Sub NUPx_ValueChanged(sender As Object, e As EventArgs) Handles NUPb.ValueChanged
        b.Text = NUPb.Value
    End Sub

    Private Sub NUPnum_ValueChanged(sender As Object, e As EventArgs) Handles NUPc.ValueChanged
        c.Text = NUPc.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Lx1.Text = (-Val(b.Text) + ((Val(b.Text) ^ 2) - (4 * Val(a.Text) * Val(c.Text))) ^ (1 / 2)) / (2 * Val(a.Text))
        Lx2.Text = (-Val(b.Text) - ((Val(b.Text) ^ 2) - (4 * Val(a.Text) * Val(c.Text))) ^ (1 / 2)) / (2 * Val(a.Text))
    End Sub
End Class
