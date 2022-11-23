Public Class Form1

    ' Two-dimensional array (rows, colums) like a grid or matrix
    Dim grid(0 To 9, 0 To 9) As Button
    Dim visibleChoice As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Because it is a 2d array, we use two for loops (nested)
        For x = 0 To 9
            For y = 0 To 9

                grid(x, y) = New Button

                grid(x, y).Width = 50
                grid(x, y).Height = 50

                ' Since we want the grid to be a grid, use a formula involving the multiples of x and y

                ' To shift away from the origin (top left), add a number to the end
                ' the make the grid spaced farther apart, modify the width and height to a larger number
                grid(x, y).Left = x * grid(x, y).Width '(Me.Width / 2)
                grid(x, y).Top = y * grid(x, y).Height '(Me.Height / 2)

                grid(x, y).BackColor = Color.Black
                grid(x, y).ForeColor = Color.White

                grid(x, y).Font = New Font("Comic Sans MS", 8)

                grid(x, y).TextAlign = ContentAlignment.MiddleCenter
                grid(x, y).Text = Str(x) + "," + Str(y)

                ' In the tag property, we can store any data we want
                ' Becasue we later need the get the row and column, we are going to store that info in the tag
                ' Store a coordinate as a two digit number
                ' (2,3) will store as 23

                grid(x, y).Tag = x * 10 + y

                Me.Controls.Add(grid(x, y))

                AddHandler grid(x, y).Click, AddressOf grid_click
            Next
        Next
    End Sub

    ' To code your own "sub", copy one which is already made
    ' 1) Modify the name to the left of the (
    ' 2) Delete the "handles" to the right of the )
    ' 3) change "as object" to "as ______" matching your array type
    Private Sub grid_click(sender As Button, e As EventArgs)

        Dim row, col As Integer

        ' To undo the 2 digit number and the row and column
        ' Divide my 10 to get the quotient (row) and use mod 10 to get the remainder (col)
        row = Int(sender.Tag / 10)
        col = sender.Tag Mod 10

        For n = 0 To 9
            If grid(row, n).BackColor = Color.Yellow Then
                grid(row, n).BackColor = Color.Black
                grid(row, n).ForeColor = Color.White
            Else
                grid(row, n).BackColor = Color.Yellow
                grid(row, n).ForeColor = Color.Black
            End If

            If grid(n, col).BackColor = Color.Yellow Then
                grid(n, col).BackColor = Color.Black
                grid(n, col).ForeColor = Color.White
            Else
                grid(n, col).BackColor = Color.Yellow
                grid(n, col).ForeColor = Color.Black
            End If
        Next

        If sender.BackColor = Color.Yellow Then
            sender.BackColor = Color.Black
            sender.ForeColor = Color.White
        Else
            sender.BackColor = Color.Yellow
            sender.ForeColor = Color.Black
        End If
        'Me.BackColor = sender.BackColor
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    For x = 0 To 9
    '  For y = 0 To 9
    '       grid(x, y).BackColor = Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))
    '        grid(x, y).ForeColor = Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))
    '         visibleChoice = Int(Rnd() * 1)
    '          If visibleChoice = 0 Then
    '               'grid(x, y).Visible = False
    '            Else
    '       grid(x, y).Visible = True
    '  End If
    'Next
    '    Next
    'End Sub
End Class
