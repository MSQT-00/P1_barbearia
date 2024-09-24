Public Class Barbearia
    Private Sub AGENDAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGENDAMENTOToolStripMenuItem.Click
        agendamento.ShowDialog()
    End Sub

    Private Sub ADMINISTRADORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINISTRADORToolStripMenuItem.Click
        Dim login As New Login_adm()
        login.ShowDialog()

        If login.IsAuthenticated Then
            adm.ShowDialog()
        End If
    End Sub

    Private Sub Barbearia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
