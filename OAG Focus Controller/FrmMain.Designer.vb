<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.btnChooseEFW = New System.Windows.Forms.Button()
        Me.btnConnectEFW = New System.Windows.Forms.Button()
        Me.txbFilterPos = New System.Windows.Forms.TextBox()
        Me.TimerUpdFilterPos = New System.Windows.Forms.Timer(Me.components)
        Me.btnDisconnectEFW = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisconnectFocuser = New System.Windows.Forms.Button()
        Me.btnConnectFocuser = New System.Windows.Forms.Button()
        Me.btnChooseFocuser = New System.Windows.Forms.Button()
        Me.TimerUpdFocuser = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbCurrentFocusPos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbFilterName7 = New System.Windows.Forms.TextBox()
        Me.txbFilterName6 = New System.Windows.Forms.TextBox()
        Me.txbFilterName5 = New System.Windows.Forms.TextBox()
        Me.txbFilterName4 = New System.Windows.Forms.TextBox()
        Me.txbFilterName3 = New System.Windows.Forms.TextBox()
        Me.txbFilterName2 = New System.Windows.Forms.TextBox()
        Me.txbFilterName1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbFilterName9 = New System.Windows.Forms.TextBox()
        Me.txbFilterName8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RadioButtonOffset = New System.Windows.Forms.RadioButton()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.RadioButtonAbsolute = New System.Windows.Forms.RadioButton()
        Me.btnFocusIn = New System.Windows.Forms.Button()
        Me.btnFocusOut = New System.Windows.Forms.Button()
        Me.btnFocusOutFine = New System.Windows.Forms.Button()
        Me.btnFocusInFine = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FilterStoredFocusOffset9 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset8 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset7 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset6 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset5 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset4 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset3 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset2 = New System.Windows.Forms.TextBox()
        Me.FilterStoredFocusOffset1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txbFilterName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txbFineSteps = New System.Windows.Forms.TextBox()
        Me.txbSteps = New System.Windows.Forms.TextBox()
        Me.txbOffsetBaseFocus = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset9 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute9 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset8 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute8 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset7 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute7 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset6 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute6 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset5 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute5 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset4 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute4 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset3 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute3 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset2 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute2 = New System.Windows.Forms.TextBox()
        Me.txbFocusoffset1 = New System.Windows.Forms.TextBox()
        Me.txbFocusAbsolute1 = New System.Windows.Forms.TextBox()
        Me.txtbFocuser = New System.Windows.Forms.TextBox()
        Me.txtbEFW = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnChooseEFW
        '
        Me.btnChooseEFW.Location = New System.Drawing.Point(12, 12)
        Me.btnChooseEFW.Name = "btnChooseEFW"
        Me.btnChooseEFW.Size = New System.Drawing.Size(235, 43)
        Me.btnChooseEFW.TabIndex = 0
        Me.btnChooseEFW.Text = "Choose EFW"
        Me.btnChooseEFW.UseVisualStyleBackColor = True
        '
        'btnConnectEFW
        '
        Me.btnConnectEFW.Location = New System.Drawing.Point(606, 12)
        Me.btnConnectEFW.Name = "btnConnectEFW"
        Me.btnConnectEFW.Size = New System.Drawing.Size(142, 43)
        Me.btnConnectEFW.TabIndex = 2
        Me.btnConnectEFW.Text = "Connect"
        Me.btnConnectEFW.UseVisualStyleBackColor = True
        '
        'txbFilterPos
        '
        Me.txbFilterPos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txbFilterPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterPos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txbFilterPos.Location = New System.Drawing.Point(162, 153)
        Me.txbFilterPos.Name = "txbFilterPos"
        Me.txbFilterPos.ReadOnly = True
        Me.txbFilterPos.Size = New System.Drawing.Size(44, 31)
        Me.txbFilterPos.TabIndex = 3
        Me.txbFilterPos.Text = "0"
        Me.txbFilterPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerUpdFilterPos
        '
        Me.TimerUpdFilterPos.Interval = 10
        '
        'btnDisconnectEFW
        '
        Me.btnDisconnectEFW.Enabled = False
        Me.btnDisconnectEFW.Location = New System.Drawing.Point(754, 12)
        Me.btnDisconnectEFW.Name = "btnDisconnectEFW"
        Me.btnDisconnectEFW.Size = New System.Drawing.Size(142, 43)
        Me.btnDisconnectEFW.TabIndex = 4
        Me.btnDisconnectEFW.Text = "Disconnect"
        Me.btnDisconnectEFW.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filter Position:"
        '
        'btnDisconnectFocuser
        '
        Me.btnDisconnectFocuser.Enabled = False
        Me.btnDisconnectFocuser.Location = New System.Drawing.Point(754, 70)
        Me.btnDisconnectFocuser.Name = "btnDisconnectFocuser"
        Me.btnDisconnectFocuser.Size = New System.Drawing.Size(142, 43)
        Me.btnDisconnectFocuser.TabIndex = 9
        Me.btnDisconnectFocuser.Text = "Disconnect"
        Me.btnDisconnectFocuser.UseVisualStyleBackColor = True
        '
        'btnConnectFocuser
        '
        Me.btnConnectFocuser.Location = New System.Drawing.Point(606, 70)
        Me.btnConnectFocuser.Name = "btnConnectFocuser"
        Me.btnConnectFocuser.Size = New System.Drawing.Size(142, 43)
        Me.btnConnectFocuser.TabIndex = 8
        Me.btnConnectFocuser.Text = "Connect"
        Me.btnConnectFocuser.UseVisualStyleBackColor = True
        '
        'btnChooseFocuser
        '
        Me.btnChooseFocuser.Location = New System.Drawing.Point(11, 70)
        Me.btnChooseFocuser.Name = "btnChooseFocuser"
        Me.btnChooseFocuser.Size = New System.Drawing.Size(235, 43)
        Me.btnChooseFocuser.TabIndex = 6
        Me.btnChooseFocuser.Text = "Choose OAG Focuser"
        Me.btnChooseFocuser.UseVisualStyleBackColor = True
        '
        'TimerUpdFocuser
        '
        Me.TimerUpdFocuser.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "OAG Focus Position:"
        '
        'txbCurrentFocusPos
        '
        Me.txbCurrentFocusPos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txbCurrentFocusPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCurrentFocusPos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txbCurrentFocusPos.Location = New System.Drawing.Point(605, 151)
        Me.txbCurrentFocusPos.Name = "txbCurrentFocusPos"
        Me.txbCurrentFocusPos.ReadOnly = True
        Me.txbCurrentFocusPos.Size = New System.Drawing.Size(120, 31)
        Me.txbCurrentFocusPos.TabIndex = 10
        Me.txbCurrentFocusPos.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Filter 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Filter 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Filter 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Filter 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Filter 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 565)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Filter 6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 621)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Filter 7"
        '
        'txbFilterName7
        '
        Me.txbFilterName7.Location = New System.Drawing.Point(99, 618)
        Me.txbFilterName7.Name = "txbFilterName7"
        Me.txbFilterName7.ReadOnly = True
        Me.txbFilterName7.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName7.TabIndex = 39
        '
        'txbFilterName6
        '
        Me.txbFilterName6.Location = New System.Drawing.Point(99, 562)
        Me.txbFilterName6.Name = "txbFilterName6"
        Me.txbFilterName6.ReadOnly = True
        Me.txbFilterName6.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName6.TabIndex = 38
        '
        'txbFilterName5
        '
        Me.txbFilterName5.Location = New System.Drawing.Point(99, 508)
        Me.txbFilterName5.Name = "txbFilterName5"
        Me.txbFilterName5.ReadOnly = True
        Me.txbFilterName5.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName5.TabIndex = 37
        '
        'txbFilterName4
        '
        Me.txbFilterName4.Location = New System.Drawing.Point(99, 458)
        Me.txbFilterName4.Name = "txbFilterName4"
        Me.txbFilterName4.ReadOnly = True
        Me.txbFilterName4.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName4.TabIndex = 36
        '
        'txbFilterName3
        '
        Me.txbFilterName3.Location = New System.Drawing.Point(99, 410)
        Me.txbFilterName3.Name = "txbFilterName3"
        Me.txbFilterName3.ReadOnly = True
        Me.txbFilterName3.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName3.TabIndex = 35
        '
        'txbFilterName2
        '
        Me.txbFilterName2.Location = New System.Drawing.Point(99, 364)
        Me.txbFilterName2.Name = "txbFilterName2"
        Me.txbFilterName2.ReadOnly = True
        Me.txbFilterName2.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName2.TabIndex = 34
        '
        'txbFilterName1
        '
        Me.txbFilterName1.Location = New System.Drawing.Point(99, 318)
        Me.txbFilterName1.Name = "txbFilterName1"
        Me.txbFilterName1.ReadOnly = True
        Me.txbFilterName1.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName1.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(99, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 75)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Filter Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(463, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 75)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "OAG Focus Absolute"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(605, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 75)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "OAG Focus Offset"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbFilterName9
        '
        Me.txbFilterName9.Location = New System.Drawing.Point(99, 727)
        Me.txbFilterName9.Name = "txbFilterName9"
        Me.txbFilterName9.ReadOnly = True
        Me.txbFilterName9.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName9.TabIndex = 50
        '
        'txbFilterName8
        '
        Me.txbFilterName8.Location = New System.Drawing.Point(99, 671)
        Me.txbFilterName8.Name = "txbFilterName8"
        Me.txbFilterName8.ReadOnly = True
        Me.txbFilterName8.Size = New System.Drawing.Size(176, 31)
        Me.txbFilterName8.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 730)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 25)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Filter 9"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 674)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 25)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Filter 8"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(415, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(184, 25)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "OAG Base Focus:"
        '
        'RadioButtonOffset
        '
        Me.RadioButtonOffset.AutoSize = True
        Me.RadioButtonOffset.Checked = True
        Me.RadioButtonOffset.Location = New System.Drawing.Point(765, 201)
        Me.RadioButtonOffset.Name = "RadioButtonOffset"
        Me.RadioButtonOffset.Size = New System.Drawing.Size(100, 29)
        Me.RadioButtonOffset.TabIndex = 55
        Me.RadioButtonOffset.TabStop = True
        Me.RadioButtonOffset.Text = "Offset"
        Me.RadioButtonOffset.UseVisualStyleBackColor = True
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(759, 695)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(142, 73)
        Me.btnSaveSettings.TabIndex = 56
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'RadioButtonAbsolute
        '
        Me.RadioButtonAbsolute.AutoSize = True
        Me.RadioButtonAbsolute.Location = New System.Drawing.Point(765, 153)
        Me.RadioButtonAbsolute.Name = "RadioButtonAbsolute"
        Me.RadioButtonAbsolute.Size = New System.Drawing.Size(127, 29)
        Me.RadioButtonAbsolute.TabIndex = 54
        Me.RadioButtonAbsolute.Text = "Absolute"
        Me.RadioButtonAbsolute.UseVisualStyleBackColor = True
        '
        'btnFocusIn
        '
        Me.btnFocusIn.Enabled = False
        Me.btnFocusIn.Location = New System.Drawing.Point(754, 364)
        Me.btnFocusIn.Name = "btnFocusIn"
        Me.btnFocusIn.Size = New System.Drawing.Size(142, 49)
        Me.btnFocusIn.TabIndex = 57
        Me.btnFocusIn.Text = "Move In"
        Me.btnFocusIn.UseVisualStyleBackColor = True
        '
        'btnFocusOut
        '
        Me.btnFocusOut.Enabled = False
        Me.btnFocusOut.Location = New System.Drawing.Point(754, 419)
        Me.btnFocusOut.Name = "btnFocusOut"
        Me.btnFocusOut.Size = New System.Drawing.Size(142, 49)
        Me.btnFocusOut.TabIndex = 58
        Me.btnFocusOut.Text = "Move Out"
        Me.btnFocusOut.UseVisualStyleBackColor = True
        '
        'btnFocusOutFine
        '
        Me.btnFocusOutFine.Enabled = False
        Me.btnFocusOutFine.Location = New System.Drawing.Point(759, 617)
        Me.btnFocusOutFine.Name = "btnFocusOutFine"
        Me.btnFocusOutFine.Size = New System.Drawing.Size(142, 49)
        Me.btnFocusOutFine.TabIndex = 60
        Me.btnFocusOutFine.Text = "Move Out"
        Me.btnFocusOutFine.UseVisualStyleBackColor = True
        '
        'btnFocusInFine
        '
        Me.btnFocusInFine.Enabled = False
        Me.btnFocusInFine.Location = New System.Drawing.Point(759, 562)
        Me.btnFocusInFine.Name = "btnFocusInFine"
        Me.btnFocusInFine.Size = New System.Drawing.Size(142, 49)
        Me.btnFocusInFine.TabIndex = 59
        Me.btnFocusInFine.Text = "Move In"
        Me.btnFocusInFine.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(754, 321)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 25)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Steps:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(760, 523)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 25)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Steps:"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(287, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 75)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Focus Offset"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilterStoredFocusOffset9
        '
        Me.FilterStoredFocusOffset9.Location = New System.Drawing.Point(287, 724)
        Me.FilterStoredFocusOffset9.Name = "FilterStoredFocusOffset9"
        Me.FilterStoredFocusOffset9.ReadOnly = True
        Me.FilterStoredFocusOffset9.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset9.TabIndex = 75
        '
        'FilterStoredFocusOffset8
        '
        Me.FilterStoredFocusOffset8.Location = New System.Drawing.Point(287, 668)
        Me.FilterStoredFocusOffset8.Name = "FilterStoredFocusOffset8"
        Me.FilterStoredFocusOffset8.ReadOnly = True
        Me.FilterStoredFocusOffset8.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset8.TabIndex = 74
        '
        'FilterStoredFocusOffset7
        '
        Me.FilterStoredFocusOffset7.Location = New System.Drawing.Point(287, 615)
        Me.FilterStoredFocusOffset7.Name = "FilterStoredFocusOffset7"
        Me.FilterStoredFocusOffset7.ReadOnly = True
        Me.FilterStoredFocusOffset7.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset7.TabIndex = 73
        '
        'FilterStoredFocusOffset6
        '
        Me.FilterStoredFocusOffset6.Location = New System.Drawing.Point(287, 559)
        Me.FilterStoredFocusOffset6.Name = "FilterStoredFocusOffset6"
        Me.FilterStoredFocusOffset6.ReadOnly = True
        Me.FilterStoredFocusOffset6.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset6.TabIndex = 72
        '
        'FilterStoredFocusOffset5
        '
        Me.FilterStoredFocusOffset5.Location = New System.Drawing.Point(287, 505)
        Me.FilterStoredFocusOffset5.Name = "FilterStoredFocusOffset5"
        Me.FilterStoredFocusOffset5.ReadOnly = True
        Me.FilterStoredFocusOffset5.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset5.TabIndex = 71
        '
        'FilterStoredFocusOffset4
        '
        Me.FilterStoredFocusOffset4.Location = New System.Drawing.Point(287, 455)
        Me.FilterStoredFocusOffset4.Name = "FilterStoredFocusOffset4"
        Me.FilterStoredFocusOffset4.ReadOnly = True
        Me.FilterStoredFocusOffset4.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset4.TabIndex = 70
        '
        'FilterStoredFocusOffset3
        '
        Me.FilterStoredFocusOffset3.Location = New System.Drawing.Point(287, 407)
        Me.FilterStoredFocusOffset3.Name = "FilterStoredFocusOffset3"
        Me.FilterStoredFocusOffset3.ReadOnly = True
        Me.FilterStoredFocusOffset3.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset3.TabIndex = 69
        '
        'FilterStoredFocusOffset2
        '
        Me.FilterStoredFocusOffset2.Location = New System.Drawing.Point(287, 361)
        Me.FilterStoredFocusOffset2.Name = "FilterStoredFocusOffset2"
        Me.FilterStoredFocusOffset2.ReadOnly = True
        Me.FilterStoredFocusOffset2.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset2.TabIndex = 68
        '
        'FilterStoredFocusOffset1
        '
        Me.FilterStoredFocusOffset1.Location = New System.Drawing.Point(287, 315)
        Me.FilterStoredFocusOffset1.Name = "FilterStoredFocusOffset1"
        Me.FilterStoredFocusOffset1.ReadOnly = True
        Me.FilterStoredFocusOffset1.Size = New System.Drawing.Size(90, 31)
        Me.FilterStoredFocusOffset1.TabIndex = 67
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 201)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 25)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Filter Name:"
        '
        'txbFilterName
        '
        Me.txbFilterName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txbFilterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txbFilterName.Location = New System.Drawing.Point(162, 198)
        Me.txbFilterName.Name = "txbFilterName"
        Me.txbFilterName.ReadOnly = True
        Me.txbFilterName.Size = New System.Drawing.Size(215, 31)
        Me.txbFilterName.TabIndex = 77
        Me.txbFilterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(754, 290)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 25)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "Coarse"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(759, 492)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(142, 25)
        Me.Label21.TabIndex = 79
        Me.Label21.Text = "Fine"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbFineSteps
        '
        Me.txbFineSteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "FocusFineStepSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFineSteps.Location = New System.Drawing.Point(836, 520)
        Me.txbFineSteps.Name = "txbFineSteps"
        Me.txbFineSteps.Size = New System.Drawing.Size(65, 31)
        Me.txbFineSteps.TabIndex = 63
        Me.txbFineSteps.Text = Global.OAG_Focus_Controller.My.MySettings.Default.FocusFineStepSize
        Me.txbFineSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txbSteps
        '
        Me.txbSteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "FocusStepSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbSteps.Location = New System.Drawing.Point(830, 321)
        Me.txbSteps.Name = "txbSteps"
        Me.txbSteps.Size = New System.Drawing.Size(66, 31)
        Me.txbSteps.TabIndex = 61
        Me.txbSteps.Text = Global.OAG_Focus_Controller.My.MySettings.Default.FocusStepSize
        Me.txbSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txbOffsetBaseFocus
        '
        Me.txbOffsetBaseFocus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "offsetBaseFocus", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbOffsetBaseFocus.Location = New System.Drawing.Point(605, 198)
        Me.txbOffsetBaseFocus.Name = "txbOffsetBaseFocus"
        Me.txbOffsetBaseFocus.Size = New System.Drawing.Size(120, 31)
        Me.txbOffsetBaseFocus.TabIndex = 52
        Me.txbOffsetBaseFocus.Text = Global.OAG_Focus_Controller.My.MySettings.Default.offsetBaseFocus
        '
        'txbFocusoffset9
        '
        Me.txbFocusoffset9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset9", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset9.Location = New System.Drawing.Point(610, 730)
        Me.txbFocusoffset9.Name = "txbFocusoffset9"
        Me.txbFocusoffset9.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset9.TabIndex = 47
        Me.txbFocusoffset9.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset9
        '
        'txbFocusAbsolute9
        '
        Me.txbFocusAbsolute9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute9", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute9.Location = New System.Drawing.Point(463, 727)
        Me.txbFocusAbsolute9.Name = "txbFocusAbsolute9"
        Me.txbFocusAbsolute9.ReadOnly = True
        Me.txbFocusAbsolute9.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute9.TabIndex = 46
        Me.txbFocusAbsolute9.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute9
        '
        'txbFocusoffset8
        '
        Me.txbFocusoffset8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset8.Location = New System.Drawing.Point(610, 674)
        Me.txbFocusoffset8.Name = "txbFocusoffset8"
        Me.txbFocusoffset8.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset8.TabIndex = 44
        Me.txbFocusoffset8.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset8
        '
        'txbFocusAbsolute8
        '
        Me.txbFocusAbsolute8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute8.Location = New System.Drawing.Point(463, 671)
        Me.txbFocusAbsolute8.Name = "txbFocusAbsolute8"
        Me.txbFocusAbsolute8.ReadOnly = True
        Me.txbFocusAbsolute8.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute8.TabIndex = 43
        Me.txbFocusAbsolute8.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute8
        '
        'txbFocusoffset7
        '
        Me.txbFocusoffset7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset7.Location = New System.Drawing.Point(610, 621)
        Me.txbFocusoffset7.Name = "txbFocusoffset7"
        Me.txbFocusoffset7.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset7.TabIndex = 31
        Me.txbFocusoffset7.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset7
        '
        'txbFocusAbsolute7
        '
        Me.txbFocusAbsolute7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute7.Location = New System.Drawing.Point(463, 618)
        Me.txbFocusAbsolute7.Name = "txbFocusAbsolute7"
        Me.txbFocusAbsolute7.ReadOnly = True
        Me.txbFocusAbsolute7.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute7.TabIndex = 30
        Me.txbFocusAbsolute7.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute7
        '
        'txbFocusoffset6
        '
        Me.txbFocusoffset6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset6.Location = New System.Drawing.Point(610, 565)
        Me.txbFocusoffset6.Name = "txbFocusoffset6"
        Me.txbFocusoffset6.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset6.TabIndex = 28
        Me.txbFocusoffset6.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset6
        '
        'txbFocusAbsolute6
        '
        Me.txbFocusAbsolute6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute6.Location = New System.Drawing.Point(463, 562)
        Me.txbFocusAbsolute6.Name = "txbFocusAbsolute6"
        Me.txbFocusAbsolute6.ReadOnly = True
        Me.txbFocusAbsolute6.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute6.TabIndex = 27
        Me.txbFocusAbsolute6.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute6
        '
        'txbFocusoffset5
        '
        Me.txbFocusoffset5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset5.Location = New System.Drawing.Point(610, 511)
        Me.txbFocusoffset5.Name = "txbFocusoffset5"
        Me.txbFocusoffset5.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset5.TabIndex = 25
        Me.txbFocusoffset5.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset5
        '
        'txbFocusAbsolute5
        '
        Me.txbFocusAbsolute5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute5.Location = New System.Drawing.Point(463, 508)
        Me.txbFocusAbsolute5.Name = "txbFocusAbsolute5"
        Me.txbFocusAbsolute5.ReadOnly = True
        Me.txbFocusAbsolute5.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute5.TabIndex = 24
        Me.txbFocusAbsolute5.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute5
        '
        'txbFocusoffset4
        '
        Me.txbFocusoffset4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset4.Location = New System.Drawing.Point(610, 461)
        Me.txbFocusoffset4.Name = "txbFocusoffset4"
        Me.txbFocusoffset4.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset4.TabIndex = 22
        Me.txbFocusoffset4.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset4
        '
        'txbFocusAbsolute4
        '
        Me.txbFocusAbsolute4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute4.Location = New System.Drawing.Point(463, 458)
        Me.txbFocusAbsolute4.Name = "txbFocusAbsolute4"
        Me.txbFocusAbsolute4.ReadOnly = True
        Me.txbFocusAbsolute4.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute4.TabIndex = 21
        Me.txbFocusAbsolute4.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute4
        '
        'txbFocusoffset3
        '
        Me.txbFocusoffset3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset3.Location = New System.Drawing.Point(610, 413)
        Me.txbFocusoffset3.Name = "txbFocusoffset3"
        Me.txbFocusoffset3.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset3.TabIndex = 19
        Me.txbFocusoffset3.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset3
        '
        'txbFocusAbsolute3
        '
        Me.txbFocusAbsolute3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute3.Location = New System.Drawing.Point(463, 410)
        Me.txbFocusAbsolute3.Name = "txbFocusAbsolute3"
        Me.txbFocusAbsolute3.ReadOnly = True
        Me.txbFocusAbsolute3.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute3.TabIndex = 18
        Me.txbFocusAbsolute3.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute3
        '
        'txbFocusoffset2
        '
        Me.txbFocusoffset2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset2.Location = New System.Drawing.Point(610, 367)
        Me.txbFocusoffset2.Name = "txbFocusoffset2"
        Me.txbFocusoffset2.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset2.TabIndex = 16
        Me.txbFocusoffset2.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset2
        '
        'txbFocusAbsolute2
        '
        Me.txbFocusAbsolute2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute2.Location = New System.Drawing.Point(463, 364)
        Me.txbFocusAbsolute2.Name = "txbFocusAbsolute2"
        Me.txbFocusAbsolute2.ReadOnly = True
        Me.txbFocusAbsolute2.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute2.TabIndex = 15
        Me.txbFocusAbsolute2.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute2
        '
        'txbFocusoffset1
        '
        Me.txbFocusoffset1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset1.Location = New System.Drawing.Point(610, 321)
        Me.txbFocusoffset1.Name = "txbFocusoffset1"
        Me.txbFocusoffset1.Size = New System.Drawing.Size(90, 31)
        Me.txbFocusoffset1.TabIndex = 13
        Me.txbFocusoffset1.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset1
        '
        'txbFocusAbsolute1
        '
        Me.txbFocusAbsolute1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute1.Location = New System.Drawing.Point(463, 318)
        Me.txbFocusAbsolute1.Name = "txbFocusAbsolute1"
        Me.txbFocusAbsolute1.ReadOnly = True
        Me.txbFocusAbsolute1.Size = New System.Drawing.Size(124, 31)
        Me.txbFocusAbsolute1.TabIndex = 12
        Me.txbFocusAbsolute1.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute1
        '
        'txtbFocuser
        '
        Me.txtbFocuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "Focuser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbFocuser.Location = New System.Drawing.Point(268, 73)
        Me.txtbFocuser.Name = "txtbFocuser"
        Me.txtbFocuser.Size = New System.Drawing.Size(320, 31)
        Me.txtbFocuser.TabIndex = 7
        Me.txtbFocuser.Text = Global.OAG_Focus_Controller.My.MySettings.Default.Focuser
        '
        'txtbEFW
        '
        Me.txtbEFW.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "EFW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbEFW.Location = New System.Drawing.Point(268, 18)
        Me.txtbEFW.Name = "txtbEFW"
        Me.txtbEFW.Size = New System.Drawing.Size(320, 31)
        Me.txtbEFW.TabIndex = 1
        Me.txtbEFW.Text = Global.OAG_Focus_Controller.My.MySettings.Default.EFW
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 780)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txbFilterName)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.FilterStoredFocusOffset9)
        Me.Controls.Add(Me.FilterStoredFocusOffset8)
        Me.Controls.Add(Me.FilterStoredFocusOffset7)
        Me.Controls.Add(Me.FilterStoredFocusOffset6)
        Me.Controls.Add(Me.FilterStoredFocusOffset5)
        Me.Controls.Add(Me.FilterStoredFocusOffset4)
        Me.Controls.Add(Me.FilterStoredFocusOffset3)
        Me.Controls.Add(Me.FilterStoredFocusOffset2)
        Me.Controls.Add(Me.FilterStoredFocusOffset1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txbFineSteps)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txbSteps)
        Me.Controls.Add(Me.btnFocusOutFine)
        Me.Controls.Add(Me.btnFocusInFine)
        Me.Controls.Add(Me.btnFocusOut)
        Me.Controls.Add(Me.btnFocusIn)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.RadioButtonOffset)
        Me.Controls.Add(Me.RadioButtonAbsolute)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txbOffsetBaseFocus)
        Me.Controls.Add(Me.txbFilterName9)
        Me.Controls.Add(Me.txbFilterName8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txbFocusoffset9)
        Me.Controls.Add(Me.txbFocusAbsolute9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txbFocusoffset8)
        Me.Controls.Add(Me.txbFocusAbsolute8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txbFilterName7)
        Me.Controls.Add(Me.txbFilterName6)
        Me.Controls.Add(Me.txbFilterName5)
        Me.Controls.Add(Me.txbFilterName4)
        Me.Controls.Add(Me.txbFilterName3)
        Me.Controls.Add(Me.txbFilterName2)
        Me.Controls.Add(Me.txbFilterName1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txbFocusoffset7)
        Me.Controls.Add(Me.txbFocusAbsolute7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbFocusoffset6)
        Me.Controls.Add(Me.txbFocusAbsolute6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbFocusoffset5)
        Me.Controls.Add(Me.txbFocusAbsolute5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbFocusoffset4)
        Me.Controls.Add(Me.txbFocusAbsolute4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbFocusoffset3)
        Me.Controls.Add(Me.txbFocusAbsolute3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbFocusoffset2)
        Me.Controls.Add(Me.txbFocusAbsolute2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbFocusoffset1)
        Me.Controls.Add(Me.txbFocusAbsolute1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbCurrentFocusPos)
        Me.Controls.Add(Me.btnDisconnectFocuser)
        Me.Controls.Add(Me.btnConnectFocuser)
        Me.Controls.Add(Me.txtbFocuser)
        Me.Controls.Add(Me.btnChooseFocuser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisconnectEFW)
        Me.Controls.Add(Me.txbFilterPos)
        Me.Controls.Add(Me.btnConnectEFW)
        Me.Controls.Add(Me.txtbEFW)
        Me.Controls.Add(Me.btnChooseEFW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "  OAG Focus Controller v1.0 (BETA)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChooseEFW As Button
    Friend WithEvents txtbEFW As TextBox
    Friend WithEvents btnConnectEFW As Button
    Friend WithEvents txbFilterPos As TextBox
    Friend WithEvents TimerUpdFilterPos As Timer
    Friend WithEvents btnDisconnectEFW As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisconnectFocuser As Button
    Friend WithEvents btnConnectFocuser As Button
    Friend WithEvents txtbFocuser As TextBox
    Friend WithEvents btnChooseFocuser As Button
    Friend WithEvents TimerUpdFocuser As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents txbCurrentFocusPos As TextBox
    Friend WithEvents txbFocusAbsolute1 As TextBox
    Friend WithEvents txbFocusoffset1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbFocusoffset2 As TextBox
    Friend WithEvents txbFocusAbsolute2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbFocusoffset3 As TextBox
    Friend WithEvents txbFocusAbsolute3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbFocusoffset4 As TextBox
    Friend WithEvents txbFocusAbsolute4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbFocusoffset5 As TextBox
    Friend WithEvents txbFocusAbsolute5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbFocusoffset6 As TextBox
    Friend WithEvents txbFocusAbsolute6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txbFocusoffset7 As TextBox
    Friend WithEvents txbFocusAbsolute7 As TextBox
    Friend WithEvents txbFilterName7 As TextBox
    Friend WithEvents txbFilterName6 As TextBox
    Friend WithEvents txbFilterName5 As TextBox
    Friend WithEvents txbFilterName4 As TextBox
    Friend WithEvents txbFilterName3 As TextBox
    Friend WithEvents txbFilterName2 As TextBox
    Friend WithEvents txbFilterName1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txbFilterName9 As TextBox
    Friend WithEvents txbFilterName8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txbFocusoffset9 As TextBox
    Friend WithEvents txbFocusAbsolute9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txbFocusoffset8 As TextBox
    Friend WithEvents txbFocusAbsolute8 As TextBox
    Friend WithEvents txbOffsetBaseFocus As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RadioButtonAbsolute As RadioButton
    Friend WithEvents RadioButtonOffset As RadioButton
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnFocusIn As Button
    Friend WithEvents btnFocusOut As Button
    Friend WithEvents btnFocusOutFine As Button
    Friend WithEvents btnFocusInFine As Button
    Friend WithEvents txbSteps As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txbFineSteps As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents FilterStoredFocusOffset9 As TextBox
    Friend WithEvents FilterStoredFocusOffset8 As TextBox
    Friend WithEvents FilterStoredFocusOffset7 As TextBox
    Friend WithEvents FilterStoredFocusOffset6 As TextBox
    Friend WithEvents FilterStoredFocusOffset5 As TextBox
    Friend WithEvents FilterStoredFocusOffset4 As TextBox
    Friend WithEvents FilterStoredFocusOffset3 As TextBox
    Friend WithEvents FilterStoredFocusOffset2 As TextBox
    Friend WithEvents FilterStoredFocusOffset1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txbFilterName As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
End Class
