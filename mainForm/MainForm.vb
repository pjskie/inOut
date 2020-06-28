Imports System.ComponentModel

Public Class mainForm
    Private q As New qry
    'Id for area code
    Public Property areaCodeId As String = ""
    'id for the user
    Public Property userId As String = ""
    'id for the role
    Public Property roleId As String = ""
    'if admin/sysDev
    Public Property isAdmin As Boolean

    'close all form open when clicking new form
    Sub closeForms()
        If MdiChildren.Length > 0 Then
            For Each r As Form In Me.MdiChildren
                r.Close()
            Next
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub




    Private Sub logOut()
        Dim result As Integer = MessageBox.Show("Are you sure want to Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            'q.logOut(userId)
            Me.Hide()
            closeForms()
            loginForm.Show()
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub ReceiveGoodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveGoodsToolStripMenuItem.Click
        closeForms()
        recvGoodsTrans.MdiParent = Me
        recvGoodsTrans.Show()
    End Sub

    Private Sub mainform_FormClosing(sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure want to Log Out?", "Warning", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else
            e.Cancel = False
            areaCodeId = ""
            userId = ""
            roleId = ""
            isAdmin = False
            closeForms()
            loginForm.Show()
        End If
    End Sub

    Private Sub mainForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.CenterToScreen()
    End Sub

    Private Sub ReleaseGoodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseGoodsToolStripMenuItem.Click
        closeForms()
        relsGoodsTrans.MdiParent = Me
        relsGoodsTrans.Show()
    End Sub

    Private Sub AddToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem5.Click
        closeForms()
        addDocTypes.MdiParent = Me
        addDocTypes.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        closeForms()
        addArreas.MdiParent = Me
        addArreas.Show()
    End Sub

    Private Sub AddToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem3.Click
        closeForms()
        addBatch.MdiParent = Me
        addBatch.Show()
    End Sub

    Private Sub AddToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem4.Click
        closeForms()
        addLocation.MdiParent = Me
        addLocation.Show()
    End Sub

    Private Sub ViewStocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStocksToolStripMenuItem.Click
        closeForms()
        viewStocks.MdiParent = Me
        viewStocks.Show()
    End Sub
End Class
