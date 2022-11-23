Public Class Form1
    Private Sub chkUSA_CheckedChanged(sender As Object, e As EventArgs) Handles chkUSA.CheckedChanged
        If chkUSA.Checked = True Then
            picUSA.Visible = True
        Else
            picUSA.Visible = False
        End If
    End Sub

    Private Sub chkUK_CheckedChanged(sender As Object, e As EventArgs) Handles chkUK.CheckedChanged
        If chkUK.Checked = True Then
            picUK.Visible = True
        Else
            picUK.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picUK.Visible = False
        picUSA.Visible = False
    End Sub
End Class
