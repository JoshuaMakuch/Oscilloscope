'Joshua Makuch
'RCET 3371
'October 17, 2023
'Oscilloscope Form
'https://github.com/JoshuaMakuch/Oscilliscope


Public Class OscilloscopeForm

    Dim g As Graphics = Me.CreateGraphics
    Dim myPen As Pen = New Pen(Color.White)
    Dim GridPen As Pen = New Pen(Color.Gray)
    Dim bmp As Bitmap
    Dim RNGVal As Integer
    Dim DrawnScale As Integer
    Dim LastX As Integer
    Dim LastY As Integer
    Dim NewX As Integer
    Dim NewY As Integer
    Dim Draw As Boolean = False
    Dim DrawIterations As Integer

    'On Form Load
    Private Sub OscilloscopeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate picture box image property
        Draw = False
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
        PBDrawing.BackColor = Color.Black
        DrawButton().Focus()
        RNGVal = 25
        RNGTextBox.Text = "RNG Value: " & CStr(RNGVal)
        VerticalOffsetBar.Maximum = PBDrawing.Height
        VerticalOffsetBar.Value = VerticalOffsetBar.Maximum / 2
        OffsetTextBox.Text = $"{(VerticalOffsetBar.Value - PBDrawing.Height / 2) / 100} V"
        TimePerDivisionDomain.SelectedIndex = 3
        VoltsPerDivisionDomain.SelectedIndex = 2
        VoltsPerDivisionDomain_SelectedItemChanged(sender, e)
        TimePerDivisionDomain_SelectedItemChanged(sender, e)
        DrawGrid()
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
        DrawButton().Focus()
    End Sub

    'Clear Button
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
        DrawButton().Focus()
        Draw = False
        DrawGrid()
    End Sub

    'Draw Waveform Button
    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click

        Draw = True
        DrawIterations = 0

    End Sub

    'Up Button 
    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        If RNGVal < PBDrawing.Height / 2 - 25 Then RNGVal += 25 Else RNGVal = PBDrawing.Height / 2
        RNGTextBox.Text = "RNG Value: " & CStr(RNGVal)
        VoltsPerDivisionDomain_SelectedItemChanged(sender, e)
    End Sub

    'Down Button
    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        If RNGVal > -PBDrawing.Height / 2 + 25 Then RNGVal -= 25 Else RNGVal = -PBDrawing.Height / 2
        RNGTextBox.Text = "RNG Value: " & CStr(RNGVal)
        VoltsPerDivisionDomain_SelectedItemChanged(sender, e)
    End Sub

    'Timer1 Tick Handle
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Draw Then
            Using g As Graphics = Graphics.FromImage(PBDrawing.Image)
                If DrawIterations < PBDrawing.Width - 1 Then
                    g.DrawLine(New Pen(Color.Black), DrawIterations + 1, PBDrawing.Height, DrawIterations + 1, 0)

                    If DrawIterations Mod Math.Round(PBDrawing.Width / 10) = 0 Then
                        g.DrawLine(GridPen, DrawIterations, PBDrawing.Height, DrawIterations, 0)
                    End If

                    For i As Integer = 1 To 7
                        g.DrawLine(GridPen, DrawIterations, Convert.ToSingle((Math.Round(PBDrawing.Height * i / 8))), DrawIterations + 1, Convert.ToSingle((Math.Round(PBDrawing.Height * i / 8))))
                    Next

                    g.DrawLine(New Pen(Color.Blue), DrawIterations, -VerticalOffsetBar.Value + PBDrawing.Height, DrawIterations + 1, -VerticalOffsetBar.Value + PBDrawing.Height)
                    NewY = (Rnd() * (-DrawnScale)) + (-VerticalOffsetBar.Value + PBDrawing.Height)
                    g.DrawLine(myPen, DrawIterations, LastY, DrawIterations + 1, NewY)
                    LastY = NewY
                    PBDrawing.Refresh()
                    DrawIterations += 1

                Else
                    Draw = False
                    DrawIterations = 0
                End If
            End Using
        End If
    End Sub

    'Custom Sub DrawGridhandle
    Sub DrawGrid()
        bmp = New Bitmap(PBDrawing.Width, PBDrawing.Height) 'Sets the bitmap to be the size of the picture box
        PBDrawing.Image = bmp
        DrawButton().Focus()
        Draw = False
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
    End Sub

    'Handles the VoltsPerDivision Domain
    Private Sub VoltsPerDivisionDomain_SelectedItemChanged(sender As Object, e As EventArgs) Handles VoltsPerDivisionDomain.SelectedItemChanged
        DrawIterations = 0

        Select Case VoltsPerDivisionDomain.SelectedItem
            Case VoltsPerDivisionDomain.Items(4)
                DrawnScale = RNGVal * 10
            Case VoltsPerDivisionDomain.Items(3)
                DrawnScale = RNGVal * 2
            Case VoltsPerDivisionDomain.Items(2)
                DrawnScale = RNGVal
            Case VoltsPerDivisionDomain.Items(1)
                DrawnScale = RNGVal / 2
            Case VoltsPerDivisionDomain.Items(0)
                DrawnScale = RNGVal / 5
        End Select

    End Sub

    'Handles the Vertical Offset Bar scroll
    Private Sub VerticalOffsetBar_Scroll(sender As Object, e As EventArgs) Handles VerticalOffsetBar.Scroll
        OffsetTextBox.Text = $"{(VerticalOffsetBar.Value - PBDrawing.Height / 2) / 100} V"
        If Not Draw Then DrawGrid()
    End Sub

End Class


