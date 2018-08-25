Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the payment class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class paymentValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the paymentValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a payment</param>
  Public Sub New(ByVal entity As payment)
    MyBase.New()

    _Entity = entity
    ClassName = "paymentValidator"

    ' Create Properties for each field in the payment entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As payment
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As payment
    Get
      Return _Entity
    End Get
    Set(ByVal value As payment)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current payment
  ''' </summary>
  ''' <returns>A cloned payment object</returns>
  Public Function CloneEntity() As payment
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in payment
  ''' </summary>
  ''' <returns>A cloned payment object</returns>
  Public Function CloneEntity(ByVal entityToClone As payment) As payment
    Dim newEntity As New payment()

    newEntity.PayID = entityToClone.PayID
    newEntity.CustID = entityToClone.CustID
    newEntity.FP = entityToClone.FP
    newEntity.PayDate = entityToClone.PayDate
    newEntity.CheckNo = entityToClone.CheckNo
    newEntity.AccountName = entityToClone.AccountName
    newEntity.DateIssued = entityToClone.DateIssued
    newEntity.DateDue = entityToClone.DateDue
    newEntity.AccountNo = entityToClone.AccountNo
    newEntity.BankName = entityToClone.BankName
    newEntity.Amount = entityToClone.Amount
    newEntity.Remarks = entityToClone.Remarks
    newEntity.Cleared = entityToClone.Cleared
    newEntity.Posted = entityToClone.Posted
    newEntity.Terminal = entityToClone.Terminal
    newEntity.InvoiceNum = entityToClone.InvoiceNum
    newEntity.Receipt = entityToClone.Receipt
    newEntity.OldBal = entityToClone.OldBal
    newEntity.NewBal = entityToClone.NewBal
    newEntity.TimeEncoded = entityToClone.TimeEncoded
    newEntity.sInsertid = entityToClone.sInsertid

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.PayID, "Pay ID", False, GetType(Integer), 10, "Pay ID must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.CustID, "Cust ID", True, GetType(Integer), 10, "Cust ID must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.FP, "FP", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.PayDate, "Pay Date", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.CheckNo, "Check No", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.AccountName, "Account Name", False, GetType(String), 100, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.DateIssued, "Date Issued", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.DateDue, "Date Due", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.AccountNo, "Account No", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.BankName, "Bank Name", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.Amount, "Amount", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.Remarks, "Remarks", False, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.Cleared, "Cleared", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.Posted, "Posted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.Terminal, "Terminal", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.InvoiceNum, "Invoice Num", False, GetType(String), 30, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.Receipt, "Receipt", False, GetType(String), 30, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.OldBal, "Old Bal", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.NewBal, "New Bal", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.TimeEncoded, "Time Encoded", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymentValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.PayID = 0
    Entity.CustID = 0
    Entity.FP = String.Empty
    Entity.PayDate = DateTime.Now
    Entity.CheckNo = String.Empty
    Entity.AccountName = String.Empty
    Entity.DateIssued = DateTime.Now
    Entity.DateDue = DateTime.Now
    Entity.AccountNo = String.Empty
    Entity.BankName = String.Empty
    Entity.Amount = 0
    Entity.Remarks = String.Empty
    Entity.Cleared = False
    Entity.Posted = False
    Entity.Terminal = 0
    Entity.InvoiceNum = String.Empty
    Entity.Receipt = String.Empty
    Entity.OldBal = 0
    Entity.NewBal = 0
    Entity.TimeEncoded = DateTime.Now
    Entity.sInsertid = String.Empty

    Entity.ResetAllIsDirtyProperties()
  End Sub
#End Region

