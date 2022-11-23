Public Class Form1
    Dim x As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 5
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left += x

        If Label1.Left > (Me.Width - Label1.Width) Or Label1.Left < 0 Then
            x = -x
            If Me.BackColor = Color.White Then
                Me.BackColor = Color.Black
            ElseIf Me.BackColor = Color.Black Then
                Me.BackColor = Color.White
            End If

            If Label1.BackColor = Color.White Then
                Label1.BackColor = Color.Black
            ElseIf label1.BackColor = Color.Black Then
                Label1.BackColor = Color.White
            End If
        End If
    End Sub

End Class
