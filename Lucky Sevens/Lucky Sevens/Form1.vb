Public Class Form1

    ' If we dim a variable here, we can use it throughout the entire program and all of the subs
    ' Any changes made to it are kept
    Dim total As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim slot1, slot2, slot3 As Integer

        slot1 = Int(Rnd() * 10)
        slot2 = Int(Rnd() * 10)
        slot3 = Int(Rnd() * 10)

        Label1.Text = slot1
        Label2.Text = slot2
        Label3.Text = slot3

        ' Did you get all 7s? (AND)
        ' Did you get ANY 7s? (OR)
        ' Did you get no 7s at all?

        'If slot1 = 7 Then
        '    Label1.BackColor = Label5.BackColor
        'Else
        '    Label1.BackColor = SeaGreen
        'End If

        If slot1 = 7 And slot2 = 7 And slot3 = 7 Then
            total = total + 700
        ElseIf slot1 = 7 Or slot2 = 7 Or slot3 = 7 Then
            total = total + 70
        Else
            total = total - 1
        End If

        Label4.Text = total
    End Sub
End Class
