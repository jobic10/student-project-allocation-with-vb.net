Public Class Member
    'Start of Properties
    Public FullName As String
    Public MatricNumber As String
    Public Photo As String

    Public Sub New(fullname As String, regno As String)
        Me.FullName = fullname
        Me.MatricNumber = regno
        Me.Photo = regno.Substring(regno.Length - 3) 'Last three characters
        Console.WriteLine("New Student Created = " & Me.Photo)
    End Sub
End Class