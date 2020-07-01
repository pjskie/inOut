<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchesMain
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUpdBatch = New System.Windows.Forms.Button()
        Me.btnUpdClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxBatchDes = New System.Windows.Forms.TextBox()
        Me.tbxBatchAbbrev = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbxFilter = New System.Windows.Forms.TextBox()
        Me.lbxBatches = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 361)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnUpdBatch)
        Me.GroupBox3.Controls.Add(Me.btnUpdClear)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tbxBatchDes)
        Me.GroupBox3.Controls.Add(Me.tbxBatchAbbrev)
        Me.GroupBox3.Location = New System.Drawing.Point(435, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 324)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Update"
        '
        'btnUpdBatch
        '
        Me.btnUpdBatch.Location = New System.Drawing.Point(243, 270)
        Me.btnUpdBatch.Name = "btnUpdBatch"
        Me.btnUpdBatch.Size = New System.Drawing.Size(73, 28)
        Me.btnUpdBatch.TabIndex = 8
        Me.btnUpdBatch.Text = "Update"
        Me.btnUpdBatch.UseVisualStyleBackColor = True
        '
        'btnUpdClear
        '
        Me.btnUpdClear.Location = New System.Drawing.Point(164, 270)
        Me.btnUpdClear.Name = "btnUpdClear"
        Me.btnUpdClear.Size = New System.Drawing.Size(73, 28)
        Me.btnUpdClear.TabIndex = 7
        Me.btnUpdClear.Text = "Clear"
        Me.btnUpdClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Batch Abbrev.:"
        '
        'tbxBatchDes
        '
        Me.tbxBatchDes.Location = New System.Drawing.Point(111, 98)
        Me.tbxBatchDes.Multiline = True
        Me.tbxBatchDes.Name = "tbxBatchDes"
        Me.tbxBatchDes.Size = New System.Drawing.Size(205, 166)
        Me.tbxBatchDes.TabIndex = 8
        '
        'tbxBatchAbbrev
        '
        Me.tbxBatchAbbrev.Location = New System.Drawing.Point(111, 56)
        Me.tbxBatchAbbrev.Name = "tbxBatchAbbrev"
        Me.tbxBatchAbbrev.Size = New System.Drawing.Size(205, 22)
        Me.tbxBatchAbbrev.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.tbxFilter)
        Me.GroupBox2.Controls.Add(Me.lbxBatches)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 324)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Batch List"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(307, 36)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(73, 28)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(228, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(73, 28)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbxFilter
        '
        Me.tbxFilter.Location = New System.Drawing.Point(17, 39)
        Me.tbxFilter.Name = "tbxFilter"
        Me.tbxFilter.Size = New System.Drawing.Size(205, 22)
        Me.tbxFilter.TabIndex = 4
        '
        'lbxBatches
        '
        Me.lbxBatches.FormattingEnabled = True
        Me.lbxBatches.ItemHeight = 16
        Me.lbxBatches.Location = New System.Drawing.Point(5, 79)
        Me.lbxBatches.Name = "lbxBatches"
        Me.lbxBatches.Size = New System.Drawing.Size(385, 164)
        Me.lbxBatches.TabIndex = 3
        '
        'BatchesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BatchesMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batches"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUpdBatch As Button
    Friend WithEvents btnUpdClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxBatchDes As TextBox
    Friend WithEvents tbxBatchAbbrev As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbxFilter As TextBox
    Friend WithEvents lbxBatches As ListBox
End Class
