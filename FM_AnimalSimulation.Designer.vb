<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FM_AnimalSimulation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.BTBack = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTClear = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblanimalONE = New System.Windows.Forms.Label()
        Me.lblanimalTWO = New System.Windows.Forms.Label()
        Me.lblanimalTHREE = New System.Windows.Forms.Label()
        Me.lblanimalFOUR = New System.Windows.Forms.Label()
        Me.lblanimalFIVE = New System.Windows.Forms.Label()
        Me.ClGlobalSettingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblAnimalOnePOP = New System.Windows.Forms.Label()
        Me.lblAnimalTwoPOP = New System.Windows.Forms.Label()
        Me.lblAnimalTHREEPOP = New System.Windows.Forms.Label()
        Me.lblAnimalFOURPOP = New System.Windows.Forms.Label()
        Me.lblAnimalFIVEPOP = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClGlobalSettingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_day
        '
        Me.lbl_day.AutoSize = True
        Me.lbl_day.Location = New System.Drawing.Point(509, 9)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(40, 13)
        Me.lbl_day.TabIndex = 8
        Me.lbl_day.Text = "0 Days"
        '
        'BTBack
        '
        Me.BTBack.Location = New System.Drawing.Point(986, 583)
        Me.BTBack.Name = "BTBack"
        Me.BTBack.Size = New System.Drawing.Size(107, 38)
        Me.BTBack.TabIndex = 7
        Me.BTBack.Text = "Back"
        Me.BTBack.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(768, 583)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Start Simulation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTClear
        '
        Me.BTClear.Location = New System.Drawing.Point(512, 583)
        Me.BTClear.Name = "BTClear"
        Me.BTClear.Size = New System.Drawing.Size(107, 35)
        Me.BTClear.TabIndex = 5
        Me.BTClear.Text = "Clear"
        Me.BTClear.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BorderlineWidth = 5
        ChartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea1.AxisX.Crossing = -1.7976931348623157E+308R
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.Minimum = 0.0R
        ChartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.ScaleView.SmallScrollMinSize = 10.0R
        ChartArea1.AxisX.ScaleView.Zoomable = False
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.AxisY.Minimum = 0.0R
        ChartArea1.CursorX.SelectionStart = 0.0R
        ChartArea1.CursorY.SelectionStart = 0.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.IsDockedInsideChartArea = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(512, 25)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Population 1"
        DataPoint1.AxisLabel = "DAYS#VALX{N}"
        Series1.Points.Add(DataPoint1)
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Population 2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Population 3"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.Legend = "Legend1"
        Series4.Name = "Population 4"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.Fuchsia
        Series5.Legend = "Legend1"
        Series5.Name = "Population 5"
        Series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(610, 509)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        '
        'lblanimalONE
        '
        Me.lblanimalONE.AutoSize = True
        Me.lblanimalONE.Location = New System.Drawing.Point(557, 63)
        Me.lblanimalONE.Name = "lblanimalONE"
        Me.lblanimalONE.Size = New System.Drawing.Size(47, 13)
        Me.lblanimalONE.TabIndex = 10
        Me.lblanimalONE.Text = "Animal 1"
        '
        'lblanimalTWO
        '
        Me.lblanimalTWO.AutoSize = True
        Me.lblanimalTWO.Location = New System.Drawing.Point(655, 63)
        Me.lblanimalTWO.Name = "lblanimalTWO"
        Me.lblanimalTWO.Size = New System.Drawing.Size(47, 13)
        Me.lblanimalTWO.TabIndex = 11
        Me.lblanimalTWO.Text = "Animal 2"
        '
        'lblanimalTHREE
        '
        Me.lblanimalTHREE.AutoSize = True
        Me.lblanimalTHREE.Location = New System.Drawing.Point(765, 63)
        Me.lblanimalTHREE.Name = "lblanimalTHREE"
        Me.lblanimalTHREE.Size = New System.Drawing.Size(47, 13)
        Me.lblanimalTHREE.TabIndex = 12
        Me.lblanimalTHREE.Text = "Animal 3"
        '
        'lblanimalFOUR
        '
        Me.lblanimalFOUR.AutoSize = True
        Me.lblanimalFOUR.Location = New System.Drawing.Point(863, 63)
        Me.lblanimalFOUR.Name = "lblanimalFOUR"
        Me.lblanimalFOUR.Size = New System.Drawing.Size(47, 13)
        Me.lblanimalFOUR.TabIndex = 13
        Me.lblanimalFOUR.Text = "Animal 4"
        '
        'lblanimalFIVE
        '
        Me.lblanimalFIVE.AutoSize = True
        Me.lblanimalFIVE.Location = New System.Drawing.Point(965, 63)
        Me.lblanimalFIVE.Name = "lblanimalFIVE"
        Me.lblanimalFIVE.Size = New System.Drawing.Size(47, 13)
        Me.lblanimalFIVE.TabIndex = 14
        Me.lblanimalFIVE.Text = "Animal 5"
        '
        'ClGlobalSettingBindingSource
        '
        Me.ClGlobalSettingBindingSource.DataSource = GetType(BackUpFormsTWO.cl_GlobalSetting)
        '
        'lblAnimalOnePOP
        '
        Me.lblAnimalOnePOP.AutoSize = True
        Me.lblAnimalOnePOP.Location = New System.Drawing.Point(599, 63)
        Me.lblAnimalOnePOP.Name = "lblAnimalOnePOP"
        Me.lblAnimalOnePOP.Size = New System.Drawing.Size(0, 13)
        Me.lblAnimalOnePOP.TabIndex = 15
        '
        'lblAnimalTwoPOP
        '
        Me.lblAnimalTwoPOP.AutoSize = True
        Me.lblAnimalTwoPOP.Location = New System.Drawing.Point(698, 63)
        Me.lblAnimalTwoPOP.Name = "lblAnimalTwoPOP"
        Me.lblAnimalTwoPOP.Size = New System.Drawing.Size(0, 13)
        Me.lblAnimalTwoPOP.TabIndex = 16
        '
        'lblAnimalTHREEPOP
        '
        Me.lblAnimalTHREEPOP.AutoSize = True
        Me.lblAnimalTHREEPOP.Location = New System.Drawing.Point(809, 63)
        Me.lblAnimalTHREEPOP.Name = "lblAnimalTHREEPOP"
        Me.lblAnimalTHREEPOP.Size = New System.Drawing.Size(0, 13)
        Me.lblAnimalTHREEPOP.TabIndex = 17
        '
        'lblAnimalFOURPOP
        '
        Me.lblAnimalFOURPOP.AutoSize = True
        Me.lblAnimalFOURPOP.Location = New System.Drawing.Point(906, 63)
        Me.lblAnimalFOURPOP.Name = "lblAnimalFOURPOP"
        Me.lblAnimalFOURPOP.Size = New System.Drawing.Size(0, 13)
        Me.lblAnimalFOURPOP.TabIndex = 18
        '
        'lblAnimalFIVEPOP
        '
        Me.lblAnimalFIVEPOP.AutoSize = True
        Me.lblAnimalFIVEPOP.Location = New System.Drawing.Point(1009, 63)
        Me.lblAnimalFIVEPOP.Name = "lblAnimalFIVEPOP"
        Me.lblAnimalFIVEPOP.Size = New System.Drawing.Size(0, 13)
        Me.lblAnimalFIVEPOP.TabIndex = 19
        '
        'FM_AnimalSimulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 646)
        Me.Controls.Add(Me.lblAnimalFIVEPOP)
        Me.Controls.Add(Me.lblAnimalFOURPOP)
        Me.Controls.Add(Me.lblAnimalTHREEPOP)
        Me.Controls.Add(Me.lblAnimalTwoPOP)
        Me.Controls.Add(Me.lblAnimalOnePOP)
        Me.Controls.Add(Me.lblanimalFIVE)
        Me.Controls.Add(Me.lblanimalFOUR)
        Me.Controls.Add(Me.lblanimalTHREE)
        Me.Controls.Add(Me.lblanimalTWO)
        Me.Controls.Add(Me.lblanimalONE)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lbl_day)
        Me.Controls.Add(Me.BTBack)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTClear)
        Me.Name = "FM_AnimalSimulation"
        Me.Text = "AnimalSimulation"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClGlobalSettingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_day As System.Windows.Forms.Label
    Friend WithEvents BTBack As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BTClear As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ClGlobalSettingBindingSource As BindingSource
    Friend WithEvents lblanimalONE As Label
    Friend WithEvents lblanimalTWO As Label
    Friend WithEvents lblanimalTHREE As Label
    Friend WithEvents lblanimalFOUR As Label
    Friend WithEvents lblanimalFIVE As Label
    Friend WithEvents lblAnimalOnePOP As System.Windows.Forms.Label
    Friend WithEvents lblAnimalTwoPOP As System.Windows.Forms.Label
    Friend WithEvents lblAnimalTHREEPOP As System.Windows.Forms.Label
    Friend WithEvents lblAnimalFOURPOP As System.Windows.Forms.Label
    Friend WithEvents lblAnimalFIVEPOP As System.Windows.Forms.Label
End Class
