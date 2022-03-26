Imports System.Data.OleDb
Public Class cl_Database

    Public Shared connectionString As String
    Private connection As OleDbConnection
    Sub New()
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\deror\OneDrive\Desktop\Validation forms\Forms\bin\Debug/AnimalSimulatorDatabase.accdb" 'F:\Current forms 3.1.2020\Forms\Forms\bin\Debug/AnimalSimulatorDatabase.accdb" 'N:/AnimalSimulatorDatabase.accdb"   ' F:\Current forms 3.1.2020\Forms\Forms\bin\Debug/AnimalSimulatorDatabase.accdb" 'Searches for desired database in directory 
        connection = New OleDbConnection(connectionString)
    End Sub

    Sub AddAnimal(ByVal Animal_name As String, ByVal Food_Source As String, ByVal Life_Span As Integer, ByVal Death_Rate As Double, ByVal Birth_Rate As Double, ByVal Hunger_Meter As Integer, ByVal Animal_Speed As Integer, ByVal Food_Chain_Rank As Integer)
        connection.Open()
        Dim insertCommand As OleDbCommand = New OleDbCommand("INSERT INTO [Species] ([Animal_names], [Food_Source_Type], [Life_Span], [Death_Rate], [Birth_Rate], [Hunger_Meter], [Animal_Speed], [Food_Chain_Rank]) VALUES ('" & Animal_name & "', '" & Food_Source & "', " & Life_Span & ", " & Death_Rate & ", " & Birth_Rate & "," & Hunger_Meter & "," & Animal_Speed & "," & Food_Chain_Rank & ";", connection)
        insertCommand.ExecuteNonQuery()
        connection.Close()
    End Sub

    Sub DeleteAnimal(ByVal Animal_name As String)

        connection.Open()
        Dim deleteCommand As OleDbCommand = New OleDbCommand("DELETE FROM [Species] WHERE [Animal_names] = '" & Animal_name & "';", connection)
        deleteCommand.ExecuteNonQuery()
        connection.Close()

    End Sub

    Sub UpdateAnimal(ByVal Animal_name As String, ByVal Food_Source As String, ByVal Life_Span As Integer, ByVal Death_Rate As Double, ByVal Birth_Rate As Double, ByVal Hunger_Meter As Integer, ByVal Animal_Speed As Integer)

        connection.Open()
        Dim updateCmd As OleDbCommand = New OleDbCommand("UPDATE [Species] SET [Food_Source_Type] = '" & Food_Source & "',[Life_Span] = '" & Life_Span & "', [Death_Rate] = '" & Death_Rate & "', [Birth_Rate] = '" & Birth_Rate & "', [Hunger_Meter] = '" & Hunger_Meter & "', [Animal_Speed] = '" & Animal_Speed & "';", connection)
        updateCmd.ExecuteNonQuery()
        connection.Close()

    End Sub

    'ORACLE PROGRAM code snippet
    Function selectSQL(ByVal table As String) As DataTable
        Dim selectCommand As String = "SELECT * FROM [" & table & "]"
        Dim reader As OleDbDataReader
        Dim command As New OleDbCommand(selectCommand, connection)
        Dim dataTable As New DataTable("")
        connection.Open()
        reader = command.ExecuteReader()
        dataTable.Load(reader)

        Return dataTable
    End Function

    'ORACLE PROGRAM code snippet
    Function selectAnimal() As DataTable '(ByVal table As String, ByVal fieldname As String) As DataTable
        Dim selectCommand As String = "Select * FROM [Species]"
        Dim reader As OleDbDataReader
        Dim command As New OleDbCommand(selectCommand, connection)
        Dim found As Boolean = False
        Dim dataTable As New DataTable("")
        Try
            connection.Open()
            reader = command.ExecuteReader()
            dataTable.Load(reader)
        Catch
            MsgBox("ERROR: Directory is misspelled.")
        End Try
        Return dataTable
    End Function
    Function selectAnimalTerrain(ByVal HabitatName As String) As DataTable '(ByVal table As String, ByVal fieldname As String) As DataTable
        Dim selectCommand As String = "SELECT * FROM [Habitat]" & " INNER JOIN [Habitat_Assignment] ON  Habitat.Habitat  = Habitat_Assignment.Habitat WHERE Habitat.Habitat_Name = '" & HabitatName & "';"
        Dim reader As OleDbDataReader
        Dim command As New OleDbCommand(selectCommand, connection)
        Dim dataTable As New DataTable("")

        connection.Open()
        reader = command.ExecuteReader()
        dataTable.Load(reader)

        reader.Close()
        connection.Close()


        Return dataTable
    End Function

    Function selectTerrain() As DataTable
        Dim selectCommand As String = "SELECT * FROM [Habitat] "
        Dim reader As OleDbDataReader
        Dim command As New OleDbCommand(selectCommand, connection)
        Dim found As Boolean = False
        Dim dataTable As New DataTable("")

        connection.Open()
        reader = command.ExecuteReader()
        dataTable.Load(reader)

        Return dataTable
    End Function

    Function selectAnimalData(ByVal AnimalName As String) As DataTable

        Dim selectCommand As String = "Select * FROM [Species] WHERE [Animal_names] = '" & AnimalName & "';"
        Dim reader As OleDbDataReader
        Dim command As New OleDbCommand(selectCommand, connection)
        Dim found As Boolean = False
        Dim dataTable As New DataTable("")

        connection.Open()
        reader = command.ExecuteReader()
        dataTable.Load(reader)

        Return dataTable
    End Function

End Class

