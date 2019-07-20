Public Class Form1
    Dim usermes As New usermess

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pcenter.Controls.Add(usermes)
        usermes.BringToFront()
        usermes.Dock = DockStyle.Fill

    End Sub
End Class
