Public Class cl_Carnivore
    Inherits cl_Animal



    Sub New(ByVal animalN As String, ByVal animalLS As Integer, ByVal animalDR As Double, ByVal animalBR As Double, ByVal animalHM As Integer, ByVal animalAS As Integer, ByVal animalFCR As Integer)
        FoodType = 3
        Birth_Rate = animalBR
        AnimalName = animalN
        LifeSpan = animalLS
        DeathRate = animalDR
        HungerMeter = animalHM
        AnimalSpeed = animalAS
        FoodChainRank = animalFCR

        age = LifeSpan * 50 'Start off at highest possible life number then decreases
        hungerlevel = HungerMeter * 25

    End Sub

    Public Overrides Function GiveBirth() As cl_Animal
        'Dim baby As New cl_Carnivore
        Dim birthChance As Decimal
        Dim Baby

        Randomize()

        birthChance = Rnd() 'Within 0-1
        'MsgBox(birthChance)

        If birthChance <= Birth_Rate Then
            '   MsgBox("Got Baby- " & Me.AnimalName & " " & birthChance)
            Baby = New cl_Carnivore(Me.AnimalName, Me.LifeSpan, Me.DeathRate, Me.Birth_Rate, Me.HungerMeter, Me.AnimalSpeed, Me.FoodChainRank)




            Return Baby
        Else
            Return Nothing

        End If


    End Function

    Overrides Function GetFood(ByVal food As cl_Animal) As Boolean
        Dim FoodChance As Decimal

        Randomize()

        FoodChance = Rnd()

        If FoodChance <= DeathRate And food.FoodChainRank < Me.FoodChainRank Then


        End If


        Randomize()

        Return Nothing
    End Function

  



End Class
