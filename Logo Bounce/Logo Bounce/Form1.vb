Public Class Form1

    Dim dx, dy, SPEED, score As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Any object you'd like to animate on a 2d plane needs to move with the following two lines
        PictureBox1.Left = PictureBox1.Left + dx
        PictureBox1.Top = PictureBox1.Top + dy

        ' If the picture hits the bottom wall
        If PictureBox1.Bottom > Me.Height Then
            dy = -SPEED
        End If

        ' If the picture hits the right wall
        If PictureBox1.Right > Me.Width Then
            dx = -SPEED
        End If

        ' If the picture hits the top wall
        If PictureBox1.Top < 0 Then
            dy = SPEED
        End If

        ' If the picture hits the left wall
        If PictureBox1.Left < 0 Then
            dx = SPEED
        End If

        'Code to check the collision of two objects
        ' (NOTE - THE AUTOCORRECT IS AWFUL AT THIS)
        If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            PictureBox2.Left = Int(Rnd() * Me.Width)
            PictureBox2.Top = Int(Rnd() * Me.Height)
            Beep()
            score = score + 1
            Label1.Text = "Score: " + Str(score)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SPEED = 100
        dx = SPEED
        dy = SPEED
    End Sub
End Class
