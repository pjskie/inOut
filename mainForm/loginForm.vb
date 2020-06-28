Public Class loginForm
    Private q As New qry
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        login()
    End Sub

    Private Sub login()
        If tbxUser.Text = "" And tbxPass.Text = "" Then
            lblError.Visible = True
            lblError.Text = "Fields with '*' are required!"
            lblErrorUser.Visible = True
            lblErrorPas.Visible = True
        ElseIf tbxUser.Text = "" Then
            lblError.Visible = True
            lblError.Text = "Fields with '*' are required!"
            lblErrorUser.Visible = True
            lblErrorPas.Visible = False
        ElseIf tbxPass.Text = "" Then
            lblError.Visible = True
            lblError.Text = "Fields with '*' are required!"
            lblErrorUser.Visible = False
            lblErrorPas.Visible = True
        Else
            q.signIn(tbxUser.Text, tbxPass.Text)
        End If
    End Sub

    Private Sub loginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub loginForm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class