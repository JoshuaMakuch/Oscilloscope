'Joshua Makuch
'RCET 3371
'October 17, 2023
'Oscilloscope Form
'https://github.com/JoshuaMakuch/Oscilliscope


Imports System.IO.Ports
Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class OscilloscopeForm

    Dim g As Graphics = Me.CreateGraphics
    Dim myPen As Pen = New Pen(Color.White)
    Dim GridPen As Pen = New Pen(Color.Gray)
    Dim bmp As Bitmap
    Dim RNGVal As Integer
    Dim VerticalScale As Double
    Dim LastX As Integer
    Dim LastY As Integer
    Dim NewY As Integer
    Dim DrawIterations As Integer
    Dim FileName As String = CurDir() & "\" & "COMPortSettings" & ".txt"
    Dim SelectedCOMPort As String
    Dim SelectedBaudRate As String
    Dim PortState As Boolean
    Public receiveByte(18) As Byte 'Receive Data Bytes
    Dim NewData As Integer
    Dim DataIn1, DataIn2, DataIn3, DataIn4, DataIn5, DataIn6, DataIn7, DataIn8 As Integer
    Dim AnaInVal As Integer
    Dim Records(96) As Single
    Dim MaxValue As Single
    Dim MinValue As Single

    'On Form Load
    Private Sub OscilloscopeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate picture box image property
        DrawCheckBox.Checked = False
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
        PBDrawing.BackColor = Color.Black
        DrawCheckBox.Focus()
        RNGVal = 25
        RNGTextBox.Text = "RNG Value: " & CStr(RNGVal)
        VerticalOffsetBar.Maximum = PBDrawing.Height
        VerticalOffsetBar.Value = VerticalOffsetBar.Maximum / 2 'Sets vertical offsetbar to match the picturebox on startup
        OffsetTextBox.Text = $"{(VerticalOffsetBar.Value - PBDrawing.Height / 2) / 100} V" 'Sets offset textbox to 0v
        TimePerDivisionDomain.SelectedIndex = 3 'Sets initial timer per divison to 1mS
        VoltsPerDivisionDomain.SelectedIndex = 2 'Sets initial votls per division to 1v
        VoltsPerDivisionDomain_SelectedItemChanged(sender, e)
        TimePerDivisionDomain_SelectedItemChanged(sender, e)
        DrawGrid()
        ReloadSettingsFileToolStripMenuItem_Click(sender, e)
        SerialPort1.DataBits = 8 '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None 'no parity
        MaxValue = 0 'Sets the max and min values to 0v
        MinValue = 0
        MaxRecordedValueTextBox.Text = $"{MaxValue} V"
        MinRecordedValueTextBox.Text = $"{MinValue} V"

        LastY = PBDrawing.Height / 2
    End Sub

    'THIS IS THE MAIN DRAWING CODE||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    'Exit Button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Sets the color of the drawn line, Color Button
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        'Opens a window dialog to be able to change the color as desired
        Dim myDialog As New ColorDialog()
        If (myDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            myPen.Color = myDialog.Color
        End If
        DrawCheckBox.Focus()
    End Sub

    'Clear Button
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear the picturebox and re-draw the grid, however, doesn't reset draw state
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
        DrawCheckBox.Focus()
        DrawIterations = 0
        DrawGrid()
    End Sub

    'Up Button 
    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        'Sets the RNGVal for random draw to +25 unless it exceeds the picture box height
        If RNGVal < PBDrawing.Height / 2 - 25 Then RNGVal += 25 Else RNGVal = PBDrawing.Height / 2
        RNGTextBox.Text = "RNG Value: " & CStr(RNGVal)
        VoltsPerDivisionDomain_SelectedItemChanged(sender, e)
    End Sub

    'Down Button
    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        'Sets the RNGVal for random draw to -25 unless it exceeds the picture box height
        If RNGVal > -PBDrawing.Height / 2 + 25 Then RNGVal -= 25 Else RNGVal = -PBDrawing.Height / 2
        RNGTextBox.Text = "RNG Value: " & CStr(RNGVal)
        VoltsPerDivisionDomain_SelectedItemChanged(sender, e)
    End Sub

    'Timer1 Tick Handle
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DrawCheckBox.Checked Then
            Using g As Graphics = Graphics.FromImage(PBDrawing.Image)
                If DrawIterations < PBDrawing.Width - 1 Then
                    g.DrawLine(New Pen(Color.Black), DrawIterations + 1, PBDrawing.Height, DrawIterations + 1, 0) 'This deals with drawing a black line to create a sweep effect

                    'This will draw a gridline every 10th of the picture box width
                    If DrawIterations Mod Math.Round(PBDrawing.Width / 10) = 0 Then
                        g.DrawLine(GridPen, DrawIterations, PBDrawing.Height, DrawIterations, 0)
                    End If

                    'Draws a gridline every 8th division of the picture box
                    For i As Integer = 1 To 7
                        g.DrawLine(GridPen, DrawIterations, Convert.ToSingle((Math.Round(PBDrawing.Height * i / 8))), DrawIterations + 1, Convert.ToSingle((Math.Round(PBDrawing.Height * i / 8))))
                    Next

                    'This will draw the offset line 
                    g.DrawLine(New Pen(Color.Blue), DrawIterations, -VerticalOffsetBar.Value + PBDrawing.Height, DrawIterations + 1, -VerticalOffsetBar.Value + PBDrawing.Height)

                    'This will determine if an analog value or random value will be displayed
                    If RandomRadioButton.Checked Then
                        NewY = (Rnd() * (-RNGVal * VerticalScale)) + (-VerticalOffsetBar.Value + PBDrawing.Height)
                    ElseIf AnalogRadioButton.Checked Then
                        'This ensures that the analog in value is properly scaled and drawn in the right spots according to the picture box and divisions
                        NewY = (((-AnaInVal * 3.3 / 1023) * VerticalScale) * PBDrawing.Height / 8) + (-VerticalOffsetBar.Value + PBDrawing.Height)
                    End If

                    'This records every x / record length data point 
                    Dim IndexRecord As Integer = CInt(DrawIterations / CInt(PBDrawing.Width / Records.Length))
                    If DrawIterations Mod CInt(PBDrawing.Width / Records.Length) = 0 Then
                        Records(IndexRecord) = Math.Round(-((NewY - PBDrawing.Height / 2) / VerticalScale / (PBDrawing.Height / 8)), 2)
                        MaxValue = Records.Max
                        MaxRecordedValueTextBox.Text = $"{MaxValue} V"
                        MinValue = Records.Min
                        MinRecordedValueTextBox.Text = $"{MinValue} V"
                    End If


                    'This is what actually draws the line for incoming data or random data
                    g.DrawLine(myPen, LastX, LastY, DrawIterations + 1, NewY)
                    LastX = DrawIterations
                    LastY = NewY

                    PBDrawing.Refresh()
                    DrawIterations += 1
                Else
                    DrawIterations = 0
                End If
            End Using
                        End If

                        'This portion will write analog read for channel 1 to the QY@ board
                        If PortState Then
                            Try
                                SerialPort1.Write({81}, 0, 1) 'Writes a 51h to the serialport
                            Catch ex As Exception

                            End Try

                            'This will then attempt to convert the received left-justified data bytes from the QY@ boards analog channel 1 to usable data (0-1023)
                            Try
                                AnaInVal = (Convert.ToInt32(Hex(receiveByte(0)), 16)) * 4 + (Convert.ToInt32(Hex(receiveByte(1)), 16) / 64)
                                AnalogInputTextBox.Text = CStr(Math.Round(AnaInVal * 3.3 / 1023, 2)) & " V"
                            Catch ex As Exception

                            End Try
                        End If

                        PortStateCheckBox.Checked = PortState

                        End Sub

    'Custom Sub DrawGridhandle
    Sub DrawGrid()
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
        DrawCheckBox.Focus()
        Using g As Graphics = Graphics.FromImage(PBDrawing.Image)
            For i As Integer = 1 To 9
                g.DrawLine(GridPen, Convert.ToSingle((Math.Round(PBDrawing.Width * i / 10))), 0, Convert.ToSingle((Math.Round(PBDrawing.Width * i / 10))), PBDrawing.Height)
            Next
            For i As Integer = 1 To 7
                g.DrawLine(GridPen, 0, Convert.ToSingle(Math.Round(i * PBDrawing.Height / 8)), PBDrawing.Width, Convert.ToSingle(Math.Round(i * PBDrawing.Height / 8)))
            Next
            g.DrawLine(New Pen(Color.Blue), 0, -VerticalOffsetBar.Value + PBDrawing.Height, PBDrawing.Width, -VerticalOffsetBar.Value + PBDrawing.Height)
        End Using
    End Sub

    'Handles the TimePerDivision Domain
    Private Sub TimePerDivisionDomain_SelectedItemChanged(sender As Object, e As EventArgs) Handles TimePerDivisionDomain.SelectedItemChanged
        DrawIterations = 0

        'Sets the timer1 interval based on whatever domain item is selected (also clears the picture box)
        Select Case TimePerDivisionDomain.SelectedItem
            Case TimePerDivisionDomain.Items(3)
                Timer1.Interval = 1
            Case TimePerDivisionDomain.Items(2)
                Timer1.Interval = 10
            Case TimePerDivisionDomain.Items(1)
                Timer1.Interval = 100
            Case TimePerDivisionDomain.Items(0)
                Timer1.Interval = 1000
        End Select

        ClearButton_Click(sender, e)

    End Sub

    'Handles the draw checkbox check changed
    Private Sub DrawCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DrawCheckBox.CheckedChanged
        'This helps to identify if the form is in a drawing state or not
        DrawIterations = 0
        If DrawCheckBox.Checked Then
            DrawCheckBox.Text = "Drawing"
        Else
            DrawCheckBox.Text = "Draw"
        End If
    End Sub

    'Handles the VoltsPerDivision Domain
    Private Sub VoltsPerDivisionDomain_SelectedItemChanged(sender As Object, e As EventArgs) Handles VoltsPerDivisionDomain.SelectedItemChanged
        DrawIterations = 0

        'Sets the voltage scale based on whatever domain item is selected (also clears the picture box)

        Select Case VoltsPerDivisionDomain.SelectedItem
            Case VoltsPerDivisionDomain.Items(4)
                VerticalScale = 10
            Case VoltsPerDivisionDomain.Items(3)
                VerticalScale = 2
            Case VoltsPerDivisionDomain.Items(2)
                VerticalScale = 1
            Case VoltsPerDivisionDomain.Items(1)
                VerticalScale = 0.5
            Case VoltsPerDivisionDomain.Items(0)
                VerticalScale = 0.1
        End Select

        ClearButton_Click(sender, e)

    End Sub

    'Handles the Vertical Offset Bar scroll
    Private Sub VerticalOffsetBar_Scroll(sender As Object, e As EventArgs) Handles VerticalOffsetBar.Scroll
        'Sets the offset bar textbox
        OffsetTextBox.Text = $"{Math.Round((VerticalOffsetBar.Value - PBDrawing.Height / 2) / 100 / VerticalScale,2)} V"
                            'This allows the offset line to be live adjusted when not drawing
                            If Not DrawCheckBox.Checked Then DrawGrid()
    End Sub

    'Goes to COM Port settings form
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        COMPortSettingsForm.Show()
    End Sub

    'Handles reload settings file tool strip menu item click
    Private Sub ReloadSettingsFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadSettingsFileToolStripMenuItem.Click
        'Attempt to reload the Com port settings file, if not declare a lack of settings file
        Try
            FileOpen(1, FileName, OpenMode.Input) 'Open file for input
            Input(1, SelectedCOMPort)
            Input(1, SelectedBaudRate)
            FileClose(1)
            SelectedCOMPort = SelectedCOMPort.Replace(ChrW(34), "").Trim()
            SelectedBaudRate = SelectedBaudRate.Replace(ChrW(34), "").Trim()
            COMPortTextBox.Text = SelectedCOMPort
            BaudRateTextBox.Text = SelectedBaudRate
        Catch ex As Exception
            FileClose(1)
            MsgBox("Settings file not found, one has been created, please reopen settings.")
        End Try
    End Sub

    'Handles the connect tool strip menu item click
    Private Sub ConnectToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        'Will attempt to connect to the serial port if not alread connected
        If Not PortState Then
            If SelectedBaudRate <> "" Then SerialPort1.BaudRate = SelectedBaudRate
            If SelectedCOMPort <> "" Then SerialPort1.PortName = SelectedCOMPort
            Try
                SerialPort1.Open()
                PortState = True
                ConnectToolStripMenuItem.Text = "Disconnect"
            Catch ex As Exception
                PortState = False
                MsgBox("Port Already Open Or Port Unavailable. Potentially try reload settings file in menu strip.")
            End Try
        Else 'If already connected then assume the user is trying to DC when pressing this again, attempt to disconnect
            Try
                SerialPort1.Close()
                PortState = False
                ConnectToolStripMenuItem.Text = "Connect"
            Catch ex As Exception
                PortState = True
                MsgBox("Port Close Failed")
            End Try
        End If
    End Sub

    'On Form unload, close the port as to not have it stuck open and inaccessible
    Private Sub OscilloscopeForm_UnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SerialPort1.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Whenever the com port says we have information
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        'This allows the input buffer to be filled, once it has `10mS later, it will push the data to receivebyte()
        Thread.Sleep(10)
        SerialPort1.Read(receiveByte, 0, 8) 'This receives new data from the serial port

        Select Case NewData
            Case = 0
                DataIn1 = receiveByte(0)
            Case = 1
                DataIn2 = receiveByte(0)
            Case = 2
                DataIn3 = receiveByte(0)
            Case = 3
                DataIn4 = receiveByte(0)
            Case = 4
                DataIn5 = receiveByte(0)
            Case = 5
                DataIn6 = receiveByte(0)
            Case = 6
                DataIn7 = receiveByte(0)
            Case = 7
                DataIn8 = receiveByte(0)
            Case Else
                NewData = 0
                Exit Sub
        End Select

        NewData += 1

        SerialPort1.DiscardInBuffer()

    End Sub

End Class

