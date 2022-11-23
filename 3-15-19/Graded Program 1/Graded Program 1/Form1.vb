Public Class Form1
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        F.Text = HScrollBar1.Value
        C.Text = (HScrollBar1.Value - 32) * 5 / 9
    End Sub
End Class
