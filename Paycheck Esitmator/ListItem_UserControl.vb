Imports System.Linq

Public Class ListItem_UserControl
#Region "CONSTANTS"

#End Region

#Region "PROPERTIES"
    ' List ID
    Private m_ListID As Guid
    Public ReadOnly Property ListID() As Guid
        Get
            Return m_ListID
        End Get
    End Property

    ' Is Complete
    Public Property IsComplete() As Boolean
        Get
            Return cbxItemComplete_CheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            cbxItemComplete_CheckBox.Checked = value
        End Set
    End Property

    ' Item Name
    Public Property ItemName() As String
        Get
            Return lblItemName_Label.Text
        End Get
        Set(ByVal value As String)
            lblItemName_Label.Text = value
        End Set
    End Property

    ' Item Amount
    Public Property ItemAmount() As Decimal
        Get
            Return nudItemAmount_NumericUpDown.Value
        End Get
        Set(value As Decimal)
            nudItemAmount_NumericUpDown.Value = value
        End Set
    End Property

    ' Item Quantity
    Public Property ItemQuantity() As Decimal
        Get
            Return nudItemQuantiy_NumericUpDown.Value
        End Get
        Set(value As Decimal)
            nudItemQuantiy_NumericUpDown.Value = value
        End Set
    End Property
#End Region

#Region "PAGE EVENTS"
    ' New
    Public Sub New(idList As Guid, strListItemName As String, amount As Decimal, quantity As Decimal, isComplete As Boolean)
        InitializeComponent()

        Me.m_ListID = idList
        Me.ItemName = strListItemName
        Me.ItemAmount = amount
        Me.ItemQuantity = quantity
        Me.IsComplete = isComplete
    End Sub
    ' Load
    Private Sub ListItem_UserControl_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        UpdateControls()
    End Sub

    ' Item Complete Check Box Checked Changed
    Private Sub cbxItemComplete_CheckBox_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbxItemComplete_CheckBox.CheckedChanged
        UpdateControls()
        UpdateListItem(New ListItem With {.ListID = Me.ListID, .Name = lblItemName_Label.Text, .Amount = nudItemAmount_NumericUpDown.Value, .Quantity = nudItemQuantiy_NumericUpDown.Value, .IsComplete = cbxItemComplete_CheckBox.Checked})
    End Sub
#End Region

    ' Update Controls
    Private Sub UpdateControls()
        If Me.IsComplete Then
            Me.BackColor = Drawing.Color.LightGreen

            nudItemAmount_NumericUpDown.Enabled = False
            nudItemQuantiy_NumericUpDown.Enabled = False
        Else
            Me.BackColor = Drawing.Color.Beige

            nudItemAmount_NumericUpDown.Enabled = True
            nudItemQuantiy_NumericUpDown.Enabled = True
        End If
    End Sub

    ' Delete Item Button Click
    Private Sub btnDeleteItem_Button_Click(sender As Object, e As System.EventArgs) Handles btnDeleteItem_Button.Click
        DeleteListItem()

        Dim flp As Windows.Forms.FlowLayoutPanel = Parent
        flp.Controls.Remove(Me)
    End Sub

    ' Delete List Item
    Private Sub DeleteListItem()
        Dim db As New PaycheckEstimator_DataClassesDataContext

        Dim itemList As ListItem = (From li In db.ListItems _
                                    Where li.ListID.Equals(Me.ListID) _
                                    AndAlso li.Name.Equals(Me.ItemName) _
                                    Select li).SingleOrDefault()

        db.ListItems.DeleteOnSubmit(itemList)

        Try
            db.SubmitChanges()
        Catch ex As ApplicationException
            Console.WriteLine(ex)
            ' TODO: Inform user that there was a problem and he should try again later.
        End Try
    End Sub

    ' Insert List Item
    Private Sub InsertListItem(ByVal newListItem As ListItem)
        Dim db As New PaycheckEstimator_DataClassesDataContext

        db.ListItems.InsertOnSubmit(newListItem)

        Try
            db.SubmitChanges()
        Catch ex As ApplicationException
            Console.WriteLine(ex)
            ' TODO: Inform the user that there was a problem and he should try again later.
        End Try
    End Sub

    ' Update List Item
    Private Sub UpdateListItem(ByVal newListItem As ListItem)
        Dim db As New PaycheckEstimator_DataClassesDataContext

        Dim itemList As ListItem = (From li In db.ListItems _
                                    Where li.ListID.Equals(Me.ListID) _
                                    AndAlso li.Name.Equals(Me.ItemName) _
                                    Select li).SingleOrDefault()

        DeleteListItem()

        InsertListItem(newListItem)
    End Sub
End Class