Public Class Form1
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If sender.Value = 1 Then
            sender.ForeColor = Color.Green
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If sender.Value = 2 Then
            sender.ForeColor = Color.Green
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If sender.Value = 3 Then
            sender.ForeColor = Color.Green
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
