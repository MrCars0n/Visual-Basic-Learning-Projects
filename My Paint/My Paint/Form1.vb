Public Class Form1

    Dim myBrush As SolidBrush = New SolidBrush(Drawing.Color.Black)

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim screen As Graphics = Me.CreateGraphics

        ' "e" is the variable representing the mouse
        Dim brushSize As Integer = Val(ToolStripTextBox1.Text)
        Dim x As Integer = e.X - (brushSize / 2)
        Dim y As Integer = e.Y - (brushSize / 2)

        If e.Button = MouseButtons.Left Then
            Dim r As Integer = Int(Rnd() * 256)
            Dim b As Integer = Int(Rnd() * 256)
            Dim g As Integer = Int(Rnd() * 256)

            myBrush = New SolidBrush(Drawing.Color.FromArgb(r, b, g))
            screen.FillRectangle(myBrush, x, y, brushSize, brushSize)
        End If

        If e.Button = MouseButtons.Right Then
            Dim myFont As Font = New Font("Comic Sans MS", brushSize, FontStyle.Regular)
            screen.DrawString(ToolStripTextBox2.Text, myFont, myBrush, x, y)
        End If

        If e.Button = MouseButtons.Middle Then
            screen.DrawImage(My.Resources.download, x, y)
        End If

    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        myBrush = New SolidBrush(Drawing.Color.Red)
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        myBrush = New SolidBrush(Drawing.Color.Green)
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        myBrush = New SolidBrush(Drawing.Color.Blue)
    End Sub

    Private Sub ChooseColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        myBrush = New SolidBrush(ColorDialog1.Color)
    End Sub
End Class
