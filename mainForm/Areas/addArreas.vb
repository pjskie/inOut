Public Class addArreas
    Private q As New qry

    Private Sub areas_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxAreaDes.Select()
    End Sub

    Private Sub btnClearGoods_Click(sender As Object, e As EventArgs) Handles btnClearGoods.Click
        tbxAreaDes.Text = ""
        lblError.Visible = False
        lblError.ForeColor = Color.Red
        tbxAreaDes.Select()
    End Sub

    Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click
        If String.IsNullOrWhiteSpace(tbxAreaDes.Text) Then
            lblError.Visible = True
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input valid data!"
            tbxAreaDes.Select()
        Else
            lblError.Visible = False
            'MsgBox("add this one")
            q.addAreaCode(tbxAreaDes.Text)
            tbxAreaDes.Text = ""
        End If
    End Sub
End Class