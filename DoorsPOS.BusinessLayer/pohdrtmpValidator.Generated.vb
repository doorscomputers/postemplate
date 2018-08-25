Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the pohdrtmp class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class pohdrtmpValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the pohdrtmpValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a pohdrtmp</param>
  Public Sub New(ByVal entity As pohdrtmp)
    MyBase.New()

    _Entity = entity
    ClassName = "pohdrtmpValidator"

    ' Create Properties for each field in the pohdrtmp entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As pohdrtmp
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As pohdrtmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As pohdrtmp)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current pohdrtmp
  ''' </summary>
  ''' <returns>A cloned pohdrtmp object</returns>
  Public Function CloneEntity() As pohdrtmp
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in pohdrtmp
  ''' </summary>
  ''' <returns>A cloned pohdrtmp object</returns>
  Public Function CloneEntity(ByVal entityToClone As pohdrtmp) As pohdrtmp
    Dim newEntity As New pohdrtmp()

    newEntity.poidtmp = entityToClone.poidtmp
    newEntity.podate = entityToClone.podate
    newEntity.poinv = entityToClone.poinv
    newEntity.supcode = entityToClone.supcode
    newEntity.poamnt = entityToClone.poamnt
    newEntity.dlivered = entityToClone.dlivered
    newEntity.drpsted = entityToClone.drpsted
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

    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.poidtmp, "poidtmp", False, GetType(Integer), 10, "poidtmp must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.podate, "podate", True, GetType(Date), -1, "podate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.poinv, "poinv", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.supcode, "supcode", True, GetType(Integer), 10, "supcode must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.poamnt, "poamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.dlivered, "dlivered", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.drpsted, "drpsted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pohdrtmpValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.poidtmp = 0
    Entity.podate = DateTime.Now
    Entity.poinv = String.Empty
    Entity.supcode = 0
    Entity.poamnt = 0
    Entity.dlivered = False
    Entity.drpsted = False
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

    If Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).Value = Entity.poidtmp
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).Value = Entity.podate
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).Value = Entity.poinv
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).Value = Entity.poamnt
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).Value = Entity.dlivered
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).Value = Entity.drpsted
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).IsNull = False Then
      Entity.poidtmp = Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).GetAsInteger()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).IsNull = False Then
      Entity.podate = Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).GetAsDate()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).IsNull = False Then
      Entity.poinv = Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).GetAsString()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).GetAsInteger()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).IsNull = False Then
      Entity.poamnt = Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).IsNull = False Then
      Entity.dlivered = Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).GetValueAsBoolean()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).IsNull = False Then
      Entity.drpsted = Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).GetValueAsBoolean()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the pohdrtmp class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'poidtmp'
    ''' </summary>
    Public Shared ReadOnly Property poidtmp() As String
      Get
        Return "poidtmp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'podate'
    ''' </summary>
    Public Shared ReadOnly Property podate() As String
      Get
        Return "podate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'poinv'
    ''' </summary>
    Public Shared ReadOnly Property poinv() As String
      Get
        Return "poinv"
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
    ''' Returns 'poamnt'
    ''' </summary>
    Public Shared ReadOnly Property poamnt() As String
      Get
        Return "poamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dlivered'
    ''' </summary>
    Public Shared ReadOnly Property dlivered() As String
      Get
        Return "dlivered"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drpsted'
    ''' </summary>
    Public Shared ReadOnly Property drpsted() As String
      Get
        Return "drpsted"
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
