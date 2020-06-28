<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDocTypes
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
        Me.tbxDocType = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClearGoods = New System.Windows.Forms.Button()
        Me.btnGoodsAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxDocType
        '
        Me.tbxDocType.Location = New System.Drawing.Point(40, 87)
        Me.tbxDocType.Name = "tbxDocType"
        Me.tbxDocType.Size = New System.Drawing.Size(254, 26)
        Me.tbxDocType.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClearGoods)
        Me.GroupBox1.Controls.Add(Me.btnGoodsAdd)
        Me.GroupBox1.Controls.Add(Me.tbxDocType)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 228)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(40, 203)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(14, 20)
        Me.lblError.TabIndex = 31
        Me.lblError.Text = "*"
        Me.lblError.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Document Type:"
        '
        'btnClearGoods
        '
        Me.btnClearGoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearGoods.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearGoods.Location = New System.Drawing.Point(173, 137)
        Me.btnClearGoods.Name = "btnClearGoods"
        Me.btnClearGoods.Size = New System.Drawing.Size(108, 38)
        Me.btnClearGoods.TabIndex = 29
        Me.btnClearGoods.Text = "Clear"
        Me.btnClearGoods.UseVisualStyleBackColor = True
        '
        'btnGoodsAdd
        '
        Me.btnGoodsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoodsAdd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoodsAdd.Location = New System.Drawing.Point(56, 137)
        Me.btnGoodsAdd.Name = "btnGoodsAdd"
        Me.btnGoodsAdd.Size = New System.Drawing.Size(108, 38)
        Me.btnGoodsAdd.TabIndex = 28
        Me.btnGoodsAdd.Text = "Add"
        Me.btnGoodsAdd.UseVisualStyleBackColor = True
        '
        'addDocTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 228)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addDocTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document Types"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbxDocType As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearGoods As Button
    Friend WithEvents btnGoodsAdd As Button
    Friend WithEvents lblError As Label
    Friend WithEvents Label1 As Label
End Class
