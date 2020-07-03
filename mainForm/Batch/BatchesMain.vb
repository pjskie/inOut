Public Class BatchesMain
    Private q As New qry
    Public selectedid As String = ""
    Public id As String = ""

    Private Sub BatchesMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxFilter.Select() 'select textbox filter upon loading the form
        lbxBatches.Items.Clear()
        q.loadLBXBatches(lbxBatches, tbxFilter)
        lbxBatches.ClearSelected()
        btnUpdBatch.Enabled = False
    End Sub

    Private Sub tbxFilter_TextChanged(sender As Object, e As EventArgs) Handles tbxFilter.TextChanged
        lbxBatches.Items.Clear()
        q.loadLBXBatches(lbxBatches, tbxFilter)
        lbxBatches.ClearSelected()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        addBatch.Show()
        lbxBatches.Items.Clear()
        tbxFilter.Text = ""
        mainForm.Enabled = False
        Me.Enabled = False
        lbxBatches.ClearSelected()
    End Sub

    'Private Sub lbxBatches_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxBatches.SelectedIndexChanged
    '    'Try
    '    '    selectedid = lbxBatches.SelectedItem.ToString()
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    'End Try

    '    'If selectedid <> "" Then
    '    '    MsgBox(selectedid)
    '    'Else
    '    '    MessageBox.Show("Select Valid Batch Name.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    'End If
    '    If lbxBatches.Items.Count > 0 Then
    '        Try
    '            selectedid = lbxBatches.SelectedItem.ToString()
    '        Catch ex As Exception
    '            MessageBox.Show("Select Valid Batch Name.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End Try
    '    Else
    '        'MessageBox.Show("Select Valid Batch Name.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    'Private Sub lbxBatches_DoubleClick(sender As Object, e As EventArgs) Handles lbxBatches.DoubleClick
    '    If selectedid <> "" Then
    '        '
    '    Else
    '        MsgBox("No selected batch")
    '    End If
    'End Sub

    Private Sub btnUpdClear_Click(sender As Object, e As EventArgs) Handles btnUpdClear.Click
        tbxBatchAbbrev.Text = ""
        tbxBatchDes.Text = ""
        selectedid = ""
        lbxBatches.ClearSelected()
        btnUpdBatch.Enabled = False
        tbxFilter.Select()
    End Sub

    Private Sub lbxBatches_Click(sender As Object, e As EventArgs) Handles lbxBatches.Click
        'If lbxBatches.Items.Count <> 0 Then
        '    If lbxBatches.SelectedItem.count > 0 Then
        '        selectedid = lbxBatches.SelectedItem
        '        MsgBox(selectedid)
        '    End If
        'ElseIf Not lbxBatches.Items.Count <> 0 Then
        '    MessageBox.Show("Select valid batch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        If lbxBatches.Items.Count = 0 Then
            MessageBox.Show("Select valid batch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If lbxBatches.SelectedItems.Count > 0 Then
                selectedid = lbxBatches.SelectedItem
                lblError.Visible = False
                q.fetchBatchDatas(selectedid)
                btnUpdBatch.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnUpdBatch_Click(sender As Object, e As EventArgs) Handles btnUpdBatch.Click
        If String.IsNullOrEmpty(selectedid) And String.IsNullOrEmpty(id) Then
            MessageBox.Show("Select valid batch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If String.IsNullOrWhiteSpace(tbxBatchAbbrev.Text) Then
                'MessageBox.Show("Select valid batch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblError.Visible = True
                lblError.ForeColor = Color.Red
                lblError.Text = "Please input valid data!"
                tbxBatchAbbrev.Select()
            Else
                q.updateBatch(tbxBatchAbbrev.Text, tbxBatchDes.Text, mainForm.userId, id)
                MessageBox.Show("Successfully Updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                selectedid = ""
                id = ""
                tbxBatchAbbrev.Text = ""
                tbxBatchDes.Text = ""
                lbxBatches.Items.Clear()
                q.loadLBXBatches(lbxBatches, tbxFilter)
                btnUpdBatch.Enabled = False
                tbxFilter.Focus()
                tbxFilter.Select()
            End If
        End If
    End Sub
End Class