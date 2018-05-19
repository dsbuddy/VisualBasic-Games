Public Class Form1
    Dim turn, changed As Boolean
    Dim play1, play2 As Integer
    Dim diceToRoll(4) As Boolean
    Dim d(4) As Integer
    Dim rButtons(25) As RadioButton
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'd(0) = 4
        'd(1) = 4
        'd(2) = 4
        'd(3) = 4
        'd(4) = 4
        newDice(d, diceToRoll)
        drawDice(d)
        For i = 0 To 4
            diceToRoll(i) = False
        Next
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub
    Public Sub newDice(d() As Integer, diceToRoll() As Boolean)
        Randomize()
        For i = 0 To 4
            If diceToRoll(i) = True Then d(i) = CInt(Int((6 * Rnd()) + 1))
        Next
    End Sub
    Public Sub drawDice(d() As Integer)
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        For x As Integer = 0 To 4
            draw.FillRectangle(Brushes.White, 10, (x * 100) + 25, 90, 90)
            draw.DrawRectangle(Pens.Black, 10, (x * 100) + 25, 90, 90)
            If d(x) Mod 2 = 1 Then
                draw.FillEllipse(Brushes.Black, 45, (x * 100) + 60, 20, 20) 'center - center
            End If
            If d(x) > 1 Then
                draw.FillEllipse(Brushes.Black, 15, (x * 100) + 90, 20, 20) ' dot TL (2,3,4,5,6)
                draw.FillEllipse(Brushes.Black, 75, (x * 100) + 30, 20, 20) ' dot TL (2,3,4,5,6)
            End If
            If d(x) > 3 Then
                draw.FillEllipse(Brushes.Black, 15, (x * 100) + 30, 20, 20)
                draw.FillEllipse(Brushes.Black, 75, (x * 100) + 90, 20, 20)
            End If
            If d(x) = 6 Then
                draw.FillEllipse(Brushes.Black, 15, (x * 100) + 60, 20, 20) ' dot ML
                draw.FillEllipse(Brushes.Black, 75, (x * 100) + 60, 20, 20) ' dot ML
            End If
        Next
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X - Me.Location.X & "," & MousePosition.Y - Me.Location.Y
    End Sub
    Public Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim locX As Integer = MousePosition.X - Me.Location.X
        Dim locY As Integer = MousePosition.Y - Me.Location.Y
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        If locX >= 10 And locX <= 100 Then
            For i = 0 To 4
                If locY >= ((i * 100) + 25) And locY <= ((i * 100) + 115) Then
                    diceToRoll(i) = True
                    Dim thick As New Pen(Color.Red)
                    thick.Width = 3.3F
                    draw.DrawRectangle(thick, 8, (i * 100) + 23, 94, 94)
                End If
            Next
        End If
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newDice(d, diceToRoll)
        drawDice(d)
        Button2.Enabled = False
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        shellSort()
        If turn = True Then
            Panel1.Enabled = True
            Panel2.Enabled = False
        Else
            Panel1.Enabled = False
            Panel2.Enabled = True
        End If
        For i = 0 To 25
            If rButtons(i).Checked = True Then
                rButtons(i).Checked = False
                rButtons(i).Enabled = False
                check((i Mod 13), play1, play2)
            End If
        Next
        turn = Not (turn)

        Label5.Text = play1
        Label6.Text = play2
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillRectangle(Brushes.LightGray, 5, 20, 110, 500)
        Button2.Enabled = False
        Button1.Enabled = True
        For i = 0 To 4
            diceToRoll(i) = True
        Next
    End Sub
    Public Sub shellSort()
        Dim gap As Integer
        gap = d.Length \ 2
        Dim switch As Boolean
        Do
            Do
                switch = True
                For x = 0 To d.Length - (1 + gap)
                    If d(x) > d(x + gap) Then
                        Dim temp As String = d(x)
                        d(x) = d(x + gap)
                        d(x + gap) = temp
                        switch = False
                    End If
                Next
            Loop Until switch = True
            gap \= 2
        Loop Until gap = 0
    End Sub
    Public Sub check(whichOne As Integer, ByRef play1 As Integer, ByRef play2 As Integer)
        If whichOne >= 0 And whichOne <= 5 Then '1's-6's
            For i = 0 To 4
                If d(i) = (whichOne + 1) Then
                    If turn = False Then
                        play1 += (whichOne + 1)
                    Else
                        play2 += (whichOne + 1)
                    End If
                End If
            Next
        ElseIf whichOne = 6 Then
            If sameOne() >= 3 Then whichPlayer(sumDice(), play1, play2) '3 of a kind
        ElseIf whichOne = 7 Then
            If sameOne() >= 4 Then whichPlayer(sumDice(), play1, play2) '4 of a kind
        ElseIf whichOne = 8 Then
            If fullHouse() = 25 Then whichPlayer(25, play1, play2) 'full house
        ElseIf whichOne = 9 Then
            whichPlayer(sequence(0), play1, play2) 'small straight
        ElseIf whichOne = 10 Then
            whichPlayer(sequence(1), play1, play2) 'large straight
        ElseIf whichOne = 11 Then
            If sameOne() = 5 Then whichPlayer(50, play1, play2) 'yahtzee
        ElseIf whichOne = 12 Then
            whichPlayer(sumDice(), play1, play2) 'chance
        End If
        Array.Clear(d, 0, 5)
    End Sub
    Public Sub whichPlayer(acc As Integer, ByRef play1 As Integer, ByRef play2 As Integer)
        If turn = False Then
            play1 += acc
        Else
            play2 += acc
        End If
    End Sub
    Public Function sumDice()
        Dim sum As Integer
        For i = 0 To 4
            sum += d(i)
        Next
        Return sum
    End Function
    Public Function sequence(type As Boolean)
        Dim count As Integer = 1
        For i = 0 To d.Length - 2
            If d(i + 1) - d(i) = 1 Then count += 1
        Next
        'MsgBox(count & ", " & type)
        If count = 4 Or (Not (type) And count = 5) Then
            Return 30
        ElseIf type And count = 5 Then
            Return 40
        End If
        Return 0
    End Function
    Public Function sameOne() As Integer
        Dim count As Integer = 1 '2 2 3 3 3
        '3 3 3 2 2
        For i = 0 To 3
            If d(i + 1) - d(i) = 0 Then
                count += 1
            ElseIf count < 3 And d(i + 1) - d(i) <> 0 Then
                count = 1
            End If
        Next
        Return count
    End Function
    Public Function fullHouse() As Integer
        If ((d(0) = d(1)) And (d(2) = d(4))) Or ((d(0) = d(2)) And (d(3) = d(4))) Then Return 25
        Return 0
    End Function
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            diceToRoll(i) = True
        Next
        Button2.Enabled = False
        Panel2.Enabled = False
        rButtons(0) = RadioButton1
        rButtons(1) = RadioButton2
        rButtons(2) = RadioButton3
        rButtons(3) = RadioButton4
        rButtons(4) = RadioButton5
        rButtons(5) = RadioButton6
        rButtons(6) = RadioButton7
        rButtons(7) = RadioButton8
        rButtons(8) = RadioButton9
        rButtons(9) = RadioButton10
        rButtons(10) = RadioButton11
        rButtons(11) = RadioButton12
        rButtons(12) = RadioButton13
        rButtons(13) = RadioButton14
        rButtons(14) = RadioButton15
        rButtons(15) = RadioButton16
        rButtons(16) = RadioButton17
        rButtons(17) = RadioButton18
        rButtons(18) = RadioButton19
        rButtons(19) = RadioButton20
        rButtons(20) = RadioButton21
        rButtons(21) = RadioButton22
        rButtons(22) = RadioButton23
        rButtons(23) = RadioButton24
        rButtons(24) = RadioButton25
        rButtons(25) = RadioButton26
    End Sub
