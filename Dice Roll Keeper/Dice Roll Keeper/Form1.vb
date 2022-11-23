Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        CheckBox1.Image = Nothing
        CheckBox2.Image = Nothing
        CheckBox3.Image = Nothing
        CheckBox4.Image = Nothing
        CheckBox5.Image = Nothing
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.BackColor = Color.Black
        Else
            CheckBox1.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.BackColor = Color.Black
        Else
            CheckBox2.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox3.BackColor = Color.Black
        Else
            CheckBox3.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox4.BackColor = Color.Black
        Else
            CheckBox4.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox5.BackColor = Color.Black
        Else
            CheckBox5.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False Then
            Dim roll As Integer = Int(Rnd() * 6) + 1

            If roll = 1 Then CheckBox1.Image = My.Resources.dice1
            If roll = 2 Then CheckBox1.Image = My.Resources.dice2
            If roll = 3 Then CheckBox1.Image = My.Resources.dice3
            If roll = 4 Then CheckBox1.Image = My.Resources.dice4
            If roll = 5 Then CheckBox1.Image = My.Resources.dice5
            If roll = 6 Then CheckBox1.Image = My.Resources.dice6
        End If
        If CheckBox2.Checked = False Then
            Dim roll As Integer = Int(Rnd() * 6) + 1

            If roll = 1 Then CheckBox2.Image = My.Resources.dice1
            If roll = 2 Then CheckBox2.Image = My.Resources.dice2
            If roll = 3 Then CheckBox2.Image = My.Resources.dice3
            If roll = 4 Then CheckBox2.Image = My.Resources.dice4
            If roll = 5 Then CheckBox2.Image = My.Resources.dice5
            If roll = 6 Then CheckBox2.Image = My.Resources.dice6
        End If
        If CheckBox3.Checked = False Then
            Dim roll As Integer = Int(Rnd() * 6) + 1

            If roll = 1 Then CheckBox3.Image = My.Resources.dice1
            If roll = 2 Then CheckBox3.Image = My.Resources.dice2
            If roll = 3 Then CheckBox3.Image = My.Resources.dice3
            If roll = 4 Then CheckBox3.Image = My.Resources.dice4
            If roll = 5 Then CheckBox3.Image = My.Resources.dice5
            If roll = 6 Then CheckBox3.Image = My.Resources.dice6
        End If
        If CheckBox4.Checked = False Then
            Dim roll As Integer = Int(Rnd() * 6) + 1

            If roll = 1 Then CheckBox4.Image = My.Resources.dice1
            If roll = 2 Then CheckBox4.Image = My.Resources.dice2
            If roll = 3 Then CheckBox4.Image = My.Resources.dice3
            If roll = 4 Then CheckBox4.Image = My.Resources.dice4
            If roll = 5 Then CheckBox4.Image = My.Resources.dice5
            If roll = 6 Then CheckBox4.Image = My.Resources.dice6
        End If
        If CheckBox5.Checked = False Then
            Dim roll As Integer = Int(Rnd() * 6) + 1

            If roll = 1 Then CheckBox5.Image = My.Resources.dice1
            If roll = 2 Then CheckBox5.Image = My.Resources.dice2
            If roll = 3 Then CheckBox5.Image = My.Resources.dice3
            If roll = 4 Then CheckBox5.Image = My.Resources.dice4
            If roll = 5 Then CheckBox5.Image = My.Resources.dice5
            If roll = 6 Then CheckBox5.Image = My.Resources.dice6
        End If
    End Sub
End Class
