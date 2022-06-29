Imports System
Imports System.IO.Ports
Public Class Form1

    Dim ComPORT As String
    Dim ReceivedData As String = ""
    Dim Daud As String
    Dim Sys_Data, Log_file, Log_fileName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Log_fileName = TextBox_LogFile.Text
        Log_file = "C:\" + Log_fileName

        Rest_COM_DATA()

    End Sub

    Private Sub Rest_Click(sender As Object, e As EventArgs) Handles Rest.Click
        ComboBox_PORT.Text = ""
        ComboBox_PORT.Items.Clear()

        Rest_COM_DATA()

        If (Button1.Text = "Connect") Then

        Else
            SerialPort1.Close()
            Button1.ForeColor = Color.Black
            Button1.Text = "Connect"
            Timer1.Enabled = False
            Timer_LAB.ForeColor = Color.Black
            Timer_LAB.Text = "Timer: OFF"
            Tool_switch_ON()

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

        If (TextBox_LogFile.Text = "") Then 'DeBug
            TextBox_LogFile.Text = "Arduino_I2C_log"
        End If


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
                Tool_switch_OFF()
            Else

                '  MsgBox("Select a COM port first")
                MsgBox("Select a COM port first", vbExclamation, "Com Prot Error!!!")
                ComboBox_PORT.Items.Clear()
                Rest_COM_DATA()

            End If
        Else
            SerialPort1.Close()
            Button1.ForeColor = Color.Black
            Button1.Text = "Connect"
            Timer1.Enabled = False
            Timer_LAB.ForeColor = Color.Black
            Timer_LAB.Text = "Timer： OFF"
            Tool_switch_ON()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Sys_Data = Format(Now, "yyyy-MM-dd  HH:mm:ss    ")
        ReceivedData = ReceiveSerialData()
        If (ReceivedData = "") Then '過濾不要的空白
        Else
            RichTextBox1.Text &= Sys_Data 'Format(Now, "yyyy-MM-dd  HH:mm:ss    ")

            Data_Storage()

        End If
        RichTextBox1.Text &= ReceivedData

        ' Label2.Text = Format(Now, "yyyy-mm-dd  ") + TimeString
        Label2.Text = Sys_Data 'Format(Now, "yyyy-MM-dd  HH:mm:ss    ")



    End Sub

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

    Private Sub Button_LOG_Click(sender As Object, e As EventArgs) Handles Button_LOG.Click
        Label_Log_file.Text = Log_file + "\" '顯示當前 Log file save as ...?

        If (Button_LOG.Text = "Log setting") Then
            Button_LOG.ForeColor = Color.Red
            Button_LOG.Text = "Close log setting"
            RichTextBox1.Visible = False
        Else
            Button_LOG.ForeColor = Color.Blue
            Button_LOG.Text = "Log setting"
            RichTextBox1.Visible = True
        End If


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

    Private Sub Rest_COM_DATA()  '用來讀取COM_PORT
        ComPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_PORT.Items.Add(sp)
        Next
    End Sub


    Private Sub LOG_SETTING_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LOG_SETTING_CheckBox.CheckedChanged

        If (Label1.ForeColor = Color.Gray) Then
            Label1.ForeColor = Color.Black
            TextBox_LogFile.Enabled = True
            TextBox_LogFile.ForeColor = Color.Black
        Else
            Label1.ForeColor = Color.Gray
            TextBox_LogFile.ForeColor = Color.Gray
            TextBox_LogFile.Enabled = False
        End If




    End Sub


    Private Sub TextBox_LogFile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_LogFile.KeyPress
        If e.KeyChar = Chr(47) Or e.KeyChar = Chr(42) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(58) Or e.KeyChar = Chr(60) Or e.KeyChar = Chr(62) Then
            e.Handled = True
        Else
            e.Handled = False

        End If
    End Sub




    Private Sub TextBox_LogFile_TextChanged(sender As Object, e As EventArgs) Handles TextBox_LogFile.TextChanged

        Log_fileName = TextBox_LogFile.Text
        Log_file = "C:\" + Log_fileName
        Label_Log_file.Text = Log_file + "\"
    End Sub

    Private Sub Tool_switch_OFF()
        ComboBox_PORT.Enabled = False
        GroupBox2.Enabled = False
        GroupBox_Baud2.Enabled = False
        GroupBox_Baud1.Enabled = False
    End Sub

    Private Sub Tool_switch_ON()
        ComboBox_PORT.Enabled = True
        GroupBox2.Enabled = True
        GroupBox_Baud2.Enabled = True
        GroupBox_Baud1.Enabled = True
    End Sub


    Private Sub Data_Storage()  '
        ' https://blog.xuite.net/xiaolian/blog/44552797
        ' OpenMode.Input從檔案中讀取字元， 這是已經存在的檔案， 程式需要使用Try /End Try錯誤處理避免開啟不存在的檔案
        ' OpenMode.Output：將字元寫入檔案， 如果檔案不存在， 就建立此檔案， 如果檔案已有內容會清除內容
        ' OpenMode.Append：將字元寫入檔案結尾的最後， 它不會清除檔案內容， 只是加在最後， 如果檔案不存在， 就建立此檔案

        Dim FileNum As Integer
        Dim strTemp As String
        Dim FileData As String
        FileData = Format(Now, "yyyy-MM-dd")
        FileNum = FreeFile()



        If Len(Dir(Log_file, vbDirectory)) = 0 Then '如果沒有資料夾
            MkDir(Log_file) '製造Arduino_I2C File
        Else


        End If


        If (CheckBox_LOG.Checked = True) Then 'LOG產生方式
            FileOpen(FileNum, Log_file + "\Arduino_" + FileData + ".txt", OpenMode.Append)
            strTemp = Sys_Data + vbCrLf + ReceivedData + vbCrLf
            PrintLine(FileNum, strTemp)
            FileClose(FileNum)

        Else
            ' MsgBox("檔案不存在")
        End If



        ' If System.IO.File.Exists("C:\Arduino_I2C\") Then
        'MsgBox("檔案存在")
        '  Else
        '  MsgBox("檔案不存在")
        ' End If


    End Sub

End Class
