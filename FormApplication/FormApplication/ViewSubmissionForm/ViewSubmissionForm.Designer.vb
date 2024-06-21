<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    ' Designer-generated code
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblEmailLabel As System.Windows.Forms.Label
    Friend WithEvents lblPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents lblGitHubLabel As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblGitHub As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button

    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGitHub As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNameLabel = New System.Windows.Forms.Label()
        Me.lblEmailLabel = New System.Windows.Forms.Label()
        Me.lblPhoneLabel = New System.Windows.Forms.Label()
        Me.lblGitHubLabel = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(208, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sarthak Sharma, Slidely Task 2 - VIEW SUBMISSIONS"
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
        ' lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(150, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 20)
        Me.lblName.TabIndex = 5
        '
        ' lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(150, 110)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 20)
        Me.lblEmail.TabIndex = 6
        '
        ' lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(150, 150)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(0, 20)
        Me.lblPhone.TabIndex = 7
        '
        ' lblGitHub
        '
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Location = New System.Drawing.Point(150, 190)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(0, 20)
        Me.lblGitHub.TabIndex = 8
        '
        ' btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(50, 230)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 30)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        '
        ' btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(200, 230)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 30)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        '
        ' txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 26)
        Me.txtName.TabIndex = 11
        '
        ' txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 110)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(200, 26)
        Me.txtEmail.TabIndex = 12
        '
        ' txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 150)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(200, 26)
        Me.txtPhone.TabIndex = 13
        '
        ' txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(150, 190)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New System.Drawing.Size(200, 26)
        Me.txtGitHub.TabIndex = 14
        '
        ' ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 700)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblGitHubLabel)
        Me.Controls.Add(Me.lblPhoneLabel)
        Me.Controls.Add(Me.lblEmailLabel)
        Me.Controls.Add(Me.lblNameLabel)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
