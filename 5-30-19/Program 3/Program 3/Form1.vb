Public Class Form1
    Private Sub Inches_CheckedChanged(sender As Object, e As EventArgs) Handles Inches.CheckedChanged
        Label1.Text = Val(TextBox1.Text) * 63360
    End Sub

    Private Sub Feet_CheckedChanged(sender As Object, e As EventArgs) Handles Feet.CheckedChanged
        Label1.Text = Val(TextBox1.Text) * 5280
    End Sub

    Private Sub yards_CheckedChanged(sender As Object, e As EventArgs) Handles yards.CheckedChanged
        Label1.Text = Val(TextBox1.Text) * 1760
    End Sub
End Class
