Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letters(25) As Integer
        Dim input As New IO.StreamReader("words.txt")
        Dim theWords() As String
        Dim howMany As Integer = 0
        Do Until input.EndOfStream
            ReDim Preserve theWords(howMany)
            theWords(howMany) = input.ReadLine
            Text = (theWords(howMany).ToString().ToUpper())
            howMany = howMany + 1
            For i = 0 To 25
                Dim amt() As String
                amt = Text.Split(Chr(i + 65))
                letters(i) = letters(i) + amt.Length - 1
            Next
        Loop

        'Everything Below is Extra Stuff to Improve Analytics
        Chart1.Series.Clear()
        Chart1.Titles.Add("Wheel of Fortune Letters")
        Dim s As New Series
        s.Name = "graph"
        s.ChartType = SeriesChartType.Column
        Dim lettersMax(25) As Double
        Dim lettersInAlpha(25) As String
        Dim total, sum As Integer
        total = 0
        sum = 0
        For i = 0 To 25
            s.Points.AddXY(i, letters(i))
            total = total + letters(i)
        Next
        For i = 0 To 25
            lettersMax(i) = Math.Round(((letters(i) / total) * 100), 2)
            ListBox1.Items.Add(Chr(i + 65) & ": " & letters(i) & " " & lettersMax(i) & "%")
            lettersInAlpha(i) = Chr(i + 65)
        Next
        Chart1.Series.Add(s)

        '  Array.Sort(lettersMax)
        '  Array.Reverse(lettersMax)
        Dim temp As Double
        Dim temp2 As String
        For x = 0 To lettersMax.Length - 1
            For y = 0 To lettersMax.Length - 2 - x
                If lettersMax(y) < lettersMax(y + 1) Then
                    temp = lettersMax(y)
                    lettersMax(y) = lettersMax(y + 1)
                    lettersMax(y + 1) = temp
                    temp2 = lettersInAlpha(y)
                    lettersInAlpha(y) = lettersInAlpha(y + 1)
                    lettersInAlpha(y + 1) = temp2
                End If
            Next
        Next
        For x = 0 To 25
            ListBox2.Items.Add(lettersInAlpha(x) & Chr(9) & lettersMax(x))

        Next



        'For Each str As Double In lettersMax
        '    'ListBox2.Items.Add(str & "%")
        '    For i = 0 To 25
        '        If lettersMax(i) = str Then lettersGreatest(i) = Chr(i + 65)
        '    Next
        '    For i = 0 To 25
        '        ListBox2.Items.Add(lettersGreatest(i))
        '    Next
        'Next
    End Sub
End Class
'109583 words

'test if sum of percentages = 100%
'For i = 0 To 25
'    sum = sum + lettersMax(i)
'Next