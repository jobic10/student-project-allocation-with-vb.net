Public Class frmLogin
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        If MsgBox("Are you sure you want to quit ?", vbYesNo, "Close Application") = vbYes Then
            End
        End If
    End Sub
End Class