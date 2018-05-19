Public Class game
    Dim topic, phrase As String
    Public Sub New()
        topic = ""
        phrase = ""
    End Sub
    Public Sub New(aTopic As String, aPhrase As String)
        topic = aTopic
        phrase = aPhrase
    End Sub
    Public Function getTopic()
        Return topic
    End Function
    Public Function getPhrase()
        Return phrase
    End Function
End Class
