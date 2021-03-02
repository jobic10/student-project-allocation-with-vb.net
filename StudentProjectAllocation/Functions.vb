Module Functions
    Public Sub showError(ByVal msg)
        MsgBox(msg, vbCritical, Application.ProductName)
    End Sub

    Public Sub showInfo(ByVal msg)
        MsgBox(msg, vbInformation, Application.ProductName)
    End Sub
End Module
