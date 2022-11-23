Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim roll, count1, count2, count3, count4, count5, count6 As Integer

        roll = Int(Rnd() * 6) + 1
        Label13.Text = roll
        If roll = 1 Then
            count1 = count1 + 1
            Label1.Text = count1
        ElseIf roll = 2 Then
            count2 = count2 + 1
            Label2.Text = count2
        ElseIf roll = 3 Then
            count3 = count3 + 1
            Label3.Text = count3
        ElseIf roll = 4 Then
            count4 = count4 + 1
            Label4.Text = count4
        ElseIf roll = 5 Then
            count5 = count5 + 1
            Label5.Text = count5
        ElseIf roll = 6 Then
            count6 = count6 + 1
            Label6.Text = count6
        End If
    End Sub
End Class
