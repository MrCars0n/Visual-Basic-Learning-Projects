Public Class Form1

    Dim dx, dy As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Left = Me.Left + dx
        Me.Top = Me.Top + dy
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            dx = -5
            dy = 0
        End If
        If e.KeyCode = Keys.Right Then
            dx = 5
            dy = 0
        End If
        If e.KeyCode = Keys.Up Then
            dx = 0
            dy = -5
        End If
        If e.KeyCode = Keys.Down Then
            dx = 0
            dy = 5
        End If
    End Sub
End Class
