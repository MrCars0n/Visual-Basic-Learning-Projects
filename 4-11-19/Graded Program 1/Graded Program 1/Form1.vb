Public Class Form1
    Dim grid(0 To 9, 0 To 9) As Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To 9
            For y = 0 To 9
                grid(x, y) = New Label

                grid(x, y).Width = 50
                grid(x, y).Height = 50
                grid(x, y).BorderStyle = BorderStyle.FixedSingle
                grid(x, y).Left = x * grid(x, y).Width
                grid(x, y).Top = y * grid(x, y).Height

                grid(x, y).BackColor = Color.White

                Me.Controls.Add(grid(x, y))
                AddHandler grid(x, y).MouseEnter, AddressOf label_enter
            Next
        Next
    End Sub

    Private Sub label_enter(sender As Object, e As EventArgs)
        sender.BackColor = Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))
    End Sub
End Class
