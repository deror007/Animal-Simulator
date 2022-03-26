<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FM_Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBterrainType = New System.Windows.Forms.ComboBox()
        Me.CBanimalONEpop = New System.Windows.Forms.ComboBox()
        Me.CBanimalTWOpop = New System.Windows.Forms.ComboBox()
        Me.TBpopulationONE = New System.Windows.Forms.TextBox()
        Me.LBLAnimalName = New System.Windows.Forms.Label()
        Me.LBLPopulation = New System.Windows.Forms.Label()
        Me.CBanimalTHREEpop = New System.Windows.Forms.ComboBox()
        Me.CBanimalFOURpop = New System.Windows.Forms.ComboBox()
        Me.CBanimalFIVEpop = New System.Windows.Forms.ComboBox()
        Me.TBpopulationTWO = New System.Windows.Forms.TextBox()
        Me.TBpopulationTHREE = New System.Windows.Forms.TextBox()
        Me.TBpopulationFOUR = New System.Windows.Forms.TextBox()
        Me.TBpopulationFIVE = New System.Windows.Forms.TextBox()
        Me.TBtotalRunduration = New System.Windows.Forms.TextBox()
        Me.LBLSimRuntime = New System.Windows.Forms.Label()
        Me.BTRunSimulation = New System.Windows.Forms.Button()
        Me.BTback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OPTIONS"
        '
        'CBterrainType
        '
        Me.CBterrainType.FormattingEnabled = True
        Me.CBterrainType.Location = New System.Drawing.Point(10, 103)
        Me.CBterrainType.Name = "CBterrainType"
        Me.CBterrainType.Size = New System.Drawing.Size(246, 21)
        Me.CBterrainType.TabIndex = 3
        Me.CBterrainType.Text = "                              Terrain Type"
        '
        'CBanimalONEpop
        '
        Me.CBanimalONEpop.FormattingEnabled = True
        Me.CBanimalONEpop.Location = New System.Drawing.Point(12, 144)
        Me.CBanimalONEpop.Name = "CBanimalONEpop"
        Me.CBanimalONEpop.Size = New System.Drawing.Size(243, 21)
        Me.CBanimalONEpop.TabIndex = 4
        Me.CBanimalONEpop.Text = "                                    Animal 1: "
        '
        'CBanimalTWOpop
        '
        Me.CBanimalTWOpop.FormattingEnabled = True
        Me.CBanimalTWOpop.Location = New System.Drawing.Point(12, 189)
        Me.CBanimalTWOpop.Name = "CBanimalTWOpop"
        Me.CBanimalTWOpop.Size = New System.Drawing.Size(243, 21)
        Me.CBanimalTWOpop.TabIndex = 5
        Me.CBanimalTWOpop.Text = "                                    Animal 2: "
        '
        'TBpopulationONE
        '
        Me.TBpopulationONE.Location = New System.Drawing.Point(261, 144)
        Me.TBpopulationONE.Name = "TBpopulationONE"
        Me.TBpopulationONE.Size = New System.Drawing.Size(43, 20)
        Me.TBpopulationONE.TabIndex = 6
        '
        'LBLAnimalName
        '
        Me.LBLAnimalName.AutoSize = True
        Me.LBLAnimalName.Location = New System.Drawing.Point(12, 127)
        Me.LBLAnimalName.Name = "LBLAnimalName"
        Me.LBLAnimalName.Size = New System.Drawing.Size(72, 13)
        Me.LBLAnimalName.TabIndex = 7
        Me.LBLAnimalName.Text = "Animal Name:"
        '
        'LBLPopulation
        '
        Me.LBLPopulation.AutoSize = True
        Me.LBLPopulation.Location = New System.Drawing.Point(258, 127)
        Me.LBLPopulation.Name = "LBLPopulation"
        Me.LBLPopulation.Size = New System.Drawing.Size(60, 13)
        Me.LBLPopulation.TabIndex = 8
        Me.LBLPopulation.Text = "Population:"
        '
        'CBanimalTHREEpop
        '
        Me.CBanimalTHREEpop.FormattingEnabled = True
        Me.CBanimalTHREEpop.Location = New System.Drawing.Point(12, 232)
        Me.CBanimalTHREEpop.Name = "CBanimalTHREEpop"
        Me.CBanimalTHREEpop.Size = New System.Drawing.Size(243, 21)
        Me.CBanimalTHREEpop.TabIndex = 9
        Me.CBanimalTHREEpop.Text = "                                    Animal 3: "
        '
        'CBanimalFOURpop
        '
        Me.CBanimalFOURpop.FormattingEnabled = True
        Me.CBanimalFOURpop.Location = New System.Drawing.Point(12, 274)
        Me.CBanimalFOURpop.Name = "CBanimalFOURpop"
        Me.CBanimalFOURpop.Size = New System.Drawing.Size(243, 21)
        Me.CBanimalFOURpop.TabIndex = 10
        Me.CBanimalFOURpop.Text = "                                    Animal 4: "
        '
        'CBanimalFIVEpop
        '
        Me.CBanimalFIVEpop.FormattingEnabled = True
        Me.CBanimalFIVEpop.Location = New System.Drawing.Point(12, 316)
        Me.CBanimalFIVEpop.Name = "CBanimalFIVEpop"
        Me.CBanimalFIVEpop.Size = New System.Drawing.Size(243, 21)
        Me.CBanimalFIVEpop.TabIndex = 11
        Me.CBanimalFIVEpop.Text = "                                    Animal 5: "
        '
        'TBpopulationTWO
        '
        Me.TBpopulationTWO.Location = New System.Drawing.Point(261, 190)
        Me.TBpopulationTWO.Name = "TBpopulationTWO"
        Me.TBpopulationTWO.Size = New System.Drawing.Size(43, 20)
        Me.TBpopulationTWO.TabIndex = 12
        '
        'TBpopulationTHREE
        '
        Me.TBpopulationTHREE.Location = New System.Drawing.Point(261, 233)
        Me.TBpopulationTHREE.Name = "TBpopulationTHREE"
        Me.TBpopulationTHREE.Size = New System.Drawing.Size(43, 20)
        Me.TBpopulationTHREE.TabIndex = 13
        '
        'TBpopulationFOUR
        '
        Me.TBpopulationFOUR.Location = New System.Drawing.Point(261, 274)
        Me.TBpopulationFOUR.Name = "TBpopulationFOUR"
        Me.TBpopulationFOUR.Size = New System.Drawing.Size(43, 20)
        Me.TBpopulationFOUR.TabIndex = 14
        '
        'TBpopulationFIVE
        '
        Me.TBpopulationFIVE.Location = New System.Drawing.Point(261, 317)
        Me.TBpopulationFIVE.Name = "TBpopulationFIVE"
        Me.TBpopulationFIVE.Size = New System.Drawing.Size(43, 20)
        Me.TBpopulationFIVE.TabIndex = 15
        '
        'TBtotalRunduration
        '
        Me.TBtotalRunduration.Location = New System.Drawing.Point(189, 392)
        Me.TBtotalRunduration.Name = "TBtotalRunduration"
        Me.TBtotalRunduration.Size = New System.Drawing.Size(141, 20)
        Me.TBtotalRunduration.TabIndex = 16
        '
        'LBLSimRuntime
        '
        Me.LBLSimRuntime.AutoSize = True
        Me.LBLSimRuntime.Location = New System.Drawing.Point(41, 395)
        Me.LBLSimRuntime.Name = "LBLSimRuntime"
        Me.LBLSimRuntime.Size = New System.Drawing.Size(130, 13)
        Me.LBLSimRuntime.TabIndex = 17
        Me.LBLSimRuntime.Text = "Total Sim. Runtime (days):"
        '
        'BTRunSimulation
        '
        Me.BTRunSimulation.Location = New System.Drawing.Point(10, 418)
        Me.BTRunSimulation.Name = "BTRunSimulation"
        Me.BTRunSimulation.Size = New System.Drawing.Size(187, 46)
        Me.BTRunSimulation.TabIndex = 18
        Me.BTRunSimulation.Text = "RUN SIMULATION"
        Me.BTRunSimulation.UseVisualStyleBackColor = True
        '
        'BTback
        '
        Me.BTback.Location = New System.Drawing.Point(261, 418)
        Me.BTback.Name = "BTback"
        Me.BTback.Size = New System.Drawing.Size(69, 46)
        Me.BTback.TabIndex = 19
        Me.BTback.Text = "BACK"
        Me.BTback.UseVisualStyleBackColor = True
        '
        'FM_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 470)
        Me.Controls.Add(Me.BTback)
        Me.Controls.Add(Me.BTRunSimulation)
        Me.Controls.Add(Me.LBLSimRuntime)
        Me.Controls.Add(Me.TBtotalRunduration)
        Me.Controls.Add(Me.TBpopulationFIVE)
        Me.Controls.Add(Me.TBpopulationFOUR)
        Me.Controls.Add(Me.TBpopulationTHREE)
        Me.Controls.Add(Me.TBpopulationTWO)
        Me.Controls.Add(Me.CBanimalFIVEpop)
        Me.Controls.Add(Me.CBanimalFOURpop)
        Me.Controls.Add(Me.CBanimalTHREEpop)
        Me.Controls.Add(Me.LBLPopulation)
        Me.Controls.Add(Me.LBLAnimalName)
        Me.Controls.Add(Me.TBpopulationONE)
        Me.Controls.Add(Me.CBanimalTWOpop)
        Me.Controls.Add(Me.CBanimalONEpop)
        Me.Controls.Add(Me.CBterrainType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FM_Options"
        Me.Text = "FM_Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBterrainType As System.Windows.Forms.ComboBox
    Friend WithEvents CBanimalONEpop As System.Windows.Forms.ComboBox
    Friend WithEvents CBanimalTWOpop As System.Windows.Forms.ComboBox
    Friend WithEvents TBpopulationONE As System.Windows.Forms.TextBox
    Friend WithEvents LBLAnimalName As System.Windows.Forms.Label
    Friend WithEvents LBLPopulation As System.Windows.Forms.Label
    Friend WithEvents CBanimalTHREEpop As System.Windows.Forms.ComboBox
    Friend WithEvents CBanimalFOURpop As System.Windows.Forms.ComboBox
    Friend WithEvents CBanimalFIVEpop As System.Windows.Forms.ComboBox
    Friend WithEvents TBpopulationTWO As System.Windows.Forms.TextBox
    Friend WithEvents TBpopulationTHREE As System.Windows.Forms.TextBox
    Friend WithEvents TBpopulationFOUR As System.Windows.Forms.TextBox
    Friend WithEvents TBpopulationFIVE As System.Windows.Forms.TextBox
    Friend WithEvents TBtotalRunduration As System.Windows.Forms.TextBox
    Friend WithEvents LBLSimRuntime As System.Windows.Forms.Label
    Friend WithEvents BTRunSimulation As System.Windows.Forms.Button
    Friend WithEvents BTback As System.Windows.Forms.Button
End Class
