Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the additnlcash class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class additnlcashValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the additnlcashValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a additnlcash</param>
  Public Sub New(ByVal entity As additnlcash)
    MyBase.New()

    _Entity = entity
    ClassName = "additnlcashValidator"

    ' Create Properties for each field in the additnlcash entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As additnlcash
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As additnlcash
    Get
      Return _Entity
    End Get
    Set(ByVal value As additnlcash)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current additnlcash
  ''' </summary>
  ''' <returns>A cloned additnlcash object</returns>
  Public Function CloneEntity() As additnlcash
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in additnlcash
  ''' </summary>
  ''' <returns>A cloned additnlcash object</returns>
  Public Function CloneEntity(ByVal entityToClone As additnlcash) As additnlcash
    Dim newEntity As New additnlcash()

    newEntity.acid = entityToClone.acid
    newEntity.posdate = entityToClone.posdate
    newEntity.acamnt = entityToClone.acamnt
    newEntity.acremarks = entityToClone.acremarks
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

    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.acid, "acid", False, GetType(Integer), 10, "acid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.posdate, "posdate", True, GetType(Date), -1, "posdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.acamnt, "acamnt", True, GetType(Decimal), 19, "acamnt must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.acremarks, "acremarks", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.cashier, "cashier", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(additnlcashValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.acid = 0
    Entity.posdate = DateTime.Now
    Entity.acamnt = 0
    Entity.acremarks = String.Empty
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

    If Properties.GetByName(additnlcashValidator.ColumnNames.acid).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.acid).Value = Entity.acid
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.posdate).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.posdate).Value = Entity.posdate
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.acamnt).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.acamnt).Value = Entity.acamnt
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.acremarks).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.acremarks).Value = Entity.acremarks
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.cashier).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.cashier).Value = Entity.cashier
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(additnlcashValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(additnlcashValidator.ColumnNames.acid).IsNull = False Then
      Entity.acid = Properties.GetByName(additnlcashValidator.ColumnNames.acid).GetAsInteger()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.posdate).IsNull = False Then
      Entity.posdate = Properties.GetByName(additnlcashValidator.ColumnNames.posdate).GetAsDate()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.acamnt).IsNull = False Then
      Entity.acamnt = Properties.GetByName(additnlcashValidator.ColumnNames.acamnt).GetAsDecimal()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.acremarks).IsNull = False Then
      Entity.acremarks = Properties.GetByName(additnlcashValidator.ColumnNames.acremarks).GetAsString()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.cashier).IsNull = False Then
      Entity.cashier = Properties.GetByName(additnlcashValidator.ColumnNames.cashier).GetAsString()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(additnlcashValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(additnlcashValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(additnlcashValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(additnlcashValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(additnlcashValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(additnlcashValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the additnlcash class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'acid'
    ''' </summary>
    Public Shared ReadOnly Property acid() As String
      Get
        Return "acid"
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
    ''' Returns 'acamnt'
    ''' </summary>
    Public Shared ReadOnly Property acamnt() As String
      Get
        Return "acamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'acremarks'
    ''' </summary>
    Public Shared ReadOnly Property acremarks() As String
      Get
        Return "acremarks"
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
