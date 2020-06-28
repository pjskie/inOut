<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblErrorPas = New System.Windows.Forms.Label()
        Me.lblErrorUser = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSignIn.Location = New System.Drawing.Point(395, 218)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(80, 40)
        Me.btnSignIn.TabIndex = 3
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(323, 113)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(213, 25)
        Me.tbxUser.TabIndex = 1
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(323, 165)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(213, 25)
        Me.tbxPass.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mainForm.My.Resources.Resources.icons8_lock_150
        Me.PictureBox1.Location = New System.Drawing.Point(13, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(284, 83)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(13, 18)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "*"
        Me.lblError.Visible = False
        '
        'lblErrorPas
        '
        Me.lblErrorPas.AutoSize = True
        Me.lblErrorPas.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPas.Location = New System.Drawing.Point(542, 165)
        Me.lblErrorPas.Name = "lblErrorPas"
        Me.lblErrorPas.Size = New System.Drawing.Size(13, 18)
        Me.lblErrorPas.TabIndex = 7
        Me.lblErrorPas.Text = "*"
        Me.lblErrorPas.Visible = False
        '
        'lblErrorUser
        '
        Me.lblErrorUser.AutoSize = True
        Me.lblErrorUser.ForeColor = System.Drawing.Color.Red
        Me.lblErrorUser.Location = New System.Drawing.Point(542, 113)
        Me.lblErrorUser.Name = "lblErrorUser"
        Me.lblErrorUser.Size = New System.Drawing.Size(13, 18)
        Me.lblErrorUser.TabIndex = 8
        Me.lblErrorUser.Text = "*"
        Me.lblErrorUser.Visible = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.lblErrorUser)
        Me.Controls.Add(Me.lblErrorPas)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSignIn)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxPass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblErrorPas As Label
    Friend WithEvents lblErrorUser As Label
End Class
