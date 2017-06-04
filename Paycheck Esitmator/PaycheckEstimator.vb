Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Linq

Public Class PaycheckEstimator
#Region "CONSTANTS"

#End Region

#Region "PAGE EVENTS"
    ' Page Load
    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Update the pay period setting if the new pay period has started.
        If Date.Compare(My.Settings.PayPeriodStartDate.AddDays(My.Settings.PayPeriodLength), Date.Today) < 0 Then
            My.Settings.PayPeriodStartDate = My.Settings.PayPeriodStartDate.AddDays(My.Settings.PayPeriodLength)
            My.Settings.Save()
        End If

        UpdateEstimatedPayStubLabels(UpdatePayStub(GetListOfDayItemControls()))

        Dim listOfLists As List(Of List) = GetListOfLists()

        lbxLists_ListBox.DataSource = listOfLists
        lbxLists_ListBox.DisplayMember = "Name"
        lbxLists_ListBox.ValueMember = "ID"

        lbxLists_ListBox.SetSelected(0, True)
    End Sub

    ' Day Item Load
    Private Sub DayItem_Load(sender As Object, e As System.EventArgs) Handles Monday_DayItem.Load, Tuesday_DayItem.Load, Wednesday_DayItem.Load, Thursday_DayItem.Load, _
                                                                                Friday_DayItem.Load, Saturday_DayItem.Load, Sunday_DayItem.Load

        ' The day item that is raising the on load event.
        Dim dayItem As DayItem_UserControl = sender

        Dim isDayOff As Boolean = GetIsDayOffSettingValue(dayItem.DayOfWeek)
        Dim hours As Decimal = GetTimeSettingValue(dayItem.DayOfWeek, "Hours")
        Dim minutes As Decimal = GetTimeSettingValue(dayItem.DayOfWeek, "Minutes")
        Dim lunchBreak As Decimal = GetTimeSettingValue(dayItem.DayOfWeek, "LunchBreak")

        SetDayItemProperties(dayItem, isDayOff, hours, minutes, lunchBreak)
    End Sub

    ' Calculate Pay Stub Button Click
    Private Sub btnCalculatePayStub_Button_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculatePayStub_Button.Click
        UpdateEstimatedPayStubLabels(UpdatePayStub(GetListOfDayItemControls()))
    End Sub

    ' Reset All Button Click
    Private Sub btnResetAll_Button_Click(sender As System.Object, e As System.EventArgs) Handles btnResetAll_Button.Click
        My.Settings.Reset()

        Dim listOfDayItems As List(Of DayItem_UserControl) = GetListOfDayItemControls()

        For i = 0 To listOfDayItems.Count - 1
            DayItem_Load(listOfDayItems(i), e)
        Next
    End Sub

    ' Pay Period Start Date Date Time Picker Value Changed
    Private Sub dtpPayPeriodStartDate_DateTimePicker_ValueChanged(sender As Object, e As System.EventArgs) Handles dtpPayPeriodStartDate_DateTimePicker.ValueChanged
        My.Settings.PayPeriodStartDate = dtpPayPeriodStartDate_DateTimePicker.Value
        My.Settings.Save()

        dtpPayPeriodEndDate_DateTimePicker.Value = My.Settings.PayPeriodStartDate.AddDays(My.Settings.PayPeriodLength - 1)
        lblPayPeriodEndDate_Label.Text = My.Settings.PayPeriodStartDate.AddDays(My.Settings.PayPeriodLength - 1).ToShortDateString()
    End Sub

    ' Additional Withholding Name Text Box Got Focus
    Private Sub txtAdditionalWithholdingName_TextBox_GotFocus(sender As Object, e As System.EventArgs) Handles txtAdditionalWithholdingName1_TextBox.GotFocus, txtAdditionalWithholdingName2_TextBox.GotFocus

        Dim txtAdditionalWithholding As Windows.Forms.TextBox = sender
        txtAdditionalWithholding.Text = String.Empty
    End Sub

    ' Additional Withholding Name Text Box Lost Focus
    Private Sub txtAdditionalWithholdingName_TextBox_LostFocus(sender As Object, e As System.EventArgs) Handles txtAdditionalWithholdingName1_TextBox.LostFocus, txtAdditionalWithholdingName2_TextBox.LostFocus
        Dim txtAdditionalWithholding As Windows.Forms.TextBox = sender

        Dim strNewText As String = txtAdditionalWithholding.Text
        If String.IsNullOrEmpty(strNewText) Then
            strNewText = My.Settings.Item("AdditionalWithholdingName" + txtAdditionalWithholding.Tag.ToString())
        ElseIf Not My.Settings.Item("AdditionalWithholdingName" + txtAdditionalWithholding.Tag.ToString()).Equals(strNewText) Then
            My.Settings.Item("AdditionalWithholdingName" + txtAdditionalWithholding.Tag.ToString()) = strNewText
            My.Settings.Save()
        End If

        txtAdditionalWithholding.Text = strNewText
    End Sub

    ' Additional Withholding Value Numeric Up Down Lost Focus
    Private Sub nudAdditionalWithholdingValue_NumericUpDown_LostFocus(sender As Object, e As System.EventArgs) Handles nudAdditionalWithholdingValue1_NumericUpDown.LostFocus, nudAdditionalWithholdingValue2_NumericUpDown.LostFocus
        Dim nudAdditionalWithholding As Windows.Forms.NumericUpDown = sender

        Dim amount As Decimal = nudAdditionalWithholding.Value
        If Not IsNumeric(amount) Then
            amount = My.Settings.Item("AdditionalWithholdingValue" + nudAdditionalWithholding.Tag.ToString())
        ElseIf Not My.Settings.Item("AdditionalWithholdingValue" + nudAdditionalWithholding.Tag.ToString()).Equals(amount) Then
            My.Settings.Item("AdditionalWithholdingValue" + nudAdditionalWithholding.Tag.ToString()) = amount
            My.Settings.Save()
        End If

        nudAdditionalWithholding.Value = amount
    End Sub
