Public Class Form1
    Dim dx, dy As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Visible = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            dy = -5
            Label1.Text = "UP"
        End If
        If e.KeyCode = Keys.Down Then
            dy = 5
            Label1.Text = "DOWN"
        End If
        If e.KeyCode = Keys.Left Then
            dx = -5
            Label1.Text = "LEFT"
        End If
        If e.KeyCode = Keys.Right Then
            dx = 5
            Label1.Text = "RIGHT"
        End If
        Form2.Left += dx
        Form2.Top += dy
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        dx = 0
        dy = 0
    End Sub
End Class
