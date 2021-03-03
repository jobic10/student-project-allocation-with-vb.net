<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSupervisor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtFileNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.allSup = New System.Windows.Forms.DataGridView()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        CType(Me.allSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(117, 16)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(246, 32)
        Me.txtFullName.TabIndex = 1
        '
        'txtFileNo
        '
        Me.txtFileNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileNo.Location = New System.Drawing.Point(117, 77)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New System.Drawing.Size(246, 32)
        Me.txtFileNo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "File No"
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = True
        Me.cmdAdd.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(231, 128)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(132, 62)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add Supervisor"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'allSup
        '
        Me.allSup.AllowDrop = True
        Me.allSup.AllowUserToAddRows = False
        Me.allSup.AllowUserToDeleteRows = False
        Me.allSup.AllowUserToOrderColumns = True
        Me.allSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.allSup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.allSup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.allSup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.allSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.allSup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.allSup.Location = New System.Drawing.Point(0, 292)
        Me.allSup.Name = "allSup"
        Me.allSup.ReadOnly = True
        Me.allSup.ShowEditingIcon = False
        Me.allSup.Size = New System.Drawing.Size(728, 240)
        Me.allSup.TabIndex = 5
        '
        'cmdUpdate
        '
        Me.cmdUpdate.AutoSize = True
        Me.cmdUpdate.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(117, 128)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(147, 62)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Update Supervisor"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.Visible = False
        '
        'addSupervisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 532)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.allSup)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtFileNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addSupervisor"
        Me.Text = "Add New Supervisor"
        CType(Me.allSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtFileNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents allSup As DataGridView
    Friend WithEvents cmdUpdate As Button
End Class
