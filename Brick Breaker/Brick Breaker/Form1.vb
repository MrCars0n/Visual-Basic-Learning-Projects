Public Class Form1

    Dim grid(0 To 4, 0 To 9) As PictureBox
    Dim brickColors(0 To 2) As Image
    Dim dx, dy As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        brickColors(0) = My.Resources.GoldBrick
        brickColors(1) = My.Resources.SilverBrick
        brickColors(2) = My.Resources.PinkBrick

        Randomize()

        dx = 3
        dy = 3

        For row = 0 To 4
            For col = 0 To 9
                grid(row, col) = New PictureBox

                grid(row, col).Width = 150
                grid(row, col).Height = 70

                grid(row, col).Left = col * 150
                grid(row, col).Top = row * 70 + 70

                If row = 0 Or row = 4 Then
                    grid(row, col).Image = My.Resources.GoldBrick
                ElseIf row = 1 Or row = 3 Then
                    grid(row, col).Image = My.Resources.SilverBrick
                ElseIf row = 2 Then
                    grid(row, col).Image = My.Resources.PinkBrick
                End If


                Me.Controls.Add(grid(row, col))
                AddHandler grid(row, col).MouseMove, AddressOf gridMouseMove
            Next
        Next
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim mousePos = PointToClient(MousePosition)
        'If mousePos.X < Me.Width Then
        Paddle.Left = mousePos.X - (Paddle.Width / 2)
        'End If
    End Sub

    Private Sub gridMouseMove(sender As Object, e As MouseEventArgs)
        Dim mousePos = PointToClient(MousePosition)
        'If mousePos.X < Me.Width Then
        Paddle.Left = mousePos.X - (Paddle.Width / 2)
        'End If
    End Sub

    Private Sub Ball_MouseMove(sender As Object, e As MouseEventArgs) Handles Ball.MouseMove
        Dim mousePos = PointToClient(MousePosition)
        'If mousePos.X < Me.Width Then
        Paddle.Left = mousePos.X - (Paddle.Width / 2)
        'End If
    End Sub

    Private Sub Paddle_MouseMove(sender As Object, e As MouseEventArgs) Handles Paddle.MouseMove
        Dim mousePos = PointToClient(MousePosition)
        'If mousePos.X < Me.Width Then
        Paddle.Left = mousePos.X - (Paddle.Width / 2)
        'End If
    End Sub

    Private Sub brickSwitchTimer_Tick(sender As Object, e As EventArgs) Handles brickSwitchTimer.Tick
        For row = 0 To 4
            For col = 0 To 9
                grid(row, col).Image = brickColors(Int(Rnd() * 3))
            Next
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If animationTimer.Enabled = False Then
            animationTimer.Enabled = True
        End If
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        Ball.Left = Ball.Left + dx
        Ball.Top = Ball.Top + dy

        If Ball.Bounds.IntersectsWith(Paddle.Bounds) Or Ball.Top < 0 Then
            dy = -dy
        End If

        If Ball.Right > Me.Width Or Ball.Left < 0 Then
            dx = -dx
        End If

        If Ball.Bottom > Me.Height Then
            animationTimer.Enabled = False
            brickSwitchTimer.Enabled = False
            MsgBox("GAME OVER")
            End
        End If

        For row = 0 To 4
            For col = 0 To 9
                If Ball.Bounds.IntersectsWith(grid(row, col).Bounds) And grid(row, col).Visible = True Then
                    grid(row, col).Visible = False
                    dy = -dy
                End If
            Next
        Next


    End Sub
End Class
