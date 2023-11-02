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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComPortSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadSettingsFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.AnalogInputTextBox = New System.Windows.Forms.TextBox()
        Me.AnaloginputLabel = New System.Windows.Forms.Label()
        Me.COMPortLabel = New System.Windows.Forms.Label()
        Me.COMPortTextBox = New System.Windows.Forms.TextBox()
        Me.BaudRateLabel = New System.Windows.Forms.Label()
        Me.BaudRateTextBox = New System.Windows.Forms.TextBox()
        Me.PortStateCheckBox = New System.Windows.Forms.CheckBox()
        Me.RandomRadioButton = New System.Windows.Forms.RadioButton()
        Me.AnalogRadioButton = New System.Windows.Forms.RadioButton()
        Me.DrawControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DrawCheckBox = New System.Windows.Forms.CheckBox()
        Me.MinRecordedValueLabel = New System.Windows.Forms.Label()
        Me.MinRecordedValueTextBox = New System.Windows.Forms.TextBox()
        Me.MaxValueLabel = New System.Windows.Forms.Label()
        Me.MaxRecordedValueTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PBDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalOffsetBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.DrawControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBDrawing
        '
        Me.PBDrawing.BackColor = System.Drawing.SystemColors.ControlText
        Me.PBDrawing.Location = New System.Drawing.Point(73, 49)
        Me.PBDrawing.Name = "PBDrawing"
        Me.PBDrawing.Size = New System.Drawing.Size(1000, 500)
        Me.PBDrawing.TabIndex = 0
        Me.PBDrawing.TabStop = False
        '
        'SelectColorButton
        '
        Me.SelectColorButton.BackColor = System.Drawing.SystemColors.Control
        Me.SelectColorButton.Location = New System.Drawing.Point(1079, 133)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(136, 78)
        Me.SelectColorButton.TabIndex = 2
        Me.SelectColorButton.Text = "Select Waveform Color"
        Me.SelectColorButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1079, 563)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 78)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearButton.Location = New System.Drawing.Point(1079, 217)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(136, 78)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'UpButton
        '
        Me.UpButton.Location = New System.Drawing.Point(1079, 301)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(136, 78)
        Me.UpButton.TabIndex = 5
        Me.UpButton.Text = "RNG Up"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Location = New System.Drawing.Point(1078, 385)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(136, 78)
        Me.DownButton.TabIndex = 6
        Me.DownButton.Text = "RNG Down"
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
        Me.VerticalOffsetBar.Location = New System.Drawing.Point(11, 40)
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
        Me.TimePerDivisionDomain.Location = New System.Drawing.Point(1078, 497)
        Me.TimePerDivisionDomain.Name = "TimePerDivisionDomain"
        Me.TimePerDivisionDomain.ReadOnly = True
        Me.TimePerDivisionDomain.Size = New System.Drawing.Size(136, 22)
        Me.TimePerDivisionDomain.TabIndex = 9
        '
        'OffsetTextBox
        '
        Me.OffsetTextBox.Location = New System.Drawing.Point(11, 563)
        Me.OffsetTextBox.Name = "OffsetTextBox"
        Me.OffsetTextBox.Size = New System.Drawing.Size(56, 22)
        Me.OffsetTextBox.TabIndex = 10
        '
        'RNGTextBox
        '
        Me.RNGTextBox.Location = New System.Drawing.Point(1078, 469)
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
        Me.VoltsPerDivisionDomain.Location = New System.Drawing.Point(1078, 525)
        Me.VoltsPerDivisionDomain.Name = "VoltsPerDivisionDomain"
        Me.VoltsPerDivisionDomain.ReadOnly = True
        Me.VoltsPerDivisionDomain.Size = New System.Drawing.Size(136, 22)
        Me.VoltsPerDivisionDomain.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComPortSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1227, 30)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComPortSettingsToolStripMenuItem
        '
        Me.ComPortSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ReloadSettingsFileToolStripMenuItem})
        Me.ComPortSettingsToolStripMenuItem.Name = "ComPortSettingsToolStripMenuItem"
        Me.ComPortSettingsToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.ComPortSettingsToolStripMenuItem.Text = "COM Port Settings"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ReloadSettingsFileToolStripMenuItem
        '
        Me.ReloadSettingsFileToolStripMenuItem.Name = "ReloadSettingsFileToolStripMenuItem"
        Me.ReloadSettingsFileToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.ReloadSettingsFileToolStripMenuItem.Text = "Reload Settings File"
        '
        'SerialPort1
        '
        '
        'AnalogInputTextBox
        '
        Me.AnalogInputTextBox.Location = New System.Drawing.Point(15, 607)
        Me.AnalogInputTextBox.Name = "AnalogInputTextBox"
        Me.AnalogInputTextBox.ReadOnly = True
        Me.AnalogInputTextBox.Size = New System.Drawing.Size(114, 22)
        Me.AnalogInputTextBox.TabIndex = 15
        '
        'AnaloginputLabel
        '
        Me.AnaloginputLabel.AutoSize = True
        Me.AnaloginputLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AnaloginputLabel.Location = New System.Drawing.Point(12, 588)
        Me.AnaloginputLabel.Name = "AnaloginputLabel"
        Me.AnaloginputLabel.Size = New System.Drawing.Size(84, 16)
        Me.AnaloginputLabel.TabIndex = 16
        Me.AnaloginputLabel.Text = "Analog Input:"
        '
        'COMPortLabel
        '
        Me.COMPortLabel.AutoSize = True
        Me.COMPortLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.COMPortLabel.Location = New System.Drawing.Point(956, 556)
        Me.COMPortLabel.Name = "COMPortLabel"
        Me.COMPortLabel.Size = New System.Drawing.Size(67, 16)
        Me.COMPortLabel.TabIndex = 18
        Me.COMPortLabel.Text = "COM Port:"
        '
        'COMPortTextBox
        '
        Me.COMPortTextBox.Location = New System.Drawing.Point(959, 575)
        Me.COMPortTextBox.Name = "COMPortTextBox"
        Me.COMPortTextBox.ReadOnly = True
        Me.COMPortTextBox.Size = New System.Drawing.Size(114, 22)
        Me.COMPortTextBox.TabIndex = 17
        '
        'BaudRateLabel
        '
        Me.BaudRateLabel.AutoSize = True
        Me.BaudRateLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BaudRateLabel.Location = New System.Drawing.Point(956, 600)
        Me.BaudRateLabel.Name = "BaudRateLabel"
        Me.BaudRateLabel.Size = New System.Drawing.Size(74, 16)
        Me.BaudRateLabel.TabIndex = 20
        Me.BaudRateLabel.Text = "Baud Rate:"
        '
        'BaudRateTextBox
        '
        Me.BaudRateTextBox.Location = New System.Drawing.Point(959, 619)
        Me.BaudRateTextBox.Name = "BaudRateTextBox"
        Me.BaudRateTextBox.ReadOnly = True
        Me.BaudRateTextBox.Size = New System.Drawing.Size(114, 22)
        Me.BaudRateTextBox.TabIndex = 19
        '
        'PortStateCheckBox
        '
        Me.PortStateCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.PortStateCheckBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PortStateCheckBox.Enabled = False
        Me.PortStateCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PortStateCheckBox.Location = New System.Drawing.Point(855, 556)
        Me.PortStateCheckBox.Name = "PortStateCheckBox"
        Me.PortStateCheckBox.Size = New System.Drawing.Size(95, 85)
        Me.PortStateCheckBox.TabIndex = 21
        Me.PortStateCheckBox.Text = "Port State"
        Me.PortStateCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PortStateCheckBox.UseVisualStyleBackColor = False
        '
        'RandomRadioButton
        '
        Me.RandomRadioButton.AutoSize = True
        Me.RandomRadioButton.Checked = True
        Me.RandomRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.RandomRadioButton.Name = "RandomRadioButton"
        Me.RandomRadioButton.Size = New System.Drawing.Size(114, 20)
        Me.RandomRadioButton.TabIndex = 22
        Me.RandomRadioButton.TabStop = True
        Me.RandomRadioButton.Text = "Random Draw"
        Me.RandomRadioButton.UseVisualStyleBackColor = True
        '
        'AnalogRadioButton
        '
        Me.AnalogRadioButton.AutoSize = True
        Me.AnalogRadioButton.Location = New System.Drawing.Point(6, 47)
        Me.AnalogRadioButton.Name = "AnalogRadioButton"
        Me.AnalogRadioButton.Size = New System.Drawing.Size(105, 20)
        Me.AnalogRadioButton.TabIndex = 23
        Me.AnalogRadioButton.Text = "Analog Draw"
        Me.AnalogRadioButton.UseVisualStyleBackColor = True
        '
        'DrawControlsGroupBox
        '
        Me.DrawControlsGroupBox.Controls.Add(Me.AnalogRadioButton)
        Me.DrawControlsGroupBox.Controls.Add(Me.RandomRadioButton)
        Me.DrawControlsGroupBox.Location = New System.Drawing.Point(723, 556)
        Me.DrawControlsGroupBox.Name = "DrawControlsGroupBox"
        Me.DrawControlsGroupBox.Size = New System.Drawing.Size(126, 85)
        Me.DrawControlsGroupBox.TabIndex = 24
        Me.DrawControlsGroupBox.TabStop = False
        Me.DrawControlsGroupBox.Text = "Draw Controls"
        '
        'DrawCheckBox
        '
        Me.DrawCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.DrawCheckBox.BackColor = System.Drawing.SystemColors.Control
        Me.DrawCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DrawCheckBox.Location = New System.Drawing.Point(1079, 49)
        Me.DrawCheckBox.Name = "DrawCheckBox"
        Me.DrawCheckBox.Size = New System.Drawing.Size(136, 78)
        Me.DrawCheckBox.TabIndex = 25
        Me.DrawCheckBox.Text = "Draw"
        Me.DrawCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DrawCheckBox.UseVisualStyleBackColor = False
        '
        'MinRecordedValueLabel
        '
        Me.MinRecordedValueLabel.AutoSize = True
        Me.MinRecordedValueLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MinRecordedValueLabel.Location = New System.Drawing.Point(135, 600)
        Me.MinRecordedValueLabel.Name = "MinRecordedValueLabel"
        Me.MinRecordedValueLabel.Size = New System.Drawing.Size(136, 16)
        Me.MinRecordedValueLabel.TabIndex = 29
        Me.MinRecordedValueLabel.Text = "Min Recorded Value: "
        '
        'MinRecordedValueTextBox
        '
        Me.MinRecordedValueTextBox.Location = New System.Drawing.Point(138, 619)
        Me.MinRecordedValueTextBox.Name = "MinRecordedValueTextBox"
        Me.MinRecordedValueTextBox.ReadOnly = True
        Me.MinRecordedValueTextBox.Size = New System.Drawing.Size(141, 22)
        Me.MinRecordedValueTextBox.TabIndex = 28
        '
        'MaxValueLabel
        '
        Me.MaxValueLabel.AutoSize = True
        Me.MaxValueLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MaxValueLabel.Location = New System.Drawing.Point(135, 556)
        Me.MaxValueLabel.Name = "MaxValueLabel"
        Me.MaxValueLabel.Size = New System.Drawing.Size(137, 16)
        Me.MaxValueLabel.TabIndex = 27
        Me.MaxValueLabel.Text = "Max Recorded Value:"
        '
        'MaxRecordedValueTextBox
        '
        Me.MaxRecordedValueTextBox.Location = New System.Drawing.Point(138, 575)
        Me.MaxRecordedValueTextBox.Name = "MaxRecordedValueTextBox"
        Me.MaxRecordedValueTextBox.ReadOnly = True
        Me.MaxRecordedValueTextBox.Size = New System.Drawing.Size(141, 22)
        Me.MaxRecordedValueTextBox.TabIndex = 26
        '
        'OscilloscopeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1227, 653)
        Me.Controls.Add(Me.MinRecordedValueLabel)
        Me.Controls.Add(Me.MinRecordedValueTextBox)
        Me.Controls.Add(Me.MaxValueLabel)
        Me.Controls.Add(Me.MaxRecordedValueTextBox)
        Me.Controls.Add(Me.DrawCheckBox)
        Me.Controls.Add(Me.DrawControlsGroupBox)
        Me.Controls.Add(Me.PortStateCheckBox)
        Me.Controls.Add(Me.BaudRateLabel)
        Me.Controls.Add(Me.BaudRateTextBox)
        Me.Controls.Add(Me.COMPortLabel)
        Me.Controls.Add(Me.COMPortTextBox)
        Me.Controls.Add(Me.AnaloginputLabel)
        Me.Controls.Add(Me.AnalogInputTextBox)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.Controls.Add(Me.PBDrawing)
        Me.Name = "OscilloscopeForm"
        Me.Text = "OscilloscopeForm"
        CType(Me.PBDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalOffsetBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DrawControlsGroupBox.ResumeLayout(False)
        Me.DrawControlsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBDrawing As PictureBox
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComPortSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents AnalogInputTextBox As TextBox
    Friend WithEvents AnaloginputLabel As Label
    Friend WithEvents COMPortLabel As Label
    Friend WithEvents COMPortTextBox As TextBox
    Friend WithEvents BaudRateLabel As Label
    Friend WithEvents BaudRateTextBox As TextBox
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadSettingsFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PortStateCheckBox As CheckBox
    Friend WithEvents RandomRadioButton As RadioButton
    Friend WithEvents AnalogRadioButton As RadioButton
    Friend WithEvents DrawControlsGroupBox As GroupBox
    Friend WithEvents DrawCheckBox As CheckBox
    Friend WithEvents MinRecordedValueLabel As Label
    Friend WithEvents MinRecordedValueTextBox As TextBox
    Friend WithEvents MaxValueLabel As Label
    Friend WithEvents MaxRecordedValueTextBox As TextBox
End Class
