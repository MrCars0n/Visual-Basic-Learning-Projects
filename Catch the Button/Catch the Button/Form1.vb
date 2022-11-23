Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Left = Int(Rnd() * 400)
        Button1.Top = Int(Rnd() * 400)
    End Sub
End Class
