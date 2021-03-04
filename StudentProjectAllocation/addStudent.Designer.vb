<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
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
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.allSup = New System.Windows.Forms.DataGridView()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.allSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDelete
        '
        Me.cmdDelete.AutoSize = True
        Me.cmdDelete.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(17, 197)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(346, 62)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Text = "Delete Student"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Visible = False
        '
        'cmdReset
        '
        Me.cmdReset.AutoSize = True
        Me.cmdReset.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(17, 120)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(147, 62)
        Me.cmdReset.TabIndex = 18
        Me.cmdReset.Text = "Reset Form"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(392, 8)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(246, 32)
        Me.txtId.TabIndex = 17
        Me.txtId.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.AutoSize = True
        Me.cmdUpdate.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(216, 120)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(147, 62)
        Me.cmdUpdate.TabIndex = 16
        Me.cmdUpdate.Text = "Update Student"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.Visible = False
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
        Me.allSup.Location = New System.Drawing.Point(0, 281)
        Me.allSup.Name = "allSup"
        Me.allSup.ReadOnly = True
        Me.allSup.ShowEditingIcon = False
        Me.allSup.Size = New System.Drawing.Size(842, 240)
        Me.allSup.TabIndex = 15
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = True
        Me.cmdAdd.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(231, 120)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(132, 62)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "Add Student"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtRegNo
        '
        Me.txtRegNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNo.Location = New System.Drawing.Point(117, 69)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(246, 32)
        Me.txtRegNo.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Matric No"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(117, 8)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(246, 32)
        Me.txtFullName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Full Name"
        '
        'addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 521)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.allSup)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addStudent"
        Me.Text = "Students Management Window"
        CType(Me.allSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents allSup As DataGridView
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label1 As Label
End Class
