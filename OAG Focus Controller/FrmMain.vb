Public Class FrmMain
    Private objFilterWheel As ASCOM.DriverAccess.FilterWheel
    Private objFocuser As ASCOM.DriverAccess.Focuser

    Dim selectedFilter As Integer
    Dim GlobalFocusmode = "offset"
    Dim GlobalCurrentFilterPos = 0
    Dim GlobalFocusPos = 0

    Private Sub btnChooseEFW_Click(sender As Object, e As EventArgs) Handles btnChooseEFW.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "FilterWheel"
        My.Settings.EFW = obj.Choose(My.Settings.EFW)
    End Sub

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
                TimerUpdFilterPos.Start()
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TimerUpdFilterPos_Tick(sender As Object, e As EventArgs) Handles TimerUpdFilterPos.Tick
        GlobalCurrentFilterPos = objFilterWheel.Position
        If GlobalCurrentFilterPos >= 0 And GlobalCurrentFilterPos <= 8 And GlobalCurrentFilterPos + 1 <> txbFilterPos.Text Then
            txbFilterPos.Text = GlobalCurrentFilterPos + 1
            txbFilterName.Text = objFilterWheel.Names.GetValue(GlobalCurrentFilterPos)
            Call ChangeFocusMode(GlobalFocusmode)
        End If
    End Sub

    Private Sub btnDisconnectEFW_Click(sender As Object, e As EventArgs) Handles btnDisconnectEFW.Click
        TimerUpdFilterPos.Stop()
        objFilterWheel.Connected = False
        sender.enabled = False
        btnConnectEFW.Enabled = True
        btnChooseEFW.Enabled = True
        Call ClearFilterNames()
        Call ClearFilterOffsets()

    End Sub

    Private Sub btnChooseFocuser_Click(sender As Object, e As EventArgs) Handles btnChooseFocuser.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Focuser"
        My.Settings.Focuser = obj.Choose(My.Settings.Focuser)
    End Sub

    Private Sub btnConnectFocuser_Click(sender As Object, e As EventArgs) Handles btnConnectFocuser.Click
        If Not My.Settings.Focuser = "" Then
            objFocuser = New ASCOM.DriverAccess.Focuser(My.Settings.Focuser)
            Try
                objFocuser.Connected = True
                sender.enabled = False
                btnDisconnectFocuser.Enabled = True
                btnFocusIn.Enabled = True
                btnFocusOut.Enabled = True
                btnFocusInFine.Enabled = True
                btnFocusOutFine.Enabled = True
                btnChooseFocuser.Enabled = False
                Call ChangeFocusMode(GlobalFocusmode)
                TimerUpdFocuser.Start()
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TimerUpdFocuser_Tick(sender As Object, e As EventArgs) Handles TimerUpdFocuser.Tick
        GlobalFocusPos = objFocuser.Position
        If GlobalFocusPos > -1 Then
            txbCurrentFocusPos.Text = GlobalFocusPos
        End If
    End Sub

    Private Sub btnDisconnectFocuser_Click(sender As Object, e As EventArgs) Handles btnDisconnectFocuser.Click
        TimerUpdFocuser.Stop()
        objFocuser.Connected = False
        sender.enabled = False
        btnConnectFocuser.Enabled = True
        btnFocusIn.Enabled = False
        btnFocusOut.Enabled = False
        btnFocusInFine.Enabled = False
        btnFocusOutFine.Enabled = False
        btnChooseFocuser.Enabled = True
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.Save()
    End Sub

    Private Sub RadioButtonAbsolute_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAbsolute.CheckedChanged
        If sender.checked = True Then
            Call ChangeFocusMode("absolute")
        End If
    End Sub

    Private Sub RadioButtonOffset_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOffset.CheckedChanged
        If sender.checked = True Then
            Call ChangeFocusMode("offset")
        End If
    End Sub
    Function ChangeFocusMode(ByVal FocusMode As String)
        If FocusMode = "absolute" Then
            Call SetFocusAbsoluteReadonly(False)
            Call SetFocusOffsetReadonly(True)
        End If
        If FocusMode = "offset" Then
            Call SetFocusAbsoluteReadonly(True)
            Call SetFocusOffsetReadonly(False)
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

    Function SetFocusAbsoluteReadonly(ByVal readonlystate As Boolean)
        For FilterIndex As Integer = 1 To 9
            Dim txb As TextBox = Me.Controls("txbFocusAbsolute" & FilterIndex.ToString)
            If txb IsNot Nothing Then
                txb.ReadOnly = readonlystate
            End If
        Next
        If readonlystate = True Then
            txbOffsetBaseFocus.ReadOnly = False
        Else
            txbOffsetBaseFocus.ReadOnly = True
        End If
    End Function

    Function SetFocusOffsetReadonly(ByVal readonlystate As Boolean)
        For FilterIndex As Integer = 1 To 9
            Dim txb As TextBox = Me.Controls("txbFocusoffset" & FilterIndex.ToString)
            If txb IsNot Nothing Then
                txb.ReadOnly = readonlystate
            End If
        Next
        If readonlystate = True Then
            txbOffsetBaseFocus.ReadOnly = True
        Else
            txbOffsetBaseFocus.ReadOnly = False
        End If
    End Function

    Private Sub btnFocusIn_Click(sender As Object, e As EventArgs) Handles btnFocusIn.Click
        Call MoveFocusBySteps(txbSteps.Text, "in")
    End Sub

    Private Sub btnFocusOut_Click(sender As Object, e As EventArgs) Handles btnFocusOut.Click
        Call MoveFocusBySteps(txbSteps.Text, "out")
    End Sub

    Function MoveFocusBySteps(ByVal Steps As Integer, ByVal Direction As String)
        If objFocuser IsNot Nothing Then
            If objFocuser.IsMoving = False Then
                Dim currentPosition = objFocuser.Position
                If Direction = "in" Then
                    objFocuser.Move(currentPosition - Steps)
                End If
                If Direction = "out" Then
                    objFocuser.Move(currentPosition + Steps)
                End If
            End If
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


    Private Sub btnFocusInFine_Click(sender As Object, e As EventArgs) Handles btnFocusInFine.Click
        Call MoveFocusBySteps(txbFineSteps.Text, "in")
    End Sub

    Private Sub btnFocusOutFine_Click(sender As Object, e As EventArgs) Handles btnFocusOutFine.Click
        Call MoveFocusBySteps(txbFineSteps.Text, "out")
    End Sub

    Private Sub txbValidateKeyEntries(sender As Object, e As KeyPressEventArgs) Handles txbSteps.KeyPress, txbOffsetBaseFocus.KeyPress, txbFocusoffset9.KeyPress, txbFocusoffset8.KeyPress, txbFocusoffset7.KeyPress, txbFocusoffset6.KeyPress, txbFocusoffset5.KeyPress, txbFocusoffset4.KeyPress, txbFocusoffset3.KeyPress, txbFocusoffset2.KeyPress, txbFocusoffset1.KeyPress, txbFocusAbsolute9.KeyPress, txbFocusAbsolute8.KeyPress, txbFocusAbsolute7.KeyPress, txbFocusAbsolute6.KeyPress, txbFocusAbsolute5.KeyPress, txbFocusAbsolute4.KeyPress, txbFocusAbsolute3.KeyPress, txbFocusAbsolute2.KeyPress, txbFocusAbsolute1.KeyPress, txbFineSteps.KeyPress
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
End Class
