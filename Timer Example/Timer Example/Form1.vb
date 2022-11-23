Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1

        If Label1.Text = 0 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Left = Label1.Left + 1

        Me.Top = Me.Top + 1

        If Label1.Left > 1000 Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Opacity = Me.Opacity - 0.01

        If Me.Opacity <= 0 Then
            End
        End If
    End Sub
End Class
