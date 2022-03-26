Public Class cl_LinkedList
    Public head As cl_Node
    Public tail As cl_Node
    Public current As cl_Node
    Private previous As cl_Node
    Public populationNum As Integer

    Sub New()
        populationNum = 0
    End Sub
    Sub addQueue(ByVal thisAnimal As cl_Animal, ByVal X As Integer, ByVal Y As Integer)
        Dim temp As New cl_Node
        temp.piece = thisAnimal
        temp.X = X
        temp.Y = Y
        If IsNothing(head) =
            True Then
            current = temp
            head = temp
            tail = temp

        Else
            tail.nextNode = temp
            tail = temp

        End If
        populationNum = populationNum + 1
    End Sub
    Sub addStack(ByVal thisAnimal As cl_Animal, ByVal X As Integer, ByVal Y As Integer)
        Dim temp As New cl_Node
        temp.piece = thisAnimal
        temp.X = X
        temp.Y = Y

        If IsNothing(head) = True Then

            current = temp
            head = temp
            tail = temp
        Else
            temp.nextNode = head
            head = temp

        End If
        populationNum = populationNum + 1
    End Sub

    Function NextAnimalNode() As Boolean

        If IsNothing(current) = False Then
            If IsNothing(current.nextNode) = False Then
                previous = current

                current = current.nextNode
                Return True

            Else



                Return False

            End If
        Else
            Return False
        End If
    End Function

    Sub reset()
        current = head
        previous = Nothing

    End Sub

    Sub delete()
        previous.nextNode = current.nextNode
        current = current.nextNode

        populationNum = populationNum - 1
    End Sub


    Sub delete(ByVal x As Integer, ByVal y As Integer) 'FLOWCHART FOR DOCUMENT ON HOW WE DELETED AN ANIMAL AFTER BEING EATEN
        Dim temp As cl_Node
        Dim isDeleted As Boolean
        Dim previous As cl_Node
        isDeleted = False
        temp = head
        previous = head

        If temp.X = x And temp.Y = y Then 'deletes head of node
            cl_GlobalSetting.log.write("ERROR 1.1")
            head = head.nextNode
            isDeleted = True
        End If

        Do
            If IsNothing(temp.nextNode) = True Then
                cl_GlobalSetting.log.write("ERROR 1.2")
                previous.nextNode = Nothing
                isDeleted = True
            Else
                If temp.nextNode.X = x And temp.nextNode.Y = y Then 'deletes a node within the body of the node
                    cl_GlobalSetting.log.write("ERROR 1.3")
                    If IsNothing(temp.nextNode.nextNode) = False Then
                        cl_GlobalSetting.log.write("ERROR 1.4")
                        temp.nextNode = temp.nextNode.nextNode
                        isDeleted = True
                    Else
                        cl_GlobalSetting.log.write("ERROR 1.5")
                        temp.nextNode = Nothing
                        isDeleted = True
                    End If
                Else
                    cl_GlobalSetting.log.write("ERROR 1.6")
                    previous = temp
                    temp = temp.nextNode
                End If

            End If
            If isDeleted = True Then
                ' cl_GlobalSetting.log.write("Ends loop")
            End If
        Loop Until isDeleted = True
        populationNum = populationNum - 1
    End Sub
    'Function getAnimal() As cl_Animal

    '    If IsNothing(head) = False Then
    '        Dim temp As cl_Animal
    '        temp = head.piece

    '        If IsNothing(head.nextNode) = False Then
    '            head = head.nextNode

    '        Else
    '            head = Nothing
    '        End If


    '        Return temp
    '    Else
    '        Return Nothing
    '    End If


    'End Function
End Class
