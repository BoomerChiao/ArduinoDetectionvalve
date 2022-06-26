<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox_PORT = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer_LAB = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Rest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_9600 = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Baud1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton_115200 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_19200 = New System.Windows.Forms.RadioButton()
        Me.Label_Baud = New System.Windows.Forms.Label()
        Me.TextBox_Baud = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox_Baud2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_Baud1.SuspendLayout()
        Me.GroupBox_Baud2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'ComboBox_PORT
        '
        Me.ComboBox_PORT.BackColor = System.Drawing.Color.White
        Me.ComboBox_PORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_PORT.FormattingEnabled = True
        Me.ComboBox_PORT.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox_PORT.Name = "ComboBox_PORT"
        Me.ComboBox_PORT.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_PORT.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(128, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer_LAB
        '
        Me.Timer_LAB.AutoSize = True
        Me.Timer_LAB.Location = New System.Drawing.Point(6, 46)
        Me.Timer_LAB.Name = "Timer_LAB"
        Me.Timer_LAB.Size = New System.Drawing.Size(74, 15)
        Me.Timer_LAB.TabIndex = 3
        Me.Timer_LAB.Text = "Timer：OFF"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(240, 52)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(280, 386)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Rest
        '
        Me.Rest.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rest.Location = New System.Drawing.Point(128, 43)
        Me.Rest.Name = "Rest"
        Me.Rest.Size = New System.Drawing.Size(88, 23)
        Me.Rest.TabIndex = 5
        Me.Rest.Text = "REST"
        Me.Rest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_Baud)
        Me.GroupBox1.Controls.Add(Me.ComboBox_PORT)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Timer_LAB)
        Me.GroupBox1.Controls.Add(Me.Rest)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 75)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Com Port"
        '
        'RadioButton_9600
        '
        Me.RadioButton_9600.AutoSize = True
        Me.RadioButton_9600.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton_9600.Checked = True
        Me.RadioButton_9600.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadioButton_9600.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton_9600.Name = "RadioButton_9600"
        Me.RadioButton_9600.Size = New System.Drawing.Size(53, 19)
        Me.RadioButton_9600.TabIndex = 10
        Me.RadioButton_9600.TabStop = True
        Me.RadioButton_9600.Text = "9600"
        Me.RadioButton_9600.UseVisualStyleBackColor = False
        '
        'GroupBox_Baud1
        '
        Me.GroupBox_Baud1.Controls.Add(Me.Button2)
        Me.GroupBox_Baud1.Controls.Add(Me.RadioButton_115200)
        Me.GroupBox_Baud1.Controls.Add(Me.RadioButton_19200)
        Me.GroupBox_Baud1.Controls.Add(Me.RadioButton_9600)
        Me.GroupBox_Baud1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Baud1.Location = New System.Drawing.Point(240, 9)
        Me.GroupBox_Baud1.Name = "GroupBox_Baud1"
        Me.GroupBox_Baud1.Size = New System.Drawing.Size(280, 41)
        Me.GroupBox_Baud1.TabIndex = 11
        Me.GroupBox_Baud1.TabStop = False
        Me.GroupBox_Baud1.Text = "Serial communication (Baud)"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Other baud rates"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton_115200
        '
        Me.RadioButton_115200.AutoSize = True
        Me.RadioButton_115200.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton_115200.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton_115200.Location = New System.Drawing.Point(118, 17)
        Me.RadioButton_115200.Name = "RadioButton_115200"
        Me.RadioButton_115200.Size = New System.Drawing.Size(66, 19)
        Me.RadioButton_115200.TabIndex = 12
        Me.RadioButton_115200.Text = "115200"
        Me.RadioButton_115200.UseVisualStyleBackColor = False
        '
        'RadioButton_19200
        '
        Me.RadioButton_19200.AutoSize = True
        Me.RadioButton_19200.Location = New System.Drawing.Point(59, 17)
        Me.RadioButton_19200.Name = "RadioButton_19200"
        Me.RadioButton_19200.Size = New System.Drawing.Size(60, 19)
        Me.RadioButton_19200.TabIndex = 11
        Me.RadioButton_19200.Text = "19200"
        Me.RadioButton_19200.UseVisualStyleBackColor = True
        '
        'Label_Baud
        '
        Me.Label_Baud.AutoSize = True
        Me.Label_Baud.Location = New System.Drawing.Point(6, 60)
        Me.Label_Baud.Name = "Label_Baud"
        Me.Label_Baud.Size = New System.Drawing.Size(55, 15)
        Me.Label_Baud.TabIndex = 12
        Me.Label_Baud.Text = "　　　　"
        Me.Label_Baud.Visible = False
        '
        'TextBox_Baud
        '
        Me.TextBox_Baud.Location = New System.Drawing.Point(6, 13)
        Me.TextBox_Baud.Name = "TextBox_Baud"
        Me.TextBox_Baud.Size = New System.Drawing.Size(91, 21)
        Me.TextBox_Baud.TabIndex = 14
        Me.TextBox_Baud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Baud"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(183, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Get back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox_Baud2
        '
        Me.GroupBox_Baud2.Controls.Add(Me.Button3)
        Me.GroupBox_Baud2.Controls.Add(Me.Label3)
        Me.GroupBox_Baud2.Controls.Add(Me.TextBox_Baud)
        Me.GroupBox_Baud2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Baud2.Location = New System.Drawing.Point(240, 8)
        Me.GroupBox_Baud2.Name = "GroupBox_Baud2"
        Me.GroupBox_Baud2.Size = New System.Drawing.Size(280, 41)
        Me.GroupBox_Baud2.TabIndex = 13
        Me.GroupBox_Baud2.TabStop = False
        Me.GroupBox_Baud2.Text = "Serial communication (Baud)"
        Me.GroupBox_Baud2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox_Baud2)
        Me.Controls.Add(Me.GroupBox_Baud1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox_Baud1.ResumeLayout(False)
        Me.GroupBox_Baud1.PerformLayout()
        Me.GroupBox_Baud2.ResumeLayout(False)
        Me.GroupBox_Baud2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ComboBox_PORT As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer_LAB As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Rest As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_9600 As RadioButton
    Friend WithEvents GroupBox_Baud1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton_115200 As RadioButton
    Friend WithEvents RadioButton_19200 As RadioButton
    Friend WithEvents Label_Baud As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox_Baud2 As GroupBox
    Friend WithEvents TextBox_Baud As TextBox
End Class
