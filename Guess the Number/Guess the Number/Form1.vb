Public Class Form1

    Dim rndNum As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        rndNum = Int(Rnd() * 100) + 1
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = rndNum Then
            Label1.Text = "Correct Number"
        ElseIf NumericUpDown1.Value < rndNum Then
            Label1.Text = "Too Low"
        Else
            Label1.Text = "Too High"
        End If
    End Sub
End Class
