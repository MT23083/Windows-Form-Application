Public Class ViewSubmissionsForm
    Dim currentEntryIndex As Integer = 0 ' Tracks current entry index
    Dim entries As New List(Of SubmissionEntry)() ' Placeholder for submitted entries (you need to define SubmissionEntry class)

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load entries from backend or wherever they are stored
        ' For demonstration, let's assume entries are added manually
        entries.Add(New SubmissionEntry("John Doe", "john.doe@example.com", "1234567890", "https://github.com/johndoe"))
        entries.Add(New SubmissionEntry("Jane Smith", "jane.smith@example.com", "9876543210", "https://github.com/janesmith"))

        DisplayEntry(currentEntryIndex)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentEntryIndex > 0 Then
            currentEntryIndex -= 1
            DisplayEntry(currentEntryIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentEntryIndex < entries.Count - 1 Then
            currentEntryIndex += 1
            DisplayEntry(currentEntryIndex)
        End If
    End Sub

    Private Sub DisplayEntry(index As Integer)
        ' Display entry details in your UI controls (e.g., labels)
        lblName.Text = entries(index).Name
        lblEmail.Text = entries(index).Email
        lblPhone.Text = entries(index).Phone
        lblGitHub.Text = entries(index).GitHub
    End Sub
End Class
