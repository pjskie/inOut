Public Class addDocTypes
    Private q As New qry
    Private Sub addDocTypes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'mainForm.Enabled = True
        'receiveGoods.enabled = True
        ' receiveGoods.select()
        ' receiveGoods.Focus()
    End Sub

    Private Sub btnClearGoods_Click(sender As Object, e As EventArgs) Handles btnClearGoods.Click
        tbxDocType.Text = ""
        lblError.Visible = False
        lblError.ForeColor = Color.Red
        tbxDocType.Select()
    End Sub

    Private Sub btnGoodsAdd_Click(sender As Object, e As EventArgs) Handles btnGoodsAdd.Click
        If String.IsNullOrWhiteSpace(tbxDocType.Text) Then
            lblError.Visible = True
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input valid data!"
            tbxDocType.Select()
        Else
            lblError.Visible = False
            'MsgBox("add this one")
            q.addDOcType(tbxDocType.Text)
            tbxDocType.Text = ""
        End If
    End Sub

    Private Sub addDocTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxDocType.Select()
    End Sub
End Class