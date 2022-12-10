Public Class Form3
    Dim Semilla, a, m, c, xn, i As Integer

    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Dim Random As Double

    Private Sub CuadradosCentralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadradosCentralesToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub LuckySevenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuckySevenToolStripMenuItem.Click
        Me.Hide()
        Lucky_seven.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Semilla = TextBox1.Text
        a = TextBox2.Text
        c = TextBox3.Text
        m = TextBox4.Text
        For i = 0 To Semilla
            xn = (a * Semilla + c) Mod m
            Random = xn / m
            ListBox1.Items.Add(xn)
            ListBox2.Items.Add(Random)
            Semilla = xn
        Next i
    End Sub
End Class