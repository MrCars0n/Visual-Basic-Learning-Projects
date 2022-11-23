Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Visible = False
        PictureBox2.Visible = False
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = My.Resources.world
    End Sub
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        PictureBox1.Image = My.Resources.China
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        PictureBox1.Image = My.Resources.Djibouti
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        PictureBox1.Image = My.Resources.France
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        PictureBox1.Image = My.Resources.Germany
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        PictureBox1.Image = My.Resources.Italy
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        PictureBox1.Image = My.Resources.Spain
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        PictureBox1.Image = My.Resources.UK
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        PictureBox1.Image = My.Resources.USA
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label9.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PictureBox2.Image = My.Resources.China
        Label9.Visible = True
        Label9.Text = "China" & Environment.NewLine & Environment.NewLine & "Capital: Bejing" & Environment.NewLine & "Population: 1.386 billion" & Environment.NewLine & "Size: 3.705 million mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PictureBox2.Image = My.Resources.Djibouti
        Label9.Visible = True
        Label9.Text = "Djibouti" & Environment.NewLine & Environment.NewLine & "Capital: Djibouti" & Environment.NewLine & "Population: 956,985" & Environment.NewLine & "Size: 8,958 mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        PictureBox2.Image = My.Resources.France
        Label9.Visible = True
        Label9.Text = "France" & Environment.NewLine & Environment.NewLine & "Capital: Paris" & Environment.NewLine & "Population: 67.12 million" & Environment.NewLine & "Size: 248,573 mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        PictureBox2.Image = My.Resources.Germany
        Label9.Visible = True
        Label9.Text = "Germany" & Environment.NewLine & Environment.NewLine & "Capital: Berlin" & Environment.NewLine & "Population: 82.79 million" & Environment.NewLine & "Size: 137,988 mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        PictureBox2.Image = My.Resources.Italy
        Label9.Visible = True
        Label9.Text = "Italy" & Environment.NewLine & Environment.NewLine & "Capital: Rome" & Environment.NewLine & "Population: 60.59 million" & Environment.NewLine & "Size: 116,347 mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        PictureBox2.Image = My.Resources.Spain
        Label9.Visible = True
        Label9.Text = "Spain" & Environment.NewLine & Environment.NewLine & "Capital: Madrid" & Environment.NewLine & "Population: 46.57 million" & Environment.NewLine & "Size: 195,364 mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        PictureBox2.Image = My.Resources.UK
        Label9.Visible = True
        Label9.Text = "United Kingdom" & Environment.NewLine & Environment.NewLine & "Capital: London" & Environment.NewLine & "Population: 66.02 million" & Environment.NewLine & "Size: 93,628 mi²"
        PictureBox2.Visible = True
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        PictureBox2.Image = My.Resources.USA
        Label9.Visible = True
        Label9.Text = "United States of America" & Environment.NewLine & Environment.NewLine & "Capital: Washington, D.C." & Environment.NewLine & "Population: 325.7 million" & Environment.NewLine & "Size: 3.797 million mi²"
        PictureBox2.Visible = True
    End Sub
End Class
