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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
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
        Me.TimerMoveFocus = New System.Windows.Forms.Timer(Me.components)
        Me.gbFocusControl = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnStoreBaseFocus = New System.Windows.Forms.Button()
        Me.btnStoreFocusPosition = New System.Windows.Forms.Button()
        Me.txbMediumSteps = New System.Windows.Forms.TextBox()
        Me.txbFastSteps = New System.Windows.Forms.TextBox()
        Me.txbSlowSteps = New System.Windows.Forms.TextBox()
        Me.rbFocusSpeedFast = New System.Windows.Forms.RadioButton()
        Me.rbFocusSpeedMedium = New System.Windows.Forms.RadioButton()
        Me.rbFocusSpeedSlow = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbFilterSelect = New System.Windows.Forms.GroupBox()
        Me.rbFilter9 = New System.Windows.Forms.RadioButton()
        Me.rbFilter5 = New System.Windows.Forms.RadioButton()
        Me.rbFilter8 = New System.Windows.Forms.RadioButton()
        Me.rbFilter4 = New System.Windows.Forms.RadioButton()
        Me.rbFilter7 = New System.Windows.Forms.RadioButton()
        Me.rbFilter3 = New System.Windows.Forms.RadioButton()
        Me.rbFilter6 = New System.Windows.Forms.RadioButton()
        Me.rbFilter2 = New System.Windows.Forms.RadioButton()
        Me.rbFilter1 = New System.Windows.Forms.RadioButton()
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
        Me.gbFocusControl.SuspendLayout()
        Me.gbFilterSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChooseEFW
        '
        Me.btnChooseEFW.BackColor = System.Drawing.Color.DimGray
        Me.btnChooseEFW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseEFW.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnChooseEFW.Location = New System.Drawing.Point(12, 12)
        Me.btnChooseEFW.Name = "btnChooseEFW"
        Me.btnChooseEFW.Size = New System.Drawing.Size(237, 47)
        Me.btnChooseEFW.TabIndex = 0
        Me.btnChooseEFW.Text = "Choose EFW"
        Me.btnChooseEFW.UseVisualStyleBackColor = False
        '
        'btnConnectEFW
        '
        Me.btnConnectEFW.BackColor = System.Drawing.Color.DimGray
        Me.btnConnectEFW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectEFW.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnConnectEFW.Location = New System.Drawing.Point(644, 12)
        Me.btnConnectEFW.Name = "btnConnectEFW"
        Me.btnConnectEFW.Size = New System.Drawing.Size(144, 47)
        Me.btnConnectEFW.TabIndex = 2
        Me.btnConnectEFW.Text = "Connect"
        Me.btnConnectEFW.UseVisualStyleBackColor = False
        '
        'txbFilterPos
        '
        Me.txbFilterPos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txbFilterPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterPos.ForeColor = System.Drawing.Color.Red
        Me.txbFilterPos.Location = New System.Drawing.Point(200, 135)
        Me.txbFilterPos.Name = "txbFilterPos"
        Me.txbFilterPos.ReadOnly = True
        Me.txbFilterPos.Size = New System.Drawing.Size(44, 44)
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
        Me.btnDisconnectEFW.BackColor = System.Drawing.Color.DimGray
        Me.btnDisconnectEFW.Enabled = False
        Me.btnDisconnectEFW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnectEFW.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnDisconnectEFW.Location = New System.Drawing.Point(833, 12)
        Me.btnDisconnectEFW.Name = "btnDisconnectEFW"
        Me.btnDisconnectEFW.Size = New System.Drawing.Size(173, 47)
        Me.btnDisconnectEFW.TabIndex = 4
        Me.btnDisconnectEFW.Text = "Disconnect"
        Me.btnDisconnectEFW.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filter Pos"
        '
        'btnDisconnectFocuser
        '
        Me.btnDisconnectFocuser.BackColor = System.Drawing.Color.DimGray
        Me.btnDisconnectFocuser.Enabled = False
        Me.btnDisconnectFocuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnectFocuser.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnDisconnectFocuser.Location = New System.Drawing.Point(833, 70)
        Me.btnDisconnectFocuser.Name = "btnDisconnectFocuser"
        Me.btnDisconnectFocuser.Size = New System.Drawing.Size(173, 47)
        Me.btnDisconnectFocuser.TabIndex = 9
        Me.btnDisconnectFocuser.Text = "Disconnect"
        Me.btnDisconnectFocuser.UseVisualStyleBackColor = False
        '
        'btnConnectFocuser
        '
        Me.btnConnectFocuser.BackColor = System.Drawing.Color.DimGray
        Me.btnConnectFocuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectFocuser.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnConnectFocuser.Location = New System.Drawing.Point(644, 70)
        Me.btnConnectFocuser.Name = "btnConnectFocuser"
        Me.btnConnectFocuser.Size = New System.Drawing.Size(144, 47)
        Me.btnConnectFocuser.TabIndex = 8
        Me.btnConnectFocuser.Text = "Connect"
        Me.btnConnectFocuser.UseVisualStyleBackColor = False
        '
        'btnChooseFocuser
        '
        Me.btnChooseFocuser.BackColor = System.Drawing.Color.DimGray
        Me.btnChooseFocuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseFocuser.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnChooseFocuser.Location = New System.Drawing.Point(11, 70)
        Me.btnChooseFocuser.Name = "btnChooseFocuser"
        Me.btnChooseFocuser.Size = New System.Drawing.Size(237, 47)
        Me.btnChooseFocuser.TabIndex = 6
        Me.btnChooseFocuser.Text = "Choose Focuser"
        Me.btnChooseFocuser.UseVisualStyleBackColor = False
        '
        'TimerUpdFocuser
        '
        Me.TimerUpdFocuser.Interval = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 55)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "OAG Focus Position"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbCurrentFocusPos
        '
        Me.txbCurrentFocusPos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txbCurrentFocusPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCurrentFocusPos.ForeColor = System.Drawing.Color.Red
        Me.txbCurrentFocusPos.Location = New System.Drawing.Point(19, 76)
        Me.txbCurrentFocusPos.Name = "txbCurrentFocusPos"
        Me.txbCurrentFocusPos.ReadOnly = True
        Me.txbCurrentFocusPos.Size = New System.Drawing.Size(171, 44)
        Me.txbCurrentFocusPos.TabIndex = 10
        Me.txbCurrentFocusPos.Text = "0"
        Me.txbCurrentFocusPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Filter 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Filter 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 29)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Filter 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Filter 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 525)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 29)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Filter 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 566)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Filter 6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 607)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 29)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Filter 7"
        '
        'txbFilterName7
        '
        Me.txbFilterName7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName7.Location = New System.Drawing.Point(103, 604)
        Me.txbFilterName7.Name = "txbFilterName7"
        Me.txbFilterName7.ReadOnly = True
        Me.txbFilterName7.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName7.TabIndex = 39
        '
        'txbFilterName6
        '
        Me.txbFilterName6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName6.Location = New System.Drawing.Point(103, 563)
        Me.txbFilterName6.Name = "txbFilterName6"
        Me.txbFilterName6.ReadOnly = True
        Me.txbFilterName6.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName6.TabIndex = 38
        '
        'txbFilterName5
        '
        Me.txbFilterName5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName5.Location = New System.Drawing.Point(103, 522)
        Me.txbFilterName5.Name = "txbFilterName5"
        Me.txbFilterName5.ReadOnly = True
        Me.txbFilterName5.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName5.TabIndex = 37
        '
        'txbFilterName4
        '
        Me.txbFilterName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName4.Location = New System.Drawing.Point(103, 481)
        Me.txbFilterName4.Name = "txbFilterName4"
        Me.txbFilterName4.ReadOnly = True
        Me.txbFilterName4.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName4.TabIndex = 36
        '
        'txbFilterName3
        '
        Me.txbFilterName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName3.Location = New System.Drawing.Point(103, 440)
        Me.txbFilterName3.Name = "txbFilterName3"
        Me.txbFilterName3.ReadOnly = True
        Me.txbFilterName3.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName3.TabIndex = 35
        '
        'txbFilterName2
        '
        Me.txbFilterName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName2.Location = New System.Drawing.Point(103, 399)
        Me.txbFilterName2.Name = "txbFilterName2"
        Me.txbFilterName2.ReadOnly = True
        Me.txbFilterName2.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName2.TabIndex = 34
        '
        'txbFilterName1
        '
        Me.txbFilterName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName1.Location = New System.Drawing.Point(103, 358)
        Me.txbFilterName1.Name = "txbFilterName1"
        Me.txbFilterName1.ReadOnly = True
        Me.txbFilterName1.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName1.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(103, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 75)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Filter Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(504, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 58)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "OAG Focus Absolute"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(650, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 61)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "OAG Focus Offset"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbFilterName9
        '
        Me.txbFilterName9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName9.Location = New System.Drawing.Point(103, 686)
        Me.txbFilterName9.Name = "txbFilterName9"
        Me.txbFilterName9.ReadOnly = True
        Me.txbFilterName9.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName9.TabIndex = 50
        '
        'txbFilterName8
        '
        Me.txbFilterName8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName8.Location = New System.Drawing.Point(103, 645)
        Me.txbFilterName8.Name = "txbFilterName8"
        Me.txbFilterName8.ReadOnly = True
        Me.txbFilterName8.Size = New System.Drawing.Size(176, 35)
        Me.txbFilterName8.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 689)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 29)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Filter 9"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 648)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 29)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Filter 8"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(634, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 59)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "OAG Base Focus"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButtonOffset
        '
        Me.RadioButtonOffset.AutoSize = True
        Me.RadioButtonOffset.Checked = True
        Me.RadioButtonOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonOffset.Location = New System.Drawing.Point(672, 242)
        Me.RadioButtonOffset.Name = "RadioButtonOffset"
        Me.RadioButtonOffset.Size = New System.Drawing.Size(107, 33)
        Me.RadioButtonOffset.TabIndex = 55
        Me.RadioButtonOffset.TabStop = True
        Me.RadioButtonOffset.Text = "Offset"
        Me.RadioButtonOffset.UseVisualStyleBackColor = True
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.BackColor = System.Drawing.Color.DimGray
        Me.btnSaveSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnSaveSettings.Location = New System.Drawing.Point(805, 674)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(212, 47)
        Me.btnSaveSettings.TabIndex = 56
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'RadioButtonAbsolute
        '
        Me.RadioButtonAbsolute.AutoSize = True
        Me.RadioButtonAbsolute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAbsolute.Location = New System.Drawing.Point(507, 242)
        Me.RadioButtonAbsolute.Name = "RadioButtonAbsolute"
        Me.RadioButtonAbsolute.Size = New System.Drawing.Size(138, 33)
        Me.RadioButtonAbsolute.TabIndex = 54
        Me.RadioButtonAbsolute.Text = "Absolute"
        Me.RadioButtonAbsolute.UseVisualStyleBackColor = True
        '
        'btnFocusIn
        '
        Me.btnFocusIn.BackColor = System.Drawing.Color.DimGray
        Me.btnFocusIn.Enabled = False
        Me.btnFocusIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFocusIn.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnFocusIn.Location = New System.Drawing.Point(19, 291)
        Me.btnFocusIn.Name = "btnFocusIn"
        Me.btnFocusIn.Size = New System.Drawing.Size(182, 52)
        Me.btnFocusIn.TabIndex = 57
        Me.btnFocusIn.Text = "Move In"
        Me.btnFocusIn.UseVisualStyleBackColor = False
        '
        'btnFocusOut
        '
        Me.btnFocusOut.BackColor = System.Drawing.Color.DimGray
        Me.btnFocusOut.Enabled = False
        Me.btnFocusOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFocusOut.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnFocusOut.Location = New System.Drawing.Point(19, 349)
        Me.btnFocusOut.Name = "btnFocusOut"
        Me.btnFocusOut.Size = New System.Drawing.Size(182, 52)
        Me.btnFocusOut.TabIndex = 58
        Me.btnFocusOut.Text = "Move Out"
        Me.btnFocusOut.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(285, 277)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 78)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Focus Offset"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilterStoredFocusOffset9
        '
        Me.FilterStoredFocusOffset9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset9.Location = New System.Drawing.Point(291, 686)
        Me.FilterStoredFocusOffset9.Name = "FilterStoredFocusOffset9"
        Me.FilterStoredFocusOffset9.ReadOnly = True
        Me.FilterStoredFocusOffset9.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset9.TabIndex = 75
        '
        'FilterStoredFocusOffset8
        '
        Me.FilterStoredFocusOffset8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset8.Location = New System.Drawing.Point(291, 645)
        Me.FilterStoredFocusOffset8.Name = "FilterStoredFocusOffset8"
        Me.FilterStoredFocusOffset8.ReadOnly = True
        Me.FilterStoredFocusOffset8.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset8.TabIndex = 74
        '
        'FilterStoredFocusOffset7
        '
        Me.FilterStoredFocusOffset7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset7.Location = New System.Drawing.Point(291, 604)
        Me.FilterStoredFocusOffset7.Name = "FilterStoredFocusOffset7"
        Me.FilterStoredFocusOffset7.ReadOnly = True
        Me.FilterStoredFocusOffset7.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset7.TabIndex = 73
        '
        'FilterStoredFocusOffset6
        '
        Me.FilterStoredFocusOffset6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset6.Location = New System.Drawing.Point(291, 563)
        Me.FilterStoredFocusOffset6.Name = "FilterStoredFocusOffset6"
        Me.FilterStoredFocusOffset6.ReadOnly = True
        Me.FilterStoredFocusOffset6.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset6.TabIndex = 72
        '
        'FilterStoredFocusOffset5
        '
        Me.FilterStoredFocusOffset5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset5.Location = New System.Drawing.Point(291, 522)
        Me.FilterStoredFocusOffset5.Name = "FilterStoredFocusOffset5"
        Me.FilterStoredFocusOffset5.ReadOnly = True
        Me.FilterStoredFocusOffset5.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset5.TabIndex = 71
        '
        'FilterStoredFocusOffset4
        '
        Me.FilterStoredFocusOffset4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset4.Location = New System.Drawing.Point(291, 481)
        Me.FilterStoredFocusOffset4.Name = "FilterStoredFocusOffset4"
        Me.FilterStoredFocusOffset4.ReadOnly = True
        Me.FilterStoredFocusOffset4.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset4.TabIndex = 70
        '
        'FilterStoredFocusOffset3
        '
        Me.FilterStoredFocusOffset3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset3.Location = New System.Drawing.Point(291, 440)
        Me.FilterStoredFocusOffset3.Name = "FilterStoredFocusOffset3"
        Me.FilterStoredFocusOffset3.ReadOnly = True
        Me.FilterStoredFocusOffset3.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset3.TabIndex = 69
        '
        'FilterStoredFocusOffset2
        '
        Me.FilterStoredFocusOffset2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset2.Location = New System.Drawing.Point(291, 399)
        Me.FilterStoredFocusOffset2.Name = "FilterStoredFocusOffset2"
        Me.FilterStoredFocusOffset2.ReadOnly = True
        Me.FilterStoredFocusOffset2.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset2.TabIndex = 68
        '
        'FilterStoredFocusOffset1
        '
        Me.FilterStoredFocusOffset1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterStoredFocusOffset1.Location = New System.Drawing.Point(291, 358)
        Me.FilterStoredFocusOffset1.Name = "FilterStoredFocusOffset1"
        Me.FilterStoredFocusOffset1.ReadOnly = True
        Me.FilterStoredFocusOffset1.Size = New System.Drawing.Size(90, 35)
        Me.FilterStoredFocusOffset1.TabIndex = 67
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(183, 37)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Filter Name"
        '
        'txbFilterName
        '
        Me.txbFilterName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txbFilterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFilterName.ForeColor = System.Drawing.Color.Red
        Me.txbFilterName.Location = New System.Drawing.Point(200, 189)
        Me.txbFilterName.Name = "txbFilterName"
        Me.txbFilterName.ReadOnly = True
        Me.txbFilterName.Size = New System.Drawing.Size(433, 44)
        Me.txbFilterName.TabIndex = 77
        Me.txbFilterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerMoveFocus
        '
        '
        'gbFocusControl
        '
        Me.gbFocusControl.BackColor = System.Drawing.Color.Black
        Me.gbFocusControl.Controls.Add(Me.Label20)
        Me.gbFocusControl.Controls.Add(Me.Label17)
        Me.gbFocusControl.Controls.Add(Me.btnStoreBaseFocus)
        Me.gbFocusControl.Controls.Add(Me.btnStoreFocusPosition)
        Me.gbFocusControl.Controls.Add(Me.txbMediumSteps)
        Me.gbFocusControl.Controls.Add(Me.txbFastSteps)
        Me.gbFocusControl.Controls.Add(Me.txbSlowSteps)
        Me.gbFocusControl.Controls.Add(Me.rbFocusSpeedFast)
        Me.gbFocusControl.Controls.Add(Me.rbFocusSpeedMedium)
        Me.gbFocusControl.Controls.Add(Me.rbFocusSpeedSlow)
        Me.gbFocusControl.Controls.Add(Me.btnFocusIn)
        Me.gbFocusControl.Controls.Add(Me.btnFocusOut)
        Me.gbFocusControl.Controls.Add(Me.txbCurrentFocusPos)
        Me.gbFocusControl.Controls.Add(Me.Label2)
        Me.gbFocusControl.ForeColor = System.Drawing.Color.White
        Me.gbFocusControl.Location = New System.Drawing.Point(805, 123)
        Me.gbFocusControl.Name = "gbFocusControl"
        Me.gbFocusControl.Size = New System.Drawing.Size(212, 545)
        Me.gbFocusControl.TabIndex = 80
        Me.gbFocusControl.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(36, 259)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 29)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "Move Focus"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(37, 399)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 29)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Store Focus"
        '
        'btnStoreBaseFocus
        '
        Me.btnStoreBaseFocus.BackColor = System.Drawing.Color.Maroon
        Me.btnStoreBaseFocus.Enabled = False
        Me.btnStoreBaseFocus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStoreBaseFocus.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnStoreBaseFocus.Location = New System.Drawing.Point(19, 431)
        Me.btnStoreBaseFocus.Name = "btnStoreBaseFocus"
        Me.btnStoreBaseFocus.Size = New System.Drawing.Size(182, 51)
        Me.btnStoreBaseFocus.TabIndex = 63
        Me.btnStoreBaseFocus.Text = "< Base Focus"
        Me.btnStoreBaseFocus.UseVisualStyleBackColor = False
        '
        'btnStoreFocusPosition
        '
        Me.btnStoreFocusPosition.BackColor = System.Drawing.Color.Maroon
        Me.btnStoreFocusPosition.Enabled = False
        Me.btnStoreFocusPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStoreFocusPosition.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnStoreFocusPosition.Location = New System.Drawing.Point(19, 488)
        Me.btnStoreFocusPosition.Name = "btnStoreFocusPosition"
        Me.btnStoreFocusPosition.Size = New System.Drawing.Size(182, 51)
        Me.btnStoreFocusPosition.TabIndex = 62
        Me.btnStoreFocusPosition.Text = "< Filter Focus"
        Me.btnStoreFocusPosition.UseVisualStyleBackColor = False
        '
        'txbMediumSteps
        '
        Me.txbMediumSteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "FocusMediumSteps", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbMediumSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMediumSteps.Location = New System.Drawing.Point(130, 179)
        Me.txbMediumSteps.Name = "txbMediumSteps"
        Me.txbMediumSteps.Size = New System.Drawing.Size(71, 35)
        Me.txbMediumSteps.TabIndex = 61
        Me.txbMediumSteps.Text = Global.OAG_Focus_Controller.My.MySettings.Default.FocusMediumSteps
        '
        'txbFastSteps
        '
        Me.txbFastSteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "FocusFastSteps", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFastSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFastSteps.Location = New System.Drawing.Point(130, 216)
        Me.txbFastSteps.Name = "txbFastSteps"
        Me.txbFastSteps.Size = New System.Drawing.Size(71, 35)
        Me.txbFastSteps.TabIndex = 60
        Me.txbFastSteps.Text = Global.OAG_Focus_Controller.My.MySettings.Default.FocusFastSteps
        '
        'txbSlowSteps
        '
        Me.txbSlowSteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "FocusSlowSteps", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbSlowSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSlowSteps.Location = New System.Drawing.Point(130, 143)
        Me.txbSlowSteps.Name = "txbSlowSteps"
        Me.txbSlowSteps.Size = New System.Drawing.Size(71, 35)
        Me.txbSlowSteps.TabIndex = 59
        Me.txbSlowSteps.Text = Global.OAG_Focus_Controller.My.MySettings.Default.FocusSlowSteps
        '
        'rbFocusSpeedFast
        '
        Me.rbFocusSpeedFast.AutoSize = True
        Me.rbFocusSpeedFast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFocusSpeedFast.Location = New System.Drawing.Point(19, 213)
        Me.rbFocusSpeedFast.Name = "rbFocusSpeedFast"
        Me.rbFocusSpeedFast.Size = New System.Drawing.Size(90, 33)
        Me.rbFocusSpeedFast.TabIndex = 2
        Me.rbFocusSpeedFast.Text = "Fast"
        Me.rbFocusSpeedFast.UseVisualStyleBackColor = True
        '
        'rbFocusSpeedMedium
        '
        Me.rbFocusSpeedMedium.AutoSize = True
        Me.rbFocusSpeedMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFocusSpeedMedium.Location = New System.Drawing.Point(19, 178)
        Me.rbFocusSpeedMedium.Name = "rbFocusSpeedMedium"
        Me.rbFocusSpeedMedium.Size = New System.Drawing.Size(92, 33)
        Me.rbFocusSpeedMedium.TabIndex = 1
        Me.rbFocusSpeedMedium.Text = "Med"
        Me.rbFocusSpeedMedium.UseVisualStyleBackColor = True
        '
        'rbFocusSpeedSlow
        '
        Me.rbFocusSpeedSlow.AutoSize = True
        Me.rbFocusSpeedSlow.BackColor = System.Drawing.Color.Black
        Me.rbFocusSpeedSlow.Checked = True
        Me.rbFocusSpeedSlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFocusSpeedSlow.ForeColor = System.Drawing.Color.White
        Me.rbFocusSpeedSlow.Location = New System.Drawing.Point(19, 143)
        Me.rbFocusSpeedSlow.Name = "rbFocusSpeedSlow"
        Me.rbFocusSpeedSlow.Size = New System.Drawing.Size(98, 33)
        Me.rbFocusSpeedSlow.TabIndex = 0
        Me.rbFocusSpeedSlow.TabStop = True
        Me.rbFocusSpeedSlow.Text = "Slow"
        Me.rbFocusSpeedSlow.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(381, 277)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 78)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Select Filter"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbFilterSelect
        '
        Me.gbFilterSelect.Controls.Add(Me.rbFilter9)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter5)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter8)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter4)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter7)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter3)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter6)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter2)
        Me.gbFilterSelect.Controls.Add(Me.rbFilter1)
        Me.gbFilterSelect.ForeColor = System.Drawing.Color.Black
        Me.gbFilterSelect.Location = New System.Drawing.Point(400, 346)
        Me.gbFilterSelect.Name = "gbFilterSelect"
        Me.gbFilterSelect.Size = New System.Drawing.Size(65, 390)
        Me.gbFilterSelect.TabIndex = 82
        Me.gbFilterSelect.TabStop = False
        Me.gbFilterSelect.Text = "GroupBox1"
        '
        'rbFilter9
        '
        Me.rbFilter9.AutoSize = True
        Me.rbFilter9.Enabled = False
        Me.rbFilter9.Location = New System.Drawing.Point(19, 345)
        Me.rbFilter9.Name = "rbFilter9"
        Me.rbFilter9.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter9.TabIndex = 90
        Me.rbFilter9.TabStop = True
        Me.rbFilter9.UseVisualStyleBackColor = True
        '
        'rbFilter5
        '
        Me.rbFilter5.AutoSize = True
        Me.rbFilter5.Enabled = False
        Me.rbFilter5.Location = New System.Drawing.Point(19, 181)
        Me.rbFilter5.Name = "rbFilter5"
        Me.rbFilter5.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter5.TabIndex = 86
        Me.rbFilter5.TabStop = True
        Me.rbFilter5.UseVisualStyleBackColor = True
        '
        'rbFilter8
        '
        Me.rbFilter8.AutoSize = True
        Me.rbFilter8.Enabled = False
        Me.rbFilter8.Location = New System.Drawing.Point(19, 304)
        Me.rbFilter8.Name = "rbFilter8"
        Me.rbFilter8.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter8.TabIndex = 89
        Me.rbFilter8.TabStop = True
        Me.rbFilter8.UseVisualStyleBackColor = True
        '
        'rbFilter4
        '
        Me.rbFilter4.AutoSize = True
        Me.rbFilter4.Enabled = False
        Me.rbFilter4.Location = New System.Drawing.Point(19, 140)
        Me.rbFilter4.Name = "rbFilter4"
        Me.rbFilter4.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter4.TabIndex = 85
        Me.rbFilter4.TabStop = True
        Me.rbFilter4.UseVisualStyleBackColor = True
        '
        'rbFilter7
        '
        Me.rbFilter7.AutoSize = True
        Me.rbFilter7.Enabled = False
        Me.rbFilter7.Location = New System.Drawing.Point(19, 263)
        Me.rbFilter7.Name = "rbFilter7"
        Me.rbFilter7.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter7.TabIndex = 88
        Me.rbFilter7.TabStop = True
        Me.rbFilter7.UseVisualStyleBackColor = True
        '
        'rbFilter3
        '
        Me.rbFilter3.AutoSize = True
        Me.rbFilter3.Enabled = False
        Me.rbFilter3.Location = New System.Drawing.Point(19, 99)
        Me.rbFilter3.Name = "rbFilter3"
        Me.rbFilter3.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter3.TabIndex = 84
        Me.rbFilter3.TabStop = True
        Me.rbFilter3.UseVisualStyleBackColor = True
        '
        'rbFilter6
        '
        Me.rbFilter6.AutoSize = True
        Me.rbFilter6.Enabled = False
        Me.rbFilter6.Location = New System.Drawing.Point(19, 222)
        Me.rbFilter6.Name = "rbFilter6"
        Me.rbFilter6.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter6.TabIndex = 87
        Me.rbFilter6.TabStop = True
        Me.rbFilter6.UseVisualStyleBackColor = True
        '
        'rbFilter2
        '
        Me.rbFilter2.AutoSize = True
        Me.rbFilter2.Enabled = False
        Me.rbFilter2.Location = New System.Drawing.Point(19, 58)
        Me.rbFilter2.Name = "rbFilter2"
        Me.rbFilter2.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter2.TabIndex = 83
        Me.rbFilter2.TabStop = True
        Me.rbFilter2.UseVisualStyleBackColor = True
        '
        'rbFilter1
        '
        Me.rbFilter1.AutoSize = True
        Me.rbFilter1.Enabled = False
        Me.rbFilter1.Location = New System.Drawing.Point(19, 17)
        Me.rbFilter1.Name = "rbFilter1"
        Me.rbFilter1.Size = New System.Drawing.Size(27, 26)
        Me.rbFilter1.TabIndex = 0
        Me.rbFilter1.TabStop = True
        Me.rbFilter1.UseVisualStyleBackColor = True
        '
        'txbOffsetBaseFocus
        '
        Me.txbOffsetBaseFocus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "offsetBaseFocus", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbOffsetBaseFocus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbOffsetBaseFocus.Location = New System.Drawing.Point(657, 195)
        Me.txbOffsetBaseFocus.Name = "txbOffsetBaseFocus"
        Me.txbOffsetBaseFocus.Size = New System.Drawing.Size(122, 35)
        Me.txbOffsetBaseFocus.TabIndex = 52
        Me.txbOffsetBaseFocus.Text = Global.OAG_Focus_Controller.My.MySettings.Default.offsetBaseFocus
        '
        'txbFocusoffset9
        '
        Me.txbFocusoffset9.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset9", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset9.Location = New System.Drawing.Point(674, 686)
        Me.txbFocusoffset9.Name = "txbFocusoffset9"
        Me.txbFocusoffset9.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset9.TabIndex = 47
        Me.txbFocusoffset9.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset9
        '
        'txbFocusAbsolute9
        '
        Me.txbFocusAbsolute9.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute9", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute9.Enabled = False
        Me.txbFocusAbsolute9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute9.Location = New System.Drawing.Point(509, 686)
        Me.txbFocusAbsolute9.Name = "txbFocusAbsolute9"
        Me.txbFocusAbsolute9.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute9.TabIndex = 46
        Me.txbFocusAbsolute9.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute9
        '
        'txbFocusoffset8
        '
        Me.txbFocusoffset8.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset8.Location = New System.Drawing.Point(674, 645)
        Me.txbFocusoffset8.Name = "txbFocusoffset8"
        Me.txbFocusoffset8.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset8.TabIndex = 44
        Me.txbFocusoffset8.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset8
        '
        'txbFocusAbsolute8
        '
        Me.txbFocusAbsolute8.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute8.Enabled = False
        Me.txbFocusAbsolute8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute8.Location = New System.Drawing.Point(509, 645)
        Me.txbFocusAbsolute8.Name = "txbFocusAbsolute8"
        Me.txbFocusAbsolute8.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute8.TabIndex = 43
        Me.txbFocusAbsolute8.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute8
        '
        'txbFocusoffset7
        '
        Me.txbFocusoffset7.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset7.Location = New System.Drawing.Point(674, 604)
        Me.txbFocusoffset7.Name = "txbFocusoffset7"
        Me.txbFocusoffset7.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset7.TabIndex = 31
        Me.txbFocusoffset7.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset7
        '
        'txbFocusAbsolute7
        '
        Me.txbFocusAbsolute7.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute7.Enabled = False
        Me.txbFocusAbsolute7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute7.Location = New System.Drawing.Point(509, 604)
        Me.txbFocusAbsolute7.Name = "txbFocusAbsolute7"
        Me.txbFocusAbsolute7.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute7.TabIndex = 30
        Me.txbFocusAbsolute7.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute7
        '
        'txbFocusoffset6
        '
        Me.txbFocusoffset6.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset6.Location = New System.Drawing.Point(674, 563)
        Me.txbFocusoffset6.Name = "txbFocusoffset6"
        Me.txbFocusoffset6.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset6.TabIndex = 28
        Me.txbFocusoffset6.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset6
        '
        'txbFocusAbsolute6
        '
        Me.txbFocusAbsolute6.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute6.Enabled = False
        Me.txbFocusAbsolute6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute6.Location = New System.Drawing.Point(509, 563)
        Me.txbFocusAbsolute6.Name = "txbFocusAbsolute6"
        Me.txbFocusAbsolute6.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute6.TabIndex = 27
        Me.txbFocusAbsolute6.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute6
        '
        'txbFocusoffset5
        '
        Me.txbFocusoffset5.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset5.Location = New System.Drawing.Point(674, 522)
        Me.txbFocusoffset5.Name = "txbFocusoffset5"
        Me.txbFocusoffset5.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset5.TabIndex = 25
        Me.txbFocusoffset5.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset5
        '
        'txbFocusAbsolute5
        '
        Me.txbFocusAbsolute5.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute5.Enabled = False
        Me.txbFocusAbsolute5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute5.Location = New System.Drawing.Point(509, 522)
        Me.txbFocusAbsolute5.Name = "txbFocusAbsolute5"
        Me.txbFocusAbsolute5.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute5.TabIndex = 24
        Me.txbFocusAbsolute5.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute5
        '
        'txbFocusoffset4
        '
        Me.txbFocusoffset4.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset4.Location = New System.Drawing.Point(674, 481)
        Me.txbFocusoffset4.Name = "txbFocusoffset4"
        Me.txbFocusoffset4.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset4.TabIndex = 22
        Me.txbFocusoffset4.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset4
        '
        'txbFocusAbsolute4
        '
        Me.txbFocusAbsolute4.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute4.Enabled = False
        Me.txbFocusAbsolute4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute4.Location = New System.Drawing.Point(509, 481)
        Me.txbFocusAbsolute4.Name = "txbFocusAbsolute4"
        Me.txbFocusAbsolute4.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute4.TabIndex = 21
        Me.txbFocusAbsolute4.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute4
        '
        'txbFocusoffset3
        '
        Me.txbFocusoffset3.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset3.Location = New System.Drawing.Point(674, 440)
        Me.txbFocusoffset3.Name = "txbFocusoffset3"
        Me.txbFocusoffset3.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset3.TabIndex = 19
        Me.txbFocusoffset3.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset3
        '
        'txbFocusAbsolute3
        '
        Me.txbFocusAbsolute3.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute3.Enabled = False
        Me.txbFocusAbsolute3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute3.Location = New System.Drawing.Point(509, 440)
        Me.txbFocusAbsolute3.Name = "txbFocusAbsolute3"
        Me.txbFocusAbsolute3.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute3.TabIndex = 18
        Me.txbFocusAbsolute3.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute3
        '
        'txbFocusoffset2
        '
        Me.txbFocusoffset2.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusoffset2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset2.Location = New System.Drawing.Point(674, 399)
        Me.txbFocusoffset2.Name = "txbFocusoffset2"
        Me.txbFocusoffset2.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset2.TabIndex = 16
        Me.txbFocusoffset2.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset2
        '
        'txbFocusAbsolute2
        '
        Me.txbFocusAbsolute2.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute2.Enabled = False
        Me.txbFocusAbsolute2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute2.Location = New System.Drawing.Point(509, 399)
        Me.txbFocusAbsolute2.Name = "txbFocusAbsolute2"
        Me.txbFocusAbsolute2.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute2.TabIndex = 15
        Me.txbFocusAbsolute2.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute2
        '
        'txbFocusoffset1
        '
        Me.txbFocusoffset1.BackColor = System.Drawing.SystemColors.Control
        Me.txbFocusoffset1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusOffset1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusoffset1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusoffset1.Location = New System.Drawing.Point(674, 358)
        Me.txbFocusoffset1.Name = "txbFocusoffset1"
        Me.txbFocusoffset1.Size = New System.Drawing.Size(90, 35)
        Me.txbFocusoffset1.TabIndex = 13
        Me.txbFocusoffset1.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusOffset1
        '
        'txbFocusAbsolute1
        '
        Me.txbFocusAbsolute1.BackColor = System.Drawing.SystemColors.Window
        Me.txbFocusAbsolute1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "focusAbsolute1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbFocusAbsolute1.Enabled = False
        Me.txbFocusAbsolute1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFocusAbsolute1.Location = New System.Drawing.Point(509, 358)
        Me.txbFocusAbsolute1.Name = "txbFocusAbsolute1"
        Me.txbFocusAbsolute1.Size = New System.Drawing.Size(124, 35)
        Me.txbFocusAbsolute1.TabIndex = 12
        Me.txbFocusAbsolute1.Text = Global.OAG_Focus_Controller.My.MySettings.Default.focusAbsolute1
        '
        'txtbFocuser
        '
        Me.txtbFocuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "Focuser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbFocuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFocuser.Location = New System.Drawing.Point(268, 73)
        Me.txtbFocuser.Name = "txtbFocuser"
        Me.txtbFocuser.Size = New System.Drawing.Size(356, 35)
        Me.txtbFocuser.TabIndex = 7
        Me.txtbFocuser.Text = Global.OAG_Focus_Controller.My.MySettings.Default.Focuser
        '
        'txtbEFW
        '
        Me.txtbEFW.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.OAG_Focus_Controller.My.MySettings.Default, "EFW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbEFW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbEFW.Location = New System.Drawing.Point(268, 18)
        Me.txtbEFW.Name = "txtbEFW"
        Me.txtbEFW.Size = New System.Drawing.Size(356, 35)
        Me.txtbEFW.TabIndex = 1
        Me.txtbEFW.Text = Global.OAG_Focus_Controller.My.MySettings.Default.EFW
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1050, 748)
        Me.Controls.Add(Me.gbFilterSelect)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.gbFocusControl)
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
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "  OAG Focus Controller v1.0 (BETA)"
        Me.gbFocusControl.ResumeLayout(False)
        Me.gbFocusControl.PerformLayout()
        Me.gbFilterSelect.ResumeLayout(False)
        Me.gbFilterSelect.PerformLayout()
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
    Friend WithEvents TimerMoveFocus As Timer
    Friend WithEvents gbFocusControl As GroupBox
    Friend WithEvents rbFocusSpeedMedium As RadioButton
    Friend WithEvents rbFocusSpeedSlow As RadioButton
    Friend WithEvents rbFocusSpeedFast As RadioButton
    Friend WithEvents txbMediumSteps As TextBox
    Friend WithEvents txbFastSteps As TextBox
    Friend WithEvents txbSlowSteps As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gbFilterSelect As GroupBox
    Friend WithEvents rbFilter5 As RadioButton
    Friend WithEvents rbFilter1 As RadioButton
    Friend WithEvents rbFilter2 As RadioButton
    Friend WithEvents rbFilter3 As RadioButton
    Friend WithEvents rbFilter4 As RadioButton
    Friend WithEvents rbFilter6 As RadioButton
    Friend WithEvents rbFilter7 As RadioButton
    Friend WithEvents rbFilter8 As RadioButton
    Friend WithEvents rbFilter9 As RadioButton
    Friend WithEvents btnStoreFocusPosition As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents btnStoreBaseFocus As Button
    Friend WithEvents Label20 As Label
End Class
