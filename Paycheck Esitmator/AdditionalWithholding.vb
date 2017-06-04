Public Class AdditionalWithholding
#Region "PROPERTIES"
    ' Name
    Private m_Name As String
    Public ReadOnly Property Name() As String
        Get
            Return m_Name
        End Get
    End Property

    ' Amount
    Private m_Amount As Decimal
    Public ReadOnly Property Amount() As Decimal
        Get
            Return m_Amount
        End Get
    End Property
#End Region

    Public Sub New(strName As String, amount As Decimal)
        Me.m_Name = strName
        Me.m_Amount = amount
    End Sub
End Class
