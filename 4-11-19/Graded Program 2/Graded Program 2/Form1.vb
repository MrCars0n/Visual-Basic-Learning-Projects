Public Class Form1
    Dim grid(0 To 9, 0 To 9) As Button
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To 9
            For y = 0 To 9

                grid(x, y) = New Button

                grid(x, y).Width = 50
                grid(x, y).Height = 50
                grid(x, y).Left = x * grid(x, y).Width
                grid(x, y).Top = y * grid(x, y).Height
                grid(x, y).BackColor = Color.White
                grid(x, y).Text = Int(Rnd() * 10)

                Me.Controls.Add(grid(x, y))

                AddHandler grid(x, y).Click, AddressOf grid_click
            Next
        Next
    End Sub

    Private Sub grid_click(sender As Object, e As EventArgs)
        Label1.Text = Val(sender.Text) + Val(Label1.Text)
        sender.visible = False
    End Sub
End Class
