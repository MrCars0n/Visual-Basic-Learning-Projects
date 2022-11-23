Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
        Form3.Show()
        Form2.Top += Me.Height
        Form3.Top += Me.Height + Form2.Height
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Height += 50
        Form2.Width += 50
        Form2.Left -= 25
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Height += 50
        Form3.Width += 50
        Form3.Left -= 25
    End Sub
End Class
