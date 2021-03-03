<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiHome))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupervisorMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTIme = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrDateTIme = New System.Windows.Forms.Timer(Me.components)
        Me.lblGroupInfo = New System.Windows.Forms.Label()
        Me.AddNewSupervisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllocationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.dropdownLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.AllocationMenu, Me.SupervisorMenu, Me.StudentMenu, Me.ViewMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownLogout, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SupervisorMenu
        '
        Me.SupervisorMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewSupervisorToolStripMenuItem})
        Me.SupervisorMenu.Name = "SupervisorMenu"
        Me.SupervisorMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SupervisorMenu.Size = New System.Drawing.Size(79, 20)
        Me.SupervisorMenu.Text = "&Supervisors"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarToolStripMenuItem, Me.GroupNameToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'GroupNameToolStripMenuItem
        '
        Me.GroupNameToolStripMenuItem.Checked = True
        Me.GroupNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GroupNameToolStripMenuItem.Name = "GroupNameToolStripMenuItem"
        Me.GroupNameToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.GroupNameToolStripMenuItem.Text = "Group Name"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripSeparator8, Me.IndexToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(157, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDate, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblTIme})
        Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 33)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 7
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(164, 30)
        Me.lblDate.Spring = True
        Me.lblDate.Text = "Date Goes Here"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(331, 15)
        Me.ToolStripStatusLabel1.Text = "                                                                                 " &
    "                           "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(331, 15)
        Me.ToolStripStatusLabel2.Text = "                                                                                 " &
    "                           "
        '
        'lblTIme
        '
        Me.lblTIme.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic)
        Me.lblTIme.Name = "lblTIme"
        Me.lblTIme.Size = New System.Drawing.Size(61, 30)
        Me.lblTIme.Spring = True
        Me.lblTIme.Text = "Time"
        '
        'tmrDateTIme
        '
        Me.tmrDateTIme.Enabled = True
        '
        'lblGroupInfo
        '
        Me.lblGroupInfo.AutoSize = True
        Me.lblGroupInfo.Location = New System.Drawing.Point(406, 4)
        Me.lblGroupInfo.Name = "lblGroupInfo"
        Me.lblGroupInfo.Size = New System.Drawing.Size(209, 13)
        Me.lblGroupInfo.TabIndex = 9
        Me.lblGroupInfo.Text = "Group 1 - Supervised By Dr. K. S. Adewole"
        '
        'AddNewSupervisorToolStripMenuItem
        '
        Me.AddNewSupervisorToolStripMenuItem.Name = "AddNewSupervisorToolStripMenuItem"
        Me.AddNewSupervisorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewSupervisorToolStripMenuItem.Text = "Manage Supervisors"
        '
        'StudentMenu
        '
        Me.StudentMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageStudentsToolStripMenuItem})
        Me.StudentMenu.Name = "StudentMenu"
        Me.StudentMenu.Size = New System.Drawing.Size(65, 20)
        Me.StudentMenu.Text = "S&tudents"
        '
        'ManageStudentsToolStripMenuItem
        '
        Me.ManageStudentsToolStripMenuItem.Name = "ManageStudentsToolStripMenuItem"
        Me.ManageStudentsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ManageStudentsToolStripMenuItem.Text = "Manage Students"
        '
        'AllocationMenu
        '
        Me.AllocationMenu.Name = "AllocationMenu"
        Me.AllocationMenu.Size = New System.Drawing.Size(73, 20)
        Me.AllocationMenu.Text = "Allocation"
        '
        'dropdownLogout
        '
        Me.dropdownLogout.Image = CType(resources.GetObject("dropdownLogout.Image"), System.Drawing.Image)
        Me.dropdownLogout.ImageTransparentColor = System.Drawing.Color.Black
        Me.dropdownLogout.Name = "dropdownLogout"
        Me.dropdownLogout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.dropdownLogout.Size = New System.Drawing.Size(155, 22)
        Me.dropdownLogout.Text = "&Log out"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.IndexToolStripMenuItem.Text = "&Group Members"
        '
        'mdiHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.lblGroupInfo)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiHome"
        Me.Text = "Student Project Allocation System - VB Group 1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dropdownLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupervisorMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents lblTIme As ToolStripStatusLabel
    Friend WithEvents tmrDateTIme As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents GroupNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblGroupInfo As Label
    Friend WithEvents AddNewSupervisorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentMenu As ToolStripMenuItem
    Friend WithEvents ManageStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllocationMenu As ToolStripMenuItem
End Class
