Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X - Me.Location.X & ", " & MousePosition.Y - Me.Location.Y
    End Sub
    Public Sub drawIt(wrong As Integer)
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        'gallow
        draw.DrawLine(Pens.Black, 85, 190, 210, 190)
        draw.DrawLine(Pens.Black, 148, 190, 148, 50)
        draw.DrawLine(Pens.Black, 148, 50, 198, 50)
        draw.DrawLine(Pens.Black, 198, 50, 198, 70)
        If wrong = 1 Then
            draw.DrawEllipse(Pens.Black, New Rectangle(188, 70, 20, 20)) 'head
        ElseIf wrong = 2 Then
            draw.DrawLine(Pens.Black, 198, 90, 198, 130) 'body
        ElseIf wrong = 3 Then
            draw.DrawLine(Pens.Black, 198, 95, 183, 115) 'left arm
        ElseIf wrong = 4 Then
            draw.DrawLine(Pens.Black, 198, 95, 213, 115) 'right arm
        ElseIf wrong = 5 Then
            draw.DrawLine(Pens.Black, 198, 130, 183, 170) 'left leg
        ElseIf wrong = 6 Then
            draw.DrawLine(Pens.Black, 198, 130, 213, 170) 'right leg
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 6
            MsgBox(i)
            drawIt(i)
        Next
    End Sub
End Class
