Public Class FM_Start

    Private Sub FM_Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim test As New cl_Carnivore
        'test.GiveBirth()
    End Sub

    Private Sub btOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOption.Click

        Me.Hide()
        FM_Options.Show()
    End Sub

    Private Sub btRunSimulator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Hide()
        'FM_RunSimulation.Show()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FM_Information.Show()
    End Sub
End Class