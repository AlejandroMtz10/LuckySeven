Public Class Form2
    Dim nElementos, Semilla, longitud, cont As Integer
    Dim nSemilla, nCuadrado As String
    Dim random, cuadrado As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Semilla = TextBox1.Text
        nElementos = Val(TextBox2.Text)
        Do
            cuadrado = Semilla ^ 2
            nCuadrado = cuadrado & ""
            longitud = Len(nCuadrado)

            If longitud = 7 Then
                nCuadrado = "0" & nCuadrado
            End If

            If longitud = 6 Then
                nCuadrado = "00" & nCuadrado
            End If

            If longitud = 5 Then
                nCuadrado = "000" & nCuadrado
            End If

            If longitud = 4 Then
                nCuadrado = "0000" & nCuadrado
            End If

            If longitud = 3 Then
                nCuadrado = "00000" & nCuadrado
            End If


            ListBox1.Items.Add(nCuadrado)

            nSemilla = Mid(nCuadrado, 3, 4)
            Semilla = Val(nSemilla)
            random = Semilla / 10000

            ListBox2.Items.Add(Random)

            cont = cont + 1
        Loop Until cont = nElementos
    End Sub

    Private Sub CongruencialMixtoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CongruencialMixtoToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub RegresarAMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAMenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
    Private Sub LuckySevenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuckySevenToolStripMenuItem.Click
        Me.Hide()
        Lucky_seven.Show()
    End Sub


End Class