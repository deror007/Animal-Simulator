Public Class FM_Options


    Private Sub FM_Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call ListAnimalNames("")
        Call ListHabitatNames()

        'CBanimalONEpop.Text = "EMPTY"
        'CBanimalTWOpop.Text = "EMPTY"
        'CBanimalTHREEpop.Text = "EMPTY"
        'CBanimalFOURpop.Text = "EMPTY"
        'CBanimalFIVEpop.Text = "EMPTY"

        TBpopulationONE.Text = 0
        TBpopulationTWO.Text = 0
        TBpopulationTHREE.Text = 0
        TBpopulationFOUR.Text = 0
        TBpopulationFIVE.Text = 0

        TBtotalRunduration.Text = 0
    End Sub

    Sub ListAnimalNames(ByVal terrain As String)

        'Animal names listed under terrain type

        Dim ListofAnimal As New cl_Database
        Dim AnimalNamesdataTable As New DataTable

        If terrain = "" Then
            AnimalNamesdataTable = ListofAnimal.selectAnimal()
            If AnimalNamesdataTable.Rows.Count > 0 Then
                For x = 0 To AnimalNamesdataTable.Rows.Count - 1
                    CBanimalONEpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(0))
                    CBanimalTWOpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(0))
                    CBanimalTHREEpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(0))
                    CBanimalFOURpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(0))
                    CBanimalFIVEpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(0))

                Next
            End If

        Else
            AnimalNamesdataTable = ListofAnimal.selectAnimalTerrain(terrain)
            If AnimalNamesdataTable.Rows.Count > 0 Then
                For x = 0 To AnimalNamesdataTable.Rows.Count - 1
                    CBanimalONEpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(4))
                    CBanimalTWOpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(4))
                    CBanimalTHREEpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(4))
                    CBanimalFOURpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(4))
                    CBanimalFIVEpop.Items.Add(AnimalNamesdataTable.Rows(x).Item(4))

                Next
            End If

        End If



    End Sub

    Sub ListHabitatNames()

        'Habitat Names are listed under the terrain type

        Dim HabitatNamesdataTable As New DataTable
        Dim ListofHabitat As New cl_Database

        HabitatNamesdataTable = ListofHabitat.selectTerrain()

        If HabitatNamesdataTable.Rows.Count > 0 Then
            For x = 0 To HabitatNamesdataTable.Rows.Count - 1
                CBterrainType.Items.Add(HabitatNamesdataTable.Rows(x).Item(1))

            Next
        End If


    End Sub

    Function Animaldata(ByVal AnimalName As String) As cl_Animal

        'Get animaldata 

        Dim AnimaldataTable As New DataTable
        Dim AnimalDb As New cl_Database

        AnimaldataTable = AnimalDb.selectAnimalData(AnimalName)

        If AnimaldataTable.Rows.Count > 0 Then

            Select Case AnimaldataTable.Rows(0).Item(1)
                Case "Herbivore"
                    Dim a As New cl_Herbivore(AnimaldataTable.Rows(0).Item(0), AnimaldataTable.Rows(0).Item(2), AnimaldataTable.Rows(0).Item(3), AnimaldataTable.Rows(0).Item(4), AnimaldataTable.Rows(0).Item(5), AnimaldataTable.Rows(0).Item(6), AnimaldataTable.Rows(0).Item(7))
                    'b.addAnimal(h, 25) 
                    Return a
                Case "Omnivore"
                    Dim a As New cl_Omnivore(AnimaldataTable.Rows(0).Item(0), AnimaldataTable.Rows(0).Item(2), AnimaldataTable.Rows(0).Item(3), AnimaldataTable.Rows(0).Item(4), AnimaldataTable.Rows(0).Item(5), AnimaldataTable.Rows(0).Item(6), AnimaldataTable.Rows(0).Item(7))
                    'b.addAnimal(o, 5)
                    Return a
                Case "Carnivore"
                    Dim a As New cl_Carnivore(AnimaldataTable.Rows(0).Item(0), AnimaldataTable.Rows(0).Item(2), AnimaldataTable.Rows(0).Item(3), AnimaldataTable.Rows(0).Item(4), AnimaldataTable.Rows(0).Item(5), AnimaldataTable.Rows(0).Item(6), AnimaldataTable.Rows(0).Item(7))
                    'b.addAnimal(c, 2)
                    Return a
            End Select
        Else
            Return Nothing
        End If


        Return Nothing

    End Function

    Private Sub BTaddAnimaltoSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim db As New cl_Database
        'db.AddAnimal("Human", "Herbivore", 15, 0.2, 0.35, 5, 2)
        'db.DeleteAnimal("Panda1")
        'db.UpdateAnimal("Panda", "NOT-Carnivore", 3, 0.5, 0.25, 7, 1)
    End Sub

    Private Sub TBtotalRunduration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtotalRunduration.TextChanged

    End Sub

    Private Sub BTback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTback.Click
        Me.Hide()
        FM_Start.Show()
    End Sub

    Private Sub LBLSimRuntime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLSimRuntime.Click

    End Sub
    'Validated user input and allow option inputs to be transferred to simulation.
    'error when IsNumeric(TBpopulationONE.Text) = False Or Nothing 'can't convert isnumeric boolean to string , silly mistake

    Private Sub BTRunSimulation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTRunSimulation.Click
        Dim validInput As Boolean = False

        If CBterrainType.Text = Nothing Or CBterrainType.Text = "                               Terrain Type" Then
            CBterrainType.Text = "                              Terrain Type"
            MsgBox("HABITAT is not valid.")

        ElseIf IsNumeric(TBpopulationONE.Text) = False Or TBpopulationONE.Text = Nothing Then

            TBpopulationONE.Text = Nothing
            MsgBox("population one size is not numerical.")

        ElseIf IsNumeric(TBpopulationTWO.Text) = False Or TBpopulationTWO.Text = Nothing Then

            TBpopulationTWO.Text = Nothing
            MsgBox("population 2 size is not numerical.")

        ElseIf IsNumeric(TBpopulationTHREE.Text) = False Or TBpopulationTHREE.Text = Nothing Then

            TBpopulationTHREE.Text = Nothing
            MsgBox("population 3 size is not numerical.")

        ElseIf IsNumeric(TBpopulationFOUR.Text) = False Or TBpopulationFOUR.Text = Nothing Then

            TBpopulationFOUR.Text = Nothing
            MsgBox("population 4 size is not numerical.")

        ElseIf IsNumeric(TBpopulationFIVE.Text) = False Or TBpopulationFIVE.Text = Nothing Then

            TBpopulationFIVE.Text = Nothing
            MsgBox("population 5 size is not numerical.")

        Else
            validInput = True
        End If

        If validInput = True Then
            setup()
            cl_GlobalSetting.TotalSimulationTime = TBtotalRunduration.Text
            Me.Close()
            FM_AnimalSimulation.Show()
        End If

    End Sub
    Private Sub setup()

        cl_GlobalSetting.Board = New cl_Board(CBterrainType.Text) 'Setup board from terraintyp information in options

        'Setup population sizes and animal specie from options

        If TBpopulationONE.Text <> 0 Then
            cl_GlobalSetting.Board.addAnimal(Animaldata(CBanimalONEpop.Text), TBpopulationONE.Text)
            cl_GlobalSetting.AnimalONEpopulation = TBpopulationONE.Text
            cl_GlobalSetting.AnimalONE = CBanimalONEpop.Text
        End If

        If TBpopulationTWO.Text <> 0 Then
            cl_GlobalSetting.Board.addAnimal(Animaldata(CBanimalTWOpop.Text), TBpopulationTWO.Text)
            cl_GlobalSetting.AnimalTWOpopulation = TBpopulationTWO.Text
            cl_GlobalSetting.AnimalTWO = CBanimalTWOpop.Text
        End If

        If TBpopulationTHREE.Text <> 0 Then
            cl_GlobalSetting.Board.addAnimal(Animaldata(CBanimalTHREEpop.Text), TBpopulationTHREE.Text)
            cl_GlobalSetting.AnimalTHREEpopulation = TBpopulationTHREE.Text
            cl_GlobalSetting.AnimalTHREE = CBanimalTHREEpop.Text
        End If

        If TBpopulationFOUR.Text <> 0 Then
            cl_GlobalSetting.Board.addAnimal(Animaldata(CBanimalFOURpop.Text), TBpopulationFOUR.Text)
            cl_GlobalSetting.AnimalFOURpopulation = TBpopulationFOUR.Text
            cl_GlobalSetting.AnimalFOUR = CBanimalFOURpop.Text
        End If

        If TBpopulationFIVE.Text <> 0 Then
            cl_GlobalSetting.Board.addAnimal(Animaldata(CBanimalFIVEpop.Text), TBpopulationFIVE.Text)
            cl_GlobalSetting.AnimalFIVEpopulation = TBpopulationFIVE.Text
            cl_GlobalSetting.AnimalFIVE = CBanimalFIVEpop.Text

        End If

    End Sub




    Private Sub CBterrainType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBterrainType.SelectedIndexChanged
        Dim terrain As String = CBterrainType.Text
        CBanimalONEpop.Items.Clear()
        CBanimalTWOpop.Items.Clear()
        CBanimalTHREEpop.Items.Clear()
        CBanimalFOURpop.Items.Clear()
        CBanimalFIVEpop.Items.Clear()


        Call ListAnimalNames(terrain)



    End Sub

   
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TBpopulationONE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBpopulationONE.TextChanged

    End Sub
    'STOP USER FROM SELECTING A SELECTED ANIMAL
    Private Sub CBanimalONEpop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBanimalONEpop.SelectedIndexChanged
        CBanimalTWOpop.Items.Remove(CBanimalONEpop.SelectedItem)
        CBanimalTHREEpop.Items.Remove(CBanimalONEpop.SelectedItem)
        CBanimalFOURpop.Items.Remove(CBanimalONEpop.SelectedItem)
        CBanimalFIVEpop.Items.Remove(CBanimalONEpop.SelectedItem)


    End Sub

    Private Sub CBanimalTWOpop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBanimalTWOpop.SelectedIndexChanged
        CBanimalTHREEpop.Items.Remove(CBanimalTWOpop.SelectedItem)
        CBanimalFOURpop.Items.Remove(CBanimalTWOpop.SelectedItem)
        CBanimalONEpop.Items.Remove(CBanimalTWOpop.SelectedItem)
        CBanimalFIVEpop.Items.Remove(CBanimalTWOpop.SelectedItem)

    End Sub

    Private Sub CBanimalTHREEpop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBanimalTHREEpop.SelectedIndexChanged
        CBanimalFOURpop.Items.Remove(CBanimalTHREEpop.SelectedItem)
        CBanimalFIVEpop.Items.Remove(CBanimalTHREEpop.SelectedItem)
        CBanimalTWOpop.Items.Remove(CBanimalTHREEpop.SelectedItem)
        CBanimalONEpop.Items.Remove(CBanimalTHREEpop.SelectedItem)
    End Sub

    Private Sub CBanimalFOURpop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBanimalFOURpop.SelectedIndexChanged
        CBanimalFIVEpop.Items.Remove(CBanimalFOURpop.SelectedItem)
        CBanimalTHREEpop.Items.Remove(CBanimalFOURpop.SelectedItem)
        CBanimalTWOpop.Items.Remove(CBanimalFOURpop.SelectedItem)
        CBanimalONEpop.Items.Remove(CBanimalFOURpop.SelectedItem)
    End Sub

    Private Sub CBanimalFIVEpop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBanimalFIVEpop.SelectedIndexChanged
        CBanimalONEpop.Items.Remove(CBanimalFIVEpop.SelectedItem)
        CBanimalFOURpop.Items.Remove(CBanimalFIVEpop.SelectedItem)
        CBanimalTHREEpop.Items.Remove(CBanimalFIVEpop.SelectedItem)
        CBanimalTWOpop.Items.Remove(CBanimalFIVEpop.SelectedItem)

    End Sub
End Class