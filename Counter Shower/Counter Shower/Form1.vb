Public Class Form1
    Dim SPEED As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        SPEED = 5
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Top < Me.Height - Label1.Height Then
            Label1.Top = Label1.Top + SPEED
        Else
            Label1.Top = Label1.Top - Me.Height
            Label1.Left = Int(Rnd() * Me.Width) + 1
            Label1.Text = Label1.Text + 1
            Me.BackColor = Color.FromArgb(Int(Rnd() * 255) + 1, Int(Rnd() * 255) + 1, Int(Rnd() * 255) + 1)
            Me.ForeColor = Color.FromArgb(Int(Rnd() * 255) + 1, Int(Rnd() * 255) + 1, Int(Rnd() * 255) + 1)
            SPEED = Int(Rnd() * 20) + 1
        End If
    End Sub
End Class
