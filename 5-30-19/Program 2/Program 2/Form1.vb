Public Class Form1
    Dim Labels(2) As Label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Labels(0) = Label1
        Labels(1) = Label2
        Labels(2) = Label2

        For n = 0 To 2
            Labels(n).ForeColor = Color.Black
        Next

        Label1.Text = Int(Rnd() * 9)
        Label2.Text = Int(Rnd() * 9)
        Label3.Text = Int(Rnd() * 9)

        If Label1.Text = Label2.Text Then
            For n = 0 To 2
                Labels(n).ForeColor = Color.Blue
            Next
        ElseIf Label1.Text = Label3.Text Then
            For n = 0 To 2
                Labels(n).ForeColor = Color.Blue
            Next
        ElseIf Label2.Text = Label3.Text Then
            For n = 0 To 2
                Labels(n).ForeColor = Color.Blue
            Next
        End If

        'For a = 0 To 2
        'For n = 0 To 2
        'If Labels(a).Text = Labels(n).Text And Not (n = a) Then
        'Labels(a).ForeColor = Color.Blue
        'Labels(n).ForeColor = Color.Blue
        'End If
        'Next
        'Next
    End Sub
End Class
