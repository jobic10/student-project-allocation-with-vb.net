Public Class Member
    'Start of Properties
    Public FullName As String
    Public MatricNumber As String
    Public Photo As String
    Public Role As String

    Public Sub New(fullname As String, regno As String, avatar As String, role As String)
        Me.FullName = fullname
        Me.MatricNumber = regno
        Me.Photo = avatar
        Me.Role = role
        Console.WriteLine("New Student Created")
    End Sub
End Class
Public Class frmDevelopers

End Class