Public Class PayStub
#Region "CONSTANTS"
    Private Const FEDERAL_TAX_RATE As Decimal = 0.052
    Private Const STATE_TAX_RATE As Decimal = 0.008
    Private Const SOCAIL_SECURITY_TAX_RATE As Decimal = 0.062
    Private Const MEDICARE_TAX_RATE As Decimal = 0.01449
#End Region

#Region "PROPERTIES"
    ' Pay Period Start Date
    Private m_PayPeriodStartDate As Date
    Public ReadOnly Property PayPeriodStartDate() As Date
        Get
            Return m_PayPeriodStartDate
        End Get
    End Property

    ' Pay Period Length
    Private m_PayPeriodLength As Integer
    Public ReadOnly Property PayPeriodLength() As Integer
        Get
            Return m_PayPeriodLength
        End Get
    End Property

    ' Pay Rate
    Private m_PayRate As Decimal
    Public ReadOnly Property PayRate() As Decimal
        Get
            Return m_PayRate
        End Get
    End Property

    ' Total Minutes Worked
    Private m_TotalMinutesWorked As Decimal
    Public ReadOnly Property TotalMinutesWorked() As Decimal
        Get
            Return m_TotalMinutesWorked
        End Get
    End Property

    ' Additional Withholdings
    Private m_AdditionalWithholdings As AdditionalWithholding()
    Public Property AdditionalWithholdings() As AdditionalWithholding()
        Get
            Return m_AdditionalWithholdings
        End Get
        Set(ByVal value As AdditionalWithholding())
            m_AdditionalWithholdings = value
        End Set
    End Property

    ' Regular Hours
    Public ReadOnly Property RegularHours() As Decimal
        Get
            Return ConvertMinutesToHours(GetRegularMinutes())
        End Get
    End Property

    ' Regular Minutes
    Public ReadOnly Property RegularMinutes() As Decimal
        Get
            Return GetLeftOverMinutes(GetRegularMinutes())
        End Get
    End Property

    ' Overtime Hours
    Public ReadOnly Property OvertimeHours() As Decimal
        Get
            Return ConvertMinutesToHours(GetOvertimeMinutes())
        End Get
    End Property

    ' Overtime Minutes
    Public ReadOnly Property OvertimeMinutes() As Decimal
        Get
            Return GetLeftOverMinutes(GetOvertimeMinutes())
        End Get
    End Property

    ' Overtime Pay Rate
    Public ReadOnly Property OvertimePayRate() As Decimal
        Get
            Return GetOvertimePayRate()
        End Get
    End Property

    ' Pay Period End Date
    Public ReadOnly Property PayPeriodEndDate() As Date
        Get
            Return GetPayPeriodEndDate()
        End Get
    End Property

    ' Pay Date
    Public ReadOnly Property PayDate() As Date
        Get
            Return GetPayDate()
        End Get
    End Property

    ' Regular Pay
    Public ReadOnly Property RegularPay() As Decimal
        Get
            Return GetRegularPay()
        End Get
    End Property

    ' Overtime Pay
    Public ReadOnly Property OvertimePay() As Decimal
        Get
            Return GetOverTimePay()
        End Get
    End Property

    ' Federal Withholding
    Public ReadOnly Property FederalWithholding() As Decimal
        Get
            Return GetTaxWithholdingAmount(FEDERAL_TAX_RATE)
        End Get
    End Property

    ' State Withholding
    Public ReadOnly Property StateWithholding() As Decimal
        Get
            Return GetTaxWithholdingAmount(STATE_TAX_RATE)
        End Get
    End Property

    ' Social Security Withholding
    Public ReadOnly Property SocialSecurityWithholding() As Decimal
        Get
            Return GetTaxWithholdingAmount(SOCAIL_SECURITY_TAX_RATE)
        End Get
    End Property

    ' Medicare Withholding
    Public ReadOnly Property MedicareWithholding() As Decimal
        Get
            Return GetTaxWithholdingAmount(MEDICARE_TAX_RATE)
        End Get
    End Property

    ' Total Tax Withholdings
    Public ReadOnly Property TotalTaxWithholdings() As Integer
        Get
            Return GetTotalTaxWithholdingsAmount()
        End Get
    End Property

    ' Total Additional Withholdings
    Public ReadOnly Property TotalAdditionalWithholdings() As Decimal
        Get
            Return GetTotalAdditionalWithholdingsAmount()
        End Get
    End Property

    ' Gross Income
    Public ReadOnly Property GrossIncome() As Decimal
        Get
            Return GetGrossIncome()
        End Get
    End Property

    ' Net Income
    Public ReadOnly Property NetIncome() As Decimal
        Get
            Return GetNetIncome()
        End Get
    End Property
