Public Class Form1
    Dim odd As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If odd = False Then
            odd = True
        Else
            odd = False
        End If
        Label1.Text = Val(Label1.Text) + 5

        If odd = True Then
            Button1.BackColor = Color.Green
        Else
            Button1.BackColor = Color.Red
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        odd = False
    End Sub
End Class
