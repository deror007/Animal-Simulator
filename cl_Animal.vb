Public Class cl_Animal
    Public AnimalName As String
    Public FoodType As Integer '[1] = herbivore, [2] = omnivore, [3] = carnivore
    'Public Topology As Integer
    Public LifeSpan As Integer
    Public DeathRate As Double
    Public Birth_Rate As Double
    Public HungerMeter As Integer
    Public AnimalSpeed As Integer
    Public FoodChainRank As Integer
    Const AnimalSize As Integer = 10
    Public isDead As Boolean

    Public age As Integer
    Public hungerlevel As Integer


    'NOW TO ONLY ALLOW BIRTHS BETWEEN MODERATELY OLD MATE AND SAME SPECIE 14/1/2020

   
    Function getAnimalSize() As Integer
        Return AnimalSize
    End Function

    Function GetMove() As String
        Dim x As Integer

        Randomize()

        x = Int((9 * Rnd()) + 1)

        Select Case x
            Case 1
                Return "N"
            Case 2
                Return "NE"
            Case 3
                Return "E"
            Case 4
                Return "SE"
            Case 5
                Return "S"
            Case 6
                Return "SW"
            Case 7
                Return "W"
            Case 8
                Return "NW"
            Case Else
                Return "No movement"
        End Select
    End Function

    Overridable Function GiveBirth() As cl_Animal


        Return Nothing
    End Function


    Overridable Function GiveDeath() As Boolean





        Return Nothing
    End Function

    Overridable Function GetFood() As Boolean


        Randomize()

        Return Nothing
    End Function

    Overridable Function GetFood(ByVal food As cl_Animal) As Boolean


        Randomize()

        Return Nothing
    End Function

    Public Overridable Sub DayStatus()


        age = age - 1 'formulae for life (2/2)
        If age = 0 Then
            isDead = True
        End If

        hungerlevel = hungerlevel - 1 'formulae for hunger (2/2)
        If hungerlevel = 0 Then
            isDead = True
        ElseIf cl_GlobalSetting.Board.EatenFood = True Then
            hungerlevel = HungerMeter
            hungerlevel = hungerlevel + 30

        End If

    End Sub




End Class
