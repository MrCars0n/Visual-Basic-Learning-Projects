Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = ComboBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ListBox1.Items.Contains(ComboBox1.Text) And ComboBox1.Items.Contains(ComboBox1.Text) Then
            ListBox1.Items.Add(ComboBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = Int(Rnd() * ListBox1.Items.Count)
        Else
            MsgBox("No Names Are In Your List :(")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Sorted = True
        ListBox1.Sorted = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Remove works with the item itself
        ListBox1.Items.Remove(ListBox1.SelectedItem)

        ' RemoveAt works with the index (position)
        ' ListBox1.items.RemoveAt(ListBox1.SelectedIndex)
    End Sub
End Class
