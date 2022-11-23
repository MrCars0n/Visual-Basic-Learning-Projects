Public Class Form1
    Dim subTotal, Tax As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBname.Text = "Lé Chef Carson Kramer's" + Environment.NewLine + "Super Italian Bros Pizzeria"
    End Sub

    Private Sub RBmedium_CheckedChanged(sender As Object, e As EventArgs) Handles RBmedium.CheckedChanged
        LBmedium.BackColor = Color.HotPink
        LBlarge.BackColor = Color.DarkSeaGreen
        LBamerican.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub RBlarge_CheckedChanged(sender As Object, e As EventArgs) Handles RBlarge.CheckedChanged
        LBlarge.BackColor = Color.HotPink
        LBamerican.BackColor = Color.DarkSeaGreen
        LBmedium.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub BTcompleteorder_Click(sender As Object, e As EventArgs) Handles BTcompleteorder.Click
        If RBamerican.Checked = True Then
            subTotal = subTotal + 10
        ElseIf RBmedium.Checked = True Then
            subTotal = subTotal + 6
        ElseIf RBlarge.Checked = True Then
            subTotal = subTotal + 8
        End If

        If CheckBox1.Checked = True Then
            subTotal = subTotal + 0.5
        End If
        If CheckBox2.Checked = True Then
            subTotal = subTotal + 0.5
        End If
        If CheckBox3.Checked = True Then
            subTotal = subTotal + 0.5
        End If
        If CheckBox4.Checked = True Then
            subTotal = subTotal + 0.5
        End If
        If CheckBox5.Checked = True Then
            subTotal = subTotal + 0.5
        End If
        If IsNumeric(TextBox1.Text) Then
            subTotal = subTotal + (TextBox1.Text * 1)
        End If
        Tax = subTotal * 0.06
        LBsubtotalnum.Text = FormatCurrency(subTotal)
        LBsalestaxnum.Text = FormatCurrency(Tax)
        LBfinaltotalnum.Text = FormatCurrency(subTotal + Tax)
        subTotal = 0
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If sender.checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub RBamerican_CheckedChanged(sender As Object, e As EventArgs) Handles RBamerican.CheckedChanged
        LBamerican.BackColor = Color.HotPink
        LBmedium.BackColor = Color.DarkSeaGreen
        LBlarge.BackColor = Color.DarkSeaGreen
    End Sub
End Class
