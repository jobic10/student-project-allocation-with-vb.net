Public Class frmAllocation
    Private Sub cmdAllocate_Click(sender As Object, e As EventArgs) Handles cmdAllocate.Click
        If MsgBox("This action re-shuffles previous allocation" & "Proceed?", vbYesNo) = vbYes Then
            'For Each Student, Select Supervisor At Random And Allocate. Then Refresh The Table
        Else
            showInfo("Action Halted")
        End If
    End Sub
End Class