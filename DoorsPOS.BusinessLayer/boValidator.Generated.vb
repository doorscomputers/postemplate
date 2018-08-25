Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the bo class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class boValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the boValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a bo</param>
  Public Sub New(ByVal entity As bo)
    MyBase.New()

    _Entity = entity
    ClassName = "boValidator"

    ' Create Properties for each field in the bo entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As bo
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As bo
    Get
      Return _Entity
    End Get
    Set(ByVal value As bo)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current bo
  ''' </summary>
  ''' <returns>A cloned bo object</returns>
  Public Function CloneEntity() As bo
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in bo
  ''' </summary>
  ''' <returns>A cloned bo object</returns>
  Public Function CloneEntity(ByVal entityToClone As bo) As bo
    Dim newEntity As New bo()

    newEntity.boid = entityToClone.boid
    newEntity.supcode = entityToClone.supcode
    newEntity.bodate = entityToClone.bodate
    newEntity.stckid = entityToClone.stckid
    newEntity.price = entityToClone.price
    newEntity.qty = entityToClone.qty
    newEntity.amnt = entityToClone.amnt
    newEntity.prevavlbl = entityToClone.prevavlbl
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

    props.Add(PDSAProperty.Create(boValidator.ColumnNames.boid, "boid", False, GetType(Integer), 10, "boid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.supcode, "supcode", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.bodate, "bodate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.price, "price", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.qty, "qty", True, GetType(Integer), 10, "qty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.amnt, "amnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.prevavlbl, "prevavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(boValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.boid = 0
    Entity.supcode = 0
    Entity.bodate = DateTime.Now
    Entity.stckid = 0
    Entity.price = 0
    Entity.qty = 0
    Entity.amnt = 0
    Entity.prevavlbl = 0
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

    If Properties.GetByName(boValidator.ColumnNames.boid).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.boid).Value = Entity.boid
    End If
    If Properties.GetByName(boValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(boValidator.ColumnNames.bodate).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.bodate).Value = Entity.bodate
    End If
    If Properties.GetByName(boValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(boValidator.ColumnNames.price).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.price).Value = Entity.price
    End If
    If Properties.GetByName(boValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(boValidator.ColumnNames.amnt).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.amnt).Value = Entity.amnt
    End If
    If Properties.GetByName(boValidator.ColumnNames.prevavlbl).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.prevavlbl).Value = Entity.prevavlbl
    End If
    If Properties.GetByName(boValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(boValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(boValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(boValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(boValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(boValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(boValidator.ColumnNames.boid).IsNull = False Then
      Entity.boid = Properties.GetByName(boValidator.ColumnNames.boid).GetAsInteger()
    End If
    If Properties.GetByName(boValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(boValidator.ColumnNames.supcode).GetAsInteger()
    End If
    If Properties.GetByName(boValidator.ColumnNames.bodate).IsNull = False Then
      Entity.bodate = Properties.GetByName(boValidator.ColumnNames.bodate).GetAsDate()
    End If
    If Properties.GetByName(boValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(boValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(boValidator.ColumnNames.price).IsNull = False Then
      Entity.price = Properties.GetByName(boValidator.ColumnNames.price).GetAsDecimal()
    End If
    If Properties.GetByName(boValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(boValidator.ColumnNames.qty).GetAsInteger()
    End If
    If Properties.GetByName(boValidator.ColumnNames.amnt).IsNull = False Then
      Entity.amnt = Properties.GetByName(boValidator.ColumnNames.amnt).GetAsDecimal()
    End If
    If Properties.GetByName(boValidator.ColumnNames.prevavlbl).IsNull = False Then
      Entity.prevavlbl = Properties.GetByName(boValidator.ColumnNames.prevavlbl).GetAsInteger()
    End If
    If Properties.GetByName(boValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(boValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(boValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(boValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(boValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(boValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(boValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(boValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(boValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(boValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the bo class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'boid'
    ''' </summary>
    Public Shared ReadOnly Property boid() As String
      Get
        Return "boid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bodate'
    ''' </summary>
    Public Shared ReadOnly Property bodate() As String
      Get
        Return "bodate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'stckid'
    ''' </summary>
    Public Shared ReadOnly Property stckid() As String
      Get
        Return "stckid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'price'
    ''' </summary>
    Public Shared ReadOnly Property price() As String
      Get
        Return "price"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'qty'
    ''' </summary>
    Public Shared ReadOnly Property qty() As String
      Get
        Return "qty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'amnt'
    ''' </summary>
    Public Shared ReadOnly Property amnt() As String
      Get
        Return "amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'prevavlbl'
    ''' </summary>
    Public Shared ReadOnly Property prevavlbl() As String
      Get
        Return "prevavlbl"
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
