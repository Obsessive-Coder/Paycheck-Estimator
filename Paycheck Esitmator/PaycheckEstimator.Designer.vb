<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaycheckEstimator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabsMain_TabControl = New System.Windows.Forms.TabControl()
        Me.tabEstimator_TabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.dtpPayPeriodEndDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblPayPeriodStartDateLabel = New System.Windows.Forms.Label()
        Me.lblPayPeriodLabel = New System.Windows.Forms.Label()
        Me.dtpPayPeriodStartDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblPayPeriodEndDateLabel = New System.Windows.Forms.Label()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.btnResetAll_Button = New System.Windows.Forms.Button()
        Me.btnCalculatePayStub_Button = New System.Windows.Forms.Button()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.pnlNetPay_Panel = New System.Windows.Forms.Panel()
        Me.lblNetPayValue_Label = New System.Windows.Forms.Label()
        Me.pnlAdditionalWithholdings_Panel = New System.Windows.Forms.Panel()
        Me.nudAdditionalWithholdingValue2_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.nudAdditionalWithholdingValue1_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.txtAdditionalWithholdingName2_TextBox = New System.Windows.Forms.TextBox()
        Me.txtAdditionalWithholdingName1_TextBox = New System.Windows.Forms.TextBox()
        Me.lblTotalAdditionalWithholdingsValue_Label = New System.Windows.Forms.Label()
        Me.lblAdditionalWithholdings_Label = New System.Windows.Forms.Label()
        Me.lblTotalAdditionalWithholdings_Label = New System.Windows.Forms.Label()
        Me.pnlTaxes_Panel = New System.Windows.Forms.Panel()
        Me.lblTotalTaxesValue_Label = New System.Windows.Forms.Label()
        Me.lblTaxes_Label = New System.Windows.Forms.Label()
        Me.lblTaxMedicareValue_Label = New System.Windows.Forms.Label()
        Me.lblTaxFederalWithholding_Label = New System.Windows.Forms.Label()
        Me.lblTaxSocialSecurityValue_Label = New System.Windows.Forms.Label()
        Me.lblTaxStateWithholding_Label = New System.Windows.Forms.Label()
        Me.lblTaxStateValue_Label = New System.Windows.Forms.Label()
        Me.lblTaxSocialSecurityWitholding_Label = New System.Windows.Forms.Label()
        Me.lblTaxFederalValue_Label = New System.Windows.Forms.Label()
        Me.lblTaxMedicareWithholding_Label = New System.Windows.Forms.Label()
        Me.lblTotalTaxes_Label = New System.Windows.Forms.Label()
        Me.pnlEarnings_Panel = New System.Windows.Forms.Panel()
        Me.lblOverTimeEarnings_Label = New System.Windows.Forms.Label()
        Me.lblRegularEarnings_Label = New System.Windows.Forms.Label()
        Me.lblTotalEarningsValue_Label = New System.Windows.Forms.Label()
        Me.lblEarnings_Label = New System.Windows.Forms.Label()
        Me.lblTotalOvertimeEarningsValue_Label = New System.Windows.Forms.Label()
        Me.lblHours_Label = New System.Windows.Forms.Label()
        Me.lblTotalRegularEarningsValue_Label = New System.Windows.Forms.Label()
        Me.lblRate_Label = New System.Windows.Forms.Label()
        Me.lblOverTimeRateValue_Label = New System.Windows.Forms.Label()
        Me.lblTotalEarnings_Label = New System.Windows.Forms.Label()
        Me.lblRegularRateValue_Label = New System.Windows.Forms.Label()
        Me.lblRegularHoursValue_Label = New System.Windows.Forms.Label()
        Me.lblOverTimeHoursValue_Label = New System.Windows.Forms.Label()
        Me.pnlPayPeriodInformation_Panel = New System.Windows.Forms.Panel()
        Me.lblPayPeriodEnd_Label = New System.Windows.Forms.Label()
        Me.lblPayPeriodStart_Label = New System.Windows.Forms.Label()
        Me.lblPaydayDayOfWeekValue_Label = New System.Windows.Forms.Label()
        Me.lblPayDateValue_Label = New System.Windows.Forms.Label()
        Me.lblPayPeriodEndDate_Label = New System.Windows.Forms.Label()
        Me.lblPayPeriodStartDate_Label = New System.Windows.Forms.Label()
        Me.lblPayDay_Label = New System.Windows.Forms.Label()
        Me.lblPayPeriod_Label = New System.Windows.Forms.Label()
        Me.tabLists_TabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.lblNewListNameErrorMessage_Label = New System.Windows.Forms.Label()
        Me.txtNewListName_TextBox = New System.Windows.Forms.TextBox()
        Me.btnAddList_Button = New System.Windows.Forms.Button()
        Me.lbxLists_ListBox = New System.Windows.Forms.ListBox()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.lblNewListItemNameErrorMessage_Label = New System.Windows.Forms.Label()
        Me.txtNewListItemName_TextBox = New System.Windows.Forms.TextBox()
        Me.btnAddListItem_Button = New System.Windows.Forms.Button()
        Me.Monday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.Tuesday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.Wednesday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.Sunday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.Saturday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.Friday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.Thursday_DayItem = New Paycheck_Esitmator.DayItem_UserControl()
        Me.SplitContainer9 = New System.Windows.Forms.SplitContainer()
        Me.flpListItems_FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabsMain_TabControl.SuspendLayout()
        Me.tabEstimator_TabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.pnlNetPay_Panel.SuspendLayout()
        Me.pnlAdditionalWithholdings_Panel.SuspendLayout()
        CType(Me.nudAdditionalWithholdingValue2_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAdditionalWithholdingValue1_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTaxes_Panel.SuspendLayout()
        Me.pnlEarnings_Panel.SuspendLayout()
        Me.pnlPayPeriodInformation_Panel.SuspendLayout()
        Me.tabLists_TabPage.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer9.Panel1.SuspendLayout()
        Me.SplitContainer9.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabsMain_TabControl
        '
        Me.tabsMain_TabControl.Controls.Add(Me.tabEstimator_TabPage)
        Me.tabsMain_TabControl.Controls.Add(Me.tabLists_TabPage)
        Me.tabsMain_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsMain_TabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabsMain_TabControl.Name = "tabsMain_TabControl"
        Me.tabsMain_TabControl.SelectedIndex = 0
        Me.tabsMain_TabControl.Size = New System.Drawing.Size(797, 707)
        Me.tabsMain_TabControl.TabIndex = 0
        '
        'tabEstimator_TabPage
        '
        Me.tabEstimator_TabPage.Controls.Add(Me.SplitContainer1)
        Me.tabEstimator_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.tabEstimator_TabPage.Name = "tabEstimator_TabPage"
        Me.tabEstimator_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEstimator_TabPage.Size = New System.Drawing.Size(789, 681)
        Me.tabEstimator_TabPage.TabIndex = 0
        Me.tabEstimator_TabPage.Text = "Estimator"
        Me.tabEstimator_TabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer1.Size = New System.Drawing.Size(783, 675)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(246, 675)
        Me.SplitContainer2.SplitterDistance = 606
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.dtpPayPeriodEndDate_DateTimePicker)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblPayPeriodStartDateLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblPayPeriodLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.dtpPayPeriodStartDate_DateTimePicker)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblPayPeriodEndDateLabel)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Monday_DayItem)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Tuesday_DayItem)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Wednesday_DayItem)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Sunday_DayItem)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Saturday_DayItem)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Friday_DayItem)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Thursday_DayItem)
        Me.SplitContainer3.Size = New System.Drawing.Size(246, 606)
        Me.SplitContainer3.SplitterDistance = 98
        Me.SplitContainer3.TabIndex = 0
        '
        'dtpPayPeriodEndDate_DateTimePicker
        '
        Me.dtpPayPeriodEndDate_DateTimePicker.Enabled = False
        Me.dtpPayPeriodEndDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayPeriodEndDate_DateTimePicker.Location = New System.Drawing.Point(134, 75)
        Me.dtpPayPeriodEndDate_DateTimePicker.Name = "dtpPayPeriodEndDate_DateTimePicker"
        Me.dtpPayPeriodEndDate_DateTimePicker.Size = New System.Drawing.Size(107, 20)
        Me.dtpPayPeriodEndDate_DateTimePicker.TabIndex = 38
        '
        'lblPayPeriodStartDateLabel
        '
        Me.lblPayPeriodStartDateLabel.AutoSize = True
        Me.lblPayPeriodStartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodStartDateLabel.Location = New System.Drawing.Point(15, 48)
        Me.lblPayPeriodStartDateLabel.Name = "lblPayPeriodStartDateLabel"
        Me.lblPayPeriodStartDateLabel.Size = New System.Drawing.Size(89, 24)
        Me.lblPayPeriodStartDateLabel.TabIndex = 39
        Me.lblPayPeriodStartDateLabel.Text = "Start Date"
        '
        'lblPayPeriodLabel
        '
        Me.lblPayPeriodLabel.AutoSize = True
        Me.lblPayPeriodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodLabel.Location = New System.Drawing.Point(37, 10)
        Me.lblPayPeriodLabel.Name = "lblPayPeriodLabel"
        Me.lblPayPeriodLabel.Size = New System.Drawing.Size(172, 37)
        Me.lblPayPeriodLabel.TabIndex = 36
        Me.lblPayPeriodLabel.Text = "Pay Period"
        '
        'dtpPayPeriodStartDate_DateTimePicker
        '
        Me.dtpPayPeriodStartDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayPeriodStartDate_DateTimePicker.Location = New System.Drawing.Point(6, 75)
        Me.dtpPayPeriodStartDate_DateTimePicker.Name = "dtpPayPeriodStartDate_DateTimePicker"
        Me.dtpPayPeriodStartDate_DateTimePicker.Size = New System.Drawing.Size(107, 20)
        Me.dtpPayPeriodStartDate_DateTimePicker.TabIndex = 37
        '
        'lblPayPeriodEndDateLabel
        '
        Me.lblPayPeriodEndDateLabel.AutoSize = True
        Me.lblPayPeriodEndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodEndDateLabel.Location = New System.Drawing.Point(143, 48)
        Me.lblPayPeriodEndDateLabel.Name = "lblPayPeriodEndDateLabel"
        Me.lblPayPeriodEndDateLabel.Size = New System.Drawing.Size(88, 24)
        Me.lblPayPeriodEndDateLabel.TabIndex = 40
        Me.lblPayPeriodEndDateLabel.Text = "End Date"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnResetAll_Button)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnCalculatePayStub_Button)
        Me.SplitContainer4.Size = New System.Drawing.Size(246, 65)
        Me.SplitContainer4.SplitterDistance = 100
        Me.SplitContainer4.TabIndex = 0
        '
        'btnResetAll_Button
        '
        Me.btnResetAll_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnResetAll_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetAll_Button.Location = New System.Drawing.Point(0, 0)
        Me.btnResetAll_Button.Name = "btnResetAll_Button"
        Me.btnResetAll_Button.Size = New System.Drawing.Size(100, 65)
        Me.btnResetAll_Button.TabIndex = 6
        Me.btnResetAll_Button.Text = "Reset"
        Me.btnResetAll_Button.UseVisualStyleBackColor = True
        '
        'btnCalculatePayStub_Button
        '
        Me.btnCalculatePayStub_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCalculatePayStub_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculatePayStub_Button.Location = New System.Drawing.Point(0, 0)
        Me.btnCalculatePayStub_Button.Name = "btnCalculatePayStub_Button"
        Me.btnCalculatePayStub_Button.Size = New System.Drawing.Size(142, 65)
        Me.btnCalculatePayStub_Button.TabIndex = 5
        Me.btnCalculatePayStub_Button.Text = "Calculate"
        Me.btnCalculatePayStub_Button.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.pnlNetPay_Panel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.pnlAdditionalWithholdings_Panel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.pnlTaxes_Panel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.pnlEarnings_Panel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.pnlPayPeriodInformation_Panel)
        Me.SplitContainer5.Size = New System.Drawing.Size(533, 675)
        Me.SplitContainer5.SplitterDistance = 135
        Me.SplitContainer5.TabIndex = 0
        '
        'pnlNetPay_Panel
        '
        Me.pnlNetPay_Panel.Controls.Add(Me.lblNetPayValue_Label)
        Me.pnlNetPay_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlNetPay_Panel.Location = New System.Drawing.Point(0, 448)
        Me.pnlNetPay_Panel.Name = "pnlNetPay_Panel"
        Me.pnlNetPay_Panel.Size = New System.Drawing.Size(533, 88)
        Me.pnlNetPay_Panel.TabIndex = 4
        '
        'lblNetPayValue_Label
        '
        Me.lblNetPayValue_Label.AutoSize = True
        Me.lblNetPayValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayValue_Label.Location = New System.Drawing.Point(170, 19)
        Me.lblNetPayValue_Label.Name = "lblNetPayValue_Label"
        Me.lblNetPayValue_Label.Size = New System.Drawing.Size(178, 51)
        Me.lblNetPayValue_Label.TabIndex = 1
        Me.lblNetPayValue_Label.Text = "$888.88"
        '
        'pnlAdditionalWithholdings_Panel
        '
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.nudAdditionalWithholdingValue2_NumericUpDown)
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.nudAdditionalWithholdingValue1_NumericUpDown)
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.txtAdditionalWithholdingName2_TextBox)
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.txtAdditionalWithholdingName1_TextBox)
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.lblTotalAdditionalWithholdingsValue_Label)
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.lblAdditionalWithholdings_Label)
        Me.pnlAdditionalWithholdings_Panel.Controls.Add(Me.lblTotalAdditionalWithholdings_Label)
        Me.pnlAdditionalWithholdings_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAdditionalWithholdings_Panel.Location = New System.Drawing.Point(0, 325)
        Me.pnlAdditionalWithholdings_Panel.Name = "pnlAdditionalWithholdings_Panel"
        Me.pnlAdditionalWithholdings_Panel.Size = New System.Drawing.Size(533, 124)
        Me.pnlAdditionalWithholdings_Panel.TabIndex = 8
        '
        'nudAdditionalWithholdingValue2_NumericUpDown
        '
        Me.nudAdditionalWithholdingValue2_NumericUpDown.DecimalPlaces = 2
        Me.nudAdditionalWithholdingValue2_NumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudAdditionalWithholdingValue2_NumericUpDown.Location = New System.Drawing.Point(327, 52)
        Me.nudAdditionalWithholdingValue2_NumericUpDown.Maximum = New Decimal(New Integer() {88888, 0, 0, 0})
        Me.nudAdditionalWithholdingValue2_NumericUpDown.Name = "nudAdditionalWithholdingValue2_NumericUpDown"
        Me.nudAdditionalWithholdingValue2_NumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.nudAdditionalWithholdingValue2_NumericUpDown.TabIndex = 46
        Me.nudAdditionalWithholdingValue2_NumericUpDown.Tag = "2"
        Me.nudAdditionalWithholdingValue2_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudAdditionalWithholdingValue1_NumericUpDown
        '
        Me.nudAdditionalWithholdingValue1_NumericUpDown.DecimalPlaces = 2
        Me.nudAdditionalWithholdingValue1_NumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudAdditionalWithholdingValue1_NumericUpDown.Location = New System.Drawing.Point(327, 26)
        Me.nudAdditionalWithholdingValue1_NumericUpDown.Maximum = New Decimal(New Integer() {88888, 0, 0, 0})
        Me.nudAdditionalWithholdingValue1_NumericUpDown.Name = "nudAdditionalWithholdingValue1_NumericUpDown"
        Me.nudAdditionalWithholdingValue1_NumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.nudAdditionalWithholdingValue1_NumericUpDown.TabIndex = 45
        Me.nudAdditionalWithholdingValue1_NumericUpDown.Tag = "1"
        Me.nudAdditionalWithholdingValue1_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdditionalWithholdingName2_TextBox
        '
        Me.txtAdditionalWithholdingName2_TextBox.Location = New System.Drawing.Point(15, 52)
        Me.txtAdditionalWithholdingName2_TextBox.Name = "txtAdditionalWithholdingName2_TextBox"
        Me.txtAdditionalWithholdingName2_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.txtAdditionalWithholdingName2_TextBox.TabIndex = 44
        Me.txtAdditionalWithholdingName2_TextBox.Tag = "2"
        '
        'txtAdditionalWithholdingName1_TextBox
        '
        Me.txtAdditionalWithholdingName1_TextBox.Location = New System.Drawing.Point(15, 26)
        Me.txtAdditionalWithholdingName1_TextBox.Name = "txtAdditionalWithholdingName1_TextBox"
        Me.txtAdditionalWithholdingName1_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.txtAdditionalWithholdingName1_TextBox.TabIndex = 43
        Me.txtAdditionalWithholdingName1_TextBox.Tag = "1"
        '
        'lblTotalAdditionalWithholdingsValue_Label
        '
        Me.lblTotalAdditionalWithholdingsValue_Label.AutoSize = True
        Me.lblTotalAdditionalWithholdingsValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAdditionalWithholdingsValue_Label.Location = New System.Drawing.Point(330, 90)
        Me.lblTotalAdditionalWithholdingsValue_Label.Name = "lblTotalAdditionalWithholdingsValue_Label"
        Me.lblTotalAdditionalWithholdingsValue_Label.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalAdditionalWithholdingsValue_Label.TabIndex = 42
        Me.lblTotalAdditionalWithholdingsValue_Label.Text = "888.88"
        '
        'lblAdditionalWithholdings_Label
        '
        Me.lblAdditionalWithholdings_Label.AutoSize = True
        Me.lblAdditionalWithholdings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalWithholdings_Label.Location = New System.Drawing.Point(3, 3)
        Me.lblAdditionalWithholdings_Label.Name = "lblAdditionalWithholdings_Label"
        Me.lblAdditionalWithholdings_Label.Size = New System.Drawing.Size(178, 17)
        Me.lblAdditionalWithholdings_Label.TabIndex = 24
        Me.lblAdditionalWithholdings_Label.Text = "Additional Withholdings"
        '
        'lblTotalAdditionalWithholdings_Label
        '
        Me.lblTotalAdditionalWithholdings_Label.AutoSize = True
        Me.lblTotalAdditionalWithholdings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAdditionalWithholdings_Label.Location = New System.Drawing.Point(340, 5)
        Me.lblTotalAdditionalWithholdings_Label.Name = "lblTotalAdditionalWithholdings_Label"
        Me.lblTotalAdditionalWithholdings_Label.Size = New System.Drawing.Size(39, 15)
        Me.lblTotalAdditionalWithholdings_Label.TabIndex = 37
        Me.lblTotalAdditionalWithholdings_Label.Text = "Total"
        '
        'pnlTaxes_Panel
        '
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTotalTaxesValue_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxes_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxMedicareValue_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxFederalWithholding_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxSocialSecurityValue_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxStateWithholding_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxStateValue_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxSocialSecurityWitholding_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxFederalValue_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTaxMedicareWithholding_Label)
        Me.pnlTaxes_Panel.Controls.Add(Me.lblTotalTaxes_Label)
        Me.pnlTaxes_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTaxes_Panel.Location = New System.Drawing.Point(0, 180)
        Me.pnlTaxes_Panel.Name = "pnlTaxes_Panel"
        Me.pnlTaxes_Panel.Size = New System.Drawing.Size(533, 145)
        Me.pnlTaxes_Panel.TabIndex = 7
        '
        'lblTotalTaxesValue_Label
        '
        Me.lblTotalTaxesValue_Label.AutoSize = True
        Me.lblTotalTaxesValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTaxesValue_Label.Location = New System.Drawing.Point(329, 111)
        Me.lblTotalTaxesValue_Label.Name = "lblTotalTaxesValue_Label"
        Me.lblTotalTaxesValue_Label.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalTaxesValue_Label.TabIndex = 36
        Me.lblTotalTaxesValue_Label.Text = "888.88"
        '
        'lblTaxes_Label
        '
        Me.lblTaxes_Label.AutoSize = True
        Me.lblTaxes_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes_Label.Location = New System.Drawing.Point(3, 3)
        Me.lblTaxes_Label.Name = "lblTaxes_Label"
        Me.lblTaxes_Label.Size = New System.Drawing.Size(51, 17)
        Me.lblTaxes_Label.TabIndex = 23
        Me.lblTaxes_Label.Text = "Taxes"
        '
        'lblTaxMedicareValue_Label
        '
        Me.lblTaxMedicareValue_Label.AutoSize = True
        Me.lblTaxMedicareValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxMedicareValue_Label.Location = New System.Drawing.Point(335, 79)
        Me.lblTaxMedicareValue_Label.Name = "lblTaxMedicareValue_Label"
        Me.lblTaxMedicareValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblTaxMedicareValue_Label.TabIndex = 35
        Me.lblTaxMedicareValue_Label.Text = "888.88"
        '
        'lblTaxFederalWithholding_Label
        '
        Me.lblTaxFederalWithholding_Label.AutoSize = True
        Me.lblTaxFederalWithholding_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxFederalWithholding_Label.Location = New System.Drawing.Point(15, 28)
        Me.lblTaxFederalWithholding_Label.Name = "lblTaxFederalWithholding_Label"
        Me.lblTaxFederalWithholding_Label.Size = New System.Drawing.Size(134, 17)
        Me.lblTaxFederalWithholding_Label.TabIndex = 24
        Me.lblTaxFederalWithholding_Label.Text = "Federal Withholding"
        '
        'lblTaxSocialSecurityValue_Label
        '
        Me.lblTaxSocialSecurityValue_Label.AutoSize = True
        Me.lblTaxSocialSecurityValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxSocialSecurityValue_Label.Location = New System.Drawing.Point(335, 62)
        Me.lblTaxSocialSecurityValue_Label.Name = "lblTaxSocialSecurityValue_Label"
        Me.lblTaxSocialSecurityValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblTaxSocialSecurityValue_Label.TabIndex = 34
        Me.lblTaxSocialSecurityValue_Label.Text = "888.88"
        '
        'lblTaxStateWithholding_Label
        '
        Me.lblTaxStateWithholding_Label.AutoSize = True
        Me.lblTaxStateWithholding_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxStateWithholding_Label.Location = New System.Drawing.Point(15, 45)
        Me.lblTaxStateWithholding_Label.Name = "lblTaxStateWithholding_Label"
        Me.lblTaxStateWithholding_Label.Size = New System.Drawing.Size(119, 17)
        Me.lblTaxStateWithholding_Label.TabIndex = 25
        Me.lblTaxStateWithholding_Label.Text = "State Withholding"
        '
        'lblTaxStateValue_Label
        '
        Me.lblTaxStateValue_Label.AutoSize = True
        Me.lblTaxStateValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxStateValue_Label.Location = New System.Drawing.Point(335, 45)
        Me.lblTaxStateValue_Label.Name = "lblTaxStateValue_Label"
        Me.lblTaxStateValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblTaxStateValue_Label.TabIndex = 33
        Me.lblTaxStateValue_Label.Text = "888.88"
        '
        'lblTaxSocialSecurityWitholding_Label
        '
        Me.lblTaxSocialSecurityWitholding_Label.AutoSize = True
        Me.lblTaxSocialSecurityWitholding_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxSocialSecurityWitholding_Label.Location = New System.Drawing.Point(15, 62)
        Me.lblTaxSocialSecurityWitholding_Label.Name = "lblTaxSocialSecurityWitholding_Label"
        Me.lblTaxSocialSecurityWitholding_Label.Size = New System.Drawing.Size(167, 17)
        Me.lblTaxSocialSecurityWitholding_Label.TabIndex = 26
        Me.lblTaxSocialSecurityWitholding_Label.Text = "Social Security Employee"
        '
        'lblTaxFederalValue_Label
        '
        Me.lblTaxFederalValue_Label.AutoSize = True
        Me.lblTaxFederalValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxFederalValue_Label.Location = New System.Drawing.Point(335, 28)
        Me.lblTaxFederalValue_Label.Name = "lblTaxFederalValue_Label"
        Me.lblTaxFederalValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblTaxFederalValue_Label.TabIndex = 32
        Me.lblTaxFederalValue_Label.Text = "888.88"
        '
        'lblTaxMedicareWithholding_Label
        '
        Me.lblTaxMedicareWithholding_Label.AutoSize = True
        Me.lblTaxMedicareWithholding_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxMedicareWithholding_Label.Location = New System.Drawing.Point(15, 79)
        Me.lblTaxMedicareWithholding_Label.Name = "lblTaxMedicareWithholding_Label"
        Me.lblTaxMedicareWithholding_Label.Size = New System.Drawing.Size(132, 17)
        Me.lblTaxMedicareWithholding_Label.TabIndex = 27
        Me.lblTaxMedicareWithholding_Label.Text = "Medicare Employee"
        '
        'lblTotalTaxes_Label
        '
        Me.lblTotalTaxes_Label.AutoSize = True
        Me.lblTotalTaxes_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTaxes_Label.Location = New System.Drawing.Point(340, 5)
        Me.lblTotalTaxes_Label.Name = "lblTotalTaxes_Label"
        Me.lblTotalTaxes_Label.Size = New System.Drawing.Size(39, 15)
        Me.lblTotalTaxes_Label.TabIndex = 28
        Me.lblTotalTaxes_Label.Text = "Total"
        '
        'pnlEarnings_Panel
        '
        Me.pnlEarnings_Panel.Controls.Add(Me.lblOverTimeEarnings_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblRegularEarnings_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblTotalEarningsValue_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblEarnings_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblTotalOvertimeEarningsValue_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblHours_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblTotalRegularEarningsValue_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblRate_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblOverTimeRateValue_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblTotalEarnings_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblRegularRateValue_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblRegularHoursValue_Label)
        Me.pnlEarnings_Panel.Controls.Add(Me.lblOverTimeHoursValue_Label)
        Me.pnlEarnings_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEarnings_Panel.Location = New System.Drawing.Point(0, 73)
        Me.pnlEarnings_Panel.Name = "pnlEarnings_Panel"
        Me.pnlEarnings_Panel.Size = New System.Drawing.Size(533, 107)
        Me.pnlEarnings_Panel.TabIndex = 5
        '
        'lblOverTimeEarnings_Label
        '
        Me.lblOverTimeEarnings_Label.AutoSize = True
        Me.lblOverTimeEarnings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverTimeEarnings_Label.Location = New System.Drawing.Point(15, 41)
        Me.lblOverTimeEarnings_Label.Name = "lblOverTimeEarnings_Label"
        Me.lblOverTimeEarnings_Label.Size = New System.Drawing.Size(70, 17)
        Me.lblOverTimeEarnings_Label.TabIndex = 34
        Me.lblOverTimeEarnings_Label.Text = "OverTime"
        '
        'lblRegularEarnings_Label
        '
        Me.lblRegularEarnings_Label.AutoSize = True
        Me.lblRegularEarnings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegularEarnings_Label.Location = New System.Drawing.Point(15, 24)
        Me.lblRegularEarnings_Label.Name = "lblRegularEarnings_Label"
        Me.lblRegularEarnings_Label.Size = New System.Drawing.Size(58, 17)
        Me.lblRegularEarnings_Label.TabIndex = 33
        Me.lblRegularEarnings_Label.Text = "Regular"
        '
        'lblTotalEarningsValue_Label
        '
        Me.lblTotalEarningsValue_Label.AutoSize = True
        Me.lblTotalEarningsValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEarningsValue_Label.Location = New System.Drawing.Point(329, 73)
        Me.lblTotalEarningsValue_Label.Name = "lblTotalEarningsValue_Label"
        Me.lblTotalEarningsValue_Label.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalEarningsValue_Label.TabIndex = 32
        Me.lblTotalEarningsValue_Label.Text = "888.88"
        '
        'lblEarnings_Label
        '
        Me.lblEarnings_Label.AutoSize = True
        Me.lblEarnings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarnings_Label.Location = New System.Drawing.Point(3, 3)
        Me.lblEarnings_Label.Name = "lblEarnings_Label"
        Me.lblEarnings_Label.Size = New System.Drawing.Size(72, 17)
        Me.lblEarnings_Label.TabIndex = 22
        Me.lblEarnings_Label.Text = "Earnings"
        '
        'lblTotalOvertimeEarningsValue_Label
        '
        Me.lblTotalOvertimeEarningsValue_Label.AutoSize = True
        Me.lblTotalOvertimeEarningsValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOvertimeEarningsValue_Label.Location = New System.Drawing.Point(335, 41)
        Me.lblTotalOvertimeEarningsValue_Label.Name = "lblTotalOvertimeEarningsValue_Label"
        Me.lblTotalOvertimeEarningsValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblTotalOvertimeEarningsValue_Label.TabIndex = 31
        Me.lblTotalOvertimeEarningsValue_Label.Text = "888.88"
        '
        'lblHours_Label
        '
        Me.lblHours_Label.AutoSize = True
        Me.lblHours_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours_Label.Location = New System.Drawing.Point(152, 7)
        Me.lblHours_Label.Name = "lblHours_Label"
        Me.lblHours_Label.Size = New System.Drawing.Size(40, 13)
        Me.lblHours_Label.TabIndex = 23
        Me.lblHours_Label.Text = "Hours"
        '
        'lblTotalRegularEarningsValue_Label
        '
        Me.lblTotalRegularEarningsValue_Label.AutoSize = True
        Me.lblTotalRegularEarningsValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegularEarningsValue_Label.Location = New System.Drawing.Point(335, 24)
        Me.lblTotalRegularEarningsValue_Label.Name = "lblTotalRegularEarningsValue_Label"
        Me.lblTotalRegularEarningsValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblTotalRegularEarningsValue_Label.TabIndex = 30
        Me.lblTotalRegularEarningsValue_Label.Text = "888.88"
        '
        'lblRate_Label
        '
        Me.lblRate_Label.AutoSize = True
        Me.lblRate_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate_Label.Location = New System.Drawing.Point(249, 7)
        Me.lblRate_Label.Name = "lblRate_Label"
        Me.lblRate_Label.Size = New System.Drawing.Size(34, 13)
        Me.lblRate_Label.TabIndex = 24
        Me.lblRate_Label.Text = "Rate"
        '
        'lblOverTimeRateValue_Label
        '
        Me.lblOverTimeRateValue_Label.AutoSize = True
        Me.lblOverTimeRateValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverTimeRateValue_Label.Location = New System.Drawing.Point(244, 41)
        Me.lblOverTimeRateValue_Label.Name = "lblOverTimeRateValue_Label"
        Me.lblOverTimeRateValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblOverTimeRateValue_Label.TabIndex = 29
        Me.lblOverTimeRateValue_Label.Text = "888.88"
        '
        'lblTotalEarnings_Label
        '
        Me.lblTotalEarnings_Label.AutoSize = True
        Me.lblTotalEarnings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEarnings_Label.Location = New System.Drawing.Point(340, 5)
        Me.lblTotalEarnings_Label.Name = "lblTotalEarnings_Label"
        Me.lblTotalEarnings_Label.Size = New System.Drawing.Size(39, 15)
        Me.lblTotalEarnings_Label.TabIndex = 25
        Me.lblTotalEarnings_Label.Text = "Total"
        '
        'lblRegularRateValue_Label
        '
        Me.lblRegularRateValue_Label.AutoSize = True
        Me.lblRegularRateValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegularRateValue_Label.Location = New System.Drawing.Point(244, 24)
        Me.lblRegularRateValue_Label.Name = "lblRegularRateValue_Label"
        Me.lblRegularRateValue_Label.Size = New System.Drawing.Size(52, 17)
        Me.lblRegularRateValue_Label.TabIndex = 28
        Me.lblRegularRateValue_Label.Text = "888.88"
        '
        'lblRegularHoursValue_Label
        '
        Me.lblRegularHoursValue_Label.AutoSize = True
        Me.lblRegularHoursValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegularHoursValue_Label.Location = New System.Drawing.Point(150, 24)
        Me.lblRegularHoursValue_Label.Name = "lblRegularHoursValue_Label"
        Me.lblRegularHoursValue_Label.Size = New System.Drawing.Size(44, 17)
        Me.lblRegularHoursValue_Label.TabIndex = 26
        Me.lblRegularHoursValue_Label.Text = "88:88"
        '
        'lblOverTimeHoursValue_Label
        '
        Me.lblOverTimeHoursValue_Label.AutoSize = True
        Me.lblOverTimeHoursValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverTimeHoursValue_Label.Location = New System.Drawing.Point(150, 41)
        Me.lblOverTimeHoursValue_Label.Name = "lblOverTimeHoursValue_Label"
        Me.lblOverTimeHoursValue_Label.Size = New System.Drawing.Size(44, 17)
        Me.lblOverTimeHoursValue_Label.TabIndex = 27
        Me.lblOverTimeHoursValue_Label.Text = "88:88"
        '
        'pnlPayPeriodInformation_Panel
        '
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayPeriodEnd_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayPeriodStart_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPaydayDayOfWeekValue_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayDateValue_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayPeriodEndDate_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayPeriodStartDate_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayDay_Label)
        Me.pnlPayPeriodInformation_Panel.Controls.Add(Me.lblPayPeriod_Label)
        Me.pnlPayPeriodInformation_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPayPeriodInformation_Panel.Location = New System.Drawing.Point(0, 0)
        Me.pnlPayPeriodInformation_Panel.Name = "pnlPayPeriodInformation_Panel"
        Me.pnlPayPeriodInformation_Panel.Size = New System.Drawing.Size(533, 73)
        Me.pnlPayPeriodInformation_Panel.TabIndex = 6
        '
        'lblPayPeriodEnd_Label
        '
        Me.lblPayPeriodEnd_Label.AutoSize = True
        Me.lblPayPeriodEnd_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodEnd_Label.Location = New System.Drawing.Point(155, 28)
        Me.lblPayPeriodEnd_Label.Name = "lblPayPeriodEnd_Label"
        Me.lblPayPeriodEnd_Label.Size = New System.Drawing.Size(36, 17)
        Me.lblPayPeriodEnd_Label.TabIndex = 7
        Me.lblPayPeriodEnd_Label.Text = "End"
        Me.lblPayPeriodEnd_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayPeriodStart_Label
        '
        Me.lblPayPeriodStart_Label.AutoSize = True
        Me.lblPayPeriodStart_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodStart_Label.Location = New System.Drawing.Point(47, 28)
        Me.lblPayPeriodStart_Label.Name = "lblPayPeriodStart_Label"
        Me.lblPayPeriodStart_Label.Size = New System.Drawing.Size(43, 17)
        Me.lblPayPeriodStart_Label.TabIndex = 6
        Me.lblPayPeriodStart_Label.Text = "Start"
        Me.lblPayPeriodStart_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPaydayDayOfWeekValue_Label
        '
        Me.lblPaydayDayOfWeekValue_Label.AutoSize = True
        Me.lblPaydayDayOfWeekValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaydayDayOfWeekValue_Label.Location = New System.Drawing.Point(306, 28)
        Me.lblPaydayDayOfWeekValue_Label.Name = "lblPaydayDayOfWeekValue_Label"
        Me.lblPaydayDayOfWeekValue_Label.Size = New System.Drawing.Size(53, 17)
        Me.lblPaydayDayOfWeekValue_Label.TabIndex = 5
        Me.lblPaydayDayOfWeekValue_Label.Text = "Friday"
        Me.lblPaydayDayOfWeekValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayDateValue_Label
        '
        Me.lblPayDateValue_Label.AutoSize = True
        Me.lblPayDateValue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayDateValue_Label.Location = New System.Drawing.Point(288, 45)
        Me.lblPayDateValue_Label.Name = "lblPayDateValue_Label"
        Me.lblPayDateValue_Label.Size = New System.Drawing.Size(89, 20)
        Me.lblPayDateValue_Label.TabIndex = 4
        Me.lblPayDateValue_Label.Text = "88/88/8888"
        Me.lblPayDateValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayPeriodEndDate_Label
        '
        Me.lblPayPeriodEndDate_Label.AutoSize = True
        Me.lblPayPeriodEndDate_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodEndDate_Label.Location = New System.Drawing.Point(129, 45)
        Me.lblPayPeriodEndDate_Label.Name = "lblPayPeriodEndDate_Label"
        Me.lblPayPeriodEndDate_Label.Size = New System.Drawing.Size(89, 20)
        Me.lblPayPeriodEndDate_Label.TabIndex = 3
        Me.lblPayPeriodEndDate_Label.Text = "88/88/8888"
        '
        'lblPayPeriodStartDate_Label
        '
        Me.lblPayPeriodStartDate_Label.AutoSize = True
        Me.lblPayPeriodStartDate_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodStartDate_Label.Location = New System.Drawing.Point(24, 45)
        Me.lblPayPeriodStartDate_Label.Name = "lblPayPeriodStartDate_Label"
        Me.lblPayPeriodStartDate_Label.Size = New System.Drawing.Size(89, 20)
        Me.lblPayPeriodStartDate_Label.TabIndex = 2
        Me.lblPayPeriodStartDate_Label.Text = "88/88/8888"
        '
        'lblPayDay_Label
        '
        Me.lblPayDay_Label.AutoSize = True
        Me.lblPayDay_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayDay_Label.Location = New System.Drawing.Point(295, 9)
        Me.lblPayDay_Label.Name = "lblPayDay_Label"
        Me.lblPayDay_Label.Size = New System.Drawing.Size(74, 20)
        Me.lblPayDay_Label.TabIndex = 1
        Me.lblPayDay_Label.Text = "Pay Day"
        Me.lblPayDay_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayPeriod_Label
        '
        Me.lblPayPeriod_Label.AutoSize = True
        Me.lblPayPeriod_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriod_Label.Location = New System.Drawing.Point(75, 9)
        Me.lblPayPeriod_Label.Name = "lblPayPeriod_Label"
        Me.lblPayPeriod_Label.Size = New System.Drawing.Size(94, 20)
        Me.lblPayPeriod_Label.TabIndex = 0
        Me.lblPayPeriod_Label.Text = "Pay Period"
        '
        'tabLists_TabPage
        '
        Me.tabLists_TabPage.Controls.Add(Me.SplitContainer6)
        Me.tabLists_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.tabLists_TabPage.Name = "tabLists_TabPage"
        Me.tabLists_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLists_TabPage.Size = New System.Drawing.Size(789, 681)
        Me.tabLists_TabPage.TabIndex = 1
        Me.tabLists_TabPage.Text = "Lists"
        Me.tabLists_TabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.IsSplitterFixed = True
        Me.SplitContainer6.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.SplitContainer8)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.SplitContainer7)
        Me.SplitContainer6.Size = New System.Drawing.Size(783, 675)
        Me.SplitContainer6.SplitterDistance = 261
        Me.SplitContainer6.TabIndex = 0
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        Me.SplitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.lblNewListNameErrorMessage_Label)
        Me.SplitContainer8.Panel1.Controls.Add(Me.txtNewListName_TextBox)
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnAddList_Button)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.Controls.Add(Me.lbxLists_ListBox)
        Me.SplitContainer8.Size = New System.Drawing.Size(261, 675)
        Me.SplitContainer8.SplitterDistance = 40
        Me.SplitContainer8.TabIndex = 0
        '
        'lblNewListNameErrorMessage_Label
        '
        Me.lblNewListNameErrorMessage_Label.AutoSize = True
        Me.lblNewListNameErrorMessage_Label.ForeColor = System.Drawing.Color.Red
        Me.lblNewListNameErrorMessage_Label.Location = New System.Drawing.Point(20, 4)
        Me.lblNewListNameErrorMessage_Label.Name = "lblNewListNameErrorMessage_Label"
        Me.lblNewListNameErrorMessage_Label.Size = New System.Drawing.Size(177, 13)
        Me.lblNewListNameErrorMessage_Label.TabIndex = 4
        Me.lblNewListNameErrorMessage_Label.Text = "Please input a name for the new list."
        Me.lblNewListNameErrorMessage_Label.Visible = False
        '
        'txtNewListName_TextBox
        '
        Me.txtNewListName_TextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtNewListName_TextBox.Location = New System.Drawing.Point(0, 20)
        Me.txtNewListName_TextBox.Name = "txtNewListName_TextBox"
        Me.txtNewListName_TextBox.Size = New System.Drawing.Size(216, 20)
        Me.txtNewListName_TextBox.TabIndex = 3
        '
        'btnAddList_Button
        '
        Me.btnAddList_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddList_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddList_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList_Button.Location = New System.Drawing.Point(216, 0)
        Me.btnAddList_Button.Name = "btnAddList_Button"
        Me.btnAddList_Button.Size = New System.Drawing.Size(45, 40)
        Me.btnAddList_Button.TabIndex = 1
        Me.btnAddList_Button.Text = "+"
        Me.btnAddList_Button.UseVisualStyleBackColor = True
        '
        'lbxLists_ListBox
        '
        Me.lbxLists_ListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxLists_ListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxLists_ListBox.FormattingEnabled = True
        Me.lbxLists_ListBox.ItemHeight = 29
        Me.lbxLists_ListBox.Location = New System.Drawing.Point(0, 0)
        Me.lbxLists_ListBox.Name = "lbxLists_ListBox"
        Me.lbxLists_ListBox.Size = New System.Drawing.Size(261, 631)
        Me.lbxLists_ListBox.TabIndex = 0
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.IsSplitterFixed = True
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.lblNewListItemNameErrorMessage_Label)
        Me.SplitContainer7.Panel1.Controls.Add(Me.txtNewListItemName_TextBox)
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnAddListItem_Button)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.SplitContainer9)
        Me.SplitContainer7.Size = New System.Drawing.Size(518, 675)
        Me.SplitContainer7.SplitterDistance = 39
        Me.SplitContainer7.TabIndex = 0
        '
        'lblNewListItemNameErrorMessage_Label
        '
        Me.lblNewListItemNameErrorMessage_Label.AutoSize = True
        Me.lblNewListItemNameErrorMessage_Label.ForeColor = System.Drawing.Color.Red
        Me.lblNewListItemNameErrorMessage_Label.Location = New System.Drawing.Point(9, 4)
        Me.lblNewListItemNameErrorMessage_Label.Name = "lblNewListItemNameErrorMessage_Label"
        Me.lblNewListItemNameErrorMessage_Label.Size = New System.Drawing.Size(199, 13)
        Me.lblNewListItemNameErrorMessage_Label.TabIndex = 5
        Me.lblNewListItemNameErrorMessage_Label.Text = "Please input a name for the new list item."
        Me.lblNewListItemNameErrorMessage_Label.Visible = False
        '
        'txtNewListItemName_TextBox
        '
        Me.txtNewListItemName_TextBox.Location = New System.Drawing.Point(0, 20)
        Me.txtNewListItemName_TextBox.Name = "txtNewListItemName_TextBox"
        Me.txtNewListItemName_TextBox.Size = New System.Drawing.Size(216, 20)
        Me.txtNewListItemName_TextBox.TabIndex = 3
        '
        'btnAddListItem_Button
        '
        Me.btnAddListItem_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddListItem_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddListItem_Button.Location = New System.Drawing.Point(216, 0)
        Me.btnAddListItem_Button.Name = "btnAddListItem_Button"
        Me.btnAddListItem_Button.Size = New System.Drawing.Size(45, 40)
        Me.btnAddListItem_Button.TabIndex = 0
        Me.btnAddListItem_Button.Text = "+"
        Me.btnAddListItem_Button.UseVisualStyleBackColor = True
        '
        'Monday_DayItem
        '
        Me.Monday_DayItem.DayOfWeek = "Monday"
        Me.Monday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Monday_DayItem.IsDayOff = False
        Me.Monday_DayItem.Location = New System.Drawing.Point(2, 2)
        Me.Monday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Monday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Monday_DayItem.Name = "Monday_DayItem"
        Me.Monday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Monday_DayItem.TabIndex = 38
        '
        'Tuesday_DayItem
        '
        Me.Tuesday_DayItem.DayOfWeek = "Tuesday"
        Me.Tuesday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Tuesday_DayItem.IsDayOff = False
        Me.Tuesday_DayItem.Location = New System.Drawing.Point(2, 73)
        Me.Tuesday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Tuesday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Tuesday_DayItem.Name = "Tuesday_DayItem"
        Me.Tuesday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Tuesday_DayItem.TabIndex = 39
        '
        'Wednesday_DayItem
        '
        Me.Wednesday_DayItem.DayOfWeek = "Wednesday"
        Me.Wednesday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Wednesday_DayItem.IsDayOff = False
        Me.Wednesday_DayItem.Location = New System.Drawing.Point(2, 146)
        Me.Wednesday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Wednesday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Wednesday_DayItem.Name = "Wednesday_DayItem"
        Me.Wednesday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Wednesday_DayItem.TabIndex = 40
        '
        'Sunday_DayItem
        '
        Me.Sunday_DayItem.DayOfWeek = "Sunday"
        Me.Sunday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Sunday_DayItem.IsDayOff = False
        Me.Sunday_DayItem.Location = New System.Drawing.Point(2, 438)
        Me.Sunday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Sunday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Sunday_DayItem.Name = "Sunday_DayItem"
        Me.Sunday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Sunday_DayItem.TabIndex = 44
        '
        'Saturday_DayItem
        '
        Me.Saturday_DayItem.DayOfWeek = "Saturday"
        Me.Saturday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Saturday_DayItem.IsDayOff = False
        Me.Saturday_DayItem.Location = New System.Drawing.Point(2, 365)
        Me.Saturday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Saturday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Saturday_DayItem.Name = "Saturday_DayItem"
        Me.Saturday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Saturday_DayItem.TabIndex = 43
        '
        'Friday_DayItem
        '
        Me.Friday_DayItem.DayOfWeek = "Friday"
        Me.Friday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Friday_DayItem.IsDayOff = False
        Me.Friday_DayItem.Location = New System.Drawing.Point(2, 292)
        Me.Friday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Friday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Friday_DayItem.Name = "Friday_DayItem"
        Me.Friday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Friday_DayItem.TabIndex = 42
        '
        'Thursday_DayItem
        '
        Me.Thursday_DayItem.DayOfWeek = "Thursday"
        Me.Thursday_DayItem.HoursWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Thursday_DayItem.IsDayOff = False
        Me.Thursday_DayItem.Location = New System.Drawing.Point(2, 219)
        Me.Thursday_DayItem.LunchBreakMinutes = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Thursday_DayItem.MinutesWorked = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Thursday_DayItem.Name = "Thursday_DayItem"
        Me.Thursday_DayItem.Size = New System.Drawing.Size(243, 65)
        Me.Thursday_DayItem.TabIndex = 41
        '
        'SplitContainer9
        '
        Me.SplitContainer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer9.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer9.Name = "SplitContainer9"
        Me.SplitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer9.Panel1
        '
        Me.SplitContainer9.Panel1.Controls.Add(Me.flpListItems_FlowLayoutPanel)
        Me.SplitContainer9.Size = New System.Drawing.Size(518, 632)
        Me.SplitContainer9.SplitterDistance = 517
        Me.SplitContainer9.TabIndex = 0
        '
        'flpListItems_FlowLayoutPanel
        '
        Me.flpListItems_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpListItems_FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpListItems_FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.flpListItems_FlowLayoutPanel.Name = "flpListItems_FlowLayoutPanel"
        Me.flpListItems_FlowLayoutPanel.Size = New System.Drawing.Size(518, 517)
        Me.flpListItems_FlowLayoutPanel.TabIndex = 1
        '
        'PaycheckEstimator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 707)
        Me.Controls.Add(Me.tabsMain_TabControl)
        Me.Name = "PaycheckEstimator"
        Me.Text = "Paycheck Estimator"
        Me.tabsMain_TabControl.ResumeLayout(False)
        Me.tabEstimator_TabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.pnlNetPay_Panel.ResumeLayout(False)
        Me.pnlNetPay_Panel.PerformLayout()
        Me.pnlAdditionalWithholdings_Panel.ResumeLayout(False)
        Me.pnlAdditionalWithholdings_Panel.PerformLayout()
        CType(Me.nudAdditionalWithholdingValue2_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAdditionalWithholdingValue1_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTaxes_Panel.ResumeLayout(False)
        Me.pnlTaxes_Panel.PerformLayout()
        Me.pnlEarnings_Panel.ResumeLayout(False)
        Me.pnlEarnings_Panel.PerformLayout()
        Me.pnlPayPeriodInformation_Panel.ResumeLayout(False)
        Me.pnlPayPeriodInformation_Panel.PerformLayout()
        Me.tabLists_TabPage.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel1.PerformLayout()
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel1.PerformLayout()
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        Me.SplitContainer9.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabsMain_TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabEstimator_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtpPayPeriodEndDate_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPayPeriodStartDateLabel As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodLabel As System.Windows.Forms.Label
    Friend WithEvents dtpPayPeriodStartDate_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPayPeriodEndDateLabel As System.Windows.Forms.Label
    Friend WithEvents Monday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents Tuesday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents Wednesday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents Sunday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents Saturday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents Friday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents Thursday_DayItem As Paycheck_Esitmator.DayItem_UserControl
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnResetAll_Button As System.Windows.Forms.Button
    Friend WithEvents btnCalculatePayStub_Button As System.Windows.Forms.Button
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlNetPay_Panel As System.Windows.Forms.Panel
    Friend WithEvents lblNetPayValue_Label As System.Windows.Forms.Label
    Friend WithEvents pnlAdditionalWithholdings_Panel As System.Windows.Forms.Panel
    Friend WithEvents nudAdditionalWithholdingValue2_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAdditionalWithholdingValue1_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtAdditionalWithholdingName2_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAdditionalWithholdingsValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalWithholdings_Label As System.Windows.Forms.Label
    Friend WithEvents lblTotalAdditionalWithholdings_Label As System.Windows.Forms.Label
    Friend WithEvents pnlTaxes_Panel As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTaxesValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxes_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxMedicareValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxFederalWithholding_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxSocialSecurityValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxStateWithholding_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxStateValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxSocialSecurityWitholding_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxFederalValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblTaxMedicareWithholding_Label As System.Windows.Forms.Label
    Friend WithEvents lblTotalTaxes_Label As System.Windows.Forms.Label
    Friend WithEvents pnlEarnings_Panel As System.Windows.Forms.Panel
    Friend WithEvents lblOverTimeEarnings_Label As System.Windows.Forms.Label
    Friend WithEvents lblRegularEarnings_Label As System.Windows.Forms.Label
    Friend WithEvents lblTotalEarningsValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblEarnings_Label As System.Windows.Forms.Label
    Friend WithEvents lblTotalOvertimeEarningsValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblHours_Label As System.Windows.Forms.Label
    Friend WithEvents lblTotalRegularEarningsValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblRate_Label As System.Windows.Forms.Label
    Friend WithEvents lblOverTimeRateValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblTotalEarnings_Label As System.Windows.Forms.Label
    Friend WithEvents lblRegularRateValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblRegularHoursValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblOverTimeHoursValue_Label As System.Windows.Forms.Label
    Friend WithEvents pnlPayPeriodInformation_Panel As System.Windows.Forms.Panel
    Friend WithEvents lblPayPeriodEnd_Label As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodStart_Label As System.Windows.Forms.Label
    Friend WithEvents lblPaydayDayOfWeekValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblPayDateValue_Label As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodEndDate_Label As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodStartDate_Label As System.Windows.Forms.Label
    Friend WithEvents lblPayDay_Label As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriod_Label As System.Windows.Forms.Label
    Friend WithEvents tabLists_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents txtAdditionalWithholdingName1_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnAddListItem_Button As System.Windows.Forms.Button
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtNewListName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddList_Button As System.Windows.Forms.Button
    Friend WithEvents lbxLists_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents lblNewListItemNameErrorMessage_Label As System.Windows.Forms.Label
    Friend WithEvents txtNewListItemName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblNewListNameErrorMessage_Label As System.Windows.Forms.Label
    Friend WithEvents SplitContainer9 As System.Windows.Forms.SplitContainer
    Friend WithEvents flpListItems_FlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
End Class
