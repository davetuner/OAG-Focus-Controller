Public Class FrmMain
    Private objFilterWheel As ASCOM.DriverAccess.FilterWheel
    Private objFocuser As ASCOM.DriverAccess.Focuser

    Dim selectedFilter As Integer
    Dim GlobalFocusmode = "offset"
    Dim GlobalCurrentFilterPos = 0
    Dim GlobalFocusPos = 0
    Dim GlobalFocusDirection = ""
    Dim GlobalFocusTimerInterval = 20
    Dim GlobalFocusStepSize = 1
    Dim GlobalFilterCount = 0
    'Launch ASCOM Filterwheel Decive Chooser
    Private Sub btnChooseEFW_Click(sender As Object, e As EventArgs) Handles btnChooseEFW.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "FilterWheel"
        My.Settings.EFW = obj.Choose(My.Settings.EFW)
    End Sub
    'Connect to Filterwheel
    Private Sub btnConnectEFW_Click(sender As Object, e As EventArgs) Handles btnConnectEFW.Click
        If Not My.Settings.EFW = "" Then
            objFilterWheel = New ASCOM.DriverAccess.FilterWheel(My.Settings.EFW)
            Try
                objFilterWheel.Connected = True
                sender.enabled = False
                btnDisconnectEFW.Enabled = True
                btnChooseEFW.Enabled = False
                Call PopulateFilterNames()
                Call PopulateFocusOffsets()
                'Get FilterCount of FilterWheel
                GlobalFilterCount = objFilterWheel.Names.Length
                SetEnableStateFilterSelectRb(True)
                TimerUpdFilterPos.Start()
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message)
            End Try
        End If
    End Sub
    'Tiner checks Fiterpostion whilst connected to FilterWheel
    Private Sub TimerUpdFilterPos_Tick(sender As Object, e As EventArgs) Handles TimerUpdFilterPos.Tick
        GlobalCurrentFilterPos = objFilterWheel.Position + 1
        If GlobalCurrentFilterPos >= 1 And GlobalCurrentFilterPos <= 9 And GlobalCurrentFilterPos <> txbFilterPos.Text Then
            txbFilterPos.Text = GlobalCurrentFilterPos
            txbFilterName.Text = objFilterWheel.Names.GetValue(GlobalCurrentFilterPos - 1)
            Call SetFilterSelectRb(GlobalCurrentFilterPos)
            Call ChangeFocusMode(GlobalFocusmode)
        End If
    End Sub
    'Disconnect from filterwheel
    Private Sub btnDisconnectEFW_Click(sender As Object, e As EventArgs) Handles btnDisconnectEFW.Click
        TimerUpdFilterPos.Stop()
        objFilterWheel.Connected = False
        sender.enabled = False
        btnConnectEFW.Enabled = True
        btnChooseEFW.Enabled = True
        SetEnableStateFilterSelectRb(False)
        Call ClearFilterNames()
        Call ClearFilterOffsets()
    End Sub
    'Launch ASCOM Focuser Decive Chooser
    Private Sub btnChooseFocuser_Click(sender As Object, e As EventArgs) Handles btnChooseFocuser.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Focuser"
        My.Settings.Focuser = obj.Choose(My.Settings.Focuser)
    End Sub
    'Connect to Focuser
    Private Sub btnConnectFocuser_Click(sender As Object, e As EventArgs) Handles btnConnectFocuser.Click
        If Not My.Settings.Focuser = "" Then
            objFocuser = New ASCOM.DriverAccess.Focuser(My.Settings.Focuser)
            Try
                objFocuser.Connected = True
                sender.enabled = False
                btnDisconnectFocuser.Enabled = True
                btnFocusIn.Enabled = True
                btnFocusOut.Enabled = True
                btnStoreFocusPosition.Enabled = True
                btnChooseFocuser.Enabled = False
                btnStoreBaseFocus.Enabled = True
                Call ChangeFocusMode(GlobalFocusmode)
                TimerUpdFocuser.Start()
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message)
            End Try
        End If
    End Sub
    'Timer to keep checking the Focus position
    Private Sub TimerUpdFocuser_Tick(sender As Object, e As EventArgs) Handles TimerUpdFocuser.Tick
        GlobalFocusPos = objFocuser.Position
        If GlobalFocusPos > -1 Then
            txbCurrentFocusPos.Text = GlobalFocusPos
        End If
    End Sub
    'Disconnect from Focuser
    Private Sub btnDisconnectFocuser_Click(sender As Object, e As EventArgs) Handles btnDisconnectFocuser.Click
        TimerUpdFocuser.Stop()
        objFocuser.Connected = False
        sender.enabled = False
        btnConnectFocuser.Enabled = True
        btnFocusIn.Enabled = False
        btnFocusOut.Enabled = False
        btnStoreBaseFocus.Enabled = False
        btnStoreFocusPosition.Enabled = False
        btnChooseFocuser.Enabled = True
    End Sub
    'Saves settings when we hit save button
    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.Save()
    End Sub
    'Chnage Focus mode to Asolute
    Private Sub RadioButtonAbsolute_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAbsolute.CheckedChanged
        If sender.checked = True Then
            Call ChangeFocusMode("absolute")
        End If
    End Sub
    'Change Focus mode to Offset
    Private Sub RadioButtonOffset_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOffset.CheckedChanged
        If sender.checked = True Then
            Call ChangeFocusMode("offset")
        End If
    End Sub
    Function ChangeFocusMode(ByVal FocusMode As String)
        If FocusMode = "absolute" Then
            Call SetFocusAbsoluteEnabled(True)
            Call SetFocusOffsetEnabled(False)
        End If
        If FocusMode = "offset" Then
            Call SetFocusAbsoluteEnabled(False)
            Call SetFocusOffsetEnabled(True)
        End If
        Call MoveFocusForFilter(FocusMode)
        GlobalFocusmode = FocusMode
    End Function
    Function MoveFocusForFilter(ByVal FocusMode As String)
        If objFocuser IsNot Nothing Then
            If txbFilterPos.Text >= 1 And txbFilterPos.Text <= 9 And objFocuser.Connected = True Then
                If FocusMode = "offset" Then
                    Dim txb As TextBox = Me.Controls("txbFocusoffset" & txbFilterPos.Text)
                    If Not txb.Text = "" And Not txbOffsetBaseFocus.Text = "" Then
                        If Int(txbOffsetBaseFocus.Text) + Int(txb.Text) <> objFocuser.Position And txbOffsetBaseFocus.Text <> 0 Then
                            objFocuser.Move(Int(txbOffsetBaseFocus.Text) + Int(txb.Text))
                        End If
                    End If
                End If
                If FocusMode = "absolute" Then
                    Dim txb As TextBox = Me.Controls("txbFocusAbsolute" & txbFilterPos.Text)
                    If Not txb.Text = "" Then
                        If txb.Text <> 0 Then
                            objFocuser.Move(txb.Text)
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Function SetFocusAbsoluteEnabled(ByVal enabledState As Boolean)
        For FilterIndex As Integer = 1 To 9
            Dim txb As TextBox = Me.Controls("txbFocusAbsolute" & FilterIndex.ToString)
            If txb IsNot Nothing Then
                txb.Enabled = enabledState
            End If
        Next
        If enabledState = True Then
            txbOffsetBaseFocus.Enabled = False
        Else
            txbOffsetBaseFocus.Enabled = True
        End If
    End Function

    Function SetFocusOffsetEnabled(ByVal EnabledState As Boolean)
        For FilterIndex As Integer = 1 To 9
            Dim txb As TextBox = Me.Controls("txbFocusoffset" & FilterIndex.ToString)
            If txb IsNot Nothing Then
                txb.Enabled = EnabledState
            End If
        Next
        If EnabledState = True Then
            txbOffsetBaseFocus.Enabled = True
        Else
            txbOffsetBaseFocus.Enabled = False
        End If
    End Function

    Function MoveFocusBySteps(ByVal Steps As Integer, ByVal Direction As String)
        If objFocuser IsNot Nothing Then
            'If objFocuser.IsMoving = False Then
            Dim currentPosition = objFocuser.Position
            If Direction = "in" Then
                objFocuser.Move(currentPosition - Steps)
            End If
            If Direction = "out" Then
                objFocuser.Move(currentPosition + Steps)
            End If
            'End If
        End If
    End Function

    Function PopulateFilterNames()
        If objFilterWheel IsNot Nothing Then
            For FilterIndex As Integer = 0 To objFilterWheel.Names.Length - 1
                Dim txb As TextBox = Me.Controls("txbFilterName" & FilterIndex.ToString + 1)
                txb.Text = objFilterWheel.Names.GetValue(FilterIndex)
            Next
        End If
    End Function

    Function ClearFilterNames()
        For FilterIndex As Integer = 1 To 9
            Dim txb As TextBox = Me.Controls("txbFilterName" & FilterIndex.ToString)
            txb.Text = ""
        Next
    End Function
    Function PopulateFocusOffsets()
        If objFilterWheel IsNot Nothing Then
            For FilterIndex As Integer = 0 To objFilterWheel.FocusOffsets.Length - 1
                Dim txb As TextBox = Me.Controls("FilterStoredFocusOffset" & FilterIndex.ToString + 1)
                txb.Text = objFilterWheel.FocusOffsets.GetValue(FilterIndex)
            Next
        End If
    End Function

    Function ClearFilterOffsets()
        For FilterIndex As Integer = 1 To 9
            Dim txb As TextBox = Me.Controls("FilterStoredFocusOffset" & FilterIndex.ToString)
            txb.Text = ""
        Next
    End Function

    Private Sub txbValidateKeyEntries(sender As Object, e As KeyPressEventArgs) Handles txbOffsetBaseFocus.KeyPress, txbFocusoffset9.KeyPress, txbFocusoffset8.KeyPress, txbFocusoffset7.KeyPress, txbFocusoffset6.KeyPress, txbFocusoffset5.KeyPress, txbFocusoffset4.KeyPress, txbFocusoffset3.KeyPress, txbFocusoffset2.KeyPress, txbFocusoffset1.KeyPress, txbFocusAbsolute9.KeyPress, txbFocusAbsolute8.KeyPress, txbFocusAbsolute7.KeyPress, txbFocusAbsolute6.KeyPress, txbFocusAbsolute5.KeyPress, txbFocusAbsolute4.KeyPress, txbFocusAbsolute3.KeyPress, txbFocusAbsolute2.KeyPress, txbFocusAbsolute1.KeyPress, txbSlowSteps.KeyPress, txbMediumSteps.KeyPress, txbFastSteps.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If e.KeyChar = "-" Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txbMoveFocus_leave(sender As Object, e As EventArgs) Handles txbOffsetBaseFocus.Leave, txbFocusoffset9.Leave, txbFocusoffset8.Leave, txbFocusoffset7.Leave, txbFocusoffset6.Leave, txbFocusoffset5.Leave, txbFocusoffset4.Leave, txbFocusoffset3.Leave, txbFocusoffset2.Leave, txbFocusoffset1.Leave, txbFocusAbsolute9.Leave, txbFocusAbsolute8.Leave, txbFocusAbsolute7.Leave, txbFocusAbsolute6.Leave, txbFocusAbsolute5.Leave, txbFocusAbsolute4.Leave, txbFocusAbsolute3.Leave, txbFocusAbsolute2.Leave, txbFocusAbsolute1.Leave
        Call MoveFocusForFilter(GlobalFocusmode)
    End Sub

    Private Sub TimerMoveFocus_Tick(sender As Object, e As EventArgs) Handles TimerMoveFocus.Tick
        If TimerMoveFocus.Enabled = True Then
            Call MoveFocusBySteps(GlobalFocusStepSize, GlobalFocusDirection)
        End If
    End Sub

    Private Sub btnFocusIn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFocusIn.MouseDown
        GlobalFocusDirection = "in"
        TimerMoveFocus.Interval = GlobalFocusTimerInterval
        Call SetGlobalFocusStepsize()
        TimerMoveFocus.Enabled = True
    End Sub

    Private Sub btnFocusIn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFocusIn.MouseUp
        TimerMoveFocus.Enabled = False
    End Sub
    Private Sub btnFocusOut_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFocusOut.MouseDown
        GlobalFocusDirection = "out"
        TimerMoveFocus.Interval = GlobalFocusTimerInterval
        Call SetGlobalFocusStepsize()
        TimerMoveFocus.Enabled = True
    End Sub

    Private Sub btnFocusOut_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFocusOut.MouseUp
        TimerMoveFocus.Enabled = False
    End Sub
    Function SetGlobalFocusStepsize()
        If rbFocusSpeedSlow.Checked = True Then
            GlobalFocusStepSize = txbSlowSteps.Text
        ElseIf rbFocusSpeedMedium.Checked = True Then
            GlobalFocusStepSize = txbMediumSteps.Text
        ElseIf rbFocusSpeedFast.Checked = True Then
            GlobalFocusStepSize = txbFastSteps.Text
        End If
    End Function
    Function SetFilterSelectRb(ByVal FilterPos As Integer)
        If objFilterWheel IsNot Nothing Then
            Dim rb As RadioButton = Me.Controls("gbFilterSelect").Controls("rbFilter" & GlobalCurrentFilterPos.ToString)
            rb.Checked = True
        End If
    End Function
    Function SelectFilter(ByVal FilterPositon As Integer)
        If objFilterWheel IsNot Nothing Then
            Dim currentPos As Integer = objFilterWheel.Position
            If currentPos >= 0 And currentPos <= 8 Then
                Call SetEnableStateFilterSelectRb(False)
                objFilterWheel.Position = FilterPositon - 1
                Call SetEnableStateFilterSelectRb(True)
            End If
        End If
    End Function
    Function SetEnableStateFilterSelectRb(ByVal rbEnabled As Boolean)
        'Enable Radio Buttons to select a Filter
        For FilterIndex As Integer = 1 To GlobalFilterCount
            Dim rb As RadioButton = Me.Controls("gbFilterSelect").Controls("rbFilter" & FilterIndex.ToString)
            rb.Enabled = rbEnabled
        Next
    End Function
    Private Sub rbFilter1_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter1.MouseClick
        SelectFilter(1)
    End Sub

    Private Sub rbFilter2_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter2.MouseClick
        SelectFilter(2)
    End Sub

    Private Sub rbFilter3_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter3.MouseClick
        SelectFilter(3)
    End Sub

    Private Sub rbFilter4_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter4.MouseClick
        SelectFilter(4)
    End Sub

    Private Sub rbFilter5_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter5.MouseClick
        SelectFilter(5)
    End Sub

    Private Sub rbFilter6_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter6.MouseClick
        SelectFilter(6)
    End Sub

    Private Sub rbFilter7_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter7.MouseClick
        SelectFilter(7)
    End Sub

    Private Sub rbFilter8_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter8.MouseClick
        SelectFilter(8)
    End Sub

    Private Sub rbFilter9_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilter9.MouseClick
        SelectFilter(9)
    End Sub
    Function StoreFocusPosition(ByVal FocusStoreType As String)
        If FocusStoreType = "filter" Then
            Dim tbCurrentAbsolute As TextBox = Me.Controls("txbFocusAbsolute" & GlobalCurrentFilterPos.ToString)
            Dim tbCurrentOffset As TextBox = Me.Controls("txbFocusoffset" & GlobalCurrentFilterPos.ToString)
            If objFocuser IsNot Nothing And objFilterWheel IsNot Nothing Then
                If objFilterWheel.Connected = True And objFocuser.Connected = True Then
                    tbCurrentAbsolute.Text = GlobalFocusPos
                    tbCurrentOffset.Text = GlobalFocusPos - txbOffsetBaseFocus.Text
                End If
            End If
        ElseIf FocusStoreType = "base" Then
            txbOffsetBaseFocus.Text = txbCurrentFocusPos.Text
        End If
    End Function
    Private Sub btnStoreFocusPosition_Click(sender As Object, e As EventArgs) Handles btnStoreFocusPosition.Click
        StoreFocusPosition("filter")
    End Sub

    Private Sub btnStoreBaseFocus_Click(sender As Object, e As EventArgs) Handles btnStoreBaseFocus.Click
        StoreFocusPosition("base")
    End Sub
End Class
