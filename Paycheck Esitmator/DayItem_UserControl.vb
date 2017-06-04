Public Class DayItem_UserControl

#Region "PROPERTIES"
    ' Day Of Week
    Public Property DayOfWeek() As String
        Get
            Return lblDayOfWeek_Label.Text
        End Get
        Set(ByVal value As String)
            lblDayOfWeek_Label.Text = value
        End Set
    End Property

    ' Is Day Off
    Public Property IsDayOff() As Boolean
        Get
            Return cbxDayOff_CheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            cbxDayOff_CheckBox.Checked = value
        End Set
    End Property

    ' Hours Worked
    Public Property HoursWorked() As Decimal
        Get
            Return nudNumberOfHours_NumericUpDown.Value
        End Get
        Set(ByVal value As Decimal)
            nudNumberOfHours_NumericUpDown.Value = value
        End Set
    End Property

    ' Minutes Worked
    Public Property MinutesWorked() As Decimal
        Get
            Return nudNumberOfMinutes_NumericUpDown.Value
        End Get
        Set(ByVal value As Decimal)
            nudNumberOfMinutes_NumericUpDown.Value = value
        End Set
    End Property

    ' Lunch Break Minutes
    Public Property LunchBreakMinutes() As Decimal
        Get
            Return nudLunchBreakNumberOfMinutes_NumericUpDown.Value
        End Get
        Set(ByVal value As Decimal)
            nudLunchBreakNumberOfMinutes_NumericUpDown.Value = value
        End Set
    End Property
#End Region

#Region "PAGE EVENTS"
    Private Sub DayItem_UserControl_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        UpdateControls()
    End Sub
#End Region

    ' Update Controls
    Private Sub UpdateControls()
        If Me.IsDayOff Then
            With Me
                .nudNumberOfHours_NumericUpDown.Enabled = False

                .nudNumberOfMinutes_NumericUpDown.Enabled = False

                .nudLunchBreakNumberOfMinutes_NumericUpDown.Enabled = False
            End With
        Else
            With Me
                .nudNumberOfHours_NumericUpDown.Enabled = True

                .nudNumberOfMinutes_NumericUpDown.Enabled = True

                .nudLunchBreakNumberOfMinutes_NumericUpDown.Enabled = True
            End With
        End If
    End Sub

    Private Sub cbxDayOff_CheckBox_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbxDayOff_CheckBox.CheckedChanged
        UpdateControls()

        My.Settings.Item(Me.DayOfWeek + "IsDayOff") = cbxDayOff_CheckBox.Checked
        My.Settings.Save()

        If Me.IsDayOff Then
            nudNumberOfHours_NumericUpDown.Value = 0
            nudNumberOfMinutes_NumericUpDown.Value = 0
            nudLunchBreakNumberOfMinutes_NumericUpDown.Value = 0
        End If
    End Sub


    Private Sub NumericUpDown_GotFocus(sender As Object, e As System.EventArgs) Handles nudNumberOfHours_NumericUpDown.GotFocus, nudNumberOfMinutes_NumericUpDown.GotFocus, nudLunchBreakNumberOfMinutes_NumericUpDown.GotFocus, _
                                                                                        nudNumberOfHours_NumericUpDown.Click, nudNumberOfMinutes_NumericUpDown.Click, nudLunchBreakNumberOfMinutes_NumericUpDown.Click
        Dim numericUpDown As Windows.Forms.NumericUpDown = sender

        numericUpDown.Select(0, 3)
    End Sub

    Private Sub nudNumberOfHours_NumericUpDown_ValueChanged(sender As Object, e As System.EventArgs) Handles nudNumberOfHours_NumericUpDown.ValueChanged, nudNumberOfMinutes_NumericUpDown.ValueChanged, nudLunchBreakNumberOfMinutes_NumericUpDown.ValueChanged
        Dim updownTime As Windows.Forms.NumericUpDown = sender
        My.Settings.Item(Me.DayOfWeek + updownTime.Tag) = updownTime.Value

        My.Settings.Save()
    End Sub
End Class
