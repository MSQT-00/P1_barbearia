Public Class Login_adm
    Public Property IsAuthenticated As Boolean = False

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = txt_user.Text
        Dim password As String = txt_senha.Text

        ' Verifique as credenciais
        If username = "admin" And password = "1234" Then
            IsAuthenticated = True
            Me.Close()
        Else
            MessageBox.Show("Usuário ou senha inválidos.")
        End If
    End Sub
End Class
