Public Class Form1
    Dim correctAns As Integer
    Dim correctMessage As String
    Dim score As Integer
    Dim answered As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'If RadioButton1.Checked Then
        '    MsgBox("You Picked Male")
        'ElseIf RadioButton2.Checked Then
        '    MsgBox("You Picked Female")
        'Else
        '    MsgBox("You Picked Other")
        'End If
        ''Dim theName As String
        'theName = TextBox1.Text
        'MsgBox("Hi " & theName) 'string literal
        'TextBox1.Text = "Hi " & theName
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'QuestionLabel.AutoSize = False
        'QuestionLabel.Dock = DockStyle.Fill
    End Sub

    Private Sub Question1Button_Click(sender As Object, e As EventArgs) Handles Question1Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "In which continent did the ostrich originate?"
        Answer1.Text = "Africa"
        Answer2.Text = "Australia"
        Answer3.Text = "North America"
        Answer4.Text = "Asia"
        Panel2.Enabled = False
        Question1Button.Enabled = False
        correctAns = 1
        correctMessage = "The large continent, Africa is where the ostrich originated."
    End Sub

    Private Sub Question2Button_Click(sender As Object, e As EventArgs) Handles Question2Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "Speed skating originated in which country?"
        Answer1.Text = "Russia"
        Answer2.Text = "Netherlands"
        Answer3.Text = "Canada"
        Answer4.Text = "Norway"
        Panel2.Enabled = False
        Question2Button.Enabled = False
        correctAns = 2
        correctMessage = "Netherlands holds one medal in the sport that originated in their country."
    End Sub

    Private Sub Question3Button_Click(sender As Object, e As EventArgs) Handles Question3Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "Who was the first band to play at the Cavern Club?"
        Answer1.Text = "Swinging Blue Jeans"
        Answer2.Text = "The Merseysippi"
        Answer3.Text = "Beatles"
        Answer4.Text = "Merseybeats"
        Panel2.Enabled = False
        Question3Button.Enabled = False
        correctAns = 4
        correctMessage = "The band that emerged from the Liverpool scene, Merseybeats were the first band to play at the Cavern Club."
    End Sub

    Private Sub Question4Button_Click(sender As Object, e As EventArgs) Handles Question4Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "What are Lanthanides?"
        Answer1.Text = "Elements in the Periodic Table"
        Answer2.Text = "Mountains on Earth"
        Answer3.Text = "Mountains on the Moon"
        Answer4.Text = "Bacterium"
        Panel2.Enabled = False
        Question4Button.Enabled = False
        correctAns = 1
        correctMessage = "Lanthanides are the elements in the periodic table are number 57 through 71."
    End Sub

    Private Sub Question5Button_Click(sender As Object, e As EventArgs) Handles Question5Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "What part of the body does a turtle use to breathe?"
        Answer1.Text = "Belly"
        Answer2.Text = "Shell"
        Answer3.Text = "Mouth"
        Answer4.Text = "Anus"
        Panel2.Enabled = False
        Question5Button.Enabled = False
        correctAns = 4
        correctMessage = "The anus happens to be the body part that the turtle uses to breathe."
    End Sub

    Private Sub Question6Button_Click(sender As Object, e As EventArgs) Handles Question6Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "For how long is a dog pregnant?"
        Answer1.Text = "Nine Weeks"
        Answer2.Text = "Nine Days"
        Answer3.Text = "Nine Months"
        Answer4.Text = "Nine Minutes"
        Panel2.Enabled = False
        Question6Button.Enabled = False
        correctAns = 1
        correctMessage = "Unlike humans, it takes dogs nine weeks during their pregnancy."
    End Sub

    Private Sub Question7Button_Click(sender As Object, e As EventArgs) Handles Question7Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "Which of the following was owned by the fewest U.S. homes in 1990?"
        Answer1.Text = "Home Computer"
        Answer2.Text = "Compact Disk Player"
        Answer3.Text = "Cordless Phone"
        Answer4.Text = "Dishwasher"
        Panel2.Enabled = False
        Question7Button.Enabled = False
        correctAns = 2
        correctMessage = "Compact Disk Players was owned by the fewest in 1990 while their modern version, MP3 players are very common now."
    End Sub

    Private Sub Question8Button_Click(sender As Object, e As EventArgs) Handles Question8Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "When did Cherokee High School open?"

        Answer1.Text = "1965"
        Answer2.Text = "1970"
        Answer3.Text = "1975"
        Answer4.Text = "1980"
        Panel2.Enabled = False
        Question8Button.Enabled = False
        correctAns = 3
        correctMessage = "The first class at Cherokee High School was 1975."
    End Sub

    Private Sub Question9Button_Click(sender As Object, e As EventArgs) Handles Question9Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "The Philadelphia mint started putting a P mint mark on quarters when?"
        Answer1.Text = "1940"
        Answer2.Text = "1960"
        Answer3.Text = "1980"
        Answer4.Text = "Never"
        Panel2.Enabled = False
        Question9Button.Enabled = False
        correctAns = 3
        correctMessage = "In 1980, the P began to be marked on quarters."
    End Sub

    Private Sub Question10Button_Click(sender As Object, e As EventArgs) Handles Question10Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "When Mt. St. Helens erupted on May 18, 1980, how many people were killed?"
        Answer1.Text = "0"
        Answer2.Text = "1"
        Answer3.Text = "57"
        Answer4.Text = "571"
        Panel2.Enabled = False
        Question10Button.Enabled = False
        correctAns = 3
        correctMessage = "Sadly, 57 people were killed due to the eruption of Mt. St. Helens."
    End Sub

    Private Sub Question11Button_Click(sender As Object, e As EventArgs) Handles Question11Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "In J. Edgar Hoover, what did the J stand for?"
        Answer1.Text = "James"
        Answer2.Text = "John"
        Answer3.Text = "Jospeh"
        Answer4.Text = "Jake"
        Panel2.Enabled = False
        Question11Button.Enabled = False
        correctAns = 2
        correctMessage = "The J in J. Edgar Hoover stood for John."
    End Sub

    Private Sub Question12Button_Click(sender As Object, e As EventArgs) Handles Question12Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "What is the capital of Missouri?"
        Answer1.Text = "Kansas City"
        Answer2.Text = "Jefferson City"
        Answer3.Text = "Boonville"
        Answer4.Text = "Columbia"
        Panel2.Enabled = False
        Question12Button.Enabled = False
        correctAns = 2
        correctMessage = "Jefferson City is the capital of Missouri."
    End Sub

    Private Sub Question13Button_Click(sender As Object, e As EventArgs) Handles Question13Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "Who founded St. Louis?"
        Answer1.Text = "Auguste Chouteau"
        Answer2.Text = "Louis Jolliet"
        Answer3.Text = "Jacques Marquette"
        Answer4.Text = "Pierre Laclede Liguest"
        Panel2.Enabled = False
        Question13Button.Enabled = False
        correctAns = 4
        correctMessage = "Pierre Laclede Liguest founded St. Louis."
    End Sub

    Private Sub Question14Button_Click(sender As Object, e As EventArgs) Handles Question14Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "In anatomy, plantar relates to which part of the human body?"
        Answer1.Text = "Foot"
        Answer2.Text = "Stomach"
        Answer3.Text = "Head"
        Answer4.Text = "Hand"
        Panel2.Enabled = False
        Question14Button.Enabled = False
        correctAns = 1
        correctMessage = "Plantar relates to the foot of the human body."
    End Sub

    Private Sub Question15Button_Click(sender As Object, e As EventArgs) Handles Question15Button.Click
        Panel1.Enabled = True
        QuestionLabel.Text = "Which type of chocolate is considered good for your health?"
        Answer1.Text = "Dark"
        Answer2.Text = "Milk"
        Answer3.Text = "Semisweet"
        Answer4.Text = "White"
        Panel2.Enabled = False
        Question15Button.Enabled = False
        correctAns = 1
        correctMessage = " Dark Choc. is good for your health so get hershey's dark choc. kisses"
    End Sub
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim playerAns As Integer
        answered = answered + 1
        If Answer1.Checked Then
            playerAns = 1
        ElseIf Answer2.Checked Then
            playerAns = 2
        ElseIf Answer3.Checked Then
            playerAns = 3
        ElseIf Answer4.Checked Then
            playerAns = 4
        End If
        If playerAns = correctAns Then
            score = score + 1 'accumulator
            MsgBox("You were right!  Your score is " & score & ".  Your trivia score so far is " & score / answered * 100 & "%")
            ScoreLabel.Text = "Score: " & score / answered * 100 & "%"
        Else
            MsgBox("You were wrong!  " & correctMessage & ". Your trivia score so far is " & score / answered * 100 & "%")
            ScoreLabel.Text = "Score: " & score / answered * 100 & "%"
        End If
        Panel1.Enabled = False
        Panel2.Enabled = True
    End Sub

    Private Sub Answer1_CheckedChanged(sender As Object, e As EventArgs) Handles Answer1.CheckedChanged

    End Sub

    Private Sub Answer2_CheckedChanged(sender As Object, e As EventArgs) Handles Answer2.CheckedChanged

    End Sub

    Private Sub Answer3_CheckedChanged(sender As Object, e As EventArgs) Handles Answer3.CheckedChanged

    End Sub

    Private Sub Answer4_CheckedChanged(sender As Object, e As EventArgs) Handles Answer4.CheckedChanged

    End Sub


    Private Sub ScoreLabel_Click(sender As Object, e As EventArgs) Handles ScoreLabel.Click

    End Sub
End Class
