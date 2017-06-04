<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListItem_UserControl
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxItemComplete_CheckBox = New System.Windows.Forms.CheckBox()
        Me.lblItemName_Label = New System.Windows.Forms.Label()
        Me.lblMoneySign_Label = New System.Windows.Forms.Label()
        Me.nudItemAmount_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.btnDeleteItem_Button = New System.Windows.Forms.Button()
        Me.nudItemQuantiy_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lblTimesSymbol_Label = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudItemAmount_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItemQuantiy_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.90578!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.471125!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82927!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.255319!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.71572!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbxItemComplete_CheckBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblItemName_Label, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoneySign_Label, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudItemAmount_NumericUpDown, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDeleteItem_Button, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudItemQuantiy_NumericUpDown, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTimesSymbol_Label, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 25)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbxItemComplete_CheckBox
        '
        Me.cbxItemComplete_CheckBox.AutoSize = True
        Me.cbxItemComplete_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbxItemComplete_CheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxItemComplete_CheckBox.Location = New System.Drawing.Point(3, 3)
        Me.cbxItemComplete_CheckBox.Name = "cbxItemComplete_CheckBox"
        Me.cbxItemComplete_CheckBox.Size = New System.Drawing.Size(26, 19)
        Me.cbxItemComplete_CheckBox.TabIndex = 0
        Me.cbxItemComplete_CheckBox.UseVisualStyleBackColor = True
        '
        'lblItemName_Label
        '
        Me.lblItemName_Label.AutoEllipsis = True
        Me.lblItemName_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName_Label.Location = New System.Drawing.Point(35, 0)
        Me.lblItemName_Label.Name = "lblItemName_Label"
        Me.lblItemName_Label.Size = New System.Drawing.Size(119, 23)
        Me.lblItemName_Label.TabIndex = 1
        Me.lblItemName_Label.Text = "Label1"
        Me.lblItemName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoneySign_Label
        '
        Me.lblMoneySign_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneySign_Label.Location = New System.Drawing.Point(160, 0)
        Me.lblMoneySign_Label.Name = "lblMoneySign_Label"
        Me.lblMoneySign_Label.Size = New System.Drawing.Size(10, 23)
        Me.lblMoneySign_Label.TabIndex = 2
        Me.lblMoneySign_Label.Text = "$"
        Me.lblMoneySign_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudItemAmount_NumericUpDown
        '
        Me.nudItemAmount_NumericUpDown.DecimalPlaces = 2
        Me.nudItemAmount_NumericUpDown.Increment = New Decimal(New Integer() {500, 0, 0, 131072})
        Me.nudItemAmount_NumericUpDown.Location = New System.Drawing.Point(177, 3)
        Me.nudItemAmount_NumericUpDown.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudItemAmount_NumericUpDown.Name = "nudItemAmount_NumericUpDown"
        Me.nudItemAmount_NumericUpDown.Size = New System.Drawing.Size(72, 20)
        Me.nudItemAmount_NumericUpDown.TabIndex = 3
        Me.nudItemAmount_NumericUpDown.ThousandsSeparator = True
        Me.nudItemAmount_NumericUpDown.Value = New Decimal(New Integer() {99999, 0, 0, 0})
        '
        'btnDeleteItem_Button
        '
        Me.btnDeleteItem_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem_Button.Location = New System.Drawing.Point(323, 3)
        Me.btnDeleteItem_Button.Name = "btnDeleteItem_Button"
        Me.btnDeleteItem_Button.Size = New System.Drawing.Size(15, 19)
        Me.btnDeleteItem_Button.TabIndex = 5
        Me.btnDeleteItem_Button.Text = "X"
        Me.btnDeleteItem_Button.UseVisualStyleBackColor = True
        '
        'nudItemQuantiy_NumericUpDown
        '
        Me.nudItemQuantiy_NumericUpDown.Location = New System.Drawing.Point(276, 3)
        Me.nudItemQuantiy_NumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudItemQuantiy_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudItemQuantiy_NumericUpDown.Name = "nudItemQuantiy_NumericUpDown"
        Me.nudItemQuantiy_NumericUpDown.Size = New System.Drawing.Size(41, 20)
        Me.nudItemQuantiy_NumericUpDown.TabIndex = 4
        Me.nudItemQuantiy_NumericUpDown.Value = New Decimal(New Integer() {888, 0, 0, 0})
        '
        'lblTimesSymbol_Label
        '
        Me.lblTimesSymbol_Label.Location = New System.Drawing.Point(263, 0)
        Me.lblTimesSymbol_Label.Name = "lblTimesSymbol_Label"
        Me.lblTimesSymbol_Label.Size = New System.Drawing.Size(7, 20)
        Me.lblTimesSymbol_Label.TabIndex = 6
        Me.lblTimesSymbol_Label.Text = "x"
        Me.lblTimesSymbol_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ListItem_UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ListItem_UserControl"
        Me.Size = New System.Drawing.Size(350, 25)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudItemAmount_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItemQuantiy_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbxItemComplete_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblItemName_Label As System.Windows.Forms.Label
    Friend WithEvents lblMoneySign_Label As System.Windows.Forms.Label
    Friend WithEvents nudItemAmount_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnDeleteItem_Button As System.Windows.Forms.Button
    Friend WithEvents nudItemQuantiy_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTimesSymbol_Label As System.Windows.Forms.Label

End Class