End Class
'Public Sub rollDice(dice As Integer)
'    Dim d(4) As Integer
'    Dim draw As System.Drawing.Graphics
'    draw = Me.CreateGraphics
'    draw.FillRectangle(Brushes.White, 10, (dice * 100) + 25, 90, 90)
'    draw.DrawRectangle(Pens.Black, 10, (dice * 100) + 25, 90, 90)
'    Randomize()
'    d(dice) = CInt(Int((6 * Rnd()) + 1))
'    d(0) = 1
'    draw.DrawRectangle(Pens.Black, 10, (dice * 100) + 25, 90, 90)
'    If d(dice) Mod 2 = 1 Then
'        draw.FillEllipse(Brushes.Black, 45, (dice * 100) + 60, 20, 20)
'    End If
'    If d(dice) > 1 Then
'        draw.FillEllipse(Brushes.Black, 15, (dice * 100) + 90, 20, 20)
'        draw.FillEllipse(Brushes.Black, 75, (dice * 100) + 30, 20, 20)
'    End If
'    If d(dice) > 3 Then
'        draw.FillEllipse(Brushes.Black, 15, (dice * 100) + 30, 20, 20)
'        draw.FillEllipse(Brushes.Black, 75, (dice * 100) + 90, 20, 20)
'    End If
'    If d(dice) = 6 Then
'        draw.FillEllipse(Brushes.Black, 15, (dice * 100) + 60, 20, 20)
'        draw.FillEllipse(Brushes.Black, 75, (dice * 100) + 60, 20, 20)
'    End If
'End Sub