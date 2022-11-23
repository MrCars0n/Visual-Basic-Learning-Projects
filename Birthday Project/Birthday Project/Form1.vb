Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim year, age As Integer
        year = Int(Rnd() * 80) + 1939
        DateTimePicker1.Value = New Date(year, Int(Rnd() * 12) + 1, Int(Rnd() * 31) + 1)
        age = 2019 - year
        Button1.Text = "You are / will be " + Str(age) + " years old this year"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r, b, g As Integer

        r = Int(Rnd() * 256)
        b = Int(Rnd() * 256)
        g = Int(Rnd() * 256)

        Me.BackColor = Color.FromArgb(r, b, g)
    End Sub
End Class
