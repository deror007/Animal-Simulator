<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FM_Start
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
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btOption = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(73, 135)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(138, 30)
        Me.btQuit.TabIndex = 7
        Me.btQuit.Text = "QUIT"
        Me.btQuit.UseVisualStyleBackColor = True
        '
        'btOption
        '
        Me.btOption.Location = New System.Drawing.Point(73, 86)
        Me.btOption.Name = "btOption"
        Me.btOption.Size = New System.Drawing.Size(138, 30)
        Me.btOption.TabIndex = 5
        Me.btOption.Text = "START OPTIONS"
        Me.btOption.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(73, 52)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(139, 13)
        Me.Title.TabIndex = 4
        Me.Title.Text = "ECOSYSTEM SIMULATOR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FM_Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btOption)
        Me.Controls.Add(Me.Title)
        Me.Name = "FM_Start"
        Me.Text = "FM_Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btOption As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
