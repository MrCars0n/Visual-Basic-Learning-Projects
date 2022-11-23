Public Class Form1

    Dim counter As Integer = 25
    Dim grid(0 To 9, 0 To 9) As Button
    Dim counterLabel As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To 9
            For y = 0 To 9
                grid(x, y) = New Button

                grid(x, y).Width = 100
                grid(x, y).Height = 100

                grid(x, y).Left = x * grid(x, y).Width
                grid(x, y).Top = y * grid(x, y).Height
                Me.Controls.Add(grid(x, y))
                AddHandler grid(x, y).Click, AddressOf gridmouseclick
                If x = 9 And y = 9 Then
                    counterLabel = New Label
                    counterLabel.Text = counter
                    counterLabel.Width = 100
                    counterLabel.Height = 100
                    counterLabel.Left = (x + 1) * grid(x, y).Width + 5
                    counterLabel.BackColor = Color.White
                    counterLabel.TextAlign = ContentAlignment.MiddleCenter
                    Me.Controls.Add(counterLabel)
                End If
            Next
        Next
    End Sub
    Private Sub gridmouseclick(sender As Object, e As EventArgs)
        counter -= 1
        counterLabel.Text = counter
        If counter <= 0 Then
            MsgBox("GAME OVER")
            End
        End If
    End Sub
End Class
