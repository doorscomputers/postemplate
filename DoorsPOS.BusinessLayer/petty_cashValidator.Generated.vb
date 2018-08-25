Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the petty_cash class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class petty_cashValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the petty_cashValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a petty_cash</param>
  Public Sub New(ByVal entity As petty_cash)
    MyBase.New()

    _Entity = entity
    ClassName = "petty_cashValidator"

    ' Create Properties for each field in the petty_cash entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As petty_cash
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As petty_cash
    Get
      Return _Entity
    End Get
    Set(ByVal value As petty_cash)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current petty_cash
  ''' </summary>
  ''' <returns>A cloned petty_cash object</returns>
  Public Function CloneEntity() As petty_cash
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in petty_cash
  ''' </summary>
  ''' <returns>A cloned petty_cash object</returns>
  Public Function CloneEntity(ByVal entityToClone As petty_cash) As petty_cash
    Dim newEntity As New petty_cash()

    newEntity.pcid = entityToClone.pcid
    newEntity.posdate = entityToClone.posdate
    newEntity.pcamnt = entityToClone.pcamnt
    newEntity.pcrem = entityToClone.pcrem
    newEntity.cashier = entityToClone.cashier
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.pcid, "pcid", False, GetType(Integer), 10, "pcid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.posdate, "posdate", True, GetType(Date), -1, "posdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.pcamnt, "pcamnt", True, GetType(Decimal), 19, "pcamnt must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.pcrem, "pcrem", False, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.cashier, "cashier", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(petty_cashValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.pcid = 0
    Entity.posdate = DateTime.Now
    Entity.pcamnt = 0
    Entity.pcrem = String.Empty
    Entity.cashier = String.Empty
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0

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

    If Properties.GetByName(petty_cashValidator.ColumnNames.pcid).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.pcid).Value = Entity.pcid
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.posdate).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.posdate).Value = Entity.posdate
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.pcamnt).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.pcamnt).Value = Entity.pcamnt
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.pcrem).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.pcrem).Value = Entity.pcrem
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.cashier).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.cashier).Value = Entity.cashier
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(petty_cashValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(petty_cashValidator.ColumnNames.pcid).IsNull = False Then
      Entity.pcid = Properties.GetByName(petty_cashValidator.ColumnNames.pcid).GetAsInteger()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.posdate).IsNull = False Then
      Entity.posdate = Properties.GetByName(petty_cashValidator.ColumnNames.posdate).GetAsDate()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.pcamnt).IsNull = False Then
      Entity.pcamnt = Properties.GetByName(petty_cashValidator.ColumnNames.pcamnt).GetAsDecimal()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.pcrem).IsNull = False Then
      Entity.pcrem = Properties.GetByName(petty_cashValidator.ColumnNames.pcrem).GetAsString()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.cashier).IsNull = False Then
      Entity.cashier = Properties.GetByName(petty_cashValidator.ColumnNames.cashier).GetAsString()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(petty_cashValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(petty_cashValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(petty_cashValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(petty_cashValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(petty_cashValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(petty_cashValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the petty_cash class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'pcid'
    ''' </summary>
    Public Shared ReadOnly Property pcid() As String
      Get
        Return "pcid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'posdate'
    ''' </summary>
    Public Shared ReadOnly Property posdate() As String
      Get
        Return "posdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pcamnt'
    ''' </summary>
    Public Shared ReadOnly Property pcamnt() As String
      Get
        Return "pcamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pcrem'
    ''' </summary>
    Public Shared ReadOnly Property pcrem() As String
      Get
        Return "pcrem"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cashier'
    ''' </summary>
    Public Shared ReadOnly Property cashier() As String
      Get
        Return "cashier"
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
  End Class
#End Region
End Class
