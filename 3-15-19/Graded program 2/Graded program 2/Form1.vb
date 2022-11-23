Public Class Form1
    Dim c1, c2, c4, c8 As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1 = F
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If sender.Checked = True Then
            c8 = True
        Else
            c8 = False
        End If
    End Sub
End Class
