Public Class cl_Omnivore
    Inherits cl_Animal
 

    Sub New(ByVal animalN As String, ByVal animalLS As Integer, ByVal animalDR As Double, ByVal animalBR As Double, ByVal animalHM As Integer, ByVal animalAS As Integer, ByVal animalFCR As Integer) 'Runs first
        FoodType = 2

        AnimalName = animalN

        LifeSpan = animalLS
        DeathRate = animalDR
        Birth_Rate = animalBR
        HungerMeter = animalHM
        AnimalSpeed = animalAS
        FoodChainRank = animalFCR

        age = LifeSpan * 75
        hungerlevel = HungerMeter * 25
      
    End Sub

    Overrides Function GetFood() As Boolean

        Randomize()

        Return Nothing
    End Function

    Public Overrides Function GiveBirth() As cl_Animal
        'Dim baby As New cl_Carnivore
        Dim birthChance As Decimal
        Dim Baby

        Randomize()

        birthChance = Rnd() 'Within 0-1
        ' MsgBox(birthChance)

        If birthChance <= Birth_Rate Then
            '  MsgBox("Got Baby- " & Me.AnimalName & " " & birthChance)
            Baby = New cl_Omnivore(Me.AnimalName, Me.LifeSpan, Me.DeathRate, Me.Birth_Rate, Me.HungerMeter, Me.AnimalSpeed, Me.FoodChainRank)




            Return Baby
        Else
            Return Nothing

        End If


    End Function

   

End Class
