Public Class addLocation
    Private q As New qry

    Private Sub addLocation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        With recvGoodsTrans
            mainForm.Enabled = True
            .Enabled = True
            .Select()
            .Focus()
            .loadTbxLoc()
        End With
    End Sub

    Private Sub addLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxLocDes.Text = ""
        tbxLocDes.Select()
    End Sub

    Private Sub btnClearGoods_Click(sender As Object, e As EventArgs) Handles btnClearGoods.Click
        tbxLocDes.Text = ""
        lblError.Visible = False
        lblError.ForeColor = Color.Red
        tbxLocDes.Select()
    End Sub

    Private Sub btnGoodsAdd_Click(sender As Object, e As EventArgs) Handles btnGoodsAdd.Click
        If String.IsNullOrWhiteSpace(tbxLocDes.Text) Then
            lblError.Visible = True
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input valid data!"
            tbxLocDes.Select()
        Else
            lblError.Visible = False
            'MsgBox("add this one")
            q.addLocations(tbxLocDes.Text)
            tbxLocDes.Text = ""
        End If
    End Sub
End Class