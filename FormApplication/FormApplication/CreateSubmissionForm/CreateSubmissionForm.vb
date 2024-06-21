Public Class CreateSubmissionForm
    Dim stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form components or settings
        lblDigitalWatch.Text = "00:00:00"
    End Sub

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If Not stopwatch.IsRunning Then
            stopwatch.Start()
            btnStartPause.Text = "Pause"
            StartStopwatchTimer()
        Else
            stopwatch.Stop()
            btnStartPause.Text = "Resume"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Submit form details to backend or process them as required
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGitHub.Text
        ' Process submission (e.g., send to server)

        ' Optionally, reset form fields or manage other UI aspects
        ' ClearForm()

        ' Reset stopwatch for next use if needed
        stopwatch.Reset()
        lblDigitalWatch.Text = "00:00:00" ' Reset the displayed stopwatch time
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSave.PerformClick() ' Simulate button click for saving
        End If
    End Sub

    Private Sub StartStopwatchTimer()
        ' Start a timer to update the stopwatch display every second
        Dim timer As New Timer()
        timer.Interval = 1000 ' 1 second interval
        AddHandler timer.Tick, Sub()
                                   If stopwatch.IsRunning Then
                                       Dim elapsed As TimeSpan = stopwatch.Elapsed
                                       lblDigitalWatch.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                                                           CInt(elapsed.TotalHours),
                                                                           elapsed.Minutes,
                                                                           elapsed.Seconds)
                                   Else
                                       timer.Stop()
                                       timer.Dispose()
                                   End If
                               End Sub
        timer.Start()
    End Sub
End Class
