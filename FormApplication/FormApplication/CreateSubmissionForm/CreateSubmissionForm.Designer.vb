<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Designer-generated code
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblEmailLabel As System.Windows.Forms.Label
    Friend WithEvents lblPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents lblGitHubLabel As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGitHub As System.Windows.Forms.TextBox
    Friend WithEvents btnStartPause As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblDigitalWatch As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNameLabel = New System.Windows.Forms.Label()
        Me.lblEmailLabel = New System.Windows.Forms.Label()
        Me.lblPhoneLabel = New System.Windows.Forms.Label()
        Me.lblGitHubLabel = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.btnStartPause = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDigitalWatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sarthak Sharma, Slidely Task 2 - Create Submission"
        '
        ' lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.Location = New System.Drawing.Point(50, 70)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(51, 20)
        Me.lblNameLabel.TabIndex = 1
        Me.lblNameLabel.Text = "Name"
        '
        ' lblEmailLabel
        '
        Me.lblEmailLabel.AutoSize = True
        Me.lblEmailLabel.Location = New System.Drawing.Point(50, 110)
        Me.lblEmailLabel.Name = "lblEmailLabel"
        Me.lblEmailLabel.Size = New System.Drawing.Size(48, 20)
        Me.lblEmailLabel.TabIndex = 2
        Me.lblEmailLabel.Text = "Email"
        '
        ' lblPhoneLabel
        '
        Me.lblPhoneLabel.AutoSize = True
        Me.lblPhoneLabel.Location = New System.Drawing.Point(50, 150)
        Me.lblPhoneLabel.Name = "lblPhoneLabel"
        Me.lblPhoneLabel.Size = New System.Drawing.Size(56, 20)
        Me.lblPhoneLabel.TabIndex = 3
        Me.lblPhoneLabel.Text = "Phone"
        '
        ' lblGitHubLabel
        '
        Me.lblGitHubLabel.AutoSize = True
        Me.lblGitHubLabel.Location = New System.Drawing.Point(50, 190)
        Me.lblGitHubLabel.Name = "lblGitHubLabel"
        Me.lblGitHubLabel.Size = New System.Drawing.Size(60, 20)
        Me.lblGitHubLabel.TabIndex = 4
        Me.lblGitHubLabel.Text = "GitHub"
        '
        ' txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 26)
        Me.txtName.TabIndex = 5
        '
        ' txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 110)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 26)
        Me.txtEmail.TabIndex = 6
        '
        ' txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 150)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 26)
        Me.txtPhone.TabIndex = 7
        '
        ' txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(150, 190)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(200, 26)
        Me.txtGitHub.TabIndex = 8
        '
        ' btnStartPause
        '
        Me.btnStartPause.Location = New System.Drawing.Point(50, 230)
        Me.btnStartPause.Name = "btnStartPause"
        Me.btnStartPause.Size = New System.Drawing.Size(200, 30)
        Me.btnStartPause.TabIndex = 9
        Me.btnStartPause.Text = "Start/Pause"
        '
        ' btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(260, 230)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        '
        ' lblDigitalWatch
        '
        Me.lblDigitalWatch.AutoSize = True
        Me.lblDigitalWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitalWatch.Location = New System.Drawing.Point(50, 270)
        Me.lblDigitalWatch.Name = "lblDigitalWatch"
        Me.lblDigitalWatch.Size = New System.Drawing.Size(140, 32)
        Me.lblDigitalWatch.TabIndex = 11
        Me.lblDigitalWatch.Text = "00:00:00"
        '
        ' CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.lblDigitalWatch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnStartPause)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblGitHubLabel)
        Me.Controls.Add(Me.lblPhoneLabel)
        Me.Controls.Add(Me.lblEmailLabel)
        Me.Controls.Add(Me.lblNameLabel)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
