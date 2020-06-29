Public Class recvGoodsTrans
    Private q As New qry
    Private p As New dgvPaging
    Private dtSource As DataTable
    'hold the id of the details 
    Public prodId As String = ""
    'hold the batch id
    Public batchId As String = ""
    'hold the location id
    Public locId As String = ""
    'hold the id of the header 
    Public transId As String = ""
    'hold the doc type id
    Public docTypeId As String = ""
    'hold the sender Id
    Public senderId As String = ""


    'form load
    Private Sub recvGoodsTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxPagesize.SelectedIndex = 2 'set page size to 10
        tbxDocEntry.Text = "" 'set temporarily doc entry as 000
        loadTbxBatch() 'autosuggest tbx batch
        loadTbxLoc() 'autosugget tbx loc
        q.cbxSender(cbxSender) 'load combobox list of senders
        q.cbxDocType(cbxRefDocType) 'load combobx list of document types
    End Sub

    'number only in reference doc number
    Private Sub tbxRefDocNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxRefDocNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'number only in product number
    Private Sub tbxPDno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPDno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'number only in quantity
    Private Sub tbxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    '=====================================================================================================
    'FOR the DATAGRID VIEW

    'Clicking the dgv
    Private Sub dgvProdDet_click(ByVal sender As Object, ByVal e As EventArgs) Handles dgvProdDet.Click
        lblError.Visible = False
        If dgvProdDet.Rows.Count = 0 Then
            MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If dgvProdDet.SelectedRows.Count > 0 Then
                prodId = ""
                prodId = dgvProdDet.CurrentRow.Cells(0).Value
                'MsgBox(Me.prodId)

            End If
        End If
    End Sub
    Private Sub dgvProdDet_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        Me.dgvProdDet.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvProdDet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub dgvProdDet_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
        dgvProdDet.ClearSelection()

        If dgvProdDet.Rows.Count > 0 Then
            lblError.Text = ""
        Else
            lblError.Text = "No results found..."
        End If
    End Sub
    Public Sub loadDataGridView()
        'q.loadProdDGV()
        'txtFilter.Text = ""
        dgvProdDet.ClearSelection()
        adjustDGv()
    End Sub
    Public Sub adjustDGv()
        'for adjusting data to display
        dtSource = q.SQL.DBDT
        p.fillDgv(cbxPagesize.Text, dtSource)
        p.LoadPage(dtSource, dgvProdDet, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)

        If p.PageCount = 1 Then
            btnNext.Enabled = False
            btnLast.Enabled = False
        Else
            btnNext.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub
    'for Paging
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        dtSource = q.SQL.DBDT
        p.tofirstpage(dtSource, dgvProdDet, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        dtSource = q.SQL.DBDT
        p.previouspage(dtSource, dgvProdDet, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        dtSource = q.SQL.DBDT
        p.nextpage(dtSource, dgvProdDet, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        dtSource = q.SQL.DBDT
        p.tolastpage(dtSource, dgvProdDet, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    'End Paging
    '------------------------------------------------------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If dgvProdDet.Rows.Count = 0 And String.IsNullOrWhiteSpace(tbxDocEntry.Text) Then
        '    'MsgBox("LALALA")
        '    btnSave.Select()
        'Else
        '    'MsgBox("LULU")
        'End If
        If transId <> "" And dgvProdDet.Rows.Count <> 0 Then
            If cbxRefDocType.SelectedIndex = -1 Or cbxSender.SelectedIndex = -1 Or tbxSenderName.Text = "" Or tbxRefDocNum.Text = "" Then
                lblError.Visible = True
                lblError.Text = "Fields with '*' are required!"

                If cbxRefDocType.SelectedIndex = -1 Then
                    lblErrDocType.Visible = True
                Else
                    lblErrDocType.Visible = False
                End If

                If cbxSender.SelectedIndex = -1 Then
                    lblErrSender.Visible = True
                Else
                    lblErrSender.Visible = False
                End If

                If tbxSenderName.Text = "" Then
                    lblErrSenderName.Visible = True
                Else
                    lblErrSenderName.Visible = False
                End If

                If tbxRefDocNum.Text = "" Then
                    lblErrDocNum.Visible = True
                Else
                    lblErrDocNum.Visible = False
                End If
            Else
                lblError.Visible = False
                lblErrDocNum.Visible = False
                lblErrSenderName.Visible = False
                lblErrSender.Visible = False
                lblErrDocType.Visible = False
                'MsgBox("Add this one")
                q.addRecvTransactions(docTypeId, tbxRefDocNum.Text, dtpDocDate.Value, senderId, tbxSenderName.Text, mainForm.userId, Me.transId)
                Me.transId = ""
                dtpDocDate.Value = Now()
                cbxRefDocType.SelectedIndex = -1
                docTypeId = ""
                cbxSender.SelectedIndex = -1
                senderId = ""
                tbxDocEntry.Text = ""
                tbxRefDocNum.Text = ""
                tbxSenderName.Text = ""
                loadDGV()
            End If
        ElseIf transId = "" And dgvProdDet.rows.Count = 0 Then
            MessageBox.Show("Input Valid Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblError.Visible = True
            lblError.Text = "Select Product First!"
            tbxPDno.Select()
            lblError.Visible = True
            lblErrDocNum.Visible = True
            lblErrSenderName.Visible = True
            lblErrSender.Visible = True
            lblErrDocType.Visible = True
            Exit Sub
        Else


        End If
    End Sub

    Private Sub tbxPDno_TextChanged(sender As Object, e As EventArgs) Handles tbxPDno.TextChanged
        q.fetchProdDesc(tbxPDno.Text)
        If String.IsNullOrWhiteSpace(tbxProdDesc.Text) Then
            tbxPDno.Text = ""
        End If
    End Sub

    Private Sub btnAddBatch_Click(sender As Object, e As EventArgs) Handles btnAddBatch.Click
        mainForm.Enabled = False
        Me.Enabled = False
        addBatch.Show()
    End Sub

    Private Sub btnAddLoc_Click(sender As Object, e As EventArgs) Handles btnAddLoc.Click
        mainForm.Enabled = False
        Me.Enabled = False
        addLocation.Show()
    End Sub

    Sub loadTbxBatch()
        With tbxBatch
            .Text = ""
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim colBat As New AutoCompleteStringCollection()
            q.populateBatchTbx(colBat)
            .AutoCompleteCustomSource = colBat
        End With
    End Sub

    'get the batch id in the goods section
    Private Sub tbxBatch_Leave(sender As Object, e As EventArgs) Handles tbxBatch.Leave
        'q.validateBatch(tbxBatch.Text)
        batchId = q.validateBatch(tbxBatch.Text)
        'MsgBox(batchId)
    End Sub

    Sub loadTbxLoc()
        With tbxLoc
            .Text = ""
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim colLoc As New AutoCompleteStringCollection()
            q.populateLocTbx(colLoc)
            .AutoCompleteCustomSource = colLoc
        End With
    End Sub

    'get the location in the goods section
    Private Sub tbxLoc_Leave(sender As Object, e As EventArgs) Handles tbxLoc.Leave
        locId = q.validateLoc(tbxLoc.Text)
    End Sub

    Private Sub btnAddProdtoDgv_Click(sender As Object, e As EventArgs) Handles btnAddProdtoDgv.Click
        If String.IsNullOrWhiteSpace(tbxDocEntry.Text) Then
            'empty tbx document and datagrid view
            If String.IsNullOrWhiteSpace(tbxPDno.Text) Or String.IsNullOrWhiteSpace(tbxLoc.Text) Or String.IsNullOrWhiteSpace(tbxQty.Text) Then
                lblError.Text = "Fields with '*' are required!"

                If String.IsNullOrWhiteSpace(tbxPDno.Text) Then
                    lblErrorPDNum.Visible = True
                Else
                    lblErrorPDNum.Visible = False
                End If

                If String.IsNullOrWhiteSpace(tbxLoc.Text) Then
                    lblErrLoc.Visible = True
                Else
                    lblErrLoc.Visible = False
                End If

                If String.IsNullOrWhiteSpace(tbxQty.Text) Then
                    lblErrQty.Visible = True
                Else
                    lblErrQty.Visible = False
                End If
            Else
                lblError.Visible = False
                lblErrorPDNum.Visible = False
                lblErrLoc.Visible = False
                lblErrQty.Visible = False
                q.addTransDetails(tbxPDno.Text, batchId, locId, mainForm.areaCodeId, tbxQty.Text, Me.transId)
                tbxPDno.Text = ""
                tbxBatch.Text = ""
                tbxLoc.Text = ""
                tbxQty.Text = ""
                tbxPDno.Select()
                loadDGV()
            End If

        ElseIf Me.transId <> "" Then
            'not empty tbx document and datagridview
            If String.IsNullOrWhiteSpace(tbxPDno.Text) Or String.IsNullOrWhiteSpace(tbxLoc.Text) Or String.IsNullOrWhiteSpace(tbxQty.Text) Then
                lblError.Text = "Fields with '*' are required!"
                tbxPDno.Select()
                If String.IsNullOrWhiteSpace(tbxPDno.Text) Then
                    lblErrorPDNum.Visible = True
                    tbxPDno.Select()
                Else
                    lblErrorPDNum.Visible = False
                End If

                If String.IsNullOrWhiteSpace(tbxLoc.Text) Then
                    lblErrLoc.Visible = True
                    tbxLoc.Select()
                Else
                    lblErrLoc.Visible = False
                End If

                If String.IsNullOrWhiteSpace(tbxQty.Text) Then
                    lblErrQty.Visible = True
                    tbxQty.Select()
                Else
                    lblErrQty.Visible = False
                End If
            Else
                lblError.Visible = False
                lblErrorPDNum.Visible = False
                lblErrLoc.Visible = False
                lblErrQty.Visible = False
                q.addTransDetails(tbxPDno.Text, batchId, locId, mainForm.areaCodeId, tbxQty.Text, Me.transId)
                tbxPDno.Text = ""
                tbxBatch.Text = ""
                tbxLoc.Text = ""
                tbxQty.Text = ""
                tbxPDno.Select()
                loadDGV()
            End If
        End If
    End Sub

    Sub hideAllErrLbls()
        lblError.Visible = False
        lblErrDocType.Visible = False
        lblErrDocNum.Visible = False
        lblErrSender.Visible = False
        lblErrorPDNum.Visible = False
        lblErrLoc.Visible = False
        lblErrQty.Visible = False
    End Sub

    Private Sub cbxRefDocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRefDocType.SelectedIndexChanged
        docTypeId = q.fetchRefDocType(cbxRefDocType.Text)
        'MsgBox(docTypeId)
    End Sub

    Private Sub cbxSender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSender.SelectedIndexChanged
        senderId = q.fetchSenderId(cbxSender.Text)
        'MsgBox(senderId)
    End Sub

    Private Sub loadDGV()
        'q.employeesLoadDGV()
        q.loadProdDGV(transId)
        dgvProdDet.ClearSelection()
        prodId = ""
        'for adjusting data to display
        dtSource = q.SQL.DBDT
        p.fillDgv(cbxPagesize.Text, dtSource)
        p.LoadPage(dtSource, dgvProdDet, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)

        If p.PageCount = 1 Then
            btnNext.Enabled = False
            btnLast.Enabled = False
        Else
            btnNext.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub

    Private Sub recvGoodsTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then
            If prodId <> "" Then
                Dim result As Integer = MessageBox.Show("Are you sure want to remove?", "Remove Details", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    loadDGV()
                ElseIf result = DialogResult.Yes Then
                    q.deleteSelectedProd(prodId)
                    prodId = ""
                    loadDGV()
                End If
            Else
                MessageBox.Show("No selected items?", "Remove Details")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub recvGoodsTrans_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If transId = "" Then
            Dim result As Integer = MessageBox.Show("Are you sure want to close?", "Notice", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                e.Cancel = True
            ElseIf result = DialogResult.Yes Then
                e.Cancel = False
                With mainForm
                    .Select()
                    .Focus()
                End With
            End If
        ElseIf transId <> "" And dgvProdDet.RowCount <> 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure want to cancel?", "Notice", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                e.Cancel = True
            ElseIf result = DialogResult.Yes Then
                e.Cancel = False
                With mainForm
                    .Select()
                    .Focus()
                End With
                'delete this cancelled transc
                q.deleteCancelledRecvTrans(transId)
            End If
        End If
    End Sub

End Class