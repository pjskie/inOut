Imports System.Data.DataTable

Public Class recvGoodsTrans
    Private q As New qry
    Private p As New dgvPaging
    Private table As New DataTable("Table")
    'hold the id of the details 
    Public prodId As Integer
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
    'hold the selectedId 
    Private selectedRowCell As Integer = 0

    'form load
    Private Sub recvGoodsTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newDGV()
        'cbxPagesize.SelectedIndex = 2 'set page size to 10
        tbxDocEntry.Text = "" 'set temporarily doc entry as 000
        loadTbxBatch() 'autosuggest tbx batch
        loadTbxLoc() 'autosugget tbx loc
        loadTbxProdNo() 'autosugest tbx PDNO
        loadTbxProdDes() 'autosuggest tbx pd des
        q.cbxSender(cbxSender) 'load combobox list of senders
        loadtbxRefDocType()
        'q.cbxDocType(cbxRefDocType) 'load combobx list of document types
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If transId <> "" And dgvProdDet.Rows.Count <> 0 Then
            If tbxRefDocType.Text = "" Or cbxSender.SelectedIndex = -1 Or tbxSenderName.Text = "" Or tbxRefDocNum.Text = "" Then
                lblError.Visible = True
                lblError.Text = "Fields with '*' are required!"

                If tbxRefDocType.Text = "" Then
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
                'q.addRecvTransactions(docTypeId, tbxRefDocNum.Text, dtpDocDate.Value, senderId, tbxSenderName.Text, mainForm.userId, Me.transId)
                q.addRecvTransactions(transId, dtpDocDate.Value, docTypeId, tbxRefDocNum.Text, senderId, tbxSenderName.Text, mainForm.areaCodeId)
                table.Clear()
                Me.transId = ""
                dtpDocDate.Value = Now()
                tbxRefDocType.Text = ""
                docTypeId = ""
                cbxSender.SelectedIndex = -1
                senderId = ""
                tbxDocEntry.Text = ""
                tbxRefDocNum.Text = ""
                tbxSenderName.Text = ""
            End If
        ElseIf transId = "" And dgvProdDet.Rows.Count = 0 Then
            MessageBox.Show("Input Valid Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblError.Visible = True
            lblError.Text = "Select Product First!"
            tbxPDno.Select()
            Exit Sub
        Else


        End If
    End Sub

    'Private Sub tbxPDno_TextChanged(sender As Object, e As EventArgs) Handles tbxPDno.TextChanged
    '    q.fetchProdDesc(tbxPDno.Text)
    '    If String.IsNullOrWhiteSpace(tbxProdDesc.Text) Then
    '        tbxPDno.Text = ""
    '    End If
    'End Sub

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

    Sub loadTbxProdDes()
        With tbxProdDesc
            .Text = ""
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim colPDDes As New AutoCompleteStringCollection()
            q.populatePDDesTbx(colPDDes)
            .AutoCompleteCustomSource = colPDDes
            '.Text = "Bullshit"
        End With
    End Sub

    Sub loadtbxRefDocType()
        With tbxRefDocType
            .Text = ""
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim colRefDoc As New AutoCompleteStringCollection()
            q.populateTbxRefDocType(colRefDoc)
            .AutoCompleteCustomSource = colRefDoc
            '.Text = "Bullshit"
        End With
    End Sub

    Private Sub tbxRefDocType_Leave(sender As Object, e As EventArgs) Handles tbxRefDocType.Leave
        docTypeId = q.getRefDoctype(tbxRefDocType.Text)
        MsgBox(docTypeId)
    End Sub

    Private Sub tbxProdDesc_Leave(sender As Object, e As EventArgs) Handles tbxProdDesc.Leave
        q.fetchPDNOTbxDes(tbxProdDesc.Text)
    End Sub

    Sub loadTbxProdNo()
        With tbxPDno
            .Text = ""
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim colPDNO As New AutoCompleteStringCollection()
            q.populatetbxPDNO(colPDNO)
            .AutoCompleteCustomSource = colPDNO
            '.Text = "Bullshit"
        End With
    End Sub

    Private Sub tbxPDno_Leave(sender As Object, e As EventArgs) Handles tbxPDno.Leave
        q.fetchtbxPDNO(tbxPDno.Text)
    End Sub
    Private Sub btnAddProdtoDgv_Click(sender As Object, e As EventArgs) Handles btnAddProdtoDgv.Click
        If String.IsNullOrWhiteSpace(tbxDocEntry.Text) And transId = "" Then
            If String.IsNullOrWhiteSpace(tbxPDno.Text) Or String.IsNullOrWhiteSpace(tbxLoc.Text) Or String.IsNullOrWhiteSpace(tbxQty.Text) Then
                lblError.Text = "Fields with '*' are required!"
                lblError.Visible = True
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
            ElseIf tbxQty.Text = 0 Then
                tbxQty.Clear()
            Else
                hideAllErrLbls()
                q.addTransDetailsforUnqHeader()
                insertRecvTransToDGV()
                'MsgBox("Add this one")
                'insertRecvTransToDGV()
                tbxPDno.Text = ""
                tbxProdDesc.Text = ""
                tbxBatch.Text = ""
                tbxLoc.Text = ""
                tbxQty.Text = ""
                batchId = ""
                locId = ""
            End If
        ElseIf Not String.IsNullOrWhiteSpace(tbxDocEntry.Text) And transId <> "" Then
            If String.IsNullOrWhiteSpace(tbxPDno.Text) Or String.IsNullOrWhiteSpace(tbxLoc.Text) Or String.IsNullOrWhiteSpace(tbxQty.Text) Then
                lblError.Text = "Fields with '*' are required!"
                lblError.Visible = True
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
            ElseIf tbxQty.Text = 0 Then
                tbxQty.Clear()
            Else
                hideAllErrLbls()
                insertRecvTransToDGV()
                tbxPDno.Text = ""
                tbxProdDesc.Text = ""
                tbxBatch.Text = ""
                tbxLoc.Text = ""
                tbxQty.Text = ""
                batchId = ""
                locId = ""
            End If
        Else
            'do nothing
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

    Sub hideProdErr()
        lblErrorPDNum.Visible = False
        lblErrLoc.Visible = False
        lblErrQty.Visible = False
    End Sub

    'Private Sub cbxRefDocType_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    docTypeId = q.fetchRefDocType(cbxRefDocType.Text)
    '    'MsgBox(docTypeId)
    'End Sub

    Private Sub cbxSender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSender.SelectedIndexChanged
        senderId = q.fetchSenderId(cbxSender.Text)
        'MsgBox(senderId)
    End Sub



    Private Sub recvGoodsTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then

            Dim result As Integer = MessageBox.Show("Are you sure want to remove?", "Remove Details", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                '
            ElseIf result = DialogResult.Yes Then
                table.Rows.RemoveAt(prodId)
            End If

        End If
    End Sub

    Private Sub recvGoodsTrans_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If transId = "" And dgvProdDet.RowCount = 0 Then
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

    Sub newDGV()
        Try
            With table
                .Columns.Add("transId", Type.GetType("System.String"))  '0
                .Columns.Add("PDNO", Type.GetType("System.String"))     '1
                .Columns.Add("DESCRIPTION", Type.GetType("System.String"))     '2
                .Columns.Add("bId", Type.GetType("System.String"))       '3
                .Columns.Add("lId", Type.GetType("System.String"))     '4
                .Columns.Add("aId", Type.GetType("System.String"))     '5
                .Columns.Add("BATCH", Type.GetType("System.String"))       '6
                .Columns.Add("LOCATION", Type.GetType("System.String"))       '7
                .Columns.Add("QUANTITY", Type.GetType("System.String"))       '9
            End With
            With dgvProdDet
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .AllowUserToAddRows = False
                .RowTemplate.Height = 30
                .DataSource = table
                .Columns(0).Visible = False
                .Columns(1).Width = 80
                .Columns(2).Width = 299
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Width = 80
                .Columns(7).Width = 80
                .Columns(8).Width = 80
                .ClearSelection()
                .Columns("PDNO").ReadOnly = True
                .Columns("DESCRIPTION").ReadOnly = True
                .Columns("BATCH").ReadOnly = True
                .Columns("LOCATION").ReadOnly = True
                .Columns("QUANTITY").ReadOnly = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub insertRecvTransToDGV()
        Try
            table.Rows.Add(transId, tbxPDno.Text, tbxProdDesc.Text, batchId, locId, mainForm.areaCodeId, tbxBatch.Text, tbxLoc.Text, tbxQty.Text)
            dgvProdDet.DataSource = table
            dgvProdDet.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvProdDet_Click(sender As Object, e As EventArgs)
        If dgvProdDet.Rows.Count = 0 Then
            MessageBox.Show("Please selec valid cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            prodId = dgvProdDet.CurrentCell.RowIndex
            'MsgBox(prodId)
        End If
    End Sub





    'Private Sub tbxProdDesc_Leave(sender As Object, e As EventArgs) Handles tbxProdDesc.Leave
    '    q.fetchProdPDNO(tbxProdDesc.Text)
    '    If String.IsNullOrWhiteSpace(tbxPDno.Text) Then
    '        tbxPDno.Text = ""
    '        tbxProdDesc.Text = ""
    '    End If
    'End Sub

End Class