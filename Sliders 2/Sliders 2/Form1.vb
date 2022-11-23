Public Class Form1
    Private Sub HSr_Scroll(sender As Object, e As ScrollEventArgs) Handles HSr.Scroll
        Lr.Text = HSr.Value
        NUPr.Value = HSr.Value
        Me.BackColor = Color.FromArgb(Lr.Text, Lg.Text, Lb.Text)
    End Sub
    Private Sub HSb_Scroll(sender As Object, e As ScrollEventArgs) Handles HSb.Scroll
        Lb.Text = HSb.Value
        NUPb.Value = HSb.Value
        Me.BackColor = Color.FromArgb(Lr.Text, Lg.Text, Lb.Text)
    End Sub
    Private Sub HSg_Scroll(sender As Object, e As ScrollEventArgs) Handles HSg.Scroll
        Lg.Text = HSg.Value
        NUPg.Value = HSg.Value
        Me.BackColor = Color.FromArgb(Lr.Text, Lg.Text, Lb.Text)
    End Sub

    Private Sub NUPr_ValueChanged(sender As Object, e As EventArgs) Handles NUPr.ValueChanged
        HSr.Value = NUPr.Value
        Lr.Text = HSr.Value
        Me.BackColor = Color.FromArgb(Lr.Text, Lg.Text, Lb.Text)
    End Sub

    Private Sub NUPb_ValueChanged(sender As Object, e As EventArgs) Handles NUPb.ValueChanged
        HSb.Value = NUPb.Value
        Lb.Text = HSb.Value
        Me.BackColor = Color.FromArgb(Lr.Text, Lg.Text, Lb.Text)
    End Sub

    Private Sub NUPg_ValueChanged(sender As Object, e As EventArgs) Handles NUPg.ValueChanged
        HSg.Value = NUPg.Value
        Lg.Text = HSg.Value
        Me.BackColor = Color.FromArgb(Lr.Text, Lg.Text, Lb.Text)
    End Sub
End Class
