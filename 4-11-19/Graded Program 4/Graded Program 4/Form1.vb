Public Class Form1
    Public count As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        count += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button1.Text = count
        Form2.Button1.Text = count
        Form3.Button1.Text = count
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Visible = True
        Form3.Visible = True
        count = 0
        Form2.Top += Me.Height
        Form3.Top += Me.Height + Form2.Height
    End Sub
End Class
