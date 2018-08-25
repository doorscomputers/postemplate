Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the Invntory class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class InvntoryValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the InvntoryValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a Invntory</param>
  Public Sub New(ByVal entity As Invntory)
    MyBase.New()

    _Entity = entity
    ClassName = "InvntoryValidator"

    ' Create Properties for each field in the Invntory entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As Invntory
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As Invntory
    Get
      Return _Entity
    End Get
    Set(ByVal value As Invntory)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current Invntory
  ''' </summary>
  ''' <returns>A cloned Invntory object</returns>
  Public Function CloneEntity() As Invntory
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in Invntory
  ''' </summary>
  ''' <returns>A cloned Invntory object</returns>
  Public Function CloneEntity(ByVal entityToClone As Invntory) As Invntory
    Dim newEntity As New Invntory()

    newEntity.miid = entityToClone.miid
    newEntity.midate = entityToClone.midate
    newEntity.stckid = entityToClone.stckid
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

    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.miid, "miid", False, GetType(Integer), 10, "miid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.midate, "midate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.qty, "qty", True, GetType(Integer), 10, "qty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.amnt, "amnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.prevavlbl, "prevavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(InvntoryValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.miid = 0
    Entity.midate = DateTime.Now
    Entity.stckid = 0
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

    If Properties.GetByName(InvntoryValidator.ColumnNames.miid).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.miid).Value = Entity.miid
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.midate).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.midate).Value = Entity.midate
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.amnt).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.amnt).Value = Entity.amnt
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.prevavlbl).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.prevavlbl).Value = Entity.prevavlbl
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(InvntoryValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(InvntoryValidator.ColumnNames.miid).IsNull = False Then
      Entity.miid = Properties.GetByName(InvntoryValidator.ColumnNames.miid).GetAsInteger()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.midate).IsNull = False Then
      Entity.midate = Properties.GetByName(InvntoryValidator.ColumnNames.midate).GetAsDate()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(InvntoryValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(InvntoryValidator.ColumnNames.qty).GetAsInteger()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.amnt).IsNull = False Then
      Entity.amnt = Properties.GetByName(InvntoryValidator.ColumnNames.amnt).GetAsDecimal()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.prevavlbl).IsNull = False Then
      Entity.prevavlbl = Properties.GetByName(InvntoryValidator.ColumnNames.prevavlbl).GetAsInteger()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(InvntoryValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(InvntoryValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(InvntoryValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(InvntoryValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(InvntoryValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(InvntoryValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the Invntory class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'miid'
    ''' </summary>
    Public Shared ReadOnly Property miid() As String
      Get
        Return "miid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'midate'
    ''' </summary>
    Public Shared ReadOnly Property midate() As String
      Get
        Return "midate"
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
