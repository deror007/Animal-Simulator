Public Class cl_Board

    Const BOARDSIZEX As Integer = 500
    Const BOARDSIZEY As Integer = 500
    Public BoardType As String
    Public Board(,) As cl_Animal
    Public animalList As New cl_LinkedList
    Public EatenFood As Boolean



    Sub New(ByVal type As String) '

        BoardType = type
        ReDim Board(BOARDSIZEX / 10, BOARDSIZEY / 10) 'board size 50X50


    End Sub

    Function returnBOARDSIZEX() As Integer
        Return BOARDSIZEX
    End Function

    Function returnBOARDSIZEY() As Integer
        Return BOARDSIZEY
    End Function
    Sub RunDay()
        Dim direction As String
        Dim AnimalName As String


        cl_GlobalSetting.log.write("population: " & animalList.populationNum)

        If animalList.populationNum > 0 Then

            animalList.reset()

            Do
                If IsNothing(animalList.current) <> True Then

                    direction = animalList.current.piece.GetMove()

                    If direction <> "No movement" Then 'Stops animal giving birth by itself if they contact themselves by not moving.



                        'MsgBox(direction)
                        ' MsgBox(animalList.current.X)
                        'MsgBox(animalList.current.Y)
                        Dim temp() As Integer
                        'Dim newBornTemp() As Integer
                        Dim x, y As Integer
                        temp = returnCor(direction, animalList.current.X, animalList.current.Y)
                        'newBornTemp = returnCor(direction, animalList.current.X, animalList.current.Y) 'Idea of finding newborn space

                        Board(animalList.current.X, animalList.current.Y).DayStatus()

                        If Board(animalList.current.X, animalList.current.Y).isDead = True Then 'dies from hunger or by age

                            cl_GlobalSetting.log.write(" name: " & animalList.current.piece.AnimalName & " by hunger or age.")

                            AnimalName = animalList.current.piece.AnimalName   'TRACK ANIMALS POPULATION
                            Select Case AnimalName

                                Case cl_GlobalSetting.AnimalONE
                                    cl_GlobalSetting.AnimalONEpopulation -= 1
                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalONEpopulation)
                                Case cl_GlobalSetting.AnimalTWO
                                    cl_GlobalSetting.AnimalTWOpopulation -= 1
                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalTWOpopulation)
                                Case cl_GlobalSetting.AnimalTHREE
                                    cl_GlobalSetting.AnimalTHREEpopulation -= 1
                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalTHREEpopulation)
                                Case cl_GlobalSetting.AnimalFOUR
                                    cl_GlobalSetting.AnimalFOURpopulation -= 1
                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalFOURpopulation)
                                Case cl_GlobalSetting.AnimalFIVE
                                    cl_GlobalSetting.AnimalFIVEpopulation -= 1
                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalFIVEpopulation)
                            End Select
                            x = animalList.current.X
                            y = animalList.current.Y
                            animalList.NextAnimalNode()
                            animalList.delete(x, y) 'removes from linked list
                            Board(x, y) = Nothing 'removes off board






                        Else
                            If checkBoundary(temp) = True Then 'Checking if temp coordinate is within board boundary
                                If checkEmpty(temp) = True Then 'checking if position is empty


                                    Board(temp(0), temp(1)) = Board(animalList.current.X, animalList.current.Y) 'Assigning specie with new coordinates 

                                    Board(animalList.current.X, animalList.current.Y) = Nothing

                                    animalList.current.X = temp(0) ' gives new x coordinate
                                    animalList.current.Y = temp(1) 'Gives new y coordinate

                                Else 'Conditions were they are on the same position
                                    If Board(animalList.current.X, animalList.current.Y).AnimalName <> Board(temp(0), temp(1)).AnimalName Then 'Different specie

                                        'MsgBox(Board(animalList.current.X, animalList.current.Y).AnimalName & " met with " & Board(temp(0), temp(1)).AnimalName) 

                                        'Remove Animal off board
                                        If Board(animalList.current.X, animalList.current.Y).FoodType > Board(temp(0), temp(1)).FoodType Then
                                            cl_GlobalSetting.log.write("animal: " & animalList.current.piece.AnimalName & " EATEN " & Board(temp(0), temp(1)).AnimalName)

                                            AnimalName = Board(temp(0), temp(1)).AnimalName 'TRACK ANIMAL POPULATION

                                            Select Case AnimalName

                                                Case cl_GlobalSetting.AnimalONE
                                                    cl_GlobalSetting.AnimalONEpopulation -= 1
                                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalONEpopulation)
                                                Case cl_GlobalSetting.AnimalTWO
                                                    cl_GlobalSetting.AnimalTWOpopulation -= 1
                                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalTWOpopulation)
                                                Case cl_GlobalSetting.AnimalTHREE
                                                    cl_GlobalSetting.AnimalTHREEpopulation -= 1
                                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalTHREEpopulation)
                                                Case cl_GlobalSetting.AnimalFOUR
                                                    cl_GlobalSetting.AnimalFOURpopulation -= 1
                                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalFOURpopulation)
                                                Case cl_GlobalSetting.AnimalFIVE
                                                    cl_GlobalSetting.AnimalFIVEpopulation -= 1
                                                    cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalFIVEpopulation)
                                            End Select
                                            Board(temp(0), temp(1)) = Board(animalList.current.X, animalList.current.Y)
                                            animalList.delete(temp(0), temp(1)) 'removes from linked list

                                            Board(animalList.current.X, animalList.current.Y) = Nothing 'removes off board

                                            animalList.current.X = temp(0) ' gives new x coordinate

                                            animalList.current.Y = temp(1) 'Gives new y coordinate

                                            EatenFood = True






                                            'MsgBox("EATEN")
                                        Else
                                            EatenFood = False



                                        End If
                                    ElseIf Board(animalList.current.X, animalList.current.Y).AnimalName = Board(temp(0), temp(1)).AnimalName And Board(animalList.current.X, animalList.current.Y).age >= Board(temp(0), temp(1)).age Then 'Species are the same or older, chance to activate BIRTH more regularly!

                                        '16/01/2020 updated conditions to mate so age of species and animal name are good for mating 
                                        'Also age is equal to minimise growth (I know naming is weird :P)
                                        'Updated birth rate to make the chance of births to be less 
                                        'Need a way to make them die faster from death as program keeps crashing and seems like they dont die
                                        'Program seems to break suddenly even when i lower birth rate to 0.05

                                        Dim newBorn As cl_Animal
                                        Dim newCoor() As Integer
                                        If checkEmpty(temp) = False Then


                                            newBorn = Board(animalList.current.X, animalList.current.Y).GiveBirth()

                                            If IsNothing(newBorn) = False Then



                                                newCoor = checkAvailableSpace(animalList.current.X, animalList.current.Y)
                                                If newCoor(0) <> -1 Then
                                                    cl_GlobalSetting.log.write(newBorn.AnimalName & " IS born")

                                                    Board(newCoor(0), newCoor(1)) = newBorn
                                                    animalList.addQueue(newBorn, newCoor(0), newCoor(1))

                                                    AnimalName = newBorn.AnimalName 'TRACK ANIMAL POPULATION
                                                    Select Case AnimalName

                                                        Case cl_GlobalSetting.AnimalONE
                                                            cl_GlobalSetting.AnimalONEpopulation += 1
                                                            cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalONEpopulation)
                                                        Case cl_GlobalSetting.AnimalTWO
                                                            cl_GlobalSetting.AnimalTWOpopulation += 1
                                                            cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalTWOpopulation)
                                                        Case cl_GlobalSetting.AnimalTHREE
                                                            cl_GlobalSetting.AnimalTHREEpopulation += 1
                                                            cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalTHREEpopulation)
                                                        Case cl_GlobalSetting.AnimalFOUR
                                                            cl_GlobalSetting.AnimalFOURpopulation += 1
                                                            cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalFOURpopulation)
                                                        Case cl_GlobalSetting.AnimalFIVE
                                                            cl_GlobalSetting.AnimalFIVEpopulation += 1
                                                            cl_GlobalSetting.log.write(animalList.current.piece.AnimalName & " POPULATION: " & cl_GlobalSetting.AnimalFIVEpopulation)
                                                    End Select

                                                End If

                                            End If


                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Loop Until animalList.NextAnimalNode() = False Or animalList.populationNum <= 0
        End If 'Population = 0

    End Sub

    Function returnCor(ByVal direction As String, ByVal x As Integer, ByVal y As Integer) As Integer()
        Dim coordinate(2) As Integer
     
        Select Case direction
            Case "N"
                coordinate(0) = x
                coordinate(1) = y - 1


            Case "NE"
                coordinate(0) = x + 1
                coordinate(1) = y - 1



            Case "E"
                coordinate(0) = x + 1
                coordinate(1) = y


            Case "SE"
                coordinate(0) = x + 1
                coordinate(1) = y + 1



            Case "S"
              coordinate(0) = x
                coordinate(1) = y + 1



            Case "SW"
                coordinate(0) = x - 1
                coordinate(1) = y + 1

            Case "W"
                coordinate(0) = x - 1
                coordinate(1) = y

            Case "NW"
                coordinate(0) = x - 1
                coordinate(1) = y - 1

            Case Else
                coordinate(0) = x
                coordinate(1) = y


        End Select


        Return coordinate
    End Function

    Function checkBoundary(ByVal coordinate() As Integer) As Boolean

        If coordinate(0) < 0 Or coordinate(0) > 49 Or coordinate(1) < 0 Or coordinate(1) > 49 Then 'Solved this via boolean algebra for documentation a.b.c.d & a+b+c+d
            Return False
        Else
            Return True
        End If

    End Function

    Function checkEmpty(ByVal coordinate() As Integer) As Boolean

        If coordinate(0) >= 0 And coordinate(1) >= 0 And coordinate(0) <= 50 And coordinate(1) <= 50 Then

            If IsNothing(Board(coordinate(0), coordinate(1))) = True Then
                Return True
            Else
                Return False
            End If

        Else
            Return False

        End If


    End Function

    Function PredatorToPrey() As Boolean 'Foodchainrank is used

        Return Nothing
    End Function

    Function SameSpecie() As Boolean   'Animal Name is compared
    
        Return Nothing
    End Function

    Function PreyToPredator() As Boolean ' Might need this one

        Return Nothing
    End Function




    Sub addAnimal(ByVal animal As cl_Animal, ByVal amount As Integer)
        Dim X As Integer
        Dim Y As Integer

        Dim count As Integer = 0


        Do
            Randomize()
            X = Int(49 * Rnd())
            Y = Int(49 * Rnd())

            If IsNothing(Board(X, Y)) Then
                Select Case animal.FoodType
                    Case 1
                        animal = New cl_Herbivore(animal.AnimalName, animal.LifeSpan, animal.DeathRate, animal.Birth_Rate, animal.HungerMeter, animal.AnimalSpeed, animal.FoodChainRank)
                    Case 2
                        animal = New cl_Omnivore(animal.AnimalName, animal.LifeSpan, animal.DeathRate, animal.Birth_Rate, animal.HungerMeter, animal.AnimalSpeed, animal.FoodChainRank)
                    Case 3
                        animal = New cl_Carnivore(animal.AnimalName, animal.LifeSpan, animal.DeathRate, animal.Birth_Rate, animal.HungerMeter, animal.AnimalSpeed, animal.FoodChainRank)
                    Case Else
                        MsgBox("Animal type is unrecognizable")
                End Select
                animalList.addQueue(animal, X, Y)
                Board(X, Y) = animal
                count = count + 1
                'MsgBox("Counter " & count & " Type:" & animal.FoodType & " x:" & X & "y:" & Y) 'Used to compare old method with this new method (linkedlist vs nested for loop)
            End If

        Loop Until count = amount

    End Sub

    Function checkAvailableSpace(ByVal x As Integer, ByVal y As Integer) As Integer()

        Dim EmptySpace(2) As Integer
        Dim newCor(2) As Integer
        Dim currentSpace(2) As Integer

        currentSpace(0) = x
        currentSpace(1) = y

        newCor(0) = CurrentSpace(0) - 1
        newCor(1) = CurrentSpace(1) - 1
        'validation is needed 
        If checkEmpty(newCor) = False Then
            newCor(0) = CurrentSpace(0)
            newCor(1) = CurrentSpace(1) - 1

            If checkEmpty(newCor) = False Then
                newCor(0) = CurrentSpace(0) + 1
                newCor(1) = CurrentSpace(1) - 1

                If checkEmpty(CurrentSpace) = False Then
                    newCor(0) = CurrentSpace(0) + 1
                    newCor(1) = CurrentSpace(1)

                    If checkEmpty(newCor) = False Then
                        newCor(0) = CurrentSpace(0) + 1
                        newCor(1) = CurrentSpace(1) + 1

                        If checkEmpty(newCor) = False Then
                            newCor(0) = CurrentSpace(0)
                            newCor(1) = CurrentSpace(1) + 1

                            If checkEmpty(newCor) = False Then
                                newCor(0) = CurrentSpace(0) - 1
                                newCor(1) = CurrentSpace(1) + 1

                                If checkEmpty(newCor) = False Then
                                    newCor(0) = CurrentSpace(0) - 1
                                    newCor(1) = CurrentSpace(1)

                                    If checkEmpty(newCor) = False Then
                                        newCor(0) = -1
                                        newCor(1) = -1
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        EmptySpace = newCor

        Return EmptySpace
    End Function




End Class
