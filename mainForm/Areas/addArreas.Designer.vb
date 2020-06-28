<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addArreas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClearGoods = New System.Windows.Forms.Button()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.tbxAreaDes = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClearGoods)
        Me.GroupBox1.Controls.Add(Me.btnAddArea)
        Me.GroupBox1.Controls.Add(Me.tbxAreaDes)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 228)
        Me.GroupBox1.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Area Description:"
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
        'btnAddArea
        '
        Me.btnAddArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddArea.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddArea.Location = New System.Drawing.Point(56, 137)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(108, 38)
        Me.btnAddArea.TabIndex = 28
        Me.btnAddArea.Text = "Add"
        Me.btnAddArea.UseVisualStyleBackColor = True
        '
        'tbxAreaDes
        '
        Me.tbxAreaDes.Location = New System.Drawing.Point(40, 87)
        Me.tbxAreaDes.Name = "tbxAreaDes"
        Me.tbxAreaDes.Size = New System.Drawing.Size(254, 26)
        Me.tbxAreaDes.TabIndex = 0
        '
        'addArreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 228)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addArreas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblError As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearGoods As Button
    Friend WithEvents btnAddArea As Button
    Friend WithEvents tbxAreaDes As TextBox
End Class
