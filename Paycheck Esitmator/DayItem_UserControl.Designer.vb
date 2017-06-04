<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayItem_UserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDayOfWeek_Label = New System.Windows.Forms.Label()
        Me.cbxDayOff_CheckBox = New System.Windows.Forms.CheckBox()
        Me.lblNumberOfHours_Label = New System.Windows.Forms.Label()
        Me.nudNumberOfHours_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberOfMinutes_Label = New System.Windows.Forms.Label()
        Me.nudNumberOfMinutes_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lblLunchBreak_Label = New System.Windows.Forms.Label()
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.pnlBody_Panel = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        CType(Me.nudNumberOfHours_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfMinutes_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLunchBreakNumberOfMinutes_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBody_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.SystemColors.Info
        Me.pnlHeader.Controls.Add(Me.lblDayOfWeek_Label)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(243, 21)
        Me.pnlHeader.TabIndex = 0
        '
        'lblDayOfWeek_Label
        '
        Me.lblDayOfWeek_Label.AutoSize = True
        Me.lblDayOfWeek_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOfWeek_Label.Location = New System.Drawing.Point(93, 2)
        Me.lblDayOfWeek_Label.Name = "lblDayOfWeek_Label"
        Me.lblDayOfWeek_Label.Size = New System.Drawing.Size(57, 17)
        Me.lblDayOfWeek_Label.TabIndex = 0
        Me.lblDayOfWeek_Label.Text = "Label1"
        '
        'cbxDayOff_CheckBox
        '
        Me.cbxDayOff_CheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbxDayOff_CheckBox.AutoSize = True
        Me.cbxDayOff_CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cbxDayOff_CheckBox.Location = New System.Drawing.Point(4, 7)
        Me.cbxDayOff_CheckBox.Name = "cbxDayOff_CheckBox"
        Me.cbxDayOff_CheckBox.Size = New System.Drawing.Size(25, 31)
        Me.cbxDayOff_CheckBox.TabIndex = 13
        Me.cbxDayOff_CheckBox.TabStop = False
        Me.cbxDayOff_CheckBox.Text = "Off"
        Me.cbxDayOff_CheckBox.UseVisualStyleBackColor = True
        '
        'lblNumberOfHours_Label
        '
        Me.lblNumberOfHours_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNumberOfHours_Label.AutoSize = True
        Me.lblNumberOfHours_Label.Location = New System.Drawing.Point(49, 4)
        Me.lblNumberOfHours_Label.Name = "lblNumberOfHours_Label"
        Me.lblNumberOfHours_Label.Size = New System.Drawing.Size(35, 13)
        Me.lblNumberOfHours_Label.TabIndex = 14
        Me.lblNumberOfHours_Label.Text = "Hours"
        '
        'nudNumberOfHours_NumericUpDown
        '
        Me.nudNumberOfHours_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.nudNumberOfHours_NumericUpDown.Location = New System.Drawing.Point(44, 21)
        Me.nudNumberOfHours_NumericUpDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudNumberOfHours_NumericUpDown.Name = "nudNumberOfHours_NumericUpDown"
        Me.nudNumberOfHours_NumericUpDown.Size = New System.Drawing.Size(45, 20)
        Me.nudNumberOfHours_NumericUpDown.TabIndex = 15
        Me.nudNumberOfHours_NumericUpDown.Tag = "Hours"
        Me.nudNumberOfHours_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberOfMinutes_Label
        '
        Me.lblNumberOfMinutes_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNumberOfMinutes_Label.AutoSize = True
        Me.lblNumberOfMinutes_Label.Location = New System.Drawing.Point(114, 4)
        Me.lblNumberOfMinutes_Label.Name = "lblNumberOfMinutes_Label"
        Me.lblNumberOfMinutes_Label.Size = New System.Drawing.Size(44, 13)
        Me.lblNumberOfMinutes_Label.TabIndex = 16
        Me.lblNumberOfMinutes_Label.Text = "Minutes"
        '
        'nudNumberOfMinutes_NumericUpDown
        '
        Me.nudNumberOfMinutes_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.nudNumberOfMinutes_NumericUpDown.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudNumberOfMinutes_NumericUpDown.Location = New System.Drawing.Point(114, 21)
        Me.nudNumberOfMinutes_NumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudNumberOfMinutes_NumericUpDown.Name = "nudNumberOfMinutes_NumericUpDown"
        Me.nudNumberOfMinutes_NumericUpDown.Size = New System.Drawing.Size(45, 20)
        Me.nudNumberOfMinutes_NumericUpDown.TabIndex = 17
        Me.nudNumberOfMinutes_NumericUpDown.Tag = "Minutes"
        Me.nudNumberOfMinutes_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLunchBreak_Label
        '
        Me.lblLunchBreak_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblLunchBreak_Label.AutoSize = True
        Me.lblLunchBreak_Label.Location = New System.Drawing.Point(198, 4)
        Me.lblLunchBreak_Label.Name = "lblLunchBreak_Label"
        Me.lblLunchBreak_Label.Size = New System.Drawing.Size(37, 13)
        Me.lblLunchBreak_Label.TabIndex = 18
        Me.lblLunchBreak_Label.Text = "Lunch"
        '
        'nudLunchBreakNumberOfMinutes_NumericUpDown
        '
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Location = New System.Drawing.Point(194, 21)
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Name = "nudLunchBreakNumberOfMinutes_NumericUpDown"
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Size = New System.Drawing.Size(45, 20)
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.TabIndex = 19
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.Tag = "LunchBreak"
        Me.nudLunchBreakNumberOfMinutes_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlBody_Panel
        '
        Me.pnlBody_Panel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnlBody_Panel.Controls.Add(Me.cbxDayOff_CheckBox)
        Me.pnlBody_Panel.Controls.Add(Me.lblLunchBreak_Label)
        Me.pnlBody_Panel.Controls.Add(Me.lblNumberOfMinutes_Label)
        Me.pnlBody_Panel.Controls.Add(Me.nudLunchBreakNumberOfMinutes_NumericUpDown)
        Me.pnlBody_Panel.Controls.Add(Me.nudNumberOfHours_NumericUpDown)
        Me.pnlBody_Panel.Controls.Add(Me.lblNumberOfHours_Label)
        Me.pnlBody_Panel.Controls.Add(Me.nudNumberOfMinutes_NumericUpDown)
        Me.pnlBody_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody_Panel.Location = New System.Drawing.Point(0, 21)
        Me.pnlBody_Panel.Name = "pnlBody_Panel"
        Me.pnlBody_Panel.Size = New System.Drawing.Size(243, 44)
        Me.pnlBody_Panel.TabIndex = 20
        '
        'DayItem_UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlBody_Panel)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "DayItem_UserControl"
        Me.Size = New System.Drawing.Size(243, 65)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.nudNumberOfHours_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfMinutes_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLunchBreakNumberOfMinutes_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBody_Panel.ResumeLayout(False)
        Me.pnlBody_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDayOfWeek_Label As System.Windows.Forms.Label
    Friend WithEvents cbxDayOff_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblNumberOfHours_Label As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfHours_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNumberOfMinutes_Label As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfMinutes_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLunchBreak_Label As System.Windows.Forms.Label
    Friend WithEvents nudLunchBreakNumberOfMinutes_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlBody_Panel As System.Windows.Forms.Panel

End Class
