Public Class FM_AnimalSimulation
    Dim b As cl_Board
    Private Sub AnimalSimulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("HI")
        b = cl_GlobalSetting.Board


    End Sub

    Private Sub lbl_day_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_day.Click

    End Sub

    Private Sub BTBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBack.Click

        Me.Chart1.Series("Population 1").Points.Clear()
        Me.Chart1.Series("Population 2").Points.Clear()
        Me.Chart1.Series("Population 3").Points.Clear()
        Me.Chart1.Series("Population 4").Points.Clear()
        Me.Chart1.Series("Population 5").Points.Clear()
        Application.Restart()
        Me.Hide()

        FM_Start.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim counter As Integer = 0
        Dim log As New cl_log

        lblanimalONE.Text = cl_GlobalSetting.AnimalONE
        lblanimalTWO.Text = cl_GlobalSetting.AnimalTWO
        lblanimalTHREE.Text = cl_GlobalSetting.AnimalTHREE
        lblanimalFOUR.Text = cl_GlobalSetting.AnimalFOUR
        lblanimalFIVE.Text = cl_GlobalSetting.AnimalFIVE



        cl_GlobalSetting.log = log

        For day = 0 To cl_GlobalSetting.TotalSimulationTime

            lblAnimalOnePOP.Text = cl_GlobalSetting.AnimalONEpopulation
            lblAnimalTwoPOP.Text = cl_GlobalSetting.AnimalTWOpopulation
            lblAnimalTHREEPOP.Text = cl_GlobalSetting.AnimalTHREEpopulation
            lblAnimalFOURPOP.Text = cl_GlobalSetting.AnimalFOURpopulation
            lblAnimalFIVEPOP.Text = cl_GlobalSetting.AnimalFIVEpopulation

            'If cl_GlobalSetting.AnimalONEpopulation Or cl_GlobalSetting.AnimalTWOpopulation Then


            'Display board 
            lbl_day.Text = day & " days"   ' counts number of days
            Dim myGraphics As Graphics = Me.CreateGraphics
            Dim myPen As Pen
            myPen = New Pen(Brushes.Black, 1)
            Dim Brush As SolidBrush
            Dim rect As New RectangleF(0.0, 0.0, b.returnBOARDSIZEX, b.returnBOARDSIZEY)

            ' Create rectangle.  ' Fill rectangle to screen.
            Select Case b.BoardType
                Case "Desert"
                    Brush = New SolidBrush(Color.LightGoldenrodYellow)
                    myGraphics.FillRectangle(Brush, rect)
                    myGraphics.FillRectangle(Brush, rect)
                Case "Greenland"
                    Brush = New SolidBrush(Color.ForestGreen)
                    myGraphics.FillRectangle(Brush, rect)
                    myGraphics.FillRectangle(Brush, rect)
                Case "Arctic"
                    Brush = New SolidBrush(Color.WhiteSmoke)
                    myGraphics.FillRectangle(Brush, rect)
                    myGraphics.FillRectangle(Brush, rect)
                Case Else
                    MsgBox(":( Type error for boardtype")

            End Select


            'Dim ANimal As Pen
            'ANimal = New Pen(Brushes.Black, 1)
            'Brush = New SolidBrush(Color.Black)
            'Dim r As New RectangleF(0.0, 0.0, 10, 10)
            'myGraphics.FillRectangle(Brush, r)
            'myGraphics.FillRectangle(Brush, r)

            b.animalList.reset()



            Do
                counter = counter + 1
                If IsNothing(b.animalList.current) = False Then

                    Select Case b.animalList.current.piece.AnimalName

                        Case cl_GlobalSetting.AnimalONE
                            Brush = New SolidBrush(Color.LightBlue) 'population 1

                        Case cl_GlobalSetting.AnimalTWO
                            Brush = New SolidBrush(Color.Yellow) 'population 2

                        Case cl_GlobalSetting.AnimalTHREE
                            Brush = New SolidBrush(Color.Red) 'population 3

                        Case cl_GlobalSetting.AnimalFOUR
                            Brush = New SolidBrush(Color.Green) 'population 4

                        Case cl_GlobalSetting.AnimalFIVE
                            Brush = New SolidBrush(Color.Purple) 'population 5


                    End Select

                    'Select Case b.animalList.current.piece.FoodType
                    '    Case 1
                    '        Brush = New SolidBrush(Color.LightBlue) 'herbivore

                    '    Case 2
                    '        Brush = New SolidBrush(Color.Purple) 'omnivore

                    '    Case 3
                    '        Brush = New SolidBrush(Color.Red) 'carnivore

                    '    Case Else
                    '        Brush = New SolidBrush(Color.Black) 'backUp

                    'End Select

                    Dim Animaloutline As Pen 'Outline for each animal
                    Animaloutline = New Pen(Brushes.Black, 1)

                    Dim r As New RectangleF(b.animalList.current.X * 10, b.animalList.current.Y * 10, 10, 10) 'dimensions for each animal inside the board
                    myGraphics.FillRectangle(Brush, r)
                    myGraphics.FillRectangle(Brush, r)
                End If
                ' MsgBox("Pop " & b.animalList.populationNum)

            Loop Until b.animalList.NextAnimalNode() = False

            If b.animalList.populationNum <= 0 Then
                day = cl_GlobalSetting.TotalSimulationTime

            End If

            Me.Chart1.Series("Population 1").Points.AddXY(day, cl_GlobalSetting.AnimalONEpopulation)
            Me.Chart1.Series("Population 2").Points.AddXY(day, cl_GlobalSetting.AnimalTWOpopulation)
            Me.Chart1.Series("Population 3").Points.AddXY(day, cl_GlobalSetting.AnimalTHREEpopulation)
            Me.Chart1.Series("Population 4").Points.AddXY(day, cl_GlobalSetting.AnimalFOURpopulation)
            Me.Chart1.Series("Population 5").Points.AddXY(day, cl_GlobalSetting.AnimalFIVEpopulation)


            b.RunDay()

            '20/1/2020 need to end simulation when population = 0




            System.Threading.Thread.Sleep(75) ' Speed at which the simulation runs 
            Application.DoEvents()



        Next

        MsgBox("End Simulation")
    End Sub
    Public Sub AddNewBornToBoard()



        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen
        myPen = New Pen(Brushes.Black, 1)
        Dim Brush As SolidBrush
        Dim rect As New RectangleF(0.0, 0.0, b.returnBOARDSIZEX, b.returnBOARDSIZEY)

        Select Case b.animalList.current.piece.AnimalName

            Case cl_GlobalSetting.AnimalONE
                Brush = New SolidBrush(Color.LightBlue) 'population 1

            Case cl_GlobalSetting.AnimalTWO
                Brush = New SolidBrush(Color.Yellow) 'population 2

            Case cl_GlobalSetting.AnimalTHREE
                Brush = New SolidBrush(Color.Red) 'population 3

            Case cl_GlobalSetting.AnimalFOUR
                Brush = New SolidBrush(Color.Green) 'population 4

            Case cl_GlobalSetting.AnimalFIVE
                Brush = New SolidBrush(Color.Purple) 'population 5

        End Select

        'Select Case b.animalList.current.piece.FoodType
        '    Case 1
        '        Brush = New SolidBrush(Color.Blue) 'herbivore

        '    Case 2
        '        Brush = New SolidBrush(Color.MediumPurple) 'omnivore

        '    Case 3
        '        Brush = New SolidBrush(Color.IndianRed) 'carnivore

        '    Case Else
        '        Brush = New SolidBrush(Color.Black) 'backUp

        'End Select

        Dim Animaloutline As Pen 'Outline for each animal
        Animaloutline = New Pen(Brushes.Black, 1)

        Dim addBaby As New RectangleF(b.animalList.current.X * 10, b.animalList.current.Y * 10, 10, 10) 'dimensions for each animal inside the board
        myGraphics.FillRectangle(Brush, addBaby)
        myGraphics.FillRectangle(Brush, addBaby)






    End Sub

    Private Sub BTClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTClear.Click
        b.animalList.reset() 'Doesnt work
    End Sub


    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click



    End Sub
End Class