#Region "InitProperties Method"
  ''' <summary>
  ''' Called by the constructor to create the PDSAProperties collection of all properties that will be validated.
  ''' </summary>
  Protected Overrides Sub InitProperties()
    ' Set the Properties collection to the collection of Entity Properties
    Properties = CreateProperties()
  End Sub
#End Region

#Region "EntityDataToProperties Method"
  ''' <summary>
  ''' Moves the Entity class data into the Properties collection.
  ''' </summary>
  Protected Overrides Sub EntityDataToProperties()
    If Properties Is Nothing Then
      InitProperties()
    End If

    If Properties.GetByName(paymentValidator.ColumnNames.PayID).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.PayID).Value = Entity.PayID
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.CustID).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.CustID).Value = Entity.CustID
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.FP).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.FP).Value = Entity.FP
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.PayDate).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.PayDate).Value = Entity.PayDate
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.CheckNo).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.CheckNo).Value = Entity.CheckNo
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.AccountName).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.AccountName).Value = Entity.AccountName
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.DateIssued).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.DateIssued).Value = Entity.DateIssued
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.DateDue).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.DateDue).Value = Entity.DateDue
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.AccountNo).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.AccountNo).Value = Entity.AccountNo
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.BankName).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.BankName).Value = Entity.BankName
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Amount).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.Amount).Value = Entity.Amount
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Remarks).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.Remarks).Value = Entity.Remarks
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Cleared).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.Cleared).Value = Entity.Cleared
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Posted).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.Posted).Value = Entity.Posted
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Terminal).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.Terminal).Value = Entity.Terminal
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.InvoiceNum).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.InvoiceNum).Value = Entity.InvoiceNum
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Receipt).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.Receipt).Value = Entity.Receipt
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.OldBal).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.OldBal).Value = Entity.OldBal
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.NewBal).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.NewBal).Value = Entity.NewBal
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.TimeEncoded).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.TimeEncoded).Value = Entity.TimeEncoded
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(paymentValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
  End Sub
#End Region

#Region "PropertiesToEntityData Method"
  ''' <summary>
  ''' Moves the Properties collection objects into the Entity properties
  ''' </summary>
  Protected Overrides Sub PropertiesToEntityData()
    If Properties Is Nothing Then
      InitProperties()
    End If

    If Properties.GetByName(paymentValidator.ColumnNames.PayID).IsNull = False Then
      Entity.PayID = Properties.GetByName(paymentValidator.ColumnNames.PayID).GetAsInteger()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.CustID).IsNull = False Then
      Entity.CustID = Properties.GetByName(paymentValidator.ColumnNames.CustID).GetAsInteger()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.FP).IsNull = False Then
      Entity.FP = Properties.GetByName(paymentValidator.ColumnNames.FP).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.PayDate).IsNull = False Then
      Entity.PayDate = Properties.GetByName(paymentValidator.ColumnNames.PayDate).GetAsDate()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.CheckNo).IsNull = False Then
      Entity.CheckNo = Properties.GetByName(paymentValidator.ColumnNames.CheckNo).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.AccountName).IsNull = False Then
      Entity.AccountName = Properties.GetByName(paymentValidator.ColumnNames.AccountName).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.DateIssued).IsNull = False Then
      Entity.DateIssued = Properties.GetByName(paymentValidator.ColumnNames.DateIssued).GetAsDate()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.DateDue).IsNull = False Then
      Entity.DateDue = Properties.GetByName(paymentValidator.ColumnNames.DateDue).GetAsDate()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.AccountNo).IsNull = False Then
      Entity.AccountNo = Properties.GetByName(paymentValidator.ColumnNames.AccountNo).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.BankName).IsNull = False Then
      Entity.BankName = Properties.GetByName(paymentValidator.ColumnNames.BankName).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Amount).IsNull = False Then
      Entity.Amount = Properties.GetByName(paymentValidator.ColumnNames.Amount).GetAsDecimal()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Remarks).IsNull = False Then
      Entity.Remarks = Properties.GetByName(paymentValidator.ColumnNames.Remarks).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Cleared).IsNull = False Then
      Entity.Cleared = Properties.GetByName(paymentValidator.ColumnNames.Cleared).GetValueAsBoolean()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Posted).IsNull = False Then
      Entity.Posted = Properties.GetByName(paymentValidator.ColumnNames.Posted).GetValueAsBoolean()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Terminal).IsNull = False Then
      Entity.Terminal = Properties.GetByName(paymentValidator.ColumnNames.Terminal).GetAsShort()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.InvoiceNum).IsNull = False Then
      Entity.InvoiceNum = Properties.GetByName(paymentValidator.ColumnNames.InvoiceNum).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.Receipt).IsNull = False Then
      Entity.Receipt = Properties.GetByName(paymentValidator.ColumnNames.Receipt).GetAsString()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.OldBal).IsNull = False Then
      Entity.OldBal = Properties.GetByName(paymentValidator.ColumnNames.OldBal).GetAsDecimal()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.NewBal).IsNull = False Then
      Entity.NewBal = Properties.GetByName(paymentValidator.ColumnNames.NewBal).GetAsDecimal()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.TimeEncoded).IsNull = False Then
      Entity.TimeEncoded = Properties.GetByName(paymentValidator.ColumnNames.TimeEncoded).GetAsDate()
    End If
    If Properties.GetByName(paymentValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(paymentValidator.ColumnNames.sInsertid).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the payment class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'PayID'
    ''' </summary>
    Public Shared ReadOnly Property PayID() As String
      Get
        Return "PayID"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'CustID'
    ''' </summary>
    Public Shared ReadOnly Property CustID() As String
      Get
        Return "CustID"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'FP'
    ''' </summary>
    Public Shared ReadOnly Property FP() As String
      Get
        Return "FP"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'PayDate'
    ''' </summary>
    Public Shared ReadOnly Property PayDate() As String
      Get
        Return "PayDate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'CheckNo'
    ''' </summary>
    Public Shared ReadOnly Property CheckNo() As String
      Get
        Return "CheckNo"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'AccountName'
    ''' </summary>
    Public Shared ReadOnly Property AccountName() As String
      Get
        Return "AccountName"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'DateIssued'
    ''' </summary>
    Public Shared ReadOnly Property DateIssued() As String
      Get
        Return "DateIssued"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'DateDue'
    ''' </summary>
    Public Shared ReadOnly Property DateDue() As String
      Get
        Return "DateDue"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'AccountNo'
    ''' </summary>
    Public Shared ReadOnly Property AccountNo() As String
      Get
        Return "AccountNo"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'BankName'
    ''' </summary>
    Public Shared ReadOnly Property BankName() As String
      Get
        Return "BankName"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Amount'
    ''' </summary>
    Public Shared ReadOnly Property Amount() As String
      Get
        Return "Amount"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Remarks'
    ''' </summary>
    Public Shared ReadOnly Property Remarks() As String
      Get
        Return "Remarks"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Cleared'
    ''' </summary>
    Public Shared ReadOnly Property Cleared() As String
      Get
        Return "Cleared"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Posted'
    ''' </summary>
    Public Shared ReadOnly Property Posted() As String
      Get
        Return "Posted"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Terminal'
    ''' </summary>
    Public Shared ReadOnly Property Terminal() As String
      Get
        Return "Terminal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'InvoiceNum'
    ''' </summary>
    Public Shared ReadOnly Property InvoiceNum() As String
      Get
        Return "InvoiceNum"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Receipt'
    ''' </summary>
    Public Shared ReadOnly Property Receipt() As String
      Get
        Return "Receipt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'OldBal'
    ''' </summary>
    Public Shared ReadOnly Property OldBal() As String
      Get
        Return "OldBal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'NewBal'
    ''' </summary>
    Public Shared ReadOnly Property NewBal() As String
      Get
        Return "NewBal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'TimeEncoded'
    ''' </summary>
    Public Shared ReadOnly Property TimeEncoded() As String
      Get
        Return "TimeEncoded"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sInsert_id'
    ''' </summary>
    Public Shared ReadOnly Property sInsertid() As String
      Get
        Return "sInsert_id"
      End Get
    End Property
  End Class
#End Region
End Class
