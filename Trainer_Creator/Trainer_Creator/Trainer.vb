Public Class Trainer
    Dim level, str, con, dex, cha, wis, inti, money, age, totalpoints, pointsleft, hp, currenthp As Integer
    Dim player, name, height As String
    Dim trainertype As ArrayList
    Dim party As ArrayList
    Dim pc As ArrayList
    Dim features As ArrayList
    Dim moves As ArrayList
    Dim space As Inventory
    Dim pdex As Pokedex

    Public Sub New(ByVal nStr As Integer, ByVal nCon As Integer, ByVal nDex As Integer, ByVal nCha As Integer, ByVal nWis As Integer, ByVal nInti As Integer)
        str = nStr
        con = nCon
        dex = nDex
        cha = nCha
        wis = nWis
        inti = nInti

    End Sub

    Public Sub New()
        level = 0
        str = 10
        con = 10
        dex = 10
        cha = 10
        wis = 10
        inti = 10
        totalpoints = 64 + (level * 2)
        pointsleft = totalpoints - str - con - dex - cha - wis - inti
        pdex = New Pokedex
        space = New Inventory
        moves = New ArrayList
        features = New ArrayList
        pc = New ArrayList
        party = New ArrayList
        trainertype = New ArrayList


    End Sub

    Public Function GetPokemon(ByVal index As Integer) As Pokemon
        Return party(index)
    End Function

    Public Sub SwapPokemon(ByVal poke1 As Integer, ByVal poke2 As Integer)
        Dim temp As Pokemon
        temp = party(poke1)
        party(poke1) = pc(poke2)
        pc(poke2) = temp
    End Sub

    Public Sub SetPokemon(ByVal index As Integer, ByRef pkmn As Pokemon)
        party(index) = pkmn
        CaughtPkmn(pkmn.GetDexNum())

    End Sub

    Public Sub AddMove(ByVal move As Attack)
        moves.Add(move)
    End Sub

    Public Sub AddFeat(ByVal feat As Feat)
        features.Add(feat)
    End Sub

    Public Sub CaughtPkmn(ByVal index As Integer)
        pdex.Caught(index)
        SetLevel()

    End Sub

    Public Sub SeenPkmn(ByRef index As Integer)
        pdex.Seen(index)
        SetLevel()
    End Sub

    Public Function GetTotalPoints() As Integer
        Return totalpoints = 64 + (GetLevel() * 2)
    End Function

    Public Function GetLevel() As Integer
        Return level
    End Function

    Public Sub SetLevel(ByVal num As Integer)
        level = num
    End Sub

    Public Sub AddItem(ByVal type As Integer, ByVal item As String, ByVal quantity As Integer)
        Select Case type
            Case 1 'GeneralItems'
                space.AddGeneralItem(item, quantity)
            Case 2 'TM/Hm'
                space.AddTM(item, quantity)
            Case 3 'Pokeball'
                space.AddPokeball(item, quantity)
            Case 4 'Food and Meds'
                space.AddMedicalItem(item, quantity)
            Case 5 'KeyItems'
                space.AddKeyItem(item, quantity)
        End Select
    End Sub

    Public Sub SetLevel()
        level = pdex.GetBadges() + (pdex.GetSeen() / 10) + (pdex.GetCaught() / 5) + pdex.GetFame() * 2 + pdex.GetRibbon() + pdex.GetStory() + pdex.GetFrontier()
    End Sub

End Class