#End Region

#Region "PRIVATE METHODS"
    ' Get Total Minutes Worked
    Private Function GetTotalMinutesWorked(ByVal aryHours As Decimal(), ByVal aryMinutes As Decimal(), ByVal aryLunch As Decimal()) As Decimal
        Dim totalMinutes As Decimal = 0.0

        totalMinutes += ConvertHoursToMinutes(GetSumOfArrayElements(aryHours))
        totalMinutes += GetSumOfArrayElements(aryMinutes)
        totalMinutes -= GetSumOfArrayElements(aryLunch)

        Return totalMinutes
    End Function

    ' Get Additional Withholdings Array
    Private Function GetAdditionalWithholdingsArray() As AdditionalWithholding()
        Dim listAdditionalWithholdingsTextBoxes As List(Of TextBox) = GetListOfAdditionalWithholdingsTextBoxes()
        Dim listAdditionalWithholdingsNumericUpDowns As List(Of NumericUpDown) = GetListOfAdditionalWithholdingsNumericUpDowns()
        Dim additionalWithholdings(listAdditionalWithholdingsTextBoxes.Count - 1) As AdditionalWithholding
        For i = 0 To listAdditionalWithholdingsTextBoxes.Count - 1
            additionalWithholdings(i) = New AdditionalWithholding(listAdditionalWithholdingsTextBoxes(i).Text, listAdditionalWithholdingsNumericUpDowns(i).Value)
        Next

        Return additionalWithholdings
    End Function

    ' Update Pay Stub
    Private Function UpdatePayStub(ByVal listDayItemControls As List(Of DayItem_UserControl)) As PayStub
        Dim totalMinutesWorked As Decimal = GetTotalMinutesWorked(GetArrayOfHoursWorked(listDayItemControls), _
                                                                  GetArrayOfMinutesWorked(listDayItemControls), _
                                                                  GetArrayOfLunchBreakMinutesWorked(listDayItemControls))

        Dim additionalWithholdings() As AdditionalWithholding = GetAdditionalWithholdingsArray()

        Return New PayStub(My.Settings.PayPeriodStartDate, My.Settings.PayPeriodLength, My.Settings.PayRate, totalMinutesWorked, additionalWithholdings)
    End Function

    ' Update Estimated Pay Stub Labels
    Private Sub UpdateEstimatedPayStubLabels(ByVal estimatedPayStub As PayStub)
        ' Pay period date time pickers.
        DirectCast(dtpPayPeriodStartDate_DateTimePicker, DateTimePicker).Value = estimatedPayStub.PayPeriodStartDate
        DirectCast(dtpPayPeriodEndDate_DateTimePicker, DateTimePicker).Value = estimatedPayStub.PayPeriodEndDate

        ' Pay period and pay day labels.
        DirectCast(lblPayPeriodStartDate_Label, Label).Text = estimatedPayStub.PayPeriodStartDate.ToShortDateString()
        DirectCast(lblPayPeriodEndDate_Label, Label).Text = estimatedPayStub.PayPeriodEndDate.ToShortDateString()

        DirectCast(lblPaydayDayOfWeekValue_Label, Label).Text = estimatedPayStub.PayDate.DayOfWeek.ToString()
        DirectCast(lblPayDateValue_Label, Label).Text = estimatedPayStub.PayDate.ToShortDateString()

        ' Regular earnings labels.
        DirectCast(lblRegularHoursValue_Label, Label).Text = estimatedPayStub.RegularHours.ToString() + ":" + GetMinutesString(estimatedPayStub.RegularMinutes.ToString())
        DirectCast(lblRegularRateValue_Label, Label).Text = GetDollarString(estimatedPayStub.PayRate.ToString())
        DirectCast(lblTotalRegularEarningsValue_Label, Label).Text = GetDollarString(estimatedPayStub.RegularPay.ToString())

        ' Overtime earnings labels.
        DirectCast(lblOverTimeHoursValue_Label, Label).Text = estimatedPayStub.OvertimeHours.ToString() + ":" + GetMinutesString(estimatedPayStub.OvertimeMinutes.ToString())
        DirectCast(lblOverTimeRateValue_Label, Label).Text = GetDollarString(estimatedPayStub.OvertimePayRate.ToString())
        DirectCast(lblTotalOvertimeEarningsValue_Label, Label).Text = GetDollarString(estimatedPayStub.OvertimePay.ToString())

        ' Total earnings label.
        DirectCast(lblTotalEarningsValue_Label, Label).Text = "$" + (estimatedPayStub.RegularPay + estimatedPayStub.OvertimePay).ToString()

        ' Tax labels.
        DirectCast(lblTaxFederalValue_Label, Label).Text = "- " + estimatedPayStub.FederalWithholding.ToString()
        DirectCast(lblTaxStateValue_Label, Label).Text = "- " + estimatedPayStub.StateWithholding.ToString()
        DirectCast(lblTaxSocialSecurityValue_Label, Label).Text = "- " + estimatedPayStub.SocialSecurityWithholding.ToString()
        DirectCast(lblTaxMedicareValue_Label, Label).Text = "- " + estimatedPayStub.MedicareWithholding.ToString()

        ' Total taxes label.
        DirectCast(lblTotalTaxesValue_Label, Label).Text = "- $" + GetDollarString(estimatedPayStub.TotalTaxWithholdings.ToString())


        ' Additional Withholdings.
        Dim listOfAdditionalWithholdingsTextBoxes As List(Of TextBox) = GetListOfAdditionalWithholdingsTextBoxes()
        Dim listOfAdditionalWithholdingsNumericUpDowns As List(Of NumericUpDown) = GetListOfAdditionalWithholdingsNumericUpDowns()
        For i = 0 To estimatedPayStub.AdditionalWithholdings.Length - 1
            DirectCast(listOfAdditionalWithholdingsTextBoxes(i), TextBox).Text = estimatedPayStub.AdditionalWithholdings(i).Name
            DirectCast(listOfAdditionalWithholdingsNumericUpDowns(i), NumericUpDown).Value = estimatedPayStub.AdditionalWithholdings(i).Amount
        Next

        ' Total additional withholdings label.
        DirectCast(lblTotalAdditionalWithholdingsValue_Label, Label).Text = "- $" + GetDollarString(estimatedPayStub.TotalAdditionalWithholdings.ToString())

        ' Net pay label.
        DirectCast(lblNetPayValue_Label, Label).Text = "$" + GetDollarString(estimatedPayStub.NetIncome.ToString())
    End Sub

    ' Get Array Of Hours Worked
    Private Function GetArrayOfHoursWorked(ByVal listDayItems As List(Of DayItem_UserControl)) As Decimal()
        Dim aryHours(listDayItems.Count - 1) As Decimal

        For i = 0 To listDayItems.Count - 1
            aryHours(i) = listDayItems(i).HoursWorked
        Next

        Return aryHours
    End Function

    ' Get Array Of Minutes Worked
    Private Function GetArrayOfMinutesWorked(ByVal listDayItems As List(Of DayItem_UserControl)) As Decimal()
        Dim aryMinutes(listDayItems.Count - 1) As Decimal

        For i = 0 To listDayItems.Count - 1
            aryMinutes(i) = listDayItems(i).MinutesWorked
        Next

        Return aryMinutes
    End Function

    ' Get Array Of Lunch Break Minutes Worked
    Private Function GetArrayOfLunchBreakMinutesWorked(ByVal listDayItems As List(Of DayItem_UserControl)) As Decimal()
        Dim aryLunchMinutes(listDayItems.Count - 1) As Decimal

        For i = 0 To listDayItems.Count - 1
            aryLunchMinutes(i) = listDayItems(i).LunchBreakMinutes
        Next

        Return aryLunchMinutes
    End Function

    ' Get Is Day Off Setting Value
    Private Function GetIsDayOffSettingValue(ByVal strDayOfWeek As String) As Boolean
        Return My.Settings.Item(strDayOfWeek + "IsDayOff")
    End Function

    ' Get Time Setting Value
    Private Function GetTimeSettingValue(ByVal strDayOfWeek As String, ByVal strSettingName As String) As Decimal
        Return My.Settings.Item(strDayOfWeek + strSettingName)
    End Function

    ' Get Minutes String
    Private Function GetMinutesString(ByVal stringToConvert) As String
        Dim newString As String = String.Empty
        If stringToConvert.Length.Equals(1) Then
            stringToConvert += "0"
        End If

        Return stringToConvert + newString
    End Function

    ' Get Dollar String
    Private Function GetDollarString(ByVal stringToConvert As String) As String
        Dim substr As String = String.Empty
        If stringToConvert.IndexOf(".") >= 0 Then
            substr = stringToConvert.Substring(stringToConvert.IndexOf("."))
        End If

        Dim s As String = String.Empty
        Select Case substr.Length
            Case 0
                s = ".00"
            Case 2
                s = "0"
        End Select

        Return stringToConvert + s
    End Function

    ' Set Day Item Properties
    Private Sub SetDayItemProperties(ByVal dayItem As DayItem_UserControl, ByVal isDayOff As Boolean, ByVal hours As Decimal, _
                                    ByVal minutes As Decimal, ByVal lunchBrreak As Decimal)

        With dayItem
            .HoursWorked = hours
            .MinutesWorked = minutes
            .LunchBreakMinutes = lunchBrreak
            .IsDayOff = isDayOff
        End With
    End Sub

    ' Get List Of Day Item Controls
    Private Function GetListOfDayItemControls() As List(Of DayItem_UserControl)
        Dim listOfDayItems As New List(Of DayItem_UserControl)

        For Each cntrl As System.Windows.Forms.Control In Me.SplitContainer3.Panel2.Controls
            If cntrl.Name.EndsWith("_DayItem") Then
                listOfDayItems.Add(cntrl)
            End If
        Next

        Return listOfDayItems
    End Function

    ' Get List Of Additional Withholdings Text Boxes
    Private Function GetListOfAdditionalWithholdingsTextBoxes() As List(Of TextBox)
        Dim listOfTextBoxes As New List(Of TextBox)

        For i = 0 To Me.pnlAdditionalWithholdings_Panel.Controls.Count - 1
            If Me.pnlAdditionalWithholdings_Panel.Controls(i).Name.EndsWith("_TextBox") Then
                listOfTextBoxes.Add(Me.pnlAdditionalWithholdings_Panel.Controls(i))
            End If
        Next

        Return listOfTextBoxes
    End Function

    ' Get List Of Additional Withholdings Numeric Up Downs
    Private Function GetListOfAdditionalWithholdingsNumericUpDowns() As List(Of NumericUpDown)
        Dim listOfNumericUpDowns As New List(Of NumericUpDown)

        For i = 0 To Me.pnlAdditionalWithholdings_Panel.Controls.Count - 1
            If Me.pnlAdditionalWithholdings_Panel.Controls(i).Name.EndsWith("_NumericUpDown") Then
                listOfNumericUpDowns.Add(Me.pnlAdditionalWithholdings_Panel.Controls(i))
            End If
        Next

        Return listOfNumericUpDowns
    End Function

    ' Get Sum Of Array Elements
    Public Shared Function GetSumOfArrayElements(ByVal aryToAdd As Decimal()) As Decimal
        Dim sumOfArray As Decimal = 0
        For i = 0 To aryToAdd.Length - 1
            sumOfArray += aryToAdd(i)
        Next

        Return sumOfArray
    End Function

    ' Convert Hours To Minutes
    Public Shared Function ConvertHoursToMinutes(ByVal hours As Decimal) As Decimal
        Return Convert.ToDecimal(hours * 60)
    End Function
