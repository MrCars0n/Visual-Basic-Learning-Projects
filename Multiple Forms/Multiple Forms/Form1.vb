Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form1 is the "startup" or "master" form
        ' Only form1 shows up unless you say otherwise. So, in form1's code, say show form2

        Form2.Show()

        ' In order to set the form's position, set it here
        Form2.Left = Me.Right
        Form2.Top = Me.Top
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Period is like an apostrophe, to refer to an object of smoneone else, you would say "Steve's shirt's color"

        Form2.Label1.Text = TextBox1.Text
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        Form2.Left = Me.Right
        Form2.Top = Me.Top
    End Sub
End Class