#End Region

    ' Initializer
    Public Sub New(payPeriodStartDate As Date, payPeriodLength As Double, payRate As Decimal, totalMinutesWorked As Decimal, additionalWitholdings As AdditionalWithholding())

        With Me
            .m_PayPeriodStartDate = payPeriodStartDate
            .m_PayPeriodLength = payPeriodLength
            .m_PayRate = payRate
            .m_AdditionalWithholdings = additionalWitholdings
            .m_TotalMinutesWorked = totalMinutesWorked
        End With
    End Sub

    ' Get Regular Minutes
    Private Function GetRegularMinutes() As Decimal
        If IsOverTime(Me.TotalMinutesWorked) Then
            Return 2400
        End If

        Return Me.TotalMinutesWorked
    End Function

    ' Get Overtime Minutes
    Private Function GetOvertimeMinutes() As Decimal
        If IsOverTime(Me.TotalMinutesWorked) Then
            Return Math.Round(Me.TotalMinutesWorked - 2400, 2)
        End If

        Return 0.0
    End Function

    ' Get Left Over Minutes
    Public Shared Function GetLeftOverMinutes(ByVal minutes As Decimal) As Decimal
        Dim leftOverMinutes As Integer
        Math.DivRem(Convert.ToInt16(minutes), 60, leftOverMinutes)

        Return Convert.ToDecimal(leftOverMinutes)
    End Function

    ' Is Over Time
    Public Shared Function IsOverTime(ByVal minutes As Decimal) As Boolean
        If minutes > 2400 Then
            Return True
        End If

        Return False
    End Function

    ' Convert Minutes To Hours
    Public Shared Function ConvertMinutesToHours(ByVal minutes As Decimal) As Decimal
        Return Convert.ToDecimal(Math.Floor(minutes / 60))
    End Function



#Region "PRIVATE METHODS"
    ' Get Pay Period End Date
    Private Function GetPayPeriodEndDate() As Date
        Return Me.PayPeriodStartDate.AddDays(Me.PayPeriodLength - 1)
    End Function

    ' Get Pay Date
    Private Function GetPayDate() As Date
        Return Me.PayPeriodStartDate.AddDays(Me.PayPeriodLength + 1).Date
    End Function

    ' Get Gross Income
    Private Function GetGrossIncome() As Decimal
        Return Math.Round(Me.RegularPay + Me.OvertimePay, 2)
    End Function

    ' Get Net Income
    Private Function GetNetIncome() As Decimal
        Return Math.Round(Me.GrossIncome - Me.TotalTaxWithholdings - Me.TotalAdditionalWithholdings, 2)
    End Function

    ' Get Total Additional Withholdings Amount
    Private Function GetTotalAdditionalWithholdingsAmount() As Decimal
        Dim totalAmount As Decimal = 0.0
        For i = 0 To Me.AdditionalWithholdings.Length - 1
            totalAmount += AdditionalWithholdings(i).Amount
        Next

        Return Math.Round(totalAmount, 2)
    End Function

    ' Get Tax Withholding Amount
    Private Function GetTaxWithholdingAmount(ByVal taxRate As Decimal) As Decimal
        Return Math.Round(Me.GrossIncome * taxRate, 2)
    End Function

    ' Get Total Tax Withholdings Amount
    Private Function GetTotalTaxWithholdingsAmount() As Decimal
        Return Math.Round(Me.FederalWithholding + Me.StateWithholding + Me.SocialSecurityWithholding + Me.MedicareWithholding, 2)
    End Function

    ' Get Regular Pay
    Private Function GetRegularPay() As Decimal
        Return Math.Round((Me.RegularHours + ConvertMinutesToDecimal(Me.RegularMinutes)) * Me.PayRate, 2)
    End Function

    ' Get Overtime Pay
    Private Function GetOvertimePay() As Decimal
        Return Math.Round((Me.OvertimeHours + ConvertMinutesToDecimal(Me.OvertimeMinutes)) * Me.OvertimePayRate, 2)
    End Function

    ' Get Overtime Pay Rate
    Private Function GetOvertimePayRate() As Decimal
        Return Math.Round(Me.PayRate * 1.5, 2)
    End Function

    ' Convert Minutes To Decimal
    Public Shared Function ConvertMinutesToDecimal(ByVal minutes As Decimal) As Decimal
        Return Math.Round(minutes / 60, 2)
    End Function
#End Region
End Class
