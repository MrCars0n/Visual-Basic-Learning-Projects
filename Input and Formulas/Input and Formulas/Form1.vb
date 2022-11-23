' Carson Kramer
' 1-8-2019
' Period 9
' Input and Formulas

' The apostrophe makes comments in Visual BASIC!

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Unlike in python, in VB we need to "dimension' our variables, which means we give the variable a name and data type (integers, string, etc...)
        Dim miles As Integer
        Dim feet As Integer

        ' Stores the text in the textbox into the miles variable (like input)
        ' use Val() to tell the computer covert text to numbers

        miles = Val(TextBox1.Text)

        ' Do the calculation(s)
        feet = miles * 5280

        ' Put the answer into the label (like print)
        Label1.Text = feet

    End Sub
End Class
