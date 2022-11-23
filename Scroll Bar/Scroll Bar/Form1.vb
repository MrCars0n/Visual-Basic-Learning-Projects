Public Class Form1

    ' To allow you to scroll up to the maximum you want you must add (largechange - 1) to the maximim property

    ' In this example, the largechange is 10, we want to go to 100.
    '  So our maximim is set to 100 + 10 - 1 = 109

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = HScrollBar1.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HScrollBar1.Value = HScrollBar1.Value + 1

        If HScrollBar1.Value = 100 Then
            Timer1.Enabled = False
        End If

        ' We have to put in the actual max rather than the maximum because otherwise it will go to 109
    End Sub

    Private Sub HScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar1.ValueChanged
        Label1.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        PictureBox1.Width = HScrollBar2.Value
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        PictureBox1.Height = VScrollBar1.Value
    End Sub
End Class
