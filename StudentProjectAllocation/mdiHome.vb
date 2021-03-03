Imports System.Windows.Forms

Public Class mdiHome
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.MdiParent = Me
        frmAbout.Show()
    End Sub

    Private Sub dropdownLogout_Click(sender As Object, e As EventArgs) Handles dropdownLogout.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub tmrDateTIme_Tick(sender As Object, e As EventArgs) Handles tmrDateTIme.Tick
        lblDate.Text = Date.Now.ToString("dddd, dd MMMM yyyy")
        lblTIme.Text = Date.Now.ToString("hh : mm : ss tt")
    End Sub

    Private Sub GroupNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupNameToolStripMenuItem.Click
        Me.GroupNameToolStripMenuItem.Checked = Not Me.GroupNameToolStripMenuItem.Checked
        Me.lblGroupInfo.Visible = Me.GroupNameToolStripMenuItem.Checked
    End Sub

    Private Sub AddNewSupervisorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewSupervisorToolStripMenuItem.Click
        addSupervisor.MdiParent = Me
        addSupervisor.Show()
    End Sub

    Private Sub ManageStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentsToolStripMenuItem.Click
        addStudent.MdiParent = Me
        addStudent.Show()
    End Sub

    Private Sub AllocationMenu_Click(sender As Object, e As EventArgs) Handles AllocationMenu.Click
        frmAllocation.MdiParent = Me
        frmAllocation.Show()
    End Sub

    Private Sub GroupMembersMenu_Click(sender As Object, e As EventArgs) Handles GroupMembersMenu.Click
        frmDevelopers.MdiParent = Me
        frmDevelopers.Show()
    End Sub
End Class
