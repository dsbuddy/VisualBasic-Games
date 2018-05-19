<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Answer1 = New System.Windows.Forms.RadioButton()
        Me.Answer2 = New System.Windows.Forms.RadioButton()
        Me.Answer3 = New System.Windows.Forms.RadioButton()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.Question1Button = New System.Windows.Forms.Button()
        Me.Question2Button = New System.Windows.Forms.Button()
        Me.Question3Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Answer4 = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Question15Button = New System.Windows.Forms.Button()
        Me.Question14Button = New System.Windows.Forms.Button()
        Me.Question13Button = New System.Windows.Forms.Button()
        Me.Question12Button = New System.Windows.Forms.Button()
        Me.Question11Button = New System.Windows.Forms.Button()
        Me.Question10Button = New System.Windows.Forms.Button()
        Me.Question9Button = New System.Windows.Forms.Button()
        Me.Question8Button = New System.Windows.Forms.Button()
        Me.Question7Button = New System.Windows.Forms.Button()
        Me.Question6Button = New System.Windows.Forms.Button()
        Me.Question5Button = New System.Windows.Forms.Button()
        Me.Question4Button = New System.Windows.Forms.Button()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Answer1
        '
        Me.Answer1.AutoSize = True
        Me.Answer1.Location = New System.Drawing.Point(18, 14)
        Me.Answer1.Name = "Answer1"
        Me.Answer1.Size = New System.Drawing.Size(69, 17)
        Me.Answer1.TabIndex = 2
        Me.Answer1.TabStop = True
        Me.Answer1.Text = "Answer 1"
        Me.Answer1.UseVisualStyleBackColor = True
        '
        'Answer2
        '
        Me.Answer2.AutoSize = True
        Me.Answer2.Location = New System.Drawing.Point(18, 37)
        Me.Answer2.Name = "Answer2"
        Me.Answer2.Size = New System.Drawing.Size(69, 17)
        Me.Answer2.TabIndex = 3
        Me.Answer2.TabStop = True
        Me.Answer2.Text = "Answer 2"
        Me.Answer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Answer2.UseVisualStyleBackColor = True
        '
        'Answer3
        '
        Me.Answer3.AutoSize = True
        Me.Answer3.Location = New System.Drawing.Point(18, 60)
        Me.Answer3.Name = "Answer3"
        Me.Answer3.Size = New System.Drawing.Size(69, 17)
        Me.Answer3.TabIndex = 4
        Me.Answer3.TabStop = True
        Me.Answer3.Text = "Answer 3"
        Me.Answer3.UseVisualStyleBackColor = True
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.ForeColor = System.Drawing.Color.Black
        Me.QuestionLabel.Location = New System.Drawing.Point(254, 108)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(101, 29)
        Me.QuestionLabel.TabIndex = 5
        Me.QuestionLabel.Text = "Question"
        Me.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Question1Button
        '
        Me.Question1Button.Location = New System.Drawing.Point(10, 15)
        Me.Question1Button.Name = "Question1Button"
        Me.Question1Button.Size = New System.Drawing.Size(59, 43)
        Me.Question1Button.TabIndex = 6
        Me.Question1Button.Text = "Question 1"
        Me.Question1Button.UseVisualStyleBackColor = True
        '
        'Question2Button
        '
        Me.Question2Button.Location = New System.Drawing.Point(75, 15)
        Me.Question2Button.Name = "Question2Button"
        Me.Question2Button.Size = New System.Drawing.Size(57, 43)
        Me.Question2Button.TabIndex = 7
        Me.Question2Button.Text = "Question 2"
        Me.Question2Button.UseVisualStyleBackColor = True
        '
        'Question3Button
        '
        Me.Question3Button.Location = New System.Drawing.Point(138, 15)
        Me.Question3Button.Name = "Question3Button"
        Me.Question3Button.Size = New System.Drawing.Size(57, 43)
        Me.Question3Button.TabIndex = 8
        Me.Question3Button.Text = "Question 3"
        Me.Question3Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Answer4)
        Me.Panel1.Controls.Add(Me.SubmitButton)
        Me.Panel1.Controls.Add(Me.Answer2)
        Me.Panel1.Controls.Add(Me.Answer1)
        Me.Panel1.Controls.Add(Me.Answer3)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(241, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 120)
        Me.Panel1.TabIndex = 9
        '
        'Answer4
        '
        Me.Answer4.AutoSize = True
        Me.Answer4.Location = New System.Drawing.Point(18, 83)
        Me.Answer4.Name = "Answer4"
        Me.Answer4.Size = New System.Drawing.Size(69, 17)
        Me.Answer4.TabIndex = 11
        Me.Answer4.TabStop = True
        Me.Answer4.Text = "Answer 4"
        Me.Answer4.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(198, 48)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(49, 20)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.Question15Button)
        Me.Panel2.Controls.Add(Me.Question14Button)
        Me.Panel2.Controls.Add(Me.Question13Button)
        Me.Panel2.Controls.Add(Me.Question12Button)
        Me.Panel2.Controls.Add(Me.Question11Button)
        Me.Panel2.Controls.Add(Me.Question10Button)
        Me.Panel2.Controls.Add(Me.Question9Button)
        Me.Panel2.Controls.Add(Me.Question8Button)
        Me.Panel2.Controls.Add(Me.Question7Button)
        Me.Panel2.Controls.Add(Me.Question6Button)
        Me.Panel2.Controls.Add(Me.Question5Button)
        Me.Panel2.Controls.Add(Me.Question4Button)
        Me.Panel2.Controls.Add(Me.Question3Button)
        Me.Panel2.Controls.Add(Me.Question2Button)
        Me.Panel2.Controls.Add(Me.Question1Button)
        Me.Panel2.Location = New System.Drawing.Point(12, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 266)
        Me.Panel2.TabIndex = 10
        '
        'Question15Button
        '
        Me.Question15Button.Location = New System.Drawing.Point(138, 211)
        Me.Question15Button.Name = "Question15Button"
        Me.Question15Button.Size = New System.Drawing.Size(57, 43)
        Me.Question15Button.TabIndex = 20
        Me.Question15Button.Text = "Question 15"
        Me.Question15Button.UseVisualStyleBackColor = True
        '
        'Question14Button
        '
        Me.Question14Button.Location = New System.Drawing.Point(75, 211)
        Me.Question14Button.Name = "Question14Button"
        Me.Question14Button.Size = New System.Drawing.Size(57, 43)
        Me.Question14Button.TabIndex = 19
        Me.Question14Button.Text = "Question 14"
        Me.Question14Button.UseVisualStyleBackColor = True
        '
        'Question13Button
        '
        Me.Question13Button.Location = New System.Drawing.Point(12, 211)
        Me.Question13Button.Name = "Question13Button"
        Me.Question13Button.Size = New System.Drawing.Size(57, 43)
        Me.Question13Button.TabIndex = 18
        Me.Question13Button.Text = "Question 13"
        Me.Question13Button.UseVisualStyleBackColor = True
        '
        'Question12Button
        '
        Me.Question12Button.Location = New System.Drawing.Point(138, 162)
        Me.Question12Button.Name = "Question12Button"
        Me.Question12Button.Size = New System.Drawing.Size(57, 43)
        Me.Question12Button.TabIndex = 17
        Me.Question12Button.Text = "Question 12"
        Me.Question12Button.UseVisualStyleBackColor = True
        '
        'Question11Button
        '
        Me.Question11Button.Location = New System.Drawing.Point(75, 162)
        Me.Question11Button.Name = "Question11Button"
        Me.Question11Button.Size = New System.Drawing.Size(57, 43)
        Me.Question11Button.TabIndex = 16
        Me.Question11Button.Text = "Question 11"
        Me.Question11Button.UseVisualStyleBackColor = True
        '
        'Question10Button
        '
        Me.Question10Button.Location = New System.Drawing.Point(12, 162)
        Me.Question10Button.Name = "Question10Button"
        Me.Question10Button.Size = New System.Drawing.Size(57, 43)
        Me.Question10Button.TabIndex = 15
        Me.Question10Button.Text = "Question 10"
        Me.Question10Button.UseVisualStyleBackColor = True
        '
        'Question9Button
        '
        Me.Question9Button.Location = New System.Drawing.Point(138, 113)
        Me.Question9Button.Name = "Question9Button"
        Me.Question9Button.Size = New System.Drawing.Size(57, 43)
        Me.Question9Button.TabIndex = 14
        Me.Question9Button.Text = "Question 9"
        Me.Question9Button.UseVisualStyleBackColor = True
        '
        'Question8Button
        '
        Me.Question8Button.Location = New System.Drawing.Point(75, 113)
        Me.Question8Button.Name = "Question8Button"
        Me.Question8Button.Size = New System.Drawing.Size(57, 43)
        Me.Question8Button.TabIndex = 13
        Me.Question8Button.Text = "Question 8"
        Me.Question8Button.UseVisualStyleBackColor = True
        '
        'Question7Button
        '
        Me.Question7Button.Location = New System.Drawing.Point(12, 113)
        Me.Question7Button.Name = "Question7Button"
        Me.Question7Button.Size = New System.Drawing.Size(57, 43)
        Me.Question7Button.TabIndex = 12
        Me.Question7Button.Text = "Question 7"
        Me.Question7Button.UseVisualStyleBackColor = True
        '
        'Question6Button
        '
        Me.Question6Button.Location = New System.Drawing.Point(138, 64)
        Me.Question6Button.Name = "Question6Button"
        Me.Question6Button.Size = New System.Drawing.Size(57, 43)
        Me.Question6Button.TabIndex = 11
        Me.Question6Button.Text = "Question 6"
        Me.Question6Button.UseVisualStyleBackColor = True
        '
        'Question5Button
        '
        Me.Question5Button.Location = New System.Drawing.Point(75, 64)
        Me.Question5Button.Name = "Question5Button"
        Me.Question5Button.Size = New System.Drawing.Size(57, 43)
        Me.Question5Button.TabIndex = 10
        Me.Question5Button.Text = "Question 5"
        Me.Question5Button.UseVisualStyleBackColor = True
        '
        'Question4Button
        '
        Me.Question4Button.Location = New System.Drawing.Point(12, 64)
        Me.Question4Button.Name = "Question4Button"
        Me.Question4Button.Size = New System.Drawing.Size(57, 43)
        Me.Question4Button.TabIndex = 9
        Me.Question4Button.Text = "Question 4"
        Me.Question4Button.UseVisualStyleBackColor = True
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(635, 98)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(35, 13)
        Me.ScoreLabel.TabIndex = 11
        Me.ScoreLabel.Text = "Score"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 344)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Name = "Form1"
        Me.Text = "Trivia Game"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Answer1 As System.Windows.Forms.RadioButton
    Friend WithEvents Answer2 As System.Windows.Forms.RadioButton
    Friend WithEvents Answer3 As System.Windows.Forms.RadioButton
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents Question1Button As System.Windows.Forms.Button
    Friend WithEvents Question2Button As System.Windows.Forms.Button
    Friend WithEvents Question3Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Question5Button As System.Windows.Forms.Button
    Friend WithEvents Question4Button As System.Windows.Forms.Button
    Friend WithEvents Answer4 As System.Windows.Forms.RadioButton
    Friend WithEvents Question15Button As System.Windows.Forms.Button
    Friend WithEvents Question14Button As System.Windows.Forms.Button
    Friend WithEvents Question13Button As System.Windows.Forms.Button
    Friend WithEvents Question12Button As System.Windows.Forms.Button
    Friend WithEvents Question11Button As System.Windows.Forms.Button
    Friend WithEvents Question10Button As System.Windows.Forms.Button
    Friend WithEvents Question9Button As System.Windows.Forms.Button
    Friend WithEvents Question8Button As System.Windows.Forms.Button
    Friend WithEvents Question7Button As System.Windows.Forms.Button
    Friend WithEvents Question6Button As System.Windows.Forms.Button
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label

End Class
