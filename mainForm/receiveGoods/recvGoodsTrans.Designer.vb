﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recvGoodsTrans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblErrQty = New System.Windows.Forms.Label()
        Me.lblErrLoc = New System.Windows.Forms.Label()
        Me.lblErrorPDNum = New System.Windows.Forms.Label()
        Me.btnClearFieldProd = New System.Windows.Forms.Button()
        Me.btnAddProdtoDgv = New System.Windows.Forms.Button()
        Me.btnAddLoc = New System.Windows.Forms.Button()
        Me.btnAddBatch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxQty = New System.Windows.Forms.TextBox()
        Me.btnAddPd = New System.Windows.Forms.Button()
        Me.tbxLoc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbxBatch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbxProdDesc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbxPDno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvProdDet = New System.Windows.Forms.DataGridView()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblErrSenderName = New System.Windows.Forms.Label()
        Me.lblErrDocNum = New System.Windows.Forms.Label()
        Me.lblErrSender = New System.Windows.Forms.Label()
        Me.lblErrDocType = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbxSenderName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxSender = New System.Windows.Forms.ComboBox()
        Me.tbxRefDocNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxDocEntry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxRefDocType = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvProdDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1184, 661)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblErrQty)
        Me.GroupBox4.Controls.Add(Me.lblErrLoc)
        Me.GroupBox4.Controls.Add(Me.lblErrorPDNum)
        Me.GroupBox4.Controls.Add(Me.btnClearFieldProd)
        Me.GroupBox4.Controls.Add(Me.btnAddProdtoDgv)
        Me.GroupBox4.Controls.Add(Me.btnAddLoc)
        Me.GroupBox4.Controls.Add(Me.btnAddBatch)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.tbxQty)
        Me.GroupBox4.Controls.Add(Me.btnAddPd)
        Me.GroupBox4.Controls.Add(Me.tbxLoc)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.tbxBatch)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.tbxProdDesc)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tbxPDno)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(740, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 489)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product"
        '
        'lblErrQty
        '
        Me.lblErrQty.AutoSize = True
        Me.lblErrQty.ForeColor = System.Drawing.Color.Red
        Me.lblErrQty.Location = New System.Drawing.Point(33, 305)
        Me.lblErrQty.Name = "lblErrQty"
        Me.lblErrQty.Size = New System.Drawing.Size(13, 15)
        Me.lblErrQty.TabIndex = 28
        Me.lblErrQty.Text = "*"
        Me.lblErrQty.Visible = False
        '
        'lblErrLoc
        '
        Me.lblErrLoc.AutoSize = True
        Me.lblErrLoc.ForeColor = System.Drawing.Color.Red
        Me.lblErrLoc.Location = New System.Drawing.Point(33, 253)
        Me.lblErrLoc.Name = "lblErrLoc"
        Me.lblErrLoc.Size = New System.Drawing.Size(13, 15)
        Me.lblErrLoc.TabIndex = 27
        Me.lblErrLoc.Text = "*"
        Me.lblErrLoc.Visible = False
        '
        'lblErrorPDNum
        '
        Me.lblErrorPDNum.AutoSize = True
        Me.lblErrorPDNum.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPDNum.Location = New System.Drawing.Point(32, 98)
        Me.lblErrorPDNum.Name = "lblErrorPDNum"
        Me.lblErrorPDNum.Size = New System.Drawing.Size(13, 15)
        Me.lblErrorPDNum.TabIndex = 25
        Me.lblErrorPDNum.Text = "*"
        Me.lblErrorPDNum.Visible = False
        '
        'btnClearFieldProd
        '
        Me.btnClearFieldProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearFieldProd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFieldProd.Location = New System.Drawing.Point(317, 362)
        Me.btnClearFieldProd.Name = "btnClearFieldProd"
        Me.btnClearFieldProd.Size = New System.Drawing.Size(66, 29)
        Me.btnClearFieldProd.TabIndex = 17
        Me.btnClearFieldProd.Text = "Clear"
        Me.btnClearFieldProd.UseVisualStyleBackColor = True
        '
        'btnAddProdtoDgv
        '
        Me.btnAddProdtoDgv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProdtoDgv.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProdtoDgv.Location = New System.Drawing.Point(230, 362)
        Me.btnAddProdtoDgv.Name = "btnAddProdtoDgv"
        Me.btnAddProdtoDgv.Size = New System.Drawing.Size(66, 29)
        Me.btnAddProdtoDgv.TabIndex = 16
        Me.btnAddProdtoDgv.Text = "Add"
        Me.btnAddProdtoDgv.UseVisualStyleBackColor = True
        '
        'btnAddLoc
        '
        Me.btnAddLoc.Image = Global.mainForm.My.Resources.Resources.icons8_add_new_24
        Me.btnAddLoc.Location = New System.Drawing.Point(255, 252)
        Me.btnAddLoc.Name = "btnAddLoc"
        Me.btnAddLoc.Size = New System.Drawing.Size(27, 26)
        Me.btnAddLoc.TabIndex = 14
        Me.btnAddLoc.UseVisualStyleBackColor = True
        '
        'btnAddBatch
        '
        Me.btnAddBatch.Image = Global.mainForm.My.Resources.Resources.icons8_add_new_24
        Me.btnAddBatch.Location = New System.Drawing.Point(255, 200)
        Me.btnAddBatch.Name = "btnAddBatch"
        Me.btnAddBatch.Size = New System.Drawing.Size(27, 26)
        Me.btnAddBatch.TabIndex = 12
        Me.btnAddBatch.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Quantity:"
        '
        'tbxQty
        '
        Me.tbxQty.Location = New System.Drawing.Point(53, 305)
        Me.tbxQty.Name = "tbxQty"
        Me.tbxQty.Size = New System.Drawing.Size(198, 23)
        Me.tbxQty.TabIndex = 15
        '
        'btnAddPd
        '
        Me.btnAddPd.Image = Global.mainForm.My.Resources.Resources.icons8_add_new_24
        Me.btnAddPd.Location = New System.Drawing.Point(255, 97)
        Me.btnAddPd.Name = "btnAddPd"
        Me.btnAddPd.Size = New System.Drawing.Size(27, 26)
        Me.btnAddPd.TabIndex = 9
        Me.btnAddPd.UseVisualStyleBackColor = True
        '
        'tbxLoc
        '
        Me.tbxLoc.Location = New System.Drawing.Point(53, 253)
        Me.tbxLoc.Name = "tbxLoc"
        Me.tbxLoc.Size = New System.Drawing.Size(198, 23)
        Me.tbxLoc.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Location:"
        '
        'tbxBatch
        '
        Me.tbxBatch.Location = New System.Drawing.Point(53, 201)
        Me.tbxBatch.Name = "tbxBatch"
        Me.tbxBatch.Size = New System.Drawing.Size(198, 23)
        Me.tbxBatch.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Batch:"
        '
        'tbxProdDesc
        '
        Me.tbxProdDesc.Location = New System.Drawing.Point(51, 152)
        Me.tbxProdDesc.Name = "tbxProdDesc"
        Me.tbxProdDesc.Size = New System.Drawing.Size(349, 23)
        Me.tbxProdDesc.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Description:"
        '
        'tbxPDno
        '
        Me.tbxPDno.Location = New System.Drawing.Point(51, 98)
        Me.tbxPDno.Name = "tbxPDno"
        Me.tbxPDno.Size = New System.Drawing.Size(200, 23)
        Me.tbxPDno.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "PD No.:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvProdDet)
        Me.GroupBox3.Controls.Add(Me.lblError)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(731, 489)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Details"
        '
        'dgvProdDet
        '
        Me.dgvProdDet.AllowUserToDeleteRows = False
        Me.dgvProdDet.AllowUserToResizeRows = False
        Me.dgvProdDet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdDet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvProdDet.ColumnHeadersHeight = 40
        Me.dgvProdDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProdDet.EnableHeadersVisualStyles = False
        Me.dgvProdDet.Location = New System.Drawing.Point(9, 22)
        Me.dgvProdDet.Name = "dgvProdDet"
        Me.dgvProdDet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvProdDet.RowHeadersWidth = 40
        Me.dgvProdDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdDet.Size = New System.Drawing.Size(706, 444)
        Me.dgvProdDet.TabIndex = 15
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(6, 469)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(13, 15)
        Me.lblError.TabIndex = 14
        Me.lblError.Text = "*"
        Me.lblError.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxRefDocType)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblErrSenderName)
        Me.GroupBox2.Controls.Add(Me.lblErrDocNum)
        Me.GroupBox2.Controls.Add(Me.lblErrSender)
        Me.GroupBox2.Controls.Add(Me.lblErrDocType)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.tbxSenderName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbxSender)
        Me.GroupBox2.Controls.Add(Me.tbxRefDocNum)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpDocDate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbxDocEntry)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1169, 140)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Header"
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(933, 83)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 34)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "RESET"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(614, 41)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 84)
        Me.TextBox1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(614, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Remarks:"
        '
        'lblErrSenderName
        '
        Me.lblErrSenderName.AutoSize = True
        Me.lblErrSenderName.ForeColor = System.Drawing.Color.Red
        Me.lblErrSenderName.Location = New System.Drawing.Point(595, 79)
        Me.lblErrSenderName.Name = "lblErrSenderName"
        Me.lblErrSenderName.Size = New System.Drawing.Size(13, 15)
        Me.lblErrSenderName.TabIndex = 32
        Me.lblErrSenderName.Text = "*"
        Me.lblErrSenderName.Visible = False
        '
        'lblErrDocNum
        '
        Me.lblErrDocNum.AutoSize = True
        Me.lblErrDocNum.ForeColor = System.Drawing.Color.Red
        Me.lblErrDocNum.Location = New System.Drawing.Point(438, 79)
        Me.lblErrDocNum.Name = "lblErrDocNum"
        Me.lblErrDocNum.Size = New System.Drawing.Size(13, 15)
        Me.lblErrDocNum.TabIndex = 31
        Me.lblErrDocNum.Text = "*"
        Me.lblErrDocNum.Visible = False
        '
        'lblErrSender
        '
        Me.lblErrSender.AutoSize = True
        Me.lblErrSender.ForeColor = System.Drawing.Color.Red
        Me.lblErrSender.Location = New System.Drawing.Point(595, 17)
        Me.lblErrSender.Name = "lblErrSender"
        Me.lblErrSender.Size = New System.Drawing.Size(13, 15)
        Me.lblErrSender.TabIndex = 30
        Me.lblErrSender.Text = "*"
        Me.lblErrSender.Visible = False
        '
        'lblErrDocType
        '
        Me.lblErrDocType.AutoSize = True
        Me.lblErrDocType.ForeColor = System.Drawing.Color.Red
        Me.lblErrDocType.Location = New System.Drawing.Point(439, 17)
        Me.lblErrDocType.Name = "lblErrDocType"
        Me.lblErrDocType.Size = New System.Drawing.Size(13, 15)
        Me.lblErrDocType.TabIndex = 29
        Me.lblErrDocType.Text = "*"
        Me.lblErrDocType.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(933, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 34)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbxSenderName
        '
        Me.tbxSenderName.Location = New System.Drawing.Point(458, 102)
        Me.tbxSenderName.Name = "tbxSenderName"
        Me.tbxSenderName.Size = New System.Drawing.Size(150, 23)
        Me.tbxSenderName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Received From:"
        '
        'cbxSender
        '
        Me.cbxSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSender.FormattingEnabled = True
        Me.cbxSender.Location = New System.Drawing.Point(458, 41)
        Me.cbxSender.Name = "cbxSender"
        Me.cbxSender.Size = New System.Drawing.Size(150, 23)
        Me.cbxSender.TabIndex = 5
        '
        'tbxRefDocNum
        '
        Me.tbxRefDocNum.Location = New System.Drawing.Point(302, 102)
        Me.tbxRefDocNum.Name = "tbxRefDocNum"
        Me.tbxRefDocNum.Size = New System.Drawing.Size(150, 23)
        Me.tbxRefDocNum.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ref. Doc. Number"
        '
        'dtpDocDate
        '
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDate.Location = New System.Drawing.Point(146, 102)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(150, 23)
        Me.dtpDocDate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Doc. Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ref. Doc. Type"
        '
        'tbxDocEntry
        '
        Me.tbxDocEntry.Location = New System.Drawing.Point(146, 41)
        Me.tbxDocEntry.Name = "tbxDocEntry"
        Me.tbxDocEntry.ReadOnly = True
        Me.tbxDocEntry.Size = New System.Drawing.Size(150, 23)
        Me.tbxDocEntry.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doc. Entry"
        '
        'tbxRefDocType
        '
        Me.tbxRefDocType.Location = New System.Drawing.Point(301, 41)
        Me.tbxRefDocType.Name = "tbxRefDocType"
        Me.tbxRefDocType.Size = New System.Drawing.Size(150, 23)
        Me.tbxRefDocType.TabIndex = 3
        '
        'recvGoodsTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "recvGoodsTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvProdDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbxSenderName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxSender As ComboBox
    Friend WithEvents tbxRefDocNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDocDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxDocEntry As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents tbxLoc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbxBatch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbxProdDesc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbxPDno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddPd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxQty As TextBox
    Friend WithEvents btnAddLoc As Button
    Friend WithEvents btnAddBatch As Button
    Friend WithEvents btnClearFieldProd As Button
    Friend WithEvents btnAddProdtoDgv As Button
    Friend WithEvents lblErrQty As Label
    Friend WithEvents lblErrLoc As Label
    Friend WithEvents lblErrorPDNum As Label
    Friend WithEvents lblErrDocNum As Label
    Friend WithEvents lblErrSender As Label
    Friend WithEvents lblErrDocType As Label
    Friend WithEvents lblErrSenderName As Label
    Friend WithEvents dgvProdDet As DataGridView
    Friend WithEvents lblError As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxRefDocType As TextBox
End Class
