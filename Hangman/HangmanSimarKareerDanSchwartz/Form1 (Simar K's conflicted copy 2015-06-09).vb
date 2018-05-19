Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X - Me.Location.X & ", " & MousePosition.Y - Me.Location.Y
    End Sub

    Public Sub hangHim(wrong As Integer)
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim x As Integer = 750
        'gallow


        If wrong = 1 Then
            draw.DrawEllipse(Pens.Black, New Rectangle(x - 10, 70, 60, 60)) 'head
        ElseIf wrong = 2 Then
            draw.DrawLine(Pens.Black, x, 90, x, 130) 'body
        ElseIf wrong = 3 Then
            draw.DrawLine(Pens.Black, x, 95, x - 15, 115) 'left arm
        ElseIf wrong = 4 Then
            draw.DrawLine(Pens.Black, x, 95, x + 15, 115) 'right arm
        ElseIf wrong = 5 Then
            draw.DrawLine(Pens.Black, x, 130, x - 15, 170) 'left leg
        ElseIf wrong = 6 Then
            draw.DrawLine(Pens.Black, x, 130, x + 15, 170) 'right leg
        End If
    End Sub

    Private Sub Guess(letter As Char, word As String)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 6
            MsgBox(i)
            hangHim(i)
        Next
    End Sub
End Class
