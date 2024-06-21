﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Declare WithEvents for controls
    Friend WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Friend WithEvents btnCreateNewSubmission As System.Windows.Forms.Button
    Friend WithEvents lblButtonDescription As System.Windows.Forms.Label ' New label for button description

    ' Required designer variable.
    Private components As System.ComponentModel.IContainer

    ' Dispose method to clean up resources
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Initialize components (generated by Windows Form Designer)
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.lblButtonDescription = New System.Windows.Forms.Label() ' Initialize the label control
        Me.SuspendLayout()
        '
        ' btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(50, 250)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(700, 50)
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS"
        Me.btnViewSubmissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubmissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter ' Center text horizontally and vertically
        Me.btnViewSubmissions.Tag = "Enter title for View Submissions" ' Title or placeholder text
        '
        ' btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(50, 325)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(700, 50)
        Me.btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION"
        Me.btnCreateNewSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter ' Center text horizontally and vertically
        Me.btnCreateNewSubmission.Tag = "Enter title for Create New Submission" ' Title or placeholder text
        '
        ' lblButtonDescription
        '
        Me.lblButtonDescription.AutoSize = True
        Me.lblButtonDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButtonDescription.Location = New System.Drawing.Point(50, 200)
        Me.lblButtonDescription.Name = "lblButtonDescription"
        Me.lblButtonDescription.Size = New System.Drawing.Size(700, 25)
        Me.lblButtonDescription.TabIndex = 0
        Me.lblButtonDescription.Text = "Sarthak Sharma, Slidely Task 2 - Slidely Form App" ' Text above both buttons
        Me.lblButtonDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter ' Center text horizontally
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblButtonDescription) ' Add label to form controls
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "FormApplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class