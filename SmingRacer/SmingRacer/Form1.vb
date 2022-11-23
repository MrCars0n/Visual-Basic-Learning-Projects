Public Class Form1

    ' The speed and direction of my object (car)
    Dim dx As Integer
    Dim dy As Integer
    Dim SPEED, speedCopy As Integer
    Dim direction As String

    Dim lapCount As Integer
    Dim checkpoint As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' the car starts at trest (not moving)
        dx = 0
        dy = 0
        SPEED = 10
        speedCopy = SPEED
        checkpoint = False
        SpeedText.Text = "Speed: " + Str(SPEED)
        direction = "Down"
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        ' To quit the game hit esc
        If e.KeyCode = Keys.Escape Then
            MsgBox("Game Over!")
            End
        End If

        If e.KeyCode = Keys.Left Then
            RaceCar.Height = 50
            RaceCar.Width = 100
            RaceCar.Image = My.Resources.CarLeft
            dx = -SPEED
            dy = 0
            direction = "Left"
        End If
        If e.KeyCode = Keys.Right Then
            RaceCar.Height = 50
            RaceCar.Width = 100
            RaceCar.Image = My.Resources.CarRight
            dx = SPEED
            dy = 0
            direction = "Right"
        End If
        If e.KeyCode = Keys.Up Then
            RaceCar.Height = 100
            RaceCar.Width = 50
            RaceCar.Image = My.Resources.CarUp
            dx = 0
            dy = -SPEED
            direction = "Up"
        End If
        If e.KeyCode = Keys.Down Then
            RaceCar.Height = 100
            RaceCar.Width = 50
            RaceCar.Image = My.Resources.CarDown
            dx = 0
            dy = SPEED
            direction = "Down"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Always do the animation in your timer! (Also change your form's double buffered to true)

        ' These two lines are basic motion of any 2d object
        RaceCar.Left = RaceCar.Left + dx
        RaceCar.Top = RaceCar.Top + dy

        ' Detech collisions in the timer, not the key up/down
        ' Rather than using five different if-statements for each border, we are going to make an array (list) and a for-loop

        Dim boundary(5) As PictureBox
        boundary(0) = PictureBox1
        boundary(1) = PictureBox2
        boundary(2) = PictureBox3
        boundary(3) = PictureBox4
        boundary(4) = PictureBox5

        For n = 0 To 4
            If RaceCar.Bounds.IntersectsWith(boundary(n).Bounds) Then
                ' Before you do anything else - turn the timer off!
                'Timer1.Enabled = False
                SPEED = Int(SPEED / 5)
                'Dim choice As Integer
                'choice = MsgBox("You crashed - play again?", MsgBoxStyle.YesNo)

                'If choice = vbYes Then
                'Application.Restart()
                'Else
                '    End
                'End If
            Else
                SPEED = speedCopy
            End If
        Next

        If direction = "Down" Then
            dy = SPEED
        ElseIf direction = "Up" Then
            dy = -SPEED
        ElseIf direction = "Left" Then
            dx = -SPEED
        ElseIf direction = "Right" Then
            dx = SPEED
        End If

        ' Detect collision with the finish line (laps)

        If RaceCar.Bounds.IntersectsWith(Label2.Bounds) Then
            checkpoint = True
        End If

        If RaceCar.Bounds.IntersectsWith(FinishLine.Bounds) And checkpoint = True Then
            checkpoint = False
            lapCount = lapCount + 1
            Laps.Text = "Number of Laps: " + Str(lapCount)
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        ' This is the event triggered when we let go of a key
        ' We commented this out, since it doesn't make sense for this game by the code would stop the motion when you let go of a key
        'dx = 0
        'dy = 0
    End Sub
End Class
