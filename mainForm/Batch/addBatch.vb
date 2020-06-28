Public Class addBatch
    Private q As New qry

    Private Sub addBatch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        With recvGoodsTrans
            mainForm.Enabled = True
            .Enabled = True
            .Select()
            .Focus()
            .loadTbxBatch()
        End With

    End Sub

    Private Sub batch_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxBatchDes.Select()
    End Sub

    Private Sub btnClearGoods_Click(sender As Object, e As EventArgs) Handles btnClearGoods.Click
        tbxBatchDes.Text = ""
        lblError.Visible = False
        lblError.ForeColor = Color.Red
        tbxBatchDes.Select()
    End Sub

    Private Sub btnGoodsAdd_Click(sender As Object, e As EventArgs) Handles btnGoodsAdd.Click
        If String.IsNullOrWhiteSpace(tbxBatchDes.Text) Then
            lblError.Visible = True
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input valid data!"
            tbxBatchDes.Select()
        Else
            lblError.Visible = False
            'MsgBox("add this one")
            q.addBatches(tbxBatchDes.Text)
            tbxBatchDes.Text = ""
        End If
    End Sub
End Class