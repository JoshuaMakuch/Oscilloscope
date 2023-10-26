<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OscilloscopeForm
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
        Me.PBDrawing = New System.Windows.Forms.PictureBox()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VerticalOffsetBar = New System.Windows.Forms.TrackBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TimePerDivisionDomain = New System.Windows.Forms.DomainUpDown()
        Me.OffsetTextBox = New System.Windows.Forms.TextBox()
        Me.RNGTextBox = New System.Windows.Forms.TextBox()
        Me.VoltsPerDivisionDomain = New System.Windows.Forms.DomainUpDown()
        CType(Me.PBDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalOffsetBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBDrawing
        '
        Me.PBDrawing.BackColor = System.Drawing.SystemColors.ControlText
        Me.PBDrawing.Location = New System.Drawing.Point(74, 14)
        Me.PBDrawing.Name = "PBDrawing"
        Me.PBDrawing.Size = New System.Drawing.Size(1000, 500)
        Me.PBDrawing.TabIndex = 0
        Me.PBDrawing.TabStop = False
        '
        'DrawButton
        '
        Me.DrawButton.BackColor = System.Drawing.SystemColors.Control
        Me.DrawButton.Location = New System.Drawing.Point(1080, 14)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(136, 78)
        Me.DrawButton.TabIndex = 1
        Me.DrawButton.Text = "Draw"
        Me.DrawButton.UseVisualStyleBackColor = False
        '
        'SelectColorButton
        '
        Me.SelectColorButton.BackColor = System.Drawing.SystemColors.Control
        Me.SelectColorButton.Location = New System.Drawing.Point(1080, 98)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(136, 78)
        Me.SelectColorButton.TabIndex = 2
        Me.SelectColorButton.Text = "Select Waveform Color"
        Me.SelectColorButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1080, 567)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 78)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearButton.Location = New System.Drawing.Point(1080, 182)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(136, 78)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'UpButton
        '
        Me.UpButton.Location = New System.Drawing.Point(1080, 266)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(136, 78)
        Me.UpButton.TabIndex = 5
        Me.UpButton.Text = "Up"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Location = New System.Drawing.Point(1079, 350)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(136, 78)
        Me.DownButton.TabIndex = 6
        Me.DownButton.Text = "Down"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'VerticalOffsetBar
        '
        Me.VerticalOffsetBar.BackColor = System.Drawing.Color.Gray
        Me.VerticalOffsetBar.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.VerticalOffsetBar.Location = New System.Drawing.Point(12, 5)
        Me.VerticalOffsetBar.Name = "VerticalOffsetBar"
        Me.VerticalOffsetBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.VerticalOffsetBar.Size = New System.Drawing.Size(56, 517)
        Me.VerticalOffsetBar.TabIndex = 8
        '
        'TimePerDivisionDomain
        '
        Me.TimePerDivisionDomain.Items.Add("Time/Div: 1s")
        Me.TimePerDivisionDomain.Items.Add("Time/Div: 100mS")
        Me.TimePerDivisionDomain.Items.Add("Time/Div: 10mS")
        Me.TimePerDivisionDomain.Items.Add("Time/Div: 1mS")
        Me.TimePerDivisionDomain.Location = New System.Drawing.Point(1079, 462)
        Me.TimePerDivisionDomain.Name = "TimePerDivisionDomain"
        Me.TimePerDivisionDomain.Size = New System.Drawing.Size(136, 22)
        Me.TimePerDivisionDomain.TabIndex = 9
        Me.TimePerDivisionDomain.Text = "Time/Div: 1mS"
        '
        'OffsetTextBox
        '
        Me.OffsetTextBox.Location = New System.Drawing.Point(12, 528)
        Me.OffsetTextBox.Name = "OffsetTextBox"
        Me.OffsetTextBox.Size = New System.Drawing.Size(56, 22)
        Me.OffsetTextBox.TabIndex = 10
        '
        'RNGTextBox
        '
        Me.RNGTextBox.Location = New System.Drawing.Point(1079, 434)
        Me.RNGTextBox.Name = "RNGTextBox"
        Me.RNGTextBox.Size = New System.Drawing.Size(136, 22)
        Me.RNGTextBox.TabIndex = 11
        Me.RNGTextBox.Text = "RNG Value: "
        '
        'VoltsPerDivisionDomain
        '
        Me.VoltsPerDivisionDomain.Items.Add("Volts/Div: 5V")
        Me.VoltsPerDivisionDomain.Items.Add("Volts/Div: 2V")
        Me.VoltsPerDivisionDomain.Items.Add("Volts/Div: 1V")
        Me.VoltsPerDivisionDomain.Items.Add("Volts/Div: 500mV")
        Me.VoltsPerDivisionDomain.Items.Add("Volts/div: 100mV")
        Me.VoltsPerDivisionDomain.Location = New System.Drawing.Point(1079, 490)
        Me.VoltsPerDivisionDomain.Name = "VoltsPerDivisionDomain"
        Me.VoltsPerDivisionDomain.Size = New System.Drawing.Size(136, 22)
        Me.VoltsPerDivisionDomain.TabIndex = 12
        Me.VoltsPerDivisionDomain.Text = "Volts/Div: 1V"
        '
        'OscilloscopeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1227, 653)
        Me.Controls.Add(Me.VoltsPerDivisionDomain)
        Me.Controls.Add(Me.RNGTextBox)
        Me.Controls.Add(Me.OffsetTextBox)
        Me.Controls.Add(Me.TimePerDivisionDomain)
        Me.Controls.Add(Me.VerticalOffsetBar)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.PBDrawing)
        Me.Name = "OscilloscopeForm"
        Me.Text = "OscilloscopeForm"
        CType(Me.PBDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalOffsetBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBDrawing As PictureBox
    Friend WithEvents DrawButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VerticalOffsetBar As TrackBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimePerDivisionDomain As DomainUpDown
    Friend WithEvents OffsetTextBox As TextBox
    Friend WithEvents RNGTextBox As TextBox
    Friend WithEvents VoltsPerDivisionDomain As DomainUpDown
End Class
