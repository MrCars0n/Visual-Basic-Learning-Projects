Public Class Form1

    Dim dx As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label1.Bounds.IntersectsWith(Label2.Bounds) Then
            Label1.Left = Label1.Left - 376
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            Label1.Left = Label1.Left + 10
        End If
    End Sub
End Class
