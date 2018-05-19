Public Class Form1
    Dim words As New ArrayList
    Dim toGuess As String
    Dim category As String
    Dim wordArray(0) As String
    Dim checked(0) As Boolean
    Dim output As String = ""
    Dim wrong As Integer

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Label1.Text = MousePosition.X - Me.Location.X & ", " & MousePosition.Y - Me.Location.Y
    'End Sub

    Public Sub hangHim(wrong As Integer)
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim x As Integer = 725
        Dim brown As New Pen(Color.Brown, 6.0F)
        Dim black As New Pen(Color.Black, 2.0F)
        'gallow
        draw.DrawLine(brown, x + 30, 70, x + 30, 30) 'vertical noose
        draw.DrawLine(brown, x + 100, 33, x + 30, 33) 'top horizontal
        draw.DrawLine(brown, x + 130, 350, x, 350) 'bottom horizontal
        draw.DrawLine(brown, x + 100, 350, x + 100, 30) 'vertical long
        'body
        If wrong = 1 Then
            draw.DrawEllipse(black, New Rectangle(x, 70, 60, 60)) 'head
        ElseIf wrong = 2 Then
            draw.DrawLine(black, x + 30, 130, x + 30, 230) 'body
        ElseIf wrong = 3 Then
            draw.DrawLine(black, x + 30, 180, x, 150) 'left arm
        ElseIf wrong = 4 Then
            draw.DrawLine(black, x + 30, 180, x + 60, 150) 'left arm
        ElseIf wrong = 5 Then
            draw.DrawLine(black, x + 30, 230, x + 60, 300) 'left leg
        ElseIf wrong = 6 Then
            draw.DrawLine(black, x + 30, 230, x, 300) 'right leg
            Label2.Text = toGuess
            reset()
        End If
    End Sub

    Private Sub reset()
        TextBox1.Text = ""
        Dim response = MsgBox("Play again?", MsgBoxStyle.YesNo, "Good Game")
        If response = MsgBoxResult.Yes Then
            For i As Integer = 0 To wordArray.Length - 1
                checked(i) = 0
            Next
            Dim clear As System.Drawing.Graphics = Me.CreateGraphics
            clear.FillRectangle(Brushes.Silver, 700, 50, 100, 280)
            ListBox1.Items.Clear()
            output = ""
            pickGame()
            arrayIt(toGuess)
            labelIt(output)
            Label2.Text = output
            wrong = 0
        Else
            End
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        output = ""
        If Not (ListBox1.Items.Contains(TextBox1.Text.ToUpper)) Then
            checkIt(TextBox1.Text, checked)
            labelIt(output)
            Label2.Text = output
            hangHim(wrong)
            If iscompleted() = False Then reset()
        End If
        TextBox1.Text = ""
    End Sub
    Private Function iscompleted()
        Dim isfinished As Boolean
        For i As Integer = 0 To checked.Length - 1
            If wordArray(i) = " " Then i += 1
            If checked(i) = False Then isfinished = True
        Next
        If isfinished = False Then My.Computer.Audio.Play("yahtzee.wav", AudioPlayMode.Background)
        Return isfinished
    End Function
    Public Sub arrayIt(word As String)
        ReDim wordArray(word.Length - 1)
        ReDim checked(word.Length - 1)
        For i = 0 To word.Length - 1
            wordArray(i) = word.Substring(i, 1)
        Next
    End Sub

    Public Sub checkIt(guessedLetter As String, ByRef checked() As Boolean)
        Dim count As Integer = 0
        If TextBox1.Text = "" Or TextBox1.Text.Length > 1 Then
        ElseIf Asc(guessedLetter.ToUpper()) >= 65 And Asc(guessedLetter.ToUpper()) <= 90 Then
            ListBox1.Items.Add(guessedLetter.ToUpper()) 'crahses if empty box
            For i = 0 To wordArray.Length - 1
                If wordArray(i).ToLower() = guessedLetter.ToLower() Then
                    checked(i) = 1
                    count += 1
                End If
            Next
            If count = 0 Then wrong += 1
        End If
    End Sub

    Public Function labelIt(ByRef output As String) As String
        For i = 0 To wordArray.Length - 1
            If wordArray(i) = " " Then
                output += "    "
            ElseIf checked(i) = True Then
                output += wordArray(i) & " "
            Else
                output += " __ "
            End If
        Next
        Return output
    End Function

    Private Sub pickGame()
        Randomize()
        Dim temp As Integer = CInt(Int((words.Count * Rnd()) + 1))
        category = words(temp).substring(0, words(temp).indexOf(","))
        toGuess = words(temp).substring(words(temp).indexof(",") + 1)
        Label3.Text = category
        words.RemoveAt(temp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Panel1.Visible = True
        arrayIt(toGuess)
        labelIt(output)
        Label2.Text = output
        Label3.Text = category
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As New IO.StreamReader("words.txt")
        Do Until list.EndOfStream
            words.Add(list.ReadLine)
        Loop
        pickGame()
    End Sub
End Class