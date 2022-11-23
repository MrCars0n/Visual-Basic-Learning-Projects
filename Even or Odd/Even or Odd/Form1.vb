Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num As Integer
        num = Int(Rnd() * 10)
        Button1.Text = num

        If num Mod 2 = 0 Then
            My.Computer.Audio.Play(My.Resources.bangbang, AudioPlayMode.Background)
        End If
    End Sub
End Class
