Public Class Pokedex
    Dim seenlist As ArrayList
    Dim caughtlist As ArrayList
    Dim dexSeen(802) As Array
    Dim dexCaught(802) As Array
    Dim fame As Integer
    Dim ribbon As Integer
    Dim badges As Integer
    Dim story As Integer
    Dim medals As Integer



    Public Sub New()
        fame = 0
        ribbon = 0
        badges = 0
        story = 0
        medals = 0
        caughtlist = New ArrayList
        seenlist = New ArrayList

    End Sub

    Public Sub New(ByVal nfame As Integer, ByVal nribbon As Integer, ByVal nbadges As Integer, ByVal nstory As Integer, ByVal nmedals As Integer)
        fame = nfame
        ribbon = nribbon
        badges = nbadges
        story = nstory
        medals = nmedals
        caughtlist = New ArrayList
        seenlist = New ArrayList
    End Sub


    Public Function GetBadges() As Integer
        Throw New NotImplementedException()
        Return badges
    End Function

    Public Function GetSeen() As Integer
        Throw New NotImplementedException()
        Return seenlist.Capacity()
    End Function

    Public Function GetCaught() As Integer
        Throw New NotImplementedException()
        Return caughtlist.Capacity()
    End Function

    Public Function GetFame() As Integer
        Throw New NotImplementedException()
        Return fame
    End Function

    Public Function GetRibbon() As Integer
        Throw New NotImplementedException()
        Return ribbon
    End Function

    Public Function GetFrontier() As Integer
        Throw New NotImplementedException()
        Return medals
    End Function

    Public Function GetStory() As Double
        Throw New NotImplementedException()
        Return story
    End Function

    Public Sub Caught(index As Integer)
        Throw New NotImplementedException()
        caughtlist.Add(index)
        dexCaught.SetValue("x", index)
    End Sub

    Public Sub Seen(index As Integer)
        Throw New NotImplementedException()
        seenlist.Add(index)
        dexSeen.SetValue("x", index)
    End Sub

    Public Sub SetThings(ByVal switch As Integer, ByVal num As Integer)
        Select Case switch
            Case 1
                fame = num
            Case 2
                ribbon = num
            Case 3
                badges = num
            Case 4
                medals = num
            Case 5
                story = num
        End Select
    End Sub
End Class
