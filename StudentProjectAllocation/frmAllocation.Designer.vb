<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllocation
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
        Me.gridSupervisor = New System.Windows.Forms.DataGridView()
        Me.gridStudents = New System.Windows.Forms.DataGridView()
        Me.cmdAllocate = New System.Windows.Forms.Button()
        CType(Me.gridSupervisor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridSupervisor
        '
        Me.gridSupervisor.AllowUserToAddRows = False
        Me.gridSupervisor.AllowUserToDeleteRows = False
        Me.gridSupervisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridSupervisor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gridSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSupervisor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridSupervisor.Location = New System.Drawing.Point(0, 276)
        Me.gridSupervisor.Name = "gridSupervisor"
        Me.gridSupervisor.ReadOnly = True
        Me.gridSupervisor.Size = New System.Drawing.Size(430, 174)
        Me.gridSupervisor.TabIndex = 0
        '
        'gridStudents
        '
        Me.gridStudents.AllowUserToAddRows = False
        Me.gridStudents.AllowUserToDeleteRows = False
        Me.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStudents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridStudents.Location = New System.Drawing.Point(0, 102)
        Me.gridStudents.Name = "gridStudents"
        Me.gridStudents.ReadOnly = True
        Me.gridStudents.Size = New System.Drawing.Size(430, 174)
        Me.gridStudents.TabIndex = 1
        '
        'cmdAllocate
        '
        Me.cmdAllocate.AutoSize = True
        Me.cmdAllocate.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAllocate.Location = New System.Drawing.Point(138, 12)
        Me.cmdAllocate.Name = "cmdAllocate"
        Me.cmdAllocate.Size = New System.Drawing.Size(151, 62)
        Me.cmdAllocate.TabIndex = 17
        Me.cmdAllocate.Text = "Perform Allocation"
        Me.cmdAllocate.UseVisualStyleBackColor = True
        '
        'frmAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 450)
        Me.Controls.Add(Me.cmdAllocate)
        Me.Controls.Add(Me.gridStudents)
        Me.Controls.Add(Me.gridSupervisor)
        Me.Name = "frmAllocation"
        Me.Text = "Allocation Management Window"
        CType(Me.gridSupervisor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridSupervisor As DataGridView
    Friend WithEvents gridStudents As DataGridView
    Friend WithEvents cmdAllocate As Button
End Class
