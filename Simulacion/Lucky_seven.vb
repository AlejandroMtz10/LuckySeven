Public Class Lucky_seven
    Dim intentos As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PictureBox1.Visible = False
        Randomize()

        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
        Label4.Text = Int(Rnd() * 10)

        If ((Label2.Text = 7 And Label3.Text = 7) And Label4.Text = 7) Then
            PictureBox1.Visible = True
            MsgBox("You are the winner ")
            intentos = 0
        End If
        intentos = intentos + 1
        Label6.Text = intentos
        Exit Sub
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub CongruencialMixtoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CongruencialMixtoToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub CuadradosCentralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadradosCentralesToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class