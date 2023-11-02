'Joshua Makuch
'RCET 3371
'October 27, 2023
'COM Port Settings Form
'https://github.com/JoshuaMakuch/Oscilliscope

Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Public Class COMPortSettingsForm

    Dim SelectedCOMPort As String
    Dim SelectedBaudRate As String
    Dim FileName As String = CurDir() & "\" & "COMPortSettings" & ".txt"

    'Handles the COM Port settings form load
    Private Sub COMPortSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FileOpen(1, FileName, OpenMode.Input) 'Open file for input
            Input(1, SelectedCOMPort)
            Input(1, SelectedBaudRate)
            SelectedCOMPort = SelectedCOMPort.Replace(ChrW(34), "").Trim()
            SelectedBaudRate = SelectedBaudRate.Replace(ChrW(34), "").Trim()
            COMPortSelectedTextBox.Text = SelectedCOMPort
            For i As Integer = 0 To COMBaudRateDomain.Items.Count() - 1
                If COMBaudRateDomain.Items(i) = SelectedBaudRate Then COMBaudRateDomain.SelectedIndex = i
            Next
        Catch ex As Exception
            MsgBox("Settings file not found, one has been created, please reopen settings.")
            FileClose(1)
            FileOpen(1, FileName, OpenMode.Append) 'Open file for append
            Write(1, "COM7", "9600")
            FileClose(1)
            Me.Close()
        End Try

        COMScanButton_Click(sender, e)
    End Sub

    'Handles return button press
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles COMReturnButton.Click
        Try
            FileClose(1)
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    'Handles COMPortSelectListBox Index Select
    Private Sub COMPortSelectListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMPortSelectListBox.SelectedIndexChanged
        If COMPortSelectListBox.SelectedItem <> "" Then
            SelectedCOMPort = COMPortSelectListBox.SelectedItem
            COMPortSelectedTextBox.Text = SelectedCOMPort
        End If
    End Sub

    'Handles Scan button click
    Private Sub COMScanButton_Click(sender As Object, e As EventArgs) Handles COMScanButton.Click
        COMPortSelectListBox.Items.Clear() 'Clear current list
        For Each sp As String In My.Computer.Ports.SerialPortNames
            COMPortSelectListBox.Items.Add(sp) 'add discovered port to listbox
        Next
    End Sub

    'Handles Selected Item Changed for COM Baud Rate Domain
    Private Sub COMBaudRateDomain_SelectedItemChanged(sender As Object, e As EventArgs) Handles COMBaudRateDomain.SelectedItemChanged
        Select Case COMBaudRateDomain.SelectedItem
            Case COMBaudRateDomain.Items(10)
                SelectedBaudRate = 1200
            Case COMBaudRateDomain.Items(9)
                SelectedBaudRate = 2400
            Case COMBaudRateDomain.Items(8)
                SelectedBaudRate = 4800
            Case COMBaudRateDomain.Items(7)
                SelectedBaudRate = 9600
            Case COMBaudRateDomain.Items(6)
                SelectedBaudRate = 19200
            Case COMBaudRateDomain.Items(5)
                SelectedBaudRate = 38400
            Case COMBaudRateDomain.Items(4)
                SelectedBaudRate = 57600
            Case COMBaudRateDomain.Items(3)
                SelectedBaudRate = 115200
            Case COMBaudRateDomain.Items(2)
                SelectedBaudRate = 230400
            Case COMBaudRateDomain.Items(1)
                SelectedBaudRate = 460800
            Case COMBaudRateDomain.Items(0)
                SelectedBaudRate = 921600
        End Select

    End Sub

    'Handles the save settings button click
    Private Sub COMSaveSettingsButton_Click(sender As Object, e As EventArgs) Handles COMSaveSettingsButton.Click
        Try
            FileClose(1)
            FileOpen(1, FileName, OpenMode.Output) 'Open file for append
            Write(1, SelectedCOMPort, SelectedBaudRate)
            FileClose(1)
        Catch ex As Exception
            MsgBox("File write failed.")
        End Try
    End Sub

End Class