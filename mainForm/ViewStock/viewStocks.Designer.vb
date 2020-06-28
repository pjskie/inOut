<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewStocks
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
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.tbxFilter = New System.Windows.Forms.TextBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.cbxPagesize = New System.Windows.Forms.ComboBox()
        Me.dgvStocks = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Controls.Add(Me.lblPage)
        Me.GroupBox1.Controls.Add(Me.tbxFilter)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.cbxPagesize)
        Me.GroupBox1.Controls.Add(Me.dgvStocks)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1201, 682)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(13, 642)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(15, 20)
        Me.lblError.TabIndex = 30
        Me.lblError.Text = "*"
        '
        'lblPage
        '
        Me.lblPage.AutoSize = True
        Me.lblPage.Location = New System.Drawing.Point(1130, 649)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(46, 20)
        Me.lblPage.TabIndex = 27
        Me.lblPage.Text = "Page"
        '
        'tbxFilter
        '
        Me.tbxFilter.Location = New System.Drawing.Point(651, 25)
        Me.tbxFilter.Name = "tbxFilter"
        Me.tbxFilter.Size = New System.Drawing.Size(280, 26)
        Me.tbxFilter.TabIndex = 3
        '
        'btnLast
        '
        Me.btnLast.Image = Global.mainForm.My.Resources.Resources.icons8_fast_forward_30
        Me.btnLast.Location = New System.Drawing.Point(1074, 645)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(50, 28)
        Me.btnLast.TabIndex = 29
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1066, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 52)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = Global.mainForm.My.Resources.Resources.icons8_sort_left_30
        Me.btnPrevious.Location = New System.Drawing.Point(962, 645)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(50, 28)
        Me.btnPrevious.TabIndex = 26
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(937, 12)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(123, 52)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "Search"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = Global.mainForm.My.Resources.Resources.icons8_sort_right_30
        Me.btnNext.Location = New System.Drawing.Point(1018, 645)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 28)
        Me.btnNext.TabIndex = 28
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'cbxPagesize
        '
        Me.cbxPagesize.FormattingEnabled = True
        Me.cbxPagesize.Items.AddRange(New Object() {"1", "5", "10", "20", "50", "100"})
        Me.cbxPagesize.Location = New System.Drawing.Point(850, 645)
        Me.cbxPagesize.Name = "cbxPagesize"
        Me.cbxPagesize.Size = New System.Drawing.Size(50, 28)
        Me.cbxPagesize.TabIndex = 24
        '
        'dgvStocks
        '
        Me.dgvStocks.AllowUserToAddRows = False
        Me.dgvStocks.AllowUserToDeleteRows = False
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocks.Location = New System.Drawing.Point(13, 70)
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.ReadOnly = True
        Me.dgvStocks.Size = New System.Drawing.Size(1182, 565)
        Me.dgvStocks.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(772, 649)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Page Size"
        '
        'btnFirst
        '
        Me.btnFirst.Image = Global.mainForm.My.Resources.Resources.icons8_rewind_30
        Me.btnFirst.Location = New System.Drawing.Point(906, 645)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(50, 28)
        Me.btnFirst.TabIndex = 25
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'viewStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 682)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "viewStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stocks"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxFilter As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents lblPage As Label
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents cbxPagesize As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents lblError As Label
End Class
