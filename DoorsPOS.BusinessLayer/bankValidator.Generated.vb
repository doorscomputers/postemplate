Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the bank class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class bankValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the bankValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a bank</param>
  Public Sub New(ByVal entity As bank)
    MyBase.New()

    _Entity = entity
    ClassName = "bankValidator"

    ' Create Properties for each field in the bank entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As bank
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As bank
    Get
      Return _Entity
    End Get
    Set(ByVal value As bank)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current bank
  ''' </summary>
  ''' <returns>A cloned bank object</returns>
  Public Function CloneEntity() As bank
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in bank
  ''' </summary>
  ''' <returns>A cloned bank object</returns>
  Public Function CloneEntity(ByVal entityToClone As bank) As bank
    Dim newEntity As New bank()

    newEntity.bankid = entityToClone.bankid
    newEntity.bank = entityToClone.bank
    newEntity.accountno = entityToClone.accountno
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.accountname = entityToClone.accountname
    newEntity.Balance = entityToClone.Balance

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.bankid, "bankid", False, GetType(Integer), 10, "bankid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.bank, "bank", True, GetType(String), 50, "bank must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.accountno, "accountno", True, GetType(String), 20, "accountno must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.accountname, "accountname", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(bankValidator.ColumnNames.Balance, "Balance", True, GetType(Decimal), 19, "Balance must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.bankid = 0
    Entity.bank = String.Empty
    Entity.accountno = String.Empty
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.accountname = String.Empty
    Entity.Balance = 0

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

    If Properties.GetByName(bankValidator.ColumnNames.bankid).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.bankid).Value = Entity.bankid
    End If
    If Properties.GetByName(bankValidator.ColumnNames.bank).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.bank).Value = Entity.bank
    End If
    If Properties.GetByName(bankValidator.ColumnNames.accountno).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.accountno).Value = Entity.accountno
    End If
    If Properties.GetByName(bankValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(bankValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(bankValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(bankValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(bankValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(bankValidator.ColumnNames.accountname).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.accountname).Value = Entity.accountname
    End If
    If Properties.GetByName(bankValidator.ColumnNames.Balance).SetAsNull = False Then
      Properties.GetByName(bankValidator.ColumnNames.Balance).Value = Entity.Balance
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

    If Properties.GetByName(bankValidator.ColumnNames.bankid).IsNull = False Then
      Entity.bankid = Properties.GetByName(bankValidator.ColumnNames.bankid).GetAsInteger()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.bank).IsNull = False Then
      Entity.bank = Properties.GetByName(bankValidator.ColumnNames.bank).GetAsString()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.accountno).IsNull = False Then
      Entity.accountno = Properties.GetByName(bankValidator.ColumnNames.accountno).GetAsString()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(bankValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(bankValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(bankValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(bankValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(bankValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.accountname).IsNull = False Then
      Entity.accountname = Properties.GetByName(bankValidator.ColumnNames.accountname).GetAsString()
    End If
    If Properties.GetByName(bankValidator.ColumnNames.Balance).IsNull = False Then
      Entity.Balance = Properties.GetByName(bankValidator.ColumnNames.Balance).GetAsDecimal()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the bank class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'bankid'
    ''' </summary>
    Public Shared ReadOnly Property bankid() As String
      Get
        Return "bankid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bank'
    ''' </summary>
    Public Shared ReadOnly Property bank() As String
      Get
        Return "bank"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'accountno'
    ''' </summary>
    Public Shared ReadOnly Property accountno() As String
      Get
        Return "accountno"
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
    ''' <summary>
    ''' Returns 'dtInsert_dt'
    ''' </summary>
    Public Shared ReadOnly Property dtInsertdt() As String
      Get
        Return "dtInsert_dt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sLastUpdate_id'
    ''' </summary>
    Public Shared ReadOnly Property sLastUpdateid() As String
      Get
        Return "sLastUpdate_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dtLastUpdate_dt'
    ''' </summary>
    Public Shared ReadOnly Property dtLastUpdatedt() As String
      Get
        Return "dtLastUpdate_dt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'iConcurrency_id'
    ''' </summary>
    Public Shared ReadOnly Property iConcurrencyid() As String
      Get
        Return "iConcurrency_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'accountname'
    ''' </summary>
    Public Shared ReadOnly Property accountname() As String
      Get
        Return "accountname"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Balance'
    ''' </summary>
    Public Shared ReadOnly Property Balance() As String
      Get
        Return "Balance"
      End Get
    End Property
  End Class
#End Region
End Class
