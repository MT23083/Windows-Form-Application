Public Class SubmissionEntry
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub As String

    Public Sub New(name As String, email As String, phone As String, github As String)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GitHub = github
    End Sub
End Class
