Public Class Form4
    Private Sub CuadradosCentralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadradosCentralesToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub CongruencialMixtoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CongruencialMixtoToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub LuckySevenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuckySevenToolStripMenuItem.Click
        Me.Hide()
        Lucky_seven.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

End Class