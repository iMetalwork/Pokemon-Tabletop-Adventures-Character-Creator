Imports System.IO

Public Class Form1
    Dim tempPoint As Integer
    Dim previousSelected, previousSelected2, previousSelected3 As String
    Dim filepath, imagepath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxClass1.Text = "None"
        cbxClass2.Text = "None"
        cbxClass3.Text = "None"
        cbxClass4.Text = "None"
        lblAdjStr.Text = txtbxStr.Text
        lblAdjDex.Text = txtbxDex.Text
        lblAdjCon.Text = txtbxCon.Text
        lblAdjInt.Text = txtbxInt.Text
        lblAdjWis.Text = txtbxWis.Text
        lblAdjCha.Text = txtbxCha.Text

        filepath = Directory.GetCurrentDirectory() + "\Resources"


        If Not Directory.Exists(filepath) Then
            Directory.CreateDirectory(filepath)
        End If


    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        Dim newdialog As New OpenFileDialog
        With newdialog
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*; .jpg; *.png"

            If .ShowDialog = DialogResult.OK Then
                Dim Fname() As String = newdialog.FileName.Split("\\")
                imagepath = filepath + "\" + Fname(Fname.Length - 1)
                If Not File.Exists(imagepath) Then

                    File.Copy(newdialog.FileName, imagepath)
                    PictureBox1.Image = Image.FromFile(.FileName)
                Else
                    PictureBox1.Image = Image.FromFile(imagepath)

                End If

            End If

        End With

    End Sub

    Private Sub cbxClass1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass1.SelectionChangeCommitted
        If cbxClass1.Text.Equals("Ace Trainer") Then
            cbxClass2.Items.Add("Chaser")
            cbxClass2.Items.Add("Enduring Soul")
            cbxClass2.Items.Add("Stat Ace")
            cbxClass2.Items.Add("Strategist")
            cbxClass2.Items.Add("Tag Battler")
            cbxClass2.Items.Add("Type Ace")
            cbxClass2.Items.Add("UnderDog")
            cbxClass3.Items.Add("Chaser")
            cbxClass3.Items.Add("Enduring Soul")
            cbxClass3.Items.Add("Stat Ace")
            cbxClass3.Items.Add("Strategist")
            cbxClass3.Items.Add("Tag Battler")
            cbxClass3.Items.Add("Type Ace")
            cbxClass3.Items.Add("UnderDog")
            cbxClass4.Items.Add("Chaser")
            cbxClass4.Items.Add("Enduring Soul")
            cbxClass4.Items.Add("Stat Ace")
            cbxClass4.Items.Add("Strategist")
            cbxClass4.Items.Add("Tag Battler")
            cbxClass4.Items.Add("Type Ace")
            cbxClass4.Items.Add("UnderDog")
        End If

        If cbxClass1.Text.Equals("Breeder") Then
            cbxClass2.Items.Add("Botanist")
            cbxClass2.Items.Add("Chef")
            cbxClass2.Items.Add("Evolver")
            cbxClass2.Items.Add("Groomer")
            cbxClass2.Items.Add("Hatcher")
            cbxClass2.Items.Add("Medic")
            cbxClass2.Items.Add("Move Tutor")
            cbxClass3.Items.Add("Botanist")
            cbxClass3.Items.Add("Chef")
            cbxClass3.Items.Add("Evolver")
            cbxClass3.Items.Add("Groomer")
            cbxClass3.Items.Add("Hatcher")
            cbxClass3.Items.Add("Medic")
            cbxClass3.Items.Add("Move Tutor")
            cbxClass4.Items.Add("Botanist")
            cbxClass4.Items.Add("Chef")
            cbxClass4.Items.Add("Evolver")
            cbxClass4.Items.Add("Groomer")
            cbxClass4.Items.Add("Hatcher")
            cbxClass4.Items.Add("Medic")
            cbxClass4.Items.Add("Move Tutor")
        End If
        If cbxClass1.Text.Equals("Capture Specialist") Then
            cbxClass2.Items.Add("Artificer")
            cbxClass2.Items.Add("Collector")
            cbxClass2.Items.Add("Engineer")
            cbxClass2.Items.Add("Juggler")
            cbxClass2.Items.Add("Pokeball Designer")
            cbxClass2.Items.Add("Snagger")
            cbxClass2.Items.Add("Trapper")
            cbxClass3.Items.Add("Artificer")
            cbxClass3.Items.Add("Collector")
            cbxClass3.Items.Add("Engineer")
            cbxClass3.Items.Add("Juggler")
            cbxClass3.Items.Add("Pokeball Designer")
            cbxClass3.Items.Add("Snagger")
            cbxClass3.Items.Add("Trapper")
            cbxClass4.Items.Add("Artificer")
            cbxClass4.Items.Add("Collector")
            cbxClass4.Items.Add("Engineer")
            cbxClass4.Items.Add("Juggler")
            cbxClass4.Items.Add("Pokeball Designer")
            cbxClass4.Items.Add("Snagger")
            cbxClass4.Items.Add("Trapper")
        End If

        If cbxClass1.Text.Equals("Coordinator") Then
            cbxClass2.Items.Add("Beauty Modeler")
            cbxClass2.Items.Add("Choreographer")
            cbxClass2.Items.Add("Cool Trainer")
            cbxClass2.Items.Add("Cute Idol")
            cbxClass2.Items.Add("Fashion Designer")
            cbxClass2.Items.Add("Smart Teacher")
            cbxClass2.Items.Add("Tough Guy")
            cbxClass3.Items.Add("Beauty Modeler")
            cbxClass3.Items.Add("Choreographer")
            cbxClass3.Items.Add("Cool Trainer")
            cbxClass3.Items.Add("Cute Idol")
            cbxClass3.Items.Add("Fashion Designer")
            cbxClass3.Items.Add("Smart Teacher")
            cbxClass3.Items.Add("Tough Guy")
            cbxClass4.Items.Add("Beauty Modeler")
            cbxClass4.Items.Add("Choreographer")
            cbxClass4.Items.Add("Cool Trainer")
            cbxClass4.Items.Add("Cute Idol")
            cbxClass4.Items.Add("Fashion Designer")
            cbxClass4.Items.Add("Smart Teacher")
            cbxClass4.Items.Add("Tough Guy")
        End If

        If cbxClass1.Text.Equals("Martial Artist") Then
            cbxClass2.Items.Add("Athlete")
            cbxClass2.Items.Add("Aura User")
            cbxClass2.Items.Add("Blackbelt")
            cbxClass2.Items.Add("Dirty Fighter")
            cbxClass2.Items.Add("Massage Therapist")
            cbxClass2.Items.Add("Ninja")
            cbxClass2.Items.Add("Weapons Master")
            cbxClass3.Items.Add("Athlete")
            cbxClass3.Items.Add("Aura User")
            cbxClass3.Items.Add("Blackbelt")
            cbxClass3.Items.Add("Dirty Fighter")
            cbxClass3.Items.Add("Massage Therapist")
            cbxClass3.Items.Add("Ninja")
            cbxClass3.Items.Add("Weapons Master")
            cbxClass4.Items.Add("Athlete")
            cbxClass4.Items.Add("Aura User")
            cbxClass4.Items.Add("Blackbelt")
            cbxClass4.Items.Add("Dirty Fighter")
            cbxClass4.Items.Add("Massage Therapist")
            cbxClass4.Items.Add("Ninja")
            cbxClass4.Items.Add("Weapons Master")
        End If

        If cbxClass1.Text.Equals("Mystic") Then
            cbxClass2.Items.Add("Body Snatcher")
            cbxClass2.Items.Add("Buffet")
            cbxClass2.Items.Add("Godspeaker")
            cbxClass2.Items.Add("Guardian")
            cbxClass2.Items.Add("Rune Master")
            cbxClass2.Items.Add("Shaman")
            cbxClass2.Items.Add("Touched")
            cbxClass3.Items.Add("Body Snatcher")
            cbxClass3.Items.Add("Buffet")
            cbxClass3.Items.Add("Godspeaker")
            cbxClass3.Items.Add("Guardian")
            cbxClass3.Items.Add("Rune Master")
            cbxClass3.Items.Add("Shaman")
            cbxClass3.Items.Add("Touched")
            cbxClass4.Items.Add("Body Snatcher")
            cbxClass4.Items.Add("Buffet")
            cbxClass4.Items.Add("Godspeaker")
            cbxClass4.Items.Add("Guardian")
            cbxClass4.Items.Add("Rune Master")
            cbxClass4.Items.Add("Shaman")
            cbxClass4.Items.Add("Touched")
        End If

        If cbxClass1.Text.Equals("Psychic") Then
            cbxClass2.Items.Add("Air Adept")
            cbxClass2.Items.Add("Clairsentient")
            cbxClass2.Items.Add("Earthshaker")
            cbxClass2.Items.Add("Empath")
            cbxClass2.Items.Add("Fire-breather")
            cbxClass2.Items.Add("Hex Maniac")
            cbxClass2.Items.Add("Rain Walker")
            cbxClass3.Items.Add("Air Adept")
            cbxClass3.Items.Add("Clairsentient")
            cbxClass3.Items.Add("Earthshaker")
            cbxClass3.Items.Add("Empath")
            cbxClass3.Items.Add("Fire-breather")
            cbxClass3.Items.Add("Hex Maniac")
            cbxClass3.Items.Add("Rain Walker")
            cbxClass4.Items.Add("Air Adept")
            cbxClass4.Items.Add("Clairsentient")
            cbxClass4.Items.Add("Earthshaker")
            cbxClass4.Items.Add("Empath")
            cbxClass4.Items.Add("Fire-breather")
            cbxClass4.Items.Add("Hex Maniac")
            cbxClass4.Items.Add("Rain Walker")
        End If

        If cbxClass1.Text.Equals("Ranger") Then
            cbxClass2.Items.Add("Coach")
            cbxClass2.Items.Add("Commander")
            cbxClass2.Items.Add("Detective")
            cbxClass2.Items.Add("Rider")
            cbxClass2.Items.Add("Signer")
            cbxClass2.Items.Add("Special Operations")
            cbxClass2.Items.Add("Survivalist")
            cbxClass3.Items.Add("Coach")
            cbxClass3.Items.Add("Commander")
            cbxClass3.Items.Add("Detective")
            cbxClass3.Items.Add("Rider")
            cbxClass3.Items.Add("Signer")
            cbxClass3.Items.Add("Special Operations")
            cbxClass3.Items.Add("Survivalist")
            cbxClass4.Items.Add("Coach")
            cbxClass4.Items.Add("Commander")
            cbxClass4.Items.Add("Detective")
            cbxClass4.Items.Add("Rider")
            cbxClass4.Items.Add("Signer")
            cbxClass4.Items.Add("Special Operations")
            cbxClass4.Items.Add("Survivalist")
        End If

        If cbxClass1.Text.Equals("Researcher") Then
            cbxClass2.Items.Add("Cryptozoologist")
            cbxClass2.Items.Add("Dream Doctor")
            cbxClass2.Items.Add("Petrologist")
            cbxClass2.Items.Add("Photographer")
            cbxClass2.Items.Add("Professor")
            cbxClass2.Items.Add("Scientist")
            cbxClass2.Items.Add("Watcher")
            cbxClass3.Items.Add("Cryptozoologist")
            cbxClass3.Items.Add("Dream Doctor")
            cbxClass3.Items.Add("Petrologist")
            cbxClass3.Items.Add("Photographer")
            cbxClass3.Items.Add("Professor")
            cbxClass3.Items.Add("Scientist")
            cbxClass3.Items.Add("Watcher")
            cbxClass4.Items.Add("Cryptozoologist")
            cbxClass4.Items.Add("Dream Doctor")
            cbxClass4.Items.Add("Petrologist")
            cbxClass4.Items.Add("Photographer")
            cbxClass4.Items.Add("Professor")
            cbxClass4.Items.Add("Scientist")
            cbxClass4.Items.Add("Watcher")
        End If

        If Int(lblAdjStr.Text) > Int(txtbxStr.Text) Or Int(lblAdjStr.Text) < Int(txtbxStr.Text) Then
            lblAdjStr.Text = txtbxStr.Text
        End If

        If Int(lblAdjDex.Text) > Int(txtbxDex.Text) Or Int(lblAdjDex.Text) < Int(txtbxDex.Text) Then
            lblAdjDex.Text = txtbxDex.Text
        End If

        If Int(lblAdjCon.Text) > Int(txtbxCon.Text) Or Int(lblAdjCon.Text) < Int(txtbxCon.Text) Then
            lblAdjCon.Text = txtbxCon.Text
        End If

        If Int(lblAdjInt.Text) > Int(txtbxInt.Text) Or Int(lblAdjInt.Text) < Int(txtbxInt.Text) Then
            lblAdjInt.Text = txtbxInt.Text
        End If

        If Int(lblAdjWis.Text) > Int(txtbxWis.Text) Or Int(lblAdjWis.Text) < Int(txtbxWis.Text) Then
            lblAdjWis.Text = txtbxWis.Text
        End If

        If Int(lblAdjCha.Text) > Int(txtbxCha.Text) Or Int(lblAdjCha.Text) < Int(txtbxCha.Text) Then
            lblAdjCha.Text = txtbxCha.Text
        End If

        If cbxClass1.Text.Equals("Ace Trainer") Or cbxClass1.Text.Equals("Martial Artist") Or cbxClass1.Text.Equals("Mystic") Then
            lblAdjStr.Text = Int(lblAdjStr.Text) + 1
        End If

        If cbxClass1.Text.Equals("Capture Specialist") Or cbxClass1.Text.Equals("Martial Artist") Or cbxClass1.Text.Equals("Ranger") Then
            lblAdjDex.Text = Int(lblAdjDex.Text) + 1
        End If

        If cbxClass1.Text.Equals("Ace Trainer") Or cbxClass1.Text.Equals("Coordinator") Or cbxClass1.Text.Equals("Psychic") Then
            lblAdjCon.Text = Int(lblAdjCon.Text) + 1
        End If

        If cbxClass1.Text.Equals("Capture Specialist") Or cbxClass1.Text.Equals("Psychic") Or cbxClass1.Text.Equals("Researcher") Then
            lblAdjInt.Text = Int(lblAdjInt.Text) + 1
        End If

        If cbxClass1.Text.Equals("Breeder") Or cbxClass1.Text.Equals("Mystic") Or cbxClass1.Text.Equals("Researcher") Then
            lblAdjWis.Text = Int(lblAdjWis.Text) + 1
        End If

        If cbxClass1.Text.Equals("Breeder") Or cbxClass1.Text.Equals("Mystic") Or cbxClass1.Text.Equals("Researcher") Then
            lblAdjCha.Text = Int(lblAdjCha.Text) + 1
        End If

        If cbxClass1.Text.Equals("Researcher") Then
            lblAdjStr.Text = Int(lblAdjStr.Text) - 2

        ElseIf cbxClass1.Text.Equals("Breeder") Or cbxClass1.Text.Equals("Coordinator") Then
            lblAdjDex.Text = Int(lblAdjDex.Text) - 2

        ElseIf cbxClass1.Text.Equals("Capture Specialist") Or cbxClass1.Text.Equals("Ranger") Then
            lblAdjCon.Text = Int(lblAdjCon.Text) - 2

        ElseIf cbxClass1.Text.Equals("Martial Artist") Then
            lblAdjInt.Text = Int(lblAdjInt.Text) - 2

        ElseIf cbxClass1.Text.Equals("Ace Trainer") Then
            lblAdjWis.Text = Int(lblAdjWis.Text) - 2

        ElseIf cbxClass1.Text.Equals("Mystic") Then
            lblAdjCha.Text = Int(lblAdjCha.Text) - 2
        End If
    End Sub

    Private Sub cbxClass4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass4.SelectionChangeCommitted
        If previousSelected3 = "Ace Trainer" Then
            lblAdjWis.Text = Int(lblAdjWis) + 2
        End If

        If previousSelected3 = "Breeder" Or previousSelected3 = "Coordinator" Then
            lblAdjDex.Text = Int(lblAdjDex) + 2
        End If

        If previousSelected3 = "Capture Specialist" Or previousSelected3 = "Ranger" Then
            lblAdjCon.Text = Int(lblAdjCon) + 2
        End If

        If previousSelected3 = "Pschic" Or previousSelected3 = "Researcher" Then
            lblAdjStr.Text = Int(lblAdjStr) + 2
        End If

        If previousSelected3 = "Mystic" Then
            lblAdjCha.Text = Int(lblAdjCha) + 2
        End If

        If previousSelected3 = "Martial Artist" Then
            lblAdjInt.Text = Int(lblAdjInt) + 2
        End If

        If previousSelected3 = "Ace Trainer" Or previousSelected3 = "Chaser" Or previousSelected3 = "Stat Ace" Or previousSelected3 = "Martial Artist" Or previousSelected3 = "Athlete" Or
            previousSelected3 = "Aura User" Or previousSelected3 = "Blackbelt" Or previousSelected3 = "Weapons Master" Or previousSelected3 = "Mystic" Or previousSelected3 = "Touched" Or
            previousSelected3 = "Guardian" Or previousSelected3 = "Godspeaker" Or previousSelected3 = "Strategist" Then


            lblAdjStr.Text = Int(lblAdjStr.Text) - 1
        End If

        If previousSelected3 = "Capture Specialist" Or previousSelected3 = "Artificer" Or previousSelected3 = "Collector" Or previousSelected3 = "Juggler" Or previousSelected3 = "Trapper" Or
            previousSelected3 = "Trapper" Or previousSelected3 = "Martial Artist" Or previousSelected3 = "Dirty Fighter" Or previousSelected3 = "Massage Therapist" Or previousSelected3 = "Ninja" Or
            previousSelected3 = "Ranger" Or previousSelected3 = "Rider" Or previousSelected3 = "Special Operations" Or previousSelected3 = "Survivalist" Or previousSelected3 = "Signer" Then

            lblAdjDex.Text = Int(lblAdjDex.Text) - 1
        End If

        If previousSelected3 = "Ace Trainer" Or previousSelected3 = "Enduring Soul" Or previousSelected3 = "Tag Battler" Or previousSelected3 = "Underdog" Or previousSelected3 = "Coordinator" Or
            previousSelected3 = "Choreographer" Or previousSelected3 = "Beauty Modeler" Or previousSelected3 = "Tough Guy" Or previousSelected3 = "Psychic" Or previousSelected3 = "Air Adept" Or
            previousSelected3 = "Earthshaker" Or previousSelected3 = "Rain Walker" Or previousSelected3 = "Type Ace" Or previousSelected3 = "Fire-breather" Then

            lblAdjCon.Text = Int(lblAdjCon.Text) - 1

        End If

        If previousSelected3 = "Capture Specialist" Or previousSelected3 = "Engineer" Or previousSelected3 = "Pokeball Designer" Or previousSelected3 = "Snagger" Or previousSelected3 = "Psychic" Or
            previousSelected3 = "Clairsentient" Or previousSelected3 = "Empath" Or previousSelected3 = "Hex Maniac" Or previousSelected3 = "Researcher" Or previousSelected3 = "Professor" Or
            previousSelected3 = "Scientist" Or previousSelected3 = "Petrologist" Then

            lblAdjInt.Text = Int(lblAdjInt.Text) - 1
        End If

        If previousSelected3 = "Breeder" Or previousSelected3 = "Botanist" Or previousSelected3 = "Chef" Or previousSelected3 = "Medic" Or previousSelected3 = "Move Tutor" Or previousSelected3 = "Mystic" Or
                previousSelected3 = "Body Snatcher" Or previousSelected3 = "Buffet" Or previousSelected3 = "Rune Master" Or previousSelected3 = "Shaman" Or previousSelected3 = "Researcher" Or
                previousSelected3 = "Cryptozoologist" Or previousSelected3 = "Dream Doctor" Or previousSelected3 = "Photographer" Or previousSelected3 = "Watcher" Then

            lblAdjWis.Text = Int(lblAdjWis.Text) - 1

        End If

        If previousSelected3 = "Breeder" Or previousSelected3 = "Evolver" Or previousSelected3 = "Groomer" Or previousSelected3 = "Hatcher" Or previousSelected3 = "Coordinator" Or previousSelected3 = "Cool Trainer" Or
            previousSelected3 = "Cute Idol" Or previousSelected3 = "Fashion Designer" Or previousSelected3 = "Smart Teacher" Or previousSelected3 = "Ranger" Or previousSelected3 = "Coach" Or
            previousSelected3 = "Commander" Or previousSelected3 = "Detective" Then

            lblAdjCha.Text = Int(lblAdjCha.Text) - 1

        End If

        If cbxClass4.Text.Equals("Ace Trainer") Or cbxClass4.Text.Equals("Chaser") Or cbxClass4.Text.Equals("Stat Ace") Or cbxClass4.Text.Equals("Martial Artist") Or cbxClass4.Text.Equals("Athlete") Or
            cbxClass4.Text.Equals("Aura User") Or cbxClass4.Text.Equals("Blackbelt") Or cbxClass4.Text.Equals("Weapons Master") Or cbxClass4.Text.Equals("Mystic") Or cbxClass4.Text.Equals("Touched") Or
            cbxClass4.Text.Equals("Guardian") Or cbxClass4.Text.Equals("Godspeaker") Or cbxClass4.Text.Equals("Strategist") Then

            lblAdjStr.Text = Int(lblAdjStr.Text) + 1
            previousSelected3 = cbxClass4.Text
        End If

        If cbxClass4.Text.Equals("Capture Specialist") Or cbxClass4.Text.Equals("Artificer") Or cbxClass4.Text.Equals("Collector") Or cbxClass4.Text.Equals("Juggler") Or cbxClass4.Text.Equals("Trapper") Or
           cbxClass4.Text.Equals("Martial Artist") Or cbxClass4.Text.Equals("Dirty Fighter") Or cbxClass4.Text.Equals("Massage Therapist") Or cbxClass4.Text.Equals("Ninja") Or cbxClass4.Text.Equals("Ranger") Or
           cbxClass4.Text.Equals("Rider") Or cbxClass4.Text.Equals("Special Operations") Or cbxClass4.Text.Equals("Survivalist") Or cbxClass4.Text.Equals("Signer") Then

            lblAdjDex.Text = Int(lblAdjDex.Text) + 1
            previousSelected3 = cbxClass4.Text
        End If

        If cbxClass4.Text.Equals("Ace Trainer") Or cbxClass4.Text.Equals("Enduring Soul") Or cbxClass4.Text.Equals("Tag Battler") Or cbxClass4.Text.Equals("Underdog") Or cbxClass4.Text.Equals("Coordinator") Or
            cbxClass4.Text.Equals("Choreographer") Or cbxClass4.Text.Equals("Beauty Modeler") Or cbxClass4.Text.Equals("Tough Guy") Or cbxClass4.Text.Equals("Psychic") Or cbxClass4.Text.Equals("Air Adept") Or
            cbxClass4.Text.Equals("Earthshaker") Or cbxClass4.Text.Equals("Rain Walker") Or cbxClass4.Text.Equals("Type Ace") Or cbxClass4.Text.Equals("Fire-breather") Then

            lblAdjCon.Text = Int(lblAdjCon.Text) + 1
            previousSelected3 = cbxClass4.Text
        End If

        If cbxClass4.Text.Equals("Capture Specialist") Or cbxClass4.Text.Equals("Engineer") Or cbxClass4.Text.Equals("Pokeball Designer") Or cbxClass4.Text.Equals("Snagger") Or cbxClass4.Text.Equals("Researcher") Or
            cbxClass4.Text.Equals("Professor") Or cbxClass4.Text.Equals("Scientist") Or cbxClass4.Text.Equals("Petrologist") Or cbxClass4.Text.Equals("Psychic") Or cbxClass4.Text.Equals("Clairsentient") Or
            cbxClass4.Text.Equals("Empath") Or cbxClass4.Text.Equals("Hex Maniac") Then

            lblAdjInt.Text = Int(lblAdjInt.Text) + 1
            previousSelected3 = cbxClass4.Text
        End If

        If cbxClass4.Text.Equals("Breeder") Or cbxClass4.Text.Equals("Botanist") Or cbxClass4.Text.Equals("Chef") Or cbxClass4.Text.Equals("Medic") Or cbxClass4.Text.Equals("Move Tutor") Or
            cbxClass4.Text.Equals("Mystic") Or cbxClass4.Text.Equals("Body Snatcher") Or cbxClass4.Text.Equals("Buffet") Or cbxClass4.Text.Equals("Rune Master") Or cbxClass4.Text.Equals("Shaman") Or
            cbxClass4.Text.Equals("Researcher") Or cbxClass4.Text.Equals("Cryptozoologist") Or cbxClass4.Text.Equals("Dream Doctor") Or cbxClass4.Text.Equals("Photographer") Or cbxClass4.Text.Equals("Watcher") Then

            lblAdjWis.Text = Int(lblAdjWis.Text) + 1
            previousSelected3 = cbxClass4.Text
        End If

        If cbxClass4.Text.Equals("Breeder") Or cbxClass4.Text.Equals("Evolver") Or cbxClass4.Text.Equals("Groomer") Or cbxClass4.Text.Equals("Hatcher") Or cbxClass4.Text.Equals("Coordinator") Or
            cbxClass4.Text.Equals("Cool Trainer") Or cbxClass4.Text.Equals("Cute Idol") Or cbxClass4.Text.Equals("Fashion Designer") Or cbxClass4.Text.Equals("Smart Teacher") Or cbxClass4.Text.Equals("Ranger") Or
            cbxClass4.Text.Equals("Coach") Or cbxClass4.Text.Equals("Commander") Or cbxClass4.Text.Equals("Detective") Then

            lblAdjCha.Text = Int(lblAdjCha.Text) + 1
            previousSelected3 = cbxClass4.Text
        End If

        If cbxClass4.Text.Equals("Researcher") Then
            lblAdjStr.Text = Int(lblAdjStr.Text) - 2

        ElseIf cbxClass4.Text.Equals("Breeder") Or cbxClass4.Text.Equals("Coordinator") Then
            lblAdjDex.Text = Int(lblAdjDex.Text) - 2

        ElseIf cbxClass4.Text.Equals("Capture Specialist") Or cbxClass4.Text.Equals("Ranger") Then
            lblAdjCon.Text = Int(lblAdjCon.Text) - 2

        ElseIf cbxClass4.Text.Equals("Martial Artist") Then
            lblAdjInt.Text = Int(lblAdjInt.Text) - 2

        ElseIf cbxClass4.Text.Equals("Ace Trainer") Then
            lblAdjWis.Text = Int(lblAdjWis.Text) - 2

        ElseIf cbxClass4.Text.Equals("Mystic") Then
            lblAdjCha.Text = Int(lblAdjCha.Text) - 2

        End If
    End Sub

    Private Sub cbxClass3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass3.SelectionChangeCommitted
        If cbxClass1.Text.Equals("Ace Trainer") Then
        ElseIf cbxClass2.Text.Equals("Ace Trainer") Then
        ElseIf cbxClass3.Text.Equals("Ace Trainer") Then
            cbxClass4.Items.Add("Chaser")
            cbxClass4.Items.Add("Enduring Soul")
            cbxClass4.Items.Add("Stat Ace")
            cbxClass4.Items.Add("Strategist")
            cbxClass4.Items.Add("Tag Battler")
            cbxClass4.Items.Add("Type Ace")
            cbxClass4.Items.Add("UnderDog")
        End If

        If cbxClass1.Text.Equals("Breeder") Then
        ElseIf cbxClass2.Text.Equals("Breeder") Then
        ElseIf cbxClass3.Text.Equals("Breeder") Then
            cbxClass4.Items.Add("Botanist")
            cbxClass4.Items.Add("Chef")
            cbxClass4.Items.Add("Evolver")
            cbxClass4.Items.Add("Groomer")
            cbxClass4.Items.Add("Hatcher")
            cbxClass4.Items.Add("Medic")
            cbxClass4.Items.Add("Move Tutor")
        End If

        If cbxClass1.Text.Equals("Capture Specialist") Then
        ElseIf cbxClass2.Text.Equals("Capture Specialist") Then
        ElseIf cbxClass3.Text.Equals("Capture Specialist") Then
            cbxClass4.Items.Add("Artificer")
            cbxClass4.Items.Add("Collector")
            cbxClass4.Items.Add("Engineer")
            cbxClass4.Items.Add("Juggler")
            cbxClass4.Items.Add("Pokeball Designer")
            cbxClass4.Items.Add("Snagger")
            cbxClass4.Items.Add("Trapper")
        End If

        If cbxClass1.Text.Equals("Coordinator") Then
        ElseIf cbxClass2.Text.Equals("Coordinator") Then
        ElseIf cbxClass3.Text.Equals("Coordinator") Then
            cbxClass4.Items.Add("Beauty Modeler")
            cbxClass4.Items.Add("Choreographer")
            cbxClass4.Items.Add("Cool Trainer")
            cbxClass4.Items.Add("Cute Idol")
            cbxClass4.Items.Add("Fashion Designer")
            cbxClass4.Items.Add("Smart Teacher")
            cbxClass4.Items.Add("Tough Guy")
        End If

        If cbxClass1.Text.Equals("Martial Artist") Then
        ElseIf cbxClass2.Text.Equals("Martial Artist") Then
        ElseIf cbxClass3.Text.Equals("Martial Artist") Then
            cbxClass4.Items.Add("Athlete")
            cbxClass4.Items.Add("Aura User")
            cbxClass4.Items.Add("Blackbelt")
            cbxClass4.Items.Add("Dirty Fighter")
            cbxClass4.Items.Add("Massage Therapist")
            cbxClass4.Items.Add("Ninja")
            cbxClass4.Items.Add("Weapons Master")
        End If

        If cbxClass1.Text.Equals("Mystic") Then
        ElseIf cbxClass2.Text.Equals("Mystic") Then
        ElseIf cbxClass3.Text.Equals("Mystic") Then
            cbxClass4.Items.Add("Body Snatcher")
            cbxClass4.Items.Add("Buffet")
            cbxClass4.Items.Add("Godspeaker")
            cbxClass4.Items.Add("Guardian")
            cbxClass4.Items.Add("Rune Master")
            cbxClass4.Items.Add("Shaman")
            cbxClass4.Items.Add("Touched")
        End If

        If cbxClass1.Text.Equals("Psychic") Then
        ElseIf cbxClass2.Text.Equals("Psychic") Then
        ElseIf cbxClass3.Text.Equals("Psychic") Then
            cbxClass4.Items.Add("Air Adept")
            cbxClass4.Items.Add("Clairsentient")
            cbxClass4.Items.Add("Earthshaker")
            cbxClass4.Items.Add("Empath")
            cbxClass4.Items.Add("Fire-breather")
            cbxClass4.Items.Add("Hex Maniac")
            cbxClass4.Items.Add("Rain Walker")
        End If

        If cbxClass1.Text.Equals("Ranger") Then
        ElseIf cbxClass2.Text.Equals("Ranger") Then
        ElseIf cbxClass3.Text.Equals("Ranger") Then
            cbxClass4.Items.Add("Coach")
            cbxClass4.Items.Add("Commander")
            cbxClass4.Items.Add("Detective")
            cbxClass4.Items.Add("Rider")
            cbxClass4.Items.Add("Signer")
            cbxClass4.Items.Add("Special Operations")
            cbxClass4.Items.Add("Survivalist")
        End If

        If cbxClass1.Text.Equals("Researcher") Then
        ElseIf cbxClass2.Text.Equals("Researcher") Then
        ElseIf cbxClass3.Text.Equals("Researcher") Then
            cbxClass4.Items.Add("Cryptozoologist")
            cbxClass4.Items.Add("Dream Doctor")
            cbxClass4.Items.Add("Petrologist")
            cbxClass4.Items.Add("Photographer")
            cbxClass4.Items.Add("Professor")
            cbxClass4.Items.Add("Scientist")
            cbxClass4.Items.Add("Watcher")
        End If

        If previousSelected2 = "Ace Trainer" Then
            lblAdjWis.Text = Int(lblAdjWis) + 2
        End If

        If previousSelected2 = "Breeder" Or previousSelected2 = "Coordinator" Then
            lblAdjDex.Text = Int(lblAdjDex) + 2
        End If

        If previousSelected2 = "Capture Specialist" Or previousSelected2 = "Ranger" Then
            lblAdjCon.Text = Int(lblAdjCon) + 2
        End If

        If previousSelected2 = "Pschic" Or previousSelected2 = "Researcher" Then
            lblAdjStr.Text = Int(lblAdjStr) + 2
        End If

        If previousSelected2 = "Mystic" Then
            lblAdjCha.Text = Int(lblAdjCha) + 2
        End If

        If previousSelected2 = "Martial Artist" Then
            lblAdjInt.Text = Int(lblAdjInt) + 2
        End If

        If previousSelected2 = "Ace Trainer" Or previousSelected2 = "Chaser" Or previousSelected2 = "Stat Ace" Or previousSelected2 = "Martial Artist" Or previousSelected2 = "Athlete" Or
            previousSelected2 = "Aura User" Or previousSelected2 = "Blackbelt" Or previousSelected2 = "Weapons Master" Or previousSelected2 = "Mystic" Or previousSelected2 = "Touched" Or
            previousSelected2 = "Guardian" Or previousSelected2 = "Godspeaker" Or previousSelected2 = "Strategist" Then


            lblAdjStr.Text = Int(lblAdjStr.Text) - 1
        End If

        If previousSelected2 = "Capture Specialist" Or previousSelected2 = "Artificer" Or previousSelected2 = "Collector" Or previousSelected2 = "Juggler" Or previousSelected2 = "Trapper" Or
            previousSelected2 = "Trapper" Or previousSelected2 = "Martial Artist" Or previousSelected2 = "Dirty Fighter" Or previousSelected2 = "Massage Therapist" Or previousSelected2 = "Ninja" Or
            previousSelected2 = "Ranger" Or previousSelected2 = "Rider" Or previousSelected2 = "Special Operations" Or previousSelected2 = "Survivalist" Or previousSelected2 = "Signer" Then

            lblAdjDex.Text = Int(lblAdjDex.Text) - 1
        End If

        If previousSelected2 = "Ace Trainer" Or previousSelected2 = "Enduring Soul" Or previousSelected2 = "Tag Battler" Or previousSelected2 = "Underdog" Or previousSelected2 = "Coordinator" Or
            previousSelected2 = "Choreographer" Or previousSelected2 = "Beauty Modeler" Or previousSelected2 = "Tough Guy" Or previousSelected2 = "Psychic" Or previousSelected2 = "Air Adept" Or
            previousSelected2 = "Earthshaker" Or previousSelected2 = "Rain Walker" Or previousSelected2 = "Type Ace" Or previousSelected2 = "Fire-breather" Then

            lblAdjCon.Text = Int(lblAdjCon.Text) - 1

        End If

        If previousSelected2 = "Capture Specialist" Or previousSelected2 = "Engineer" Or previousSelected2 = "Pokeball Designer" Or previousSelected2 = "Snagger" Or previousSelected2 = "Psychic" Or
            previousSelected2 = "Clairsentient" Or previousSelected2 = "Empath" Or previousSelected2 = "Hex Maniac" Or previousSelected2 = "Researcher" Or previousSelected2 = "Professor" Or
            previousSelected2 = "Scientist" Or previousSelected2 = "Petrologist" Then

            lblAdjInt.Text = Int(lblAdjInt.Text) - 1
        End If

        If previousSelected2 = "Breeder" Or previousSelected2 = "Botanist" Or previousSelected2 = "Chef" Or previousSelected2 = "Medic" Or previousSelected2 = "Move Tutor" Or previousSelected2 = "Mystic" Or
                previousSelected2 = "Body Snatcher" Or previousSelected2 = "Buffet" Or previousSelected2 = "Rune Master" Or previousSelected2 = "Shaman" Or previousSelected2 = "Researcher" Or
                previousSelected2 = "Cryptozoologist" Or previousSelected2 = "Dream Doctor" Or previousSelected2 = "Photographer" Or previousSelected2 = "Watcher" Then

            lblAdjWis.Text = Int(lblAdjWis.Text) - 1

        End If

        If previousSelected2 = "Breeder" Or previousSelected2 = "Evolver" Or previousSelected2 = "Groomer" Or previousSelected2 = "Hatcher" Or previousSelected2 = "Coordinator" Or previousSelected2 = "Cool Trainer" Or
            previousSelected2 = "Cute Idol" Or previousSelected2 = "Fashion Designer" Or previousSelected2 = "Smart Teacher" Or previousSelected2 = "Ranger" Or previousSelected2 = "Coach" Or
            previousSelected2 = "Commander" Or previousSelected2 = "Detective" Then

            lblAdjCha.Text = Int(lblAdjCha.Text) - 1

        End If

        If cbxClass3.Text.Equals("Ace Trainer") Or cbxClass3.Text.Equals("Chaser") Or cbxClass3.Text.Equals("Stat Ace") Or cbxClass3.Text.Equals("Martial Artist") Or cbxClass3.Text.Equals("Athlete") Or
            cbxClass3.Text.Equals("Aura User") Or cbxClass3.Text.Equals("Blackbelt") Or cbxClass3.Text.Equals("Weapons Master") Or cbxClass3.Text.Equals("Mystic") Or cbxClass3.Text.Equals("Touched") Or
            cbxClass3.Text.Equals("Guardian") Or cbxClass3.Text.Equals("Godspeaker") Or cbxClass3.Text.Equals("Strategist") Then

            lblAdjStr.Text = Int(lblAdjStr.Text) + 1
            previousSelected2 = cbxClass3.Text
        End If

        If cbxClass3.Text.Equals("Capture Specialist") Or cbxClass3.Text.Equals("Artificer") Or cbxClass3.Text.Equals("Collector") Or cbxClass3.Text.Equals("Juggler") Or cbxClass3.Text.Equals("Trapper") Or
        cbxClass3.Text.Equals("Martial Artist") Or cbxClass3.Text.Equals("Dirty Fighter") Or cbxClass3.Text.Equals("Massage Therapist") Or cbxClass3.Text.Equals("Ninja") Or cbxClass3.Text.Equals("Ranger") Or
        cbxClass3.Text.Equals("Rider") Or cbxClass3.Text.Equals("Special Operations") Or cbxClass3.Text.Equals("Survivalist") Or cbxClass3.Text.Equals("Signer") Then

            lblAdjDex.Text = Int(lblAdjDex.Text) + 1
            previousSelected2 = cbxClass3.Text

        End If

        If cbxClass3.Text.Equals("Ace Trainer") Or cbxClass3.Text.Equals("Enduring Soul") Or cbxClass3.Text.Equals("Tag Battler") Or cbxClass3.Text.Equals("Underdog") Or cbxClass3.Text.Equals("Coordinator") Or
        cbxClass3.Text.Equals("Choreographer") Or cbxClass3.Text.Equals("Beauty Modeler") Or cbxClass3.Text.Equals("Tough Guy") Or cbxClass3.Text.Equals("Psychic") Or cbxClass3.Text.Equals("Air Adept") Or
        cbxClass3.Text.Equals("Earthshaker") Or cbxClass3.Text.Equals("Rain Walker") Or cbxClass3.Text.Equals("Type Ace") Or cbxClass3.Text.Equals("Fire-breather") Then

            lblAdjCon.Text = Int(lblAdjCon.Text) + 1
            previousSelected2 = cbxClass3.Text
        End If
        If cbxClass3.Text.Equals("Capture Specialist") Or cbxClass3.Text.Equals("Engineer") Or cbxClass3.Text.Equals("Pokeball Designer") Or cbxClass3.Text.Equals("Snagger") Or cbxClass3.Text.Equals("Researcher") Or
        cbxClass3.Text.Equals("Professor") Or cbxClass3.Text.Equals("Scientist") Or cbxClass3.Text.Equals("Petrologist") Or cbxClass3.Text.Equals("Psychic") Or cbxClass3.Text.Equals("Clairsentient") Or
        cbxClass3.Text.Equals("Empath") Or cbxClass3.Text.Equals("Hex Maniac") Then

            lblAdjInt.Text = Int(lblAdjInt.Text) + 1
            previousSelected2 = cbxClass3.Text
        End If

        If cbxClass3.Text.Equals("Breeder") Or cbxClass3.Text.Equals("Botanist") Or cbxClass3.Text.Equals("Chef") Or cbxClass3.Text.Equals("Medic") Or cbxClass3.Text.Equals("Move Tutor") Or
                    cbxClass3.Text.Equals("Mystic") Or cbxClass3.Text.Equals("Body Snatcher") Or cbxClass3.Text.Equals("Buffet") Or cbxClass3.Text.Equals("Rune Master") Or cbxClass3.Text.Equals("Shaman") Or
                    cbxClass3.Text.Equals("Researcher") Or cbxClass3.Text.Equals("Cryptozoologist") Or cbxClass3.Text.Equals("Dream Doctor") Or cbxClass3.Text.Equals("Photographer") Or cbxClass3.Text.Equals("Watcher") Then

            lblAdjWis.Text = Int(lblAdjWis.Text) + 1
            previousSelected2 = cbxClass3.Text
        End If

        If cbxClass3.Text.Equals("Breeder") Or cbxClass3.Text.Equals("Evolver") Or cbxClass3.Text.Equals("Groomer") Or cbxClass3.Text.Equals("Hatcher") Or cbxClass3.Text.Equals("Coordinator") Or
                   cbxClass3.Text.Equals("Cool Trainer") Or cbxClass3.Text.Equals("Cute Idol") Or cbxClass3.Text.Equals("Fashion Designer") Or cbxClass3.Text.Equals("Smart Teacher") Or cbxClass3.Text.Equals("Ranger") Or
                   cbxClass3.Text.Equals("Coach") Or cbxClass3.Text.Equals("Commander") Or cbxClass3.Text.Equals("Detective") Then

            lblAdjCha.Text = Int(lblAdjCha.Text) + 1
            previousSelected2 = cbxClass3.Text
        End If

        If cbxClass3.Text.Equals("Researcher") Then
            lblAdjStr.Text = Int(lblAdjStr.Text) - 2

        ElseIf cbxClass3.Text.Equals("Breeder") Or cbxClass3.Text.Equals("Coordinator") Then
            lblAdjDex.Text = Int(lblAdjDex.Text) - 2

        ElseIf cbxClass3.Text.Equals("Capture Specialist") Or cbxClass3.Text.Equals("Ranger") Then
            lblAdjCon.Text = Int(lblAdjCon.Text) - 2

        ElseIf cbxClass3.Text.Equals("Martial Artist") Then
            lblAdjInt.Text = Int(lblAdjInt.Text) - 2

        ElseIf cbxClass3.Text.Equals("Ace Trainer") Then
            lblAdjWis.Text = Int(lblAdjWis.Text) - 2

        ElseIf cbxClass3.Text.Equals("Mystic") Then
            lblAdjCha.Text = Int(lblAdjCha.Text) - 2

        End If

    End Sub

    Private Sub cbxClass2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxClass2.SelectionChangeCommitted
        If cbxClass1.Text.Equals("Ace Trainer") Then
        ElseIf cbxClass2.Text.Equals("Ace Trainer") Then
            cbxClass3.Items.Add("Chaser")
            cbxClass3.Items.Add("Enduring Soul")
            cbxClass3.Items.Add("Stat Ace")
            cbxClass3.Items.Add("Strategist")
            cbxClass3.Items.Add("Tag Battler")
            cbxClass3.Items.Add("Type Ace")
            cbxClass3.Items.Add("UnderDog")
            cbxClass4.Items.Add("Chaser")
            cbxClass4.Items.Add("Enduring Soul")
            cbxClass4.Items.Add("Stat Ace")
            cbxClass4.Items.Add("Strategist")
            cbxClass4.Items.Add("Tag Battler")
            cbxClass4.Items.Add("Type Ace")
            cbxClass4.Items.Add("UnderDog")

        End If

        If cbxClass1.Text.Equals("Breeder") Then
        ElseIf cbxClass2.Text.Equals("Breeder") Then
            cbxClass3.Items.Add("Botanist")
            cbxClass3.Items.Add("Chef")
            cbxClass3.Items.Add("Evolver")
            cbxClass3.Items.Add("Groomer")
            cbxClass3.Items.Add("Hatcher")
            cbxClass3.Items.Add("Medic")
            cbxClass3.Items.Add("Move Tutor")
            cbxClass4.Items.Add("Botanist")
            cbxClass4.Items.Add("Chef")
            cbxClass4.Items.Add("Evolver")
            cbxClass4.Items.Add("Groomer")
            cbxClass4.Items.Add("Hatcher")
            cbxClass4.Items.Add("Medic")
            cbxClass4.Items.Add("Move Tutor")
        End If

        If cbxClass1.Text.Equals("Capture Specialist") Then
        ElseIf cbxClass2.Text.Equals("Capture Specialist") Then
            cbxClass3.Items.Add("Artificer")
            cbxClass3.Items.Add("Collector")
            cbxClass3.Items.Add("Engineer")
            cbxClass3.Items.Add("Juggler")
            cbxClass3.Items.Add("Pokeball Designer")
            cbxClass3.Items.Add("Snagger")
            cbxClass3.Items.Add("Trapper")
            cbxClass4.Items.Add("Artificer")
            cbxClass4.Items.Add("Collector")
            cbxClass4.Items.Add("Engineer")
            cbxClass4.Items.Add("Juggler")
            cbxClass4.Items.Add("Pokeball Designer")
            cbxClass4.Items.Add("Snagger")
            cbxClass4.Items.Add("Trapper")
        End If

        If cbxClass1.Text.Equals("Coordinator") Then
        ElseIf cbxClass2.Text.Equals("Coordinator") Then
            cbxClass3.Items.Add("Beauty Modeler")
            cbxClass3.Items.Add("Choreographer")
            cbxClass3.Items.Add("Cool Trainer")
            cbxClass3.Items.Add("Cute Idol")
            cbxClass3.Items.Add("Fashion Designer")
            cbxClass3.Items.Add("Smart Teacher")
            cbxClass3.Items.Add("Tough Guy")
            cbxClass4.Items.Add("Beauty Modeler")
            cbxClass4.Items.Add("Choreographer")
            cbxClass4.Items.Add("Cool Trainer")
            cbxClass4.Items.Add("Cute Idol")
            cbxClass4.Items.Add("Fashion Designer")
            cbxClass4.Items.Add("Smart Teacher")
            cbxClass4.Items.Add("Tough Guy")
        End If

        If cbxClass1.Text.Equals("Martial Artist") Then
        ElseIf cbxClass2.Text.Equals("Martial Artist") Then
            cbxClass3.Items.Add("Athlete")
            cbxClass3.Items.Add("Aura User")
            cbxClass3.Items.Add("Blackbelt")
            cbxClass3.Items.Add("Dirty Fighter")
            cbxClass3.Items.Add("Massage Therapist")
            cbxClass3.Items.Add("Ninja")
            cbxClass3.Items.Add("Weapons Master")
            cbxClass4.Items.Add("Athlete")
            cbxClass4.Items.Add("Aura User")
            cbxClass4.Items.Add("Blackbelt")
            cbxClass4.Items.Add("Dirty Fighter")
            cbxClass4.Items.Add("Massage Therapist")
            cbxClass4.Items.Add("Ninja")
            cbxClass4.Items.Add("Weapons Master")
        End If

        If cbxClass1.Text.Equals("Mystic") Then
        ElseIf cbxClass2.Text.Equals("Mystic") Then
            cbxClass3.Items.Add("Body Snatcher")
            cbxClass3.Items.Add("Buffet")
            cbxClass3.Items.Add("Godspeaker")
            cbxClass3.Items.Add("Guardian")
            cbxClass3.Items.Add("Rune Master")
            cbxClass3.Items.Add("Shaman")
            cbxClass3.Items.Add("Touched")
            cbxClass4.Items.Add("Body Snatcher")
            cbxClass4.Items.Add("Buffet")
            cbxClass4.Items.Add("Godspeaker")
            cbxClass4.Items.Add("Guardian")
            cbxClass4.Items.Add("Rune Master")
            cbxClass4.Items.Add("Shaman")
            cbxClass4.Items.Add("Touched")
        End If

        If cbxClass1.Text.Equals("Psychic") Then
        ElseIf cbxClass2.Text.Equals("Psychic") Then
            cbxClass3.Items.Add("Air Adept")
            cbxClass3.Items.Add("Clairsentient")
            cbxClass3.Items.Add("Earthshaker")
            cbxClass3.Items.Add("Empath")
            cbxClass3.Items.Add("Fire-breather")
            cbxClass3.Items.Add("Hex Maniac")
            cbxClass3.Items.Add("Rain Walker")
            cbxClass4.Items.Add("Air Adept")
            cbxClass4.Items.Add("Clairsentient")
            cbxClass4.Items.Add("Earthshaker")
            cbxClass4.Items.Add("Empath")
            cbxClass4.Items.Add("Fire-breather")
            cbxClass4.Items.Add("Hex Maniac")
            cbxClass4.Items.Add("Rain Walker")
        End If

        If cbxClass1.Text.Equals("Ranger") Then
        ElseIf cbxClass2.Text.Equals("Ranger") Then
            cbxClass3.Items.Add("Coach")
            cbxClass3.Items.Add("Commander")
            cbxClass3.Items.Add("Detective")
            cbxClass3.Items.Add("Rider")
            cbxClass3.Items.Add("Signer")
            cbxClass3.Items.Add("Special Operations")
            cbxClass3.Items.Add("Survivalist")
            cbxClass4.Items.Add("Coach")
            cbxClass4.Items.Add("Commander")
            cbxClass4.Items.Add("Detective")
            cbxClass4.Items.Add("Rider")
            cbxClass4.Items.Add("Signer")
            cbxClass4.Items.Add("Special Operations")
            cbxClass4.Items.Add("Survivalist")
        End If

        If cbxClass1.Text.Equals("Researcher") Then
        ElseIf cbxClass2.Text.Equals("Researcher") Then
            cbxClass3.Items.Add("Cryptozoologist")
            cbxClass3.Items.Add("Dream Doctor")
            cbxClass3.Items.Add("Petrologist")
            cbxClass3.Items.Add("Photographer")
            cbxClass3.Items.Add("Professor")
            cbxClass3.Items.Add("Scientist")
            cbxClass3.Items.Add("Watcher")
            cbxClass4.Items.Add("Cryptozoologist")
            cbxClass4.Items.Add("Dream Doctor")
            cbxClass4.Items.Add("Petrologist")
            cbxClass4.Items.Add("Photographer")
            cbxClass4.Items.Add("Professor")
            cbxClass4.Items.Add("Scientist")
            cbxClass4.Items.Add("Watcher")
        End If

        If previousSelected = "Ace Trainer" Or previousSelected = "Chaser" Or previousSelected = "Stat Ace" Or previousSelected = "Martial Artist" Or previousSelected = "Athlete" Or
            previousSelected = "Aura User" Or previousSelected = "Blackbelt" Or previousSelected = "Weapons Master" Or previousSelected = "Mystic" Or previousSelected = "Touched" Or
            previousSelected = "Guardian" Or previousSelected = "Godspeaker" Or previousSelected = "Strategist" Then

            lblAdjStr.Text = Int(lblAdjStr.Text) - 1
        End If

        If previousSelected = "Capture Specialist" Or previousSelected = "Artificer" Or previousSelected = "Collector" Or previousSelected = "Juggler" Or previousSelected = "Trapper" Or
            previousSelected = "Trapper" Or previousSelected = "Martial Artist" Or previousSelected = "Dirty Fighter" Or previousSelected = "Massage Therapist" Or previousSelected = "Ninja" Or
            previousSelected = "Ranger" Or previousSelected = "Rider" Or previousSelected = "Special Operations" Or previousSelected = "Survivalist" Or previousSelected = "Signer" Then

            lblAdjDex.Text = Int(lblAdjDex.Text) - 1
        End If

        If previousSelected = "Ace Trainer" Or previousSelected = "Enduring Soul" Or previousSelected = "Tag Battler" Or previousSelected = "Underdog" Or previousSelected = "Coordinator" Or
            previousSelected = "Choreographer" Or previousSelected = "Beauty Modeler" Or previousSelected = "Tough Guy" Or previousSelected = "Psychic" Or previousSelected = "Air Adept" Or
            previousSelected = "Earthshaker" Or previousSelected = "Rain Walker" Or previousSelected = "Type Ace" Or previousSelected = "Fire-breather" Then

            lblAdjCon.Text = Int(lblAdjCon.Text) - 1

        End If

        If previousSelected = "Capture Specialist" Or previousSelected = "Engineer" Or previousSelected = "Pokeball Designer" Or previousSelected = "Snagger" Or previousSelected = "Psychic" Or
            previousSelected = "Clairsentient" Or previousSelected = "Empath" Or previousSelected = "Hex Maniac" Or previousSelected = "Researcher" Or previousSelected = "Professor" Or
            previousSelected = "Scientist" Or previousSelected = "Petrologist" Then

            lblAdjInt.Text = Int(lblAdjInt.Text) - 1
        End If

        If previousSelected = "Breeder" Or previousSelected = "Botanist" Or previousSelected = "Chef" Or previousSelected = "Medic" Or previousSelected = "Move Tutor" Or previousSelected = "Mystic" Or
                previousSelected = "Body Snatcher" Or previousSelected = "Buffet" Or previousSelected = "Rune Master" Or previousSelected = "Shaman" Or previousSelected = "Researcher" Or
                previousSelected = "Cryptozoologist" Or previousSelected = "Dream Doctor" Or previousSelected = "Photographer" Or previousSelected = "Watcher" Then

            lblAdjWis.Text = Int(lblAdjWis.Text) - 1

        End If

        If previousSelected = "Breeder" Or previousSelected = "Evolver" Or previousSelected = "Groomer" Or previousSelected = "Hatcher" Or previousSelected = "Coordinator" Or previousSelected = "Cool Trainer" Or
            previousSelected = "Cute Idol" Or previousSelected = "Fashion Designer" Or previousSelected = "Smart Teacher" Or previousSelected = "Ranger" Or previousSelected = "Coach" Or
            previousSelected = "Commander" Or previousSelected = "Detective" Then

            lblAdjCha.Text = Int(lblAdjCha.Text) - 1


        End If

        If previousSelected = "Ace Trainer" Then
            lblAdjWis.Text = Int(lblAdjWis) + 2
        End If

        If previousSelected = "Breeder" Or previousSelected = "Coordinator" Then
            lblAdjDex.Text = Int(lblAdjDex) + 2
        End If

        If previousSelected = "Capture Specialist" Or previousSelected = "Ranger" Then
            lblAdjCon.Text = Int(lblAdjCon) + 2
        End If

        If previousSelected = "Pschic" Or previousSelected = "Researcher" Then
            lblAdjStr.Text = Int(lblAdjStr) + 2
        End If

        If previousSelected = "Mystic" Then
            lblAdjCha.Text = Int(lblAdjCha) + 2
        End If

        If previousSelected = "Martial Artist" Then
            lblAdjInt.Text = Int(lblAdjInt) + 2
        End If

        If cbxClass2.Text.Equals("Ace Trainer") Or cbxClass2.Text.Equals("Chaser") Or cbxClass2.Text.Equals("Stat Ace") Or cbxClass2.Text.Equals("Martial Artist") Or cbxClass2.Text.Equals("Athlete") Or
        cbxClass2.Text.Equals("Aura User") Or cbxClass2.Text.Equals("Blackbelt") Or cbxClass2.Text.Equals("Weapons Master") Or cbxClass2.Text.Equals("Mystic") Or cbxClass2.Text.Equals("Touched") Or
        cbxClass2.Text.Equals("Guardian") Or cbxClass2.Text.Equals("Godspeaker") Or cbxClass2.Text.Equals("Strategist") Then

            lblAdjStr.Text = Int(lblAdjStr.Text) + 1
            previousSelected = cbxClass2.Text
        End If

        If cbxClass2.Text.Equals("Capture Specialist") Or cbxClass2.Text.Equals("Artificer") Or cbxClass2.Text.Equals("Collector") Or cbxClass2.Text.Equals("Juggler") Or cbxClass2.Text.Equals("Trapper") Or
                   cbxClass2.Text.Equals("Martial Artist") Or cbxClass2.Text.Equals("Dirty Fighter") Or cbxClass2.Text.Equals("Massage Therapist") Or cbxClass2.Text.Equals("Ninja") Or cbxClass2.Text.Equals("Ranger") Or
                   cbxClass2.Text.Equals("Rider") Or cbxClass2.Text.Equals("Special Operations") Or cbxClass2.Text.Equals("Survivalist") Or cbxClass2.Text.Equals("Signer") Then

            lblAdjDex.Text = Int(lblAdjDex.Text) + 1
            previousSelected = cbxClass2.Text
        End If

        If cbxClass2.Text.Equals("Ace Trainer") Or cbxClass2.Text.Equals("Enduring Soul") Or cbxClass2.Text.Equals("Tag Battler") Or cbxClass2.Text.Equals("Underdog") Or cbxClass2.Text.Equals("Coordinator") Or
        cbxClass2.Text.Equals("Choreographer") Or cbxClass2.Text.Equals("Beauty Modeler") Or cbxClass2.Text.Equals("Tough Guy") Or cbxClass2.Text.Equals("Psychic") Or cbxClass2.Text.Equals("Air Adept") Or
        cbxClass2.Text.Equals("Earthshaker") Or cbxClass2.Text.Equals("Rain Walker") Or cbxClass2.Text.Equals("Type Ace") Or cbxClass2.Text.Equals("Fire-breather") Then

            lblAdjCon.Text = Int(lblAdjCon.Text) + 1
            previousSelected = cbxClass2.Text
        End If

        If cbxClass2.Text.Equals("Capture Specialist") Or cbxClass2.Text.Equals("Engineer") Or cbxClass2.Text.Equals("Pokeball Designer") Or cbxClass2.Text.Equals("Snagger") Or cbxClass2.Text.Equals("Researcher") Or
                    cbxClass2.Text.Equals("Professor") Or cbxClass2.Text.Equals("Scientist") Or cbxClass2.Text.Equals("Petrologist") Or cbxClass2.Text.Equals("Psychic") Or cbxClass2.Text.Equals("Clairsentient") Or
                    cbxClass2.Text.Equals("Empath") Or cbxClass2.Text.Equals("Hex Maniac") Then

            lblAdjInt.Text = Int(lblAdjInt.Text) + 1
            previousSelected = cbxClass2.Text
        End If
        If cbxClass2.Text.Equals("Breeder") Or cbxClass2.Text.Equals("Botanist") Or cbxClass2.Text.Equals("Chef") Or cbxClass2.Text.Equals("Medic") Or cbxClass2.Text.Equals("Move Tutor") Or
       cbxClass2.Text.Equals("Mystic") Or cbxClass2.Text.Equals("Body Snatcher") Or cbxClass2.Text.Equals("Buffet") Or cbxClass2.Text.Equals("Rune Master") Or cbxClass2.Text.Equals("Shaman") Or
       cbxClass2.Text.Equals("Researcher") Or cbxClass2.Text.Equals("Cryptozoologist") Or cbxClass2.Text.Equals("Dream Doctor") Or cbxClass2.Text.Equals("Photographer") Or cbxClass2.Text.Equals("Watcher") Then

            lblAdjWis.Text = Int(lblAdjWis.Text) + 1
            previousSelected = cbxClass2.Text
        End If

        If cbxClass2.Text.Equals("Breeder") Or cbxClass2.Text.Equals("Botanist") Or cbxClass2.Text.Equals("Chef") Or cbxClass2.Text.Equals("Medic") Or cbxClass2.Text.Equals("Move Tutor") Or
        cbxClass2.Text.Equals("Mystic") Or cbxClass2.Text.Equals("Body Snatcher") Or cbxClass2.Text.Equals("Buffet") Or cbxClass2.Text.Equals("Rune Master") Or cbxClass2.Text.Equals("Shaman") Or
        cbxClass2.Text.Equals("Researcher") Or cbxClass2.Text.Equals("Cryptozoologist") Or cbxClass2.Text.Equals("Dream Doctor") Or cbxClass2.Text.Equals("Photographer") Or cbxClass2.Text.Equals("Watcher") Then

            lblAdjCha.Text = Int(lblAdjCha.Text) + 1
            previousSelected = cbxClass2.Text
        End If

        If cbxClass2.Text.Equals("Researcher") Then
            lblAdjStr.Text = Int(lblAdjStr.Text) - 2

        ElseIf cbxClass2.Text.Equals("Breeder") Or cbxClass2.Text.Equals("Coordinator") Then
            lblAdjDex.Text = Int(lblAdjDex.Text) - 2

        ElseIf cbxClass2.Text.Equals("Capture Specialist") Or cbxClass2.Text.Equals("Ranger") Then
            lblAdjCon.Text = Int(lblAdjCon.Text) - 2

        ElseIf cbxClass2.Text.Equals("Martial Artist") Then
            lblAdjInt.Text = Int(lblAdjInt.Text) - 2

        ElseIf cbxClass2.Text.Equals("Ace Trainer") Then
            lblAdjWis.Text = Int(lblAdjWis.Text) - 2

        ElseIf cbxClass2.Text.Equals("Mystic") Then
            lblAdjCha.Text = Int(lblAdjCha.Text) - 2

        End If

    End Sub

    Private Sub lblAdjStr_TextChanged(sender As Object, e As EventArgs) Handles lblAdjStr.TextChanged
        lblAdjStr.Text = lblAdjStr.Text



        tempPoint = GetMod(Int(lblAdjStr.Text))
        lblModStr.Text = tempPoint
        ' lblPointsLeft.Text = "Points Left: " + (GetStatPoints(Int(lblLevel.Text)) - Int(lblAdjCha.Text) - Int(lblAdjStr.Text) - Int(lblAdjDex.Text) - Int(lblAdjInt.Text) - Int(lblAdjWis.Text) - Int(lblAdjCon.Text))

    End Sub

    Private Function GetStatPoints(v As Integer) As Integer

        If v <= 15 Then
            Return 63 + v
        End If
        Return 63 + ((v - 15) / 2) + 16
    End Function

    Private Function GetMod(v As Integer) As Integer

        If v > 10 Then
            Return (v - 10) / 2


        End If
        Return v - 10
    End Function

    Private Sub lblAdjDex_TextChanged(sender As Object, e As EventArgs) Handles lblAdjDex.TextChanged
        lblAdjDex.Text = lblAdjDex.Text



        tempPoint = GetMod(Int(lblAdjDex.Text))
        lblModDex.Text = tempPoint
        ' lblPointsLeft.Text = "Points Left: " + (GetStatPoints(Int(lblLevel.Text)) - Int(lblAdjCha.Text) - Int(lblAdjStr.Text) - Int(lblAdjDex.Text) - Int(lblAdjInt.Text) - Int(lblAdjWis.Text) - Int(lblAdjCon.Text))

    End Sub

    Private Sub lblAdjCon_TextChanged(sender As Object, e As EventArgs) Handles lblAdjCon.TextChanged
        lblAdjCon.Text = lblAdjCon.Text



        tempPoint = GetMod(Int(lblAdjCon.Text))
        lblModCon.Text = tempPoint
        'lblPointsLeft.Text = "Points Left: " + (GetStatPoints(Int(lblLevel.Text)) - Int(lblAdjCha.Text) - Int(lblAdjStr.Text) - Int(lblAdjDex.Text) - Int(lblAdjInt.Text) - Int(lblAdjWis.Text) - Int(lblAdjCon.Text))

    End Sub


    Private Sub lblAdjInt_TextChanged(sender As Object, e As EventArgs) Handles lblAdjInt.TextChanged
        lblAdjInt.Text = lblAdjInt.Text




        tempPoint = GetMod(Int(lblAdjStr.Text))
        lblModStr.Text = tempPoint
        ' lblPointsLeft.Text = "Points Left: " + (GetStatPoints(Int(lblLevel.Text)) - Int(lblAdjCha.Text) - Int(lblAdjStr.Text) - Int(lblAdjDex.Text) - Int(lblAdjInt.Text) - Int(lblAdjWis.Text) - Int(lblAdjCon.Text))

    End Sub

    Private Sub lblAdjWis_TextChanged(sender As Object, e As EventArgs) Handles lblAdjWis.TextChanged
        lblAdjWis.Text = lblAdjWis.Text



        tempPoint = GetMod(Int(lblAdjWis.Text))
        lblModWis.Text = tempPoint
        ' lblPointsLeft.Text = "Points Left: " + (GetStatPoints(Int(lblLevel.Text)) - Int(lblAdjCha.Text) - Int(lblAdjStr.Text) - Int(lblAdjDex.Text) - Int(lblAdjInt.Text) - Int(lblAdjWis.Text) - Int(lblAdjCon.Text))

    End Sub

    Private Sub lblAdjCha_TextChanged(sender As Object, e As EventArgs) Handles lblAdjCha.TextChanged
        lblAdjCha.Text = lblAdjCha.Text


        tempPoint = GetMod(Int(lblAdjCha.Text))
        lblModCha.Text = tempPoint
        ' lblPointsLeft.Text = "Points Left: " + (GetStatPoints(Int(lblLevel.Text)) - Int(lblAdjCha.Text) - Int(lblAdjStr.Text) - Int(lblAdjDex.Text) - Int(lblAdjInt.Text) - Int(lblAdjWis.Text) - Int(lblAdjCon.Text))

    End Sub


End Class
