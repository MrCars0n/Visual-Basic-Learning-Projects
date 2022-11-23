Public Class Form1
    Dim arrayList As New List(Of String)({"RED", "GREEN", "BLUE", "YELLOW", "ORANGE", "PURPLE", "BLACK"})

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            'Label1.Text = "COLOR"
            'Label1.ForeColor = Color.Black
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Timer1.Enabled = True
            Timer1.Interval = 3000
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Timer1.Enabled = True
            Timer1.Interval = 2000
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Timer1.Enabled = True
            Timer1.Interval = 1000
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Timer1.Enabled = True
            Timer1.Interval = 500
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim myColor As Integer = Int(Rnd() * arrayList.Count)
        Label1.ForeColor = Color.FromName(arrayList(myColor))
        Label1.Text = arrayList(myColor)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
