﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class locationMain
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
        Me.btnUpdLoc = New System.Windows.Forms.Button()
        Me.btnUpdClr = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLocDes = New System.Windows.Forms.TextBox()
        Me.tbxLocAbbrv = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbxFilter = New System.Windows.Forms.TextBox()
        Me.lbxLocations = New System.Windows.Forms.ListBox()
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
        Me.GroupBox3.Controls.Add(Me.btnUpdLoc)
        Me.GroupBox3.Controls.Add(Me.btnUpdClr)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnLocDes)
        Me.GroupBox3.Controls.Add(Me.tbxLocAbbrv)
        Me.GroupBox3.Location = New System.Drawing.Point(435, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 324)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Update"
        '
        'btnUpdLoc
        '
        Me.btnUpdLoc.Location = New System.Drawing.Point(243, 270)
        Me.btnUpdLoc.Name = "btnUpdLoc"
        Me.btnUpdLoc.Size = New System.Drawing.Size(73, 28)
        Me.btnUpdLoc.TabIndex = 8
        Me.btnUpdLoc.Text = "Update"
        Me.btnUpdLoc.UseVisualStyleBackColor = True
        '
        'btnUpdClr
        '
        Me.btnUpdClr.Location = New System.Drawing.Point(164, 270)
        Me.btnUpdClr.Name = "btnUpdClr"
        Me.btnUpdClr.Size = New System.Drawing.Size(73, 28)
        Me.btnUpdClr.TabIndex = 7
        Me.btnUpdClr.Text = "Clear"
        Me.btnUpdClr.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Locations Abbv.:"
        '
        'btnLocDes
        '
        Me.btnLocDes.Location = New System.Drawing.Point(111, 98)
        Me.btnLocDes.Multiline = True
        Me.btnLocDes.Name = "btnLocDes"
        Me.btnLocDes.Size = New System.Drawing.Size(205, 166)
        Me.btnLocDes.TabIndex = 8
        '
        'tbxLocAbbrv
        '
        Me.tbxLocAbbrv.Location = New System.Drawing.Point(111, 56)
        Me.tbxLocAbbrv.Name = "tbxLocAbbrv"
        Me.tbxLocAbbrv.Size = New System.Drawing.Size(205, 22)
        Me.tbxLocAbbrv.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.tbxFilter)
        Me.GroupBox2.Controls.Add(Me.lbxLocations)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 324)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Area List"
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
        'lbxLocations
        '
        Me.lbxLocations.FormattingEnabled = True
        Me.lbxLocations.ItemHeight = 16
        Me.lbxLocations.Location = New System.Drawing.Point(5, 79)
        Me.lbxLocations.Name = "lbxLocations"
        Me.lbxLocations.Size = New System.Drawing.Size(385, 164)
        Me.lbxLocations.TabIndex = 3
        '
        'locationMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "locationMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUpdLoc As Button
    Friend WithEvents btnUpdClr As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLocDes As TextBox
    Friend WithEvents tbxLocAbbrv As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbxFilter As TextBox
    Friend WithEvents lbxLocations As ListBox
End Class
