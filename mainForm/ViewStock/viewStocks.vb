Public Class viewStocks
    Private q As New qry
    Private p As New dgvPaging
    Private dtSource As DataTable
    Private selectedId As String = ""

    Private Sub loadDGVNonFilter()
        q.loadStocksDGV()
        dgvStocks.ClearSelection()
        'for adjusting data to display
        dtSource = q.SQL.DBDT
        p.fillDgv(cbxPagesize.Text, dtSource)
        p.LoadPage(dtSource, dgvStocks, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)

        If p.PageCount = 1 Then
            btnNext.Enabled = False
            btnLast.Enabled = False
        Else
            btnNext.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub

    Private Sub loadDGVFilter()
        q.loadStocksDGVFilter(tbxFilter.Text)
        dgvStocks.ClearSelection()
        'for adjusting data to display
        dtSource = q.SQL.DBDT
        p.fillDgv(cbxPagesize.Text, dtSource)
        p.LoadPage(dtSource, dgvStocks, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)

        If p.PageCount = 1 Then
            btnNext.Enabled = False
            btnLast.Enabled = False
        Else
            btnNext.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub

    '=====================================================================================================
    'FOR the DATAGRID VIEW

    'Clicking the dgv
    Private Sub dgvStocks_click(ByVal sender As Object, ByVal e As EventArgs) Handles dgvStocks.Click
        lblError.Visible = False
        If dgvStocks.Rows.Count = 0 Then
            MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If dgvStocks.SelectedRows.Count > 0 Then
                selectedId = ""
                selectedId = dgvStocks.CurrentRow.Cells(0).Value
                'MsgBox(Me.selectedId)
            End If
        End If
    End Sub
    Private Sub dgvStocks_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        Me.dgvStocks.RowsDefaultCellStyle.BackColor = Color.White
        Me.dgvStocks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub dgvStocks_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
        dgvStocks.ClearSelection()

        If dgvStocks.Rows.Count > 0 Then
            lblError.Text = ""
        Else
            lblError.Text = "No results found..."
        End If
    End Sub
    Public Sub loadDataGridView()
        dgvStocks.ClearSelection()
        adjustDGv()
    End Sub
    Public Sub adjustDGv()
        'for adjusting data to display
        dtSource = q.SQL.DBDT
        p.fillDgv(cbxPagesize.Text, dtSource)
        p.LoadPage(dtSource, dgvStocks, cbxPagesize.Text)
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
        p.tofirstpage(dtSource, dgvStocks, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        dtSource = q.SQL.DBDT
        p.previouspage(dtSource, dgvStocks, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        dtSource = q.SQL.DBDT
        p.nextpage(dtSource, dgvStocks, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        dtSource = q.SQL.DBDT
        p.tolastpage(dtSource, dgvStocks, cbxPagesize.Text)
        p.DisplayPageInfo(lblPage)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If String.IsNullOrWhiteSpace(tbxFilter.Text) Then
            loadDGVNonFilter()
        Else
            loadDGVFilter()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxFilter.Text = ""
        loadDGVNonFilter()
    End Sub

    Private Sub viewStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxPagesize.SelectedIndex = 2 'set page size to 10
        loadDGVNonFilter()
    End Sub

End Class