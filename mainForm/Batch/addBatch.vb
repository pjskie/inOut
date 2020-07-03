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

        With BatchesMain
            mainForm.Enabled = True
            .Enabled = True
            .lbxBatches.Items.Clear()
            q.loadLBXBatches(.lbxBatches, .tbxFilter)
            .id = ""
            .selectedid = ""
            .tbxFilter.Select()
            .tbxFilter.Focus()
            .tbxBatchAbbrev.Text = ""
            .tbxBatchDes.Text = ""
            .btnUpdBatch.Enabled = False
        End With
    End Sub

    Private Sub batch_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxAbbvBatch.Select()
    End Sub

    Private Sub btnClearGoods_Click(sender As Object, e As EventArgs) Handles btnClearGoods.Click
        tbxAbbvBatch.Text = ""
        lblError.Visible = False
        lblError.ForeColor = Color.Red
        tbxAbbvBatch.Select()
    End Sub

    Private Sub btnGoodsAdd_Click(sender As Object, e As EventArgs) Handles btnGoodsAdd.Click
        If String.IsNullOrWhiteSpace(tbxAbbvBatch.Text) Then
            lblError.Visible = True
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input valid data!"
            tbxAbbvBatch.Select()
        Else
            lblError.Visible = False
            'MsgBox("add this one")
            q.addBatches(tbxAbbvBatch.Text.ToString, tbxDescBatch.Text.ToString)
            tbxAbbvBatch.Text = ""
            tbxDescBatch.Text = ""
        End If
    End Sub
End Class