#End Region

    ' Add List Button Click
    Private Sub btnAddList_Button_Click(sender As System.Object, e As System.EventArgs) Handles btnAddList_Button.Click
        If ValidateNewListTextBox() Then
            lblNewListNameErrorMessage_Label.Visible = False

            Dim newList As List = CreateList()
            InsertList(newList)


            lbxLists_ListBox.Update()
        Else
            lblNewListNameErrorMessage_Label.Text = GetNewListNameErrorMessage()
            lblNewListNameErrorMessage_Label.Visible = True
        End If

        txtNewListName_TextBox.Text = String.Empty
    End Sub

    ' Add List Item Button Click
    Private Sub btnAddListItem_Button_Click(sender As System.Object, e As System.EventArgs) Handles btnAddListItem_Button.Click
        If ValidateNewListItemTextBox() Then
            lblNewListItemNameErrorMessage_Label.Visible = False

            Dim lstItem As New ListItem With
            {
                .ListID = lbxLists_ListBox.SelectedValue,
                .Name = txtNewListItemName_TextBox.Text,
                .Amount = 0,
                .Quantity = 1,
                .IsComplete = False
            }

            Dim db As New PaycheckEstimator_DataClassesDataContext
            db.ListItems.InsertOnSubmit(lstItem)
            db.SubmitChanges()

            Dim lstItemControl As New ListItem_UserControl(lbxLists_ListBox.SelectedValue, lstItem.Name, lstItem.Amount, lstItem.Quantity, lstItem.IsComplete)
            flpListItems_FlowLayoutPanel.Controls.Add(lstItemControl)
        Else
            lblNewListItemNameErrorMessage_Label.Text = GetNewListItemNameErrorMessage()
            lblNewListItemNameErrorMessage_Label.Visible = True
        End If

        txtNewListItemName_TextBox.Text = String.Empty
    End Sub

    ' Validate New List Text Box
    Private Function ValidateNewListTextBox() As Boolean
        If String.IsNullOrEmpty(txtNewListName_TextBox.Text) Then
            Return False
        End If

        For i = 0 To lbxLists_ListBox.Items.Count - 1
            If lbxLists_ListBox.Items(i).ToString.Equals(txtNewListName_TextBox.Text) Then
                Return False
            End If
        Next

        Return True
    End Function

    ' Get New List Name Error Message
    Private Function GetNewListNameErrorMessage() As String
        If String.IsNullOrEmpty(txtNewListName_TextBox.Text) Then
            Return "Please input a name for the new list."
        End If

        Return "That list already exists."
    End Function

    ' Validate New List Item Text Box
    Private Function ValidateNewListItemTextBox() As Boolean
        If String.IsNullOrEmpty(txtNewListItemName_TextBox.Text) Then
            Return False
        End If

        For i = 0 To flpListItems_FlowLayoutPanel.Controls.Count - 1
            Dim listItem As ListItem_UserControl = flpListItems_FlowLayoutPanel.Controls(i)
            If listItem.ItemName.Equals(txtNewListItemName_TextBox.Text) Then
                Return False
            End If
        Next

        If IsNothing(lbxLists_ListBox.SelectedIndex) Then
            Return False
        End If

        Return True
    End Function

    ' Get New List Item Name Error Message
    Private Function GetNewListItemNameErrorMessage() As String
        If String.IsNullOrEmpty(txtNewListItemName_TextBox.Text) Then
            Return "Please provide a name for the new list item."
        End If

        If IsNothing(lbxLists_ListBox.SelectedIndex) Then
            Return "Please select a list before adding a new item."
        End If

        Return "That item already exists in this list."
    End Function

    Private Sub tabsMain_TabControl_TabIndexChanged(sender As Object, e As System.EventArgs) Handles tabsMain_TabControl.TabIndexChanged
        If tabsMain_TabControl.TabIndex.Equals(0) Then
            Me.AcceptButton = btnCalculatePayStub_Button
        End If
    End Sub

    Private Sub txtNewListName_TextBox_GotFocus(sender As Object, e As System.EventArgs) Handles txtNewListName_TextBox.GotFocus
        Me.AcceptButton = btnAddList_Button
    End Sub

    Private Sub txtNewListName_TextBox_LostFocus(sender As Object, e As System.EventArgs) Handles txtNewListName_TextBox.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub txtNewListItemName_TextBox_GotFocus(sender As Object, e As System.EventArgs) Handles txtNewListItemName_TextBox.GotFocus
        Me.AcceptButton = btnAddListItem_Button
    End Sub

    Private Sub txtNewListItemName_TextBox_LostFocus(sender As Object, e As System.EventArgs) Handles txtNewListItemName_TextBox.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub lbxLists_ListBox_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lbxLists_ListBox.SelectedIndexChanged
        flpListItems_FlowLayoutPanel.Controls.Clear()

        Dim db As New PaycheckEstimator_DataClassesDataContext
        If Not TypeOf (lbxLists_ListBox.SelectedValue) Is Paycheck_Esitmator.List Then
            Dim listOfListItems As List(Of ListItem) = GetListOfListItems(lbxLists_ListBox.SelectedValue)
            Dim listOfListItemControls As New List(Of ListItem_UserControl)
            For i = 0 To listOfListItems.Count - 1
                listOfListItemControls.Add(New ListItem_UserControl(lbxLists_ListBox.SelectedValue, listOfListItems(i).Name, listOfListItems(i).Amount, listOfListItems(i).Quantity, listOfListItems(i).IsComplete))
            Next

            flpListItems_FlowLayoutPanel.Controls.AddRange(listOfListItemControls.ToArray)
        End If
    End Sub

    Private Function GetListOfLists() As List(Of List)
        Dim db As New PaycheckEstimator_DataClassesDataContext

        Return New List(Of List)(From l In db.Lists _
                                 Select l).ToList()
    End Function

    Private Function GetListOfListItems(ByVal idList As Guid) As List(Of ListItem)
        Dim db As New PaycheckEstimator_DataClassesDataContext

        Return New List(Of ListItem)(From li In db.ListItems _
                                      Where li.ListID.Equals(idList) _
                                      Select li).ToList()
    End Function

    Private Function CreateList() As List
        Return New List With
        {
            .ID = Guid.NewGuid(),
            .Name = txtNewListName_TextBox.Text,
            .PaystubID = Guid.Empty
        }
    End Function

    Private Sub InsertList(ByVal lst As List)
        Dim db As New PaycheckEstimator_DataClassesDataContext

        db.Lists.InsertOnSubmit(lst)

        Try
            db.SubmitChanges()
        Catch ex As Exception
            Console.WriteLine(ex)

            Close()
        End Try
    End Sub
End Class