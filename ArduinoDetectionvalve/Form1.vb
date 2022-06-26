Imports System
Imports System.IO.Ports
Public Class Form1

    Dim ComPORT As String
    Dim ReceivedData As String = ""
    Dim Daud As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        ComPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_PORT.Items.Add(sp)
        Next

    End Sub

    Private Sub Rest_Click(sender As Object, e As EventArgs) Handles Rest.Click
        ComboBox_PORT.Text = ""
        ComPORT = ""
        ComboBox_PORT.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_PORT.Items.Add(sp)
        Next

        If (Button1.Text = "Connect") Then

        Else
            SerialPort1.Close()
            Button1.ForeColor = Color.Black
            Button1.Text = "Connect"
            Timer1.Enabled = False
            Timer_LAB.ForeColor = Color.Black
            Timer_LAB.Text = "Timer: OFF"
        End If


    End Sub

    Private Sub ComboBox_PORT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_PORT.SelectedIndexChanged



        If (ComboBox_PORT.SelectedItem <> "") Then
            ComPORT = ComboBox_PORT.SelectedItem
        End If

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label_Baud.Visible = True
        Label_Baud.Text = "Baud：" + Daud

        If (Button1.Text = "Connect") Then
            If (ComPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = ComPORT
                SerialPort1.BaudRate = Daud '讀取baud
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                Button1.ForeColor = Color.Green

                Button1.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LAB.ForeColor = Color.Green
                Timer_LAB.Text = "Timer： ON"
            Else

                '  MsgBox("Select a COM port first")
                MsgBox("Select a COM port first", vbExclamation, "Com Prot Error!!!")


                '  ComPORT = ""
                ComboBox_PORT.Items.Clear()
                For Each sp As String In My.Computer.Ports.SerialPortNames
                    ComboBox_PORT.Items.Add(sp)
                Next

            End If
        Else
            SerialPort1.Close()
            Button1.ForeColor = Color.Black
            Button1.Text = "Connect"
            Timer1.Enabled = False
            Timer_LAB.ForeColor = Color.Black
            Timer_LAB.Text = "Timer： OFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ReceivedData = ReceiveSerialData()
        If (ReceivedData = "") Then '過濾不要的空白

        Else
            RichTextBox1.Text &= Format(Now, "yyyy-MM-dd  HH:mm:ss    ")
        End If
        RichTextBox1.Text &= ReceivedData


        ' Label2.Text = Format(Now, "yyyy-mm-dd  ") + TimeString
        Label2.Text = Format(Now, "yyyy-MM-dd  HH:mm:ss    ")

    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged


        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton_9600.Checked = False
        RadioButton_19200.Checked = False
        RadioButton_115200.Checked = False
        Daud = "1"
        TextBox_Baud.Text = ""
        GroupBox_Baud1.Visible = False
        GroupBox_Baud2.Visible = True
    End Sub

    Private Sub RadioButton_9600_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_9600.CheckedChanged
        Daud = 9600
    End Sub

    Private Sub RadioButton_19200_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_19200.CheckedChanged
        Daud = 19200
    End Sub

    Private Sub RadioButton_115200_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_115200.CheckedChanged
        Daud = 115200
    End Sub

    Private Sub TextBox_Baud_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Baud.TextChanged


        If (TextBox_Baud.Text = "") Then  'DeBug
            Daud = 1
        ElseIf (TextBox_Baud.Text <= 0) Then
            Daud = 1
            TextBox_Baud.Text = ""
        Else
            Daud = TextBox_Baud.Text
        End If
    End Sub
    Private Sub TextBox_Baud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Baud.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RadioButton_9600.Checked = True
        GroupBox_Baud1.Visible = True
        GroupBox_Baud2.Visible = False
    End Sub


End Class
