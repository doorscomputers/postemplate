Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the ReadingSum class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class ReadingSumValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the ReadingSumValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a ReadingSum</param>
  Public Sub New(ByVal entity As ReadingSum)
    MyBase.New()

    _Entity = entity
    ClassName = "ReadingSumValidator"

    ' Create Properties for each field in the ReadingSum entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As ReadingSum
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As ReadingSum
    Get
      Return _Entity
    End Get
    Set(ByVal value As ReadingSum)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current ReadingSum
  ''' </summary>
  ''' <returns>A cloned ReadingSum object</returns>
  Public Function CloneEntity() As ReadingSum
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in ReadingSum
  ''' </summary>
  ''' <returns>A cloned ReadingSum object</returns>
  Public Function CloneEntity(ByVal entityToClone As ReadingSum) As ReadingSum
    Dim newEntity As New ReadingSum()

    newEntity.ReadingId = entityToClone.ReadingId
    newEntity.ReadingDate = entityToClone.ReadingDate
    newEntity.Location = entityToClone.Location
    newEntity.Cashier = entityToClone.Cashier
    newEntity.TotalSales = entityToClone.TotalSales
    newEntity.BegCash = entityToClone.BegCash
    newEntity.CashEnd = entityToClone.CashEnd
    newEntity.xShort = entityToClone.xShort
    newEntity.OverAmount = entityToClone.OverAmount
    newEntity.Remittance = entityToClone.Remittance
    newEntity.AddFund = entityToClone.AddFund
    newEntity.PettyCash = entityToClone.PettyCash

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.ReadingId, "Reading Id", False, GetType(Integer), 10, "Reading Id must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.ReadingDate, "Reading Date", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.Location, "Location", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.Cashier, "Cashier", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.TotalSales, "Total Sales", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.BegCash, "Beg Cash", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.CashEnd, "Cash End", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.xShort, "Short", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.OverAmount, "Over Amount", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.Remittance, "Remittance", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.AddFund, "Add Fund", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ReadingSumValidator.ColumnNames.PettyCash, "Petty Cash", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.ReadingId = 0
    Entity.ReadingDate = DateTime.Now
    Entity.Location = String.Empty
    Entity.Cashier = String.Empty
    Entity.TotalSales = 0
    Entity.BegCash = 0
    Entity.CashEnd = 0
    Entity.xShort = 0
    Entity.OverAmount = 0
    Entity.Remittance = 0
    Entity.AddFund = 0
    Entity.PettyCash = 0

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

    If Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).Value = Entity.ReadingId
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).Value = Entity.ReadingDate
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.Location).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.Location).Value = Entity.Location
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).Value = Entity.Cashier
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).Value = Entity.TotalSales
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).Value = Entity.BegCash
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).Value = Entity.CashEnd
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).Value = Entity.xShort
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).Value = Entity.OverAmount
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).Value = Entity.Remittance
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).Value = Entity.AddFund
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).SetAsNull = False Then
      Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).Value = Entity.PettyCash
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

    If Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).IsNull = False Then
      Entity.ReadingId = Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).GetAsInteger()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).IsNull = False Then
      Entity.ReadingDate = Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).GetAsDate()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.Location).IsNull = False Then
      Entity.Location = Properties.GetByName(ReadingSumValidator.ColumnNames.Location).GetAsString()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).IsNull = False Then
      Entity.Cashier = Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).GetAsString()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).IsNull = False Then
      Entity.TotalSales = Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).IsNull = False Then
      Entity.BegCash = Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).IsNull = False Then
      Entity.CashEnd = Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).IsNull = False Then
      Entity.xShort = Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).IsNull = False Then
      Entity.OverAmount = Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).IsNull = False Then
      Entity.Remittance = Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).IsNull = False Then
      Entity.AddFund = Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).GetAsDecimal()
    End If
    If Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).IsNull = False Then
      Entity.PettyCash = Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).GetAsDecimal()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the ReadingSum class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'ReadingId'
    ''' </summary>
    Public Shared ReadOnly Property ReadingId() As String
      Get
        Return "ReadingId"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ReadingDate'
    ''' </summary>
    Public Shared ReadOnly Property ReadingDate() As String
      Get
        Return "ReadingDate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Location'
    ''' </summary>
    Public Shared ReadOnly Property Location() As String
      Get
        Return "Location"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Cashier'
    ''' </summary>
    Public Shared ReadOnly Property Cashier() As String
      Get
        Return "Cashier"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'TotalSales'
    ''' </summary>
    Public Shared ReadOnly Property TotalSales() As String
      Get
        Return "TotalSales"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'BegCash'
    ''' </summary>
    Public Shared ReadOnly Property BegCash() As String
      Get
        Return "BegCash"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'CashEnd'
    ''' </summary>
    Public Shared ReadOnly Property CashEnd() As String
      Get
        Return "CashEnd"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Short'
    ''' </summary>
    Public Shared ReadOnly Property xShort() As String
      Get
        Return "Short"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'OverAmount'
    ''' </summary>
    Public Shared ReadOnly Property OverAmount() As String
      Get
        Return "OverAmount"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Remittance'
    ''' </summary>
    Public Shared ReadOnly Property Remittance() As String
      Get
        Return "Remittance"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'AddFund'
    ''' </summary>
    Public Shared ReadOnly Property AddFund() As String
      Get
        Return "AddFund"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'PettyCash'
    ''' </summary>
    Public Shared ReadOnly Property PettyCash() As String
      Get
        Return "PettyCash"
      End Get
    End Property
  End Class
#End Region
End Class
