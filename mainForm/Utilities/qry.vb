Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Image

Public Class qry
    Public SQL As New sqlCon
    Private f As New functions
    Public errMsg As String = ""

    'sign in
    Public Sub signIn(user As String, pass As String)

        SQL.AddParam("@user", user)
        SQL.AddParam("@pass", pass)

        SQL.ExecQueryDT("SELECT * FROM tbl_employeeDetails T0
                        JOIN tbl_users T1 ON T1.emp_id = T0.id
                        WHERE T1.username = @user AND T1.pass = @pass AND T0.status = 1;;")
        'if error exit sub
        If SQL.HasException(True) Then Exit Sub
        'if not error get the empType and empId
        If SQL.DBDT.Rows.Count > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                With mainForm
                    'set the session id in main form
                    .userId = r("emp_id")
                    .roleId = r("role_id")
                    .areaCodeId = r("area_id")
                    .isAdmin = r("isAdmin")
                End With
            Next
            'logIn(mainForm.userId)
            MessageBox.Show("Login Successfully.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With loginForm
                .lblError.Visible = False
                .lblErrorUser.Visible = False
                .lblErrorPas.Visible = False
                .tbxUser.Text = ""
                .tbxPass.Text = ""
                .tbxUser.Select()
            End With
            mainForm.Show()
            loginForm.Hide()
        Else
            MessageBox.Show("Invalid Account, try again.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With loginForm
                .lblError.Visible = False
                .lblErrorUser.Visible = False
                .lblErrorPas.Visible = False
                .tbxUser.Text = ""
                .tbxPass.Text = ""
                .tbxUser.Select()
            End With
        End If

    End Sub
    'end login

    'add document type
    Public Sub addDOcType(txt As String)
        SQL.AddParam("@txt", txt.ToString().ToUpper())
        SQL.ExecQueryDT("select * from [dbo].[tbl_documentTypes]
                        where docDesc = @txt;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            With addDocTypes
                .lblError.Visible = True
                .lblError.ForeColor = Color.Red
                .lblError.Text = "Already exist"
            End With
            'Already exist
            Exit Sub
        Else
            SQL.AddParam("@txt", txt.ToString().ToUpper())
            SQL.AddParam("@encBy", mainForm.userId)
            SQL.ExecQueryDT("INSERT INTO [dbo].[tbl_documentTypes]
            VALUES (@txt,@encBy);")
            If SQL.HasException(True) Then Exit Sub
            With addDocTypes
                .lblError.Visible = True
                .lblError.ForeColor = Color.Green
                .lblError.Text = "Successfully Added!"
            End With
        End If
    End Sub
    'end add document type

    'add area code
    Public Sub addAreaCode(txt As String)
        SQL.AddParam("@txt", txt.ToString().ToUpper())
        SQL.ExecQueryDT("SELECT * FROM [dbo].[tbl_areaCodes]
                        WHERE areaDes = @txt;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            With addAreas
                .lblError.Visible = True
                .lblError.ForeColor = Color.Red
                .lblError.Text = "Already exist"
            End With
            'Already exist
            Exit Sub
        Else
            SQL.AddParam("@txt", txt.ToString().ToUpper())
            SQL.AddParam("@encBy", mainForm.userId)
            SQL.ExecQueryDT("INSERT INTO [dbo].[tbl_areaCodes]
                             VALUES (@txt,@encBy);")
            If SQL.HasException(True) Then Exit Sub
            With addAreas
                .lblError.Visible = True
                .lblError.ForeColor = Color.Green
                .lblError.Text = "Successfully Added!"
            End With
        End If
    End Sub
    'end add area code

    'populate combobox doc type
    Public Sub cbxSender(cbx As ComboBox)
        cbx.Items.Clear()
        With mainForm
            If .isAdmin = True Then
                'identify if the acc is admin
                SQL.ExecQueryDS("SELECT areaDes FROM [dbo].[tbl_areaCodes]
                        ORDER BY areaDes;")
                If SQL.HasException(True) Then Exit Sub

                If SQL.RecordCountDS > 0 Then
                    For Each r As DataRow In SQL.DBDS.Tables(0).Rows
                        cbx.Items.Add(r(0))
                    Next
                    cbx.SelectedIndex = -1
                End If
            ElseIf .isAdmin = False Then
                'identify if the acc is not admin
                SQL.AddParam("@id", mainForm.areaCodeId)
                SQL.ExecQueryDS("SELECT areaDes FROM [dbo].[tbl_areaCodes]
                        WHERE id NOT IN (@id)
                        ORDER BY areaDes;")
                If SQL.HasException(True) Then Exit Sub

                If SQL.RecordCountDS > 0 Then
                    For Each r As DataRow In SQL.DBDS.Tables(0).Rows
                        cbx.Items.Add(r(0))
                    Next
                    cbx.SelectedIndex = -1
                End If
            Else
                'aws
            End If
        End With
    End Sub
    'end

    'populate sender combobox
    Public Sub cbxDocType(cbx As ComboBox)
        cbx.Items.Clear()
        With mainForm
            If .isAdmin = True Then
                'if admin acc
                SQL.ExecQueryDS("select docDesc from tbl_documentTypes
                                order by docDesc;")
                If SQL.HasException(True) Then Exit Sub

                If SQL.RecordCountDS > 0 Then
                    For Each r As DataRow In SQL.DBDS.Tables(0).Rows
                        cbx.Items.Add(r(0))
                    Next
                    cbx.SelectedIndex = -1
                End If
            ElseIf .isAdmin = False Then
                'if not admin acc
                SQL.ExecQueryDS("select docDesc from tbl_documentTypes
                                order by docDesc;")
                If SQL.HasException Then Exit Sub

                If SQL.RecordCountDS > 0 Then
                    For Each r As DataRow In SQL.DBDS.Tables(0).Rows
                        cbx.Items.Add(r(0))
                    Next
                    cbx.SelectedIndex = -1
                End If
            Else
                'aws
            End If
        End With
    End Sub
    'end

    'fetch product des
    Public Sub fetchProdDesc(id As String)
        SQL.AddParam("@id", id)
        SQL.ExecQueryDT("SELECT goodDes FROM [dbo].[tbl_goods] WHERE id = @id;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                recvGoodsTrans.tbxProdDesc.Text = r(0)
            Next
        Else
            recvGoodsTrans.tbxProdDesc.Text = ""
        End If
    End Sub
    'end

    'fetch product no
    Public Sub fetchProdPDNO(id As String)
        SQL.AddParam("@id", id)
        SQL.ExecQueryDT("SELECT id FROM [dbo].[tbl_goods] WHERE goodDes = @id;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                recvGoodsTrans.tbxPDno.Text = r(0)
            Next
        Else
            recvGoodsTrans.tbxPDno.Text = ""
        End If
    End Sub
    'end

    'add batches
    Public Sub addBatches(txt As String, rmks As String)
        SQL.AddParam("@txt", txt.ToString().ToUpper())
        SQL.ExecQueryDT("SELECT * FROM [dbo].[tbl_batches]
                        WHERE batchDes =  @txt;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            With addBatch
                .lblError.Visible = True
                .lblError.ForeColor = Color.Red
                .lblError.Text = "Already exist"
            End With
            'Already exist
            Exit Sub
        Else
            SQL.AddParam("@txt", txt.ToString().ToUpper())
            SQL.AddParam("@rmks", rmks.ToString())
            SQL.AddParam("@encBy", mainForm.userId)
            SQL.ExecQueryDT("INSERT INTO [dbo].[tbl_batches]
                            VALUES(@txt,@encBy,@rmks);")
            If SQL.HasException(True) Then Exit Sub
            With addBatch
                .lblError.Visible = True
                .lblError.ForeColor = Color.Green
                .lblError.Text = "Successfully Added!"
            End With
        End If
    End Sub
    'end

    Public Sub addLocations(txt As String)
        SQL.AddParam("@txt", txt.ToString().ToUpper())
        SQL.AddParam("@aId", mainForm.areaCodeId)
        SQL.ExecQueryDT("SELECT * FROM tbl_locations
                        WHERE locationDes =@txt AND area_id =@aId;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            With addLocation
                .lblError.Visible = True
                .lblError.ForeColor = Color.Red
                .lblError.Text = "Already exist"
            End With
            'Already exist
            Exit Sub
        Else
            SQL.AddParam("@txt", txt.ToString().ToUpper())
            SQL.AddParam("@encBy", mainForm.userId)
            SQL.AddParam("@aId", mainForm.areaCodeId)
            SQL.ExecQueryDT("INSERT INTO [dbo].[tbl_locations]
                            VALUES (@txt, @encBy, @aId);")
            If SQL.HasException(True) Then Exit Sub
            With addLocation
                .lblError.Visible = True
                .lblError.ForeColor = Color.Green
                .lblError.Text = "Successfully Added!"
            End With
        End If
    End Sub

    'populate batch textbox
    Public Sub populateBatchTbx(ByVal d As AutoCompleteStringCollection)
        SQL.ExecQueryDT("select batchDes from tbl_batches;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                d.Add(r(0)).ToString()
            Next
        End If
    End Sub
    'end

    'check if the batch is valid
    Public Function validateBatch(ByVal s As String)
        Dim id As String = ""

        SQL.AddParam("@s", s)
        SQL.ExecQueryDT("SELECT id FROM tbl_batches
                        WHERE batchDes = @s;")
        If SQL.HasException(True) Then Return Nothing

        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                id = r(0)
            Next
        Else
            With recvGoodsTrans
                .tbxBatch.Text = ""
                id = ""
            End With
        End If

        Return id
    End Function


    'populate loc textbox
    Public Sub populateLocTbx(ByVal d As AutoCompleteStringCollection)
        With mainForm
            If .isAdmin = True Then

            ElseIf .isAdmin = False Then
                SQL.AddParam("@aId", .areaCodeId)
                'SQL.ExecQueryDT("SELECT locationDes FROM tbl_locations
                '        WHERE area_id = @aId;")
                SQL.ExecQueryDT("SELECT locationDes FROM tbl_locations;")
                If SQL.HasException(True) Then Exit Sub
                If SQL.RecordCountDT > 0 Then
                    For Each r As DataRow In SQL.DBDT.Rows
                        d.Add(r(0)).ToString()
                    Next
                End If
            End If
        End With

    End Sub
    'end

    'populate prod des textbox
    Public Sub populatePDDesTbx(ByVal d As AutoCompleteStringCollection)
        With mainForm
            If .isAdmin = True Then

            ElseIf .isAdmin = False Then
                SQL.AddParam("@aId", .areaCodeId)
                'SQL.ExecQueryDT("SELECT locationDes FROM tbl_locations
                '        WHERE area_id = @aId;")
                SQL.ExecQueryDT("SELECT goodDes FROM tbl_goods;")
                If SQL.HasException(True) Then Exit Sub
                If SQL.RecordCountDT > 0 Then
                    For Each r As DataRow In SQL.DBDT.Rows
                        d.Add(r(0)).ToString()
                    Next
                End If
            End If
        End With
    End Sub
    'end

    'populate prodno textbox
    Public Sub populatetbxPDNO(ByVal d As AutoCompleteStringCollection)
        With mainForm
            If .isAdmin = True Then

            ElseIf .isAdmin = False Then
                SQL.AddParam("@aId", .areaCodeId)
                'SQL.ExecQueryDT("SELECT locationDes FROM tbl_locations
                '        WHERE area_id = @aId;")
                SQL.ExecQueryDT("SELECT id from tbl_goods;")
                If SQL.HasException(True) Then Exit Sub
                If SQL.RecordCountDT > 0 Then
                    For Each r As DataRow In SQL.DBDT.Rows
                        d.Add(r(0)).ToString()
                    Next
                End If
            End If
        End With
    End Sub
    'end

    'populate prodno textbox
    Public Sub populateTbxRefDocType(ByVal d As AutoCompleteStringCollection)
        With mainForm
            If .isAdmin = True Then

            ElseIf .isAdmin = False Then
                SQL.AddParam("@aId", .areaCodeId)
                'SQL.ExecQueryDT("SELECT locationDes FROM tbl_locations
                '        WHERE area_id = @aId;")
                SQL.ExecQueryDT("SELECT docDesc FROM tbl_documentTypes;")
                If SQL.HasException(True) Then Exit Sub
                If SQL.RecordCountDT > 0 Then
                    For Each r As DataRow In SQL.DBDT.Rows
                        d.Add(r(0)).ToString()
                    Next
                End If
            End If
        End With
    End Sub
    'end

    'fetch pdno and descrip if leaving the tbxprodes
    Public Sub fetchPDNOTbxDes(t As String)
        SQL.AddParam("@txt", t)
        SQL.ExecQueryDT("SELECT * FROM tbl_goods
                        WHERE goodDes = @txt;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                With recvGoodsTrans
                    .tbxPDno.Text = ""
                    .tbxProdDesc.Text = ""
                    .tbxPDno.Text = r(0)
                    .tbxProdDesc.Text = r(1)
                End With
            Next
        Else
            With recvGoodsTrans
                .tbxPDno.Text = ""
                .tbxProdDesc.Text = ""
            End With
        End If

    End Sub
    'end

    'fetch pdno and descrip if leaving the tbxprodes
    Public Sub fetchtbxPDNO(t As String)
        SQL.AddParam("@txt", t)
        SQL.ExecQueryDT("SELECT * FROM tbl_goods
                        WHERE id = @txt;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                With recvGoodsTrans
                    .tbxPDno.Text = ""
                    .tbxProdDesc.Text = ""
                    .tbxPDno.Text = r(0)
                    .tbxProdDesc.Text = r(1)
                End With
            Next
        Else
            With recvGoodsTrans
                .tbxPDno.Text = ""
                .tbxProdDesc.Text = ""
            End With
        End If

    End Sub
    'end

    ''fetch pdno and descrip if leaving the tbxprodes
    'Public Sub getRefDoctype(t As String)
    '    SQL.AddParam("@txt", t)
    '    SQL.ExecQueryDT("SELECT id FROM tbl_documentTypes
    '                    WHERE docDesc = 
    '                    @txt;")
    '    If SQL.HasException(True) Then Exit Sub
    '    If SQL.RecordCountDT > 0 Then
    '        For Each r As DataRow In SQL.DBDT.Rows
    '            With recvGoodsTrans
    '                .tbxRefDocType.Text = ""
    '                .tbxRefDocType.Text = r(0)
    '            End With
    '        Next
    '    Else
    '        With recvGoodsTrans
    '            .tbxRefDocType.Text = ""
    '        End With
    '    End If
    'End Sub
    ''end

    'check if the loc is valid
    Public Function getRefDoctype(ByVal s As String)
        Dim id As String = ""

        SQL.AddParam("@txt", s)
        SQL.ExecQueryDT("SELECT id FROM tbl_documentTypes
                            WHERE docDesc = 
                            @txt;")
        If SQL.HasException(True) Then Return Nothing

        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                id = ""
                id = r(0)
            Next
        Else
            With recvGoodsTrans
                .tbxRefDocType.Text = ""
                id = ""
            End With
        End If

        Return id
    End Function

    'check if the loc is valid
    Public Function validateLoc(ByVal s As String)
        Dim id As String = ""

        SQL.AddParam("@s", s)
        SQL.AddParam("@aId", mainForm.areaCodeId)
        'SQL.ExecQueryDT("SELECT id FROM tbl_locations
        '                        WHERE locationDes = @s AND area_id = @aId;")
        SQL.ExecQueryDT("SELECT id FROM tbl_locations
                                WHERE locationDes = @s;")
        If SQL.HasException(True) Then Return Nothing

        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                id = r(0)
            Next
        Else
            With recvGoodsTrans
                .tbxLoc.Text = ""
                id = ""
            End With
        End If

        Return id
    End Function
    'end


    'fetch id of ref doc type
    Public Function fetchRefDocType(ByVal t As String)
        Dim id As String = ""

        SQL.AddParam("@txt", t)
        SQL.ExecQueryDT("SELECT id FROM tbl_documentTypes
                        WHERE docDesc = @txt;")
        If SQL.HasException(True) Then Return Nothing

        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                id = r(0)
            Next
        End If
        Return id
    End Function
    'end

    'fetch id of sender
    Public Function fetchSenderId(ByVal t As String)
        Dim id As String = ""

        SQL.AddParam("@txt", t)
        SQL.ExecQueryDT("SELECT id FROM tbl_areaCodes
                    WHERE areaDes = @txt;")
        If SQL.HasException(True) Then Return Nothing

        If SQL.RecordCountDT > 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                id = r(0)
            Next
        End If

        Return id
    End Function
    'end

    'add Receive Details
    Public Sub addTransDetailsforUnqHeader()
        SQL.ExecQueryDT("DECLARE @getId AS INT 
                            EXEC spInsertTransRecvHeader @id = @getId OUTPUT
                            SELECT @getId")
        If SQL.HasException(True) Then Exit Sub
        For Each r As DataRow In SQL.DBDT.Rows
            With recvGoodsTrans
                .transId = r(0)
                .tbxDocEntry.Text = r(0)
            End With
        Next
    End Sub
    'end

    'load data grid view of product details
    'Public Sub loadProdDGV(t As String, Optional query As String = "")
    '    If query = "" Then
    '        SQL.AddParam("@t", t)
    '        SQL.ExecQueryDT("spSelectRecvGoodsDetails @t;")
    '    Else
    '        SQL.ExecQueryDT(query)
    '    End If
    '    If SQL.HasException(True) Then Exit Sub
    '    With recvGoodsTrans.dgvProdDet
    '        .AllowUserToResizeColumns = False
    '        .AllowUserToResizeRows = False
    '        .AllowUserToAddRows = False
    '        .AllowUserToOrderColumns = False
    '        .ReadOnly = True
    '        .DataSource = SQL.DBDT
    '        .ClearSelection()
    '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '        .Columns(0).Visible = False
    '        .Columns(1).HeaderText = "PD NO."
    '        .Columns(2).HeaderText = "DESCRIPTION"
    '        .Columns(3).HeaderText = "BATCH NAME"
    '        .Columns(4).HeaderText = "LOCATION NAME"
    '        .Columns(5).HeaderText = "AREA"
    '        .Columns(6).HeaderText = "QUANTITY"
    '        .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
    '        .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
    '        .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
    '        .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
    '        .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
    '        .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
    '        .Columns(1).Width = 30
    '        .Columns(2).Width = 100
    '        .Columns(3).Width = 50
    '        .Columns(4).Width = 50
    '        .Columns(5).Width = 30
    '        .Columns(6).Width = 90
    '        .RowTemplate.Height = 30
    '        ' Set the background color for all rows And for alternating rows. 
    '        'The value for alternating rows overrides the value for all rows. 
    '        .RowsDefaultCellStyle.BackColor = Color.LightGray
    '        .AlternatingRowsDefaultCellStyle.BackColor = Color.White

    '        'Set the row and column header styles.
    '        .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '        .ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
    '        .RowHeadersDefaultCellStyle.BackColor = Color.Black
    '    End With
    'End Sub
    'end

    'delete from dgv product details
    Public Sub deleteSelectedProd(id As String)
        SQL.AddParam("@id", id)
        SQL.ExecQueryDT("DELETE FROM tbl_transRecvDetails
                         WHERE id = @id;")
        If SQL.HasException(True) Then Exit Sub
    End Sub
    'end


    'update transaction recv header along with the recv details
    Public Sub addRecvTransactions(t As String, dd As Date, dt As String, drn As String, rf As String, frmn As String, ai As String)
        Dim goodId As String
        Dim batchId As String
        Dim locId As String
        Dim areaId As String
        Dim qty As Integer

        SQL.AddParam("@tId", t)
        SQL.AddParam("@dd", dd)
        SQL.AddParam("@dt", dt)
        SQL.AddParam("@drn", drn)
        SQL.AddParam("@rf", rf)
        SQL.AddParam("@frmn", frmn)
        SQL.AddParam("@ai", ai)
        'update table transRecvheader
        SQL.ExecQueryDT("EXEC spFinalUpdateforTransHeader
	                        @docType = @dt
	                        ,@docRefNum = @drn
	                        ,@docrefDate = @dd
	                        ,@orgId = @rf
	                        ,@orgName = @frmn
	                        ,@encBy = @ai
	                        ,@transId = @tId;")
        If SQL.HasException(True) Then Exit Sub
        'end
        'insert data in table transRecvDetails
        With recvGoodsTrans.dgvProdDet
            For i As Integer = 0 To .Rows.Count - 1 Step +1
                SQL.AddParam("@tId", t)
                SQL.AddParam("@gId", .Rows(i).Cells(1).Value.ToString)
                SQL.AddParam("@bId", .Rows(i).Cells(3).Value.ToString)
                SQL.AddParam("@lId", .Rows(i).Cells(4).Value.ToString)
                SQL.AddParam("@aId", ai)
                SQL.AddParam("@qty", .Rows(i).Cells(8).Value.ToString)

                SQL.ExecQueryDT("EXEC spADDTransRECVDetails
	                                @transId = @tId
	                                ,@gId = @gId
	                                ,@bId = @bId
	                                ,@lId = @lId
	                                ,@aId = @aId
	                                ,@qty = @qty;")
                If SQL.HasException(True) Then Exit Sub
            Next
        End With
        'end
        'selecting table transRecvDetails
        SQL.AddParam("@tId", t)
        SQL.ExecQueryDT("EXEC spSelectRECVTransDet @transId = @tId;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT <> 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                goodId = r("good_id")
                batchId = r("batch_id")
                locId = r("loc_id")
                areaId = r("area_id")
                qty = r("qty")
                SQL.AddParam("@gId", goodId)
                SQL.AddParam("@bId", batchId)
                SQL.AddParam("@lId", locId)
                SQL.AddParam("@aId", areaId)
                SQL.AddParam("@qty", qty)
                SQL.ExecQueryDT("EXEC spSELECTProducts
	                                @gId = @gId
	                                ,@bId = @bId
	                                ,@lId = @lId
	                                ,@aId = @aId;")
                If SQL.HasException(True) Then Exit Sub
                If SQL.RecordCountDT <> 0 Then
                    'update in the parameters are existing in tbl products
                    SQL.AddParam("@gId", goodId)
                    SQL.AddParam("@bId", batchId)
                    SQL.AddParam("@lId", locId)
                    SQL.AddParam("@aId", areaId)
                    SQL.AddParam("@qty", qty)
                    SQL.ExecQueryDT("EXEC spUPDATEProducts
	                                            @gId = @gId
	                                            ,@bId = @bId
	                                            ,@lId = @lId
	                                            ,@aId = @aId
	                                            ,@qty = @qty;")
                    If SQL.HasException(True) Then Exit Sub
                ElseIf SQL.RecordCountDT = 0 Then
                    'insert in the parameters are NOT existing in tbl products
                    SQL.AddParam("@gId", goodId)
                    SQL.AddParam("@bId", batchId)
                    SQL.AddParam("@lId", locId)
                    SQL.AddParam("@aId", areaId)
                    SQL.AddParam("@qty", qty)
                    SQL.ExecQueryDT("EXEC spINSERTProducts 
		                                        @gId =  @gId
		                                        ,@bId = @bId
		                                        ,@lId = @lId
		                                        ,@aId = @aId
		                                        ,@qty = @qty;")
                    If SQL.HasException(True) Then Exit Sub
                End If
            Next
        End If
        'end
        MessageBox.Show("Successfully Added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'end

    'load stocks
    Public Sub loadStocksDGV(Optional qry As String = "")
        If qry = "" Then
            With mainForm
                If .isAdmin = True Then
                    SQL.ExecQueryDT("SELECT 
                                T0.id
                                ,T0.good_id AS [PDNO]
		                        ,T1.goodDes AS [GDes]
		                        ,COALESCE(T2.batchDes,'Unspecified') AS [BDes]
		                        ,T3.locationDes AS [LDes]
		                        ,T4.areaDes	 AS [ADes]
		                        ,T0.qty AS [SOH]
		                        ,SUM(qty) OVER (PARTITION BY T1.goodDes,T0.Good_id ORDER BY T0.qty) AS [RTotal]
	                        FROM tbl_products T0
	                        JOIN tbl_goods T1 on T1.id = T0.good_id
	                        LEFT JOIN tbl_batches T2 ON t2.id = T0.batch_id
	                        JOIN tbl_locations T3 ON T3.id = T0.loc_id
	                        JOIN tbl_areaCodes T4 ON T4.id = T0.area_id;")
                    If SQL.HasException(True) Then Exit Sub
                Else
                    SQL.AddParam("@aid", .areaCodeId)
                    SQL.ExecQueryDT("SELECT 
                                    T0.id
                                    ,T0.good_id AS [PDNO]
                                    ,T1.goodDes AS [GDes]
                                        ,COALESCE(T2.batchDes,'Unspecified') AS [BDes]
                                        ,T3.locationDes AS [LDes]
                                        ,T4.areaDes	 AS [ADes]
                                        ,T0.qty AS [SOH]
                                        ,SUM(qty) OVER (PARTITION BY T1.goodDes,T0.Good_id ORDER BY T0.qty) AS [RTotal]
                                FROM tbl_products T0
                                JOIN tbl_goods T1 on T1.id = T0.good_id
                                LEFT JOIN tbl_batches T2 ON t2.id = T0.batch_id
                                JOIN tbl_locations T3 ON T3.id = T0.loc_id
                                JOIN tbl_areaCodes T4 ON T4.id = T0.area_id
                                WHERE T4.id = @aid;")
                    If SQL.HasException(True) Then Exit Sub
                End If
            End With
        Else
            SQL.ExecQueryDT(qry)
        End If
        viewStockDgvFOrmat()
    End Sub

    Public Sub loadStocksDGVFilter(fltr As String)
        SQL.AddParam("@fltr", fltr)
        With mainForm
            If .isAdmin = True Then
                loadStocksDGV("SELECT 
                                T0.id
                                ,T0.good_id AS [PDNO]
                                ,T1.goodDes AS [GDes]
                                ,COALESCE(T2.batchDes,'Unspecified') AS [BDes]
                                ,T3.locationDes AS [LDes]
                                ,T4.areaDes	 AS [ADes]
                                ,T0.qty AS [SOH]
                                ,SUM(qty) OVER (PARTITION BY T1.goodDes,T0.Good_id ORDER BY T0.qty) AS [RTotal]
                                FROM tbl_products T0
                                JOIN tbl_goods T1 on T1.id = T0.good_id
                                LEFT JOIN tbl_batches T2 ON t2.id = T0.batch_id
                                JOIN tbl_locations T3 ON T3.id = T0.loc_id
                                JOIN tbl_areaCodes T4 ON T4.id = T0.area_id
                                WHERE T1.goodDes LIKE CONCAT(@fltr,'%');")
                If SQL.HasException(True) Then Exit Sub
            Else
                SQL.AddParam("@aId", .areaCodeId)
                loadStocksDGV("SELECT 
                                T0.id
                                ,T0.good_id AS [PDNO]
                                ,T1.goodDes AS [GDes]
                                ,COALESCE(T2.batchDes,'Unspecified') AS [BDes]
                                ,T3.locationDes AS [LDes]
                                ,T4.areaDes	 AS [ADes]
                                ,T0.qty AS [SOH]
                                ,SUM(qty) OVER (PARTITION BY T1.goodDes,T0.Good_id ORDER BY T0.qty) AS [RTotal]
                                FROM tbl_products T0
                                JOIN tbl_goods T1 on T1.id = T0.good_id
                                LEFT JOIN tbl_batches T2 ON t2.id = T0.batch_id
                                JOIN tbl_locations T3 ON T3.id = T0.loc_id
                                JOIN tbl_areaCodes T4 ON T4.id = T0.area_id
                                WHERE T4.id = @aId AND T1.goodDes LIKE CONCAT(@fltr,'%');")
                If SQL.HasException(True) Then Exit Sub
            End If
        End With
    End Sub
    Private Sub viewStockDgvFOrmat()
        With viewStocks.dgvStocks
            Try
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .AllowUserToAddRows = False
                .AllowUserToOrderColumns = False
                .ReadOnly = True
                .DataSource = SQL.DBDT
                .ClearSelection()
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "PD NO."
                .Columns(2).HeaderText = "DESCRIPTION"
                .Columns(3).HeaderText = "BATCH NAME"
                .Columns(4).HeaderText = "LOCATION NAME"
                .Columns(5).HeaderText = "AREA"
                .Columns(6).HeaderText = "QUANTITY"
                .Columns(7).HeaderText = "R TOTAL"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 30
                .Columns(2).Width = 100
                .Columns(3).Width = 50
                .Columns(4).Width = 50
                .Columns(5).Width = 30
                .Columns(6).Width = 30
                .Columns(7).Width = 90
                .RowTemplate.Height = 30
                ' Set the background color for all rows And for alternating rows. 
                'The value for alternating rows overrides the value for all rows. 
                .RowsDefaultCellStyle.BackColor = Color.LightGray
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White

                'Set the row and column header styles.
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
                .RowHeadersDefaultCellStyle.BackColor = Color.Black
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End With
    End Sub
    'end

    'delete canced recv transaction
    Public Sub deleteCancelledRecvTrans(t As String)
        SQL.AddParam("@id", t)
        SQL.ExecQueryDT("spDeleteRecvCancelledTransaction @transId = @id;")
        If SQL.HasException(True) Then Exit Sub
        With recvGoodsTrans
            .transId = ""
        End With
    End Sub
    'end


    Public Sub loadLBXBatches(lbx As ListBox, txt As TextBox)
        SQL.AddParam("@txt", txt.Text & "%")
        SQL.ExecQueryDT("SELECT batchDes FROM [dbo].[tbl_batches] 
                         WHERE batchDes LIKE @txt
                         ORDER BY id DESC;")

        ''REPORT & ABORT SUB ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            lbx.Items.Add(r(0))
        Next
    End Sub


    'fetch batch to the textboxes
    Public Sub fetchBatchDatas(t As String)
        SQL.AddParam("@txt", t)
        SQL.ExecQueryDT("SELECT * FROM tbl_batches
                         WHERE batchDes = @txt;")
        If SQL.HasException(True) Then Exit Sub
        If SQL.RecordCountDT <> 0 Then
            For Each r As DataRow In SQL.DBDT.Rows
                With BatchesMain
                    .tbxBatchAbbrev.Text = r(1)
                    .tbxBatchDes.Text = r(3)
                    .id = r(0)
                    'MsgBox(.id)
                End With
            Next
        End If
    End Sub


    Public Sub updateBatch(abbv As String, des As String, uId As String, id As String)
        SQL.AddParam("@abbv", abbv)
        SQL.AddParam("@des", des)
        SQL.AddParam("@uId", uId)
        SQL.AddParam("@id", id)

        SQL.ExecQueryDT("UPDATE tbl_batches
                        SET batchDes = @abbv
	                        ,encBy = @uId
	                        ,remarks = @des
                        WHERE
	                        id = @id ;")
        If SQL.HasException(True) Then Exit Sub
    End Sub

End Class
